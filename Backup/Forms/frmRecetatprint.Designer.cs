namespace ResManagerAdmin.Forms
{
    partial class frmRecetatprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecetatprint));
            this.paneli = new System.Windows.Forms.Panel();
            this.multiColumnCombo1 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.paneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paneli.Controls.Add(this.multiColumnCombo1);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(1012, 586);
            this.paneli.TabIndex = 0;
            // 
            // multiColumnCombo1
            // 
            this.multiColumnCombo1.BackColor = System.Drawing.SystemColors.Window;
            this.multiColumnCombo1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.multiColumnCombo1.DisplayMember = "";
            this.multiColumnCombo1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.multiColumnCombo1.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.multiColumnCombo1.LayoutData = resources.GetString("multiColumnCombo1.LayoutData");
            this.multiColumnCombo1.Location = new System.Drawing.Point(178, 83);
            this.multiColumnCombo1.Name = "multiColumnCombo1";
            this.multiColumnCombo1.Size = new System.Drawing.Size(75, 20);
            this.multiColumnCombo1.TabIndex = 0;
            this.multiColumnCombo1.Text = "multiColumnCombo1";
            this.multiColumnCombo1.Value = "";
            this.multiColumnCombo1.ValueMember = "";
            // 
            // frmRecetatprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 586);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecetatprint";
            this.Text = "Recetat printeri ";
            this.paneli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneli;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo multiColumnCombo1;
    }
}