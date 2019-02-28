namespace ResManagerAdmin.Forms
{
    partial class frmXhiroSipasArtikujve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXhiroSipasArtikujve));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.gbXhiro = new Janus.Windows.EditControls.UIGroupBox();
            this.gridXhiro = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.cmbRecetat = new System.Windows.Forms.ComboBox();
            this.cmbKategoriaRecetat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbRecetat = new System.Windows.Forms.RadioButton();
            this.dtpMbarimi = new System.Windows.Forms.DateTimePicker();
            this.dtpFillimi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.uiGroupBox4 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnKerko = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbXhiro)).BeginInit();
            this.gbXhiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridXhiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).BeginInit();
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
            this.expandablePanel1.Controls.Add(this.btnKerko);
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
            this.expandablePanel1.TitleText = "Xhiro sipas artikujve";
            // 
            // gbXhiro
            // 
            this.gbXhiro.Controls.Add(this.gridXhiro);
            this.gbXhiro.Image = ((System.Drawing.Image)(resources.GetObject("gbXhiro.Image")));
            this.gbXhiro.Location = new System.Drawing.Point(229, 40);
            this.gbXhiro.Name = "gbXhiro";
            this.gbXhiro.Size = new System.Drawing.Size(649, 562);
            this.gbXhiro.TabIndex = 4;
            this.gbXhiro.Text = "Xhiro efektive sipas artikujve per intervalin e zgjedhur të datave";
            this.gbXhiro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // gridXhiro
            // 
            this.gridXhiro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gridXhiro.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridXhiro.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridXhiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridXhiro.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridXhiro.GroupByBoxVisible = false;
            this.gridXhiro.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridXhiro.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridXhiro.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.gridXhiro.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridXhiro.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridXhiro.LayoutData = resources.GetString("gridXhiro.LayoutData");
            this.gridXhiro.Location = new System.Drawing.Point(13, 35);
            this.gridXhiro.Name = "gridXhiro";
            this.gridXhiro.Size = new System.Drawing.Size(605, 510);
            this.gridXhiro.TabIndex = 1;
            this.gridXhiro.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cmbRecetat);
            this.uiGroupBox1.Controls.Add(this.cmbKategoriaRecetat);
            this.uiGroupBox1.Controls.Add(this.label6);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.rbRecetat);
            this.uiGroupBox1.Controls.Add(this.dtpMbarimi);
            this.uiGroupBox1.Controls.Add(this.dtpFillimi);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.uiGroupBox4);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox1.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox1.Image")));
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 40);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(210, 255);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Shfaq fitimin sipas";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // cmbRecetat
            // 
            this.cmbRecetat.DisplayMember = "EMRI";
            this.cmbRecetat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecetat.FormattingEnabled = true;
            this.cmbRecetat.Location = new System.Drawing.Point(13, 214);
            this.cmbRecetat.Name = "cmbRecetat";
            this.cmbRecetat.Size = new System.Drawing.Size(180, 21);
            this.cmbRecetat.TabIndex = 28;
            this.cmbRecetat.ValueMember = "ID_RECETA";
            // 
            // cmbKategoriaRecetat
            // 
            this.cmbKategoriaRecetat.DisplayMember = "PERSHKRIMI";
            this.cmbKategoriaRecetat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoriaRecetat.FormattingEnabled = true;
            this.cmbKategoriaRecetat.Location = new System.Drawing.Point(13, 164);
            this.cmbKategoriaRecetat.Name = "cmbKategoriaRecetat";
            this.cmbKategoriaRecetat.Size = new System.Drawing.Size(180, 21);
            this.cmbKategoriaRecetat.TabIndex = 27;
            this.cmbKategoriaRecetat.ValueMember = "ID_KATEGORIARECETA";
            this.cmbKategoriaRecetat.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriaRecetat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Artikulli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Kategoria";
            // 
            // rbRecetat
            // 
            this.rbRecetat.AutoSize = true;
            this.rbRecetat.Checked = true;
            this.rbRecetat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecetat.Location = new System.Drawing.Point(13, 120);
            this.rbRecetat.Name = "rbRecetat";
            this.rbRecetat.Size = new System.Drawing.Size(57, 17);
            this.rbRecetat.TabIndex = 12;
            this.rbRecetat.TabStop = true;
            this.rbRecetat.Text = "Artikujt";
            this.rbRecetat.UseVisualStyleBackColor = true;
            this.rbRecetat.CheckedChanged += new System.EventHandler(this.rbRecetat_CheckedChanged);
            // 
            // dtpMbarimi
            // 
            this.dtpMbarimi.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMbarimi.Location = new System.Drawing.Point(13, 87);
            this.dtpMbarimi.Name = "dtpMbarimi";
            this.dtpMbarimi.ShowUpDown = true;
            this.dtpMbarimi.Size = new System.Drawing.Size(180, 20);
            this.dtpMbarimi.TabIndex = 3;
            // 
            // dtpFillimi
            // 
            this.dtpFillimi.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFillimi.Location = new System.Drawing.Point(13, 52);
            this.dtpFillimi.Name = "dtpFillimi";
            this.dtpFillimi.ShowUpDown = true;
            this.dtpFillimi.Size = new System.Drawing.Size(180, 20);
            this.dtpFillimi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Midis datave";
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.uiGroupBox4.Location = new System.Drawing.Point(63, 123);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Size = new System.Drawing.Size(130, 100);
            this.uiGroupBox4.TabIndex = 24;
            this.uiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnKerko
            // 
            this.btnKerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerko.ForeColor = System.Drawing.Color.Navy;
            this.btnKerko.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerko.Location = new System.Drawing.Point(83, 315);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(66, 28);
            this.btnKerko.TabIndex = 3;
            this.btnKerko.Text = "Kërko";
            this.btnKerko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmXhiroSipasArtikujve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXhiroSipasArtikujve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Xhiro sipas artikujve dhe recetave";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmXhiroSipasArtikujve_CausesValidationChanged);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbXhiro)).EndInit();
            this.gbXhiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridXhiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMbarimi;
        private System.Windows.Forms.DateTimePicker dtpFillimi;
        private System.Windows.Forms.RadioButton rbRecetat;
        private System.Windows.Forms.Button btnKerko;
        private Janus.Windows.EditControls.UIGroupBox gbXhiro;
        private Janus.Windows.GridEX.GridEX gridXhiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox4;
        private System.Windows.Forms.ComboBox cmbRecetat;
        private System.Windows.Forms.ComboBox cmbKategoriaRecetat;
        private System.Windows.Forms.ErrorProvider error1;
    }
}