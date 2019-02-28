namespace ResManagerAdmin.Forms
{
    partial class frmZgjidhOpsionFshiFurnitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZgjidhOpsionFshiFurnitor));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnOk = new System.Windows.Forms.Button();
            this.rbAnullo = new System.Windows.Forms.RadioButton();
            this.rbFshiTeGjithe = new System.Windows.Forms.RadioButton();
            this.rbFshiDisa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnOk);
            this.panelEx1.Controls.Add(this.rbAnullo);
            this.panelEx1.Controls.Add(this.rbFshiTeGjithe);
            this.panelEx1.Controls.Add(this.rbFshiDisa);
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Controls.Add(this.uiGroupBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(326, 245);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Navy;
            this.btnOk.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(130, 200);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 30);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "Ok";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rbAnullo
            // 
            this.rbAnullo.AutoSize = true;
            this.rbAnullo.Location = new System.Drawing.Point(62, 164);
            this.rbAnullo.Name = "rbAnullo";
            this.rbAnullo.Size = new System.Drawing.Size(93, 17);
            this.rbAnullo.TabIndex = 4;
            this.rbAnullo.Text = "Anullo fshirjen.";
            this.rbAnullo.UseVisualStyleBackColor = true;
            // 
            // rbFshiTeGjithe
            // 
            this.rbFshiTeGjithe.Location = new System.Drawing.Point(62, 118);
            this.rbFshiTeGjithe.Name = "rbFshiTeGjithe";
            this.rbFshiTeGjithe.Size = new System.Drawing.Size(252, 36);
            this.rbFshiTeGjithe.TabIndex = 3;
            this.rbFshiTeGjithe.Text = "Fshi të gjithë furnitorët e zgjedhur dhe fshi referencat përkatëse në regjistrime" +
                "t e blerjeve.";
            this.rbFshiTeGjithe.UseVisualStyleBackColor = true;
            // 
            // rbFshiDisa
            // 
            this.rbFshiDisa.Checked = true;
            this.rbFshiDisa.Location = new System.Drawing.Point(62, 69);
            this.rbFshiDisa.Name = "rbFshiDisa";
            this.rbFshiDisa.Size = new System.Drawing.Size(249, 43);
            this.rbFshiDisa.TabIndex = 2;
            this.rbFshiDisa.TabStop = true;
            this.rbFshiDisa.Text = "Fshi vetëm furnitorët për të cilët nuk janë regjistruar  blerje. ";
            this.rbFshiDisa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Për ndonjë prej furnitorëve të zgjedhur mund të jenë regjistruar blerje. Zgjidhni" +
                " një prej opsioneve më poshtë për të vendosur se si do të veproni më tej.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.FrameStyle = Janus.Windows.EditControls.FrameStyle.None;
            this.uiGroupBox1.Icon = ((System.Drawing.Icon)(resources.GetObject("uiGroupBox1.Icon")));
            this.uiGroupBox1.Location = new System.Drawing.Point(15, 26);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(52, 33);
            this.uiGroupBox1.TabIndex = 24;
            // 
            // frmZgjidhOpsionFshiFurnitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 245);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmZgjidhOpsionFshiFurnitor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zgjidhni një prej opsioneve";
            this.Load += new System.EventHandler(this.frmZgjidhOpsionFshiFurnitor_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.RadioButton rbAnullo;
        public System.Windows.Forms.RadioButton rbFshiTeGjithe;
        public System.Windows.Forms.RadioButton rbFshiDisa;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
    }
}