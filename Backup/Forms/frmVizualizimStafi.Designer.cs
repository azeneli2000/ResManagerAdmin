namespace ResManagerAdmin.Forms
{
    partial class frmVizualizimStafi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVizualizimStafi));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.panelButona = new System.Windows.Forms.Panel();
            this.btnFshi = new System.Windows.Forms.Button();
            this.btnModifiko = new System.Windows.Forms.Button();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.chkLogimi = new System.Windows.Forms.CheckBox();
            this.cboRoli = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnKerko = new System.Windows.Forms.Button();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.chkRoli = new System.Windows.Forms.CheckBox();
            this.chkEmri = new System.Windows.Forms.CheckBox();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            this.panelButona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
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
            this.expandablePanel1.Size = new System.Drawing.Size(1020, 642);
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
            this.expandablePanel1.TitleText = "Vizualizimi i stafit";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.grida);
            this.uiGroupBox2.Controls.Add(this.panelButona);
            this.uiGroupBox2.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox2.Image")));
            this.uiGroupBox2.ImageSize = new System.Drawing.Size(24, 24);
            this.uiGroupBox2.Location = new System.Drawing.Point(240, 40);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(768, 590);
            this.uiGroupBox2.TabIndex = 4;
            this.uiGroupBox2.Text = "Personeli";
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // grida
            // 
            this.grida.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(12, 76);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(740, 492);
            this.grida.TabIndex = 8;
            // 
            // panelButona
            // 
            this.panelButona.Controls.Add(this.btnFshi);
            this.panelButona.Controls.Add(this.btnModifiko);
            this.panelButona.Location = new System.Drawing.Point(10, 24);
            this.panelButona.Name = "panelButona";
            this.panelButona.Size = new System.Drawing.Size(742, 46);
            this.panelButona.TabIndex = 7;
            // 
            // btnFshi
            // 
            this.btnFshi.ForeColor = System.Drawing.Color.Navy;
            this.btnFshi.Image = global::ResManagerAdmin.Properties.Resources.cancelbuild;
            this.btnFshi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshi.Location = new System.Drawing.Point(664, 3);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(75, 37);
            this.btnFshi.TabIndex = 6;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.UseVisualStyleBackColor = true;
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // btnModifiko
            // 
            this.btnModifiko.ForeColor = System.Drawing.Color.Navy;
            this.btnModifiko.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.btnModifiko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifiko.Location = new System.Drawing.Point(3, 3);
            this.btnModifiko.Name = "btnModifiko";
            this.btnModifiko.Size = new System.Drawing.Size(75, 37);
            this.btnModifiko.TabIndex = 5;
            this.btnModifiko.Text = "    Modifiko";
            this.btnModifiko.UseVisualStyleBackColor = true;
            this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.chkLogimi);
            this.uiGroupBox1.Controls.Add(this.cboRoli);
            this.uiGroupBox1.Controls.Add(this.btnKerko);
            this.uiGroupBox1.Controls.Add(this.txtEmri);
            this.uiGroupBox1.Controls.Add(this.chkRoli);
            this.uiGroupBox1.Controls.Add(this.chkEmri);
            this.uiGroupBox1.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox1.Image")));
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 40);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(219, 228);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "Kërkoni sipas";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // chkLogimi
            // 
            this.chkLogimi.AutoSize = true;
            this.chkLogimi.Location = new System.Drawing.Point(14, 159);
            this.chkLogimi.Name = "chkLogimi";
            this.chkLogimi.Size = new System.Drawing.Size(116, 17);
            this.chkLogimi.TabIndex = 12;
            this.chkLogimi.Text = "Aktualisht të loguar";
            this.chkLogimi.UseVisualStyleBackColor = true;
            // 
            // cboRoli
            // 
            this.cboRoli.BackColor = System.Drawing.SystemColors.Window;
            this.cboRoli.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboRoli.DisplayMember = "ROLI";
            this.cboRoli.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboRoli.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboRoli.LayoutData = resources.GetString("cboRoli.LayoutData");
            this.cboRoli.Location = new System.Drawing.Point(14, 120);
            this.cboRoli.Name = "cboRoli";
            this.cboRoli.Size = new System.Drawing.Size(180, 20);
            this.cboRoli.TabIndex = 11;
            this.cboRoli.Value = null;
            this.cboRoli.ValueMember = "ID_ROLI";
            this.cboRoli.TextChanged += new System.EventHandler(this.cboRoli_TextChanged);
            // 
            // btnKerko
            // 
            this.btnKerko.ForeColor = System.Drawing.Color.Navy;
            this.btnKerko.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerko.Location = new System.Drawing.Point(68, 187);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(66, 28);
            this.btnKerko.TabIndex = 3;
            this.btnKerko.Text = "Kërko";
            this.btnKerko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(14, 58);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(180, 20);
            this.txtEmri.TabIndex = 7;
            // 
            // chkRoli
            // 
            this.chkRoli.AutoSize = true;
            this.chkRoli.Location = new System.Drawing.Point(14, 97);
            this.chkRoli.Name = "chkRoli";
            this.chkRoli.Size = new System.Drawing.Size(47, 17);
            this.chkRoli.TabIndex = 2;
            this.chkRoli.Text = "Rolit";
            this.chkRoli.UseVisualStyleBackColor = true;
            this.chkRoli.CheckedChanged += new System.EventHandler(this.chkRoli_CheckedChanged);
            // 
            // chkEmri
            // 
            this.chkEmri.AutoSize = true;
            this.chkEmri.Location = new System.Drawing.Point(14, 35);
            this.chkEmri.Name = "chkEmri";
            this.chkEmri.Size = new System.Drawing.Size(49, 17);
            this.chkEmri.TabIndex = 1;
            this.chkEmri.Text = "Emrit";
            this.chkEmri.UseVisualStyleBackColor = true;
            this.chkEmri.CheckedChanged += new System.EventHandler(this.chkEmri_CheckedChanged);
            // 
            // frmVizualizimStafi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 642);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVizualizimStafi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vizualizimi i stafit";
            this.Load += new System.EventHandler(this.frmVizualizimStafi_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmVizualizimStafi_CausesValidationChanged);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            this.panelButona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.CheckBox chkRoli;
        private System.Windows.Forms.CheckBox chkEmri;
        private System.Windows.Forms.TextBox txtEmri;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboRoli;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.CheckBox chkLogimi;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Panel panelButona;
        private System.Windows.Forms.Button btnModifiko;
        private System.Windows.Forms.Button btnFshi;
        private Janus.Windows.GridEX.GridEX grida;
    }
}