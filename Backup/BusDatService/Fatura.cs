using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ResManagerAdmin.BusDatService
{
    public class Fatura
    {
        #region Constructor
        #endregion

        #region Public methods
        #region Per konfigurimin e formave te pageses
        /// <summary>
        /// Kthen nje dataset me te gjitha format e pageses
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqFormatEPageses()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqFormatEPageses");
            if (!Convert.IsDBNull(ds))
            {
                ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
                ds.AcceptChanges();
                ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
                ds.AcceptChanges();
            }
            return ds;
        }

        /// <summary>
        /// Ben shtimin e nje forme te re pagese sipas parametrave te marre
        /// </summary>
        /// <param name="formaPagesa"></param>
        /// <param name="komisioni"></param>
        /// <returns></returns>
        public int ShtoFormePagese(string formaPagesa, decimal komisioni)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqFormaPagesePerEmer", formaPagesa);
            int b;
            double komisioniDouble = Convert.ToDouble(komisioni);
            if (ds.Tables[0].Rows.Count == 0)
            {
                b = db.Create("ShtoFormePagese", formaPagesa, komisioniDouble);
            }
            else
            {
                //nqs ekziston nje forme pagese me kete emer atehere 
                //kthejme gabimin me numer 2
                b = 2;
            }
            return b;
        }

        public int ModifikoFormePagese(int idFormaPagesa, string formaPagesa, decimal komisioni)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqFormePagesePerEmerPerjashtoId", idFormaPagesa, formaPagesa);
            int b;
            if (ds.Tables[0].Rows.Count == 0)
            {
                DataSet dsPagesaFatura = db.Read("ShfaqNumrinEFaturavePerSecilenFormePagese");
                DataColumn[] vektorPrimary = new DataColumn[1];
                vektorPrimary[0] = dsPagesaFatura.Tables[0].Columns["ID_FORMAPAGESA"];
                dsPagesaFatura.Tables[0].PrimaryKey = vektorPrimary;
                DataRow drSearch = dsPagesaFatura.Tables[0].Rows.Find(idFormaPagesa);
                if (drSearch == null)
                {
                    b = db.Update("ModifikoFormePagese", idFormaPagesa, formaPagesa, komisioni);
                }
                else
                {
                    //forma e pageses nuk mund te modifikohet sepse
                    //tashme jane kryer pagesa me kete forme
                    b = 3;
                }
            }
            else
            {
                //nqs ekziston nje forme pagese me kete emer atehere 
                //kthejme gabimin me numer 2
                b = 2;
            }
            return b;
        }

        /// <summary>
        /// Fshin te gjitha format e pageses id e te cilave gjenden ne dataset
        /// </summary>
        /// <param name="dsId"></param>
        /// <returns></returns>
        public DataSet FshiFormaPagese(DataSet dsId)
        {
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("FORMA_PAGESA", typeof(String));
            dsError.AcceptChanges();
            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_FORMAPAGESA", typeof(Int32));
            dsToErase.AcceptChanges();
            DbController db = new DbController();
            DataSet dsTavolinatKategori = db.Read("ShfaqNumrinEFaturavePerSecilenFormePagese");
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsTavolinatKategori.Tables[0].Columns["ID_FORMAPAGESA"];
            dsTavolinatKategori.Tables[0].PrimaryKey = vektorPrimary;
            foreach (DataRow dr in dsId.Tables[0].Rows)
            {
                int idKategoria = Convert.ToInt32(dr["ID_FORMAPAGESA"]);
                DataRow drSearch = dsTavolinatKategori.Tables[0].Rows.Find(idKategoria);
                //nqs nuk ka asnje fature me kete forme pagese
                //forma e pageses mund te fshihet
                if (drSearch == null)
                {
                    DataRow r = dsToErase.Tables[0].NewRow();
                    r["ID_FORMAPAGESA"] = dr["ID_FORMAPAGESA"];
                    dsToErase.Tables[0].Rows.Add(r);
                }
                //pnd raportohet se forma e pageses nuk mund te fshihet
                else
                {
                    DataRow r = dsError.Tables[0].NewRow();
                    r["FORMA_PAGESA"] = dr["FORMA_PAGESA"];
                    dsError.Tables[0].Rows.Add(r);
                }
            }
            dsToErase.AcceptChanges();
            dsError.AcceptChanges();
            if (dsToErase.Tables[0].Rows.Count == 0)
            {
                return dsError;
            }
            int b = db.Delete("FshiFormatEPageses", dsToErase);
            //nqs veprimi ne database kryhet ne rregull
            if (b == 0)
                return dsError;
            //pnd kthejme null
            else
                return null;
        }
        #endregion

        #region Manipulimi i fatures

        public DataSet KtheArtikujtPerFature(int idFatura)
        {
            DbController db = new DbController();
            DataSet dsArtikujtSasite = db.Read("KtheArtikujtSasitePerRecetat", idFatura);

            return dsArtikujtSasite;
        }

        public int ModifikoFature(int idFatura, double totali, double skonto, DataSet dsFatura)
        {
            int b = 0;
            DbController db = new DbController();
            DataSet dsFatura1 = db.Read("ShfaqTeDhenaPerFaturen", idFatura);
            string strSql = "";

            strSql = "UPDATE FATURAT SET TOTALI = " + totali + ", SKONTO = " + skonto + " WHERE ID_FATURA = " + idFatura;
            b = db.Update("EkzekutoQuery", strSql);
            if (b > 0)
            {
                return b;
            }

         
            DataSet dsArtikujt = null;   //// this.KrijoDsArtikujt(dsFatura);
            DataSet dsRecetat1 = this.KrijoDsRecetatPerAnullim(dsFatura1);


            
            if (dsRecetat1.Tables[0].Rows.Count > 0)
            {

                DataSet dsArtikujtSasite1 = db.Read("KtheArtikujtSasitePerRecetat", idFatura);
                b = db.Update("ModifikoSasiaPerArtikujtPerAnullim", dsArtikujtSasite1);

                DataSet dsArtikujtKonsumuarPerRecetat1 = db.Read("LexoBlerjeArtikujshPerKonsumPerRecetatPerAnullim", idFatura);
                strSql = this.KtheSlqStringPerKonsumArtikujshPerAnullim(dsArtikujtSasite1, dsArtikujtKonsumuarPerRecetat1);
                b = db.Update("EkzekutoQuery", strSql);


            }

            b = db.Delete("FshiLidhjenFaturaRecetat", idFatura);
            if (b > 0)
            {
                return b;
            }


            DataSet dsRecetat = this.KrijoDsRecetat(dsFatura);
            DataSet dsKosto = null;
            ///string strSql = "";
            double kosto = 0;

            if (dsRecetat.Tables[0].Rows.Count > 0)
            {
                b = db.Create("LidhFaturenMeRecetat", idFatura, dsRecetat);
                DataSet dsArtikujtSasite = db.Read("KtheArtikujtSasitePerRecetat", idFatura);
                b = db.Update("ModifikoSasiaPerArtikujt", dsArtikujtSasite);

                DataSet dsArtikujtKonsumuarPerRecetat = db.Read("LexoBlerjeArtikujshPerKonsumPerRecetat", idFatura);
                strSql = this.KtheSlqStringPerKonsumArtikujsh(dsArtikujtSasite, dsArtikujtKonsumuarPerRecetat);
                b = db.Update("EkzekutoQuery", strSql);

                string[] strRecetat = this.KtheSqlArtikujtKosto(dsArtikujtSasite, dsArtikujtKonsumuarPerRecetat);

                for (int j = 0; j < strRecetat.Length; j++)
                {
                    strSql = strRecetat[j];

                    if (strSql == null)
                    {
                    }
                    else
                    {
                        ///strSql = strArtikujt[j];

                        dsKosto = db.Read("GjejKostoArtikujshPerFature", strSql);

                        if (dsKosto != null && dsKosto.Tables[0].Rows.Count != 0)
                        {
                            kosto = kosto + Convert.ToDouble(dsKosto.Tables[0].Rows[0][1]);
                        }
                    }
                }
            }

            b = db.Update("ModifikoKostoFature", idFatura, kosto);

            return b;

        }

        public int AnulloFaturen(int idFatura)
        {
            int b = 0;
            DbController db = new DbController();
            DataSet dsFatura = db.Read("ShfaqTeDhenaPerFaturen", idFatura);

            b = db.Update("AnulloFaturen", idFatura);
            if (b != 0)
            {
                return b;
            }

            DataSet dsArtikujt = null;   //// this.KrijoDsArtikujt(dsFatura);
            DataSet dsRecetat = this.KrijoDsRecetatPerAnullim(dsFatura);

            
            string strSql = "";
            if (dsRecetat.Tables[0].Rows.Count > 0)
            {
               
                DataSet dsArtikujtSasite = db.Read("KtheArtikujtSasitePerRecetat", idFatura);
                b = db.Update("ModifikoSasiaPerArtikujtPerAnullim", dsArtikujtSasite);

               
               
            }

            return b;
        }

        public DataSet KtheFaturatSipasKerkimit(string strSql)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("KtheFaturatSipasKerkimit", strSql);

            if (ds == null)
            {
                return null;
            }

            DataSet dsFatura = new DataSet();
            dsFatura.Tables.Add();

            dsFatura.Tables[0].Columns.Add("ID_FATURA", typeof(Int32));
            dsFatura.Tables[0].Columns.Add("DATA_ORA", typeof(string));
            dsFatura.Tables[0].Columns.Add("NR_FATURE", typeof(string));
            dsFatura.Tables[0].Columns.Add("TAVOLINA", typeof(string));
            dsFatura.Tables[0].Columns.Add("KAMARIERI", typeof(string));
            dsFatura.Tables[0].Columns.Add("VLERA", typeof(float));
            dsFatura.Tables[0].Columns.Add("SKONTO", typeof(float));
            dsFatura.Tables[0].Columns.Add("TOTALI", typeof(float));
            dsFatura.Tables[0].Columns.Add("FORMA_PAGESA", typeof(string));
            dsFatura.Tables[0].Columns.Add("ANULLUAR", typeof(bool));

            dsFatura.Tables[0].AcceptChanges();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drFatura = dsFatura.Tables[0].NewRow();

                drFatura["ID_FATURA"] = dr["ID_FATURA"];
                drFatura["DATA_ORA"] = Convert.ToDateTime(dr["DATA_ORA"]).ToString("dd.MM.yyyy HH:mm");
                drFatura["NR_FATURE"] = dr["NR_FATURE"];
                drFatura["TAVOLINA"] = dr["TAVOLINA"];
                drFatura["KAMARIERI"] = dr["KAMARIERI"];
                drFatura["VLERA"] = dr["TOTALI"];
                drFatura["SKONTO"] = dr["SKONTO"];
                drFatura["TOTALI"] = Convert.ToDouble(dr["TOTALI"]) - Convert.ToDouble(dr["SKONTO"]);
                drFatura["FORMA_PAGESA"] = dr["FORMA_PAGESA"];
                drFatura["ANULLUAR"] = dr["ANULLUAR"];

                dsFatura.Tables[0].Rows.Add(drFatura);
            }

            dsFatura.Tables[0].AcceptChanges();

            return dsFatura;
        }

        public DataSet ShfaqFaturatPerSot()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqFaturatPerSot");

            if (ds == null)
            {
                return null;
            }

            DataSet dsFatura = new DataSet();
            dsFatura.Tables.Add();

            dsFatura.Tables[0].Columns.Add("ID_FATURA", typeof(Int32));
            dsFatura.Tables[0].Columns.Add("DATA_ORA", typeof(string));
            dsFatura.Tables[0].Columns.Add("NR_FATURE", typeof(string));
            dsFatura.Tables[0].Columns.Add("TAVOLINA", typeof(string));
            dsFatura.Tables[0].Columns.Add("KAMARIERI", typeof(string));
            dsFatura.Tables[0].Columns.Add("VLERA", typeof(float));
            dsFatura.Tables[0].Columns.Add("SKONTO", typeof(float));
            dsFatura.Tables[0].Columns.Add("TOTALI", typeof(float));
            dsFatura.Tables[0].Columns.Add("FORMA_PAGESA", typeof(string));
            dsFatura.Tables[0].Columns.Add("ANULLUAR", typeof(bool));

            dsFatura.Tables[0].AcceptChanges();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drFatura = dsFatura.Tables[0].NewRow();

                drFatura["ID_FATURA"] = dr["ID_FATURA"];
                drFatura["DATA_ORA"] = Convert.ToDateTime(dr["DATA_ORA"]).ToString("dd.MM.yyyy HH:mm");
                drFatura["NR_FATURE"] = dr["NR_FATURE"];
                drFatura["TAVOLINA"] = dr["TAVOLINA"];
                drFatura["KAMARIERI"] = dr["KAMARIERI"];
                drFatura["VLERA"] = dr["TOTALI"];
                drFatura["SKONTO"] = dr["SKONTO"];
                drFatura["TOTALI"] = Convert.ToDouble(dr["TOTALI"]) - Convert.ToDouble(dr["SKONTO"]);
                drFatura["FORMA_PAGESA"] = dr["FORMA_PAGESA"];
                drFatura["ANULLUAR"] = dr["ANULLUAR"];


                dsFatura.Tables[0].Rows.Add(drFatura);
            }

            dsFatura.Tables[0].AcceptChanges();

            return dsFatura;

           
        }

        public DataSet FaturatPerdaten(DateTime dateFatura)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqFaturatPerDatenZgjedhur", dateFatura);

            return ds;
        }

        public DataSet LexoTeDhenaPerTavolinen(int[] idFaturat)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("LexoTeDhenaPerTavolinen", idFaturat);
            

            return ds;
        }

        public DataSet LexoOfertatPerTavolinen(int[] idFaturat)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("LexoOfertatPerTavolinen", idFaturat);

            ////ds.Tables.Add();
            ////ds.Tables[1].Columns.Add("ID_FATURA", typeof(Int32));
            ////ds.Tables[1].Columns.Add("NR_FATURE", typeof(string));
            ////ds.Tables[1].Columns.Add("ID_FATURAOFERTA", typeof(Int32));
            ////ds.Tables[1].Columns.Add("ID_OFERTA", typeof(Int32));
            ////ds.Tables[1].Columns.Add("OFERTA", typeof(string));
            ////ds.Tables[1].Columns.Add("INDEKSI", typeof(Int32));
            ////ds.Tables[1].Columns.Add("ID_RECETA", typeof(Int32));
            ////ds.Tables[1].Columns.Add("SASIA", typeof(Int32));

            ////ds.Tables[1].AcceptChanges();

            ////DataRow drNew = 

            ////DataSet dsRecetat = db.Read("LexoRecetatPerOfertatTavoline", idFaturat);



            return ds;
        }


        public DataSet KtheNrFaturaLast()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("KtheNrFaturaLast");

            return ds;
        }



        public int KrijoFature(int idUser, int idTavolina, int idKlienti, int idFormaPagesa, double totali, double skonto, string nrFatura, DataSet dsFatura, DataSet dsOfertat)
        {
            DbController db = new DbController();
            int nr = dsFatura.Tables[0].Rows.Count;
            int b = 0;
            double kosto = 0;
            DataSet ds = db.Read("KrijoFature", idUser, idTavolina, idKlienti, idFormaPagesa, totali, skonto, nrFatura);

            int idFatura = 0;
            if ((ds == null) || (ds.Tables[0].Rows.Count == 0))
            {
                return 2;
            }
            else
            {
                idFatura = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }

            b = db.Create("KrijoLidhjeTavolineFature", idTavolina, idFatura);

            DataSet dsArtikujt = this.KrijoDsArtikujt(dsFatura);
            DataSet dsRecetat = this.KrijoDsRecetat(dsFatura);
            DataSet dsKosto = null;
            string strSql = "";
            if (dsArtikujt.Tables[0].Rows.Count > 0)
            {
                b = db.Create("LidhFaturenMeArtikujt", idFatura, dsArtikujt);
                b = db.Update("ModifikoSasiaPerArtikujt", dsArtikujt);
                DataSet dsArtikujtKonsumuar = db.Read("LexoBlerjeArtikujshPerKonsum", idFatura);

                strSql = this.KtheSlqStringPerKonsumArtikujsh(dsArtikujt, dsArtikujtKonsumuar);
                b = db.Update("EkzekutoQuery", strSql);

                string[] strArtikujt = this.KtheSqlArtikujtKosto(dsArtikujt, dsArtikujtKonsumuar);

                for (int j = 0; j < strArtikujt.Length; j++)
                {
                    strSql = strArtikujt[j];

                    if (strSql == null)
                    {
                    }
                    else
                    {
                        ///strSql = strArtikujt[j];

                        dsKosto = db.Read("GjejKostoArtikujshPerFature", strSql);

                        if (dsKosto != null && dsKosto.Tables[0].Rows.Count != 0)
                        {
                            kosto = kosto + Convert.ToDouble(dsKosto.Tables[0].Rows[0][1]);
                        }
                    }
                }

                
               
            }

            if (dsRecetat.Tables[0].Rows.Count > 0)
            {
                b = db.Create("LidhFaturenMeRecetat", idFatura, dsRecetat);
                DataSet dsArtikujtSasite = db.Read("KtheArtikujtSasitePerRecetat", idFatura);
                b = db.Update("ModifikoSasiaPerArtikujt", dsArtikujtSasite);

                //DataSet dsArtikujtKonsumuarPerRecetat = db.Read("LexoBlerjeArtikujshPerKonsumPerRecetat", idFatura);
                //strSql = this.KtheSlqStringPerKonsumArtikujsh(dsArtikujtSasite, dsArtikujtKonsumuarPerRecetat);
                //b = db.Update("EkzekutoQuery", strSql);

                //string[] strRecetat = this.KtheSqlArtikujtKosto(dsArtikujtSasite, dsArtikujtKonsumuarPerRecetat);

                //for (int j = 0; j < strRecetat.Length; j++)
                //{
                //    strSql = strRecetat[j];

                //    if (strSql == null)
                //    {
                //    }
                //    else
                //    {
                //        ///strSql = strArtikujt[j];

                //        dsKosto = db.Read("GjejKostoArtikujshPerFature", strSql);

                //        if (dsKosto != null && dsKosto.Tables[0].Rows.Count != 0)
                //        {
                //            kosto = kosto + Convert.ToDouble(dsKosto.Tables[0].Rows[0][1]);
                //        }
                //    }
                //}


                foreach (DataRow drKosto in dsArtikujtSasite.Tables[0].Rows)
                {
                    kosto = kosto + Convert.ToDouble(drKosto["KOSTO"]);
                }
            }

            int idOferta = 0;
            int indeksiOferta = 0;
            int idRecOferta = 0;
            int sasiaOferta = 0;
            decimal cmimi = 0;
            int idFatOferta = 0;
            DataSet dsIdOferta = null;

            if (dsOfertat.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsOfertat.Tables[0].Rows)
                {
                    idOferta = Convert.ToInt32(dr["ID_OFERTA"]);
                    cmimi = Convert.ToDecimal(dr["CMIMI"]);
                    indeksiOferta = Convert.ToInt32(dr["INDEKSI"]);

                    dsIdOferta = db.Read("LidhFatureOferte", idFatura, idOferta, indeksiOferta, cmimi);

                    idFatOferta = Convert.ToInt32(dsIdOferta.Tables[0].Rows[0][0]);

                    foreach (DataRow drOther in dsOfertat.Tables[1].Rows)
                    {
                        if (idOferta == Convert.ToInt32(drOther["ID_OFERTA"]) && indeksiOferta == Convert.ToInt32(drOther["INDEKSI"]))
                        {
                            idRecOferta = Convert.ToInt32(drOther["ID_RECETA"]);
                            sasiaOferta = Convert.ToInt32(drOther["SASIA"]);

                            b = db.Create("LidhFatureOferteRecete", idFatOferta, idRecOferta, sasiaOferta);
                        }
                    }


                }

                DataSet dsArtikujtOfertat = db.Read("KtheArtikujtSasitePerOfertat", idFatura);
                b = db.Update("ModifikoSasiaPerArtikujt", dsArtikujtOfertat);

                DataSet dsArtikujtKonsumuarPerOfertat = db.Read("LexoBlerjeArtikujshPerKonsumPerOfertat", idFatura);
                strSql = this.KtheSlqStringPerKonsumArtikujsh(dsArtikujtOfertat, dsArtikujtKonsumuarPerOfertat);
                b = db.Update("EkzekutoQuery", strSql);

                string[] strOfertat = this.KtheSqlArtikujtKosto(dsArtikujtOfertat, dsArtikujtKonsumuarPerOfertat);

                for (int j = 0; j < strOfertat.Length; j++)
                {
                    strSql = strOfertat[j];

                    if (strSql == null)
                    {
                    }
                    else
                    {
                        ///strSql = strArtikujt[j];

                        dsKosto = db.Read("GjejKostoArtikujshPerFature", strSql);

                        if (dsKosto != null && dsKosto.Tables[0].Rows.Count != 0)
                        {
                            kosto = kosto + Convert.ToDouble(dsKosto.Tables[0].Rows[0][1]);
                        }
                    }
                }
            }

            b = db.Update("ModifikoKostoFature", idFatura, kosto);
            
            return b;

        }

        public DataSet ShfaqTeDhenaPerFaturen(int idFatura)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTeDhenaPerFaturen", idFatura);

            return ds;
        }

        public DataSet PrintoFaturenPC(int idFatura)
        {
            //DataSet dsRecetat = new DataSet();
            //dsRecetat.Tables.Add();

            //dsRecetat.Tables[0].Columns.Add("CELESI", typeof(Int32));
            //dsRecetat.Tables[0].Columns.Add("SASIA", typeof(Int32));

            //dsRecetat.Tables[0].AcceptChanges();

            string strSql = "";
            DataSet dsKosto = null;
            double kosto = 0;
            int b = 0;

            DbController db = new DbController();

            string nrFatura = this.KtheNrFatura();

            b = db.Update("ModifikoNrFatura", idFatura, nrFatura);

            DataSet dsRecetat = db.Read("KtheRecetatPerPrintoPC", idFatura);

            if (dsRecetat.Tables[0].Rows.Count > 0)
            {
               
                DataSet dsArtikujtSasite = db.Read("KtheArtikujtSasitePerRecetat", idFatura);
                b = db.Update("ModifikoSasiaPerArtikujt", dsArtikujtSasite);

                DataSet dsArtikujtKonsumuarPerRecetat = db.Read("LexoBlerjeArtikujshPerKonsumPerRecetat", idFatura);
                strSql = this.KtheSlqStringPerKonsumArtikujsh(dsArtikujtSasite, dsArtikujtKonsumuarPerRecetat);
                b = db.Update("EkzekutoQuery", strSql);

                string[] strRecetat = this.KtheSqlArtikujtKosto(dsArtikujtSasite, dsArtikujtKonsumuarPerRecetat);

                for (int j = 0; j < strRecetat.Length; j++)
                {
                    strSql = strRecetat[j];

                    if (strSql == null)
                    {
                    }
                    else
                    {
                        ///strSql = strArtikujt[j];

                        dsKosto = db.Read("GjejKostoArtikujshPerFature", strSql);

                        if (dsKosto != null && dsKosto.Tables[0].Rows.Count != 0)
                        {
                            kosto = kosto + Convert.ToDouble(dsKosto.Tables[0].Rows[0][1]);
                        }
                    }
                }
            }

            b = db.Update("ModifikoKostoFature", idFatura, kosto);

            DataSet dsTotali = db.Read("ShfaqTeDhenaPerFaturen", idFatura);

            double totaliPc = 0;

            foreach(DataRow dr in dsTotali.Tables[0].Rows)
            {
                totaliPc = totaliPc + Convert.ToDouble(dr["TOTALI"]);

            }

            b = db.Update("ModifikoTotaliFature", idFatura, totaliPc);


            DataSet dsFaturaPc = db.Read("KtheTeDhenaPerFaturenPc", idFatura);

            dsTotali.Tables.Add();

            dsTotali.Tables[1].Columns.Add("DATA_ORA", typeof(DateTime));
            dsTotali.Tables[1].Columns.Add("TAVOLINA", typeof(string));
            dsTotali.Tables[1].Columns.Add("KAMARIERI", typeof(string));
            dsTotali.Tables[1].Columns.Add("TOTALI", typeof(float));
            dsTotali.Tables[1].Columns.Add("SKONTO", typeof(float));
            dsTotali.Tables[1].Columns.Add("NR_FATURE", typeof(string));
            

            dsTotali.Tables[1].AcceptChanges();

            DataRow drFat = dsTotali.Tables[1].NewRow();

            drFat["DATA_ORA"] = dsFaturaPc.Tables[0].Rows[0]["DATA_ORA"];
            drFat["TAVOLINA"] = dsFaturaPc.Tables[0].Rows[0]["TAVOLINA"];
            drFat["KAMARIERI"] = dsFaturaPc.Tables[0].Rows[0]["KAMARIERI"];
            drFat["TOTALI"] = dsFaturaPc.Tables[0].Rows[0]["TOTALI"];
            drFat["SKONTO"] = dsFaturaPc.Tables[0].Rows[0]["SKONTO"];
            drFat["NR_FATURE"] = dsFaturaPc.Tables[0].Rows[0]["NR_FATURE"];

            dsTotali.Tables[1].Rows.Add(drFat);

            return dsTotali;

        }


      
        #endregion
        #endregion

        #region Private methods

        private string[] KtheSqlArtikujtKosto(DataSet dsArtikujt, DataSet dsArtikujtKonsumuar)
        {
            int nr1 = dsArtikujt.Tables[0].Rows.Count;
            string[] strSql = new string[20];

            int idArtikulli = 0;
            int celesi = 0;
            double sasia;
            double blerje = 0;
            double konsumi = 0;
            double diferenca = 0;
            bool mbyll = false;
            int numri = dsArtikujtKonsumuar.Tables[0].Rows.Count;
            int i = 0;
            int idBlerja = 0;
            int k = 0;
            string strSasia = "";

            foreach (DataRow dr in dsArtikujt.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);
                sasia = Convert.ToDouble(dr[1]);
                i = 0;
                mbyll = false;

                while (mbyll == false && i < numri)
                {
                    DataRow drNew = dsArtikujtKonsumuar.Tables[0].Rows[i];
                    celesi = Convert.ToInt32(drNew["ID_ARTIKULLI"]);

                    if (idArtikulli == celesi)
                    {
                        idBlerja = Convert.ToInt32(drNew["ID_BLERJEARTIKUJ"]);
                        blerje = Convert.ToDouble(drNew["SASIA"]);
                        konsumi = Convert.ToDouble(drNew["KONSUMUAR"]);

                        diferenca = blerje - konsumi;

                        if (sasia < diferenca)
                        {
                            strSasia = this.FormatoNumrinDecimal(sasia);

                            strSql[k] = "SELECT ID_ARTIKULLI, (CMIMI * " + strSasia + ") AS KOSTO FROM BLERJET_ARTIKUJT WHERE ID_BLERJEARTIKUJ = " + idBlerja + " ";

                            mbyll = true;
                        }
                        else
                        {
                            strSasia = this.FormatoNumrinDecimal(diferenca);
                            strSql[k] = "SELECT ID_ARTIKULLI, (CMIMI * " + strSasia + ") AS KOSTO FROM BLERJET_ARTIKUJT WHERE ID_BLERJEARTIKUJ = " + idBlerja + " ";

                            sasia = sasia - diferenca;
                        }

                        k = k + 1;
                    }

                    i = i + 1;

                }
            }

            return strSql;

        }

        private string KtheSlqStringPerKonsumArtikujsh(DataSet dsArtikujt, DataSet dsArtikujtKonsumuar)
        {
            int nr1 = dsArtikujt.Tables[0].Rows.Count;
            string strSql = "";

            int idArtikulli = 0;
            int celesi = 0;
            double sasia;
            double blerje = 0;
            double konsumi = 0;
            double diferenca = 0;
            bool mbyll = false;
            int  numri = dsArtikujtKonsumuar.Tables[0].Rows.Count;
            int  i = 0;
            int idBlerja = 0;

            string strSasia = "";

            foreach (DataRow dr in dsArtikujt.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);
                sasia = Convert.ToDouble(dr[1]);
                i = 0;
                mbyll = false;

                while (mbyll == false && i < numri)
                {
                    DataRow drNew = dsArtikujtKonsumuar.Tables[0].Rows[i];
                    celesi = Convert.ToInt32(drNew["ID_ARTIKULLI"]);

                    if (idArtikulli == celesi)
                    {
                        idBlerja = Convert.ToInt32(drNew["ID_BLERJEARTIKUJ"]);
                        blerje = Convert.ToDouble(drNew["SASIA"]);
                        konsumi = Convert.ToDouble(drNew["KONSUMUAR"]);

                        diferenca = blerje - konsumi;

                        if (sasia < diferenca)
                        {
                            strSasia = this.FormatoNumrinDecimal(sasia);

                            strSql += Environment.NewLine + "UPDATE BLERJET_ARTIKUJT SET KONSUMUAR = KONSUMUAR + " + strSasia + " WHERE ID_BLERJEARTIKUJ = " + idBlerja + " ";

                            mbyll = true;
                        }
                        else
                        {
                            strSasia = this.FormatoNumrinDecimal(diferenca);
                            strSql += Environment.NewLine + "UPDATE BLERJET_ARTIKUJT SET KONSUMUAR = KONSUMUAR + " + strSasia + " WHERE ID_BLERJEARTIKUJ = " + idBlerja + " ";

                            sasia = sasia - diferenca;
                        }
                    }

                    i = i + 1;

                }
            }

            return strSql;
        }


        private DataSet KrijoDsSasiaArtikujt(DataSet ds)
        {
            DataSet dsArtikujt = new DataSet();
            dsArtikujt.Tables.Add();

            dsArtikujt.Tables[0].Columns.Add("CELESI", typeof(Int32));
            dsArtikujt.Tables[0].Columns.Add("SASIA", typeof(Int32));

            dsArtikujt.Tables[0].AcceptChanges();

            



            return dsArtikujt;

        }

        private DataSet KrijoDsArtikujt(DataSet ds)
        {
            DataSet dsArtikujt = new DataSet();
            dsArtikujt.Tables.Add();

            dsArtikujt.Tables[0].Columns.Add("CELESI", typeof(Int32));
            dsArtikujt.Tables[0].Columns.Add("SASIA", typeof(Int32));

            dsArtikujt.Tables[0].AcceptChanges();

            int celesi = 0;
            string lloji = "";
            int sasia = 0;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lloji = Convert.ToString(dr["LLOJI"]);

                if (lloji == "A")
                {
                    celesi = Convert.ToInt32(dr["CELESI"]);
                    sasia = Convert.ToInt32(dr["SASIA"]);

                    DataRow drNew = dsArtikujt.Tables[0].NewRow();

                    drNew["SASIA"] = sasia;
                    drNew["CELESI"] = celesi;

                    dsArtikujt.Tables[0].Rows.Add(drNew);

                }
            }

            dsArtikujt.Tables[0].AcceptChanges();

            return dsArtikujt;
        }

        private DataSet KrijoDsRecetatPerAnullim(DataSet ds)
        {
            DataSet dsRecetat = new DataSet();
            dsRecetat.Tables.Add();

            dsRecetat.Tables[0].Columns.Add("CELESI", typeof(Int32));
            dsRecetat.Tables[0].Columns.Add("SASIA", typeof(Int32));

            dsRecetat.Tables[0].AcceptChanges();

            int celesi = 0;
            string lloji = "";
            int sasia = 0;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
               
                    celesi = Convert.ToInt32(dr["ID_RECETA"]);
                    sasia = Convert.ToInt32(dr["SASIA"]);

                    DataRow drNew = dsRecetat.Tables[0].NewRow();

                    drNew["SASIA"] = sasia;
                    drNew["CELESI"] = celesi;

                    dsRecetat.Tables[0].Rows.Add(drNew);

                
            }

            dsRecetat.Tables[0].AcceptChanges();


            return dsRecetat;
        }

        private string FormatoNumrinDecimal(double nr)
        {
            bool gjendet = false;
            string numri = Convert.ToString(nr);
            int i = 0;
            int gj = numri.Length;
            int j = 0;
            string el = "";
            string str1 = "";
            string str2 = "";

            while (gjendet == false && i < gj)
            {
                el = numri.Substring(i, 1);

                if (el == "." || el == ",")
                {
                    j = gj - i - 1;
                    str1 = numri.Substring(0, i);
                    str2 = numri.Substring(i + 1, j);

                    gjendet = true;
                }

                i = i + 1;
            }

            string kthe = "";

            if (str2 == "")
            {
                kthe = numri;
            }
            else
            {
                kthe = str1 + "." + str2;
            }

            return kthe;
        }

        private string KtheSlqStringPerKonsumArtikujshPerAnullim(DataSet dsArtikujt, DataSet dsArtikujtKonsumuar)
        {
            int nr1 = dsArtikujt.Tables[0].Rows.Count;
            string strSql = "";

            int idArtikulli = 0;
            int celesi = 0;
            double sasia;
            double blerje = 0;
            double konsumi = 0;
            double diferenca = 0;
            bool mbyll = false;
            int numri = dsArtikujtKonsumuar.Tables[0].Rows.Count;
            int i = 0;
            int idBlerja = 0;

            string strSasia = "";

            foreach (DataRow dr in dsArtikujt.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);
                sasia = Convert.ToDouble(dr[1]);
                i = 0;
                mbyll = false;

                while (mbyll == false && i < numri)
                {
                    DataRow drNew = dsArtikujtKonsumuar.Tables[0].Rows[i];
                    celesi = Convert.ToInt32(drNew["ID_ARTIKULLI"]);

                    if (idArtikulli == celesi)
                    {
                        idBlerja = Convert.ToInt32(drNew["ID_BLERJEARTIKUJ"]);
                        blerje = Convert.ToDouble(drNew["SASIA"]);
                        konsumi = Convert.ToDouble(drNew["KONSUMUAR"]);

                        ///diferenca = blerje - konsumi;

                        if (sasia < konsumi)
                        {
                            strSasia = this.FormatoNumrinDecimal(sasia);

                            strSql += Environment.NewLine + "UPDATE BLERJET_ARTIKUJT SET KONSUMUAR = KONSUMUAR - " + strSasia + " WHERE ID_BLERJEARTIKUJ = " + idBlerja + " ";

                            mbyll = true;
                        }
                        else
                        {
                            strSasia = this.FormatoNumrinDecimal(diferenca);
                            strSql += Environment.NewLine + "UPDATE BLERJET_ARTIKUJT SET KONSUMUAR = 0 WHERE ID_BLERJEARTIKUJ = " + idBlerja + " ";

                            sasia = sasia - konsumi;
                        }
                    }

                    i = i + 1;

                }
            }

            return strSql;
        }

        private DataSet KrijoDsRecetat(DataSet ds)
        {
            DataSet dsRecetat = new DataSet();
            dsRecetat.Tables.Add();

            dsRecetat.Tables[0].Columns.Add("CELESI", typeof(Int32));
            dsRecetat.Tables[0].Columns.Add("SASIA", typeof(Int32));
            dsRecetat.Tables[0].Columns.Add("CMIMI", typeof(decimal));

            dsRecetat.Tables[0].AcceptChanges();

            int celesi = 0;
            string lloji = "";
            int sasia = 0;
            decimal cmimi = 0;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                celesi = Convert.ToInt32(dr["CELESI"]);
                sasia = Convert.ToInt32(dr["SASIA"]);
                cmimi = Convert.ToDecimal(dr["CMIMI"]);

                DataRow drNew = dsRecetat.Tables[0].NewRow();

                drNew["SASIA"] = sasia;
                drNew["CELESI"] = celesi;
                drNew["CMIMI"] = cmimi;

                dsRecetat.Tables[0].Rows.Add(drNew);


            }

            dsRecetat.Tables[0].AcceptChanges();


            return dsRecetat;
        }

       

        private string KtheNrFatura()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("KtheNrFaturaLast");

            int numri = 0;
            if (ds.Tables[0].Rows.Count != 0)
            {
                numri = Convert.ToInt32(ds.Tables[0].Rows[0][1]);
            }
            numri = numri + 1;

            string strFatura = Convert.ToString(numri);

            return strFatura;
        }



        #endregion
    }
}
