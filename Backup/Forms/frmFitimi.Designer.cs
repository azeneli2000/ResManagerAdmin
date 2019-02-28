namespace ResManagerAdmin.Forms
{
    partial class frmFitimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFitimi));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.grupFitimi = new Janus.Windows.EditControls.UIGroupBox();
            this.lblFitimi = new System.Windows.Forms.Label();
            this.gridaFaturat = new Janus.Windows.GridEX.GridEX();
            this.gridaFitimi = new Janus.Windows.GridEX.GridEX();
            this.button1 = new System.Windows.Forms.Button();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateMbarimi = new System.Windows.Forms.DateTimePicker();
            this.dateFillimi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupFitimi)).BeginInit();
            this.grupFitimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaFaturat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridaFitimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.AutoScroll = true;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.grupFitimi);
            this.expandablePanel1.Controls.Add(this.button1);
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
            this.expandablePanel1.TitleText = "Fitimi në restorant";
            // 
            // grupFitimi
            // 
            this.grupFitimi.Controls.Add(this.lblFitimi);
            this.grupFitimi.Controls.Add(this.gridaFaturat);
            this.grupFitimi.Controls.Add(this.gridaFitimi);
            this.grupFitimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupFitimi.ForeColor = System.Drawing.Color.DarkBlue;
            this.grupFitimi.Image = ((System.Drawing.Image)(resources.GetObject("grupFitimi.Image")));
            this.grupFitimi.ImageSize = new System.Drawing.Size(24, 24);
            this.grupFitimi.Location = new System.Drawing.Point(229, 40);
            this.grupFitimi.Name = "grupFitimi";
            this.grupFitimi.Size = new System.Drawing.Size(760, 562);
            this.grupFitimi.TabIndex = 4;
            this.grupFitimi.Text = "Fitimi për periudhën e zgjedhur kohore";
            this.grupFitimi.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // lblFitimi
            // 
            this.lblFitimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFitimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFitimi.ForeColor = System.Drawing.Color.Brown;
            this.lblFitimi.Location = new System.Drawing.Point(290, 24);
            this.lblFitimi.Name = "lblFitimi";
            this.lblFitimi.Size = new System.Drawing.Size(439, 25);
            this.lblFitimi.TabIndex = 2;
            this.lblFitimi.Text = "Fitimi per daten e zgjedhur :";
            this.lblFitimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridaFaturat
            // 
            this.gridaFaturat.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaFaturat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaFaturat.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridaFaturat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaFaturat.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaFaturat.GroupByBoxVisible = false;
            this.gridaFaturat.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridaFaturat.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.gridaFaturat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaFaturat.LayoutData = resources.GetString("gridaFaturat.LayoutData");
            this.gridaFaturat.Location = new System.Drawing.Point(290, 52);
            this.gridaFaturat.Name = "gridaFaturat";
            this.gridaFaturat.Size = new System.Drawing.Size(439, 494);
            this.gridaFaturat.TabIndex = 1;
            this.gridaFaturat.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaFaturat.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // gridaFitimi
            // 
            this.gridaFitimi.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaFitimi.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaFitimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaFitimi.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaFitimi.GroupByBoxVisible = false;
            this.gridaFitimi.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaFitimi.LayoutData = resources.GetString("gridaFitimi.LayoutData");
            this.gridaFitimi.Location = new System.Drawing.Point(17, 52);
            this.gridaFitimi.Name = "gridaFitimi";
            this.gridaFitimi.Size = new System.Drawing.Size(226, 494);
            this.gridaFitimi.TabIndex = 0;
            this.gridaFitimi.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaFitimi.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gridaFitimi.CurrentCellChanged += new System.EventHandler(this.gridaFitimi_CurrentCellChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(67, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kërko";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.dateMbarimi);
            this.uiGroupBox1.Controls.Add(this.dateFillimi);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Image = ((System.Drawing.Image)(resources.GetObject("uiGroupBox1.Image")));
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 40);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(210, 146);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Shfaq fitimin sipas";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Deri në datën";
            // 
            // dateMbarimi
            // 
            this.dateMbarimi.CustomFormat = "dd.MM.yyyy";
            this.dateMbarimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMbarimi.Location = new System.Drawing.Point(6, 110);
            this.dateMbarimi.Name = "dateMbarimi";
            this.dateMbarimi.ShowUpDown = true;
            this.dateMbarimi.Size = new System.Drawing.Size(180, 20);
            this.dateMbarimi.TabIndex = 3;
            this.dateMbarimi.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateFillimi
            // 
            this.dateFillimi.CustomFormat = "dd.MM.yyyy";
            this.dateFillimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFillimi.Location = new System.Drawing.Point(8, 52);
            this.dateFillimi.Name = "dateFillimi";
            this.dateFillimi.ShowUpDown = true;
            this.dateFillimi.Size = new System.Drawing.Size(180, 20);
            this.dateFillimi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nga data";
            // 
            // frmFitimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFitimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fitimi në restorant";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmFitimi_CausesValidationChanged);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grupFitimi)).EndInit();
            this.grupFitimi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaFaturat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridaFitimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateMbarimi;
        private System.Windows.Forms.DateTimePicker dateFillimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Janus.Windows.EditControls.UIGroupBox grupFitimi;
        private Janus.Windows.GridEX.GridEX gridaFaturat;
        private Janus.Windows.GridEX.GridEX gridaFitimi;
        private System.Windows.Forms.Label lblFitimi;
    }
}