using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResManagerAdmin.Forms
{
    public partial class frmRaportJanus : Form
    {
        public frmRaportJanus()
        {
            InitializeComponent();
        }

        private void tbPrintPreview_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch(e.Button.Tag.ToString())
            {
                case "MoveUp":
                    if (this.PrintPreviewControl1.StartPage - 1 >= 0)
                        this.PrintPreviewControl1.StartPage = this.PrintPreviewControl1.StartPage - 1;
                    break;
                case "MoveDown":
                    this.PrintPreviewControl1.StartPage = this.PrintPreviewControl1.StartPage + 1;
                    break;
                case "Zoom100":
                    this.tbtnOnePage.Pushed = false;
                    this.tbtnTwoPages.Pushed = false;
                    this.PrintPreviewControl1.AutoZoom = false;
                    this.PrintPreviewControl1.Zoom = 1;
                    break;
                case "OnePage":
                    this.tbtnZoom100.Pushed = false;
                    this.tbtnTwoPages.Pushed = false;
                    this.PrintPreviewControl1.AutoZoom = true;
                    this.PrintPreviewControl1.Rows = 1;
                    this.PrintPreviewControl1.Columns = 1;
                    break;
                case "TwoPages":
                    this.tbtnOnePage.Pushed = false;
                    this.tbtnZoom100.Pushed = false;
                    this.PrintPreviewControl1.AutoZoom = true;
                    this.PrintPreviewControl1.Rows = 1;
                    this.PrintPreviewControl1.Columns = 2;
                    break;
                case "PageSetup":
                    this.PageSetupDialog1.Document = this.PrintPreviewControl1.Document;
                    if (this.PageSetupDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        
                        System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                        doc = this.PrintPreviewControl1.Document;
                        this.PrintPreviewControl1.Document = doc;
                    }
                    break;
                case "Print":
                    this.PrintPreviewControl1.Document.Print();
                    this.Close();
                    break;
                case "Close":
                    this.Close();
                    break;
            }
        }

        private void frmRaportJanus_Load(object sender, EventArgs e)
        {
            
        }
    }
}