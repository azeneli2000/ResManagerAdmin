namespace ResManagerAdmin.Forms
{
    partial class frmKerkoKategoriteArtikuj
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
            this.components = new System.ComponentModel.Container();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRuajPerberesRi = new System.Windows.Forms.Button();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.lbKategorite = new System.Windows.Forms.ListBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.btnOk);
            this.panelEx1.Controls.Add(this.btnRuajPerberesRi);
            this.panelEx1.Controls.Add(this.btnAnullo);
            this.panelEx1.Controls.Add(this.lbKategorite);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(297, 354);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Kategoritë e artikujve";
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Navy;
            this.btnOk.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(47, 314);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(68, 28);
            this.btnOk.TabIndex = 26;
            this.btnOk.Text = "Ok";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRuajPerberesRi
            // 
            this.btnRuajPerberesRi.ForeColor = System.Drawing.Color.Navy;
            this.btnRuajPerberesRi.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.btnRuajPerberesRi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajPerberesRi.Location = new System.Drawing.Point(-130, 121);
            this.btnRuajPerberesRi.Name = "btnRuajPerberesRi";
            this.btnRuajPerberesRi.Size = new System.Drawing.Size(75, 37);
            this.btnRuajPerberesRi.TabIndex = 21;
            this.btnRuajPerberesRi.Text = "Ok";
            this.btnRuajPerberesRi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuajPerberesRi.UseVisualStyleBackColor = true;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(189, 314);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(68, 28);
            this.btnAnullo.TabIndex = 22;
            this.btnAnullo.Text = "Dil";
            this.btnAnullo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // lbKategorite
            // 
            this.lbKategorite.DisplayMember = "PERSHKRIMI";
            this.lbKategorite.FormattingEnabled = true;
            this.lbKategorite.Location = new System.Drawing.Point(12, 27);
            this.lbKategorite.Name = "lbKategorite";
            this.lbKategorite.Size = new System.Drawing.Size(268, 277);
            this.lbKategorite.TabIndex = 0;
            this.lbKategorite.ValueMember = "ID_KATEGORIAARTIKULLI";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmKerkoKategoriteArtikuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 354);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKerkoKategoriteArtikuj";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zgjidhni një prej kategorive";
            this.Load += new System.EventHandler(this.frmKerkoKategoriteArtikuj_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.ListBox lbKategorite;
        private System.Windows.Forms.Button btnRuajPerberesRi;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error1;
    }
}