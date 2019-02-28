namespace ResManagerAdmin.Forms
{
    partial class PrintPromptXhiro
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
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rbMeDetaje = new System.Windows.Forms.RadioButton();
            this.rbPaDetaje = new System.Windows.Forms.RadioButton();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnAnullo);
            this.panelEx1.Controls.Add(this.btnPrint);
            this.panelEx1.Controls.Add(this.rbMeDetaje);
            this.panelEx1.Controls.Add(this.rbPaDetaje);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(394, 140);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Location = new System.Drawing.Point(226, 95);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 23);
            this.btnAnullo.TabIndex = 3;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ForeColor = System.Drawing.Color.Navy;
            this.btnPrint.Location = new System.Drawing.Point(66, 95);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Ok";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // rbMeDetaje
            // 
            this.rbMeDetaje.AutoSize = true;
            this.rbMeDetaje.Location = new System.Drawing.Point(33, 59);
            this.rbMeDetaje.Name = "rbMeDetaje";
            this.rbMeDetaje.Size = new System.Drawing.Size(282, 17);
            this.rbMeDetaje.TabIndex = 1;
            this.rbMeDetaje.TabStop = true;
            this.rbMeDetaje.Text = "Printo raportin e detajuar të xhiros për datën e zgjedhur";
            this.rbMeDetaje.UseVisualStyleBackColor = true;
            // 
            // rbPaDetaje
            // 
            this.rbPaDetaje.AutoSize = true;
            this.rbPaDetaje.Location = new System.Drawing.Point(33, 21);
            this.rbPaDetaje.Name = "rbPaDetaje";
            this.rbPaDetaje.Size = new System.Drawing.Size(304, 17);
            this.rbPaDetaje.TabIndex = 0;
            this.rbPaDetaje.TabStop = true;
            this.rbPaDetaje.Text = "Printo raportin e padetajuar të xhiros per secilen prej datave";
            this.rbPaDetaje.UseVisualStyleBackColor = true;
            // 
            // PrintPromptXhiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 140);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 164);
            this.MinimumSize = new System.Drawing.Size(400, 164);
            this.Name = "PrintPromptXhiro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lloji i raportit";
            this.Load += new System.EventHandler(this.PrintPromptXhiro_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.RadioButton rbMeDetaje;
        private System.Windows.Forms.RadioButton rbPaDetaje;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.Button btnPrint;
    }
}