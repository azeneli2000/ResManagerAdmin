namespace ResManagerAdmin.Forms
{
    partial class frmZgjidhPrintiminXhiro
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnDil = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.rbDetaje = new System.Windows.Forms.RadioButton();
            this.rbDitet = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnDil);
            this.panelEx1.Controls.Add(this.btnOk);
            this.panelEx1.Controls.Add(this.rbDetaje);
            this.panelEx1.Controls.Add(this.rbDitet);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(363, 179);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // btnDil
            // 
            this.btnDil.ForeColor = System.Drawing.Color.Navy;
            this.btnDil.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnDil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDil.Location = new System.Drawing.Point(255, 129);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(66, 28);
            this.btnDil.TabIndex = 4;
            this.btnDil.Text = "Dil";
            this.btnDil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDil.UseVisualStyleBackColor = true;
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Navy;
            this.btnOk.Image = global::ResManagerAdmin.Properties.Resources.button_ok1;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(41, 129);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(66, 28);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rbDetaje
            // 
            this.rbDetaje.AutoSize = true;
            this.rbDetaje.Location = new System.Drawing.Point(41, 95);
            this.rbDetaje.Name = "rbDetaje";
            this.rbDetaje.Size = new System.Drawing.Size(231, 17);
            this.rbDetaje.TabIndex = 2;
            this.rbDetaje.TabStop = true;
            this.rbDetaje.Text = "Xhiro e detajuar vetëm për datën e zgjedhur";
            this.rbDetaje.UseVisualStyleBackColor = true;
            // 
            // rbDitet
            // 
            this.rbDitet.AutoSize = true;
            this.rbDitet.Checked = true;
            this.rbDitet.Location = new System.Drawing.Point(41, 60);
            this.rbDitet.Name = "rbDitet";
            this.rbDitet.Size = new System.Drawing.Size(157, 17);
            this.rbDitet.TabIndex = 1;
            this.rbDitet.TabStop = true;
            this.rbDitet.Text = "Xhiro për intervalin e datave";
            this.rbDitet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zgjidhni se cilën prej tabelave doni të printoni:";
            // 
            // frmZgjidhPrintiminXhiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 179);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmZgjidhPrintiminXhiro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zgjidh";
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Button btnDil;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rbDetaje;
        private System.Windows.Forms.RadioButton rbDitet;
        public System.Windows.Forms.Label label1;
    }
}