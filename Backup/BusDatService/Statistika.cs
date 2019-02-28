using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ResManagerAdmin.BusDatService
{
    public class Statistika
    {
        #region Constructor
        #endregion

        #region Public methods

        public DataSet ShfaqStatistikaPerVitin(int viti)
        {
            DbController db = new DbController();

            DataSet dsViti = new DataSet();
            dsViti.Tables.Add();

            dsViti.Tables[0].Columns.Add("MUAJI", typeof(Int32));
            dsViti.Tables[0].Columns.Add("MUAJISTR", typeof(string));
            dsViti.Tables[0].Columns.Add("XHIRO", typeof(float));
            dsViti.Tables[0].Columns.Add("BLERJE", typeof(float));
            dsViti.Tables[0].Columns.Add("SHPENZIMI_MUJOR", typeof(float));
            dsViti.Tables[0].Columns.Add("SHPENZIMI_DITOR", typeof(float));
            dsViti.Tables[0].Columns.Add("BILANCI", typeof(float));

            

            for (int i = 0; i < 12; i++)
            {
                DataRow drNew = dsViti.Tables[0].NewRow();

                drNew[0] = i + 1;
                drNew[1] = this.KtheMuajiStr(i + 1);
                drNew[2] = 0;
                drNew[3] = 0;
                drNew[4] = 0;
                drNew[5] = 0;

                dsViti.Tables[0].Rows.Add(drNew);
            }

            dsViti.Tables[0].AcceptChanges();

            DataSet dsXhiro = db.Read("ShfaqXhiroPerVitin", viti);

            bool ugjet = false;
            int muaji = 0;
            int muajiXhiro = 0;
            double xhiro = 0;
 
            foreach (DataRow dr in dsViti.Tables[0].Rows)
            {
                ugjet = false;
                muaji = Convert.ToInt32(dr[0]);
                xhiro = 0;

                foreach (DataRow drXhiro in dsXhiro.Tables[0].Rows)
                {
                    muajiXhiro = Convert.ToInt32(drXhiro[0]);

                    if (muaji == muajiXhiro)
                    {
                        xhiro = Convert.ToDouble(drXhiro[1]);
                        
                    }
                }

                dr["XHIRO"] = xhiro;


            }

            dsViti.Tables[0].AcceptChanges();

            DataSet dsBlerjet = db.Read("ShfaqBlerjetPerVitin", viti);

           
            
            int muajiBlerje = 0;
            double blerje = 0;

            foreach (DataRow dr in dsViti.Tables[0].Rows)
            {
                
                muaji = Convert.ToInt32(dr[0]);
                blerje = 0;

                foreach (DataRow drBlerje in dsBlerjet.Tables[0].Rows)
                {
                    muajiBlerje = Convert.ToInt32(drBlerje[0]);

                    if (muaji == muajiBlerje)
                    {
                        blerje = Convert.ToDouble(drBlerje[1]);

                    }
                }

                dr["BLERJE"] = blerje;


            }

            dsViti.Tables[0].AcceptChanges();

            DataSet dsShpenzimiMujor = db.Read("ShfaqShpenzimetMujorePerVitin", viti);



            int muajiShpenzimiMujor = 0;
            double shpenzimiMujor = 0;

            foreach (DataRow dr in dsViti.Tables[0].Rows)
            {

                muaji = Convert.ToInt32(dr[0]);
                shpenzimiMujor = 0;

                foreach (DataRow drShpenzimiMujor in dsShpenzimiMujor.Tables[0].Rows)
                {
                    muajiShpenzimiMujor = Convert.ToInt32(drShpenzimiMujor[0]);

                    if (muaji == muajiShpenzimiMujor)
                    {
                        shpenzimiMujor = Convert.ToDouble(drShpenzimiMujor[1]);

                    }
                }

                dr["SHPENZIMI_MUJOR"] = shpenzimiMujor;


            }

            dsViti.Tables[0].AcceptChanges();


            DataSet dsShpenzimi = db.Read("ShfaqShpenzimetVitin", viti);



            int muajiShpenzimi = 0;
            double shpenzimi = 0;

            foreach (DataRow dr in dsViti.Tables[0].Rows)
            {

                muaji = Convert.ToInt32(dr[0]);
                shpenzimi = 0;

                foreach (DataRow drShpenzimi in dsShpenzimi.Tables[0].Rows)
                {
                    muajiShpenzimi = Convert.ToInt32(drShpenzimi[0]);

                    if (muaji == muajiShpenzimi)
                    {
                        shpenzimi = Convert.ToDouble(drShpenzimi[1]);

                    }
                }

                dr["SHPENZIMI_DITOR"] = shpenzimi;


            }

            dsViti.Tables[0].AcceptChanges();

            foreach (DataRow dr in dsViti.Tables[0].Rows)
            {


                dr["BILANCI"] = Convert.ToDouble(dr[2]) - Convert.ToDouble(dr[3]) - Convert.ToDouble(dr[4]) - Convert.ToDouble(dr[5]);


            }

            dsViti.Tables[0].AcceptChanges();


            return dsViti;
        }

        public DataSet ShfaqBilancinPerPeriudhen(DateTime dateFillimi, DateTime dateMbarimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqniFitiminPerPeriudhen", dateFillimi, dateMbarimi);
            DataSet dsShpenzimeDitore = db.Read("ShfaqShpenzimetDitorePerPeriudhen", dateFillimi, dateMbarimi);

            int vitiFillimi = dateFillimi.Year;
            int muajiFillimi = dateFillimi.Month;
            int vitiMbarimi = dateMbarimi.Year;
            int muajiMbarimi = dateMbarimi.Month;

            DataSet dsShpenzimeMujore = db.Read("ShfaqShpenzimeMujorePerPeriudhen", vitiFillimi, muajiFillimi, vitiMbarimi, muajiMbarimi);

            TimeSpan ts = dateMbarimi.Subtract(dateFillimi);
            int ditet = ts.Days + 1;

            DataSet dsBilanci = new DataSet();
            dsBilanci.Tables.Add();

            dsBilanci.Tables[0].Columns.Add("DATABILANCI", typeof(string));
            dsBilanci.Tables[0].Columns.Add("FITIMI", typeof(float));
            dsBilanci.Tables[0].Columns.Add("SHPENZIMI_DITOR", typeof(float));
            dsBilanci.Tables[0].Columns.Add("SHPENZIMI_MUJOR", typeof(float));
            dsBilanci.Tables[0].Columns.Add("BILANCI", typeof(float));

            dsBilanci.AcceptChanges();
            DateTime dateBilanci;
            string strDateBilanci = "";
            double fitimi = 0;
            double shpenzimiDitor = 0;
            double shpenzimiMujor = 0;
            string strData = "";
            for (int i = 0; i < ditet; i++)
            {
                dateBilanci = dateFillimi.AddDays(i);
                strDateBilanci = dateBilanci.ToString("yyyy.MM.dd");
                fitimi = this.KtheFitimin(ds, strDateBilanci);
                shpenzimiDitor = this.KtheShpenziminDitor(dsShpenzimeDitore, strDateBilanci);
                shpenzimiMujor = this.KtheShpenziminMujor(dsShpenzimeMujore, strDateBilanci);
                strData = dateBilanci.ToString("dd.MM.yyyy");

                DataRow drNew = dsBilanci.Tables[0].NewRow();

                drNew[0] = strData;
                drNew[1] = fitimi;
                drNew[2] = shpenzimiDitor;
                drNew[3] = shpenzimiMujor;
                drNew[4] = fitimi - shpenzimiDitor - shpenzimiMujor;

                dsBilanci.Tables[0].Rows.Add(drNew);
            }





            return dsBilanci;
        }

        public DataSet ShfaqniFitiminPerPeriudhen(DateTime dateFillimi, DateTime dateMbarimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqniFitiminPerPeriudhen", dateFillimi, dateMbarimi);

            TimeSpan ts = dateMbarimi.Subtract(dateFillimi);
            int ditet = ts.Days + 1;

            DataSet dsFitimi = new DataSet();
            dsFitimi.Tables.Add();

            dsFitimi.Tables[0].Columns.Add("DATAFITIMI", typeof(string));
            dsFitimi.Tables[0].Columns.Add("FITIMI", typeof(float));

            dsFitimi.AcceptChanges();
            DateTime dateFitimi;
            string strDateFitimi = "";
            double fitimi = 0;
            string strData = "";
            for (int i = 0; i < ditet; i++)
            {
                dateFitimi = dateFillimi.AddDays(i);
                strDateFitimi = dateFitimi.ToString("yyyy.MM.dd");
                fitimi = this.KtheFitimin(ds, strDateFitimi);
                strData = dateFitimi.ToString("dd.MM.yyyy");

                DataRow drNew = dsFitimi.Tables[0].NewRow();

                drNew[0] = strData;
                drNew[1] = fitimi;

                dsFitimi.Tables[0].Rows.Add(drNew);
            }

            return dsFitimi;
        }

        public DataSet GjendjeArke(DateTime dt)
        {
            DbController db = new DbController();
            DataSet dsArka = db.Read("ShfaqGjendjeArka",dt);
            DataColumn[] v = new DataColumn[1];
            v[0] = dsArka.Tables[0].Columns["ID_FORMAPAGESA"];
            dsArka.Tables[0].PrimaryKey = v;
            //shtohen format e pageses per te cilat nuk jane kryer veprime ne arke
            DataSet dsPagesat = db.Read("ShfaqFormatEPageses");
            foreach(DataRow dr in dsPagesat.Tables[0].Rows)
            {
                int idPagesa = Convert.ToInt32(dr["ID_FORMAPAGESA"]);
                DataRow drSearch = dsArka.Tables[0].Rows.Find(idPagesa);
                if (drSearch == null)
                {
                    DataRow newR = dsArka.Tables[0].NewRow();
                    newR["KOMISIONI"] = dr["KOMISIONI"];
                    newR["ID_FORMAPAGESA"] = dr["ID_FORMAPAGESA"];
                    newR["FORMA_PAGESA"] = dr["FORMA_PAGESA"];
                    newR["VLERA_HEDHUR"] = 0;
                    newR["VLERA_KOMISION"] = 0;
                    dsArka.Tables[0].Rows.Add(newR);
                }
            }
            dsArka.AcceptChanges();
            return dsArka;
        }

        /// <summary>
        /// Kthen nje dataset me shumen e xhiros per secilen date
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DataSet XhirojaPerSecilenDate(string s)
        {
            DbController db = new DbController();
            DataSet dsXhiro = db.Read("XhirojaPerSecilenDate", s);
            return dsXhiro;
        }

        /// <summary>
        /// Kthen nje dataset i cili permban xhiron per diten
        /// te detajuar sipas faturave te bera per ate dite
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DataSet XhirojaPerDatenSipasFaturave(string s)
        {
            DbController db = new DbController();
            DataSet dsXhiro = db.Read("ShfaqXhiroSipasFaturavePerDaten", s);
            return dsXhiro;
        }

        /// <summary>
        /// Shfaq xhiron e realizuar sipas artikujve
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DataSet XhirojaPerArtikullin(string s)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("XhirojaPerSecilenDateSipasArtikujve", s);
            return ds;
        }

        /// <summary>
        /// Shfaq xhiron e realizuar sipas recetave
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DataSet XhirojaPerReceten(string s)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("XhirojaPerSecilenDateSipasRecetave", s);
            return ds;
        }

        public DataSet XhirojaPerSecilenDateSipasRecetave(int idKatReceta, int idReceta, DateTime dateFillimi, DateTime dateMbarimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("XhirojaPerSecilenDateSipasRecetave", idKatReceta, idReceta, dateFillimi, dateMbarimi);
            return ds;
        }

        #endregion

        #region Private methods

        private double KtheFitimin(DataSet ds, string dtFitimi)
        {
            string strData = "";
            double fitimi = 0;

            bool ugjet = false;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                strData = Convert.ToString(dr[0]).Trim();

                if (strData == dtFitimi)
                {
                    ugjet = true;
                    fitimi = Convert.ToDouble(dr[1]);
                    return fitimi;
                }
            }

            return 0;
        }

        private double KtheShpenziminDitor(DataSet ds, string dtFitimi)
        {
            string strData = "";
            double shpenzimi = 0;

            bool ugjet = false;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                strData = Convert.ToString(dr[0]).Trim();

                if (strData == dtFitimi)
                {
                    ugjet = true;
                    shpenzimi = Convert.ToDouble(dr[1]);
                    return shpenzimi;
                }
            }

            return 0;
        }

        private double KtheShpenziminMujor(DataSet ds, string dtFitimi)
        {
            DateTime dateShpenzimi = Convert.ToDateTime(dtFitimi);

            string strData = "";
            double shpenzimi = 0;
            int muaji = dateShpenzimi.Month;
            int viti = dateShpenzimi.Year;

            int nrDitet = this.KtheNrDitetPerMuaj(muaji);
            double totali = 0;
            int m = 0;
            int v = 0;
            bool ugjet = false;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                m = Convert.ToInt32(dr[0]);
                v = Convert.ToInt32(dr[1]);

                if (m == muaji && v == viti)
                {
                    ugjet = true;
                    totali = Convert.ToDouble(dr[2]);
                    /////return shpenzimi/30;
                }
            }

            if (ugjet == true)
            {
                shpenzimi = totali / nrDitet;
            }
            else
            {
                shpenzimi = 0;
            }

            return shpenzimi;
        }

        private int KtheNrDitetPerMuaj(int muaji)
        {
            int nrDitet = 1;

            switch (muaji)
            {
                case 1:
                    nrDitet = 31;
                    break;

                case 2:
                    nrDitet = 28;
                    break;

                case 3:
                    nrDitet = 31;
                    break;

                case 4:
                    nrDitet = 30;
                    break;

                case 5:
                    nrDitet = 31;
                    break;

                case 6:
                    nrDitet = 30;
                    break;

                case 7:
                    nrDitet = 31;
                    break;

                case 8:
                    nrDitet = 31;
                    break;

                case 9:
                    nrDitet = 30;
                    break;

                case 10 :
                    nrDitet = 31;
                    break;

                case 11 :
                    nrDitet = 30;
                    break;

                case 12 :
                    nrDitet = 31;
                    break;

                default :
                    break;

            }

            return nrDitet;

        }

        private string KtheMuajiStr(int muaji)
        {
            string strMuaji = "";

            switch (muaji)
            {
                case 1:
                    strMuaji = "Janar";
                    break;

                case 2:
                    strMuaji = "Shkurt";
                    break;

                case 3:
                    strMuaji = "Mars";
                    break;

                case 4:
                    strMuaji = "Prill";
                    break;

                case 5:
                    strMuaji = "Maj";
                    break;

                case 6:
                    strMuaji = "Qershor";
                    break;

                case 7:
                    strMuaji = "Korrik";
                    break;

                case 8:
                    strMuaji = "Gusht";
                    break;

                case 9 :
                    strMuaji = "Shtator";
                    break;

                case 10:
                    strMuaji = "Tetor";
                    break;

                case 11:
                    strMuaji = "Nentor";
                    break;

                case 12:
                    strMuaji = "Dhjetor";
                    break;

                default :
                    break;

            }

            return strMuaji;
        }

        #endregion
    }   

}
