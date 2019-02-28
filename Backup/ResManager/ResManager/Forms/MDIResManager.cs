using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using Janus.Windows.ExplorerBar;
using DevComponents.DotNetBar;
using ResManagerAdmin.BusDatService;
using ResManager.Forms;

namespace ResManager.Forms
{
    public partial class MDIResManager : Form
    {
        private int childFormNumber = 0;
        public static int idPerdoruesi = 0;
        public static string emerPerdoruesi = "";
        public static string mbiemerPerdoruesi = "";
        public static string perdoruesi = "";
        public static string fjalekalimi = "";
        public bool anullo = false;
        private bool done = false;
        private int idTavolina;
        private DataSet dsFatura = null;
        private DataSet dsFatOfertat = null;
        private DataSet dsRecetat = null;
        private DataSet dsTavolinat = null;
        private int fatura = 0;
        private int idTavolinaZgjedhur;
        private string nrTavolinaZgjedhur = "";
        private string printNrFatura = "";
        private string[] printArtikujt = null;
        private string[] printCmimet = null;
        private string[] printSasite = null;
        private string[] printVlerat = null;
        private string printTotali = "";
        private string printBari = "";
        private string printTavolina = "";
        private string printUser = "";
        private string printData = "";
        private string printOra = "";

        private int[] idRecetat = new int[10];
        private string[] emratRecetat = new string[10];
        private int nrFavorite = 0;

        private string gjendjaZgjedhur = "";
        private string strKam = "1";


        /// <summary>
        /// konfigurimet
        /// </summary>
        private int printModeli = 3;
        private int modeTavolinat = 0;
        private string strOferta = "1";
        private string strMinus = "";


        private int idFaturaOld = 0;
        private int idFaturaNew = 0;
        private int nrOfertat = 0;



        private DataSet dsUsers = null;
        private DataSet dsPrinterBanaku = null;
        private DataSet dsPrinterTavolina = null;

        private DataSet dsPrinterRecete = null;
        private DataSet dsPrinters = null;

        private DataSet dsPrintimi = null;

        private DataSet dsKategoriteMenu = null;
        private DataSet dsRecetatMenu = null;
        private int nrKatMenu = 0;
        private int nrRecMenu = 0;


        private DataSet dsBanaku = new DataSet();
        private DataSet dsArtikujtBanaku = null;

        


        #region MDIParent
        public MDIResManager()
        {
            frmLogin.ShowForm();
            idPerdoruesi = frmLogin.idPerdoruesi;
            emerPerdoruesi = frmLogin.emerPerdoruesi;
            mbiemerPerdoruesi = frmLogin.mbiemerPerdoruesi;
            perdoruesi = frmLogin.perdoruesi;
            fjalekalimi = frmLogin.fjalekalimi;
            if (idPerdoruesi == -1)
            {
                anullo = true;
                this.Close();
                return;
            }
            
            //Vendosim kulturen e aplikacionit
            //System.Globalization.CultureInfo MyCulture = System.Globalization.CultureInfo.CreateSpecificCulture("sq-Al");
            //MyCulture.DateTimeFormat.LongDatePattern = "dd-MM-yyyy";
            //MyCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            //MyCulture.NumberFormat.CurrencyDecimalDigits = 2;
            //Application.CurrentCulture = MyCulture;
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: Add code here to open the file.
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }
        #endregion

        #region MenuEventHandlers
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ResManager.Forms.AboutBox1 aboutForm = new AboutBox1();
            //aboutForm.ShowDialog();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            uiTabPagePersoneli.Text = "Merr turnin";
            btnKonfirmoFjalekalim.Visible = false;
            this.Kerko();
            uiTabPagePersoneli.TabVisible = true;
            uiTabPageTavolinat.TabVisible = false;
            uiTabPagePorosi.TabVisible = false;
            uiTabPagePersoneli.Enabled = true;

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            uiTabPagePersoneli.Text = "Mbyll turnin";
            btnKonfirmoFjalekalim.Visible = false;
            this.Kerko(); 
            uiTabPagePersoneli.TabVisible = true;
            uiTabPageTavolinat.TabVisible = false;
            uiTabPagePorosi.TabVisible = false;
        }

