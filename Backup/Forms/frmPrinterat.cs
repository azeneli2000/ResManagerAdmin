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
    public partial class frmPrinterat : Form
    {
        private DataSet dsPrinterRecete = null;
        private DataSet dsPrinters = null;
        private DataSet dsRecetat = null;
        private bool kaKonfigurim = false;

        private int zgjedhur = 0;

        public frmPrinterat()
        {
            InitializeComponent();
        }

        private void frmPrinterat_Load(object sender, EventArgs e)
        {
            this.KtheRecetat();
            this.dsPrinters = this.KrijoDataSetPrinter();

            string pathi = Global.stringXml + "\\RecetatPrinterat.xml";

            if (System.IO.File.Exists(pathi) == false)
            {
                this.HidhXmlFirst();
            }

           
            
            this.dsPrinterRecete = this.KrijoDataSetPrinterRecete();
            this.LexoXml();

            this.gridaPrinterat.DataSource = this.dsPrinters.Tables[0];

            


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

        private DataSet KrijoDataSetPrinterRecete()
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

            this.dsRecetat = ds;

            this.gridaRecetat.DataSource = this.dsRecetat.Tables[0];

          
        }

        private DataSet KrijoDataSetPrinter()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("PRINTERI", typeof(string));
            ds.Tables[0].Columns.Add("ZGJEDHUR", typeof(bool));

            ds.Tables[0].AcceptChanges();

           

            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                DataRow dr = ds.Tables[0].NewRow();

                dr["PRINTERI"] = strPrinter;
                dr["ZGJEDHUR"] = false;

                ds.Tables[0].Rows.Add(dr);

            }

            ds.Tables[0].AcceptChanges();

            return ds;
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
            dr = this.dsPrinterRecete.Tables[0].NewRow();

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
                                    dr = this.dsPrinterRecete.Tables[0].NewRow();
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

                                this.dsPrinterRecete.Tables[0].Rows.Add(dr);
                            }
                            else
                            {
                            }

                            break;

                     

                        default:
                            break;


                    }

                }

                
                
                this.dsPrinterRecete.Tables[0].AcceptChanges();

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
            try
            {
                int indeksi = this.gridaRecetat.Row;

                int idReceta = Convert.ToInt32(this.gridaRecetat.GetRow(indeksi).Cells[0].Text);

                string strPrinteri = "";
                bool zgjedhur = false;
                int celesi = 0;

                foreach (DataRow dr in this.dsPrinterRecete.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_RECETA"]);

                    if (celesi == idReceta)
                    {
                        strPrinteri = Convert.ToString(dr["PRINTERI"]);
                        zgjedhur = this.KtheVleraDsPrinters(strPrinteri);

                        dr["ZGJEDHUR"] = zgjedhur;
                    }

                }

                this.dsPrinterRecete.Tables[0].AcceptChanges();

                this.HidhXml();

            }
            catch (Exception ex)
            {
              
            }
        }

        private void ModifikoXML(int celesi)
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

                tw.WriteStartElement("Receta");
                tw.WriteElementString("ID_RECETA", strReceta);

                if (celesi == idReceta)
                {
                    foreach (DataRow drOther in this.dsPrinters.Tables[0].Rows)
                    {
                        strPrinteri = Convert.ToString(drOther[0]);
                        zgjedhur = Convert.ToBoolean(drOther[1]);
                        if (zgjedhur == true)
                        {
                            strZgjedhur = "1";
                        }
                        else
                        {
                            strZgjedhur = "0";
                        }

                        tw.WriteStartElement("PRINTERI");
                        tw.WriteElementString("Emri", strPrinteri);
                        tw.WriteElementString("Zgjedhur", strZgjedhur);
                        tw.WriteEndElement();
                    }
                }
                else
                {

                    foreach (DataRow drOther in this.dsPrinters.Tables[0].Rows)
                    {
                        strPrinteri = Convert.ToString(drOther[0]);
                       
                        tw.WriteStartElement("PRINTERI");
                        tw.WriteElementString("Emri", strPrinteri);
                        tw.WriteElementString("Zgjedhur", strZgjedhur);
                        tw.WriteEndElement();
                    }
                }

                tw.WriteEndElement();
            }




            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Flush();
            tw.Close();
               
       }

        private void gridaRecetat_CurrentCellChanged(object sender, EventArgs e)
        {
            this.zgjedhur = this.zgjedhur + 1;
            if (this.zgjedhur == 1)
            {
                return;
            }


            try
            {
                int indeksi = this.gridaRecetat.Row;

                int idReceta = Convert.ToInt32(this.gridaRecetat.GetRow(indeksi).Cells[0].Text);
                string receta = Convert.ToString(this.gridaRecetat.GetRow(indeksi).Cells[1].Text);

                string strPrinteri = "";
                bool zgjedhur = false;
                int celesi = 0;

                foreach (DataRow dr in this.dsPrinterRecete.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_RECETA"]);

                    if (celesi == idReceta)
                    {
                        strPrinteri = Convert.ToString(dr["PRINTERI"]);
                        zgjedhur = Convert.ToBoolean(dr["ZGJEDHUR"]);

                        this.ModifikoDsPrinters(strPrinteri, zgjedhur);
                    }

                }

                this.lblReceta.Text = "Konfigurimi per :  " + receta + "  .";

            }
            catch (Exception ex)
            {
                this.PastroDsPrinters();
                this.lblReceta.Text = "Konfigurimi per receten e zgjedhur.";
            }
        }

        private void ModifikoDsPrinters(string prEmri, bool zgjedhur)
        {
            string strPrinter = "";

            foreach (DataRow dr in this.dsPrinters.Tables[0].Rows)
            {
                strPrinter = Convert.ToString(dr[0]).Trim();

                if (strPrinter == prEmri)
                {
                    dr["ZGJEDHUR"] = zgjedhur;
                    this.dsPrinters.Tables[0].AcceptChanges();
                    return;
                }
            }
        }

        private bool KtheVleraDsPrinters(string prEmri)
        {
            string strPrinter = "";
            bool zgjedhur = false;

            foreach (DataRow dr in this.dsPrinters.Tables[0].Rows)
            {
                strPrinter = Convert.ToString(dr[0]).Trim();
              
                if (strPrinter == prEmri)
                {
                    zgjedhur = Convert.ToBoolean(dr["ZGJEDHUR"]);
                    
                    return zgjedhur;
                }
            }

            return zgjedhur;
        }

        private void PastroDsPrinters()
        {
            try
            {
                foreach (DataRow dr in this.dsPrinters.Tables[0].Rows)
                {

                    dr["ZGJEDHUR"] = false;

                }

                this.dsPrinters.Tables[0].AcceptChanges();
            }
            catch (Exception ex)
            {
            }

        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            try
            {
                int indeksi = this.gridaRecetat.Row;

                int idReceta = Convert.ToInt32(this.gridaRecetat.GetRow(indeksi).Cells[0].Text);

                string strPrinteri = "";
                bool zgjedhur = false;
                int celesi = 0;

                foreach (DataRow dr in this.dsPrinterRecete.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_RECETA"]);

                    if (celesi == idReceta)
                    {
                        strPrinteri = Convert.ToString(dr["PRINTERI"]);
                        zgjedhur = Convert.ToBoolean(dr["ZGJEDHUR"]);

                        this.ModifikoDsPrinters(strPrinteri, zgjedhur);
                    }

                }

            }
            catch (Exception ex)
            {
                //this.PastroDsPrinters();
            }
        }

        
    }
}