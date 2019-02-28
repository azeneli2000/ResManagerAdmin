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
    public partial class frmKonfigurimKlientet : System.Windows.Forms.Form, IPrintable
    {
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        #region Form Load
        public frmKonfigurimKlientet()
        {
            InitializeComponent();
        }

        private void frmKonfigurimArtikujsh_Load(object sender, EventArgs e)
        {
            gridaKlientet.BringToFront();
            LexoInformacione();
            MbushGride("");
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = gridaKlientet;
            Doc.DefaultPageSettings.Landscape = true;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Klientët";
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
            DataSet ds = data.KerkesaRead("ShfaqKlientet", kushti);

            ds.Tables[0].Columns.Add("CHECKED", typeof(bool));

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                dr["CHECKED"] = false;
            }

            ds.Tables[0].AcceptChanges();

            gridaKlientet.DataSource = ds.Tables[0];
            //FormatoGride(gridaKlientet);
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.RowCount <= 23)
                grid.RootTable.Columns["ADRESA"].Width = 168;
            else
                grid.RootTable.Columns["ADRESA"].Width = 151;
        }

        private void Pastro()
        {
            this.txtEmri.Clear();
            this.txtMbiemri.Clear();
            this.txtKodiKlienti.Clear();
            this.txtTelefoni.Clear();
            this.txtAdresa.Clear();
        }

        private void Ploteso(int i)
        {
            this.txtEmri.Text = gridaKlientet.GetRow(i).Cells["colEmri"].Text;
            this.txtMbiemri.Text = gridaKlientet.GetRow(i).Cells["colMbiemri"].Text;
            this.txtKodiKlienti.Text = gridaKlientet.GetRow(i).Cells["colKodiKlienti"].Text;
            this.txtAdresa.Text = this.gridaKlientet.GetRow(i).Cells["colAdresa"].Text;
            this.txtTelefoni.Text = gridaKlientet.GetRow(i).Cells["colTelefoni"].Text;
        }

        private int ShtoKlient()
        {
            if (txtEmri.Text != "" && txtMbiemri.Text != "" && txtKodiKlienti.Text != "")
            {
                InputController data = new InputController();
                int b = data.KerkesaUpdate("ShtoKlient", txtEmri.Text, txtMbiemri.Text, txtKodiKlienti.Text,
                    txtTelefoni.Text, txtAdresa.Text);

                if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston një klient me të njëjtin emër dhe mbiemër!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
                else if (b == 0)
                {
                    MessageBox.Show(this, "Klienti i ri u krijua!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
                else
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë krijimit të klientit. Provoni përsëri!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            }
            else
                return 1;
        }

        private int ModifikoKlient()
        {
            if (txtEmri.Text != "" && txtMbiemri.Text != "" && txtKodiKlienti.Text != "")
            {
                InputController data = new InputController();
                int index = gridaKlientet.Row;
                int idKlienti = Convert.ToInt32(gridaKlientet.GetRow(index).Cells["colIdKlienti"].Text);
                int b = data.KerkesaUpdate("ModifikoKlient",idKlienti, txtEmri.Text, txtMbiemri.Text, txtKodiKlienti.Text, txtTelefoni.Text, txtAdresa.Text);

                if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston një klient me të njëjtin emër dhe mbiemër!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
                else if (b == 0)
                {
                    MessageBox.Show(this, "Klienti i zgjedhur u modifikua!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
                else
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë modifikimit të klientit. Provoni përsëri!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }

            }
            else
                return 1;
        }
        #endregion

        #region Event Handlers
        private void btnShtoArtikull_Click(object sender, EventArgs e)
        {
            Pastro();
            this.gridaKlientet.Visible = false;
            this.uiTabModifiko.Visible = true;
            this.CaktivizoPanel(panelTop);
            this.CaktivizoPanel(panelBottom);
            this.uiTabPage.Text = "Shtim";
            this.uiTabPage.Image = ResManagerAdmin.Properties.Resources.news_info;
        }

        private void btnModifikoArtikull_Click(object sender, EventArgs e)
        {
            int index = gridaKlientet.Row;
            if (index >= 0)
            {
                Ploteso(index);
                this.gridaKlientet.Visible = false;
                this.uiTabModifiko.Visible = true;
                this.CaktivizoPanel(panelTop);
                this.uiTabPage.Text = "Modifikim";
                this.uiTabPage.Image = ResManagerAdmin.Properties.Resources.forum_newmsg;
            }
        }

        private void btnRuajArtikull_Click(object sender, EventArgs e)
        {
            int r = 1;
            if (uiTabPage.Text == "Shtim")
            {
                r = this.ShtoKlient();
            }
            else if (uiTabPage.Text == "Modifikim")
            {
                r = this.ModifikoKlient();
            }
            if (r == 0)
            {
                this.gridaKlientet.Visible = true;
                this.uiTabModifiko.Visible = false;
                this.AktivizoPanel(panelTop);
                this.AktivizoPanel(panelBottom);
                this.btnKerko_Click(sender, e);
                Pastro();
            } 
        }

        private void btnRuajKrijo_Click(object sender, EventArgs e)
        {
            int r = 1;
            if (uiTabPage.Text == "Shtim")
            {
                r = this.ShtoKlient();
            }
            else if (uiTabPage.Text == "Modifikim")
            {
                r = this.ModifikoKlient();
            }
            if (r == 0)
            {
                this.btnKerko_Click(sender, e);
                Pastro();
                if (uiTabPage.Text == "Modifikim")
                {
                    uiTabPage.Text = "Shtim";
                    uiTabPage.Image = ResManagerAdmin.Properties.Resources.news_info;
                    CaktivizoPanel(panelBottom);
                }
            }
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.gridaKlientet.Visible = true;
            this.uiTabModifiko.Visible = false;
            this.AktivizoPanel(panelTop);
            this.AktivizoPanel(panelBottom);
            Pastro();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            frmKategoriteArtikuj frm = new frmKategoriteArtikuj();
            frm.ShowDialog();
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            string strDesc = "Klientët ";
            if (cbEmri.Checked == false && cbMbiemri.Checked == false && cbAdresa.Checked == false)
            {
                MbushGride("");
            }
            else
            {
                string s = "WHERE ";
                bool check1 = false;
                if (cbEmri.Checked == true)
                {
                    s += "EMRI LIKE '" + txtEmriKerkim.Text + "%' ";
                    check1 = true;
                    strDesc += "me emër " + txtEmriKerkim.Text;
                }
                if (cbMbiemri.Checked == true)
                {
                    if (check1)
                    {
                        s += "AND MBIEMRI LIKE '" + txtMbiemriKerkim.Text + "%' ";
                        strDesc += ", mbiemër " + txtMbiemriKerkim.Text;
                    }
                    else
                    {
                        s += "MBIEMRI LIKE '" + txtMbiemriKerkim.Text + "%' ";
                        check1 = true;
                        strDesc += "me mbiemër " + txtMbiemriKerkim.Text;
                    }
                }
                if (cbAdresa.Checked == true)
                {
                    if (check1)
                    {
                        s += "AND ADRESA LIKE '" + this.txtAdresaKerkim.Text + "%' ";
                        strDesc += ", adresë " + txtMbiemriKerkim.Text;
                    }
                    else
                    {
                        s += "ADRESA LIKE '" + txtAdresaKerkim.Text + "%' ";
                        strDesc += "me adresë " + txtMbiemriKerkim.Text;
                        check1 = true;
                    }
                }
                MbushGride(s);
            }
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + strDesc;
            gridaKlientet.Visible = true;
            uiTabModifiko.Visible = false;
            AktivizoPanel(panelTop);
            Pastro();
        }

        private void cbEmri_CheckedChanged(object sender, EventArgs e)
        {
            txtEmriKerkim.Clear();
        }

        private void cbMbiemri_CheckedChanged(object sender, EventArgs e)
        {
            txtMbiemriKerkim.Clear();
        }

        private void cbAdresa_CheckedChanged(object sender, EventArgs e)
        {
            txtAdresaKerkim.Clear();
        }

        private void btnFshiArtikull_Click(object sender, EventArgs e)
        {
            DataSet dsId = new DataSet();
            dsId.Tables.Add();
            dsId.Tables[0].Columns.Add("ID_KLIENTI", typeof(Int32));
            dsId.Tables[0].Columns.Add("EMRI", typeof(String));
            dsId.Tables[0].Columns.Add("MBIEMRI", typeof(String));
            dsId.AcceptChanges();

            for (int i = 0; i < gridaKlientet.RowCount; i++)
            {
                if (gridaKlientet.GetRow(i).Cells["colZgjedhur"].Text == "True")
                {
                    DataRow r = dsId.Tables[0].NewRow();
                    r["ID_KLIENTI"] = Convert.ToInt32(gridaKlientet.GetRow(i).Cells["colIdKlienti"].Text);
                    r["EMRI"] = gridaKlientet.GetRow(i).Cells["colEmri"].Text;
                    r["MBIEMRI"] = gridaKlientet.GetRow(i).Cells["colMbiemri"].Text;
                    dsId.Tables[0].Rows.Add(r);
                }
            }

            dsId.AcceptChanges();

            if (dsId.Tables[0].Rows.Count != 0)
            {
                frmZgjidhOpsionFshiFurnitor frm = new frmZgjidhOpsionFshiFurnitor();
                frm.ShowDialog();

                string llojiFshirje = "";
                if (frm.rbFshiDisa.Checked == true)
                    llojiFshirje = "FshiDisa";
                if (frm.rbFshiTeGjithe.Checked)
                    llojiFshirje = "FshiTeGjithe";
                if (frm.rbAnullo.Checked)
                {
                    this.btnKerko_Click(sender, e);
                    return;
                }

                InputController data = new InputController();
                DataSet dsError = data.KerkesaRead("FshiKlientet", dsId, llojiFshirje);

                if (Convert.IsDBNull(dsError))
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së klienteve!" + Environment.NewLine +
                        "Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //jane fshire te gjithe furnitoret dhe gjate fshirjes
                //nuk ka patur konflikte
                if (dsError.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(this, "Klientet e zgjedhur u fshinë.",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (llojiFshirje == "FshiTeGjithe")
                    {
                        string s = "Për klientet e mëposhtëm rezultoi të kishte fatura të regjitruara.";
                        s += Environment.NewLine + "Sipas konfirmimit referencat përkatese të faturave u fshinë.";
                        int i = 1;
                        foreach (DataRow dr in dsError.Tables[0].Rows)
                        {
                            s += Environment.NewLine + i + ". " + dr["EMRI"].ToString() + " " + dr["MBIEMRI"].ToString();
                            i++;
                        }
                        MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (llojiFshirje == "FshiDisa")
                    {
                        string s = "Për klientet e mëposhtëm rezultoi të kishte fatura të regjitruara.";
                        s += Environment.NewLine + "Sipas konfirmimit këta kliente nuk u fshinë.";
                        int i = 1;
                        foreach (DataRow dr in dsError.Tables[0].Rows)
                        {
                            s += Environment.NewLine + i + ". " + dr["EMRI"].ToString() + " " + dr["MBIEMRI"].ToString();
                            i++;
                        }
                        MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                this.btnKerko_Click(sender, e);
            }
        }

        private void gridFurnitoret_CurrentCellChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int index = gridaKlientet.Row;
            if (index >= 0)
            {
                Ploteso(index);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            if (gridaKlientet.RowCount > 0)
            {
                gridaKlientet.Row = 0;
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            if ((gridaKlientet.Row >= 1) && (gridaKlientet.Row - 1 >= 0))
            {
                gridaKlientet.Row = gridaKlientet.Row - 1;
            }
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            if ((gridaKlientet.Row <= gridaKlientet.RowCount - 2) && (gridaKlientet.Row + 1 >= 0))
            {
                gridaKlientet.Row = gridaKlientet.Row + 1;
            }
        }

        private void btnFundit_Click(object sender, EventArgs e)
        {
            if ((gridaKlientet.RowCount > 0) && (gridaKlientet.RowCount - 1 >= 0))
            {
                gridaKlientet.Row = gridaKlientet.RowCount - 1;
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
                Janus.Windows.GridEX.GridEXFilterCondition(gridaKlientet.RootTable.Columns["EMRI"], operatori, tekst);
            gridaKlientet.Find(kusht, 0, -1);

        }

        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridaKlientet.RowCount != 0)
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
            string[] fushat = new string[5];
            string[] llojet = new string[5];
            string[] key = new string[5];
            fushat[0] = "Emri";
            fushat[1] = "Mbiemri";
            fushat[2] = "KodiKlienti";
            fushat[3] = "Telefoni";
            fushat[4] = "Adresa";

            key[0] = "colEmri";
            key[1] = "colMbiemri";
            key[2] = "colKodiKlienti";
            key[3] = "colTelefoni";
            key[4] = "colAdresa";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "char(255)";
            llojet[3] = "char(255)";
            llojet[4] = "char(255)";

            KlaseExcel excel = new KlaseExcel("Klientet.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGride("Klientet.xls", gridaKlientet, fushat,
                    key, llojet, "colEmri");

            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Klientet.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (gridaKlientet.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion
    }
}