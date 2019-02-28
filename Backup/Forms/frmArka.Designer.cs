namespace ResManagerAdmin.Forms
{
    partial class frmArka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArka));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.gridArka = new Janus.Windows.GridEX.GridEX();
            this.gbCash = new Janus.Windows.EditControls.UIGroupBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calendar = new Janus.Windows.Schedule.Calendar();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSot = new System.Windows.Forms.Button();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.cbHoteli = new System.Windows.Forms.CheckBox();
            this.cbBari = new System.Windows.Forms.CheckBox();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCash)).BeginInit();
            this.gbCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).BeginInit();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.AutoScroll = true;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.uiGroupBox3);
            this.expandablePanel1.Controls.Add(this.gbCash);
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
            this.expandablePanel1.TitleText = "Gjendja e arkës";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.gridArka);
            this.uiGroupBox3.Location = new System.Drawing.Point(10, 319);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(552, 283);
            this.uiGroupBox3.TabIndex = 3;
            this.uiGroupBox3.Text = "Arka sipas formës së pagesave";
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // gridArka
            // 
            this.gridArka.AutomaticSort = false;
            this.gridArka.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridArka.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridArka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridArka.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridArka.GroupByBoxVisible = false;
            this.gridArka.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridArka.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridArka.LayoutData = resources.GetString("gridArka.LayoutData");
            this.gridArka.Location = new System.Drawing.Point(15, 21);
            this.gridArka.Name = "gridArka";
            this.gridArka.Size = new System.Drawing.Size(524, 244);
            this.gridArka.TabIndex = 0;
            this.gridArka.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridArka.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // gbCash
            // 
            this.gbCash.Controls.Add(this.txtCash);
            this.gbCash.Controls.Add(this.pictureBox1);
            this.gbCash.Controls.Add(this.calendar);
            this.gbCash.Controls.Add(this.panelEx2);
            this.gbCash.Location = new System.Drawing.Point(10, 111);
            this.gbCash.Name = "gbCash";
            this.gbCash.Size = new System.Drawing.Size(552, 202);
            this.gbCash.TabIndex = 2;
            this.gbCash.Text = "Gjendja fizike(cash) në arkë për sot";
            this.gbCash.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.Color.White;
            this.txtCash.Location = new System.Drawing.Point(241, 83);
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(180, 20);
            this.txtCash.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
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
            this.calendar.Location = new System.Drawing.Point(15, 28);
            this.calendar.MonthBackgroundStyle.BackColor = System.Drawing.Color.White;
            this.calendar.MonthBackgroundStyle.BackColorAlphaMode = Janus.Windows.Schedule.AlphaMode.UseAlpha;
            this.calendar.MonthBackgroundStyle.BackColorGradient = System.Drawing.SystemColors.InactiveCaptionText;
            this.calendar.MonthBackgroundStyle.BackgroundGradientMode = Janus.Windows.Schedule.BackgroundGradientMode.Horizontal;
            this.calendar.MonthBackgroundStyle.ForeColor = System.Drawing.Color.Navy;
            this.calendar.Name = "calendar";
            this.calendar.SelectedDates = new System.DateTime[0];
            this.calendar.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.calendar.Size = new System.Drawing.Size(150, 134);
            this.calendar.TabIndex = 19;
            this.calendar.Text = "Calendar";
            this.calendar.SelectionChanged += new System.EventHandler(this.calendar_SelectionChanged);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.Controls.Add(this.label8);
            this.panelEx2.Controls.Add(this.btnSot);
            this.panelEx2.Location = new System.Drawing.Point(15, 125);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(150, 60);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.Color = System.Drawing.Color.Silver;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx2.TabIndex = 20;
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
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cbHoteli);
            this.uiGroupBox1.Controls.Add(this.cbBari);
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 40);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(552, 67);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Modulet";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // cbHoteli
            // 
            this.cbHoteli.AutoSize = true;
            this.cbHoteli.Location = new System.Drawing.Point(241, 29);
            this.cbHoteli.Name = "cbHoteli";
            this.cbHoteli.Size = new System.Drawing.Size(96, 17);
            this.cbHoteli.TabIndex = 0;
            this.cbHoteli.Text = "Hotel Manager";
            this.cbHoteli.UseVisualStyleBackColor = true;
            // 
            // cbBari
            // 
            this.cbBari.AutoSize = true;
            this.cbBari.Checked = true;
            this.cbBari.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBari.Location = new System.Drawing.Point(15, 29);
            this.cbBari.Name = "cbBari";
            this.cbBari.Size = new System.Drawing.Size(142, 17);
            this.cbBari.TabIndex = 1;
            this.cbBari.Text = "Bar-Restaurant Manager";
            this.cbBari.UseVisualStyleBackColor = true;
            // 
            // frmArka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gjendja e arkës";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmArka_CausesValidationChanged);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCash)).EndInit();
            this.gbCash.ResumeLayout(false);
            this.gbCash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.CheckBox cbBari;
        private System.Windows.Forms.CheckBox cbHoteli;
        private Janus.Windows.EditControls.UIGroupBox gbCash;
        private Janus.Windows.Schedule.Calendar calendar;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSot;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.GridEX.GridEX gridArka;
    }
}