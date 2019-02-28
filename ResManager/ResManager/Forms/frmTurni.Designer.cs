namespace ResManager.Forms
{
    partial class frmTurni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurni));
            this.panelBack = new DevComponents.DotNetBar.PanelEx();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnKerko = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtMbarimi = new System.Windows.Forms.DateTimePicker();
            this.dtFillimi = new System.Windows.Forms.DateTimePicker();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.tabTurni = new Janus.Windows.UI.Tab.UITab();
            this.tabiMbyll = new Janus.Windows.UI.Tab.UITabPage();
            this.btnAnulloMbyllje = new DevComponents.DotNetBar.ButtonX();
            this.btnMbyllTurnin = new DevComponents.DotNetBar.ButtonX();
            this.txtFjalekalimiMbyll = new System.Windows.Forms.TextBox();
            this.lblMbyll = new System.Windows.Forms.Label();
            this.tabiHap = new Janus.Windows.UI.Tab.UITabPage();
            this.btnAnulloHapje = new DevComponents.DotNetBar.ButtonX();
            this.btnHapTurnin = new DevComponents.DotNetBar.ButtonX();
            this.lblHap = new System.Windows.Forms.Label();
            this.txtFjalekalimiHap = new System.Windows.Forms.TextBox();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTurni)).BeginInit();
            this.tabTurni.SuspendLayout();
            this.tabiMbyll.SuspendLayout();
            this.tabiHap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelBack.Controls.Add(this.uiGroupBox1);
            this.panelBack.Controls.Add(this.grida);
            this.panelBack.Controls.Add(this.tabTurni);
            this.panelBack.Location = new System.Drawing.Point(-1, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(404, 495);
            this.panelBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBack.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBack.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBack.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBack.Style.GradientAngle = 90;
            this.panelBack.TabIndex = 0;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btnKerko);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.dtMbarimi);
            this.uiGroupBox1.Controls.Add(this.dtFillimi);
            this.uiGroupBox1.Location = new System.Drawing.Point(11, 3);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(379, 94);
            this.uiGroupBox1.TabIndex = 6;
            // 
            // btnKerko
            // 
            this.btnKerko.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnKerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerko.Location = new System.Drawing.Point(283, 31);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(80, 30);
            this.btnKerko.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnKerko.TabIndex = 6;
            this.btnKerko.Text = "Kerko";
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date mbarimi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date fillimi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtMbarimi
            // 
            this.dtMbarimi.CustomFormat = "dd.MM.yyyy    hh:mm";
            this.dtMbarimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMbarimi.Location = new System.Drawing.Point(106, 49);
            this.dtMbarimi.Name = "dtMbarimi";
            this.dtMbarimi.ShowUpDown = true;
            this.dtMbarimi.Size = new System.Drawing.Size(149, 22);
            this.dtMbarimi.TabIndex = 3;
            // 
            // dtFillimi
            // 
            this.dtFillimi.CustomFormat = "dd.MM.yyyy    hh:mm";
            this.dtFillimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFillimi.Location = new System.Drawing.Point(106, 15);
            this.dtFillimi.Name = "dtFillimi";
            this.dtFillimi.ShowUpDown = true;
            this.dtFillimi.Size = new System.Drawing.Size(149, 22);
            this.dtFillimi.TabIndex = 2;
            // 
            // grida
            // 
            this.grida.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(13, 121);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(377, 329);
            this.grida.TabIndex = 1;
            // 
            // tabTurni
            // 
            this.tabTurni.Controls.Add(this.tabiMbyll);
            this.tabTurni.Controls.Add(this.tabiHap);
            this.tabTurni.Location = new System.Drawing.Point(29, 143);
            this.tabTurni.Name = "tabTurni";
            this.tabTurni.SelectedIndex = 0;
            this.tabTurni.Size = new System.Drawing.Size(348, 215);
            this.tabTurni.TabIndex = 0;
            this.tabTurni.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.tabiMbyll,
            this.tabiHap});
            // 
            // tabiMbyll
            // 
            this.tabiMbyll.Controls.Add(this.btnAnulloMbyllje);
            this.tabiMbyll.Controls.Add(this.btnMbyllTurnin);
            this.tabiMbyll.Controls.Add(this.txtFjalekalimiMbyll);
            this.tabiMbyll.Controls.Add(this.lblMbyll);
            this.tabiMbyll.Location = new System.Drawing.Point(1, 21);
            this.tabiMbyll.Name = "tabiMbyll";
            this.tabiMbyll.Size = new System.Drawing.Size(344, 253);
            this.tabiMbyll.TabIndex = 0;
            this.tabiMbyll.Text = "Mbyll turnin";
            // 
            // btnAnulloMbyllje
            // 
            this.btnAnulloMbyllje.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnulloMbyllje.Location = new System.Drawing.Point(197, 158);
            this.btnAnulloMbyllje.Name = "btnAnulloMbyllje";
            this.btnAnulloMbyllje.Size = new System.Drawing.Size(90, 35);
            this.btnAnulloMbyllje.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnulloMbyllje.TabIndex = 3;
            this.btnAnulloMbyllje.Text = "Anullo";
            // 
            // btnMbyllTurnin
            // 
            this.btnMbyllTurnin.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnMbyllTurnin.Location = new System.Drawing.Point(50, 158);
            this.btnMbyllTurnin.Name = "btnMbyllTurnin";
            this.btnMbyllTurnin.Size = new System.Drawing.Size(90, 35);
            this.btnMbyllTurnin.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnMbyllTurnin.TabIndex = 2;
            this.btnMbyllTurnin.Text = "Mbyll";
            this.btnMbyllTurnin.Click += new System.EventHandler(this.btnMbyllTurnin_Click);
            // 
            // txtFjalekalimiMbyll
            // 
            this.txtFjalekalimiMbyll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFjalekalimiMbyll.Location = new System.Drawing.Point(74, 78);
            this.txtFjalekalimiMbyll.Name = "txtFjalekalimiMbyll";
            this.txtFjalekalimiMbyll.PasswordChar = '*';
            this.txtFjalekalimiMbyll.Size = new System.Drawing.Size(170, 22);
            this.txtFjalekalimiMbyll.TabIndex = 1;
            // 
            // lblMbyll
            // 
            this.lblMbyll.BackColor = System.Drawing.Color.Transparent;
            this.lblMbyll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMbyll.Location = new System.Drawing.Point(74, 52);
            this.lblMbyll.Name = "lblMbyll";
            this.lblMbyll.Size = new System.Drawing.Size(170, 23);
            this.lblMbyll.TabIndex = 0;
            this.lblMbyll.Text = "Fjalekalimi :";
            this.lblMbyll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabiHap
            // 
            this.tabiHap.Controls.Add(this.btnAnulloHapje);
            this.tabiHap.Controls.Add(this.btnHapTurnin);
            this.tabiHap.Controls.Add(this.lblHap);
            this.tabiHap.Controls.Add(this.txtFjalekalimiHap);
            this.tabiHap.Location = new System.Drawing.Point(1, 21);
            this.tabiHap.Name = "tabiHap";
            this.tabiHap.Size = new System.Drawing.Size(344, 210);
            this.tabiHap.TabIndex = 1;
            this.tabiHap.Text = "Hap turnin";
            // 
            // btnAnulloHapje
            // 
            this.btnAnulloHapje.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnulloHapje.Location = new System.Drawing.Point(186, 173);
            this.btnAnulloHapje.Name = "btnAnulloHapje";
            this.btnAnulloHapje.Size = new System.Drawing.Size(90, 35);
            this.btnAnulloHapje.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnulloHapje.TabIndex = 3;
            this.btnAnulloHapje.Text = "Anullo";
            // 
            // btnHapTurnin
            // 
            this.btnHapTurnin.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnHapTurnin.Location = new System.Drawing.Point(55, 173);
            this.btnHapTurnin.Name = "btnHapTurnin";
            this.btnHapTurnin.Size = new System.Drawing.Size(90, 35);
            this.btnHapTurnin.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnHapTurnin.TabIndex = 2;
            this.btnHapTurnin.Text = "Hap turnin";
            this.btnHapTurnin.Click += new System.EventHandler(this.btnHapTurnin_Click);
            // 
            // lblHap
            // 
            this.lblHap.BackColor = System.Drawing.Color.Transparent;
            this.lblHap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHap.Location = new System.Drawing.Point(88, 57);
            this.lblHap.Name = "lblHap";
            this.lblHap.Size = new System.Drawing.Size(163, 23);
            this.lblHap.TabIndex = 1;
            this.lblHap.Text = "Fjalekalimi :";
            this.lblHap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFjalekalimiHap
            // 
            this.txtFjalekalimiHap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFjalekalimiHap.Location = new System.Drawing.Point(87, 83);
            this.txtFjalekalimiHap.Name = "txtFjalekalimiHap";
            this.txtFjalekalimiHap.Size = new System.Drawing.Size(164, 22);
            this.txtFjalekalimiHap.TabIndex = 0;
            this.txtFjalekalimiHap.TextChanged += new System.EventHandler(this.txtFjalekalimiHap_TextChanged);
            // 
            // frmTurni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 495);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTurni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turni";
            this.Load += new System.EventHandler(this.frmTurni_Load);
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabTurni)).EndInit();
            this.tabTurni.ResumeLayout(false);
            this.tabiMbyll.ResumeLayout(false);
            this.tabiMbyll.PerformLayout();
            this.tabiHap.ResumeLayout(false);
            this.tabiHap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelBack;
        private Janus.Windows.UI.Tab.UITab tabTurni;
        private Janus.Windows.UI.Tab.UITabPage tabiMbyll;
        private Janus.Windows.UI.Tab.UITabPage tabiHap;
        private System.Windows.Forms.TextBox txtFjalekalimiMbyll;
        private System.Windows.Forms.Label lblMbyll;
        private DevComponents.DotNetBar.ButtonX btnAnulloMbyllje;
        private DevComponents.DotNetBar.ButtonX btnMbyllTurnin;
        private System.Windows.Forms.Label lblHap;
        private System.Windows.Forms.TextBox txtFjalekalimiHap;
        private DevComponents.DotNetBar.ButtonX btnAnulloHapje;
        private DevComponents.DotNetBar.ButtonX btnHapTurnin;
        private Janus.Windows.GridEX.GridEX grida;
        private System.Windows.Forms.DateTimePicker dtMbarimi;
        private System.Windows.Forms.DateTimePicker dtFillimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private DevComponents.DotNetBar.ButtonX btnKerko;
    }
}