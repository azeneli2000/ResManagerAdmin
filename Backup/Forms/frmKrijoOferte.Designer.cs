namespace ResManagerAdmin.Forms
{
    partial class frmKrijoOferte
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKrijoOferte));
            this.paneli = new DevComponents.DotNetBar.ExpandablePanel();
            this.panelLeft = new DevComponents.DotNetBar.PanelEx();
            this.btnAktivizo = new DevComponents.DotNetBar.ButtonX();
            this.btnCaktivizo = new DevComponents.DotNetBar.ButtonX();
            this.btnModifikoOferte = new DevComponents.DotNetBar.ButtonX();
            this.btnShtoOferte = new DevComponents.DotNetBar.ButtonX();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.btnAnulloOferte = new DevComponents.DotNetBar.ButtonX();
            this.btnRuajOferte = new DevComponents.DotNetBar.ButtonX();
            this.tabi = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.cboRecetat = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cboKategorite = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFshiRecete = new DevComponents.DotNetBar.ButtonX();
            this.btnRuajRecete = new DevComponents.DotNetBar.ButtonX();
            this.numSasia = new Janus.Windows.GridEX.EditControls.IntegerUpDown();
            this.gridaOferta = new Janus.Windows.GridEX.GridEX();
            this.cboGrupi = new System.Windows.Forms.ComboBox();
            this.tabRecetat = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel = new DevComponents.DotNetBar.TabControlPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.numCmimi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.tabOferta = new DevComponents.DotNetBar.TabItem(this.components);
            this.optBari = new System.Windows.Forms.RadioButton();
            this.optHoteli = new System.Windows.Forms.RadioButton();
            this.paneli.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabi)).BeginInit();
            this.tabi.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaOferta)).BeginInit();
            this.tabControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCmimi)).BeginInit();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.paneli.Controls.Add(this.panelLeft);
            this.paneli.Controls.Add(this.grida);
            this.paneli.Controls.Add(this.btnAnulloOferte);
            this.paneli.Controls.Add(this.btnRuajOferte);
            this.paneli.Controls.Add(this.tabi);
            this.paneli.Controls.Add(this.optBari);
            this.paneli.Controls.Add(this.optHoteli);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.ExpandButtonVisible = false;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(1014, 640);
            this.paneli.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.paneli.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.paneli.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.paneli.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.paneli.Style.GradientAngle = 90;
            this.paneli.TabIndex = 0;
            this.paneli.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.paneli.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.paneli.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneli.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.paneli.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneli.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.paneli.TitleStyle.GradientAngle = 90;
            this.paneli.TitleText = "Ofertat";
            // 
            // panelLeft
            // 
            this.panelLeft.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelLeft.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelLeft.Controls.Add(this.btnAktivizo);
            this.panelLeft.Controls.Add(this.btnCaktivizo);
            this.panelLeft.Controls.Add(this.btnModifikoOferte);
            this.panelLeft.Controls.Add(this.btnShtoOferte);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 26);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(195, 614);
            this.panelLeft.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelLeft.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelLeft.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelLeft.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelLeft.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelLeft.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelLeft.Style.GradientAngle = 90;
            this.panelLeft.TabIndex = 7;
            // 
            // btnAktivizo
            // 
            this.btnAktivizo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAktivizo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktivizo.Image = global::ResManagerAdmin.Properties.Resources.minus;
            this.btnAktivizo.Location = new System.Drawing.Point(45, 268);
            this.btnAktivizo.Name = "btnAktivizo";
            this.btnAktivizo.Size = new System.Drawing.Size(100, 35);
            this.btnAktivizo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAktivizo.TabIndex = 3;
            this.btnAktivizo.Text = " Aktivizo";
            // 
            // btnCaktivizo
            // 
            this.btnCaktivizo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCaktivizo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnCaktivizo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaktivizo.Image = global::ResManagerAdmin.Properties.Resources.plus_vogel;
            this.btnCaktivizo.Location = new System.Drawing.Point(45, 198);
            this.btnCaktivizo.Name = "btnCaktivizo";
            this.btnCaktivizo.Size = new System.Drawing.Size(100, 35);
            this.btnCaktivizo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnCaktivizo.TabIndex = 2;
            this.btnCaktivizo.Text = " Caktivizo";
            this.btnCaktivizo.Click += new System.EventHandler(this.btnCaktivizo_Click);
            // 
            // btnModifikoOferte
            // 
            this.btnModifikoOferte.BackColor = System.Drawing.Color.Transparent;
            this.btnModifikoOferte.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnModifikoOferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifikoOferte.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.btnModifikoOferte.Location = new System.Drawing.Point(45, 128);
            this.btnModifikoOferte.Name = "btnModifikoOferte";
            this.btnModifikoOferte.Size = new System.Drawing.Size(100, 35);
            this.btnModifikoOferte.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnModifikoOferte.TabIndex = 1;
            this.btnModifikoOferte.Text = "Modifiko";
            this.btnModifikoOferte.Click += new System.EventHandler(this.btnModifikoOferte_Click);
            // 
            // btnShtoOferte
            // 
            this.btnShtoOferte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShtoOferte.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnShtoOferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShtoOferte.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShtoOferte.Image = ((System.Drawing.Image)(resources.GetObject("btnShtoOferte.Image")));
            this.btnShtoOferte.Location = new System.Drawing.Point(45, 58);
            this.btnShtoOferte.Name = "btnShtoOferte";
            this.btnShtoOferte.Size = new System.Drawing.Size(100, 35);
            this.btnShtoOferte.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnShtoOferte.TabIndex = 0;
            this.btnShtoOferte.Text = "Shto";
            this.btnShtoOferte.Click += new System.EventHandler(this.btnShtoOferte_Click);
            // 
            // grida
            // 
            this.grida.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(233, 84);
            this.grida.Name = "grida";
            this.grida.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grida.Size = new System.Drawing.Size(751, 520);
            this.grida.TabIndex = 6;
            this.grida.DoubleClick += new System.EventHandler(this.grida_DoubleClick);
            // 
            // btnAnulloOferte
            // 
            this.btnAnulloOferte.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnulloOferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulloOferte.Image = ((System.Drawing.Image)(resources.GetObject("btnAnulloOferte.Image")));
            this.btnAnulloOferte.Location = new System.Drawing.Point(660, 569);
            this.btnAnulloOferte.Name = "btnAnulloOferte";
            this.btnAnulloOferte.Size = new System.Drawing.Size(100, 35);
            this.btnAnulloOferte.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnulloOferte.TabIndex = 5;
            this.btnAnulloOferte.Text = "Anullo";
            this.btnAnulloOferte.Click += new System.EventHandler(this.btnAnulloOferte_Click);
            // 
            // btnRuajOferte
            // 
            this.btnRuajOferte.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuajOferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuajOferte.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.btnRuajOferte.Location = new System.Drawing.Point(475, 569);
            this.btnRuajOferte.Name = "btnRuajOferte";
            this.btnRuajOferte.Size = new System.Drawing.Size(100, 35);
            this.btnRuajOferte.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnRuajOferte.TabIndex = 4;
            this.btnRuajOferte.Text = "Ruaj";
            this.btnRuajOferte.Click += new System.EventHandler(this.btnRuajOferte_Click);
            // 
            // tabi
            // 
            this.tabi.BackColor = System.Drawing.Color.Transparent;
            this.tabi.CanReorderTabs = true;
            this.tabi.Controls.Add(this.tabControlPanel);
            this.tabi.Controls.Add(this.tabControlPanel1);
            this.tabi.Location = new System.Drawing.Point(243, 84);
            this.tabi.Name = "tabi";
            this.tabi.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabi.SelectedTabIndex = 0;
            this.tabi.Size = new System.Drawing.Size(718, 458);
            this.tabi.TabIndex = 3;
            this.tabi.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabi.Tabs.Add(this.tabOferta);
            this.tabi.Tabs.Add(this.tabRecetat);
            this.tabi.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.cboRecetat);
            this.tabControlPanel1.Controls.Add(this.cboKategorite);
            this.tabControlPanel1.Controls.Add(this.label6);
            this.tabControlPanel1.Controls.Add(this.label5);
            this.tabControlPanel1.Controls.Add(this.label4);
            this.tabControlPanel1.Controls.Add(this.label3);
            this.tabControlPanel1.Controls.Add(this.btnFshiRecete);
            this.tabControlPanel1.Controls.Add(this.btnRuajRecete);
            this.tabControlPanel1.Controls.Add(this.numSasia);
            this.tabControlPanel1.Controls.Add(this.gridaOferta);
            this.tabControlPanel1.Controls.Add(this.cboGrupi);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(718, 432);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 2;
            this.tabControlPanel1.TabItem = this.tabRecetat;
            this.tabControlPanel1.Click += new System.EventHandler(this.tabControlPanel1_Click);
            // 
            // cboRecetat
            // 
            this.cboRecetat.BackColor = System.Drawing.SystemColors.Window;
            this.cboRecetat.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboRecetat.DisplayMember = "EMRI";
            this.cboRecetat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboRecetat.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboRecetat.LayoutData = resources.GetString("cboRecetat.LayoutData");
            this.cboRecetat.Location = new System.Drawing.Point(214, 97);
            this.cboRecetat.Name = "cboRecetat";
            this.cboRecetat.Size = new System.Drawing.Size(169, 20);
            this.cboRecetat.TabIndex = 12;
            this.cboRecetat.Value = null;
            this.cboRecetat.ValueMember = "ID_RECETA";
            this.cboRecetat.ValueChanged += new System.EventHandler(this.cboRecetat_ValueChanged);
            // 
            // cboKategorite
            // 
            this.cboKategorite.BackColor = System.Drawing.SystemColors.Window;
            this.cboKategorite.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboKategorite.DisplayMember = "PERSHKRIMI";
            this.cboKategorite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboKategorite.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboKategorite.LayoutData = resources.GetString("cboKategorite.LayoutData");
            this.cboKategorite.Location = new System.Drawing.Point(25, 97);
            this.cboKategorite.Name = "cboKategorite";
            this.cboKategorite.Size = new System.Drawing.Size(169, 20);
            this.cboKategorite.TabIndex = 11;
            this.cboKategorite.Value = null;
            this.cboKategorite.ValueMember = "ID_KATEGORIARECETA";
            this.cboKategorite.ValueChanged += new System.EventHandler(this.cboKategorite_ValueChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(405, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sasia";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(214, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Recetat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(25, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kategorite";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(25, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Indeksi i shportes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFshiRecete
            // 
            this.btnFshiRecete.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnFshiRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFshiRecete.Image = global::ResManagerAdmin.Properties.Resources.delete_button1;
            this.btnFshiRecete.Location = new System.Drawing.Point(513, 246);
            this.btnFshiRecete.Name = "btnFshiRecete";
            this.btnFshiRecete.Size = new System.Drawing.Size(80, 30);
            this.btnFshiRecete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnFshiRecete.TabIndex = 6;
            this.btnFshiRecete.Click += new System.EventHandler(this.btnFshiRecete_Click);
            // 
            // btnRuajRecete
            // 
            this.btnRuajRecete.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuajRecete.Image = ((System.Drawing.Image)(resources.GetObject("btnRuajRecete.Image")));
            this.btnRuajRecete.Location = new System.Drawing.Point(513, 95);
            this.btnRuajRecete.Name = "btnRuajRecete";
            this.btnRuajRecete.Size = new System.Drawing.Size(80, 30);
            this.btnRuajRecete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnRuajRecete.TabIndex = 5;
            this.btnRuajRecete.Click += new System.EventHandler(this.btnRuajRecete_Click);
            // 
            // numSasia
            // 
            this.numSasia.BackColor = System.Drawing.SystemColors.Window;
            this.numSasia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numSasia.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.numSasia.Increment = 1;
            this.numSasia.Location = new System.Drawing.Point(403, 97);
            this.numSasia.Name = "numSasia";
            this.numSasia.Size = new System.Drawing.Size(91, 20);
            this.numSasia.TabIndex = 4;
            // 
            // gridaOferta
            // 
            this.gridaOferta.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaOferta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaOferta.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaOferta.GroupByBoxVisible = false;
            this.gridaOferta.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaOferta.LayoutData = resources.GetString("gridaOferta.LayoutData");
            this.gridaOferta.Location = new System.Drawing.Point(25, 134);
            this.gridaOferta.Name = "gridaOferta";
            this.gridaOferta.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaOferta.Size = new System.Drawing.Size(468, 289);
            this.gridaOferta.TabIndex = 3;
            // 
            // cboGrupi
            // 
            this.cboGrupi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupi.FormattingEnabled = true;
            this.cboGrupi.Location = new System.Drawing.Point(25, 36);
            this.cboGrupi.Name = "cboGrupi";
            this.cboGrupi.Size = new System.Drawing.Size(137, 21);
            this.cboGrupi.TabIndex = 0;
            // 
            // tabRecetat
            // 
            this.tabRecetat.AttachedControl = this.tabControlPanel1;
            this.tabRecetat.Name = "tabRecetat";
            this.tabRecetat.Text = "Perberesit";
            // 
            // tabControlPanel
            // 
            this.tabControlPanel.Controls.Add(this.label2);
            this.tabControlPanel.Controls.Add(this.numCmimi);
            this.tabControlPanel.Controls.Add(this.label1);
            this.tabControlPanel.Controls.Add(this.txtEmri);
            this.tabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel.Name = "tabControlPanel";
            this.tabControlPanel.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel.Size = new System.Drawing.Size(718, 432);
            this.tabControlPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel.Style.GradientAngle = 90;
            this.tabControlPanel.TabIndex = 1;
            this.tabControlPanel.TabItem = this.tabOferta;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(83, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cmimi";
            // 
            // numCmimi
            // 
            this.numCmimi.Location = new System.Drawing.Point(232, 122);
            this.numCmimi.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCmimi.Name = "numCmimi";
            this.numCmimi.Size = new System.Drawing.Size(261, 20);
            this.numCmimi.TabIndex = 2;
            this.numCmimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(83, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emertimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(232, 74);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(262, 20);
            this.txtEmri.TabIndex = 0;
            // 
            // tabOferta
            // 
            this.tabOferta.AttachedControl = this.tabControlPanel;
            this.tabOferta.Name = "tabOferta";
            this.tabOferta.Text = "   Oferta     ";
            // 
            // optBari
            // 
            this.optBari.AutoSize = true;
            this.optBari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBari.Location = new System.Drawing.Point(493, 44);
            this.optBari.Name = "optBari";
            this.optBari.Size = new System.Drawing.Size(87, 20);
            this.optBari.TabIndex = 2;
            this.optBari.TabStop = true;
            this.optBari.Text = "Restoranti";
            this.optBari.UseVisualStyleBackColor = true;
            this.optBari.CheckedChanged += new System.EventHandler(this.optBari_CheckedChanged);
            // 
            // optHoteli
            // 
            this.optHoteli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHoteli.Location = new System.Drawing.Point(681, 44);
            this.optHoteli.Name = "optHoteli";
            this.optHoteli.Size = new System.Drawing.Size(101, 20);
            this.optHoteli.TabIndex = 1;
            this.optHoteli.TabStop = true;
            this.optHoteli.Text = "Hoteli";
            this.optHoteli.UseVisualStyleBackColor = true;
            // 
            // frmKrijoOferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 640);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKrijoOferte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krijo ofertë";
            this.Load += new System.EventHandler(this.frmKrijoOferte_Load);
            this.paneli.ResumeLayout(false);
            this.paneli.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabi)).EndInit();
            this.tabi.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaOferta)).EndInit();
            this.tabControlPanel.ResumeLayout(false);
            this.tabControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCmimi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel paneli;
        private System.Windows.Forms.RadioButton optBari;
        private System.Windows.Forms.RadioButton optHoteli;
        private DevComponents.DotNetBar.TabControl tabi;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel;
        private DevComponents.DotNetBar.TabItem tabOferta;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabRecetat;
        private System.Windows.Forms.NumericUpDown numCmimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnAnulloOferte;
        private DevComponents.DotNetBar.ButtonX btnRuajOferte;
        private System.Windows.Forms.ComboBox cboGrupi;
        private Janus.Windows.GridEX.EditControls.IntegerUpDown numSasia;
        private Janus.Windows.GridEX.GridEX gridaOferta;
        private DevComponents.DotNetBar.ButtonX btnRuajRecete;
        private DevComponents.DotNetBar.ButtonX btnFshiRecete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboKategorite;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboRecetat;
        private Janus.Windows.GridEX.GridEX grida;
        private DevComponents.DotNetBar.PanelEx panelLeft;
        private DevComponents.DotNetBar.ButtonX btnCaktivizo;
        private DevComponents.DotNetBar.ButtonX btnModifikoOferte;
        private DevComponents.DotNetBar.ButtonX btnShtoOferte;
        private DevComponents.DotNetBar.ButtonX btnAktivizo;

    }
}