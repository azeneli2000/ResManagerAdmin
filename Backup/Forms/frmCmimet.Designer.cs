namespace ResManagerAdmin.Forms
{
    partial class frmCmimet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCmimet));
            this.paneli = new DevComponents.DotNetBar.ExpandablePanel();
            this.cboGrupet = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label1 = new System.Windows.Forms.Label();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.btnAnullo = new DevComponents.DotNetBar.ButtonX();
            this.btnRuaj = new DevComponents.DotNetBar.ButtonX();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.Controls.Add(this.cboGrupet);
            this.paneli.Controls.Add(this.label1);
            this.paneli.Controls.Add(this.grida);
            this.paneli.Controls.Add(this.btnAnullo);
            this.paneli.Controls.Add(this.btnRuaj);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.ExpandButtonVisible = false;
            this.paneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(1002, 620);
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
            this.paneli.TitleText = "     Cmimet per recetat";
            // 
            // cboGrupet
            // 
            this.cboGrupet.BackColor = System.Drawing.SystemColors.Window;
            this.cboGrupet.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cboGrupet.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboGrupet.DisplayMember = "KGRUPCMIMI";
            this.cboGrupet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrupet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboGrupet.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboGrupet.LayoutData = resources.GetString("cboGrupet.LayoutData");
            this.cboGrupet.Location = new System.Drawing.Point(384, 70);
            this.cboGrupet.Name = "cboGrupet";
            this.cboGrupet.Size = new System.Drawing.Size(243, 22);
            this.cboGrupet.TabIndex = 6;
            this.cboGrupet.Value = null;
            this.cboGrupet.ValueMember = "ID_GRUPCMIMI";
            this.cboGrupet.ValueChanged += new System.EventHandler(this.cboGrupet_ValueChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grupet e cmimeve";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grida
            // 
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.grida.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(268, 115);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(504, 417);
            this.grida.TabIndex = 4;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnullo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnullo.Image = ((System.Drawing.Image)(resources.GetObject("btnAnullo.Image")));
            this.btnAnullo.Location = new System.Drawing.Point(527, 547);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(100, 35);
            this.btnAnullo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnullo.TabIndex = 3;
            this.btnAnullo.Text = " Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.btnRuaj.Location = new System.Drawing.Point(384, 547);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(100, 35);
            this.btnRuaj.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnRuaj.TabIndex = 2;
            this.btnRuaj.Text = " Ruaj";
            this.btnRuaj.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // frmCmimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 620);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCmimet";
            this.Text = "Cmimet per receta";
            this.Load += new System.EventHandler(this.frmCmimet_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmCmimet_CausesValidationChanged);
            this.paneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel paneli;
        private DevComponents.DotNetBar.ButtonX btnAnullo;
        private DevComponents.DotNetBar.ButtonX btnRuaj;
        private Janus.Windows.GridEX.GridEX grida;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboGrupet;
        private System.Windows.Forms.Label label1;
    }
}