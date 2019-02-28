namespace ResManagerAdmin.Forms
{
    partial class frmArtikujFurnitore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtikujFurnitore));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.gridFurnitoret = new Janus.Windows.GridEX.GridEX();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnFundit = new System.Windows.Forms.Button();
            this.btnPas = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.btnPari = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnKerkoNeGride = new System.Windows.Forms.Button();
            this.btnModifikoArtikull = new System.Windows.Forms.Button();
            this.btnFshiArtikull = new System.Windows.Forms.Button();
            this.uiTabModifiko = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage = new Janus.Windows.UI.Tab.UITabPage();
            this.gbFurnitori = new Janus.Windows.EditControls.UIGroupBox();
            this.gridEXArtikujt = new Janus.Windows.GridEX.GridEX();
            this.btnPastro = new System.Windows.Forms.Button();
            this.gridEXArtikujtZgjedhur = new Janus.Windows.GridEX.GridEX();
            this.btnDjathtas = new System.Windows.Forms.Button();
            this.btnMajtas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKategoria = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnRuajFurnitor = new System.Windows.Forms.Button();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.cmbArtikujtKerkim = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cmbKategoriaKerkim = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbArtikulli = new System.Windows.Forms.CheckBox();
            this.txtMbiemriKerkim = new System.Windows.Forms.TextBox();
            this.btnKerko = new System.Windows.Forms.Button();
            this.txtEmriKerkim = new System.Windows.Forms.TextBox();
            this.cbMbiemri = new System.Windows.Forms.CheckBox();
            this.cbEmri = new System.Windows.Forms.CheckBox();
            this.dsArtikujZgjedhur = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.ID_ARTIKULLI = new System.Data.DataColumn();
            this.EMRI = new System.Data.DataColumn();
            this.CHECKED = new System.Data.DataColumn();
            this.dsArtikujKategori = new System.Data.DataSet();
            this.dataTable2 = new System.Data.DataTable();
            this.ID_ARTIKULLI1 = new System.Data.DataColumn();
            this.EMRI1 = new System.Data.DataColumn();
            this.CHECKED1 = new System.Data.DataColumn();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFurnitoret)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTabModifiko)).BeginInit();
            this.uiTabModifiko.SuspendLayout();
            this.uiTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbFurnitori)).BeginInit();
            this.gbFurnitori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXArtikujt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXArtikujtZgjedhur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsArtikujZgjedhur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArtikujKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.AutoScroll = true;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.uiGroupBox2);
            this.expandablePanel1.Controls.Add(this.uiGroupBox1);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandablePanel1.ExpandButtonVisible = false;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(1020, 614);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandablePanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 6;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Përkatësitë e artikujve sipas furnitorëve";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.gridFurnitoret);
            this.uiGroupBox2.Controls.Add(this.panelBottom);
            this.uiGroupBox2.Controls.Add(this.panelTop);
            this.uiGroupBox2.Controls.Add(this.uiTabModifiko);
            this.uiGroupBox2.Location = new System.Drawing.Point(234, 40);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(641, 562);
            this.uiGroupBox2.TabIndex = 5;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // gridFurnitoret
            // 
            this.gridFurnitoret.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridFurnitoret.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridFurnitoret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gridFurnitoret.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridFurnitoret.GroupByBoxFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Raised;
            this.gridFurnitoret.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.Transparent;
            this.gridFurnitoret.GroupByBoxInfoFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Raised;
            this.gridFurnitoret.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gridFurnitoret.GroupByBoxInfoFormatStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridFurnitoret.GroupByBoxInfoText = "Tërhiqni një prej kolonave për të grupuar";
            this.gridFurnitoret.GroupByBoxVisible = false;
            this.gridFurnitoret.HeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gridFurnitoret.HeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.gridFurnitoret.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridFurnitoret.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridFurnitoret.LayoutData = resources.GetString("gridFurnitoret.LayoutData");
            this.gridFurnitoret.Location = new System.Drawing.Point(10, 60);
            this.gridFurnitoret.Name = "gridFurnitoret";
            this.gridFurnitoret.RowFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gridFurnitoret.Size = new System.Drawing.Size(614, 453);
            this.gridFurnitoret.TabIndex = 7;
            this.gridFurnitoret.Tag = "NullText";
            this.gridFurnitoret.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)((((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls)
                        | Janus.Windows.GridEX.ThemedArea.Headers)
                        | Janus.Windows.GridEX.ThemedArea.TreeGliphs)
                        | Janus.Windows.GridEX.ThemedArea.GroupRows)
                        | Janus.Windows.GridEX.ThemedArea.ControlBorder)));
            this.gridFurnitoret.CurrentCellChanged += new System.EventHandler(this.gridFurnitoret_CurrentCellChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnFundit);
            this.panelBottom.Controls.Add(this.btnPas);
            this.panelBottom.Controls.Add(this.btnPara);
            this.panelBottom.Controls.Add(this.btnPari);
            this.panelBottom.Location = new System.Drawing.Point(10, 515);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(614, 44);
            this.panelBottom.TabIndex = 9;
            // 
            // btnFundit
            // 
            this.btnFundit.ForeColor = System.Drawing.Color.Navy;
            this.btnFundit.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_fundit;
            this.btnFundit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFundit.Location = new System.Drawing.Point(535, 4);
            this.btnFundit.Name = "btnFundit";
            this.btnFundit.Size = new System.Drawing.Size(75, 37);
            this.btnFundit.TabIndex = 11;
            this.btnFundit.Text = "I fundit";
            this.btnFundit.UseVisualStyleBackColor = true;
            this.btnFundit.Click += new System.EventHandler(this.btnFundit_Click);
            // 
            // btnPas
            // 
            this.btnPas.ForeColor = System.Drawing.Color.Navy;
            this.btnPas.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_djathtas;
            this.btnPas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPas.Location = new System.Drawing.Point(365, 4);
            this.btnPas.Name = "btnPas";
            this.btnPas.Size = new System.Drawing.Size(75, 37);
            this.btnPas.TabIndex = 10;
            this.btnPas.Text = "Pas";
            this.btnPas.UseVisualStyleBackColor = true;
            this.btnPas.Click += new System.EventHandler(this.btnPas_Click);
            // 
            // btnPara
            // 
            this.btnPara.ForeColor = System.Drawing.Color.Navy;
            this.btnPara.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_majtas;
            this.btnPara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPara.Location = new System.Drawing.Point(172, 4);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(75, 37);
            this.btnPara.TabIndex = 9;
            this.btnPara.Text = "Para";
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // btnPari
            // 
            this.btnPari.ForeColor = System.Drawing.Color.Navy;
            this.btnPari.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_pari;
            this.btnPari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPari.Location = new System.Drawing.Point(2, 4);
            this.btnPari.Name = "btnPari";
            this.btnPari.Size = new System.Drawing.Size(75, 37);
            this.btnPari.TabIndex = 8;
            this.btnPari.Text = "I pari";
            this.btnPari.UseVisualStyleBackColor = true;
            this.btnPari.Click += new System.EventHandler(this.btnPari_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnKerkoNeGride);
            this.panelTop.Controls.Add(this.btnModifikoArtikull);
            this.panelTop.Controls.Add(this.btnFshiArtikull);
            this.panelTop.Location = new System.Drawing.Point(10, 10);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(614, 44);
            this.panelTop.TabIndex = 6;
            // 
            // btnKerkoNeGride
            // 
            this.btnKerkoNeGride.ForeColor = System.Drawing.Color.Navy;
            this.btnKerkoNeGride.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerkoNeGride.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerkoNeGride.Location = new System.Drawing.Point(535, 4);
            this.btnKerkoNeGride.Name = "btnKerkoNeGride";
            this.btnKerkoNeGride.Size = new System.Drawing.Size(75, 37);
            this.btnKerkoNeGride.TabIndex = 7;
            this.btnKerkoNeGride.Text = "Kërko";
            this.btnKerkoNeGride.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKerkoNeGride.UseVisualStyleBackColor = true;
            this.btnKerkoNeGride.Click += new System.EventHandler(this.btnKerkoNeGride_Click);
            // 
            // btnModifikoArtikull
            // 
            this.btnModifikoArtikull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifikoArtikull.ForeColor = System.Drawing.Color.Navy;
            this.btnModifikoArtikull.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.btnModifikoArtikull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifikoArtikull.Location = new System.Drawing.Point(0, 4);
            this.btnModifikoArtikull.Name = "btnModifikoArtikull";
            this.btnModifikoArtikull.Size = new System.Drawing.Size(75, 37);
            this.btnModifikoArtikull.TabIndex = 5;
            this.btnModifikoArtikull.Text = "Modifiko";
            this.btnModifikoArtikull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifikoArtikull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifikoArtikull.UseVisualStyleBackColor = true;
            this.btnModifikoArtikull.Click += new System.EventHandler(this.btnModifikoArtikull_Click);
            // 
            // btnFshiArtikull
            // 
            this.btnFshiArtikull.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFshiArtikull.ForeColor = System.Drawing.Color.Navy;
            this.btnFshiArtikull.Image = global::ResManagerAdmin.Properties.Resources.cancelbuild;
            this.btnFshiArtikull.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshiArtikull.Location = new System.Drawing.Point(269, 4);
            this.btnFshiArtikull.Name = "btnFshiArtikull";
            this.btnFshiArtikull.Size = new System.Drawing.Size(75, 37);
            this.btnFshiArtikull.TabIndex = 6;
            this.btnFshiArtikull.Text = "Fshi";
            this.btnFshiArtikull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFshiArtikull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFshiArtikull.UseVisualStyleBackColor = true;
            this.btnFshiArtikull.Click += new System.EventHandler(this.btnFshiArtikull_Click);
            // 
            // uiTabModifiko
            // 
            this.uiTabModifiko.Controls.Add(this.uiTabPage);
            this.uiTabModifiko.Location = new System.Drawing.Point(12, 75);
            this.uiTabModifiko.Name = "uiTabModifiko";
            this.uiTabModifiko.SelectedIndex = 0;
            this.uiTabModifiko.Size = new System.Drawing.Size(612, 434);
            this.uiTabModifiko.TabIndex = 8;
            this.uiTabModifiko.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage});
            // 
            // uiTabPage
            // 
            this.uiTabPage.Controls.Add(this.gbFurnitori);
            this.uiTabPage.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage.Name = "uiTabPage";
            this.uiTabPage.Size = new System.Drawing.Size(608, 410);
            this.uiTabPage.TabIndex = 0;
            this.uiTabPage.Text = "Konfigurimi i artikujve që ofron furnitori";
            // 
            // gbFurnitori
            // 
            this.gbFurnitori.BackColor = System.Drawing.Color.Transparent;
            this.gbFurnitori.Controls.Add(this.gridEXArtikujt);
            this.gbFurnitori.Controls.Add(this.btnPastro);
            this.gbFurnitori.Controls.Add(this.gridEXArtikujtZgjedhur);
            this.gbFurnitori.Controls.Add(this.btnDjathtas);
            this.gbFurnitori.Controls.Add(this.btnMajtas);
            this.gbFurnitori.Controls.Add(this.label2);
            this.gbFurnitori.Controls.Add(this.label1);
            this.gbFurnitori.Controls.Add(this.cmbKategoria);
            this.gbFurnitori.Controls.Add(this.btnAnullo);
            this.gbFurnitori.Controls.Add(this.btnRuajFurnitor);
            this.gbFurnitori.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.gbFurnitori.Image = global::ResManagerAdmin.Properties.Resources.artikuj_furnitore1;
            this.gbFurnitori.ImageSize = new System.Drawing.Size(24, 24);
            this.gbFurnitori.Location = new System.Drawing.Point(16, 19);
            this.gbFurnitori.Name = "gbFurnitori";
            this.gbFurnitori.Size = new System.Drawing.Size(577, 388);
            this.gbFurnitori.TabIndex = 4;
            this.gbFurnitori.UseThemes = false;
            this.gbFurnitori.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.UseDefault;
            // 
            // gridEXArtikujt
            // 
            this.gridEXArtikujt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gridEXArtikujt.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEXArtikujt.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEXArtikujt.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEXArtikujt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXArtikujt.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridEXArtikujt.GroupByBoxVisible = false;
            this.gridEXArtikujt.HeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXArtikujt.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridEXArtikujt.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEXArtikujt.LayoutData = resources.GetString("gridEXArtikujt.LayoutData");
            this.gridEXArtikujt.Location = new System.Drawing.Point(10, 91);
            this.gridEXArtikujt.Name = "gridEXArtikujt";
            this.gridEXArtikujt.RowFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXArtikujt.Size = new System.Drawing.Size(218, 253);
            this.gridEXArtikujt.TabIndex = 41;
            // 
            // btnPastro
            // 
            this.btnPastro.ForeColor = System.Drawing.Color.Navy;
            this.btnPastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPastro.Location = new System.Drawing.Point(490, 46);
            this.btnPastro.Name = "btnPastro";
            this.btnPastro.Size = new System.Drawing.Size(75, 37);
            this.btnPastro.TabIndex = 40;
            this.btnPastro.Text = "Pastro";
            this.btnPastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPastro.UseVisualStyleBackColor = true;
            this.btnPastro.Click += new System.EventHandler(this.btnPastro_Click);
            // 
            // gridEXArtikujtZgjedhur
            // 
            this.gridEXArtikujtZgjedhur.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEXArtikujtZgjedhur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXArtikujtZgjedhur.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridEXArtikujtZgjedhur.GroupByBoxInfoText = "Tërhiqni një prej kolonave për të grupuar tavolinat";
            this.gridEXArtikujtZgjedhur.GroupByBoxVisible = false;
            this.gridEXArtikujtZgjedhur.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridEXArtikujtZgjedhur.HeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXArtikujtZgjedhur.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridEXArtikujtZgjedhur.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEXArtikujtZgjedhur.LayoutData = resources.GetString("gridEXArtikujtZgjedhur.LayoutData");
            this.gridEXArtikujtZgjedhur.Location = new System.Drawing.Point(347, 92);
            this.gridEXArtikujtZgjedhur.Name = "gridEXArtikujtZgjedhur";
            this.gridEXArtikujtZgjedhur.RowFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXArtikujtZgjedhur.Size = new System.Drawing.Size(218, 253);
            this.gridEXArtikujtZgjedhur.TabIndex = 39;
            // 
            // btnDjathtas
            // 
            this.btnDjathtas.ForeColor = System.Drawing.Color.Navy;
            this.btnDjathtas.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_fundit;
            this.btnDjathtas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDjathtas.Location = new System.Drawing.Point(250, 187);
            this.btnDjathtas.Name = "btnDjathtas";
            this.btnDjathtas.Size = new System.Drawing.Size(75, 24);
            this.btnDjathtas.TabIndex = 37;
            this.btnDjathtas.Text = "Kalo";
            this.btnDjathtas.UseVisualStyleBackColor = true;
            this.btnDjathtas.Click += new System.EventHandler(this.btnDjathtas_Click);
            // 
            // btnMajtas
            // 
            this.btnMajtas.ForeColor = System.Drawing.Color.Navy;
            this.btnMajtas.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_pari;
            this.btnMajtas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMajtas.Location = new System.Drawing.Point(250, 217);
            this.btnMajtas.Name = "btnMajtas";
            this.btnMajtas.Size = new System.Drawing.Size(75, 24);
            this.btnMajtas.TabIndex = 36;
            this.btnMajtas.Text = "Kalo";
            this.btnMajtas.UseVisualStyleBackColor = true;
            this.btnMajtas.Click += new System.EventHandler(this.btnMajtas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Artikujt për kategorinë";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Kategoria";
            // 
            // cmbKategoria
            // 
            this.cmbKategoria.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKategoria.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbKategoria.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbKategoria.DisplayMember = "PERSHKRIMI";
            this.cmbKategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbKategoria.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbKategoria.LayoutData = resources.GetString("cmbKategoria.LayoutData");
            this.cmbKategoria.Location = new System.Drawing.Point(10, 46);
            this.cmbKategoria.Name = "cmbKategoria";
            this.cmbKategoria.Size = new System.Drawing.Size(178, 20);
            this.cmbKategoria.TabIndex = 33;
            this.cmbKategoria.Value = null;
            this.cmbKategoria.ValueMember = "ID_KATEGORIAARTIKULLI";
            this.cmbKategoria.ValueChanged += new System.EventHandler(this.cmbKategoria_ValueChanged);
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(301, 351);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 37);
            this.btnAnullo.TabIndex = 19;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuajFurnitor
            // 
            this.btnRuajFurnitor.ForeColor = System.Drawing.Color.Navy;
            this.btnRuajFurnitor.Image = global::ResManagerAdmin.Properties.Resources.save;
            this.btnRuajFurnitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajFurnitor.Location = new System.Drawing.Point(194, 351);
            this.btnRuajFurnitor.Name = "btnRuajFurnitor";
            this.btnRuajFurnitor.Size = new System.Drawing.Size(75, 37);
            this.btnRuajFurnitor.TabIndex = 17;
            this.btnRuajFurnitor.Text = "Ruaj";
            this.btnRuajFurnitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuajFurnitor.UseVisualStyleBackColor = true;
            this.btnRuajFurnitor.Click += new System.EventHandler(this.btnRuajArtikull_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cmbArtikujtKerkim);
            this.uiGroupBox1.Controls.Add(this.cmbKategoriaKerkim);
            this.uiGroupBox1.Controls.Add(this.label11);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.cbArtikulli);
            this.uiGroupBox1.Controls.Add(this.txtMbiemriKerkim);
            this.uiGroupBox1.Controls.Add(this.btnKerko);
            this.uiGroupBox1.Controls.Add(this.txtEmriKerkim);
            this.uiGroupBox1.Controls.Add(this.cbMbiemri);
            this.uiGroupBox1.Controls.Add(this.cbEmri);
            this.uiGroupBox1.Image = global::ResManagerAdmin.Properties.Resources.search_f2;
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 40);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(214, 356);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "Kërkoni sipas";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // cmbArtikujtKerkim
            // 
            this.cmbArtikujtKerkim.BackColor = System.Drawing.SystemColors.Window;
            this.cmbArtikujtKerkim.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbArtikujtKerkim.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbArtikujtKerkim.DisplayMember = "EMRI";
            this.cmbArtikujtKerkim.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbArtikujtKerkim.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbArtikujtKerkim.LayoutData = resources.GetString("cmbArtikujtKerkim.LayoutData");
            this.cmbArtikujtKerkim.Location = new System.Drawing.Point(13, 255);
            this.cmbArtikujtKerkim.Name = "cmbArtikujtKerkim";
            this.cmbArtikujtKerkim.Size = new System.Drawing.Size(178, 20);
            this.cmbArtikujtKerkim.TabIndex = 33;
            this.cmbArtikujtKerkim.Value = null;
            this.cmbArtikujtKerkim.ValueMember = "ID_ARTIKULLI";
            // 
            // cmbKategoriaKerkim
            // 
            this.cmbKategoriaKerkim.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKategoriaKerkim.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbKategoriaKerkim.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbKategoriaKerkim.DisplayMember = "PERSHKRIMI";
            this.cmbKategoriaKerkim.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbKategoriaKerkim.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbKategoriaKerkim.LayoutData = resources.GetString("cmbKategoriaKerkim.LayoutData");
            this.cmbKategoriaKerkim.Location = new System.Drawing.Point(13, 206);
            this.cmbKategoriaKerkim.Name = "cmbKategoriaKerkim";
            this.cmbKategoriaKerkim.Size = new System.Drawing.Size(178, 20);
            this.cmbKategoriaKerkim.TabIndex = 32;
            this.cmbKategoriaKerkim.Value = null;
            this.cmbKategoriaKerkim.ValueMember = "ID_KATEGORIAARTIKULLI";
            this.cmbKategoriaKerkim.ValueChanged += new System.EventHandler(this.cmbKategoriaKerkim_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(12, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Artikujt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Kategoria";
            // 
            // cbArtikulli
            // 
            this.cbArtikulli.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbArtikulli.AutoSize = true;
            this.cbArtikulli.Location = new System.Drawing.Point(15, 161);
            this.cbArtikulli.Name = "cbArtikulli";
            this.cbArtikulli.Size = new System.Drawing.Size(109, 17);
            this.cbArtikulli.TabIndex = 6;
            this.cbArtikulli.Text = "Artikujve që ofron";
            this.cbArtikulli.UseVisualStyleBackColor = true;
            this.cbArtikulli.CheckedChanged += new System.EventHandler(this.cbAdresa_CheckedChanged);
            // 
            // txtMbiemriKerkim
            // 
            this.txtMbiemriKerkim.Location = new System.Drawing.Point(11, 115);
            this.txtMbiemriKerkim.Name = "txtMbiemriKerkim";
            this.txtMbiemriKerkim.Size = new System.Drawing.Size(180, 20);
            this.txtMbiemriKerkim.TabIndex = 5;
            // 
            // btnKerko
            // 
            this.btnKerko.ForeColor = System.Drawing.Color.Navy;
            this.btnKerko.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerko.Location = new System.Drawing.Point(68, 300);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(66, 28);
            this.btnKerko.TabIndex = 4;
            this.btnKerko.Text = "Kërko";
            this.btnKerko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // txtEmriKerkim
            // 
            this.txtEmriKerkim.Location = new System.Drawing.Point(13, 45);
            this.txtEmriKerkim.Name = "txtEmriKerkim";
            this.txtEmriKerkim.Size = new System.Drawing.Size(180, 20);
            this.txtEmriKerkim.TabIndex = 3;
            // 
            // cbMbiemri
            // 
            this.cbMbiemri.AutoSize = true;
            this.cbMbiemri.Location = new System.Drawing.Point(13, 92);
            this.cbMbiemri.Name = "cbMbiemri";
            this.cbMbiemri.Size = new System.Drawing.Size(65, 17);
            this.cbMbiemri.TabIndex = 1;
            this.cbMbiemri.Text = "Mbiemrit";
            this.cbMbiemri.UseVisualStyleBackColor = true;
            this.cbMbiemri.CheckedChanged += new System.EventHandler(this.cbMbiemri_CheckedChanged);
            // 
            // cbEmri
            // 
            this.cbEmri.AutoSize = true;
            this.cbEmri.Location = new System.Drawing.Point(13, 22);
            this.cbEmri.Name = "cbEmri";
            this.cbEmri.Size = new System.Drawing.Size(101, 17);
            this.cbEmri.TabIndex = 0;
            this.cbEmri.Text = "Emrit të furnitorit";
            this.cbEmri.UseVisualStyleBackColor = true;
            this.cbEmri.CheckedChanged += new System.EventHandler(this.cbEmri_CheckedChanged);
            // 
            // dsArtikujZgjedhur
            // 
            this.dsArtikujZgjedhur.DataSetName = "NewDataSet";
            this.dsArtikujZgjedhur.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.ID_ARTIKULLI,
            this.EMRI,
            this.CHECKED});
            this.dataTable1.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ID_ARTIKULLI"}, true)});
            this.dataTable1.PrimaryKey = new System.Data.DataColumn[] {
        this.ID_ARTIKULLI};
            this.dataTable1.TableName = "Table1";
            // 
            // ID_ARTIKULLI
            // 
            this.ID_ARTIKULLI.AllowDBNull = false;
            this.ID_ARTIKULLI.ColumnName = "ID_ARTIKULLI";
            this.ID_ARTIKULLI.DataType = typeof(int);
            // 
            // EMRI
            // 
            this.EMRI.ColumnName = "EMRI";
            // 
            // CHECKED
            // 
            this.CHECKED.ColumnName = "CHECKED";
            this.CHECKED.DataType = typeof(bool);
            this.CHECKED.DefaultValue = false;
            // 
            // dsArtikujKategori
            // 
            this.dsArtikujKategori.DataSetName = "NewDataSet";
            this.dsArtikujKategori.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable2});
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.ID_ARTIKULLI1,
            this.EMRI1,
            this.CHECKED1});
            this.dataTable2.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ID_ARTIKULLI"}, true)});
            this.dataTable2.PrimaryKey = new System.Data.DataColumn[] {
        this.ID_ARTIKULLI1};
            this.dataTable2.TableName = "Table1";
            // 
            // ID_ARTIKULLI1
            // 
            this.ID_ARTIKULLI1.AllowDBNull = false;
            this.ID_ARTIKULLI1.ColumnName = "ID_ARTIKULLI";
            this.ID_ARTIKULLI1.DataType = typeof(int);
            // 
            // EMRI1
            // 
            this.EMRI1.ColumnName = "EMRI";
            // 
            // CHECKED1
            // 
            this.CHECKED1.ColumnName = "CHECKED";
            this.CHECKED1.DataType = typeof(bool);
            // 
            // frmArtikujFurnitore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArtikujFurnitore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Përkatësitë e artikujve";
            this.Load += new System.EventHandler(this.frmKonfigurimArtikujsh_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmArtikujFurnitore_CausesValidationChanged);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFurnitoret)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTabModifiko)).EndInit();
            this.uiTabModifiko.ResumeLayout(false);
            this.uiTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbFurnitori)).EndInit();
            this.gbFurnitori.ResumeLayout(false);
            this.gbFurnitori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXArtikujt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXArtikujtZgjedhur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsArtikujZgjedhur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArtikujKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private System.Windows.Forms.Button btnKerko;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.TextBox txtEmriKerkim;
        private System.Windows.Forms.CheckBox cbMbiemri;
        private System.Windows.Forms.CheckBox cbEmri;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnModifikoArtikull;
        private System.Windows.Forms.Button btnFshiArtikull;
        private Janus.Windows.GridEX.GridEX gridFurnitoret;
        private Janus.Windows.UI.Tab.UITab uiTabModifiko;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage;
        private Janus.Windows.EditControls.UIGroupBox gbFurnitori;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.Button btnRuajFurnitor;
        private System.Windows.Forms.CheckBox cbArtikulli;
        private System.Windows.Forms.TextBox txtMbiemriKerkim;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnFundit;
        private System.Windows.Forms.Button btnPas;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Button btnPari;
        private System.Windows.Forms.Button btnKerkoNeGride;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbArtikujtKerkim;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbKategoriaKerkim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbKategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDjathtas;
        private System.Windows.Forms.Button btnMajtas;
        private Janus.Windows.GridEX.GridEX gridEXArtikujtZgjedhur;
        private System.Windows.Forms.Button btnPastro;
        private Janus.Windows.GridEX.GridEX gridEXArtikujt;
        private System.Data.DataSet dsArtikujZgjedhur;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn ID_ARTIKULLI;
        private System.Data.DataColumn EMRI;
        private System.Data.DataColumn CHECKED;
        private System.Data.DataSet dsArtikujKategori;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn ID_ARTIKULLI1;
        private System.Data.DataColumn EMRI1;
        private System.Data.DataColumn CHECKED1;
    }
}