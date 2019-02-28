namespace ResManagerAdmin.Forms
{
    partial class frmZgjidhGrupCmimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZgjidhGrupCmimi));
            this.paneli = new DevComponents.DotNetBar.ExpandablePanel();
            this.lblGrupi = new System.Windows.Forms.Label();
            this.btnAnullo = new DevComponents.DotNetBar.ButtonX();
            this.btnRuaj = new DevComponents.DotNetBar.ButtonX();
            this.grida = new Janus.Windows.GridEX.GridEX();
            this.paneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grida)).BeginInit();
            this.SuspendLayout();
            // 
            // paneli
            // 
            this.paneli.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneli.Controls.Add(this.lblGrupi);
            this.paneli.Controls.Add(this.btnAnullo);
            this.paneli.Controls.Add(this.btnRuaj);
            this.paneli.Controls.Add(this.grida);
            this.paneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneli.ExpandButtonVisible = false;
            this.paneli.Location = new System.Drawing.Point(0, 0);
            this.paneli.Name = "paneli";
            this.paneli.Size = new System.Drawing.Size(994, 586);
            this.paneli.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneli.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.paneli.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.paneli.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.paneli.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.paneli.Style.GradientAngle = 90;
            this.paneli.TabIndex = 0;
            this.paneli.TitleStyle.BackColor1.Color = System.Drawing.Color.White;
            this.paneli.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.paneli.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneli.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.paneli.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paneli.TitleStyle.ForeColor.Color = System.Drawing.Color.Navy;
            this.paneli.TitleStyle.GradientAngle = 90;
            this.paneli.TitleText = "     Zgjidh grupin e cmimeve";
            // 
            // lblGrupi
            // 
            this.lblGrupi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrupi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupi.Location = new System.Drawing.Point(230, 59);
            this.lblGrupi.Name = "lblGrupi";
            this.lblGrupi.Size = new System.Drawing.Size(548, 31);
            this.lblGrupi.TabIndex = 4;
            this.lblGrupi.Text = "Grupi korent :  ";
            this.lblGrupi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnullo
            // 
            this.btnAnullo.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnAnullo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnullo.Image = ((System.Drawing.Image)(resources.GetObject("btnAnullo.Image")));
            this.btnAnullo.Location = new System.Drawing.Point(548, 513);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(110, 35);
            this.btnAnullo.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnAnullo.TabIndex = 3;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuaj.Image = global::ResManagerAdmin.Properties.Resources.button_ok2;
            this.btnRuaj.Location = new System.Drawing.Point(370, 513);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(110, 35);
            this.btnRuaj.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office12;
            this.btnRuaj.TabIndex = 2;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // grida
            // 
            this.grida.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grida.AutomaticSort = false;
            this.grida.Cursor = System.Windows.Forms.Cursors.Default;
            this.grida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grida.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.grida.GroupByBoxVisible = false;
            this.grida.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grida.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.grida.LayoutData = resources.GetString("grida.LayoutData");
            this.grida.Location = new System.Drawing.Point(230, 131);
            this.grida.Name = "grida";
            this.grida.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grida.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grida.Size = new System.Drawing.Size(548, 350);
            this.grida.TabIndex = 1;
            this.grida.Click += new System.EventHandler(this.grida_Click);
            this.grida.CurrentCellChanged += new System.EventHandler(this.grida_CurrentCellChanged);
            // 
            // frmZgjidhGrupCmimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 586);
            this.Controls.Add(this.paneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmZgjidhGrupCmimi";
            this.Text = "Zgjidh grupin e cmimeve";
            this.Load += new System.EventHandler(this.frmZgjidhGrupCmimi_Load);
            this.CausesValidationChanged += new System.EventHandler(this.frmZgjidhGrupCmimi_CausesValidationChanged);
            this.paneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel paneli;
        private Janus.Windows.GridEX.GridEX grida;
        private DevComponents.DotNetBar.ButtonX btnRuaj;
        private DevComponents.DotNetBar.ButtonX btnAnullo;
        private System.Windows.Forms.Label lblGrupi;
    }
}