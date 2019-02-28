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
    public partial class frmKrijoOferte : Form
    {

        private DataSet dsOferta = null;
        private int veprimi = 0;
        private int nrShporta = 0;

        public frmKrijoOferte()
        {
            InitializeComponent();
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.paneli.TitleText = s;
        }

      

        private void frmKrijoOferte_Load(object sender, EventArgs e)
        {
            this.LexoInformacione();

            this.optBari.Checked = true;

            this.MbushKomboGrupi();
            this.MbushKategorite();

            this.dsOferta = this.KrijoDataSetOferte();

            this.gridaOferta.DataSource = this.dsOferta.Tables[0];
            this.MbushGridenPerBarin();


            ///this.cboKategorite.SelectedValue = -1;
        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void MbushKomboGrupi()
        {
            this.cboGrupi.Items.Add("1");
            this.cboGrupi.Items.Add("2");
            this.cboGrupi.Items.Add("3");
            this.cboGrupi.Items.Add("4");
            this.cboGrupi.Items.Add("5");
            this.cboGrupi.Items.Add("6");
            this.cboGrupi.Items.Add("7");
            this.cboGrupi.Items.Add("8");
            this.cboGrupi.Items.Add("9");
            this.cboGrupi.Items.Add("10");
        }

        private void MbushKategorite()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteERecetave");

            this.cboKategorite.ValueMember = ds.Tables[0].Columns["ID_KATEGORIARECETA"].ColumnName;
            this.cboKategorite.DisplayMember = ds.Tables[0].Columns["PERSHKRIMI"].ColumnName;

            this.cboKategorite.DataSource = ds.Tables[0];
        }

        private void cboKategorite_ValueChanged(object sender, EventArgs e)
        {
            if (this.cboKategorite.Value == null)
            {
                return;
            }

            try
            {
                int idKat = Convert.ToInt32(this.cboKategorite.Value);

                this.MbushRecetat(idKat);
                this.cboRecetat.Value = null;
            }
            catch (Exception ex)
            {
                this.cboRecetat.DataSource = null;
            }
        }

        private void MbushRecetat(int idKat)
        {
            InputController data = new InputController();

            //DataSet ds = data.KerkesaRead("ShfaqRecetatPerKategori", celesi);
            //this.lstRecetat.DataSource = ds.Tables[0];
            //gridTeGjitha.DataSource = null;
            //gridKorrent.DataSource = null;
            //idZgjedhur = 0;

            DataSet ds = data.KerkesaRead("ShfaqRecetatPerKategoriOferte", idKat);
            this.cboRecetat.DataSource = ds.Tables[0];
        }

        private DataSet KrijoDataSetOferte()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("ID_KATEGORIARECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("SHPORTA", typeof(Int32));
            ds.Tables[0].Columns.Add("RECETA", typeof(string));
            ds.Tables[0].Columns.Add("SASIA", typeof(Int32));
           

            ds.AcceptChanges();

            return ds;



        }

        private void btnRuajRecete_Click(object sender, EventArgs e)
        {
            if (this.KaGabimReceta())
            {
                return;
            }

            int grupi = this.cboGrupi.SelectedIndex + 1;

           

            int idKat = Convert.ToInt32(this.cboKategorite.Value);
            int idReceta = Convert.ToInt32(this.cboRecetat.Value);
            string receta = this.cboRecetat.Text;

            int sasia = this.numSasia.Value;
            decimal cmimi = 0;
            decimal vlera = sasia * cmimi;

            if (this.GjendetReceta(idReceta, sasia, cmimi))
            {
                return;
            }


            DataRow dr = this.dsOferta.Tables[0].NewRow();


            dr["ID_KATEGORIARECETA"] = idKat;
            dr["ID_RECETA"] = idReceta;
            dr["SHPORTA"] = grupi;
            dr["RECETA"] = receta;
            dr["SASIA"] = sasia;
            

            this.dsOferta.Tables[0].Rows.Add(dr);

            if (grupi == this.nrShporta)
            {
                this.nrShporta = this.nrShporta + 1;
            }
        }

        private void cboRecetat_ValueChanged(object sender, EventArgs e)
        {
            if (this.cboRecetat.Value == null)
            {
                this.numSasia.Value = 0;
                return;
            }

            try
            {
                int idReceta = Convert.ToInt32(this.cboRecetat.Value);
                this.numSasia.Value = 1;
            }
            catch (Exception ex)
            {
                this.numSasia.Value = 0;
            }


        }

        private bool GjendetReceta(int idReceta, int sasia, decimal cmimi)
        {
            bool gjendet = false;
            int celesi = 0;

            if (this.dsOferta.Tables[0].Rows.Count > 0)
            {


                foreach (DataRow dr in this.dsOferta.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_RECETA"]);

                    if (celesi == idReceta)
                    {
                        gjendet = true;
                        dr["SASIA"] = sasia;

                    }
                }

                this.dsOferta.Tables[0].AcceptChanges();

            }

            return gjendet;
        }

        private bool KaGabimReceta()
        {
            int indeksi = this.cboGrupi.SelectedIndex + 1;

            string shporta = "shporta";

            if (this.nrShporta == 2)
            {
                shporta = "shporte";
            }

            if (indeksi > this.nrShporta)
            {
                MessageBox.Show(this, "Ju deri tani keni konfiguruar " + (this.nrShporta - 1).ToString() + "  " + shporta + ". Indeksi i shportes se re nuk mund te jete me i madh se " + this.nrShporta.ToString() + "  .", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return true;
            }

            if (this.cboGrupi.Text.Trim() == "")
            {
                MessageBox.Show(this, "Ju duhet te percaktoni indeksin e shportes ku do te beje pjese produkti !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
                return true;
            }

            int idReceta = 0;

            try
            {
                idReceta = Convert.ToInt32(this.cboRecetat.Value);

                if (idReceta == 0)
                {
                    MessageBox.Show(this, "Ju duhet te percaktoni produktin !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Ju duhet te percaktoni produktin !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (this.numSasia.Value == 0)
            {
                MessageBox.Show(this, "Sasia per produktin nuk mund te jete 0 !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void btnRuajOferte_Click(object sender, EventArgs e)
        {
            if (this.KaGabimOferta())
            {
                return;
            }

            string oferta = this.txtEmri.Text.Trim();
            decimal cmimi = this.numCmimi.Value;
            int shportat = this.KtheNrShporta();

            string tipi = "R";
            if (this.optHoteli.Checked == true)
            {
                tipi = "H";
            }

            InputController data = new InputController();
            int b = 0;

            if (this.veprimi == 0)
            {
                b = data.KerkesaUpdate("KrijoOferte", oferta, tipi, shportat, cmimi, this.dsOferta);
            }
            else
            {
                int indeksi = this.grida.Row;
                int idOferta = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);

                b = data.KerkesaUpdate("ModifikoOferte", idOferta, oferta, tipi, shportat, cmimi, this.dsOferta);

            }

            if (this.optBari.Checked == true)
            {
                this.MbushGridenPerBarin();
            }
            else
            {
                this.MbushGridenPerHotelin();
            }

            this.grida.Visible = true;
            this.veprimi = 0;
            this.Aktivizo();
            this.Pastro();


        }

        private int KtheNrShporta()
        {
            int numri = 0;

            int shporta = 0;

            foreach (DataRow dr in this.dsOferta.Tables[0].Rows)
            {
                shporta = Convert.ToInt32(dr["SHPORTA"]);

                if (numri < shporta)
                {
                    numri = shporta;
                }
            }

            return numri;

        }

        private bool KaGabimOferta()
        {
            if (this.txtEmri.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te jepni emrin e ofertes !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (this.dsOferta.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Oferta duhet te permbaje te pakten nje recete !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void MbushGridenPerBarin()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqOfertatPerBarin");

            if (ds != null)
            {
                this.grida.DataSource = ds.Tables[0];
            }
        }

        private void MbushGridenPerHotelin()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqOfertatPerHotelin");

            if (ds != null)
            {
                this.grida.DataSource = ds.Tables[0];
            }
        }

        private void btnShtoOferte_Click(object sender, EventArgs e)
        {
            this.Pastro();
            
            this.veprimi = 0;
            this.grida.Visible = false;
            this.Caktivizo();
            this.nrShporta = 1;

        }

        private void Aktivizo()
        {
            this.btnShtoOferte.Enabled = true;
            this.btnModifikoOferte.Enabled = true;
            this.btnCaktivizo.Enabled = true;
            this.btnAktivizo.Enabled = true;

            this.optBari.Enabled = true;
            this.optHoteli.Enabled = true;

        }

        private void Caktivizo()
        {
            this.btnShtoOferte.Enabled = false;
            this.btnModifikoOferte.Enabled = false;
            this.btnCaktivizo.Enabled = false;
            this.btnAktivizo.Enabled = false;

            this.optBari.Enabled = false;
            this.optHoteli.Enabled = false;

          

        }

        private void Pastro()
        {
            this.cboGrupi.SelectedValue = -1;
            this.cboKategorite.Value = null;
            this.cboRecetat.DataSource = null;
            this.numSasia.Value = 0;

            this.txtEmri.Text = "";
            this.numCmimi.Value = 0;

            try
            {
                this.dsOferta.Tables[0].Rows.Clear();
            }
            catch (Exception ex)
            {
            }

        }

        private void btnAnulloOferte_Click(object sender, EventArgs e)
        {
            this.grida.Visible = true;
            this.veprimi = 0;
            this.Aktivizo();
            this.Pastro();
        }

        private void btnModifikoOferte_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;
            if (indeksi < 0)
            {
                return;
            }

            string emri = Convert.ToString(this.grida.GetRow(indeksi).Cells[1].Text);
            decimal cmimi = Convert.ToDecimal(this.grida.GetRow(indeksi).Cells[2].Text);
            int nrShportash = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[3].Text);

            this.nrShporta = nrShportash + 1;

            this.txtEmri.Text = emri;
            this.numCmimi.Value = cmimi;

            int idOferta = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTeDhenaPerOferten", idOferta);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = this.dsOferta.Tables[0].NewRow();

                drNew["ID_RECETA"] = dr["ID_RECETA"];
                drNew["ID_KATEGORIARECETA"] = drNew["ID_KATEGORIARECETA"];
                drNew["SHPORTA"] = dr["SHPORTA"];
                drNew["RECETA"] = dr["RECETA"];
                drNew["SASIA"] = dr["SASIA"];

                this.dsOferta.Tables[0].Rows.Add(drNew);
            }

            this.dsOferta.Tables[0].AcceptChanges();

            this.tabi.SelectedTabIndex = 1;
            this.veprimi = 1;
            this.grida.Visible = false;
            this.Caktivizo();


        }

        private void grida_DoubleClick(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;
            if (indeksi < 0)
            {
                return;
            }

            string emri = Convert.ToString(this.grida.GetRow(indeksi).Cells[1].Text);
            decimal cmimi = Convert.ToDecimal(this.grida.GetRow(indeksi).Cells[2].Text);
            int nrShportash = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[3].Text);

            this.txtEmri.Text = emri;
            this.numCmimi.Value = cmimi;

            int idOferta = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTeDhenaPerOferten", idOferta);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = this.dsOferta.Tables[0].NewRow();

                drNew["ID_RECETA"] = dr["ID_RECETA"];
                drNew["ID_KATEGORIARECETA"] = drNew["ID_KATEGORIARECETA"];
                drNew["SHPORTA"] = dr["SHPORTA"];
                drNew["RECETA"] = dr["RECETA"];
                drNew["SASIA"] = dr["SASIA"];

                this.dsOferta.Tables[0].Rows.Add(drNew);
            }

            this.dsOferta.Tables[0].AcceptChanges();

            this.veprimi = 1;
            this.grida.Visible = false;
            this.Caktivizo();
        }

        private void btnFshiRecete_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaOferta.Row;

            if (indeksi < 0)
            {
                return;
            }

            try
            {
                int idReceta = Convert.ToInt32(this.gridaOferta.GetRow(indeksi).Cells[0].Text);
                int indeksiShporta = 0;
                int celesi = 0;

                foreach (DataRow dr in this.dsOferta.Tables[0].Rows)
                {
                    celesi = Convert.ToInt32(dr["ID_RECETA"]);

                    if (celesi == idReceta)
                    {
                        indeksiShporta = Convert.ToInt32(dr["SHPORTA"]);
                        this.ModifikoIndeksiShporta(indeksiShporta);

                        int numriRreshtash = this.dsOferta.Tables[0].Rows.Count;

                        this.dsOferta.Tables[0].Rows.Remove(dr);
                        //this.dsOferta.Tables[0].AcceptChanges();

                        int nrGrupi = this.KtheNrShporta();

                        if (nrGrupi < this.nrShporta - 1)
                        {
                            this.nrShporta = this.nrShporta - 1;
                        }
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void ModifikoIndeksiShporta(int indeksi)
        {
            int numri = 0;
            int grupi = 0;

            foreach (DataRow dr in this.dsOferta.Tables[0].Rows)
            {
                grupi = Convert.ToInt32(dr["SHPORTA"]);

                if (grupi == indeksi)
                {
                    numri = numri + 1;
                }
            }

            if (numri == 1)
            {
                foreach (DataRow dr in this.dsOferta.Tables[0].Rows)
                {
                    grupi = Convert.ToInt32(dr["SHPORTA"]);

                    if (grupi > indeksi)
                    {
                        dr["SHPORTA"] = grupi - 1;
                    }
                }

                this.dsOferta.Tables[0].AcceptChanges();

            }
        }

        private void optBari_CheckedChanged(object sender, EventArgs e)
        {
            if (this.optBari.Checked == true)
            {
                this.MbushGridenPerBarin();
            }
            else
            {
                this.MbushGridenPerHotelin();
            }
        }

        private void btnCaktivizo_Click(object sender, EventArgs e)
        {

        }


    }
}