using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmTurnet : System.Windows.Forms.Form, IPrintable
    {
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;


        #region Load Form
        public frmTurnet()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = gridTurnet;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Turnet e hapur";

            LexoInformacione();
            dtpData.Value = DateTime.Now;
            //string data = DateTime.Now.Date.Day + "." + DateTime.Now.Date.Month + "." + DateTime.Now.Date.Year;
            //string kushti = "WHERE DATA = '" + data + "' ";
            //MbushGride(kushti);

            this.BllokoKerkimin();


        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Lexon informacionet e pergjithshme te aplikacionit
        /// </summary>
        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void MbushGride(string kushti)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTurnet", kushti);
            gridTurnet.DataSource = ds.Tables[0];
            //FormatoGride(gridTurnet);
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.RowCount <= 24)
                grid.RootTable.Columns["KAMARIERI"].Width = 150;
            else
                grid.RootTable.Columns["KAMARIERI"].Width = 133;
        }

        private void MbushCombo()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqPerdoruesitKamariere");
            cmbKamarieri.DataSource = ds.Tables[0];
        }

        private void BllokoKerkimin()
        {
            this.cmbKamarieri.Value = null;
            this.cmbKamarieri.Enabled = false;
            this.cmbKamarieri.BackColor = Color.White;

            this.dtpData.Value = System.DateTime.Today;
            this.dtpData.Enabled = false;

            this.optHapur.Checked = true;
        }

        private void KerkoFirst()
        {
            //if ((cbData.Checked == false) && (cbKamarieri.Checked == false))
            //{

            //}
            //else
            //{
            //    string s = "WHERE ";
            //    bool check1 = false;
            //    if (this.cbKamarieri.Checked == true)
            //    {
            //        if (cmbKamarieri.Value == null || cmbKamarieri.Text == "")
            //            return;
            //        s += "ID_PERSONELI = " + cmbKamarieri.Value + "";
            //        check1 = true;
            //    }
            //    if (this.cbData.Checked == true)
            //    {
            //        if (check1)
            //        {
            //            s += "AND DATA = '" + dtpData.Text + "' ";
            //        }
            //        else
            //        {
            //            s += " DATA = '" + dtpData.Text + "' ";
            //            check1 = true;
            //        }
            //    }
            //    MbushGride(s);
            //}

            int zgjedhja = 0;

            bool hapur = this.optHapur.Checked;
            int idKamarieri = 0;
            DateTime dtKerkimi = System.DateTime.Today;


            if (this.cbKamarieri.Checked == true)
            {
                idKamarieri = Convert.ToInt32(this.cmbKamarieri.Value);
                zgjedhja = zgjedhja + 1;
            }


            dtKerkimi = System.DateTime.Now;
            zgjedhja = zgjedhja + 2;


            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTurnetSipasKerkimit", zgjedhja, hapur, idKamarieri, dtKerkimi);

            if (ds != null)
            {
                this.gridTurnet.DataSource = ds.Tables[0];
            }
        }

        #endregion
       
        #region Event Handlers
        private void btnKerko_Click(object sender, EventArgs e)
        {
            if ((cbData.Checked == false) && (cbKamarieri.Checked == false))
            {
                
            }
            else
            {
                string s = "WHERE ";
                bool check1 = false;
                if ( this.cbKamarieri.Checked == true)
                {
                    if (cmbKamarieri.Value == null || cmbKamarieri.Text == "")
                        return;
                    s += "ID_PERSONELI = " + cmbKamarieri.Value + "";
                    check1 = true;
                }
                if (this.cbData.Checked == true)
                {
                    if (check1)
                    {
                        s += "AND DATA = '" + dtpData.Text + "' ";
                    }
                    else
                    {
                        s += " DATA = '" + dtpData.Text + "' ";
                        check1 = true;
                    }
                }
                MbushGride(s);
            }
        }

        private void Kerko()
        {
            int zgjedhja = 0;
            bool hapur = this.optHapur.Checked;
            int idKamarieri = 0;
            DateTime dtKerkimi = System.DateTime.Today;
            string strDesc = "Turnet ";
            if (optHapur.Checked)
                strDesc += "e hapura";
            else
                strDesc += "e mbyllura";
            if (this.cbKamarieri.Checked == true)
            {
                idKamarieri = Convert.ToInt32(this.cmbKamarieri.Value);
                zgjedhja = zgjedhja + 1;
                strDesc += ", për kamarierin " + cmbKamarieri.Text;
            }

            if (this.cbData.Checked == true)
            {
                dtKerkimi = this.dtpData.Value;
                zgjedhja = zgjedhja + 2;
                strDesc += ", për datën " + dtpData.Text;
            }
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + strDesc;
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTurnetSipasKerkimit", zgjedhja, hapur, idKamarieri, dtKerkimi);

            if (ds != null)
            {
                this.gridTurnet.DataSource = ds.Tables[0];
            }
        }

        private void cbKamarieri_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbKamarieri.Checked == true)
            {
                this.cmbKamarieri.Enabled = true;
            }
            else
            {
                this.cmbKamarieri.Value = null;
                this.cmbKamarieri.Enabled = false;
                this.cmbKamarieri.BackColor = Color.White;
            }
        }

        private void cbData_CheckedChanged(object sender, EventArgs e)
        {
            if (cbData.Checked == true)
            {
                this.dtpData.Value = System.DateTime.Today;
                this.dtpData.Enabled = true;
                 
            }
            else
            {
                this.dtpData.Value = System.DateTime.Today;
                this.dtpData.Enabled = false;
                ///this.dtpData.ba
            }
        }

        private void btnFshiHistorik_Click(object sender, EventArgs e)
        {
            //konfimim nqs duhet fshire historiku
            InputController data = new InputController();
            int b = data.KerkesaUpdate("FshiHistorikTurnet");
            if (b == 0)
            {
                MessageBox.Show(this, "Historiku i  ndërrimit të turneve për kamarierët u fshi," +
                    Environment.NewLine + "përveç veprimeve të ditës së sotme!", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbData.Checked = false;
                cbKamarieri.Checked = false;
                dtpData.Value = DateTime.Now;
                string dataSot = DateTime.Now.Date.Day + "." + DateTime.Now.Date.Month + "." + DateTime.Now.Date.Year;
                string kushti = "WHERE DATA = '" + dataSot + "' ";
                MbushGride(kushti);
            }
            else
                MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së historikut të turneve!" +
                    Environment.NewLine + "Provoni përsëri!", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnKerko_Click_1(object sender, EventArgs e)
        {
            this.Kerko();
        }

        private void btnKonsulto_Click(object sender, EventArgs e)
        {
            try
            {
                int indeksi = this.gridTurnet.Row;
                bool mbyllur = false;
                int idKamarieri = Convert.ToInt32(this.gridTurnet.GetRow(indeksi).Cells[0].Text);
                string kam = Convert.ToString(this.gridTurnet.GetRow(indeksi).Cells[2].Text);
                DateTime dtFillimi = Convert.ToDateTime(this.gridTurnet.GetRow(indeksi).Cells[3].Text);
                DateTime dtMbarimi = System.DateTime.Today; ;
                decimal vlera = Convert.ToDecimal(this.gridTurnet.GetRow(indeksi).Cells[5].Text);

                if (this.optMbyllur.Checked == true)
                {
                    mbyllur = true;
                    dtMbarimi = Convert.ToDateTime(this.gridTurnet.GetRow(indeksi).Cells[4].Text);
                }

                frmXhiroKam frm = new frmXhiroKam();
                frm.StartPosition = FormStartPosition.CenterParent;

                frm.idKam = idKamarieri;
                frm.kamarieri = kam;
                frm.dtFillimi = dtFillimi;
                frm.dtMbarimi = dtMbarimi;
                frm.mbyllur = mbyllur;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
            }

        }
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridTurnet.RowCount != 0)
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
            this.gridTurnet.ExpandGroups();
            string[] fushat = new string[4];
            string[] llojet = new string[4];
            string[] key = new string[4];
            fushat[0] = "Kamarieri";
            fushat[1] = "Data_Ora_e_hyrjes";
            fushat[2] = "Data_Ora_e_daljes";
            fushat[3] = "Xhiro";

            key[0] = "KAMARIERI";
            key[1] = "FILLIMI_STR";
            key[2] = "MBARIMI_STR";
            key[3] = "XHIRO";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "char(255)";
            llojet[3] = "float";

            KlaseExcel excel = new KlaseExcel("Turnet.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("Turnet.xls", gridTurnet, fushat, key, llojet,
                    "KAMARIERI");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Turnet.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (gridTurnet.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion

        private void frmTurnet_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            MbushCombo();
            this.KerkoFirst();
        }
    }
}