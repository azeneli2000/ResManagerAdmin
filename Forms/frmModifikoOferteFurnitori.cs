using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmModifikoOferteFurnitori : Form
    {
        #region FormLoad
        public int idFurnitori = 0;
        public DateTime dataBlerje;
        private int id = 0;
        public string pergjigje = "";


        public frmModifikoOferteFurnitori()
        {
            InitializeComponent();
        }

        private void frmModifikoOferteFurnitori_Load(object sender, EventArgs e)
        {
            gridOfertat.DataSource = this.dsOfertat.Tables[0];
            gridOfertat.BringToFront();
            GjejArtikujtNeBlerje();
            MbushCombo();
        }
        #endregion

        #region PrivateMethods
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

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.RowCount <= 18)
                grid.RootTable.Columns["SQARIM_OFERTA"].Width = 364;
            else
                grid.RootTable.Columns["SQARIM_OFERTA"].Width = 347;
        }

        private void PastroKontrolle()
        {
            cmbArtikujtNeBlerje.Text = "";
            cmbArtikujtNeBlerje.Value = null;
            numArtikujtKusht.Value = 0;
            txtNjesiaArtikujtKusht.Clear();

            cmbKategoriaOferta.Text = "";
            cmbKategoriaOferta.Value = null;
            cmbArtikujtQellim.DataSource = null;
            cmbArtikujtQellim.Text = "";
            cmbArtikujtQellim.Value = null;
            numArtikujtQellim.Value = 0;
            txtNjesiaArtikujQellim.Clear();
            sasiaOferta.Clear();
            this.id = 0;
            dtpDataSkadencaOferte.Value = DateTime.Now;
        }

        private void GjejArtikujtNeBlerje()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();
            ds.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            ds.Tables[0].Columns.Add("EMRI", typeof(String));
            ds.Tables[0].Columns.Add("NJESIA", typeof(String));
            DataColumn[] celes = new DataColumn[1];
            celes[0] = ds.Tables[0].Columns["ID_ARTIKULLI"];
            ds.Tables[0].PrimaryKey = celes;
            foreach (DataRow dr in this.dsArtikujt.Tables[0].Rows)
            {
                int idArtikulli = Convert.ToInt32(dr["ID_ARTIKULLI"]);
                DataRow drSearch = ds.Tables[0].Rows.Find(idArtikulli);
                if (drSearch == null)
                {
                    DataRow newR = ds.Tables[0].NewRow();
                    newR["ID_ARTIKULLI"] = Convert.ToInt32(dr["ID_ARTIKULLI"]);
                    newR["EMRI"] = dr["EMRI"].ToString();
                    newR["NJESIA"] = dr["NJESIA"].ToString();
                    ds.Tables[0].Rows.Add(newR);
                }
            }
            ds.AcceptChanges();
            cmbArtikujtNeBlerje.DataSource = ds.Tables[0];
        }

        private void MbushCombo()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEArtikujve");
            this.cmbKategoriaOferta.DataSource = ds.Tables[0];
        }

        private void LlogaritOferten()
        {
            error1.SetError(cmbArtikujtNeBlerje, "");
            error1.SetError(numArtikujtKusht, "");
            error1.SetError(numArtikujtQellim, "");
            if (cmbArtikujtNeBlerje.Text != "" && cmbArtikujtNeBlerje.Value != null)
            {
                int idArtikulli = Convert.ToInt32(cmbArtikujtNeBlerje.Value);
                double sasiaArtikuj = 0;
                foreach (DataRow dr in dsBlerja.Tables[1].Rows)
                {
                    if (Convert.ToInt32(dr["ID_ARTIKULLI"]) == idArtikulli && dr["LLOJI"].ToString() == "Artikull")
                        sasiaArtikuj += Convert.ToDouble(dr["SASIA"]);
                }
                if (numArtikujtKusht.Value != 0 && numArtikujtQellim.Value != 0)
                {
                    double sasiaKusht = Convert.ToDouble(numArtikujtKusht.Value);
                    if (sasiaKusht > sasiaArtikuj)
                    {
                        this.sasiaOferta.Text = "0";
                    }
                    else
                    {
                        double sasiaQellim = Convert.ToDouble(numArtikujtQellim.Value);
                        double sasiaOferte = Math.Floor((sasiaArtikuj / sasiaKusht)) * sasiaQellim;
                        this.sasiaOferta.Text = Convert.ToDecimal(sasiaOferte).ToString();
                    }
                }
                else if (numArtikujtKusht.Value == 0)
                {
                    error1.SetError(numArtikujtKusht, "Caktoni numrin e artikujve që duhen blerë që oferta të inicializohet!");
                    this.sasiaOferta.Text = "0";
                }
                else if (numArtikujtQellim.Value == 0)
                {
                    error1.SetError(numArtikujtQellim, "Caktoni numrin e artikujve përbërës të ofertës!");
                    this.sasiaOferta.Text = "0";
                }
            }
            else
            {
                error1.SetError(cmbArtikujtNeBlerje, "Zgjidhni një prej artikujve si kusht për ofertën!");
                this.sasiaOferta.Text = "0";
            }
        }

        private bool GabimNeKonfigurimOferte()
        {
            this.error1.SetError(sasiaOferta, "");
            this.error1.SetError(dtpDataSkadencaOferte, "");
            int i = 0;
            if (sasiaOferta.Text == "0")
            {
                this.error1.SetError(sasiaOferta, "Sasia e artikujve të ofruar nuk mund të jetë 0!");
                i++;
            }
            if (dtpDataSkadencaOferte.Value.Date <= dataBlerje.Date)
            {
                this.error1.SetError(dtpDataSkadencaOferte, "Data e skadencës së artikullit duhet të jetë më e madhe se data e blerjes!");
                i++;
            }
            //nuk mund te behen dy oferta me te njejtet artikuj fillestar dhe perfundimtar
            int idArtikulliFillimi = Convert.ToInt32(cmbArtikujtNeBlerje.Value);
            int idArtikulliFund = Convert.ToInt32(cmbArtikujtQellim.Value);

            object[] celes = new object[3];
            celes[0] = idArtikulliFund;
            celes[1] = 0;
            celes[2] = Convert.ToDateTime(this.dtpDataSkadencaOferte.Value.ToString("yyyy-MM-dd")); ;
            DataRow drSearch = dsBlerja.Tables[1].Rows.Find(celes);
            if (drSearch != null)
            {
                if (uiTabPageOfertat.Text == "Shto ofertë")
                {
                    i++;
                    string s = "Ky artikull figuron një herë në blerje" + Environment.NewLine +
                        "me të njëjtin çmim blerje dhe datë skadence." + Environment.NewLine +
                        "Për të përfunduar veprimin modifikoni sasinë e blerë për këtë artikull!";
                    MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
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
            foreach (DataRow dr in dsBlerja.Tables[1].Rows)
            {
                if (Convert.ToDecimal(dr["CMIMI"]) == 0)
                {
                    if ((Convert.ToInt32(dr["ID_ARTIKULLI"]) == idArtikulliFund)
                        && (Convert.ToInt32(dr["ID_ARTIKULLIFILLESTAR"]) == idArtikulliFillimi)
                        && (this.id != Convert.ToInt32(dr["ID"])))
                    {
                        MessageBox.Show(this, "Për blerjen është aplikuar një herë një ofertë për të njëjtit artikuj!",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        i++;
                        break;
                    }
                }
            }
            if (i == 0)
                return false;
            else
                return true;
        }

        private void PlotesoTeDhena()
        {
            int i = gridOfertat.Row;
            if ((i >= 0) && (gridOfertat.GetRow(i).Cells["ID"].Text != ""))
            {
                //nqs vlera e artikullit te zgjedhur eshte 0 atehere eshte oferte
                if (Convert.ToDouble(gridOfertat.GetRow(i).Cells["VLERA"].Text) == 0)
                {
                    this.id = Convert.ToInt32(gridOfertat.GetRow(i).Cells["ID"].Text);
                    int idArtikulliKusht = Convert.ToInt32(gridOfertat.GetRow(i).Cells["ID_ARTIKULLIFILLESTAR"].Text);
                    cmbArtikujtNeBlerje.Value = Convert.ToInt32(gridOfertat.GetRow(i).Cells["ID_ARTIKULLIFILLESTAR"].Text);
                    double sasiaKusht = Convert.ToDouble(gridOfertat.GetRow(i).Cells["SASIA_KUSHT_OFERTA"].Text);
                    numArtikujtKusht.Value = Convert.ToDecimal(gridOfertat.GetRow(i).Cells["SASIA_KUSHT_OFERTA"].Text);
                    cmbKategoriaOferta.Value = Convert.ToInt32(gridOfertat.GetRow(i).Cells["ID_KATEGORIAARTIKULLI"].Text);
                    cmbArtikujtQellim.Value = Convert.ToInt32(gridOfertat.GetRow(i).Cells["ID_ARTIKULLI"].Text);
                    double sasiaTotale = Convert.ToDouble(gridOfertat.GetRow(i).Cells["SASIA"].Text);
                    double sasiaArtikuj = 0;
                    foreach (DataRow dr in dsBlerja.Tables[1].Rows)
                    {
                        if (Convert.ToInt32(dr["ID_ARTIKULLI"]) == idArtikulliKusht && dr["LLOJI"].ToString() == "Artikull")
                            sasiaArtikuj += Convert.ToDouble(dr["SASIA"]);
                    }
                    double sasiaOfruar = sasiaTotale / (Math.Floor(sasiaArtikuj / sasiaKusht));
                    numArtikujtQellim.Value = Convert.ToDecimal(sasiaOfruar);
                    //sasiaOferta.Text = sasiaTotale.ToString();
                    dtpDataSkadencaOferte.Value = Convert.ToDateTime(gridOfertat.GetRow(i).Cells["DATA_SKADENCA"].Text);
                }
            }
        }

        private int ShtoOferteNeBlerje()
        {
            if (GabimNeKonfigurimOferte())
                return 1;
            DataRow r = dsBlerja.Tables[1].NewRow();
            r["ID"] = dsBlerja.Tables[1].Rows.Count + 1;
            r["ID_ARTIKULLI"] = Convert.ToInt32(this.cmbArtikujtQellim.Value);
            r["ID_KATEGORIAARTIKULLI"] = Convert.ToInt32(this.cmbKategoriaOferta.Value);
            r["EMRI"] = cmbArtikujtQellim.Text;
            DateTime dataSkadenca = Convert.ToDateTime(this.dtpDataSkadencaOferte.Value.ToString("yyyy-MM-dd"));
            r["DATA_SKADENCA"] = dataSkadenca;
            r["DATA_SKADENCA_STR"] = dataSkadenca.ToString("dd.MM.yyyy");
            r["SASIA"] = Convert.ToDecimal(this.sasiaOferta.Text);
            r["CMIMI"] = 0;
            r["SASIA_STR"] = this.sasiaOferta.Text + " " + txtNjesiaArtikujQellim.Text;
            r["VLERA"] = 0;
            r["CHECKED"] = false;
            r["LLOJI"] = "Ofertë";
            r["NJESIA"] = txtNjesiaArtikujQellim.Text;

            r["SASIA_KUSHT_OFERTA"] = Convert.ToDecimal(numArtikujtKusht.Value);
            r["ID_ARTIKULLIFILLESTAR"] = Convert.ToInt32(cmbArtikujtNeBlerje.Value);
            r["SQARIM_OFERTA"] = "Për " + Convert.ToDecimal(numArtikujtKusht.Value) + " " + txtNjesiaArtikujtKusht.Text + " " + cmbArtikujtNeBlerje.Text +
                " ofrohen " + numArtikujtQellim.Value.ToString() + " " + txtNjesiaArtikujQellim.Text + " " + cmbArtikujtQellim.Text;
            dsBlerja.Tables[1].Rows.Add(r);
            dsBlerja.AcceptChanges();

            r = dsOfertat.Tables[0].NewRow();
            r["ID"] = dsBlerja.Tables[1].Rows.Count;
            r["ID_ARTIKULLI"] = Convert.ToInt32(this.cmbArtikujtQellim.Value);
            r["ID_KATEGORIAARTIKULLI"] = Convert.ToInt32(this.cmbKategoriaOferta.Value);
            r["EMRI"] = cmbArtikujtQellim.Text;
            r["DATA_SKADENCA"] = dataSkadenca;
            r["DATA_SKADENCA_STR"] = dataSkadenca.ToString("dd.MM.yyyy");
            r["SASIA"] = Convert.ToDecimal(this.sasiaOferta.Text);
            r["CMIMI"] = 0;
            r["SASIA_STR"] = this.sasiaOferta.Text + " " + txtNjesiaArtikujQellim.Text;
            r["VLERA"] = 0;
            r["CHECKED"] = false;
            r["LLOJI"] = "Ofertë";
            r["NJESIA"] = txtNjesiaArtikujQellim.Text;

            r["SASIA_KUSHT_OFERTA"] = Convert.ToDecimal(numArtikujtKusht.Value);
            r["ID_ARTIKULLIFILLESTAR"] = Convert.ToInt32(cmbArtikujtNeBlerje.Value);
            r["SQARIM_OFERTA"] = "Për " + Convert.ToDecimal(numArtikujtKusht.Value) + " " + txtNjesiaArtikujtKusht.Text + " " + cmbArtikujtNeBlerje.Text +
                " ofrohen " + numArtikujtQellim.Value.ToString() + " " + txtNjesiaArtikujQellim.Text + " " + cmbArtikujtQellim.Text;
            dsOfertat.Tables[0].Rows.Add(r);
            dsOfertat.AcceptChanges();
            FormatoGride(gridOfertat);
            return 0;
        }

        private int ModifikoOferteBlerje()
        {
            if (GabimNeKonfigurimOferte())
                return 1;
            int index = gridOfertat.Row;
            object[] celes = new object[3];
            celes[0] = Convert.ToInt32(gridOfertat.GetRow(index).Cells["ID_ARTIKULLI"].Text);
            celes[1] = Convert.ToDouble(gridOfertat.GetRow(index).Cells["CMIMI"].Text);
            celes[2] = Convert.ToDateTime(gridOfertat.GetRow(index).Cells["DATA_SKADENCA"].Text);
            DataRow drSearch = dsBlerja.Tables[1].Rows.Find(celes);
            if (drSearch != null)
            {
                DateTime dataSkadenca = Convert.ToDateTime(this.dtpDataSkadencaOferte.Value.ToString("yyyy-MM-dd"));
                drSearch["ID_ARTIKULLI"] = Convert.ToInt32(cmbArtikujtQellim.Value);
                drSearch["SASIA"] = Convert.ToDecimal(sasiaOferta.Text);
                drSearch["CMIMI"] = 0;
                drSearch["DATA_SKADENCA"] = dataSkadenca;
                drSearch["EMRI"] = cmbArtikujtQellim.Text;
                drSearch["DATA_SKADENCA_STR"] = dataSkadenca.ToString("dd.MM.yyyy");
                drSearch["SASIA_STR"] = numArtikujtQellim.Value + " " + txtNjesiaArtikujQellim.Text; ;
                drSearch["VLERA"] = 0;
                drSearch["CHECKED"] = false;

                drSearch["SASIA_KUSHT_OFERTA"] = Convert.ToDecimal(numArtikujtKusht.Value);
                drSearch["ID_ARTIKULLIFILLESTAR"] = Convert.ToInt32(cmbArtikujtNeBlerje.Value);
                drSearch["SQARIM_OFERTA"] = "Për " + Convert.ToDecimal(numArtikujtKusht.Value) + " " + txtNjesiaArtikujtKusht.Text + " " + cmbArtikujtNeBlerje.Text +
                    " ofrohen " + numArtikujtQellim.Value.ToString() + " " + txtNjesiaArtikujQellim.Text + " " + cmbArtikujtQellim.Text;
                dsBlerja.AcceptChanges();
            }
            else
                return 1;

            drSearch = this.dsOfertat.Tables[0].Rows.Find(celes);
            if (drSearch != null)
            {
                DateTime dataSkadenca = Convert.ToDateTime(this.dtpDataSkadencaOferte.Value.ToString("yyyy-MM-dd"));
                drSearch["ID_ARTIKULLI"] = Convert.ToInt32(cmbArtikujtQellim.Value);
                drSearch["SASIA"] = Convert.ToDecimal(sasiaOferta.Text);
                drSearch["CMIMI"] = 0;
                drSearch["DATA_SKADENCA"] = dataSkadenca;
                drSearch["EMRI"] = cmbArtikujtQellim.Text;
                drSearch["DATA_SKADENCA_STR"] = dataSkadenca.ToString("dd.MM.yyyy");
                drSearch["SASIA_STR"] = numArtikujtQellim.Value + " " + txtNjesiaArtikujQellim.Text; ;
                drSearch["VLERA"] = 0;
                drSearch["CHECKED"] = false;

                drSearch["SASIA_KUSHT_OFERTA"] = Convert.ToDecimal(numArtikujtKusht.Value);
                drSearch["ID_ARTIKULLIFILLESTAR"] = Convert.ToInt32(cmbArtikujtNeBlerje.Value);
                drSearch["SQARIM_OFERTA"] = "Për " + Convert.ToDecimal(numArtikujtKusht.Value) + " " + txtNjesiaArtikujtKusht.Text + " " + cmbArtikujtNeBlerje.Text +
                    " ofrohen " + numArtikujtQellim.Value.ToString() + " " + txtNjesiaArtikujQellim.Text + " " + cmbArtikujtQellim.Text;
                dsBlerja.AcceptChanges();
                return 0;
            }
            else
                return 1;

        }

        #endregion

        #region Event Handlers
        private void btnShtoOferte_Click(object sender, EventArgs e)
        {
            PastroKontrolle();
            uiTabPageOfertat.Text = "Shto ofertë";
            uiTabModifiko.Visible = true;
            gridOfertat.Visible = false;
            CaktivizoPanel(panelTop);
        }

        private void btnModifikoOferte_Click(object sender, EventArgs e)
        {
            int index = gridOfertat.Row;
            if (index >= 0)
            {
                uiTabModifiko.Visible = true;
                gridOfertat.Visible = false;
                uiTabPageOfertat.Text = "Modifiko ofertë";
                CaktivizoPanel(panelTop);
                PlotesoTeDhena();
            }
        }

        private void btnRuajOferte_Click(object sender, EventArgs e)
        {
            int b = 1;
            if (uiTabPageOfertat.Text == "Shto ofertë")
            {
                b = ShtoOferteNeBlerje();
            }
            else
            {
                b = ModifikoOferteBlerje();
            }
            if (b == 0)
            {
                uiTabModifiko.Visible = false;
                gridOfertat.Visible = true;
                AktivizoPanel(panelTop);
                PastroKontrolle();
            }
        }

        private void btnRuajKrijoOferte_Click(object sender, EventArgs e)
        {
            int b = 1;
            if (uiTabPageOfertat.Text == "Shto ofertë")
            {
                b = ShtoOferteNeBlerje();
            }
            else
            {
                b = ModifikoOferteBlerje();
            }
            if (b == 0)
            {
                PastroKontrolle();
            }
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            uiTabModifiko.Visible = false;
            gridOfertat.Visible = true;
            AktivizoPanel(panelTop);
            PastroKontrolle();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.pergjigje = "ok";
            Close();
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.pergjigje = "anullo";
            Close();
        }

        private void cmbKategoriaOferta_ValueChanged(object sender, EventArgs e)
        {
            InputController data = new InputController();
            int idKategoria = Convert.ToInt32(cmbKategoriaOferta.Value);
            DataSet ds = data.KerkesaRead("ShfaqArtikujPerKategoriFurnitor", idKategoria, this.idFurnitori);
            cmbArtikujtQellim.DataSource = ds.Tables[0];
        }

        private void numArtikujtKusht_ValueChanged(object sender, EventArgs e)
        {
            LlogaritOferten();
        }

        private void numArtikujtQellim_ValueChanged(object sender, EventArgs e)
        {
            LlogaritOferten();
        }

        private void cmbArtikujtNeBlerje_ValueChanged(object sender, EventArgs e)
        {
            int i = cmbArtikujtNeBlerje.DropDownList.Row;
            if (i >= 0)
            {
                string njesia = cmbArtikujtNeBlerje.DropDownList.GetRow(i).Cells["NJESIA"].Text;
                txtNjesiaArtikujtKusht.Text = njesia;
            }
            LlogaritOferten();
        }

        private void cmbArtikujtQellim_ValueChanged(object sender, EventArgs e)
        {
            int i = cmbArtikujtQellim.DropDownList.Row;
            if (i >= 0)
            {
                string njesia = cmbArtikujtQellim.DropDownList.GetRow(i).Cells["NJESIA"].Text;
                txtNjesiaArtikujQellim.Text = njesia;
            }
        }
        #endregion      
    }
}