        private void modifikoFjalëkalimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            uiTabPagePersoneli.Text = "Modifiko fjalëkalimin";
            this.Kerko(); 
            btnKonfirmoFjalekalim.Visible = true;
            uiTabPagePersoneli.TabVisible = true;
            uiTabPageTavolinat.TabVisible = false;
            uiTabPagePorosi.TabVisible = false;
        }
        private void tëPreferuaritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFavorites frm = new frmFavorites();
            frm.Location = new Point(235,100);
            frm.ShowDialog();
        }
        #endregion

        #region Load
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            try
            {

                this.dsUsers = this.KrijoDsKamarieret();

                DataRow r = this.dsUsers.Tables[0].NewRow();
                r["ID_PERSONELI"] = idPerdoruesi;
                r["PERDORUESI"] = perdoruesi;
                r["FJALEKALIMI"] = fjalekalimi;

                dsUsers.Tables[0].Rows.Add(r);
                dsUsers.AcceptChanges();

                this.printUser = perdoruesi;

                this.uiTab.BringToFront();
                //gridEXBashke.Size = new Size(545, 568);
                this.exArtikujt.Dock = DockStyle.Left;
                this.exBarFavorite.Dock = DockStyle.Left;

                this.dsKategoriteMenu = this.KrijoDsKatMenu();
                this.dsRecetatMenu = this.KrijoDsRecetatMenu();

                this.MbushEksplorerBar1();
                this.dsTavolinat = this.KrijoDataSetTavolinat();
                this.MbushTavolina();
                this.KtheInformacionPerBarin();
                this.LexoXml();
                this.LexoXmlKonfigurime();

                this.dsPrinterBanaku = this.KrijoDataSetZgjidh();
                this.dsPrinterTavolina = this.KrijoDataSetZgjidh();

                this.dsArtikujtBanaku = this.KrijoDsArtikujtBanaku();
                this.MbushGridenArtikujtFirst();
                if (File.Exists("C:\\Program Files\\VisionInfoSolution\\RestaurantManager\\Raportet\\Banaku.xml"))
                {
                    this.dsBanaku.ReadXml("C:\\Program Files\\VisionInfoSolution\\RestaurantManager\\Raportet\\Banaku.xml");
                    this.NgarkoTeDhenat();
                }

                this.LexoXmlPrinterat();

                this.dsPrinterRecete = this.KrijoDataSetPrinterRecete();
                this.LexoXmlPrinterRecete();

                this.dsPrinters = this.KrijoDataSetPrinter();

                this.dsPrintimi = this.KrijoDsPrintimi();

                if (this.strOferta == "0")
                {
                    this.btnShtoOferte.Visible = false;
                    this.btnFshiOferte.Visible = false;
                }
                else
                {
                    this.btnShtoOferte.Visible = true;
                    this.btnFshiOferte.Visible = true;
                }

                this.btnShtoOferte.Visible = false;
                this.btnFshiOferte.Visible = false;
                
                
                this.PercaktoFirstIdTavolina();

                if (this.modeTavolinat == 0)
                {
                    this.OpenModeOneTable();
                }
                else
                {
                    this.PercaktoViewTables();
                }
                
                
                //this.txtNrTavolina.Visible = false;
                //this.txtNrTavolina.Visible = true;
                //this.txtNrTavolina.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text);
            }
        }

        /// <summary>
        /// Eshte metode qe do perderot vetem per baret qe perdorin nje tavoline
        /// </summary>
        /// <returns></returns>
        private void PercaktoFirstIdTavolina()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTavolinatDetaje");

            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                this.idTavolina = 1;
            }
            else
            {
                this.idTavolina = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_TAVOLINA"]);
            }

            this.gridaFatura.DataSource = null;
            this.dsFatura = null;
            dsFatura = this.KrijoDataSet();
            this.gridaFatura.DataSource = dsFatura.Tables[0];

            
        }

        private void PercaktoViewTables()
        {
            this.uiTab.Visible = false;
            this.exBarFavorite.Visible = false;
            this.exArtikujt.Visible = false;

            //uiTabPagePorosi.TabVisible = false;

            this.uiTab.Location = new Point(0, 24);
            this.uiTab.Size = new Size(1020, 700);
            this.uiTab.Visible = true;
            this.txtNrTavolina.Text = "";
            this.txtNrTavolina.Visible = true;
            this.txtNrTavolina.Focus();
            
            this.txtNrTavolina.Focus();
            
        }

        private void PercaktoViewFatura()
        {
            this.PastroEkstrat();

            this.uiTab.Visible = false;
            this.exBarFavorite.Visible = true;
            this.exArtikujt.Visible = false;
            this.exBarFavorite.Groups[0].Expanded = false;
            this.exBarFavorite.Groups[1].Expanded = true;
            this.txtNrTavolina.Visible = false;
            uiTabPageTavolinat.TabVisible = false;
            uiTabPagePorosi.TabVisible = true;

            this.uiTab.Location = new Point(234, 24);
            this.uiTab.Size = new Size(790, 700);
            

            this.uiTab.Visible = true;
            this.gridaFatura.Focus();
           
           
        }

        private void MbushEksplorerBar1()
        {
            this.MbushFavorite();
            ///this.MbushKategoriArtikujsh();
            this.MbushKategoriRecetash();
        }

        #endregion

        #region explorerBarEventHandlers
       


        private void explorerBar1_GroupClick(object sender, Janus.Windows.ExplorerBar.GroupEventArgs e)
        {
            string s = e.Group.Key;
            switch (s)
            {
                case "Favorites":
                    //this.exBarFavorite.Groups["Artikuj"].Expanded = false;
                    this.exBarFavorite.Groups["Receta"].Expanded = false;
                    break;
                case "Artikuj":
                    this.exBarFavorite.Groups["Favorites"].Expanded = false;
                    this.exBarFavorite.Groups["Receta"].Expanded = false;
                    break;
                case "Receta":
                    this.exBarFavorite.Groups["Favorites"].Expanded = false;
                    //this.exBarFavorite.Groups["Artikuj"].Expanded = false;
                    break;
            }
        }

        private void explorerBar2_GroupClick_1(object sender, Janus.Windows.ExplorerBar.GroupEventArgs e)
        {
            string grupi = e.Group.Key;
            if (grupi == "Kthehu")
            {
                this.exArtikujt.Hide();
                //this.explorerBar1.Dock = DockStyle.Left;
                //this.explorerBar2.Dock = DockStyle.None;
                this.exBarFavorite.Show();
            }
        }
        private void explorerBar2_ItemClick(object sender, Janus.Windows.ExplorerBar.ItemEventArgs e)
        {

        }

        private void MbushArtikujt()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqArtikujtSipasKategorive");
        }
        #endregion

        #region Menyrat e faturimit
        private void rbBashke_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbBashke.Checked == true)
            //{
            //    //gridEXBashke.Show();
            //    gridaFatura.Show();
            //    panelButona.Hide();
            //    panelTavolina.Hide();
            //}
            //else
            //{
            //    this.gridEXBashke.Hide();
            //    gridaFatura.Show();
            //    panelButona.Show();
            //    panelTavolina.Show();
            //}
        }

        private void rbNdare_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbBashke.Checked == true)
            //{
            //    //gridEXBashke.Show();
            //    gridaFatura.Show();
            //    panelButona.Hide();
            //    panelTavolina.Hide();
            //}
            //else
            //{
            //    this.gridEXBashke.Hide();
            //    gridaFatura.Show();
            //    panelButona.Show();
            //    panelTavolina.Show();
            //}
        }
        #endregion

        #region Mbyllja e tavolinave
        private void btnRuaj_Click(object sender, EventArgs e)
        {
           

        }

        private void btnMbyll_Click(object sender, EventArgs e)
        {
            this.gridEXBashke.Visible = false;
            this.gridaFatura.Visible = true;
            //this.panelButona.Visible = false;
            //this.panelTavolina.Visible = false;
            this.uiTabPagePorosi.TabVisible = false;
            
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
           
            
        }
        #endregion

        #region Close Form
        private void MDIResManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            //fillimisht duhet te kontrollohet nqs ka ndonje tavoline te pambyllur
            //ketu duhet te behen log out te gjithe kamarieret e loguar

            InputController data = new InputController();
            ////DataSet ds = data.KerkesaRead("KtheKamarieretLoguar");
            int b = 0;

            if (this.dsUsers.Tables[0].Rows.Count > 0)
            {
                DialogResult r = MessageBox.Show(this, "Restaurant Manager po mbyllet." +
                    Environment.NewLine + "Dëshironi të mbyllni turnin për të gjithë" +
                    Environment.NewLine + "kamarierët e loguar në këtë kompjuter?", "Restaurant Manager",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);




                if (r == DialogResult.Yes)
                {
                    //frmXhiroKamarieri frm = new frmXhiroKamarieri();
                    //frm.idKamarieri = idPerdoruesi;
                    //frm.ShowDialog();




                    b = data.KerkesaUpdate("MbyllGjitheTurnet", this.dsUsers);
                }

                b = data.KerkesaUpdate("Logout", this.dsUsers);
            }
        }

        private void MDIResManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Per Personelin
        #region Private Methods
        private void Kerko()
        {
            int zgjedhja = 3;
            string emri = "";
            int roli = 2;
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqPersonelinSipasZgjedhjes", zgjedhja, roli, emri);
            DataSet dsPersoneli = this.KonvertoDataSetin(ds);
            this.gridPersoneli.DataSource = dsPersoneli.Tables[0];
            FormatoGride(gridPersoneli);
        }

        private DataSet KonvertoDataSetin(DataSet ds)
        {

            DataSet dsNew = new DataSet();
            dsNew.Tables.Add();
            dsNew.Tables[0].Columns.Add("ID_PERSONELI", typeof(Int32));
            dsNew.Tables[0].Columns.Add("EMRI", typeof(String));
            dsNew.Tables[0].Columns.Add("MBIEMRI", typeof(String));
            dsNew.Tables[0].Columns.Add("TELEFONI", typeof(String));
            dsNew.Tables[0].Columns.Add("ID_ROLI", typeof(Int32));
            dsNew.Tables[0].Columns.Add("ROLI", typeof(string));
            dsNew.Tables[0].Columns.Add("PERDORUESI", typeof(String));
            dsNew.Tables[0].Columns.Add("FJALEKALIMI", typeof(String));
            dsNew.Tables[0].Columns.Add("EMAILI", typeof(String));
            dsNew.Tables[0].Columns.Add("ADRESA", typeof(String));
            dsNew.Tables[0].Columns.Add("FOTO", typeof(Image));
            dsNew.Tables[0].Columns.Add("AKTIV", typeof(string));
            dsNew.AcceptChanges();

            int idPersoneli = 0;
            string emri = "";
            string mbiemri = "";
            string telefoni = "";
            int idRoli = 0;
            string roli = "";
            string perdoruesi = "";
            string fjalekalimi = "";
            string emaili = "";
            string adresa = "";
            string pathiFoto = "";
            Image foto = null;
            bool aktiv = false;
            string aktivStr = "";

            DataRow drNew = null;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                drNew = dsNew.Tables[0].NewRow();

                idPersoneli = Convert.ToInt32(dr["ID_PERSONELI"]);
                emri = Convert.ToString(dr["EMRI"]);
                mbiemri = Convert.ToString(dr["MBIEMRI"]);
                telefoni = Convert.ToString(dr["TELEFONI"]);
                idRoli = Convert.ToInt32(dr["ID_ROLI"]);
                roli = Convert.ToString(dr["ROLI"]);
                perdoruesi = Convert.ToString(dr["PERDORUESI"]);
                fjalekalimi = Convert.ToString(dr["FJALEKALIMI"]);
                emaili = Convert.ToString(dr["EMAILI"]);
                adresa = Convert.ToString(dr["ADRESA"]);
                pathiFoto = Convert.ToString(dr["FOTO"]);
                if (pathiFoto == "")
                    foto = null;
                else
                    foto = Image.FromFile(pathiFoto);


                aktiv = Convert.ToBoolean(dr["AKTIV"]);

                if (aktiv == true)
                    aktivStr = "Po";
                else
                    aktivStr = "Jo";

                drNew["ID_PERSONELI"] = idPersoneli;
                drNew["EMRI"] = emri;
                drNew["MBIEMRI"] = mbiemri;
                drNew["TELEFONI"] = telefoni;
                drNew["ID_ROLI"] = idRoli;
                drNew["ROLI"] = roli;
                drNew["PERDORUESI"] = perdoruesi;
                drNew["FJALEKALIMI"] = fjalekalimi;
                drNew["EMAILI"] = emaili;
                drNew["ADRESA"] = adresa;
                drNew["FOTO"] = foto;
                drNew["AKTIV"] = aktivStr;

                dsNew.Tables[0].Rows.Add(drNew);
            }

            dsNew.Tables[0].AcceptChanges();

            return dsNew;
        }

        private void ShtoKarakter(System.Windows.Forms.Button btn)
        {
            string ch = btn.Name.Substring(btn.Name.Length - 1);
            txtFjalekalimi.Text = txtFjalekalimi.Text + ch;
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.RowCount <= 10)
                grid.RootTable.Columns["EMRI"].Width = 100;
            else
                grid.RootTable.Columns["EMRI"].Width = 83;
        }

        private void MbushFavorite()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqFavorite");
            int j = 0;

            string emri = "";
            string lloji = "";
            int celesi = 0;
            int gjatesiEmri = 0;
            int gjatesiStrBosh = 0;
            string strBosh = "";
            int prioriteti = 0;
            string strPrioriteti = "";
            this.exBarFavorite.Groups["FAVORITES"].Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["ID_FAVORITE"]);
                emri = Convert.ToString(dr["EMRI"]);

                lloji = Convert.ToString(dr["LLOJI"]).Trim();
                prioriteti = Convert.ToInt32(dr["PRIORITETI"]);
                prioriteti = prioriteti - 1;
                strPrioriteti = "(" + Convert.ToString(prioriteti) + ")" ;
                gjatesiEmri = emri.Trim().Length;
                ///strPrioriteti = this.KtheStringBosh(gjatesiStrBosh) + strPrioriteti;
                emri = emri + " " + strPrioriteti;
                
                ExplorerBarItem el = new ExplorerBarItem();
                el.Key = Convert.ToString(celesi);
                el.Text = emri;
                el.Height = 44;
                el.TagString = lloji;
                el.ToolTipText = emri;
               
                this.exBarFavorite.Groups[0].Items.Add(el);

                this.idRecetat[j] = celesi;
                this.emratRecetat[j] = emri;
                j = j + 1;
                
            }

            this.nrFavorite = j;
            
        }

        private string KtheStringBosh(int nr)
        {
            string str = "";

            for (int i = 0; i < nr; i++)
            {
                str = " " + str;
            }

            return str;
        }

        private void MbushKategoriArtikujsh()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEArtikujvePerMenu");

            string emri = "";
            int celesi = 0;
            this.exBarFavorite.Groups[1].Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["ID_KATEGORIAARTIKULLI"]);
                emri = Convert.ToString(dr["PERSHKRIMI"]);

                ExplorerBarItem el = new ExplorerBarItem();
                el.Key = Convert.ToString(celesi);
                el.Text = emri;
                el.Height = 40;
                el.ToolTipText = emri;

                this.exBarFavorite.Groups[1].Items.Add(el);

            }

        }

        private DataSet KrijoDsKatMenu()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_KATEGORIARECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("PERSHKRIMI", typeof(string));
            ds.Tables[0].Columns.Add("INDEKSI", typeof(Int32));

            ds.AcceptChanges();

            return ds;
        }

        private DataSet KrijoDsRecetatMenu()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("EMRI", typeof(string));
            ds.Tables[0].Columns.Add("INDEKSI", typeof(Int32));

            ds.AcceptChanges();

            return ds;
        }

        private void MbushKategoriRecetash()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteERecetavePerMenu");

            int i = 0;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                i = i + 1;

                DataRow drNew = this.dsKategoriteMenu.Tables[0].NewRow();

                drNew["ID_KATEGORIARECETA"] = dr["ID_KATEGORIARECETA"];
                drNew["PERSHKRIMI"] = dr["PERSHKRIMI"];
                drNew["INDEKSI"] = i;

                this.dsKategoriteMenu.Tables[0].Rows.Add(drNew);

            }

            this.dsKategoriteMenu.Tables[0].AcceptChanges();

            string emri = "";
            int celesi = 0;
            int indeksi = 0;
            this.exBarFavorite.Groups[1].Items.Clear();
            foreach (DataRow dr in this.dsKategoriteMenu.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["ID_KATEGORIARECETA"]);
                emri = Convert.ToString(dr["PERSHKRIMI"]);
                indeksi = Convert.ToInt32(dr["INDEKSI"]);
                if (indeksi < 13)
                {
                    ExplorerBarItem el = new ExplorerBarItem();
                    el.Key = Convert.ToString(celesi);
                    el.Text = emri;
                    el.Height = 44;
                    el.ToolTipText = emri;

                    this.exBarFavorite.Groups[1].Items.Add(el);
                }

            }

            if (i > 12)
            {
                ExplorerBarItem el = new ExplorerBarItem();
                el.Key = Convert.ToString(-10);
                el.TextAlignment = Alignment.Center;
                //el.Text = "-->";
                System.Drawing.Icon ikoni = new Icon(Application.StartupPath + "\\images\\butoni.ico");
                el.Icon = ikoni;
                el.Height = 45;
                el.ToolTipText = "Klikoni ketu per te vizualisuar kategorite e tjera" ;

                this.exBarFavorite.Groups[1].Items.Add(el);

                this.nrKatMenu = 1;
            }

        }

        private void MbushTavolina()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTavolinatDetaje");



            int[] v = new int[5];
            //v[0] numri i dhomave
            //v[1] dhomat plotesisht te lira
            //v[2] dhomat e zena
            //v[3] dhomat pjeserisht te lira
            //v[4] dhomat e rezervuara
            int numer_rreshtash = ds.Tables[0].Rows.Count;
            v[0] = numer_rreshtash;
            int id_tavolina;
            string emer_tavolina;
            string gjendja;
            int i = 0;
            int lartesi = 0;
            int gjeresi = 0;
            int hapsire = 0;
            int p1 = 0;
            int p2 = 0;
            int h_nr = 0;
            //			int v_nr = 0;
            if (numer_rreshtash <= 100)
            {
                lartesi = 20;
                gjeresi = 72;
                hapsire = 30;
                h_nr = 13;
            }
            else if (numer_rreshtash <= 221)
            {
                lartesi = 20;
                gjeresi = 60;
                hapsire = 30;
                h_nr = 13;
            }
            else
            {
                //msgbox
            }
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                id_tavolina = Convert.ToInt32(dr[0]);
                emer_tavolina = Convert.ToString(dr[1]);
                gjendja = Convert.ToString(dr[3]);
                DevComponents.DotNetBar.PanelEx btn = new DevComponents.DotNetBar.PanelEx();
                btn.Name = id_tavolina.ToString();
                btn.Text = emer_tavolina;
                btn.Tag = gjendja;

                btn.Font = new Font("ARIAL", 13);


                btn.Style.ForeColor.Color = Color.Black;

                btn.BackgroundImageLayout = ImageLayout.Center;
                btn.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Center;
                btn.Style.BackColor1.Alpha = 1;
                btn.Style.BackColor2.Alpha = 1;

                btn.Style.BackColor1.Color = Color.Transparent;
                btn.Style.BackColor2.Color = Color.Transparent;

                btn.Style.Alignment = StringAlignment.Center;
                btn.Style.LineAlignment = StringAlignment.Near;

                btn.Text = Convert.ToString(dr["EMRI"]);



                btn.Width = 74;
                btn.Height = 75;

                //p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * 35;
                //p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * 70;

                p1 = 30 + (i % h_nr) * 74;
                p2 = (i / h_nr) * 75;

                btn.Location = new System.Drawing.Point(p1, p2);


                if (gjendja == "R")
                {
                    //btn.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_rezervuar.png");
                    btn.BackgroundImage = ResManager.Properties.Resources.t_rezervuar;
                    v[4]++;
                }
                else if (gjendja == "L")
                {
                    //btn.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_lire.png");


                    btn.BackgroundImage = ResManager.Properties.Resources.t_lire;
                    v[1]++;
                }
                else if (gjendja == "Z")
                {
                    //btn.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_zene.png");

                    btn.BackgroundImage = ResManager.Properties.Resources.t_zene;
                    v[2]++;
                }

                btn.DoubleClick += new System.EventHandler(this.btn_DoubleClick);
                btn.Click += new System.EventHandler(this.btn_Click);
                this.panelImazh.Controls.Add(btn);

                DataRow drNew = this.dsTavolinat.Tables[0].NewRow();

                drNew[0] = id_tavolina;
                drNew[1] = gjendja;
                drNew[2] = emer_tavolina;

                dsTavolinat.Tables[0].Rows.Add(drNew);

                i = i + 1;
            }

            dsTavolinat.Tables[0].AcceptChanges();
			


        }
       
        #endregion



        #region Event Handlers

        private void btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                DevComponents.DotNetBar.PanelEx b = (DevComponents.DotNetBar.PanelEx)sender;
                string strIdTavolina = b.Name;
                double dTav = Convert.ToDouble(strIdTavolina);
                int idTav = Convert.ToInt32(strIdTavolina);
                string emer_tavolina = b.Text;
                this.printTavolina = emer_tavolina;
                string gjendja = "";
                this.idTavolinaZgjedhur = idTav;
                this.gjendjaZgjedhur = "Z";

                int celesi = 0;

                //foreach (DataRow dr in dsTavolinat.Tables[0].Rows)
                //{
                //    celesi = Convert.ToInt32(dr[0]);

                //    if (celesi == idTav)
                //    {
                //        gjendja = Convert.ToString(dr[1]);
                //        dr[1] = "Z";
                //    }

                //}


                //if (gjendja != "Z")
                //{

                //    InputController data = new InputController();
                //    int d = data.KerkesaUpdate("HapTavoline", idTav);
                //    b.Style.BackgroundImage = ResManager.Properties.Resources.t_zene;

                //}

                //b.BackColor = Color.Violet;

                this.gbPorosia.Text = "Porosia per tavolinen: " + emer_tavolina;
                uiTabPageTavolinat.TabVisible = false;
                uiTabPagePorosi.TabVisible = true;
                uiTab.SelectedTab = uiTab.TabPages[1];
                this.idTavolina = idTav;

                this.gridaFatura.DataSource = null;
                this.dsFatura = null;
                dsFatura = this.KrijoDataSet();
                this.gridaFatura.DataSource = dsFatura.Tables[0];

                this.PercaktoViewFatura();
            }
            catch (Exception ex)
            {

                return;
            }
            

        }

        private void btn_DoubleClick(object sender, System.EventArgs e)
        {
            //try
            //{
            //    DevComponents.DotNetBar.PanelEx b = (DevComponents.DotNetBar.PanelEx)sender;
            //    string strIdTavolina = b.Name;
            //    double dTav = Convert.ToDouble(strIdTavolina);
            //    int idTav = Convert.ToInt32(strIdTavolina);
            //    string emer_tavolina = b.Text;
            //    this.printTavolina = emer_tavolina;
            //    string gjendja = "";
            //    this.idTavolinaZgjedhur = idTav;
            //    this.gjendjaZgjedhur = "Z";

            //    int celesi = 0;

            //    foreach(DataRow dr in dsTavolinat.Tables[0].Rows)
            //    {
            //        celesi = Convert.ToInt32(dr[0]);

            //        if (celesi == idTav)
            //        {
            //            gjendja = Convert.ToString(dr[1]);
            //            dr[1] = "Z";
            //        }

            //    }

                
            //    if (gjendja != "Z")
            //    {

            //        InputController data = new InputController();
            //        int d = data.KerkesaUpdate("HapTavoline", idTav);
            //        b.Style.BackgroundImage = ResManager.Properties.Resources.t_zene;
 
            //    }

            //    //b.BackColor = Color.Violet;

            //    this.gbPorosia.Text = "Porosia per tavolinen: " + emer_tavolina;
            //    uiTabPageTavolinat.TabVisible = false;
            //    uiTabPagePorosi.TabVisible = true;
            //    uiTab.SelectedTab = uiTab.TabPages[1];
            //    this.idTavolina = idTav;

            //    this.gridaFatura.DataSource = null;
            //    this.dsFatura = null;
            //    dsFatura = this.KrijoDataSet();
            //    this.gridaFatura.DataSource = dsFatura.Tables[0];

            //    this.PercaktoViewFatura();
            //}
            //catch (Exception ex)
            //{
               
            //    return;
            //}
            
        }

        private void OpenModeOneTable()
        {
            uiTabPageTavolinat.TabVisible = false;
            uiTabPagePorosi.TabVisible = true;
            uiTab.SelectedTab = uiTab.TabPages[1];
            //this.idTavolina = 4;

            this.gridaFatura.DataSource = null;
            this.dsFatura = null;
            dsFatura = this.KrijoDataSet();
            this.gridaFatura.DataSource = dsFatura.Tables[0];
            this.idTavolinaZgjedhur = this.idTavolina;
            this.PercaktoViewFatura();
        }

        private void OpenModeManyTable()
        {
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            if (gridPersoneli.RowCount > 0)
            {
                gridPersoneli.Row = 0;
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            if ((gridPersoneli.Row >= 1) && (gridPersoneli.Row - 1 >= 0))
            {
                gridPersoneli.Row = gridPersoneli.Row - 1;
            }
        }

        private void btnPAs_Click(object sender, EventArgs e)
        {
            if ((gridPersoneli.Row <= gridPersoneli.RowCount - 2) && (gridPersoneli.Row + 1 >= 0))
            {
                gridPersoneli.Row = gridPersoneli.Row + 1;
            }
        }

        
        private void btnFundit_Click(object sender, EventArgs e) 
        
        {
            if ((gridPersoneli.RowCount > 0) && (gridPersoneli.RowCount - 1 >= 0))
            {
                gridPersoneli.Row = gridPersoneli.RowCount - 1;
            }
        }

        private void btnPastro_Click(object sender, EventArgs e)
        {
            txtFjalekalimi.Clear();
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            if (txtFjalekalimi.Text != "")
                txtFjalekalimi.Text = txtFjalekalimi.Text.Substring(0, txtFjalekalimi.Text.Length - 1);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ShtoKarakter(btn0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ShtoKarakter(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
        
            ShtoKarakter(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ShtoKarakter(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ShtoKarakter(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ShtoKarakter(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ShtoKarakter(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ShtoKarakter(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ShtoKarakter(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ShtoKarakter(btn9);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int i = gridPersoneli.Row;
            string aktiv = gridPersoneli.GetRow(i).Cells["AKTIV"].Text;
            int b = 1;
            if (uiTabPagePersoneli.Text == "Merr turnin")
            {
                if (txtFjalekalimi.Text != gridPersoneli.GetRow(i).Cells["FJALEKALIMI"].Text)
                {
                    MessageBox.Show(this, "Marrja e turnit nuk mund të kryhet." + Environment.NewLine +
                        "Fjalëkalimi nuk është i saktë.", this.uiTab.SelectedTab.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (aktiv == "Po")
                {
                    MessageBox.Show(this, "Ky kamarier është tashmë i loguar.", uiTab.SelectedTab.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //behet logimi
                    InputController data = new InputController();
                    int idPerdoruesi = Convert.ToInt32(gridPersoneli.GetRow(i).Cells["ID_PERSONELI"].Text);
                    b = data.KerkesaUpdate("Login", idPerdoruesi, 1);
                    //Shtojme kamarierin ne datasetin global
                    DataRow r = dsKamarieret.Tables[0].NewRow();
                    r["ID_PERSONELI"] = idPerdoruesi;
                    r["EMRI"] = gridPersoneli.GetRow(i).Cells["EMRI"].Text;
                    r["MBIEMRI"] = gridPersoneli.GetRow(i).Cells["MBIEMRI"].Text;
                    r["PERDORUESI"] = gridPersoneli.GetRow(i).Cells["PERDORUESI"].Text;
                    r["FJALEKALIMI"] = gridPersoneli.GetRow(i).Cells["FJALEKALIMI"].Text;
                    dsKamarieret.Tables[0].Rows.Add(r);
                    dsKamarieret.AcceptChanges();
                }

            }
            else if (uiTabPagePersoneli.Text == "Mbyll turnin")
            {
                if (txtFjalekalimi.Text != gridPersoneli.GetRow(i).Cells["FJALEKALIMI"].Text)
                {
                    MessageBox.Show(this, "Dorëzimi i turnit nuk mund të kryhet." + Environment.NewLine +
                        "Fjalëkalimi nuk është i saktë.", uiTab.SelectedTab.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (aktiv == "Jo")
                {
                    MessageBox.Show(this, "Ky kamarier nuk është i loguar.", uiTab.SelectedTab.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //behet logout
                    InputController data = new InputController();
                    int idPerdoruesi = Convert.ToInt32(gridPersoneli.GetRow(i).Cells["ID_PERSONELI"].Text);
                    b = data.KerkesaUpdate("Logout", idPerdoruesi, 1);
                    DataRow r = dsKamarieret.Tables[0].Rows.Find(idPerdoruesi);
                    r.Delete();
                    dsKamarieret.AcceptChanges();
                }
            }
            else if (uiTabPagePersoneli.Text == "Modifiko fjalëkalimin")
            {
                int idPerdoruesi = Convert.ToInt32(gridPersoneli.GetRow(i).Cells["ID_PERSONELI"].Text);
                InputController data = new InputController();
                string fjalekalimiRi = txtFjalekalimi.Text;
                bool r = System.Text.RegularExpressions.Regex.IsMatch(fjalekalimiRi, "^[0-9]*$");
                if (r == false)
                {
                    MessageBox.Show(this, "Për lehtësi përdorimi fjalëkalimi i kamarierit duhet të ketë vetëm numra!",
                       uiTab.SelectedTab.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                b = data.KerkesaUpdate("ModifikoFjalekalim", idPerdoruesi, fjalekalimiRi);
            }
            if (b == 0)
            {
                btnDil_Click(sender, e);
            }
            else
            {
                if (uiTabPagePersoneli.Text == "Modifiko fjalëkalimin")
                    MessageBox.Show(this, "Një gabim ndodhi gjatë modifikimit të fjalëkalimit. Provoni përsëri!", uiTab.SelectedTab.Text,
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                else
                    MessageBox.Show(this, "Një gabim ndodhi gjatë ndërrimit të turneve. Provoni përsëri!", uiTab.SelectedTab.Text,
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void btnKonfirmoFjalekalim_Click(object sender, EventArgs e)
        {
            int i = gridPersoneli.Row;
            if (txtFjalekalimi.Text != gridPersoneli.GetRow(i).Cells["FJALEKALIMI"].Text)
            {
                MessageBox.Show(this, "Konfirmimi i fjalëkalimit nuk është i saktë.", this.Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnKonfirmoFjalekalim.Visible = false;
        }

        private void gridPersoneli_CurrentCellChanged(object sender, EventArgs e)
        {
            txtFjalekalimi.Clear();
            if (uiTab.SelectedTab.Text == "Modifiko fjalëkalimin")
            {
                btnKonfirmoFjalekalim.Visible = true;
            }
            int i = gridPersoneli.Row;
            if (i >= 0)
                txtKamarieri.Text = gridPersoneli.GetRow(i).Cells["PERDORUESI"].Text;
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            uiTabPagePersoneli.TabVisible = false;
            uiTabPagePorosi.TabVisible = true;
            uiTabPageTavolinat.TabVisible = true;
            uiTab.SelectedIndex = 0;
        }

        #endregion
        #endregion

        #region Event Handlers

        private void exBarFavorite_ItemClick(object sender, ItemEventArgs e)
        {
            InputController data = new InputController();
            DataSet ds = null;
            int idArtikulli = 0;
            string grupi = e.Item.Group.Key;

            if (grupi == "Favorites" && uiTab.SelectedTab == uiTab.TabPages[1])
            {
                string emriArtikulli = e.Item.Key;
                idArtikulli = Convert.ToInt32(emriArtikulli);
                string llojiArtikulli = e.Item.TagString;

                if (this.GjendetArtikulli(idArtikulli, llojiArtikulli))
                {
                    this.PastroEkstrat();
                    this.MbushEkstra(idArtikulli);
                    return;
                }

                ds = data.KerkesaRead("LexoTeDhenaPerArtikullin", llojiArtikulli, idArtikulli);

                if (ds == null)
                {
                    DialogResult result = MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ds.Tables[0].Rows.Count == 0)
                {
                    DialogResult result = MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double numriTotal = Convert.ToDouble(ds.Tables[0].Rows[0]["NUMRI_TOTAL"]);
                string nameStock = Convert.ToString(ds.Tables[0].Rows[0]["EMRI"]);

                if (this.strMinus == "0")
                {
                    if (numriTotal < 1)
                    {
                        MessageBox.Show("Ju nuk keni asnje artikull  '" + nameStock + "'  ne magazine.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                decimal cmimiKontrolli = Convert.ToDecimal(ds.Tables[0].Rows[0]["VLERA"]) ;

                if (cmimiKontrolli == 0)
                {
                    MessageBox.Show("Cmimi momental i per artikullin '" + nameStock + "'  eshte 0." + Environment.NewLine + "Ju nuk mund te shisni me cmim 0 !", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow dr = dsFatura.Tables[0].NewRow();
               
                if (llojiArtikulli == "A")
                {
                    dr["CELESI"] = ds.Tables[0].Rows[0]["CELESI"];
                    dr["EMRI"] = ds.Tables[0].Rows[0]["EMRI"];
                    dr["CMIMI"] = ds.Tables[0].Rows[0]["VLERA"];
                    dr["SASIA"] = 1;
                    dr["VLERA"] = Convert.ToDouble(ds.Tables[0].Rows[0]["VLERA"]);
                    dr["NJESIA"] = ds.Tables[0].Rows[0]["NJESIA"];
                    dr["LIMITI"] = 0;
                    dr["LLOJI"] = "A";
                    dr["INDEKSI"] = 0;
                    dr["KUFIRI"] = ds.Tables[0].Rows[0]["NUMRI_TOTAL"];
                    

                    dsFatura.Tables[0].Rows.Add(dr);

                }
                else
                {
                    dr["CELESI"] = ds.Tables[0].Rows[0]["CELESI"];
                    dr["EMRI"] = ds.Tables[0].Rows[0]["EMRI"];
                    dr["CMIMI"] = ds.Tables[0].Rows[0]["VLERA"];
                    dr["SASIA"] = 1;
                    dr["VLERA"] = Convert.ToDouble(ds.Tables[0].Rows[0]["VLERA"]);
                    dr["LLOJI"] = "R";
                    dr["INDEKSI"] = 0;
                    dr["LIMITI"] = 0;
                    dr["KUFIRI"] = ds.Tables[0].Rows[0]["NUMRI_TOTAL"];

                    dsFatura.Tables[0].Rows.Add(dr);
                   
                }

                dsFatura.Tables[0].AcceptChanges();
                

                int numri = dsFatura.Tables[0].Rows.Count;

                this.gridaFatura.DataSource = null;
                this.gridaFatura.DataSource = dsFatura.Tables[0];
                this.gridaFatura.Focus();
                this.gridaFatura.Row = numri - 1;

                this.PastroEkstrat();
                this.MbushEkstra(idArtikulli);

                return;

            }


            string katReceta = e.Item.Text;
            string s = e.Item.Key;
            int celesiR = Convert.ToInt32(s);

            int nrPara = 0;
            int nrPas = 0;

            string emriR = "";
            int celesi = 0;
            int indeksi = 0;

            if (celesiR == -10)
            {
                nrPara = this.nrKatMenu * 12 + 1;
                nrPas = (this.nrKatMenu + 1) * 12;

               
                this.exBarFavorite.Groups[1].Items.Clear();
                foreach (DataRow dr in this.dsKategoriteMenu.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_KATEGORIARECETA"]);
                    emriR = Convert.ToString(dr["PERSHKRIMI"]);
                    indeksi = Convert.ToInt32(dr["INDEKSI"]);
                    if ((indeksi >= nrPara) && (indeksi <= nrPas))
                    {
                        ExplorerBarItem el = new ExplorerBarItem();
                        el.Key = Convert.ToString(celesi);
                        el.Text = emriR;
                        el.Height = 44;
                        el.ToolTipText = emriR;
                        

                        this.exBarFavorite.Groups[1].Items.Add(el);
                    }

                }

                this.nrKatMenu = this.nrKatMenu + 1;

                if (this.dsKategoriteMenu.Tables[0].Rows.Count > nrPas)
                {
                    ExplorerBarItem el = new ExplorerBarItem();
                    el.Key = Convert.ToString(-10);
                    
                    el.TextAlignment = Alignment.Center;
                    System.Drawing.Icon ikoni = new Icon(Application.StartupPath + "\\images\\butoni.ico");
                    el.Icon = ikoni;

                    el.Height = 45;
                    el.FormatStyle.ForeColor = Color.Red;
                    el.ToolTipText = "Klikoni ketu per te vizualisuar kategorite e tjera";

                    this.exBarFavorite.Groups[1].Items.Add(el);

                    

                   
                }

                if (this.nrKatMenu > 1)
                {
                    ExplorerBarItem elPas = new ExplorerBarItem();
                    elPas.Key = Convert.ToString(-20);
                    elPas.TextAlignment = Alignment.Center;
                    System.Drawing.Icon ikoni = new Icon(Application.StartupPath + "\\images\\butoni.ico");
                    elPas.Icon = ikoni;
                    elPas.Height = 44;

                    elPas.ToolTipText = "Klikoni ketu per te vizualisuar kategorite para ketyre";

                    this.exBarFavorite.Groups[1].Items.Add(elPas);
                }

                return;
            }

            if (celesiR == -20)
            {
                nrPara = (this.nrKatMenu - 2) * 12 + 1;
                nrPas = (this.nrKatMenu - 1) * 12;

              
                this.exBarFavorite.Groups[1].Items.Clear();
                foreach (DataRow dr in this.dsKategoriteMenu.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_KATEGORIARECETA"]);
                    emriR = Convert.ToString(dr["PERSHKRIMI"]);
                    indeksi = Convert.ToInt32(dr["INDEKSI"]);
                    if ((indeksi >= nrPara) && (indeksi <= nrPas))
                    {
                        ExplorerBarItem el = new ExplorerBarItem();
                        el.Key = Convert.ToString(celesi);
                        el.Text = emriR;
                        el.Height = 44;
                        el.ToolTipText = emriR;

                        this.exBarFavorite.Groups[1].Items.Add(el);
                    }

                }

                this.nrKatMenu = this.nrKatMenu - 1;

              
                    ExplorerBarItem el1 = new ExplorerBarItem();
                    el1.Key = Convert.ToString(-10);
                    el1.TextAlignment = Alignment.Center;
                    System.Drawing.Icon ikoni1 = new Icon(Application.StartupPath + "\\images\\butoni.ico");
                    el1.Icon = ikoni1;
                    el1.Height = 45;
                    el1.FormatStyle.ForeColor = Color.Red;
                    el1.ToolTipText = "Klikoni ketu per te vizualisuar kategorite e tjera";

                    this.exBarFavorite.Groups[1].Items.Add(el1);




                

                if (this.nrKatMenu > 1)
                {
                    ExplorerBarItem elPas = new ExplorerBarItem();
                    elPas.Key = Convert.ToString(-20);
                    elPas.TextAlignment = Alignment.Center;
                    System.Drawing.Icon ikoni11 = new Icon(Application.StartupPath + "\\images\\butoniPrapa.ico");
                    elPas.Icon = ikoni11;
                    elPas.Height = 45;
                    elPas.ToolTipText = "Klikoni ketu per te vizualisuar kategorite para ketyre";
                    ///elPas.Image = ResManager.Properties.Resources.back;

                    this.exBarFavorite.Groups[1].Items.Add(elPas);
                }

                return;
            }

            string lloji = "";

            if (grupi == "Artikuj")
            {
                lloji = "A";
            }
            else
            {
                lloji = "R";
            }

            string strSql = "";

            if (lloji == "A")
            {
                strSql = "SELECT ID_ARTIKULLI, EMRI FROM ARTIKUJT WHERE ID_KATEGORIAARTIKULLI = " + celesiR + " AND ID_ARTIKULLI IN (SELECT ID_ARTIKULLI FROM CMIMET_PERIUDHA)";
                
            }
            else
            {
                strSql = "SELECT ID_RECETA, EMRI FROM RECETAT WHERE DISPONUESHEM = 1 AND AKTIVE = 1 AND ID_KATEGORIARECETA = " + celesiR;
                
            }


            ds = data.KerkesaRead("ShfaqArtikujtPerBar", strSql);

            if (ds == null)
            {
                //mesazh gabimi

                return;
            }

            this.dsRecetatMenu.Tables[0].Clear();

            int rMenu = 0;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                rMenu = rMenu + 1;

                DataRow drNew = this.dsRecetatMenu.Tables[0].NewRow();

                drNew["ID_RECETA"] = dr["ID_RECETA"];
                drNew["EMRI"] = dr["EMRI"];
                drNew["INDEKSI"] = rMenu;

                this.dsRecetatMenu.Tables[0].Rows.Add(drNew);
            }

            this.dsRecetatMenu.Tables[0].AcceptChanges();

            string emri = "";
            int celesiA = 0;
            this.exArtikujt.Groups[0].Items.Clear();
            this.exArtikujt.Groups[0].Text = katReceta;

            int indeksiR = 0;

            foreach (DataRow dr in this.dsRecetatMenu.Tables[0].Rows)
            {
                celesiA = Convert.ToInt32(dr[0]);
                emri = Convert.ToString(dr[1]);
                indeksiR = Convert.ToInt32(dr[2]);

                if (indeksiR < 13)
                {
                    ExplorerBarItem el = new ExplorerBarItem();
                    el.Key = Convert.ToString(celesiA);
                    el.Text = emri;
                    el.Height = 44;
                    el.TagString = lloji;
                    el.ToolTipText = emri;

                    this.exArtikujt.Groups[0].Items.Add(el);
                }

            }

            if (rMenu > 12)
            {
                ExplorerBarItem el = new ExplorerBarItem();
                el.Key = Convert.ToString(-10);
                el.TextAlignment = Alignment.Center;
                System.Drawing.Icon ikoni2 = new Icon(Application.StartupPath + "\\images\\butoni.ico");
                el.Icon = ikoni2;

                el.Height = 45;
                el.FormatStyle.ForeColor = Color.Red;
                el.TagString = lloji;
                el.ToolTipText = "Ketu mund te vizualisoni recetat e tjera per kete kategori !";

                this.exArtikujt.Groups[0].Items.Add(el);

                this.nrRecMenu = 1;
            }

            this.nrRecMenu = 1;

            this.exBarFavorite.Hide();

            this.exArtikujt.Show();
            this.exArtikujt.Groups[0].Expanded = true;




        }

        
      

       

        private void optVlera_CheckedChanged(object sender, EventArgs e)
        {
            if (this.optVlera.Checked == true)
            {
                //this.numVlera.Value = 0;
                //this.numVlera.Enabled = true;
                //this.numVlera.BackColor = Color.White;

                //this.numPerqindja.Value = 0;
                //this.numPerqindja.Enabled = false;
                //this.numPerqindja.BackColor = Color.White;


            }
            else
            {
                //this.numPerqindja.Text = "";
                //this.numPerqindja.Enabled = true;
                //this.numPerqindja.BackColor = Color.White;

                //this.numVlera.Text = "";
                //this.numVlera.Enabled = false;
                //this.numVlera.BackColor = Color.White;
            }
        }

        private void optPerqindja_CheckedChanged(object sender, EventArgs e)
        {
            if (this.optPerqindja.Checked == true)
            {
                //this.numPerqindja.Text = "";
                //this.numPerqindja.Enabled = true;
                //this.numPerqindja.BackColor = Color.White;

                //this.numVlera.Text = "";
                //this.numVlera.Enabled = false;
                //this.numVlera.BackColor = Color.White;


            }
            else
            {
                //this.numVlera.Text = "";
                //this.numVlera.Enabled = true;
                //this.numVlera.BackColor = Color.White;

                //this.numPerqindja.Text = "";
                //this.numPerqindja.Enabled = false;
                //this.numPerqindja.BackColor = Color.White;
            }
        }

        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXhiroKamarieri frm = new frmXhiroKamarieri();
            frm.dsKam = this.dsUsers;
            frm.ShowDialog();

        }

        private void exArtikujt_ItemClick(object sender, ItemEventArgs e)
        {
            if (this.uiTab.TabIndex == 0)
            {
                return;
            }

            string emriArtikulli = e.Item.Key;
            int idArtikulli = Convert.ToInt32(emriArtikulli);
            string llojiArtikulli = e.Item.TagString;

            int nrPara = 0;
            int nrPas = 0;

            string emriR = "";
            int celesi = 0;
            int indeksi = 0;

            int celesiR = idArtikulli;

            if (celesiR == -10)
            {
                nrPara = this.nrRecMenu * 12 + 1;
                nrPas = (this.nrRecMenu + 1) * 12;


                this.exArtikujt.Groups[0].Items.Clear();

                this.nrRecMenu = this.nrRecMenu + 1;

                //if (this.nrRecMenu > 1)
                //{
                //    ExplorerBarItem elPas = new ExplorerBarItem();
                //    elPas.Key = Convert.ToString(-20);
                //    elPas.TextAlignment = Alignment.Center;
                //    elPas.Text = "<<<<<<<<<";
                //    elPas.Height = 44;
                //    elPas.ToolTipText = "Klikoni ketu per te vizualisuar recetat para ketyre";
                //    elPas.TagString = "R";

                //    this.exArtikujt.Groups[0].Items.Add(elPas);
                //}

                foreach (DataRow dr in this.dsRecetatMenu.Tables[0].Rows)
                {
                   

                    celesi = Convert.ToInt32(dr["ID_RECETA"]);
                    emriR = Convert.ToString(dr["EMRI"]);
                    indeksi = Convert.ToInt32(dr["INDEKSI"]);
                    if ((indeksi >= nrPara) && (indeksi <= nrPas))
                    {
                        ExplorerBarItem el = new ExplorerBarItem();
                        el.Key = Convert.ToString(celesi);
                        el.Text = emriR;
                        el.Height = 44;
                        el.ToolTipText = emriR;
                        el.TagString = "R";

                        this.exArtikujt.Groups[0].Items.Add(el);
                    }

                }

                

                if (this.dsRecetatMenu.Tables[0].Rows.Count > nrPas)
                {
                    ExplorerBarItem el = new ExplorerBarItem();
                    el.Key = Convert.ToString(-10);
                    el.TextAlignment = Alignment.Center;
                    System.Drawing.Icon ikoni3 = new Icon(Application.StartupPath + "\\images\\butoni.ico");
                    el.Icon = ikoni3;

                    el.Height = 45;
                    el.FormatStyle.ForeColor = Color.Red;
                    el.ToolTipText = "Klikoni ketu per te vizualisuar recetat e tjera per kete kategori !";
                    el.TagString = "R";

                    this.exArtikujt.Groups[0].Items.Add(el);




                }

                if (this.nrRecMenu > 1)
                {
                    ExplorerBarItem elPas = new ExplorerBarItem();
                    elPas.Key = Convert.ToString(-20);
                    elPas.TextAlignment = Alignment.Center;
                    System.Drawing.Icon ikoni12 = new Icon(Application.StartupPath + "\\images\\butoniPrapa.ico");
                    elPas.Icon = ikoni12;
                    elPas.Height = 44;
                    elPas.ToolTipText = "Klikoni ketu per te vizualisuar recetat para ketyre";
                    elPas.TagString = "R";

                    this.exArtikujt.Groups[0].Items.Add(elPas);
                }

                return;
            }

            if (celesiR == -20)
            {
                nrPara = (this.nrRecMenu - 2) * 12 + 1;
                nrPas = (this.nrRecMenu - 1) * 12;


                this.exArtikujt.Groups[0].Items.Clear();

                this.nrRecMenu = this.nrRecMenu - 1;

              

                foreach (DataRow dr in this.dsRecetatMenu.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_RECETA"]);
                    emriR = Convert.ToString(dr["EMRI"]);
                    indeksi = Convert.ToInt32(dr["INDEKSI"]);
                    if ((indeksi >= nrPara) && (indeksi <= nrPas))
                    {
                        ExplorerBarItem el = new ExplorerBarItem();
                        el.Key = Convert.ToString(celesi);
                        el.Text = emriR;
                        el.Height = 44;
                        el.ToolTipText = emriR;
                        el.TagString = "R";

                        this.exArtikujt.Groups[0].Items.Add(el);
                    }

                }

                


                ExplorerBarItem el1 = new ExplorerBarItem();
                el1.Key = Convert.ToString(-10);
                el1.TextAlignment = Alignment.Center;
                System.Drawing.Icon ikoni4 = new Icon(Application.StartupPath + "\\images\\butoni.ico");
                el1.Icon = ikoni4;
 
                el1.Height = 45;
                el1.FormatStyle.ForeColor = Color.Red;

                el1.ToolTipText = "Klikoni ketu per te vizualisuar recetat e tjera per kategorine e zgjedhur !";
                el1.TagString = "R";

                this.exArtikujt.Groups[0].Items.Add(el1);



                if (this.nrRecMenu > 1)
                {
                    ExplorerBarItem elPas = new ExplorerBarItem();
                    elPas.Key = Convert.ToString(-20);
                    elPas.TextAlignment = Alignment.Center;
                    System.Drawing.Icon ikoni13 = new Icon(Application.StartupPath + "\\images\\butoniPrapa.ico");
                    elPas.Icon = ikoni13;
                    
                    elPas.Height = 44;
                    elPas.ToolTipText = "Klikoni ketu per te vizualisuar recetat para ketyre";
                    elPas.TagString = "R";

                    this.exArtikujt.Groups[0].Items.Add(elPas);
                }


               

                return;
            }

            if (this.GjendetArtikulli(idArtikulli, llojiArtikulli))
            {
                this.PastroEkstrat();
                this.MbushEkstra(idArtikulli);
                return;
            }

            InputController data = new InputController();

            DataSet ds = data.KerkesaRead("LexoTeDhenaPerArtikullin", llojiArtikulli, idArtikulli);

            if (ds == null)
            {
                DialogResult result = MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double numriTotal = Convert.ToDouble(ds.Tables[0].Rows[0]["NUMRI_TOTAL"]);
            string nameStock = Convert.ToString(ds.Tables[0].Rows[0]["EMRI"]);

            if (this.strMinus == "0")
            {
                if (numriTotal < 1)
                {
                    MessageBox.Show("Ju nuk keni asnje artikull  '" + nameStock + "'  ne magazine.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            decimal cmimiKontrolli = Convert.ToDecimal(ds.Tables[0].Rows[0]["VLERA"]);

            if (cmimiKontrolli == 0)
            {
                MessageBox.Show("Cmimi momental i per artikullin '" + nameStock + "'  eshte 0." + Environment.NewLine + "Ju nuk mund te shisni me cmim 0 !", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataRow dr1 = dsFatura.Tables[0].NewRow();
            

            if (llojiArtikulli == "A")
            {
                dr1["CELESI"] = ds.Tables[0].Rows[0]["CELESI"];
                dr1["EMRI"] = ds.Tables[0].Rows[0]["EMRI"];
                dr1["CMIMI"] = ds.Tables[0].Rows[0]["VLERA"];
                dr1["SASIA"] = Convert.ToInt32(1);
                dr1["VLERA"] = Convert.ToDouble(dr1["CMIMI"]) ;
                dr1["NJESIA"] = ds.Tables[0].Rows[0]["NJESIA"];
                //dr["LIMITI"] = ds.Tables[0].Rows[0]["LIMITI"];
                dr1["LLOJI"] = "A";
                dr1["LIMITI"] = 0;
                dr1["INDEKSI"] = 0;
                dr1["KUFIRI"] = ds.Tables[0].Rows[0]["NUMRI_TOTAL"];

                dsFatura.Tables[0].Rows.Add(dr1);

                
                


               
            }
            else
            {
                dr1["CELESI"] = ds.Tables[0].Rows[0]["CELESI"];
                dr1["EMRI"] =  ds.Tables[0].Rows[0]["EMRI"];
                dr1["CMIMI"] = ds.Tables[0].Rows[0]["VLERA"];
                dr1["SASIA"] = 1;
                dr1["VLERA"] = Convert.ToDouble(dr1["CMIMI"]);
                //dr["NJESIA"] = ds.Tables[0].Rows[0]["NJESIA"];
                //dr["LIMITI"] = ds.Tables[0].Rows[0]["LIMITI"];
                dr1["LLOJI"] = "R";
                dr1["LIMITI"] = 0;
                dr1["INDEKSI"] = 0;
                dr1["KUFIRI"] = ds.Tables[0].Rows[0]["NUMRI_TOTAL"];

                dsFatura.Tables[0].Rows.Add(dr1);
            }

            dsFatura.Tables[0].AcceptChanges();

            int numri = dsFatura.Tables[0].Rows.Count;
            int indeksi1 = numri - 1;


            this.gridaFatura.Row = indeksi1;
            this.gridaFatura.Focus();

            this.PastroEkstrat();
            this.MbushEkstra(idArtikulli);

            //this.gridaFatura.DataSource = null;
            ///this.gridaFatura.DataSource = dsFatura.Tables[0];

            return;
        }

        //private void gridaFatura_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        //{
        //    int indeksi = this.gridaFatura.Row;
        //    if (indeksi < 0)
        //    {
        //        return;
        //    }

        //    int celesi = Convert.ToInt32(this.gridaFatura.GetRow(indeksi).Cells[0].Text);
        //    string sasia = Convert.ToString(this.gridaFatura.GetRow(indeksi).Cells[4].Text);

        //    int nr = 0;

        //    try
        //    {
        //        nr = Convert.ToInt32(sasia);
        //    }
        //    catch (Exception)
        //    {
        //        this.gridaFatura.GetRow(indeksi).Cells[4].Text = "0";
        //        nr = 0;

        //    }

        //    int idArtikulli = 0;
        //    double cmimi = 0;
        //    double vlera = 0;

        //    foreach (DataRow dr in dsFatura.Tables[0].Rows)
        //    {
        //        idArtikulli = Convert.ToInt32(dr[0]);

        //        if (idArtikulli == celesi)
        //        {
        //            dr["SASIA"] = nr;
        //            cmimi = Convert.ToDouble(dr["CMIMI"]);
        //            vlera = cmimi * nr;
        //            dr["VLERA"] = vlera;

        //            this.gridaFatura.GetRow(indeksi).Cells[5].Text = vlera.ToString();

        //        }
        //    }

        //    dsFatura.Tables[0].AcceptChanges();

        //}

        private void uiTab_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            if (this.uiTab.SelectedTab.Index == 1)
            {
                this.optVlera.Checked = true;
                this.optPerqindja.Checked = false;
                this.txtSkonto.Text = "0";
            }
        }

        #endregion

        #region Private Methods


        private void KonsumoArtikujtBanaku()
        {
            int idFatura = this.KtheIdFatura();

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
            decimal sasia = 0;

            foreach (DataRow drB in this.dsBanaku.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(drB["ID_ARTIKULLI"]);

                sasia = Convert.ToDecimal(drB["SASIA"]);


                this.ModifikoSasiaArtikullFirst(idArtikulli, sasia);
            }

            this.dsArtikujtBanaku.Tables[0].AcceptChanges();
        }

        private void ModifikoSasiaArtikullFirst(int idArtikulli, decimal sasia)
        {
            int celesi = 0;
            double gjendja = 0;
            string strGjendja = "";

            foreach (DataRow dr in this.dsArtikujtBanaku.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["ID_ARTIKULLI"]);

                if (celesi == idArtikulli)
                {
                    strGjendja = Convert.ToDecimal(dr["SASIA"]).ToString("0.00");
                    dr["SASIA"] = Convert.ToDecimal(strGjendja) + sasia;
                    break;
                }
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
                    dr["SASIA"] = Convert.ToDouble(strGjendja) - sasia;
                    break;
                }
            }

            this.dsArtikujtBanaku.Tables[0].AcceptChanges();
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

        private DataSet KrijoDsOfertat()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_OFERTA", typeof(Int32));
            ds.Tables[0].Columns.Add("CMIMI", typeof(decimal));
            ds.Tables[0].Columns.Add("INDEKSI", typeof(Int32));

            ds.Tables[0].AcceptChanges();

            ds.Tables.Add();

            ds.Tables[1].Columns.Add("ID_OFERTA", typeof(Int32));
            ds.Tables[1].Columns.Add("INDEKSI", typeof(Int32));
            ds.Tables[1].Columns.Add("ID_RECETA", typeof(Int32));
            ds.Tables[1].Columns.Add("SASIA", typeof(Int32));

            ds.Tables[1].AcceptChanges();

            return ds;

        }

        private void LexoXmlKonfigurime()
        {
            string str = "";
            string fileName = Global.stringXml + "\\Konfigurime.xml";
            XmlTextReader tr = new XmlTextReader(fileName);
            try
            {
                while (tr.Read())
                {
                    if (tr.NodeType == XmlNodeType.Element)
                    {
                        str = tr.LocalName.ToString();
                        switch (str)
                        {
                            case "Nr":
                                this.modeTavolinat = Convert.ToInt32(tr.ReadElementString(str).ToString());
                                break;

                            case "OfertaMode" :
                                this.strOferta = tr.ReadElementString(str).ToString().Trim();
                                break;

                            case "ModeMinus":
                                this.strMinus = tr.ReadElementString(str).ToString();
                                break;

                            case "ModeKam":
                                this.strKam = tr.ReadElementString(str).ToString();
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
            catch
            {

            }
            finally
            {
                tr.Close();
            }
        }

        private void LexoXml()
        {
            string str = "";
            string fileName = Global.stringXml + "\\Printimi.xml";
            XmlTextReader tr = new XmlTextReader(fileName);
            try
            {
                while (tr.Read())
                {
                    if (tr.NodeType == XmlNodeType.Element)
                    {
                        str = tr.LocalName.ToString();
                        switch (str)
                        {
                            case "Modeli":
                                this.printModeli = Convert.ToInt32(tr.ReadElementString(str).ToString());
                                break;
                            
                            default:
                                break;
                        }
                    }
                }
            }
            catch
            {
               
            }
            finally
            {
                tr.Close();
            }
        }

        private bool GjendetArtikulli(int idArtikulli, string lloji)
        {
            try
            {
                int celesi = 0;
                int sasia = 0;
                double cmimi = 0;
                double vlera = 0;
                string tipi = "";
                if (dsFatura != null && dsFatura.Tables.Count != 0)
                {
                    foreach (DataRow dr in dsFatura.Tables[0].Rows)
                    {
                        celesi = Convert.ToInt32(dr["CELESI"]);
                        tipi = Convert.ToString(dr["LLOJI"]);

                        if (celesi == idArtikulli && tipi == lloji)
                        {
                            sasia = Convert.ToInt32(dr["SASIA"]);
                            sasia = sasia + 1;
                            cmimi = Convert.ToDouble(dr["CMIMI"]);
                            vlera = sasia * cmimi;
                            dr["SASIA"] = sasia;
                            dr["VLERA"] = vlera;

                            this.dsFatura.Tables[0].AcceptChanges();
                            return true;
                        }

                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private DataSet KrijoDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("CELESI", typeof(Int32));
            ds.Tables[0].Columns.Add("EMRI", typeof(string));
            ds.Tables[0].Columns.Add("CMIMI", typeof(double));
            ds.Tables[0].Columns.Add("SASIA", typeof(Int32));
            ds.Tables[0].Columns.Add("NJESIA", typeof(string));
            ds.Tables[0].Columns.Add("VLERA", typeof(double));
            ds.Tables[0].Columns.Add("LIMITI", typeof(double));
            ds.Tables[0].Columns.Add("LLOJI", typeof(string));
            ds.Tables[0].Columns.Add("INDEKSI", typeof(Int32));
            ds.Tables[0].Columns.Add("KUFIRI", typeof(Int32));
            

            ds.Tables[0].AcceptChanges();

            return ds;
        }


        private bool EshteInteger(string shtesa)
        {
            bool eshte = false;

            switch (shtesa)
            {
                case "1":
                    eshte = true;
                    break;

                case "2":
                    eshte = true;
                    break;

                case "3":
                    eshte = true;
                    break;

                case "4":
                    eshte = true;
                    break;

                case "5":
                    eshte = true;
                    break;

                case "6":
                    eshte = true;
                    break;

                case "7":
                    eshte = true;
                    break;

                case "8":
                    eshte = true;
                    break;

                case "9":
                    eshte = true;
                    break;

                case "0":
                    eshte = true;
                    break;

                default:
                    eshte = false;
                    break;

            }

            return eshte;
        }

        private bool EshteIntegerPozitiv(string shtesa)
        {
            bool eshte = false;

            switch (shtesa)
            {
                case "1":
                    eshte = true;
                    break;

                case "2":
                    eshte = true;
                    break;

                case "3":
                    eshte = true;
                    break;

                case "4":
                    eshte = true;
                    break;

                case "5":
                    eshte = true;
                    break;

                case "6":
                    eshte = true;
                    break;

                case "7":
                    eshte = true;
                    break;

                case "8":
                    eshte = true;
                    break;

                case "9":
                    eshte = true;
                    break;

                default:
                    eshte = false;
                    break;

            }

            return eshte;
        }

        private bool EshteReal(string nr)
        {
            bool eshte = true;

            double vlera = 0;

            try
            {
                vlera = Convert.ToDouble(nr);
            }
            catch (Exception ex)
            {
                eshte = false;
            }

            return eshte;
        }

        private bool EshtePerqindje(string nr)
        {
            bool eshte = true;

            int vlera = 0;

            try
            {
                vlera = Convert.ToInt32(nr);
            }
            catch (Exception ex)
            {
                eshte = false;
            }

            if (eshte == true)
            {
                if (vlera > 100 || vlera < 0)
                {
                    eshte = false;
                }
            }

            return eshte;
        }

        private bool KaGabime()
        {
            string numri = "";

            if (numri == "")
            {
               
            }

            return true;
        }

        private DataSet KrijoDataSetRuaj()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("CELESI", typeof(string));
            ds.Tables[0].Columns.Add("LLOJI", typeof(string));
            ds.Tables[0].Columns.Add("SASIA", typeof(int));
            ds.Tables[0].Columns.Add("CMIMI", typeof(decimal));

            ds.Tables[0].AcceptChanges();

            return ds;
        }

        private DataSet KrijoDataSetTavolinat()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("TAVOLINAT");
            ds.Tables.Add("FATURAT");

            ds.Tables[0].Columns.Add("ID_TAVOLINA", typeof(Int32));
            ds.Tables[0].Columns.Add("GJENDJA", typeof(string));
            ds.Tables[0].Columns.Add("EMRI", typeof(string));

            DataColumn[] celesi1 = new DataColumn[1];
            celesi1[0] = ds.Tables[0].Columns[0];

            ds.Tables[0].PrimaryKey = celesi1;

            ds.Tables[0].AcceptChanges();

            ds.Tables[1].Columns.Add("ID_TAVOLINA", typeof(Int32));
            ds.Tables[1].Columns.Add("ID_FATURA", typeof(Int32));

            DataColumn[] celesi2 = new DataColumn[2];
            celesi2[0] = ds.Tables[1].Columns[0];
            celesi2[1] = ds.Tables[1].Columns[1];

            ds.Tables[1].PrimaryKey = celesi2;

            ds.Tables[1].AcceptChanges();

            ds.Relations.Add("Lidhja", ds.Tables[0].Columns["ID_TAVOLINA"], ds.Tables[1].Columns["ID_TAVOLINA"]);
            ds.AcceptChanges();

            return ds;
        }


        private void InicializoSkonto()
        {
            //this.optVlera.Checked = true;
            //this.numVlera.Value = 0;
            //this.numVlera.Enabled = true;
            //this.numVlera.BackColor = Color.White;

            this.optPerqindja.Checked = false;
            //this.numPerqindja.Value = 0;
            //this.numPerqindja.Enabled = false;
            //this.numPerqindja.BackColor = Color.White; 
        }

        private string KtheNrFatura()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("KtheNrFaturaLast");

            int numri = 0;
            if (ds.Tables[0].Rows.Count != 0)
            {
                numri = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
            }
            numri = numri + 1;

            string strFatura = Convert.ToString(numri);

            return strFatura;
        }

        private int KtheIdFatura()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("KtheNrFaturaLast");

            int numri = 0;
            if (ds.Tables[0].Rows.Count != 0)
            {
                numri = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }
           

            return numri;
        }



        #endregion

        private void splitContainerTavolinat_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiButton1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void printDok_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string drawString = "";
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float posX = 90;
            float posY = 0;
            PointF drawPoint = new PointF();

            string dataSot = System.DateTime.Today.ToString("dd/MM/yyyy");
            string oraTani = System.DateTime.Now.ToString("HH:mm");

            bool gjendetImazhi = true;

            string shumezimi = "×";

            switch (printModeli)
            {
                case 1:



                    if (gjendetImazhi)
                    {

                        drawFont = new Font("Nina", 16);
                        drawString = this.printBari;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        posX = 10;
                        posY = 30;


                    }
                    else
                    {
                        posX = 70;
                        posY = 0;
                    }

                    drawFont = new Font("Arial", 8);

                    drawString = "Fatura nr: " + this.printNrFatura;
                    //PointF drawPoint = new PointF(70.0F, 10.0F)
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawPoint = new PointF(10.0F, 20.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 15;
                    }
                    else
                    {
                        posX = 10;
                        posY = 45;
                    }


                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Data: " + dataSot + " , Ora: " + oraTani;
                    //drawPoint = new PointF(10.0F, 30.0F);



                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 30;

                    }
                    else
                    {
                        posX = 10;
                        posY = 60;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 43;

                    }
                    else
                    {
                        posX = 10;
                        posY = 73;
                    }

                    drawString = "Tavolina: " + this.printTavolina + " ,       Kamarieri: " + this.printUser;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);



                    drawString = "----------------------------------------------------------------";
                    //drawPoint = new PointF(10.0F, 40.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 58;

                    }
                    else
                    {
                        posX = 10;
                        posY = 88;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Emertimi";
                    //drawPoint = new PointF(10.0F, 50.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 73;

                    }
                    else
                    {
                        posX = 10;
                        posY = 103;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Cmimi";
                    //drawPoint = new PointF(10.0F, 50.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 110;
                        posY = 73;

                    }
                    else
                    {
                        posX = 110;
                        posY = 103;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Sasia";
                    //drawPoint = new PointF(10.0F, 50.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 155;
                        posY = 73;

                    }
                    else
                    {
                        posX = 155;
                        posY = 103;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Vlera";
                    //drawPoint = new PointF(10.0F, 50.0F);


                    if (gjendetImazhi == false)
                    {
                        posX = 195;
                        posY = 73;

                    }
                    else
                    {
                        posX = 195;
                        posY = 103;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "----------------------------------------------------------------";
                    drawPoint = new PointF(10.0F, 60.0F);
                    posX = 10;

                    if (gjendetImazhi == false)
                    {
                        posY = 83;
                    }
                    else
                    {
                        posY = 113;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    int nr = this.printArtikujt.Length;

                    for (int i = 0; i < nr; i++)
                    {
                        //posX = 10;
                        //posY = posY + 15;

                        //drawString = "--------------------------------------------------";
                        ////drawPoint = new PointF(10.0F,  70.0F);
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        drawString = this.FormayoEmrinRecetaPerPrintim(this.printArtikujt[i]);
                        posX = 10;
                        posY = posY + 20;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        drawString = this.printCmimet[i];
                        posX = 118;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printSasite[i];
                        posX = 163;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printVlerat[i];
                        posX = 200;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    }

                    posX = 10;
                    posY = posY + 15;

                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 15;

                    drawString = "Vlera totale :";


                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 200;

                    drawString = this.printTotali;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 15;


                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
                    posX = 10;
                    posY = posY + 3;

                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawFont = new Font("Pristina", 12);
                    posX = 80;
                    posY = posY + 25;

                    drawString = "Faleminderit !";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    drawFont = new Font("Verdana", 7);
                    posX = 60;
                    posY = posY + 30;

                    drawString = "www.visioninfosolution.com";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    break;

                case 2:

                   



                    //drawPoint = new PointF(10.0F, 20.0F);
                    posX = 90;
                    posY = 0;

                    drawFont = new Font("Nina", 16);
                    drawString = this.printBari;

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawString = "Data: " + dataSot + " , Ora: " + oraTani;
                    ////drawPoint = new PointF(10.0F, 30.0F);

                    posX = 10;
                    posY = 35;

                    drawFont = new Font("Nina", 9);

                    drawString = "Nr: " + this.printNrFatura;
                    //PointF drawPoint = new PointF(70.0F, 10.0F)
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawPoint = new PointF(10.0F, 20.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 15;
                    }
                    else
                    {
                        posX = 10;
                        posY = 47;
                    }


                    drawFont = new Font("Nina", 8);
                    drawString = "----------------------------------------------------------------";
                    
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Data: " + dataSot + " ";     //// ORA: " + oraTani;
                    //drawPoint = new PointF(10.0F, 30.0F);



                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 30;

                    }
                    else
                    {
                        posX = 10;
                        posY = 60;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Ora: " + oraTani;
                    //drawPoint = new PointF(10.0F, 30.0F);



                    if (gjendetImazhi == false)
                    {
                        posX = 120;
                        posY = 30;

                    }
                    else
                    {
                        posX = 120;
                        posY = 60;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 43;

                    }
                    else
                    {
                        posX = 10;
                        posY = 77;
                    }

                    drawString = "Tavolina: " + this.printTavolina + " "; ////       KAMARIERI: " + this.printUser.ToUpper();
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    if (gjendetImazhi == false)
                    {
                        posX = 120;
                        posY = 43;

                    }
                    else
                    {
                        posX = 120;
                        posY = 77;
                    }

                    drawString = "Kamarieri: " + this.printUser;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);



                    drawString = "----------------------------------------------------------------";
                    //drawPoint = new PointF(10.0F, 40.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 58;

                    }
                    else
                    {
                        posX = 10;
                        posY = 88;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                   

                    int nr2 = this.printArtikujt.Length;

                    //posY = posY + 15; 

                    for (int i = 0; i < nr2; i++)
                    {
                        //posX = 10;
                        //posY = posY + 15;

                        //drawString = "--------------------------------------------------";
                        ////drawPoint = new PointF(10.0F,  70.0F);
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawFont = new Font("Nina", 8);

                        drawString = this.FormayoEmrinRecetaPerPrintim(this.printArtikujt[i].ToUpper());
                        posX = 10;
                        posY = posY + 20;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        drawString = this.printSasite[i] + " " + shumezimi + " " + this.printCmimet[i];
                        posX = 150;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        //drawString = shumezimi; /// +" " + shumezimi + " " + this.printCmimet[i];
                        //posX = 160;
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        //drawString = this.printSasite[i];
                        //posX = 170;
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printVlerat[i];
                        posX = 220;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    }

                    posX = 10;
                    posY = posY + 15;

                    drawString = "------------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 20;

                    drawString = "TOTALI :";
                    drawFont = new Font("Agency FB", 14);

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 210;

                    drawString = this.printTotali;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 15;


                    //drawString = "----------------------------------------------------------------";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
                    //posX = 10;
                    //posY = posY + 3;

                    //drawString = "----------------------------------------------------------------";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawFont = new Font("Pristina", 14);
                    posX = 80;
                    posY = posY + 30;

                    drawString = "Faleminderit !";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    drawFont = new Font("Verdana", 7);
                    posX = 60;
                    posY = posY + 30;

                    drawString = "www.visioninfosolution.com";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    break;

                case 3:
                    //drawString = "Fatura nr: " + this.printNrFatura;
                    ////PointF drawPoint = new PointF(70.0F, 10.0F);


                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);



                    //drawPoint = new PointF(10.0F, 20.0F);
                    posX = 100;
                    posY = 0;

                    drawFont = new Font("Nina", 16);
                    drawString = this.printBari;

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawString = "Data: " + dataSot + " , Ora: " + oraTani;
                    ////drawPoint = new PointF(10.0F, 30.0F);

                    //posX = 10;
                    //posY = 30;

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //posX = 10;
                    //posY = 43;
                    //drawString = "Tavolina: " + this.printTavolina + " ,       Kamarieri: " + this.printUser;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);



                    //drawString = "----------------------------------------------------------------";
                    //drawPoint = new PointF(10.0F, 40.0F);

                    //posX = 10;
                    //posY = 58;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawFont = new Font("Nina", 8);
                    //drawString = "Emertimi";
                    ////drawPoint = new PointF(10.0F, 50.0F);
                    //posX = 10;
                    //posY = posY + 50;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawString = "Cmimi";
                    ////drawPoint = new PointF(10.0F, 50.0F);
                    //posX = 130;
                    ////posY = 73;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawString = "Sasia";
                    ////drawPoint = new PointF(10.0F, 50.0F);
                    //posX = 175;
                    ////posY = 73;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawString = "Vlera";
                    ////drawPoint = new PointF(10.0F, 50.0F);
                    //posX = 215;
                    ////posY = 73;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
                    //posY = posY + 30; 

                    posX = 10;
                    posY = 35;

                    drawFont = new Font("Nina", 9);
                    drawString = "Nr: " + this.printNrFatura;
                    //PointF drawPoint = new PointF(70.0F, 10.0F);


                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawFont = new Font("Nina", 8);
                    drawString = "------------------------------------------------------------------";
                    drawPoint = new PointF(10.0F, 60.0F);
                    posX = 10;
                    posY = posY + 15;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    int nr3 = this.printArtikujt.Length;



                    for (int i = 0; i < nr3; i++)
                    {
                        //posX = 10;
                        //posY = posY + 15;

                        //drawString = "--------------------------------------------------";
                        ////drawPoint = new PointF(10.0F,  70.0F);
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawFont = new Font("Nina", 8);

                        drawString = this.FormayoEmrinRecetaPerPrintim(this.printArtikujt[i].ToUpper());
                        posX = 50;
                        posY = posY + 20;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        //drawString = this.printCmimet[i];
                        //posX = 10;
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printSasite[i];
                        posX = 10;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printVlerat[i];
                        posX = 220;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    }

                    posX = 10;
                    posY = posY + 20;

                    drawString = "------------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 20;

                    drawString = "TOTALI :";
                    drawFont = new Font("Agency FB", 14);

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 210;

                    drawString = this.printTotali;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 15;


                    //drawString = "----------------------------------------------------------------";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
                    //posX = 10;
                    //posY = posY + 3;

                    //drawString = "----------------------------------------------------------------";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawFont = new Font("Pristina", 14);
                    posX = 80;
                    posY = posY + 30;

                    drawString = "Faleminderit !";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    drawFont = new Font("Verdana", 7);
                    posX = 60;
                    posY = posY + 30;

                    drawString = "www.visioninfosolution.com";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    break;

                default:
                    break;
            }


            

         


        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaFatura.Row;
            int nrReshta = this.gridaFatura.RowCount;

            if (indeksi < 0 || indeksi >= nrReshta - 1)
            {
                return;
            }

            if (indeksi < 0)
            {
                return;
            }

            int celesi = Convert.ToInt32(this.gridaFatura.GetRow(indeksi).Cells[0].Text);

            double cmimi = 0;
            int sasia = 0;

            double vlera = 0;

          

            int idArtikulli = 0;

            foreach (DataRow dr in this.dsFatura.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);

                if (idArtikulli > 0)
                {
                    if (idArtikulli == celesi)
                    {
                        sasia = Convert.ToInt32(dr["SASIA"]);
                        sasia = sasia + 1;
                        dr["SASIA"] = Convert.ToInt32(sasia);

                        cmimi = Convert.ToDouble(dr["CMIMI"]);
                        vlera = cmimi * sasia;

                        dr["VLERA"] = vlera;

                    }
                }
            }

            this.dsFatura.Tables[0].AcceptChanges();

            //this.gridaFatura.GetRow(indeksi).Cells[4].Text = sasia.ToString();
            //this.gridaFatura.GetRow(indeksi).Cells[5].Text = vlera.ToString();

            this.gridaFatura.Row = indeksi;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaFatura.Row;
            int nrReshta = this.gridaFatura.RowCount;

            if (indeksi < 0 || indeksi >= nrReshta - 1)
            {
                return;
            }

            if (indeksi < 0)
            {
                return;
            }

            int celesi = Convert.ToInt32(this.gridaFatura.GetRow(indeksi).Cells[0].Text);

            double cmimi = 0;
            int sasia = 0;

            double vlera = 0;



            int idArtikulli = 0;

            foreach (DataRow dr in this.dsFatura.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);
                if (idArtikulli > 0)
                {
                    if (idArtikulli == celesi)
                    {
                        sasia = Convert.ToInt32(dr["SASIA"]);
                        if (sasia == 1)
                        {
                            this.dsFatura.Tables[0].Rows.Remove(dr);
                            this.dsFatura.Tables[0].AcceptChanges();
                            return;
                        }

                        sasia = sasia - 1;
                        dr["SASIA"] = Convert.ToInt32(sasia);

                        cmimi = Convert.ToDouble(dr["CMIMI"]);
                        vlera = cmimi * sasia;

                        dr["VLERA"] = vlera;

                    }
                }
            }

            this.dsFatura.Tables[0].AcceptChanges();

            this.gridaFatura.Row = indeksi;

        }

        private void btnShfaq_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel p = (System.Windows.Forms.Panel)sender;
        }

        private void btnLart_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaFatura.Row;

            if (indeksi > 0)
            {
                this.gridaFatura.Row = indeksi - 1;

              
            }
        }

        private void btnPoshte_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaFatura.Row;
            int numri = this.gridaFatura.RowCount;
            if (numri > 0)
            {
                if (indeksi < numri - 2)
                {
                    this.gridaFatura.Row = indeksi + 1;
                }
            }
        }

        private void gridaFatura_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                int indeksi = this.gridaFatura.Row;
                int idReceta = Convert.ToInt32(this.gridaFatura.GetRow(indeksi).Cells[0].Text);

                this.PastroEkstrat();
                this.MbushEkstra(idReceta);


            }
            catch (Exception ex)
            {
            }
        }

        private void KtheInformacionPerBarin()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("LexoInformacioneRestoranti");

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.printBari = Convert.ToString(ds.Tables[0].Rows[0]["EMRI"]);

            }
            else
            {
                this.printBari = "";
            }
            
        }

        private void btnShfaq_Click_1(object sender, EventArgs e)
        {
            frmZgjidhTavoline frm = new frmZgjidhTavoline();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.dsTavolinat = this.dsTavolinat;
            frm.ShowDialog();

            if (frm.idTavolina == 0)
            {
                return;
            }

            int[] faturat = new int[100];

            int celesi = 0;
            int i = 0;
            string gjendjaTav = "";

            InputController data = new InputController();
            DataSet dsTav = data.KerkesaRead("ShfaqFaturatKorentePerTavoline", frm.idTavolina);

            foreach (DataRow dr in dsTav.Tables[0].Rows)
            {
               
                 faturat[i] = Convert.ToInt32(dr[0]);
                 i = i + 1;
                
            }

            frmTavolina tavolina = new frmTavolina();
            tavolina.idTavolina = frm.idTavolina;
            tavolina.dsTavolinat = dsTavolinat;
            tavolina.nrTavolina = frm.emriTavolina;
            tavolina.idFaturat = faturat;
            tavolina.gjendja = frm.gjendjaTav;
            tavolina.StartPosition = FormStartPosition.CenterScreen;
            tavolina.ShowDialog();

            if (tavolina.veprimi == 0)
            {
                return;
            }

            gjendjaTav = tavolina.gjendja;


            celesi = 0;
            int idTav = 0;

            try
            {
                foreach (DevComponents.DotNetBar.PanelEx tav in panelImazh.Controls)
                {
                    ///DevComponents.DotNetBar.PanelEx tav1 = tav;

                    idTav = Convert.ToInt32(tav.Name);
                    string emri = Convert.ToString(tav.Text);
                    string gj = "";


                    if (idTav == frm.idTavolina)
                    {

                        tav.Style.BackgroundImage = ResManager.Properties.Resources.t_lire;

                    }

                }
            }
            catch (Exception ex)
            {
            }

            this.gjendjaZgjedhur = "L";

            
        }

        private bool KontrolloKamarierPerTavoline(int idTavKam, int idKam)
        {
          

         

            InputController data = new InputController();
            DataSet dsTav = data.KerkesaRead("ShfaqFaturatKorentePerTavoline", idTavKam);

            if (dsTav.Tables[0].Rows.Count == 0)
            {
                return true;
            }

            int nr = dsTav.Tables[0].Rows.Count;
            int[] celesi = new int[nr];

            int i = 0;

            foreach (DataRow dr in dsTav.Tables[0].Rows)
            {

                celesi[i] = Convert.ToInt32(dr["ID_FATURA"]);
                i = i + 1;

            }
 

           

            
            DataSet ds = data.KerkesaRead("LexoTeDhenaPerTavolinen", celesi);

            int idKamarieri = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_PERSONELI"]);

            if (idKam != idKamarieri)
            {
                return false;
            }

            return true;
        }

        private void btnRuaj_Click_1(object sender, EventArgs e)
        {
            if (uiTab.SelectedIndex == 0)
            {
                try
                {
                    string nrTavolina = this.txtNrTavolina.Text.Trim();

                    bool ugjet = false;
                    string tavProva = "";
                    int idTavProva = 0;

                    foreach (DataRow dr in dsTavolinat.Tables[0].Rows)
                    {
                        tavProva = Convert.ToString(dr[2]);

                        if (tavProva == nrTavolina)
                        {
                            ugjet = true;
                            idTavProva = Convert.ToInt32(dr[0]);

                        }
                    }

                    if (ugjet == false)
                    {
                        return;
                    }





                    ///string strIdTavolina = tavProva;
                    ///double dTav = Convert.ToDouble(strIdTavolina);
                    int idTav = idTavProva;
                    string emer_tavolina = tavProva;
                    this.printTavolina = emer_tavolina;
                    string gjendja = "";
                    this.idTavolinaZgjedhur = idTav;
                    this.printTavolina = nrTavolina;
                    this.nrTavolinaZgjedhur = nrTavolina;

                    this.gjendjaZgjedhur = "Z";

                    //int celesi = 0;

                    //foreach (DataRow dr in dsTavolinat.Tables[0].Rows)
                    //{
                    //    celesi = Convert.ToInt32(dr[0]);

                    //    if (celesi == idTav)
                    //    {
                    //        gjendja = Convert.ToString(dr[1]);
                    //        dr[1] = "Z";
                    //    }

                    //}


                    //if (gjendja != "Z")
                    //{

                    //    InputController data1 = new InputController();
                    //    int d = data1.KerkesaUpdate("HapTavoline", idTav);

                    //    foreach (Control c in panelImazh.Controls)
                    //    {
                    //        DevComponents.DotNetBar.PanelEx tav = (DevComponents.DotNetBar.PanelEx)c;

                    //        idTav = Convert.ToInt32(tav.Name);

                    //        if (idTav == this.idTavolinaZgjedhur)
                    //        {

                    //            tav.Style.BackgroundImage = ResManager.Properties.Resources.t_zene;
                    //        }
                    //    }



                    //}

                    //b.BackColor = Color.Violet;

                    this.gbPorosia.Text = "Porosia per tavolinen: " + nrTavolina;
                    uiTabPageTavolinat.TabVisible = false;
                    uiTabPagePorosi.TabVisible = true;
                    uiTab.SelectedTab = uiTab.TabPages[1];
                    this.idTavolina = this.idTavolinaZgjedhur;

                    this.gridaFatura.DataSource = null;
                    this.dsFatura = null;
                    dsFatura = this.KrijoDataSet();
                    this.gridaFatura.DataSource = dsFatura.Tables[0];

                    this.PercaktoViewFatura();
                    this.gridaFatura.Focus();
                    return;
                }
                catch (Exception ex)
                {

                    return;
                }

            }

            int nrArtikuj = this.dsFatura.Tables[0].Rows.Count;
            if (nrArtikuj == 0)
            {
                return;
            }

            frmKontrolloUser frm = new frmKontrolloUser();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.dsKam = this.dsUsers;
            frm.ShowDialog();

            if (frm.veprimi == 0)
            {
                return;
            }

            int idUser = frm.idUser;

            if (this.strKam == "1")
            {
                if (this.KontrolloKamarierPerTavoline(this.idTavolinaZgjedhur, idUser) == false)
                {
                    MessageBox.Show(this, "Kjo tavoline eshte hapur nga nje kamarier tjeter !" + Environment.NewLine + "Ju nuk mund te faturoni kete tavoline !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            this.printUser = frm.perdoruesi;

            if (this.strMinus == "0")
            {
                if (this.KontrolloKufirinRecetat() == true)
                {
                    return;
                }
            }

            this.gridEXBashke.Visible = false;
            this.gridaFatura.Visible = true;
            //this.panelButona.Visible = false;
            //this.panelTavolina.Visible = false;
            this.uiTabPagePorosi.TabVisible = false;
            this.uiTab.SelectedIndex = 0;

            InputController data = new InputController();
            DataSet dsRuaj = this.KrijoDataSetRuaj();

            double totali = 0;
            int nr = this.gridaFatura.RowCount - 1;
            if (nr == 0)
            {
                return;
            }

            int ofertaKey = 0;

            for (int i = 0; i < nr; i++)
            {
                

                ofertaKey = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["CELESI"].Text);

                if (ofertaKey > 0)
                {
                    DataRow dr = dsRuaj.Tables[0].NewRow();

                    dr["CELESI"] = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["CELESI"].Text);
                    dr["LLOJI"] = Convert.ToString(this.gridaFatura.GetRow(i).Cells["LLOJI"].Text);
                    dr["SASIA"] = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["SASIA"].Text);
                    dr["CMIMI"] = Convert.ToDecimal(this.gridaFatura.GetRow(i).Cells["CMIMI"].Text);

                    totali = totali + Convert.ToDouble(this.gridaFatura.GetRow(i).Cells["CMIMI"].Text) * Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["SASIA"].Text);

                    dsRuaj.Tables[0].Rows.Add(dr);
                }
            }

            dsRuaj.Tables[0].AcceptChanges();

            DataSet dsOfertaRuaj = this.KrijoDsOfertat();
            string tipiOferta = "";
            int cmimiIdOferta = 0;
            int cmimiIndeksi = 0;

            for (int i = 0; i < nr; i++)
            {
                

                ofertaKey = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["CELESI"].Text);
                tipiOferta = Convert.ToString(this.gridaFatura.GetRow(i).Cells["LLOJI"].Text);

                if (ofertaKey < 0)
                {
                    switch (tipiOferta)
                    {
                        case "O":


                            DataRow drOferta = dsOfertaRuaj.Tables[0].NewRow();

                            drOferta["ID_OFERTA"] = (-1) * Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["CELESI"].Text);
                            drOferta["INDEKSI"] = Convert.ToString(this.gridaFatura.GetRow(i).Cells["INDEKSI"].Text);
                            drOferta["CMIMI"] = 0;

                            dsOfertaRuaj.Tables[0].Rows.Add(drOferta);

                            break;

                        case "R" :

                            DataRow drReceta = dsOfertaRuaj.Tables[1].NewRow();

                            drReceta["ID_OFERTA"] = (-1) * Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["CELESI"].Text);
                            drReceta["INDEKSI"] = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["INDEKSI"].Text);
                            drReceta["ID_RECETA"] = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["LIMITI"].Text);
                            drReceta["SASIA"] = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["SASIA"].Text);

                            dsOfertaRuaj.Tables[1].Rows.Add(drReceta);

                            break;

                        case "C" :

                            cmimiIdOferta = (-1) * Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["CELESI"].Text);
                            cmimiIndeksi = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["INDEKSI"].Text);

                            foreach (DataRow dr in dsOfertaRuaj.Tables[0].Rows)
                            {
                                if (Convert.ToInt32(dr["ID_OFERTA"]) == cmimiIdOferta && Convert.ToInt32(dr["INDEKSI"]) == cmimiIndeksi)
                                {
                                    dr["CMIMI"] = Convert.ToDecimal(this.gridaFatura.GetRow(i).Cells["VLERA"].Text);
                                    dsOfertaRuaj.Tables[0].AcceptChanges();
                                }
                            }

                            totali = totali + Convert.ToDouble(this.gridaFatura.GetRow(i).Cells["VLERA"].Text);

                            break;

                        default :
                            break;
                    }

                    dsOfertaRuaj.AcceptChanges();
                }
            }



            double skonto = 0;
            int perqindja = 0;

            string strSkonto = "";
            strSkonto = this.txtSkonto.Text;

            if (this.optVlera.Checked == true)
            {
                skonto = Convert.ToDouble(strSkonto);
            }
            else
            {
                skonto = totali * Convert.ToInt32(strSkonto) / 100;
            }

            //int idUser = MDIResManager.idPerdoruesi;
            int idKlienti = 1;
            int idFormaPagesa = 1;
            //int idTavolina = 1;
            string nrFatura = this.KtheNrFatura();
            this.printNrFatura = nrFatura;
            int b = data.KerkesaUpdate("KrijoFature", idUser, this.idTavolina, idKlienti, idFormaPagesa, totali, skonto, nrFatura, dsRuaj, dsOfertaRuaj);

            if (b != 0)
            {
                MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e bazes se te dhenave!", "Kudes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow drNew = this.dsTavolinat.Tables[1].NewRow();


            drNew[0] = this.idTavolinaZgjedhur;
            drNew[1] = this.KtheIdFatura();

            ////int idFatTav = this.KtheIdFatura();

            ///--> konsumon artikujt e banakut

            this.KonsumoArtikujtBanaku();

            //////////////////////////////

            this.dsTavolinat.Tables[1].Rows.Add(drNew);

            this.dsTavolinat.Tables[1].AcceptChanges();
            string gjendjaTav = "";
            foreach (DataRow dr in dsTavolinat.Tables[0].Rows)
            {
                

                if (Convert.ToInt32(dr[0]) == this.idTavolinaZgjedhur)
                {
                    gjendjaTav = Convert.ToString(dr[1]);
                    dr[1] = "Z";
                }

            }


            if (gjendjaTav != "Z")
            {

                InputController data10 = new InputController();
                int d = data10.KerkesaUpdate("HapTavoline", this.idTavolinaZgjedhur);

                
                try
                {
                    foreach (DevComponents.DotNetBar.PanelEx tav in panelImazh.Controls)
                    {
                        ///DevComponents.DotNetBar.PanelEx tav1 = tav;

                       


                        if (Convert.ToInt32(tav.Name) == this.idTavolinaZgjedhur)
                        {

                            tav.Style.BackgroundImage = ResManager.Properties.Resources.t_zene;

                        }

                    }
                }
                catch (Exception ex)
                {
                }

            }

            this.printArtikujt = new string[nr];
            this.printCmimet = new string[nr];
            this.printSasite = new string[nr];
            this.printVlerat = new string[nr];

            int j = 0;
            foreach (DataRow dr in dsFatura.Tables[0].Rows)
            {
                this.printArtikujt[j] = Convert.ToString(dr["EMRI"]);
                if (Convert.IsDBNull(dr["CMIMI"]) == false)
                {
                    this.printCmimet[j] = Convert.ToString(dr["CMIMI"]);
                }
                else
                {
                    this.printCmimet[j] = "";
                }

                if (Convert.IsDBNull(dr["SASIA"]) == false)
                {
                    this.printSasite[j] = Convert.ToString(dr["SASIA"]);
                }
                else
                {
                    this.printSasite[j] = "";
                }

                if (Convert.IsDBNull(dr["VLERA"]) == false)
                {
                    this.printVlerat[j] = Convert.ToString(dr["VLERA"]);
                }
                else
                {
                    this.printVlerat[j] = "";
                }

               

                j = j + 1;
            }
            this.printTotali = Convert.ToString(totali);

            ///this.printDok.PrinterSettings.PrinterName "
            ///

            string strBanaku = "";
            int nrBanaku = 0;

            
            
            
            foreach (DataRow dr in this.dsPrinterTavolina.Tables[0].Rows)
            {
                strBanaku = Convert.ToString(dr[0]);
                nrBanaku = Convert.ToInt32(dr[1]);

                
                printDok.PrinterSettings.PrinterName = strBanaku;
                for (int i = 0; i < nrBanaku; i++)
                {
                    printDok.Print();
                }

            }



            //foreach (DataRow dr in this.dsPrinterBanaku.Tables[0].Rows)
            //{
            //    strBanaku = Convert.ToString(dr[0]);
            //    nrBanaku = Convert.ToInt32(dr[1]);

            //    printDocBanaku.PrinterSettings.PrinterName = strBanaku;
            //    for (int i = 0; i < nrBanaku; i++)
            //    {
            //        printDocBanaku.Print();
            //    }

            //}

            

            int idRecPrint = 0;
            string strPrinteri = "";
            bool zgjedhur = false;
            int indeksPrinteri = 0;

            int celesi1 = 0;
            foreach (DataRow dr in dsFatura.Tables[0].Rows)
            {
                idRecPrint = Convert.ToInt32(dr[0]);

                if (idRecPrint > 0)
                {
                }

                foreach (DataRow drOther in this.dsPrinterRecete.Tables[0].Rows)
                {
                    celesi1 = Convert.ToInt32(drOther[0]);
                    strPrinteri = Convert.ToString(drOther[1]).Trim();
                    zgjedhur = Convert.ToBoolean(drOther[2]);

                    if (idRecPrint == celesi1)
                    {
                        if (zgjedhur == true)
                        {
                            indeksPrinteri = this.KtheIndeksPrinteri(strPrinteri);

                            DataRow dr1 = this.dsPrintimi.Tables[indeksPrinteri].NewRow();

                            dr1["ARTIKULLI"] = Convert.ToString(dr["EMRI"]);
                            dr1["CMIMI"] = Convert.ToString(dr["CMIMI"]);
                            dr1["SASIA"] = Convert.ToString(dr["SASIA"]);
                            dr1["VLERA"] = Convert.ToString(dr["VLERA"]);

                            this.dsPrintimi.Tables[indeksPrinteri].Rows.Add(dr1);

                        }
                    }

                }

                j = j + 1;
            }

            int p = 0;

            foreach (DataRow dr in this.dsPrinters.Tables[0].Rows)
            {
                indeksPrinteri = Convert.ToInt32(dr[1]);
                strPrinteri = Convert.ToString(dr[0]);

                this.dsPrintimi.Tables[indeksPrinteri].AcceptChanges();

                if (this.dsPrintimi.Tables[indeksPrinteri].Rows.Count > 0)
                {
                    j = this.dsPrintimi.Tables[indeksPrinteri].Rows.Count;

                    this.printArtikujt = new string[j];
                    this.printCmimet = new string[j];
                    this.printSasite = new string[j];
                    this.printVlerat = new string[j];

                    p = 0;

                    foreach(DataRow drP in this.dsPrintimi.Tables[indeksPrinteri].Rows)
                    {
                        this.printArtikujt[p] = Convert.ToString(drP["ARTIKULLI"]);
                        this.printCmimet[p] = Convert.ToString(drP["CMIMI"]);
                        this.printSasite[p] = Convert.ToString(drP["SASIA"]);
                        this.printVlerat[p] = Convert.ToString(drP["VLERA"]);

                        p = p + 1;
                    }

                    printDocBanaku.PrinterSettings.PrinterName = strPrinteri;
                    printDocBanaku.Print();
                }

            }

            int nrPrinteratPastro = PrinterSettings.InstalledPrinters.Count;



            for (int i = 0; i < nrPrinteratPastro; i++)
            {
                this.dsPrintimi.Tables[i].Rows.Clear();

            }




            



            //printDok.Print();
            //printDocBanaku.Print();

            if (this.modeTavolinat == 1)
            {
                this.gridEXBashke.Visible = false;
                this.gridaFatura.Visible = true;
                //this.panelButona.Visible = false;
                //this.panelTavolina.Visible = false;
                this.uiTab.TabPages[0].TabVisible = true;
                this.uiTab.TabPages[1].TabVisible = false;
                this.uiTab.SelectedTab = this.uiTab.TabPages[0];

                this.PercaktoViewTables();

                this.gridaFatura.DataSource = null;
                this.dsFatura = null;
                this.dsFatura = this.KrijoDataSet();
                this.gridaFatura.DataSource = this.dsFatura.Tables[0];
            }
            else
            {
                this.gridaFatura.DataSource = null;
                this.dsFatura = null;
                this.dsFatura = this.KrijoDataSet();
                this.gridaFatura.DataSource = this.dsFatura.Tables[0];
            }
        }

      
        private void btnAnullo_Click_1(object sender, EventArgs e)
        {
            if (this.modeTavolinat == 1)
            {
                if (this.uiTab.SelectedIndex == 0)
                {
                    return;
                }
                else
                {
                    this.gridEXBashke.Visible = false;
                    this.gridaFatura.Visible = true;
                    //this.panelButona.Visible = false;
                    //this.panelTavolina.Visible = false;
                    this.uiTab.TabPages[0].TabVisible = true;
                    this.uiTab.TabPages[1].TabVisible = false;
                    exBarFavorite.Focus();

                    this.PercaktoViewTables();
                }
            }
            else
            {

                this.gridaFatura.DataSource = null;
                this.dsFatura = null;
                this.dsFatura = this.KrijoDataSet();
                this.gridaFatura.DataSource = this.dsFatura.Tables[0];
            }
        }

        private void exBarFavorite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.uiTab.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                string shtypur = e.KeyChar.ToString();
                //string numriStr = shtypur.Substring(1, 1);
                int numri = -1;

                try
                {
                    numri = Convert.ToInt32(shtypur);
                }
                catch (Exception ex)
                {
                    return;
                }

                if (numri >= this.nrFavorite)
                {
                    return;
                }

                if (numri < 0)
                {
                    return;
                }

                string emri = this.emratRecetat[numri];
                int celesi = this.idRecetat[numri];

                string lloji = "R";

                this.MenuFavoriteKlikoElement(celesi, lloji, emri);
            }
        }

        private void exBarFavorite_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void MDIResManager_KeyDown(object sender, KeyEventArgs e)
        {
          
          
        }

        private void MDIResManager_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.uiTab.TabIndex == 0)
            {
                return;
            }
            else
            {
                string shtypur = e.KeyChar.ToString();
                //string numriStr = shtypur.Substring(1, 1);
                int numri = -1;

                try
                {
                    numri = Convert.ToInt32(shtypur);
                }
                catch (Exception ex)
                {
                    return;
                }

                if (numri >= this.nrFavorite)
                {
                    return;
                }

                if (numri < 0)
                {
                    return;
                }

                string emri = this.emratRecetat[numri];
                int celesi = this.idRecetat[numri];

                string lloji = "R";

                this.MenuFavoriteKlikoElement(celesi, lloji, emri);
            }
                
            
        }

        private void exBarFavorite_Click(object sender, EventArgs e)
        {
            exBarFavorite.Focus();
        }

        private void MenuFavoriteKlikoElement(int celesi, string tipi, string emri)
        {
            InputController data = new InputController();
            DataSet ds = null;
            int idArtikulli = 0;
            

           
                string emriArtikulli = emri;
                idArtikulli = celesi;
                string llojiArtikulli = tipi;

                if (this.GjendetArtikulli(idArtikulli, llojiArtikulli))
                {
                    this.PastroEkstrat();
                    this.MbushEkstra(idArtikulli);
                    return;
                }

                ds = data.KerkesaRead("LexoTeDhenaPerArtikullin", llojiArtikulli, idArtikulli);

                if (ds == null)
                {
                    DialogResult result = MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ds.Tables[0].Rows.Count == 0)
                {
                    DialogResult result = MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double numriTotal = Convert.ToDouble(ds.Tables[0].Rows[0]["NUMRI_TOTAL"]);
                string nameStock = Convert.ToString(ds.Tables[0].Rows[0]["EMRI"]);

                if (this.strMinus == "0")
                {
                    if (numriTotal < 1)
                    {
                        MessageBox.Show("Ju nuk keni asnje artikull  '" + nameStock + "'  ne magazine.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                decimal cmimiKontrolli = Convert.ToDecimal(ds.Tables[0].Rows[0]["VLERA"]);

                if (cmimiKontrolli == 0)
                {
                    MessageBox.Show("Cmimi momental i per artikullin '" + nameStock + "'  eshte 0." + Environment.NewLine + "Ju nuk mund te shisni me cmim 0 !", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow dr = dsFatura.Tables[0].NewRow();

                if (llojiArtikulli == "A")
                {
                    dr["CELESI"] = ds.Tables[0].Rows[0]["CELESI"];
                    dr["EMRI"] = ds.Tables[0].Rows[0]["EMRI"];
                    dr["CMIMI"] = ds.Tables[0].Rows[0]["VLERA"];
                    dr["SASIA"] = 1;
                    dr["VLERA"] = Convert.ToDouble(ds.Tables[0].Rows[0]["VLERA"]);
                    dr["NJESIA"] = ds.Tables[0].Rows[0]["NJESIA"];
                    dr["LIMITI"] = ds.Tables[0].Rows[0]["LIMITI"];
                    dr["LLOJI"] = "A";
                    dr["INDEKSI"] = 0;

                    dsFatura.Tables[0].Rows.Add(dr);

                }
                else
                {
                    dr["CELESI"] = ds.Tables[0].Rows[0]["CELESI"];
                    dr["EMRI"] = ds.Tables[0].Rows[0]["EMRI"];
                    dr["CMIMI"] = ds.Tables[0].Rows[0]["VLERA"];
                    dr["SASIA"] = 1;
                    dr["VLERA"] = Convert.ToDouble(ds.Tables[0].Rows[0]["VLERA"]);
                    dr["LLOJI"] = "R";
                    dr["INDEKSI"] = 0;


                    dsFatura.Tables[0].Rows.Add(dr);
                }

                dsFatura.Tables[0].AcceptChanges();

                int numri = dsFatura.Tables[0].Rows.Count;

                this.gridaFatura.DataSource = null;
                this.gridaFatura.DataSource = dsFatura.Tables[0];
                this.gridaFatura.Focus();
                this.gridaFatura.Row = numri - 1;

                this.PastroEkstrat();
                this.MbushEkstra(idArtikulli);

                return;

            


         }

        private void gridaFatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.uiTab.TabIndex == 0)
            {
                return;
            }
            else
            {
                string shtypur = e.KeyChar.ToString();
                //string numriStr = shtypur.Substring(1, 1);
                int numri = -1;

                try
                {
                    numri = Convert.ToInt32(shtypur);
                }
                catch (Exception ex)
                {
                    return;
                }

                if (numri >= this.nrFavorite)
                {
                    return;
                }

                if (numri < 0)
                {
                    return;
                }

                string emri = this.emratRecetat[numri];
                int celesi = this.idRecetat[numri];

                string lloji = "R";

                this.MenuFavoriteKlikoElement(celesi, lloji, emri);
            }
        }

        private void KlikoPlusin()
        {
            int indeksi = this.gridaFatura.Row;
            int nrReshta = this.gridaFatura.RowCount;

            if (indeksi < 0 || indeksi >= nrReshta - 1)
            {
                return;
            }

            int celesi = Convert.ToInt32(this.gridaFatura.GetRow(indeksi).Cells[0].Text);

            double cmimi = 0;
            int sasia = 0;

            double vlera = 0;



            int idArtikulli = 0;

            foreach (DataRow dr in this.dsFatura.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);

                if (idArtikulli == celesi)
                {
                    sasia = Convert.ToInt32(dr["SASIA"]);
                    sasia = sasia + 1;
                    dr["SASIA"] = Convert.ToInt32(sasia);

                    cmimi = Convert.ToDouble(dr["CMIMI"]);
                    vlera = cmimi * sasia;

                    dr["VLERA"] = vlera;

                }
            }

            this.dsFatura.Tables[0].AcceptChanges();

            //this.gridaFatura.GetRow(indeksi).Cells[4].Text = sasia.ToString();
            //this.gridaFatura.GetRow(indeksi).Cells[5].Text = vlera.ToString();

            this.gridaFatura.Row = indeksi;
        }

        private void KlikoMinusin()
        {
            int indeksi = this.gridaFatura.Row;
            int nrReshta = this.gridaFatura.RowCount;

            if (indeksi < 0 || indeksi >= nrReshta - 1)
            {
                return;
            }

            if (indeksi < 0)
            {
                return;
            }

            int celesi = Convert.ToInt32(this.gridaFatura.GetRow(indeksi).Cells[0].Text);

            double cmimi = 0;
            int sasia = 0;

            double vlera = 0;



            int idArtikulli = 0;

            foreach (DataRow dr in this.dsFatura.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);

                if (idArtikulli == celesi)
                {
                    sasia = Convert.ToInt32(dr["SASIA"]);
                    if (sasia == 1)
                    {
                        this.dsFatura.Tables[0].Rows.Remove(dr);
                        this.dsFatura.Tables[0].AcceptChanges();
                        return;
                    }

                    sasia = sasia - 1;
                    dr["SASIA"] = Convert.ToInt32(sasia);

                    cmimi = Convert.ToDouble(dr["CMIMI"]);
                    vlera = cmimi * sasia;

                    dr["VLERA"] = vlera;

                }
            }

            this.dsFatura.Tables[0].AcceptChanges();

            this.gridaFatura.Row = indeksi;
        }

        private void RuajFaturen()
        {
            int nrArtikuj = this.dsFatura.Tables[0].Rows.Count;
            if (nrArtikuj == 0)
            {
                return;
            }

            this.gridEXBashke.Visible = false;
            this.gridaFatura.Visible = true;
            //this.panelButona.Visible = false;
            //this.panelTavolina.Visible = false;
            this.uiTabPagePorosi.TabVisible = false;
            this.uiTab.SelectedIndex = 0;

            InputController data = new InputController();
            DataSet dsRuaj = this.KrijoDataSetRuaj();

            double totali = 0;
            int nr = this.gridaFatura.RowCount - 1;
            if (nr == 0)
            {
                return;
            }

            for (int i = 0; i < nr; i++)
            {
                DataRow dr = dsRuaj.Tables[0].NewRow();

                dr["CELESI"] = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["CELESI"].Text);
                dr["LLOJI"] = Convert.ToString(this.gridaFatura.GetRow(i).Cells["LLOJI"].Text);
                dr["SASIA"] = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["SASIA"].Text);

                totali = totali + Convert.ToDouble(this.gridaFatura.GetRow(i).Cells["CMIMI"].Text) * Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["SASIA"].Text);

                dsRuaj.Tables[0].Rows.Add(dr);
            }

            dsRuaj.Tables[0].AcceptChanges();

            double skonto = 0;
            int perqindja = 0;

            string strSkonto = "";
            strSkonto = this.txtSkonto.Text;

            if (this.optVlera.Checked == true)
            {
                skonto = Convert.ToDouble(strSkonto);
            }
            else
            {
                skonto = totali * Convert.ToInt32(strSkonto) / 100;
            }

            int idUser = MDIResManager.idPerdoruesi;
            int idKlienti = 1;
            int idFormaPagesa = 1;
            //int idTavolina = 1;
            string nrFatura = this.KtheNrFatura();
            this.printNrFatura = nrFatura;
            int b = 0; // data.KerkesaUpdate("KrijoFature", idUser, this.idTavolina, idKlienti, idFormaPagesa, totali, skonto, nrFatura, dsRuaj);

            if (b != 0)
            {
                MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e bazes se te dhenave!", "Kudes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow drNew = this.dsTavolinat.Tables[1].NewRow();


            drNew[0] = this.idTavolinaZgjedhur;
            drNew[1] = this.KtheIdFatura();

            this.dsTavolinat.Tables[1].Rows.Add(drNew);

            this.dsTavolinat.Tables[1].AcceptChanges();

            this.printArtikujt = new string[nr];
            this.printCmimet = new string[nr];
            this.printSasite = new string[nr];
            this.printVlerat = new string[nr];

            int j = 0;
            foreach (DataRow dr in dsFatura.Tables[0].Rows)
            {
                this.printArtikujt[j] = Convert.ToString(dr["EMRI"]);
                this.printCmimet[j] = Convert.ToString(dr["CMIMI"]);
                this.printSasite[j] = Convert.ToString(dr["SASIA"]);
                this.printVlerat[j] = Convert.ToString(dr["VLERA"]);

                j = j + 1;
            }
            this.printTotali = Convert.ToString(totali);
            printDok.Print();


            this.gridEXBashke.Visible = false;
            this.gridaFatura.Visible = true;
            //this.panelButona.Visible = false;
            //this.panelTavolina.Visible = false;
            this.uiTab.TabPages[0].TabVisible = true;
            this.uiTab.TabPages[1].TabVisible = false;
            this.uiTab.SelectedTab = this.uiTab.TabPages[0];

        }

        private void gridaFatura_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.uiTab.TabIndex == 0)
            {
                return;
            }
            else
            {
                int kodi = e.KeyValue;
                if (kodi == 107)
                {
                    this.KlikoPlusin();
                }
                else if (kodi == 109)
                {
                    this.KlikoMinusin();
                }
                else if (kodi == 13)
                {
                    this.RuajFaturen();
                }
                else
                {
                }
            }

        }

        private void exArtikujt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (this.uiTab.TabIndex == 0)
            {
                return;
            }
            else
            {
                string shtypur = e.KeyChar.ToString();
                //string numriStr = shtypur.Substring(1, 1);
                int numri = -1;

                try
                {
                    numri = Convert.ToInt32(shtypur);
                }
                catch (Exception ex)
                {
                    return;
                }

                if (numri >= this.nrFavorite)
                {
                    return;
                }

                if (numri < 0)
                {
                    return;
                }

                string emri = this.emratRecetat[numri];
                int celesi = this.idRecetat[numri];

                string lloji = "R";

                this.MenuFavoriteKlikoElement(celesi, lloji, emri);
            }
        }

        private void turnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTurni frm = new frmTurni();
            //frm.idKamarieri = idPerdoruesi;
            //frm.Show();
        }

        //private void btnKliko_Click(object sender, EventArgs e)
        //{
            
        //    try
        //    {
        //        string nrTavolina = this.txtNrTavolina.Text.Trim();

        //        bool ugjet = false;
        //        string tavProva = "";
        //        int idTavProva = 0;

        //        foreach(DataRow dr in dsTavolinat.Tables[0].Rows)
        //        {
        //            tavProva = Convert.ToString(dr[2]);

        //            if (tavProva == nrTavolina)
        //            {
        //                ugjet = true;
        //                idTavProva = Convert.ToInt32(dr[0]);
        //            }
        //        }

        //        if (ugjet == false)
        //        {
        //            return;
        //        }


        //        ///string strIdTavolina = tavProva;
        //        ///double dTav = Convert.ToDouble(strIdTavolina);
        //        int idTav = idTavProva;
        //        string emer_tavolina = tavProva;
        //        this.printTavolina = emer_tavolina;
        //        string gjendja = "";
        //        this.idTavolinaZgjedhur = idTav;
        //        this.gjendjaZgjedhur = "Z";

        //        int celesi = 0;

        //        foreach (DataRow dr in dsTavolinat.Tables[0].Rows)
        //        {
        //            celesi = Convert.ToInt32(dr[0]);

        //            if (celesi == idTav)
        //            {
        //                gjendja = Convert.ToString(dr[1]);
        //                dr[1] = "Z";
        //            }

        //        }


        //        if (gjendja != "Z")
        //        {

        //            InputController data = new InputController();
        //            int d = data.KerkesaUpdate("HapTavoline", idTav);
        //            ////b.Style.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_zene.png");

        //        }

        //        //b.BackColor = Color.Violet;

        //        this.gbPorosia.Text = "Porosia per tavolinen: " + emer_tavolina;
        //        uiTabPageTavolinat.TabVisible = false;
        //        uiTabPagePorosi.TabVisible = true;
        //        uiTab.SelectedTab = uiTab.TabPages[1];
        //        this.idTavolina = idTav;

        //        this.gridaFatura.DataSource = null;
        //        this.dsFatura = null;
        //        dsFatura = this.KrijoDataSet();
        //        this.gridaFatura.DataSource = dsFatura.Tables[0];
        //    }
        //    catch (Exception ex)
        //    {

        //        return;
        //    }
        //}

        private void PrintoFaturenPC(int idFatura)
        {
            InputController data = new InputController();

            DataSet ds = data.KerkesaRead("PrintoFaturenPC", idFatura);

            int nr = ds.Tables[0].Rows.Count;

            this.printArtikujt = new string[nr];
            this.printCmimet = new string[nr];
            this.printSasite = new string[nr];
            this.printVlerat = new string[nr];

            int j = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.printArtikujt[j] = Convert.ToString(dr["EMRI"]);
                this.printCmimet[j] = Convert.ToString(dr["VLERA"]);
                this.printSasite[j] = Convert.ToString(dr["SASIA"]);
                this.printVlerat[j] = Convert.ToString(dr["TOTALI"]);

                j = j + 1;
            }
            this.printTotali = Convert.ToString(ds.Tables[1].Rows[0]["TOTALI"]);
            this.printUser = Convert.ToString(ds.Tables[1].Rows[0]["KAMARIERI"]);
            this.printTavolina = Convert.ToString(ds.Tables[1].Rows[0]["TAVOLINA"]);
            this.printNrFatura = Convert.ToString(ds.Tables[1].Rows[0]["NR_FATURE"]);

            this.printDok.Print();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ResManagerDataSet resDs = new ResManagerDataSet();
            //ResManagerDataSetTableAdapters.FATURATTableAdapter fta = new ResManager.ResManagerDataSetTableAdapters.FATURATTableAdapter();
            //fta.FillByDateTime(resDs.FATURAT);




            //idFaturaNew = resDs.Tables[0].Rows.Count;
            //int idFatura = 0;

            //if (idFaturaNew > idFaturaOld)
            //{
            //    for (int i = idFaturaOld ; i < idFaturaNew; i++)
            //    {
            //        idFatura = Convert.ToInt32(resDs.Tables[0].Rows[i]["ID_FATURA"]);
            //        this.PrintoFaturenPC(idFatura);
            //    }
            //}

            //idFaturaOld = idFaturaNew;


        }

        private void btnShtoOferte_Click(object sender, EventArgs e)
        {
            frmOffer frm = new frmOffer();
            frm.ShowDialog();

            if (frm.veprimi == 1)
            {
                this.nrOfertat = this.nrOfertat + 1;

                DataRow dr = this.dsFatura.Tables[0].NewRow();

                dr["CELESI"] = (-1) * frm.idOfertaZgjedhur;
                dr["EMRI"] = frm.emriOfertaZgjedhur;
                //dr["CMIMI"] = "";
                //dr["SASIA"] = "";
                //dr["NJESIA"] = "";
                //dr["VLERA"] = "";
                dr["LIMITI"] = 0;
                dr["LLOJI"] = "O";
                dr["INDEKSI"] = this.nrOfertat;
                

                this.dsFatura.Tables[0].Rows.Add(dr);

                foreach (DataRow drNew in frm.dsRecetat.Tables[0].Rows)
                {
                    DataRow drOther = this.dsFatura.Tables[0].NewRow();

                    drOther["CELESI"] = (-1) * frm.idOfertaZgjedhur;
                    drOther["EMRI"] = "        " + Convert.ToString(drNew["RECETA"]);
                    //drOther["CMIMI"] = "";
                    drOther["SASIA"] = drNew["SASIA"];
                    //drOther["VLERA"] = "";
                    drOther["LIMITI"] = drNew["ID_RECETA"];
                    drOther["LLOJI"] = "R";
                    drOther["INDEKSI"] = this.nrOfertat;


                    this.dsFatura.Tables[0].Rows.Add(drOther);
                    
                }

                DataRow drCmimi = this.dsFatura.Tables[0].NewRow();

                drCmimi["CELESI"] = (-1) * frm.idOfertaZgjedhur;
                drCmimi["EMRI"] = "----------------------------------";
                //drCmimi["CMIMI"] = "";
                //drCmimi["SASIA"] = "";
                //drCmimi["NJESIA"] = "";
                drCmimi["VLERA"] = frm.cmimiOferta;
                drCmimi["LIMITI"] = 0;
                drCmimi["LLOJI"] = "C";
                drCmimi["INDEKSI"] = this.nrOfertat;


                this.dsFatura.Tables[0].Rows.Add(drCmimi);

                this.dsFatura.Tables[0].AcceptChanges();
            }
        }

        private void btnFshiOferte_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaFatura.Row;
            int nrReshta = this.gridaFatura.RowCount;

            if (indeksi < 0 || indeksi >= nrReshta - 1)
            {
                return;
            }

            if (indeksi < 0)
            {
                return;
            }

            int celesi = Convert.ToInt32(this.gridaFatura.GetRow(indeksi).Cells[0].Text);
            

            if (celesi > 0)
            {
                return;
            }

            int numri = Convert.ToInt32(this.gridaFatura.GetRow(indeksi).Cells[8].Text);

            int[] indeksiRows = new int[20];
            int nrRows = 0;
            int j = 0;
            int idArtikulli = 0;
            int nrIndeksi = 0;

            foreach (DataRow dr in this.dsFatura.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);
                nrIndeksi = Convert.ToInt32(dr[8]);
               
                if (idArtikulli == celesi && nrIndeksi == numri)
                {
                    indeksiRows[j] = nrRows - j;
                    j = j + 1;

                }

                nrRows = nrRows + 1;
                
            }

            for (int i = 0; i < j; i++)
            {
                this.dsFatura.Tables[0].Rows.RemoveAt(indeksiRows[i]);
            }

            this.dsFatura.Tables[0].AcceptChanges();

            this.nrOfertat = this.nrOfertat - 1;

            //this.gridaFatura.GetRow(indeksi).Cells[4].Text = sasia.ToString();
            //this.gridaFatura.GetRow(indeksi).Cells[5].Text = vlera.ToString();

            
        }

        /// <summary>
        /// Kontrollon per kufirin e sasise se recetave te kerkuara
        /// </summary>
        private bool KontrolloKufirinRecetat()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("SASIA", typeof(Int32));
            ds.Tables[0].Columns.Add("KUFIRI", typeof(Int32));
            ds.Tables[0].Columns.Add("RECETA", typeof(string));

            ds.Tables[0].AcceptChanges();

            int idReceta = 0;
            int celesi = 0;
            bool gjendet = false;
            int kufiri = 0;
            string tipi = "";

            foreach (DataRow dr in dsFatura.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["CELESI"]);
                gjendet = false;

                if (celesi > 0)
                {
                    idReceta = celesi;

                    foreach (DataRow drNew in ds.Tables[0].Rows)
                    {
                        

                        if (idReceta == Convert.ToInt32(drNew["ID_RECETA"]))
                        {
                            gjendet = true;
                            drNew["SASIA"] = Convert.ToInt32(drNew["SASIA"]) + Convert.ToInt32(dr["SASIA"]);
                            drNew["KUFIRI"] = Convert.ToInt32(dr["KUFIRI"]);

                            ds.Tables[0].AcceptChanges();
                        }
                    }

                    if (gjendet == false)
                    {
                        DataRow dr1 = ds.Tables[0].NewRow();

                        dr1["ID_RECETA"] = idReceta;
                        dr1["SASIA"] = dr["SASIA"];
                        dr1["KUFIRI"] = dr["KUFIRI"];
                        dr1["RECETA"] = dr["EMRI"];

                        ds.Tables[0].Rows.Add(dr1);

                        ds.Tables[0].AcceptChanges();
                    }
                }
                else
                {
                    
                    tipi = Convert.ToString(dr["LLOJI"]);

                    if (tipi == "R")
                    {
                        idReceta = Convert.ToInt32(dr["LIMITI"]);

                        foreach (DataRow drNew in ds.Tables[0].Rows)
                        {


                            if (idReceta == Convert.ToInt32(drNew["ID_RECETA"]))
                            {
                                gjendet = true;
                                drNew["SASIA"] = Convert.ToInt32(drNew["SASIA"]) + Convert.ToInt32(dr["SASIA"]);


                                ds.Tables[0].AcceptChanges();
                            }
                        }

                        if (gjendet == false)
                        {
                            DataRow dr1 = ds.Tables[0].NewRow();

                            dr1["ID_RECETA"] = idReceta;
                            dr1["SASIA"] = dr["SASIA"];
                            dr1["KUFIRI"] = 0;
                            dr1["RECETA"] = dr["EMRI"];

                            ds.Tables[0].Rows.Add(dr1);

                            ds.Tables[0].AcceptChanges();
                        }
                    }
                }
            }

            InputController data = new InputController();
            DataSet dsKthe = data.KerkesaRead("KtheKufirinPerRecetat", ds);

            if (dsKthe == null)
            {
                MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e te dhenave !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (dsKthe.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show(this, "Per produktin  " + Convert.ToString(dsKthe.Tables[0].Rows[0]["RECETA"]) + "  gjendja ne magazine eshte  " + Convert.ToInt32(dsKthe.Tables[0].Rows[0]["SASIA"]).ToString() + " .", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }

            return false; 
        }

        private void btnBashko_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogimi frm = new frmLogimi();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.dsKam = this.dsUsers;

            frm.ShowDialog();

            if (frm.veprimi == 1)
            {
                DataRow dr = this.dsUsers.Tables[0].NewRow();

                dr["ID_PERSONELI"] = frm.idUser;
                dr["PERDORUESI"] = frm.perdoruesi;
                dr["FJALEKALIMI"] = frm.fjalekalimi;

                this.dsUsers.Tables[0].Rows.Add(dr);
                this.dsUsers.Tables[0].AcceptChanges();

            }
        }

        private DataSet KrijoDsKamarieret()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_PERSONELI", typeof(Int32));
            ds.Tables[0].Columns.Add("PERDORUESI", typeof(string));
            ds.Tables[0].Columns.Add("FJALEKALIMI", typeof(String));
            

            ds.AcceptChanges();

            return ds;

        }

        private void printDocBanaku_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string drawString = "";
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float posX = 10;
            float posY = 0;
            PointF drawPoint = new PointF();

            string dataSot = System.DateTime.Today.ToString("dd/MM/yyyy");
            string oraTani = System.DateTime.Now.ToString("HH:mm");

            drawString = "Fatura nr: " + this.printNrFatura;
            //PointF drawPoint = new PointF(70.0F, 10.0F)
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            //drawPoint = new PointF(10.0F, 20.0F);
            posX = 10;
            posY = 15;


            drawString = "----------------------------------------------------------------";

            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            drawString = "Data: " + dataSot + " , Ora: " + oraTani;
            //drawPoint = new PointF(10.0F, 30.0F);

            posX = 10;
            posY = 30;

            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            posX = 10;
            posY = 43;
            drawString = "Tavolina: " + this.printTavolina + " ,       Kamarieri: " + this.printUser;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);



            drawString = "----------------------------------------------------------------";
            //drawPoint = new PointF(10.0F, 40.0F);
            posX = 10;
            posY = 58;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            drawString = "Emertimi";
            //drawPoint = new PointF(10.0F, 50.0F);
            posX = 10;
            posY = 73;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            drawString = "Cmimi";
            //drawPoint = new PointF(10.0F, 50.0F);
            posX = 110;
            posY = 73;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            drawString = "Sasia";
            //drawPoint = new PointF(10.0F, 50.0F);
            posX = 155;
            posY = 73;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            drawString = "Vlera";
            //drawPoint = new PointF(10.0F, 50.0F);
            posX = 195;
            posY = 73;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            drawString = "----------------------------------------------------------------";
            drawPoint = new PointF(10.0F, 60.0F);
            posX = 10;
            posY = 83;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            int nr1 = this.printArtikujt.Length;

            for (int i = 0; i < nr1; i++)
            {
                //posX = 10;
                //posY = posY + 15;

                //drawString = "--------------------------------------------------";
                ////drawPoint = new PointF(10.0F,  70.0F);
                //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                drawString = this.printArtikujt[i];
                posX = 10;
                posY = posY + 20;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                drawString = this.printCmimet[i];
                posX = 118;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                drawString = this.printSasite[i];
                posX = 163;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                drawString = this.printVlerat[i];
                posX = 200;
                e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            }

            posX = 10;
            posY = posY + 15;

            drawString = "----------------------------------------------------------------";

            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            posX = 10;
            posY = posY + 15;

            drawString = "Vlera totale :";


            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            posX = 200;

            drawString = this.printTotali;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            posX = 10;
            posY = posY + 15;


            drawString = "----------------------------------------------------------------";

            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
            posX = 10;
            posY = posY + 3;

            drawString = "----------------------------------------------------------------";

            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
        }

       


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMbyllTurnin frm = new frmMbyllTurnin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.dsKam = this.dsUsers;

            frm.ShowDialog();

            int celesi = 0;

            if (frm.veprimi == 1)
            {
                foreach (DataRow dr in this.dsUsers.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr[0]);

                    if (celesi == frm.idUser)
                    {
                        this.dsUsers.Tables[0].Rows.Remove(dr);
                        this.dsUsers.Tables[0].AcceptChanges();
                        return;
                    }
                }
            }
        }

        private void printeratToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
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

        private void LexoXmlPrinterat()
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
                                dr1 = this.dsPrinterBanaku.Tables[0].NewRow();
                                korenti = "Banaku";

                            }
                            else if (str == "Tavolina")
                            {
                                dr2 = this.dsPrinterTavolina.Tables[0].NewRow();
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
                                    this.dsPrinterBanaku.Tables[0].Rows.Add(dr1);
                                }
                                else
                                {
                                    dr2["NUMRI"] = Convert.ToInt32(tr.ReadElementString().ToString());
                                    this.dsPrinterTavolina.Tables[0].Rows.Add(dr2);
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

                this.dsPrinterBanaku.Tables[0].AcceptChanges();
                this.dsPrinterTavolina.Tables[0].AcceptChanges();

                

            }


            catch
            {

            }
            finally
            {
                tr.Close();
            }
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

        private void LexoXmlPrinterRecete()
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

        private DataSet KrijoDsPrintimi()
        {
            int nrPrinterat = PrinterSettings.InstalledPrinters.Count;

            DataSet ds = new DataSet();

            for (int i = 0; i < nrPrinterat; i++)
            {
                ds.Tables.Add();

                ds.Tables[i].Columns.Add("ARTIKULLI", typeof(string));
                ds.Tables[i].Columns.Add("CMIMI", typeof(string));
                ds.Tables[i].Columns.Add("SASIA", typeof(string));
                ds.Tables[i].Columns.Add("VLERA", typeof(string));

                ds.Tables[i].AcceptChanges();

            }

            ds.AcceptChanges();

            return ds;
        }

        private DataSet KrijoDataSetPrinter()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("PRINTERI", typeof(string));
            ds.Tables[0].Columns.Add("NUMRI", typeof(int));

            ds.Tables[0].AcceptChanges();

            int i = 0;

            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                DataRow dr = ds.Tables[0].NewRow();

                dr["PRINTERI"] = strPrinter;
                dr["NUMRI"] = i;

                ds.Tables[0].Rows.Add(dr);

                i = i + 1;

            }

            ds.Tables[0].AcceptChanges();

            return ds;
        }

        private int KtheIndeksPrinteri(string strPrinteri)
        {
            string strPr = "";
            int indeksi = 0;

            foreach (DataRow dr in this.dsPrinters.Tables[0].Rows)
            {
                strPr = Convert.ToString(dr[0]).Trim();

                if (strPr == strPrinteri)
                {
                    indeksi = Convert.ToInt32(dr[1]);
                    return indeksi;
                }
            }

            return indeksi;
        }

        private string FormayoEmrinRecetaPerPrintim(string emri)
        {
            string kthe = "";
            int gjatesia = 0;

            gjatesia = emri.Length;

            if (gjatesia <= 20)
            {
                return emri;
            }

            kthe = emri.Substring(0, 20);

            return kthe;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogimi frm = new frmLogimi();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.dsKam = this.dsUsers;

            frm.ShowDialog();

            if (frm.veprimi == 1)
            {
                DataRow dr = this.dsUsers.Tables[0].NewRow();

                dr["ID_PERSONELI"] = frm.idUser;
                dr["PERDORUESI"] = frm.perdoruesi;
                dr["FJALEKALIMI"] = frm.fjalekalimi;

                this.dsUsers.Tables[0].Rows.Add(dr);
                this.dsUsers.Tables[0].AcceptChanges();

            }
        }

        private void btnXhiro_Click(object sender, EventArgs e)
        {
            frmXhiroKamarieri frm = new frmXhiroKamarieri();
            frm.dsKam = this.dsUsers;
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMbyllTurnin frm = new frmMbyllTurnin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.dsKam = this.dsUsers;

            frm.ShowDialog();

            int celesi = 0;

            if (frm.veprimi == 1)
            {
                foreach (DataRow dr in this.dsUsers.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr[0]);

                    if (celesi == frm.idUser)
                    {
                        this.dsUsers.Tables[0].Rows.Remove(dr);
                        this.dsUsers.Tables[0].AcceptChanges();
                        return;
                    }
                }
            }
        }

        private void daljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rrethNeshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void PastroEkstrat()
        {
            this.btnEkstra1.Text = "";
            this.btnEkstra2.Text = "";
            this.btnEkstra3.Text = "";
            this.btnEkstra4.Text = "";
            this.btnEkstra5.Text = "";
            this.btnEkstra6.Text = "";
            this.btnEkstra7.Text = "";
            this.btnEkstra8.Text = "";


            this.btnEkstra1.Visible = false;
            this.btnEkstra2.Visible = false;
            this.btnEkstra3.Visible = false;
            this.btnEkstra4.Visible = false;
            this.btnEkstra5.Visible = false;
            this.btnEkstra6.Visible = false;
            this.btnEkstra7.Visible = false;
            this.btnEkstra8.Visible = false;

        }

        private void MbushEkstra(int idReceta)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqEkstratPerReceten", idReceta);

            if (ds != null)
            {
                int i = 0;
                string ekstra = "";

                int numri = ds.Tables[0].Rows.Count;

                if (numri >= 1)
                {
                    this.btnEkstra1.Tag = idReceta.ToString();
                    this.btnEkstra1.Text = Convert.ToString(ds.Tables[0].Rows[0]["KEKSTRA"]);
                    this.btnEkstra1.Visible = true;


                }

                if (numri >= 2)
                {
                    this.btnEkstra2.Tag = idReceta.ToString();
                    this.btnEkstra2.Text = Convert.ToString(ds.Tables[0].Rows[1]["KEKSTRA"]);
                    this.btnEkstra2.Visible = true;

                }

                if (numri >= 3)
                {
                    this.btnEkstra3.Tag = idReceta.ToString();
                    this.btnEkstra3.Text = Convert.ToString(ds.Tables[0].Rows[2]["KEKSTRA"]);
                    this.btnEkstra3.Visible = true;

                }

                if (numri >= 4)
                {
                    this.btnEkstra4.Tag = idReceta.ToString();
                    this.btnEkstra4.Text = Convert.ToString(ds.Tables[0].Rows[3]["KEKSTRA"]);
                    this.btnEkstra4.Visible = true;

                }

                if (numri >= 5)
                {
                    this.btnEkstra5.Tag = idReceta.ToString();
                    this.btnEkstra5.Text = Convert.ToString(ds.Tables[0].Rows[4]["KEKSTRA"]);
                    this.btnEkstra5.Visible = true;

                }

                if (numri >= 6)
                {
                    this.btnEkstra6.Tag = idReceta.ToString();
                    this.btnEkstra6.Text = Convert.ToString(ds.Tables[0].Rows[5]["KEKSTRA"]);
                    this.btnEkstra6.Visible = true;

                }

                if (numri >= 7)
                {
                    this.btnEkstra7.Tag = idReceta.ToString();
                    this.btnEkstra7.Text = Convert.ToString(ds.Tables[0].Rows[6]["KEKSTRA"]);
                    this.btnEkstra7.Visible = true;

                }

                if (numri >= 8)
                {
                    this.btnEkstra8.Tag = idReceta.ToString();
                    this.btnEkstra8.Text = Convert.ToString(ds.Tables[0].Rows[7]["KEKSTRA"]);
                    this.btnEkstra8.Visible = true;

                }
                     


            }
        }

        private void HidhEkstraNeGride(int idReceta, string ekstra)
        {
            foreach (DataRow dr in this.dsFatura.Tables[0].Rows)
            {
                if (Convert.ToInt32(dr[0]) == idReceta)
                {
                    dr[1] = Convert.ToString(dr[1]) + " " + ekstra;
                    
                }
            }

            this.dsFatura.Tables[0].AcceptChanges();
        }

        private void btnEkstra1_Click(object sender, EventArgs e)
        {
            int idReceta = Convert.ToInt32(this.btnEkstra1.Tag);
            string ekstra = Convert.ToString(this.btnEkstra1.Text);

            this.HidhEkstraNeGride(idReceta, ekstra);
        }

        private void btnEkstra2_Click(object sender, EventArgs e)
        {
            int idReceta = Convert.ToInt32(this.btnEkstra2.Tag);
            string ekstra = Convert.ToString(this.btnEkstra2.Text);

            this.HidhEkstraNeGride(idReceta, ekstra);
        }

        private void btnEkstra3_Click(object sender, EventArgs e)
        {
            int idReceta = Convert.ToInt32(this.btnEkstra3.Tag);
            string ekstra = Convert.ToString(this.btnEkstra3.Text);

            this.HidhEkstraNeGride(idReceta, ekstra);
        }

        private void btnEkstra4_Click(object sender, EventArgs e)
        {
            int idReceta = Convert.ToInt32(this.btnEkstra4.Tag);
            string ekstra = Convert.ToString(this.btnEkstra4.Text);

            this.HidhEkstraNeGride(idReceta, ekstra);
        }

        private void btnEkstra5_Click(object sender, EventArgs e)
        {
            int idReceta = Convert.ToInt32(this.btnEkstra5.Tag);
            string ekstra = Convert.ToString(this.btnEkstra5.Text);

            this.HidhEkstraNeGride(idReceta, ekstra);
        }

        private void btnEkstra6_Click(object sender, EventArgs e)
        {
            int idReceta = Convert.ToInt32(this.btnEkstra6.Tag);
            string ekstra = Convert.ToString(this.btnEkstra6.Text);

            this.HidhEkstraNeGride(idReceta, ekstra);
        }

        private void btnEkstra7_Click(object sender, EventArgs e)
        {
            int idReceta = Convert.ToInt32(this.btnEkstra7.Tag);
            string ekstra = Convert.ToString(this.btnEkstra7.Text);

            this.HidhEkstraNeGride(idReceta, ekstra);
        }

        private void btnEkstra8_Click(object sender, EventArgs e)
        {
            int idReceta = Convert.ToInt32(this.btnEkstra8.Tag);
            string ekstra = Convert.ToString(this.btnEkstra8.Text);

            this.HidhEkstraNeGride(idReceta, ekstra);
        }

        private void mbylljaETurnitNgaAdministratoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMbyllTurninAdministratori frm = new frmMbyllTurninAdministratori();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.dsKam = this.dsUsers;

            frm.ShowDialog();

            int celesi = 0;

            if (frm.veprimi == 1)
            {
                foreach (DataRow dr in this.dsUsers.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr[0]);

                    if (celesi == frm.idUser)
                    {
                        this.dsUsers.Tables[0].Rows.Remove(dr);
                        this.dsUsers.Tables[0].AcceptChanges();
                        return;
                    }
                }
            }

        }




    }
}
