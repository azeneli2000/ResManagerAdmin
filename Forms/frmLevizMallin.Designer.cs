namespace ResManagerAdmin.Forms
{
    partial class frmLevizMallin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevizMallin));
            this.paneli = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnNxirr = new DevComponents.DotNetBar.ButtonX();
            this.btnFut = new DevComponents.DotNetBar.ButtonX();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.tabControli = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnAnullo = new DevComponents.DotNetBar.ButtonX();
            this.btnFshiArtikull = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRuajArtikull = new DevComponents.DotNetBar.ButtonX();
            this.gridaArtikujt = new Janus.Windows.GridEX.GridEX();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbArtikulli = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnAnulloArtikull = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.numSasia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNjesia = new System.Windows.Forms.TextBox();
            this.cmbKategoriaArtikulli = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.tabItemShto = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControli)).BeginInit();
            this.tabControli.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaArtikujt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSasia)).BeginInit();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.paneli.Controls.Add(this.btnNxirr);
            this.paneli.Controls.Add(this.btnFut);
            this.paneli.Controls.Add(this.lblTitle);
            this.paneli.Controls.Add(this.grida);
            this.paneli.Controls.Add(this.tabControli);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.ExpandButtonVisible = false;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(1036, 640);
            this.paneli.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.paneli.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.paneli.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.paneli.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.paneli.Style.GradientAngle = 90;
            this.paneli.TabIndex = 0;
            this.paneli.TitleHeight = 30;
            this.paneli.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.paneli.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.paneli.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneli.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.paneli.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneli.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.paneli.TitleStyle.GradientAngle = 90;
            this.paneli.TitleText = "Levizja e mallit ne banak";
            // 
            // btnNxirr
            // 
            this.btnNxirr.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnNxirr.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNxirr.Image = ((System.Drawing.Image)(resources.GetObject("btnNxirr.Image")));
            this.btnNxirr.Location = new System.Drawing.Point(543, 585);
            this.btnNxirr.Name = "btnNxirr";
            this.btnNxirr.Size = new System.Drawing.Size(110, 40);
            this.btnNxirr.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnNxirr.TabIndex = 5;
            this.btnNxirr.Text = "  Nxirr mall";
            this.btnNxirr.Click += new System.EventHandler(this.btnNxirr_Click);
            // 
            // btnFut
            // 
            this.btnFut.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnFut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFut.Image = ((System.Drawing.Image)(resources.GetObject("btnFut.Image")));
            this.btnFut.Location = new System.Drawing.Point(408, 585);
            this.btnFut.Name = "btnFut";
            this.btnFut.Size = new System.Drawing.Size(110, 40);
            this.btnFut.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnFut.TabIndex = 4;
            this.btnFut.Text = "  Hidh mall";
            this.btnFut.Click += new System.EventHandler(this.btnFut_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(174, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(648, 27);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Gjendja momentale e mallit ne banakun korespondues";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grida
            // 
            this.grida.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxInfoText = "Tërhiqni një prej kolonave për të grupuar";
            this.grida.GroupByBoxVisible = false;
            this.grida.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.grida.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.grida.HeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grida.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.False;
            this.grida.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(174, 78);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(648, 492);
            this.grida.TabIndex = 6;
            // 
            // tabControli
            // 
            this.tabControli.Controls.Add(this.uiTabPage1);
            this.tabControli.Location = new System.Drawing.Point(174, 78);
            this.tabControli.Name = "tabControli";
            this.tabControli.SelectedIndex = 0;
            this.tabControli.Size = new System.Drawing.Size(648, 492);
            this.tabControli.TabIndex = 7;
            this.tabControli.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.buttonX1);
            this.uiTabPage1.Controls.Add(this.btnAnullo);
            this.uiTabPage1.Controls.Add(this.btnFshiArtikull);
            this.uiTabPage1.Controls.Add(this.label2);
            this.uiTabPage1.Controls.Add(this.btnRuajArtikull);
            this.uiTabPage1.Controls.Add(this.gridaArtikujt);
            this.uiTabPage1.Controls.Add(this.label3);
            this.uiTabPage1.Controls.Add(this.cmbArtikulli);
            this.uiTabPage1.Controls.Add(this.btnAnulloArtikull);
            this.uiTabPage1.Controls.Add(this.label4);
            this.uiTabPage1.Controls.Add(this.numSasia);
            this.uiTabPage1.Controls.Add(this.label5);
            this.uiTabPage1.Controls.Add(this.txtNjesia);
            this.uiTabPage1.Controls.Add(this.cmbKategoriaArtikulli);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(644, 468);
            this.uiTabPage1.TabIndex = 0;
            this.uiTabPage1.Text = "Shtim";
            // 
            // buttonX1
            // 
            this.buttonX1.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.buttonX1.Location = new System.Drawing.Point(265, 425);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(80, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.buttonX1.TabIndex = 41;
            this.buttonX1.Text = "Ruaj";
            this.buttonX1.Click += new System.EventHandler(this.btnRuajLevizje_Click);
            // 
            // btnAnullo
            // 
            this.btnAnullo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnullo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.mbyll;
            this.btnAnullo.Location = new System.Drawing.Point(368, 425);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(80, 30);
            this.btnAnullo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnullo.TabIndex = 40;
            this.btnAnullo.Text = "Dil";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnulloLevizje_Click);
            // 
            // btnFshiArtikull
            // 
            this.btnFshiArtikull.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnFshiArtikull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFshiArtikull.Image = global::ResManagerAdmin.Properties.Resources.delete_button2;
            this.btnFshiArtikull.Location = new System.Drawing.Point(559, 297);
            this.btnFshiArtikull.Name = "btnFshiArtikull";
            this.btnFshiArtikull.Size = new System.Drawing.Size(75, 30);
            this.btnFshiArtikull.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnFshiArtikull.TabIndex = 35;
            this.btnFshiArtikull.Text = "Fshi";
            this.btnFshiArtikull.Click += new System.EventHandler(this.btnFshiArtikull_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Kategoria";
            // 
            // btnRuajArtikull
            // 
            this.btnRuajArtikull.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuajArtikull.Image = ((System.Drawing.Image)(resources.GetObject("btnRuajArtikull.Image")));
            this.btnRuajArtikull.Location = new System.Drawing.Point(363, 152);
            this.btnRuajArtikull.Name = "btnRuajArtikull";
            this.btnRuajArtikull.Size = new System.Drawing.Size(80, 30);
            this.btnRuajArtikull.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnRuajArtikull.TabIndex = 32;
            this.btnRuajArtikull.Text = "Shto";
            this.btnRuajArtikull.Click += new System.EventHandler(this.btnRuajArtikull_Click);
            // 
            // gridaArtikujt
            // 
            this.gridaArtikujt.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaArtikujt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaArtikujt.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaArtikujt.GroupByBoxVisible = false;
            this.gridaArtikujt.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridaArtikujt.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaArtikujt.LayoutData = resources.GetString("gridaArtikujt.LayoutData");
            this.gridaArtikujt.Location = new System.Drawing.Point(102, 205);
            this.gridaArtikujt.Name = "gridaArtikujt";
            this.gridaArtikujt.Size = new System.Drawing.Size(446, 205);
            this.gridaArtikujt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Artikulli";
            // 
            // cmbArtikulli
            // 
            this.cmbArtikulli.BackColor = System.Drawing.SystemColors.Window;
            this.cmbArtikulli.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbArtikulli.DisplayMember = "EMRI";
            this.cmbArtikulli.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbArtikulli.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbArtikulli.LayoutData = resources.GetString("cmbArtikulli.LayoutData");
            this.cmbArtikulli.Location = new System.Drawing.Point(265, 51);
            this.cmbArtikulli.Name = "cmbArtikulli";
            this.cmbArtikulli.Size = new System.Drawing.Size(178, 20);
            this.cmbArtikulli.TabIndex = 24;
            this.cmbArtikulli.Value = null;
            this.cmbArtikulli.ValueMember = "ID_ARTIKULLI";
            this.cmbArtikulli.ValueChanged += new System.EventHandler(this.cmbArtikulli_ValueChanged);
            // 
            // btnAnulloArtikull
            // 
            this.btnAnulloArtikull.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnulloArtikull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulloArtikull.Image = ((System.Drawing.Image)(resources.GetObject("btnAnulloArtikull.Image")));
            this.btnAnulloArtikull.Location = new System.Drawing.Point(265, 152);
            this.btnAnulloArtikull.Name = "btnAnulloArtikull";
            this.btnAnulloArtikull.Size = new System.Drawing.Size(80, 30);
            this.btnAnulloArtikull.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnulloArtikull.TabIndex = 31;
            this.btnAnulloArtikull.Text = "Pastro";
            this.btnAnulloArtikull.Click += new System.EventHandler(this.btnAnulloArtikull_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Njesia";
            // 
            // numSasia
            // 
            this.numSasia.DecimalPlaces = 2;
            this.numSasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSasia.Location = new System.Drawing.Point(265, 111);
            this.numSasia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSasia.Name = "numSasia";
            this.numSasia.Size = new System.Drawing.Size(178, 21);
            this.numSasia.TabIndex = 25;
            this.numSasia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Sasia";
            // 
            // txtNjesia
            // 
            this.txtNjesia.BackColor = System.Drawing.Color.White;
            this.txtNjesia.Enabled = false;
            this.txtNjesia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNjesia.ForeColor = System.Drawing.Color.Navy;
            this.txtNjesia.Location = new System.Drawing.Point(265, 81);
            this.txtNjesia.Name = "txtNjesia";
            this.txtNjesia.ReadOnly = true;
            this.txtNjesia.Size = new System.Drawing.Size(178, 20);
            this.txtNjesia.TabIndex = 26;
            // 
            // cmbKategoriaArtikulli
            // 
            this.cmbKategoriaArtikulli.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKategoriaArtikulli.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbKategoriaArtikulli.DisplayMember = "PERSHKRIMI";
            this.cmbKategoriaArtikulli.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbKategoriaArtikulli.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbKategoriaArtikulli.LayoutData = resources.GetString("cmbKategoriaArtikulli.LayoutData");
            this.cmbKategoriaArtikulli.Location = new System.Drawing.Point(265, 21);
            this.cmbKategoriaArtikulli.Name = "cmbKategoriaArtikulli";
            this.cmbKategoriaArtikulli.Size = new System.Drawing.Size(178, 20);
            this.cmbKategoriaArtikulli.TabIndex = 23;
            this.cmbKategoriaArtikulli.Value = null;
            this.cmbKategoriaArtikulli.ValueMember = "ID_KATEGORIAARTIKULLI";
            this.cmbKategoriaArtikulli.ValueChanged += new System.EventHandler(this.cmbKategoriaArtikulli_ValueChanged);
            // 
            // tabItemShto
            // 
            this.tabItemShto.Name = "tabItemShto";
            this.tabItemShto.Text = "   Shtim      :";
            // 
            // tabItem1
            // 
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Shtim";
            // 
            // frmLevizMallin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 640);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLevizMallin";
            this.Text = "Levizja e mallit ne banak";
            this.Load += new System.EventHandler(this.frmLevizMallin_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmLevizMallin_CausesValidationChanged);
            this.paneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControli)).EndInit();
            this.tabControli.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaArtikujt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSasia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel paneli;
        private DevComponents.DotNetBar.TabItem tabItemShto;
        private System.Windows.Forms.Label lblTitle;
        private DevComponents.DotNetBar.ButtonX btnNxirr;
        private DevComponents.DotNetBar.ButtonX btnFut;
        private Janus.Windows.GridEX.GridEX grida;
        private Janus.Windows.GridEX.GridEX gridaArtikujt;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbKategoriaArtikulli;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbArtikulli;
        private System.Windows.Forms.NumericUpDown numSasia;
        private System.Windows.Forms.TextBox txtNjesia;
        private DevComponents.DotNetBar.ButtonX btnRuajArtikull;
        private DevComponents.DotNetBar.ButtonX btnAnulloArtikull;
        private DevComponents.DotNetBar.ButtonX btnFshiArtikull;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.UI.Tab.UITab tabControli;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnAnullo;
    }
}