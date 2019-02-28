using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ResManagerAdmin.BusDatService
{
    public class Tavolina
    {
        #region Constructor
        #endregion

        #region Public methods

        #region Per konfigurimin e kategorive

        /// <summary>
        /// Sherben per te shfaqur te gjitha kategorite e tavolinave qe jane regjistruar
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet ShfaqKategorite()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteETavolinave");
            ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                dr["CHECKED"] = false;
            }
            ds.AcceptChanges();
            return ds;
        }

        /// <summary>
        /// Sherben per te shtuar nje kategori te re tavoline
        /// Nuk mund te shtohen dy kategori me te njejtin emer
        /// </summary>
        /// <param name="emri"></param>
        /// <returns>int</returns>
        public int ShtoKategoriTavoline(string emri)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriTavolinePerEmer", emri);
            int b;
            if (ds.Tables[0].Rows.Count == 0)
            {
                b = db.Create("ShtoKategoriTavolinash", emri);
            }
            else
            {
                //nqs ekziston nje kategori tavoline me kete emer atehere 
                //kthejme gabimin me numer 2
                b = 2;
            }
            return b;
        }

        /// <summary>
        /// Sherben per te modifikuar nje kategori tavoline ne baze id.
        /// Modifikimi nuk behet nqs ekziston nje kategori me kete emer
        /// </summary>
        /// <param name="idKategoria"></param>
        /// <param name="emri"></param>
        /// <returns>int</returns>
        public int ModifikoKategoriTavoline(int idKategoria, string emri)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriTavolinePerEmerPerjashtoId", idKategoria, emri);
            int b;
            if (ds.Tables[0].Rows.Count == 0)
            {

                b = db.Update("ModifikoKategoriTavoline", idKategoria, emri);
            }
            else
            {
                //nqs ekziston nje kategori tavoline me kete emer atehere 
                //kthejme gabimin me numer 2
                b = 2;
            }
            return b;
        }

        /// <summary>
        /// Fshin te gjitha ato kategori te tavolinave qe nuk kane 
        /// tavolina te regjistruara
        /// </summary>
        /// <param name="dsId"></param>
        /// <returns></returns>
        public DataSet FshiKategoriTavoline(DataSet dsId)
        {
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("PERSHKRIMI", typeof(String));
            dsError.AcceptChanges();
            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_KATEGORIATAVOLINA", typeof(Int32));
            dsToErase.AcceptChanges();
            DbController db = new DbController();
            DataSet dsTavolinatKategori = db.Read("ShfaqNumrinETavolinavePerSecilenKategori");
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsTavolinatKategori.Tables[0].Columns["ID_KATEGORIATAVOLINA"];
            dsTavolinatKategori.Tables[0].PrimaryKey = vektorPrimary;
            foreach (DataRow dr in dsId.Tables[0].Rows)
            {
                int idKategoria = Convert.ToInt32(dr["ID_KATEGORIATAVOLINA"]);
                DataRow drSearch = dsTavolinatKategori.Tables[0].Rows.Find(idKategoria);
                //nqs nuk ka asnje tavoline te lidhur me kategorine
                //kategoria mund te fshihet
                if (drSearch == null)
                {
                    DataRow r = dsToErase.Tables[0].NewRow();
                    r["ID_KATEGORIATAVOLINA"] = dr["ID_KATEGORIATAVOLINA"];
                    dsToErase.Tables[0].Rows.Add(r);
                }
                //pnd raportohet se kategoria nuk mund te fshihet
                else
                {
                    DataRow r= dsError.Tables[0].NewRow();
                    r["PERSHKRIMI"] = dr["PERSHKRIMI"];
                    dsError.Tables[0].Rows.Add(r);
                }
            }
            dsToErase.AcceptChanges();
            dsError.AcceptChanges();
            if (dsToErase.Tables[0].Rows.Count == 0)
            {
                return dsError;
            }
            int b = db.Delete("FshiKategoriteETavolinave", dsToErase);
            //nqs veprimi ne database kryhet ne rregull
            if (b == 0)
                return dsError;
            //pnd kthejme null
            else
                return null;
        }

        /// <summary>
        /// Kthen tavolinat per te mbushur kombon e tavolinave per kerkim
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqTavolinatPerKombo()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTavolinatPerKombo");

            return ds;
        }

        #endregion

        #region Per konfigurimin e tavolinave

        /// <summary>
        /// Hap tavolinen per sherbime klientesh
        /// </summary>
        /// <param name="idTavolina"></param>
        /// <returns></returns>
        public int HapTavoline(int idTavolina)
        {
            DbController db = new DbController();
            int b = db.Update("HapTavoline", idTavolina);
            return 1;
        }

        /// <summary>
        /// Shfaq te gjitha tavolinat me te gjithe detajet e tyre
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqTavolinatDetaje()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTavolinatDetaje");
            ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                dr["CHECKED"] = false;
            }
            ds.AcceptChanges();
            return ds;
        }

        /// <summary>
        /// Kthen tavolinen me numrin me te madh
        /// </summary>
        /// <returns></returns>
        public DataSet TavolinaMeNrMeTeMadh()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTavolinenMeNumerMeTeMadh");
            return ds;
        }

        /// <summary>
        /// Shton tavoline te re sipas parametrave te percaktuar
        /// </summary>
        /// <param name="emri"></param>
        /// <param name="idKategoria"></param>
        /// <param name="kapaciteti"></param>
        /// <returns></returns>
        public int ShtoTavoline(string emri, int idKategoria, int kapaciteti)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTavolinatMeEmer", emri);
            //nqs ka nje tavoline me kete numer nuk duhet
            //te lejohet shtimi
            if (ds.Tables[0].Rows.Count != 0)
            {
                return 2;
            }
            else
            {
                int b = db.Create("ShtoTavoline", emri, idKategoria, kapaciteti);
                return b;
            }
        }

        /// <summary>
        /// Shton disa tavolina ne te njejten kohe
        /// </summary>
        /// <param name="numerTavolinash"></param>
        /// <param name="idKategoria"></param>
        /// <param name="kapaiteti"></param>
        /// <returns>Kthen numrat e tavolinave te shtuara</returns>
        public DataSet ShtoDisaTavolina(int numerTavolinash, int idKategoria, int kapaciteti)
        {
            DataSet dsResult = new DataSet();
            dsResult.Tables.Add();
            dsResult.Tables[0].Columns.Add("EMRI", typeof(Int32));
            dsResult.AcceptChanges();
            DbController db = new DbController();
            DataSet dsFundit = this.TavolinaMeNrMeTeMadh();
            int nrFundit;
            if (Convert.IsDBNull(dsFundit.Tables[0].Rows[0][0]))
            {
                nrFundit = 0;
            }
            else
            {
                nrFundit = Convert.ToInt32(dsFundit.Tables[0].Rows[0][0]);
            }
            for (int i = 0; i < numerTavolinash; i++)
            {
                nrFundit++;
                int b = db.Create("ShtoTavoline", nrFundit, idKategoria, kapaciteti);
                if (b == 0)
                {
                    DataRow r = dsResult.Tables[0].NewRow();
                    r["EMRI"] = nrFundit;
                    dsResult.Tables[0].Rows.Add(r);
                }
            }
            dsResult.AcceptChanges();
            return dsResult;
        }

        /// <summary>
        /// Modifikon tavolinen sipas parametrave te zgjedhur
        /// </summary>
        /// <param name="idTavolina"></param>
        /// <param name="emri"></param>
        /// <param name="idKategoria"></param>
        /// <param name="kapaciteti"></param>
        /// <returns></returns>
        public int ModifikoTavoline(int idTavolina, string emri, int idKategoria, int kapaciteti)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTavolinatMeEmerPerjashtoId", idTavolina, emri);
            //nqs ka nje tavoline me kete numer nuk duhet
            //te lejohet modifikimi
            if (ds.Tables[0].Rows.Count != 0)
            {
                return 2;
            }
            else
            {
                int b = db.Update("ModifikoTavoline", idTavolina, emri, idKategoria, kapaciteti);
                return b;
            }
        }

        /// <summary>
        /// Ben fshirjen e disa tavolinave ne te njejten kohe
        /// </summary>
        /// <param name="dsId"></param>
        /// <returns></returns>
        public DataSet FshiTavolina(DataSet dsId)
        {
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("EMRI", typeof(Int32));
            dsError.AcceptChanges();
            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_TAVOLINA", typeof(Int32));
            dsToErase.AcceptChanges();
            DbController db = new DbController();

            //DataSeti per kontrollin e gjendjes se tavolines 
            //nqs eshte  e lire apo e zene
            DataSet dsTavolinat = db.Read("ShfaqTavolinatDetaje");
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsTavolinat.Tables[0].Columns["ID_TAVOLINA"];
            dsTavolinat.Tables[0].PrimaryKey = vektorPrimary;
            dsTavolinat.AcceptChanges();

            //DataSet per kontrollin nqs ka rezervime per tavolinen
            DataSet dsRezervimeTavolina = db.Read("GjejTavolinatERezervuara");
            vektorPrimary[0] = dsRezervimeTavolina.Tables[0].Columns["ID_TAVOLINA"];
            dsRezervimeTavolina.Tables[0].PrimaryKey = vektorPrimary;
            dsRezervimeTavolina.AcceptChanges();

            //Ne datasetin me id qe merret si parameter
            //kontrollojme nqs ndonje prej tavolinave eshte e zene apo e rezervuar
            foreach (DataRow dr in dsId.Tables[0].Rows)
            {
                int idTavolina = Convert.ToInt32(dr["ID_TAVOLINA"]);
                DataRow drSearch = dsTavolinat.Tables[0].Rows.Find(idTavolina);
                string gjendja = drSearch["GJENDJA"].ToString();
                //nqs tavolina eshte e zene ajo nuk mund te fshihet
                if (gjendja != "L")
                {
                    DataRow r = dsError.Tables[0].NewRow();
                    r["EMRI"] = dr["EMRI"];
                    dsError.Tables[0].Rows.Add(r);
                }
                else
                {
                    //kontrollojme nqs tavolina eshte e rezervuar
                    
                    DataRow drSearch1 = dsRezervimeTavolina.Tables[0].Rows.Find(idTavolina);
                    //nje tavoline  e rezervuar nuk mund te fshihet
                    if (drSearch1 != null)
                    {
                        DataRow r = dsError.Tables[0].NewRow();
                        r["EMRI"] = dr["EMRI"];
                        dsError.Tables[0].Rows.Add(r);
                    }
                    //pnd raportohet se tavolina nuk mund te fshihet
                    else
                    {
                        DataRow r = dsToErase.Tables[0].NewRow();
                        r["ID_TAVOLINA"] = dr["ID_TAVOLINA"];
                        dsToErase.Tables[0].Rows.Add(r);
                    }
                }
            }
            dsToErase.AcceptChanges();
            dsError.AcceptChanges();
            if (dsToErase.Tables[0].Rows.Count == 0)
            {
                return dsError;
            }
            int b = db.Delete("FshiTavolinat", dsToErase);
            //nqs veprimi ne database kryhet ne rregull
            if (b == 0)
                return dsError;
            //pnd kthejme null
            else
                return null;
        }

        public int Mbyll(int idTavolina)
        {
            DbController db = new DbController();
            int b = db.Update("MbyllTavoline", idTavolina);
            b = db.Delete("FshiLidhjetFaturePerTavoline", idTavolina);

            return b;
        }

        public DataSet ShfaqFaturatKorentePerTavoline(int idTavolina)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqFaturatKorentePerTavoline", idTavolina);

            return ds;
        }

        public int TransferoTavolinen(int idTavolinaOld, int idTavolinaNew, int[] idFaturat)
        {
            DbController db = new DbController();
            int b = db.Update("TransferoTavolinen", idTavolinaOld, idTavolinaNew, idFaturat);

            if (b != 0)
            {
                return b;
            }

            b = db.Update("MbyllTavoline", idTavolinaOld);

            if (b != 0)
            {
                return b;
            }

            b = db.Update("HapTavoline", idTavolinaNew);
            return b;
        }

        #endregion

        #region Te tjera
        public DataSet TavolinatLiraPerKategori(int idKategoria, DateTime oraFillimi, DateTime oraMbarimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTavolinatEliraPerKategori", idKategoria, oraFillimi, oraMbarimi);
            return ds;
        }

        public DataSet TavolinatLiraPerKategori(int idKategoria, int idRezervimi, DateTime oraFillimi, DateTime oraMbarimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTavolinatEliraPerKategori", idKategoria, idRezervimi, oraFillimi, oraMbarimi );
            return ds;
        }
        #endregion

        #endregion

        #region Private methods
        #endregion
    }    
}
