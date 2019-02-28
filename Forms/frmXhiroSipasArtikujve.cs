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
    public partial class frmXhiroSipasArtikujve : System.Windows.Forms.Form, IPrintable
    {
        #region Load Form
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        public frmXhiroSipasArtikujve()
        {
            InitializeComponent();
        }

       

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = gridXhiro;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;

            LexoInformacione();
            cmbKategoriaRecetat.Text = "";
            cmbKategoriaRecetat.SelectedItem = null;
           
            cmbRecetat.Text = "";
            cmbRecetat.SelectedItem = null;

            dtpFillimi.Value = DateTime.Now;
            dtpMbarimi.Value = DateTime.Now;

            DateTime dt1 = dtpFillimi.Value;
            dt1 = dt1.AddHours(-dt1.Hour);
            dt1 = dt1.AddMinutes(-dt1.Minute);
            dt1 = dt1.AddSeconds(-dt1.Second);
            dtpFillimi.Value = dt1;

            DateTime dt2 = dtpMbarimi.Value.AddHours(-dtpMbarimi.Value.Hour);
            dt2 = dt2.AddMinutes(-dt2.Minute);
            dt2 = dt2.AddSeconds(-dt2.Second);
            dtpMbarimi.Value = dt2;

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

        private void MbushKomboKategorite()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteERecetave");
            cmbKategoriaRecetat.DataSource = ds.Tables[0];
        }

        private void MbushGride(string s, string lloji, string koment)
        {
            InputController data = new InputController();
            DataSet dsXhiro = new DataSet();
            if (lloji == "artikujt")
                dsXhiro = data.KerkesaRead("XhirojaPerSecilenDateSipasArtikujve", s);
            else if (lloji == "recetat")
                dsXhiro = data.KerkesaRead("XhirojaPerSecilenDateSipasRecetave", s);
            gridXhiro.DataSource = dsXhiro.Tables[0];
            dsXhiro.Tables.Add("KOMENT_RAPORTI");
            dsXhiro.Tables[1].Columns.Add("KOMENT", typeof(string));
            DataRow newR = dsXhiro.Tables[1].NewRow();
            newR["KOMENT"] = koment;
            dsXhiro.Tables[1].Rows.Add(newR);
            dsXhiro.AcceptChanges();
            dsXhiro.WriteXml(Global.stringXml + "\\xhiroSipasArtikujveRecetave.Xml", XmlWriteMode.WriteSchema);
        }
        #endregion

        #region Event Handlers
        private void cmbKategoriaArtikujt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //InputController data = new InputController();
            //DataSet ds = data.KerkesaRead("ShfaqArtikujtPerKategori", Convert.ToInt32(cmbKategoriaArtikujt.SelectedValue));
           
        }

        private void cmbKategoriaRecetat_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqRecetatPerKategori", Convert.ToInt32(cmbKategoriaRecetat.SelectedValue));
            cmbRecetat.DataSource = ds.Tables[0];
            cmbRecetat.Text = "";
            cmbRecetat.SelectedItem = null;
        }

       

        private void btnKerko_Click(object sender, EventArgs e)
        {
            error1.SetError(dtpFillimi, "");
            
            error1.SetError(cmbKategoriaRecetat, "");
          
            error1.SetError(cmbRecetat, "");
            if (dtpFillimi.Value.Date > dtpMbarimi.Value.Date)
            {
                error1.SetError(dtpFillimi, "Data e fillimit duhet të jetë më e vogël se data e mbarimit!");
                return;
            }
            string koment = "Xhiro efektive sipas artikujve dhe recetave midis datave " + dtpFillimi.Text + " dhe " + dtpMbarimi.Text;
            //kufizimi brenda datave
            //string strSql = " AND CONVERT(DATETIME, CONVERT(char(12), F.DATA_ORA)) BETWEEN '" + dtpFillimi.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpMbarimi.Value.ToString("yyyy-MM-dd") + "'";
           
            if (rbRecetat.Checked)
            {
                if (cmbKategoriaRecetat.Text == "")
                {
                    error1.SetError(cmbKategoriaRecetat, "Zgjidhni një prej kategorive të artikujve!");
                    return;
                }


                //if (cmbRecetat.Text == "" && cmbRecetat.SelectedItem == null)
                //{
                //    error1.SetError(cmbRecetat, "Zgjidhni një prej artikujve!");
                //    return;
                //}

                

                //strSql += " AND R.ID_RECETA = " + Convert.ToInt32(cmbRecetat.SelectedValue);
                ///MbushGride(strSql, "recetat", koment);
                
                int idKatReceta = Convert.ToInt32(this.cmbKategoriaRecetat.SelectedValue);
                int idReceta = 0;

                if (this.cmbRecetat.Text != "")
                {
                    idReceta = Convert.ToInt32(this.cmbRecetat.SelectedValue);
                    koment += ", për recetën " + cmbRecetat.Text;
                }
                else
                {
                    koment += ", për kategorinë e recetave " + cmbKategoriaRecetat.Text;
                }
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine +
                    koment;
                DateTime dateFillimi = this.dtpFillimi.Value;
                DateTime dateMbarimi = this.dtpMbarimi.Value;

                this.MbushGriden(idKatReceta, idReceta, dateFillimi, dateMbarimi);
            }
        }

        private void MbushGriden(int idKatReceta, int idReceta, DateTime dateFillimi, DateTime dateMbarimi)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("XhirojaPerSecilenDateSipasRecetave", idKatReceta, idReceta, dateFillimi, dateMbarimi);

            if (ds == null)
            {
                MessageBox.Show("Ju keni hasur nje problem ne aksesimin e bazes se te dhenave !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.gridXhiro.DataSource = ds.Tables[0];
            }
        }

        private void rbArtikujt_CheckedChanged(object sender, EventArgs e)
        {
            //cmbKategoriaArtikujt.Text = "";
            //cmbKategoriaArtikujt.SelectedItem = null;
        }

        private void rbRecetat_CheckedChanged(object sender, EventArgs e)
        {
            cmbKategoriaRecetat.Text = "";
            cmbKategoriaRecetat.SelectedItem = null;
        }
        #endregion    

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridXhiro.RowCount != 0)
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

        public void Print()
        {
            if (gridXhiro.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public void ConvertToExcel()
        {
            this.gridXhiro.ExpandGroups();
            string[] fushat = new string[5];
            string[] llojet = new string[5];
            string[] key = new string[5];
            fushat[0] = "Ora";
            fushat[1] = "Nr_fature";
            fushat[2] = "Cmimi_i_shitjes";
            fushat[3] = "Sasia";
            fushat[4] = "Vlera_e_xhiros";

            key[0] = "ORA";
            key[1] = "NR_FATURE";
            key[2] = "CMIMIS";
            key[3] = "SASIA";
            key[4] = "TOTALI";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "float";
            llojet[3] = "float";
            llojet[4] = "float";

            KlaseExcel excel = new KlaseExcel("XhiroSipasArtikujve.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("XhiroSipasArtikujve.xls", gridXhiro, fushat, key, llojet,
                    "ORA");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "XhiroSipasArtikujve.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmXhiroSipasArtikujve_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            MbushKomboKategorite();
            btnKerko_Click(sender, e);
        }

       
    }
}