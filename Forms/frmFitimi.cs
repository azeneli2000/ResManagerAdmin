using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerLibrary;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmFitimi : System.Windows.Forms.Form, IPrintable
    {
        private bool readyToPrint = true;
        private int zgjedhur = 0;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        #region Load Form
        public frmFitimi()
        {
            InitializeComponent();
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;

            this.LexoInformacione();
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
     
        #region Event Handlers
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            frmZgjidhPrintiminFitimi frm = new frmZgjidhPrintiminFitimi();
            frm.ShowDialog();
            if ((frm.zgjedhja == 1) && (gridaFitimi.RowCount != 0))
            {
                Doc.GridEX = gridaFitimi;
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine +
                    "Fitimi i përmbledhur midis datave " + dateFillimi.Value.ToString("dd.MM.yyyy") + " dhe " + 
                        dateMbarimi.Value.ToString("dd.MM.yyyy");
                frmRaportJanus frmPrint = new frmRaportJanus();
                frmPrint.PrintPreviewControl1.Document = Doc;
                frmPrint.ShowDialog();
            }
            else if ((frm.zgjedhja == 2) && (gridaFaturat.RowCount != 0))
            {
                Doc.GridEX = gridaFaturat;
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine +
                    "Fitimi i detajuar për datën " + gridaFitimi.GetRow(gridaFitimi.Row).Cells["DATAFITIMI"].Text;
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
            frmZgjidhPrintiminFitimi frm = new frmZgjidhPrintiminFitimi();
            frm.label1.Text = "Zgjidhni se cilën prej tabelave doni të konvertoni në Excel:";
            frm.ShowDialog();
            if ((frm.zgjedhja == 1) && (gridaFitimi.RowCount != 0))
            {
                this.ExcelGridaDatat();
            }
            else if ((frm.zgjedhja == 2) && (gridaFaturat.RowCount != 0))
            {
                ExcelGridaDetaje();
            }
        }

        public void Print()
        {
            frmZgjidhPrintiminFitimi frm = new frmZgjidhPrintiminFitimi();
            frm.ShowDialog();
            if ((frm.zgjedhja == 1) && (gridaFitimi.RowCount != 0))
            {
                Doc.GridEX = gridaFitimi;
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine +
                    "Fitimi i përmbledhur midis datave " + dateFillimi.Value.ToString("dd.MM.yyyy") + " dhe " +
                        dateMbarimi.Value.ToString("dd.MM.yyyy");
                Doc.Print();
            }
            else if ((frm.zgjedhja == 2) && (gridaFaturat.RowCount != 0))
            {
                Doc.GridEX = gridaFaturat;
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine +
                    "Fitimi i detajuar për datën " + gridaFitimi.GetRow(gridaFitimi.Row).Cells["DATAFITIMI"].Text;
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

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

        #endregion

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateFitimiFirst = dateFillimi.Value;
            DateTime dateFitimiLast = dateMbarimi.Value;

            DateTime dtFirst = dateFitimiFirst;
            DateTime dtLast = dateFitimiLast.AddMinutes(1);

            if (dtFirst > dtLast)
            {
                MessageBox.Show("Data e fillimit nuk mund te jete me e madhe se data e mbarimit!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqniFitiminPerPeriudhen", dateFitimiFirst, dateFitimiLast);

            this.gridaFitimi.DataSource = ds.Tables[0];

            string data1 = dateFitimiFirst.ToString("dd.MM.yyyy");
            string data2 = dateFitimiLast.ToString("dd.MM.yyyy");

            this.grupFitimi.Text = "Fitimi per periudhen :   " + data1 + " - " + data2;

            this.zgjedhur = 0;

        }

        private void gridaFitimi_CurrentCellChanged(object sender, EventArgs e)
        {
            this.zgjedhur = this.zgjedhur + 1;

            if (this.zgjedhur == 1)
            {
                return;
            }


            int indeksi = this.gridaFitimi.Row;

            if (indeksi < 0 || indeksi >= this.gridaFitimi.RowCount - 1)
            {
                return;
            }

            DateTime dataFitimi = Convert.ToDateTime(this.gridaFitimi.GetRow(indeksi).Cells[0].Text);

            DataSet ds = ShfaqFaturatPerDaten(dataFitimi);
            if (ds == null)
            {
                MessageBox.Show("Ju keni hasur nje problem ne aksesimin e te te dhenave!", "Gabim !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.gridaFaturat.DataSource = ds.Tables[0];

            string dataZgjedhur = dataFitimi.ToString("dd.MM.yyyy");

            this.lblFitimi.Text = "Fitimi per daten :  " + dataZgjedhur;

            
        }

        private DataSet ShfaqFaturatPerDaten(DateTime dateFatura)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqFaturatPerDatenZgjedhur", dateFatura);

            return ds;
        }

        private void frmFitimi_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            button1_Click( sender,  e);
        }

        private void ExcelGridaDatat()
        {
            string[] fushat = new string[2];
            string[] llojet = new string[2];
            string[] key = new string[2];

            fushat[0] = "Data";
            fushat[1] = "Vlera_e_fitimit";

            key[0] = "DATAFITIMI";
            key[1] = "FITIMI";

            llojet[0] = "char(255)";
            llojet[1] = "float";

            KlaseExcel excel = new KlaseExcel("FitimiSipasDatave.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGride("FitimiSipasDatave.xls", gridaFitimi, fushat, key, llojet, "DATAFITIMI");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "FitimiSipasDatave.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExcelGridaDetaje()
        {
            string[] fushat = new string[4];
            string[] llojet = new string[4];
            string[] key = new string[4];
            fushat[0] = "Nr_Fatura";
            fushat[1] = "Vlera";
            fushat[2] = "Kosto";
            fushat[3] = "Fitimi";

            key[0] = "NR_FATURE";
            key[1] = "VLERA";
            key[2] = "KOSTO";
            key[3] = "FITIMI";

            llojet[0] = "char(255)";
            llojet[1] = "float";
            llojet[2] = "float";
            llojet[3] = "float";

            KlaseExcel excel = new KlaseExcel("DetajeFitimiPerDaten.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("DetajeFitimiPerDaten.xls", gridaFaturat,
                    fushat, key, llojet, "NR_FATURE");
                
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "DetajeFitimiPerDaten.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}