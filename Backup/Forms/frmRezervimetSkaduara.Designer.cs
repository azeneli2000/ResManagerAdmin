namespace ResManagerAdmin.Forms
{
	partial class frmRezervimetSkaduara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervimetSkaduara));
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.gridEXRezervimet = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnModifiko = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnFshi = new System.Windows.Forms.Button();
            this.ds = new System.Data.DataSet();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXRezervimet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // tabItem1
            // 
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "tabItem1";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.gridEXRezervimet);
            this.panelEx1.Controls.Add(this.uiGroupBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(544, 506);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // gridEXRezervimet
            // 
            this.gridEXRezervimet.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEXRezervimet.GroupByBoxVisible = false;
            this.gridEXRezervimet.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEXRezervimet.LayoutData = resources.GetString("gridEXRezervimet.LayoutData");
            this.gridEXRezervimet.Location = new System.Drawing.Point(27, 58);
            this.gridEXRezervimet.Name = "gridEXRezervimet";
            this.gridEXRezervimet.Size = new System.Drawing.Size(485, 380);
            this.gridEXRezervimet.TabIndex = 3;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btnModifiko);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.btnAnullo);
            this.uiGroupBox1.Controls.Add(this.btnFshi);
            this.uiGroupBox1.Image = global::ResManagerAdmin.Properties.Resources.INFO;
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(517, 480);
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = "Rezervimeve të mëposhtme u ka kaluar afati.";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnModifiko
            // 
            this.btnModifiko.ForeColor = System.Drawing.Color.Navy;
            this.btnModifiko.Image = global::ResManagerAdmin.Properties.Resources.forum_newmsg;
            this.btnModifiko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifiko.Location = new System.Drawing.Point(227, 442);
            this.btnModifiko.Name = "btnModifiko";
            this.btnModifiko.Size = new System.Drawing.Size(75, 30);
            this.btnModifiko.TabIndex = 30;
            this.btnModifiko.Text = "Modifiko";
            this.btnModifiko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifiko.UseVisualStyleBackColor = true;
            this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 39);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mund të zgjidhni disa prej rezervimeve për të fshirë ose vetëm një prej rezervime" +
                "ve për të modifikuar.";
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(411, 442);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 30);
            this.btnAnullo.TabIndex = 28;
            this.btnAnullo.Text = "Dil";
            this.btnAnullo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnFshi
            // 
            this.btnFshi.ForeColor = System.Drawing.Color.Navy;
            this.btnFshi.Image = global::ResManagerAdmin.Properties.Resources.cancelbuild;
            this.btnFshi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFshi.Location = new System.Drawing.Point(49, 442);
            this.btnFshi.Name = "btnFshi";
            this.btnFshi.Size = new System.Drawing.Size(75, 30);
            this.btnFshi.TabIndex = 27;
            this.btnFshi.Text = "Fshi";
            this.btnFshi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFshi.UseVisualStyleBackColor = true;
            this.btnFshi.Click += new System.EventHandler(this.btnFshi_Click);
            // 
            // ds
            // 
            this.ds.DataSetName = "NewDataSet";
            // 
            // frmRezervimetSkaduara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 506);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRezervimetSkaduara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "...0.0";
            this.Load += new System.EventHandler(this.frmRezervimetSkaduara_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXRezervimet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Janus.Windows.GridEX.GridEX gridEXRezervimet;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Button btnFshi;
        private System.Windows.Forms.Button btnAnullo;
        public System.Data.DataSet ds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifiko;
	}
}