namespace ResManagerAdmin.Forms
{
    partial class frmXhiroKam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXhiroKam));
            this.paneli = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnPrintoXhiro = new DevComponents.DotNetBar.ButtonX();
            this.btnPrinto = new DevComponents.DotNetBar.ButtonX();
            this.btnMbyll = new DevComponents.DotNetBar.ButtonX();
            this.btnTotali = new DevComponents.DotNetBar.ButtonX();
            this.btnFatura = new DevComponents.DotNetBar.ButtonX();
            this.tabTavolina = new Janus.Windows.UI.Tab.UITab();
            this.tabFaturat = new Janus.Windows.UI.Tab.UITabPage();
            this.gridaFaturat = new Janus.Windows.GridEX.GridEX();
            this.tabTotali = new Janus.Windows.UI.Tab.UITabPage();
            this.gridaTotali = new Janus.Windows.GridEX.GridEX();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printXhiro = new System.Drawing.Printing.PrintDocument();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabTavolina)).BeginInit();
            this.tabTavolina.SuspendLayout();
            this.tabFaturat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaFaturat)).BeginInit();
            this.tabTotali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaTotali)).BeginInit();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.Controls.Add(this.btnPrintoXhiro);
            this.paneli.Controls.Add(this.btnPrinto);
            this.paneli.Controls.Add(this.btnMbyll);
            this.paneli.Controls.Add(this.btnTotali);
            this.paneli.Controls.Add(this.btnFatura);
            this.paneli.Controls.Add(this.tabTavolina);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.ExpandButtonVisible = false;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(600, 620);
            this.paneli.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.paneli.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.paneli.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.paneli.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.paneli.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.paneli.Style.GradientAngle = 90;
            this.paneli.TabIndex = 0;
            this.paneli.TitleHeight = 32;
            this.paneli.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.paneli.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.paneli.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.paneli.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.paneli.TitleStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneli.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.paneli.TitleStyle.GradientAngle = 90;
            this.paneli.TitleText = "Xhiro";
            // 
            // btnPrintoXhiro
            // 
            this.btnPrintoXhiro.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnPrintoXhiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintoXhiro.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintoXhiro.Image")));
            this.btnPrintoXhiro.Location = new System.Drawing.Point(247, 543);
            this.btnPrintoXhiro.Name = "btnPrintoXhiro";
            this.btnPrintoXhiro.Size = new System.Drawing.Size(115, 40);
            this.btnPrintoXhiro.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnPrintoXhiro.TabIndex = 12;
            this.btnPrintoXhiro.Text = "   Xhiro";
            this.btnPrintoXhiro.Click += new System.EventHandler(this.btnPrintoXhiro_Click);
            // 
            // btnPrinto
            // 
            this.btnPrinto.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnPrinto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinto.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinto.Image")));
            this.btnPrinto.Location = new System.Drawing.Point(79, 543);
            this.btnPrinto.Name = "btnPrinto";
            this.btnPrinto.Size = new System.Drawing.Size(115, 40);
            this.btnPrinto.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnPrinto.TabIndex = 11;
            this.btnPrinto.Text = " Produktet";
            this.btnPrinto.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnPrinto.Click += new System.EventHandler(this.btnPrinto_Click);
            // 
            // btnMbyll
            // 
            this.btnMbyll.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnMbyll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMbyll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMbyll.Image = ((System.Drawing.Image)(resources.GetObject("btnMbyll.Image")));
            this.btnMbyll.Location = new System.Drawing.Point(415, 543);
            this.btnMbyll.Name = "btnMbyll";
            this.btnMbyll.Size = new System.Drawing.Size(115, 40);
            this.btnMbyll.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnMbyll.TabIndex = 10;
            this.btnMbyll.Text = "  Dil";
            this.btnMbyll.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnMbyll.Click += new System.EventHandler(this.btnMbyll_Click);
            // 
            // btnTotali
            // 
            this.btnTotali.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnTotali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotali.Image = ((System.Drawing.Image)(resources.GetObject("btnTotali.Image")));
            this.btnTotali.Location = new System.Drawing.Point(344, 49);
            this.btnTotali.Name = "btnTotali";
            this.btnTotali.Size = new System.Drawing.Size(110, 45);
            this.btnTotali.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnTotali.TabIndex = 9;
            this.btnTotali.Text = "Produktet";
            this.btnTotali.Click += new System.EventHandler(this.btnTotali_Click);
            // 
            // btnFatura
            // 
            this.btnFatura.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnFatura.Image")));
            this.btnFatura.Location = new System.Drawing.Point(148, 49);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(110, 45);
            this.btnFatura.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnFatura.TabIndex = 8;
            this.btnFatura.Text = "Faturat";
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // tabTavolina
            // 
            this.tabTavolina.Controls.Add(this.tabFaturat);
            this.tabTavolina.Controls.Add(this.tabTotali);
            this.tabTavolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTavolina.Location = new System.Drawing.Point(58, 112);
            this.tabTavolina.Name = "tabTavolina";
            this.tabTavolina.SelectedIndex = 0;
            this.tabTavolina.Size = new System.Drawing.Size(484, 382);
            this.tabTavolina.TabIndex = 5;
            this.tabTavolina.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.tabFaturat,
            this.tabTotali});
            // 
            // tabFaturat
            // 
            this.tabFaturat.Controls.Add(this.gridaFaturat);
            this.tabFaturat.Location = new System.Drawing.Point(1, 23);
            this.tabFaturat.Name = "tabFaturat";
            this.tabFaturat.Size = new System.Drawing.Size(480, 356);
            this.tabFaturat.TabIndex = 0;
            this.tabFaturat.Text = "Faturat";
            // 
            // gridaFaturat
            // 
            this.gridaFaturat.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaFaturat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaFaturat.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaFaturat.GroupByBoxVisible = false;
            this.gridaFaturat.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.gridaFaturat.GroupRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridaFaturat.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.gridaFaturat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaFaturat.LayoutData = resources.GetString("gridaFaturat.LayoutData");
            this.gridaFaturat.Location = new System.Drawing.Point(20, 20);
            this.gridaFaturat.Name = "gridaFaturat";
            this.gridaFaturat.Size = new System.Drawing.Size(440, 309);
            this.gridaFaturat.TabIndex = 0;
            this.gridaFaturat.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaFaturat.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // tabTotali
            // 
            this.tabTotali.Controls.Add(this.gridaTotali);
            this.tabTotali.Location = new System.Drawing.Point(1, 23);
            this.tabTotali.Name = "tabTotali";
            this.tabTotali.Size = new System.Drawing.Size(480, 367);
            this.tabTotali.TabIndex = 1;
            this.tabTotali.Text = "Totali";
            // 
            // gridaTotali
            // 
            this.gridaTotali.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaTotali.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaTotali.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridaTotali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaTotali.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaTotali.GroupByBoxVisible = false;
            this.gridaTotali.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaTotali.LayoutData = resources.GetString("gridaTotali.LayoutData");
            this.gridaTotali.Location = new System.Drawing.Point(20, 20);
            this.gridaTotali.Name = "gridaTotali";
            this.gridaTotali.Size = new System.Drawing.Size(440, 328);
            this.gridaTotali.TabIndex = 1;
            this.gridaTotali.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaTotali.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // printXhiro
            // 
            this.printXhiro.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printXhiro_PrintPage);
            // 
            // frmXhiroKam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 620);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXhiroKam";
            this.Load += new System.EventHandler(this.frmXhiroKam_Load);
            this.paneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabTavolina)).EndInit();
            this.tabTavolina.ResumeLayout(false);
            this.tabFaturat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaFaturat)).EndInit();
            this.tabTotali.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaTotali)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel paneli;
        private Janus.Windows.UI.Tab.UITab tabTavolina;
        private Janus.Windows.UI.Tab.UITabPage tabFaturat;
        private Janus.Windows.GridEX.GridEX gridaFaturat;
        private Janus.Windows.UI.Tab.UITabPage tabTotali;
        private Janus.Windows.GridEX.GridEX gridaTotali;
        private DevComponents.DotNetBar.ButtonX btnTotali;
        private DevComponents.DotNetBar.ButtonX btnFatura;
        private DevComponents.DotNetBar.ButtonX btnPrintoXhiro;
        private DevComponents.DotNetBar.ButtonX btnPrinto;
        private DevComponents.DotNetBar.ButtonX btnMbyll;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Drawing.Printing.PrintDocument printXhiro;
    }
}