using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmFatura : System.Windows.Forms.Form, IPrintable
    {
        private int zgjidhFatura = 0;

        private DataSet dsBanaku = new DataSet();
        private DataSet dsArtikujtBanaku = null;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        #region FormLoad
        public frmFatura()
        {
            InitializeComponent();
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
            DateTime dt1 = dtFillimi.Value.AddHours(-dtFillimi.Value.Hour);
            dt1 = dt1.AddMinutes(-dt1.Minute);
            dt1 = dt1.AddSeconds(-dt1.Second);
            dtFillimi.Value = dt1;

            DateTime dt2 = dtMbarimi.Value.AddHours(-dtMbarimi.Value.Hour);
            dt2 = dt2.AddMinutes(-dt2.Minute);
            dt2 = dt2.AddSeconds(-dt2.Second);
            dtMbarimi.Value = dt2;
        }


        private void frmDergesa_Load(object sender, EventArgs e)
        {
            //gridaFaturat.Size = new Size(869, 388);

            this.LexoInformacione();
            gridaFaturat.BringToFront();
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.MbushGridenPerSot();
            this.BllokoKerkimin();

            this.dsArtikujtBanaku = this.KrijoDsArtikujtBanaku();
            this.MbushGridenArtikujtFirst();
            if (File.Exists("C:\\Program Files\\VisionInfoSolution\\RestaurantManager\\Raportet\\Banaku.xml"))
            {
                this.dsBanaku.ReadXml("C:\\Program Files\\VisionInfoSolution\\RestaurantManager\\Raportet\\Banaku.xml");
                this.NgarkoTeDhenat();
            }


        }
        #endregion

        #region Private Methods

        private void MbushGridenArtikujtFirst()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqArtikujt");

            //this.gridArtikujt.DataSource = ds.Tables[0];

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = this.dsArtikujtBanaku.Tables[0].NewRow();

                drNew["ID_KATEGORIAARTIKULLI"] = dr["ID_KATEGORIAARTIKULLI"];
                drNew["PERSHKRIMI"] = dr["PERSHKRIMI"];
                drNew["ID_ARTIKULLI"] = dr["ID_ARTIKULLI"];
                drNew["EMRI"] = dr["EMRI"];
                drNew["NJESIA"] = dr["NJESIA"];
                drNew["SASIA"] = 0;

                this.dsArtikujtBanaku.Tables[0].Rows.Add(drNew);
            }

            this.dsArtikujtBanaku.Tables[0].AcceptChanges();
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

            this.dsArtikujtBanaku.Tables[0].AcceptChanges();
        }

        private void ModifikoSasiaArtikull(int idArtikulli, double sasia)
        {
            int celesi = 0;
            
            string strGjendja = "";
            double gjendja = 0;

            foreach (DataRow dr in this.dsArtikujtBanaku.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["ID_ARTIKULLI"]);

                if (celesi == idArtikulli)
                {
                    strGjendja = Convert.ToDouble(dr["SASIA"]).ToString("0.00");
                    dr["SASIA"] = Convert.ToDouble(strGjendja) + sasia;
                }
            }

            this.dsArtikujtBanaku.Tables[0].AcceptChanges();
        }

        private void KonsumoArtikujtBanaku(int idFatura)
        {
            

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("KtheArtikujtPerFature", idFatura);

            int nr = ds.Tables[0].Rows.Count;

            int idArtikulli = 0;
            double sasia = 0;
            string strSasia = "";

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr["CELESI"]);

                strSasia = Convert.ToDouble(dr["SASIA"]).ToString("0.00");
                sasia = Convert.ToDouble(strSasia);
                this.ModifikoSasiaArtikull(idArtikulli, sasia);
            }

            this.dsArtikujtBanaku.Tables[0].AcceptChanges();
            this.dsArtikujtBanaku.WriteXml("C:\\Program Files\\VisionInfoSolution\\RestaurantManager\\Raportet\\Banaku.xml");
        }

        private DataSet KrijoDsArtikujtBanaku()
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

        private void CaktivizoPanel(System.Windows.Forms.Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Button)
                    c.Enabled = false;
            }
        }

        private void AktivizoPanel(System.Windows.Forms.Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Button)
                    c.Enabled = true;
            }
        }

        private void Kerko()
        {
            if (this.KaGabim())
            {
                return;
            }

            this.zgjidhFatura = 0;

            int zgjedhja = 0;

            string nrFatura = "";
            int idTavolina = 0;
            int idKamarieri = 0;

            DateTime dateFillimi = this.dtFillimi.Value;
            DateTime dateMbarimi = this.dtMbarimi.Value;

            string strSql = "SELECT ID_FATURA, DATA_ORA, NR_FATURE, F.ID_TAVOLINA, T.EMRI AS TAVOLINA, P.ID_PERSONELI , P.PERDORUESI AS KAMARIERI, SKONTO, TOTALI, F.ID_FORMAPAGESA, FORMA_PAGESA, ANULLUAR " +
                             "FROM FATURAT AS F left JOIN TAVOLINAT AS T ON F.ID_TAVOLINA = T.ID_TAVOLINA " +
                             "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                             "INNER JOIN FORMA_PAGESA AS FP ON F.ID_FORMAPAGESA = FP.ID_FORMAPAGESA ";

            string kushti = "WHERE (ANULLUAR = 0 OR ANULLUAR = 1) ";
            zgjedhja = 1;
            string s = "Faturat ";
            if (this.chkNrFature.Checked == true)
            {
                nrFatura = this.txtNrFatura.Text;

                if (zgjedhja == 0)
                {
                    kushti = kushti + "NR_FATURE = '" + nrFatura + "' ";
                }
                else
                {
                    kushti = kushti + "AND NR_FATURE = '" + nrFatura + "' ";
                }

                zgjedhja = zgjedhja + 1;
                s += "me nr fature " + nrFatura;
            }

            if (this.chkTavolina.Checked == true)
            {
                int idTav = Convert.ToInt32(this.cboTavolinat.Value);

                if (zgjedhja == 0)
                    kushti = kushti + "F.ID_TAVOLINA = " + idTav + " ";
                else
                    kushti = kushti + "AND F.ID_TAVOLINA = " + idTav + " ";

                if (zgjedhja == 1)
                    s += "për tavolinën " + cboTavolinat.Text;
                else
                    s += ", për tavolinën " + cboTavolinat.Text;
                zgjedhja = zgjedhja + 1;
            }

            if (this.chkKamarieri.Checked == true)
            {
                int idKam = Convert.ToInt32(this.cboKamarieri.Value);

                if (zgjedhja == 0)
                    kushti = kushti + "P.ID_PERSONELI = " + idKam + " ";
                else
                    kushti = kushti + " AND P.ID_PERSONELI = " + idKam + " ";

                if (zgjedhja == 1)
                    s += "të kamarierit " + cboKamarieri.Text;
                else
                    s += ", të kamarierit " + cboKamarieri.Text;
                zgjedhja = zgjedhja + 1;
            }

            if (this.chkPeriudha.Checked == true)
            {
                string data1 = dateFillimi.ToString("yyyy-MM-dd HH:mm:ss");
                string data2 = dateMbarimi.ToString("yyyy-MM-dd HH:mm:ss");

                if (zgjedhja == 0)
                    kushti = kushti + " DATA_ORA BETWEEN  CONVERT(DATETIME, '" + data1 + "') AND CONVERT(DATETIME, '" + data2 + "')";
                else
                    kushti = kushti + " AND DATA_ORA BETWEEN  CONVERT(DATETIME, '" + data1 + "') AND CONVERT(DATETIME, '" + data2 + "')";

                if (zgjedhja == 1)
                    s += "midis datave " + dateFillimi.ToString("dd.MM.yyyy HH:mm") + " dhe " + dateMbarimi.ToString("dd.MM.yyyy HH:mm");
                else
                    s += ", midis datave " + dateFillimi.ToString("dd.MM.yyyy HH:mm") + " dhe " + dateMbarimi.ToString("dd.MM.yyyy HH:mm");
                zgjedhja = zgjedhja + 1;
            }

            if (zgjedhja != 0)
            {
                strSql = strSql + kushti;
            }
            else
            {
                this.MbushGridenPerSot();
                return;
            }
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("KtheFaturatSipasKerkimit", strSql);
            
            if (ds != null)
            {
                ds.AcceptChanges();
                this.gridaFaturat.DataSource = ds.Tables[0];
                this.Doc.GridEX = gridaFaturat;
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + s;
                Doc.DefaultPageSettings.Landscape = true;
                Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
                Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            }
        }

        private bool KaGabim()
        {
            if (this.chkNrFature.Checked == true)
            {
                if (this.txtNrFatura.Text.Trim() == "")
                {
                    MessageBox.Show("Ju duhet te jepni numrin e fatures!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            if (this.chkTavolina.Checked == true)
            {
                if (this.cboTavolinat.Text.Trim() == "")
                {
                    MessageBox.Show("Ju duhet te zgjidhni tavolinen!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            if (this.chkKamarieri.Checked == true)
            {
                if (this.cboKamarieri.Text.Trim() == "")
                {
                    MessageBox.Show("Ju duhet te zgjidhni kamarierin!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            if (this.chkPeriudha.Checked == true)
            {
                DateTime dateFillimi = this.dtFillimi.Value;
                DateTime dateMbarimi = this.dtMbarimi.Value;

                DateTime dtFirst = dateFillimi;
                DateTime dtLast = dateMbarimi.AddMinutes(2);

                if (dtFirst > dtLast)
                {
                    MessageBox.Show("Data e fillimit nuk mund te jete me e madhe se data e mbarimit!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            return false;
        }

        private void BllokoKerkimin()
        {
            this.txtNrFatura.ReadOnly = true;
            this.cboTavolinat.Enabled = false;
            this.cboKamarieri.Enabled = false;
            this.dtFillimi.Enabled = false;
            this.dtMbarimi.Enabled = false;

            this.txtDateFillimi.ReadOnly = true;
            this.txtDateFillimi.BackColor = Color.White;
            this.txtDateFillimi.Visible = true;

            this.txtDateMbarimi.ReadOnly = true;
            this.txtDateMbarimi.BackColor = Color.White;
            this.txtDateMbarimi.Visible = true;

            this.txtNrFatura.BackColor = Color.White;
            this.cboKamarieri.BackColor = Color.White;
            this.cboTavolinat.BackColor = Color.White;
        }

        private void MbushGridenPerSot()
        {

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqFaturatPerSot");

            if (ds != null)
            {
                this.gridaFaturat.DataSource = ds.Tables[0];
            }
            string s = "Faturat për datën " + DateTime.Now.ToString("dd.MM.yyyy");
            this.Doc.GridEX = gridaFaturat;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + s;
            Doc.DefaultPageSettings.Landscape = true;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
        }

        private void MbushTavolinat()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTavolinatPerKombo");

            if (ds != null)
            {
                this.cboTavolinat.DataSource = ds.Tables[0];
            }

        }

        private void MbushKamarieret()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKamarieretPerKombo");

            if (ds != null)
            {
                this.cboKamarieri.DataSource = ds.Tables[0];
            }
        }

        private void KerkoNeGride(int idFatura)
        {
            Janus.Windows.GridEX.ConditionOperator operatori = new Janus.Windows.GridEX.ConditionOperator();
            operatori = Janus.Windows.GridEX.ConditionOperator.Equal;
            Janus.Windows.GridEX.GridEXFilterCondition kusht = new Janus.Windows.GridEX.GridEXFilterCondition(gridaFaturat.RootTable.Columns["ID_FATURA"], operatori, idFatura);
            gridaFaturat.Find(kusht, 0, -1);
        }
        #endregion

        #region Event Handlers
        private void btnMbyll_Click(object sender, EventArgs e)
        {
            this.uiTabModifiko.Visible = false;
            this.gridaFaturat.Visible = true;
            //this.AktivizoPanel(panelButona);
        }

        private void btnRuajDergese_Click(object sender, EventArgs e)
        {
            this.uiTabModifiko.Visible = false;
            this.gridaFaturat.Visible = true;
            //this.AktivizoPanel(panelButona);
        }

        private void btnShtoDergese_Click(object sender, EventArgs e)
        {
            this.gridaFaturat.Visible = false;
            this.uiTabModifiko.Visible = true;
            //this.CaktivizoPanel(panelButona);

        }

        private void btnModifikoDergese_Click(object sender, EventArgs e)
        {
            this.gridaFaturat.Visible = false;
            this.uiTabModifiko.Visible = true;
            //this.CaktivizoPanel(panelButona);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {

            this.Kerko();

        }

        private void gridaFaturat_CurrentCellChanged(object sender, EventArgs e)
        {


        }

        private void chkNrFature_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkNrFature.Checked == true)
            {
                this.txtNrFatura.ReadOnly = false;
                this.txtNrFatura.BackColor = Color.White;
            }
            else
            {
                this.txtNrFatura.Text = "";
                this.txtNrFatura.ReadOnly = true;
                this.txtNrFatura.BackColor = Color.White;


            }


        }

        private void chkTavolina_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkTavolina.Checked == true)
            {
                this.cboTavolinat.Enabled = true;
                this.cboTavolinat.BackColor = Color.White;
            }
            else
            {
                this.cboTavolinat.Text = "";
                this.cboTavolinat.Enabled = false;
                this.cboTavolinat.BackColor = Color.White;
            }


        }

        private void chkKamarieri_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkKamarieri.Checked == true)
            {
                this.cboKamarieri.Enabled = true;
                this.cboKamarieri.BackColor = Color.White;
            }
            else
            {
                this.cboKamarieri.Text = "";
                this.cboKamarieri.Enabled = false;
                this.cboKamarieri.BackColor = Color.White;
            }


        }

        private void chkPeriudha_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPeriudha.Checked == true)
            {
                this.dtFillimi.Enabled = true;
                this.dtMbarimi.Enabled = true;

                this.txtDateFillimi.Visible = false;
                this.txtDateMbarimi.Visible = false;
            }
            else
            {
                this.dtFillimi.Enabled = false;
                this.dtMbarimi.Enabled = false;

                this.txtDateFillimi.Visible = true;
                this.txtDateMbarimi.Visible = true;
            }


        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaFaturat.Row;

            int nr = this.gridaFaturat.RowCount;

            if (indeksi < 0 || indeksi >= nr - 1)
            {
                return;
            }

            int idFatura = Convert.ToInt32(this.gridaFaturat.GetRow(indeksi).Cells[0].Text);
            string nrFatura = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["NR_FATURE"].Text);
            string tavolina = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["TAVOLINA"].Text);
            string kamarieri = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["KAMARIERI"].Text);
            string dataFatura = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["DATA_ORA"].Text);
            string skonto = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["SKONTO"].Text);
            string totali = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["TOTALI"].Text);

            frmModifikoFature frm = new frmModifikoFature();
            frm.idFatura = idFatura;
            frm.nrFatura = nrFatura;
            frm.kamarieri = kamarieri;
            frm.tavolina = tavolina;
            frm.dataFatura = dataFatura;

            frm.ShowDialog();

            if (frm.veprimi == 1)
            {
                this.Kerko();
            }


        }

        private void gridaFaturat_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnShfaq_Click(object sender, EventArgs e)
        {
            //this.zgjidhFatura = this.zgjidhFatura + 1;
            //if (this.zgjidhFatura == 1)
            //{
            //    return;
            //}

            int indeksi = this.gridaFaturat.Row;

            int nr = this.gridaFaturat.RowCount;

            if (indeksi < 0 || indeksi >= nr)
            {
                return;
            }

            int idFatura = Convert.ToInt32(this.gridaFaturat.GetRow(indeksi).Cells[0].Text);
            string nrFatura = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["NR_FATURE"].Text);
            string tavolina = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["TAVOLINA"].Text);
            string kamarieri = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["KAMARIERI"].Text);
            string dataFatura = Convert.ToDateTime(this.gridaFaturat.GetRow(indeksi).Cells["DATA_ORA"].Text).ToString("dd.MM.yyyy  HH:mm");
            string skonto = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["SKONTO"].Text);
            string totali = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["TOTALI"].Text);

            frmFaturaShfaq frm = new frmFaturaShfaq();
            frm.idFatura = idFatura;
            frm.nrFatura = nrFatura;
            frm.tavolina = tavolina;
            frm.kamarieri = kamarieri;
            frm.dataFatura = dataFatura;
            frm.skonto = skonto;
            frm.totali = totali;

            frm.ShowDialog();
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaFaturat.Row;
            if (indeksi < 0)
            {
                return;
            }

            bool anulluar = Convert.ToBoolean(this.gridaFaturat.GetRow(indeksi).Cells["ANULLUAR"].Text);

            if (anulluar == true)
            {
                return;
            }

            int idFatura = Convert.ToInt32(this.gridaFaturat.GetRow(indeksi).Cells["ID_FATURA"].Text);
            string nrFatura = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["NR_FATURE"].Text);
            string dataFatura = Convert.ToString(this.gridaFaturat.GetRow(indeksi).Cells["DATA_ORA"].Text).Substring(0, 11);

            DialogResult result = MessageBox.Show("Ju jeni duke anulluar faturen me numer  '" + nrFatura + "'  date  '" + dataFatura + "' .Jeni te sigurte se doni te vazhdoni ?", "Vemendje !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            InputController data = new InputController();
            int b = data.KerkesaUpdate("AnulloFaturen", idFatura);

            if (b == 0)
            {
                MessageBox.Show("Fatura me numer  '" + nrFatura + "'  date   '" + dataFatura + "'  u anullua.", "Vemendje !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Kerko();
                this.KonsumoArtikujtBanaku(idFatura);
                this.KerkoNeGride(idFatura);

            }
            else
            {
                MessageBox.Show("Ju keni hasur nje problem ne aksesimin e databazes .Ju lutem provoni perseri!", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridaFaturat.RowCount != 0)
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
            string[] fushat = new string[7];
            string[] llojet = new string[7];
            string[] key = new string[7];
            fushat[0] = "Data";
            fushat[1] = "Nr_fature";
            fushat[2] = "Tavolina";
            fushat[3] = "Kamarieri";
            fushat[4] = "Totali";
            fushat[5] = "Forma_e_pageses";
            fushat[6] = "Anulluar";

            key[0] = "DATA_ORA";
            key[1] = "NR_FATURE";
            key[2] = "TAVOLINA";
            key[3] = "KAMARIERI";
            key[4] = "TOTALI";
            key[5] = "FORMA_PAGESA";
            key[6] = "ANULLUAR";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "char(255)";
            llojet[3] = "char(255)";
            llojet[4] = "float";
            llojet[5] = "char(255)";
            llojet[6] = "char(255)";

            KlaseExcel excel = new KlaseExcel("Faturat.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGride("Faturat.xls", gridaFaturat, fushat, key, llojet, "DATA_ORA");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Faturat.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (gridaFaturat.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion

        private void frmFatura_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            this.MbushTavolinat();
            this.MbushKamarieret();
        }

        

        
    }
}