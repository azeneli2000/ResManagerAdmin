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
    public partial class frmKonfigurimPrinteri : Form
    {
        private DataSet dsPrinterat1 = null;
        private DataSet dsPrinterat2 = null;
        private DataSet dsPrinterat3 = null;
        private DataSet dsPrinterat4 = null;

        public frmKonfigurimPrinteri()
        {
            InitializeComponent();
        }

        private void frmKonfigurimPrinteri_Load(object sender, EventArgs e)
        {
            ///this.LexoInformacione();

            dsPrinterat1 = this.KrijoDataSet();
            dsPrinterat2 = this.KrijoDataSetZgjidh();
            dsPrinterat3 = this.KrijoDataSet();
            dsPrinterat4 = this.KrijoDataSetZgjidh();

            this.MbushGridaPrinterat();
            this.LexoXml();

            this.grida1.DataSource = this.dsPrinterat1.Tables[0];
            this.grida2.DataSource = this.dsPrinterat2.Tables[0];
            this.grida3.DataSource = this.dsPrinterat3.Tables[0];
            this.grida4.DataSource = this.dsPrinterat4.Tables[0];

            

        }

        private void MbushGridaPrinterat()
        {
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                DataRow drNew1 = this.dsPrinterat1.Tables[0].NewRow();
                drNew1["PRINTERI"] = strPrinter;

                this.dsPrinterat1.Tables[0].Rows.Add(drNew1);

                DataRow drNew3 = this.dsPrinterat3.Tables[0].NewRow();
                drNew3["PRINTERI"] = strPrinter;

                this.dsPrinterat3.Tables[0].Rows.Add(drNew3);
            }

            this.dsPrinterat1.Tables[0].AcceptChanges();
            this.dsPrinterat3.Tables[0].AcceptChanges();

        }

        private DataSet KrijoDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("PRINTERI", typeof(string));

            ds.AcceptChanges();

            return ds;
        }

        private DataSet KrijoDataSetZgjidh()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("PRINTERI", typeof(string));
            ds.Tables[0].Columns.Add("NUMRI", typeof(Int32));

            ds.AcceptChanges();

            return ds;
        }

        private bool GjendetPrinter(DataSet ds, string pr)
        {
            string printeri = "";
            
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                printeri = Convert.ToString(dr[0]);

                if (printeri == pr)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnKalo1_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida1.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida1.GetRow(indeksi).Cells[0].Text);

            if (this.GjendetPrinter(this.dsPrinterat2, pr) == false)
            {
                DataRow dr = this.dsPrinterat2.Tables[0].NewRow();
                dr["PRINTERI"] = pr;
                dr["NUMRI"] = 1;

                this.dsPrinterat2.Tables[0].Rows.Add(dr);

                this.dsPrinterat2.Tables[0].AcceptChanges();
            }
        }

        private void btnKalo2_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida3.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida3.GetRow(indeksi).Cells[0].Text);

            if (this.GjendetPrinter(this.dsPrinterat4, pr) == false)
            {
                DataRow dr = this.dsPrinterat4.Tables[0].NewRow();
                dr["PRINTERI"] = pr;
                dr["NUMRI"] = 1;

                this.dsPrinterat4.Tables[0].Rows.Add(dr);

                this.dsPrinterat4.Tables[0].AcceptChanges();
            }
        }

        private void grida2_DoubleClick(object sender, EventArgs e)
        {
            int indeksi = this.grida2.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida2.GetRow(indeksi).Cells[0].Text);

            string printeri = "";

            foreach (DataRow dr in this.dsPrinterat2.Tables[0].Rows)
            {
                printeri = Convert.ToString(dr[0]);

                if (printeri == pr)
                {
                    this.dsPrinterat2.Tables[0].Rows.Remove(dr);
                    this.dsPrinterat2.Tables[0].AcceptChanges();

                    return;
                }
            }

        }

        private void grida4_DoubleClick(object sender, EventArgs e)
        {
            int indeksi = this.grida4.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida4.GetRow(indeksi).Cells[0].Text);

            string printeri = "";

            foreach (DataRow dr in this.dsPrinterat4.Tables[0].Rows)
            {
                printeri = Convert.ToString(dr[0]);

                if (printeri == pr)
                {
                    this.dsPrinterat4.Tables[0].Rows.Remove(dr);
                    this.dsPrinterat4.Tables[0].AcceptChanges();

                    return;
                }
            }
        }

        private void grida1_DoubleClick(object sender, EventArgs e)
        {
            int indeksi = this.grida1.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida1.GetRow(indeksi).Cells[0].Text);

            if (this.GjendetPrinter(this.dsPrinterat2, pr) == false)
            {
                DataRow dr = this.dsPrinterat2.Tables[0].NewRow();
                dr["PRINTERI"] = pr;
                dr["NUMRI"] = 1;

                this.dsPrinterat2.Tables[0].Rows.Add(dr);

                this.dsPrinterat2.Tables[0].AcceptChanges();
            }
        }

        private void grida3_DoubleClick(object sender, EventArgs e)
        {
            int indeksi = this.grida3.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida3.GetRow(indeksi).Cells[0].Text);

            if (this.GjendetPrinter(this.dsPrinterat4, pr) == false)
            {
                DataRow dr = this.dsPrinterat4.Tables[0].NewRow();
                dr["PRINTERI"] = pr;
                dr["NUMRI"] = 1;

                this.dsPrinterat4.Tables[0].Rows.Add(dr);

                this.dsPrinterat4.Tables[0].AcceptChanges();
            }
        }

        private void HidhXml(string[] prBanaku, string[] prTavolina, int[] nrBanaku, int[] nrTavolina)
        {
            string fileName = Global.stringXml + "\\Printerat.xml";
            XmlTextWriter tw = new XmlTextWriter(fileName, null);
            tw.Formatting = Formatting.Indented;
            tw.WriteStartDocument();

            tw.WriteStartElement("Printerat");

            for(int i = 0; i < prBanaku.Length; i++)
            {
                tw.WriteStartElement("Banaku");
                tw.WriteElementString("Emri", prBanaku[i]);
                tw.WriteElementString("Numri", nrBanaku[i].ToString());
                tw.WriteEndElement();

            }

            for (int i = 0; i < prTavolina.Length; i++)
            {
                tw.WriteStartElement("Tavolina");
                tw.WriteElementString("Emri", prTavolina[i]);
                tw.WriteElementString("Numri", nrTavolina[i].ToString());
                tw.WriteEndElement();
            }
           

           

            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Flush();
            tw.Close();


        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            int nrB = this.dsPrinterat2.Tables[0].Rows.Count;
            int nrT = this.dsPrinterat4.Tables[0].Rows.Count;

            string[] strBanaku = new string[nrB];
            string[] strTavolina = new string[nrT];

            int[] nrBanaku = new int[nrB];
            int[] nrTavolina = new int[nrT];

            int i = 0;

            foreach (DataRow dr in this.dsPrinterat2.Tables[0].Rows)
            {
                strBanaku[i] = Convert.ToString(dr[0]);
                nrBanaku[i] = Convert.ToInt32(dr[1]);

                i = i + 1;

            }

            i = 0;

            foreach (DataRow dr in this.dsPrinterat4.Tables[0].Rows)
            {
                strTavolina[i] = Convert.ToString(dr[0]);
                nrTavolina[i] = Convert.ToInt32(dr[1]);

                i = i + 1;

            }


            this.HidhXml(strBanaku, strTavolina, nrBanaku, nrTavolina);

            MessageBox.Show(this, "Konfigurimet e printerave u ruajten !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void expandablePanel1_Click(object sender, EventArgs e)
        {



        }

        private void LexoXml()
        {
            string str = "";
            string korenti = "";
            string fileName = Global.stringXml + "\\Printerat.xml";

            DataRow dr1 = null;
            DataRow dr2 = null;
            
            XmlTextReader tr = new XmlTextReader(fileName);
            try
            {
                while (tr.Read())
                {

                    switch (tr.NodeType)
                    {
                        case XmlNodeType.Element:


                            str = tr.Name;

                            if (str == "Banaku")
                            {
                                dr1 = this.dsPrinterat2.Tables[0].NewRow();
                                korenti = "Banaku";

                            }
                            else if (str == "Tavolina")
                            {
                                dr2 = this.dsPrinterat4.Tables[0].NewRow();
                                korenti = "Tavolina";
                            }
                            else if (str == "Emri")
                            {
                                if (korenti == "Banaku")
                                {
                                    dr1["PRINTERI"] = tr.ReadElementString().ToString();
                                }
                                else
                                {
                                    dr2["PRINTERI"] = tr.ReadElementString().ToString();
                                }

                            }
                            else if (str == "Numri")
                            {
                                if (korenti == "Banaku")
                                {
                                    dr1["NUMRI"] = Convert.ToInt32(tr.ReadElementString().ToString());
                                    this.dsPrinterat2.Tables[0].Rows.Add(dr1);
                                }
                                else
                                {
                                    dr2["NUMRI"] = Convert.ToInt32(tr.ReadElementString().ToString());
                                    this.dsPrinterat4.Tables[0].Rows.Add(dr2);
                                }
                            }
                            else
                            {
                            }

                            break;

                        //case XmlNodeType.Text:

                        //    str = tr.Value;
                        //    break;

                        default:
                            break;


                    }

                }

                this.dsPrinterat2.Tables[0].AcceptChanges();
                this.dsPrinterat4.Tables[0].AcceptChanges();

                int prova = this.dsPrinterat2.Tables[0].Rows.Count;

            }


            catch
            {

            }
            finally
            {
                tr.Close();
            }
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}