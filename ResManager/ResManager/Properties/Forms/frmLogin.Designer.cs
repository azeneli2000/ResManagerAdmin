namespace ResManager.Forms
{
    partial class frmLogin
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
            this.pictureBoxPerdoruesi = new System.Windows.Forms.PictureBox();
            this.pictureBoxFjalekalimi = new System.Windows.Forms.PictureBox();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtFjalekalimi = new System.Windows.Forms.TextBox();
            this.txtPerdoruesi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerdoruesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFjalekalimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.pictureBoxPerdoruesi);
            this.panelEx1.Controls.Add(this.pictureBoxFjalekalimi);
            this.panelEx1.Controls.Add(this.btnAnullo);
            this.panelEx1.Controls.Add(this.btnOk);
            this.panelEx1.Controls.Add(this.txtFjalekalimi);
            this.panelEx1.Controls.Add(this.txtPerdoruesi);
            this.panelEx1.Controls.Add(this.label2);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(239, 192);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // pictureBoxPerdoruesi
            // 
            this.pictureBoxPerdoruesi.Image = global::ResManager.Properties.Resources.Client;
            this.pictureBoxPerdoruesi.Location = new System.Drawing.Point(28, 33);
            this.pictureBoxPerdoruesi.Name = "pictureBoxPerdoruesi";
            this.pictureBoxPerdoruesi.Size = new System.Drawing.Size(27, 20);
            this.pictureBoxPerdoruesi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPerdoruesi.TabIndex = 30;
            this.pictureBoxPerdoruesi.TabStop = false;
            // 
            // pictureBoxFjalekalimi
            // 
            this.pictureBoxFjalekalimi.Image = global::ResManager.Properties.Resources.password;
            this.pictureBoxFjalekalimi.Location = new System.Drawing.Point(28, 93);
            this.pictureBoxFjalekalimi.Name = "pictureBoxFjalekalimi";
            this.pictureBoxFjalekalimi.Size = new System.Drawing.Size(27, 20);
            this.pictureBoxFjalekalimi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFjalekalimi.TabIndex = 29;
            this.pictureBoxFjalekalimi.TabStop = false;
            // 
            // btnAnullo
            // 
            this.btnAnullo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManager.Properties.Resources.delete_button;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(134, 133);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 30);
            this.btnAnullo.TabIndex = 28;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Navy;
            this.btnOk.Image = global::ResManager.Properties.Resources.button_ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(28, 133);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 30);
            this.btnOk.TabIndex = 27;
            this.btnOk.Text = "Ok";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFjalekalimi
            // 
            this.txtFjalekalimi.Location = new System.Drawing.Point(55, 93);
            this.txtFjalekalimi.Name = "txtFjalekalimi";
            this.txtFjalekalimi.PasswordChar = '*';
            this.txtFjalekalimi.Size = new System.Drawing.Size(154, 20);
            this.txtFjalekalimi.TabIndex = 7;
            // 
            // txtPerdoruesi
            // 
            this.txtPerdoruesi.Location = new System.Drawing.Point(55, 33);
            this.txtPerdoruesi.Name = "txtPerdoruesi";
            this.txtPerdoruesi.Size = new System.Drawing.Size(154, 20);
            this.txtPerdoruesi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fjalekalimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Përdoruesi";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnullo;
            this.ClientSize = new System.Drawing.Size(239, 192);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerdoruesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFjalekalimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.TextBox txtFjalekalimi;
        private System.Windows.Forms.TextBox txtPerdoruesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.PictureBox pictureBoxPerdoruesi;
        private System.Windows.Forms.PictureBox pictureBoxFjalekalimi;
        private System.Windows.Forms.ErrorProvider error;
    }
}