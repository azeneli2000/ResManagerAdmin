namespace ResManagerAdmin.Forms
{
    partial class frmGrupCmimet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupCmimet));
            this.paneli = new DevComponents.DotNetBar.ExpandablePanel();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.uiTab = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.txtKodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnFshi = new System.Windows.Forms.Button();
            this.btnModifiko = new System.Windows.Forms.Button();
            this.btnShto = new System.Windows.Forms.Button();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab)).BeginInit();
            this.uiTab.SuspendLayout();
            this.uiTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.Controls.Add(this.grida);
            this.paneli.Controls.Add(this.uiTab);
            this.paneli.Controls.Add(this.uiGroupBox1);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.ExpandButtonVisible = false;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(1020, 614);
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
            this.paneli.TitleText = "     Grupet e cmimeve";
            // 
            // grida
            // 
            this.grida.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(187, 126);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(629, 407);
            this.grida.TabIndex = 1;
            this.grida.DoubleClick += new System.EventHandler(this.grida_DoubleClick);
            // 
            // uiTab
            // 
            this.uiTab.Controls.Add(this.uiTabPage);
            this.uiTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTab.Location = new System.Drawing.Point(187, 141);
            this.uiTab.Name = "uiTab";
            this.uiTab.SelectedIndex = 0;
            this.uiTab.Size = new System.Drawing.Size(629, 385);
            this.uiTab.TabIndex = 2;
            this.uiTab.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage});
            // 
            // uiTabPage
            // 
            this.uiTabPage.Controls.Add(this.groupBox1);
            this.uiTabPage.Location = new System.Drawing.Point(1, 23);
            this.uiTabPage.Name = "uiTabPage";
            this.uiTabPage.Size = new System.Drawing.Size(625, 359);
            this.uiTabPage.TabIndex = 0;
            this.uiTabPage.Text = "Shtim";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAnullo);
            this.groupBox1.Controls.Add(this.btnRuaj);
            this.groupBox1.Controls.Add(this.txtPershkrimi);
            this.groupBox1.Controls.Add(this.txtKodi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 291);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Te dhena per grupin e cmimit : ";
            // 
            // btnAnullo
            // 
            this.btnAnullo.Image = ((System.Drawing.Image)(resources.GetObject("btnAnullo.Image")));
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(317, 219);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(90, 32);
            this.btnAnullo.TabIndex = 5;
            this.btnAnullo.Text = "   Anullo";
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.Image = ((System.Drawing.Image)(resources.GetObject("btnRuaj.Image")));
            this.btnRuaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuaj.Location = new System.Drawing.Point(174, 219);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(90, 32);
            this.btnRuaj.TabIndex = 4;
            this.btnRuaj.Text = "   Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Location = new System.Drawing.Point(152, 80);
            this.txtPershkrimi.Multiline = true;
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(278, 101);
            this.txtPershkrimi.TabIndex = 3;
            // 
            // txtKodi
            // 
            this.txtKodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodi.Location = new System.Drawing.Point(152, 41);
            this.txtKodi.Name = "txtKodi";
            this.txtKodi.Size = new System.Drawing.Size(278, 21);
            this.txtKodi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pershkrimi";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kodi";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btnFshi);
            this.uiGroupBox1.Controls.Add(this.btnModifiko);
            this.uiGroupBox1.Controls.Add(this.btnShto);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox1.Location = new System.Drawing.Point(169, 56);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(668, 498);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = "Konfigurimi i grupeve te cmimeve : ";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnFshi
            // 
            this.btnFshi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFshi.Image = ((System.Drawing.Image)(resources.GetObject("btnFshi.Image")));
            this.btnFshi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshi.Location = new System.Drawing.Point(557, 34);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(90, 30);
            this.btnFshi.TabIndex = 2;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.UseVisualStyleBackColor = true;
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // btnModifiko
            // 
            this.btnModifiko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifiko.Image = ((System.Drawing.Image)(resources.GetObject("btnModifiko.Image")));
            this.btnModifiko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifiko.Location = new System.Drawing.Point(307, 34);
            this.btnModifiko.Name = "btnModifiko";
            this.btnModifiko.Size = new System.Drawing.Size(90, 30);
            this.btnModifiko.TabIndex = 1;
            this.btnModifiko.Text = "     Modifiko";
            this.btnModifiko.UseVisualStyleBackColor = true;
            this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
            // 
            // btnShto
            // 
            this.btnShto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.Image = ((System.Drawing.Image)(resources.GetObject("btnShto.Image")));
            this.btnShto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShto.Location = new System.Drawing.Point(19, 34);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(90, 30);
            this.btnShto.TabIndex = 0;
            this.btnShto.Text = "   Shto";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // frmGrupCmimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrupCmimet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Grupet e cmimeve";
            this.Load += new System.EventHandler(this.frmGrupCmimet_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmGrupCmimet_CausesValidationChanged);
            this.paneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab)).EndInit();
            this.uiTab.ResumeLayout(false);
            this.uiTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel paneli;
        private Janus.Windows.GridEX.GridEX grida;
        private Janus.Windows.UI.Tab.UITab uiTab;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.TextBox txtKodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.Button btnRuaj;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Button btnModifiko;
        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.Button btnFshi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}