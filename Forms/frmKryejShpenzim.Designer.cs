namespace ResManagerAdmin.Forms
{
    partial class frmKryejShpenzim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKryejShpenzim));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.calendar = new Janus.Windows.Schedule.Calendar();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSot = new System.Windows.Forms.Button();
            this.txtPerdoruesi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numTotali = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numVlera = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKategorite = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVlera)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.uiGroupBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(515, 372);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.calendar);
            this.uiGroupBox1.Controls.Add(this.panelEx2);
            this.uiGroupBox1.Controls.Add(this.txtPerdoruesi);
            this.uiGroupBox1.Controls.Add(this.label7);
            this.uiGroupBox1.Controls.Add(this.numTotali);
            this.uiGroupBox1.Controls.Add(this.btnOk);
            this.uiGroupBox1.Controls.Add(this.label6);
            this.uiGroupBox1.Controls.Add(this.numVlera);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.cmbKategorite);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.txtPershkrimi);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.dtpData);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Icon = ((System.Drawing.Icon)(resources.GetObject("uiGroupBox1.Icon")));
            this.uiGroupBox1.ImageSize = new System.Drawing.Size(24, 24);
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(488, 343);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "Të dhënat mbi shpenzimin";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // calendar
            // 
            this.calendar.CurrentDate = new System.DateTime(2006, 9, 29, 0, 0, 0, 0);
            this.calendar.DaysFormatStyle.FontItalic = Janus.Windows.Schedule.TriState.False;
            this.calendar.DaysHeadersFormatStyle.FontBold = Janus.Windows.Schedule.TriState.True;
            this.calendar.DaysHeadersFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.calendar.FirstDayOfWeek = Janus.Windows.Schedule.CalendarDayOfWeek.Monday;
            this.calendar.FirstMonth = new System.DateTime(2006, 9, 1, 0, 0, 0, 0);
            this.calendar.HeadersFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.calendar.Location = new System.Drawing.Point(19, 45);
            this.calendar.MonthBackgroundStyle.BackColor = System.Drawing.Color.White;
            this.calendar.MonthBackgroundStyle.BackColorAlphaMode = Janus.Windows.Schedule.AlphaMode.UseAlpha;
            this.calendar.MonthBackgroundStyle.BackColorGradient = System.Drawing.SystemColors.InactiveCaptionText;
            this.calendar.MonthBackgroundStyle.BackgroundGradientMode = Janus.Windows.Schedule.BackgroundGradientMode.Horizontal;
            this.calendar.MonthBackgroundStyle.ForeColor = System.Drawing.Color.Navy;
            this.calendar.Name = "calendar";
            this.calendar.SelectedDates = new System.DateTime[0];
            this.calendar.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.calendar.Size = new System.Drawing.Size(150, 134);
            this.calendar.TabIndex = 17;
            this.calendar.Text = "Calendar";
            this.calendar.SelectionChanged += new System.EventHandler(this.calendar_SelectionChanged);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.Controls.Add(this.label8);
            this.panelEx2.Controls.Add(this.btnSot);
            this.panelEx2.Location = new System.Drawing.Point(19, 142);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(150, 60);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.Color = System.Drawing.Color.Silver;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(44, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sot";
            // 
            // btnSot
            // 
            this.btnSot.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnSot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSot.Location = new System.Drawing.Point(12, 40);
            this.btnSot.Name = "btnSot";
            this.btnSot.Size = new System.Drawing.Size(29, 17);
            this.btnSot.TabIndex = 5;
            this.btnSot.UseVisualStyleBackColor = true;
            this.btnSot.Click += new System.EventHandler(this.btnSot_Click);
            // 
            // txtPerdoruesi
            // 
            this.txtPerdoruesi.BackColor = System.Drawing.Color.White;
            this.txtPerdoruesi.Location = new System.Drawing.Point(280, 160);
            this.txtPerdoruesi.Name = "txtPerdoruesi";
            this.txtPerdoruesi.ReadOnly = true;
            this.txtPerdoruesi.Size = new System.Drawing.Size(180, 20);
            this.txtPerdoruesi.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Përdoruesi";
            // 
            // numTotali
            // 
            this.numTotali.BackColor = System.Drawing.Color.White;
            this.numTotali.DecimalPlaces = 2;
            this.numTotali.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numTotali.Location = new System.Drawing.Point(17, 299);
            this.numTotali.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numTotali.Name = "numTotali";
            this.numTotali.ReadOnly = true;
            this.numTotali.Size = new System.Drawing.Size(152, 20);
            this.numTotali.TabIndex = 14;
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Navy;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(329, 201);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 30);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label6
            // 
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(16, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vlerat totale e shpenzimeve për datën e zgjedhur";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numVlera
            // 
            this.numVlera.DecimalPlaces = 2;
            this.numVlera.Location = new System.Drawing.Point(280, 120);
            this.numVlera.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numVlera.Name = "numVlera";
            this.numVlera.Size = new System.Drawing.Size(180, 20);
            this.numVlera.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vlera";
            // 
            // cmbKategorite
            // 
            this.cmbKategorite.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKategorite.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbKategorite.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbKategorite.DisplayMember = "PERSHKRIMI";
            this.cmbKategorite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbKategorite.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbKategorite.LayoutData = resources.GetString("cmbKategorite.LayoutData");
            this.cmbKategorite.Location = new System.Drawing.Point(280, 45);
            this.cmbKategorite.Name = "cmbKategorite";
            this.cmbKategorite.Size = new System.Drawing.Size(180, 20);
            this.cmbKategorite.TabIndex = 10;
            this.cmbKategorite.Value = null;
            this.cmbKategorite.ValueMember = "ID_KATEGORIASHPENZIMI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategoria";
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Location = new System.Drawing.Point(280, 82);
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(180, 20);
            this.txtPershkrimi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Përshkrimi";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "HH:mm";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(17, 231);
            this.dtpData.Name = "dtpData";
            this.dtpData.ShowUpDown = true;
            this.dtpData.Size = new System.Drawing.Size(152, 20);
            this.dtpData.TabIndex = 3;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(16, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ora";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmKryejShpenzim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 372);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKryejShpenzim";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kryej shpenzim";
            this.Load += new System.EventHandler(this.frmKryejShpenzim_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVlera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbKategorite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTotali;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numVlera;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPerdoruesi;
        private System.Windows.Forms.Label label7;
        private Janus.Windows.Schedule.Calendar calendar;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSot;
    }
}