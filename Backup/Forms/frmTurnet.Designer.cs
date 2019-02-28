namespace ResManagerAdmin.Forms
{
    partial class frmTurnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurnet));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnFshiHistorik = new System.Windows.Forms.Button();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnKonsulto = new DevComponents.DotNetBar.ButtonX();
            this.gridTurnet = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnKerko = new DevComponents.DotNetBar.ButtonX();
            this.optMbyllur = new System.Windows.Forms.RadioButton();
            this.optHapur = new System.Windows.Forms.RadioButton();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.cmbKamarieri = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cbKamarieri = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.AutoScroll = true;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.btnFshiHistorik);
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
            this.expandablePanel1.TabIndex = 7;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Turnet e kamarierëve";
            // 
            // btnFshiHistorik
            // 
            this.btnFshiHistorik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFshiHistorik.ForeColor = System.Drawing.Color.Navy;
            this.btnFshiHistorik.Image = global::ResManagerAdmin.Properties.Resources.fshi_historikun;
            this.btnFshiHistorik.Location = new System.Drawing.Point(37, 476);
            this.btnFshiHistorik.Name = "btnFshiHistorik";
            this.btnFshiHistorik.Size = new System.Drawing.Size(85, 37);
            this.btnFshiHistorik.TabIndex = 3;
            this.btnFshiHistorik.Text = "Fshi historikun";
            this.btnFshiHistorik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshiHistorik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFshiHistorik.UseVisualStyleBackColor = true;
            this.btnFshiHistorik.Visible = false;
            this.btnFshiHistorik.Click += new System.EventHandler(this.btnFshiHistorik_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.btnKonsulto);
            this.uiGroupBox2.Controls.Add(this.gridTurnet);
            this.uiGroupBox2.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox2.Image")));
            this.uiGroupBox2.ImageSize = new System.Drawing.Size(20, 20);
            this.uiGroupBox2.Location = new System.Drawing.Point(261, 40);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(635, 539);
            this.uiGroupBox2.TabIndex = 4;
            this.uiGroupBox2.Text = "110, 35";
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnKonsulto
            // 
            this.btnKonsulto.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnKonsulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKonsulto.Image = ((System.Drawing.Image)(resources.GetObject("btnKonsulto.Image")));
            this.btnKonsulto.Location = new System.Drawing.Point(273, 490);
            this.btnKonsulto.Name = "btnKonsulto";
            this.btnKonsulto.Size = new System.Drawing.Size(110, 40);
            this.btnKonsulto.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnKonsulto.TabIndex = 1;
            this.btnKonsulto.Text = "Konsulto";
            this.btnKonsulto.Click += new System.EventHandler(this.btnKonsulto_Click);
            // 
            // gridTurnet
            // 
            this.gridTurnet.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridTurnet.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridTurnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTurnet.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridTurnet.GroupByBoxVisible = false;
            this.gridTurnet.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridTurnet.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridTurnet.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridTurnet.LayoutData = resources.GetString("gridTurnet.LayoutData");
            this.gridTurnet.Location = new System.Drawing.Point(31, 38);
            this.gridTurnet.Name = "gridTurnet";
            this.gridTurnet.Size = new System.Drawing.Size(589, 435);
            this.gridTurnet.TabIndex = 0;
            this.gridTurnet.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btnKerko);
            this.uiGroupBox1.Controls.Add(this.optMbyllur);
            this.uiGroupBox1.Controls.Add(this.optHapur);
            this.uiGroupBox1.Controls.Add(this.dtpData);
            this.uiGroupBox1.Controls.Add(this.cbData);
            this.uiGroupBox1.Controls.Add(this.cmbKamarieri);
            this.uiGroupBox1.Controls.Add(this.cbKamarieri);
            this.uiGroupBox1.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox1.Image")));
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 40);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(217, 276);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "Kërkoni sipas";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnKerko
            // 
            this.btnKerko.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnKerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerko.Image = ((System.Drawing.Image)(resources.GetObject("btnKerko.Image")));
            this.btnKerko.Location = new System.Drawing.Point(67, 224);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(75, 40);
            this.btnKerko.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnKerko.TabIndex = 16;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click_1);
            // 
            // optMbyllur
            // 
            this.optMbyllur.AutoSize = true;
            this.optMbyllur.Location = new System.Drawing.Point(105, 38);
            this.optMbyllur.Name = "optMbyllur";
            this.optMbyllur.Size = new System.Drawing.Size(79, 17);
            this.optMbyllur.TabIndex = 15;
            this.optMbyllur.TabStop = true;
            this.optMbyllur.Text = "Te mbyllura";
            this.optMbyllur.UseVisualStyleBackColor = true;
            // 
            // optHapur
            // 
            this.optHapur.AutoSize = true;
            this.optHapur.Location = new System.Drawing.Point(13, 38);
            this.optHapur.Name = "optHapur";
            this.optHapur.Size = new System.Drawing.Size(74, 17);
            this.optHapur.TabIndex = 14;
            this.optHapur.TabStop = true;
            this.optHapur.Text = "Te hapura";
            this.optHapur.UseVisualStyleBackColor = true;
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd.MM.yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(13, 181);
            this.dtpData.Name = "dtpData";
            this.dtpData.ShowUpDown = true;
            this.dtpData.Size = new System.Drawing.Size(180, 20);
            this.dtpData.TabIndex = 13;
            // 
            // cbData
            // 
            this.cbData.AutoSize = true;
            this.cbData.Location = new System.Drawing.Point(13, 158);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(54, 17);
            this.cbData.TabIndex = 12;
            this.cbData.Text = "Datës";
            this.cbData.UseVisualStyleBackColor = true;
            this.cbData.CheckedChanged += new System.EventHandler(this.cbData_CheckedChanged);
            // 
            // cmbKamarieri
            // 
            this.cmbKamarieri.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKamarieri.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbKamarieri.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbKamarieri.DisplayMember = "KAMARIERI";
            this.cmbKamarieri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbKamarieri.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbKamarieri.LayoutData = resources.GetString("cmbKamarieri.LayoutData");
            this.cmbKamarieri.Location = new System.Drawing.Point(13, 110);
            this.cmbKamarieri.Name = "cmbKamarieri";
            this.cmbKamarieri.Size = new System.Drawing.Size(180, 20);
            this.cmbKamarieri.TabIndex = 11;
            this.cmbKamarieri.Value = null;
            this.cmbKamarieri.ValueMember = "ID_PERSONELI";
            // 
            // cbKamarieri
            // 
            this.cbKamarieri.AutoSize = true;
            this.cbKamarieri.Location = new System.Drawing.Point(13, 87);
            this.cbKamarieri.Name = "cbKamarieri";
            this.cbKamarieri.Size = new System.Drawing.Size(72, 17);
            this.cbKamarieri.TabIndex = 1;
            this.cbKamarieri.Text = "Kamarierit";
            this.cbKamarieri.UseVisualStyleBackColor = true;
            this.cbKamarieri.CheckedChanged += new System.EventHandler(this.cbKamarieri_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // frmTurnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTurnet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Turnet e kamarierëve";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmTurnet_CausesValidationChanged);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTurnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.CheckBox cbKamarieri;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.CheckBox cbData;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbKamarieri;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.GridEX.GridEX gridTurnet;
        private System.Windows.Forms.Button btnFshiHistorik;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton optMbyllur;
        private System.Windows.Forms.RadioButton optHapur;
        private DevComponents.DotNetBar.ButtonX btnKonsulto;
        private DevComponents.DotNetBar.ButtonX btnKerko;
    }
}