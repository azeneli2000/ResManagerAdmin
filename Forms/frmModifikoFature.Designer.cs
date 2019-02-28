namespace ResManagerAdmin.Forms
{
    partial class frmModifikoFature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifikoFature));
            this.panelBack = new DevComponents.DotNetBar.PanelEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSkonto = new System.Windows.Forms.TextBox();
            this.optPerqindja = new System.Windows.Forms.RadioButton();
            this.optVlera = new System.Windows.Forms.RadioButton();
            this.btnMinus = new DevComponents.DotNetBar.ButtonX();
            this.btnPlus = new DevComponents.DotNetBar.ButtonX();
            this.cboKategorite = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.lblDataOra = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKamarieri = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTavolina = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNrFatura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridaArtikujt = new Janus.Windows.GridEX.GridEX();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnullo = new DevComponents.DotNetBar.ButtonX();
            this.btnRuaj = new DevComponents.DotNetBar.ButtonX();
            this.gridaFatura = new Janus.Windows.GridEX.GridEX();
            this.panelBack.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaArtikujt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridaFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelBack.Controls.Add(this.groupBox1);
            this.panelBack.Controls.Add(this.btnMinus);
            this.panelBack.Controls.Add(this.btnPlus);
            this.panelBack.Controls.Add(this.cboKategorite);
            this.panelBack.Controls.Add(this.lblDataOra);
            this.panelBack.Controls.Add(this.label8);
            this.panelBack.Controls.Add(this.lblKamarieri);
            this.panelBack.Controls.Add(this.label6);
            this.panelBack.Controls.Add(this.lblTavolina);
            this.panelBack.Controls.Add(this.label4);
            this.panelBack.Controls.Add(this.lblNrFatura);
            this.panelBack.Controls.Add(this.label2);
            this.panelBack.Controls.Add(this.gridaArtikujt);
            this.panelBack.Controls.Add(this.label1);
            this.panelBack.Controls.Add(this.btnAnullo);
            this.panelBack.Controls.Add(this.btnRuaj);
            this.panelBack.Controls.Add(this.gridaFatura);
            this.panelBack.Location = new System.Drawing.Point(0, -1);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(647, 568);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSkonto);
            this.groupBox1.Controls.Add(this.optPerqindja);
            this.groupBox1.Controls.Add(this.optVlera);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(15, 503);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 35);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skonto";
            this.groupBox1.Visible = false;
            // 
            // txtSkonto
            // 
            this.txtSkonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkonto.Location = new System.Drawing.Point(162, 31);
            this.txtSkonto.Name = "txtSkonto";
            this.txtSkonto.Size = new System.Drawing.Size(138, 26);
            this.txtSkonto.TabIndex = 2;
            // 
            // optPerqindja
            // 
            this.optPerqindja.AutoSize = true;
            this.optPerqindja.Location = new System.Drawing.Point(20, 52);
            this.optPerqindja.Name = "optPerqindja";
            this.optPerqindja.Size = new System.Drawing.Size(104, 20);
            this.optPerqindja.TabIndex = 1;
            this.optPerqindja.TabStop = true;
            this.optPerqindja.Text = "Ne perqindje";
            this.optPerqindja.UseVisualStyleBackColor = true;
            // 
            // optVlera
            // 
            this.optVlera.AutoSize = true;
            this.optVlera.Location = new System.Drawing.Point(20, 22);
            this.optVlera.Name = "optVlera";
            this.optVlera.Size = new System.Drawing.Size(77, 20);
            this.optVlera.TabIndex = 0;
            this.optVlera.TabStop = true;
            this.optVlera.Text = "Ne vlere";
            this.optVlera.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(560, 339);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(74, 45);
            this.btnMinus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "-";
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(560, 218);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 44);
            this.btnPlus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // cboKategorite
            // 
            this.cboKategorite.BackColor = System.Drawing.SystemColors.Window;
            this.cboKategorite.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cboKategorite.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboKategorite.DisplayMember = "PERSHKRIMI";
            this.cboKategorite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboKategorite.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboKategorite.LayoutData = resources.GetString("cboKategorite.LayoutData");
            this.cboKategorite.Location = new System.Drawing.Point(15, 105);
            this.cboKategorite.Name = "cboKategorite";
            this.cboKategorite.Size = new System.Drawing.Size(175, 20);
            this.cboKategorite.TabIndex = 15;
            this.cboKategorite.Value = null;
            this.cboKategorite.ValueMember = "ID_KATEGORIARECETA";
            this.cboKategorite.ValueChanged += new System.EventHandler(this.cboKategorite_ValueChanged);
            // 
            // lblDataOra
            // 
            this.lblDataOra.BackColor = System.Drawing.Color.White;
            this.lblDataOra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDataOra.Location = new System.Drawing.Point(396, 45);
            this.lblDataOra.Name = "lblDataOra";
            this.lblDataOra.Size = new System.Drawing.Size(148, 20);
            this.lblDataOra.TabIndex = 14;
            this.lblDataOra.Text = "12.05.2007  22:00";
            this.lblDataOra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKamarieri
            // 
            this.lblKamarieri.BackColor = System.Drawing.Color.White;
            this.lblKamarieri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKamarieri.Location = new System.Drawing.Point(262, 45);
            this.lblKamarieri.Name = "lblKamarieri";
            this.lblKamarieri.Size = new System.Drawing.Size(115, 20);
            this.lblKamarieri.TabIndex = 12;
            this.lblKamarieri.Text = "Klajdi";
            this.lblKamarieri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kamarieri ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTavolina
            // 
            this.lblTavolina.BackColor = System.Drawing.Color.White;
            this.lblTavolina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTavolina.Location = new System.Drawing.Point(130, 45);
            this.lblTavolina.Name = "lblTavolina";
            this.lblTavolina.Size = new System.Drawing.Size(115, 20);
            this.lblTavolina.TabIndex = 10;
            this.lblTavolina.Text = "12";
            this.lblTavolina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tavolina ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNrFatura
            // 
            this.lblNrFatura.BackColor = System.Drawing.Color.White;
            this.lblNrFatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNrFatura.Location = new System.Drawing.Point(15, 45);
            this.lblNrFatura.Name = "lblNrFatura";
            this.lblNrFatura.Size = new System.Drawing.Size(100, 20);
            this.lblNrFatura.TabIndex = 8;
            this.lblNrFatura.Text = "1545";
            this.lblNrFatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nr. fatura ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridaArtikujt
            // 
            this.gridaArtikujt.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaArtikujt.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaArtikujt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaArtikujt.GridLines = Janus.Windows.GridEX.GridLines.Horizontal;
            this.gridaArtikujt.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaArtikujt.GroupByBoxVisible = false;
            this.gridaArtikujt.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaArtikujt.LayoutData = resources.GetString("gridaArtikujt.LayoutData");
            this.gridaArtikujt.Location = new System.Drawing.Point(13, 134);
            this.gridaArtikujt.Name = "gridaArtikujt";
            this.gridaArtikujt.Size = new System.Drawing.Size(177, 329);
            this.gridaArtikujt.TabIndex = 6;
            this.gridaArtikujt.CellValueChanged += new Janus.Windows.GridEX.ColumnActionEventHandler(this.gridaArtikujt_CellValueChanged);
            this.gridaArtikujt.CurrentCellChanged += new System.EventHandler(this.gridaArtikujt_CurrentCellChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zgjidh kategorine :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnullo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnullo.Image = ((System.Drawing.Image)(resources.GetObject("btnAnullo.Image")));
            this.btnAnullo.Location = new System.Drawing.Point(408, 503);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(100, 35);
            this.btnAnullo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnAnullo.TabIndex = 4;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuaj.Image = ((System.Drawing.Image)(resources.GetObject("btnRuaj.Image")));
            this.btnRuaj.Location = new System.Drawing.Point(250, 503);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(100, 35);
            this.btnRuaj.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnRuaj.TabIndex = 3;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // gridaFatura
            // 
            this.gridaFatura.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridaFatura.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridaFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridaFatura.GridLines = Janus.Windows.GridEX.GridLines.None;
            this.gridaFatura.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridaFatura.GroupByBoxVisible = false;
            this.gridaFatura.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridaFatura.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridaFatura.LayoutData = resources.GetString("gridaFatura.LayoutData");
            this.gridaFatura.Location = new System.Drawing.Point(208, 134);
            this.gridaFatura.Name = "gridaFatura";
            this.gridaFatura.Size = new System.Drawing.Size(336, 329);
            this.gridaFatura.TabIndex = 0;
            this.gridaFatura.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridaFatura.TotalRowFormatStyle.FontSize = 10F;
            this.gridaFatura.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // frmModifikoFature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 564);
            this.Controls.Add(this.panelBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifikoFature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifiko faturen :";
            this.Load += new System.EventHandler(this.frmModifikoFature_Load);
            this.panelBack.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridaArtikujt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridaFatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelBack;
        private Janus.Windows.GridEX.GridEX gridaFatura;
        private DevComponents.DotNetBar.ButtonX btnAnullo;
        private DevComponents.DotNetBar.ButtonX btnRuaj;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.GridEX gridaArtikujt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNrFatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTavolina;
        private System.Windows.Forms.Label lblDataOra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKamarieri;
        private System.Windows.Forms.Label label6;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboKategorite;
        private DevComponents.DotNetBar.ButtonX btnPlus;
        private DevComponents.DotNetBar.ButtonX btnMinus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optPerqindja;
        private System.Windows.Forms.RadioButton optVlera;
        private System.Windows.Forms.TextBox txtSkonto;
    }
}