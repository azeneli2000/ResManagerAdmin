namespace ResManagerAdmin.Forms
{
    partial class frmFormatPagesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormatPagesa));
            this.gridEXKategorite = new Janus.Windows.GridEX.GridEX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.uiTab = new VisionInfoSolutionLibrary.TabControl();
            this.uiTabPage = new VisionInfoSolutionLibrary.TabPageControl();
            this.label3 = new System.Windows.Forms.Label();
            this.numKomisioni = new VisionInfoSolutionLibrary.NumericBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnRuajKrijo = new VisionInfoSolutionLibrary.Button();
            this.btnRuaj = new VisionInfoSolutionLibrary.Button();
            this.txtEmri = new VisionInfoSolutionLibrary.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnFundit = new System.Windows.Forms.Button();
            this.btnPAs = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.btnPari = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnKerko = new System.Windows.Forms.Button();
            this.btnFshi = new System.Windows.Forms.Button();
            this.btnModifiko = new System.Windows.Forms.Button();
            this.btnShto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXKategorite)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab)).BeginInit();
            this.uiTab.SuspendLayout();
            this.uiTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKomisioni)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEXKategorite
            // 
            this.gridEXKategorite.AcceptsEscape = false;
            this.gridEXKategorite.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEXKategorite.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEXKategorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXKategorite.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridEXKategorite.GroupByBoxVisible = false;
            this.gridEXKategorite.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridEXKategorite.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEXKategorite.LayoutData = resources.GetString("gridEXKategorite.LayoutData");
            this.gridEXKategorite.Location = new System.Drawing.Point(12, 67);
            this.gridEXKategorite.Name = "gridEXKategorite";
            this.gridEXKategorite.Size = new System.Drawing.Size(387, 282);
            this.gridEXKategorite.TabIndex = 0;
            this.gridEXKategorite.CurrentCellChanged += new System.EventHandler(this.gridEXKategorite_CurrentCellChanged);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.uiTab);
            this.panelEx1.Controls.Add(this.panelBottom);
            this.panelEx1.Controls.Add(this.panelTop);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(411, 411);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // uiTab
            // 
            this.uiTab.Controls.Add(this.uiTabPage);
            this.uiTab.Location = new System.Drawing.Point(12, 81);
            this.uiTab.Name = "uiTab";
            this.uiTab.SelectedIndex = 0;
            this.uiTab.Size = new System.Drawing.Size(353, 268);
            this.uiTab.TabIndex = 2;
            this.uiTab.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage});
            this.uiTab.Visible = false;
            // 
            // uiTabPage
            // 
            this.uiTabPage.Controls.Add(this.label3);
            this.uiTabPage.Controls.Add(this.numKomisioni);
            this.uiTabPage.Controls.Add(this.label2);
            this.uiTabPage.Controls.Add(this.btnAnullo);
            this.uiTabPage.Controls.Add(this.btnRuajKrijo);
            this.uiTabPage.Controls.Add(this.btnRuaj);
            this.uiTabPage.Controls.Add(this.txtEmri);
            this.uiTabPage.Controls.Add(this.label1);
            this.uiTabPage.Image = global::ResManagerAdmin.Properties.Resources.news_info;
            this.uiTabPage.IsValid = true;
            this.uiTabPage.Location = new System.Drawing.Point(1, 23);
            this.uiTabPage.Name = "uiTabPage";
            this.uiTabPage.Size = new System.Drawing.Size(349, 242);
            this.uiTabPage.TabIndex = 0;
            this.uiTabPage.Text = "Shtim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Emri i formës së pagesës";
            // 
            // numKomisioni
            // 
            this.numKomisioni.DecimalPlaces = 2;
            this.numKomisioni.DefaultErrorMessage = "Komisioni i formës së pagesës nuk mund të jetë bosh!";
            this.numKomisioni.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numKomisioni.IsValid = true;
            this.numKomisioni.Location = new System.Drawing.Point(7, 121);
            this.numKomisioni.Name = "numKomisioni";
            this.numKomisioni.Required = true;
            this.numKomisioni.Size = new System.Drawing.Size(180, 20);
            this.numKomisioni.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Komisioni në përqindje";
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(264, 131);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 37);
            this.btnAnullo.TabIndex = 5;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuajKrijo
            // 
            this.btnRuajKrijo.DoValidation = true;
            this.btnRuajKrijo.ForeColor = System.Drawing.Color.Navy;
            this.btnRuajKrijo.Image = global::ResManagerAdmin.Properties.Resources.save_new;
            this.btnRuajKrijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajKrijo.Location = new System.Drawing.Point(264, 86);
            this.btnRuajKrijo.Name = "btnRuajKrijo";
            this.btnRuajKrijo.ParentToValidate = this.uiTabPage;
            this.btnRuajKrijo.Size = new System.Drawing.Size(75, 37);
            this.btnRuajKrijo.TabIndex = 4;
            this.btnRuajKrijo.Text = "Ruaj && Krijo";
            this.btnRuajKrijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajKrijo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuajKrijo.UseVisualStyleBackColor = true;
            this.btnRuajKrijo.Click += new System.EventHandler(this.btnRuajKrijo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.DoValidation = true;
            this.btnRuaj.ForeColor = System.Drawing.Color.Navy;
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.save;
            this.btnRuaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuaj.Location = new System.Drawing.Point(264, 42);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.ParentToValidate = this.uiTabPage;
            this.btnRuaj.Size = new System.Drawing.Size(75, 37);
            this.btnRuaj.TabIndex = 3;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // txtEmri
            // 
            this.txtEmri.DefaultErrorMessage = "Emri i formës së pagesës nuk mund të jetë bosh!";
            this.txtEmri.IsValid = false;
            this.txtEmri.Location = new System.Drawing.Point(7, 72);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Required = true;
            this.txtEmri.Size = new System.Drawing.Size(180, 20);
            this.txtEmri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 55);
            this.label1.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Controls.Add(this.btnFundit);
            this.panelBottom.Controls.Add(this.btnPAs);
            this.panelBottom.Controls.Add(this.btnPara);
            this.panelBottom.Controls.Add(this.btnPari);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 355);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(411, 56);
            this.panelBottom.TabIndex = 1;
            // 
            // btnFundit
            // 
            this.btnFundit.ForeColor = System.Drawing.Color.Navy;
            this.btnFundit.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_fundit;
            this.btnFundit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFundit.Location = new System.Drawing.Point(322, 7);
            this.btnFundit.Name = "btnFundit";
            this.btnFundit.Size = new System.Drawing.Size(75, 37);
            this.btnFundit.TabIndex = 7;
            this.btnFundit.Text = "I fundit";
            this.btnFundit.UseVisualStyleBackColor = true;
            this.btnFundit.Click += new System.EventHandler(this.btnFundit_Click);
            // 
            // btnPAs
            // 
            this.btnPAs.ForeColor = System.Drawing.Color.Navy;
            this.btnPAs.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_djathtas;
            this.btnPAs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPAs.Location = new System.Drawing.Point(220, 7);
            this.btnPAs.Name = "btnPAs";
            this.btnPAs.Size = new System.Drawing.Size(75, 37);
            this.btnPAs.TabIndex = 6;
            this.btnPAs.Text = "Pas";
            this.btnPAs.UseVisualStyleBackColor = true;
            this.btnPAs.Click += new System.EventHandler(this.btnPAs_Click);
            // 
            // btnPara
            // 
            this.btnPara.ForeColor = System.Drawing.Color.Navy;
            this.btnPara.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_majtas;
            this.btnPara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPara.Location = new System.Drawing.Point(115, 7);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(75, 37);
            this.btnPara.TabIndex = 5;
            this.btnPara.Text = "Para";
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // btnPari
            // 
            this.btnPari.ForeColor = System.Drawing.Color.Navy;
            this.btnPari.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_pari;
            this.btnPari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPari.Location = new System.Drawing.Point(11, 7);
            this.btnPari.Name = "btnPari";
            this.btnPari.Size = new System.Drawing.Size(75, 37);
            this.btnPari.TabIndex = 4;
            this.btnPari.Text = "I pari";
            this.btnPari.UseVisualStyleBackColor = true;
            this.btnPari.Click += new System.EventHandler(this.btnPari_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.btnKerko);
            this.panelTop.Controls.Add(this.btnFshi);
            this.panelTop.Controls.Add(this.btnModifiko);
            this.panelTop.Controls.Add(this.btnShto);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(411, 56);
            this.panelTop.TabIndex = 0;
            // 
            // btnKerko
            // 
            this.btnKerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerko.ForeColor = System.Drawing.Color.Navy;
            this.btnKerko.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerko.Location = new System.Drawing.Point(322, 7);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(75, 37);
            this.btnKerko.TabIndex = 3;
            this.btnKerko.Text = "Kërko";
            this.btnKerko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // btnFshi
            // 
            this.btnFshi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFshi.ForeColor = System.Drawing.Color.Navy;
            this.btnFshi.Image = global::ResManagerAdmin.Properties.Resources.cancelbuild;
            this.btnFshi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshi.Location = new System.Drawing.Point(220, 7);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(75, 37);
            this.btnFshi.TabIndex = 2;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFshi.UseVisualStyleBackColor = true;
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // btnModifiko
            // 
            this.btnModifiko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifiko.ForeColor = System.Drawing.Color.Navy;
            this.btnModifiko.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.btnModifiko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifiko.Location = new System.Drawing.Point(115, 7);
            this.btnModifiko.Name = "btnModifiko";
            this.btnModifiko.Size = new System.Drawing.Size(75, 37);
            this.btnModifiko.TabIndex = 1;
            this.btnModifiko.Text = "Modifiko";
            this.btnModifiko.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifiko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifiko.UseVisualStyleBackColor = true;
            this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
            // 
            // btnShto
            // 
            this.btnShto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShto.ForeColor = System.Drawing.Color.Navy;
            this.btnShto.Image = global::ResManagerAdmin.Properties.Resources.news_info;
            this.btnShto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShto.Location = new System.Drawing.Point(11, 7);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(75, 37);
            this.btnShto.TabIndex = 0;
            this.btnShto.Text = "Shto";
            this.btnShto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // frmFormatPagesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(411, 411);
            this.Controls.Add(this.gridEXKategorite);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormatPagesa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Konfigurimi i formave të pagesës";
            this.Load += new System.EventHandler(this.frmFormatPagesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXKategorite)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTab)).EndInit();
            this.uiTab.ResumeLayout(false);
            this.uiTabPage.ResumeLayout(false);
            this.uiTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKomisioni)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEXKategorite;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnFshi;
        private System.Windows.Forms.Button btnModifiko;
        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnFundit;
        private System.Windows.Forms.Button btnPAs;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Button btnPari;
        private System.Windows.Forms.Button btnKerko;
        private VisionInfoSolutionLibrary.TabControl uiTab;
        private VisionInfoSolutionLibrary.TabPageControl uiTabPage;
        private System.Windows.Forms.Button btnAnullo;
        private VisionInfoSolutionLibrary.Button btnRuajKrijo;
        private VisionInfoSolutionLibrary.Button btnRuaj;
        private VisionInfoSolutionLibrary.TextBox txtEmri;
        private System.Windows.Forms.Label label1;
        private VisionInfoSolutionLibrary.NumericBox numKomisioni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}