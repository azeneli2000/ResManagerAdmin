using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using Janus.Windows.GridEX;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmArka : System.Windows.Forms.Form, IPrintable
    {
        #region Load Form
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        public frmArka()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = gridArka;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes +
                Environment.NewLine + "Gjendja e arkës për datën " + DateTime.Now.ToString("dd.MM.yyyy");

            DateTime[] v = new DateTime[1];
            v[0] = DateTime.Now;
            calendar.SelectedDates = v;
            calendar.CurrentDate = System.DateTime.Today;
            LexoInformacione();
            //kontrollo ketu nqs eshte programi i hotelit
            //per te shfaqur modulet e duhur
            
        }
        #endregion

        #region Private Methods
        private void LexoInformacione()
        {
            InputController data = new InputController();
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void ShfaqGjendjeArka()
        {
            InputController data = new InputController();
            DateTime dt = calendar.CurrentDate.Date;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes +
                Environment.NewLine + "Gjendja e arkës për datën " + dt.ToString("dd.MM.yyyy");
            DataSet dsArka = data.KerkesaRead("ShfaqGjendjeArka", dt);
            gridArka.DataSource = dsArka.Tables[0];
            //gjejme sasine per formen e pageses cash
            DataRow drCash = dsArka.Tables[0].Rows.Find(1);
            double sasia = Convert.ToDouble(drCash["VLERA_HEDHUR"]);
            txtCash.Text = sasia.ToString();
            if (dt.Date == DateTime.Now.Date)
                gbCash.Text = "Gjendja fizike(cash) në arkë për sot";
            else
                gbCash.Text = "Gjendja fizike(cash) në arkë për datën " + dt.ToString("dd.MM.yyyy");
            dsArka.Tables.Add();
            //konfigurohet dataseti per printim
            dsArka.Tables[1].Columns.Add("TEKST", typeof(String));
            DataRow newR = dsArka.Tables[1].NewRow();
            newR["TEKST"] = gbCash.Text;
            dsArka.Tables[1].Rows.Add(newR);
            dsArka.AcceptChanges();
            dsArka.WriteXml(Global.stringXml + "\\arka.Xml", XmlWriteMode.WriteSchema);
            FormatoGride();
        }

        private void FormatoGride()
        {
            if (gridArka.RowCount <= 12)
            {
                gridArka.RootTable.Columns["KOMISIONI"].Width = 100;
            }
            else
            {
                gridArka.RootTable.Columns["KOMISIONI"].Width = 83;
            }
        }
        #endregion
       
        #region Event Handlers
        private void btnSot_Click(object sender, EventArgs e)
        {
            calendar.CurrentDate = DateTime.Now;
        }

        private void calendar_SelectionChanged(object sender, EventArgs e)
        {
            ShfaqGjendjeArka();
        }
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridArka.RowCount != 0)
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
            string[] fushat = new string[4];
            string[] llojet = new string[4];
            string[] key = new string[4];
            fushat[0] = "Forma_e_pagesës";
            fushat[1] = "Vlera_e_hedhur";
            fushat[2] = "Komisioni";
            fushat[3] = "Vlera_me_komision";

            key[0] = "FORMA_PAGESA";
            key[1] = "VLERA_HEDHUR";
            key[2] = "KOMISIONI";
            key[3] = "VLERA_KOMISION";

            llojet[0] = "char(255)";
            llojet[1] = "float";
            llojet[2] = "float";
            llojet[3] = "float";

            KlaseExcel excel = new KlaseExcel("Arka.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGride("Arka.xls", gridArka, fushat, key, llojet, "FORMA_PAGESA");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Arka.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Print()
        {
            if (gridArka.RowCount != 0)
            {
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

        private void frmArka_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            ShfaqGjendjeArka();
        }

    }
}