namespace ResManagerAdmin.Forms
{
    partial class frmKonfigurimTavolinash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKonfigurimTavolinash));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.uiTab = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage = new Janus.Windows.UI.Tab.UITabPage();
            this.btnShtoDisa = new System.Windows.Forms.Button();
            this.lblGabimi = new System.Windows.Forms.Label();
            this.numKapaciteti = new VisionInfoSolutionLibrary.NumericBox();
            this.btnRuajKrijo = new VisionInfoSolutionLibrary.Button();
            this.cmbKategorite = new VisionInfoSolutionLibrary.MultiComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnRuaj = new VisionInfoSolutionLibrary.Button();
            this.lblNrTavolinash = new System.Windows.Forms.Label();
            this.numNumerTavolinash = new VisionInfoSolutionLibrary.NumericBox();
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
            this.gridEXTavolinat = new Janus.Windows.GridEX.GridEX();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.numEmri = new System.Windows.Forms.TextBox();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab)).BeginInit();
            this.uiTab.SuspendLayout();
            this.uiTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKapaciteti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerTavolinash)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTavolinat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.uiTab);
            this.panelEx1.Controls.Add(this.panelBottom);
            this.panelEx1.Controls.Add(this.panelTop);
            this.panelEx1.Controls.Add(this.gridEXTavolinat);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(472, 464);
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
            this.uiTab.Location = new System.Drawing.Point(12, 67);
            this.uiTab.Name = "uiTab";
            this.uiTab.SelectedIndex = 0;
            this.uiTab.Size = new System.Drawing.Size(444, 322);
            this.uiTab.TabIndex = 2;
            this.uiTab.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage});
            this.uiTab.Visible = false;
            // 
            // uiTabPage
            // 
            this.uiTabPage.Controls.Add(this.numEmri);
            this.uiTabPage.Controls.Add(this.btnShtoDisa);
            this.uiTabPage.Controls.Add(this.lblGabimi);
            this.uiTabPage.Controls.Add(this.numKapaciteti);
            this.uiTabPage.Controls.Add(this.btnRuajKrijo);
            this.uiTabPage.Controls.Add(this.cmbKategorite);
            this.uiTabPage.Controls.Add(this.label3);
            this.uiTabPage.Controls.Add(this.label2);
            this.uiTabPage.Controls.Add(this.btnAnullo);
            this.uiTabPage.Controls.Add(this.btnRuaj);
            this.uiTabPage.Controls.Add(this.lblNrTavolinash);
            this.uiTabPage.Controls.Add(this.numNumerTavolinash);
            this.uiTabPage.Image = global::ResManagerAdmin.Properties.Resources.news_info;
            this.uiTabPage.Location = new System.Drawing.Point(1, 23);
            this.uiTabPage.Name = "uiTabPage";
            this.uiTabPage.Size = new System.Drawing.Size(440, 296);
            this.uiTabPage.TabIndex = 0;
            this.uiTabPage.Text = "Shtim";
            // 
            // btnShtoDisa
            // 
            this.btnShtoDisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShtoDisa.ForeColor = System.Drawing.Color.Navy;
            this.btnShtoDisa.Image = global::ResManagerAdmin.Properties.Resources.new_disa;
            this.btnShtoDisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShtoDisa.Location = new System.Drawing.Point(64, 262);
            this.btnShtoDisa.Name = "btnShtoDisa";
            this.btnShtoDisa.Size = new System.Drawing.Size(32, 37);
            this.btnShtoDisa.TabIndex = 4;
            this.btnShtoDisa.Text = "Shto disa";
            this.btnShtoDisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShtoDisa.UseVisualStyleBackColor = true;
            this.btnShtoDisa.Visible = false;
            this.btnShtoDisa.Click += new System.EventHandler(this.btnShtoDisa_Click);
            // 
            // lblGabimi
            // 
            this.lblGabimi.BackColor = System.Drawing.Color.Transparent;
            this.lblGabimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGabimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGabimi.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGabimi.Location = new System.Drawing.Point(12, 220);
            this.lblGabimi.Name = "lblGabimi";
            this.lblGabimi.Size = new System.Drawing.Size(336, 25);
            this.lblGabimi.TabIndex = 18;
            this.lblGabimi.Text = "    Mesazh gabimi :";
            this.lblGabimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numKapaciteti
            // 
            this.numKapaciteti.DefaultErrorMessage = "Kapaciteti i tavolinës nuk mund të jetë bosh!";
            this.numKapaciteti.IsValid = true;
            this.numKapaciteti.Location = new System.Drawing.Point(12, 160);
            this.numKapaciteti.Name = "numKapaciteti";
            this.numKapaciteti.Required = true;
            this.numKapaciteti.Size = new System.Drawing.Size(180, 20);
            this.numKapaciteti.TabIndex = 14;
            // 
            // btnRuajKrijo
            // 
            this.btnRuajKrijo.DoValidation = true;
            this.btnRuajKrijo.ForeColor = System.Drawing.Color.Navy;
            this.btnRuajKrijo.Image = global::ResManagerAdmin.Properties.Resources.save_new;
            this.btnRuajKrijo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajKrijo.Location = new System.Drawing.Point(227, 92);
            this.btnRuajKrijo.Name = "btnRuajKrijo";
            this.btnRuajKrijo.ParentToValidate = this.uiTabPage;
            this.btnRuajKrijo.Size = new System.Drawing.Size(75, 37);
            this.btnRuajKrijo.TabIndex = 16;
            this.btnRuajKrijo.Text = "Ruaj && Krijo";
            this.btnRuajKrijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajKrijo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuajKrijo.UseVisualStyleBackColor = true;
            this.btnRuajKrijo.Click += new System.EventHandler(this.btnRuajKrijo_Click);
            // 
            // cmbKategorite
            // 
            this.cmbKategorite.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKategorite.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbKategorite.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbKategorite.DefaultErrorMessage = "Zgjidhni një prej kategorive!";
            this.cmbKategorite.DisplayMember = "PERSHKRIMI";
            this.cmbKategorite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbKategorite.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbKategorite.IsValid = false;
            this.cmbKategorite.LayoutData = resources.GetString("cmbKategorite.LayoutData");
            this.cmbKategorite.Location = new System.Drawing.Point(12, 109);
            this.cmbKategorite.Name = "cmbKategorite";
            this.cmbKategorite.Required = true;
            this.cmbKategorite.Size = new System.Drawing.Size(180, 20);
            this.cmbKategorite.TabIndex = 13;
            this.cmbKategorite.Value = null;
            this.cmbKategorite.ValueMember = "ID_KATEGORIATAVOLINA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kapaciteti";
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(227, 143);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 37);
            this.btnAnullo.TabIndex = 17;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.DoValidation = true;
            this.btnRuaj.ForeColor = System.Drawing.Color.Navy;
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.save;
            this.btnRuaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuaj.Location = new System.Drawing.Point(227, 44);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.ParentToValidate = this.uiTabPage;
            this.btnRuaj.Size = new System.Drawing.Size(75, 37);
            this.btnRuaj.TabIndex = 15;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // lblNrTavolinash
            // 
            this.lblNrTavolinash.AutoSize = true;
            this.lblNrTavolinash.BackColor = System.Drawing.Color.Transparent;
            this.lblNrTavolinash.Location = new System.Drawing.Point(9, 38);
            this.lblNrTavolinash.Name = "lblNrTavolinash";
            this.lblNrTavolinash.Size = new System.Drawing.Size(63, 13);
            this.lblNrTavolinash.TabIndex = 0;
            this.lblNrTavolinash.Text = "Tavolina nr:";
            // 
            // numNumerTavolinash
            // 
            this.numNumerTavolinash.DefaultErrorMessage = "Numri i tavolinave nuk mund te jetë bosh!";
            this.numNumerTavolinash.IsValid = true;
            this.numNumerTavolinash.Location = new System.Drawing.Point(168, 3);
            this.numNumerTavolinash.Name = "numNumerTavolinash";
            this.numNumerTavolinash.Required = true;
            this.numNumerTavolinash.Size = new System.Drawing.Size(180, 20);
            this.numNumerTavolinash.TabIndex = 11;
            this.numNumerTavolinash.Visible = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnFundit);
            this.panelBottom.Controls.Add(this.btnPAs);
            this.panelBottom.Controls.Add(this.btnPara);
            this.panelBottom.Controls.Add(this.btnPari);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 408);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(472, 56);
            this.panelBottom.TabIndex = 1;
            // 
            // btnFundit
            // 
            this.btnFundit.ForeColor = System.Drawing.Color.Navy;
            this.btnFundit.Image = global::ResManagerAdmin.Properties.Resources.bullet_triangle_blue_fundit;
            this.btnFundit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFundit.Location = new System.Drawing.Point(379, 7);
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
            this.btnPAs.Location = new System.Drawing.Point(259, 7);
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
            this.btnPara.Location = new System.Drawing.Point(136, 7);
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
            this.panelTop.Controls.Add(this.btnKerko);
            this.panelTop.Controls.Add(this.btnFshi);
            this.panelTop.Controls.Add(this.btnModifiko);
            this.panelTop.Controls.Add(this.btnShto);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(472, 56);
            this.panelTop.TabIndex = 0;
            // 
            // btnKerko
            // 
            this.btnKerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKerko.ForeColor = System.Drawing.Color.Navy;
            this.btnKerko.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerko.Location = new System.Drawing.Point(379, 7);
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
            this.btnFshi.Location = new System.Drawing.Point(259, 7);
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
            this.btnModifiko.Location = new System.Drawing.Point(128, 7);
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
            // gridEXTavolinat
            // 
            this.gridEXTavolinat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEXTavolinat.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEXTavolinat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXTavolinat.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridEXTavolinat.GroupByBoxInfoText = "Tërhiqni një prej kolonave për të grupuar tavolinat";
            this.gridEXTavolinat.GroupByBoxVisible = false;
            this.gridEXTavolinat.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridEXTavolinat.HeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXTavolinat.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridEXTavolinat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEXTavolinat.LayoutData = resources.GetString("gridEXTavolinat.LayoutData");
            this.gridEXTavolinat.Location = new System.Drawing.Point(12, 67);
            this.gridEXTavolinat.Name = "gridEXTavolinat";
            this.gridEXTavolinat.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEXTavolinat.Size = new System.Drawing.Size(444, 335);
            this.gridEXTavolinat.TabIndex = 3;
            this.gridEXTavolinat.CurrentCellChanged += new System.EventHandler(this.gridEXTavolinat_CurrentCellChanged);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // numEmri
            // 
            this.numEmri.Location = new System.Drawing.Point(12, 54);
            this.numEmri.Name = "numEmri";
            this.numEmri.Size = new System.Drawing.Size(180, 20);
            this.numEmri.TabIndex = 19;
            // 
            // frmKonfigurimTavolinash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(472, 464);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKonfigurimTavolinash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Konfigurimi i  tavolinave ";
            this.Load += new System.EventHandler(this.frmKategoriteTavolina_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTab)).EndInit();
            this.uiTab.ResumeLayout(false);
            this.uiTabPage.ResumeLayout(false);
            this.uiTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKapaciteti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerTavolinash)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXTavolinat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private Janus.Windows.UI.Tab.UITab uiTab;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage;
        private System.Windows.Forms.Button btnAnullo;
        private VisionInfoSolutionLibrary.Button btnRuaj;
        private System.Windows.Forms.Label lblNrTavolinash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShtoDisa;
        private VisionInfoSolutionLibrary.MultiComboBox cmbKategorite;
        private System.Windows.Forms.Label label3;
        private VisionInfoSolutionLibrary.Button btnRuajKrijo;
        private VisionInfoSolutionLibrary.NumericBox numKapaciteti;
        private VisionInfoSolutionLibrary.NumericBox numNumerTavolinash;
        private Janus.Windows.GridEX.GridEX gridEXTavolinat;
        private System.Windows.Forms.Label lblGabimi;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox numEmri;
    }
}