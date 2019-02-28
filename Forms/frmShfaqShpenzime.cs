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
    public partial class frmShfaqShpenzime : System.Windows.Forms.Form, IPrintable
    {
        private int upDirection = 0;
        private bool clickedSearch = false;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        #region Form Load
        public frmShfaqShpenzime()
        {
            InitializeComponent();
            this.BllokoKerkimin();
        }

        private void frmShfaqShpenzime_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = gridShpenzimet;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + 
                Environment.NewLine + "Shpenzimet për datën " + DateTime.Now.ToString("dd.MM.yyyy");

            dtpData.Value = DateTime.Now;
            dtpDataKerkim.Value = DateTime.Now;
            string kushti = " WHERE MONTH(DATA) = MONTH(GETDATE()) AND YEAR(DATA) = YEAR(GETDATE()) " + 
                " AND DAY(DATA) = DAY(GETDATE())";
            MbushGride(kushti);
            LexoInformacione();
        }
        #endregion

        #region Private Methods
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
        /// <summary>
        /// mbush griden me te dhena te filtruara sipas kushtit qe merr si parameter
        /// </summary>
        /// <param name="kushti"></param>
        private void MbushGride(string kushti)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqShpenzimet", kushti);
            gridShpenzimet.DataSource = ds.Tables[0];
            FormatoGride(gridShpenzimet);
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.RowCount <= 23)
                grid.RootTable.Columns["KOMENT"].Width = 168;
            else
                grid.RootTable.Columns["KOMENT"].Width = 151;
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void MbushCombo()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEShpenzimeve");
            cmbKategorite.DataSource = ds.Tables[0];
            cmbKategoriteKerkim.DataSource = ds.Tables[0];
        }

        private void Pastro()
        {
            dtpData.Value = DateTime.Now;
            txtPershkrimi.Text = "";
            numVlera.Value = 0;
            cmbKategorite.Value = null;
            cmbKategorite.Text = "";
        }

        private void Kerko()
        {
            //nqs nuk eshte klikuar asnjehere butoni Kerko
            //atehere Shfaq te gjithe shpenzimet per daten sot
            if (!clickedSearch)
            {
                string s = " WHERE MONTH(DATA) = MONTH(GETDATE()) AND YEAR(DATA) = YEAR(GETDATE()) " +
                " AND DAY(DATA) = DAY(GETDATE())";
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes +
                Environment.NewLine + "Shpenzimet për datën " + DateTime.Now.ToString("dd.MM.yyyy");
                MbushGride(s);
            }
            else if (cbData.Checked == false && cbKategoria.Checked == false && cbPershkrimi.Checked == false)
            {
                MbushGride("");
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes +
                Environment.NewLine + "Shpenzimet";
            }
            else
            {
                string s = "WHERE ";
                string strDesc = "Shpenzimet ";
                bool check1 = false;
                if (cbData.Checked == true)
                {
                    DateTime data = dtpDataKerkim.Value;
                    s += "  MONTH(DATA) = MONTH('" + data.ToString("yyyy-MM-dd") + "') AND YEAR(DATA) = YEAR('" + data.ToString("yyyy-MM-dd") + "') " +
                " AND DAY(DATA) = DAY('" + data.ToString("yyyy-MM-dd") + "')";
                    strDesc += " për datën " + data.ToString("dd.MM.yyyy");
                    check1 = true;
                }
                if (cbKategoria.Checked == true)
                {
                    if (check1)
                    {
                        s += "AND ID_KATEGORIASHPENZIMI = " + Convert.ToInt32(cmbKategoriteKerkim.Value) + " ";
                        strDesc += ", për kategorinë e shpenzimeve " + cmbKategoriteKerkim.Text;
                    }
                    else
                    {
                        s += "ID_KATEGORIASHPENZIMI = " + Convert.ToInt32(cmbKategoriteKerkim.Value) + " ";
                        strDesc += " për kategorinë e shpenzimeve " + cmbKategoriteKerkim.Text;
                        check1 = true;
                    }
                }
                if (cbPershkrimi.Checked == true)
                {
                    if (check1)
                    {
                        s += "AND KOMENT LIKE '" + this.txtPershkrimiKerkim.Text + "%' ";

                    }
                    else
                    {
                        s += "KOMENT LIKE '" + txtPershkrimiKerkim.Text + "%' ";
                        check1 = true;
                    }
                }
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + strDesc;
                MbushGride(s);
                gridShpenzimet.Visible = true;
                uiTabModifiko.Visible = false;
                AktivizoPanel(panelTop);
            }
        }
        #endregion

        #region Event Handlers
        private void btnShto_Click(object sender, EventArgs e)
        {

        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            int index = gridShpenzimet.Row;
            if (index >= 0 && gridShpenzimet.GetRow(index).Cells["ID_SHPENZIMI"].Text != "")
            {
                CaktivizoPanel(panelTop);
                uiTabModifiko.Visible = true;
                gridShpenzimet.Visible = false;
                txtPershkrimi.Text = gridShpenzimet.GetRow(index).Cells["KOMENT"].Text;
                dtpData.Value = Convert.ToDateTime(gridShpenzimet.GetRow(index).Cells["DATA"].Text);
                cmbKategorite.Value = Convert.ToInt32(gridShpenzimet.GetRow(index).Cells["ID_KATEGORIASHPENZIMI"].Text);
                numVlera.Value = Convert.ToDecimal(gridShpenzimet.GetRow(index).Cells["SASIA"].Text);
            }
        }

        private void btnKerkoNeGride_Click(object sender, EventArgs e)
        {
            Forms.frmKerko frm = new frmKerko();
            frm.ShowDialog();
            string tekst = frm.txtKerkim.Text;
            Janus.Windows.GridEX.ConditionOperator operatori = new Janus.Windows.GridEX.ConditionOperator();
            operatori = Janus.Windows.GridEX.ConditionOperator.BeginsWith;
            Janus.Windows.GridEX.GridEXFilterCondition kusht = new
                Janus.Windows.GridEX.GridEXFilterCondition(this.gridShpenzimet.RootTable.Columns["KOMENT"], operatori, tekst);
            gridShpenzimet.Find(kusht, 0, -1);
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            Pastro();
            gridShpenzimet.Visible = true;
            uiTabModifiko.Visible = false;
            AktivizoPanel(panelTop);
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            gridShpenzimet.ExpandGroups();
            if (gridShpenzimet.RowCount > 0)
            {
                gridShpenzimet.Row = 0;
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            upDirection = 1;
            gridShpenzimet.ExpandGroups();
            if ((gridShpenzimet.Row >= 1) && (gridShpenzimet.Row - 1 >= 0))
            {
                gridShpenzimet.Row = gridShpenzimet.Row - 1;
            }
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            gridShpenzimet.ExpandGroups();
            if ((gridShpenzimet.Row <= gridShpenzimet.RowCount - 2) && (gridShpenzimet.Row + 1 >= 0))
            {
                gridShpenzimet.Row = gridShpenzimet.Row + 1;
            }
        }

        private void btnFundit_Click(object sender, EventArgs e)
        {
            gridShpenzimet.ExpandGroups();
            if ((gridShpenzimet.RowCount > 0) && (gridShpenzimet.RowCount - 3 >= 0))
            {
                gridShpenzimet.Row = gridShpenzimet.RowCount - 3;
            }
        }

        private void gridShpenzimet_CurrentCellChanged(object sender, EventArgs e)
        {
            int index = this.gridShpenzimet.Row;
            if ((index >= 0) && (gridShpenzimet.GetRow(index).Cells["ID_SHPENZIMI"].Text != ""))
            {
                numVlera.Value = Convert.ToDecimal(gridShpenzimet.GetRow(index).Cells["SASIA"].Text);
                dtpData.Value = Convert.ToDateTime(gridShpenzimet.GetRow(index).Cells["DATA"].Text);
                cmbKategorite.Value = Convert.ToInt32(gridShpenzimet.GetRow(index).Cells["ID_KATEGORIASHPENZIMI"].Text);
                txtPershkrimi.Text = gridShpenzimet.GetRow(index).Cells["KOMENT"].Text;
            }
            else
            {
                if ((index > 0) && (upDirection == 1))
                {
                    gridShpenzimet.Row = index - 1;
                    upDirection = 0;
                    return;
                }
                if ((gridShpenzimet.RowCount > index + 1) && (index + 1 >= 0))
                {
                    gridShpenzimet.Row = index + 1;
                    return;
                }
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (txtPershkrimi.Text != "" && cmbKategorite.Value != null
                && cmbKategorite.Text != "" && numVlera.Value != 0)
            {
                InputController data = new InputController();
                int index = gridShpenzimet.Row;
                int idShpenzimi = Convert.ToInt32(gridShpenzimet.GetRow(index).Cells["ID_SHPENZIMI"].Text);
                int idKategoria = Convert.ToInt32(cmbKategorite.Value);
                int idPerdoruesi = MDIAdminTjeter.idPerdoruesi;
                int b = data.KerkesaUpdate("ModifikoShpenzim", idShpenzimi, idKategoria, idPerdoruesi, txtPershkrimi.Text
                    ,dtpData.Value, numVlera.Value);
                if (b == 0)
                {
                    MessageBox.Show(this, "Shpenzimi i zgjedhur u modifikua." + Environment.NewLine + 
                        "Shpenzimi u regjistrua në përgjegjësi të përdoruesit të loguar.", this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Pastro();
                    Kerko();
                    this.uiTabModifiko.Visible = false;
                    gridShpenzimet.Visible = true;
                    AktivizoPanel(panelTop);
                }
                else
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë modifikimit të shpenzimit. Provoni përsëri!",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbData_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbData.Checked == true)
            {
                this.dtpDataKerkim.Enabled = true;
                this.dtpDataKerkim.Value = System.DateTime.Now;
            }
            else
            {
                this.dtpDataKerkim.Value = System.DateTime.Now;
                this.dtpDataKerkim.Enabled = false;
            }
        }

        private void cbKategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbKategoria.Checked == true)
            {
                this.cmbKategoriteKerkim.Text = "";
                this.cmbKategoriteKerkim.Value = null;
                this.cmbKategoriteKerkim.Enabled = true;

            }
            else
            {
                this.cmbKategoriteKerkim.Text = "";
                this.cmbKategoriteKerkim.Enabled = false;
                this.cmbKategoriteKerkim.BackColor = Color.White;
            }
        }

        private void cbPershkrimi_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbPershkrimi.Checked == true)
            {
                this.txtPershkrimiKerkim.Text = "";
                this.txtPershkrimiKerkim.ReadOnly = false;
            }
            else
            {
                this.txtPershkrimiKerkim.Text = "";
                this.txtPershkrimiKerkim.ReadOnly = true;
                this.txtPershkrimiKerkim.BackColor = Color.White;
            }
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            clickedSearch = true;
            gbShpenzimet.Text = "Shpenzimet";
            Kerko();
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            DataSet dsId = new DataSet();
            dsId.Tables.Add();
            dsId.Tables[0].Columns.Add("ID_SHPENZIMI", typeof(Int32));
            dsId.AcceptChanges();
            for (int i = 0; i < gridShpenzimet.RowCount; i++)
            {
                if (gridShpenzimet.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    DataRow r = dsId.Tables[0].NewRow();
                    r["ID_SHPENZIMI"] = Convert.ToInt32(gridShpenzimet.GetRow(i).Cells["ID_SHPENZIMI"].Text);
                    dsId.Tables[0].Rows.Add(r);
                }
            }
            dsId.AcceptChanges();
            if (dsId.Tables[0].Rows.Count != 0)
            {
                InputController data = new InputController();
                int b = data.KerkesaUpdate("FshiShpenzimet", dsId);
                if (b != 0)
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së shpenzimeve!" + Environment.NewLine +
                        "Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //jane fshire te gjithe shpenzimet dhe gjate fshirjes
                //nuk ka patur konflikte
                else
                {
                    MessageBox.Show(this, "Shpenzimet e zgjedhur u fshinë.",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Kerko();
                    return;
                }
            }
        }

        private void BllokoKerkimin()
        {
            this.cbData.Checked = false;
            this.cbKategoria.Checked = false;
            this.cbPershkrimi.Checked = false;

            this.dtpDataKerkim.Value = System.DateTime.Now;
            this.dtpDataKerkim.Enabled = false;
            ////this.dtpDataKerkim.back
            
            this.cmbKategoriteKerkim.Text = "";
            this.cmbKategoriteKerkim.Enabled = false;
            this.cmbKategoriteKerkim.BackColor = Color.White;

            this.txtPershkrimiKerkim.Text = "";
            this.txtPershkrimiKerkim.ReadOnly = true;
            this.txtPershkrimiKerkim.BackColor = Color.White;


        }

        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridShpenzimet.RowCount != 0)
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
            this.gridShpenzimet.ExpandGroups();
            string[] fushat = new string[5];
            string[] llojet = new string[5];
            string[] key = new string[5];
            fushat[0] = "Kategoria";
            fushat[1] = "Pershkrimi";
            fushat[2] = "Data";
            fushat[3] = "Sasia";
            fushat[4] = "Personeli";

            key[0] = "PERSHKRIMI";
            key[1] = "KOMENT";
            key[2] = "DATA_STR";
            key[3] = "SASIA";
            key[4] = "PERDORUESI";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "char(255)";
            llojet[3] = "float";
            llojet[4] = "char(255)";

            KlaseExcel excel = new KlaseExcel("Shpenzimet.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("Shpenzimet.xls", gridShpenzimet, fushat, key, llojet,
                    "PERSHKRIMI");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Shpenzimet.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (gridShpenzimet.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion

        private void frmShfaqShpenzime_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            MbushCombo();
            btnKerko_Click(sender, e);
        }
    }
}