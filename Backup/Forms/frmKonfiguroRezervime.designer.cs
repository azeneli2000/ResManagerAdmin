namespace ResManagerAdmin.Forms
{
    partial class frmKonfiguroRezervime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKonfiguroRezervime));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnFshi = new System.Windows.Forms.Button();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.gridEXTavolinaRezervimi = new Janus.Windows.GridEX.GridEX();
            this.gridEXTavolina = new Janus.Windows.GridEX.GridEX();
            this.btnPastro = new System.Windows.Forms.Button();
            this.btnDjathtas = new System.Windows.Forms.Button();
            this.btnMajtas = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKategorite = new VisionInfoSolutionLibrary.MultiComboBox();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.dtpOraMbarimi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOraFillimi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dsRezervimi = new System.Data.DataSet();
            this.dsTavolinat = new System.Data.DataSet();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTavolinaRezervimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTavolina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRezervimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTavolinat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnFshi);
            this.panelEx1.Controls.Add(this.btnAnullo);
            this.panelEx1.Controls.Add(this.btnRuaj);
            this.panelEx1.Controls.Add(this.uiGroupBox2);
            this.panelEx1.Controls.Add(this.uiGroupBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(631, 527);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnFshi
            // 
            this.btnFshi.ForeColor = System.Drawing.Color.Navy;
            this.btnFshi.Image = global::ResManagerAdmin.Properties.Resources.cancelbuild;
            this.btnFshi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshi.Location = new System.Drawing.Point(281, 485);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(75, 30);
            this.btnFshi.TabIndex = 26;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFshi.UseVisualStyleBackColor = true;
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(519, 485);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 30);
            this.btnAnullo.TabIndex = 25;
            this.btnAnullo.Text = "Dil";
            this.btnAnullo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.ForeColor = System.Drawing.Color.Navy;
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.save;
            this.btnRuaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuaj.Location = new System.Drawing.Point(46, 484);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(75, 30);
            this.btnRuaj.TabIndex = 24;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.gridEXTavolinaRezervimi);
            this.uiGroupBox2.Controls.Add(this.gridEXTavolina);
            this.uiGroupBox2.Controls.Add(this.btnPastro);
            this.uiGroupBox2.Controls.Add(this.btnDjathtas);
            this.uiGroupBox2.Controls.Add(this.btnMajtas);
            this.uiGroupBox2.Controls.Add(this.label8);
            this.uiGroupBox2.Controls.Add(this.label7);
            this.uiGroupBox2.Controls.Add(this.label6);
            this.uiGroupBox2.Controls.Add(this.cmbKategorite);
            this.uiGroupBox2.Location = new System.Drawing.Point(12, 146);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(601, 330);
            this.uiGroupBox2.TabIndex = 1;
            this.uiGroupBox2.Text = "Tavolinat e rezervuara";
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // gridEXTavolinaRezervimi
            // 
            this.gridEXTavolinaRezervimi.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEXTavolinaRezervimi.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEXTavolinaRezervimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXTavolinaRezervimi.GroupByBoxInfoText = "Tërhiqni një prej kolonave për të grupuar tavolinat";
            this.gridEXTavolinaRezervimi.GroupByBoxVisible = false;
            this.gridEXTavolinaRezervimi.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridEXTavolinaRezervimi.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEXTavolinaRezervimi.LayoutData = resources.GetString("gridEXTavolinaRezervimi.LayoutData");
            this.gridEXTavolinaRezervimi.Location = new System.Drawing.Point(364, 81);
            this.gridEXTavolinaRezervimi.Name = "gridEXTavolinaRezervimi";
            this.gridEXTavolinaRezervimi.Size = new System.Drawing.Size(218, 233);
            this.gridEXTavolinaRezervimi.TabIndex = 29;
            // 
            // gridEXTavolina
            // 
            this.gridEXTavolina.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEXTavolina.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEXTavolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXTavolina.GroupByBoxInfoText = "Tërhiqni një prej kolonave për të grupuar tavolinat";
            this.gridEXTavolina.GroupByBoxVisible = false;
            this.gridEXTavolina.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridEXTavolina.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEXTavolina.LayoutData = resources.GetString("gridEXTavolina.LayoutData");
            this.gridEXTavolina.Location = new System.Drawing.Point(34, 81);
            this.gridEXTavolina.Name = "gridEXTavolina";
            this.gridEXTavolina.Size = new System.Drawing.Size(218, 233);
            this.gridEXTavolina.TabIndex = 28;
            // 
            // btnPastro
            // 
            this.btnPastro.ForeColor = System.Drawing.Color.Navy;
            this.btnPastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPastro.Location = new System.Drawing.Point(507, 35);
            this.btnPastro.Name = "btnPastro";
            this.btnPastro.Size = new System.Drawing.Size(75, 30);
            this.btnPastro.TabIndex = 27;
            this.btnPastro.Text = "Pastro";
            this.btnPastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPastro.UseVisualStyleBackColor = true;
            this.btnPastro.Click += new System.EventHandler(this.btnPastro_Click);
            // 
            // btnDjathtas
            // 
            this.btnDjathtas.ForeColor = System.Drawing.Color.Navy;
            this.btnDjathtas.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_fundit;
            this.btnDjathtas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDjathtas.Location = new System.Drawing.Point(269, 157);
            this.btnDjathtas.Name = "btnDjathtas";
            this.btnDjathtas.Size = new System.Drawing.Size(75, 24);
            this.btnDjathtas.TabIndex = 21;
            this.btnDjathtas.Text = "Kalo";
            this.btnDjathtas.UseVisualStyleBackColor = true;
            this.btnDjathtas.Click += new System.EventHandler(this.btnDjathtas_Click);
            // 
            // btnMajtas
            // 
            this.btnMajtas.ForeColor = System.Drawing.Color.Navy;
            this.btnMajtas.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_pari;
            this.btnMajtas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMajtas.Location = new System.Drawing.Point(269, 187);
            this.btnMajtas.Name = "btnMajtas";
            this.btnMajtas.Size = new System.Drawing.Size(75, 24);
            this.btnMajtas.TabIndex = 20;
            this.btnMajtas.Text = "Kalo";
            this.btnMajtas.UseVisualStyleBackColor = true;
            this.btnMajtas.Click += new System.EventHandler(this.btnMajtas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tavolinat për rezervim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tavolinat e lira për kategorinë";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kategoria";
            // 
            // cmbKategorite
            // 
            this.cmbKategorite.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKategorite.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbKategorite.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbKategorite.DefaultErrorMessage = "Zgjidhni një prej kategorive!";
            this.cmbKategorite.DisplayMember = "PERSHKRIMI";
            this.cmbKategorite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbKategorite.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbKategorite.IsValid = false;
            this.cmbKategorite.LayoutData = resources.GetString("cmbKategorite.LayoutData");
            this.cmbKategorite.Location = new System.Drawing.Point(34, 35);
            this.cmbKategorite.Name = "cmbKategorite";
            this.cmbKategorite.Required = true;
            this.cmbKategorite.Size = new System.Drawing.Size(180, 20);
            this.cmbKategorite.TabIndex = 14;
            this.cmbKategorite.Value = null;
            this.cmbKategorite.ValueMember = "ID_KATEGORIATAVOLINA";
            this.cmbKategorite.ValueChanged += new System.EventHandler(this.cmbKategorite_ValueChanged);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.dtpOraMbarimi);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.dtpOraFillimi);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.dtpData);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.txtMbiemri);
            this.uiGroupBox1.Controls.Add(this.txtEmri);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Image = global::ResManagerAdmin.Properties.Resources.Scheduled_Tasks;
            this.uiGroupBox1.ImageSize = new System.Drawing.Size(18, 24);
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(601, 133);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "Të dhënat mbi rezervimin";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // dtpOraMbarimi
            // 
            this.dtpOraMbarimi.CustomFormat = "HH:mm";
            this.dtpOraMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOraMbarimi.Location = new System.Drawing.Point(476, 92);
            this.dtpOraMbarimi.Name = "dtpOraMbarimi";
            this.dtpOraMbarimi.ShowUpDown = true;
            this.dtpOraMbarimi.Size = new System.Drawing.Size(68, 20);
            this.dtpOraMbarimi.TabIndex = 9;
            this.dtpOraMbarimi.ValueChanged += new System.EventHandler(this.dtpOraMbarimi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Deri në orën";
            // 
            // dtpOraFillimi
            // 
            this.dtpOraFillimi.CustomFormat = "HH:mm";
            this.dtpOraFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOraFillimi.Location = new System.Drawing.Point(364, 92);
            this.dtpOraFillimi.Name = "dtpOraFillimi";
            this.dtpOraFillimi.ShowUpDown = true;
            this.dtpOraFillimi.Size = new System.Drawing.Size(68, 20);
            this.dtpOraFillimi.TabIndex = 7;
            this.dtpOraFillimi.ValueChanged += new System.EventHandler(this.dtpOraFillimi_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nga ora";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd.MM.yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(364, 47);
            this.dtpData.Name = "dtpData";
            this.dtpData.ShowUpDown = true;
            this.dtpData.Size = new System.Drawing.Size(180, 20);
            this.dtpData.TabIndex = 5;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data e rezervimit";
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.Location = new System.Drawing.Point(36, 93);
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.Size = new System.Drawing.Size(180, 20);
            this.txtMbiemri.TabIndex = 3;
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(36, 47);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(180, 20);
            this.txtEmri.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mbiemri i klientit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emri i klientit";
            // 
            // dsRezervimi
            // 
            this.dsRezervimi.DataSetName = "NewDataSet";
            // 
            // dsTavolinat
            // 
            this.dsTavolinat.DataSetName = "NewDataSet";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmKonfiguroRezervime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 527);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKonfiguroRezervime";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Konfigurimi i rezervimeve";
            this.Load += new System.EventHandler(this.frmKonfiguroRezervime_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTavolinaRezervimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTavolina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRezervimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTavolinat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private VisionInfoSolutionLibrary.MultiComboBox cmbKategorite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDjathtas;
        private System.Windows.Forms.Button btnMajtas;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.Button btnFshi;
        private System.Windows.Forms.DateTimePicker dtpOraMbarimi;
        private System.Windows.Forms.DateTimePicker dtpOraFillimi;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtMbiemri;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.Button btnPastro;
        private System.Data.DataSet dsRezervimi;
        private Janus.Windows.GridEX.GridEX gridEXTavolina;
        private Janus.Windows.GridEX.GridEX gridEXTavolinaRezervimi;
        private System.Data.DataSet dsTavolinat;
        private System.Windows.Forms.ErrorProvider error;
    }
}