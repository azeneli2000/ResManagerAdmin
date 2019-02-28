using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Nmo;
using Microsoft.SqlServer.Server;
//using SQLDMO;

namespace ResManagerAdmin.BusDatService
{
    public class Global
    {
        public static string stringXml;
        /// <summary>
        /// Vendos pathin e raporteve
        /// </summary>
        public Global()
        {
            stringXml = "C:\\Program Files\\Vision Info Solution\\Bar Restorant Manager\\Raportet";
        }

        #region Public Methods

        #region Per konfigurimin e informacioneve rreth restorantit
        public DataSet LexoInformacioneRestoranti(string fileName)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();
            ds.Tables[0].Columns.Add("EMRI", typeof(String));
            ds.Tables[0].Columns.Add("KODI", typeof(String));
            ds.Tables[0].Columns.Add("EMAIL", typeof(String));
            ds.Tables[0].Columns.Add("TELEFON", typeof(String));
            ds.Tables[0].Columns.Add("ADRESA", typeof(String));
            ds.Tables[0].Columns.Add("WEBSITE", typeof(String));
            ds.Tables[0].Columns.Add("MESAZH", typeof(String));
            ds.Tables[0].Columns.Add("LOGOPATH", typeof(String));
            ds.AcceptChanges();
            DataRow r = ds.Tables[0].NewRow();
            string str = "";
            try
            {
                XmlTextReader tr = new XmlTextReader(fileName);
                while (tr.Read())
                {
                    if (tr.NodeType == XmlNodeType.Element)
                    {
                        str = tr.LocalName.ToString();
                        switch (str)
                        {
                            case "Emri":
                                r["EMRI"] = tr.ReadElementString(str).ToString();
                                break;
                            case "Adresa":
                                r["ADRESA"] = tr.ReadElementString(str).ToString();
                                break;
                            case "Telefoni":
                                r["TELEFON"] = tr.ReadElementString(str).ToString();
                                break;
                            case "E-maili":
                                r["EMAIL"] = tr.ReadElementString(str).ToString();
                                break;
                            case "Website-i":
                                r["WEBSITE"] = tr.ReadElementString(str).ToString();
                                break;
                            case "KodiFiskal":
                                r["KODI"] = tr.ReadElementString(str).ToString();
                                break;
                            case "LogoPath":
                                r["LOGOPATH"] = tr.ReadElementString(str).ToString();
                                break;
                            case "Mesazh":
                                r["MESAZH"] = tr.ReadElementString(str).ToString();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ds;
            }
            ds.Tables[0].Rows.Add(r);
            ds.AcceptChanges();
            return ds;
        }

        public DataSet LexoInformacioneRestorantiShkurt()
        {
            string fileName = Global.stringXml + "\\Informacione.Xml";
            DataSet dsInf = this.LexoInformacioneRestoranti(fileName);
            string s = ""; 
            if (dsInf.Tables[0].Rows.Count == 0)
            {
                ////s = "DATA: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm");
            }
            else
            {
                DataRow r = dsInf.Tables[0].Rows[0];
                s = "        BAR-RESTORANT: " + r["EMRI"].ToString() + "     /  ADRESA: " + r["ADRESA"].ToString(); ///// +" / DATA: " + DateTime.Now.ToString("dd-MM-yyyy hh:mm");
            }
            DataSet ds = new DataSet();
            ds.Tables.Add();
            ds.Tables[0].Columns.Add("TEXT", typeof(String));
            DataRow rNew = ds.Tables[0].NewRow();
            rNew["TEXT"] = s;
            ds.Tables[0].Rows.Add(rNew);
            ds.AcceptChanges();
            return ds;
        }
        #endregion

        #region Per intervalet e cmimeve

        public DataSet LexoIntervaletECmimeve()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("LexoIntervaletCmime");
            return ds;
        }

        public DataSet RuajIntervalet(DataSet dsModifikuar, DataSet dsEkzistues)
        {
            DataSet dsResult = new DataSet();
            bool TeNjejte = true;
            if (dsModifikuar.Tables[0].Rows.Count != dsEkzistues.Tables[0].Rows.Count)
            {
                TeNjejte = false;
            }
            if (TeNjejte)
            {
                int i = 0;
                foreach (DataRow dr in dsModifikuar.Tables[0].Rows)
                {
                    if (dr["ORE_FILLIMI"].ToString() != dsEkzistues.Tables[0].Rows[0]["ORE_FILLIMI"].ToString())
                    {
                        TeNjejte = false;
                        break;
                    }
                    i++;
                }
            }
            //nqs intervalet jane te njejte atehere nuk ka nevoje per ndonje modifikimi te mundshem
            if (TeNjejte)
            {
                dsResult.Tables.Add();
                dsResult.Tables.Add();
                dsResult.Tables[0].Columns.Add("EMRI", typeof(String));
                dsResult.Tables[1].Columns.Add("EMRI", typeof(String));
                dsResult.AcceptChanges();
                return dsResult;
            }
            else
            {
                dsResult.Tables.Add();
                dsResult.Tables.Add();
                dsResult.Tables[0].Columns.Add("EMRI", typeof(String));
                dsResult.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
                dsResult.Tables[0].Columns.Add("ID_CMIMIPERIUDHA", typeof(Int32));

                dsResult.Tables[1].Columns.Add("EMRI", typeof(String));
                dsResult.Tables[1].Columns.Add("ID_RECETA", typeof(Int32));
                dsResult.Tables[1].Columns.Add("ID_CMIMIPERIUDHA", typeof(Int32));
                dsResult.AcceptChanges();
                DbController db = new DbController();
                //DataSeti ka 4 DataTable
                //1 --> Numri i cmimeve korente per cdo artikull
                //2 --> Numri i cmimeve korente per cdo recete
                DataSet dsARIntervale = db.Read("ArtikujtDheRecetatCmimeIntervale");
                foreach (DataRow dr in dsARIntervale.Tables[0].Rows)
                {
                    //Nqs artikulli ka vetem nje cmim per periudhen me te fundit atehere
                    //ai nuk eshte i konfiguruar me intervale
                    if (Convert.ToInt32(dr["NR"]) > 1)
                    {
                        DataRow newR = dsResult.Tables[0].NewRow();
                        newR["EMRI"] = dr["EMRI"];
                        newR["ID_ARTIKULLI"] = dr["ID_ARTIKULLI"];
                        newR["ID_CMIMIPERIUDHA"] = dr["ID_CMIMIPERIUDHA"];
                        dsResult.Tables[0].Rows.Add(newR);
                    }
                }
                foreach (DataRow dr in dsARIntervale.Tables[1].Rows)
                {
                    //Nqs receta ka vetem nje cmim per periudhen me te fundit atehere ajo
                    //nuk eshte konfiguruar me intervale
                    if (Convert.ToInt32(dr["NR"]) > 1)
                    {
                        DataRow newR = dsResult.Tables[1].NewRow();
                        newR["EMRI"] = dr["EMRI"];
                        newR["ID_RECETA"] = dr["ID_RECETA"];
                        newR["ID_CMIMIPERIUDHA"] = dr["ID_CMIMIPERIUDHA"];
                        dsResult.Tables[1].Rows.Add(newR);
                    }
                }
                int b = 0;
                if (dsResult.Tables[0].Rows.Count != 0 || dsResult.Tables[1].Rows.Count != 0)
                {
                    //b = db.Update("KrijoPeriudhaTeRejaPerArtikujtDheRecetatMeIntervale", dsResult);
                }
                if (b == 0)
                {
                    b = db.Update("RuajIntervalet", dsModifikuar);
                }
                else
                    return null;
                if (b != 0)
                    return null;
                else
                    return dsResult;
            }
        }

        /// <summary>
        /// Kthen id e intervalit korrent
        /// </summary>
        /// <returns></returns>
        public int LexoIntervalinKorrent()
        {
            DataSet dsIntervale = LexoIntervaletECmimeve();
            if (dsIntervale.Tables[0].Rows.Count <= 1)
            {
                return -1;
            }
            for (int i = 1; i < dsIntervale.Tables[0].Rows.Count; i++)
            {

            }
            return 0;
        }

        #endregion

        #region Per back up database
        public int KrijoBackUp()
        {
            if (!Directory.Exists(@"C:\ResManager Back up"))
                Directory.CreateDirectory(@"C:\ResManager Back up");
            string emriBackUp = "ResManager" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm");
            DbController db = new DbController();
            int r = db.Create("KrijoBackUp", emriBackUp);
            return r;
        }

        public DataSet LexoBackUp()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("BackUp");
            ds.Tables[0].Columns.Add("EMRI", typeof(String));
            ds.Tables[0].Columns.Add("DATA", typeof(DateTime));
            ds.Tables[0].Columns.Add("MUAJI", typeof(String));
            ds.AcceptChanges();
            if (!Directory.Exists(@"C:\ResManager Back up"))
            {
                Directory.CreateDirectory(@"C:\ResManager Back up");
                return ds;
            }
            //Lexohen te gjithe back -up 
            string[] str = Directory.GetFiles(@"C:\ResManager Back up");
            string data = "";
            for (int i = 0; i < str.Length; i++)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr["EMRI"] = str.GetValue(i).ToString().Substring(22);
                DateTime dateKrijimi = File.GetCreationTime(str.GetValue(i).ToString());
                dr["DATA"] = dateKrijimi;
                dr["MUAJI"] = dateKrijimi.ToString("MMMM") + " " + dateKrijimi.Year.ToString();
                ds.Tables[0].Rows.Add(dr);
            }
            DataRow[] renditTab = ds.Tables[0].Select("", " DATA ASC");
            ds.AcceptChanges();
            DataSet dsRendit = ds.Clone();
            foreach (DataRow dr in renditTab)
            {
                DataRow newR = dsRendit.Tables[0].NewRow();
                newR[0] = dr[0];
                newR[1] = dr[1];
                newR[2] = dr[2];
                dsRendit.Tables[0].Rows.Add(newR);
            }
            dsRendit.AcceptChanges();
            return dsRendit;
        }

