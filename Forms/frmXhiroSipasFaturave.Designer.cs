namespace ResManagerAdmin.Forms
{
    partial class frmXhiroSipasFaturave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXhiroSipasFaturave));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.gbXhiro = new Janus.Windows.EditControls.UIGroupBox();
            this.lblDataZgjedhur = new System.Windows.Forms.Label();
            this.gridDetaje = new Janus.Windows.GridEX.GridEX();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grupoSipasKolonësToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tavolinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kamarieriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaEPagesësToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shfaqKoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nrFatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tavolinaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kamarieriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vleraEXhirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaEPagesësToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vleraMeKomisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridDatat = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTavolina = new System.Windows.Forms.ComboBox();
            this.cboKamarieri = new System.Windows.Forms.ComboBox();
            this.btnKerko = new System.Windows.Forms.Button();
            this.chkKamarieri = new System.Windows.Forms.CheckBox();
            this.chkTavolina = new System.Windows.Forms.CheckBox();
            this.dtpMbarimi = new System.Windows.Forms.DateTimePicker();
            this.dtpFillimi = new System.Windows.Forms.DateTimePicker();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbXhiro)).BeginInit();
            this.gbXhiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetaje)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.AutoScroll = true;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.gbXhiro);
            this.expandablePanel1.Controls.Add(this.uiGroupBox1);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandablePanel1.ExpandButtonVisible = false;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(1020, 620);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandablePanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 7;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Xhiro sipas faturave";
            // 
            // gbXhiro
            // 
            this.gbXhiro.Controls.Add(this.lblDataZgjedhur);
            this.gbXhiro.Controls.Add(this.gridDetaje);
            this.gbXhiro.Controls.Add(this.gridDatat);
            this.gbXhiro.Image = ((System.Drawing.Image)(resources.GetObject("gbXhiro.Image")));
            this.gbXhiro.ImageSize = new System.Drawing.Size(24, 24);
            this.gbXhiro.Location = new System.Drawing.Point(216, 40);
            this.gbXhiro.Name = "gbXhiro";
            this.gbXhiro.Size = new System.Drawing.Size(801, 571);
            this.gbXhiro.TabIndex = 4;
            this.gbXhiro.Text = "Xhiro efektive për intervalin e zgjedhur të datave";
            this.gbXhiro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // lblDataZgjedhur
            // 
            this.lblDataZgjedhur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDataZgjedhur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataZgjedhur.Location = new System.Drawing.Point(263, 27);
            this.lblDataZgjedhur.Name = "lblDataZgjedhur";
            this.lblDataZgjedhur.Size = new System.Drawing.Size(516, 22);
            this.lblDataZgjedhur.TabIndex = 2;
            this.lblDataZgjedhur.Text = "Faturat per daten e zgjedhur :";
            this.lblDataZgjedhur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridDetaje
            // 
            this.gridDetaje.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridDetaje.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText;
            this.gridDetaje.ContextMenuStrip = this.contextMenuStrip1;
            this.gridDetaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridDetaje.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridDetaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDetaje.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridDetaje.GroupByBoxVisible = false;
            this.gridDetaje.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridDetaje.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridDetaje.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.gridDetaje.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridDetaje.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridDetaje.LayoutData = resources.GetString("gridDetaje.LayoutData");
            this.gridDetaje.Location = new System.Drawing.Point(263, 52);
            this.gridDetaje.Name = "gridDetaje";
            this.gridDetaje.Size = new System.Drawing.Size(516, 496);
            this.gridDetaje.TabIndex = 1;
            this.gridDetaje.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridDetaje.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grupoSipasKolonësToolStripMenuItem,
            this.shfaqKoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // grupoSipasKolonësToolStripMenuItem
            // 
            this.grupoSipasKolonësToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tavolinaToolStripMenuItem,
            this.kamarieriToolStripMenuItem,
            this.formaEPagesësToolStripMenuItem});
            this.grupoSipasKolonësToolStripMenuItem.Name = "grupoSipasKolonësToolStripMenuItem";
            this.grupoSipasKolonësToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grupoSipasKolonësToolStripMenuItem.Text = "Grupo sipas kolonës";
            // 
            // tavolinaToolStripMenuItem
            // 
            this.tavolinaToolStripMenuItem.CheckOnClick = true;
            this.tavolinaToolStripMenuItem.Name = "tavolinaToolStripMenuItem";
            this.tavolinaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tavolinaToolStripMenuItem.Text = "Tavolina";
            this.tavolinaToolStripMenuItem.Click += new System.EventHandler(this.tavolinaToolStripMenuItem_Click);
            // 
            // kamarieriToolStripMenuItem
            // 
            this.kamarieriToolStripMenuItem.CheckOnClick = true;
            this.kamarieriToolStripMenuItem.Name = "kamarieriToolStripMenuItem";
            this.kamarieriToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kamarieriToolStripMenuItem.Text = "Kamarieri";
            this.kamarieriToolStripMenuItem.Click += new System.EventHandler(this.kamarieriToolStripMenuItem_Click);
            // 
            // formaEPagesësToolStripMenuItem
            // 
            this.formaEPagesësToolStripMenuItem.CheckOnClick = true;
            this.formaEPagesësToolStripMenuItem.Name = "formaEPagesësToolStripMenuItem";
            this.formaEPagesësToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.formaEPagesësToolStripMenuItem.Text = "Forma e pagesës";
            this.formaEPagesësToolStripMenuItem.Click += new System.EventHandler(this.formaEPagesësToolStripMenuItem_Click);
            // 
            // shfaqKoToolStripMenuItem
            // 
            this.shfaqKoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nrFatureToolStripMenuItem,
            this.tavolinaToolStripMenuItem1,
            this.kamarieriToolStripMenuItem1,
            this.vleraEXhirosToolStripMenuItem,
            this.formaEPagesësToolStripMenuItem1,
            this.vleraMeKomisionToolStripMenuItem});
            this.shfaqKoToolStripMenuItem.Name = "shfaqKoToolStripMenuItem";
            this.shfaqKoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shfaqKoToolStripMenuItem.Text = "Shfaq kolonat";
            // 
            // nrFatureToolStripMenuItem
            // 
            this.nrFatureToolStripMenuItem.Checked = true;
            this.nrFatureToolStripMenuItem.CheckOnClick = true;
            this.nrFatureToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nrFatureToolStripMenuItem.Name = "nrFatureToolStripMenuItem";
            this.nrFatureToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nrFatureToolStripMenuItem.Text = "Nr fature";
            this.nrFatureToolStripMenuItem.Click += new System.EventHandler(this.nrFatureToolStripMenuItem_Click);
            // 
            // tavolinaToolStripMenuItem1
            // 
            this.tavolinaToolStripMenuItem1.Checked = true;
            this.tavolinaToolStripMenuItem1.CheckOnClick = true;
            this.tavolinaToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tavolinaToolStripMenuItem1.Name = "tavolinaToolStripMenuItem1";
            this.tavolinaToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.tavolinaToolStripMenuItem1.Text = "Tavolina";
            this.tavolinaToolStripMenuItem1.Click += new System.EventHandler(this.tavolinaToolStripMenuItem1_Click);
            // 
            // kamarieriToolStripMenuItem1
            // 
            this.kamarieriToolStripMenuItem1.Checked = true;
            this.kamarieriToolStripMenuItem1.CheckOnClick = true;
            this.kamarieriToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kamarieriToolStripMenuItem1.Name = "kamarieriToolStripMenuItem1";
            this.kamarieriToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.kamarieriToolStripMenuItem1.Text = "Kamarieri";
            this.kamarieriToolStripMenuItem1.Click += new System.EventHandler(this.kamarieriToolStripMenuItem1_Click);
            // 
            // vleraEXhirosToolStripMenuItem
            // 
            this.vleraEXhirosToolStripMenuItem.Checked = true;
            this.vleraEXhirosToolStripMenuItem.CheckOnClick = true;
            this.vleraEXhirosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vleraEXhirosToolStripMenuItem.Name = "vleraEXhirosToolStripMenuItem";
            this.vleraEXhirosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.vleraEXhirosToolStripMenuItem.Text = "Vlera e xhiros";
            this.vleraEXhirosToolStripMenuItem.Click += new System.EventHandler(this.vleraEXhirosToolStripMenuItem_Click);
            // 
            // formaEPagesësToolStripMenuItem1
            // 
            this.formaEPagesësToolStripMenuItem1.Checked = true;
            this.formaEPagesësToolStripMenuItem1.CheckOnClick = true;
            this.formaEPagesësToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.formaEPagesësToolStripMenuItem1.Name = "formaEPagesësToolStripMenuItem1";
            this.formaEPagesësToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.formaEPagesësToolStripMenuItem1.Text = "Forma e pagesës";
            this.formaEPagesësToolStripMenuItem1.Click += new System.EventHandler(this.formaEPagesësToolStripMenuItem1_Click);
            // 
            // vleraMeKomisionToolStripMenuItem
            // 
            this.vleraMeKomisionToolStripMenuItem.Checked = true;
            this.vleraMeKomisionToolStripMenuItem.CheckOnClick = true;
            this.vleraMeKomisionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vleraMeKomisionToolStripMenuItem.Name = "vleraMeKomisionToolStripMenuItem";
            this.vleraMeKomisionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.vleraMeKomisionToolStripMenuItem.Text = "Vlera me komision";
            this.vleraMeKomisionToolStripMenuItem.Click += new System.EventHandler(this.vleraMeKomisionToolStripMenuItem_Click);
            // 
            // gridDatat
            // 
            this.gridDatat.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridDatat.AutomaticSort = false;
            this.gridDatat.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText;
            this.gridDatat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridDatat.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridDatat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDatat.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridDatat.GroupByBoxVisible = false;
            this.gridDatat.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridDatat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridDatat.LayoutData = resources.GetString("gridDatat.LayoutData");
            this.gridDatat.Location = new System.Drawing.Point(12, 52);
            this.gridDatat.Name = "gridDatat";
            this.gridDatat.Size = new System.Drawing.Size(238, 496);
            this.gridDatat.TabIndex = 0;
            this.gridDatat.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridDatat.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridDatat.CurrentCellChanged += new System.EventHandler(this.gridDatat_CurrentCellChanged);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.cboTavolina);
            this.uiGroupBox1.Controls.Add(this.cboKamarieri);
            this.uiGroupBox1.Controls.Add(this.btnKerko);
            this.uiGroupBox1.Controls.Add(this.chkKamarieri);
            this.uiGroupBox1.Controls.Add(this.chkTavolina);
            this.uiGroupBox1.Controls.Add(this.dtpMbarimi);
            this.uiGroupBox1.Controls.Add(this.dtpFillimi);
            this.uiGroupBox1.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox1.Image")));
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 40);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(200, 290);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Kërko sipas";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Midis datave";
            // 
            // cboTavolina
            // 
            this.cboTavolina.DisplayMember = "EMRI";
            this.cboTavolina.FormattingEnabled = true;
            this.cboTavolina.Location = new System.Drawing.Point(13, 209);
            this.cboTavolina.Name = "cboTavolina";
            this.cboTavolina.Size = new System.Drawing.Size(180, 21);
            this.cboTavolina.TabIndex = 7;
            this.cboTavolina.ValueMember = "ID_TAVOLINA";
            // 
            // cboKamarieri
            // 
            this.cboKamarieri.DisplayMember = "PERDORUESI";
            this.cboKamarieri.FormattingEnabled = true;
            this.cboKamarieri.Location = new System.Drawing.Point(13, 148);
            this.cboKamarieri.Name = "cboKamarieri";
            this.cboKamarieri.Size = new System.Drawing.Size(180, 21);
            this.cboKamarieri.TabIndex = 5;
            this.cboKamarieri.ValueMember = "ID_PERSONELI";
            // 
            // btnKerko
            // 
            this.btnKerko.ForeColor = System.Drawing.Color.Navy;
            this.btnKerko.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerko.Location = new System.Drawing.Point(71, 248);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(66, 28);
            this.btnKerko.TabIndex = 8;
            this.btnKerko.Text = "Kërko";
            this.btnKerko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // chkKamarieri
            // 
            this.chkKamarieri.AutoSize = true;
            this.chkKamarieri.Location = new System.Drawing.Point(13, 125);
            this.chkKamarieri.Name = "chkKamarieri";
            this.chkKamarieri.Size = new System.Drawing.Size(85, 17);
            this.chkKamarieri.TabIndex = 4;
            this.chkKamarieri.Text = "Kamarierëve";
            this.chkKamarieri.UseVisualStyleBackColor = true;
            this.chkKamarieri.CheckedChanged += new System.EventHandler(this.cbKamarieri_CheckedChanged);
            // 
            // chkTavolina
            // 
            this.chkTavolina.AutoSize = true;
            this.chkTavolina.Location = new System.Drawing.Point(13, 186);
            this.chkTavolina.Name = "chkTavolina";
            this.chkTavolina.Size = new System.Drawing.Size(79, 17);
            this.chkTavolina.TabIndex = 6;
            this.chkTavolina.Text = "Tavolinave";
            this.chkTavolina.UseVisualStyleBackColor = true;
            this.chkTavolina.CheckedChanged += new System.EventHandler(this.cbTavolina_CheckedChanged);
            // 
            // dtpMbarimi
            // 
            this.dtpMbarimi.CustomFormat = "dd.MM.yyyy";
            this.dtpMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMbarimi.Location = new System.Drawing.Point(13, 87);
            this.dtpMbarimi.Name = "dtpMbarimi";
            this.dtpMbarimi.ShowUpDown = true;
            this.dtpMbarimi.Size = new System.Drawing.Size(180, 20);
            this.dtpMbarimi.TabIndex = 3;
            // 
            // dtpFillimi
            // 
            this.dtpFillimi.CustomFormat = "dd.MM.yyyy";
            this.dtpFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFillimi.Location = new System.Drawing.Point(13, 52);
            this.dtpFillimi.Name = "dtpFillimi";
            this.dtpFillimi.ShowUpDown = true;
            this.dtpFillimi.Size = new System.Drawing.Size(180, 20);
            this.dtpFillimi.TabIndex = 2;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmXhiroSipasFaturave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 620);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXhiroSipasFaturave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Xhiro sipas faturave";
            this.Load += new System.EventHandler(this.frmXhiroSipasFaturave_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmXhiroSipasFaturave_CausesValidationChanged);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbXhiro)).EndInit();
            this.gbXhiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetaje)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.DateTimePicker dtpMbarimi;
        private System.Windows.Forms.DateTimePicker dtpFillimi;
        private System.Windows.Forms.Button btnKerko;
        private Janus.Windows.EditControls.UIGroupBox gbXhiro;
        private Janus.Windows.GridEX.GridEX gridDetaje;
        private Janus.Windows.GridEX.GridEX gridDatat;
        private System.Windows.Forms.CheckBox chkKamarieri;
        private System.Windows.Forms.CheckBox chkTavolina;
        private System.Windows.Forms.ComboBox cboTavolina;
        private System.Windows.Forms.ComboBox cboKamarieri;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem grupoSipasKolonësToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tavolinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kamarieriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaEPagesësToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shfaqKoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nrFatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tavolinaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kamarieriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vleraEXhirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaEPagesësToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vleraMeKomisionToolStripMenuItem;
        private System.Windows.Forms.Label lblDataZgjedhur;
    }
}