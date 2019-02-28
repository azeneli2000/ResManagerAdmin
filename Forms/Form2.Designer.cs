namespace ResManagerAdmin.Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gridArtikujt = new Janus.Windows.GridEX.GridEX();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.gridBlerjet = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.gridArtikujt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlerjet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridArtikujt
            // 
            this.gridArtikujt.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridArtikujt.Location = new System.Drawing.Point(0, 0);
            this.gridArtikujt.Name = "gridArtikujt";
            this.gridArtikujt.Size = new System.Drawing.Size(400, 376);
            this.gridArtikujt.TabIndex = 0;
            // 
            // gridEX1
            // 
            this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEX1.LayoutData = resources.GetString("gridEX1.LayoutData");
            this.gridEX1.Location = new System.Drawing.Point(157, 67);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.Size = new System.Drawing.Size(454, 344);
            this.gridEX1.TabIndex = 24;
            this.gridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // gridBlerjet
            // 
            this.gridBlerjet.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridBlerjet.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridBlerjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBlerjet.GroupByBoxFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat;
            this.gridBlerjet.GroupByBoxFormatStyle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridBlerjet.GroupByBoxInfoFormatStyle.Alpha = 1;
            this.gridBlerjet.GroupByBoxInfoFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.RaisedLight;
            this.gridBlerjet.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gridBlerjet.GroupByBoxInfoFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.gridBlerjet.GroupByBoxInfoFormatStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridBlerjet.GroupByBoxInfoText = "Tërhiqni një prej kolonave për të grupuar";
            this.gridBlerjet.GroupByBoxVisible = false;
            this.gridBlerjet.GroupRowFormatStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gridBlerjet.GroupRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty;
            this.gridBlerjet.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.Navy;
            this.gridBlerjet.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.gridBlerjet.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridBlerjet.LayoutData = resources.GetString("gridBlerjet.LayoutData");
            this.gridBlerjet.Location = new System.Drawing.Point(9, 16);
            this.gridBlerjet.Name = "gridBlerjet";
            this.gridBlerjet.Size = new System.Drawing.Size(750, 447);
            this.gridBlerjet.TabIndex = 25;
            this.gridBlerjet.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)((((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls)
                        | Janus.Windows.GridEX.ThemedArea.Headers)
                        | Janus.Windows.GridEX.ThemedArea.TreeGliphs)
                        | Janus.Windows.GridEX.ThemedArea.GroupRows)
                        | Janus.Windows.GridEX.ThemedArea.ControlBorder)));
            this.gridBlerjet.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridBlerjet.TotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 479);
            this.Controls.Add(this.gridEX1);
            this.Controls.Add(this.gridBlerjet);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gridArtikujt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlerjet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridArtikujt;
        private Janus.Windows.GridEX.GridEX gridEX1;
        private Janus.Windows.GridEX.GridEX gridBlerjet;
    }
}