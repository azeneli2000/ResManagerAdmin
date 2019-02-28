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
    public partial class frmKonfigurimFurnitoresh : System.Windows.Forms.Form, IPrintable 
    {
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        #region Form Load
        public frmKonfigurimFurnitoresh()
        {
            InitializeComponent();
        }

        private void frmKonfigurimArtikujsh_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = gridFurnitoret;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Furnitor�t";

            gridFurnitoret.BringToFront();
            LexoInformacione();
            MbushGride("");
            this.BllokoKerkimin();


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
            DataSet ds = data.KerkesaRead("ShfaqFurnitoret", kushti);
            gridFurnitoret.DataSource = ds.Tables[0];
            ///FormatoGride(gridFurnitoret);
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.RowCount <= 23)
                grid.RootTable.Columns["EMAILI"].Width = 168;
            else
                grid.RootTable.Columns["EMAILI"].Width = 151;
        }

        private void Pastro()
        {
            
            txtEmri.Clear();
            txtMbiemri.Clear();
            txtAdresa.Clear();
            txtEmail.Clear();
            txtTelefoni.Clear();

          

           
        }

        private void Ploteso(int i)
        {
            txtEmri.Text = gridFurnitoret.GetRow(i).Cells["EMRI"].Text;
            txtMbiemri.Text = gridFurnitoret.GetRow(i).Cells["MBIEMRI"].Text;
            txtAdresa.Text = gridFurnitoret.GetRow(i).Cells["ADRESA"].Text;
            txtEmail.Text = gridFurnitoret.GetRow(i).Cells["EMAILI"].Text;
            txtTelefoni.Text = gridFurnitoret.GetRow(i).Cells["TELEFONI"].Text;

            
        }

        private int ShtoFurnitor()
        {
            if (txtEmri.Text != "")
            {
                InputController data = new InputController();
                int b = data.KerkesaUpdate("ShtoFurnitor", txtEmri.Text, txtMbiemri.Text,
                    txtAdresa.Text, txtEmail.Text, txtTelefoni.Text);
                if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston nj� furnitor me t� nj�jtin em�r dhe mbiem�r!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
                else if (b == 0)
                {
                   
                    return 0;
                }
                else
                {
                    MessageBox.Show(this, "Nj� gabim ndodhi gjat� krijimit t� furnitorit. Provoni p�rs�ri!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            }
            else
                return 1;
        }

        private int ModifikoFurnitor()
        {
            if (txtEmri.Text != "")
            {
                InputController data = new InputController();
                int index = gridFurnitoret.Row;
                int idFurnitori = Convert.ToInt32(gridFurnitoret.GetRow(index).Cells["ID_FURNITORI"].Text);
                int b = data.KerkesaUpdate("ModifikoFurnitor",idFurnitori, txtEmri.Text.Trim(), txtMbiemri.Text.Trim(),
                    txtAdresa.Text.Trim(), txtEmail.Text.Trim(), txtTelefoni.Text.Trim());
                if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston nj� furnitor me t� nj�jtin em�r dhe mbiem�r!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
                else if (b == 0)
                {
                    //MessageBox.Show(this, "Furnitori i zgjedhur u modifikua!", this.Text,
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
                else
                {
                    MessageBox.Show(this, "Nj� gabim ndodhi gjat� modifikimit t� furnitorit. Provoni p�rs�ri!", this.Text,
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
            this.gridFurnitoret.Visible = false;
            this.uiTabModifiko.Visible = true;
            this.CaktivizoPanel(panelTop);
            this.CaktivizoPanel(panelBottom);
            this.uiTabPage.Text = "Shtim";
            this.uiTabPage.Image = ResManagerAdmin.Properties.Resources.news_info;
        }

        private void btnModifikoArtikull_Click(object sender, EventArgs e)
        {
            int index = gridFurnitoret.Row;
            if (index >= 0)
            {
                string emri = Convert.ToString(this.gridFurnitoret.GetRow(index).Cells["EMRI"].Text);
                if (emri == "Furnitori")
                {
                    MessageBox.Show(this, "Ju nuk mund te modifikoni furnitorin standart 'Furnitori' .", "Kujdes !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Ploteso(index);
                this.gridFurnitoret.Visible = false;
                this.uiTabModifiko.Visible = true;
                this.CaktivizoPanel(panelTop);
                this.uiTabPage.Text = "Modifikim";
                this.uiTabPage.Image = ResManagerAdmin.Properties.Resources.forum_newmsg;
            }
        }
        private bool KaGabim()
        {
            if (this.txtEmri.Text == "")
            {
                MessageBox.Show("Ju duhet te vendosni emrin e furnitorit !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return true;
            }

            return false;
        }

        private void btnRuajArtikull_Click(object sender, EventArgs e)
        {
            if (this.KaGabim() == true)
            {
                return;
            }

            int r = 1;
            if (uiTabPage.Text == "Shtim")
            {
                r = ShtoFurnitor();
            }
            else if (uiTabPage.Text == "Modifikim")
            {
                r = ModifikoFurnitor();
            }
            if (r == 0)
            {
                this.gridFurnitoret.Visible = true;
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
                r = ShtoFurnitor();
            }
            else if (uiTabPage.Text == "Modifikim")
            {
                r = ModifikoFurnitor();
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
            this.gridFurnitoret.Visible = true;
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
            if (cbEmri.Checked == false && cbMbiemri.Checked == false && cbAdresa.Checked == false)
            {
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Furnitor�t";
                MbushGride("");
            }
            else
            {
                string s = "WHERE ";
                string strDesc = "";
                bool check1 = false;
                if (cbEmri.Checked == true)
                {
                    s += "EMRI LIKE '" + txtEmriKerkim.Text + "%' ";
                    strDesc = "Furnitor�t me em�r " + txtEmriKerkim.Text;
                    check1 = true;
                }
                if (cbMbiemri.Checked == true)
                {
                    if (check1)
                    {
                        s += "AND MBIEMRI LIKE '" + txtMbiemriKerkim.Text + "%' ";
                        strDesc += ", mbiem�r" + txtMbiemriKerkim.Text;
                    }
                    else
                    {
                        s += "MBIEMRI LIKE '" + txtMbiemriKerkim.Text + "%' ";
                        strDesc = "Furnitor�t me mbiem�r " + txtMbiemriKerkim.Text;
                        check1 = true;
                    }
                }
                if (cbAdresa.Checked == true)
                {
                    if (check1)
                    {
                        s += "AND ADRESA LIKE '" + this.txtAdresaKerkim.Text + "%' ";
                        strDesc += ", adres�" + txtAdresaKerkim.Text;
                    }
                    else
                    {
                        s += "ADRESA LIKE '" + txtAdresaKerkim.Text + "%' ";
                        strDesc = "Furnitor�t me adres�" + txtAdresaKerkim.Text;
                        check1 = true;
                    }
                }
                MbushGride(s);
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + strDesc;
            }
            gridFurnitoret.Visible = true;
            uiTabModifiko.Visible = false;
            AktivizoPanel(panelTop);
            Pastro();
        }

        private void BllokoKerkimin()
        {
            this.txtEmriKerkim.Text = "";
            this.txtEmriKerkim.Enabled = false;
            this.txtEmriKerkim.BackColor = Color.White;

            this.txtMbiemriKerkim.Text = "";
            this.txtMbiemriKerkim.Enabled = false;
            this.txtMbiemriKerkim.BackColor = Color.White;

            this.txtAdresaKerkim.Text = "";
            this.txtAdresaKerkim.Enabled = false;
            this.txtAdresaKerkim.BackColor = Color.White;
        }

        private void cbEmri_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbEmri.Checked == true)
            {
                this.txtEmriKerkim.Text = "";
                this.txtEmriKerkim.Enabled = true;
            }
            else
            {
                this.txtEmriKerkim.Text = "";
                this.txtEmriKerkim.Enabled = false;
                this.txtEmriKerkim.BackColor = Color.White;

            }
        }

        private void cbMbiemri_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbMbiemri.Checked == true)
            {
                this.txtMbiemriKerkim.Text = "";
                this.txtMbiemriKerkim.Enabled = true;
            }
            else
            {
                this.txtMbiemriKerkim.Text = "";
                this.txtMbiemriKerkim.Enabled = false;
                this.txtMbiemriKerkim.BackColor = Color.White;

            }
        }

        private void cbAdresa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbAdresa.Checked == true)
            {
                this.txtAdresaKerkim.Text = "";
                this.txtAdresaKerkim.Enabled = true;
            }
            else
            {
                this.txtAdresaKerkim.Text = "";
                this.txtAdresaKerkim.Enabled = false;
                this.txtAdresaKerkim.BackColor = Color.White;

            }
        }

        private void btnFshiArtikull_Click(object sender, EventArgs e)
        {
            DataSet dsId = new DataSet();
            dsId.Tables.Add();
            dsId.Tables[0].Columns.Add("ID_FURNITORI", typeof(Int32));
            dsId.Tables[0].Columns.Add("EMRI", typeof(String));
            dsId.Tables[0].Columns.Add("MBIEMRI", typeof(String));
            dsId.AcceptChanges();
            for (int i = 0; i < gridFurnitoret.RowCount; i++)
            {
                if (gridFurnitoret.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    DataRow r = dsId.Tables[0].NewRow();
                    r["ID_FURNITORI"] = Convert.ToInt32(gridFurnitoret.GetRow(i).Cells["ID_FURNITORI"].Text);
                    r["EMRI"] = gridFurnitoret.GetRow(i).Cells["EMRI"].Text;
                    r["MBIEMRI"] = gridFurnitoret.GetRow(i).Cells["MBIEMRI"].Text;
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
                DataSet dsError = data.KerkesaRead("FshiFurnitoret", dsId, llojiFshirje);
                if (Convert.IsDBNull(dsError))
                {
                    MessageBox.Show(this, "Nj� gabim ndodhi gjat� fshirjes s� furnitor�ve!" + Environment.NewLine +
                        "Provoni p�rs�ri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //jane fshire te gjithe furnitoret dhe gjate fshirjes
                //nuk ka patur konflikte
                if (dsError.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(this, "Furnitor�t e zgjedhur u fshin�.",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (llojiFshirje == "FshiTeGjithe")
                    {
                        string s = "P�r furnitoret e m�posht�m rezultoi t� kishte blerje t� regjitruara.";
                        s += Environment.NewLine + "Sipas konfirmimit referencat p�rkatese t� blerjeve u fshin�.";
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
                        string s = "P�r furnitoret e m�posht�m rezultoi t� kishte blerje t� regjitruara.";
                        s += Environment.NewLine + "Sipas konfirmimit k�ta furnitor� nuk u fshin�.";
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
            int index = gridFurnitoret.Row;
            if (index >= 0)
            {
                Ploteso(index);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            if (gridFurnitoret.RowCount > 0)
            {
                gridFurnitoret.Row = 0;
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            if ((gridFurnitoret.Row >= 1) && (gridFurnitoret.Row - 1 >= 0))
            {
                gridFurnitoret.Row = gridFurnitoret.Row - 1;
            }
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            if ((gridFurnitoret.Row <= gridFurnitoret.RowCount - 2) && (gridFurnitoret.Row + 1 >= 0))
            {
                gridFurnitoret.Row = gridFurnitoret.Row + 1;
            }
        }

        private void btnFundit_Click(object sender, EventArgs e)
        {
            if ((gridFurnitoret.RowCount > 0) && (gridFurnitoret.RowCount - 1 >= 0))
            {
                gridFurnitoret.Row = gridFurnitoret.RowCount - 1;
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
                Janus.Windows.GridEX.GridEXFilterCondition(gridFurnitoret.RootTable.Columns["EMRI"], operatori, tekst);
            gridFurnitoret.Find(kusht, 0, -1);

        }

        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridFurnitoret.RowCount != 0)
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
            fushat[2] = "Telefoni";
            fushat[3] = "Email";
            fushat[4] = "Adresa";

            key[0] = "EMRI";
            key[1] = "MBIEMRI";
            key[2] = "TELEFONI";
            key[3] = "EMAILI";
            key[4] = "ADRESA";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "char(255)";
            llojet[3] = "char(255)";
            llojet[4] = "char(255)";

            KlaseExcel excel = new KlaseExcel("Furnitoret.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGride("Furnitoret.xls", gridFurnitoret, fushat,
                    key, llojet, "EMRI");

            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua n� skedarin " + excel.excelPath + "\\" +
                    "Furnitoret.xls!", "Konvertimi n� Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (gridFurnitoret.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion
    
    
    }
}