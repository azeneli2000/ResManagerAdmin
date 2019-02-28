namespace ResManagerAdmin.Forms
{
    partial class frmFavoritet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFavoritet));
            this.paneli = new DevComponents.DotNetBar.ExpandablePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnullo = new DevComponents.DotNetBar.ButtonX();
            this.btnRuaj = new DevComponents.DotNetBar.ButtonX();
            this.btnPas = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.gridaFavorite = new Janus.Windows.GridEX.GridEX();
            this.gridaRecetat = new Janus.Windows.GridEX.GridEX();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridaRecetat)).BeginInit();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.Controls.Add(this.label2);
            this.paneli.Controls.Add(this.label1);
            this.paneli.Controls.Add(this.btnAnullo);
            this.paneli.Controls.Add(this.btnRuaj);
            this.paneli.Controls.Add(this.btnPas);
            this.paneli.Controls.Add(this.btnPara);
            this.paneli.Controls.Add(this.gridaFavorite);
            this.paneli.Controls.Add(this.gridaRecetat);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.ExpandButtonVisible = false;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(1020, 640);
            this.paneli.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.paneli.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.paneli.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.paneli.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.paneli.Style.GradientAngle = 90;
            this.paneli.TabIndex = 0;
            this.paneli.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.paneli.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.paneli.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneli.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.paneli.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneli.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.paneli.TitleStyle.GradientAngle = 90;
            this.paneli.TitleText = "     Menu e shpejte";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Menuja e shpejte";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Recetat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnullo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.mbyll;
            this.btnAnullo.Location = new System.Drawing.Point(531, 572);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(110, 35);
            this.btnAnullo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnullo.TabIndex = 8;
            this.btnAnullo.Text = " Anullo";
            this.btnAnullo.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.btnRuaj.Location = new System.Drawing.Point(349, 572);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(110, 35);
            this.btnRuaj.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnRuaj.TabIndex = 7;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // btnPas
            // 
            this.btnPas.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_pari;
            this.btnPas.Location = new System.Drawing.Point(461, 333);
            this.btnPas.Name = "btnPas";
            this.btnPas.Size = new System.Drawing.Size(71, 33);
            this.btnPas.TabIndex = 6;
            this.btnPas.UseVisualStyleBackColor = true;
            this.btnPas.Click += new System.EventHandler(this.btnPas_Click);
            // 
            // btnPara
            // 
            this.btnPara.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_fundit;
            this.btnPara.Location = new System.Drawing.Point(461, 237);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(71, 33);
            this.btnPara.TabIndex = 5;
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // gridaFavorite
            // 
            this.gridaFavorite.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaFavorite.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaFavorite.GroupByBoxVisible = false;
            this.gridaFavorite.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.False;
            this.gridaFavorite.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridaFavorite.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaFavorite.LayoutData = resources.GetString("gridaFavorite.LayoutData");
            this.gridaFavorite.Location = new System.Drawing.Point(576, 82);
            this.gridaFavorite.Name = "gridaFavorite";
            this.gridaFavorite.Size = new System.Drawing.Size(413, 435);
            this.gridaFavorite.TabIndex = 3;
            // 
            // gridaRecetat
            // 
            this.gridaRecetat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaRecetat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaRecetat.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaRecetat.GroupByBoxVisible = false;
            this.gridaRecetat.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.gridaRecetat.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridaRecetat.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.False;
            this.gridaRecetat.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridaRecetat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaRecetat.LayoutData = resources.GetString("gridaRecetat.LayoutData");
            this.gridaRecetat.Location = new System.Drawing.Point(75, 82);
            this.gridaRecetat.Name = "gridaRecetat";
            this.gridaRecetat.Size = new System.Drawing.Size(344, 435);
            this.gridaRecetat.TabIndex = 2;
            // 
            // frmFavoritet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 640);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFavoritet";
            this.Text = "Menu e shpejte";
            this.Load += new System.EventHandler(this.frmFavoritet_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmFavoritet_CausesValidationChanged);
            this.paneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridaRecetat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel paneli;
        private Janus.Windows.GridEX.GridEX gridaRecetat;
        private Janus.Windows.GridEX.GridEX gridaFavorite;
        private System.Windows.Forms.Button btnPas;
        private System.Windows.Forms.Button btnPara;
        private DevComponents.DotNetBar.ButtonX btnAnullo;
        private DevComponents.DotNetBar.ButtonX btnRuaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}