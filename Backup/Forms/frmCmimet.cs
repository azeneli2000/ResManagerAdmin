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
    public partial class frmCmimet : System.Windows.Forms.Form, IPrintable
    {
        private DataSet dsRecetat = null;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        public frmCmimet()
        {
            InitializeComponent();
        }

        private DataSet KrijoDataSetRecetat()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("EMRI", typeof(string));
            ds.Tables[0].Columns.Add("ID_KATEGORIARECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("PERSHKRIMI", typeof(string));
            ds.Tables[0].Columns.Add("CMIMI", typeof(decimal));
            ds.Tables[0].Columns.Add("KOSTO", typeof(decimal));

            ds.AcceptChanges();

            return ds;
        }

        private void frmCmimet_Load(object sender, EventArgs e)
        {
            this.LexoInformacione();
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = grida;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
        }

        private void MbushKomboGrupi()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqGrupCmimet");

            if (data != null)
            {
                this.cboGrupet.DataSource = ds.Tables[0];
            }
        }

        private void cboGrupet_ValueChanged(object sender, EventArgs e)
        {

            if (this.cboGrupet.Text.Trim() == "")
            {
                return;
            }

            this.dsRecetat.Tables[0].Rows.Clear();

            int idGrupi = Convert.ToInt32(this.cboGrupet.Value);

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqCmimeRecetatPerGrupinZgjedhur", idGrupi);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = this.dsRecetat.Tables[0].NewRow();

                drNew["ID_RECETA"] = dr["ID_RECETA"];
                drNew["EMRI"] = dr["EMRI"];
                drNew["ID_KATEGORIARECETA"] = dr["ID_KATEGORIARECETA"];
                drNew["PERSHKRIMI"] = dr["PERSHKRIMI"];
                drNew["CMIMI"] = dr["CMIMI"];
                drNew["KOSTO"] = dr["KOSTO"];

                this.dsRecetat.Tables[0].Rows.Add(drNew);
            }

            this.dsRecetat.Tables[0].AcceptChanges();
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Çmimet e recetave sipas grupit të çmimeve " + cboGrupet.Text;


        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            if (this.cboGrupet.Text.Trim() == "")
            {
                return;
            }

            this.dsRecetat.Tables[0].Rows.Clear();

            int idGrupi = Convert.ToInt32(this.cboGrupet.Value);

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqCmimeRecetatPerGrupinZgjedhur", idGrupi);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = this.dsRecetat.Tables[0].NewRow();

                drNew["ID_RECETA"] = dr["ID_RECETA"];
                drNew["EMRI"] = dr["EMRI"];
                drNew["ID_KATEGORIARECETA"] = dr["ID_KATEGORIARECETA"];
                drNew["PERSHKRIMI"] = dr["PERSHKRIMI"];
                drNew["CMIMI"] = dr["CMIMI"];
                drNew["KOSTO"] = dr["KOSTO"];

                this.dsRecetat.Tables[0].Rows.Add(drNew);
            }

            this.dsRecetat.Tables[0].AcceptChanges();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (this.cboGrupet.Text.Trim() == "")
            {
                return;
            }

            int idGrupi = Convert.ToInt32(this.cboGrupet.Value);

            InputController data = new InputController();
            int b = data.KerkesaUpdate("ModifikoCmimeRecetatPerGrup", idGrupi, this.dsRecetat);

            if (b == 0)
            {
                MessageBox.Show(this, "Cmimet e recetave per grupin e zgjedhur u modifikuan !", "Cmimet e recetave !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "Nje gabim ndodhi ne modifikim e cmimeve te recetave  !" + Environment.NewLine + "Ju lutem , provoni perseri !", "Cmimet e recetave !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.paneli.TitleText = s;
        }

        private void frmCmimet_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            this.MbushKomboGrupi();
            this.dsRecetat = this.KrijoDataSetRecetat();
            this.grida.DataSource = this.dsRecetat.Tables[0];

        }

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.grida.RowCount != 0)
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
            grida.ExpandGroups();
            string[] fushat = new string[3];
            string[] llojet = new string[3];
            string[] key = new string[3];
            fushat[0] = "Receta";
            fushat[1] = "Kosto";
            fushat[2] = "Cmimi";

            key[0] = "EMRI";
            key[1] = "KOSTO";
            key[2] = "CMIMI";

            llojet[0] = "char(255)";
            llojet[1] = "float";
            llojet[2] = "float";

            KlaseExcel excel = new KlaseExcel("Cmimet.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("Cmimet.xls", grida, fushat, key, llojet,
                    "EMRI");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Cmimet.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (grida.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion
    }
}