using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ResManagerAdmin.BusDatService
{
    public class Shpenzime
    {
        #region Constructor
        #endregion

        #region Public methods
        #region Per konfigurimin e kategorive
        /// <summary>
        /// Kthen nje dataset me te gjitha kategorite e shpenzimeve
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqKategoriteShpenzime()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteEShpenzimeve");
            if (!Convert.IsDBNull(ds))
            {
                ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
                ds.AcceptChanges();
                ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
                ds.AcceptChanges();
            }
            return ds;
        }

        public DataSet ShfaqKategoriShpenzimeshMujore()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriShpenzimeshMujore");
           
            return ds;
        }


        /// <summary>
        /// Shton nje kategori shpenzimi me emrin qe merr si parameter
        /// </summary>
        /// <param name="emri"></param>
        /// <returns></returns>
        public int ShtoKategoriShpenzimi(string emri)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteEShpenzimevePerEmer", emri);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nqs ka nje kategori shpenzimi me kete emer nuk lejohet shtimi
                return 2;
            }
            else
            {
                int b = db.Create("ShtoKategoriShpenzimi", emri);
                return b;
            }
        }

        public int KrijoKategoriShpenzimMujor(string emri, string pershkrimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("KontrolloKategoriShpenzimMujor", emri);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nqs ka nje kategori shpenzimi me kete emer nuk lejohet shtimi
                return 2;
            }
            else
            {
                int b = db.Create("KrijoKategoriShpenzimMujor", emri, pershkrimi);
                return b;
            }
        }

        /// <summary>
        /// Modifikon emrin e nje kategorie shpenzimi
        /// </summary>
        /// <param name="idKategoria"></param>
        /// <param name="emri"></param>
        /// <returns></returns>
        public int ModifikoKategoriShpenzimi(int idKategoria, string emri)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteEShpenzimevePerEmerPerjashtoId", idKategoria, emri);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nqs ka nje kategori shpenzimi me kete emer nuk lejohet modifikimi
                return 2;
            }
            else
            {
                int b = db.Update("ModifikoKategoriShpenzimi", idKategoria, emri);
                return b;
            }
        }

        public int ModifikoKategoriShpenzimiMujor(int idKategoria, string emri, string pershkrimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteEShpenzimeveMujorePerEmerPerjashtoId", idKategoria, emri);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nqs ka nje kategori shpenzimi me kete emer nuk lejohet modifikimi
                return 2;
            }
            else
            {
                int b = db.Update("ModifikoKategoriShpenzimiMujor", idKategoria, emri, pershkrimi);
                return b;
            }
        }

        /// <summary>
        /// Fshin te gjitha kategorite e shpenzimeve id e te cilave
        /// permbahen ne dataset
        /// </summary>
        /// <param name="dsId"></param>
        /// <returns></returns>
        public DataSet FshiKategoriShpenzimi(DataSet dsId)
        {
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("PERSHKRIMI", typeof(String));
            dsError.AcceptChanges();
            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_KATEGORIASHPENZIMI", typeof(Int32));
            dsToErase.AcceptChanges();
            DbController db = new DbController();
            DataSet dsKategoriteShpenzimet = db.Read("ShfaqNumrinEShpenzimevePerSecilenKategori");
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsKategoriteShpenzimet.Tables[0].Columns["ID_KATEGORIASHPENZIMI"];
            dsKategoriteShpenzimet.Tables[0].PrimaryKey = vektorPrimary;
            foreach (DataRow dr in dsId.Tables[0].Rows)
            {
                int idKategoria = Convert.ToInt32(dr["ID_KATEGORIASHPENZIMI"]);
                DataRow drSearch = dsKategoriteShpenzimet.Tables[0].Rows.Find(idKategoria);
                //nqs nuk ka asnje shpenzim te lidhur me kategorine
                //kategoria mund te fshihet
                if (drSearch == null)
                {
                    DataRow r = dsToErase.Tables[0].NewRow();
                    r["ID_KATEGORIASHPENZIMI"] = dr["ID_KATEGORIASHPENZIMI"];
                    dsToErase.Tables[0].Rows.Add(r);
                }
                //pnd raportohet se kategoria nuk mund te fshihet
                else
                {
                    DataRow r = dsError.Tables[0].NewRow();
                    r["PERSHKRIMI"] = dr["PERSHKRIMI"];
                    dsError.Tables[0].Rows.Add(r);
                }
            }
            dsToErase.AcceptChanges();
            dsError.AcceptChanges();
            if (dsToErase.Tables[0].Rows.Count == 0)
            {
                return dsError;
            }
            int b = db.Delete("FshiKategoriteEShpenzimeve", dsToErase);
            //nqs veprimi ne database kryhet ne rregull
            if (b == 0)
                return dsError;
            //pnd kthejme null
            else
                return null;
        }
        #endregion

        #region Per konfigurimin e shpenzimeve
        /// <summary>
        /// Gjen shumen e shpenzimeve te kryer per daten e dhene
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public DataSet ShpenzimetPerDaten(DateTime dt)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShpenzimetPerDaten", dt);
            return ds;
        }
        /// <summary>
        /// krijon nje shpenzim te ri
        /// </summary>
        /// <param name="idKategoria"></param>
        /// <param name="idPerdoruesi"></param>
        /// <param name="pershkrimi"></param>
        /// <param name="data"></param>
        /// <param name="sasia"></param>
        /// <returns></returns>
        public int KryejShpenzim(int idKategoria, int idPerdoruesi, string pershkrimi,
            DateTime data, decimal sasia)
        {
            DbController db = new DbController();
            int b = db.Create("KryejShpenzim", idKategoria, idPerdoruesi, pershkrimi, data, sasia);
            return b;
        }

        public DataSet ShfaqShpenzime(string kushti)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqShpenzimet", kushti);
            if (!Convert.IsDBNull(ds))
            {
                ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
                ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
                ds.AcceptChanges();
            }
            return ds;
        }
        
        /// <summary>
        /// Modifikon shpenzimin me id e dhene
        /// </summary>
        /// <param name="idShpenzimi"></param>
        /// <param name="idKategoria"></param>
        /// <param name="idPerdoruesi"></param>
        /// <param name="pershkrimi"></param>
        /// <param name="data"></param>
        /// <param name="sasia"></param>
        /// <returns></returns>
        public int ModifikoShpenzim(int idShpenzimi, int idKategoria, int idPerdoruesi, string pershkrimi,
            DateTime data, decimal sasia)
        {
            DbController db = new DbController();
            int b = db.Update("ModifikoShpenzim", idShpenzimi, idKategoria, idPerdoruesi,
                pershkrimi, data, sasia);
            return b;

        }

        public int FshiShpenzime(DataSet dsId)
        {
            DbController db = new DbController();
            int b = db.Delete("FshiShpenzimet", dsId);
            return b;
        }

        #region Shpenzimet mujore

        public int KrijoShpenzimMujor(int katShpenzimi, int muaji, int viti, double vlera, string komenti)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("KontrolloShpenzimMujor", katShpenzimi, muaji, viti);

            if (ds == null)
            {
                return 1;
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                return 2;
            }

            int b = db.Create("KrijoShpenzimMujor", katShpenzimi, muaji, viti, vlera, komenti);

            return b;
        }

        public int ModifikoShpenzimMujor(int shpenzimiMujor, double vlera, string komenti)
        {
            DbController db = new DbController();
            int b = db.Update("ModifikoShpenzimMujor", shpenzimiMujor, vlera, komenti);

            return b;
        }

        public DataSet ShfaqShpenzimetMujore()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqShpenzimetMujore");

            int muajInt = 0;
            string muajiStr = "";

            if (ds != null)
            {
                ds.Tables[0].Columns.Add("MUAJISTR", typeof(string));

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    muajInt = Convert.ToInt32(dr["MUAJI"]);

                    muajiStr = this.KtheMuajStr(muajInt);

                    dr["MUAJISTR"] = muajiStr;
                }

                ds.Tables[0].AcceptChanges();
            }

            

            

            return ds;
        }

        public DataSet ShfaqShpenzimetMujoreSipasKerkimit(string strQuery)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqShpenzimetMujoreSipasKerkimit", strQuery);

            int muajInt = 0;
            string muajiStr = "";

            if (ds != null)
            {
                ds.Tables[0].Columns.Add("MUAJISTR", typeof(string));

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    muajInt = Convert.ToInt32(dr["MUAJI"]);

                    muajiStr = this.KtheMuajStr(muajInt);

                    dr["MUAJISTR"] = muajiStr;
                }

                ds.Tables[0].AcceptChanges();
            }





            return ds;
        }

        #endregion
        #endregion

        #endregion

        #region Private methods

        private string KtheMuajStr(int indeksi)
        {
            string muaji = "";

            switch (indeksi)
            {
                case 1 :
                    muaji = "Janar";
                    break;

                case 2 :
                    muaji = "Shkurt";
                    break;

                case 3 :
                    muaji = "Mars";
                    break;

                case 4 :
                    muaji = "Prill";
                    break;

                case 5 :
                    muaji = "Maj";
                    break;

                case 6 :
                    muaji = "Qershor";
                    break;

                case 7 :
                    muaji = "Korrik";
                    break;

                case 8:
                    muaji = "Gusht";
                    break;

                case 9 :
                    muaji = "Shtator";
                    break;

                case 10 :
                    muaji = "Tetor";
                    break;

                case 11 :
                    muaji = "Nentor";
                    break;

                case 12 :
                    muaji = "Dhjetor";
                    break;

               
                default :
                    break;
            }

            return muaji;
        }

        #endregion
    }
}
