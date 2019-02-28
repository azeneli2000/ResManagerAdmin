using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ResManagerAdmin.BusDatService
{
    public  class Rezervimi
    {
        #region Constructors
        #endregion

        #region Private Methods
        #endregion

        #region Public Methods
        /// <summary>
        /// kthen nje dataset me te gjithe rezervimet per daten e dhene
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public DataSet ShfaqRezervime(DateTime data)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqRezervimetTavolina", data);
            return ds;
        }

        /// <summary>
        /// Kthen te gjitha te dhenat per rezervimin me id e dhene
        /// </summary>
        /// <param name="idRezervimi"></param>
        /// <returns></returns>
        public DataSet ShfaqTeDhenaRezervimi(int idRezervimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTeDhenaRezervimi", idRezervimi);
            return ds;
        }

        /// <summary>
        /// Shton nje rezervim te ri per tavolinat ne vektor
        /// </summary>
        /// <param name="emri"></param>
        /// <param name="mbiemri"></param>
        /// <param name="data"></param>
        /// <param name="oraFillimi"></param>
        /// <param name="oraMbarimi"></param>
        /// <param name="vektorId"></param>
        /// <returns></returns>
        public int ShtoRezervim(string emri, string mbiemri, DateTime data,
            DateTime oraFillimi, DateTime oraMbarimi, int[] vektorId)
        {
            DbController db = new DbController();
            DataSet ds = db.Create("ShtoRezervim", emri,mbiemri, data, oraFillimi, oraMbarimi);
            int idRezervimi = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            int b = db.Create("RezervoTavolina", idRezervimi, vektorId);
            return b;
        }

        /// <summary>
        /// Modifikon te dhenat per rezervimin dhe tavolinat e rezervuara
        /// </summary>
        /// <param name="idRezervimi"></param>
        /// <param name="emri"></param>
        /// <param name="mbiemri"></param>
        /// <param name="data"></param>
        /// <param name="oraFillimi"></param>
        /// <param name="oraMbarimi"></param>
        /// <param name="vektorId"></param>
        /// <returns></returns>
        public int ModifikoRezervim(int idRezervimi, string emri, string mbiemri, DateTime data,
            DateTime oraFillimi, DateTime oraMbarimi, int[] vektorId)
        {
            DbController db = new DbController();
            int b = db.Update("ModifikoRezervim",idRezervimi, emri, mbiemri, data, oraFillimi, oraMbarimi);
            b += db.Create("RezervoTavolina", idRezervimi, vektorId);
            return b;
        }

        /// <summary>
        /// Fshin rezervimin me id e e dhene
        /// </summary>
        /// <param name="idRezervimi"></param>
        /// <returns></returns>
        public int FshiRezervim(int idRezervimi)
        {
            DbController db = new DbController();
            int b = db.Delete("FshiRezervim", idRezervimi);
            return 0;
        }

        public DataSet FshiRezervim(DataSet dsId)
        {
            DbController db = new DbController();
            int b = db.Delete("FshiRezervimeSkaduara", dsId);
            if (b == 0)
                return new DataSet();
            else
                return null;
        }

        /// <summary>
        /// Kthen nje dataset me te gjithe rezervimet e skaduara
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqRezervimeSkaduara()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("RezervimetESkaduara");
            return ds;
        }
        #endregion
    }
}
