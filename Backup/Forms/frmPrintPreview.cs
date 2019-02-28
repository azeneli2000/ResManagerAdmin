using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResManagerAdmin.Forms
{
    public partial class frmPrintPreview : Form
    {
        public frmPrintPreview()
        {
            InitializeComponent();
        }

        public void ZgjidhRaport(string emriRaporti)
        {
            switch (emriRaporti)
            {
                case "arka":
                    Raporte.arka arkaRaport = new ResManagerAdmin.Raporte.arka();
                    arkaRaport.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    arkaRaport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    crystalReportViewer1.ReportSource = arkaRaport;
                    break;
                case "xhiroSipasFaturavePaDetaje":
                    Raporte.CxhiroSipasFaturavePaDetaje xhiroRaport = new ResManagerAdmin.Raporte.CxhiroSipasFaturavePaDetaje();
                    xhiroRaport.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    xhiroRaport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    crystalReportViewer1.ReportSource = xhiroRaport;
                    break;
                case "xhiroSipasFaturaveMeDetaje":
                    Raporte.XhiroSipasFaturaveMeDetaje xhiroRaport1 = new ResManagerAdmin.Raporte.XhiroSipasFaturaveMeDetaje();
                    xhiroRaport1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    xhiroRaport1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    crystalReportViewer1.ReportSource = xhiroRaport1;
                    break;
                case "xhiroSipasArtikujveRecetave":
                    Raporte.XhiroSipasFaturaveMeDetaje xhiroRaport2 = new ResManagerAdmin.Raporte.XhiroSipasFaturaveMeDetaje();
                    xhiroRaport2.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                    xhiroRaport2.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                    crystalReportViewer1.ReportSource = xhiroRaport2;
                    break;
            }
        }
    }
}