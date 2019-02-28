using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ResManagerAdmin.BusDatService
{
    public class Blerje
    {
        #region Constructor
        #endregion

        #region Public methods

        /// <summary>
        /// Shton nje blerje te re me te dhena si ne dsBlerja.Tables[0]
        /// dhe me artikuj si ne dsBlerja.Tables[1]
        /// </summary>
        /// <param name="dsBlerja"></param>
        /// <returns></returns>
        public int ShtoBlerje(DataSet dsBlerja)
        {
            DbController db = new DbController();
            int idFurnitori = Convert.ToInt32(dsBlerja.Tables[0].Rows[0]["ID_FURNITORI"]);
            DateTime data = Convert.ToDateTime(dsBlerja.Tables[0].Rows[0]["DATA_BLERJE"]);
            string nrFature = dsBlerja.Tables[0].Rows[0]["NR_FATURE"].ToString();
            if (nrFature == "")
            {
                nrFature = this.KtheNrFaturaDefault();
            }

            DataSet dsVerifiko = db.Read("KontrolloBlerjeSipasFurnitoritDheFatures", idFurnitori, nrFature);
            if (dsVerifiko.Tables[0].Rows.Count != 0)
                return 2;

            DataSet ds = db.Create("ShtoBlerje", idFurnitori, nrFature, data);

            int idBlerja = 0;
            int b = 0;

            if (!Convert.IsDBNull(ds))
            {
                idBlerja = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                b = db.Create("ShtoArtikujNeBlerje", idBlerja, dsBlerja);
                
            }
            else
            {
                return 1;
            }

            return b;





        }

        /// <summary>
        /// Shfaq te gjitha blerjet dhe artikujt perberes ne varesi te kushtit qe merr si parameter
        /// </summary>
        /// <param name="kushti"></param>
        /// <returns></returns>
        public DataSet ShfaqBlerjet(string kushti)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqBlerjet", kushti );
            ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
            ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
            ds.Tables[0].Columns.Add("ID_ARTIKULLIFILLESTAR", typeof(Int32));
            ds.Tables[0].Columns.Add("SASIA_KUSHT_OFERTA", typeof(Decimal));
            ds.Tables[0].Columns.Add("SQARIM_OFERTA", typeof(String));
            ds.Tables[0].Columns.Add("LLOJI", typeof(String));
            ds.Tables[0].Columns.Add("NJESIA_FILLESTAR", typeof(String));
            ds.Tables[0].Columns.Add("ARTIKULLI_FILLESTAR", typeof(String));
            DataColumn[] Primary = new DataColumn[1];
            Primary[0] = ds.Tables[1].Columns["ID_BLERJEARTIKUJ"];
            ds.Tables[1].PrimaryKey = Primary;
            ds.AcceptChanges();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //nqs cmimi eshte 0 atehere artikulli eshte oferte
                if (Convert.ToDouble(dr["CMIMI"]) == 0)
                {
                    dr["LLOJI"] = "Ofertë";
                    int idBlerjeArtikuj = Convert.ToInt32(dr["ID_BLERJEARTIKUJ"]);
                    DataRow drSearch = ds.Tables[1].Rows.Find(idBlerjeArtikuj);
                    if (drSearch != null)
                    {
                        int idArtikulliFillestar = Convert.ToInt32(drSearch["ID_ARTIKULLIFILLESTAR"]);
                        dr["ID_ARTIKULLIFILLESTAR"] = idArtikulliFillestar;
                        string artikulliFillestar = drSearch["ARTIKULLI_FILLESTAR"].ToString();
                        dr["ARTIKULLI_FILLESTAR"] = artikulliFillestar;
                        string njesiaFillestar = drSearch["NJESIA"].ToString();
                        dr["NJESIA_FILLESTAR"] = njesiaFillestar;
                        dr["SASIA_KUSHT_OFERTA"] = Convert.ToInt32(drSearch["SASIA_KUSHT_OFERTA"]);
                        double sasiaKusht = Convert.ToDouble(drSearch["SASIA_KUSHT_OFERTA"]);
                        double sasiaTotale = Convert.ToDouble(dr["SASIA"]);
                        double sasiaArtikuj = 0;
                        bool ugjet = false;
                        int idBlerja = Convert.ToInt32(dr["ID_BLERJA"]);
                        foreach (DataRow r in ds.Tables[0].Rows)
                        {
                            if (idBlerja == Convert.ToInt32(r["ID_BLERJA"]))
                            {
                                ugjet = true;
                                if (idArtikulliFillestar == Convert.ToInt32(r["ID_ARTIKULLI"]) && Convert.ToDouble(r["CMIMI"]) != 0)
                                    sasiaArtikuj += Convert.ToDouble(r["SASIA"]);
                            }
                            else if (ugjet)
                                break;
                        }
                        double sasiaOfruar = sasiaTotale / (Math.Floor(sasiaArtikuj / sasiaKusht));
                        string koment = "Për " + sasiaKusht + " " + njesiaFillestar + " " + artikulliFillestar + 
                            " ofrohen " + sasiaOfruar + " " + dr["NJESIA"].ToString() + " " + dr["EMRI"].ToString();
                        dr["SQARIM_OFERTA"] = koment;

                    }
                }
                else
                {
                    dr["LLOJI"] = "Artikull";
                }
            }
            ds.AcceptChanges();
            return ds;
        }

        /// <summary>
        /// Modifikon blerje me id sa IdBlerja sipas vlerave ne DataSet
        /// </summary>
        /// <param name="idBlerja"></param>
        /// <param name="dsBlerja"></param>
        /// <returns></returns>
        public DataSet ModifikoBlerje(int idBlerja, DataSet dsBlerja)
        {
            DbController db = new DbController();
            int idFurnitori = Convert.ToInt32(dsBlerja.Tables[0].Rows[0]["ID_FURNITORI"]);
            DateTime data = Convert.ToDateTime(dsBlerja.Tables[0].Rows[0]["DATA_BLERJE"]);
            string nrFature = dsBlerja.Tables[0].Rows[0]["NR_FATURE"].ToString();
            //duhen bere kontrolle paraprake
            DataSet dsSasiteBlerje = db.Read("SasitePerkateseTeArtikujvePerBlerjen", idBlerja);
            DataSet dsSasite = db.Read("NumriTotalArtikujtNeBlerje", idBlerja);
            int i = 0;
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            dsError.Tables[0].Columns.Add("EMRI", typeof(String));
            dsError.AcceptChanges();
            //blerja nuk mund te modifikohet nqs per ndonje nga artikujt 
            //numri total i mbetur pas modifikimit rezulton negativ
            foreach (DataRow dr in dsSasite.Tables[0].Rows)
            {
                double sasiaBlerje = Convert.ToDouble(dsSasiteBlerje.Tables[0].Rows[i]["SASIA"]);
                int idArtikulli = Convert.ToInt32(dr["ID_ARTIKULLI"]);
                double sasiaRe = ArtikulliIHequrNgaBlerja(dsBlerja, idArtikulli);
                double sasiaMbetur = Convert.ToDouble(Convert.ToDouble(dr["NUMRI_TOTAL"])) - sasiaBlerje + sasiaRe; 
                if (sasiaMbetur < 0)
                {
                    DataRow newR = dsError.Tables[0].NewRow();
                    newR["ID_ARTIKULLI"] = Convert.ToInt32(dr["ID_ARTIKULLI"]);
                    newR["EMRI"] = dr["EMRI"].ToString();
                    dsError.Tables[0].Rows.Add(newR);
                }
                i++;
            }
            dsError.AcceptChanges();
            if (dsError.Tables[0].Rows.Count > 0)
                return dsError;
            int b = db.Update("ModifikoSasiteArtikujt", dsSasiteBlerje);
            if (b == 0)
                b = db.Update("ModifikoBlerje", idBlerja, idFurnitori,nrFature, data);
            if (b == 0)
            {
                b = db.Create("ShtoArtikujNeBlerje", idBlerja, dsBlerja);
                return null;
            }
            else
                return new DataSet();
        }

        /// <summary>
        /// Fshin blerjet me id ne DataSet duke mos lejuar qe
        /// numri total i artikujve te mbetet negativ
        /// </summary>
        /// <param name="dsId"></param>
        /// <returns></returns>
        public DataSet FshiBlerjet(DataSet dsId)
        {
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("FURNITORI", typeof(String));
            dsError.Tables[0].Columns.Add("DATA_BLERJE_STR", typeof(String));
            dsError.Tables[0].Columns.Add("NR_FATURE", typeof(String));
            dsError.AcceptChanges();

            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_BLERJA", typeof(Int32));
            dsToErase.AcceptChanges();

            DbController db = new DbController();
            //dsSasiteBlerje do te mbaje sasite e blera per cdo artikull per cdo blerje
            //secila prej blerjeve te zgjedhura do te kete nje datatable ne dataset
            DataSet dsSasiteBlerje = db.Read("SasitePerkateseTeArtikujvePerBlerjen", dsId);
            foreach (DataTable dt in dsSasiteBlerje.Tables)
            {
                DataColumn[] celes = new DataColumn[1];
                celes[0] = dt.Columns["ID_ARTIKULLI"];
                dt.PrimaryKey = celes;
            }
            //dsSasite do te mbaje numrin total te artikujve per cdo artikull te cdo blerjeje
            //secila prej blerjeve te zgjedhura do te kete nje datatable ne dataset
            DataSet dsSasite = db.Read("NumriTotalArtikujtNeBlerje", dsId);
            foreach(DataTable dt in dsSasite.Tables)
            {
                DataColumn[] celes = new DataColumn[1];
                celes[0] = dt.Columns["ID_ARTIKULLI"];
                dt.PrimaryKey = celes;
            }
            //dsSasiteFshirje do te mbaje sasite e blera per cdo artikull per cdo blerje qe 
            //mund te fshihet, secila prej blerjeve do te kete nje datatable
            DataSet dsSasiteFshirje = new DataSet();
            int i = 0;

            foreach (DataRow dr in dsId.Tables[0].Rows)
            {
                int idBlerja = Convert.ToInt32(dr["ID_BLERJA"]);
                int j = 0;
                bool MundTeFshihet = true;
                foreach (DataRow r in dsSasite.Tables[i].Rows)
                {
                    double sasiaBlerje = Convert.ToDouble(dsSasiteBlerje.Tables[i].Rows[j]["SASIA"]);
                    int idArtikulli = Convert.ToInt32(r["ID_ARTIKULLI"]);
                    double sasiaMbetur = Convert.ToDouble(Convert.ToDouble(r["NUMRI_TOTAL"])) - sasiaBlerje;
                    if (sasiaMbetur < 0)
                    {
                        //ne momentin e pare qe gjejme nje artikull ne blerje
                        //numri total i te cilit mbetet negativ pas fshirjes se blerjes
                        //e nderpresim kerkimin ne blerje dhe e deklarojme kete blerje si te paeleminueshme
                        DataRow newR = dsError.Tables[0].NewRow();
                        newR["FURNITORI"] = dr["FURNITORI"].ToString();
                        newR["DATA_BLERJE_STR"] = dr["DATA_BLERJE_STR"].ToString();
                        newR["NR_FATURE"] = dr["NR_FATURE"].ToString();
                        dsError.Tables[0].Rows.Add(newR);
                        MundTeFshihet = false;
                        break;
                    }
                    j++;
                }
                if (MundTeFshihet)
                {
                    //nqs blerja mund te fshihet atehere duhet te modifikojme vlerat
                    //e numrit total te artikujve ne te gjitha tabelat pasardhese
                    for (int k = i + 1; k < dsSasite.Tables.Count; k++)
                    {
                        int l = 0;
                        foreach (DataRow r in dsSasite.Tables[i].Rows)
                        {
                            int idArtikulli = Convert.ToInt32(r["ID_ARTIKULLI"]);
                            double sasiaBlerje = Convert.ToDouble(dsSasiteBlerje.Tables[i].Rows[l]["SASIA"]);
                            DataRow drSearch = dsSasite.Tables[k].Rows.Find(idArtikulli);
                            if (drSearch != null)
                            {
                                drSearch["NUMRI_TOTAL"] = Convert.ToDouble(drSearch["NUMRI_TOTAL"]) - sasiaBlerje;
                            }
                            l++;
                        }
                    }
                    //shtojme rreshtin ne dataset
                    DataRow newR = dsToErase.Tables[0].NewRow();
                    newR["ID_BLERJA"] = Convert.ToInt32(dr["ID_BLERJA"]);
                    dsToErase.Tables[0].Rows.Add(newR);
                    //shtojme datatable perkates ne dsSasiteFshirje
                    DataTable newTable = dsSasiteBlerje.Tables[i].Copy();
                    dsSasiteFshirje.Tables.Add(newTable);
                }
                i++;
            }
            dsToErase.AcceptChanges();
            dsError.AcceptChanges();
            dsSasiteFshirje.AcceptChanges();
            if (dsToErase.Tables[0].Rows.Count == 0)
            {
                return dsError;
            }
            int b = db.Delete("FshiBlerjet", dsToErase, dsSasiteFshirje);
            //nqs veprimi ne database kryhet ne rregull
            if (b == 0)
                return dsError;
            //pnd kthejme null
            else
                return null;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Kontrollon nqs nje artikull i caktuar eshte ende ne blerje apo jo
        /// dhe nqs po kthen sasine e re te artikujve ne blerje
        /// </summary>
        /// <param name="dsBlerja"></param>
        /// <param name="idArtikulli"></param>
        /// <returns></returns>
        private double ArtikulliIHequrNgaBlerja(DataSet dsBlerja, int idArtikulli)
        {
            double sasiaRe = 0;
            foreach (DataRow dr in dsBlerja.Tables[1].Rows)
            {
                if (idArtikulli == Convert.ToInt32(dr["ID_ARTIKULLI"]))
                {
                    sasiaRe += Convert.ToDouble(dr["SASIA"]);
                }
            }
            return sasiaRe;
        }

        private string KtheNrFaturaDefault()
        {
            string dataTani = System.DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss");

            string dita = dataTani.Substring(0, 2);
            string muaji = dataTani.Substring(3, 2);
            string viti = dataTani.Substring(6, 4);

            string ora = dataTani.Substring(11, 2);
            string minutat = dataTani.Substring(14, 2);
            string sekondat = dataTani.Substring(17, 2);

            string nrFature = viti + muaji + dita + ora + minutat + sekondat;

            return nrFature;
        }

        #endregion
    }
}
