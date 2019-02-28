using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ResManagerAdmin.BusDatService
{
    public class Oferta
    {
        #region Constructor
        #endregion

        #region Public methods
        #region Create
        public int KrijoOferte(string emri, string tipi, int shportat, decimal cmimi, DataSet dsRecetat)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("KontrolloKodinPerOferte", emri);
            int b = 0;

            if (ds == null)
            {
                return 1;
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                return 2;
            }

            ds = db.Read("KrijoOferte", emri, tipi, shportat, cmimi);

            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                return 1;  
            }

            int idOferta = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            b = db.Create("KrijoLidhjeOferteRecete", idOferta, dsRecetat);

            return b;
        }

        # endregion

        #region Update

        public int ModifikoOferte(int idOferta, string emri, string tipi, int shportat, decimal cmimi, DataSet dsRecetat)
        {
            DbController db = new DbController();

            DataSet ds = db.Read("KontrolloEmrinOfertaPerModifikim", idOferta, emri);

            if (ds == null)
            {
                return 1;
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                return 2;
            }

            int b = db.Update("ModifikoOferte", idOferta, emri, tipi, shportat, cmimi);

            b = db.Delete("FshiRecetatPerOferte", idOferta);

            b = db.Create("KrijoLidhjeOferteRecete", idOferta, dsRecetat);

            return b;

        }

        #endregion

        #region Read
        public DataSet ShfaqOfertatPerBarin()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqOfertatPerBarin");

            return ds;
        }

        public DataSet ShfaqOfertatPerHotelin()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqOfertatPerHotelin");

            return ds;
        }

        public DataSet ShfaqTeDhenaPerOferten(int idOferta)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTeDhenaPerOferten", idOferta);

            return ds;
        }

        #endregion

        #endregion

        #region Private methods
        #endregion
    }   
}
