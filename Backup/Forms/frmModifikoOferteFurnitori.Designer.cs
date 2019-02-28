namespace ResManagerAdmin.Forms
{
    partial class frmModifikoOferteFurnitori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifikoOferteFurnitori));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnModifikoOferte = new System.Windows.Forms.Button();
            this.btnShtoOferte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gridOfertat = new Janus.Windows.GridEX.GridEX();
            this.uiTabModifiko = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPageOfertat = new Janus.Windows.UI.Tab.UITabPage();
            this.btnDil = new System.Windows.Forms.Button();
            this.uiGroupBox3 = new Janus.Windows.EditControls.UIGroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.uiGroupBox6 = new Janus.Windows.EditControls.UIGroupBox();
            this.cmbKategoriaOferta = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.Kategoria = new System.Windows.Forms.Label();
            this.txtNjesiaArtikujQellim = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numArtikujtQellim = new System.Windows.Forms.NumericUpDown();
            this.cmbArtikujtQellim = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label26 = new System.Windows.Forms.Label();
            this.uiGroupBox5 = new Janus.Windows.EditControls.UIGroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbArtikujtNeBlerje = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtNjesiaArtikujtKusht = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numArtikujtKusht = new System.Windows.Forms.NumericUpDown();
            this.uiGroupBox7 = new Janus.Windows.EditControls.UIGroupBox();
            this.txtCmimiOferte = new System.Windows.Forms.TextBox();
            this.sasiaOferta = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpDataSkadencaOferte = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.txtVleraOferte = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnRuajOferte = new System.Windows.Forms.Button();
            this.btnRuajKrijoOferte = new System.Windows.Forms.Button();
            this.dsOfertat = new System.Data.DataSet();
            this.dsArtikujt = new System.Data.DataSet();
            this.dsBlerja = new System.Data.DataSet();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEx1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOfertat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTabModifiko)).BeginInit();
            this.uiTabModifiko.SuspendLayout();
            this.uiTabPageOfertat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).BeginInit();
            this.uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox6)).BeginInit();
            this.uiGroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArtikujtQellim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).BeginInit();
            this.uiGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArtikujtKusht)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox7)).BeginInit();
            this.uiGroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOfertat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArtikujt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlerja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.panelTop);
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.Controls.Add(this.uiTabModifiko);
            this.panelEx1.Controls.Add(this.gridOfertat);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(789, 522);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.btnModifikoOferte);
            this.panelTop.Controls.Add(this.btnShtoOferte);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(789, 56);
            this.panelTop.TabIndex = 7;
            // 
            // btnModifikoOferte
            // 
            this.btnModifikoOferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifikoOferte.ForeColor = System.Drawing.Color.Navy;
            this.btnModifikoOferte.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.btnModifikoOferte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifikoOferte.Location = new System.Drawing.Point(696, 7);
            this.btnModifikoOferte.Name = "btnModifikoOferte";
            this.btnModifikoOferte.Size = new System.Drawing.Size(75, 37);
            this.btnModifikoOferte.TabIndex = 16;
            this.btnModifikoOferte.Text = "Modifiko ofertë";
            this.btnModifikoOferte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifikoOferte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifikoOferte.UseVisualStyleBackColor = true;
            this.btnModifikoOferte.Click += new System.EventHandler(this.btnModifikoOferte_Click);
            // 
            // btnShtoOferte
            // 
            this.btnShtoOferte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShtoOferte.ForeColor = System.Drawing.Color.Navy;
            this.btnShtoOferte.Image = global::ResManagerAdmin.Properties.Resources.news_info;
            this.btnShtoOferte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShtoOferte.Location = new System.Drawing.Point(11, 7);
            this.btnShtoOferte.Name = "btnShtoOferte";
            this.btnShtoOferte.Size = new System.Drawing.Size(75, 37);
            this.btnShtoOferte.TabIndex = 15;
            this.btnShtoOferte.Text = "Shto ofertë";
            this.btnShtoOferte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShtoOferte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShtoOferte.UseVisualStyleBackColor = true;
            this.btnShtoOferte.Click += new System.EventHandler(this.btnShtoOferte_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAnullo);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 56);
            this.panel1.TabIndex = 28;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(696, 10);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 37);
            this.btnAnullo.TabIndex = 18;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Navy;
            this.btnOk.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(11, 10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 37);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Ok";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gridOfertat
            // 
            this.gridOfertat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridOfertat.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridOfertat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridOfertat.GroupByBoxVisible = false;
            this.gridOfertat.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridOfertat.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.gridOfertat.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridOfertat.LayoutData = resources.GetString("gridOfertat.LayoutData");
            this.gridOfertat.Location = new System.Drawing.Point(12, 67);
            this.gridOfertat.Name = "gridOfertat";
            this.gridOfertat.Size = new System.Drawing.Size(761, 379);
            this.gridOfertat.TabIndex = 1;
            this.gridOfertat.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // uiTabModifiko
            // 
            this.uiTabModifiko.BackColor = System.Drawing.Color.Transparent;
            this.uiTabModifiko.Controls.Add(this.uiTabPageOfertat);
            this.uiTabModifiko.ImeMode = System.Windows.Forms.ImeMode.On;
            this.uiTabModifiko.Location = new System.Drawing.Point(12, 67);
            this.uiTabModifiko.Name = "uiTabModifiko";
            this.uiTabModifiko.SelectedIndex = 0;
            this.uiTabModifiko.Size = new System.Drawing.Size(761, 379);
            this.uiTabModifiko.TabIndex = 29;
            this.uiTabModifiko.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPageOfertat});
            this.uiTabModifiko.Visible = false;
            this.uiTabModifiko.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal;
            // 
            // uiTabPageOfertat
            // 
            this.uiTabPageOfertat.Controls.Add(this.btnDil);
            this.uiTabPageOfertat.Controls.Add(this.uiGroupBox3);
            this.uiTabPageOfertat.Controls.Add(this.btnRuajOferte);
            this.uiTabPageOfertat.Controls.Add(this.btnRuajKrijoOferte);
            this.uiTabPageOfertat.Location = new System.Drawing.Point(1, 21);
            this.uiTabPageOfertat.Name = "uiTabPageOfertat";
            this.uiTabPageOfertat.Size = new System.Drawing.Size(757, 355);
            this.uiTabPageOfertat.TabIndex = 1;
            this.uiTabPageOfertat.Text = "Shto ofertë";
            // 
            // btnDil
            // 
            this.btnDil.ForeColor = System.Drawing.Color.Navy;
            this.btnDil.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnDil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDil.Location = new System.Drawing.Point(525, 285);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(75, 37);
            this.btnDil.TabIndex = 32;
            this.btnDil.Text = "Dil";
            this.btnDil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDil.UseVisualStyleBackColor = true;
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox3.Controls.Add(this.pictureBox4);
            this.uiGroupBox3.Controls.Add(this.pictureBox3);
            this.uiGroupBox3.Controls.Add(this.uiGroupBox6);
            this.uiGroupBox3.Controls.Add(this.uiGroupBox5);
            this.uiGroupBox3.Controls.Add(this.uiGroupBox7);
            this.uiGroupBox3.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.uiGroupBox3.Image = global::ResManagerAdmin.Properties.Resources.oferte_20;
            this.uiGroupBox3.Location = new System.Drawing.Point(3, 15);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Size = new System.Drawing.Size(747, 269);
            this.uiGroupBox3.TabIndex = 35;
            this.uiGroupBox3.Text = "Të dhënat e ofertës";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(206, 115);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(160, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // uiGroupBox6
            // 
            this.uiGroupBox6.Controls.Add(this.cmbKategoriaOferta);
            this.uiGroupBox6.Controls.Add(this.Kategoria);
            this.uiGroupBox6.Controls.Add(this.txtNjesiaArtikujQellim);
            this.uiGroupBox6.Controls.Add(this.label14);
            this.uiGroupBox6.Controls.Add(this.numArtikujtQellim);
            this.uiGroupBox6.Controls.Add(this.cmbArtikujtQellim);
            this.uiGroupBox6.Controls.Add(this.label26);
            this.uiGroupBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiGroupBox6.Location = new System.Drawing.Point(15, 142);
            this.uiGroupBox6.Name = "uiGroupBox6";
            this.uiGroupBox6.Size = new System.Drawing.Size(357, 119);
            this.uiGroupBox6.TabIndex = 31;
            this.uiGroupBox6.Text = "Furnitori ofron";
            // 
            // cmbKategoriaOferta
            // 
            this.cmbKategoriaOferta.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKategoriaOferta.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbKategoriaOferta.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbKategoriaOferta.DisplayMember = "PERSHKRIMI";
            this.cmbKategoriaOferta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbKategoriaOferta.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbKategoriaOferta.LayoutData = resources.GetString("cmbKategoriaOferta.LayoutData");
            this.cmbKategoriaOferta.Location = new System.Drawing.Point(146, 17);
            this.cmbKategoriaOferta.Name = "cmbKategoriaOferta";
            this.cmbKategoriaOferta.Size = new System.Drawing.Size(178, 20);
            this.cmbKategoriaOferta.TabIndex = 22;
            this.cmbKategoriaOferta.Value = null;
            this.cmbKategoriaOferta.ValueMember = "ID_KATEGORIAARTIKULLI";
            this.cmbKategoriaOferta.ValueChanged += new System.EventHandler(this.cmbKategoriaOferta_ValueChanged);
            // 
            // Kategoria
            // 
            this.Kategoria.AutoSize = true;
            this.Kategoria.Location = new System.Drawing.Point(65, 20);
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.Size = new System.Drawing.Size(52, 13);
            this.Kategoria.TabIndex = 31;
            this.Kategoria.Text = "Kategoria";
            // 
            // txtNjesiaArtikujQellim
            // 
            this.txtNjesiaArtikujQellim.BackColor = System.Drawing.Color.White;
            this.txtNjesiaArtikujQellim.Location = new System.Drawing.Point(244, 85);
            this.txtNjesiaArtikujQellim.Name = "txtNjesiaArtikujQellim";
            this.txtNjesiaArtikujQellim.ReadOnly = true;
            this.txtNjesiaArtikujQellim.Size = new System.Drawing.Size(80, 20);
            this.txtNjesiaArtikujQellim.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(32, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 34);
            this.label14.TabIndex = 0;
            this.label14.Text = "Numri  i artikujve të ofruar";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numArtikujtQellim
            // 
            this.numArtikujtQellim.Location = new System.Drawing.Point(146, 85);
            this.numArtikujtQellim.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numArtikujtQellim.Name = "numArtikujtQellim";
            this.numArtikujtQellim.Size = new System.Drawing.Size(80, 20);
            this.numArtikujtQellim.TabIndex = 24;
            this.numArtikujtQellim.ValueChanged += new System.EventHandler(this.numArtikujtQellim_ValueChanged);
            // 
            // cmbArtikujtQellim
            // 
            this.cmbArtikujtQellim.BackColor = System.Drawing.SystemColors.Window;
            this.cmbArtikujtQellim.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbArtikujtQellim.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbArtikujtQellim.DisplayMember = "EMRI";
            this.cmbArtikujtQellim.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbArtikujtQellim.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbArtikujtQellim.LayoutData = resources.GetString("cmbArtikujtQellim.LayoutData");
            this.cmbArtikujtQellim.Location = new System.Drawing.Point(146, 50);
            this.cmbArtikujtQellim.Name = "cmbArtikujtQellim";
            this.cmbArtikujtQellim.Size = new System.Drawing.Size(178, 20);
            this.cmbArtikujtQellim.TabIndex = 23;
            this.cmbArtikujtQellim.Value = null;
            this.cmbArtikujtQellim.ValueMember = "ID_ARTIKULLI";
            this.cmbArtikujtQellim.ValueChanged += new System.EventHandler(this.cmbArtikujtQellim_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(42, 52);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Artikulli i ofruar";
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.Controls.Add(this.label15);
            this.uiGroupBox5.Controls.Add(this.cmbArtikujtNeBlerje);
            this.uiGroupBox5.Controls.Add(this.txtNjesiaArtikujtKusht);
            this.uiGroupBox5.Controls.Add(this.label16);
            this.uiGroupBox5.Controls.Add(this.numArtikujtKusht);
            this.uiGroupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiGroupBox5.Location = new System.Drawing.Point(15, 17);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Size = new System.Drawing.Size(357, 90);
            this.uiGroupBox5.TabIndex = 30;
            this.uiGroupBox5.Text = "Për sasinë më poshtë të artikullit";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(16, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 34);
            this.label15.TabIndex = 0;
            this.label15.Text = "Numri  i artikujve që duhet të merren";
            // 
            // cmbArtikujtNeBlerje
            // 
            this.cmbArtikujtNeBlerje.BackColor = System.Drawing.SystemColors.Window;
            this.cmbArtikujtNeBlerje.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbArtikujtNeBlerje.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cmbArtikujtNeBlerje.DisplayMember = "EMRI";
            this.cmbArtikujtNeBlerje.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbArtikujtNeBlerje.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cmbArtikujtNeBlerje.LayoutData = resources.GetString("cmbArtikujtNeBlerje.LayoutData");
            this.cmbArtikujtNeBlerje.Location = new System.Drawing.Point(146, 19);
            this.cmbArtikujtNeBlerje.Name = "cmbArtikujtNeBlerje";
            this.cmbArtikujtNeBlerje.Size = new System.Drawing.Size(178, 20);
            this.cmbArtikujtNeBlerje.TabIndex = 19;
            this.cmbArtikujtNeBlerje.Value = null;
            this.cmbArtikujtNeBlerje.ValueMember = "ID_ARTIKULLI";
            this.cmbArtikujtNeBlerje.ValueChanged += new System.EventHandler(this.cmbArtikujtNeBlerje_ValueChanged);
            // 
            // txtNjesiaArtikujtKusht
            // 
            this.txtNjesiaArtikujtKusht.BackColor = System.Drawing.Color.White;
            this.txtNjesiaArtikujtKusht.Location = new System.Drawing.Point(244, 54);
            this.txtNjesiaArtikujtKusht.Name = "txtNjesiaArtikujtKusht";
            this.txtNjesiaArtikujtKusht.ReadOnly = true;
            this.txtNjesiaArtikujtKusht.Size = new System.Drawing.Size(80, 20);
            this.txtNjesiaArtikujtKusht.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Artikujt në blerje";
            // 
            // numArtikujtKusht
            // 
            this.numArtikujtKusht.Location = new System.Drawing.Point(146, 54);
            this.numArtikujtKusht.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numArtikujtKusht.Name = "numArtikujtKusht";
            this.numArtikujtKusht.Size = new System.Drawing.Size(80, 20);
            this.numArtikujtKusht.TabIndex = 20;
            this.numArtikujtKusht.ValueChanged += new System.EventHandler(this.numArtikujtKusht_ValueChanged);
            // 
            // uiGroupBox7
            // 
            this.uiGroupBox7.Controls.Add(this.txtCmimiOferte);
            this.uiGroupBox7.Controls.Add(this.sasiaOferta);
            this.uiGroupBox7.Controls.Add(this.label23);
            this.uiGroupBox7.Controls.Add(this.label21);
            this.uiGroupBox7.Controls.Add(this.dtpDataSkadencaOferte);
            this.uiGroupBox7.Controls.Add(this.label25);
            this.uiGroupBox7.Controls.Add(this.txtVleraOferte);
            this.uiGroupBox7.Controls.Add(this.label24);
            this.uiGroupBox7.Image = global::ResManagerAdmin.Properties.Resources.package;
            this.uiGroupBox7.Location = new System.Drawing.Point(392, 17);
            this.uiGroupBox7.Name = "uiGroupBox7";
            this.uiGroupBox7.Size = new System.Drawing.Size(347, 244);
            this.uiGroupBox7.TabIndex = 33;
            this.uiGroupBox7.Text = "Të dhenat e artikullit që ofrohet";
            // 
            // txtCmimiOferte
            // 
            this.txtCmimiOferte.BackColor = System.Drawing.Color.White;
            this.txtCmimiOferte.Location = new System.Drawing.Point(131, 79);
            this.txtCmimiOferte.Name = "txtCmimiOferte";
            this.txtCmimiOferte.ReadOnly = true;
            this.txtCmimiOferte.Size = new System.Drawing.Size(178, 20);
            this.txtCmimiOferte.TabIndex = 27;
            this.txtCmimiOferte.Text = "0";
            // 
            // sasiaOferta
            // 
            this.sasiaOferta.BackColor = System.Drawing.Color.White;
            this.sasiaOferta.Location = new System.Drawing.Point(131, 30);
            this.sasiaOferta.Name = "sasiaOferta";
            this.sasiaOferta.ReadOnly = true;
            this.sasiaOferta.Size = new System.Drawing.Size(178, 20);
            this.sasiaOferta.TabIndex = 26;
            this.sasiaOferta.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Sasia e artikujve";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(73, 133);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Vlera";
            // 
            // dtpDataSkadencaOferte
            // 
            this.dtpDataSkadencaOferte.CustomFormat = "dd.MM.yyyy";
            this.dtpDataSkadencaOferte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataSkadencaOferte.Location = new System.Drawing.Point(131, 181);
            this.dtpDataSkadencaOferte.Name = "dtpDataSkadencaOferte";
            this.dtpDataSkadencaOferte.ShowUpDown = true;
            this.dtpDataSkadencaOferte.Size = new System.Drawing.Size(180, 20);
            this.dtpDataSkadencaOferte.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(32, 84);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Cmimi i blerjes";
            // 
            // txtVleraOferte
            // 
            this.txtVleraOferte.BackColor = System.Drawing.Color.White;
            this.txtVleraOferte.Location = new System.Drawing.Point(131, 130);
            this.txtVleraOferte.Name = "txtVleraOferte";
            this.txtVleraOferte.ReadOnly = true;
            this.txtVleraOferte.Size = new System.Drawing.Size(178, 20);
            this.txtVleraOferte.TabIndex = 28;
            this.txtVleraOferte.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 186);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "Data e skadencës";
            // 
            // btnRuajOferte
            // 
            this.btnRuajOferte.ForeColor = System.Drawing.Color.Navy;
            this.btnRuajOferte.Image = global::ResManagerAdmin.Properties.Resources.save;
            this.btnRuajOferte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajOferte.Location = new System.Drawing.Point(173, 285);
            this.btnRuajOferte.Name = "btnRuajOferte";
            this.btnRuajOferte.Size = new System.Drawing.Size(75, 37);
            this.btnRuajOferte.TabIndex = 30;
            this.btnRuajOferte.Text = "Ruaj";
            this.btnRuajOferte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajOferte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuajOferte.UseVisualStyleBackColor = true;
            this.btnRuajOferte.Click += new System.EventHandler(this.btnRuajOferte_Click);
            // 
            // btnRuajKrijoOferte
            // 
            this.btnRuajKrijoOferte.ForeColor = System.Drawing.Color.Navy;
            this.btnRuajKrijoOferte.Image = global::ResManagerAdmin.Properties.Resources.save_new;
            this.btnRuajKrijoOferte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajKrijoOferte.Location = new System.Drawing.Point(352, 285);
            this.btnRuajKrijoOferte.Name = "btnRuajKrijoOferte";
            this.btnRuajKrijoOferte.Size = new System.Drawing.Size(75, 37);
            this.btnRuajKrijoOferte.TabIndex = 31;
            this.btnRuajKrijoOferte.Text = "Ruaj && Krijo";
            this.btnRuajKrijoOferte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajKrijoOferte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuajKrijoOferte.UseVisualStyleBackColor = true;
            this.btnRuajKrijoOferte.Click += new System.EventHandler(this.btnRuajKrijoOferte_Click);
            // 
            // dsOfertat
            // 
            this.dsOfertat.DataSetName = "dsOfertat";
            // 
            // dsArtikujt
            // 
            this.dsArtikujt.DataSetName = "NewDataSet";
            // 
            // dsBlerja
            // 
            this.dsBlerja.DataSetName = "NewDataSet";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // frmModifikoOferteFurnitori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 522);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModifikoOferteFurnitori";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ofertat";
            this.Load += new System.EventHandler(this.frmModifikoOferteFurnitori_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOfertat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTabModifiko)).EndInit();
            this.uiTabModifiko.ResumeLayout(false);
            this.uiTabPageOfertat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox3)).EndInit();
            this.uiGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox6)).EndInit();
            this.uiGroupBox6.ResumeLayout(false);
            this.uiGroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArtikujtQellim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox5)).EndInit();
            this.uiGroupBox5.ResumeLayout(false);
            this.uiGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArtikujtKusht)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox7)).EndInit();
            this.uiGroupBox7.ResumeLayout(false);
            this.uiGroupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOfertat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArtikujt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlerja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Janus.Windows.GridEX.GridEX gridOfertat;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnModifikoOferte;
        private System.Windows.Forms.Button btnShtoOferte;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.Panel panel1;
        private Janus.Windows.UI.Tab.UITab uiTabModifiko;
        private Janus.Windows.UI.Tab.UITabPage uiTabPageOfertat;
        private System.Windows.Forms.Button btnDil;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox6;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbKategoriaOferta;
        private System.Windows.Forms.Label Kategoria;
        private System.Windows.Forms.TextBox txtNjesiaArtikujQellim;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numArtikujtQellim;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbArtikujtQellim;
        private System.Windows.Forms.Label label26;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox5;
        private System.Windows.Forms.Label label15;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbArtikujtNeBlerje;
        private System.Windows.Forms.TextBox txtNjesiaArtikujtKusht;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numArtikujtKusht;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox7;
        private System.Windows.Forms.TextBox txtCmimiOferte;
        private System.Windows.Forms.TextBox sasiaOferta;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpDataSkadencaOferte;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtVleraOferte;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnRuajOferte;
        private System.Windows.Forms.Button btnRuajKrijoOferte;
        public System.Data.DataSet dsOfertat;
        public System.Data.DataSet dsArtikujt;
        public System.Data.DataSet dsBlerja;
        private System.Windows.Forms.ErrorProvider error1;
    }
}