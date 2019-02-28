namespace ResManagerAdmin.Forms
{
    partial class frmShpenzimetMujore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShpenzimetMujore));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.grKerkimi = new Janus.Windows.EditControls.UIGroupBox();
            this.cboKategoriaKerkimi = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnKerko = new System.Windows.Forms.Button();
            this.chkKategoria = new System.Windows.Forms.CheckBox();
            this.cboMuajiKerkimi = new System.Windows.Forms.ComboBox();
            this.chkMuaji = new System.Windows.Forms.CheckBox();
            this.cboVitiKerkimi = new System.Windows.Forms.ComboBox();
            this.chkViti = new System.Windows.Forms.CheckBox();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.lblKerkimi = new System.Windows.Forms.Label();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnFshi = new System.Windows.Forms.Button();
            this.btnModifiko = new System.Windows.Forms.Button();
            this.btnShto = new System.Windows.Forms.Button();
            this.tabi = new Janus.Windows.UI.Tab.UITab();
            this.tabpage = new Janus.Windows.UI.Tab.UITabPage();
            this.cboKategoria = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKomenti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMuaji = new System.Windows.Forms.ComboBox();
            this.cboViti = new System.Windows.Forms.ComboBox();
            this.numVlera = new System.Windows.Forms.NumericUpDown();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grKerkimi)).BeginInit();
            this.grKerkimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabi)).BeginInit();
            this.tabi.SuspendLayout();
            this.tabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVlera)).BeginInit();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.Controls.Add(this.grKerkimi);
            this.expandablePanel1.Controls.Add(this.uiGroupBox1);
            this.expandablePanel1.ExpandButtonVisible = false;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(1024, 640);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 0;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "    Shpenzimet mujore";
            // 
            // grKerkimi
            // 
            this.grKerkimi.Controls.Add(this.cboKategoriaKerkimi);
            this.grKerkimi.Controls.Add(this.btnKerko);
            this.grKerkimi.Controls.Add(this.chkKategoria);
            this.grKerkimi.Controls.Add(this.cboMuajiKerkimi);
            this.grKerkimi.Controls.Add(this.chkMuaji);
            this.grKerkimi.Controls.Add(this.cboVitiKerkimi);
            this.grKerkimi.Controls.Add(this.chkViti);
            this.grKerkimi.Image = global::ResManagerAdmin.Properties.Resources.search_f2;
            this.grKerkimi.Location = new System.Drawing.Point(13, 38);
            this.grKerkimi.Name = "grKerkimi";
            this.grKerkimi.Size = new System.Drawing.Size(229, 267);
            this.grKerkimi.TabIndex = 2;
            this.grKerkimi.Text = "Kerko shpenzim mujor";
            this.grKerkimi.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // cboKategoriaKerkimi
            // 
            this.cboKategoriaKerkimi.BackColor = System.Drawing.SystemColors.Window;
            this.cboKategoriaKerkimi.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cboKategoriaKerkimi.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboKategoriaKerkimi.DisplayMember = "CSHPENZIMI";
            this.cboKategoriaKerkimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKategoriaKerkimi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboKategoriaKerkimi.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboKategoriaKerkimi.LayoutData = resources.GetString("cboKategoriaKerkimi.LayoutData");
            this.cboKategoriaKerkimi.Location = new System.Drawing.Point(10, 173);
            this.cboKategoriaKerkimi.Name = "cboKategoriaKerkimi";
            this.cboKategoriaKerkimi.Size = new System.Drawing.Size(184, 21);
            this.cboKategoriaKerkimi.TabIndex = 7;
            this.cboKategoriaKerkimi.Value = null;
            this.cboKategoriaKerkimi.ValueMember = "ID_KATSHPENZIMIMUJOR";
            // 
            // btnKerko
            // 
            this.btnKerko.ForeColor = System.Drawing.Color.Navy;
            this.btnKerko.Image = global::ResManagerAdmin.Properties.Resources.Search;
            this.btnKerko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKerko.Location = new System.Drawing.Point(59, 221);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(90, 35);
            this.btnKerko.TabIndex = 6;
            this.btnKerko.Text = "  Kerko";
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // chkKategoria
            // 
            this.chkKategoria.AutoSize = true;
            this.chkKategoria.Location = new System.Drawing.Point(11, 150);
            this.chkKategoria.Name = "chkKategoria";
            this.chkKategoria.Size = new System.Drawing.Size(77, 17);
            this.chkKategoria.TabIndex = 4;
            this.chkKategoria.Text = "Kategoria :";
            this.chkKategoria.UseVisualStyleBackColor = true;
            this.chkKategoria.CheckedChanged += new System.EventHandler(this.chkKategoria_CheckedChanged);
            // 
            // cboMuajiKerkimi
            // 
            this.cboMuajiKerkimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMuajiKerkimi.FormattingEnabled = true;
            this.cboMuajiKerkimi.Location = new System.Drawing.Point(10, 110);
            this.cboMuajiKerkimi.Name = "cboMuajiKerkimi";
            this.cboMuajiKerkimi.Size = new System.Drawing.Size(127, 21);
            this.cboMuajiKerkimi.TabIndex = 3;
            // 
            // chkMuaji
            // 
            this.chkMuaji.AutoSize = true;
            this.chkMuaji.Location = new System.Drawing.Point(10, 90);
            this.chkMuaji.Name = "chkMuaji";
            this.chkMuaji.Size = new System.Drawing.Size(57, 17);
            this.chkMuaji.TabIndex = 2;
            this.chkMuaji.Text = "Muaji :";
            this.chkMuaji.UseVisualStyleBackColor = true;
            this.chkMuaji.CheckedChanged += new System.EventHandler(this.chkMuaji_CheckedChanged);
            // 
            // cboVitiKerkimi
            // 
            this.cboVitiKerkimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVitiKerkimi.FormattingEnabled = true;
            this.cboVitiKerkimi.Location = new System.Drawing.Point(10, 55);
            this.cboVitiKerkimi.Name = "cboVitiKerkimi";
            this.cboVitiKerkimi.Size = new System.Drawing.Size(127, 21);
            this.cboVitiKerkimi.TabIndex = 1;
            // 
            // chkViti
            // 
            this.chkViti.AutoSize = true;
            this.chkViti.Location = new System.Drawing.Point(11, 32);
            this.chkViti.Name = "chkViti";
            this.chkViti.Size = new System.Drawing.Size(46, 17);
            this.chkViti.TabIndex = 0;
            this.chkViti.Text = "Viti :";
            this.chkViti.UseVisualStyleBackColor = true;
            this.chkViti.CheckedChanged += new System.EventHandler(this.chkViti_CheckedChanged);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.lblKerkimi);
            this.uiGroupBox1.Controls.Add(this.panelTop);
            this.uiGroupBox1.Controls.Add(this.grida);
            this.uiGroupBox1.Controls.Add(this.tabi);
            this.uiGroupBox1.Location = new System.Drawing.Point(248, 38);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(737, 581);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // lblKerkimi
            // 
            this.lblKerkimi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKerkimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKerkimi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblKerkimi.Location = new System.Drawing.Point(28, 82);
            this.lblKerkimi.Name = "lblKerkimi";
            this.lblKerkimi.Size = new System.Drawing.Size(681, 25);
            this.lblKerkimi.TabIndex = 4;
            this.lblKerkimi.Text = "Shpenzimet mujore sipas kerkimit";
            this.lblKerkimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grida
            // 
            this.grida.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(26, 110);
            this.grida.Name = "grida";
            this.grida.Size = new System.Drawing.Size(683, 437);
            this.grida.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnFshi);
            this.panelTop.Controls.Add(this.btnModifiko);
            this.panelTop.Controls.Add(this.btnShto);
            this.panelTop.Location = new System.Drawing.Point(26, 17);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(680, 50);
            this.panelTop.TabIndex = 2;
            // 
            // btnFshi
            // 
            this.btnFshi.ForeColor = System.Drawing.Color.Navy;
            this.btnFshi.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnFshi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshi.Location = new System.Drawing.Point(549, 5);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(90, 35);
            this.btnFshi.TabIndex = 2;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.UseVisualStyleBackColor = true;
            // 
            // btnModifiko
            // 
            this.btnModifiko.ForeColor = System.Drawing.Color.Navy;
            this.btnModifiko.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.btnModifiko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifiko.Location = new System.Drawing.Point(295, 5);
            this.btnModifiko.Name = "btnModifiko";
            this.btnModifiko.Size = new System.Drawing.Size(90, 35);
            this.btnModifiko.TabIndex = 1;
            this.btnModifiko.Text = "Modifiko";
            this.btnModifiko.UseVisualStyleBackColor = true;
            this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
            // 
            // btnShto
            // 
            this.btnShto.ForeColor = System.Drawing.Color.Navy;
            this.btnShto.Image = global::ResManagerAdmin.Properties.Resources.news_info;
            this.btnShto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShto.Location = new System.Drawing.Point(31, 5);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(90, 35);
            this.btnShto.TabIndex = 0;
            this.btnShto.Text = "Shto";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // tabi
            // 
            this.tabi.Controls.Add(this.tabpage);
            this.tabi.Location = new System.Drawing.Point(26, 110);
            this.tabi.Name = "tabi";
            this.tabi.SelectedIndex = 0;
            this.tabi.Size = new System.Drawing.Size(683, 437);
            this.tabi.TabIndex = 1;
            this.tabi.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.tabpage});
            // 
            // tabpage
            // 
            this.tabpage.Controls.Add(this.numVlera);
            this.tabpage.Controls.Add(this.cboKategoria);
            this.tabpage.Controls.Add(this.btnAnullo);
            this.tabpage.Controls.Add(this.btnRuaj);
            this.tabpage.Controls.Add(this.label5);
            this.tabpage.Controls.Add(this.txtKomenti);
            this.tabpage.Controls.Add(this.label4);
            this.tabpage.Controls.Add(this.label3);
            this.tabpage.Controls.Add(this.label2);
            this.tabpage.Controls.Add(this.label1);
            this.tabpage.Controls.Add(this.cboMuaji);
            this.tabpage.Controls.Add(this.cboViti);
            this.tabpage.Location = new System.Drawing.Point(1, 21);
            this.tabpage.Name = "tabpage";
            this.tabpage.Size = new System.Drawing.Size(679, 402);
            this.tabpage.TabIndex = 0;
            this.tabpage.Text = "Shtim";
            // 
            // cboKategoria
            // 
            this.cboKategoria.BackColor = System.Drawing.SystemColors.Window;
            this.cboKategoria.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cboKategoria.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.cboKategoria.DisplayMember = "CSHPENZIMI";
            this.cboKategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboKategoria.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
            this.cboKategoria.LayoutData = resources.GetString("cboKategoria.LayoutData");
            this.cboKategoria.Location = new System.Drawing.Point(209, 103);
            this.cboKategoria.Name = "cboKategoria";
            this.cboKategoria.Size = new System.Drawing.Size(175, 20);
            this.cboKategoria.TabIndex = 12;
            this.cboKategoria.Value = null;
            this.cboKategoria.ValueMember = "ID_KATSHPENZIMIMUJOR";
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.cancelbuild;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(345, 303);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(90, 35);
            this.btnAnullo.TabIndex = 11;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.ForeColor = System.Drawing.Color.Navy;
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.save;
            this.btnRuaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuaj.Location = new System.Drawing.Point(222, 303);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(90, 35);
            this.btnRuaj.TabIndex = 10;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(120, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Komenti :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKomenti
            // 
            this.txtKomenti.Location = new System.Drawing.Point(209, 169);
            this.txtKomenti.Multiline = true;
            this.txtKomenti.Name = "txtKomenti";
            this.txtKomenti.Size = new System.Drawing.Size(337, 96);
            this.txtKomenti.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vlera :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategoria :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Muaji :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Viti :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboMuaji
            // 
            this.cboMuaji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMuaji.FormattingEnabled = true;
            this.cboMuaji.Location = new System.Drawing.Point(209, 70);
            this.cboMuaji.Name = "cboMuaji";
            this.cboMuaji.Size = new System.Drawing.Size(112, 21);
            this.cboMuaji.TabIndex = 1;
            // 
            // cboViti
            // 
            this.cboViti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViti.FormattingEnabled = true;
            this.cboViti.Location = new System.Drawing.Point(209, 37);
            this.cboViti.Name = "cboViti";
            this.cboViti.Size = new System.Drawing.Size(112, 21);
            this.cboViti.TabIndex = 0;
            // 
            // numVlera
            // 
            this.numVlera.DecimalPlaces = 2;
            this.numVlera.Location = new System.Drawing.Point(209, 136);
            this.numVlera.Name = "numVlera";
            this.numVlera.Size = new System.Drawing.Size(175, 20);
            this.numVlera.TabIndex = 13;
            // 
            // frmShpenzimetMujore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShpenzimetMujore";
            this.Text = "Shpenzimet mujore";
            this.Load += new System.EventHandler(this.frmShpenzimetMujore_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmShpenzimetMujore_CausesValidationChanged);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grKerkimi)).EndInit();
            this.grKerkimi.ResumeLayout(false);
            this.grKerkimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabi)).EndInit();
            this.tabi.ResumeLayout(false);
            this.tabpage.ResumeLayout(false);
            this.tabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVlera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.UI.Tab.UITab tabi;
        private Janus.Windows.UI.Tab.UITabPage tabpage;
        private System.Windows.Forms.ComboBox cboViti;
        private System.Windows.Forms.ComboBox cboMuaji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.EditControls.UIGroupBox grKerkimi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKomenti;
        private System.Windows.Forms.Button btnAnullo;
        private System.Windows.Forms.Button btnRuaj;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnFshi;
        private System.Windows.Forms.Button btnModifiko;
        private System.Windows.Forms.Button btnShto;
        private Janus.Windows.GridEX.GridEX grida;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboKategoria;
        private System.Windows.Forms.CheckBox chkKategoria;
        private System.Windows.Forms.ComboBox cboMuajiKerkimi;
        private System.Windows.Forms.CheckBox chkMuaji;
        private System.Windows.Forms.ComboBox cboVitiKerkimi;
        private System.Windows.Forms.CheckBox chkViti;
        private System.Windows.Forms.Button btnKerko;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cboKategoriaKerkimi;
        private System.Windows.Forms.Label lblKerkimi;
        private System.Windows.Forms.NumericUpDown numVlera;
    }
}