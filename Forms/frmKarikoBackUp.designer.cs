namespace ResManagerAdmin.Forms
{
    partial class frmKarikoBackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKarikoBackUp));
            Janus.Windows.UI.StatusBar.UIStatusBarPanel uiStatusBarPanel11 = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
            Janus.Windows.UI.StatusBar.UIStatusBarPanel uiStatusBarPanel12 = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnAnullo = new System.Windows.Forms.Button();
            this.btnRuaj = new VisionInfoSolutionLibrary.Button();
            this.gridBackUp = new Janus.Windows.GridEX.GridEX();
            this.uiStatusBar = new Janus.Windows.UI.StatusBar.UIStatusBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBackUp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.uiStatusBar);
            this.panelEx1.Controls.Add(this.btnAnullo);
            this.panelEx1.Controls.Add(this.btnRuaj);
            this.panelEx1.Controls.Add(this.gridBackUp);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(452, 458);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 8;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ForeColor = System.Drawing.Color.Navy;
            this.btnAnullo.Image = global::ResManagerAdmin.Properties.Resources.delete_button;
            this.btnAnullo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnullo.Location = new System.Drawing.Point(340, 396);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 37);
            this.btnAnullo.TabIndex = 10;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnullo.UseVisualStyleBackColor = true;
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.DoValidation = true;
            this.btnRuaj.ForeColor = System.Drawing.Color.Navy;
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.dbrestore1;
            this.btnRuaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRuaj.Location = new System.Drawing.Point(34, 396);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.ParentToValidate = null;
            this.btnRuaj.Size = new System.Drawing.Size(75, 37);
            this.btnRuaj.TabIndex = 9;
            this.btnRuaj.Text = "       Kariko";
            this.btnRuaj.UseVisualStyleBackColor = true;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // gridBackUp
            // 
            this.gridBackUp.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridBackUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridBackUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridBackUp.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBackUp.GroupByBoxVisible = false;
            this.gridBackUp.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridBackUp.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridBackUp.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridBackUp.LayoutData = resources.GetString("gridBackUp.LayoutData");
            this.gridBackUp.Location = new System.Drawing.Point(0, 0);
            this.gridBackUp.Name = "gridBackUp";
            this.gridBackUp.Size = new System.Drawing.Size(452, 393);
            this.gridBackUp.TabIndex = 8;
            // 
            // uiStatusBar
            // 
            this.uiStatusBar.Location = new System.Drawing.Point(0, 435);
            this.uiStatusBar.Name = "uiStatusBar";
            uiStatusBarPanel11.Key = "";
            uiStatusBarPanel11.ProgressBarValue = 0;
            uiStatusBarPanel11.Text = "Karikimi i back up-it";
            uiStatusBarPanel11.Width = 130;
            uiStatusBarPanel12.Control = this.btnRuaj;
            uiStatusBarPanel12.Key = "";
            uiStatusBarPanel12.PanelType = Janus.Windows.UI.StatusBar.StatusBarPanelType.ProgressBar;
            uiStatusBarPanel12.ProgressBarValue = 0;
            uiStatusBarPanel12.Width = 314;
            this.uiStatusBar.Panels.AddRange(new Janus.Windows.UI.StatusBar.UIStatusBarPanel[] {
            uiStatusBarPanel11,
            uiStatusBarPanel12});
            this.uiStatusBar.Size = new System.Drawing.Size(452, 23);
            this.uiStatusBar.TabIndex = 11;
            this.uiStatusBar.UseThemes = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmKarikoBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 458);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmKarikoBackUp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kariko back up";
            this.Load += new System.EventHandler(this.frmKarikoBackUp_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBackUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Button btnAnullo;
        private VisionInfoSolutionLibrary.Button btnRuaj;
        private Janus.Windows.GridEX.GridEX gridBackUp;
        public Janus.Windows.UI.StatusBar.UIStatusBar uiStatusBar;
        private System.Windows.Forms.Timer timer;
    }
}