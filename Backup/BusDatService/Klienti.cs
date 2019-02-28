using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.BusDatService
{
    class Klienti
    {
        #region Contructor
        #endregion

        #region PublicMethods

        public int ShtoKlient(string emri, string mbiemri, string kodiKlienti, string telefoni, string adresa)
        {
            int b = 0;
            DbController db = new DbController();

            string varString = "ShtoKlient";

            b = db.Create(varString, emri, mbiemri, kodiKlienti, telefoni, adresa);

            return b;
        }

        public int ModifikoKlient(int idKlienti, string emri, string mbiemri, string kodiKlienti, string telefoni, string adresa)
        {
            int b = 0;
            DbController db = new DbController();

            string varString = "ModifikoKlient";

            b = db.Update(varString, idKlienti, emri, mbiemri, kodiKlienti, telefoni, adresa);

            return b;
        }

        public DataSet ShfaqKlientet(string kushti)
        {
            DbController db = new DbController();
            DataSet ds = null;

            string varKerkesa = "ShfaqKlientet";

            ds = db.Read(varKerkesa, kushti);

            return ds;
        }

        public DataSet FshiKlient(DataSet dsId, string llojiFshirje)
        {
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("EMRI", typeof(String));
            dsError.Tables[0].Columns.Add("MBIEMRI", typeof(String));
            dsError.AcceptChanges();

            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_KLIENTI", typeof(Int32));
            dsToErase.AcceptChanges();

            DbController db = new DbController();

            DataSet dsKlientiFaturat = db.Read("ShfaqNumrinEfaturavePerSecilinKlient");
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsKlientiFaturat.Tables[0].Columns["ID_KLIENTI"];
            dsKlientiFaturat.Tables[0].PrimaryKey = vektorPrimary;

            foreach (DataRow dr in dsId.Tables[0].Rows)
            {
                int idKlienti = Convert.ToInt32(dr["ID_KLIENTI"]);
                DataRow drSearch = dsKlientiFaturat.Tables[0].Rows.Find(idKlienti);
                //nqs nuk ka asnje blerje per klientin
                //klienti mund te fshihet
                if (drSearch == null)
                {
                    DataRow r = dsToErase.Tables[0].NewRow();
                    r["ID_KLIENTI"] = dr["ID_KLIENTI"];
                    dsToErase.Tables[0].Rows.Add(r);
                }
                //pnd ne varesi te llojit te Fshirjes duhet te vendoset nqs
                //ne tabelen e blerjeve do vendosen null vlerat e id_klienti
                //dhe klientet te fshihen apo nqs keta lloj klientet nuk do lejohen te fshihen
                else
                {
                    //klienti gjithsesi shtohet ne datasetin dsError
                    //pasi pavarsisht nga lloji i fshirjes perdoruesi
                    //do te informohet ne lidhje me klientet qe kane patur fatura

                    DataRow r = dsError.Tables[0].NewRow();
                    r["EMRI"] = dr["EMRI"];
                    r["MBIEMRI"] = dr["MBIEMRI"];
                    dsError.Tables[0].Rows.Add(r);
                    //Vetem nqs perdoruesi ka zgjedhur te fshije te gjithe klientet
                    //pavarsisht nga faturatt klienti shtohet ne dsToErase
                    if (llojiFshirje == "FshiTeGjithe")
                    {
                        DataRow r1 = dsToErase.Tables[0].NewRow();
                        r1["ID_KLIENTI"] = dr["ID_KLIENTI"];
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
            //Vendosen Null vlerat e id_klienti ne tabelen e faturave
            //dhe fshihen klientet
            int b = db.Delete("FshiKlientet", dsToErase);
            //nqs veprimi ne database kryhet ne rregull
            if (b == 0)
                return dsError;
            //pnd kthejme null
            else
                return null;
        }


        #endregion

        #region PrivateMethods
        #endregion




    }
}
