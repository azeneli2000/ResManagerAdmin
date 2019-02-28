namespace ResManager.Forms
{
    partial class frmFavorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFavorites));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.btnPas = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.gridaFavorite = new Janus.Windows.GridEX.GridEX();
            this.tabArtikujt = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridaRecetat = new Janus.Windows.GridEX.GridEX();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaFavorite)).BeginInit();
            this.tabArtikujt.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaRecetat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnRuaj);
            this.panelEx1.Controls.Add(this.btnPas);
            this.panelEx1.Controls.Add(this.btnPara);
            this.panelEx1.Controls.Add(this.gridaFavorite);
            this.panelEx1.Controls.Add(this.tabArtikujt);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(765, 528);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.ThemeAware = true;
            // 
            // btnRuaj
            // 
            this.btnRuaj.Location = new System.Drawing.Point(547, 488);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(75, 28);
            this.btnRuaj.TabIndex = 5;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // btnPas
            // 
            this.btnPas.Image = global::ResManager.Properties.Resources.bullet_triangle_blue_pari;
            this.btnPas.Location = new System.Drawing.Point(354, 269);
            this.btnPas.Name = "btnPas";
            this.btnPas.Size = new System.Drawing.Size(43, 33);
            this.btnPas.TabIndex = 4;
            this.btnPas.UseVisualStyleBackColor = true;
            this.btnPas.Click += new System.EventHandler(this.btnPas_Click);
            // 
            // btnPara
            // 
            this.btnPara.Image = global::ResManager.Properties.Resources.bullet_triangle_blue_fundit;
            this.btnPara.Location = new System.Drawing.Point(354, 222);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(43, 33);
            this.btnPara.TabIndex = 3;
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // gridaFavorite
            // 
            this.gridaFavorite.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaFavorite.GroupByBoxVisible = false;
            this.gridaFavorite.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaFavorite.LayoutData = resources.GetString("gridaFavorite.LayoutData");
            this.gridaFavorite.Location = new System.Drawing.Point(416, 37);
            this.gridaFavorite.Name = "gridaFavorite";
            this.gridaFavorite.Size = new System.Drawing.Size(329, 444);
            this.gridaFavorite.TabIndex = 1;
            // 
            // tabArtikujt
            // 
            this.tabArtikujt.Controls.Add(this.tabPage2);
            this.tabArtikujt.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabArtikujt.Location = new System.Drawing.Point(0, 0);
            this.tabArtikujt.Name = "tabArtikujt";
            this.tabArtikujt.SelectedIndex = 0;
            this.tabArtikujt.Size = new System.Drawing.Size(348, 528);
            this.tabArtikujt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridaRecetat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(340, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recetat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridaRecetat
            // 
            this.gridaRecetat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaRecetat.GroupByBoxVisible = false;
            this.gridaRecetat.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.gridaRecetat.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridaRecetat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaRecetat.LayoutData = resources.GetString("gridaRecetat.LayoutData");
            this.gridaRecetat.Location = new System.Drawing.Point(10, 15);
            this.gridaRecetat.Name = "gridaRecetat";
            this.gridaRecetat.Size = new System.Drawing.Size(317, 444);
            this.gridaRecetat.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ruaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 528);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(235, 100);
            this.Name = "frmFavorites";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Konfigurimi i artikujve të preferuar";
            this.Load += new System.EventHandler(this.frmFavorites_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaFavorite)).EndInit();
            this.tabArtikujt.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaRecetat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.TabControl tabArtikujt;
        private System.Windows.Forms.TabPage tabPage2;
        private Janus.Windows.GridEX.GridEX gridaRecetat;
        private Janus.Windows.GridEX.GridEX gridaFavorite;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Button btnPas;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.Button button1;
    }
}