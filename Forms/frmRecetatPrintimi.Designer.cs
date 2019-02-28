namespace ResManagerAdmin.Forms
{
    partial class frmRecetatPrintimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecetatPrintimi));
            this.paneli = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnDil = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnullo = new DevComponents.DotNetBar.ButtonX();
            this.btnRuaj = new DevComponents.DotNetBar.ButtonX();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.cboPrinteri = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.paneli.Controls.Add(this.chkSelectAll);
            this.paneli.Controls.Add(this.btnDil);
            this.paneli.Controls.Add(this.label1);
            this.paneli.Controls.Add(this.btnAnullo);
            this.paneli.Controls.Add(this.btnRuaj);
            this.paneli.Controls.Add(this.grida);
            this.paneli.Controls.Add(this.cboPrinteri);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.ExpandButtonVisible = false;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(800, 600);
            this.paneli.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.paneli.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.paneli.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.paneli.Style.BorderColor.Color = System.Drawing.Color.Navy;
            this.paneli.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.paneli.Style.GradientAngle = 90;
            this.paneli.TabIndex = 0;
            this.paneli.TitleHeight = 30;
            this.paneli.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.paneli.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(148)))));
            this.paneli.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.paneli.TitleStyle.BorderColor.Color = System.Drawing.Color.Navy;
            this.paneli.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneli.TitleStyle.ForeColor.Color = System.Drawing.Color.White;
            this.paneli.TitleStyle.GradientAngle = 90;
            this.paneli.TitleText = "Recetat per printer";
            // 
            // btnDil
            // 
            this.btnDil.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnDil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDil.Image = ((System.Drawing.Image)(resources.GetObject("btnDil.Image")));
            this.btnDil.Location = new System.Drawing.Point(479, 544);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(110, 35);
            this.btnDil.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnDil.TabIndex = 7;
            this.btnDil.Text = "Dil";
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Printeri i zgjedhur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnullo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnullo.Image = ((System.Drawing.Image)(resources.GetObject("btnAnullo.Image")));
            this.btnAnullo.Location = new System.Drawing.Point(342, 544);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(110, 35);
            this.btnAnullo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnullo.TabIndex = 4;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.btnRuaj.Location = new System.Drawing.Point(202, 544);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(110, 35);
            this.btnRuaj.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnRuaj.TabIndex = 3;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // grida
            // 
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.HeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(202, 133);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(387, 392);
            this.grida.TabIndex = 2;
            // 
            // cboPrinteri
            // 
            this.cboPrinteri.BackColor = System.Drawing.SystemColors.Window;
            this.cboPrinteri.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cboPrinteri.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboPrinteri.DisplayMember = "PRINTERI";
            this.cboPrinteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrinteri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboPrinteri.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboPrinteri.LayoutData = resources.GetString("cboPrinteri.LayoutData");
            this.cboPrinteri.Location = new System.Drawing.Point(271, 70);
            this.cboPrinteri.Name = "cboPrinteri";
            this.cboPrinteri.Size = new System.Drawing.Size(252, 22);
            this.cboPrinteri.TabIndex = 1;
            this.cboPrinteri.Value = null;
            this.cboPrinteri.ValueMember = "PRINTERI";
            this.cboPrinteri.ValueChanged += new System.EventHandler(this.cboPrinteri_ValueChanged);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAll.ForeColor = System.Drawing.Color.Black;
            this.chkSelectAll.Location = new System.Drawing.Point(511, 107);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(119, 24);
            this.chkSelectAll.TabIndex = 8;
            this.chkSelectAll.Text = "Te gjitha";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // frmRecetatPrintimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecetatPrintimi";
            this.Text = "frmRecetatPrintimi";
            this.Load += new System.EventHandler(this.frmRecetatPrintimi_Load);
            this.paneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel paneli;
        private Janus.Windows.GridEX.GridEX grida;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboPrinteri;
        private DevComponents.DotNetBar.ButtonX btnAnullo;
        private DevComponents.DotNetBar.ButtonX btnRuaj;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnDil;
        private System.Windows.Forms.CheckBox chkSelectAll;
    }
}