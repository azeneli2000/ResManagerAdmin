namespace ResManagerAdmin.Forms
{
    partial class NumriSerial
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInfoEmail = new System.Windows.Forms.LinkLabel();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfoTel = new System.Windows.Forms.Label();
            this.txtNrPerRregjistrim = new System.Windows.Forms.TextBox();
            this.btnRregjistro = new System.Windows.Forms.Button();
            this.btnMbyll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(383, 51);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Per te kryer rregjistrimin e programit tuaj, ju lutemi kontaktoni ne adresen e e-" +
                "mailit:\r\ndhe dergoni numrin me poshte:";
            // 
            // lblInfoEmail
            // 
            this.lblInfoEmail.AutoSize = true;
            this.lblInfoEmail.Location = new System.Drawing.Point(51, 22);
            this.lblInfoEmail.Name = "lblInfoEmail";
            this.lblInfoEmail.Size = new System.Drawing.Size(138, 13);
            this.lblInfoEmail.TabIndex = 1;
            this.lblInfoEmail.TabStop = true;
            this.lblInfoEmail.Text = "info@visioninfosolution.com";
            this.lblInfoEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInfoEmail_LinkClicked);
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(185, 22);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(125, 13);
            this.lblInfo2.TabIndex = 2;
            this.lblInfo2.Text = "ose ne numrin e telefonit:";
            // 
            // lblInfoTel
            // 
            this.lblInfoTel.AutoSize = true;
            this.lblInfoTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTel.Location = new System.Drawing.Point(305, 22);
            this.lblInfoTel.Name = "lblInfoTel";
            this.lblInfoTel.Size = new System.Drawing.Size(100, 13);
            this.lblInfoTel.TabIndex = 3;
            this.lblInfoTel.Text = "(+355) 69 20 99613";
            // 
            // txtNrPerRregjistrim
            // 
            this.txtNrPerRregjistrim.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNrPerRregjistrim.Location = new System.Drawing.Point(26, 63);
            this.txtNrPerRregjistrim.Name = "txtNrPerRregjistrim";
            this.txtNrPerRregjistrim.ReadOnly = true;
            this.txtNrPerRregjistrim.Size = new System.Drawing.Size(369, 22);
            this.txtNrPerRregjistrim.TabIndex = 4;
            // 
            // btnRregjistro
            // 
            this.btnRregjistro.Location = new System.Drawing.Point(88, 102);
            this.btnRregjistro.Name = "btnRregjistro";
            this.btnRregjistro.Size = new System.Drawing.Size(75, 23);
            this.btnRregjistro.TabIndex = 5;
            this.btnRregjistro.Text = "Rregjistro";
            this.btnRregjistro.UseVisualStyleBackColor = true;
            this.btnRregjistro.Click += new System.EventHandler(this.btnRregjistro_Click);
            // 
            // btnMbyll
            // 
            this.btnMbyll.Location = new System.Drawing.Point(222, 102);
            this.btnMbyll.Name = "btnMbyll";
            this.btnMbyll.Size = new System.Drawing.Size(75, 23);
            this.btnMbyll.TabIndex = 6;
            this.btnMbyll.Text = "Mbyll";
            this.btnMbyll.UseVisualStyleBackColor = true;
            this.btnMbyll.Click += new System.EventHandler(this.btnMbyll_Click);
            // 
            // NumriSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 148);
            this.Controls.Add(this.btnMbyll);
            this.Controls.Add(this.btnRregjistro);
            this.Controls.Add(this.txtNrPerRregjistrim);
            this.Controls.Add(this.lblInfoTel);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfoEmail);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumriSerial";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numri i nevojshem per aktivizim";
            this.Load += new System.EventHandler(this.NumriSerial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.LinkLabel lblInfoEmail;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfoTel;
        private System.Windows.Forms.TextBox txtNrPerRregjistrim;
        private System.Windows.Forms.Button btnRregjistro;
        private System.Windows.Forms.Button btnMbyll;
    }
}