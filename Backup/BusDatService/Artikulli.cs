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
    public class Artikulli
    {
        #region Constructor
        #endregion

        #region Public methods

        #region Per konfigurimin e kategorive
        /// <summary>
        /// Kthen nje dataset me te gjitha kategorite e artikujve
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqKategoriteArtikuj()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteEArtikujve");
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
        /// Kthe kategorite e artikujve qe jane te dukshem ne menu
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqKategoriteArtikujPerMenu()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteEArtikujvePerMenu");
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
        /// Shton nje kategori artikulli me emrin qe merr si parameter
        /// </summary>
        /// <param name="emri"></param>
        /// <returns></returns>
        public int ShtoKategoriArtikulli(string emri, int statusi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteEArtikujvePerEmer", emri);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nqs ka nje kategori artikulli me kete emer nuk lejohet shtimi
                return 2;
            }
            else
            {
                int b = db.Create("ShtoKategoriArtikulli", statusi, emri);
                return b;
            }
        }

        /// <summary>
        /// Modifikon emrin e nje kategorie artikulli
        /// </summary>
        /// <param name="idKategoria"></param>
        /// <param name="emri"></param>
        /// <returns></returns>
        public int ModifikoKategoriArtikulli(int idKategoria, int statusi, string emri)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqKategoriteEArtikujvePerEmerPerjashtoId",idKategoria, emri);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nqs ka nje kategori artikulli me kete emer nuk lejohet modifikimi
                return 2;
            }
            else
            {
                int b = db.Update("ModifikoKategoriArtikulli",idKategoria , statusi, emri);
                return b;
            }
        }

        /// <summary>
        /// Fshin te gjitha kategorite e artikujve id e te cilave
        /// permbahen ne dataset
        /// </summary>
        /// <param name="dsId"></param>
        /// <returns></returns>
        public DataSet FshiKategoriArtikujsh(DataSet dsId)
        {
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("PERSHKRIMI", typeof(String));
            dsError.AcceptChanges();
            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_KATEGORIAARTIKULLI", typeof(Int32));
            dsToErase.AcceptChanges();
            DbController db = new DbController();
            DataSet dsKategoriteArtikujt = db.Read("ShfaqNumrinEArtikujvePerSecilenKategori");
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsKategoriteArtikujt.Tables[0].Columns["ID_KATEGORIAARTIKULLI"];
            dsKategoriteArtikujt.Tables[0].PrimaryKey = vektorPrimary;
            foreach (DataRow dr in dsId.Tables[0].Rows)
            {
                int idKategoria = Convert.ToInt32(dr["ID_KATEGORIAARTIKULLI"]);
                DataRow drSearch = dsKategoriteArtikujt.Tables[0].Rows.Find(idKategoria);
                //nqs nuk ka asnje artikull te lidhur me kategorine
                //kategoria mund te fshihet
                if (drSearch == null)
                {
                    DataRow r = dsToErase.Tables[0].NewRow();
                    r["ID_KATEGORIAARTIKULLI"] = dr["ID_KATEGORIAARTIKULLI"];
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
            int b = db.Delete("FshiKategoriteEArtikujve", dsToErase);
            //nqs veprimi ne database kryhet ne rregull
            if (b == 0)
                return dsError;
            //pnd kthejme null
            else
                return null;
        }
        #endregion

        #region Per konfigurimin e njesive matese
        /// <summary>
        /// Shfaq te gjitha njesite matese te regjistruara
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqNjesiteMatese()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqNjesiteMatese");
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
        /// Shton njesi te re matese
        /// </summary>
        /// <param name="emri"></param>
        /// <returns></returns>
        public int ShtoNjesiMatese(string emri)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqNjesitePerEmer", emri);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nqs ka nje njesi matese me kete emer nuk lejohet shtimi
                return 2;
            }
            else
            {
                int b = db.Create("ShtoNjesi", emri);
                return b;
            }
        }
        /// <summary>
        /// Ben modifikimin e njesise matese sipas parametrave
        /// </summary>
        /// <param name="idKategoria"></param>
        /// <param name="emri"></param>
        /// <returns></returns>
        public int ModifikoNjesiMatese(int idNjesia, string emri)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqNjesitePerEmerPerjashtoId", idNjesia, emri);
            if (ds.Tables[0].Rows.Count != 0)
            {
                //nqs ka nje njesi matese me kete emer nuk lejohet modifikimi
                return 2;
            }
            else
            {
                int b = db.Update("ModifikoNjesi", idNjesia, emri);
                return b;
            }
        }
        /// <summary>
        /// Fshin te gjitha njesite matese id e te cilave jane ne dataset
        /// </summary>
        /// <param name="dsId"></param>
        /// <returns></returns>
        public DataSet FshiNjesiMatese(DataSet dsId)
        {
            DataSet dsError = new DataSet();
            dsError.Tables.Add();
            dsError.Tables[0].Columns.Add("NJESIA", typeof(String));
            dsError.AcceptChanges();
            DataSet dsToErase = new DataSet();
            dsToErase.Tables.Add();
            dsToErase.Tables[0].Columns.Add("ID_NJESIA", typeof(Int32));
            dsToErase.AcceptChanges();
            DbController db = new DbController();
            DataSet dsKategoriteArtikujt = db.Read("ShfaqNumrinEArtikujvePerSecilenNjesi");
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsKategoriteArtikujt.Tables[0].Columns["ID_NJESIA"];
            dsKategoriteArtikujt.Tables[0].PrimaryKey = vektorPrimary;
            foreach (DataRow dr in dsId.Tables[0].Rows)
            {
                int idKategoria = Convert.ToInt32(dr["ID_NJESIA"]);
                DataRow drSearch = dsKategoriteArtikujt.Tables[0].Rows.Find(idKategoria);
                //nqs nuk ka asnje artikull te lidhur me njesine
                //njesia mund te fshihet
                if (drSearch == null)
                {
                    DataRow r = dsToErase.Tables[0].NewRow();
                    r["ID_NJESIA"] = dr["ID_NJESIA"];
                    dsToErase.Tables[0].Rows.Add(r);
                }
                //pnd raportohet se njesia nuk mund te fshihet
                else
                {
                    DataRow r = dsError.Tables[0].NewRow();
                    r["NJESIA"] = dr["NJESIA"];
                    dsError.Tables[0].Rows.Add(r);
                }
            }
            dsToErase.AcceptChanges();
            dsError.AcceptChanges();
            if (dsToErase.Tables[0].Rows.Count == 0)
            {
                return dsError;
            }
            int b = db.Delete("FshiNjesite", dsToErase);
            //nqs veprimi ne database kryhet ne rregull
            if (b == 0)
                return dsError;
            //pnd kthejme null
            else
                return null;
        }
        #endregion

        #region Konfigurimi dhe manipulimi i artikujve
        public int ModifikoKostoVilaX()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqArtikujt");

            int idArtikulli = 0;
            int b = 0;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                idArtikulli = Convert.ToInt32(dr[0]);
                b = db.Update("ModifikoKostoVilaX", idArtikulli);
            }

            return b;
        }
        public DataSet ShfaqArtikujtPerKategoriPerKonfigurimCmimesh(int idKategoria)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqArtikujtPerKategoriPerKonfigurimCmimesh", idKategoria);

            DataSet dsCmimet = new DataSet();
            dsCmimet.Tables.Add();

            dsCmimet.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            dsCmimet.Tables[0].Columns.Add("EMRI", typeof(string));
            dsCmimet.Tables[0].Columns.Add("CMIMI", typeof(string));
            
            dsCmimet.Tables[0].AcceptChanges();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = dsCmimet.Tables[0].NewRow();

                drNew["ID_ARTIKULLI"] = dr["ID_ARTIKULLI"];
                drNew["EMRI"] = dr["EMRI"];

                if (Convert.IsDBNull(dr["CMIMI"]) == false)
                {
                    drNew["CMIMI"] = Convert.ToDouble(dr["CMIMI"]).ToString();
                }
                else
                {
                    drNew["CMIMI"] = "Nuk dihet";
                }

                dsCmimet.Tables[0].Rows.Add(drNew);

            }

            dsCmimet.Tables[0].AcceptChanges();

            return dsCmimet;

        }

        public DataSet LexoTeDhenaPerArtikullin(string lloji, int idArtikulli)
        {
            try
            {
                DbController db = new DbController();
                DataSet ds = db.Read("LexoTeDhenaPerArtikullin", idArtikulli, lloji);
                int nr = ds.Tables[0].Rows.Count;
                if (ds != null && lloji == "R")
                {
                    DataSet dsCmimi = db.Read("LexoSasineMinimalePerReceten", idArtikulli);

                    double totali = Convert.ToDouble(dsCmimi.Tables[0].Rows[0]["NR"]);

                    ds.Tables[0].Columns.Add("NUMRI_TOTAL", typeof(float));
                    ds.Tables[0].Rows[0]["NUMRI_TOTAL"] = totali;

                }

                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message);
                return null;
            }
            
        }

        public DataSet ShfaqArtikujtPerBar(string kushti)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqArtikujtPerBar", kushti);
            return ds;
        }

        public DataSet ShfaqFavorite()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqFavorite");

            return ds;

        }

        public int HidhFavorite(DataSet dsFavorite)
        {
            DbController db = new DbController();

            int b = db.Delete("FshiFavorite");

            if (b != 0)
            {
                return 1;
            }

            if (dsFavorite.Tables[0].Rows.Count > 0)
            {
                b = db.Create("HidhFavorite", dsFavorite);
            }

            return b;
        }

        

        public int KrijoArtikull(int idKategoria, int idNjesia, int llojKonsumi,  string kodiArtikulli, string foto, double cmimi, double sasiaSkorte)
        {
            DataSet ds = null;
            int b = 0;

            DbController db = new DbController();
            ds = db.Read("KontrolloKodinPerKrijoArtikull", kodiArtikulli);

            if (ds == null)
            {
                return 1;
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                bool fshire = false;
                fshire = Convert.ToBoolean(ds.Tables[0].Rows[0]["DISPONUESHEM"]);
                if (fshire == false)
                {
                    int idArtikulliFshire = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_ARTIKULLI"]);

                    b = db.Update("AktivizoArtikull", idArtikulliFshire);

                    return b;
                }

                return 2;
            }

            ds  = db.Read("KrijoArtikull", idKategoria, idNjesia, llojKonsumi, kodiArtikulli, foto, cmimi, sasiaSkorte);
            if (ds == null)
            {
                return 1;
            }

            int celesi = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            if (foto != "")
            {
                int gjatesia = foto.Length;

                string prapashtesa = foto.Substring(gjatesia - 4, 4);
                string skedari = Convert.ToString(celesi).Trim();


                string pathiFoto = Application.StartupPath + "\\Foto\\Artikujt\\" + skedari + prapashtesa;

                File.Copy(foto, pathiFoto, true);

                b = db.Update("ModifikoPathiFotoArtikulli", celesi, pathiFoto);
            }

            ds = db.Read("KtheIdFurnitoriGeneral");

            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                return b;
            }

            int idFurnitori = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_FURNITORI"]);
            b = db.Create("KrijoLidhjeArikujFurnitor", idFurnitori, celesi);

            return b;

        }

        public int ModifikoArtikull(int idArtikulli, int idKategoria, int idNjesia, int llojKonsumi, string kodiArtikulli, string foto, double cmimi, double sasiaSkorte)
        {
            int b = 0;
            DataSet ds = null;
            DbController db = new DbController();

            ds = db.Read("KontrolloKodinPerModifikoArtikull", idArtikulli, kodiArtikulli);
            if (ds == null)
            {
                return 1;
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                return 2;
            }

            b = db.Update("ModifikoArtikull", idArtikulli, idKategoria, idNjesia, llojKonsumi, kodiArtikulli, foto, cmimi, sasiaSkorte);

            if (b != 0)
            {
                return b;
            }

            ds = db.Read("ShfaqCmimiArtikulli", idArtikulli);

            if (ds == null)
            {
                return 1;
            }

            int idCmimi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_CMIMI"]);
            double cmimiArtikulli = Convert.ToDouble(ds.Tables[0].Rows[0]["VLERA"]);
            DateTime dateFillimi = Convert.ToDateTime(ds.Tables[0].Rows[0]["DATE_FILLIMI"]);

            b = db.Update("ModifikoCmimiArtikulli", idCmimi);
            b = db.Create("KrijoCmimiArtikulli", idArtikulli, cmimi);


            return b;
            

        }

        public DataSet ShfaqArtikujt()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqArtikujt");

            if (ds == null)
                return null;

            DataSet dsNew = new DataSet();
            dsNew.Tables.Add();

            dsNew.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(int));
            dsNew.Tables[0].Columns.Add("EMRI", typeof(string));
            dsNew.Tables[0].Columns.Add("ID_KATEGORIAARTIKULLI", typeof(int));
            dsNew.Tables[0].Columns.Add("PERSHKRIMI", typeof(string));
            dsNew.Tables[0].Columns.Add("ARTIKULL_KONSUMI", typeof(bool));
            dsNew.Tables[0].Columns.Add("ID_NJESIA", typeof(int));
            dsNew.Tables[0].Columns.Add("NJESIA", typeof(string));
            dsNew.Tables[0].Columns.Add("CMIMI_SHITJE", typeof(double));
            dsNew.Tables[0].Columns.Add("NUMRI_TOTAL", typeof(double));
            dsNew.Tables[0].Columns.Add("SASIA_SKORTE", typeof(double));
            dsNew.Tables[0].Columns.Add("FOTO", typeof(Image));
            dsNew.Tables[0].Columns.Add("CHECHKED", typeof(bool));
            dsNew.Tables[0].Columns.Add("DISPONUESHEM", typeof(bool));

            dsNew.Tables[0].AcceptChanges();

            int idArtikulli = 0;
            string emri = "";
            int idKategoria = 0;
            string kodiKategoria = "";
            bool konsumi = false;
            int idNjesia = 0;
            string njesia = "";
            double cmimi = 0;
            double totali = 0;
            double sasiaSkorte = 0;
            string pathiFoto = "";
            bool disponueshemn = false;
            Image foto = null;

            DataRow drNew = null;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                drNew = dsNew.Tables[0].NewRow();

                idArtikulli = Convert.ToInt32(dr["ID_ARTIKULLI"]);
                emri = Convert.ToString(dr["EMRI"]);
                idKategoria = Convert.ToInt32(dr["ID_KATEGORIAARTIKULLI"]);
                kodiKategoria = Convert.ToString(dr["PERSHKRIMI"]);
                konsumi = Convert.ToBoolean(dr["ARTIKULL_KONSUMI"]);
                idNjesia = Convert.ToInt32(dr["ID_NJESIA"]);
                njesia = Convert.ToString(dr["NJESIA"]);
                totali = Convert.ToDouble(dr["NUMRI_TOTAL"]);
                sasiaSkorte = Convert.ToDouble(dr["SASIA_SKORTE"]);
                pathiFoto = Convert.ToString(dr["FOTO"]);
                disponueshemn = Convert.ToBoolean(dr["DISPONUESHEM"]);

                //if (pathiFoto == "")
                //{
                //    foto = null;
                //}
                //else
                //{
                //    foto = Image.FromFile(pathiFoto);
                //}

                drNew["ID_ARTIKULLI"] = idArtikulli;
                drNew["EMRI"] = emri;
                drNew["ID_KATEGORIAARTIKULLI"] = idKategoria;
                drNew["PERSHKRIMI"] = kodiKategoria;
                drNew["ARTIKULL_KONSUMI"] = konsumi;
                drNew["ID_NJESIA"] = idNjesia;
                drNew["NJESIA"] = njesia;
                drNew["NUMRI_TOTAL"] = totali;
                drNew["SASIA_SKORTE"] = sasiaSkorte;
                drNew["FOTO"] = foto;
                drNew["CHECHKED"] = false;
                drNew["DISPONUESHEM"] = disponueshemn;


                dsNew.Tables[0].Rows.Add(drNew);

                
            }

            dsNew.Tables[0].AcceptChanges();



            
           

            return dsNew;
        }

        public DataSet ShfaqTeDhenaPerArtikullin(int idArtikulli)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqTeDhenaPerArtikullin", idArtikulli);

            return ds;
        }

        public int CaktivizoArtikujt(DataSet dsHiq)
        {
            DbController db = new DbController();
            int b = 0;

            b = db.Update("CaktivizoArtikujt", dsHiq);

            return b;


        }

        public int AktivizoArtikujt(DataSet dsShto)
        {
            DbController db = new DbController();
            int b = 0;

            b = db.Update("AktivizoArtikujt", dsShto);

            return b;
        }

        public DataSet FshiArtikujt(DataSet dsFshi)
        {
            DataSet ds = null;
            DbController db = new DbController();

            DataSet dsPastro = new DataSet();
            dsPastro.Tables.Add();
            dsPastro.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            dsPastro.Tables[0].AcceptChanges();

            dsPastro.AcceptChanges();

            DataSet dsKthe = new DataSet();

            dsKthe.Tables.Add();
            dsKthe.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            dsKthe.Tables[0].Columns.Add("EMRI", typeof(string));
            dsKthe.Tables[0].Columns.Add("OFERTAT", typeof(bool));
            dsKthe.Tables[0].Columns.Add("RECETAT", typeof(bool));

            dsKthe.AcceptChanges();
            int idArtikulli = 0;
            string emri = "";
            int nr = 0;

            foreach (DataRow dr in dsFshi.Tables[0].Rows)
            {
                DataRow drKthe = dsKthe.Tables[0].NewRow();
                DataRow drPastro = dsPastro.Tables[0].NewRow();

                emri = Convert.ToString(dr["EMRI"]);
                idArtikulli = Convert.ToInt32(dr["ID_ARTIKULLI"]);

                ds = db.Read("KtheReferencaArtikulli", idArtikulli);



                if (ds.Tables[0].Rows.Count == 0)
                {
                    drKthe["RECETAT"] = false;
                }
                else
                {
                    drKthe["RECETAT"] = true;
                    nr = nr + 1;
                }

                drKthe["EMRI"] = emri;
                drKthe["ID_ARTIKULLI"] = idArtikulli;
                drPastro["ID_ARTIKULLI"] = idArtikulli;

                if (nr > 0)
                {
                    dsKthe.Tables[0].Rows.Add(drKthe);
                }
                else
                {
                    dsPastro.Tables[0].Rows.Add(drPastro);

                }


            }

            dsKthe.Tables[0].AcceptChanges();
            dsPastro.Tables[0].AcceptChanges();

            if (dsPastro.Tables[0].Rows.Count > 0)
            {
                int b = db.Delete("FshiArtikujt", dsPastro);

                if (b == 1)
                {
                    return null;
                }
            }

            return dsKthe;

                
       }

        public DataSet ShfaqArtikujtSipasZgjedhjesPerSkorte(int zgjedhja, int idKategoria, string artikulli)
        {
            DbController db = new DbController();
            DataSet ds = null;

            ds = db.Read("dbShfaqArtikujtSipasZgjedhjesPerSkorte", zgjedhja, idKategoria, artikulli);
            return ds;


        }

            



        #endregion

        #region Konfigurimi dhe manipulimi i cmimeve

        public DataSet ShfaqCmimetPerArtikullin(int idArtikulli)
        {
            DbController db = new DbController();
            DataSet ds = null;

            string varString = "dbShfaqCmimetPerArtikullin";

            ds = db.Read(varString, idArtikulli);

            return ds;

        }

        public int KrijoCmimetPerArtikullin(int idArtikulli, DataSet dsCmimet)
        {
            DbController db = new DbController();
            int b = 0;
            string varString = "ModifikoPeriudhaCmimiPerArtikullin";


            b = db.Update(varString, idArtikulli);

            if (b != 0)
            {
                return b;
            }

            varString = "KrijoPeriudhaCmimiPerArtikullin";

            DataSet ds = db.Read(varString, idArtikulli);

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

            varString = "KrijoCmimPerArtikullin";
            for (int i = 0; i <= nr-1; i++)
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

            varString = "KtheIdCmimiLast";
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
            varString = "ModifikoOrenLast";

            b = db.Update(varString, idCmimi, oraFundi);
            return b;

        }

        public DataSet ShfaqCmimetEfunditPerArtikullin(int idArtikulli)
        {
            DataSet ds = null;
            DbController db = new DbController();
            string varString = "dbShfaqCmimetEfunditPerArtikullin";
            ds = db.Read(varString, idArtikulli);

            return ds;
        }

        #endregion

        #region Të tjera
        /// <summary>
        /// Kthen nje dataset me te gjithe artikujt te nje kategorie
        /// pavarsisht nqs jane te disponueshem apo jo
        /// </summary>
        /// <param name="idKategoria"></param>
        /// <returns></returns>
        public DataSet ArtikujtPerKategori(int idKategoria)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqArtikujPerKategori", idKategoria);
            return ds;
        }

        /// <summary>
        /// Kthen nje dataset me te gjithe artikujt qe kane te njejten kategori me 
        /// artikullin me id sa idArtikulli
        /// </summary>
        /// <param name="idArtikulli"></param>
        /// <returns></returns>
        public DataSet ArtikujtKategoriNjejte(int idArtikulli)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqArtikujtMeTeNjejtenKategori", idArtikulli);
            return ds;
        }

        /// <summary>
        /// Shfaq te gjithe artikujt qe i perkasin nje kategorie te caktuar
        /// dhe qe jane ne perkatesi te nje furnitori te caktuar
        /// </summary>
        /// <param name="idKategoria"></param>
        /// <param name="idFurnitori"></param>
        /// <returns></returns>
        public DataSet ArtikujtPerKategoriFurnitor(int idKategoria, int idFurnitori)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqArtikujPerKategoriFurnitor", idKategoria, idFurnitori);
            return ds;
        }

        public DataSet ShfaqArtikujtSipasKategorive()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqArtikujtSipasKategorive");
            return ds;
        }

        #endregion

        #endregion

        #region Private methods
        #endregion
    }
}
