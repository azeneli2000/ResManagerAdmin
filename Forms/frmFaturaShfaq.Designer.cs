namespace ResManagerAdmin.Forms
{
    partial class frmFaturaShfaq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturaShfaq));
            this.panelBack = new DevComponents.DotNetBar.PanelEx();
            this.lblTotali = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSkonto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMbyll = new DevComponents.DotNetBar.ButtonX();
            this.gridaFatura = new Janus.Windows.GridEX.GridEX();
            this.lblKamarieri = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTavolina = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNrFature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDataoRA = new System.Windows.Forms.Label();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelBack.Controls.Add(this.lblTotali);
            this.panelBack.Controls.Add(this.label6);
            this.panelBack.Controls.Add(this.lblSkonto);
            this.panelBack.Controls.Add(this.label5);
            this.panelBack.Controls.Add(this.btnMbyll);
            this.panelBack.Controls.Add(this.gridaFatura);
            this.panelBack.Controls.Add(this.lblKamarieri);
            this.panelBack.Controls.Add(this.label4);
            this.panelBack.Controls.Add(this.lblTavolina);
            this.panelBack.Controls.Add(this.label3);
            this.panelBack.Controls.Add(this.lblNrFature);
            this.panelBack.Controls.Add(this.label1);
            this.panelBack.Controls.Add(this.label2);
            this.panelBack.Controls.Add(this.lblDataoRA);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(466, 478);
            this.panelBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBack.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBack.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBack.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBack.Style.GradientAngle = 90;
            this.panelBack.TabIndex = 0;
            // 
            // lblTotali
            // 
            this.lblTotali.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotali.Location = new System.Drawing.Point(348, 385);
            this.lblTotali.Name = "lblTotali";
            this.lblTotali.Size = new System.Drawing.Size(69, 23);
            this.lblTotali.TabIndex = 13;
            this.lblTotali.Text = "250";
            this.lblTotali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Totali :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSkonto
            // 
            this.lblSkonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSkonto.Location = new System.Drawing.Point(79, 388);
            this.lblSkonto.Name = "lblSkonto";
            this.lblSkonto.Size = new System.Drawing.Size(62, 23);
            this.lblSkonto.TabIndex = 11;
            this.lblSkonto.Text = "0";
            this.lblSkonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSkonto.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Skonto :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // btnMbyll
            // 
            this.btnMbyll.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnMbyll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMbyll.Image = ((System.Drawing.Image)(resources.GetObject("btnMbyll.Image")));
            this.btnMbyll.Location = new System.Drawing.Point(178, 426);
            this.btnMbyll.Name = "btnMbyll";
            this.btnMbyll.Size = new System.Drawing.Size(110, 40);
            this.btnMbyll.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnMbyll.TabIndex = 9;
            this.btnMbyll.Text = "Dil";
            this.btnMbyll.Click += new System.EventHandler(this.btnMbyll_Click);
            // 
            // gridaFatura
            // 
            this.gridaFatura.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaFatura.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaFatura.GridLines = Janus.Windows.GridEX.GridLines.None;
            this.gridaFatura.GroupByBoxVisible = false;
            this.gridaFatura.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaFatura.LayoutData = resources.GetString("gridaFatura.LayoutData");
            this.gridaFatura.Location = new System.Drawing.Point(30, 92);
            this.gridaFatura.Name = "gridaFatura";
            this.gridaFatura.Size = new System.Drawing.Size(401, 273);
            this.gridaFatura.TabIndex = 8;
            this.gridaFatura.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaFatura.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // lblKamarieri
            // 
            this.lblKamarieri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKamarieri.Location = new System.Drawing.Point(321, 50);
            this.lblKamarieri.Name = "lblKamarieri";
            this.lblKamarieri.Size = new System.Drawing.Size(96, 25);
            this.lblKamarieri.TabIndex = 7;
            this.lblKamarieri.Text = "Klajdi";
            this.lblKamarieri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kamarieri :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTavolina
            // 
            this.lblTavolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTavolina.Location = new System.Drawing.Point(115, 50);
            this.lblTavolina.Name = "lblTavolina";
            this.lblTavolina.Size = new System.Drawing.Size(87, 25);
            this.lblTavolina.TabIndex = 5;
            this.lblTavolina.Text = "54";
            this.lblTavolina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tavolina :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNrFature
            // 
            this.lblNrFature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrFature.Location = new System.Drawing.Point(115, 23);
            this.lblNrFature.Name = "lblNrFature";
            this.lblNrFature.Size = new System.Drawing.Size(87, 25);
            this.lblNrFature.TabIndex = 3;
            this.lblNrFature.Text = "545454";
            this.lblNrFature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nr.Fature :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data ora :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataoRA
            // 
            this.lblDataoRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataoRA.Location = new System.Drawing.Point(318, 23);
            this.lblDataoRA.Name = "lblDataoRA";
            this.lblDataoRA.Size = new System.Drawing.Size(138, 27);
            this.lblDataoRA.TabIndex = 0;
            this.lblDataoRA.Text = "12/05/2006";
            this.lblDataoRA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmFaturaShfaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 478);
            this.Controls.Add(this.panelBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFaturaShfaq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura ";
            this.Load += new System.EventHandler(this.frmFaturaShfaq_Load);
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridaFatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDataoRA;
        private System.Windows.Forms.Label lblNrFature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTavolina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKamarieri;
        private Janus.Windows.GridEX.GridEX gridaFatura;
        private DevComponents.DotNetBar.ButtonX btnMbyll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSkonto;
        private System.Windows.Forms.Label lblTotali;
        private System.Windows.Forms.Label label6;
    }
}