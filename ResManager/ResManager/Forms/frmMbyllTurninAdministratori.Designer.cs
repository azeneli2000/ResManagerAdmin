namespace ResManager.Forms
{
    partial class frmMbyllTurninAdministratori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMbyllTurninAdministratori));
            this.paneli = new DevComponents.DotNetBar.PanelEx();
            this.btnDil = new DevComponents.DotNetBar.ButtonX();
            this.btnMbyll = new DevComponents.DotNetBar.ButtonX();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAdministratori = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtFjalekalimi = new System.Windows.Forms.TextBox();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUser = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.paneli.Controls.Add(this.btnDil);
            this.paneli.Controls.Add(this.btnMbyll);
            this.paneli.Controls.Add(this.uiGroupBox2);
            this.paneli.Controls.Add(this.uiGroupBox1);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(518, 381);
            this.paneli.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.paneli.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.paneli.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneli.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.paneli.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.paneli.Style.GradientAngle = 90;
            this.paneli.TabIndex = 0;
            // 
            // btnDil
            // 
            this.btnDil.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnDil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDil.Image = ((System.Drawing.Image)(resources.GetObject("btnDil.Image")));
            this.btnDil.Location = new System.Drawing.Point(285, 295);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(112, 37);
            this.btnDil.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDil.TabIndex = 5;
            this.btnDil.Text = " Dil";
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // btnMbyll
            // 
            this.btnMbyll.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnMbyll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMbyll.Image = ((System.Drawing.Image)(resources.GetObject("btnMbyll.Image")));
            this.btnMbyll.Location = new System.Drawing.Point(131, 295);
            this.btnMbyll.Name = "btnMbyll";
            this.btnMbyll.Size = new System.Drawing.Size(108, 37);
            this.btnMbyll.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnMbyll.TabIndex = 4;
            this.btnMbyll.Text = "  Mbyll";
            this.btnMbyll.Click += new System.EventHandler(this.btnMbyll_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.label3);
            this.uiGroupBox2.Controls.Add(this.label2);
            this.uiGroupBox2.Controls.Add(this.cboAdministratori);
            this.uiGroupBox2.Controls.Add(this.txtFjalekalimi);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox2.Location = new System.Drawing.Point(23, 108);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(468, 130);
            this.uiGroupBox2.TabIndex = 3;
            this.uiGroupBox2.Text = "Verifikimi i administratorit : ";
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fjalekalimi";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Administratori";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAdministratori
            // 
            this.cboAdministratori.BackColor = System.Drawing.SystemColors.Window;
            this.cboAdministratori.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboAdministratori.DisplayMember = "PERDORUESI";
            this.cboAdministratori.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAdministratori.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboAdministratori.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboAdministratori.LayoutData = resources.GetString("cboAdministratori.LayoutData");
            this.cboAdministratori.Location = new System.Drawing.Point(230, 37);
            this.cboAdministratori.Name = "cboAdministratori";
            this.cboAdministratori.Size = new System.Drawing.Size(218, 26);
            this.cboAdministratori.TabIndex = 2;
            this.cboAdministratori.Value = null;
            this.cboAdministratori.ValueMember = "ID_PERSONELI";
            // 
            // txtFjalekalimi
            // 
            this.txtFjalekalimi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFjalekalimi.Location = new System.Drawing.Point(230, 80);
            this.txtFjalekalimi.Name = "txtFjalekalimi";
            this.txtFjalekalimi.PasswordChar = '*';
            this.txtFjalekalimi.Size = new System.Drawing.Size(218, 26);
            this.txtFjalekalimi.TabIndex = 1;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.cboUser);
            this.uiGroupBox1.Location = new System.Drawing.Point(23, 12);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(468, 76);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "Zgjidh kamarierin : ";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kamarieri :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboUser
            // 
            this.cboUser.BackColor = System.Drawing.SystemColors.Window;
            this.cboUser.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cboUser.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboUser.DisplayMember = "PERDORUESI";
            this.cboUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboUser.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboUser.LayoutData = resources.GetString("cboUser.LayoutData");
            this.cboUser.Location = new System.Drawing.Point(230, 29);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(218, 26);
            this.cboUser.TabIndex = 0;
            this.cboUser.Value = null;
            this.cboUser.ValueMember = "ID_PERSONELI";
            // 
            // frmMbyllTurninAdministratori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 381);
            this.Controls.Add(this.paneli);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMbyllTurninAdministratori";
            this.Text = "Mbyllja e turnit nga administratori";
            this.Load += new System.EventHandler(this.frmMbyllTurninAdministratori_Load);
            this.paneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx paneli;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private System.Windows.Forms.TextBox txtFjalekalimi;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboUser;
        private DevComponents.DotNetBar.ButtonX btnDil;
        private DevComponents.DotNetBar.ButtonX btnMbyll;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboAdministratori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}