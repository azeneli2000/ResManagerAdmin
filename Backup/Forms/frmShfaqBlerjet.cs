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
    public partial class frmShfaqBlerjet : System.Windows.Forms.Form, IPrintable
    {
        private int upDirection = 0;
        private int idBlerja = -1;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        /// <summary>
        /// Sherben si id per cdo artikull te blere
        /// brenda te njejtes blerje
        /// </summary>
        private int id = 0;

        #region FormLoad
        public frmShfaqBlerjet()
        {
            InitializeComponent();
        }

        private void frmDergesa_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = gridBlerjet;
            Doc.DefaultPageSettings.Landscape = true;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Raport për blerjet";

            gridBlerjet.BringToFront();
            LexoInformacione();
            
            dtpData.Value = DateTime.Now;
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

            dtpDataSkadenca.Value = DateTime.Now;
            dtpDataSkadencaModifikim.Value = DateTime.Now;

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
            this.ds = data.KerkesaRead("ShfaqBlerjet", kushti);
            gridBlerjet.DataSource = this.ds.Tables[0];
            ///FormatoGride(gridBlerjet);
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.Name == "gridArtikujt")
            {
                if (grid.RowCount <= 17)
                    grid.RootTable.Columns["EMRI"].Width = 121;
                else
                    grid.RootTable.Columns["EMRI"].Width = 104;
            }
            else
            {
                if (grid.RowCount <= 23)
                    grid.RootTable.Columns["SQARIM_OFERTA"].Width = 192;
                else
                    grid.RootTable.Columns["SQARIM_OFERTA"].Width = 175;
            }
        }

        private void MbushCombo()
        {
            InputController data = new InputController();
            //per kombon e furnitoreve
            DataSet ds = data.KerkesaRead("ShfaqFurnitoret", "");
            cmbFurnitori.DataSource = ds.Tables[0];
            cmbFurnitoriKerkim.DataSource = ds.Tables[0];
            //per kombon me kategorite e artikujve
            ds = data.KerkesaRead("ShfaqKategoriteEArtikujve");
            this.cmbKategoriaKerkim.DataSource = ds.Tables[0];
        }

        private void PlotesoTeDhena()
        {
            dsBlerja.Tables[0].Clear();
            dsBlerja.Tables[1].Clear();
            int index = gridBlerjet.Row;
            bool ugjet = false;
            int j = 1;
            if (gridBlerjet.GetRow(index).Cells["ID_FURNITORI"].Text != "")
                cmbFurnitori.Value = Convert.ToInt32(gridBlerjet.GetRow(index).Cells["ID_FURNITORI"].Text);
            else
                cmbFurnitori.Value = null;
            this.idBlerja = Convert.ToInt32(gridBlerjet.GetRow(index).Cells["ID_BLERJA"].Text);
            for (int i = 0; i < gridBlerjet.RowCount; i++)
            {
                if (gridBlerjet.GetRow(i).Cells["ID_ARTIKULLI"].Text != "")
                {
                    //plotesojme te dhenat per artikujt e blere
                    if (idBlerja == Convert.ToInt32(gridBlerjet.GetRow(i).Cells["ID_BLERJA"].Text))
                    {
                        ugjet = true;
                        DataRow r = dsBlerja.Tables[1].NewRow();
                        Janus.Windows.GridEX.GridEXRow rGrid = gridBlerjet.GetRow(i);
                        r["ID_ARTIKULLI"] = Convert.ToInt32(rGrid.Cells["ID_ARTIKULLI"].Text);
                        r["SASIA"] = Convert.ToDouble(rGrid.Cells["SASIA"].Text);
                        r["CMIMI"] = Convert.ToDouble(rGrid.Cells["CMIMI"].Text);
                        r["DATA_SKADENCA"] = Convert.ToDateTime(rGrid.Cells["DATA_SKADENCA"].Text);
                        r["DATA_SKADENCA_STR"] = Convert.ToString(rGrid.Cells["DATA_SKADENCA_STR"].Text);
                        r["EMRI"] = Convert.ToString(rGrid.Cells["EMRI"].Text);
                        r["SASIA_STR"] = Convert.ToString(rGrid.Cells["SASIA_STR"].Text);
                        r["VLERA"] = Convert.ToDouble(rGrid.Cells["VLERA"].Text);
                        r["LLOJI"] = rGrid.Cells["LLOJI"].Text;
                        r["CHECKED"] = false;
                        r["ID"] = j;
                        r["ID_KATEGORIAARTIKULLI"] = Convert.ToInt32(rGrid.Cells["ID_KATEGORIAARTIKULLI"].Text);
                        r["NJESIA"] = rGrid.Cells["NJESIA"].Text;
                        if (rGrid.Cells["ID_ARTIKULLIFILLESTAR"].Text != "")
                        {
                            r["ID_ARTIKULLIFILLESTAR"] = Convert.ToInt32(rGrid.Cells["ID_ARTIKULLIFILLESTAR"].Text);
                            r["SASIA_KUSHT_OFERTA"] = Convert.ToDouble(rGrid.Cells["SASIA_KUSHT_OFERTA"].Text);
                            r["SQARIM_OFERTA"] = rGrid.Cells["SQARIM_OFERTA"].Text;
                        }
                        j++;
                        dsBlerja.Tables[1].Rows.Add(r);
                        //nqs ende nuk i kemi hedhur te dhenat mbi blerjen
                        //bejme plotesimin e tyre
                        if (dsBlerja.Tables[0].Rows.Count == 0)
                        {
                            r = dsBlerja.Tables[0].NewRow();
                            if (rGrid.Cells["ID_FURNITORI"].Text != "")
                                r["ID_FURNITORI"] = Convert.ToInt32(rGrid.Cells["ID_FURNITORI"].Text);
                            r["DATA_BLERJE"] = Convert.ToDateTime(rGrid.Cells["DATA_BLERJE"].Text);
                            r["NR_FATURE"] = rGrid.Cells["NR_FATURE"].Text;
                            dsBlerja.Tables[0].Rows.Add(r);
                        }

                    }
                    //nqs me pare jane gjetur artikuj te blerjes
                    //dhe rreshti qe po kontrolojme nuk i perket blerjes
                    //atehere kerkimi ka mbaruar
                    else if (ugjet == true)
                        break;
                }
            }
            dsBlerja.AcceptChanges();
            gridArtikujt.DataSource = dsBlerja.Tables[1];
            dtpData.Value = Convert.ToDateTime(dsBlerja.Tables[0].Rows[0]["DATA_BLERJE"]);
            txtNrFature.Text = dsBlerja.Tables[0].Rows[0]["NR_FATURE"].ToString();
        }

        private void PastroBlerje()
        {
            dsBlerja.Tables[0].Clear();
            dsBlerja.Tables[1].Clear();
            //cmbFurnitori.Value = null;
            //cmbFurnitori.Text = "";
            this.idBlerja = -1;
            this.id = 0;

            cmbArtikulli.DataSource = null;
            numSasia.Value = 0;
            txtNjesia.Clear();
            numCmimi.Value = 0;
            dtpDataSkadenca.Value = DateTime.Now;

            cmbArtikulliModifikim.DataSource = null;
            numSasiaModifikim.Value = 0;
            txtNjesiaModifikim.Clear();
            numCmimiModifikim.Value = 0;
            dtpDataSkadencaModifikim.Value = DateTime.Now;
        }

        private bool GabimNeKonfigurimArtikulli()
        {
            this.error1.SetError(dtpDataSkadenca, "");
            this.error1.SetError(dtpDataSkadencaModifikim, "");
            int i = 0;
            if (uiTab.SelectedIndex == 1)
            {
                if (dtpDataSkadenca.Value.Date <= dtpData.Value.Date)
                {
                    this.error1.SetError(dtpDataSkadenca, "Data e skadencës së artikullit duhet të jetë më e madhe se data e blerjes!");
                    i++;
                }
            }
            else if (uiTab.SelectedIndex == 2)
            {
                if (dtpDataSkadencaModifikim.Value.Date <= dtpData.Value.Date)
                {
                    this.error1.SetError(dtpDataSkadencaModifikim, "Data e skadencës së artikullit duhet të jetë më e madhe se data e blerjes!");
                    i++;
                }
            }
            if (uiTab.SelectedIndex == 1)
            {
                Double cmimi = Convert.ToDouble(numCmimi.Value);
                DateTime dataSkadenca = Convert.ToDateTime(dtpDataSkadenca.Value.ToString("yyyy-MM-dd"));
                int idArtikulli = Convert.ToInt32(cmbArtikulli.Value);
                object[] celes = new object[3];
                celes[0] = idArtikulli;
                celes[1] = cmimi;
                celes[2] = dataSkadenca;
                DataRow drSearch = dsBlerja.Tables[1].Rows.Find(celes);
                //nqs gjendet ky artikull ne blerje me te njejten date skadence 
                //dhe me te njejtin cmim atehere ai nuk mund te shtohet ne blerje
                if (drSearch != null)
                {
                    i++;
                    string s = "Ky artikull figuron një herë në blerje" + Environment.NewLine +
                        "me të njëjtin çmim blerje dhe datë skadence." + Environment.NewLine +
                        "Për të përfunduar veprimin modifikoni sasinë e blerë për këtë artikull!";
                    MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (uiTab.SelectedIndex == 2)
            {

                Double cmimi = Convert.ToDouble(numCmimiModifikim.Value);
                DateTime dataSkadenca = Convert.ToDateTime(dtpDataSkadencaModifikim.Value.ToString("yyyy-MM-dd"));
                int idArtikulli = Convert.ToInt32(cmbArtikulliModifikim.Value);
                object[] celes = new object[3];
                celes[0] = idArtikulli;
                celes[1] = cmimi;
                celes[2] = dataSkadenca;
                DataRow drSearch = dsBlerja.Tables[1].Rows.Find(celes);
                //nqs gjendet ky artikull ne blerje me te njejten date skadence 
                //dhe me te njejtin cmim atehere ai nuk mund te shtohet ne blerje
                if (drSearch != null)
                {
                    if (this.id != Convert.ToInt32(drSearch["ID"]))
                    {
                        i++;
                        string s = "Ky artikull figuron një herë në blerje" + Environment.NewLine +
                            "me të njëjtin çmim blerje dhe datë skadence." + Environment.NewLine +
                            "Për të përfunduar veprimin modifikoni sasinë e blerë për këtë artikull!";
                        MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            if (i > 0)
                return true;
            else
                return false;
        }

        private bool GabimNeBlerje()
        {
            int i = 0;
            if (cmbFurnitori.Value == null || cmbFurnitori.Text == "" || txtNrFature.Text == "")
                i++;
            if (dsBlerja.Tables[1].Rows.Count == 0)
            {
                i++;
                MessageBox.Show(this, "Para se të përfundoni ruejtjen e blerjes duhet të keni hedhur" +
                        Environment.NewLine + "të paktën një artikull në shportë!", this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            if (i > 0)
                return true;
            else
                return false;
        }

        #endregion

        #region Checked Changed per CheckBox

        private void BllokoKerkimin()
        {
            cmbArtikujtKerkim.DataSource = null;
            cmbKategoriaKerkim.Value = null;
            cmbKategoriaKerkim.Text = "";
            cmbArtikujtKerkim.Text = "";

            cmbKategoriaKerkim.Enabled = false;
            cmbArtikujtKerkim.Enabled = false;

            cmbKategoriaKerkim.BackColor = Color.White;

            cmbArtikujtKerkim.BackColor = Color.White;



            dtpFillimi.Enabled = false;
            dtpMbarimi.Enabled = false;

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


            cmbFurnitoriKerkim.Value = null;
            cmbFurnitoriKerkim.Text = "";
            cmbFurnitoriKerkim.Enabled = false;
            cmbFurnitoriKerkim.BackColor = Color.White;

            this.txtNrFatureKerkim.Text = "";
            this.txtNrFatureKerkim.Enabled = false;
            this.txtNrFatureKerkim.BackColor = Color.White;

            cbData.Checked = false;
            cbArtikujt.Checked = false;
            cbFurnitori.Checked = false;
            cbNrFature.Checked = false;
        }

        private void cbArtikujt_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbArtikujt.Checked == true)
            {
                cmbKategoriaKerkim.Enabled = true;
                cmbArtikujtKerkim.Enabled = true;
                
            }
            else
            {
                cmbArtikujtKerkim.DataSource = null;
                cmbKategoriaKerkim.Value = null;
                cmbKategoriaKerkim.Text = "";
                cmbArtikujtKerkim.Text = "";

                cmbKategoriaKerkim.Enabled = false;
                cmbArtikujtKerkim.Enabled = false;

                cmbKategoriaKerkim.BackColor = Color.White;

                cmbArtikujtKerkim.BackColor = Color.White;

                
            }
        }

        private void cbData_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbData.Checked == true)
            {
                dtpFillimi.Enabled = true;
                dtpMbarimi.Enabled = true;

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
            else
            {
                dtpFillimi.Enabled = false;
                dtpMbarimi.Enabled = false;

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
        }

        private void cbFurnitori_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbFurnitori.Checked == true)
            {
                cmbFurnitoriKerkim.Value = null;
                cmbFurnitoriKerkim.Text = "";
                cmbFurnitoriKerkim.Enabled = true;
            }
            else
            {
                cmbFurnitoriKerkim.Value = null;
                cmbFurnitoriKerkim.Text = "";
                cmbFurnitoriKerkim.Enabled = false;
                cmbFurnitoriKerkim.BackColor = Color.White;
            }
        }
        #endregion

        #region Event Handlers
        private void btnMbyll_Click(object sender, EventArgs e)
        {
            PastroBlerje();
            cmbFurnitori.Value = null;
            cmbFurnitori.Text = "";
            this.uiTabModifiko.Visible = false;
            this.gridBlerjet.Visible = true;
            this.AktivizoPanel(panelTop);
        }

        private void btnRuajBlerje_Click(object sender, EventArgs e)
        {
            this.uiTabModifiko.Visible = false;
            this.gridBlerjet.Visible = true;
            this.AktivizoPanel(panelTop);
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            this.error1.SetError(dtpFillimi, "");
            this.error1.SetError(dtpMbarimi, "");
            string strDesc = "Raport për blerjet";
            if ( this.cbArtikujt.Checked == false && cbData.Checked == false && cbFurnitori.Checked == false && cbNrFature.Checked == false)
            {
            }
            else
            {
                string s = "WHERE ";
                bool check1 = false;
                if (cbArtikujt.Checked == true)
                {
                    if (cmbArtikujtKerkim.Text != "" && cmbArtikujtKerkim.Value != null &&
                        cmbKategoriaKerkim.Text != "" && cmbKategoriaKerkim.Value != null)
                    {
                        s += " ID_BLERJA IN (SELECT B.ID_BLERJA FROM " +
                            " (SELECT VB.ID_BLERJA, COUNT(VB.ID_ARTIKULLI) AS  NUMRI " +
                            " FROM VIZUALIZIM_BLERJET AS VB WHERE VB.ID_ARTIKULLI = " + Convert.ToInt32(cmbArtikujtKerkim.Value) +
                            " GROUP BY VB.ID_BLERJA ) AS B) ";
                        check1 = true;
                        strDesc += " e artikullit " + cmbArtikujtKerkim.Text;
                    }
                    else
                        return;
                }
                if (cbData.Checked == true)
                {
                    if (dtpFillimi.Value.Date > dtpMbarimi.Value.Date)
                    {
                        this.error1.SetError(dtpMbarimi, "Data e mbarimit nuk mund të jetë më e vogël se data e fillimit");
                        return;
                    }
                    if (check1)
                    {
                        //s += "AND (DATA_BLERJE BETWEEN '" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "' AND '" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "' " +
                        //    " OR (YEAR(DATA_BLERJE) = YEAR('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm")  + "') " +
                        //    " AND MONTH(DATA_BLERJE) = MONTH('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                        //    " AND DAY(DATA_BLERJE) = DAY('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "')) " +
                        //    " OR (YEAR(DATA_BLERJE) = YEAR('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                        //    " AND MONTH(DATA_BLERJE) = MONTH('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                        //    " AND DAY(DATA_BLERJE) = DAY('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "'))) ";
                        s += "AND (DATA_BLERJE BETWEEN '" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "' AND '" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "') ";
                           //" OR (YEAR(DATA_BLERJE) = YEAR('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                           //" AND MONTH(DATA_BLERJE) = MONTH('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                           //" AND DAY(DATA_BLERJE) = DAY('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "')) " +
                           //" OR (YEAR(DATA_BLERJE) = YEAR('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                           //" AND MONTH(DATA_BLERJE) = MONTH('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                           //" AND DAY(DATA_BLERJE) = DAY('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "'))) ";
                        strDesc += ", të kryera midis datave " + dtpFillimi.Value.ToString("dd.MM.yyyy HH:mm") + " dhe " + dtpMbarimi.Value.ToString("dd.MM.yyyy HH:mm");
                    }
                    else
                    {
                        //s += " (DATA_BLERJE BETWEEN '" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "' AND '" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "' " +
                        //    " OR (YEAR(DATA_BLERJE) = YEAR('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                        //    " AND MONTH(DATA_BLERJE) = MONTH('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                        //    " AND DAY(DATA_BLERJE) = DAY('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "')) " +
                        //    " OR (YEAR(DATA_BLERJE) = YEAR('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                        //    " AND MONTH(DATA_BLERJE) = MONTH('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                        //    " AND DAY(DATA_BLERJE) = DAY('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "'))) ";
                        s += " (DATA_BLERJE BETWEEN '" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "' AND '" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "') ";
                           //" OR (YEAR(DATA_BLERJE) = YEAR('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                           //" AND MONTH(DATA_BLERJE) = MONTH('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                           //" AND DAY(DATA_BLERJE) = DAY('" + dtpFillimi.Value.ToString("yyyy-MM-dd HH:mm") + "')) " +
                           //" OR (YEAR(DATA_BLERJE) = YEAR('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                           //" AND MONTH(DATA_BLERJE) = MONTH('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "') " +
                           //" AND DAY(DATA_BLERJE) = DAY('" + dtpMbarimi.Value.ToString("yyyy-MM-dd HH:mm") + "'))) ";
                        strDesc += " e kryera midis datave " + dtpFillimi.Value.ToString("dd.MM.yyyy HH:mm") + " dhe " + dtpMbarimi.Value.ToString("dd.MM.yyyy HH:mm");
                        check1 = true;
                    }
                }
                if (cbFurnitori.Checked == true)
                {
                    if (check1)
                    {
                        s += " AND ID_FURNITORI = " + Convert.ToInt32(cmbFurnitoriKerkim.Value);
                        strDesc += ", nga furnitori " + cmbFurnitoriKerkim.Text;
                    }
                    else
                    {
                        s += " ID_FURNITORI = " + Convert.ToInt32(cmbFurnitoriKerkim.Value);
                        strDesc += " nga furnitori " + cmbFurnitoriKerkim.Text;
                        check1 = true;
                    }
                }
                if (cbNrFature.Checked == true)
                {
                    if (txtNrFatureKerkim.Text == "")
                    {
                        return;
                    }
                    if (check1)
                    {
                        s += "AND NR_FATURE = '" + txtNrFatureKerkim.Text + "'";
                        strDesc += ", me nr fature " + txtNrFatureKerkim.Text;
                    }
                    else
                    {
                        s += " NR_FATURE = '" + txtNrFatureKerkim.Text + "'";
                        strDesc += " me nr fature " + txtNrFatureKerkim.Text;
                        check1 = true;
                    }
                }
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + strDesc;
                MbushGride(s);
                gridBlerjet.Visible = true;
                uiTabModifiko.Visible = false;
                AktivizoPanel(panelTop);
            }

        }

        private void cmbKategoriaKerkim_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idKategoria = Convert.ToInt32(cmbKategoriaKerkim.Value);
                InputController data = new InputController();
                DataSet ds1 = data.KerkesaRead("ShfaqArtikujPerKategori", idKategoria);
                cmbArtikujtKerkim.DataSource = ds1.Tables[0];
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            gridBlerjet.ExpandGroups();
            if (gridBlerjet.RowCount > 0)
            {
                gridBlerjet.Row = 0;
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            upDirection = 1;
            gridBlerjet.ExpandGroups();

            if (gridBlerjet.Row == gridBlerjet.RowCount - 1)
            {
                gridBlerjet.Row = gridBlerjet.Row - 2;
                return;
            }
           
            int idBlerja = 0;
            if (gridBlerjet.GetRow(gridBlerjet.Row).Cells["ID_BLERJA"].Text != "")
                idBlerja = Convert.ToInt32(gridBlerjet.GetRow(gridBlerjet.Row).Cells["ID_BLERJA"].Text);
            while ((gridBlerjet.GetRow(gridBlerjet.Row).Cells["ID_BLERJA"].Text != "")
                && (idBlerja == Convert.ToInt32(gridBlerjet.GetRow(gridBlerjet.Row).Cells["ID_BLERJA"].Text))
                &&(gridBlerjet.Row != 2))
            {
                if ((gridBlerjet.Row >= 1) && (gridBlerjet.Row - 1 >= 0))
                {
                    gridBlerjet.Row = gridBlerjet.Row - 1;
                }
            }
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            upDirection = 0;
            gridBlerjet.ExpandGroups();
            int idBlerja = 0;
            if (gridBlerjet.GetRow(gridBlerjet.Row).Cells["ID_BLERJA"].Text != "")
                idBlerja = Convert.ToInt32(gridBlerjet.GetRow(gridBlerjet.Row).Cells["ID_BLERJA"].Text);
            while ((gridBlerjet.GetRow(gridBlerjet.Row).Cells["ID_BLERJA"].Text != "")
                && (idBlerja == Convert.ToInt32(gridBlerjet.GetRow(gridBlerjet.Row).Cells["ID_BLERJA"].Text)))
            {
                
                if ((gridBlerjet.Row <= gridBlerjet.RowCount - 2) && 
                    (gridBlerjet.Row + 1 >= 0)&&
                    (gridBlerjet.Row != gridBlerjet.RowCount - 1))
                {
                    gridBlerjet.Row = gridBlerjet.Row + 1;
                }
            }
        }

        private void btnFundit_Click(object sender, EventArgs e)
        {
            gridBlerjet.ExpandGroups();
            if ((gridBlerjet.RowCount > 0) && (gridBlerjet.RowCount - 3 >= 0))
            {
                gridBlerjet.Row = gridBlerjet.RowCount - 3;
            }
        }

        private void gridBlerjet_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                int index = this.gridBlerjet.Row;
                if (index == 0 && upDirection == 1)
                {
                    if (gridBlerjet.RowCount >= 4)
                        gridBlerjet.Row = 3;
                    else
                        gridBlerjet.Row = gridBlerjet.RowCount - 1;
                    return;
                }
                if (index == 0)
                {
                    int i = index;
                    while (i < gridBlerjet.RowCount)
                    {
                        i++;
                        if (gridBlerjet.GetRow(i).Cells["ID_ARTIKULLI"].Text != "" ||
                            i == gridBlerjet.RowCount - 1)
                            break;
                    }
                    gridBlerjet.Row = i;
                    return;
                }
                if ((index >= 0) && (gridBlerjet.GetRow(index).Cells["ID_ARTIKULLI"].Text != ""))
                {
                    PlotesoTeDhena();
                }
                else
                {
                    if ((index > 1) && (upDirection == 1))
                    {
                        gridBlerjet.Row = index - 1;
                        //upDirection = 0;
                        return;
                    }
                    if (gridBlerjet.RowCount > index + 1 && upDirection == 0)
                    {
                        gridBlerjet.Row = index + 1;
                        return;
                    }
                }
            }
            catch (System.StackOverflowException ex)
            {
                return;
            }
        }

        private void btnModifikoBlerje_Click_1(object sender, EventArgs e)
        {
            PastroBlerje();
            cmbFurnitori.Value = null;
            cmbFurnitori.Text = "";
            int index = gridBlerjet.Row;
            if (index >= 0 && gridBlerjet.GetRow(index).Cells["ID_ARTIKULLI"].Text != "")
            {
                PlotesoTeDhena();
                uiTabModifiko.Visible = true;
                uiTab.SelectedIndex = 0;
                gridBlerjet.Visible = false;
                CaktivizoPanel(panelTop);
            }
        }

        private void btnKategoriteArtikuj_Click(object sender, EventArgs e)
        {
            frmKerkoKategoriteArtikuj frm = new frmKerkoKategoriteArtikuj();
            frm.ShowDialog();
            int idKategoria = frm.idKategoria;
            int idFurnitori = 0;
            if (cmbFurnitori.Value != null && cmbFurnitori.Text != "")
                idFurnitori = Convert.ToInt32(cmbFurnitori.Value);
            else
            {
                MessageBox.Show(this, "Duhet të zgjidhni më parë një prej furnitorëve!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idKategoria > 0)
            {
                InputController data = new InputController();
                DataSet ds1 = data.KerkesaRead("ShfaqArtikujPerKategoriFurnitor", idKategoria, idFurnitori);
                cmbArtikulli.DataSource = ds1.Tables[0];
                cmbArtikulli.Text = "";
                cmbArtikulli.Value = null;
            }
        }

        private void btnKategoriteArtikujModifikim_Click(object sender, EventArgs e)
        {
            frmKerkoKategoriteArtikuj frm = new frmKerkoKategoriteArtikuj();
            frm.ShowDialog();
            int idKategoria = frm.idKategoria;
            int idFurnitori = 0;
            if (cmbFurnitori.Value != null && cmbFurnitori.Text != "")
                idFurnitori = Convert.ToInt32(cmbFurnitori.Value);
            else
            {
                MessageBox.Show(this, "Duhet të zgjidhni më parë një prej furnitorëve!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            if (idKategoria > 0)
            {
                InputController data = new InputController();
                DataSet ds1 = data.KerkesaRead("ShfaqArtikujPerKategoriFurnitor", idKategoria, idFurnitori);
                cmbArtikulliModifikim.DataSource = ds1.Tables[0];
                cmbArtikulliModifikim.Value = null;
                cmbArtikulliModifikim.Text = "";
            }
        }

        private void cmbArtikulli_ValueChanged(object sender, EventArgs e)
        {
            txtNjesia.Clear();
            int i = cmbArtikulli.DropDownList.Row;
            txtNjesia.Text = cmbArtikulli.DropDownList.GetRow(i).Cells["NJESIA"].Text;
        }

        private void cmbArtikulliModifikim_ValueChanged(object sender, EventArgs e)
        {
            txtNjesiaModifikim.Clear();
            int i = cmbArtikulliModifikim.DropDownList.Row;
            txtNjesiaModifikim.Text = cmbArtikulliModifikim.DropDownList.GetRow(i).Cells["NJESIA"].Text;
        }

        private void uiTab_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            if (uiTab.SelectedIndex == 2)
            {
                cmbArtikulliModifikim.DataSource = null;
                numSasiaModifikim.Value = 0;
                numCmimiModifikim.Value = 0;
                txtNjesiaModifikim.Clear();
                dtpDataSkadencaModifikim.Value = DateTime.Now;    
            }
        }

        private void btnRuajArtikullModifikim_Click(object sender, EventArgs e)
        {
            if (cmbArtikulliModifikim.Value != null && cmbArtikulliModifikim.Text != ""
                && numSasiaModifikim.Value != 0 && numCmimiModifikim.Value != 0
                )
            {
                if (!GabimNeKonfigurimArtikulli())
                {
                    int index = gridArtikujt.Row;
                    if (gridArtikujt.GetRow(index).Cells["CMIMI"].Text == "0")
                        return;
                    if (index >= 0 && index != gridArtikujt.RowCount - 1 && gridArtikujt.GetRow(index).Cells["ID_ARTIKULLI"].Text != "")
                    {
                        int idArtikulli = Convert.ToInt32(gridArtikujt.GetRow(index).Cells["ID_ARTIKULLI"].Text);
                        double cmimi = Convert.ToDouble(gridArtikujt.GetRow(index).Cells["CMIMI"].Text);
                        DateTime dataSkadenca= Convert.ToDateTime(gridArtikujt.GetRow(index).Cells["DATA_SKADENCA"].Text);
                        object[] celes = new object[3];
                        celes[0] = idArtikulli;
                        celes[1] = cmimi;
                        celes[2] = dataSkadenca;
                        DataRow drSearch = dsBlerja.Tables[1].Rows.Find(celes);
                        //gjejme rreshtin qe duhet modifikuar
                        if (drSearch != null)
                        {
                            drSearch["ID_ARTIKULLI"] = Convert.ToInt32(cmbArtikulliModifikim.Value);
                            drSearch["SASIA"] = Convert.ToDouble(numSasiaModifikim.Value);
                            drSearch["CMIMI"] = Convert.ToDouble(numCmimiModifikim.Value);
                            DateTime dataSkadencaModifikim = Convert.ToDateTime(dtpDataSkadencaModifikim.Value.ToString("yyyy-MM-dd"));
                            drSearch["DATA_SKADENCA"] = dataSkadencaModifikim;
                            drSearch["DATA_SKADENCA_STR"] = dataSkadencaModifikim.ToString("dd.MM.yyyy");
                            drSearch["ID"] = dsBlerja.Tables[1].Rows.Count + 1;
                            drSearch["EMRI"] = cmbArtikulliModifikim.Text;
                            drSearch["SASIA_STR"] = Convert.ToDouble(numSasiaModifikim.Value).ToString() + " " + txtNjesiaModifikim.Text;
                            drSearch["VLERA"] = Convert.ToDouble(Convert.ToDouble(numSasiaModifikim.Value) * Convert.ToDouble(numCmimiModifikim.Value));
                            drSearch["CHECKED"] = false;
                            drSearch["NJESIA"] = txtNjesiaModifikim.Text;
                            dsBlerja.AcceptChanges();
                        }
                        //nqs verprimi eshte i rregullt
                        cmbArtikulliModifikim.DataSource = null;
                        numSasiaModifikim.Value = 0;
                        numCmimiModifikim.Value = 0;
                        txtNjesiaModifikim.Clear();
                        dtpDataSkadencaModifikim.Value = DateTime.Now;
                        id = 0;
                    }
                    //double idArtikulli
                }
              
            }
        }

        private void btnRuajPerberesRi_Click(object sender, EventArgs e)
        {
            if (cmbArtikulli.Value != null && cmbArtikulli.Text != ""
                && numSasia.Value != 0 && numCmimi.Value != 0)
            {
                if (!GabimNeKonfigurimArtikulli())
                {
                    DataRow r = dsBlerja.Tables[1].NewRow();
                    r["ID_ARTIKULLI"] = Convert.ToInt32(cmbArtikulli.Value);
                    r["SASIA"] = Convert.ToDouble(numSasia.Value);
                    r["CMIMI"] = Convert.ToDouble(numCmimi.Value);
                    DateTime dataSkadenca = Convert.ToDateTime(dtpDataSkadenca.Value.ToString("yyyy-MM-dd"));
                    r["DATA_SKADENCA"] = dataSkadenca;
                    r["DATA_SKADENCA_STR"] = dataSkadenca.ToString("dd.MM.yyyy");
                    r["ID"] = dsBlerja.Tables[1].Rows.Count + 1;
                    r["EMRI"] = cmbArtikulli.Text;
                    r["SASIA_STR"] = Convert.ToDouble(numSasia.Value).ToString() + " " + txtNjesia.Text;
                    r["VLERA"] = Convert.ToDouble(Convert.ToDouble(numSasia.Value) * Convert.ToDouble(numCmimi.Value));
                    r["CHECKED"] = false;
                    r["LLOJI"] = "Artikull";
                    r["NJESIA"] = txtNjesia.Text;
                    dsBlerja.Tables[1].Rows.Add(r);
                    dsBlerja.AcceptChanges();
                    //nqs verprimi eshte i rregullt
                    cmbArtikulli.DataSource = null;
                    numSasia.Value = 0;
                    numCmimi.Value = 0;
                    txtNjesia.Clear();
                    dtpDataSkadenca.Value = DateTime.Now;
                    id = 0;
                }
            }
        }

        private void gridArtikujt_CurrentCellChanged(object sender, EventArgs e)
        {
            if ((uiTab.SelectedIndex == 2) && (gridArtikujt.Row >= 0) && (gridArtikujt.Row != gridArtikujt.RowCount - 1))
            {
                if (gridArtikujt.GetRow(gridArtikujt.Row).Cells["ID"].Text != "")
                {
                    int i = gridArtikujt.Row;
                    Janus.Windows.GridEX.GridEXRow gRow = gridArtikujt.GetRow(i);
                    if (gRow.Cells["CMIMI"].Text != "0" )
                    {
                        this.id = Convert.ToInt32(gRow.Cells["ID"].Text);
                        int idArtikulli = Convert.ToInt32(gRow.Cells["ID_ARTIKULLI"].Text);
                        InputController data = new InputController();
                        DataSet dsArtikulli = data.KerkesaRead("ShfaqArtikujtMeTeNjejtenKategori", idArtikulli);
                        cmbArtikulliModifikim.DataSource = dsArtikulli.Tables[0];
                        cmbArtikulliModifikim.Value = idArtikulli;
                        numSasiaModifikim.Value = Convert.ToDecimal(gRow.Cells["SASIA"].Text);
                        numCmimiModifikim.Value = Convert.ToDecimal(gRow.Cells["CMIMI"].Text);
                        dtpDataSkadencaModifikim.Value = Convert.ToDateTime(gRow.Cells["DATA_SKADENCA"].Text);
                    }
                    else
                    {
                        cmbArtikulliModifikim.DataSource = null;
                        numSasiaModifikim.Value = 0;
                        numCmimiModifikim.Value = 0;
                        txtNjesiaModifikim.Clear();
                        dtpDataSkadencaModifikim.Value = DateTime.Now;
                        id = 0;
                    }
                }
                else
                {
                    cmbArtikulliModifikim.DataSource = null;
                    numSasiaModifikim.Value = 0;
                    numCmimiModifikim.Value = 0;
                    txtNjesiaModifikim.Clear();
                    dtpDataSkadencaModifikim.Value = DateTime.Now;
                    id = 0;
                }
            }
        }

        private void btnHiqArtikull_Click(object sender, EventArgs e)
        {
            string s = "Për artikuj më poshtë janë konfiguruar oferta." + Environment.NewLine +
                "Artikujt nuk mund të hiqen nga blerja pa hequr më parë ofertat përkatese!";
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("EMRI", typeof(String));
            dsError.AcceptChanges();
            foreach (DataRow dr in dsBlerja.Tables[1].Rows)
            {
                if (dr["CHECKED"].ToString() == "True")
                {
                    int idArtikulli = Convert.ToInt32(dr["ID_ARTIKULLI"]);
                    bool fshi = true;
                    if (dr["CMIMI"].ToString() != "0")
                    {
                        foreach (DataRow drTjeter in dsBlerja.Tables[1].Rows)
                        {
                            if ((drTjeter["ID_ARTIKULLIFILLESTAR"].ToString() != "")
                                && (Convert.ToInt32(drTjeter["ID_ARTIKULLIFILLESTAR"]) == idArtikulli))
                            {
                                DataRow newR = dsError.Tables[0].NewRow();
                                newR["EMRI"] = dr["EMRI"].ToString();
                                dsError.Tables[0].Rows.Add(newR);
                                fshi = false;
                                break;
                            }
                        }
                    }
                    if (fshi)
                        dr.Delete();
                }
            }
            int count = 1;
            if (dsError.Tables[0].Rows.Count != 0)
            {
                foreach (DataRow dr in dsError.Tables[0].Rows)
                {
                    s += Environment.NewLine + count + ". " + dr["EMRI"].ToString();
                    count++;
                }
                MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dsBlerja.AcceptChanges();
            count = 1;
            foreach (DataRow dr in dsBlerja.Tables[1].Rows)
            {
                dr["ID"] = count;
                count++;
            }
        }

        private void btnPerfundo_Click(object sender, EventArgs e)
        {
            if (Convert.IsDBNull(dsBlerja.Tables[0].Rows[0]["ID_FURNITORI"]))
            {
                MessageBox.Show(this, "Për blerjen e zgjedhur është fshirë furnitori." +
                    Environment.NewLine + "Për pasojë blerja nuk mund të modifikohet.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (!GabimNeBlerje())
                {
                    DialogResult result = MessageBox.Show(this, "Jeni të sigurtë që doni ta modifikoni blerjen?",
                        this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataRow r = dsBlerja.Tables[0].Rows[0];
                        r["ID_FURNITORI"] = Convert.ToInt32(cmbFurnitori.Value);
                        r["DATA_BLERJE"] = Convert.ToDateTime(dtpData.Value);
                        r["NR_FATURE"] = txtNrFature.Text;
                        dsBlerja.AcceptChanges();
                        InputController data = new InputController();
                        DataSet dsError = data.KerkesaRead("ModifikoBlerje", idBlerja, dsBlerja);
                        if (dsError == null)
                        {
                            MessageBox.Show(this, "Të dhënat mbi blerjen e zgjedhur u modifikuan!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PastroBlerje();
                            cmbFurnitori.Value = null;
                            cmbFurnitori.Text = "";
                            btnKerko_Click(sender, e);
                            uiTabModifiko.Visible = false;
                            gridBlerjet.Visible = true;
                            AktivizoPanel(panelTop);
                        }
                        else if (dsError.Tables.Count == 0)
                        {
                            MessageBox.Show(this, "Një gabim ndodhi gjatë modifikimit të blerjes. Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (dsError.Tables[0].Rows.Count > 0)
                        {
                            string s = "Modifikimi i blerjes nuk mund të bëhet pasi" + Environment.NewLine +
                                "për artikujt e mëposhtëm të blerjes numri total" + Environment.NewLine +
                                "do të rezultonte negativ pas modifikimit:";
                            int i = 1;
                            foreach (DataRow dr in dsError.Tables[0].Rows)
                            {
                                s += Environment.NewLine + i + ". " + dr["EMRI"].ToString();
                                i++;
                            }
                            MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnFshiBlerje_Click(object sender, EventArgs e)
        {
            
            DataSet dsErase = new DataSet();
            dsErase.Tables.Add();
            dsErase.Tables[0].Columns.Add("ID_BLERJA", typeof(Int32));
            dsErase.Tables[0].Columns.Add("FURNITORI", typeof(String));
            dsErase.Tables[0].Columns.Add("DATA_BLERJE_STR", typeof(String));
            dsErase.Tables[0].Columns.Add("NR_FATURE", typeof(String));
            DataColumn[] celesPrimar = new DataColumn[1];
            celesPrimar[0] = dsErase.Tables[0].Columns["ID_BLERJA"];
            dsErase.Tables[0].PrimaryKey = celesPrimar;
            dsErase.AcceptChanges();
            for(int i = 0; i < gridBlerjet.RowCount; i++)
            {
                if (gridBlerjet.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    int idBlerja = Convert.ToInt32(gridBlerjet.GetRow(i).Cells["ID_BLERJA"].Text);
                    DataRow drSearch = dsErase.Tables[0].Rows.Find(idBlerja);
                    if (drSearch == null)
                    {
                        DataRow newR = dsErase.Tables[0].NewRow();
                        newR["ID_BLERJA"] = idBlerja;
                        newR["FURNITORI"] = Convert.ToString(gridBlerjet.GetRow(i).Cells["FURNITORI"].Text);
                        newR["DATA_BLERJE_STR"] = Convert.ToString(gridBlerjet.GetRow(i).Cells["DATA_BLERJE_STR"].Text);
                        newR["NR_FATURE"] = Convert.ToString(gridBlerjet.GetRow(i).Cells["NR_FATURE"].Text);
                        dsErase.Tables[0].Rows.Add(newR);
                    }
                }
            }
            dsErase.AcceptChanges();
            if (dsErase.Tables[0].Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show(this, "Për zgjedhjet që keni bërë do të fshihen të gjitha të dhënat" +
                Environment.NewLine + "mbi blerjen dhe mbi artikujt përbëres të saj!" +
                Environment.NewLine + "Jeni të sigurtë që doni të vazhdoni me fshirjen?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
                InputController data = new InputController();
                DataSet dsResult = data.KerkesaRead("FshiBlerjet", dsErase);
                if (dsResult == null)
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së blerjeve. Provoni përsëri!", 
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dsResult.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(this, "Të gjitha blerjet e zgjedhura u fshinë!",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnKerko_Click(sender, e);
                }
                else
                {
                    string s = "Blerjet e mëposhtme nuk ishte e mundur të fshiheshin pasi" + 
                        Environment.NewLine + "për disa nga artikujt përbëres të tyre numri total" + 
                        Environment.NewLine  + "do të rezultonte negativ pas fshirjes!";
                    int i = 1;
                    foreach (DataRow dr in dsResult.Tables[0].Rows)
                    {
                        s += Environment.NewLine + i + ". Nr fature: " + dr["NR_FATURE"].ToString() +
                            "  Furnitori: " + dr["FURNITORI"].ToString() + "  Data: " + dr["DATA_BLERJE_STR"].ToString();
                        i++;
                    }
                    MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnKerko_Click(sender, e);
                }
            }
        }

        private void gridBlerjet_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (e.Column.Key == "CHECKED")
            {
                Janus.Windows.GridEX.GridEXRow r = gridBlerjet.GetRow(gridBlerjet.Row);
                int idBlerja = Convert.ToInt32(r.Cells["ID_BLERJA"].Text);
                if (r.Cells["CHECKED"].Text != "")
                {

                    bool vlera = Convert.ToBoolean(r.Cells["CHECKED"].Text);
                    bool finish = false;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        if (Convert.ToInt32(dr["ID_BLERJA"]) == idBlerja)
                        {
                            dr["CHECKED"] = vlera;
                            finish = true;
                        }
                        else if (finish)
                            break;
                    }
                }
            }
        }

        private void gridBlerjet_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            gridBlerjet.Refresh();
            gridBlerjet.UpdateData();
        }

        private void cbNrFature_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbNrFature.Checked == true)
            {
                this.txtNrFatureKerkim.Text = "";
                this.txtNrFatureKerkim.Enabled = true;
            }
            else
            {
                this.txtNrFatureKerkim.Text = "";
                this.txtNrFatureKerkim.Enabled = false;
                this.txtNrFatureKerkim.BackColor = Color.White;
            }
        }

        private void btnOfertat_Click(object sender, EventArgs e)
        {
            if (Convert.IsDBNull(dsBlerja.Tables[0].Rows[0]["ID_FURNITORI"]))
            {
                MessageBox.Show(this, "Për blerjen e zgjedhur është fshirë furnitori." + 
                    Environment.NewLine + "Për pasojë blerja nuk mund të modifikohet.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataSet dsOferta = new DataSet();
            DataTable dt = dsBlerja.Tables[1].Clone();
            dsOferta.Tables.Add(dt);
            DataSet dsArtikuj = new DataSet();
            DataTable dt1 = dsBlerja.Tables[1].Clone();
            dsArtikuj.Tables.Add(dt1);
            dsOferta.AcceptChanges();
            dsArtikuj.AcceptChanges();
            foreach (DataRow dr in dsBlerja.Tables[1].Rows)
            {
                if (Convert.ToDouble(dr["CMIMI"]) == 0)
                {
                    DataRow newR = dsOferta.Tables[0].NewRow();
                    newR["ID_ARTIKULLI"] = dr["ID_ARTIKULLI"];
                    newR["SASIA"] = dr["SASIA"];
                    newR["CMIMI"] = dr["CMIMI"];
                    newR["DATA_SKADENCA"] = dr["DATA_SKADENCA"];
                    newR["ID"] = dr["ID"];
                    newR["EMRI"] = dr["EMRI"];
                    newR["DATA_SKADENCA_STR"] = dr["DATA_SKADENCA_STR"];
                    newR["SASIA_STR"] = dr["SASIA_STR"];
                    newR["VLERA"] = dr["VLERA"];
                    newR["CHECKED"] = dr["CHECKED"];
                    newR["ID_KATEGORIAARTIKULLI"] = dr["ID_KATEGORIAARTIKULLI"];
                    newR["LLOJI"] = dr["LLOJI"];
                    newR["NJESIA"] = dr["NJESIA"];
                    newR["ID_ARTIKULLIFILLESTAR"] = dr["ID_ARTIKULLIFILLESTAR"];
                    newR["SASIA_KUSHT_OFERTA"] = dr["SASIA_KUSHT_OFERTA"];
                    newR["SQARIM_OFERTA"] = dr["SQARIM_OFERTA"];
                    newR["NJESIA_FILLESTAR"] = dr["NJESIA_FILLESTAR"];
                    dsOferta.Tables[0].Rows.Add(newR);
                }
                else
                {
                    DataRow newR = dsArtikuj.Tables[0].NewRow();
                    newR["ID_ARTIKULLI"] = dr["ID_ARTIKULLI"];
                    newR["SASIA"] = dr["SASIA"];
                    newR["CMIMI"] = dr["CMIMI"];
                    newR["DATA_SKADENCA"] = dr["DATA_SKADENCA"];
                    newR["ID"] = dr["ID"];
                    newR["EMRI"] = dr["EMRI"];
                    newR["DATA_SKADENCA_STR"] = dr["DATA_SKADENCA_STR"];
                    newR["SASIA_STR"] = dr["SASIA_STR"];
                    newR["VLERA"] = dr["VLERA"];
                    newR["CHECKED"] = dr["CHECKED"];
                    newR["ID_KATEGORIAARTIKULLI"] = dr["ID_KATEGORIAARTIKULLI"];
                    newR["LLOJI"] = dr["LLOJI"];
                    newR["NJESIA"] = dr["NJESIA"];
                    dsArtikuj.Tables[0].Rows.Add(newR);
                }
            }
            dsOferta.AcceptChanges();
            dsArtikuj.AcceptChanges();
            frmModifikoOferteFurnitori frm = new frmModifikoOferteFurnitori();
            frm.dsOfertat = dsOferta;
            frm.dsArtikujt = dsArtikuj;
            frm.dsBlerja = this.dsBlerja;
            frm.dataBlerje = Convert.ToDateTime(dtpData.Value);
            frm.idFurnitori = Convert.ToInt32(dsBlerja.Tables[0].Rows[0]["ID_FURNITORI"]);
            frm.ShowDialog();
            if (frm.pergjigje == "ok")
            {
                this.dsBlerja = frm.dsBlerja;
            }
        }

        private void cmbFurnitori_ValueChanged(object sender, EventArgs e)
        {
            PastroBlerje();
        }
        #endregion      

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridBlerjet.RowCount != 0)
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
            fushat[0] = "Artikulli";
            fushat[1] = "Sasia";
            fushat[2] = "Cmimi";
            fushat[3] = "Vlera";
            fushat[4] = "Dt_skadence";


            key[0] = "EMRI";
            key[1] = "SASIA_STR";
            key[2] = "CMIMI";
            key[3] = "VLERA";
            key[4] = "DATA_SKADENCA_STR";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "float";
            llojet[3] = "float";
            llojet[4] = "char(255)";

            KlaseExcel excel = new KlaseExcel("Blerjet.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("Blerjet.xls", gridBlerjet,
                    fushat, key, llojet, "EMRI");
                
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Blerjet.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (gridBlerjet.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion

        private void frmShfaqBlerjet_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            MbushCombo();
            //ne gride shfaqim vetem blerjet e bera sot
            string kushti = "WHERE DATA_BLERJE BETWEEN GETDATE() AND GETDATE() " +
                            " OR (YEAR(DATA_BLERJE) = YEAR(GETDATE()) AND MONTH(DATA_BLERJE) = MONTH(GETDATE()) " +
                            " AND DAY(DATA_BLERJE) = DAY(GETDATE())) OR (YEAR(DATA_BLERJE) = YEAR(GETDATE()) " +
                            " AND MONTH(DATA_BLERJE) = MONTH(GETDATE()) " +
                            " AND DAY(DATA_BLERJE) = DAY(GETDATE()))";
            MbushGride(kushti);
            MbushCombo();
            this.BllokoKerkimin();

        }

    }
}
