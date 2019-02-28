using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmLevizMallin : System.Windows.Forms.Form, IPrintable
    {
        public int veprimi = 0;
        private DataSet dsLevizja = null;
        private DataSet dsBanaku = new DataSet();
        private DataSet dsArtikujt = null;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        public frmLevizMallin()
        {
            InitializeComponent();
        }

        private void frmLevizMallin_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = grida;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Gjendja e mallit për banakun";

            this.dsLevizja = this.KrijoDataSet();
            this.gridaArtikujt.DataSource = this.dsLevizja.Tables[0];
            gridaArtikujt.BringToFront();
            tabControli.SendToBack();

            this.dsArtikujt = this.KrijoDsArtikujt();
            this.grida.DataSource = this.dsArtikujt.Tables[0];

            this.MbushGridenArtikujtFirst();

            if (File.Exists("C:\\Program Files\\VisionInfoSolution\\RestaurantManager\\Raportet\\Banaku.xml"))
            {
                this.dsBanaku.ReadXml("C:\\Program Files\\VisionInfoSolution\\RestaurantManager\\Raportet\\Banaku.xml");
                this.NgarkoTeDhenat();
            }

        }

        private void btnFut_Click(object sender, EventArgs e)
        {
            this.veprimi = 1;
            this.tabItemShto.Text = "   Shtim  :";
            this.Caktivizo();
        }

        private void btnNxirr_Click(object sender, EventArgs e)
        {
            this.veprimi = 2;
            this.tabItemShto.Text = "   Nxjerrje  :";
            this.Caktivizo();

        }

        private void btnAnulloLevizje_Click(object sender, EventArgs e)
        {
            this.Aktivizo();
            this.PastroLevizje();
        }

        private void PastroLevizje()
        {
            this.cmbKategoriaArtikulli.Value = null;
            this.cmbArtikulli.DataSource = null;
            this.cmbArtikulli.Value = null;
            this.txtNjesia.Text = "";
            this.numSasia.Value = 0;

            this.dsLevizja.Tables[0].Rows.Clear();
        }

        private DataSet KrijoDsArtikujt()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_KATEGORIAARTIKULLI", typeof(Int32));
            ds.Tables[0].Columns.Add("PERSHKRIMI", typeof(string));
            ds.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            ds.Tables[0].Columns.Add("EMRI", typeof(string));
            ds.Tables[0].Columns.Add("NJESIA", typeof(string));
            ds.Tables[0].Columns.Add("SASIA", typeof(float));

            ds.AcceptChanges();

            return ds;
        }

        private DataSet KrijoDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            ds.Tables[0].Columns.Add("EMRI", typeof(string));
            ds.Tables[0].Columns.Add("NJESIA", typeof(string));
            ds.Tables[0].Columns.Add("SASIA", typeof(float));

            ds.AcceptChanges();

            return ds;
        }
        
        private void MbushKomboKategorite()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEArtikujve");

            if (ds != null)
            {
                this.cmbKategoriaArtikulli.DataSource = ds.Tables[0];
            }


        }

        private void MbushGridenArtikujtFirst()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqArtikujt");

            //this.gridArtikujt.DataSource = ds.Tables[0];

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = this.dsArtikujt.Tables[0].NewRow();

                drNew["ID_KATEGORIAARTIKULLI"] = dr["ID_KATEGORIAARTIKULLI"];
                drNew["PERSHKRIMI"] = dr["PERSHKRIMI"];
                drNew["ID_ARTIKULLI"] = dr["ID_ARTIKULLI"];
                drNew["EMRI"] = dr["EMRI"];
                drNew["NJESIA"] = dr["NJESIA"];
                drNew["SASIA"] = 0;

                this.dsArtikujt.Tables[0].Rows.Add(drNew);
            }

            this.dsArtikujt.Tables[0].AcceptChanges();

          

        }

        private void NgarkoTeDhenat()
        {
            int idArtikulli = 0;
            double sasia = 0;
            string strSasia = "";

            foreach (DataRow drB in this.dsBanaku.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(drB["ID_ARTIKULLI"]);

                strSasia = Convert.ToDouble(drB["SASIA"]).ToString("0.00");
                sasia = Convert.ToDouble(strSasia);


                this.ModifikoSasiaArtikull(idArtikulli, sasia);
            }

            this.dsArtikujt.Tables[0].AcceptChanges();
        }

        private void Aktivizo()
        {
            this.grida.Visible = true;
            this.btnFut.Visible = true;
            this.btnNxirr.Visible = true;
            this.lblTitle.Visible = true;

        }

        private void Caktivizo()
        {
            this.grida.Visible = false;
            this.btnFut.Visible = false;
            this.btnNxirr.Visible = false;
            this.lblTitle.Visible = false;
        }

        private void ShfaqArtikujtPerKategori(int idKat)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqArtikujtPerKategori", idKat);

            if (ds != null)
            {
                this.cmbArtikulli.DataSource = ds.Tables[0];
                this.cmbArtikulli.Value = null;
            }
        }

        private void cmbKategoriaArtikulli_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idKat = Convert.ToInt32(this.cmbKategoriaArtikulli.Value);
                
                this.ShfaqArtikujtPerKategori(idKat);
            }
            catch (Exception ex)
            {
                this.cmbArtikulli.DataSource = null;
                this.txtNjesia.Text = "";
                this.numSasia.ResetText();
            }

            if (this.cmbKategoriaArtikulli.Text.Trim() == "")
            {
                this.cmbArtikulli.DataSource = null;
                this.txtNjesia.Text = "";
                this.numSasia.ResetText();
            }
        }

        private void cmbArtikulli_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idArtikulli = Convert.ToInt32(this.cmbArtikulli.Value);

                int indeksi = this.cmbArtikulli.DropDownList.Row;

                string njesia = Convert.ToString(this.cmbArtikulli.DropDownList.GetRow(indeksi).Cells["NJESIA"].Text);

                this.txtNjesia.Text = njesia;
                this.numSasia.Value = 1;

                this.numSasia.Focus();


            }
            catch (Exception ex)
            {
                this.txtNjesia.Text = "";
                this.numSasia.Value = 0;
            }

            if (this.cmbArtikulli.Text.Trim() == "")
            {
                this.txtNjesia.Text = "";
                this.numSasia.Value = 0;
            }
        }

        private void PastroArtikullin()
        {
            this.cmbKategoriaArtikulli.Value = null;
            this.txtNjesia.Text = "";
            this.numSasia.Value = 0;
            
             
        }

        private void btnAnulloArtikull_Click(object sender, EventArgs e)
        {
            this.PastroArtikullin();
        }

        private bool KaGabimShtimArtikulli()
        {
            if (this.cmbArtikulli.Text.Trim() == "")
            {
                MessageBox.Show(this, "Ju duhet te zgjidhni njerin prej artikujve !", "Kujdes !!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return true;

            }

            try
            {
                int idArtikulli = Convert.ToInt32(this.cmbArtikulli.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Artikulli i zgjedhur prej jush nuk rezulton te jete i regjistruar ne program !", "Kujdes !!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return true;
            }

            decimal sasia = Convert.ToDecimal(this.numSasia.Value);

            if (sasia == 0)
            {
                MessageBox.Show(this, "Sasia e artikullit duhet te jete me e mdhe se 0 !", "Kujdes !!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return true;
            }

            return false;
        }

        private bool GjendetArtikull(int idArtikulli)
        {
           

            foreach (DataRow dr in this.dsLevizja.Tables[0].Rows)
            {
                if (Convert.ToInt32(dr[0]) == idArtikulli)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnRuajArtikull_Click(object sender, EventArgs e)
        {
            if (this.KaGabimShtimArtikulli() == true)
            {
                return;
            }


            int idArtikulli = Convert.ToInt32(this.cmbArtikulli.Value);

            if (this.GjendetArtikull(idArtikulli))
            {
                MessageBox.Show("Ky artikull eshte gjendet ne tabele .", "Vemendje !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string artikulli = this.cmbArtikulli.Text.Trim();
            string njesia = this.txtNjesia.Text.Trim();

            double sasia = Convert.ToDouble(this.numSasia.Value);


            DataRow dr = this.dsLevizja.Tables[0].NewRow();

            dr["ID_ARTIKULLI"] = idArtikulli;
            dr["EMRI"] = artikulli;
            dr["NJESIA"] = njesia;
            dr["SASIA"] = sasia;

            this.dsLevizja.Tables[0].Rows.Add(dr);
            this.dsLevizja.Tables[0].AcceptChanges();


            this.cmbArtikulli.Value = null;
            this.txtNjesia.Text = "";
            this.numSasia.Value = 0;

            this.cmbArtikulli.Focus();

        }

        private void btnFshiArtikull_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaArtikujt.Row;

            if (indeksi < 0)
            {
                return;
            }

            int idArtikulli = Convert.ToInt32(this.gridaArtikujt.GetRow(indeksi).Cells[0].Text);

            foreach (DataRow dr in this.dsLevizja.Tables[0].Rows)
            {
                if (idArtikulli == Convert.ToInt32(dr[0]))
                {
                    this.dsLevizja.Tables[0].Rows.Remove(dr);
                    this.dsLevizja.Tables[0].AcceptChanges();
                    return;
                }
            }

        }

        private bool KontrolloSasiaZero()
        {
            int i = 0;

            foreach (DataRow dr in this.dsLevizja.Tables[0].Rows)
            {
                if (Convert.ToDouble(dr["SASIA"]) == 0)
                {
                    MessageBox.Show(this, "Sasia e artikullit nuk mund te jete 0", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.gridaArtikujt.Row = i;
                    return true;
                }

                i = i + 1;
            }

            return false;
        }

        private void btnRuajLevizje_Click(object sender, EventArgs e)
        {
            if (this.dsLevizja.Tables[0].Rows.Count == 0)
            {
                return;
            }

            if (this.KontrolloSasiaZero() == true)
            {
                return;
            }

            int idArtikulli = 0;
            double sasia = 0;

            foreach (DataRow dr in this.dsLevizja.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr["ID_ARTIKULLI"]);

                sasia = Convert.ToDouble(dr["SASIA"]);

                if (this.veprimi == 2)
                {
                    sasia = (-1) * sasia;
                }

                this.ModifikoSasiaArtikull(idArtikulli, sasia);
            }

            this.dsArtikujt.WriteXml("C:\\Program Files\\VisionInfoSolution\\RestaurantManager\\Raportet\\Banaku.xml");
            this.Aktivizo();
            this.PastroLevizje();

            
        }

        private void ModifikoSasiaArtikull(int idArtikulli, double sasia)
        {
            int celesi = 0;
            double gjendja = 0;
            string strGjendja = "";

            foreach (DataRow dr in this.dsArtikujt.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["ID_ARTIKULLI"]);

                if (celesi == idArtikulli)
                {
                    strGjendja = Convert.ToDouble(dr["SASIA"]).ToString("0.00");
                    dr["SASIA"] = Convert.ToDouble(strGjendja) + sasia;
                }
            }

            this.dsArtikujt.Tables[0].AcceptChanges();
        }

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.grida.RowCount != 0)
            {
                frmRaportJanus frmPrint = new frmRaportJanus();
                frmPrint.PrintPreviewControl1.Document = Doc;
                frmPrint.ShowDialog();
            }
        }

        public bool ReadyToPrint
        {
            get
            {
                return this.readyToPrint;
            }
            set
            {
                bool oldValue = readyToPrint;
                readyToPrint = value;
                if (ReadyToPrintChanged != null && value != oldValue)
                    ReadyToPrintChanged(this, new ReadyChangedEventArgs());
            }
        }

        public void ConvertToExcel()
        {
            grida.ExpandGroups();
            string[] fushat = new string[3];
            string[] llojet = new string[3];
            string[] key = new string[3];
            fushat[0] = "Artikulli";
            fushat[1] = "Njesia";
            fushat[2] = "Gjendja";

            key[0] = "EMRI";
            key[1] = "NJESIA";
            key[2] = "SASIA";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "float";

            KlaseExcel excel = new KlaseExcel("GjendjaBanaku.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("GjendjaBanaku.xls", grida, fushat, key, llojet,
                    "EMRI");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "GjendjaBanaku.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Janus.Windows.GridEX.GridEXPrintDocument Doc
        {
            get
            {
                return this.doc;
            }
            set
            {
                doc = value;
            }
        }

        public void Print()
        {
            if (grida.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion

        private void frmLevizMallin_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            this.MbushKomboKategorite();
        }
    }
}