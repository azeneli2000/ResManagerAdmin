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
    public partial class frmKontrolloSkorte : System.Windows.Forms.Form, IPrintable
    {
        private bool nenSkorte = false;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        #region Form Load
        public frmKontrolloSkorte()
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


        private void frmKontrolloSkorte_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = grida;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Inventari për artikujt";


            this.LexoInformacione();

            this.MbushKomboKategorite();
            AddConditionalFormatting();

            this.BllokoKerkimin();
            this.MbushGriden();
        }
        #endregion

        #region Private Methods
        private void MbushKomboKategorite()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEArtikujve");
            this.cboKategoria.DataSource = ds.Tables[0];


        }

        private DataSet KonvertoDataSetin(DataSet ds)
        {
            DataSet dsNew = new DataSet();
            dsNew.Tables.Add();

            dsNew.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            dsNew.Tables[0].Columns.Add("FOTO", typeof(Image));
            dsNew.Tables[0].Columns.Add("EMRI", typeof(string));
            dsNew.Tables[0].Columns.Add("ID_KATEGORIAARTIKULLI", typeof(Int32));
            dsNew.Tables[0].Columns.Add("PERSHKRIMI", typeof(string));
            dsNew.Tables[0].Columns.Add("SASIA_SKORTE", typeof(double));
            dsNew.Tables[0].Columns.Add("NUMRI_TOTAL", typeof(double));
            dsNew.Tables[0].Columns.Add("DIFERENCA", typeof(double));

            dsNew.AcceptChanges();
            DataRow drNew = null;
            string pathiFoto = "";
            Image foto = null;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                drNew = dsNew.Tables[0].NewRow();

                drNew["ID_ARTIKULLI"] = dr["ID_ARTIKULLI"];
                pathiFoto = Convert.ToString(dr["FOTO"]);
                if (pathiFoto == "")
                {
                    foto = null;
                }
                else
                {
                    foto = Image.FromFile(pathiFoto);
                }

                drNew["FOTO"] = foto;
                drNew["EMRI"] = dr["EMRI"];
                drNew["ID_KATEGORIAARTIKULLI"] = dr["ID_KATEGORIAARTIKULLI"];
                drNew["PERSHKRIMI"] = dr["PERSHKRIMI"];
                drNew["SASIA_SKORTE"] = dr["SASIA_SKORTE"];
                drNew["NUMRI_TOTAL"] = Convert.ToDecimal(Convert.ToDecimal(dr["NUMRI_TOTAL"]).ToString(".00"));
                drNew["DIFERENCA"] = Convert.ToDouble(dr["NUMRI_TOTAL"]) - Convert.ToDouble(dr["SASIA_SKORTE"]);
                drNew["DIFERENCA"] = Convert.ToDecimal(drNew["DIFERENCA"]).ToString(".00");
                dsNew.Tables[0].Rows.Add(drNew);


            }

            dsNew.Tables[0].AcceptChanges();

            return dsNew;
        }

        private void FormatoGride()
        {
            if (grida.RowCount <= 25)
            {
                grida.RootTable.Columns["colArtikulli"].Width = 221;
            }
            else
            {
                grida.RootTable.Columns["colArtikulli"].Width = 203;
            }
        }

        private void AddConditionalFormatting()
        {
            GridEXFormatCondition fc = new GridEXFormatCondition(
                this.grida.RootTable.Columns["colDiferenca"],
                ConditionOperator.LessThan, 0);
            fc.FormatStyle.ForeColor = Color.Red;
            this.grida.RootTable.FormatConditions.Add(fc);

        }

        #endregion

        #region Event Handlers
        private void chkArtikulli_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkArtikulli.Checked == true)
            {
                this.txtEmriArtikulli.Text = "";
                this.txtEmriArtikulli.Enabled = true;
            }
            else
            {
                this.txtEmriArtikulli.Text = "";
                this.txtEmriArtikulli.Enabled = false;
                this.txtEmriArtikulli.BackColor = Color.White;
                
            }
        }

        private void chkKategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkKategoria.Checked == true)
            {
                this.cboKategoria.Enabled = true;
            }
            else
            {
                this.cboKategoria.Value = null;
                this.cboKategoria.Enabled = false;
                this.cboKategoria.BackColor = Color.White;
                
            }


        }

        private void BllokoKerkimin()
        {
            this.txtEmriArtikulli.Text = "";
            this.txtEmriArtikulli.Enabled = false;
            this.txtEmriArtikulli.BackColor = Color.White;

            this.cboKategoria.Value = null;
            this.cboKategoria.Enabled = false;
            this.cboKategoria.BackColor = Color.White;

            this.chkArtikulli.Checked = false;
                
        }

        private void chkNenSkorte_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkNenSkorte.Checked == true)
            {
                this.nenSkorte = true;
            }
            else
            {
                this.nenSkorte = false;
            }
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            int zgjedhja = 0;
            string artikulli = "";
            int idKategoria = 0;
            string strDesc = "Inventari për artikujt";
            if ((this.chkArtikulli.Checked == false) && (this.chkKategoria.Checked == false) && (this.chkNenSkorte.Checked == false))
            {
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + strDesc;
                return;
            }
            if (this.chkArtikulli.Checked == true)
            {
                zgjedhja = zgjedhja + 1;
                artikulli = this.txtEmriArtikulli.Text.Trim();
                strDesc += " me emër " + artikulli;
            }

            if (this.chkKategoria.Checked == true)
            {
                if (zgjedhja == 0)
                    strDesc += " e kategorisë " + cboKategoria.Text;
                else
                    strDesc += ", të kategorisë " + cboKategoria.Text;
                zgjedhja = zgjedhja + 2;
                idKategoria = Convert.ToInt32(this.cboKategoria.Value);
                
            }
            if (this.chkNenSkorte.Checked == true)
            {
                zgjedhja = zgjedhja + 4;
                strDesc += " që janë nën gjendjen kritike";
            }
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + strDesc;
            if (zgjedhja == 0)
            {
                this.MbushGriden();
                return;
            }

            InputController data = new InputController();
            DataSet ds = null;

            ds = data.KerkesaRead("ShfaqArtikujtSipasZgjedhjes", zgjedhja, idKategoria, artikulli);

            DataSet dsNew = this.KonvertoDataSetin(ds);
            this.grida.DataSource = dsNew.Tables[0];
            FormatoGride();
        }

        private void MbushGriden()
        {
            
            InputController data = new InputController();
            DataSet ds = null;

            ds = data.KerkesaRead("ShfaqArtikujtSipasZgjedhjes", 1, 1, "");

            DataSet dsNew = this.KonvertoDataSetin(ds);
            this.grida.DataSource = dsNew.Tables[0];
            //FormatoGride();
        }

        #endregion

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
            string[] fushat = new string[4];
            string[] llojet = new string[4];
            string[] key = new string[4];
            fushat[0] = "Artikulli";
            fushat[1] = "Sasia_e_mbetur";
            fushat[2] = "Sasia_e_skortes";
            fushat[3] = "Diferenca";

            key[0] = "colArtikulli";
            key[1] = "colSasiaMbetur";
            key[2] = "colSasiaSkorte";
            key[3] = "colDiferenca";

            llojet[0] = "char(255)";
            llojet[1] = "float";
            llojet[2] = "float";
            llojet[3] = "float";

            KlaseExcel excel = new KlaseExcel("Inventari.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("Inventari.xls", grida, fushat, key, llojet,
                    "colArtikulli");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Inventari.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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