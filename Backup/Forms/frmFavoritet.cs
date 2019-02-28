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
    public partial class frmFavoritet : Form
    {
        private DataSet dsFavorite = null;
        private DataSet dsArtikujt = null;
        private DataSet dsRecetat = null;
        private int nrFavorite = 10;


        public frmFavoritet()
        {
            InitializeComponent();
        }

        private void frmFavoritet_Load(object sender, EventArgs e)
        {
            this.LexoInformacione();

            
            
        }

        private void MbushFavorite()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqFavorite");

            this.dsFavorite.Tables[0].Rows.Clear();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drFav = this.dsFavorite.Tables[0].NewRow();

                drFav["ID_FAVORITE"] = dr["ID_FAVORITE"];

                drFav["EMRI"] = dr["EMRI"];
                drFav["LLOJI"] = dr["LLOJI"];
                drFav["PRIORITETI"] = dr["PRIORITETI"];
                drFav["CHECKED"] = false;

                this.dsFavorite.Tables[0].Rows.Add(drFav);

            }

            this.dsFavorite.Tables[0].AcceptChanges();
            this.gridaFavorite.DataSource = this.dsFavorite.Tables[0];

        }

        private void MbushArtikujt()
        {
            //InputController data = new InputController();
            //DataSet ds = data.KerkesaRead("ShfaqArtikujtSipasKategorive");

            //DataSet dsArtikujt = this.KonvertoDataSetinArtikujt(ds);

            //this.gridaArtikujt.DataSource = dsArtikujt.Tables[0];

        }

        private DataSet KrijoDataSetArtikujt()
        {
            DataSet dsArt = new DataSet();
            dsArt.Tables.Add();
            dsArt.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            dsArt.Tables[0].Columns.Add("EMRI", typeof(string));
            dsArt.Tables[0].Columns.Add("CHECKED", typeof(bool));
            dsArt.Tables[0].Columns.Add("ID_KATEGORIAARTIKULLI", typeof(Int32));
            dsArt.Tables[0].Columns.Add("PERSHKRIMI", typeof(string));

            dsArt.Tables[0].AcceptChanges();

            return dsArt;

        }

        private DataSet KrijoDataSetRecetat()
        {
            DataSet dsRec = new DataSet();
            dsRec.Tables.Add();
            dsRec.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            dsRec.Tables[0].Columns.Add("EMRI", typeof(string));
            dsRec.Tables[0].Columns.Add("CHECKED", typeof(bool));
            dsRec.Tables[0].Columns.Add("ID_KATEGORIARECETA", typeof(Int32));
            dsRec.Tables[0].Columns.Add("PERSHKRIMI", typeof(string));

            dsRec.Tables[0].AcceptChanges();

            return dsRec;
        }

        private DataSet KonvertoDataSetinArtikujt(DataSet ds)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drArtikulli = dsArtikujt.Tables[0].NewRow();

                drArtikulli["ID_ARTIKULLI"] = dr["ID_ARTIKULLI"];
                drArtikulli["EMRI"] = dr["EMRI"];
                drArtikulli["CHECKED"] = false;
                drArtikulli["ID_KATEGORIAARTIKULLI"] = dr["ID_KATEGORIAARTIKULLI"];
                drArtikulli["PERSHKRIMI"] = dr["PERSHKRIMI"];

                dsArtikujt.Tables[0].Rows.Add(drArtikulli);
            }

            dsArtikujt.Tables[0].AcceptChanges();

            return dsArtikujt;
        }

        private void MbushRecetat()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqRecetatSipasKategorivePerFavorite");

            DataSet dsRecetat = this.KonvertoDataSetinRecetat(ds);

            this.gridaRecetat.DataSource = dsRecetat.Tables[0];
        }

        private DataSet KonvertoDataSetinRecetat(DataSet ds)
        {
           

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drReceta = dsRecetat.Tables[0].NewRow();

                drReceta["ID_RECETA"] = dr["ID_RECETA"];
                drReceta["EMRI"] = dr["EMRI"];
                drReceta["CHECKED"] = false;
                drReceta["ID_KATEGORIARECETA"] = dr["ID_KATEGORIARECETA"];
                drReceta["PERSHKRIMI"] = dr["PERSHKRIMI"];

                dsRecetat.Tables[0].Rows.Add(drReceta);

            }

            dsRecetat.Tables[0].AcceptChanges();

            return dsRecetat;
        }

        private DataSet KrijoDataSetFavorite()
        {
            DataSet dsFav = new DataSet();
            dsFav.Tables.Add();

            dsFav.Tables[0].Columns.Add("ID_FAVORITE", typeof(Int32));
            dsFav.Tables[0].Columns.Add("EMRI", typeof(string));
            dsFav.Tables[0].Columns.Add("LLOJI", typeof(string));
            dsFav.Tables[0].Columns.Add("PRIORITETI", typeof(Int32));
            dsFav.Tables[0].Columns.Add("CHECKED", typeof(bool));

            DataColumn[] celesi = new DataColumn[2];
            celesi[0] = dsFav.Tables[0].Columns["ID_FAVORITE"];
            celesi[1] = dsFav.Tables[0].Columns["LLOJI"];
            dsFav.Tables[0].PrimaryKey = celesi;

            dsFav.Tables[0].AcceptChanges();

            return dsFav;


        }

        private void btnPara_Click(object sender, EventArgs e)
        {
           
                this.KaloRecetat();
                this.PastroZgjedhjen();

        
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            this.HiqTeZgjedhura(this.dsFavorite);
            this.PastroZgjedhjen();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {

            InputController data = new InputController();
            int b = data.KerkesaUpdate("HidhFavorite", this.dsFavorite);

            if (b == 0)
            {
                
                MessageBox.Show(this, "Menuja e shpejte u rikonfigurua !", "Menu e shpejte !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PastroZgjedhjen();
            }
        }

        private void HiqTeZgjedhura(DataSet ds)
        {
            int numri = ds.Tables[0].Rows.Count;
            bool zgjedhur = false;
            for (int i = 0; i < numri; i++)
            {
                zgjedhur = Convert.ToBoolean(ds.Tables[0].Rows[i]["CHECKED"]);
                if (zgjedhur == true)
                {
                    ds.Tables[0].Rows.RemoveAt(i);
                    numri = numri - 1;
                    i = i - 1;
                }
            }

            int j = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                j = j + 1;

                dr["PRIORITETI"] = j;
            }

            ds.Tables[0].AcceptChanges();
        }

        private void KaloRecetat()
        {
            int numri = this.KtheNrFavorite();

            for (int i = 0; i < this.gridaRecetat.RowCount; i++)
            {
                if (this.gridaRecetat.GetRow(i).Cells[0].Text != "")
                {
                    if (numri >= this.nrFavorite)
                    {
                        this.dsFavorite.Tables[0].AcceptChanges();
                        return;
                    }
                    if (this.gridaRecetat.GetRow(i).Cells["CHECKED"].Text == "True")
                    {
                        object[] cKerko = new object[2];
                        cKerko[0] = Convert.ToInt32(this.gridaRecetat.GetRow(i).Cells["ID_RECETA"].Text);
                        cKerko[1] = "R";
                        DataRow drKerko = this.dsFavorite.Tables[0].Rows.Find(cKerko);
                        if (drKerko == null)
                        {
                            DataRow dr = this.dsFavorite.Tables[0].NewRow();
                            dr["ID_FAVORITE"] = Convert.ToInt32(this.gridaRecetat.GetRow(i).Cells["ID_RECETA"].Text);
                            dr["EMRI"] = Convert.ToString(this.gridaRecetat.GetRow(i).Cells["EMRI"].Text);
                            dr["LLOJI"] = "R";
                            dr["PRIORITETI"] = numri + 1;
                            dr["CHECKED"] = false;

                            this.dsFavorite.Tables[0].Rows.Add(dr);

                            numri = numri + 1;
                        }

                    }

                }
            }

            this.dsFavorite.Tables[0].AcceptChanges();
        }

        private void PastroGridaArtRec()
        {
            foreach (DataRow dr in this.dsArtikujt.Tables[0].Rows)
            {
                dr["CHECKED"] = false;
            }

            foreach (DataRow dr in dsRecetat.Tables[0].Rows)
            {
                dr["CHECKED"] = false;
            }

            this.dsArtikujt.Tables[0].AcceptChanges();
            this.dsRecetat.Tables[0].AcceptChanges();
        }

        private int KtheNrFavorite()
        {
            int numri = this.dsFavorite.Tables[0].Rows.Count;
            return numri;
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.MbushFavorite();
            this.PastroZgjedhjen();
        }

        private void PastroZgjedhjen()
        {
            foreach (DataRow dr in this.dsFavorite.Tables[0].Rows)
            {
                dr["CHECKED"] = false;
            }

            this.dsFavorite.Tables[0].AcceptChanges();

            foreach (DataRow dr in this.dsRecetat.Tables[0].Rows)
            {
                dr["CHECKED"] = false;
            }

            this.dsRecetat.Tables[0].AcceptChanges();

            this.gridaRecetat.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.True;
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.paneli.TitleText = s;
        }

        private void frmFavoritet_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            this.dsArtikujt = this.KrijoDataSetArtikujt();
            this.dsRecetat = this.KrijoDataSetRecetat();

            ///this.MbushArtikujt();
            this.MbushRecetat();

            this.dsFavorite = this.KrijoDataSetFavorite();
            this.MbushFavorite();
        }

        

    }
}