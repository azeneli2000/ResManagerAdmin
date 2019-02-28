using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;

namespace ResManagerAdmin.BusDatService
{
    public class DbController
    {
        #region Constructor
        #endregion

        #region Read
        public DataSet Read(string CRUD)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "ShfaqKategoriteERecetavePerMenu":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteERecetavePerMenu");
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheMaksIdGrupCmimi":
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheMaksIdGrupCmimi");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqGrupCmimet":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqGrupCmimet");
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheKamarieretLoguar" :
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheKamarieretLoguar");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqOfertatPerHotelin" :
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqOfertatPerHotelin");
                    ds = dbmanObject.GetData("R");
                    break;


                case "ShfaqOfertatPerBarin" :
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqOfertatPerBarin");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqShpenzimetMujore" :
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqShpenzimetMujore");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriShpenzimeshMujore" :
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriShpenzimeshMujore");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKamarieretPerKombo":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKamarieretPerKombo");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTavolinatPerKombo":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTavolinatPerKombo");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqFaturatPerSot":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqFaturatPerSot");
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheIdFurnitoriGeneral":
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheIdFurnitoriGeneral");
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheNrFaturaLast":
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheNrFaturaLast");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqFavorite":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqFavorite");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqRecetatSipasKategorive":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRecetatSipasKategorive");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqRecetatSipasKategorivePerFavorite":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRecetatSipasKategorivePerFavorite");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqArtikujtSipasKategorive" :
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujtSipasKategorive");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqArtikujt" :
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujt");
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheNumerAdministratoresh" :
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheNumerAdministratoresh");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqRolet":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRolet");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteETavolinave":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteETavolinave");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTavolinatDetaje":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTavolinatDetaje");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTavolinenMeNumerMeTeMadh":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTavolinenMeNumerMeTeMadh");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteEArtikujve":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteEArtikujve");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteEArtikujvePerMenu":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteEArtikujvePerMenu");
                    ds = dbmanObject.GetData("R");
                    break;


                case "ShfaqNumrinEArtikujvePerSecilenKategori":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNumrinEArtikujvePerSecilenKategori");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqNumrinETavolinavePerSecilenKategori":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNumrinETavolinavePerSecilenKategori");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteERecetave":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteERecetave");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqNumrinERecetavePerSecilenKategori":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNumrinERecetavePerSecilenKategori");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteEShpenzimeve":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteEShpenzimeve");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqNumrinEShpenzimevePerSecilenKategori":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNumrinEShpenzimevePerSecilenKategori");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqNjesiteMatese":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNjesiteMatese");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqNumrinEArtikujvePerSecilenNjesi":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNumrinEArtikujvePerSecilenNjesi");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqFormatEPageses":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqFormatEPageses");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqNumrinEFaturavePerSecilenFormePagese":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNumrinEFaturavePerSecilenFormePagese");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqNumrinEfaturavePerSecilinKlient" :
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNumrinEfaturavePerSecilinKlient");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqNumrinEBlerjevePerSecilinFurnitor":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNumrinEBlerjevePerSecilinFurnitor");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqPerdoruesitJoKamariere":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqPerdoruesitJoKamariere");
                    ds = dbmanObject.GetData("R");
                    break;

                case "RezervimetESkaduara":
                    dbmanObject.strSql = dbmapObject.GetQuery("RezervimetESkaduara");
                    ds = dbmanObject.GetData("R");
                    break;

