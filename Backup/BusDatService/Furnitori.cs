using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ResManagerAdmin.BusDatService
{
    public class Furnitori
    {
        #region Constructors
        #endregion

        #region Public methods
        /// <summary>
        /// Shfaq te gjithe detajet per te gjithe furnitoret
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqFurnitore(string kushti)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqFurnitoret", kushti);
            if (!Convert.IsDBNull(ds))
            {
                ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
                ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
                ds.AcceptChanges();
            }
            return ds;
        }

        /// <summary>
        /// Krijon nje furnitor te ri
        /// </summary>
        /// <param name="emri"></param>
        /// <param name="mbiemri"></param>
        /// <param name="adresa"></param>
        /// <param name="emaili"></param>
        /// <param name="telefoni"></param>
        /// <returns></returns>
        public int ShtoFurnitor(string emri, string mbiemri, string adresa, string emaili, string telefoni)
        {
            DbController db = new DbController();
            string kushti = " WHERE EMRI = '" + emri + "'"; /// AND MBIEMRI = '" + mbiemri + "' ";
            DataSet ds = db.Read("ShfaqFurnitoret", kushti);

            //DataSet ds = db.Read("KontrolloKodinPerFurnitor", emri, mbiemri);

            if (ds.Tables[0].Rows.Count != 0)
            {
                //nuk lejohen dy furnitore me te njejtin emer dhe mbiemer
                return 2;
            }
            else
            {
                int b = db.Create("ShtoFurnitor", emri, mbiemri, adresa, emaili, telefoni);
                return b;
            }
        }
        /// <summary>
        /// Modifikon nje furnitor sipas parametrave te dhene
        /// </summary>
        /// <param name="idFurnitori"></param>
        /// <param name="emri"></param>
        /// <param name="mbiemri"></param>
        /// <param name="adresa"></param>
        /// <param name="emaili"></param>
        /// <param name="telefoni"></param>
        /// <returns></returns>
        /// 
        public int ModifikoFurnitor(int idFurnitori, string emri, string mbiemri, string adresa, string emaili, string telefoni)
        {
            
            DbController db = new DbController();
            string kushti = " WHERE (EMRI = '" + emri + "')";   //// AND (MBIEMRI = '" + mbiemri + "') AND NOT (ID_FURNITORI = " + idFurnitori + ")";
            DataSet ds = db.Read("ShfaqFurnitoret", kushti);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nuk lejohen dy furnitore me te njejtin emer dhe mbiemer
                return 2;
            }
            else
            {
                int b = db.Update("ModifikoFurnitor",idFurnitori, emri, mbiemri, adresa, emaili, telefoni);
                return b;
            }
        }

        /// <summary>
        /// Fshin furnitoret id e te cileve jane ne dsID dhe
        /// ne varesi te llojit te fshirjes te konfirmuar nga perdoruesi
        /// </summary>
        /// <param name="dsId"></param>
        /// <param name="llojiFshirje"></param>
        /// <returns></returns>
        public DataSet FshiFurnitor(DataSet dsId, string llojiFshirje)
        {
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("EMRI", typeof(String));
            dsError.Tables[0].Columns.Add("MBIEMRI", typeof(String));
            dsError.AcceptChanges();
            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_FURNITORI", typeof(Int32));
            dsToErase.AcceptChanges();
            DbController db = new DbController();
            DataSet dsFurnitoretBlerjet = db.Read("ShfaqNumrinEBlerjevePerSecilinFurnitor");
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsFurnitoretBlerjet.Tables[0].Columns["ID_FURNITORI"];
            dsFurnitoretBlerjet.Tables[0].PrimaryKey = vektorPrimary;
            foreach (DataRow dr in dsId.Tables[0].Rows)
            {
                int idFurnitori = Convert.ToInt32(dr["ID_FURNITORI"]);
                DataRow drSearch = dsFurnitoretBlerjet.Tables[0].Rows.Find(idFurnitori);
                //nqs nuk ka asnje blerje per furnitorin
                //furnitori mund te fshihet
                if (drSearch == null)
                {
                    DataRow r = dsToErase.Tables[0].NewRow();
                    r["ID_FURNITORI"] = dr["ID_FURNITORI"];
                    dsToErase.Tables[0].Rows.Add(r);
                }
                //pnd ne varesi te llojit te Fshirjes duhet te vendoset nqs
                //ne tabelen e blerjeve do vendosen null vlerat e id_furnitori 
                //dhe furnitoret te fshihen apo nqs keta lloj furnitoresh nuk do lejohen te fshihen
                else
                {
                    //furnitori gjithsesi shtohet ne datasetin dsError
                    //pasi pavarsisht nga lloji i fshirjes perdoruesi
                    //do te informohet ne lidhje me furnitoret qe kane patur blerje
                    DataRow r = dsError.Tables[0].NewRow();
                    r["EMRI"] = dr["EMRI"];
                    r["MBIEMRI"] = dr["MBIEMRI"];
                    dsError.Tables[0].Rows.Add(r);
                    //Vetem nqs perdoruesi ka zgjedhur te fshije te gjithe furnitoret
                    //pavarsisht nga blerjet furnitori shtohet ne dsToErase
                    if (llojiFshirje == "FshiTeGjithe")
                    {
                        DataRow r1 = dsToErase.Tables[0].NewRow();
                        r1["ID_FURNITORI"] = dr["ID_FURNITORI"];
                        dsToErase.Tables[0].Rows.Add(r1);
                    }
                }
            }
            dsToErase.AcceptChanges();
            dsError.AcceptChanges();
            if (dsToErase.Tables[0].Rows.Count == 0)
            {
                return dsError;
            }
            //Vendosen Null vlerat e id_furnitori ne tabelen e blerjeve
            //dhe fshihen furnitoret
            int b = db.Delete("FshiFurnitoret", dsToErase);
            //nqs veprimi ne database kryhet ne rregull
            if (b == 0)
                return dsError;
            //pnd kthejme null
            else
                return null;
        }

        public DataSet ShfaqArtikujtPerFurnitoret(string kushti)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqArtikujtPerFurnitoret", kushti);
            ds.Tables[0].Columns.Add("CHECKED", typeof(bool));
            ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
            ds.AcceptChanges();
            return ds;
        }

        /// <summary>
        /// Ne perkatesi te furnitorit me ID sa idFurnitori ruan artikujt qe gjenden ne dataset
        /// </summary>
        /// <param name="idFurnitori"></param>
        /// <param name="dsArtikujt"></param>
        /// <returns></returns>
        public DataSet RuajPerkatesiArtikuj(int idFurnitori, DataSet dsArtikujt)
        {
            DbController db = new DbController();
            int b = db.Update("RuajPerkatesiArtikuj", idFurnitori, dsArtikujt);
            if (b == 1)
                return null;
            else
                return new DataSet();
            
        }

        public int FshiPerkatesiArtikuj(DataSet dsAF)
        {
            DbController db = new DbController();
            int b = db.Delete("FshiPerkatesiArtikuj", dsAF);
            return b;
        }
        #endregion

        #region Private methods
        #endregion
    }
}
