using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmRecetatPrintimi : Form
    {
        private DataSet dsPrinterRecete = null;
        private DataSet dsPrinters = null;
        private DataSet dsRecetat = null;
        private DataSet dsPrinterReceteLexo = null;
        

        public frmRecetatPrintimi()
        {
            InitializeComponent();
        }


        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.paneli.TitleText = s;
        }

        private void frmRecetatPrintimi_Load(object sender, EventArgs e)
        {
            ///this.LexoInformacione();

            this.dsPrinters = this.KrijoDataSetPrinter();

            this.cboPrinteri.DataSource = this.dsPrinters.Tables[0];

            this.dsRecetat = this.KrijoDataSetRecetat();
            this.grida.DataSource = this.dsRecetat.Tables[0];

            this.KtheRecetat();

            string pathi = Global.stringXml + "\\RecetatPrinterat.xml";

            if (System.IO.File.Exists(pathi) == false)
            {
                this.HidhXmlFirst();
            }


            this.dsPrinterReceteLexo = this.KrijoDataSetPrinterLexo();
            this.LexoXml();

            this.KrijoDataSetPrinterRecete();
            this.ModifikoFirst();



        }

        private void ModifikoFirst()
        {
            int idReceta = 0;
            string strPrinteri = "";
            bool zgjedhur = false;

            foreach(DataRow dr in this.dsPrinterReceteLexo.Tables[0].Rows)
            {
                idReceta = Convert.ToInt32(dr["ID_RECETA"]);
                strPrinteri = Convert.ToString(dr["PRINTERI"]);
                zgjedhur = Convert.ToBoolean(dr["ZGJEDHUR"]);

                this.ModifikoDsPrinterRecete(idReceta, strPrinteri, zgjedhur);
                
            }
        }

        private DataSet KrijoDataSetPrinterLexo()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("PRINTERI", typeof(string));
            ds.Tables[0].Columns.Add("ZGJEDHUR", typeof(bool));

            ds.AcceptChanges();

            return ds;
        }


        private void KtheRecetat()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqRecetatSipasKategorive");


            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = this.dsRecetat.Tables[0].NewRow();

                drNew["ID_RECETA"] = dr["ID_RECETA"];
                drNew["EMRI"] = dr["EMRI"];
                drNew["ID_KATEGORIARECETA"] = dr["ID_KATEGORIARECETA"];
                drNew["PERSHKRIMI"] = dr["PERSHKRIMI"];
                drNew["ZGJEDHUR"] = false;

                this.dsRecetat.Tables[0].Rows.Add(drNew);
            }

            this.dsRecetat.Tables[0].AcceptChanges();


        }

        private DataSet KrijoDataSetRecetat()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("EMRI", typeof(string));
            ds.Tables[0].Columns.Add("ID_KATEGORIARECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("PERSHKRIMI", typeof(string));
            ds.Tables[0].Columns.Add("ZGJEDHUR", typeof(bool));

            ds.AcceptChanges();

            return ds;
        }

        private void KrijoDataSetPrinterRecete()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("PRINTERI", typeof(string));
            ds.Tables[0].Columns.Add("ZGJEDHUR", typeof(bool));

            ds.AcceptChanges();

            this.dsPrinterRecete = ds;

            string strPrinteri = "";
            bool zgjedhur = false;
            

            int idReceta = 0;
            



            foreach (DataRow dr in this.dsRecetat.Tables[0].Rows)
            {
                idReceta = Convert.ToInt32(dr[0]);
                




                foreach (DataRow drOther in this.dsPrinters.Tables[0].Rows)
                {
                    strPrinteri = Convert.ToString(drOther[0]);

                    DataRow drNew = this.dsPrinterRecete.Tables[0].NewRow();

                    drNew["ID_RECETA"] = idReceta;
                    drNew["PRINTERI"] = strPrinteri;
                    drNew["ZGJEDHUR"] = false;

                    this.dsPrinterRecete.Tables[0].Rows.Add(drNew);
                }


            }


            this.dsPrinterRecete.Tables[0].AcceptChanges();
        }

        private DataSet KrijoDataSetPrinter()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("PRINTERI", typeof(string));
           

            ds.Tables[0].AcceptChanges();



            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                DataRow dr = ds.Tables[0].NewRow();

                dr["PRINTERI"] = strPrinter;
               

                ds.Tables[0].Rows.Add(dr);

            }

            ds.Tables[0].AcceptChanges();

            return ds;
        }

        private void HidhXml()
        {
            string fileName = Global.stringXml + "\\RecetatPrinterat.xml";
            XmlTextWriter tw = new XmlTextWriter(fileName, null);
            tw.Formatting = Formatting.Indented;
            tw.WriteStartDocument();

            tw.WriteStartElement("Recetat");

            string strPrinteri = "";
            bool zgjedhur = false;
            string strZgjedhur = "0";

            int idReceta = 0;
            string strReceta = "";






            foreach (DataRow dr in this.dsPrinterRecete.Tables[0].Rows)
            {
                idReceta = Convert.ToInt32(dr[0]);
                strReceta = idReceta.ToString();

                strPrinteri = Convert.ToString(dr[1]);

                zgjedhur = Convert.ToBoolean(dr[2]);
                if (zgjedhur == false)
                {
                    strZgjedhur = "0";
                }
                else
                {
                    strZgjedhur = "1";
                }


                tw.WriteStartElement("RecetaPrinter");
                tw.WriteElementString("ID_RECETA", strReceta);
                tw.WriteElementString("PRINTERI", strPrinteri);
                tw.WriteElementString("ZGJEDHUR", strZgjedhur);
                tw.WriteEndElement();
            }







            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Flush();
            tw.Close();
        }

        private void HidhXmlFirst()
        {
            string fileName = Global.stringXml + "\\RecetatPrinterat.xml";
            XmlTextWriter tw = new XmlTextWriter(fileName, null);
            tw.Formatting = Formatting.Indented;
            tw.WriteStartDocument();

            tw.WriteStartElement("Recetat");

            string strPrinteri = "";
            bool zgjedhur = false;
            string strZgjedhur = "0";

            int idReceta = 0;
            string strReceta = "";



            foreach (DataRow dr in this.dsRecetat.Tables[0].Rows)
            {
                idReceta = Convert.ToInt32(dr[0]);
                strReceta = idReceta.ToString();




                foreach (DataRow drOther in this.dsPrinters.Tables[0].Rows)
                {
                    strPrinteri = Convert.ToString(drOther[0]);

                    tw.WriteStartElement("RecetaPrinter");
                    tw.WriteElementString("ID_RECETA", strReceta);
                    tw.WriteElementString("PRINTERI", strPrinteri);
                    tw.WriteElementString("ZGJEDHUR", strZgjedhur);
                    tw.WriteEndElement();
                }


            }




            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Flush();
            tw.Close();
        }

        private void LexoXml()
        {
            string str = "";

            int idReceta = 0;
            string strPrinteri = "";
            bool zgjedhur = false;
            string strZgjedhur = "";
            string fileName = Global.stringXml + "\\RecetatPrinterat.xml";

            DataRow dr = null;
            int numri = 0;
            dr = this.dsPrinterReceteLexo.Tables[0].NewRow();

            XmlTextReader tr = new XmlTextReader(fileName);
            try
            {
                while (tr.Read())
                {

                    switch (tr.NodeType)
                    {

                        case XmlNodeType.Element:


                            str = tr.Name;

                            if (str == "ID_RECETA")
                            {
                                if (numri == 0)
                                {


                                    numri = numri + 1;

                                }
                                else
                                {
                                    dr = this.dsPrinterReceteLexo.Tables[0].NewRow();
                                }

                                idReceta = Convert.ToInt32(tr.ReadElementString().ToString());
                                dr["ID_RECETA"] = idReceta;


                            }
                            else if (str == "PRINTERI")
                            {
                                strPrinteri = tr.ReadElementString().ToString();
                                dr["PRINTERI"] = strPrinteri;
                            }
                            else if (str == "ZGJEDHUR")
                            {
                                strZgjedhur = tr.ReadElementString().ToString();
                                if (strZgjedhur == "0")
                                {
                                    dr["ZGJEDHUR"] = false;
                                }
                                else
                                {
                                    dr["ZGJEDHUR"] = true;
                                }

                                this.dsPrinterReceteLexo.Tables[0].Rows.Add(dr);
                            }
                            else
                            {
                            }

                            break;



                        default:
                            break;


                    }

                }



                this.dsPrinterReceteLexo.Tables[0].AcceptChanges();

            }


            catch
            {

            }
            finally
            {
                tr.Close();
            }


        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (this.cboPrinteri.Text.Trim() == "")
            {
                return;
            }

            try
            {
                string pr = this.cboPrinteri.Text.Trim();

                

                string strPrinteri = "";
                bool zgjedhur = false;
                int celesi = 0;

                foreach (DataRow dr in this.dsPrinterRecete.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_RECETA"]);
                    strPrinteri = Convert.ToString(dr["PRINTERI"]);


                    if (pr == strPrinteri)
                    {
                        strPrinteri = Convert.ToString(dr["PRINTERI"]);
                        zgjedhur = this.KtheZgjedhurRecete(celesi);

                        dr["ZGJEDHUR"] = zgjedhur;
                    }

                }

                this.dsPrinterRecete.Tables[0].AcceptChanges();

                this.HidhXml();

                MessageBox.Show(this, "Recetat per printerin e zgjedhur u konfiguruan !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

            }
        }

        private bool KtheZgjedhurRecete(int idReceta)
        {
            int celesi = 0;
            bool zgjedhur = false;

            foreach (DataRow dr in this.dsRecetat.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["ID_RECETA"]);

                if (celesi == idReceta)
                {
                    zgjedhur = Convert.ToBoolean(dr["ZGJEDHUR"]);
                    return zgjedhur;
                }
            }

            return zgjedhur;
        }

        private void cboPrinteri_ValueChanged(object sender, EventArgs e)
        {
            this.chkSelectAll.Checked = false;

            try
            {
                string pr = this.cboPrinteri.Text.Trim();
                if (pr == "")
                {
                    return;
                }

                this.PastroDsRecetat();

                string strPrinteri = "";
                bool zgjedhur = false;
                int celesi = 0;

                foreach (DataRow dr in this.dsPrinterRecete.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_RECETA"]);
                    strPrinteri = Convert.ToString(dr["PRINTERI"]);

                    if (pr == strPrinteri)
                    {
                        
                        zgjedhur = Convert.ToBoolean(dr["ZGJEDHUR"]);

                        this.ModifikoDsRecete(celesi, zgjedhur);
                    }

                }

                

            }
            catch (Exception ex)
            {
               
                
            }
        }

        private void ModifikoDsRecete(int idReceta, bool zgjedhur)
        {
            int celesi = 0;
           

            foreach (DataRow dr in this.dsRecetat.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["ID_RECETA"]);

                if (celesi == idReceta)
                {

                    dr["ZGJEDHUR"] = zgjedhur;
                    this.dsRecetat.Tables[0].AcceptChanges();
                    return;
                }
            }

            this.dsRecetat.Tables[0].AcceptChanges();
        }

        private void PastroDsRecetat()
        {
            foreach (DataRow dr in this.dsRecetat.Tables[0].Rows)
            {
                
                 dr["ZGJEDHUR"] = false;
                   
            }            

            this.dsRecetat.Tables[0].AcceptChanges();
        }

        private void ModifikoDsPrinterRecete(int idReceta, string strPrinteri, bool zgjedhur)
        {
            int celesi = 0;
            string pr = "";

            foreach (DataRow dr in this.dsPrinterRecete.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["ID_RECETA"]);
                pr = Convert.ToString(dr["PRINTERI"]);

                if (celesi == idReceta && pr == strPrinteri)
                {
                    dr["ZGJEDHUR"] = zgjedhur;
                    this.dsPrinterRecete.Tables[0].AcceptChanges();
                    return;
                }
            }
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            try
            {
                string pr = this.cboPrinteri.Text.Trim();
                if (pr == "")
                {
                    return;
                }

                this.PastroDsRecetat();

                string strPrinteri = "";
                bool zgjedhur = false;
                int celesi = 0;

                foreach (DataRow dr in this.dsPrinterRecete.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_RECETA"]);
                    strPrinteri = Convert.ToString(dr["PRINTERI"]);

                    if (pr == strPrinteri)
                    {

                        zgjedhur = Convert.ToBoolean(dr["ZGJEDHUR"]);

                        this.ModifikoDsRecete(celesi, zgjedhur);
                    }

                }



            }
            catch (Exception ex)
            {


            }
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkSelectAll.Checked == true)
            {
               
                    foreach (DataRow dr in this.dsRecetat.Tables[0].Rows)
                    {
                        dr["ZGJEDHUR"] = true;
                    }

                    this.dsRecetat.Tables[0].AcceptChanges();
              
            }
            else
            {
               
                    foreach (DataRow dr in this.dsRecetat.Tables[0].Rows)
                    {
                        dr["ZGJEDHUR"] = false;
                    }

                    this.dsRecetat.Tables[0].AcceptChanges();
                
            }
        }

    }
}