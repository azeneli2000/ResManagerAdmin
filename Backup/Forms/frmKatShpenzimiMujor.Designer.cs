namespace ResManagerAdmin.Forms
{
    partial class frmKatShpenzimiMujor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKatShpenzimiMujor));
            this.panelBack = new DevComponents.DotNetBar.PanelEx();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.panelTop = new System.Windows.Forms.Panel();
            this.grTop = new Janus.Windows.EditControls.UIGroupBox();
            this.btnFshi = new System.Windows.Forms.Button();
            this.btnShto = new System.Windows.Forms.Button();
            this.btnModifiko = new System.Windows.Forms.Button();
            this.tabi = new Janus.Windows.UI.Tab.UITab();
            this.tabPage = new Janus.Windows.UI.Tab.UITabPage();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTop)).BeginInit();
            this.grTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabi)).BeginInit();
            this.tabi.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelBack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelBack.Controls.Add(this.grida);
            this.panelBack.Controls.Add(this.panelTop);
            this.panelBack.Controls.Add(this.tabi);
            this.panelBack.Location = new System.Drawing.Point(-4, -3);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(484, 463);
            this.panelBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelBack.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelBack.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelBack.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelBack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelBack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelBack.Style.GradientAngle = 90;
            this.panelBack.TabIndex = 0;
            // 
            // grida
            // 
            this.grida.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(30, 75);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(433, 347);
            this.grida.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.grTop);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(484, 69);
            this.panelTop.TabIndex = 1;
            // 
            // grTop
            // 
            this.grTop.BackColor = System.Drawing.Color.White;
            this.grTop.Controls.Add(this.btnFshi);
            this.grTop.Controls.Add(this.btnShto);
            this.grTop.Controls.Add(this.btnModifiko);
            this.grTop.FrameStyle = Janus.Windows.EditControls.FrameStyle.None;
            this.grTop.Location = new System.Drawing.Point(3, 3);
            this.grTop.Name = "grTop";
            this.grTop.Size = new System.Drawing.Size(478, 55);
            this.grTop.TabIndex = 3;
            this.grTop.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnFshi
            // 
            this.btnFshi.ForeColor = System.Drawing.Color.Navy;
            this.btnFshi.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnFshi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshi.Location = new System.Drawing.Point(375, 12);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(85, 35);
            this.btnFshi.TabIndex = 2;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.UseVisualStyleBackColor = true;
            // 
            // btnShto
            // 
            this.btnShto.ForeColor = System.Drawing.Color.Navy;
            this.btnShto.Image = global::ResManagerAdmin.Properties.Resources.news_info;
            this.btnShto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShto.Location = new System.Drawing.Point(27, 12);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(85, 35);
            this.btnShto.TabIndex = 0;
            this.btnShto.Text = "Shto";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // btnModifiko
            // 
            this.btnModifiko.ForeColor = System.Drawing.Color.Navy;
            this.btnModifiko.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.btnModifiko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifiko.Location = new System.Drawing.Point(209, 12);
            this.btnModifiko.Name = "btnModifiko";
            this.btnModifiko.Size = new System.Drawing.Size(85, 35);
            this.btnModifiko.TabIndex = 1;
            this.btnModifiko.Text = "Modifiko";
            this.btnModifiko.UseVisualStyleBackColor = true;
            this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
            // 
            // tabi
            // 
            this.tabi.Controls.Add(this.tabPage);
            this.tabi.Location = new System.Drawing.Point(45, 85);
            this.tabi.Name = "tabi";
            this.tabi.SelectedIndex = 0;
            this.tabi.Size = new System.Drawing.Size(398, 325);
            this.tabi.TabIndex = 0;
            this.tabi.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.tabPage});
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.btnAnullo);
            this.tabPage.Controls.Add(this.btnRuaj);
            this.tabPage.Controls.Add(this.txtPershkrimi);
            this.tabPage.Controls.Add(this.label2);
            this.tabPage.Controls.Add(this.txtEmri);
            this.tabPage.Controls.Add(this.label1);
            this.tabPage.Location = new System.Drawing.Point(1, 21);
            this.tabPage.Name = "tabPage";
            this.tabPage.Size = new System.Drawing.Size(394, 301);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Shtim";
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.cancelbuild;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(259, 221);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(80, 35);
            this.btnAnullo.TabIndex = 5;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.ForeColor = System.Drawing.Color.Navy;
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.save;
            this.btnRuaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuaj.Location = new System.Drawing.Point(144, 221);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(80, 35);
            this.btnRuaj.TabIndex = 4;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Location = new System.Drawing.Point(132, 77);
            this.txtPershkrimi.Multiline = true;
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(227, 93);
            this.txtPershkrimi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pershkrimi :";
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(132, 42);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(227, 20);
            this.txtEmri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emri :";
            // 
            // frmKatShpenzimiMujor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 459);
            this.Controls.Add(this.panelBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKatShpenzimiMujor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategorite e shpenzimeve mujore";
            this.Load += new System.EventHandler(this.frmKatShpenzimiMujor_Load);
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grTop)).EndInit();
            this.grTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabi)).EndInit();
            this.tabi.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelBack;
        private Janus.Windows.UI.Tab.UITab tabi;
        private Janus.Windows.UI.Tab.UITabPage tabPage;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnFshi;
        private System.Windows.Forms.Button btnModifiko;
        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.Button btnRuaj;
        private Janus.Windows.GridEX.GridEX grida;
        private Janus.Windows.EditControls.UIGroupBox grTop;
    }
}