using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using ResManager;

namespace ResManager.Forms
{
    public partial class frmFavorites : Form
    {
        public frmFavorites()
        {
            InitializeComponent();
        }

        private DataSet dsFavorite = null;
        private DataSet dsArtikujt = null;
        private DataSet dsRecetat = null;
        private int nrFavorite = 10;
      
        #region Load

        private void frmFavorites_Load(object sender, EventArgs e)
        {
            this.dsArtikujt = this.KrijoDataSetArtikujt();
            this.dsRecetat = this.KrijoDataSetRecetat();

            ///this.MbushArtikujt();
            this.MbushRecetat();

            this.dsFavorite = this.KrijoDataSetFavorite();
            this.MbushFavorite();
            this.gridaFavorite.DataSource = this.dsFavorite.Tables[0];

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
            DataSet ds = data.KerkesaRead("ShfaqRecetatSipasKategorive");

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

        #endregion

        private void btnPara_Click(object sender, EventArgs e)
        {
            if (this.tabArtikujt.SelectedIndex == 0)
            {
                ////this.KaloArtikujt();

                this.KaloRecetat();

            }
            else
            {
                
            }

           // this.PastroGridaArtRec();
            
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

        private void KaloArtikujt()
        {
            //int numri = this.KtheNrFavorite();

            //for (int i = 0; i < this.gridaArtikujt.RowCount; i++)
            //{
            //    if (this.gridaArtikujt.GetRow(i).Cells[0].Text != "" )
            //    {
            //        if (numri >= this.nrFavorite)
            //        {
            //            this.dsFavorite.Tables[0].AcceptChanges();
            //            return;
            //        }
            //        if (this.gridaArtikujt.GetRow(i).Cells["CHECKED"].Text == "True")
            //        {
            //            object[] cKerko = new object[2];
            //            cKerko[0] = Convert.ToInt32(this.gridaArtikujt.GetRow(i).Cells["ID_ARTIKULLI"].Text);
            //            cKerko[1] = "A";
            //            DataRow drKerko = this.dsFavorite.Tables[0].Rows.Find(cKerko);
            //            if (drKerko == null)
            //            {
            //                DataRow dr = this.dsFavorite.Tables[0].NewRow();
            //                dr["ID_FAVORITE"] = Convert.ToInt32(this.gridaArtikujt.GetRow(i).Cells["ID_ARTIKULLI"].Text);
            //                dr["EMRI"] = Convert.ToString(this.gridaArtikujt.GetRow(i).Cells["EMRI"].Text);
            //                dr["LLOJI"] = "A";
            //                dr["PRIORITETI"] = numri + 1;
            //                dr["CHECKED"] = false;

            //                this.dsFavorite.Tables[0].Rows.Add(dr);

            //                numri = numri + 1;
            //            }
                        
            //        }

            //    }
            //}

            //this.dsFavorite.Tables[0].AcceptChanges();
        }

        private int KtheNrFavorite()
        {
            int numri = this.dsFavorite.Tables[0].Rows.Count;
            return numri;
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

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            InputController data = new InputController();
            int b = data.KerkesaUpdate("HidhFavorite", this.dsFavorite);
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            //int celesi = 0;
            //int idFavorite = 0;
            //int rreshtat = this.gridaFavorite.RowCount;
            //for (int i = 0; i < rreshtat; i++)
            //{
            //    if (this.gridaFavorite.GetRow(i).Cells["CHECKED"].Text == "True")
            //        {
            //            celesi = Convert.ToInt32(this.gridaFavorite.GetRow(i).Cells["ID_FAVORITE"].Text);

            //            int numri = this.dsFavorite.Tables[0].Rows.Count;

            //            for (int j = 0; j < numri; j++ )
            //            {
            //                DataRow dr = this.dsFavorite.Tables[0].Rows[j];
            //                idFavorite = Convert.ToInt32(dr["ID_FAVORITE"]);

            //                if (celesi == idFavorite)
            //                {
            //                    this.dsFavorite.Tables[0].Rows.Remove(dr);
            //                    numri = numri - 1;
            //                    rreshtat = rreshtat - 1;
            //                }
            //            }

                        

            //        }

                
            //}

            this.HiqTeZgjedhura(this.dsFavorite);


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
        }

    }
}