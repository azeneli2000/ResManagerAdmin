namespace ResManagerAdmin.Forms
{
    partial class frmKontrolloSkorte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKontrolloSkorte));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.btnKerko = new System.Windows.Forms.Button();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.chkNenSkorte = new System.Windows.Forms.CheckBox();
            this.cboKategoria = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtEmriArtikulli = new System.Windows.Forms.TextBox();
            this.chkKategoria = new System.Windows.Forms.CheckBox();
            this.chkArtikulli = new System.Windows.Forms.CheckBox();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
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
            this.expandablePanel1.Controls.Add(this.btnKerko);
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
            this.expandablePanel1.TabIndex = 7;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Kontrolli i skortës";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.grida);
            this.uiGroupBox2.Location = new System.Drawing.Point(269, 40);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(688, 529);
            this.uiGroupBox2.TabIndex = 6;
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
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
            this.grida.Location = new System.Drawing.Point(32, 22);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(623, 494);
            this.grida.TabIndex = 0;
            // 
            // btnKerko
            // 
            this.btnKerko.ForeColor = System.Drawing.Color.Navy;
            this.btnKerko.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerko.Location = new System.Drawing.Point(84, 226);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(66, 28);
            this.btnKerko.TabIndex = 5;
            this.btnKerko.Text = "Kërko";
            this.btnKerko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.chkNenSkorte);
            this.uiGroupBox1.Controls.Add(this.cboKategoria);
            this.uiGroupBox1.Controls.Add(this.txtEmriArtikulli);
            this.uiGroupBox1.Controls.Add(this.chkKategoria);
            this.uiGroupBox1.Controls.Add(this.chkArtikulli);
            this.uiGroupBox1.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox1.Image")));
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 40);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(231, 166);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "Kërkoni sipas";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // chkNenSkorte
            // 
            this.chkNenSkorte.AutoSize = true;
            this.chkNenSkorte.Location = new System.Drawing.Point(13, 131);
            this.chkNenSkorte.Name = "chkNenSkorte";
            this.chkNenSkorte.Size = new System.Drawing.Size(111, 17);
            this.chkNenSkorte.TabIndex = 11;
            this.chkNenSkorte.Text = "Artikujt nën skortë";
            this.chkNenSkorte.UseVisualStyleBackColor = true;
            this.chkNenSkorte.CheckedChanged += new System.EventHandler(this.chkNenSkorte_CheckedChanged);
            // 
            // cboKategoria
            // 
            this.cboKategoria.BackColor = System.Drawing.SystemColors.Window;
            this.cboKategoria.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboKategoria.DisplayMember = "PERSHKRIMI";
            this.cboKategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboKategoria.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboKategoria.LayoutData = resources.GetString("cboKategoria.LayoutData");
            this.cboKategoria.Location = new System.Drawing.Point(13, 98);
            this.cboKategoria.Name = "cboKategoria";
            this.cboKategoria.Size = new System.Drawing.Size(180, 20);
            this.cboKategoria.TabIndex = 10;
            this.cboKategoria.Value = null;
            this.cboKategoria.ValueMember = "ID_KATEGORIAARTIKULLI";
            // 
            // txtEmriArtikulli
            // 
            this.txtEmriArtikulli.Location = new System.Drawing.Point(13, 45);
            this.txtEmriArtikulli.Name = "txtEmriArtikulli";
            this.txtEmriArtikulli.Size = new System.Drawing.Size(180, 20);
            this.txtEmriArtikulli.TabIndex = 3;
            // 
            // chkKategoria
            // 
            this.chkKategoria.AutoSize = true;
            this.chkKategoria.Location = new System.Drawing.Point(13, 75);
            this.chkKategoria.Name = "chkKategoria";
            this.chkKategoria.Size = new System.Drawing.Size(76, 17);
            this.chkKategoria.TabIndex = 1;
            this.chkKategoria.Text = "Kategorisë";
            this.chkKategoria.UseVisualStyleBackColor = true;
            this.chkKategoria.CheckedChanged += new System.EventHandler(this.chkKategoria_CheckedChanged);
            // 
            // chkArtikulli
            // 
            this.chkArtikulli.AutoSize = true;
            this.chkArtikulli.Location = new System.Drawing.Point(13, 22);
            this.chkArtikulli.Name = "chkArtikulli";
            this.chkArtikulli.Size = new System.Drawing.Size(99, 17);
            this.chkArtikulli.TabIndex = 0;
            this.chkArtikulli.Text = "Emrit të artikullit";
            this.chkArtikulli.UseVisualStyleBackColor = true;
            this.chkArtikulli.CheckedChanged += new System.EventHandler(this.chkArtikulli_CheckedChanged);
            // 
            // frmKontrolloSkorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKontrolloSkorte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inventari";
            this.Load += new System.EventHandler(this.frmKontrolloSkorte_Load);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.CheckBox chkNenSkorte;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboKategoria;
        private System.Windows.Forms.TextBox txtEmriArtikulli;
        private System.Windows.Forms.CheckBox chkKategoria;
        private System.Windows.Forms.CheckBox chkArtikulli;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Button btnKerko;
        private Janus.Windows.GridEX.GridEX grida;
    }
}