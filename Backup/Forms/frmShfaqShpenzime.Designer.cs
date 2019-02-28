namespace ResManagerAdmin.Forms
{
    partial class frmShfaqShpenzime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShfaqShpenzime));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.gbShpenzimet = new Janus.Windows.EditControls.UIGroupBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnFundit = new System.Windows.Forms.Button();
            this.btnPas = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.btnPari = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnKerkoNeGride = new System.Windows.Forms.Button();
            this.btnModifiko = new System.Windows.Forms.Button();
            this.btnFshi = new System.Windows.Forms.Button();
            this.gridShpenzimet = new Janus.Windows.GridEX.GridEX();
            this.uiTabModifiko = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiGroupBox4 = new Janus.Windows.EditControls.UIGroupBox();
            this.cmbKategorite = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.numVlera = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnKerko = new System.Windows.Forms.Button();
            this.cmbKategoriteKerkim = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.dtpDataKerkim = new System.Windows.Forms.DateTimePicker();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.txtPershkrimiKerkim = new System.Windows.Forms.TextBox();
            this.cbPershkrimi = new System.Windows.Forms.CheckBox();
            this.cbKategoria = new System.Windows.Forms.CheckBox();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbShpenzimet)).BeginInit();
            this.gbShpenzimet.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridShpenzimet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTabModifiko)).BeginInit();
            this.uiTabModifiko.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).BeginInit();
            this.uiGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVlera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.AutoScroll = true;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.gbShpenzimet);
            this.expandablePanel1.Controls.Add(this.uiGroupBox2);
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
            this.expandablePanel1.TabIndex = 8;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Shpenzimet";
            // 
            // gbShpenzimet
            // 
            this.gbShpenzimet.Controls.Add(this.panelBottom);
            this.gbShpenzimet.Controls.Add(this.panelTop);
            this.gbShpenzimet.Controls.Add(this.gridShpenzimet);
            this.gbShpenzimet.Controls.Add(this.uiTabModifiko);
            this.gbShpenzimet.ImageSize = new System.Drawing.Size(32, 32);
            this.gbShpenzimet.Location = new System.Drawing.Point(234, 40);
            this.gbShpenzimet.Name = "gbShpenzimet";
            this.gbShpenzimet.Size = new System.Drawing.Size(742, 562);
            this.gbShpenzimet.TabIndex = 6;
            this.gbShpenzimet.Text = "Shpenzimet e kryer sot";
            this.gbShpenzimet.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnFundit);
            this.panelBottom.Controls.Add(this.btnPas);
            this.panelBottom.Controls.Add(this.btnPara);
            this.panelBottom.Controls.Add(this.btnPari);
            this.panelBottom.Location = new System.Drawing.Point(10, 515);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(715, 44);
            this.panelBottom.TabIndex = 24;
            // 
            // btnFundit
            // 
            this.btnFundit.ForeColor = System.Drawing.Color.Navy;
            this.btnFundit.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_fundit;
            this.btnFundit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFundit.Location = new System.Drawing.Point(640, 4);
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
            this.btnPas.Location = new System.Drawing.Point(430, 4);
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
            this.btnPara.Location = new System.Drawing.Point(208, 4);
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
            this.panelTop.Controls.Add(this.btnModifiko);
            this.panelTop.Controls.Add(this.btnFshi);
            this.panelTop.Location = new System.Drawing.Point(10, 10);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(723, 44);
            this.panelTop.TabIndex = 6;
            // 
            // btnKerkoNeGride
            // 
            this.btnKerkoNeGride.ForeColor = System.Drawing.Color.Navy;
            this.btnKerkoNeGride.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerkoNeGride.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerkoNeGride.Location = new System.Drawing.Point(640, 4);
            this.btnKerkoNeGride.Name = "btnKerkoNeGride";
            this.btnKerkoNeGride.Size = new System.Drawing.Size(75, 37);
            this.btnKerkoNeGride.TabIndex = 8;
            this.btnKerkoNeGride.Text = "Kërko";
            this.btnKerkoNeGride.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKerkoNeGride.UseVisualStyleBackColor = true;
            this.btnKerkoNeGride.Click += new System.EventHandler(this.btnKerkoNeGride_Click);
            // 
            // btnModifiko
            // 
            this.btnModifiko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifiko.ForeColor = System.Drawing.Color.Navy;
            this.btnModifiko.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.btnModifiko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifiko.Location = new System.Drawing.Point(2, 4);
            this.btnModifiko.Name = "btnModifiko";
            this.btnModifiko.Size = new System.Drawing.Size(75, 37);
            this.btnModifiko.TabIndex = 2;
            this.btnModifiko.Text = "Modifiko";
            this.btnModifiko.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifiko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifiko.UseVisualStyleBackColor = true;
            this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
            // 
            // btnFshi
            // 
            this.btnFshi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFshi.ForeColor = System.Drawing.Color.Navy;
            this.btnFshi.Image = global::ResManagerAdmin.Properties.Resources.cancelbuild;
            this.btnFshi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshi.Location = new System.Drawing.Point(311, 4);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(75, 37);
            this.btnFshi.TabIndex = 3;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFshi.UseVisualStyleBackColor = true;
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // gridShpenzimet
            // 
            this.gridShpenzimet.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridShpenzimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridShpenzimet.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridShpenzimet.GroupByBoxVisible = false;
            this.gridShpenzimet.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridShpenzimet.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup;
            this.gridShpenzimet.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridShpenzimet.LayoutData = resources.GetString("gridShpenzimet.LayoutData");
            this.gridShpenzimet.Location = new System.Drawing.Point(12, 62);
            this.gridShpenzimet.Name = "gridShpenzimet";
            this.gridShpenzimet.Size = new System.Drawing.Size(716, 447);
            this.gridShpenzimet.TabIndex = 0;
            this.gridShpenzimet.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridShpenzimet.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridShpenzimet.CurrentCellChanged += new System.EventHandler(this.gridShpenzimet_CurrentCellChanged);
            // 
            // uiTabModifiko
            // 
            this.uiTabModifiko.BackColor = System.Drawing.Color.Transparent;
            this.uiTabModifiko.Controls.Add(this.uiTabPage2);
            this.uiTabModifiko.Location = new System.Drawing.Point(12, 62);
            this.uiTabModifiko.Name = "uiTabModifiko";
            this.uiTabModifiko.SelectedIndex = 0;
            this.uiTabModifiko.Size = new System.Drawing.Size(716, 447);
            this.uiTabModifiko.TabIndex = 23;
            this.uiTabModifiko.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2});
            this.uiTabModifiko.Visible = false;
            this.uiTabModifiko.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.uiGroupBox4);
            this.uiTabPage2.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.uiTabPage2.Location = new System.Drawing.Point(1, 23);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(712, 421);
            this.uiTabPage2.TabIndex = 0;
            this.uiTabPage2.Text = "Modifikim";
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox4.Controls.Add(this.cmbKategorite);
            this.uiGroupBox4.Controls.Add(this.dtpData);
            this.uiGroupBox4.Controls.Add(this.btnAnullo);
            this.uiGroupBox4.Controls.Add(this.btnRuaj);
            this.uiGroupBox4.Controls.Add(this.numVlera);
            this.uiGroupBox4.Controls.Add(this.label4);
            this.uiGroupBox4.Controls.Add(this.txtPershkrimi);
            this.uiGroupBox4.Controls.Add(this.label7);
            this.uiGroupBox4.Controls.Add(this.label8);
            this.uiGroupBox4.Controls.Add(this.label9);
            this.uiGroupBox4.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.uiGroupBox4.Image = global::ResManagerAdmin.Properties.Resources.bundle_024;
            this.uiGroupBox4.ImageSize = new System.Drawing.Size(24, 24);
            this.uiGroupBox4.Location = new System.Drawing.Point(3, 15);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Size = new System.Drawing.Size(521, 275);
            this.uiGroupBox4.TabIndex = 12;
            this.uiGroupBox4.Text = "Të dhënat e shpenzimit";
            this.uiGroupBox4.UseThemes = false;
            // 
            // cmbKategorite
            // 
            this.cmbKategorite.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKategorite.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbKategorite.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbKategorite.DisplayMember = "PERSHKRIMI";
            this.cmbKategorite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbKategorite.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbKategorite.LayoutData = resources.GetString("cmbKategorite.LayoutData");
            this.cmbKategorite.Location = new System.Drawing.Point(136, 101);
            this.cmbKategorite.Name = "cmbKategorite";
            this.cmbKategorite.Size = new System.Drawing.Size(180, 20);
            this.cmbKategorite.TabIndex = 26;
            this.cmbKategorite.Value = null;
            this.cmbKategorite.ValueMember = "ID_KATEGORIASHPENZIMI";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(138, 31);
            this.dtpData.Name = "dtpData";
            this.dtpData.ShowUpDown = true;
            this.dtpData.Size = new System.Drawing.Size(178, 20);
            this.dtpData.TabIndex = 25;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(378, 120);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 37);
            this.btnAnullo.TabIndex = 18;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.ForeColor = System.Drawing.Color.Navy;
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.save;
            this.btnRuaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuaj.Location = new System.Drawing.Point(378, 31);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(75, 37);
            this.btnRuaj.TabIndex = 16;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // numVlera
            // 
            this.numVlera.DecimalPlaces = 2;
            this.numVlera.Location = new System.Drawing.Point(138, 137);
            this.numVlera.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numVlera.Name = "numVlera";
            this.numVlera.Size = new System.Drawing.Size(178, 20);
            this.numVlera.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kategoria e shpenzimit";
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Location = new System.Drawing.Point(138, 65);
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(178, 20);
            this.txtPershkrimi.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Përshkrimi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Vlera";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.btnKerko);
            this.uiGroupBox2.Controls.Add(this.cmbKategoriteKerkim);
            this.uiGroupBox2.Controls.Add(this.dtpDataKerkim);
            this.uiGroupBox2.Controls.Add(this.cbData);
            this.uiGroupBox2.Controls.Add(this.txtPershkrimiKerkim);
            this.uiGroupBox2.Controls.Add(this.cbPershkrimi);
            this.uiGroupBox2.Controls.Add(this.cbKategoria);
            this.uiGroupBox2.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox2.Image")));
            this.uiGroupBox2.Location = new System.Drawing.Point(10, 40);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(214, 219);
            this.uiGroupBox2.TabIndex = 7;
            this.uiGroupBox2.Text = "Kërkim sipas";
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnKerko
            // 
            this.btnKerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerko.ForeColor = System.Drawing.Color.Navy;
            this.btnKerko.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerko.Location = new System.Drawing.Point(68, 181);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(66, 28);
            this.btnKerko.TabIndex = 9;
            this.btnKerko.Text = "Kërko";
            this.btnKerko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // cmbKategoriteKerkim
            // 
            this.cmbKategoriteKerkim.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKategoriteKerkim.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbKategoriteKerkim.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbKategoriteKerkim.DisplayMember = "PERSHKRIMI";
            this.cmbKategoriteKerkim.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbKategoriteKerkim.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbKategoriteKerkim.LayoutData = resources.GetString("cmbKategoriteKerkim.LayoutData");
            this.cmbKategoriteKerkim.Location = new System.Drawing.Point(13, 99);
            this.cmbKategoriteKerkim.Name = "cmbKategoriteKerkim";
            this.cmbKategoriteKerkim.Size = new System.Drawing.Size(180, 20);
            this.cmbKategoriteKerkim.TabIndex = 25;
            this.cmbKategoriteKerkim.Value = null;
            this.cmbKategoriteKerkim.ValueMember = "ID_KATEGORIASHPENZIMI";
            // 
            // dtpDataKerkim
            // 
            this.dtpDataKerkim.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtpDataKerkim.CustomFormat = "dd.MM.yyyy";
            this.dtpDataKerkim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataKerkim.Location = new System.Drawing.Point(13, 45);
            this.dtpDataKerkim.Name = "dtpDataKerkim";
            this.dtpDataKerkim.ShowUpDown = true;
            this.dtpDataKerkim.Size = new System.Drawing.Size(180, 20);
            this.dtpDataKerkim.TabIndex = 24;
            // 
            // cbData
            // 
            this.cbData.AutoSize = true;
            this.cbData.Location = new System.Drawing.Point(13, 22);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(54, 17);
            this.cbData.TabIndex = 15;
            this.cbData.Text = "Datës";
            this.cbData.UseVisualStyleBackColor = true;
            this.cbData.CheckedChanged += new System.EventHandler(this.cbData_CheckedChanged);
            // 
            // txtPershkrimiKerkim
            // 
            this.txtPershkrimiKerkim.Location = new System.Drawing.Point(13, 151);
            this.txtPershkrimiKerkim.Name = "txtPershkrimiKerkim";
            this.txtPershkrimiKerkim.Size = new System.Drawing.Size(180, 20);
            this.txtPershkrimiKerkim.TabIndex = 14;
            // 
            // cbPershkrimi
            // 
            this.cbPershkrimi.AutoSize = true;
            this.cbPershkrimi.Location = new System.Drawing.Point(13, 127);
            this.cbPershkrimi.Name = "cbPershkrimi";
            this.cbPershkrimi.Size = new System.Drawing.Size(77, 17);
            this.cbPershkrimi.TabIndex = 13;
            this.cbPershkrimi.Text = "Përshkrimit";
            this.cbPershkrimi.UseVisualStyleBackColor = true;
            this.cbPershkrimi.CheckedChanged += new System.EventHandler(this.cbPershkrimi_CheckedChanged);
            // 
            // cbKategoria
            // 
            this.cbKategoria.AutoSize = true;
            this.cbKategoria.Location = new System.Drawing.Point(13, 75);
            this.cbKategoria.Name = "cbKategoria";
            this.cbKategoria.Size = new System.Drawing.Size(76, 17);
            this.cbKategoria.TabIndex = 12;
            this.cbKategoria.Text = "Kategorise";
            this.cbKategoria.UseVisualStyleBackColor = true;
            this.cbKategoria.CheckedChanged += new System.EventHandler(this.cbKategoria_CheckedChanged);
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Checked = true;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.OptionGroup = "navBar";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // frmShfaqShpenzime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShfaqShpenzime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Shpenzimet";
            this.Load += new System.EventHandler(this.frmShfaqShpenzime_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmShfaqShpenzime_CausesValidationChanged);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbShpenzimet)).EndInit();
            this.gbShpenzimet.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridShpenzimet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTabModifiko)).EndInit();
            this.uiTabModifiko.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).EndInit();
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVlera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.EditControls.UIGroupBox gbShpenzimet;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnModifiko;
        private System.Windows.Forms.Button btnFshi;
        private Janus.Windows.UI.Tab.UITab uiTabModifiko;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox4;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.NumericUpDown numVlera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Janus.Windows.GridEX.GridEX gridShpenzimet;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.TextBox txtPershkrimiKerkim;
        private System.Windows.Forms.CheckBox cbPershkrimi;
        private System.Windows.Forms.CheckBox cbKategoria;
        private System.Windows.Forms.Button btnKerko;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private System.Windows.Forms.DateTimePicker dtpDataKerkim;
        private System.Windows.Forms.CheckBox cbData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnFundit;
        private System.Windows.Forms.Button btnPas;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Button btnPari;
        private System.Windows.Forms.Button btnKerkoNeGride;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbKategoriteKerkim;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbKategorite;
    }
}