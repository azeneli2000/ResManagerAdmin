using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using Janus.Windows.ExplorerBar;
using ResManagerAdmin.BusDatService;

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
        private DataSet dsTavolinat = null;
        private int fatura = 0;
        private int idTavolinaZgjedhur;
        private string printNrFatura = "";
        private string[] printArtikujt = null;
        private string[] printCmimet = null;
        private string[] printSasite = null;
        private string[] printVlerat = null;
        private string printTotali = "";
        private string printBari = "";
        private string printTavolina = "";
        private string printUser = "";

        private int[] idRecetat = new int[10];
        private string[] emratRecetat = new string[10];
        private int nrFavorite = 0;

        private string gjendjaZgjedhur = "";

        private int printModeli = 3;
        private int modeTavolinat = 0;
       

        


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
            System.Globalization.CultureInfo MyCulture = System.Globalization.CultureInfo.CreateSpecificCulture("sq-Al");
            MyCulture.DateTimeFormat.LongDatePattern = "dd-MM-yyyy";
            MyCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            MyCulture.NumberFormat.CurrencyDecimalDigits = 2;
            Application.CurrentCulture = MyCulture;
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
            ResManager.Forms.AboutBox1 aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
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
                //ne nje DataSet global ruajme te gjithe kamarieret qe 
                //jane loguar ne kete workstation
                DataRow r = this.dsKamarieret.Tables[0].NewRow();
                r["ID_PERSONELI"] = idPerdoruesi;
                r["EMRI"] = emerPerdoruesi;
                r["MBIEMRI"] = mbiemerPerdoruesi;
                r["PERDORUESI"] = perdoruesi;
                r["FJALEKALIMI"] = fjalekalimi;
                dsKamarieret.Tables[0].Rows.Add(r);
                dsKamarieret.AcceptChanges();

                this.printUser = emerPerdoruesi;

                this.uiTab.BringToFront();
                //gridEXBashke.Size = new Size(545, 568);
                this.exArtikujt.Dock = DockStyle.Left;
                this.exBarFavorite.Dock = DockStyle.Left;

                this.MbushEksplorerBar1();
                this.dsTavolinat = this.KrijoDataSetTavolinat();
                this.MbushTavolina();
                this.KtheInformacionPerBarin();
                this.LexoXml();
                this.LexoXmlTavolinat();
                
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
            this.uiTab.Visible = false;
            this.exBarFavorite.Visible = true;
            this.exArtikujt.Visible = false;
            this.exBarFavorite.Groups[0].Expanded = true;
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
            DialogResult r = MessageBox.Show(this, "Restaurant Manager po mbyllet." +
                Environment.NewLine + "Dëshironi të mbyllni turnin për të gjithë" + 
                Environment.NewLine + "kamarierët e loguar në këtë kompjuter?","Restaurant Manager",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //frmXhiroKamarieri frm = new frmXhiroKamarieri();
                //frm.idKamarieri = idPerdoruesi;
                //frm.ShowDialog();

                InputController data = new InputController();
                int b = data.KerkesaUpdate("Logout", dsKamarieret);
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
                el.Height = 40;
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

        private void MbushKategoriRecetash()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteERecetave");

            string emri = "";
            int celesi = 0;
            this.exBarFavorite.Groups[1].Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["ID_KATEGORIARECETA"]);
                emri = Convert.ToString(dr["PERSHKRIMI"]);

                ExplorerBarItem el = new ExplorerBarItem();
                el.Key = Convert.ToString(celesi);
                el.Text = emri;
                el.Height = 40;
                el.ToolTipText = emri;

                this.exBarFavorite.Groups[1].Items.Add(el);

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
				lartesi = 60;
				gjeresi = 72;
				hapsire = 50;
				h_nr = 6;
			}
			else if (numer_rreshtash <= 221)
			{
				lartesi = 72;
				gjeresi = 60;
				hapsire = 50;
				h_nr = 6;
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
                btn.Font = new Font("ARIAL", 12);
               
                btn.Style.ForeColor.Color = Color.Black;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Stretch;
                btn.Style.BackColor1.Alpha = 1;
                btn.Style.BackColor2.Alpha = 1;

                btn.Style.BackColor1.Color = Color.Transparent;
                btn.Style.BackColor2.Color = Color.Transparent;

                btn.Style.Alignment = StringAlignment.Near;
                btn.Style.LineAlignment = StringAlignment.Center;
                
                btn.Text = Convert.ToString(dr["EMRI"]);
                

                
				btn.Width =  54;
				btn.Height = 66;

				p1 = (i % h_nr + 1) * hapsire + (i % h_nr) * 54;
				p2 = (i / h_nr + 1) * hapsire + (i / h_nr) * 66;
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
            int idTryeza = 0;
            int celesi = 0;

            DevComponents.DotNetBar.PanelEx b = (DevComponents.DotNetBar.PanelEx)sender;
            idTryeza = Convert.ToInt32(b.Name);
            gjendjaZgjedhur = Convert.ToString(b.Tag);
            idTavolinaZgjedhur = idTryeza;
            string emri = Convert.ToString(b.Text);
            this.txtNrTavolina.Text = emri;
            string gjendja = "";

            try
            {
                foreach (Control c in this.panelImazh.Controls)
                {


                    DevComponents.DotNetBar.PanelEx tv = (DevComponents.DotNetBar.PanelEx)c;

                    int idTav = Convert.ToInt32(tv.Name);

                    //gjendja = Convert.ToString(tv.Tag);

                    if (idTav == idTavolinaZgjedhur)
                    {
                        tv.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
                        tv.Style.BorderColor.Color = Color.Green;
                        tv.Style.BorderWidth = 1;

                    }
                    else
                    {
                        tv.Style.BorderColor.Color = Color.Transparent;
                        tv.Style.Border = DevComponents.DotNetBar.eBorderType.None;
                    }

                    if (gjendja == "R")
                    {
                        tv.Style.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_rezervuar.png");


                    }
                    else if (gjendja == "L")
                    {
                        tv.Style.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_lire.png");


                    }
                    else if (gjendja == "Z")
                    {
                        tv.Style.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_zene.png");

                    }

                    //if (idTav == idTavolinaZgjedhur)
                    //{
                    //    tv.Style.BorderColor.Color = Color.Green;
                    //    tv.Style.BorderWidth = 1;
                    //    tv.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
                    //}
                    //else
                    //{
                    //    tv.Style.BorderColor.Color = Color.Transparent;
                    //}


                }





                // b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                this.idTavolinaZgjedhur = idTryeza;
            }
            catch (Exception ex)
            {
                return;
            }
            

        }

        private void btn_DoubleClick(object sender, System.EventArgs e)
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

                foreach(DataRow dr in dsTavolinat.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr[0]);

                    if (celesi == idTav)
                    {
                        gjendja = Convert.ToString(dr[1]);
                        dr[1] = "Z";
                    }

                }

                
                if (gjendja != "Z")
                {

                    InputController data = new InputController();
                    int d = data.KerkesaUpdate("HapTavoline", idTav);
                    b.Style.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_zene.png");
 
                }

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

                if (numriTotal < 1)
                {
                    MessageBox.Show("Ju nuk keni asnje artikull  '" + nameStock + "'  ne magazine.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


                    dsFatura.Tables[0].Rows.Add(dr);
                   
                }

                dsFatura.Tables[0].AcceptChanges();
                

                int numri = dsFatura.Tables[0].Rows.Count;

                this.gridaFatura.DataSource = null;
                this.gridaFatura.DataSource = dsFatura.Tables[0];
                this.gridaFatura.Focus();
                this.gridaFatura.Row = numri - 1;

                return;

            }


            string s = e.Item.Key;
            int celesi = Convert.ToInt32(s);

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
                strSql = "SELECT ID_ARTIKULLI, EMRI FROM ARTIKUJT WHERE ID_KATEGORIAARTIKULLI = " + celesi + " AND ID_ARTIKULLI IN (SELECT ID_ARTIKULLI FROM CMIMET_PERIUDHA)";
                
            }
            else
            {
                strSql = "SELECT ID_RECETA, EMRI FROM RECETAT WHERE ID_KATEGORIARECETA = " + celesi + " AND ID_RECETA IN (SELECT ID_RECETA FROM CMIMET_PERIUDHA_RECETAT)";
                
            }


            ds = data.KerkesaRead("ShfaqArtikujtPerBar", strSql);

            if (ds == null)
            {
                //mesazh gabimi

                return;
            }

            string emri = "";
            int celesiA = 0;
            this.exArtikujt.Groups[0].Items.Clear();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                celesiA = Convert.ToInt32(dr[0]);
                emri = Convert.ToString(dr[1]);

                ExplorerBarItem el = new ExplorerBarItem();
                el.Key = Convert.ToString(celesiA);
                el.Text = emri;
                el.Height = 40;
                el.TagString = lloji;
                el.ToolTipText = emri;

                this.exArtikujt.Groups[0].Items.Add(el);

            }

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
            frm.idKamarieri = idPerdoruesi;
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

            if (this.GjendetArtikulli(idArtikulli, llojiArtikulli))
            {
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

            if (numriTotal < 1)
            {
                MessageBox.Show("Ju nuk keni asnje artikull  '" + nameStock + "'  ne magazine.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow dr = dsFatura.Tables[0].NewRow();
            

            if (llojiArtikulli == "A")
            {
                dr["CELESI"] = ds.Tables[0].Rows[0]["CELESI"];
                dr["EMRI"] = ds.Tables[0].Rows[0]["EMRI"];
                dr["CMIMI"] = ds.Tables[0].Rows[0]["VLERA"];
                dr["SASIA"] = Convert.ToInt32(1);
                dr["VLERA"] = Convert.ToDouble(dr["CMIMI"]) ;
                dr["NJESIA"] = ds.Tables[0].Rows[0]["NJESIA"];
                //dr["LIMITI"] = ds.Tables[0].Rows[0]["LIMITI"];
                dr["LLOJI"] = "A";

                dsFatura.Tables[0].Rows.Add(dr);

                
                


               
            }
            else
            {
                dr["CELESI"] = ds.Tables[0].Rows[0]["CELESI"];
                dr["EMRI"] =  ds.Tables[0].Rows[0]["EMRI"];
                dr["CMIMI"] = ds.Tables[0].Rows[0]["VLERA"];
                dr["SASIA"] = 1;
                dr["VLERA"] = Convert.ToDouble(dr["CMIMI"]);
                //dr["NJESIA"] = ds.Tables[0].Rows[0]["NJESIA"];
                //dr["LIMITI"] = ds.Tables[0].Rows[0]["LIMITI"];
                dr["LLOJI"] = "R";

                dsFatura.Tables[0].Rows.Add(dr);
            }

            dsFatura.Tables[0].AcceptChanges();

            int numri = dsFatura.Tables[0].Rows.Count;
            int indeksi = numri - 1;


            this.gridaFatura.Row = indeksi;
            this.gridaFatura.Focus();

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

        private void LexoXmlTavolinat()
        {
            string str = "";
            string fileName = Global.stringXml + "\\Tavolinat.xml";
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
                string tipi = "";
                if (dsFatura != null && dsFatura.Tables.Count != 0)
                {
                    foreach (DataRow dr in dsFatura.Tables[0].Rows)
                    {
                        celesi = Convert.ToInt32(dr["CELESI"]);
                        tipi = Convert.ToString(dr["LLOJI"]);

                        if (celesi == idArtikulli && tipi == lloji)
                        {
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
            float posX = 70;
            float posY = 0;
            PointF drawPoint = new PointF();

            string dataSot = System.DateTime.Today.ToString("dd/MM/yyyy");
            string oraTani = System.DateTime.Now.ToString("hh:mm:ss");

            switch (printModeli)
            {
                case 1:

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

                    int nr = this.printArtikujt.Length;

                    for (int i = 0; i < nr; i++)
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

                    //drawString = "Fatura nr: " + this.printNrFatura;
                    ////PointF drawPoint = new PointF(70.0F, 10.0F);


                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                   

                    //drawPoint = new PointF(10.0F, 20.0F);
                    posX = 90;
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

                    drawFont = new Font("Nina", 8);
                    drawString = "Emertimi";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 10;
                    posY = posY + 50;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Cmimi";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 130;
                    //posY = 73;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Sasia";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 175;
                    //posY = 73;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Vlera";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 215;
                    //posY = 73;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "------------------------------------------------------------------";
                    drawPoint = new PointF(10.0F, 60.0F);
                    posX = 10;
                    posY = posY + 15;
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

                        drawString = this.printArtikujt[i].ToUpper();
                        posX = 10;
                        posY = posY + 20;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        drawString = this.printCmimet[i];
                        posX = 138;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printSasite[i];
                        posX = 183;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

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

                case 3 :
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

                    drawFont = new Font("Nina", 8);
                    drawString = "------------------------------------------------------------------";
                    drawPoint = new PointF(10.0F, 60.0F);
                    posX = 10;
                    posY = posY + 40;
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

                        drawString = this.printArtikujt[i].ToUpper();
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
            if (idTavolinaZgjedhur == 0)
            {
                return;
            }

            int[] faturat = new int[20];

            int celesi = 0;
            int i = 0;
            foreach (DataRow dr in this.dsTavolinat.Tables[1].Rows)
            {
                celesi = Convert.ToInt32(dr[0]);
                if (celesi == idTavolinaZgjedhur)
                {
                    faturat[i] = Convert.ToInt32(dr[1]);
                    i = i + 1;
                }
            }

            frmTavolina tavolina = new frmTavolina();
            tavolina.idTavolina = this.idTavolinaZgjedhur;
            tavolina.dsTavolinat = dsTavolinat;
            tavolina.idFaturat = faturat;
            tavolina.Top = 100;
            tavolina.Left = 100;
            tavolina.ShowDialog();




            celesi = 0;
            int idTav = 0;

            try
            {
                foreach (Control c in panelImazh.Controls)
                {
                    DevComponents.DotNetBar.PanelEx tav = (DevComponents.DotNetBar.PanelEx)c;

                    idTav = Convert.ToInt32(tav.Name);
                    string emri = Convert.ToString(tav.Text);
                    string gj = "";

                    foreach (DataRow dr in dsTavolinat.Tables[0].Rows)
                    {
                        celesi = Convert.ToInt32(dr[0]);
                        if (celesi == idTav)
                        {
                            gj = Convert.ToString(dr[1]);
                        }
                    }

                    switch (gj)
                    {
                        case "L":
                            tav.Style.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_lire.png");
                            break;

                        case "Z":
                            tav.Style.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_zene.png");
                            break;

                        case "R":
                            tav.Style.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_rezervuar.png");
                            break;

                        default:
                            break;
                    }

                    //if (idTav == this.idTavolinaZgjedhur)
                    //{
                    //    tav.Style.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_lire.png");
                    //    //this.idTavolinaZgjedhur = 0;
                    //}
                }
            }
            catch (Exception ex)
            {
            }

            this.gjendjaZgjedhur = "L";

            
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
                    this.gjendjaZgjedhur = "Z";

                    int celesi = 0;

                    foreach (DataRow dr in dsTavolinat.Tables[0].Rows)
                    {
                        celesi = Convert.ToInt32(dr[0]);

                        if (celesi == idTav)
                        {
                            gjendja = Convert.ToString(dr[1]);
                            dr[1] = "Z";
                        }

                    }


                    if (gjendja != "Z")
                    {

                        InputController data1 = new InputController();
                        int d = data1.KerkesaUpdate("HapTavoline", idTav);
                        ////b.Style.BackgroundImage = Image.FromFile("C:\\ResManagerAdmin\\Resources\\t_zene.png");

                    }

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
            int b = data.KerkesaUpdate("KrijoFature", idUser, this.idTavolina, idKlienti, idFormaPagesa, totali, skonto, nrFatura, dsRuaj);

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

                if (numriTotal < 1)
                {
                    MessageBox.Show("Ju nuk keni asnje artikull  '" + nameStock + "'  ne magazine.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


                    dsFatura.Tables[0].Rows.Add(dr);
                }

                dsFatura.Tables[0].AcceptChanges();

                int numri = dsFatura.Tables[0].Rows.Count;

                this.gridaFatura.DataSource = null;
                this.gridaFatura.DataSource = dsFatura.Tables[0];
                this.gridaFatura.Focus();
                this.gridaFatura.Row = numri - 1;

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
            int b = data.KerkesaUpdate("KrijoFature", idUser, this.idTavolina, idKlienti, idFormaPagesa, totali, skonto, nrFatura, dsRuaj);

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
            frmTurni frm = new frmTurni();
            frm.idKamarieri = idPerdoruesi;
            frm.Show();
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
    }
}
