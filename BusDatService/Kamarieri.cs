using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ResManagerAdmin.BusDatService
{
    public class Kamarieri
    {
        #region Constructor
        #endregion

        #region Public methods
        #region Per Logim & Logout & Turnet
        /// <summary>
        /// Shfaq vetem perdoruesit qe jane kamariere
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqKamarieret()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqPerdoruesitKamariere");
            return ds;
        }

        public DataSet ShfaqKamarieretPerKombo()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKamarieretPerKombo");
            return ds;
        }

        /// <summary>
        /// Modifikon fjalekalimin per nje perdorues
        /// </summary>
        /// <param name="idPerdoruesi"></param>
        /// <param name="fjalekalimi"></param>
        /// <returns></returns>
        public int ModifikoFjalekalim(int idPerdoruesi, string fjalekalimi)
        {
            DbController db = new DbController();
            int b = db.Update("ModifikoFjalekalim", idPerdoruesi, fjalekalimi);
            return b;
        }

        public DataSet ShfaqTurnet(string kushti)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTurnet", kushti);
            return ds;
        }

        /// <summary>
        /// Fshin te gjithe regjistrimet e nderrimit te turneve
        /// per kamarieret pervec turneve qe bejne pjese ne diten e sotme
        /// </summary>
        /// <returns></returns>
        public int FshiHistorikTurnet()
        {
            DbController db = new DbController();
            int b = db.Delete("FshiHistorikTurnet");
            return b;
        }

        public DataSet KtheKamarieretLoguar()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("KtheKamarieretLoguar");

            return ds;
             
        }

        public DataSet ShfaqTurnetPerLodim(int idKamarieri)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("KtheTurninKorent", idKamarieri);

            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            DateTime fillimi = Convert.ToDateTime(ds.Tables[0].Rows[0]["FILLIMI"]);
            double xhiro = 0;

            ds = db.Read("KtheXhironPerTurnin", idKamarieri, fillimi);
            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                xhiro = 0;
            }
            else
            {
                if (Convert.IsDBNull(ds.Tables[0].Rows[0][0]))
                {
                    xhiro = 0;
                }
                else
                {
                    xhiro = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                }
            }

            DataSet dsXhiroTurni = new DataSet();
            dsXhiroTurni.Tables.Add();

            dsXhiroTurni.Tables[0].Columns.Add("ID_TURNI", typeof(Int32));
            dsXhiroTurni.Tables[0].Columns.Add("FILLIMI", typeof(string));
            dsXhiroTurni.Tables[0].Columns.Add("MBARIMI", typeof(string));
            dsXhiroTurni.Tables[0].Columns.Add("XHIRO", typeof(string));

            DataRow dr = dsXhiroTurni.Tables[0].NewRow();

            dr["ID_TURNI"] = 1;
            dr["FILLIMI"] = fillimi.ToString("dd.MM.yyyy hh:mm");
            dr["MBARIMI"] = "----";
            dr["XHIRO"] = xhiro.ToString();

            dsXhiroTurni.Tables[0].Rows.Add(dr);
            dsXhiroTurni.Tables[0].AcceptChanges();


            return dsXhiroTurni;
        }

        public DataSet ShfaqTurnetPerKamarierPerPeriudhen(int idKamarieri, DateTime dtFillimi, DateTime dtMbarimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTurnetPerKamarierPerPeriudhen", idKamarieri, dtFillimi, dtMbarimi);

            return ds;
        }

        public DataSet ShfaqTurnetSipasKerkimit(int zgjedhja, bool hapur, int idKam, DateTime dtKerkimi)
        {
            DbController db = new DbController();
            DataSet ds = null;
            string strSql = "";

            if (hapur == true)
            {
                switch (zgjedhja)
                {
                    case 0 :
                        strSql = "SELECT ID_TURNI, P.ID_PERSONELI, P.PERDORUESI AS KAMARIERI, FILLIMI, SUM(TOTALI - SKONTO) AS XHIRO " +
                                 "FROM TURNET AS T INNER JOIN FATURAT AS F ON T.ID_PERSONELI = F.ID_PERSONELI " +
                                 "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                                 "WHERE (F.ANULLUAR = 0) AND (DATA_ORA >= FILLIMI) AND MBYLLUR = 0 " +
                                 "GROUP BY ID_TURNI, FILLIMI, P.PERDORUESI, P.ID_PERSONELI";
                        break;

                    case 1 :
                        strSql = "SELECT ID_TURNI, P.ID_PERSONELI, P.PERDORUESI AS KAMARIERI, FILLIMI, SUM(TOTALI - SKONTO) AS XHIRO " +
                                 "FROM TURNET AS T INNER JOIN FATURAT AS F ON T.ID_PERSONELI = F.ID_PERSONELI " +
                                 "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                                 "WHERE (F.ANULLUAR = 0) AND T.ID_PERSONELI = " + idKam + " AND " +
                                 "(DATA_ORA >= FILLIMI) AND MBYLLUR = 0 " +
                                 "GROUP BY ID_TURNI, FILLIMI, P.PERDORUESI, P.ID_PERSONELI";
                        break;

                    case 2:
                        strSql = "SELECT ID_TURNI, P.ID_PERSONELI, P.PERDORUESI AS KAMARIERI, FILLIMI,  SUM(TOTALI - SKONTO) AS XHIRO " +
                                 "FROM TURNET AS T INNER JOIN FATURAT AS F ON T.ID_PERSONELI = F.ID_PERSONELI " +
                                 "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                                 "WHERE (F.ANULLUAR = 0) AND (DATA_ORA >= FILLIMI) AND MBYLLUR = 0 AND " +
                                 "( YEAR(FILLIMI) = " + dtKerkimi.Year + " AND MONTH(FILLIMI) = " + dtKerkimi.Month + " AND DAY(FILLIMI) = " + dtKerkimi.Day + " ) " +
                                 "GROUP BY ID_TURNI, FILLIMI, P.PERDORUESI, P.ID_PERSONELI";
                        break;

                    case 3:
                        strSql = "SELECT ID_TURNI, P.ID_PERSONELI, P.PERDORUESI AS KAMARIERI, FILLIMI, MBARIMI, SUM(TOTALI - SKONTO) AS XHIRO " +
                                "FROM TURNET AS T INNER JOIN FATURAT AS F ON T.ID_PERSONELI = F.ID_PERSONELI " +
                                "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                                "WHERE (F.ANULLUAR = 0) AND T.ID_PERSONELI = " + idKam + " AND " +
                                "(DATA_ORA >= FILLIMI) AND MBYLLUR = 0 AND " +
                                "( YEAR(FILLIMI) = " + dtKerkimi.Year + " AND MONTH(FILLIMI) = " + dtKerkimi.Month + " AND DAY(FILLIMI) = " + dtKerkimi.Day + " ) " +
                                "GROUP BY ID_TURNI, FILLIMI, P.PERDORUESI, P.ID_PERSONELI";
                        break;

                    default :
                        break;
                }
            }
            else
            {
                switch (zgjedhja)
                {
                    case 0:
                        strSql = "SELECT ID_TURNI, P.ID_PERSONELI, P.PERDORUESI AS KAMARIERI, FILLIMI, MBARIMI, SUM(TOTALI - SKONTO) AS XHIRO " +
                                 "FROM TURNET AS T INNER JOIN FATURAT AS F ON T.ID_PERSONELI = F.ID_PERSONELI " +
                                 "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                                 "WHERE (F.ANULLUAR = 0) AND (DATA_ORA BETWEEN FILLIMI AND MBARIMI) AND  (MBYLLUR = 1) " +
                                 "GROUP BY ID_TURNI, FILLIMI, MBARIMI, P.PERDORUESI, P.ID_PERSONELI";
                        break;

                    case 1:
                        strSql = "SELECT ID_TURNI, P.ID_PERSONELI, P.PERDORUESI AS KAMARIERI, FILLIMI, MBARIMI, SUM(TOTALI - SKONTO) AS XHIRO " +
                                 "FROM TURNET AS T INNER JOIN FATURAT AS F ON T.ID_PERSONELI = F.ID_PERSONELI " +
                                 "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                                 "WHERE (F.ANULLUAR = 0) AND T.ID_PERSONELI = " + idKam + " AND (MBYLLUR = 1) AND " +
                                 "(DATA_ORA BETWEEN FILLIMI AND MBARIMI) " +
                                 "GROUP BY ID_TURNI, FILLIMI, MBARIMI, P.PERDORUESI, P.ID_PERSONELI";
                        break;

                    case 2:
                        strSql = "SELECT ID_TURNI, P.ID_PERSONELI, P.PERDORUESI AS KAMARIERI, FILLIMI, MBARIMI, SUM(TOTALI - SKONTO) AS XHIRO " +
                                 "FROM TURNET AS T INNER JOIN FATURAT AS F ON T.ID_PERSONELI = F.ID_PERSONELI " +
                                 "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                                 "WHERE (F.ANULLUAR = 0) AND (DATA_ORA BETWEEN FILLIMI AND MBARIMI) AND (MBYLLUR = 1) AND " +
                                 "( YEAR(FILLIMI) = " + dtKerkimi.Year + " AND MONTH(FILLIMI) = " + dtKerkimi.Month + " AND DAY(FILLIMI) = " + dtKerkimi.Day + " ) " +
                                 "GROUP BY ID_TURNI, FILLIMI, MBARIMI, P.PERDORUESI, P.ID_PERSONELI";
                        break;

                    case 3:
                        strSql = "SELECT ID_TURNI, P.ID_PERSONELI, P.PERDORUESI AS KAMARIERI, FILLIMI, MBARIMI, SUM(TOTALI - SKONTO) AS XHIRO " +
                                 "FROM TURNET AS T INNER JOIN FATURAT AS F ON T.ID_PERSONELI = F.ID_PERSONELI " +
                                 "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                                 "WHERE (F.ANULLUAR = 0) AND T.ID_PERSONELI = " + idKam + " AND " +
                                 "(DATA_ORA BETWEEN FILLIMI AND MBARIMI) AND (MBYLLUR = 1) AND " +
                                 "( YEAR(FILLIMI) = " + dtKerkimi.Year + " AND MONTH(FILLIMI) = " + dtKerkimi.Month + " AND DAY(FILLIMI) = " + dtKerkimi.Day + " ) " +
                                 "GROUP BY ID_TURNI, FILLIMI, MBARIMI, P.PERDORUESI, P.ID_PERSONELI";
                        break;

                    default:
                        break;
                }
            }

            ds = db.Read("ShfaqTurnetSipasKerkimit", strSql);

            return ds;
        }

        public DataSet LexoTurninPerKamarierin(int idKam, DateTime dtFillimi, DateTime dtMbarimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("LexoTurninPerKamarierin", idKam, dtFillimi, dtMbarimi);

            return ds;
        }

        #endregion


        #endregion

        #region Private methods
        #endregion
    }
}
