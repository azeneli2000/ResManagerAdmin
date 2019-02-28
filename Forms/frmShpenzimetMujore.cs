using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using ResManagerAdmin.BusDatService;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmShpenzimetMujore : System.Windows.Forms.Form, IPrintable
    {

        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        public frmShpenzimetMujore()
        {
            InitializeComponent();
        }


        #region PrivateMethods

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

        private void BllokoKerkimin()
        {
            this.cboVitiKerkimi.Enabled = false;
            this.cboVitiKerkimi.SelectedIndex = -1;
            this.cboVitiKerkimi.BackColor = Color.White;

            this.cboMuajiKerkimi.Enabled = false;
            this.cboMuajiKerkimi.SelectedIndex = -1;
            this.cboMuajiKerkimi.BackColor = Color.White;

            this.cboKategoriaKerkimi.Enabled = false;
            this.cboKategoriaKerkimi.Text = "";
            this.cboKategoriaKerkimi.BackColor = Color.White;
        }

        private void MbushKomboViti()
        {
            this.cboViti.Items.Add("2000");
            this.cboViti.Items.Add("2001");
            this.cboViti.Items.Add("2002");
            this.cboViti.Items.Add("2003");
            this.cboViti.Items.Add("2004");
            this.cboViti.Items.Add("2005");
            this.cboViti.Items.Add("2006");
            this.cboViti.Items.Add("2007");
            this.cboViti.Items.Add("2008");
            this.cboViti.Items.Add("2009");
            this.cboViti.Items.Add("2010");
            this.cboViti.Items.Add("2011");
            this.cboViti.Items.Add("2012");
            this.cboViti.Items.Add("2013");
            this.cboViti.Items.Add("2014");
            this.cboViti.Items.Add("2015");
            this.cboViti.Items.Add("2016");
            this.cboViti.Items.Add("2017");
            this.cboViti.Items.Add("2018");
            this.cboViti.Items.Add("2019");
            this.cboViti.Items.Add("2020");
            this.cboViti.Items.Add("2021");
            this.cboViti.Items.Add("2022");
            this.cboViti.Items.Add("2023");
            this.cboViti.Items.Add("2024");
            this.cboViti.Items.Add("2025");
            this.cboViti.Items.Add("2026");
            this.cboViti.Items.Add("2027");
            this.cboViti.Items.Add("2028");
            this.cboViti.Items.Add("2029");
            this.cboViti.Items.Add("2030");

            this.cboVitiKerkimi.Items.Add("2000");
            this.cboVitiKerkimi.Items.Add("2001");
            this.cboVitiKerkimi.Items.Add("2002");
            this.cboVitiKerkimi.Items.Add("2003");
            this.cboVitiKerkimi.Items.Add("2004");
            this.cboVitiKerkimi.Items.Add("2005");
            this.cboVitiKerkimi.Items.Add("2006");
            this.cboVitiKerkimi.Items.Add("2007");
            this.cboVitiKerkimi.Items.Add("2008");
            this.cboVitiKerkimi.Items.Add("2009");
            this.cboVitiKerkimi.Items.Add("2010");
            this.cboVitiKerkimi.Items.Add("2011");
            this.cboVitiKerkimi.Items.Add("2012");
            this.cboVitiKerkimi.Items.Add("2013");
            this.cboVitiKerkimi.Items.Add("2014");
            this.cboVitiKerkimi.Items.Add("2015");
            this.cboVitiKerkimi.Items.Add("2016");
            this.cboVitiKerkimi.Items.Add("2017");
            this.cboVitiKerkimi.Items.Add("2018");
            this.cboVitiKerkimi.Items.Add("2019");
            this.cboVitiKerkimi.Items.Add("2020");
            this.cboVitiKerkimi.Items.Add("2021");
            this.cboVitiKerkimi.Items.Add("2022");
            this.cboVitiKerkimi.Items.Add("2023");
            this.cboVitiKerkimi.Items.Add("2024");
            this.cboVitiKerkimi.Items.Add("2025");
            this.cboVitiKerkimi.Items.Add("2026");
            this.cboVitiKerkimi.Items.Add("2027");
            this.cboVitiKerkimi.Items.Add("2028");
            this.cboVitiKerkimi.Items.Add("2029");
            this.cboVitiKerkimi.Items.Add("2030");
        }

        private void MbushKomboMuaji()
        {
            this.cboMuaji.Items.Add("Janar");
            this.cboMuaji.Items.Add("Shkurt");
            this.cboMuaji.Items.Add("Mars");
            this.cboMuaji.Items.Add("Prill");
            this.cboMuaji.Items.Add("Maj");
            this.cboMuaji.Items.Add("Qershor");
            this.cboMuaji.Items.Add("Korrik");
            this.cboMuaji.Items.Add("Gusht");
            this.cboMuaji.Items.Add("Shtator");
            this.cboMuaji.Items.Add("Tetor");
            this.cboMuaji.Items.Add("Nentor");
            this.cboMuaji.Items.Add("Dhjetor");

            this.cboMuajiKerkimi.Items.Add("Janar");
            this.cboMuajiKerkimi.Items.Add("Shkurt");
            this.cboMuajiKerkimi.Items.Add("Mars");
            this.cboMuajiKerkimi.Items.Add("Prill");
            this.cboMuajiKerkimi.Items.Add("Maj");
            this.cboMuajiKerkimi.Items.Add("Qershor");
            this.cboMuajiKerkimi.Items.Add("Korrik");
            this.cboMuajiKerkimi.Items.Add("Gusht");
            this.cboMuajiKerkimi.Items.Add("Shtator");
            this.cboMuajiKerkimi.Items.Add("Tetor");
            this.cboMuajiKerkimi.Items.Add("Nentor");
            this.cboMuajiKerkimi.Items.Add("Dhjetor");
           

        }

        private void StartoKomboViti()
        {
            string viti = System.DateTime.Today.Year.ToString();
            int indeksiViti = Convert.ToInt32(viti.Substring(2, 2));

            this.cboViti.SelectedIndex = indeksiViti;
        }

        private void StartoKomboKerkimiViti()
        {
            string viti = System.DateTime.Today.Year.ToString();
            int indeksiViti = Convert.ToInt32(viti.Substring(2, 2));

            this.cboVitiKerkimi.SelectedIndex = indeksiViti;
        }

        private void StartoKomboMuaji()
        {
            int indeksiMuaji = System.DateTime.Today.Month;
            this.cboMuaji.SelectedIndex = indeksiMuaji - 1;
            
        }

        private void StartoKomboKerkimiMuaji()
        {
            int indeksiMuaji = System.DateTime.Today.Month;
            this.cboMuajiKerkimi.SelectedIndex = indeksiMuaji - 1;

        }

        private void MbushKomboKatShpenzimetMujore()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriShpenzimeshMujore");

            if (ds == null)
            {
                return;
            }

            this.cboKategoria.DataSource = ds.Tables[0];
            this.cboKategoriaKerkimi.DataSource = ds.Tables[0];
            
        }

        private void MbushGridenShpenzimeMujore()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqShpenzimetMujore");

            if (ds == null)
            {
                return;
            }

            this.grida.DataSource = ds.Tables[0];

            this.lblKerkimi.Text = "Shpenzimet mujore per muajin korent :";
        }


        #endregion

        private void btnShto_Click(object sender, EventArgs e)
        {
            this.StartoKomboMuaji();
            this.StartoKomboViti();
            this.cboKategoria.Text = "";
            numVlera.Value = 0;
            this.txtKomenti.Clear();

            this.grida.Visible = false;
            this.tabi.Visible = true;
            this.tabpage.Text = "Shtim";
            this.tabpage.Image = ResManagerAdmin.Properties.Resources.news_info;
            this.CaktivizoPanel(panelTop);
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void frmShpenzimetMujore_Load(object sender, EventArgs e)
        {
            this.LexoInformacione();

            this.MbushKomboViti();
            this.MbushKomboMuaji();

            this.StartoKomboViti();
            this.StartoKomboMuaji();

            this.MbushGridenShpenzimeMujore();

            this.BllokoKerkimin();

            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = grida;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;

        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (this.KaGabim() == true)
            {
                return;
            }

            int viti = Convert.ToInt32(this.cboViti.Text);
            int muaji = this.cboMuaji.SelectedIndex + 1;
            int kategoria = Convert.ToInt32(this.cboKategoria.Value);
            double vlera = Convert.ToDouble(numVlera.Value);
            string komenti = this.txtKomenti.Text;

            InputController data = new InputController();
            int b = 0;

            string veprimi = this.tabpage.Text.Trim();

            switch (veprimi)
            {
                case "Shtim" :

                    b = data.KerkesaUpdate("KrijoShpenzimMujor", kategoria, muaji, viti, vlera, komenti);

                    if (b == 1)
                    {
                        MessageBox.Show("Nje gabim ndodhi gjate aksesimit te bazes se te dhenave!" + Environment.NewLine + "Ju lutemi, provoni perseri!", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (b == 2)
                    {
                        MessageBox.Show("Per vitin, muajin dhe kategorine e zgjedhur eshte hedhur shpenzimi mujor." + Environment.NewLine + "Ju vetem mund ta modifikoni ate." , "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    break;

                case "Modifikim" :

                    int indeksi = this.grida.Row;
                    int idShpenzimiMujor = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);

                    b = data.KerkesaUpdate("ModifikoShpenzimMujor", idShpenzimiMujor, vlera, komenti);

                    if (b == 1)
                    {
                        MessageBox.Show("Nje gabim ndodhi gjate aksesimit te bazes se te dhenave!" + Environment.NewLine + "Ju lutemi, provoni perseri!", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;

                default :
                    break;
            }

            this.MbushGridenShpenzimeMujore();
            this.grida.Visible = true;
            this.tabi.Visible = false;
            this.AktivizoPanel(panelTop);

            this.StartoKomboMuaji();
            this.StartoKomboViti();
            this.cboKategoria.Text = "";
            numVlera.Value = 0;
            this.txtKomenti.Clear();

        }

        private bool KaGabim()
        {
            if (this.cboViti.Text == "")
            {
                MessageBox.Show("Ju duhet te zgjidhni vitin e shpenzimit mujor.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;

            }

            if (this.cboMuaji.Text == "")
            {
                MessageBox.Show("Ju duhet te zgjidhni muajin e shpenzimit mujor.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (this.cboKategoria.Text == "")
            {
                MessageBox.Show("Ju duhet te zgjidhni kategorine e shpenzimit mujor.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (numVlera.Value == 0)
            {
                MessageBox.Show("Vlera e shpenzimit mujor nuk mund të jetë 0!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }            
            return false;
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.grida.Visible = true;
            this.tabi.Visible = false;
            this.AktivizoPanel(panelTop);

            this.StartoKomboMuaji();
            this.StartoKomboViti();
            this.cboKategoria.Text = "";
            numVlera.Value = 0;
            this.txtKomenti.Clear();

            this.cboMuaji.Enabled = true;
            this.cboViti.Enabled = true;
            this.cboKategoria.Enabled = true;
        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;

            if (indeksi < 0)
            {
                return;
            }

            int muaji = Convert.ToInt32(this.grida.GetRow(indeksi).Cells["MUAJI"].Text);
            this.cboMuaji.SelectedIndex = muaji - 1;

            this.cboMuaji.Enabled = false;
            this.cboMuaji.BackColor = Color.White;

            string viti = Convert.ToString(this.grida.GetRow(indeksi).Cells["VITI"].Text).Trim();
            int indeksiViti = Convert.ToInt32(viti.Substring(2, 2));
            this.cboViti.SelectedIndex = indeksiViti;
            this.cboViti.Enabled = false;
            this.cboViti.BackColor = Color.White;

            int idKatShpenzimi = Convert.ToInt32(this.grida.GetRow(indeksi).Cells["ID_KATSHPENZIMIMUJOR"].Text);
            this.cboKategoria.Value = idKatShpenzimi;
            this.cboKategoria.Enabled = false;
            this.cboKategoria.BackColor = Color.White;

            double vlera = Convert.ToDouble(this.grida.GetRow(indeksi).Cells["VLERA"].Text);
            numVlera.Value = Convert.ToDecimal(vlera);

            string komenti = Convert.ToString(this.grida.GetRow(indeksi).Cells["KOMENTI"].Text);
            this.txtKomenti.Text = komenti;
            
            this.tabpage.Text = "Modifikim";
            this.tabpage.Image = ResManagerAdmin.Properties.Resources.news_info;
            this.CaktivizoPanel(panelTop);
            this.tabi.Visible = true;
            this.grida.Visible = false;
            
        }

        private void chkViti_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkViti.Checked == true)
            {
                this.cboVitiKerkimi.Enabled = true;
                this.StartoKomboKerkimiViti();
            }
            else
            {
                this.cboVitiKerkimi.Enabled = false;
                this.cboVitiKerkimi.SelectedIndex = -1;
                this.cboVitiKerkimi.BackColor = Color.White;
            }
        }

        private void chkMuaji_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkMuaji.Checked == true)
            {
                this.cboMuajiKerkimi.Enabled = true;
                this.StartoKomboKerkimiMuaji();
            }
            else
            {
                this.cboMuajiKerkimi.Enabled = false;
                this.cboMuajiKerkimi.SelectedIndex = -1;
                this.cboMuajiKerkimi.BackColor = Color.White;
            }
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            if (this.KaGabimeKerkimi() == true)
            {
                return;
            }

            string strSql = "SELECT ID_SHPENZIMIMUJOR, SP.ID_KATSHPENZIMIMUJOR, CSHPENZIMI, MUAJI, VITI, VLERA, KOMENTI " +
                            "FROM SHPENZIMET_MUJORE AS SP INNER JOIN KATEGORIA_SHPENZIMIMUJOR AS K ON SP.ID_KATSHPENZIMIMUJOR = K.ID_KATSHPENZIMIMUJOR ";

            string kushti = "";
            string titulli = "Shpenzimet mujore per ";

            int zgjedhja = 0;
            int viti = 0;
            int muaji = 0;
            string kategoria = "";

            if (this.chkViti.Checked == true)
            {
                viti = Convert.ToInt32(this.cboVitiKerkimi.Text);

                if (zgjedhja == 0)
                {
                    kushti = "WHERE VITI = " + viti;
                    titulli = titulli + "vitin " + viti.ToString() + " ";

                }
                else
                {
                    kushti = " AND VITI = " + viti;
                    titulli = titulli + ", vitin " + viti.ToString() + " ";
                }

                zgjedhja = zgjedhja + 1;
            }

            if (this.chkMuaji.Checked == true)
            {
                muaji = this.cboMuajiKerkimi.SelectedIndex + 1;
                string strMuaji = this.cboMuajiKerkimi.Text;

                if (zgjedhja == 0)
                {
                    kushti = "WHERE MUAJI = " + muaji;
                    titulli = titulli + "muajin " + strMuaji + " ";
                }
                else
                {
                    kushti = " AND MUAJI = " + muaji;
                    titulli = titulli + ", muajin " + strMuaji + " ";
                }

                zgjedhja = zgjedhja + 1;
            }

            if (this.chkKategoria.Checked == true)
            {
                int idKatShpenzimiMujor = Convert.ToInt32(this.cboKategoriaKerkimi.Value);
                kategoria = this.cboKategoriaKerkimi.Text;

                if (zgjedhja == 0)
                {
                    kushti = "WHERE SP.ID_KATSHPENZIMIMUJOR = " + idKatShpenzimiMujor;
                    titulli = titulli + "kategorine " + kategoria + " ";
                }
                else
                {
                    kushti = " AND SP.ID_KATSHPENZIMIMUJOR = " + idKatShpenzimiMujor;
                    titulli = titulli + ", kategorine " + kategoria + " ";
                }

                zgjedhja = zgjedhja + 1;
            }

            if (zgjedhja > 0)
            {
                strSql = strSql + kushti;
                this.lblKerkimi.Text = titulli;
            }
            else
            {
                return;
            }

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqShpenzimetMujoreSipasKerkimit", strSql);

            if (ds == null)
            {
                MessageBox.Show("Ju nuk arrini te lidheni me bazen e të dhenave!", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.grida.DataSource = ds.Tables[0];
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + titulli;

            
            


        }

        private bool KaGabimeKerkimi()
        {
            int zgjidh = 0;

            if (this.chkViti.Checked == true )
            {
                if (this.cboVitiKerkimi.Text == "")
                {
                    MessageBox.Show("Ju duhet te zgjidhni vitin e kerkimit!", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else
                {
                    zgjidh = zgjidh + 1;
                }
            }

            if (this.chkMuaji.Checked == true)
            {
                if (this.cboMuajiKerkimi.Text == "")
                {
                    MessageBox.Show("Ju duhet te zgjidhni muajin e kerkimit!", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else
                {
                    zgjidh = zgjidh + 1;
                }
            }

            if (this.chkKategoria.Checked == true)
            {
                if (this.cboKategoriaKerkimi.Text == "")
                {
                    MessageBox.Show("Ju duhet te zgjidhni kategorine e shpenzimit mujor!", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else
                {
                    zgjidh = zgjidh + 1;
                }
            }

            if (zgjidh == 0)
            {
                return true;
            }

            return false;
        }

        private void CaktivizoKerkimin()
        {
            this.cboVitiKerkimi.Enabled = false;
            this.cboVitiKerkimi.SelectedIndex = -1;
            this.cboVitiKerkimi.BackColor = Color.White;

            this.cboMuajiKerkimi.Enabled = false;
            this.cboMuajiKerkimi.SelectedIndex = -1;
            this.cboMuajiKerkimi.BackColor = Color.White;

            this.cboKategoriaKerkimi.Enabled = false;
            this.cboKategoriaKerkimi.Text = "";
            this.cboKategoriaKerkimi.BackColor = Color.White;


        }

        private void chkKategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkKategoria.Checked == true)
            {
                this.cboKategoriaKerkimi.Enabled = true;
            }
            else
            {
                this.cboKategoriaKerkimi.Enabled = false;
                this.cboKategoriaKerkimi.Text = "";
                this.cboKategoriaKerkimi.BackColor = Color.White;
            }
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
            string[] fushat = new string[5];
            string[] llojet = new string[5];
            string[] key = new string[5];
            fushat[0] = "Viti";
            fushat[1] = "Muaji";
            fushat[2] = "Kategoria_e_shpenzimit";
            fushat[3] = "Vlera";
            fushat[4] = "Komenti";

            key[0] = "VITI";
            key[1] = "MUAJISTR";
            key[2] = "CSHPENZIMI";
            key[3] = "VLERA";
            key[4] = "KOMENTI";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "char(255)";
            llojet[3] = "float";
            llojet[4] = "char(255)";

            KlaseExcel excel = new KlaseExcel("ShpenzimetMujore.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("ShpenzimetMujore.xls", grida, fushat, key, llojet,
                    "VITI");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "ShpenzimetMujore.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmShpenzimetMujore_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            this.MbushKomboKatShpenzimetMujore();

        }


    }
}