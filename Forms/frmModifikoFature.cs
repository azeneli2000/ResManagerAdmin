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
    public partial class frmModifikoFature : Form
    {
        public int idFatura;
        public string dataFatura;
        public string nrFatura;
        public string kamarieri;
        public string tavolina;
        public string skonto;
        public string totali;
        public DataSet dsFatura;
        public int veprimi = 0;

        private int zgjidhArtikull = 0;

        public frmModifikoFature()
        {
            InitializeComponent();
        }

        private void panelBack_Click(object sender, EventArgs e)
        {

        }

        private void MbushGriden()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTeDhenaPerFaturen", this.idFatura);

            if (ds == null)
            {
                MessageBox.Show("Ju keni hasur nje problem ne aksesimin e bazes se te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

        
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = this.dsFatura.Tables[0].NewRow();

                drNew["ID_RECETA"] = dr["ID_RECETA"];
                drNew["EMRI"] = dr["EMRI"];
                drNew["CMIMI"] = dr["VLERA"];
                drNew["SASIA"] = dr["SASIA"];
                drNew["VLERA"] = dr["TOTALI"];

                this.dsFatura.Tables[0].Rows.Add(drNew);
            }

            this.dsFatura.Tables[0].AcceptChanges();

            this.gridaFatura.DataSource = dsFatura.Tables[0];
        }

        private void frmModifikoFature_Load(object sender, EventArgs e)
        {
            this.dsFatura = this.KrijoDataSet();

            this.MbushGriden();
            this.MbushKategoriRecetash();

            this.lblDataOra.Text = this.dataFatura;
            this.lblTavolina.Text = this.tavolina;
            this.lblNrFatura.Text = this.nrFatura;
            this.lblKamarieri.Text = this.kamarieri;

            this.optVlera.Checked = true;
            this.txtSkonto.Text = "0";
        }

        private void MbushKategoriRecetash()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteERecetave");

            if (ds == null)
            {
                return;
            }

            this.cboKategorite.DataSource = ds.Tables[0];
            
        }

        private void cboKategorite_ValueChanged(object sender, EventArgs e)
        {
            int celesi = Convert.ToInt32(this.cboKategorite.Value);

            InputController data = new InputController();
            
            string strSql = "";
            strSql = "SELECT ID_RECETA, EMRI FROM RECETAT WHERE ID_KATEGORIARECETA = " + celesi + " AND ID_RECETA IN (SELECT ID_RECETA FROM CMIMET_PERIUDHA_RECETAT)";

            DataSet ds = data.KerkesaRead("ShfaqArtikujtPerBar", strSql);

            if (ds == null)
            {
                return;
            }

            this.zgjidhArtikull = 0;

            this.gridaArtikujt.DataSource = ds.Tables[0];

        }

        private DataSet KrijoDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("EMRI", typeof(string));
            ds.Tables[0].Columns.Add("CMIMI", typeof(double));
            ds.Tables[0].Columns.Add("SASIA", typeof(Int32));
            ds.Tables[0].Columns.Add("NJESIA", typeof(string));
            ds.Tables[0].Columns.Add("VLERA", typeof(double));
           


            ds.Tables[0].AcceptChanges();

            return ds;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaFatura.Row;
            int nrReshta = this.gridaFatura.RowCount;

            if (indeksi < 0 || indeksi >= nrReshta - 1)
            {
                return;
            }

            if (indeksi < 0)
            {
                return;
            }

            int celesi = Convert.ToInt32(this.gridaFatura.GetRow(indeksi).Cells[0].Text);

            double cmimi = 0;
            int sasia = 0;

            double vlera = 0;



            int idArtikulli = 0;

            foreach (DataRow dr in this.dsFatura.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);

                if (idArtikulli == celesi)
                {
                    sasia = Convert.ToInt32(dr["SASIA"]);
                    sasia = sasia + 1;
                    dr["SASIA"] = Convert.ToInt32(sasia);

                    cmimi = Convert.ToDouble(dr["CMIMI"]);
                    vlera = cmimi * sasia;

                    dr["VLERA"] = vlera;

                }
            }

            this.dsFatura.Tables[0].AcceptChanges();

            //this.gridaFatura.GetRow(indeksi).Cells[4].Text = sasia.ToString();
            //this.gridaFatura.GetRow(indeksi).Cells[5].Text = vlera.ToString();

            this.gridaFatura.Row = indeksi;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridaFatura.Row;
            int nrReshta = this.gridaFatura.RowCount;

            if (indeksi < 0 || indeksi >= nrReshta - 1)
            {
                return;
            }

            if (indeksi < 0)
            {
                return;
            }

            int celesi = Convert.ToInt32(this.gridaFatura.GetRow(indeksi).Cells[0].Text);

            double cmimi = 0;
            int sasia = 0;

            double vlera = 0;



            int idArtikulli = 0;

            foreach (DataRow dr in this.dsFatura.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);

                if (idArtikulli == celesi)
                {
                    sasia = Convert.ToInt32(dr["SASIA"]);
                    if (sasia == 1)
                    {
                        this.dsFatura.Tables[0].Rows.Remove(dr);
                        this.dsFatura.Tables[0].AcceptChanges();
                        return;
                    }

                    sasia = sasia - 1;
                    dr["SASIA"] = Convert.ToInt32(sasia);

                    cmimi = Convert.ToDouble(dr["CMIMI"]);
                    vlera = cmimi * sasia;

                    dr["VLERA"] = vlera;

                }
            }

            this.dsFatura.Tables[0].AcceptChanges();

            this.gridaFatura.Row = indeksi;
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridaArtikujt_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            
        }

        private bool GjendetArtikulli(int idArtikulli)
        {
            try
            {
                int celesi = 0;
                if (dsFatura != null && dsFatura.Tables.Count != 0)
                {
                    foreach (DataRow dr in dsFatura.Tables[0].Rows)
                    {
                        celesi = Convert.ToInt32(dr["ID_RECETA"]);
                        

                        if (celesi == idArtikulli)
                        {
                            return true;
                        }

                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void gridaArtikujt_CurrentCellChanged(object sender, EventArgs e)
        {
            this.zgjidhArtikull = this.zgjidhArtikull + 1;
            if (this.zgjidhArtikull == 1)
            {
                return;
            }

            int indeksi = this.gridaArtikujt.Row;
            if (indeksi < 0)
            {
                return;
            }

            string emriArtikulli = Convert.ToString(this.gridaArtikujt.GetRow(indeksi).Cells["EMRI"].Text);
            int idArtikulli = Convert.ToInt32(this.gridaArtikujt.GetRow(indeksi).Cells[0].Text);
            string llojiArtikulli = "R";

            if (this.GjendetArtikulli(idArtikulli))
            {
                return;
            }

            InputController data = new InputController();

            DataSet ds = data.KerkesaRead("LexoTeDhenaPerArtikullin", "R", idArtikulli);

            if (ds == null)
            {
                DialogResult result = MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                DialogResult result = MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double numriTotal = Convert.ToDouble(ds.Tables[0].Rows[0]["NUMRI_TOTAL"]);
            string nameStock = Convert.ToString(ds.Tables[0].Rows[0]["EMRI"]);

            if (numriTotal < 1)
            {
                MessageBox.Show("Ju nuk keni asnje artikull  '" + nameStock + "'  ne magazine.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow dr = dsFatura.Tables[0].NewRow();


            if (llojiArtikulli == "A")
            {
                dr["ID_RECETA"] = ds.Tables[0].Rows[0]["CELESI"];
                dr["EMRI"] = ds.Tables[0].Rows[0]["EMRI"];
                dr["CMIMI"] = ds.Tables[0].Rows[0]["VLERA"];
                dr["SASIA"] = Convert.ToInt32(1);
                dr["VLERA"] = Convert.ToDouble(dr["CMIMI"]);


                dsFatura.Tables[0].Rows.Add(dr);






            }
            else
            {
                dr["ID_RECETA"] = ds.Tables[0].Rows[0]["CELESI"];
                dr["EMRI"] = ds.Tables[0].Rows[0]["EMRI"];
                dr["CMIMI"] = ds.Tables[0].Rows[0]["VLERA"];
                dr["SASIA"] = 1;
                dr["VLERA"] = Convert.ToDouble(dr["CMIMI"]);


                dsFatura.Tables[0].Rows.Add(dr);
            }

            dsFatura.Tables[0].AcceptChanges();

            int numri = dsFatura.Tables[0].Rows.Count;
            int indeksiReshti = numri - 1;


            this.gridaFatura.Row = indeksiReshti;
            this.gridaFatura.Focus();

            //this.gridaFatura.DataSource = null;
            ///this.gridaFatura.DataSource = dsFatura.Tables[0];

            return;
        }

        private DataSet KrijoDataSetRuaj()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("CELESI", typeof(string));
            ds.Tables[0].Columns.Add("LLOJI", typeof(string));
            ds.Tables[0].Columns.Add("SASIA", typeof(int));

            ds.Tables[0].AcceptChanges();

            return ds;
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            int nrArtikuj = this.dsFatura.Tables[0].Rows.Count;
            if (nrArtikuj == 0)
            {
                return;
            }

            InputController data = new InputController();
            DataSet dsRuaj = this.KrijoDataSetRuaj();

            double totali = 0;
            int nr = this.gridaFatura.RowCount - 1;
            if (nr == 0)
            {
                return;
            }

            for (int i = 0; i < nr; i++)
            {
                DataRow dr = dsRuaj.Tables[0].NewRow();

                dr["CELESI"] = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["ID_RECETA"].Text);
                dr["LLOJI"] = "R";
                dr["SASIA"] = Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["SASIA"].Text);

                totali = totali + Convert.ToDouble(this.gridaFatura.GetRow(i).Cells["CMIMI"].Text) * Convert.ToInt32(this.gridaFatura.GetRow(i).Cells["SASIA"].Text);

                dsRuaj.Tables[0].Rows.Add(dr);
            }

            dsRuaj.Tables[0].AcceptChanges();

            double skonto = 0;
            int perqindja = 0;

            string strSkonto = "";
            strSkonto = this.txtSkonto.Text;

            if (this.optVlera.Checked == true)
            {
                skonto = Convert.ToDouble(strSkonto);
            }
            else
            {
                skonto = totali * Convert.ToInt32(strSkonto) / 100;
            }

            
            
            int b = data.KerkesaUpdate("ModifikoFature", this.idFatura, totali, skonto, dsRuaj);

            if (b != 0)
            {
                MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e bazes se te dhenave!", "Kudes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.veprimi = 1;
            this.Close();
        }


    }
}