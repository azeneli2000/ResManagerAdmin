using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using System.Data.OleDb;
using System.IO;

namespace ResManagerAdmin.Forms
{
    public partial class frmBlerjeArtikujsh : Form
    {
        private int id = 0;
        private int upDirection = 0;

        #region Form Load
        public frmBlerjeArtikujsh()
        {
            InitializeComponent();
        }

        private void frmBlerjeArtikujsh_Load(object sender, EventArgs e)
        {
            LexoInformacione();
            dtpDateBlerje.Value = DateTime.Now;
            dtpOreBlerje.Value = DateTime.Now;
            gridArtikujt.DataSource = dsBlerja.Tables[1];

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

        private void MbushCombo()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqFurnitoret", "");
            cmbFurnitori.DataSource = ds.Tables[0];
            ds = data.KerkesaRead("ShfaqKategoriteEArtikujve");
            cmbKategoriaArtikulli.DataSource = ds.Tables[0];
            cmbKategoriaOferta.DataSource = ds.Tables[0];
        }

        private void PastroKontrolle()
        {
            cmbKategoriaArtikulli.Text = "";
            cmbKategoriaArtikulli.Value = null;
            cmbArtikulli.DataSource = null;
            numSasia.Value = 0;
            txtNjesia.Clear();
            numCmimi.Value = 0;
            txtVlera.Clear();
            pictureBoxFoto.Image = null;
            this.id = 0;
            dtpDataSkadenca.Value = DateTime.Now;
            this.chkDateSkadenca.Checked = false;
            this.dtpDataSkadenca.Enabled = false;
        }

