namespace ResManager.Forms
{
    partial class frmXhiroKamarieri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXhiroKamarieri));
            this.panelBack = new DevComponents.DotNetBar.PanelEx();
            this.tabTavolina = new Janus.Windows.UI.Tab.UITab();
            this.tabFaturat = new Janus.Windows.UI.Tab.UITabPage();
            this.gridaFaturat = new Janus.Windows.GridEX.GridEX();
            this.tabTotali = new Janus.Windows.UI.Tab.UITabPage();
            this.gridaTotali = new Janus.Windows.GridEX.GridEX();
            this.btnPrinto = new DevComponents.DotNetBar.ButtonX();
            this.btnMbyll = new DevComponents.DotNetBar.ButtonX();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
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
            this.panelBack.Controls.Add(this.tabTavolina);
            this.panelBack.Controls.Add(this.btnPrinto);
            this.panelBack.Controls.Add(this.btnMbyll);
            this.panelBack.Location = new System.Drawing.Point(-5, 1);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(411, 432);
            this.panelBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBack.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBack.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBack.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBack.Style.GradientAngle = 90;
            this.panelBack.TabIndex = 1;
            // 
            // tabTavolina
            // 
            this.tabTavolina.Controls.Add(this.tabFaturat);
            this.tabTavolina.Controls.Add(this.tabTotali);
            this.tabTavolina.Location = new System.Drawing.Point(17, 24);
            this.tabTavolina.Name = "tabTavolina";
            this.tabTavolina.SelectedIndex = 0;
            this.tabTavolina.Size = new System.Drawing.Size(382, 341);
            this.tabTavolina.TabIndex = 4;
            this.tabTavolina.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.tabFaturat,
            this.tabTotali});
            // 
            // tabFaturat
            // 
            this.tabFaturat.Controls.Add(this.gridaFaturat);
            this.tabFaturat.Location = new System.Drawing.Point(1, 21);
            this.tabFaturat.Name = "tabFaturat";
            this.tabFaturat.Size = new System.Drawing.Size(378, 317);
            this.tabFaturat.TabIndex = 0;
            this.tabFaturat.Text = "Faturat";
            // 
            // gridaFaturat
            // 
            this.gridaFaturat.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaFaturat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaFaturat.GroupByBoxVisible = false;
            this.gridaFaturat.GroupRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridaFaturat.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.gridaFaturat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaFaturat.LayoutData = resources.GetString("gridaFaturat.LayoutData");
            this.gridaFaturat.Location = new System.Drawing.Point(17, 28);
            this.gridaFaturat.Name = "gridaFaturat";
            this.gridaFaturat.Size = new System.Drawing.Size(345, 277);
            this.gridaFaturat.TabIndex = 0;
            this.gridaFaturat.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaFaturat.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // tabTotali
            // 
            this.tabTotali.Controls.Add(this.gridaTotali);
            this.tabTotali.Location = new System.Drawing.Point(1, 21);
            this.tabTotali.Name = "tabTotali";
            this.tabTotali.Size = new System.Drawing.Size(378, 317);
            this.tabTotali.TabIndex = 1;
            this.tabTotali.Text = "Totali";
            // 
            // gridaTotali
            // 
            this.gridaTotali.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaTotali.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaTotali.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridaTotali.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaTotali.GroupByBoxVisible = false;
            this.gridaTotali.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaTotali.LayoutData = resources.GetString("gridaTotali.LayoutData");
            this.gridaTotali.Location = new System.Drawing.Point(29, 18);
            this.gridaTotali.Name = "gridaTotali";
            this.gridaTotali.Size = new System.Drawing.Size(306, 296);
            this.gridaTotali.TabIndex = 1;
            this.gridaTotali.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaTotali.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnPrinto
            // 
            this.btnPrinto.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnPrinto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinto.Location = new System.Drawing.Point(300, 380);
            this.btnPrinto.Name = "btnPrinto";
            this.btnPrinto.Size = new System.Drawing.Size(80, 40);
            this.btnPrinto.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnPrinto.TabIndex = 3;
            this.btnPrinto.Text = "Printo";
            this.btnPrinto.Click += new System.EventHandler(this.btnPrinto_Click);
            // 
            // btnMbyll
            // 
            this.btnMbyll.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnMbyll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMbyll.Location = new System.Drawing.Point(35, 380);
            this.btnMbyll.Name = "btnMbyll";
            this.btnMbyll.Size = new System.Drawing.Size(80, 40);
            this.btnMbyll.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnMbyll.TabIndex = 1;
            this.btnMbyll.Text = "Mbyll";
            this.btnMbyll.Click += new System.EventHandler(this.btnMbyll_Click);
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // frmXhiroKamarieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 433);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXhiroKamarieri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xhirua e kamarierit";
            this.Load += new System.EventHandler(this.frmXhiroKamarieri_Load);
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
        private Janus.Windows.UI.Tab.UITab tabTavolina;
        private Janus.Windows.UI.Tab.UITabPage tabFaturat;
        private Janus.Windows.GridEX.GridEX gridaFaturat;
        private Janus.Windows.UI.Tab.UITabPage tabTotali;
        private Janus.Windows.GridEX.GridEX gridaTotali;
        private DevComponents.DotNetBar.ButtonX btnPrinto;
        private DevComponents.DotNetBar.ButtonX btnMbyll;
        private System.Drawing.Printing.PrintDocument printDoc;
    }
}