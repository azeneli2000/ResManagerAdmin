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
    public partial class frmArtikujFurnitore : System.Windows.Forms.Form, IPrintable
    {
        #region Form Load
        private int upDirection = 0;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;



        public frmArtikujFurnitore()
        {
            InitializeComponent();
        }

        private void frmKonfigurimArtikujsh_Load(object sender, EventArgs e)
        {
            gridFurnitoret.BringToFront();
            LexoInformacione();

            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = gridFurnitoret;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Përkatësitë a artikujve për furnitorët";
        }
        #endregion

        #region Private Methods
        private void CaktivizoPanel(System.Windows.Forms.Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Button)
                    c.Enabled = false;
            }
        }

        private void AktivizoPanel(System.Windows.Forms.Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Button)
                    c.Enabled = true;
            }
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void MbushGride(string kushti)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqArtikujtPerFurnitoret", kushti);
            gridFurnitoret.DataSource = ds.Tables[0];
            ///FormatoGride(gridFurnitoret);
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.Name == "gridFurnitoret")
            {
                if (grid.RowCount <= 23)
                    grid.RootTable.Columns["ARTIKULLI"].Width = 288;
                else
                    grid.RootTable.Columns["ARTIKULLI"].Width = 271;
            }
            else
            {
                if (grid.RowCount <= 12)
                    grid.RootTable.Columns["EMRI"].Width = 158;
                else
                    grid.RootTable.Columns["EMRI"].Width = 141;
            }
        }

        private void Pastro()
        {
            cmbKategoria.Text = "";
            cmbKategoria.Value = null;
            dsArtikujZgjedhur.Tables[0].Rows.Clear();
            dsArtikujKategori.Tables[0].Rows.Clear();
        }

        private void Ploteso(int i)
        {
            dsArtikujZgjedhur.Tables[0].Rows.Clear();
            bool ugjet = false;
            int idFurnitori = Convert.ToInt32(gridFurnitoret.GetRow(i).Cells["ID_FURNITORI"].Text);
            for (int j = 0; j < gridFurnitoret.RowCount; j++)
            {
                if (gridFurnitoret.GetRow(j).Cells["ID_FURNITORI"].Text != "")
                {
                    //plotesojme te dhenat per artikujt e blere
                    if (idFurnitori == Convert.ToInt32(gridFurnitoret.GetRow(j).Cells["ID_FURNITORI"].Text))
                    {
                        ugjet = true;
                        if (gridFurnitoret.GetRow(j).Cells["ID_ARTIKULLI"].Text != "")
                        {
                            DataRow r = this.dsArtikujZgjedhur.Tables[0].NewRow();
                            r["ID_ARTIKULLI"] = Convert.ToInt32(gridFurnitoret.GetRow(j).Cells["ID_ARTIKULLI"].Text);
                            r["EMRI"] = gridFurnitoret.GetRow(j).Cells["ARTIKULLI"].Text;
                            dsArtikujZgjedhur.Tables[0].Rows.Add(r);
                        }
                    }
                    else if (ugjet)
                        break;
                }
            }
            dsArtikujZgjedhur.AcceptChanges();
            gridEXArtikujtZgjedhur.DataSource = dsArtikujZgjedhur.Tables[0];
            gbFurnitori.Text = "Artikujt që ofron furnitori " + gridFurnitoret.GetRow(i).Cells["FURNITORI"].Text;
            //FormatoGride(gridEXArtikujt);
            //FormatoGride(gridEXArtikujtZgjedhur);
        }

        private int RuajPerkatesiArtikuj()
        {
            InputController data = new InputController();
            int idFurnitori = Convert.ToInt32(gridFurnitoret.GetRow(gridFurnitoret.Row).Cells["ID_FURNITORI"].Text);
            string Furnitori = gridFurnitoret.GetRow(gridFurnitoret.Row).Cells["FURNITORI"].Text;
            DataSet ds = data.KerkesaRead("RuajPerkatesiArtikuj",idFurnitori, dsArtikujZgjedhur);
            if (ds != null)
            {
                MessageBox.Show(this, "Aritikujt e zgjedhur u ruajtën në përkatësi të " + Furnitori + "!",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            else
            {
                MessageBox.Show(this, "Një gabim ndodhi gjatë ruajtjes së të dhënave! Provoni përsëri!",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
        }

        private void MbushCombo()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEArtikujve");
            cmbKategoriaKerkim.DataSource = ds.Tables[0];
            cmbKategoria.DataSource = ds.Tables[0];
        }

        private bool Fund()
        {
            bool fund = true;
            for (int i = 0; i < gridEXArtikujtZgjedhur.RowCount; i++)
            {
                if (gridEXArtikujtZgjedhur.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    fund = false;
                    break;
                }
            }
            return fund;
        }
        #endregion

        #region Event Handlers

        private void btnModifikoArtikull_Click(object sender, EventArgs e)
        {
            int index = gridFurnitoret.Row;
            if ((index >= 0) && (gridFurnitoret.GetRow(index).Cells["ID_FURNITORI"].Text != ""))
            {
                Ploteso(index);
                this.gridFurnitoret.Visible = false;
                this.uiTabModifiko.Visible = true;
                this.CaktivizoPanel(panelTop);
            }
        }

        private void btnRuajArtikull_Click(object sender, EventArgs e)
        {
            int r = RuajPerkatesiArtikuj();
            if (r == 0)
            {
                this.gridFurnitoret.Visible = true;
                this.uiTabModifiko.Visible = false;
                this.AktivizoPanel(panelTop);
                this.AktivizoPanel(panelBottom);
                this.btnKerko_Click(sender, e);
                Pastro();
            } 
        }
      
        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.gridFurnitoret.Visible = true;
            this.uiTabModifiko.Visible = false;
            this.AktivizoPanel(panelTop);
            this.AktivizoPanel(panelBottom);
            Pastro();
        }

        private bool KaGabim()
        {
            if (cbEmri.Checked == false && this.cbMbiemri.Checked == false && this.cbArtikulli.Checked == false)
            {
                return true;
            }

            if (this.cbArtikulli.Checked == true)
            {
                if (this.cmbKategoriaKerkim.Text == "" )
                {
                    MessageBox.Show("Ju duhet te zgjidhni kategorine e artikullit  !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }

            return false;
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            if (this.KaGabim() == true)
            {
                return;
            }

            int zgjedhur = 0;

            if (cbEmri.Checked == false && cbMbiemri.Checked == false && cbArtikulli.Checked == false)
            {
                MbushGride("");
            }
            else
            {
                string s = "WHERE ";
                //bool check1 = false;
                if (cbEmri.Checked == true)
                {
                    
                    if (zgjedhur == 0)
                    {
                        s += "EMRI LIKE '" + txtEmriKerkim.Text + "%' ";
                    }
                    else
                    {
                        s += "AND EMRI LIKE '" + txtEmriKerkim.Text + "%' ";

                    }

                    zgjedhur = zgjedhur + 1;
                }
                if (cbMbiemri.Checked == true)
                {
                    
                    if (zgjedhur == 0)
                    {
                        s += "MBIEMRI LIKE '" + txtMbiemriKerkim.Text + "%' ";
                        
                    }
                    else
                    {
                        s += "AND MBIEMRI LIKE '" + txtMbiemriKerkim.Text + "%' ";
                       
                    }

                    zgjedhur = zgjedhur + 1;
                }
                if (cbArtikulli.Checked == true)
                {
                    

                    if (this.cmbKategoriaKerkim.Text != "")
                    {
                        if (cmbArtikujtKerkim.Text == "")
                        {
                            

                            if (zgjedhur == 0)
                            {
                                s += " ID_KATEGORIAARTIKULLI = " + Convert.ToInt32(this.cmbKategoriaKerkim.Value) + " ";
                                      
                               
                            }
                            else
                            {
                                s += "AND ID_KATEGORIAARTIKULLI = " + Convert.ToInt32(this.cmbKategoriaKerkim.Value) + " ";
                               
                            }
                        }
                        else
                        {
                            if (zgjedhur == 0)
                            {
                                s += " ID_ARTIKULLI = " + Convert.ToInt32(this.cmbArtikujtKerkim.Value) + " ";


                            }
                            else
                            {
                                s += "AND ID_ARTIKULLI = " + Convert.ToInt32(this.cmbArtikujtKerkim.Value) + " ";

                            }

                        }
                    }

                    zgjedhur = zgjedhur + 1;
                }
                MbushGride(s);
            }
            gridFurnitoret.Visible = true;
            uiTabModifiko.Visible = false;
            AktivizoPanel(panelTop);
            Pastro();
        }

        private void cbEmri_CheckedChanged(object sender, EventArgs e)
        {
            txtEmriKerkim.Clear();
        }

        private void cbMbiemri_CheckedChanged(object sender, EventArgs e)
        {
            txtMbiemriKerkim.Clear();
        }

        private void cbAdresa_CheckedChanged(object sender, EventArgs e)
        {
            cmbKategoriaKerkim.Value = null;
            cmbKategoriaKerkim.Text = "";
            cmbArtikujtKerkim.DataSource = null;
        }

        private void btnFshiArtikull_Click(object sender, EventArgs e)
        {
            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            dsToErase.Tables[0].Columns.Add("ID_FURNITORI", typeof(Int32));
            dsToErase.AcceptChanges();
            for (int i = 0; i < gridFurnitoret.RowCount; i++)
            {
                if (gridFurnitoret.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    if (gridFurnitoret.GetRow(i).Cells["ARTIKULLI"].Text != "Për furnitorin nuk është konfiguruar asnjë artikull")
                    {
                        DataRow newR = dsToErase.Tables[0].NewRow();
                        newR["ID_ARTIKULLI"] = Convert.ToInt32(gridFurnitoret.GetRow(i).Cells["ID_ARTIKULLI"].Text);
                        newR["ID_FURNITORI"] = Convert.ToInt32(gridFurnitoret.GetRow(i).Cells["ID_FURNITORI"].Text);
                        dsToErase.Tables[0].Rows.Add(newR);
                    }
                }
            }
            dsToErase.AcceptChanges();
            if (dsToErase.Tables[0].Rows.Count != 0)
            {
                DialogResult r = MessageBox.Show(this, "Jeni të sigurtë që doni të fshini artikujt e zgjedhur" + 
                    Environment.NewLine  + "nga lista e artikujve përkatës për furnitorët?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes)
                    return;
                InputController data = new InputController();
                int b = data.KerkesaUpdate("FshiPerkatesiArtikuj", dsToErase);
                if (b == 0)
                {
                    MessageBox.Show(this, "Artikujt e zgjedhur u hoqën nga listat e artikujve përkates të furnitoreve!", Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnKerko_Click(sender, e);
                }
                else
                    MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së përkatësive të artikujve! Provoni përsëri!", Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridFurnitoret_CurrentCellChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int index = gridFurnitoret.Row;
            if (index == 0)
            {
                int i = index;
                while (i < gridFurnitoret.RowCount - 1)
                {
                    i++;
                    if (gridFurnitoret.GetRow(i).Cells["ID_FURNITORI"].Text != "" ||
                        i == gridFurnitoret.RowCount - 1)
                        break;
                }
                gridFurnitoret.Row = i;
                return;
            }
            if ((index >= 0) && (gridFurnitoret.GetRow(index).Cells["ID_FURNITORI"].Text != ""))
            {
                Ploteso(index);
            }
            else
            {
                if ((index > 0) && (upDirection == 1))
                {
                    gridFurnitoret.Row = index - 1;
                    upDirection = 0;
                    return;
                }
                if (gridFurnitoret.RowCount > index + 1 && upDirection == 0)
                {
                    gridFurnitoret.Row = index + 1;
                    return;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            gridFurnitoret.ExpandGroups();
            if (gridFurnitoret.RowCount > 0)
            {
                gridFurnitoret.Row = 0;
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            gridFurnitoret.ExpandGroups();
            upDirection = 1;
            int idFurnitori = 0;
            if (gridFurnitoret.GetRow(gridFurnitoret.Row).Cells["ID_FURNITORI"].Text != "")
                idFurnitori = Convert.ToInt32(gridFurnitoret.GetRow(gridFurnitoret.Row).Cells["ID_FURNITORI"].Text);
            while ((gridFurnitoret.GetRow(gridFurnitoret.Row).Cells["ID_FURNITORI"].Text != "")
                && (idFurnitori == Convert.ToInt32(gridFurnitoret.GetRow(gridFurnitoret.Row).Cells["ID_FURNITORI"].Text))
                && (gridFurnitoret.Row != 1))
            {
                if ((gridFurnitoret.Row >= 1) && (gridFurnitoret.Row - 1 >= 0))
                {
                    gridFurnitoret.Row = gridFurnitoret.Row - 1;
                }
            }
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            gridFurnitoret.ExpandGroups();
            int idFurnitori = 0;
            if (gridFurnitoret.GetRow(gridFurnitoret.Row).Cells["ID_FURNITORI"].Text != "")
                idFurnitori = Convert.ToInt32(gridFurnitoret.GetRow(gridFurnitoret.Row).Cells["ID_FURNITORI"].Text);
            while ((gridFurnitoret.GetRow(gridFurnitoret.Row).Cells["ID_FURNITORI"].Text != "") &&
                (idFurnitori == Convert.ToInt32(gridFurnitoret.GetRow(gridFurnitoret.Row).Cells["ID_FURNITORI"].Text))
                &&(gridFurnitoret.Row < gridFurnitoret.RowCount - 1))
            {

                if ((gridFurnitoret.Row <= gridFurnitoret.RowCount - 2) && (gridFurnitoret.Row + 1 >= 0) && (gridFurnitoret.Row != gridFurnitoret.RowCount - 1))
                {
                    gridFurnitoret.Row = gridFurnitoret.Row + 1;
                }
            }
        }

        private void btnFundit_Click(object sender, EventArgs e)
        {
            gridFurnitoret.ExpandGroups();
            if ((gridFurnitoret.RowCount > 0) && (gridFurnitoret.RowCount - 1 >= 0))
            {
                gridFurnitoret.Row = gridFurnitoret.RowCount - 1;
            }
        }

        private void btnKerkoNeGride_Click(object sender, EventArgs e)
        {
            Forms.frmKerko frm = new frmKerko();
            frm.ShowDialog();
            string tekst = frm.txtKerkim.Text;
            Janus.Windows.GridEX.ConditionOperator operatori = new Janus.Windows.GridEX.ConditionOperator();
            operatori = Janus.Windows.GridEX.ConditionOperator.BeginsWith;
            Janus.Windows.GridEX.GridEXFilterCondition kusht = new
                Janus.Windows.GridEX.GridEXFilterCondition(gridFurnitoret.RootTable.Columns["FURNITORI"], operatori, tekst);
            gridFurnitoret.Find(kusht, 0, -1);

        }

        private void cmbKategoriaKerkim_ValueChanged(object sender, EventArgs e)
        {
            int idKategoria = Convert.ToInt32(cmbKategoriaKerkim.Value);
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqArtikujPerKategori", idKategoria);
            cmbArtikujtKerkim.DataSource = ds.Tables[0];
        }

        private void cmbKategoria_ValueChanged(object sender, EventArgs e)
        {
            dsArtikujKategori.Tables[0].Rows.Clear();
            int idKategoria = Convert.ToInt32(cmbKategoria.Value);
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqArtikujPerKategori", idKategoria);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow r = dsArtikujKategori.Tables[0].NewRow();
                r["ID_ARTIKULLI"] = Convert.ToInt32(dr["ID_ARTIKULLI"]);
                r["EMRI"] = dr["EMRI"].ToString();
                r["CHECKED"] = false;
                dsArtikujKategori.Tables[0].Rows.Add(r);
            }
            dsArtikujKategori.AcceptChanges();
            this.gridEXArtikujt.DataSource = dsArtikujKategori.Tables[0];
        }

        private void btnPastro_Click(object sender, EventArgs e)
        {
            Pastro();
        }

        private void btnDjathtas_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dsArtikujKategori.Tables[0].Rows)
            {
                if (Convert.ToBoolean(dr["CHECKED"]) == true)
                {
                    int idArtikulli = Convert.ToInt32(dr["ID_ARTIKULLI"]);
                    DataRow drSearch = dsArtikujZgjedhur.Tables[0].Rows.Find(idArtikulli);
                    if (drSearch == null)
                    {
                        DataRow r = dsArtikujZgjedhur.Tables[0].NewRow();
                        r["ID_ARTIKULLI"] = idArtikulli;
                        r["EMRI"] = dr["EMRI"].ToString();
                        r["CHECKED"] = false;
                        dsArtikujZgjedhur.Tables[0].Rows.Add(r);
                    }
                    dr["CHECKED"] = false;
                }
            }
            //FormatoGride(gridEXArtikujt);
            //FormatoGride(gridEXArtikujtZgjedhur);
        }

        private void btnMajtas_Click(object sender, EventArgs e)
        {
            while (!Fund())
            {
                for (int i = 0; i < gridEXArtikujtZgjedhur.RowCount; i++)
                {
                    if (gridEXArtikujtZgjedhur.GetRow(i).Cells["CHECKED"].Text == "True")
                    {
                        int idArtikulli = Convert.ToInt32(gridEXArtikujtZgjedhur.GetRow(i).Cells["ID_ARTIKULLI"].Text);
                        DataRow drSearch = dsArtikujZgjedhur.Tables[0].Rows.Find(idArtikulli);
                        dsArtikujZgjedhur.Tables[0].Rows.Remove(drSearch);
                        dsArtikujZgjedhur.AcceptChanges();
                    }
                }
            }
           // FormatoGride(gridEXArtikujt);
            //FormatoGride(gridEXArtikujtZgjedhur);
        }
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridFurnitoret.RowCount != 0)
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
            string[] fushat = new string[2];
            string[] llojet = new string[2];
            string[] key = new string[2];
            fushat[0] = "Kategoria_e_artikullit";
            fushat[1] = "Artikujt_qe_ofron";

            key[0] = "PERSHKRIMI";
            key[1] = "ARTIKULLI";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";

            KlaseExcel excel = new KlaseExcel("PerkatesiteArikujFurnitore.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("PerkatesiteArikujFurnitore.xls", gridFurnitoret, fushat,
                    key, llojet, "PERSHKRIMI");

            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "PerkatesiteArikujFurnitore.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (gridFurnitoret.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion
        private void frmArtikujFurnitore_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            MbushGride("");
            MbushCombo();
        }

    }
}