        private void PastroKontrolleOferta()
        {
            cmbArtikujtNeBlerje.DataSource = null;
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

        private void PastroForme()
        {
            PastroKontrolle();
            PastroKontrolleOferta();
            dsBlerja.Tables[0].Clear();
            dsBlerja.Tables[1].Clear();
            dtpDateBlerje.Value = DateTime.Now;
            dtpOreBlerje.Value = DateTime.Now;
            cmbFurnitori.Value = null;
            cmbFurnitori.Text = null;
            txtNrFature.Clear();
        }

        private bool GabimNeKonfigurimArtikulli()
        {
            this.error1.SetError(dtpDataSkadenca, "");
            int i = 0;

            if (this.chkDateSkadenca.Checked == true)
            {
                if (dtpDataSkadenca.Value.Date <= dtpDateBlerje.Value.Date)
                {
                    this.error1.SetError(dtpDataSkadenca, "Data e skadencës së artikullit duhet të jetë më e madhe se data e blerjes!");
                    i++;
                }
            }

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
                if (uiTabPageArtikujt.Text == "Shto artikull")
                {
                    i++;
                    string s = "Ky artikull figuron një herë në blerje" + Environment.NewLine +
                        "me të njëjtin çmim blerje dhe datë skadence." + Environment.NewLine +
                        "Për të përfunduar veprimin modifikoni sasinë e blerë për këtë artikull!";
                    MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (uiTabPageArtikujt.Text == "Modifiko artikull")
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

        private bool GabimNeKonfigurimOferte()
        {
            this.error1.SetError(sasiaOferta, "");
            this.error1.SetError(dtpDataSkadencaOferte, "");
            int i = 0;
            if (sasiaOferta.Text == "0" || sasiaOferta.Text == "")
            {
                this.error1.SetError(sasiaOferta, "Sasia e artikujve të ofruar nuk mund të jetë 0!");
                i++;
            }
            if (dtpDataSkadencaOferte.Value.Date <= dtpDateBlerje.Value.Date)
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
            celes[2] = Convert.ToDateTime(this.dtpDataSkadencaOferte.Value.ToString("yyyy-MM-dd"));;
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

        private int ShtoArtikullNeBlerje()
        {
            if ((cmbKategoriaArtikulli.Value != null) &&
                (cmbKategoriaArtikulli.Text != null) &&
                (cmbArtikulli.Value != null) &&
                (cmbArtikulli.Text != "") &&
                (numSasia.Value != 0) &&
                (txtNjesia.Text != "") &&
                (numCmimi.Value != 0) &&
                (txtVlera.Text != "") &&
                (txtVlera.Text != "0"))
            {
                if (GabimNeKonfigurimArtikulli() == true)
                    return 1;
                else
                {
                    DataRow r = dsBlerja.Tables[1].NewRow();
                    r["ID"] = dsBlerja.Tables[1].Rows.Count + 1;
                    r["ID_ARTIKULLI"] = Convert.ToInt32(cmbArtikulli.Value);
                    r["ID_KATEGORIAARTIKULLI"] = Convert.ToInt32(cmbKategoriaArtikulli.Value);
                    r["EMRI"] = cmbArtikulli.Text;

                    DateTime dataSkadenca = Convert.ToDateTime(dtpDataSkadenca.Value.ToString("yyyy-MM-dd"));
                    if (chkDateSkadenca.Checked == true)
                    {
                        r["DATA_SKADENCA"] = dataSkadenca;
                       
                        
                        r["DATA_SKADENCA_STR"] = dataSkadenca.ToString("dd.MM.yyyy");
                        
                      
                    }
                    else
                    {
                        DateTime dataSkadencaOther = dataSkadenca.AddYears(100);
                        r["DATA_SKADENCA"] = dataSkadencaOther;
                        r["DATA_SKADENCA_STR"] = "";
                    }
                    
                    r["SASIA"] = numSasia.Value;
                    r["CMIMI"] = numCmimi.Value;
                    r["SASIA_STR"] = numSasia.Value + " " + txtNjesia.Text;
                    r["VLERA"] = Convert.ToDouble(txtVlera.Text);
                    r["CHECKED"] = false;
                    r["LLOJI"] = "Artikull";
                    r["NJESIA"] = txtNjesia.Text;
                    dsBlerja.Tables[1].Rows.Add(r);
                    dsBlerja.AcceptChanges();
                    //FormatoGride(gridArtikujt);
                    return 0;
                }
            }
            else
                return 1;
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
            if (chkDateSkadenca.Checked == true)
            {
                r["DATA_SKADENCA"] = dataSkadenca;


                r["DATA_SKADENCA_STR"] = dataSkadenca.ToString("dd.MM.yyyy");


            }
            else
            {
                DateTime dataSkadencaOther = dataSkadenca.AddYears(100);
                r["DATA_SKADENCA"] = dataSkadencaOther;
                r["DATA_SKADENCA_STR"] = "";
            }
                    
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
            //FormatoGride(gridArtikujt);
            return 0;
        }

        private int ModifikoArtikullBlerje()
        {
            if ((cmbKategoriaArtikulli.Value != null) &&
                (cmbKategoriaArtikulli.Text != null) &&
                (cmbArtikulli.Value != null) &&
                (cmbArtikulli.Text != "") &&
                (numSasia.Value != 0) &&
                (txtNjesia.Text != "") &&
                (numCmimi.Value != 0) &&
                (txtVlera.Text != "") &&
                (txtVlera.Text != "0"))
            {
                if (GabimNeKonfigurimArtikulli() == true)
                    return 1;
                else
                {
                    int i = gridArtikujt.Row;
                    int idArtikulli = Convert.ToInt32(gridArtikujt.GetRow(i).Cells["ID_ARTIKULLI"].Text);
                    if (idArtikulli != Convert.ToInt32(cmbArtikulli.Value))
                    {
                        foreach (DataRow dr in dsBlerja.Tables[1].Rows)
                        {
                            if ((dr["ID_ARTIKULLIFILLESTAR"].ToString() != "") && (Convert.ToInt32(dr["ID_ARTIKULLIFILLESTAR"]) == idArtikulli))
                            {
                                string s = "Për artikullin " + gridArtikujt.GetRow(i).Cells["EMRI"].Text + " janë konfiguruar oferta." + Environment.NewLine +
                                    "Artikulli nuk mund të modifikohet pa hequr më parë ofertat përkatese!";
                                MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return 1;
                            }
                        }
                    }
                    int index = gridArtikujt.Row;
                    object[] celes = new object[3];
                    celes[0] = Convert.ToInt32(gridArtikujt.GetRow(index).Cells["ID_ARTIKULLI"].Text);
                    celes[1] = Convert.ToDouble(gridArtikujt.GetRow(index).Cells["CMIMI"].Text);
                    celes[2] = Convert.ToDateTime(gridArtikujt.GetRow(index).Cells["DATA_SKADENCA"].Text);
                    DataRow drSearch = dsBlerja.Tables[1].Rows.Find(celes);
                    if (drSearch != null)
                    {
                        DateTime dataSkadenca = Convert.ToDateTime(dtpDataSkadenca.Value.ToString("yyyy-MM-dd"));
                        drSearch["ID_ARTIKULLI"] = Convert.ToInt32(cmbArtikulli.Value);
                        drSearch["SASIA"] = numSasia.Value;
                        drSearch["CMIMI"] = numCmimi.Value;
                        drSearch["EMRI"] = cmbArtikulli.Text;

                        if (chkDateSkadenca.Checked == true)
                        {
                            drSearch["DATA_SKADENCA"] = dataSkadenca;


                            drSearch["DATA_SKADENCA_STR"] = dataSkadenca.ToString("dd.MM.yyyy");


                        }
                        else
                        {
                            DateTime dataSkadencaOther = dataSkadenca.AddYears(100);
                            drSearch["DATA_SKADENCA"] = dataSkadencaOther;
                            drSearch["DATA_SKADENCA_STR"] = "";
                        }

                        drSearch["SASIA_STR"] = numSasia.Value + " " + txtNjesia.Text; ;
                        drSearch["VLERA"] = Convert.ToDouble(txtVlera.Text);
                        drSearch["CHECKED"] = false;
                        dsBlerja.AcceptChanges();
                        return 0;
                    }
                    else
                        return 1;
                }
            }
            else
                return 1;
        }

        private int ModifikoOferteBlerje()
        {
            if (GabimNeKonfigurimOferte())
                return 1;
            int index = gridArtikujt.Row;
            object[] celes = new object[3];
            celes[0] = Convert.ToInt32(gridArtikujt.GetRow(index).Cells["ID_ARTIKULLI"].Text);
            celes[1] = Convert.ToDouble(gridArtikujt.GetRow(index).Cells["CMIMI"].Text);
            celes[2] = Convert.ToDateTime(gridArtikujt.GetRow(index).Cells["DATA_SKADENCA"].Text);
            DataRow drSearch = dsBlerja.Tables[1].Rows.Find(celes);
            if (drSearch != null)
            {
                DateTime dataSkadenca = Convert.ToDateTime(this.dtpDataSkadencaOferte.Value.ToString("yyyy-MM-dd"));
                drSearch["ID_ARTIKULLI"] = Convert.ToInt32(cmbArtikujtQellim.Value);
                drSearch["SASIA"] = Convert.ToDecimal(sasiaOferta.Text); ;
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

        private void PlotesoTeDhena()
        {
            int i = gridArtikujt.Row;
            if ((i >= 0) && (gridArtikujt.GetRow(i).Cells["ID"].Text != ""))
            {
                //nqs vlera e artikullit te zgjedhur eshte 0 atehere eshte oferte
                if (Convert.ToDouble(gridArtikujt.GetRow(i).Cells["VLERA"].Text) == 0)
                {
                    if (uiTabModifiko.Visible == true)
                    {
                        uiTabPageOfertat.TabVisible = true;
                        uiTabPageOfertat.Text = "Modifiko ofertë";
                        uiTabPageArtikujt.TabVisible = false;
                    }
                    this.id = Convert.ToInt32(gridArtikujt.GetRow(i).Cells["ID"].Text);
                    GjejArtikujtNeBlerje();
                    int idArtikulliKusht = Convert.ToInt32(gridArtikujt.GetRow(i).Cells["ID_ARTIKULLIFILLESTAR"].Text);
                    cmbArtikujtNeBlerje.Value = Convert.ToInt32(gridArtikujt.GetRow(i).Cells["ID_ARTIKULLIFILLESTAR"].Text);
                    double sasiaKusht = Convert.ToDouble(gridArtikujt.GetRow(i).Cells["SASIA_KUSHT_OFERTA"].Text);
                    numArtikujtKusht.Value = Convert.ToDecimal(gridArtikujt.GetRow(i).Cells["SASIA_KUSHT_OFERTA"].Text);
                    cmbKategoriaOferta.Value = Convert.ToInt32(gridArtikujt.GetRow(i).Cells["ID_KATEGORIAARTIKULLI"].Text);
                    cmbArtikujtQellim.Value = Convert.ToInt32(gridArtikujt.GetRow(i).Cells["ID_ARTIKULLI"].Text);
                    double sasiaTotale = Convert.ToDouble(gridArtikujt.GetRow(i).Cells["SASIA"].Text);
                    double sasiaArtikuj = 0;
                    foreach (DataRow dr in dsBlerja.Tables[1].Rows)
                    {
                        if (Convert.ToInt32(dr["ID_ARTIKULLI"]) == idArtikulliKusht && dr["LLOJI"].ToString() == "Artikull")
                            sasiaArtikuj += Convert.ToDouble(dr["SASIA"]);
                    }
                    double sasiaOfruar = sasiaTotale / (Math.Floor(sasiaArtikuj / sasiaKusht));
                    numArtikujtQellim.Value = Convert.ToDecimal(sasiaOfruar);
                    //sasiaOferta.Text = sasiaTotale.ToString();
                    dtpDataSkadencaOferte.Value = Convert.ToDateTime(gridArtikujt.GetRow(i).Cells["DATA_SKADENCA"].Text);
                }
                else
                {
                    if (uiTabModifiko.Visible == true)
                    {
                        uiTabPageArtikujt.TabVisible = true;
                        uiTabPageArtikujt.Text = "Modifiko artikull";
                        uiTabPageOfertat.TabVisible = false;
                    }
                    this.id = Convert.ToInt32(gridArtikujt.GetRow(i).Cells["ID"].Text);
                    cmbKategoriaArtikulli.Value = Convert.ToInt32(gridArtikujt.GetRow(i).Cells["ID_KATEGORIAARTIKULLI"].Text);
                    cmbArtikulli.Value = Convert.ToInt32(gridArtikujt.GetRow(i).Cells["ID_ARTIKULLI"].Text);
                    numSasia.Value = Convert.ToDecimal(Convert.ToDouble(gridArtikujt.GetRow(i).Cells["SASIA"].Text));
                    numCmimi.Value = Convert.ToDecimal(Convert.ToDouble(gridArtikujt.GetRow(i).Cells["CMIMI"].Text));
                    dtpDataSkadenca.Value = Convert.ToDateTime(gridArtikujt.GetRow(i).Cells["DATA_SKADENCA"].Text);
                }
            }
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.RowCount <= 18)
                grid.RootTable.Columns["DATA_SKADENCA_STR"].Width = 131;
            else
                grid.RootTable.Columns["DATA_SKADENCA_STR"].Width = 114;
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
            foreach (DataRow dr in dsBlerja.Tables[1].Rows)
            {
                if (dr["LLOJI"].ToString() == "Artikull")
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
            }
            ds.AcceptChanges();
            cmbArtikujtNeBlerje.DataSource = ds.Tables[0];
        }
        #endregion

        #region Event Handlers

        private void btnShtoArtikull_Click(object sender, EventArgs e)
        {
            PastroKontrolle();
            this.uiTabPageArtikujt.Text = "Shto artikull";
            this.uiTabModifiko.Visible = true;
            uiTabPageArtikujt.TabVisible = true;
            uiTabPageOfertat.TabVisible = false;
            this.gridArtikujt.Visible = false;
            this.CaktivizoPanel(panelTop);
            this.CaktivizoPanel(panelBottom);
        }

        private void btnShtoOferte_Click(object sender, EventArgs e)
        {
            PastroKontrolleOferta();
            this.uiTabPageOfertat.Text = "Shto ofertë";
            this.uiTabModifiko.Visible = true;
            uiTabPageOfertat.TabVisible = true;
            uiTabPageArtikujt.TabVisible = false;
            this.gridArtikujt.Visible = false;
            this.CaktivizoPanel(panelTop);
            this.CaktivizoPanel(panelBottom);
        }

        private void btnModifikoArtikull_Click(object sender, EventArgs e)
        {
            PastroKontrolle();
            PastroKontrolleOferta();
            if (gridArtikujt.Row >= 0 && gridArtikujt.RowCount >= 1 && gridArtikujt.Row != gridArtikujt.RowCount - 1)
            {
                int index = gridArtikujt.Row;
                double vlera  = Convert.ToDouble(gridArtikujt.GetRow(index).Cells["VLERA"].Text);
                //nqs vlera eshte 0 atehere artikulli i shtuar eshte oferte
                if (vlera == 0)
                {
                    this.uiTabModifiko.Visible = true;
                    this.gridArtikujt.Visible = false;
                    uiTabPageOfertat.TabVisible = true;
                    uiTabPageArtikujt.TabVisible = false;
                    this.uiTabPageOfertat.Text = "Modifiko ofertë";
                    this.CaktivizoPanel(panelTop);
                    PlotesoTeDhena();
                }
                else
                {
                    this.uiTabModifiko.Visible = true;
                    this.gridArtikujt.Visible = false;
                    uiTabPageArtikujt.TabVisible = true;
                    uiTabPageOfertat.TabVisible = false;
                    this.uiTabPageArtikujt.Text = "Modifiko artikull";
                    this.CaktivizoPanel(panelTop);
                    PlotesoTeDhena();
                }
            }
        }

        private void btnFshiArtikull_Click(object sender, EventArgs e)
        {
            int i = gridArtikujt.Row;
            string s = "Për artikuj më poshtë janë konfiguruar oferta." + Environment.NewLine +
                "Artikujt nuk mund të hiqen nga blerja pa hequr më parë ofertat përkatese!";
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("EMRI", typeof(String));
            dsError.AcceptChanges();
            foreach(DataRow dr in dsBlerja.Tables[1].Rows)
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
            FormatoGride(gridArtikujt);
        }

        private bool KaGabimNeShtim()
        {
            if (this.cmbArtikulli.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te zgjidhni nje prej artikujve !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            try
            {
                int idKat = Convert.ToInt32(this.cmbArtikulli.Value);


            }

            catch (Exception ex)
            {
                MessageBox.Show("Artikulli i zgjedhur nga ju nuk eshte i regjistruar ne program !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;

        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (this.KaGabimNeShtim() == true)
            {
                return;
            }

            int b = 1;
            if (uiTabPageArtikujt.Text == "Shto artikull")
            {
                b = ShtoArtikullNeBlerje();
            }
            else
            {
                b = ModifikoArtikullBlerje();
            }
            if (b == 0)
            {
                PastroKontrolle();
                this.uiTabModifiko.Visible = false;
                this.gridArtikujt.Visible = true;
                this.AktivizoPanel(panelTop);
                this.AktivizoPanel(panelBottom);
            }
        }

        private void btnRuajKrijo_Click(object sender, EventArgs e)
        {
            if (this.KaGabimNeShtim() == true)
            {
                return;
            }

            int b = 1;
            if (uiTabPageArtikujt.Text == "Shto artikull")
            {
                b = ShtoArtikullNeBlerje();
            }
            else
            {
                b = ModifikoArtikullBlerje();
            }
            if (b == 0)
            {
                PastroKontrolle();
                uiTabPageArtikujt.Text = "Shto artikull";
                CaktivizoPanel(panelBottom);
                GjejArtikujtNeBlerje();
            }
        } 

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            PastroKontrolle();
            this.uiTabModifiko.Visible = false;
            this.gridArtikujt.Visible = true;
            this.AktivizoPanel(panelTop);
            this.AktivizoPanel(panelBottom);
        }
 
        private void cmbKategoriaArtikulli_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                error1.SetError(cmbFurnitori, "");
                int idKategoria = Convert.ToInt32(cmbKategoriaArtikulli.Value);
                int idFurnitori = 0;
                if (cmbFurnitori.Text != "" && cmbFurnitori.Value != null)
                    idFurnitori = Convert.ToInt32(cmbFurnitori.Value);
                else
                    error1.SetError(cmbFurnitori, "Duhet të zgjidhni më parë një prej furnitorëve!");
                InputController data = new InputController();
                DataSet ds = data.KerkesaRead("ShfaqArtikujPerKategoriFurnitor", idKategoria, idFurnitori);
                cmbArtikulli.DataSource = ds.Tables[0];

                cmbArtikulli.Value = null;
                cmbArtikulli.Text = "";
                numSasia.Value = 0;
                txtNjesia.Clear();
                numCmimi.Value = 0;
                txtVlera.Clear();
                pictureBoxFoto.Image = null;
            }
            catch(Exception ex)
            {
                this.cmbArtikulli.DataSource = null;
            }

            
        }

        private void cmbArtikulli_ValueChanged(object sender, EventArgs e)
        {
            numSasia.Value = 0;
            txtNjesia.Clear();
            numCmimi.Value = 0;
            txtVlera.Clear();
            pictureBoxFoto.Image = null;
            int i = cmbArtikulli.DropDownList.Row;
            if (i >= 0)
            {
                string njesia = cmbArtikulli.DropDownList.GetRow(i).Cells["NJESIA"].Text;
                txtNjesia.Text = njesia;
                //duhet shtuar edhe shfaqja e imazhit
            }
        }

        private void numSasia_ValueChanged(object sender, EventArgs e)
        {
            Double vlera = Convert.ToDouble(numSasia.Value * numCmimi.Value);
            txtVlera.Text = vlera.ToString();
        }

        private void numCmimi_ValueChanged(object sender, EventArgs e)
        {
            Double vlera = Convert.ToDouble(numSasia.Value * numCmimi.Value);
            txtVlera.Text = vlera.ToString();
        }

        private void gridArtikujt_CurrentCellChanged(object sender, EventArgs e)
        {
            //int index = this.gridArtikujt.Row;
            //if (index == 0)
            //{
            //    int i = index;
            //    while (i < gridArtikujt.RowCount)
            //    {
            //        i++;
            //        if (gridArtikujt.GetRow(i).Cells["ID_ARTIKULLI"].Text != "" ||
            //            i == gridArtikujt.RowCount - 1)
            //            break;
            //    }
            //    gridArtikujt.Row = i;
            //    return;
            //}
            //if ((index >= 0) && (gridArtikujt.GetRow(index).Cells["ID_ARTIKULLI"].Text != ""))
            //{
            //    PlotesoTeDhena();
            //}
            //else
            //{
            //    if ((index > 0) && (upDirection == 1))
            //    {
            //        gridArtikujt.Row = index - 1;
            //        upDirection = 0;
            //        return;
            //    }
            //    if ((gridArtikujt.RowCount > index + 1)&& (index + 1 >= 0))
            //    {
            //        gridArtikujt.Row = index + 1;
            //        return;
            //    }
            //}
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            gridArtikujt.ExpandGroups();
            if (gridArtikujt.RowCount > 0)
            {
                gridArtikujt.Row = 0;
            } 
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            upDirection = 1;
            gridArtikujt.ExpandGroups();
            if ((gridArtikujt.Row >= 1) && (gridArtikujt.Row - 1 >= 0))
            {
                gridArtikujt.Row = gridArtikujt.Row - 1;
            }
            
        }

        private void btnPAs_Click(object sender, EventArgs e)
        {
            gridArtikujt.ExpandGroups();
            if ((gridArtikujt.Row <= gridArtikujt.RowCount - 2) && (gridArtikujt.Row + 1 >= 0))
            {
                gridArtikujt.Row = gridArtikujt.Row + 1;
            }
            
        }

        private void btnFundit_Click(object sender, EventArgs e)
        {
            gridArtikujt.ExpandGroups();
            if ((gridArtikujt.RowCount > 0) && (gridArtikujt.RowCount - 3 >= 0))
            {
                gridArtikujt.Row = gridArtikujt.RowCount - 3;
            }
            
        }

        private bool KaGabimNeBlerje()
        {
            if (this.cmbFurnitori.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te zgjidhni nje prej furnitoreve !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            try
            {
                int idFurnitori = Convert.ToInt32(this.cmbFurnitori.Value);


            }

            catch (Exception ex)
            {
                MessageBox.Show("Furnitori i zgjedhur nga ju nuk eshte i regjistruar ne program !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;

        }

        private void btnPerfundo_Click(object sender, EventArgs e)
        {
            if (this.KaGabimNeBlerje() == true)
            {
                return;
            }

            //furnitori nuk duhet te jete bosh
            //dhe blerja duhet te permbaje te pakten nje artikull
            if (cmbFurnitori.Value != null && cmbFurnitori.Text != "")
            {
                if (dsBlerja.Tables[1].Rows.Count == 0)
                {
                    MessageBox.Show(this, "Para se të përfundoni blerjen duhet të keni hedhur" +
                        Environment.NewLine + "të paktën një artikull në shportë!", this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                //nqs tabela e dyte me te dhenat per blerjen e ka nje rresht
                //duhet modifikuar vetem rreshti ekzistues
                if (dsBlerja.Tables[0].Rows.Count != 0)
                {
                    dsBlerja.Tables[0].Rows[0]["DATA_BLERJE"] = Convert.ToDateTime(dtpDateBlerje.Value.ToString("yyyy-MM-dd") + ' ' + dtpOreBlerje.Value.ToShortTimeString());
                    dsBlerja.Tables[0].Rows[0]["ID_FURNITORI"] = Convert.ToInt32(cmbFurnitori.Value);
                    dsBlerja.Tables[0].Rows[0]["NR_FATURE"] = txtNrFature.Text;
                }
                else
                {
                    DataRow r = dsBlerja.Tables[0].NewRow();
                    r["DATA_BLERJE"] = Convert.ToDateTime(dtpDateBlerje.Value.ToString("yyyy-MM-dd") + ' ' + dtpOreBlerje.Value.ToShortTimeString());
                    r["ID_FURNITORI"] = Convert.ToInt32(cmbFurnitori.Value);
                    r["NR_FATURE"] = txtNrFature.Text;
                    dsBlerja.Tables[0].Rows.Add(r);

                }
                dsBlerja.AcceptChanges();
                InputController data = new InputController();
                int b = data.KerkesaUpdate("ShtoBlerje", dsBlerja);
                if (b == 0)
                {
                    MessageBox.Show(this, "Blerja u ruajt!", this.Text, MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    this.PastroForme();
                }
                else if (b == 2)
                {
                    MessageBox.Show(this, "Blerja nuk u ruajt!" + Environment.NewLine +
                        "Për furnitorin e zgjedhur ekziston një blerje me të njëjtin numër fature!", this.Text, MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show(this, "Një gabim ndodhi gjatë ruajtjes së blerjes. Provoni përsëri!", this.Text, MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void uiTabPageOfertat_VisibleChanged(object sender, EventArgs e)
        {
            if (uiTabPageOfertat.TabVisible == true)
            {
                GjejArtikujtNeBlerje();
            }
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

        private void multiColumnCombo1_ValueChanged(object sender, EventArgs e)
        {
            error1.SetError(cmbFurnitori, "");
            int idKategoria = Convert.ToInt32(cmbKategoriaOferta.Value);
            int idFurnitori = 0;
            if (cmbFurnitori.Text != "" && cmbFurnitori.Value != null)
                idFurnitori = Convert.ToInt32(cmbFurnitori.Value);
            else
                error1.SetError(cmbFurnitori, "Duhet të zgjidhni më parë një prej furnitorëve!");
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqArtikujPerKategoriFurnitor", idKategoria, idFurnitori);
            cmbArtikujtQellim.DataSource = ds.Tables[0];
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

        private void numArtikujtKusht_ValueChanged(object sender, EventArgs e)
        {
            LlogaritOferten();
        }

        private void numArtikujtQellim_ValueChanged(object sender, EventArgs e)
        {
            LlogaritOferten();
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
                PastroKontrolleOferta();
                gridArtikujt.Visible = true;
                uiTabModifiko.Visible = false;
                AktivizoPanel(panelTop);
                AktivizoPanel(panelBottom);
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
                PastroKontrolleOferta();
                uiTabPageOfertat.Text = "Shto ofertë";
                CaktivizoPanel(panelBottom);
                uiTabPageOfertat.TabVisible = true;
                uiTabPageArtikujt.TabVisible = false;
            }
        }

        private void cmbFurnitori_ValueChanged(object sender, EventArgs e)
        {
            dsBlerja.Tables[1].Rows.Clear();
            PastroKontrolle();
            PastroKontrolleOferta();
        }

        private void uiGroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void chkDateSkadenca_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkDateSkadenca.Checked == true)
            {
                this.dtpDataSkadenca.Enabled = true;
                
            }
            else
            {
                this.dtpDataSkadenca.Enabled = false;
            }
        }

        private void frmBlerjeArtikujsh_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            MbushCombo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                //blerja
                DataRow r = dsBlerja.Tables[0].NewRow();
                r["DATA_BLERJE"] = Convert.ToDateTime(dtpDateBlerje.Value.ToString("yyyy-MM-dd") + ' ' + dtpOreBlerje.Value.ToShortTimeString());
                r["ID_FURNITORI"] = Convert.ToInt32(cmbFurnitori.Value);
                r["NR_FATURE"] = txtNrFature.Text;
                dsBlerja.Tables[0].Rows.Add(r);

                //blerja detajet
                //lexo nga exceli
                string connString;
                OleDbConnection conn = new OleDbConnection();
                string excelPath = @"C:\Excel Restoranti";
                string file = "artikujt.xls";
                OleDbCommand cmd = new OleDbCommand();
                connString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                       @"Data Source=" + excelPath + "\\" + file +
                       @";Extended Properties=""Excel 8.0;HDR=YES""";
                conn.ConnectionString = connString;
                conn.Open();
                cmd.Connection = conn;
                string str = "SELECT * FROM [" + file.Remove(file.Length - 4) + "$] ";
                cmd.CommandText = str;
                OleDbDataReader reader = cmd.ExecuteReader();
                InputController data = new InputController();
                DataSet dsArtikujt = data.KerkesaRead("ShfaqArtikujt");
                DataTable dtArtikujt = dsArtikujt.Tables[0];
                string gabim = "";
                while (reader.Read())
                {
                    DataRow dataRow = dsBlerja.Tables[1].NewRow();
                    dataRow["ID"] = dsBlerja.Tables[1].Rows.Count + 1;
                    dataRow["EMRI"] = reader.GetValue(0).ToString();
                    //gjej id dhe kategorine e artikullit
                    DataRow[] rArtikulli = dtArtikujt.Select("EMRI = '" + reader.GetValue(0).ToString() + "'");
                    if (rArtikulli.Length != 1)
                    {
                        gabim += reader.GetValue(0).ToString() + Environment.NewLine;
                    }
                    else if (reader.GetValue(0).ToString().StartsWith("Kategoria:"))
                    {
                        continue;
                    }
                    else
                    {
                        dataRow["ID_ARTIKULLI"] = Convert.ToInt32(rArtikulli[0]["ID_ARTIKULLI"]);
                        dataRow["ID_KATEGORIAARTIKULLI"] = Convert.ToInt32(rArtikulli[0]["ID_KATEGORIAARTIKULLI"]);
                        dataRow["DATA_SKADENCA"] = DateTime.Now.AddYears(100);
                        dataRow["DATA_SKADENCA_STR"] = "";
                        decimal sasia = Convert.ToDecimal(reader.GetValue(3));
                        decimal cmimi = 1;
                        string njesia = rArtikulli[0]["NJESIA"].ToString();
                        dataRow["SASIA"] = sasia;
                        dataRow["CMIMI"] = 1;
                        dataRow["SASIA_STR"] = numSasia.Value + " " + njesia;
                        dataRow["VLERA"] = sasia * cmimi;
                        dataRow["CHECKED"] = false;
                        dataRow["LLOJI"] = "Artikull";
                        dataRow["NJESIA"] = njesia;
                        dsBlerja.Tables[1].Rows.Add(dataRow);
                        dsBlerja.AcceptChanges();
                    }
                }
                File.WriteAllText("C:\\gabimet.txt", gabim);
                conn.Close();
                int b = data.KerkesaUpdate("ShtoBlerje", dsBlerja);
                if (b == 0)
                {
                    MessageBox.Show(this, "Te dhenat u importuan", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
  }
        #endregion
}