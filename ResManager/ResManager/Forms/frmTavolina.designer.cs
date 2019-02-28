namespace ResManager.Forms
{
	partial class frmTavolina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTavolina));
            this.panelBack = new DevComponents.DotNetBar.PanelEx();
            this.btnTotali = new DevComponents.DotNetBar.ButtonX();
            this.btnFatura = new DevComponents.DotNetBar.ButtonX();
            this.btnDil = new DevComponents.DotNetBar.ButtonX();
            this.tabTavolina = new Janus.Windows.UI.Tab.UITab();
            this.tabFaturat = new Janus.Windows.UI.Tab.UITabPage();
            this.gridaFaturat = new Janus.Windows.GridEX.GridEX();
            this.tabTotali = new Janus.Windows.UI.Tab.UITabPage();
            this.gridaTotali = new Janus.Windows.GridEX.GridEX();
            this.btnPrinto = new DevComponents.DotNetBar.ButtonX();
            this.btnMbyll = new DevComponents.DotNetBar.ButtonX();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printProva = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabTavolina)).BeginInit();
            this.tabTavolina.SuspendLayout();
            this.tabFaturat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaFaturat)).BeginInit();
            this.tabTotali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaTotali)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelBack.Controls.Add(this.btnTotali);
            this.panelBack.Controls.Add(this.btnFatura);
            this.panelBack.Controls.Add(this.btnDil);
            this.panelBack.Controls.Add(this.tabTavolina);
            this.panelBack.Controls.Add(this.btnPrinto);
            this.panelBack.Controls.Add(this.btnMbyll);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(544, 548);
            this.panelBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBack.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBack.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBack.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBack.Style.GradientAngle = 90;
            this.panelBack.TabIndex = 0;
            this.panelBack.Click += new System.EventHandler(this.panelBack_Click);
            // 
            // btnTotali
            // 
            this.btnTotali.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnTotali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotali.Image = ((System.Drawing.Image)(resources.GetObject("btnTotali.Image")));
            this.btnTotali.Location = new System.Drawing.Point(324, 15);
            this.btnTotali.Name = "btnTotali";
            this.btnTotali.Size = new System.Drawing.Size(110, 45);
            this.btnTotali.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnTotali.TabIndex = 7;
            this.btnTotali.Text = "Produktet";
            this.btnTotali.Click += new System.EventHandler(this.btnTotali_Click);
            // 
            // btnFatura
            // 
            this.btnFatura.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFatura.Image = ((System.Drawing.Image)(resources.GetObject("btnFatura.Image")));
            this.btnFatura.Location = new System.Drawing.Point(128, 15);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(110, 45);
            this.btnFatura.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnFatura.TabIndex = 6;
            this.btnFatura.Text = "Faturat";
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnDil
            // 
            this.btnDil.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnDil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDil.Image = global::ResManager.Properties.Resources.close;
            this.btnDil.Location = new System.Drawing.Point(380, 490);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(110, 40);
            this.btnDil.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDil.TabIndex = 5;
            this.btnDil.Text = "  Dil";
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // tabTavolina
            // 
            this.tabTavolina.Controls.Add(this.tabFaturat);
            this.tabTavolina.Controls.Add(this.tabTotali);
            this.tabTavolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTavolina.Location = new System.Drawing.Point(31, 85);
            this.tabTavolina.Name = "tabTavolina";
            this.tabTavolina.SelectedIndex = 0;
            this.tabTavolina.Size = new System.Drawing.Size(484, 382);
            this.tabTavolina.TabIndex = 4;
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
            this.gridaFaturat.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.gridaFaturat.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaFaturat.GroupByBoxVisible = false;
            this.gridaFaturat.GroupRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridaFaturat.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.gridaFaturat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaFaturat.LayoutData = resources.GetString("gridaFaturat.LayoutData");
            this.gridaFaturat.Location = new System.Drawing.Point(20, 28);
            this.gridaFaturat.Name = "gridaFaturat";
            this.gridaFaturat.Size = new System.Drawing.Size(440, 300);
            this.gridaFaturat.TabIndex = 0;
            this.gridaFaturat.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaFaturat.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // tabTotali
            // 
            this.tabTotali.Controls.Add(this.gridaTotali);
            this.tabTotali.Location = new System.Drawing.Point(1, 23);
            this.tabTotali.Name = "tabTotali";
            this.tabTotali.Size = new System.Drawing.Size(480, 362);
            this.tabTotali.TabIndex = 1;
            this.tabTotali.Text = "Produktet";
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
            this.gridaTotali.Location = new System.Drawing.Point(20, 28);
            this.gridaTotali.Name = "gridaTotali";
            this.gridaTotali.Size = new System.Drawing.Size(440, 300);
            this.gridaTotali.TabIndex = 1;
            this.gridaTotali.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaTotali.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnPrinto
            // 
            this.btnPrinto.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnPrinto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinto.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinto.Image")));
            this.btnPrinto.Location = new System.Drawing.Point(60, 490);
            this.btnPrinto.Name = "btnPrinto";
            this.btnPrinto.Size = new System.Drawing.Size(110, 40);
            this.btnPrinto.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnPrinto.TabIndex = 3;
            this.btnPrinto.Text = "  Printo";
            this.btnPrinto.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnPrinto.Click += new System.EventHandler(this.btnPrinto_Click);
            // 
            // btnMbyll
            // 
            this.btnMbyll.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnMbyll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMbyll.Image = ((System.Drawing.Image)(resources.GetObject("btnMbyll.Image")));
            this.btnMbyll.Location = new System.Drawing.Point(215, 490);
            this.btnMbyll.Name = "btnMbyll";
            this.btnMbyll.Size = new System.Drawing.Size(120, 40);
            this.btnMbyll.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnMbyll.TabIndex = 1;
            this.btnMbyll.Text = "Mbyll tavolinen";
            this.btnMbyll.Click += new System.EventHandler(this.btnMbyll_Click);
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // printProva
            // 
            this.printProva.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printProva_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSelection = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // frmTavolina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 548);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(50, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTavolina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tavolina";
            this.Load += new System.EventHandler(this.frmTavolina_Load);
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabTavolina)).EndInit();
            this.tabTavolina.ResumeLayout(false);
            this.tabFaturat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaFaturat)).EndInit();
            this.tabTotali.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaTotali)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private DevComponents.DotNetBar.PanelEx panelBack;
        private DevComponents.DotNetBar.ButtonX btnPrinto;
        private DevComponents.DotNetBar.ButtonX btnMbyll;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Drawing.Printing.PrintDocument printProva;
        private Janus.Windows.UI.Tab.UITab tabTavolina;
        private Janus.Windows.UI.Tab.UITabPage tabFaturat;
        private Janus.Windows.UI.Tab.UITabPage tabTotali;
        private Janus.Windows.GridEX.GridEX gridaTotali;
        private Janus.Windows.GridEX.GridEX gridaFaturat;
        private System.Windows.Forms.PrintDialog printDialog1;
        private DevComponents.DotNetBar.ButtonX btnDil;
        private DevComponents.DotNetBar.ButtonX btnTotali;
        private DevComponents.DotNetBar.ButtonX btnFatura;
	}
}