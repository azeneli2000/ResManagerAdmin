namespace ResManagerAdmin.Forms
{
    partial class frmPrinterat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinterat));
            this.paneli = new DevComponents.DotNetBar.ExpandablePanel();
            this.lblReceta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridaPrinterat = new Janus.Windows.GridEX.GridEX();
            this.gridaRecetat = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnRuaj = new DevComponents.DotNetBar.ButtonX();
            this.btnAnullo = new DevComponents.DotNetBar.ButtonX();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaPrinterat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridaRecetat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.Controls.Add(this.lblReceta);
            this.paneli.Controls.Add(this.label1);
            this.paneli.Controls.Add(this.gridaPrinterat);
            this.paneli.Controls.Add(this.gridaRecetat);
            this.paneli.Controls.Add(this.uiGroupBox1);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(1012, 640);
            this.paneli.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.paneli.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.paneli.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.paneli.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.paneli.Style.GradientAngle = 90;
            this.paneli.TabIndex = 0;
            this.paneli.TitleHeight = 30;
            this.paneli.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.paneli.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.paneli.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneli.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.paneli.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneli.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.paneli.TitleStyle.GradientAngle = 90;
            this.paneli.TitleText = "Printerat";
            // 
            // lblReceta
            // 
            this.lblReceta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceta.Location = new System.Drawing.Point(549, 65);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(386, 30);
            this.lblReceta.TabIndex = 4;
            this.lblReceta.Text = "Konfigurimi per receten e zgjedhur";
            this.lblReceta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recetat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridaPrinterat
            // 
            this.gridaPrinterat.AutomaticSort = false;
            this.gridaPrinterat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaPrinterat.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridaPrinterat.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.gridaPrinterat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaPrinterat.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaPrinterat.GroupByBoxVisible = false;
            this.gridaPrinterat.HeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaPrinterat.HeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridaPrinterat.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridaPrinterat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaPrinterat.LayoutData = resources.GetString("gridaPrinterat.LayoutData");
            this.gridaPrinterat.Location = new System.Drawing.Point(549, 110);
            this.gridaPrinterat.Name = "gridaPrinterat";
            this.gridaPrinterat.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridaPrinterat.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.gridaPrinterat.Size = new System.Drawing.Size(386, 376);
            this.gridaPrinterat.TabIndex = 2;
            // 
            // gridaRecetat
            // 
            this.gridaRecetat.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaRecetat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaRecetat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaRecetat.GridLines = Janus.Windows.GridEX.GridLines.Horizontal;
            this.gridaRecetat.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaRecetat.GroupByBoxVisible = false;
            this.gridaRecetat.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridaRecetat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaRecetat.LayoutData = resources.GetString("gridaRecetat.LayoutData");
            this.gridaRecetat.Location = new System.Drawing.Point(85, 110);
            this.gridaRecetat.Name = "gridaRecetat";
            this.gridaRecetat.Size = new System.Drawing.Size(319, 443);
            this.gridaRecetat.TabIndex = 1;
            this.gridaRecetat.CurrentCellChanged += new System.EventHandler(this.gridaRecetat_CurrentCellChanged);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btnRuaj);
            this.uiGroupBox1.Controls.Add(this.btnAnullo);
            this.uiGroupBox1.Location = new System.Drawing.Point(549, 492);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(386, 61);
            this.uiGroupBox1.TabIndex = 8;
            // 
            // btnRuaj
            // 
            this.btnRuaj.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuaj.Location = new System.Drawing.Point(88, 19);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(90, 30);
            this.btnRuaj.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnRuaj.TabIndex = 5;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // btnAnullo
            // 
            this.btnAnullo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnullo.Location = new System.Drawing.Point(229, 19);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(90, 30);
            this.btnAnullo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnullo.TabIndex = 6;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // frmPrinterat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 640);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrinterat";
            this.Text = "Konfigurimi i printerave";
            this.Load += new System.EventHandler(this.frmPrinterat_Load);
            this.paneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaPrinterat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridaRecetat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel paneli;
        private Janus.Windows.GridEX.GridEX gridaRecetat;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.GridEX gridaPrinterat;
        private DevComponents.DotNetBar.ButtonX btnAnullo;
        private DevComponents.DotNetBar.ButtonX btnRuaj;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
    }
}