using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmBilancDitor : System.Windows.Forms.Form, IPrintable
    {
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;


        #region Load Form
        public frmBilancDitor()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = gridaPeriudha;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes 
                + Environment.NewLine + "Bilanci ditor i përmbledhur midis datave " + dateFillimi.Value.ToString("dd.MM.yyyy") + 
                " dhe " + dateMbarimi.Value.ToString("dd.MM.yyyy");

            LexoInformacione();
            dateFillimi.Value = DateTime.Now;
            dateMbarimi.Value = DateTime.Now;

            DateTime dt1 = dateFillimi.Value;
            dt1 = dt1.AddHours(-dt1.Hour);
            dt1 = dt1.AddMinutes(-dt1.Minute);
            dt1 = dt1.AddSeconds(-dt1.Second);
            dateFillimi.Value = dt1;

            DateTime dt2 = dateMbarimi.Value.AddHours(-dateMbarimi.Value.Hour);
            dt2 = dt2.AddMinutes(-dt2.Minute);
            dt2 = dt2.AddSeconds(-dt2.Second);
            dateMbarimi.Value = dt2;
        }
        #endregion

        #region PrivateMethods
        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            DateTime dtFillimi = this.dateFillimi.Value.Date;
            DateTime dtMbarimi = this.dateMbarimi.Value.Date;

            if (dtFillimi > dtMbarimi)
            {
                MessageBox.Show("Data e fillimit nuk mund te jete me e madhe se data e mbarimit.", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqBilancinPerPeriudhen", dtFillimi, dtMbarimi);

            if (ds != null)
            {
                this.gridaPeriudha.DataSource = ds.Tables[0];
            }

        }

        private void frmBilancDitor_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            btnKerko_Click(sender, e);
        }

     
        #region Event Handlers
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridaPeriudha.RowCount != 0)
            {
                frmRaportJanus frmPrint = new frmRaportJanus();
                frmPrint.PrintPreviewControl1.Document = Doc;
                frmPrint.ShowDialog();
            }
        }

        public bool ReadyToPrint
        {
            get
            {
                return this.readyToPrint;
            }
            set
            {
                bool oldValue = readyToPrint;
                readyToPrint = value;
                if (ReadyToPrintChanged != null && value != oldValue)
                    ReadyToPrintChanged(this, new ReadyChangedEventArgs());
            }
        }

        public void ConvertToExcel()
        {
            string[] fushat = new string[5];
            string[] llojet = new string[5];
            string[] key = new string[5];
            fushat[0] = "Data";
            fushat[1] = "Fitimi";
            fushat[2] = "Shpenzimi_ditor";
            fushat[3] = "Shpenzimi_mujor";
            fushat[4] = "Bilanci";

            key[0] = "DATABILANCI";
            key[1] = "FITIMI";
            key[2] = "SHPENZIMI_DITOR";
            key[3] = "SHPENZIMI_MUJOR";
            key[4] = "BILANCI";

            llojet[0] = "char(255)";
            llojet[1] = "float";
            llojet[2] = "float";
            llojet[3] = "float";
            llojet[4] = "float";

            KlaseExcel excel = new KlaseExcel("BilancDitor.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGride("BilancDitor.xls", gridaPeriudha, fushat, key, llojet, "DATABILANCI");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "BilancDitor.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Janus.Windows.GridEX.GridEXPrintDocument Doc
        {
            get
            {
                return this.doc;
            }
            set
            {
                doc = value;
            }
        }

        public void Print()
        {
            if (gridaPeriudha.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion
    }
}