        //public int KarikoBackUp(string emri)
        //{
        //    System.Data.SqlClient.SqlConnection conn = new SqlConnection();
        //    //stop Sql Server
        //    SQLServer server = new SQLServer();
        //    try
        //    {

        //        server.Name = "(LOCAL)";
        //        server.Login = "sa";
        //        server.Password = "vision";
        //        //server.Pause();
        //        server.Stop();
        //        System.Threading.Thread.Sleep(9000);
        //        server.Start(true, (object)"(LOCAL)", (object)"sa", (object)"vision");
        //    }
        //    catch (Exception ex1)
        //    {
        //        MessageBox.Show(ex1.Message, "Gabim gjatë karikimit te back up-it", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return 1;
        //    }
        //    System.Threading.Thread.Sleep(1000);
        //    conn.ConnectionString = "Server=\"VALENTIN\";UId=sa;PWD=vision;Connect Timeout=100;Max Pool Size=1;Connection Lifetime=1000;";
        //    System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
        //    try
        //    {

        //        conn.Open();
        //        cmd.CommandText = @"RESTORE DATABASE ResManager FROM DISK = 'C:\ResManager Back up\" + emri + "' WITH RECOVERY";
        //        cmd.Connection = conn;
        //        cmd.ExecuteNonQuery();
        //        conn.Close();
        //        return 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        if (conn.State == ConnectionState.Open)
        //        {
        //            conn.Close();
        //            conn.Dispose();
        //        }
        //        System.Threading.Thread.Sleep(1000);
        //        try
        //        {
        //            conn.Open();
        //            cmd.CommandText = @"RESTORE DATABASE ResManager FROM DISK = 'C:\ResManager Back up\" + emri + "' WITH RECOVERY";
        //            cmd.Connection = conn;
        //            cmd.ExecuteNonQuery();
        //            conn.Close();
        //            return 0;
        //        }
        //        catch (Exception ex2)
        //        {
        //            MessageBox.Show(ex.Message, "Gabim gjatë karikimit te back up-it", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return 1;
        //        }

        //    }
        //}
        public int KarikoBackUp(string emri)
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LOCAL)\\REM;Initial Catalog=ResManager;User ID=sa;Password=vision";
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            try
            {

                conn.Open();
                cmd.Connection = conn;
                //shkeput bazen e te dhenave
                cmd.CommandText = "alter database ResManager SET OFFLINE";
                cmd.ExecuteNonQuery();

                //kariko back up
                cmd.CommandText = @"RESTORE DATABASE  ResManager FROM DISK = 'C:\ResManager Back up\" + emri + "' WITH REPLACE";
                cmd.ExecuteNonQuery();

                //lidh perseri bazen e te dhenave
                cmd.CommandText = "alter database ResManager SET ONLINE";
                cmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, "Gabim gjatë karikimit te back up-it", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gabim gjatë karikimit te back up-it", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
        }
        #endregion
        #endregion
    }
}
