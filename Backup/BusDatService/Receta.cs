using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ResManagerAdmin.BusDatService;


namespace ResManagerAdmin.BusDatService
{
    public class Receta
    {
        #region Constructor
        #endregion

        #region Public methods

        #region Per konfigurimin e kategorive
        /// <summary>
        /// Kthen nje dataset me te gjitha kategorite e recetave
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqKategoriteReceta()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteERecetave");
            if (!Convert.IsDBNull(ds))
            {
                ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
                ds.AcceptChanges();
                ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
                ds.AcceptChanges();
            }
            return ds;
        }

        public DataSet ShfaqKategoriteRecetaPerMenu()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteERecetavePerMenu");

            return ds;
        }

        /// <summary>
        /// Shton nje kategori recete me emrin qe merr si parameter
        /// </summary>
        /// <param name="emri"></param>
        /// <returns></returns>
        public int ShtoKategoriRecete(string emri)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteERecetavePerEmer", emri);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nqs ka nje kategori recete me kete emer nuk lejohet shtimi
                return 2;
            }
            else
            {
                int b = db.Create("ShtoKategoriRecete", emri);
                return b;
            }
        }

        public DataSet ShfaqRecetatSipasKategorive()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqRecetatSipasKategorive");

            return ds;
           
        }

        public DataSet ShfaqRecetatSipasKategorivePerFavorite()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqRecetatSipasKategorivePerFavorite");

            return ds;

        }

        public DataSet ShfaqRecetatPerKategoriOferte(int idKategoria)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqRecetatPerKategoriOferte", idKategoria);

            return ds;

        }


        /// <summary>
        /// Modifikon emrin e nje kategorie recete
        /// </summary>
        /// <param name="idKategoria"></param>
        /// <param name="emri"></param>
        /// <returns></returns>
        public int ModifikoKategoriRecete(int idKategoria, string emri)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteERecetavePerEmerPerjashtoId", idKategoria, emri);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nqs ka nje kategori recete me kete emer nuk lejohet modifikimi
                return 2;
            }
            else
            {
                int b = db.Update("ModifikoKategoriRecete", idKategoria, emri);
                return b;
            }
        }

        /// <summary>
        /// Fshin te gjitha kategorite e recetave id e te cilave
        /// permbahen ne dataset
        /// </summary>
        /// <param name="dsId"></param>
        /// <returns></returns>
        public DataSet FshiKategoriRecetash(DataSet dsId)
        {
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("PERSHKRIMI", typeof(String));
            dsError.AcceptChanges();
            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_KATEGORIARECETA", typeof(Int32));
            dsToErase.AcceptChanges();
            DbController db = new DbController();
            DataSet dsKategoriteRecetat = db.Read("ShfaqNumrinERecetavePerSecilenKategori");
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsKategoriteRecetat.Tables[0].Columns["ID_KATEGORIARECETA"];
            dsKategoriteRecetat.Tables[0].PrimaryKey = vektorPrimary;
            foreach (DataRow dr in dsId.Tables[0].Rows)
            {
                int idKategoria = Convert.ToInt32(dr["ID_KATEGORIARECETA"]);
                DataRow drSearch = dsKategoriteRecetat.Tables[0].Rows.Find(idKategoria);
                //nqs nuk ka asnje recete te lidhur me kategorine
                //kategoria mund te fshihet
                if (drSearch == null)
                {
                    DataRow r = dsToErase.Tables[0].NewRow();
                    r["ID_KATEGORIARECETA"] = dr["ID_KATEGORIARECETA"];
                    dsToErase.Tables[0].Rows.Add(r);
                }
                //pnd raportohet se kategoria nuk mund te fshihet
                else
                {
                    DataRow r = dsError.Tables[0].NewRow();
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
            int b = db.Delete("FshiKategoriteERecetave", dsToErase);
            //nqs veprimi ne database kryhet ne rregull
            if (b == 0)
                return dsError;
            //pnd kthejme null
            else
                return null;
        }
         #endregion

        #region Per konfigurimin e recetave

        public DataSet KtheKufirinPerRecetat(DataSet dsRecetat)
        {
            DbController db = new DbController();
            //DataSet ds = db.Read("KtheKufirinPerRecetat", dsRecetat);
            

            DataSet ds = null;
            int idReceta = 0;
            int sasia = 0;

            DataSet dsKthe = new DataSet();
            dsKthe.Tables.Add();

            dsKthe.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            dsKthe.Tables[0].Columns.Add("RECETA", typeof(string));
            dsKthe.Tables[0].Columns.Add("SASIA", typeof(Int32));

            dsKthe.AcceptChanges();

            foreach (DataRow dr in dsRecetat.Tables[0].Rows)
            {
                idReceta = Convert.ToInt32(dr[0]);
                ds = db.Read("LexoSasineMinimalePerReceten", idReceta);
                sasia = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                if (sasia < Convert.ToInt32(dr["SASIA"]))
                {
                    DataRow drNew = dsKthe.Tables[0].NewRow();
                    drNew["ID_RECETA"] = idReceta;
                    drNew["RECETA"] = dr["RECETA"];
                    drNew["SASIA"] = sasia;

                    dsKthe.Tables[0].Rows.Add(drNew);
                    dsKthe.Tables[0].AcceptChanges();

                   return dsKthe;
                }
            }

            return dsKthe;
        }

        public DataSet ShfaqRecetatPerKategoriKonfigurimCmimesh(int idKategoria)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqRecetatPerKategoriKonfigurimCmimesh", idKategoria);

            return ds;
        }

        public DataSet ShfaqRecetat(string kushti)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqRecetat", kushti);
            ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
            ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
            ds.Tables[0].Columns.Add("CMIMI_AKTUAL", typeof(Double));
            ds.Tables[0].Columns.Add("RECETA", typeof(String));
            //bashke me recetat shfaqen edhe cmimet aktuale te tyre
            DataSet dsCmimet = db.Read("ShfaqCmimetShitjeKorrenteRecetat");
            DataColumn[] primary = new DataColumn[1];
            primary[0] = dsCmimet.Tables[0].Columns["ID_RECETA"];
            dsCmimet.Tables[0].PrimaryKey = primary;
            dsCmimet.AcceptChanges();
            int idReceta = 0;
            decimal cmimi = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (idReceta != Convert.ToInt32(dr["ID_RECETA"]))
                {
                    idReceta = Convert.ToInt32(dr["ID_RECETA"]);
                    DataRow drSearch = dsCmimet.Tables[0].Rows.Find(idReceta);
                    //nqs nuk ka nje cmim korrent per receten atehere cmimin e vendosim automatikisht 0
                    if (drSearch == null)
                        cmimi = 0;
                    else
                        cmimi = Convert.ToDecimal(drSearch["VLERA"]);
                }
                dr["CMIMI_AKTUAL"] = Convert.ToDecimal(cmimi);
                if (cmimi == 0)
                    dr["RECETA"] = dr["EMRI"].ToString();
                else
                    dr["RECETA"] = dr["EMRI"].ToString();

            }
            ds.AcceptChanges();
           
            
            return ds;
        }

        /// <summary>
        /// Shton nje recete te re me te dhena si ne dataset
        /// tabela e pare e dataset ka te dhenat per receten
        /// tabele e dyte e dataset ka te dhenat per secilin artikull
        /// </summary>
        /// <param name="dsReceta"></param>
        /// <returns></returns>
        public int ShtoRecete(DataSet dsReceta, DataSet dsEkstrat)
        {
            DbController db = new DbController();
            string emriReceta = dsReceta.Tables[0].Rows[0]["EMRI"].ToString();
            string kushti = " WHERE dbo.RECETAT.EMRI = '" + emriReceta + "'";
            DataSet dsKerko = db.Read("ShfaqRecetat", kushti);
            if (dsKerko.Tables[0].Rows.Count != 0)
                return 2;
            else
            {
                int idKategoriaReceta = Convert.ToInt32(dsReceta.Tables[0].Rows[0]["ID_KATEGORIARECETA"]);
                DataSet ds = db.Read("ShtoRecete", idKategoriaReceta, emriReceta);
                if (ds != null)
                {
                    int idReceta = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    int b = db.Create("ShtoArtikujNeRecete", idReceta ,dsReceta);

                    ds = db.Read("ShfaqGrupCmimet");
                    if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                    {
                        b = db.Create("KrijoLidhjenReceteGrupCmimesh", idReceta, ds);
                    }

                    b = db.Delete("FshiEkstratPerRecete", idReceta);

                    if (dsEkstrat.Tables[0].Rows.Count > 0)
                    {
                        b = db.Create("KrijoEkstratPerRecete", idReceta, dsEkstrat);
                    }

                    return b;
                }
                else
                    return 1;
            }
        }

        /// <summary>
        /// Modifikon nje recete
        /// tabela e pare e dataset ka te dhenat per receten
        /// tabele e dyte e dataset ka te dhenat per secilin artikull
        /// </summary>
        /// <param name="idReceta"></param>
        /// <param name="dsReceta"></param>
        /// <returns></returns>
        public int ModifikoRecete(int idReceta, DataSet dsReceta, DataSet dsEkstrat)
        {
            DbController db = new DbController();
            //nqs permbajtja e recetes ka ndryshuar atehere
            //modifikimi i recetes caktivizon receten dhe krijon nje recete te re me
            //te dhenat e modifikuara
            if (KrahasoReceten(idReceta, dsReceta) == true)
            {
                //caktivizim
                int b = db.Update("CaktivizoRecete", idReceta);
                //krijo te re
                if (b == 0)
                    b += ShtoRecete(dsReceta, dsEkstrat);
                return b;
            }
            //nqs ka ndryshuar vetem emri i recetes apo kategoria
            //behet modifikimi i te njejtes recete
            else
            {
                int b = db.Update("ModifikoRecete", idReceta, Convert.ToInt32(dsReceta.Tables[0].Rows[0]["ID_KATEGORIARECETA"]),
                    dsReceta.Tables[0].Rows[0]["EMRI"].ToString());

                b = db.Delete("FshiEkstratPerRecete", idReceta);

                if (dsEkstrat.Tables[0].Rows.Count > 0)
                {
                    b = db.Create("KrijoEkstratPerRecete", idReceta, dsEkstrat);
                }

                return b;
            }
            
        }

        /// <summary>
        /// Ndryshon disponibilitetin e recetave ne menu
        /// </summary>
        /// <param name="disponueshem"></param>
        /// <param name="dsId"></param>
        /// <returns></returns>
        public int NdryshoDisponibilitet(int disponueshem, DataSet dsId)
        {
            DbController db = new DbController();
            int b = db.Update("NdryshoDisponibilitet", disponueshem, dsId);

            if (b == 0)
            {
                if (disponueshem == 0)
                {
                    b = db.Delete("FshiRecetatNgaFavoritet", dsId);
                }
            }

            return b;
        }

        /// <summary>
        /// metoda nuk ben fshirje reale te recetes por vetem
        /// caktivizim te saj ne menyre qe te mos figuroje me ne menu
        /// </summary>
        /// <param name="dsId"></param>
        /// <returns></returns>
        public int FshiReceta(DataSet dsId)
        {
            DbController db = new DbController();
            int b = db.Delete("FshiRecetat", dsId);

            if (b == 0)
            {
                b = db.Delete("FshiRecetatNgaFavoritet", dsId);
            }

            return b;
        }
        #endregion

        #region Grupet e cmimeve

        public DataSet ShfaqGrupCmimet()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqGrupCmimet");

            return ds;
        }

        public int KrijoGrupCmimi(string kodi, string pershkrimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("KontrolloKodinGrupCmimiPerInsert", kodi);

            if (ds == null )
            {
                return 1;
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                return 2;
            }

            

            int b = db.Create("KrijoGrupCmimi", kodi, pershkrimi);

            if (b != 0)
            {
                return b;
            }

            ds = db.Read("ShfaqGrupCmimet");

            ds = db.Read("KtheMaksIdGrupCmimi");

            int idGrupi = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            ds = db.Read("ShfaqRecetatSipasKategorive");

            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                b = db.Create("KrijoCmimRecetePerGrup", idGrupi, ds);
            }

            ds = db.Read("ShfaqGrupCmimet");

            if ((ds != null ) && (ds.Tables[0].Rows.Count == 1))
            {
                b = db.Update("ZgjidhGrupCmimi", idGrupi);
            }

            return b;
        }

        public int ModifikoGrupCmimi(int idGrupi, string kodi, string pershkrimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("KontrolloKodinGrupCmimiPerModifikim", idGrupi, kodi);

            if (ds == null)
            {
                return 1;
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                return 2;
            }

            int b = db.Update("ModifikoGrupCmimi", idGrupi, kodi, pershkrimi);

            return b;
        }

        public DataSet ShfaqCmimeRecetatPerGrupinZgjedhur(int idGrupi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqCmimeRecetatPerGrupinZgjedhur", idGrupi);

            return ds;
        }

        public int ModifikoCmimeRecetatPerGrup(int idGrupi, DataSet dsRecetat)
        {
            DbController db = new DbController();
            int b = db.Update("ModifikoCmimeRecetatPerGrup", idGrupi, dsRecetat);

            return b;
        }

        public int ModifikoGrupCmiminZgjedhur(DataSet dsGrupet)
        {
            DbController db = new DbController();
            int b = db.Update("ModifikoGrupCmiminZgjedhur", dsGrupet);

            return b;
        }

        public int FshiGrupCmimi(int idGrupi)
        {
            DbController db = new DbController();
            int b = db.Delete("FshiGrupCmimi", idGrupi);

            return b;
        }

        #endregion

        #region Te Tjera
        public DataSet ArtikujtCmimetPerKategorine(int idKategoria)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqArtikujCmimePerKategori", idKategoria);
            
            
            return ds;
        }

        public DataSet ShfaqRecetatPerKategorine(int idKategoria)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqRecetatPerKategorine", idKategoria);
            ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
            ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
            ds.AcceptChanges();
            return ds;
        }
        #endregion

        #region Per Konfigurimin e cmimeve te recetave

        public DataSet ShfaqEkstratPerReceten(int idReceta)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqEkstratPerReceten", idReceta);
            return ds;

        }


        public DataSet LexoCmiminERecetes(int idReceta)
        {
            DbController db = new DbController();
            DataSet dsAll = db.Read("LexoCmimetPerReceten", idReceta);
            return dsAll;

        }

        public int KrijoCmimetPerReceten(int idReceta, DataSet dsCmimet)
        {
            //DbController db = new DbController();
            //int b = db.Update("CaktivizoCmiminEFunditPerReceten", idReceta);
            //if (b == 0)
            //{
            //    b = db.Create("KrijoCmimePerRecete", idReceta, dsCmimet);
            //}

            //varString = "KtheIdCmimiLast";
            //ds = db.Read(varString, idPeriudhaCmimi);

            //if (ds == null)
            //{
            //    return 1;
            //}

            //if (ds.Tables[0].Rows.Count == 0)
            //{
            //    return 1;
            //}

            //int idCmimi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_CMIMI"]);
            //DateTime dataFundi = Convert.ToDateTime(ds.Tables[0].Rows[0]["ORE_MBARIMI"]);
            //DateTime oraFundi = dataFundi.AddDays(1);
            //varString = "ModifikoOrenLast";

            //b = db.Update(varString, idCmimi, oraFundi);
            //return b;

            DbController db = new DbController();
            int b = 0;
            string varString = "ModifikoPeriudhaCmimiPerReceten";


            b = db.Update(varString, idReceta);

            if (b != 0)
            {
                return b;
            }

            varString = "KrijoPeriudhaCmimiPerReceten";

            DataSet ds = db.Read(varString, idReceta);

            if (ds == null)
            {
                return 1;
            }

            int idPeriudhaCmimi = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            DateTime oreFillimi;// = null;
            DateTime oreMbarimi;// = null;

            DateTime data = System.DateTime.Now;
            double cmimi = 0;


            int nr = dsCmimet.Tables[0].Rows.Count;

            varString = "KrijoCmimPerRecetat";
            for (int i = 0; i <= nr - 1; i++)
            {
                oreFillimi = Convert.ToDateTime(dsCmimet.Tables[0].Rows[i]["ORE_FILLIMI"]);
                oreMbarimi = Convert.ToDateTime(dsCmimet.Tables[0].Rows[i]["ORE_MBARIMI"]);
                cmimi = Convert.ToDouble(dsCmimet.Tables[0].Rows[i]["CMIMI"]);

                b = db.Create(varString, idPeriudhaCmimi, oreFillimi, oreMbarimi, cmimi);

                if (b != 0)
                {
                    return b;
                }

            }

            varString = "KtheIdCmimiLastReceta";
            ds = db.Read(varString, idPeriudhaCmimi);

            if (ds == null)
            {
                return 1;
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                return 1;
            }

            int idCmimi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_CMIMI"]);
            DateTime dataFundi = Convert.ToDateTime(ds.Tables[0].Rows[0]["ORE_MBARIMI"]);
            DateTime oraFundi = dataFundi.AddDays(1);
            varString = "ModifikoOrenLastReceta";

            b = db.Update(varString, idCmimi, oraFundi);
            return b;

        }
        #endregion
        #endregion

        #region Private methods
        /// <summary>
        /// true nqs recetes i eshte modifikuar permbajtja e artikujve
        /// false nqs recetes i eshte modifikuar vetem emri ose kategoria
        /// </summary>
        /// <param name="idReceta"></param>
        /// <param name="dsReceta"></param>
        /// <returns></returns>
        private bool KrahasoReceten(int idReceta, DataSet dsReceta)
        {
            DbController db = new DbController();
            string kushti = " WHERE dbo.RECETAT.ID_RECETA = " + idReceta;
            DataSet dsOriginal = db.Read("ShfaqRecetat", kushti);
            //nqs kane nr te ndryshem artikujsh atehere kthe true
            if (dsOriginal.Tables[0].Rows.Count != dsReceta.Tables[1].Rows.Count)
            {
                return true;
            }
            DataColumn[] celes = new DataColumn[1];
            celes[0] = dsOriginal.Tables[0].Columns["ID_ARTIKULLI"];
            dsOriginal.Tables[0].PrimaryKey = celes;
            foreach (DataRow dr in dsReceta.Tables[1].Rows)
            {
                int idArtikulli = Convert.ToInt32(dr["ID_ARTIKULLI"]);
                DataRow drSearch = dsOriginal.Tables[0].Rows.Find(idArtikulli);
                //nqs receta ndryshon nga te pakten nje artikull permbajtja e  saj ka ndryshuar
                if (drSearch == null)
                    return true;
                //nqs sasite jane te ndryshme permbajtja e recetes ka ndryshuar
                if (Convert.ToDouble(dr["SASIA"]) != Math.Round(Convert.ToDouble(drSearch["SASIA"]), 2))
                    return true;
            }
            return false;
        }
        #endregion
    }
}