                case "GjejTavolinatERezervuara":
                    dbmanObject.strSql = dbmapObject.GetQuery("GjejTavolinatERezervuara");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqPerdoruesitKamariere":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqPerdoruesitKamariere");
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoIntervaletCmime":
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoIntervaletCmime");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ArtikujtDheRecetatCmimeIntervale":
                    dbmanObject.strSql = dbmapObject.GetQuery("ArtikujtDheRecetatCmimeIntervale");
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqCmimetShitjeKorrenteRecetat":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqCmimetShitjeKorrenteRecetat");
                    ds = dbmanObject.GetData("R");
                    break;



                   
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "ShfaqTavolinatMeEmer":
                    //varString1 --> emri
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTavolinatMeEmer", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTurnetSipasKerkimit":
                    //varString1 --> query
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTurnetSipasKerkimit", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KontrolloKodinGrupCmimiPerInsert":
                    //varString1 --> emri i grupit te cmimit
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKodinGrupCmimiPerInsert", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KontrolloKodinPerOferte":
                    //varString1 --> emri i ofertes 
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKodinPerOferte", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqShpenzimetMujoreSipasKerkimit":
                    //varString1 --> query 
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqShpenzimetMujoreSipasKerkimit", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KontrolloKategoriShpenzimMujor":
                    //varString1 --> emri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKategoriShpenzimMujor", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheFaturatSipasKerkimit":
                    //varString1 --> query 

                    dbmanObject.strSql = dbmapObject.GetQuery("KtheFaturatSipasKerkimit", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "GjejKostoArtikujshPerFature":
                    //varString1 --> query 

                    dbmanObject.strSql = dbmapObject.GetQuery("GjejKostoArtikujshPerFature", varString1);
                    ds = dbmanObject.GetData("R");
                    break;


                case "ShfaqArtikujtPerBar":
                    //varString1 --> query 

                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujtPerBar", varString1);
                    ds = dbmanObject.GetData("R");
                    break;


                case "KontrolloKodinPerKrijoArtikull":
                    //varString1 --> kodi i artikullit

                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKodinPerKrijoArtikull", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KontrolloKodiPerKrijoPersonelFjalekalimi":
                    //varString1 --> fjalekalimi i  personelit
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKodiPerKrijoPersonelFjalekalimi", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KontrolloKodiPerKrijoPersonel":
                    //varString1 --> emri i  personelit
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKodiPerKrijoPersonel", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriTavolinePerEmer":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriTavolinePerEmer", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteEArtikujvePerEmer":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteEArtikujvePerEmer", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteERecetavePerEmer":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteERecetavePerEmer", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteEShpenzimevePerEmer":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteEShpenzimevePerEmer", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqNjesitePerEmer":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNjesitePerEmer", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqFormaPagesePerEmer":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqFormaPagesePerEmer", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKlientet":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKlientet", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqFurnitoret":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqFurnitoret", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqShpenzimet":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqShpenzimet", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTurnet":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTurnet", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqBlerjet":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqBlerjet", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqArtikujtPerFurnitoret":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujtPerFurnitoret", varString1);
                    ds = dbmanObject.GetData("R");
                    break; 

                case "ShfaqRecetat":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRecetat", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "XhirojaPerSecilenDate":
                    dbmanObject.strSql = dbmapObject.GetQuery("XhirojaPerSecilenDate", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqXhiroSipasFaturavePerDaten":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqXhiroSipasFaturavePerDaten", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "XhirojaPerSecilenDateSipasArtikujve":
                    dbmanObject.strSql = dbmapObject.GetQuery("XhirojaPerSecilenDateSipasArtikujve", varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "XhirojaPerSecilenDateSipasRecetave":
                    dbmanObject.strSql = dbmapObject.GetQuery("XhirojaPerSecilenDateSipasRecetave", varString1);
                    ds = dbmanObject.GetData("R");
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "ShfaqTavolinatMeEmerPerjashtoId":
                    //varInt1 --> emri
                    //varInt2 -->idTavolina
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTavolinatMeEmerPerjashtoId", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KontrolloKodinGrupCmimiPerModifikim":
                    //varInt1 --> idGrupi
                    //varString1 --> emri
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKodinGrupCmimiPerModifikim", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KontrolloEmrinOfertaPerModifikim":
                    //varInt1 --> idOferta
                    //varString1 --> emri
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloEmrinOfertaPerModifikim", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "VerifikoFjalekalimin":
                    //varInt1 --> idPerdoruesi
                    //varString1 --> fjalekalimi
                    dbmanObject.strSql = dbmapObject.GetQuery("VerifikoFjalekalimin", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoTeDhenaPerArtikullin" :
                    //varInt1 --> idArtikulli
                    //varString1 --> lloji i artikullit
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoTeDhenaPerArtikullin" , varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KontrolloKodinPerModifikoArtikull" :
                    //varInt1 --> idArtikulli
                    //varString1 --> emri i artikullit
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKodinPerModifikoArtikull" , varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KontrolloKodiPerModifikoPersonelFjalekalimi":
                    //varInt1 --> idPersoneli
                    //varString1 --> emri i perdoruesit 
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKodiPerModifikoPersonelFjalekalimi", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;
               
                case "KontrolloKodiPerModifikoPersonel":
                    //varInt1 --> idPersoneli
                    //varString1 --> emri i perdoruesit 
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloKodiPerModifikoPersonel", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;
               
                case "ShfaqKategoriTavolinePerEmerPerjashtoId":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriTavolinePerEmerPerjashtoId", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteEArtikujvePerEmerPerjashtoId":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteEArtikujvePerEmerPerjashtoId", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteERecetavePerEmerPerjashtoId":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteERecetavePerEmerPerjashtoId", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteEShpenzimeveMujorePerEmerPerjashtoId":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteEShpenzimeveMujorePerEmerPerjashtoId", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqKategoriteEShpenzimevePerEmerPerjashtoId":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqKategoriteEShpenzimevePerEmerPerjashtoId", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;


                case "ShfaqNjesitePerEmerPerjashtoId":
                    //varInt1 --> idNjesia
                    //varString1 --> emri i ri i njesise
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqNjesitePerEmerPerjashtoId", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqFormePagesePerEmerPerjashtoId":
                    //varInt1 --> idFormaPagesa
                    //varString1 --> emri i formes se pagese
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqFormePagesePerEmerPerjashtoId", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KontrolloBlerjeSipasFurnitoritDheFatures":
                    //varInt1 --> idFurnitori
                    //varString1 --> numri i fatures
                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloBlerjeSipasFurnitoritDheFatures", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShtoRecete":
                    //varInt1 --> idKategoriaReceta
                    //varString1 --> emri i recetes
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoRecete", varInt1, varString1);
                    ds = dbmanObject.GetData("R");
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, int varInt2, int varInt3, string varString1, string varString2, double varDouble1, double varDouble2)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "KrijoArtikull":
                    //varInt1 --> idKategoria
                    //varInt2 --> idNjesia
                    //varInt3 --> lloji i konsumit
                    //varString1 --> kodi i artikullit
                    //varString2 --> pathi i fotos
                    //varDouble1 --> cmimi
                    //varDouble2 --> sasiaSkorte

                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoArtikull", varInt1, varInt2, varInt3, varString1, varString2, varDouble1, varDouble2);
                    ds = dbmanObject.GetData("R");
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, int varInt2, int varInt3)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "KontrolloShpenzimMujor":
                    //varInt1 --> idKategoria
                    //varInt2 --> muaji
                    //varInt3 --> viti

                    dbmanObject.strSql = dbmapObject.GetQuery("KontrolloShpenzimMujor", varInt1, varInt2, varInt3);
                    ds = dbmanObject.GetData("R");

                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, int varInt2, int varInt3, Decimal varDecimal1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "LidhFatureOferte":
                    //varInt1 --> idFatura
                    //varInt2 --> idOferta
                    //varInt3 --> indeksi
                    //varDecimal1 --> cmimi

                    dbmanObject.strSql = dbmapObject.GetQuery("LidhFatureOferte", varInt1, varInt2, varInt3, varDecimal1);
                    ds = dbmanObject.GetData("R");

                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, int varInt2, int varInt3, int varInt4)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "ShfaqShpenzimeMujorePerPeriudhen":
                    //varInt1 --> viti i  fiilimit
                    //varInt2 --> muaji i fillimit
                    //varInt3 --> viti i mbarimit
                    //varInt4 --> muaji i mbarimit

                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqShpenzimeMujorePerPeriudhen", varInt1, varInt2, varInt3, varInt4);
                    ds = dbmanObject.GetData("R");

                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, string varString1, string varString2, int varInt1, decimal varDecimal1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "KrijoOferte" :

                    // varString1 --> emri i ofertes
                    // varString2 --> tipi i ofertes
                    // varInt1 --> numri i shportave
                    // varDecimal1 --> cmimi

                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoOferte", varString1, varString2, varInt1, varDecimal1);
                    ds = dbmanObject.GetData("R");

                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }


        public DataSet Read(string CRUD, int varInt1, int varInt2, int varInt3, int varInt4, double varDouble1, double varDouble2, string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "KrijoFature":
                    //varInt1 --> celesi i kamarierit
                    //varInt2 --> idTavolina
                    //varInt3 --> idKlienti
                    //varInt4 --> idFormaPagesa
                    //varDouble1 --> totali
                    //varDouble2 --> skonto
                    //varString1 --> nrFatura

                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoFature", varInt1, varInt2, varInt3, varInt4, varDouble1, varDouble2, varString1);
                    ds = dbmanObject.GetData("R");

                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "ShfaqEkstratPerReceten":
                    //varInt1 --> idReceta
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqEkstratPerReceten", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqFaturatKorentePerTavoline":
                    //varInt1 --> idTavolina
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqFaturatKorentePerTavoline", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheIdRoli":
                    //varInt1 --> idPersoneli
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheIdRoli", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqCmimeRecetatPerGrupinZgjedhur":
                    //varInt1 --> idGrupcmimi
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqCmimeRecetatPerGrupinZgjedhur", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheTurninLast":
                    //varInt1 --> idTurni
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheTurninLast", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoBlerjeArtikujshPerKonsumPerOfertat":
                    //varInt1 --> idFatura
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoBlerjeArtikujshPerKonsumPerOfertat", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheArtikujtSasitePerOfertat":
                    //varInt1 --> idFatura
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheArtikujtSasitePerOfertat", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTeDhenaPerOferten" :
                    //varInt1 --> idOferta
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTeDhenaPerOferten", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqRecetatPerKategoriOferte" :
                    //varInt1 --> idKategoriaRecete
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRecetatPerKategoriOferte", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;


                case "KtheTeDhenaPerFaturenPc":
                    //varInt1 --> idFatura
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheTeDhenaPerFaturenPc", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheRecetatPerPrintoPC":
                    //varInt1 --> idFatura
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheRecetatPerPrintoPC", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqShpenzimetVitin":
                    //varInt1 --> viti
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqShpenzimetVitin", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqShpenzimetMujorePerVitin":
                    //varInt1 --> viti
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqShpenzimetMujorePerVitin", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqBlerjetPerVitin":
                    //varInt1 --> viti
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqBlerjetPerVitin", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqXhiroPerVitin":
                    //varInt1 --> viti
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqXhiroPerVitin", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTeDhenaPerFaturen":
                    //varInt1 --> idFatura
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTeDhenaPerFaturen", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheTurninKorent":
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheTurninKorent", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

               

                case "ShfaqRecetatPerKategoriKonfigurimCmimesh":
                    //varInt1 --> idKategoriaReceta
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRecetatPerKategoriKonfigurimCmimesh", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqArtikujtPerKategoriPerKonfigurimCmimesh":
                    //varInt1 --> idKategoriaArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujtPerKategoriPerKonfigurimCmimesh", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoSasineMinimalePerReceten":
                    //varInt1 --> idReceta
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoSasineMinimalePerReceten", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoBlerjeArtikujshPerKonsumPerRecetatPerAnullim":
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoBlerjeArtikujshPerKonsumPerRecetatPerAnullim", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;


                case "LexoBlerjeArtikujshPerKonsumPerRecetat":
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoBlerjeArtikujshPerKonsumPerRecetat", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoBlerjeArtikujshPerKonsum":
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoBlerjeArtikujshPerKonsum", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheArtikujtSasitePerRecetat":
                    //varInt1 --> idFatura
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheArtikujtSasitePerRecetat", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheIdCmimiLastReceta":
                    //varInt1 --> idPeriudhaCmimi
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheIdCmimiLastReceta", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheIdCmimiLast":
                    //varInt1 --> idPeriudhaCmimi
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheIdCmimiLast", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoTeDhenaPerArtikullin":
                    //varInt1 --> idArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoTeDhenaPerArtikullin", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "dbShfaqCmimetEfunditPerArtikullin":
                    //varInt1 --> idArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqCmimetEfunditPerArtikullin", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KrijoPeriudhaCmimiPerReceten":
                    //varInt1 --> idReceta
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoPeriudhaCmimiPerReceten", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KrijoPeriudhaCmimiPerArtikullin":
                    //varInt1 --> idArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoPeriudhaCmimiPerArtikullin", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "dbShfaqCmimetPerArtikullin":
                    //varInt1 --> idArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqCmimetPerArtikullin", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheReferencaArtikulli" :
                    //varInt1 --> idArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheReferencaArtikulli", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqCmimiArtikulli":
                    //varInt1 --> idPersoneli
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqCmimiArtikulli", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTeDhenaPerArtikullin" :
                    //varInt1 --> idPersoneli
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTeDhenaPerArtikullin" , varInt1);
                    ds = dbmanObject.GetData("R");
                    break;


                case "KtheFotoPersoneli":
                    //varInt1 --> idPersoneli
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheFotoPersoneli", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTeDhenaPerPersonelinZgjedhur" :
                    //varInt1 --> idPersoneli
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTeDhenaPerPersonelinZgjedhur" , varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTavolinatPerKategori":
                    //varInt1 --> idKategoria
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTavolinatPerKategori", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;


                case "ShfaqTeDhenaRezervimi":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTeDhenaRezervimi", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                
                case "ShfaqArtikujPerKategori":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujPerKategori", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqArtikujtMeTeNjejtenKategori":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujtMeTeNjejtenKategori", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "SasitePerkateseTeArtikujvePerBlerjen":
                    dbmanObject.strSql = dbmapObject.GetQuery("SasitePerkateseTeArtikujvePerBlerjen", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "NumriTotalArtikujtNeBlerje":
                    dbmanObject.strSql = dbmapObject.GetQuery("NumriTotalArtikujtNeBlerje", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqArtikujCmimePerKategori":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujCmimePerKategori", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqRecetatPerKategorine":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRecetatPerKategorine", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoCmimetPerReceten":
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoCmimetPerReceten", varInt1);
                    ds = dbmanObject.GetData("R");
                    break;
                
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        
        public DataSet Read(string CRUD, DateTime varDate1, DateTime varDate2)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {

                case "ShfaqShpenzimetDitorePerPeriudhen":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqShpenzimetDitorePerPeriudhen", varDate1, varDate2);
                    ds = dbmanObject.GetData("R");
                    break;


                case "ShfaqniFitiminPerPeriudhen":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqniFitiminPerPeriudhen", varDate1, varDate2);
                    ds = dbmanObject.GetData("R");
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, DateTime varDate1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {

                case "KtheXhironPerTurnin":
                    //varInt1 --> idKamarieri
                    //varDate1 --> ore fillimi
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheXhironPerTurnin", varInt1, varDate1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoXhironPerKamarierin":
                    //varInt1 --> idKamarieri
                    //varDate1 --> ore fillimi
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoXhironPerKamarierin", varInt1, varDate1);
                    ds = dbmanObject.GetData("R");
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }


        public DataSet Read(string CRUD, int varInt1, DateTime varDate1, DateTime varDate2)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "LexoTurninPerKamarierin":
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoTurninPerKamarierin", varInt1, varDate1, varDate2);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTurnetPerKamarierPerPeriudhen":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTurnetPerKamarierPerPeriudhen", varInt1, varDate1, varDate2);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqTavolinatEliraPerKategori":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTavolinatEliraPerKategori", varInt1, varDate1, varDate2);
                    ds = dbmanObject.GetData("R");
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, int varInt2)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
 

                case "ShfaqArtikujPerKategoriFurnitor":
                    //varInt1 --> idKategoria
                    //varInt2 -->idFurnitori
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujPerKategoriFurnitor", varInt1, varInt2);
                    ds = dbmanObject.GetData("R");
                    break;

                case "GjejNjeCmimMePare":
                    //varInt1 --> idArtikulli
                    //varInt2 -->idBlerjeArtikuj
                    dbmanObject.strSql = dbmapObject.GetQuery("GjejNjeCmimMePare", varInt1, varInt2);
                    ds = dbmanObject.GetData("R");
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, int varInt2, DateTime varDate1, DateTime varDate2)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "ShfaqTavolinatEliraPerKategori":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqTavolinatEliraPerKategori", varInt1, varInt2, varDate1, varDate2);
                    ds = dbmanObject.GetData("R");
                    break;

                case "XhirojaPerSecilenDateSipasRecetave":
                    //varInt1 --> idKatReceta
                    //varInt2 --> idReceta
                    //varDate1 --> dateFillimi
                    //varDate2 --> dateMbarimi
                    dbmanObject.strSql = dbmapObject.GetQuery("XhirojaPerSecilenDateSipasRecetave", varInt1, varInt2, varDate1, varDate2);
                    ds = dbmanObject.GetData("R");
                    break;


                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, int varInt2, string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "ShfaqPersonelinSipasZgjedhjes":
                    //varInt1 --> koeficenti i zgjedhjes
                    //varInt2 --> roli i personelit
                    //varString1 --> emri i personelit

                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqPersonelinSipasZgjedhjes", varInt1, varInt2, varString1);
                    ds = dbmanObject.GetData("R");
                    break;


                case "dbShfaqArtikujtSipasZgjedhjesPerSkorte":
                    //varInt1 --> koeficenti i zgjedhjes
                    //varInt2 --> celesi i kategorise
                    //varString1 --> emri i artikullit

                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujtSipasZgjedhjesPerSkorte", varInt1, varInt2, varString1);
                    ds = dbmanObject.GetData("R");
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, string varString1, string varString2)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "GjejPerdorues":
                    //varString1 --> perdoruesi
                    //varString2 --> fjalekalimi
                    dbmanObject.strSql = dbmapObject.GetQuery("GjejPerdorues", varString1, varString2);
                    ds = dbmanObject.GetData("R");
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, DateTime varDate1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "ShfaqFaturatPerDatenZgjedhur":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqFaturatPerDatenZgjedhur", varDate1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShpenzimetPerDaten":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShpenzimetPerDaten", varDate1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqRezervimetTavolina":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqRezervimetTavolina", varDate1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "ShfaqGjendjeArka":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqGjendjeArka",varDate1);
                    ds = dbmanObject.GetData("R");
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, string varString1, string varString2, string varString3,
          string varString4, string varString5, string varString6, string varString7, string varString8)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "KrijoPerdorues":
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoPerdorues", varInt1, varString1, varString2,
                        varString3, varString4, varString5, varString6, varString7, varString8);
                    ds = dbmanObject.GetData("R");

                    // varInt1 sherben si roli i personelit
                    // varString1 sherben si emer
                    // varString2 sherben si mbiemer
                    // varString3 sherben si emaili
                    // varString4 sherben si telefoni
                    // varString5 sherben si adresa
                    // varString6 sherben si perdoruesi
                    // varString7 sherben si fjalekalimi
                    // varString8 sherben si foto
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int varInt1, string varString1, string varString2, string varString3,
                 string varString4, string varString5, string varString6, string varString7, string varString8, Image varImazh)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "KrijoPerdorues":
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoPerdorues", varInt1, varString1, varString2,
                        varString3, varString4, varString5, varString6, varString7, varString8, varImazh);
                    ds = dbmanObject.GetData("R");

                    // varInt1 sherben si roli i personelit
                    // varString1 sherben si emer
                    // varString2 sherben si mbiemer
                    // varString3 sherben si emaili
                    // varString4 sherben si telefoni
                    // varString5 sherben si adresa
                    // varString6 sherben si perdoruesi
                    // varString7 sherben si fjalekalimi
                    //varString8 --> pathi i fotos
                    // varImazh sherben si foto
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, int[] varArrayInt1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "LexoTeDhenaPerTavolinen":
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoTeDhenaPerTavolinen", varArrayInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoOfertatPerTavolinen":
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoOfertatPerTavolinen", varArrayInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                case "LexoRecetatPerOfertatTavoline":
                    dbmanObject.strSql = dbmapObject.GetQuery("LexoRecetatPerOfertatTavoline", varArrayInt1);
                    ds = dbmanObject.GetData("R");
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet Read(string CRUD, DataSet dsId)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "ShfaqArtikujtPerKostoBlerje":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShfaqArtikujtPerKostoBlerje", dsId);
                    ds = dbmanObject.GetData("R");
                    break;

                case "KtheKufirinPerRecetat":
                    dbmanObject.strSql = dbmapObject.GetQuery("KtheKufirinPerRecetat", dsId);
                    ds = dbmanObject.GetData("R");
                    break;

                case "SasitePerkateseTeArtikujvePerBlerjen":
                    dbmanObject.strSql = dbmapObject.GetQuery("SasitePerkateseTeArtikujvePerBlerjen", dsId);
                    ds = dbmanObject.GetData("R");
                   break;

               case "NumriTotalArtikujtNeBlerje":
                   dbmanObject.strSql = dbmapObject.GetQuery("NumriTotalArtikujtNeBlerje", dsId);
                   ds = dbmanObject.GetData("R");
                   break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }
        

        #endregion

        #region Create
        public int Create(string CRUD, string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ShtoKategoriTavolinash":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoKategoriTavolinash", varString1);
                    b = dbmanObject.GetData();
                    break;
                case "ShtoKategoriArtikulli":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoKategoriArtikulli", varString1);
                    b = dbmanObject.GetData();
                    break;
                case "ShtoKategoriRecete":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoKategoriRecete", varString1);
                    b = dbmanObject.GetData();
                    break;
                case "ShtoKategoriShpenzimi":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoKategoriShpenzimi", varString1);
                    b = dbmanObject.GetData();
                    break;
                case "ShtoNjesi":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoNjesi", varString1);
                    b = dbmanObject.GetData();
                    break;
                case "KrijoBackUp":
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoBackUp", varString1);
                    b = dbmanObject.GetData();
                    break;
                case "KarikoBackUp":
                    dbmanObject.strSql = dbmapObject.GetQuery("KarikoBackUp", varString1);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, string varString1, double varDouble1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
             
                case "ShtoFormePagese":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoFormePagese", varString1, varDouble1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, int varInt1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {

                case "MerrTurnKamarieri":
                    //varInt1 --> idPerdoruesi
                    dbmanObject.strSql = dbmapObject.GetQuery("MerrTurnKamarieri", varInt1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, DataSet varDs)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {

                case "HidhFavorite":
                    //varDs --> ketu ruhen te dhena per artikujt e preferuar
                    dbmanObject.strSql = dbmapObject.GetQuery("HidhFavorite", varDs);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, int varInt1, string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b = 0;
            switch (CRUD)
            {
                case "ShtoKategoriArtikulli":
                    //varInt1 --> {0, 1} per statusin e kategorise
                    //varString1 --> emri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoKategoriArtikulli", varInt1, varString1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public DataSet Create(string CRUD, int varInt1,string varString1,  DateTime varDate1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds = null;
            switch (CRUD)
            {
                case "ShtoBlerje":
                    //varInt1 --> idFurnitori
                    //varDate1 --> data e blerjes
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoBlerje", varInt1, varString1, varDate1);
                    ds = dbmanObject.GetData("R");
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public int Create(string CRUD, int varInt1, DataSet varDs)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "KrijoEkstratPerRecete":
                    //varInt1 --> idReceta
                    //varDs --> mban ekstrat
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoEkstratPerRecete", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;

                case "KrijoLidhjenReceteGrupCmimesh":
                    //varInt1 --> idReceta
                    //varDs --> mban grupet e cmimeve
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoLidhjenReceteGrupCmimesh", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;

                case "KrijoCmimRecetePerGrup":
                    //varInt1 --> idGrupCmimi
                    //varDs --> mban recetat 
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoCmimRecetePerGrup", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;

                case "KrijoLidhjeOferteRecete":
                    //varInt1 --> idFatura
                    //varDs --> mban recetat perberese te ofertes
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoLidhjeOferteRecete", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;

                case "LidhFaturenMeRecetat":
                    //varInt1 --> idFatura
                    //varDs --> mban recetat perberese te fatures
                    dbmanObject.strSql = dbmapObject.GetQuery("LidhFaturenMeRecetat", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;

                case "LidhFaturenMeArtikujt":
                    //varInt1 --> idFatura
                    //varDs --> mban artikujt perberes te fatures
                    dbmanObject.strSql = dbmapObject.GetQuery("LidhFaturenMeArtikujt", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;

                case "ShtoArtikujNeBlerje":
                    //varInt1 --> idBlerja
                    //varDs --> mban artikujt perberes te blerjes
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoArtikujNeBlerje", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;

                case "ShtoArtikujNeRecete":
                    //varInt1 --> idReceta
                    //varDs --> mban artikujt perberes te recetes
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoArtikujNeRecete", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;

                case "KrijoCmimePerRecete":
                    //varInt1 --> idReceta
                    //varDs --> mban cmimet qe do te shtohen per cdo interval te konfiguruar
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoCmimePerRecete", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;//
                default:
                    b = 1;
                    break;
            }
            return b;
        }     
        
        public int Create(string CRUD, int varInt1, double varDouble1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b = 0;
            switch (CRUD)
            {
                case "KrijoCmimiArtikulli":
                    //dbmanObject.strSql = dbmapObject.GetQuery("KrijoCmimiArtikulli", varInt1, varDouble1);
                    //b = dbmanObject.GetData();

                    ////varInt1 --> idArtikulli
                    ////varDouble1 --> cmimi i ri
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, int varInt1, int varInt2)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "KrijoLidhjeArikujFurnitor":
                    //varInt1 --> idFurnitori
                    //varInt1 --> idArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoLidhjeArikujFurnitor", varInt1, varInt2);
                    b = dbmanObject.GetData();
                    break;

                case "KrijoLidhjeTavolineFature":
                    //varInt1 --> idTavolina
                    //varInt1 --> idFatura
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoLidhjeTavolineFature", varInt1, varInt2);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, int varInt1, int varInt2, int varInt3)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "LidhFatureOferteRecete":

                    dbmanObject.strSql = dbmapObject.GetQuery("LidhFatureOferteRecete", varInt1, varInt2, varInt3);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, string  varString1, int varInt2, int varInt3)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ShtoTavoline":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoTavoline", varInt2, varInt3, varString1);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, string varString1, string varString2)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "KrijoKategoriShpenzimMujor":
                    // varString1 --> emri i kategorise
                    // varString2 --> pershkrimi i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoKategoriShpenzimMujor", varString1, varString2);
                    b = dbmanObject.GetData();
                    break;

                case "KrijoGrupCmimi":
                    // varString1 --> emri i grupit te cmimit
                    // varString2 --> pershkrimi i grupit te cmimit
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoGrupCmimi", varString1, varString2);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, int varInt1, int[] arrayInt)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "RezervoTavolina":
                    dbmanObject.strSql = dbmapObject.GetQuery("RezervoTavolina", varInt1, arrayInt);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, string varString1, string varString2, string varString3, string varString4)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();

            int b;
            switch (CRUD)
            {
               

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, string varString1, string varString2, int varInt1, decimal varDecimal1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();

            int b;
            switch (CRUD)
            {


                default:
                    b = 1;
                    break;
            }
            return b;
        }



        public int Create(string CRUD, string varString1, string varString2, string varString3,
            string varString4, string varString5)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ShtoKlient":
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> kodi
                    //varString4 --> telefoni
                    //varString5 --> adresa
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoKlient", varString1, varString2, varString3, varString4, varString5);
                    b = dbmanObject.GetData();
                    break;

                case "ShtoFurnitor":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoFurnitor", varString1, varString2, varString3, varString4, varString5);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int Create(string CRUD, int varInt1, int varInt2, string varString1, DateTime varDate1,
            decimal varDec1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "KryejShpenzim":
                    dbmanObject.strSql = dbmapObject.GetQuery("KryejShpenzim", varInt1, varInt2, varString1, varDate1, varDec1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, int varInt1, int varInt2, int varInt3, double varDouble1, string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "KrijoShpenzimMujor":
                    //varInt1 --> idKategoria
                    //varInt2 --> muaji
                    //varInt3 --> viti
                    //varDouble1 --> vlera
                    //varString1 --> komenti mbi shpenzimin
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoShpenzimMujor", varInt1, varInt2, varInt3, varDouble1, varString1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Create(string CRUD, int varInt1, DateTime varDate1, DateTime varDate2, double varDouble1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "KrijoCmimPerArtikullin" :
                    // varInt1--> idPeriudhaCmimi
                    // varDate1 --> data e fillimit
                    // varDate2 --> data e mbarimit
                    // varDouble1 --> cmimi i artikullit
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoCmimPerArtikullin", varInt1, varDate1, varDate2, varDouble1);
                    b = dbmanObject.GetData();
                    break;

                case "KrijoCmimPerRecetat":
                    // varInt1--> idPeriudhaCmimi
                    // varDate1 --> data e fillimit
                    // varDate2 --> data e mbarimit
                    // varDouble1 --> cmimi i recetes
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoCmimPerRecetat", varInt1, varDate1, varDate2, varDouble1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public DataSet Create(string CRUD, string varString1, string varString2, DateTime varDate1, DateTime varDate2,
            DateTime varDate3)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            DataSet ds;
            switch (CRUD)
            {
                case "ShtoRezervim":
                    dbmanObject.strSql = dbmapObject.GetQuery("ShtoRezervim", varString1, varString2,
                        varDate1, varDate2, varDate3);
                    ds = dbmanObject.GetData("R");
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }
        #endregion

        #region Delete
        
        public int Delete(string CRUD)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b = 0;
            switch (CRUD)
            {
                case "FshiFavorite" :
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiFavorite");
                    b = dbmanObject.GetData();
                    break;

                case "FshiHistorikTurnet":
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiHistorikTurnet");
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }

            return b;
        }

        public int Delete(string CRUD, int varInt1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b = 0;
            switch (CRUD)
            {
                case "FshiEkstratPerRecete":
                    //varInt1 --> idReceta
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiEkstratPerRecete", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "FshiGrupCmimi":
                    //varInt1 --> idGrupCmimi
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiGrupCmimi", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "FshiLidhjetFaturePerTavoline":
                    //varInt1 --> idTavolina
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiLidhjetFaturePerTavoline", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "FshiRecetatPerOferte":
                    //varInt1 --> idOferta
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiRecetatPerOferte", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "FshiLidhjenFaturaRecetat":
                    //varInt1 --> idFatura
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiLidhjenFaturaRecetat", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "FshiPersonel":
                    //varInt1 --> idPersoneli
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiPersonel", varInt1);
                    b = dbmanObject.GetData();
                    break;
                    
                case "FshiRezervim":
                    //varInt1 --> idRezervimi
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiRezervim", varInt1);
                    b = dbmanObject.GetData();
                    break;

                default :
                    b = 1;
                    break;
            }

            return b;
        }

        public int Delete(string CRUD, DataSet varDs)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "FshiRecetatNgaFavoritet":
                    //varDs --> Mban te gjitha id e recetave qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiRecetatNgaFavoritet", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiArtikujt":
                    //varDs --> Mban te gjitha id e artikujve qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiArtikujt", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiKategoriteETavolinave":
                    //varDs --> Mban te gjitha Id e kategorive te tavolinave qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiKategoriteETavolinave", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiTavolinat":
                    //varDs --> Mban te gjitha Id e tavolinave qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiTavolinat", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiKategoriteEArtikujve":
                    //varDs --> Mban te gjitha Id e kategorive te artikujve qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiKategoriteEArtikujve", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiKategoriteERecetave":
                    //varDs --> Mban te gjitha Id e kategorive te recetave qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiKategoriteERecetave", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiKategoriteEShpenzimeve":
                    //varDs --> Mban te gjitha Id e kategorive te recetave qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiKategoriteEShpenzimeve", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiNjesite":
                    //varDs --> Mban te gjitha Id e njesive matese qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiNjesite", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiFormatEPageses":
                    //varDs --> Mban te gjitha Id e formave te pageses qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiFormatEPageses", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiFurnitoret":
                    //varDs --> Mban te gjitha Id e furnitoreve qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiFurnitoret", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiKlientet":
                    //varDs --> Mban te gjitha Id e klienteve qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiKlientet", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiShpenzimet":
                    //varDs --> Mban te gjitha Id e shpenzimeve qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiShpenzimet", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiRezervimeSkaduara":
                    //varDs --> Mban te gjitha Id e rezervimeve qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiRezervimeSkaduara", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiBlerjet":
                    //varDs --> Mban te gjitha Id e blerjeve qe duhet te fshihen
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiBlerjet", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiPerkatesiArtikuj":
                    //varDs --> Mban te gjitha Id e furnitoreve dhe artikujve perkates qe duhen fshire
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiPerkatesiArtikuj", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "FshiRecetat":
                    //varDs --> Mban te gjitha Id e recetave qe duhen fshire
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiRecetat", varDs);
                    b = dbmanObject.GetData();
                    break;
                
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Delete(string CRUD, DataSet varDs, DataSet varDs1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "FshiBlerjet":
                    //varDs --> Mban te gjitha Id e blerjeve qe duhet te fshihen
                    //varDs1 -->per cdo tabele te varDs1 ruhen sasite e artikujve te blerjes perkatese
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiBlerjet", varDs, varDs1);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }
        #endregion

        #region Update
        public int Update(string CRUD)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "VendosNjeUserPerBazen":
                    dbmanObject.strSql = dbmapObject.GetQuery("VendosNjeUserPerBazen");
                    b = dbmanObject.GetData();
                    break;

                

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoNrFatura":
                    //varInt1 --> idFatura
                    //varString1 --> nrFatura
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoNrFatura", varInt1, varString1);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoPathiFotoArtikulli" :
                    //varInt1 --> idArtikulli
                    //varString1 --> pathi i ri i fotos se artikullit
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoPathiFotoArtikulli" , varInt1, varString1);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoPathiFotoPersoneli":
                    //varInt1 --> idPersoneli
                    //varString1 --> pathi i ri i fotos se personelit
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoPathiFotoPersoneli", varInt1, varString1);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoKategoriTavoline":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoKategoriTavoline", varInt1, varString1);
                    b = dbmanObject.GetData();
                    break;
                
                case "ModifikoKategoriRecete":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoKategoriRecete", varInt1, varString1);
                    b = dbmanObject.GetData();
                    break;
                case "ModifikoKategoriShpenzimi":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoKategoriShpenzimi", varInt1, varString1);
                    b = dbmanObject.GetData();
                    break;
                case "ModifikoNjesi":
                    //varInt1 --> idNjesia
                    //varString1 --> emri i ri i njesise
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoNjesi", varInt1, varString1);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoFjalekalim":
                    //varInt1 --> idPersoneli
                    //varString1 --> fjalekalimi i ri
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoFjalekalim", varInt1, varString1);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoKostoVilaX":
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoKostoVilaX", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "AktivizoArtikull":
                    //varInt1 --> idArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("AktivizoArtikull", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "ZgjidhGrupCmimi":
                    //varInt1 --> idGrupCmimi
                    dbmanObject.strSql = dbmapObject.GetQuery("ZgjidhGrupCmimi", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "AnulloFaturen":
                    //varInt1 --> idFatura
                    dbmanObject.strSql = dbmapObject.GetQuery("AnulloFaturen", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "MbyllTurnin":
                    //varInt1 --> idPerdorues
                    dbmanObject.strSql = dbmapObject.GetQuery("MbyllTurnin", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "FshiPerdorues":
                    //varInt1 --> idPerdorues
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiPerdorues", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "MbyllTavoline":
                    //varInt1 --> idTavolina
                    dbmanObject.strSql = dbmapObject.GetQuery("MbyllTavoline", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "HapTavoline":
                    //varInt1 --> idTavolina
                    dbmanObject.strSql = dbmapObject.GetQuery("HapTavoline", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoPeriudhaCmimiPerReceten":
                    //varInt1 --> idCmimiArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoPeriudhaCmimiPerReceten", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoPeriudhaCmimiPerArtikullin" :
                    //varInt1 --> idCmimiArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoPeriudhaCmimiPerArtikullin", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoCmimiArtikulli":
                    //varInt1 --> idCmimiArtikulli
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoCmimiArtikulli", varInt1);
                    b = dbmanObject.GetData();
                    break;
              

                case "FshiReferenceKamarieri":
                    //varInt1 --> idPersoneli
                    dbmanObject.strSql = dbmapObject.GetQuery("FshiReferenceKamarieri", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "Login":
                    //varInt1 --> idPersoneli
                    dbmanObject.strSql = dbmapObject.GetQuery("Login", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "Logout":
                    //varInt1 --> idPersoneli
                    dbmanObject.strSql = dbmapObject.GetQuery("Logout", varInt1);
                    b = dbmanObject.GetData();
                    break;

                case "MbyllTurnKamarieri":
                    //varInt1 --> idPerdoruesi
                    dbmanObject.strSql = dbmapObject.GetQuery("MbyllTurnKamarieri", varInt1);
                    b = dbmanObject.GetData();
                    break;
                case "CaktivizoRecete":
                    //varInt1 --> idReceta
                    dbmanObject.strSql = dbmapObject.GetQuery("CaktivizoRecete", varInt1);
                    b = dbmanObject.GetData();
                    break;
                
                
                case "CaktivizoCmiminEFunditPerReceten":
                    //varInt1 --> idReceta
                    dbmanObject.strSql = dbmapObject.GetQuery("CaktivizoCmiminEFunditPerReceten", varInt1);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, double varDouble1, string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoShpenzimMujor":
                    //varInt1 --> idShpenzimiMujor
                    //varDouble1 --> vlera e shpenzimit
                    //varString1 --> komenti mbi shpenzimin mujor
                    
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoShpenzimMujor", varInt1, varDouble1, varString1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }
        
        public int Update(string CRUD, int varInt1, string varString1, decimal varDec1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoFormePagese":
                    //varInt1 --> idFormaPagesa
                    //varString1 --> emri i ri i formes se pageses
                    //varDec1 --> komisioni
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoFormePagese", varInt1, varString1, varDec1);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, int varInt2, int[] varArrayInt1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;

            switch (CRUD)
            {
                case "TransferoTavolinen":
                    //varInt1 --> idTavolinaOld
                    //varInt2 --> idTavolinaNew
                    //varArrayInt1 --> vektori i idFaturave qe tranferohen
                    dbmanObject.strSql = dbmapObject.GetQuery("TransferoTavolinen", varInt1, varInt2, varArrayInt1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, string varString1, int varInt3, int varInt4)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoTavoline":
                    //varInt1 --> idTavolina
                    //varString1 --> emri
                    //varInt3 --> idKategoria
                    //varInt4 --> kapaciteti
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoTavoline", varInt1, varString1, varInt3, varInt4);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, int varInt2,string varString1, DateTime varDate1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoBlerje":
                    //varInt1 --> idBlerja
                    //varInt2 --> idFurnitori
                    //varDate1 --> data e blerjes
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoBlerje", varInt1, varInt2,varString1, varDate1);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, DateTime varDate1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoOrenLast":
                    //varInt1 --> idCmimi
                    //varDate1 --> data e fundit
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoOrenLast", varInt1, varDate1);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoOrenLastReceta":
                    //varInt1 --> idCmimi
                    //varDate1 --> data e fundit
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoOrenLastReceta", varInt1, varDate1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, string varString1, string varString2, string varString3, string varString4)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();

            int b;
            switch (CRUD)
            {
                case "dbModifikoKlient":
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> kodi
                    //varString4 --> telefoni
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoKlient", varInt1, varString1, varString2, varString3, varString4);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }
        
        public int Update(string CRUD, int varInt1, string varString1, string varString2, string varString3,
            string varString4, string varString5)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoFurnitor":
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoFurnitor", varInt1, varString1, varString2, varString3, varString4, varString5);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoKlient":
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> kodi
                    //varString4 --> telefoni
                    //varString5 --> adresa
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoKlient", varInt1, varString1, varString2, varString3, varString4, varString5);
                    b = dbmanObject.GetData();
                    break;


                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, int varInt2, string varString1, string varString2, string varString3,
          string varString4, string varString5, string varString6, string varString7, string varString8)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoPersonel":
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoPersonel", varInt1, varInt2, varString1, varString2,
                        varString3, varString4, varString5, varString6, varString7, varString8);
                    b = dbmanObject.GetData();

                    // varInt1 --> celesi i personelit
                    // varInt2 --> roli i personelit
                    // varString1 --> emer
                    // varString2 --> mbiemer
                    // varString3 --> emaili
                    // varString4 --> telefoni
                    // varString5 --> adresa
                    // varString6 --> perdoruesi
                    // varString7 --> fjalekalimi
                    // varString8 --> foto
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, int varInt2, int varInt3, string varString1,
            DateTime varDate1, decimal varDec1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoShpenzim":
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoShpenzim", varInt1, varInt2, varInt3,
                        varString1, varDate1, varDec1);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, int varInt2,  string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoRecete":
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoRecete", varInt1, varInt2, varString1);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoKategoriArtikulli":
                    //varInt1 --> idKategoria
                    //varInt2 --> {0, 1} percakton shfaqjen ne menu te artikullit
                    //varString1 --> emri i ri i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoKategoriArtikulli", varInt1, varInt2, varString1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, string varString1, string varString2)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {

                case "ModifikoKategoriShpenzimiMujor":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    //varString2 --> pershkrimi i kategorise
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoKategoriShpenzimiMujor", varInt1, varString1, varString2);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoGrupCmimi":
                    //varInt1 --> idGrupi
                    //varString1 --> emri i grupit
                    //varString2 --> pershkrimi i grupit
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoGrupCmimi", varInt1, varString1, varString2);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int Update(string CRUD, string varString1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "EkzekutoQuery":
                    dbmanObject.strSql = dbmapObject.GetQuery("EkzekutoQuery", varString1);
                    b = dbmanObject.GetData();
                    break;

                case "KarikoBackUp":
                    dbmanObject.strSql = dbmapObject.GetQuery("KarikoBackUp", varString1);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }
        

        public int Update(string CRUD,int varInt1, string varString1, string varString2, DateTime varDate1, DateTime varDate2,
            DateTime varDate3)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoRezervim":
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoRezervim",varInt1, varString1, varString2, 
                        varDate1, varDate2, varDate3);
                    b = dbmanObject.GetData();
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, double varDouble1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b = 0;
            switch (CRUD)
            {
                case "ModifikoKostoFature":
                    //varInt1 --> idFatura
                    //varDouble1 --> kostoFature
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoKostoFature", varInt1, varDouble1);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoTotaliFature":
                    //varInt1 --> idFatura
                    //varDouble1 --> kostoFature
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoTotaliFature", varInt1, varDouble1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 0;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1,  string varString1, string varString2, int varInt2, decimal varDecimal1)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b = 0;
            switch (CRUD)
            {
                case "ModifikoOferte":

                    //varInt1 --> idOferta
                    // varString1 --> emri i ofertes
                    // varString2 --> tipi i ofertes
                    // varInt2 --> numri i shportave
                    // varDecimal1 --> cmimi

                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoOferte", varInt1, varString1, varString2, varInt2, varDecimal1);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 0;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, int varInt1, int varInt2, int varInt3, int varInt4, string varString1, string varString2, double varDouble1, double varDouble2)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b = 0;
            switch (CRUD)
            {
                case "ModifikoArtikull":
                    //varInt1 --> idArtikulli
                    //varInt2 --> idKategoria
                    //varInt3 --> idNjesia
                    //varInt4 --> lloji i konsumit
                    //varString1 --> kodi i artikullit
                    //varString2 --> pathi i fotos
                    //varDouble1 --> cmimi
                    //varDouble2 --> sasiaSkorte

                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoArtikull", varInt1, varInt2, varInt3, varInt4, varString1, varString2, varDouble1, varDouble2);
                    b = dbmanObject.GetData();
                    break;

                default:
                    b = 0;
                    break;
            }
            return b;
        }

        public int Update(string CRUD, DataSet varDs)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoGrupCmiminZgjedhur":
                    //varDs --> idGrupet
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoGrupCmiminZgjedhur", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "MbyllGjitheTurnet":
                    //varDs --> idKamarieret
                    dbmanObject.strSql = dbmapObject.GetQuery("MbyllGjitheTurnet", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoSasiaPerArtikujtPerAnullim":
                    //varDs --> artikujt me sasite perkatese per tu modifikuar per anullim fature
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoSasiaPerArtikujtPerAnullim", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoSasiaPerArtikujt":
                    //varDs --> artikujt me sasite perkatese per tu modifikuar
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoSasiaPerArtikujt", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "AktivizoArtikujt" :
                    //varDs --> artikujt per tu aktivizuar
                    dbmanObject.strSql = dbmapObject.GetQuery("AktivizoArtikujt", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "CaktivizoArtikujt" :
                    //varDs --> artikujt per tu caktivizuar
                    dbmanObject.strSql = dbmapObject.GetQuery("CaktivizoArtikujt", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "Logout":
                    //varDs --> kamarieret per tu caktivizuar
                    dbmanObject.strSql = dbmapObject.GetQuery("Logout", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "MbyllTurnKamarieri":
                    //varDs --> kamarieret per tu caktivizuar
                    dbmanObject.strSql = dbmapObject.GetQuery("MbyllTurnKamarieri", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "ModifikoSasiteArtikujt":
                    //varDs --> dataseti mban idEArtikujve qe kane marre pjese ne blerjen e pamodifikuar
                    //dhe sasite perkatese
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoSasiteArtikujt", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "KrijoPeriudhaTeRejaPerArtikujtDheRecetatMeIntervale":
                    //varDs --> dataseti ka dy datatable
                    //1 --> artikujt e ndare ne intervale
                    //2 --> recetat e ndara ne intervale
                    dbmanObject.strSql = dbmapObject.GetQuery("KrijoPeriudhaTeRejaPerArtikujtDheRecetatMeIntervale", varDs);
                    b = dbmanObject.GetData();
                    break;

                case "RuajIntervalet":
                    //varDs --> dataseti ka per rreshta te dhenat per intervalet e krijuar
                    dbmanObject.strSql = dbmapObject.GetQuery("RuajIntervalet", varDs);
                    b = dbmanObject.GetData();
                    break; 
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int Update(string CRUD,int varInt1, DataSet varDs)
        {
            DbMapper dbmapObject = new DbMapper();
            DbManager dbmanObject = new DbManager();
            int b;
            switch (CRUD)
            {
                case "ModifikoCmimeRecetatPerGrup":
                    //varInt1 --> celesi i grupcmimit
                    //varDs --> ketu ruhen te dhenat per recetat
                    dbmanObject.strSql = dbmapObject.GetQuery("ModifikoCmimeRecetatPerGrup", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;

                case "RuajPerkatesiArtikuj":
                    //varInt1 --> idFurnitori
                    //varDs --> artikujt per tu aktivizuar
                    dbmanObject.strSql = dbmapObject.GetQuery("RuajPerkatesiArtikuj",varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;

                case "NdryshoDisponibilitet":
                    //varInt1 --> 1 ose 0
                    //varDs --> recetat per tu ndryshuar
                    dbmanObject.strSql = dbmapObject.GetQuery("NdryshoDisponibilitet", varInt1, varDs);
                    b = dbmanObject.GetData();
                    break;
                
                default:
                    b = 1;
                    break;
            }
            return b;
        }
        #endregion
    }

}
