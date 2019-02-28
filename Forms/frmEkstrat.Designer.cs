namespace ResManagerAdmin.Forms
{
    partial class frmEkstrat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEkstrat));
            this.paneli = new DevComponents.DotNetBar.PanelEx();
            this.btnFshi = new DevComponents.DotNetBar.ButtonX();
            this.btnPastro = new DevComponents.DotNetBar.ButtonX();
            this.btnShto = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.btnAnullo = new DevComponents.DotNetBar.ButtonX();
            this.btnRuaj = new DevComponents.DotNetBar.ButtonX();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.paneli.Controls.Add(this.btnFshi);
            this.paneli.Controls.Add(this.btnPastro);
            this.paneli.Controls.Add(this.btnShto);
            this.paneli.Controls.Add(this.label1);
            this.paneli.Controls.Add(this.txtEkstra);
            this.paneli.Controls.Add(this.btnAnullo);
            this.paneli.Controls.Add(this.btnRuaj);
            this.paneli.Controls.Add(this.grida);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(542, 496);
            this.paneli.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.paneli.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.paneli.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneli.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.paneli.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.paneli.Style.GradientAngle = 90;
            this.paneli.TabIndex = 0;
            // 
            // btnFshi
            // 
            this.btnFshi.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnFshi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFshi.Image = ((System.Drawing.Image)(resources.GetObject("btnFshi.Image")));
            this.btnFshi.Location = new System.Drawing.Point(438, 243);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(83, 27);
            this.btnFshi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnFshi.TabIndex = 7;
            this.btnFshi.Text = " Fshi";
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // btnPastro
            // 
            this.btnPastro.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnPastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPastro.Image = ((System.Drawing.Image)(resources.GetObject("btnPastro.Image")));
            this.btnPastro.Location = new System.Drawing.Point(284, 82);
            this.btnPastro.Name = "btnPastro";
            this.btnPastro.Size = new System.Drawing.Size(83, 27);
            this.btnPastro.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnPastro.TabIndex = 6;
            this.btnPastro.Text = " Pastro";
            this.btnPastro.Click += new System.EventHandler(this.btnPastro_Click);
            // 
            // btnShto
            // 
            this.btnShto.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnShto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.Image = ((System.Drawing.Image)(resources.GetObject("btnShto.Image")));
            this.btnShto.Location = new System.Drawing.Point(161, 82);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(91, 27);
            this.btnShto.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnShto.TabIndex = 5;
            this.btnShto.Text = " Ruaj";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(151, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ekstra";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(151, 40);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(228, 20);
            this.txtEkstra.TabIndex = 3;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnullo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnullo.Image = ((System.Drawing.Image)(resources.GetObject("btnAnullo.Image")));
            this.btnAnullo.Location = new System.Drawing.Point(274, 439);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(105, 33);
            this.btnAnullo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnullo.TabIndex = 2;
            this.btnAnullo.Text = " Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuaj.Image = ((System.Drawing.Image)(resources.GetObject("btnRuaj.Image")));
            this.btnRuaj.Location = new System.Drawing.Point(130, 439);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(105, 33);
            this.btnRuaj.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnRuaj.TabIndex = 1;
            this.btnRuaj.Text = " Ruaj";
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // grida
            // 
            this.grida.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.GridLines = Janus.Windows.GridEX.GridLines.Horizontal;
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(109, 128);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(308, 277);
            this.grida.TabIndex = 0;
            // 
            // frmEkstrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 496);
            this.Controls.Add(this.paneli);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEkstrat";
            this.Text = "Ekstrat";
            this.Load += new System.EventHandler(this.frmEkstrat_Load);
            this.paneli.ResumeLayout(false);
            this.paneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx paneli;
        private DevComponents.DotNetBar.ButtonX btnAnullo;
        private DevComponents.DotNetBar.ButtonX btnRuaj;
        private Janus.Windows.GridEX.GridEX grida;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnPastro;
        private DevComponents.DotNetBar.ButtonX btnShto;
        private DevComponents.DotNetBar.ButtonX btnFshi;
    }
}