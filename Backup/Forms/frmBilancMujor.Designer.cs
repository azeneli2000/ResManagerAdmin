namespace ResManagerAdmin.Forms
{
    partial class frmBilancMujor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilancMujor));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.ZedBilanci = new ZedGraph.ZedGraphControl();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.uiGroupBox5 = new Janus.Windows.EditControls.UIGroupBox();
            this.dtViti = new System.Windows.Forms.DateTimePicker();
            this.uiGroupBox4 = new Janus.Windows.EditControls.UIGroupBox();
            this.optTabelare = new System.Windows.Forms.RadioButton();
            this.optGrafike = new System.Windows.Forms.RadioButton();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).BeginInit();
            this.uiGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).BeginInit();
            this.uiGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.AutoScroll = true;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.uiGroupBox3);
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
            this.expandablePanel1.TitleText = "Bilanci mujor";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.grida);
            this.uiGroupBox3.Controls.Add(this.ZedBilanci);
            this.uiGroupBox3.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox3.Image")));
            this.uiGroupBox3.ImageSize = new System.Drawing.Size(24, 24);
            this.uiGroupBox3.Location = new System.Drawing.Point(170, 40);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(838, 470);
            this.uiGroupBox3.TabIndex = 3;
            this.uiGroupBox3.Text = "Bilanci sipas muajve për vitin";
            this.uiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // grida
            // 
            this.grida.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida.AutomaticSort = false;
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(15, 39);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(808, 415);
            this.grida.TabIndex = 0;
            this.grida.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grida.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grida.TotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
            // 
            // ZedBilanci
            // 
            this.ZedBilanci.IsEnableHPan = true;
            this.ZedBilanci.IsEnableVPan = true;
            this.ZedBilanci.IsEnableZoom = true;
            this.ZedBilanci.IsScrollY2 = false;
            this.ZedBilanci.IsShowContextMenu = true;
            this.ZedBilanci.IsShowHScrollBar = false;
            this.ZedBilanci.IsShowPointValues = false;
            this.ZedBilanci.IsShowVScrollBar = false;
            this.ZedBilanci.IsZoomOnMouseCenter = false;
            this.ZedBilanci.Location = new System.Drawing.Point(26, 86);
            this.ZedBilanci.Name = "ZedBilanci";
            this.ZedBilanci.PanButtons = System.Windows.Forms.MouseButtons.Left;
            this.ZedBilanci.PanButtons2 = System.Windows.Forms.MouseButtons.Middle;
            this.ZedBilanci.PanModifierKeys2 = System.Windows.Forms.Keys.None;
            this.ZedBilanci.PointDateFormat = "g";
            this.ZedBilanci.PointValueFormat = "G";
            this.ZedBilanci.ScrollMaxX = 0;
            this.ZedBilanci.ScrollMaxY = 0;
            this.ZedBilanci.ScrollMaxY2 = 0;
            this.ZedBilanci.ScrollMinX = 0;
            this.ZedBilanci.ScrollMinY = 0;
            this.ZedBilanci.ScrollMinY2 = 0;
            this.ZedBilanci.Size = new System.Drawing.Size(769, 360);
            this.ZedBilanci.TabIndex = 1;
            this.ZedBilanci.ZoomButtons = System.Windows.Forms.MouseButtons.Left;
            this.ZedBilanci.ZoomButtons2 = System.Windows.Forms.MouseButtons.None;
            this.ZedBilanci.ZoomModifierKeys = System.Windows.Forms.Keys.None;
            this.ZedBilanci.ZoomModifierKeys2 = System.Windows.Forms.Keys.None;
            this.ZedBilanci.ZoomStepFraction = 0.1;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiGroupBox5);
            this.uiGroupBox1.Controls.Add(this.uiGroupBox4);
            this.uiGroupBox1.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox1.Image")));
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 40);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(154, 251);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Kërkimi i bilancit";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.Controls.Add(this.dtViti);
            this.uiGroupBox5.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.uiGroupBox5.Location = new System.Drawing.Point(13, 125);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Size = new System.Drawing.Size(125, 55);
            this.uiGroupBox5.TabIndex = 5;
            this.uiGroupBox5.Text = "Viti";
            this.uiGroupBox5.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.uiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // dtViti
            // 
            this.dtViti.CustomFormat = "yyyy";
            this.dtViti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtViti.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtViti.Location = new System.Drawing.Point(0, 21);
            this.dtViti.Name = "dtViti";
            this.dtViti.ShowUpDown = true;
            this.dtViti.Size = new System.Drawing.Size(99, 21);
            this.dtViti.TabIndex = 0;
            this.dtViti.ValueChanged += new System.EventHandler(this.dtViti_ValueChanged);
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.optTabelare);
            this.uiGroupBox4.Controls.Add(this.optGrafike);
            this.uiGroupBox4.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.uiGroupBox4.Location = new System.Drawing.Point(13, 25);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Size = new System.Drawing.Size(125, 81);
            this.uiGroupBox4.TabIndex = 4;
            this.uiGroupBox4.Text = "Forma e paraqitjes";
            this.uiGroupBox4.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.uiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // optTabelare
            // 
            this.optTabelare.AutoSize = true;
            this.optTabelare.Location = new System.Drawing.Point(0, 28);
            this.optTabelare.Name = "optTabelare";
            this.optTabelare.Size = new System.Drawing.Size(107, 17);
            this.optTabelare.TabIndex = 0;
            this.optTabelare.TabStop = true;
            this.optTabelare.Text = "Paraqitje tabelare";
            this.optTabelare.UseVisualStyleBackColor = true;
            this.optTabelare.CheckedChanged += new System.EventHandler(this.optTabelare_CheckedChanged);
            // 
            // optGrafike
            // 
            this.optGrafike.AutoSize = true;
            this.optGrafike.Location = new System.Drawing.Point(0, 61);
            this.optGrafike.Name = "optGrafike";
            this.optGrafike.Size = new System.Drawing.Size(101, 17);
            this.optGrafike.TabIndex = 1;
            this.optGrafike.TabStop = true;
            this.optGrafike.Text = "Paraqitje grafike";
            this.optGrafike.UseVisualStyleBackColor = true;
            // 
            // frmBilancMujor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBilancMujor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bilanci mujor";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmBilancMujor_CausesValidationChanged);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).EndInit();
            this.uiGroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox4)).EndInit();
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.RadioButton optGrafike;
        private System.Windows.Forms.RadioButton optTabelare;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox4;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox5;
        private System.Windows.Forms.DateTimePicker dtViti;
        private Janus.Windows.GridEX.GridEX grida;
        private ZedGraph.ZedGraphControl ZedBilanci;

    }
}