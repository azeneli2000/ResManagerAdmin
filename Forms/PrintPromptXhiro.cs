using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResManagerAdmin.Forms
{
    public partial class PrintPromptXhiro : Form
    {
        public string veprimi;
        public PrintPromptXhiro()
        {
            InitializeComponent();
        }

        private void PrintPromptXhiro_Load(object sender, EventArgs e)
        {
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (veprimi == "PrintPreview")
            {
                if (rbPaDetaje.Checked)
                {
                    frmPrintPreview frmPrint = new frmPrintPreview();
                    frmPrint.ZgjidhRaport("xhiroSipasFaturavePaDetaje");
                    frmPrint.ShowDialog();
                }
                else
                {
                    frmPrintPreview frmPrint = new frmPrintPreview();
                    frmPrint.ZgjidhRaport("xhiroSipasFaturaveMeDetaje");
                   frmPrint.ShowDialog();
                }
            }
            else if (veprimi == "Print")
            {
                if (rbPaDetaje.Checked)
                {
                    Raporte.CxhiroSipasFaturavePaDetaje xhiroRaport = new ResManagerAdmin.Raporte.CxhiroSipasFaturavePaDetaje();
                    xhiroRaport.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    xhiroRaport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    xhiroRaport.PrintToPrinter(1, true, 0, 0);
                }
                else
                {
                    Raporte.XhiroSipasFaturaveMeDetaje xhiroRaport = new ResManagerAdmin.Raporte.XhiroSipasFaturaveMeDetaje();
                    xhiroRaport.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    xhiroRaport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    xhiroRaport.PrintToPrinter(1, true, 0, 0);
                }
            }
            Close();
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}