namespace ResManagerAdmin.Forms
{
    partial class frmSettings
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
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRuajPerberesRi = new System.Windows.Forms.Button();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.gbIntervalet = new Janus.Windows.EditControls.UIGroupBox();
            this.panelIntervale = new System.Windows.Forms.Panel();
            this.dtpMbarimi4 = new System.Windows.Forms.DateTimePicker();
            this.dtpMbarimi3 = new System.Windows.Forms.DateTimePicker();
            this.dtpMbarimi2 = new System.Windows.Forms.DateTimePicker();
            this.lbMbarimi4 = new System.Windows.Forms.Label();
            this.lbMbarimi3 = new System.Windows.Forms.Label();
            this.lbMbarimi2 = new System.Windows.Forms.Label();
            this.dtpMbarimi1 = new System.Windows.Forms.DateTimePicker();
            this.lbMbarimi1 = new System.Windows.Forms.Label();
            this.dtpFillimi4 = new System.Windows.Forms.DateTimePicker();
            this.dtpFillimi3 = new System.Windows.Forms.DateTimePicker();
            this.dtpFillimi2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFillimi1 = new System.Windows.Forms.DateTimePicker();
            this.lbFillimi4 = new System.Windows.Forms.Label();
            this.lbFillimi3 = new System.Windows.Forms.Label();
            this.lbFillimi2 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbFillimi1 = new System.Windows.Forms.Label();
            this.numNrIntervalesh = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNdajNeIntervale = new System.Windows.Forms.CheckBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dsIntervalet = new System.Data.DataSet();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbIntervalet)).BeginInit();
            this.gbIntervalet.SuspendLayout();
            this.panelIntervale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNrIntervalesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIntervalet)).BeginInit();
            this.SuspendLayout();
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.AutoScroll = true;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.btnRuajPerberesRi);
            this.expandablePanel1.Controls.Add(this.uiTab1);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandablePanel1.ExpandButtonVisible = false;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(1020, 614);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandablePanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 7;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.Color = System.Drawing.Color.White;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Rregullime";
            // 
            // btnRuajPerberesRi
            // 
            this.btnRuajPerberesRi.ForeColor = System.Drawing.Color.Navy;
            this.btnRuajPerberesRi.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.btnRuajPerberesRi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuajPerberesRi.Location = new System.Drawing.Point(206, 414);
            this.btnRuajPerberesRi.Name = "btnRuajPerberesRi";
            this.btnRuajPerberesRi.Size = new System.Drawing.Size(75, 28);
            this.btnRuajPerberesRi.TabIndex = 18;
            this.btnRuajPerberesRi.Text = "Ok";
            this.btnRuajPerberesRi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuajPerberesRi.UseVisualStyleBackColor = true;
            this.btnRuajPerberesRi.Click += new System.EventHandler(this.btnRuajPerberesRi_Click);
            // 
            // uiTab1
            // 
            this.uiTab1.Controls.Add(this.uiTabPage1);
            this.uiTab1.Location = new System.Drawing.Point(10, 40);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.SelectedIndex = 0;
            this.uiTab1.Size = new System.Drawing.Size(481, 363);
            this.uiTab1.TabIndex = 1;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.gbIntervalet);
            this.uiTabPage1.Controls.Add(this.cbNdajNeIntervale);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(477, 339);
            this.uiTabPage1.TabIndex = 0;
            this.uiTabPage1.Text = "Konfigurimi i periudhave të çmimeve";
            // 
            // gbIntervalet
            // 
            this.gbIntervalet.BackColor = System.Drawing.Color.Transparent;
            this.gbIntervalet.Controls.Add(this.panelIntervale);
            this.gbIntervalet.Controls.Add(this.numNrIntervalesh);
            this.gbIntervalet.Controls.Add(this.label1);
            this.gbIntervalet.Location = new System.Drawing.Point(23, 53);
            this.gbIntervalet.Name = "gbIntervalet";
            this.gbIntervalet.Size = new System.Drawing.Size(438, 265);
            this.gbIntervalet.TabIndex = 1;
            // 
            // panelIntervale
            // 
            this.panelIntervale.Controls.Add(this.dtpMbarimi4);
            this.panelIntervale.Controls.Add(this.dtpMbarimi3);
            this.panelIntervale.Controls.Add(this.dtpMbarimi2);
            this.panelIntervale.Controls.Add(this.lbMbarimi4);
            this.panelIntervale.Controls.Add(this.lbMbarimi3);
            this.panelIntervale.Controls.Add(this.lbMbarimi2);
            this.panelIntervale.Controls.Add(this.dtpMbarimi1);
            this.panelIntervale.Controls.Add(this.lbMbarimi1);
            this.panelIntervale.Controls.Add(this.dtpFillimi4);
            this.panelIntervale.Controls.Add(this.dtpFillimi3);
            this.panelIntervale.Controls.Add(this.dtpFillimi2);
            this.panelIntervale.Controls.Add(this.dtpFillimi1);
            this.panelIntervale.Controls.Add(this.lbFillimi4);
            this.panelIntervale.Controls.Add(this.lbFillimi3);
            this.panelIntervale.Controls.Add(this.lbFillimi2);
            this.panelIntervale.Controls.Add(this.lb4);
            this.panelIntervale.Controls.Add(this.lb3);
            this.panelIntervale.Controls.Add(this.lb2);
            this.panelIntervale.Controls.Add(this.lb1);
            this.panelIntervale.Controls.Add(this.lbFillimi1);
            this.panelIntervale.Location = new System.Drawing.Point(3, 46);
            this.panelIntervale.Name = "panelIntervale";
            this.panelIntervale.Size = new System.Drawing.Size(421, 201);
            this.panelIntervale.TabIndex = 2;
            // 
            // dtpMbarimi4
            // 
            this.dtpMbarimi4.CustomFormat = "HH:mm";
            this.dtpMbarimi4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMbarimi4.Location = new System.Drawing.Point(316, 161);
            this.dtpMbarimi4.Name = "dtpMbarimi4";
            this.dtpMbarimi4.ShowUpDown = true;
            this.dtpMbarimi4.Size = new System.Drawing.Size(75, 20);
            this.dtpMbarimi4.TabIndex = 20;
            this.dtpMbarimi4.ValueChanged += new System.EventHandler(this.dtpMbarimi4_ValueChanged);
            // 
            // dtpMbarimi3
            // 
            this.dtpMbarimi3.CustomFormat = "HH:mm";
            this.dtpMbarimi3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMbarimi3.Location = new System.Drawing.Point(316, 118);
            this.dtpMbarimi3.Name = "dtpMbarimi3";
            this.dtpMbarimi3.ShowUpDown = true;
            this.dtpMbarimi3.Size = new System.Drawing.Size(75, 20);
            this.dtpMbarimi3.TabIndex = 19;
            this.dtpMbarimi3.ValueChanged += new System.EventHandler(this.dtpMbarimi3_ValueChanged);
            // 
            // dtpMbarimi2
            // 
            this.dtpMbarimi2.CustomFormat = "HH:mm";
            this.dtpMbarimi2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMbarimi2.Location = new System.Drawing.Point(316, 75);
            this.dtpMbarimi2.Name = "dtpMbarimi2";
            this.dtpMbarimi2.ShowUpDown = true;
            this.dtpMbarimi2.Size = new System.Drawing.Size(75, 20);
            this.dtpMbarimi2.TabIndex = 18;
            this.dtpMbarimi2.ValueChanged += new System.EventHandler(this.dtpMbarimi2_ValueChanged);
            // 
            // lbMbarimi4
            // 
            this.lbMbarimi4.AutoSize = true;
            this.lbMbarimi4.Location = new System.Drawing.Point(228, 163);
            this.lbMbarimi4.Name = "lbMbarimi4";
            this.lbMbarimi4.Size = new System.Drawing.Size(65, 13);
            this.lbMbarimi4.TabIndex = 17;
            this.lbMbarimi4.Text = "Deri në orën";
            // 
            // lbMbarimi3
            // 
            this.lbMbarimi3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbMbarimi3.AutoSize = true;
            this.lbMbarimi3.Location = new System.Drawing.Point(228, 120);
            this.lbMbarimi3.Name = "lbMbarimi3";
            this.lbMbarimi3.Size = new System.Drawing.Size(65, 13);
            this.lbMbarimi3.TabIndex = 16;
            this.lbMbarimi3.Text = "Deri në orën";
            // 
            // lbMbarimi2
            // 
            this.lbMbarimi2.AutoSize = true;
            this.lbMbarimi2.Location = new System.Drawing.Point(228, 79);
            this.lbMbarimi2.Name = "lbMbarimi2";
            this.lbMbarimi2.Size = new System.Drawing.Size(65, 13);
            this.lbMbarimi2.TabIndex = 15;
            this.lbMbarimi2.Text = "Deri në orën";
            // 
            // dtpMbarimi1
            // 
            this.dtpMbarimi1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpMbarimi1.CustomFormat = "HH:mm";
            this.dtpMbarimi1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMbarimi1.Location = new System.Drawing.Point(316, 32);
            this.dtpMbarimi1.Name = "dtpMbarimi1";
            this.dtpMbarimi1.ShowUpDown = true;
            this.dtpMbarimi1.Size = new System.Drawing.Size(75, 20);
            this.dtpMbarimi1.TabIndex = 14;
            this.dtpMbarimi1.ValueChanged += new System.EventHandler(this.dtpMbarimi1_ValueChanged);
            // 
            // lbMbarimi1
            // 
            this.lbMbarimi1.AutoSize = true;
            this.lbMbarimi1.Location = new System.Drawing.Point(228, 36);
            this.lbMbarimi1.Name = "lbMbarimi1";
            this.lbMbarimi1.Size = new System.Drawing.Size(65, 13);
            this.lbMbarimi1.TabIndex = 13;
            this.lbMbarimi1.Text = "Deri në orën";
            // 
            // dtpFillimi4
            // 
            this.dtpFillimi4.CustomFormat = "HH:mm";
            this.dtpFillimi4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFillimi4.Location = new System.Drawing.Point(125, 161);
            this.dtpFillimi4.Name = "dtpFillimi4";
            this.dtpFillimi4.ShowUpDown = true;
            this.dtpFillimi4.Size = new System.Drawing.Size(75, 20);
            this.dtpFillimi4.TabIndex = 12;
            this.dtpFillimi4.ValueChanged += new System.EventHandler(this.dtpFillimi4_ValueChanged);
            // 
            // dtpFillimi3
            // 
            this.dtpFillimi3.CustomFormat = "HH:mm";
            this.dtpFillimi3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFillimi3.Location = new System.Drawing.Point(125, 118);
            this.dtpFillimi3.Name = "dtpFillimi3";
            this.dtpFillimi3.ShowUpDown = true;
            this.dtpFillimi3.Size = new System.Drawing.Size(75, 20);
            this.dtpFillimi3.TabIndex = 11;
            this.dtpFillimi3.ValueChanged += new System.EventHandler(this.dtpFillimi3_ValueChanged);
            // 
            // dtpFillimi2
            // 
            this.dtpFillimi2.CustomFormat = "HH:mm";
            this.dtpFillimi2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFillimi2.Location = new System.Drawing.Point(125, 75);
            this.dtpFillimi2.Name = "dtpFillimi2";
            this.dtpFillimi2.ShowUpDown = true;
            this.dtpFillimi2.Size = new System.Drawing.Size(75, 20);
            this.dtpFillimi2.TabIndex = 10;
            this.dtpFillimi2.ValueChanged += new System.EventHandler(this.dtpFillimi2_ValueChanged);
            // 
            // dtpFillimi1
            // 
            this.dtpFillimi1.CustomFormat = "HH:mm";
            this.dtpFillimi1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFillimi1.Location = new System.Drawing.Point(125, 32);
            this.dtpFillimi1.Name = "dtpFillimi1";
            this.dtpFillimi1.ShowUpDown = true;
            this.dtpFillimi1.Size = new System.Drawing.Size(75, 20);
            this.dtpFillimi1.TabIndex = 9;
            this.dtpFillimi1.ValueChanged += new System.EventHandler(this.dtpFillimi1_ValueChanged);
            // 
            // lbFillimi4
            // 
            this.lbFillimi4.AutoSize = true;
            this.lbFillimi4.Location = new System.Drawing.Point(62, 163);
            this.lbFillimi4.Name = "lbFillimi4";
            this.lbFillimi4.Size = new System.Drawing.Size(45, 13);
            this.lbFillimi4.TabIndex = 8;
            this.lbFillimi4.Text = "Nga ora";
            // 
            // lbFillimi3
            // 
            this.lbFillimi3.AutoSize = true;
            this.lbFillimi3.Location = new System.Drawing.Point(62, 120);
            this.lbFillimi3.Name = "lbFillimi3";
            this.lbFillimi3.Size = new System.Drawing.Size(45, 13);
            this.lbFillimi3.TabIndex = 7;
            this.lbFillimi3.Text = "Nga ora";
            // 
            // lbFillimi2
            // 
            this.lbFillimi2.AutoSize = true;
            this.lbFillimi2.Location = new System.Drawing.Point(62, 79);
            this.lbFillimi2.Name = "lbFillimi2";
            this.lbFillimi2.Size = new System.Drawing.Size(45, 13);
            this.lbFillimi2.TabIndex = 6;
            this.lbFillimi2.Text = "Nga ora";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.ForeColor = System.Drawing.Color.Navy;
            this.lb4.Location = new System.Drawing.Point(32, 163);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(18, 13);
            this.lb4.TabIndex = 5;
            this.lb4.Text = "4.";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.Color.Navy;
            this.lb3.Location = new System.Drawing.Point(32, 120);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(18, 13);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "3.";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.Navy;
            this.lb2.Location = new System.Drawing.Point(32, 79);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(18, 13);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "2.";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Navy;
            this.lb1.Location = new System.Drawing.Point(32, 36);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(18, 13);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "1.";
            // 
            // lbFillimi1
            // 
            this.lbFillimi1.AutoSize = true;
            this.lbFillimi1.Location = new System.Drawing.Point(62, 36);
            this.lbFillimi1.Name = "lbFillimi1";
            this.lbFillimi1.Size = new System.Drawing.Size(45, 13);
            this.lbFillimi1.TabIndex = 1;
            this.lbFillimi1.Text = "Nga ora";
            // 
            // numNrIntervalesh
            // 
            this.numNrIntervalesh.Location = new System.Drawing.Point(128, 20);
            this.numNrIntervalesh.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNrIntervalesh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNrIntervalesh.Name = "numNrIntervalesh";
            this.numNrIntervalesh.Size = new System.Drawing.Size(75, 20);
            this.numNrIntervalesh.TabIndex = 1;
            this.numNrIntervalesh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNrIntervalesh.ValueChanged += new System.EventHandler(this.numNrIntervalesh_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numri i intervaleve";
            // 
            // cbNdajNeIntervale
            // 
            this.cbNdajNeIntervale.AutoSize = true;
            this.cbNdajNeIntervale.BackColor = System.Drawing.Color.Transparent;
            this.cbNdajNeIntervale.Location = new System.Drawing.Point(26, 21);
            this.cbNdajNeIntervale.Name = "cbNdajNeIntervale";
            this.cbNdajNeIntervale.Size = new System.Drawing.Size(357, 17);
            this.cbNdajNeIntervale.TabIndex = 0;
            this.cbNdajNeIntervale.Text = "Konfiguro çmimet artikujve dhe recetave në restorant sipas intervaleve";
            this.cbNdajNeIntervale.UseVisualStyleBackColor = false;
            this.cbNdajNeIntervale.CheckedChanged += new System.EventHandler(this.cbNdajNeIntervale_CheckedChanged);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // dsIntervalet
            // 
            this.dsIntervalet.DataSetName = "NewDataSet";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 614);
            this.ControlBox = false;
            this.Controls.Add(this.expandablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rregullime";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbIntervalet)).EndInit();
            this.gbIntervalet.ResumeLayout(false);
            this.gbIntervalet.PerformLayout();
            this.panelIntervale.ResumeLayout(false);
            this.panelIntervale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNrIntervalesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIntervalet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private Janus.Windows.UI.Tab.UITab uiTab1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private System.Windows.Forms.CheckBox cbNdajNeIntervale;
        private Janus.Windows.EditControls.UIGroupBox gbIntervalet;
        private System.Windows.Forms.NumericUpDown numNrIntervalesh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelIntervale;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbFillimi1;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.DateTimePicker dtpMbarimi2;
        private System.Windows.Forms.Label lbMbarimi4;
        private System.Windows.Forms.Label lbMbarimi3;
        private System.Windows.Forms.Label lbMbarimi2;
        private System.Windows.Forms.DateTimePicker dtpMbarimi1;
        private System.Windows.Forms.Label lbMbarimi1;
        private System.Windows.Forms.DateTimePicker dtpFillimi4;
        private System.Windows.Forms.DateTimePicker dtpFillimi3;
        private System.Windows.Forms.DateTimePicker dtpFillimi2;
        private System.Windows.Forms.DateTimePicker dtpFillimi1;
        private System.Windows.Forms.Label lbFillimi4;
        private System.Windows.Forms.Label lbFillimi3;
        private System.Windows.Forms.Label lbFillimi2;
        private System.Windows.Forms.DateTimePicker dtpMbarimi4;
        private System.Windows.Forms.DateTimePicker dtpMbarimi3;
        private System.Windows.Forms.Button btnRuajPerberesRi;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Data.DataSet dsIntervalet;
    }
}