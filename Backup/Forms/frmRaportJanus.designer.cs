namespace ResManagerAdmin.Forms
{
    partial class frmRaportJanus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRaportJanus));
            this.gridEXPrintDocument1 = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.tbPrintPreview = new System.Windows.Forms.ToolBar();
            this.tbtnMoveUp = new System.Windows.Forms.ToolBarButton();
            this.tbtnMoveDown = new System.Windows.Forms.ToolBarButton();
            this.tbtnSep1 = new System.Windows.Forms.ToolBarButton();
            this.tbtnZoom100 = new System.Windows.Forms.ToolBarButton();
            this.tbtnOnePage = new System.Windows.Forms.ToolBarButton();
            this.tbtnTwoPages = new System.Windows.Forms.ToolBarButton();
            this.tbtnSep2 = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.tbtnPrint = new System.Windows.Forms.ToolBarButton();
            this.ToolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.tbtnClose = new System.Windows.Forms.ToolBarButton();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.PrintPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // gridEXPrintDocument1
            // 
            this.gridEXPrintDocument1.CardColumnsPerPage = 2;
            this.gridEXPrintDocument1.ExpandFarColumn = true;
            this.gridEXPrintDocument1.FitColumns = Janus.Windows.GridEX.FitColumnsMode.NoFit;
            this.gridEXPrintDocument1.GridEX = null;
            this.gridEXPrintDocument1.PageFooterCenter = "";
            this.gridEXPrintDocument1.PageFooterLeft = "";
            this.gridEXPrintDocument1.PageFooterRight = "";
            this.gridEXPrintDocument1.PageHeaderCenter = "";
            this.gridEXPrintDocument1.PageHeaderLeft = "";
            this.gridEXPrintDocument1.PageHeaderRight = "";
            this.gridEXPrintDocument1.PrintBackgroundImage = false;
            this.gridEXPrintDocument1.PrintCollapsedRows = true;
            this.gridEXPrintDocument1.PrintHierarchical = false;
            // 
            // tbPrintPreview
            // 
            this.tbPrintPreview.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbPrintPreview.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbtnMoveUp,
            this.tbtnMoveDown,
            this.tbtnSep1,
            this.tbtnZoom100,
            this.tbtnOnePage,
            this.tbtnTwoPages,
            this.tbtnSep2,
            this.ToolBarButton3,
            this.tbtnPrint,
            this.ToolBarButton4,
            this.tbtnClose});
            this.tbPrintPreview.DropDownArrows = true;
            this.tbPrintPreview.ImageList = this.icons;
            this.tbPrintPreview.Location = new System.Drawing.Point(0, 0);
            this.tbPrintPreview.Name = "tbPrintPreview";
            this.tbPrintPreview.ShowToolTips = true;
            this.tbPrintPreview.Size = new System.Drawing.Size(883, 28);
            this.tbPrintPreview.TabIndex = 1;
            this.tbPrintPreview.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.tbPrintPreview.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbPrintPreview_ButtonClick);
            // 
            // tbtnMoveUp
            // 
            this.tbtnMoveUp.ImageIndex = 0;
            this.tbtnMoveUp.Name = "tbtnMoveUp";
            this.tbtnMoveUp.Tag = "MoveUp";
            this.tbtnMoveUp.ToolTipText = "Faqja e mëparshme";
            // 
            // tbtnMoveDown
            // 
            this.tbtnMoveDown.ImageIndex = 1;
            this.tbtnMoveDown.Name = "tbtnMoveDown";
            this.tbtnMoveDown.Tag = "MoveDown";
            this.tbtnMoveDown.ToolTipText = "Faqja tjetër";
            // 
            // tbtnSep1
            // 
            this.tbtnSep1.Name = "tbtnSep1";
            this.tbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbtnZoom100
            // 
            this.tbtnZoom100.ImageIndex = 3;
            this.tbtnZoom100.Name = "tbtnZoom100";
            this.tbtnZoom100.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbtnZoom100.Tag = "Zoom100";
            this.tbtnZoom100.ToolTipText = "Madhësia aktuale";
            // 
            // tbtnOnePage
            // 
            this.tbtnOnePage.ImageIndex = 2;
            this.tbtnOnePage.Name = "tbtnOnePage";
            this.tbtnOnePage.Pushed = true;
            this.tbtnOnePage.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbtnOnePage.Tag = "OnePage";
            this.tbtnOnePage.ToolTipText = "Një faqe";
            // 
            // tbtnTwoPages
            // 
            this.tbtnTwoPages.ImageIndex = 4;
            this.tbtnTwoPages.Name = "tbtnTwoPages";
            this.tbtnTwoPages.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbtnTwoPages.Tag = "TwoPages";
            this.tbtnTwoPages.ToolTipText = "Dy faqe";
            // 
            // tbtnSep2
            // 
            this.tbtnSep2.Name = "tbtnSep2";
            this.tbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ToolBarButton3
            // 
            this.ToolBarButton3.Name = "ToolBarButton3";
            this.ToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbtnPrint
            // 
            this.tbtnPrint.ImageIndex = 5;
            this.tbtnPrint.Name = "tbtnPrint";
            this.tbtnPrint.Tag = "Print";
            this.tbtnPrint.Text = "Print";
            // 
            // ToolBarButton4
            // 
            this.ToolBarButton4.Name = "ToolBarButton4";
            this.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbtnClose
            // 
            this.tbtnClose.Name = "tbtnClose";
            this.tbtnClose.Tag = "Close";
            this.tbtnClose.Text = "Mbyll";
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "");
            this.icons.Images.SetKeyName(1, "");
            this.icons.Images.SetKeyName(2, "");
            this.icons.Images.SetKeyName(3, "");
            this.icons.Images.SetKeyName(4, "");
            this.icons.Images.SetKeyName(5, "");
            this.icons.Images.SetKeyName(6, "");
            // 
            // PrintPreviewControl1
            // 
            this.PrintPreviewControl1.AutoZoom = false;
            this.PrintPreviewControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintPreviewControl1.Location = new System.Drawing.Point(0, 28);
            this.PrintPreviewControl1.Name = "PrintPreviewControl1";
            this.PrintPreviewControl1.Size = new System.Drawing.Size(883, 479);
            this.PrintPreviewControl1.TabIndex = 2;
            this.PrintPreviewControl1.Tag = "";
            this.PrintPreviewControl1.UseAntiAlias = true;
            this.PrintPreviewControl1.Zoom = 1;
            // 
            // PageSetupDialog1
            // 
            this.PageSetupDialog1.EnableMetric = true;
            // 
            // frmRaportJanus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 507);
            this.Controls.Add(this.PrintPreviewControl1);
            this.Controls.Add(this.tbPrintPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRaportJanus";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Raporti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRaportJanus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.GridEX.GridEXPrintDocument gridEXPrintDocument1;
        internal System.Windows.Forms.ToolBar tbPrintPreview;
        internal System.Windows.Forms.ToolBarButton tbtnMoveUp;
        internal System.Windows.Forms.ToolBarButton tbtnMoveDown;
        internal System.Windows.Forms.ToolBarButton tbtnSep1;
        internal System.Windows.Forms.ToolBarButton tbtnZoom100;
        internal System.Windows.Forms.ToolBarButton tbtnOnePage;
        internal System.Windows.Forms.ToolBarButton tbtnTwoPages;
        internal System.Windows.Forms.ToolBarButton tbtnSep2;
        internal System.Windows.Forms.ToolBarButton ToolBarButton3;
        internal System.Windows.Forms.ToolBarButton tbtnPrint;
        internal System.Windows.Forms.ToolBarButton ToolBarButton4;
        internal System.Windows.Forms.ToolBarButton tbtnClose;
        internal System.Windows.Forms.ImageList icons;
        internal System.Windows.Forms.PrintPreviewControl PrintPreviewControl1;
        internal System.Windows.Forms.PageSetupDialog PageSetupDialog1;
    }
}