namespace ResManager.Forms
{
    partial class frmKonfigurimPrinteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKonfigurimPrinteri));
            this.paneli = new DevComponents.DotNetBar.PanelEx();
            this.btnAnullo = new DevComponents.DotNetBar.ButtonX();
            this.btnRuaj = new DevComponents.DotNetBar.ButtonX();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnKalo2 = new System.Windows.Forms.Button();
            this.grida4 = new Janus.Windows.GridEX.GridEX();
            this.grida3 = new Janus.Windows.GridEX.GridEX();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.btnKalo1 = new System.Windows.Forms.Button();
            this.grida2 = new Janus.Windows.GridEX.GridEX();
            this.grida1 = new Janus.Windows.GridEX.GridEX();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grida3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grida1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.paneli.Controls.Add(this.btnAnullo);
            this.paneli.Controls.Add(this.btnRuaj);
            this.paneli.Controls.Add(this.uiGroupBox2);
            this.paneli.Controls.Add(this.uiGroupBox1);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(794, 568);
            this.paneli.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.paneli.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.paneli.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneli.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.paneli.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.paneli.Style.GradientAngle = 90;
            this.paneli.TabIndex = 0;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnullo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnullo.Location = new System.Drawing.Point(468, 496);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(102, 41);
            this.btnAnullo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnullo.TabIndex = 3;
            this.btnAnullo.Text = "Anullo";
            // 
            // btnRuaj
            // 
            this.btnRuaj.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuaj.Location = new System.Drawing.Point(296, 496);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(101, 41);
            this.btnRuaj.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnRuaj.TabIndex = 2;
            this.btnRuaj.Text = "Ruaj";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.btnKalo2);
            this.uiGroupBox2.Controls.Add(this.grida4);
            this.uiGroupBox2.Controls.Add(this.grida3);
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox2.Location = new System.Drawing.Point(99, 247);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(629, 227);
            this.uiGroupBox2.TabIndex = 1;
            this.uiGroupBox2.Text = "Fatura e tavolines : ";
            this.uiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnKalo2
            // 
            this.btnKalo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKalo2.Location = new System.Drawing.Point(282, 95);
            this.btnKalo2.Name = "btnKalo2";
            this.btnKalo2.Size = new System.Drawing.Size(75, 39);
            this.btnKalo2.TabIndex = 2;
            this.btnKalo2.Text = "=>";
            this.btnKalo2.UseVisualStyleBackColor = true;
            this.btnKalo2.Click += new System.EventHandler(this.btnKalo2_Click);
            // 
            // grida4
            // 
            this.grida4.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida4.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida4.GridLines = Janus.Windows.GridEX.GridLines.Horizontal;
            this.grida4.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida4.GroupByBoxVisible = false;
            this.grida4.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida4.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida4.LayoutData = resources.GetString("grida4.LayoutData");
            this.grida4.Location = new System.Drawing.Point(383, 50);
            this.grida4.Name = "grida4";
            this.grida4.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida4.Size = new System.Drawing.Size(200, 150);
            this.grida4.TabIndex = 1;
            this.grida4.DoubleClick += new System.EventHandler(this.grida4_DoubleClick);
            // 
            // grida3
            // 
            this.grida3.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida3.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida3.GridLines = Janus.Windows.GridEX.GridLines.Horizontal;
            this.grida3.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida3.GroupByBoxVisible = false;
            this.grida3.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida3.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida3.LayoutData = resources.GetString("grida3.LayoutData");
            this.grida3.Location = new System.Drawing.Point(50, 50);
            this.grida3.Name = "grida3";
            this.grida3.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida3.Size = new System.Drawing.Size(200, 150);
            this.grida3.TabIndex = 0;
            this.grida3.DoubleClick += new System.EventHandler(this.grida3_DoubleClick);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.btnKalo1);
            this.uiGroupBox1.Controls.Add(this.grida2);
            this.uiGroupBox1.Controls.Add(this.grida1);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiGroupBox1.Location = new System.Drawing.Point(99, 26);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(629, 215);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "Fatura e banakut : ";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnKalo1
            // 
            this.btnKalo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKalo1.Location = new System.Drawing.Point(282, 86);
            this.btnKalo1.Name = "btnKalo1";
            this.btnKalo1.Size = new System.Drawing.Size(75, 41);
            this.btnKalo1.TabIndex = 2;
            this.btnKalo1.Text = "=>";
            this.btnKalo1.UseVisualStyleBackColor = true;
            this.btnKalo1.Click += new System.EventHandler(this.btnKalo1_Click);
            // 
            // grida2
            // 
            this.grida2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida2.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida2.GridLines = Janus.Windows.GridEX.GridLines.Horizontal;
            this.grida2.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida2.GroupByBoxVisible = false;
            this.grida2.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida2.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida2.LayoutData = resources.GetString("grida2.LayoutData");
            this.grida2.Location = new System.Drawing.Point(383, 50);
            this.grida2.Name = "grida2";
            this.grida2.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida2.Size = new System.Drawing.Size(200, 150);
            this.grida2.TabIndex = 1;
            this.grida2.DoubleClick += new System.EventHandler(this.grida2_DoubleClick);
            // 
            // grida1
            // 
            this.grida1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida1.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida1.GridLines = Janus.Windows.GridEX.GridLines.Horizontal;
            this.grida1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida1.GroupByBoxVisible = false;
            this.grida1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida1.LayoutData = resources.GetString("grida1.LayoutData");
            this.grida1.Location = new System.Drawing.Point(50, 50);
            this.grida1.Name = "grida1";
            this.grida1.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida1.Size = new System.Drawing.Size(200, 150);
            this.grida1.TabIndex = 0;
            this.grida1.DoubleClick += new System.EventHandler(this.grida1_DoubleClick);
            // 
            // frmKonfigurimPrinteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKonfigurimPrinteri";
            this.Text = "Konfigurimi i printimit";
            this.Load += new System.EventHandler(this.frmKonfigurimPrinteri_Load);
            this.paneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grida3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grida1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx paneli;
        private DevComponents.DotNetBar.ButtonX btnAnullo;
        private DevComponents.DotNetBar.ButtonX btnRuaj;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Janus.Windows.GridEX.GridEX grida2;
        private Janus.Windows.GridEX.GridEX grida1;
        private Janus.Windows.GridEX.GridEX grida4;
        private Janus.Windows.GridEX.GridEX grida3;
        private System.Windows.Forms.Button btnKalo2;
        private System.Windows.Forms.Button btnKalo1;

    }
}