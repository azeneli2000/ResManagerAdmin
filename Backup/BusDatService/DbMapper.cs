using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;

namespace ResManagerAdmin.BusDatService
{
    public class DbMapper
    {
        #region Constructor
        #endregion

        #region GetQuery

        public string GetQuery(string kerkesaQuery)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                
                case "ShfaqKategoriteERecetavePerMenu":
                    strSql = "SELECT  ID_KATEGORIARECETA, PERSHKRIMI FROM KATEGORITE_RECETAT WHERE ID_KATEGORIARECETA IN (SELECT ID_KATEGORIARECETA FROM RECETAT WHERE DISPONUESHEM = 1 AND AKTIVE = 1) ORDER BY PERSHKRIMI ";
                    break;

                case "KtheMaksIdGrupCmimi" :
                    strSql = "SELECT MAX(ID_GRUPCMIMI) AS CELESI FROM GRUP_CMIMET";
                    break;

                case "ShfaqGrupCmimet" :
                    strSql = "SELECT ID_GRUPCMIMI, KGRUPCMIMI, PGRUPCMIMI, ZGJEDHUR FROM GRUP_CMIMET";
                    break;

                case "KtheKamarieretLoguar" :
                    strSql = "";
                    break;

                case "ShfaqOfertatPerHotelin":
                    strSql = "SELECT ID_OFERTA, EMRI, CMIMI, NR_SHPORTASH, AKTIV FROM OFERTAT " +
                             "WHERE TIPI = 'H' ";
                    break;

                case "ShfaqOfertatPerBarin" :
                    strSql = "SELECT ID_OFERTA, EMRI, CMIMI, NR_SHPORTASH, AKTIV FROM OFERTAT " +
                             "WHERE TIPI = 'R' ";
                    break;

                case "ShfaqShpenzimetMujore" :
                    strSql = "SELECT ID_SHPENZIMIMUJOR, SP.ID_KATSHPENZIMIMUJOR, CSHPENZIMI, MUAJI, VITI, VLERA, KOMENTI " +
                             "FROM SHPENZIMET_MUJORE AS SP INNER JOIN KATEGORIA_SHPENZIMIMUJOR AS K ON SP.ID_KATSHPENZIMIMUJOR = K.ID_KATSHPENZIMIMUJOR";
                    break;

                case "ShfaqKategoriShpenzimeshMujore" :
                    strSql = "SELECT * FROM KATEGORIA_SHPENZIMIMUJOR";
                    break;

                case "ShfaqKamarieretPerKombo" :
                    strSql = "SELECT ID_PERSONELI AS ID_KAMARIERI, PERDORUESI AS KAMARIERI FROM PERSONELI WHERE ID_ROLI = 2";
                    break;

                case "ShfaqTavolinatPerKombo" :
                    strSql = "SELECT ID_TAVOLINA, EMRI AS TAVOLINA FROM TAVOLINAT";
                    break;

                case "ShfaqFaturatPerSot" :
                    strSql = "SELECT ID_FATURA, DATA_ORA, NR_FATURE, F.ID_TAVOLINA, T.EMRI AS TAVOLINA, P.ID_PERSONELI , P.EMRI AS KAMARIERI, SKONTO, TOTALI, F.ID_FORMAPAGESA, FORMA_PAGESA, ANULLUAR " +
                             "FROM FATURAT AS F INNER JOIN TAVOLINAT AS T ON F.ID_TAVOLINA = T.ID_TAVOLINA " +
                             "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                             "INNER JOIN FORMA_PAGESA AS FP ON F.ID_FORMAPAGESA = FP.ID_FORMAPAGESA " +
                             "WHERE DAY(DATA_ORA) = DAY(GETDATE()) AND MONTH(DATA_ORA) = MONTH(GETDATE()) AND YEAR(DATA_ORA) = YEAR(GETDATE())";
                    break;

                case "LexoXhironPerKamarierin" :
                    strSql = "";
                    break;

                case "KtheIdFurnitoriGeneral" :
                    strSql = "SELECT ID_FURNITORI FROM FURNITORET WHERE EMRI = 'Furnitori'";
                    break;

                case "KtheNrFaturaLast" :
                    strSql = "SELECT ID_FATURA, NR_FATURE FROM FATURAT WHERE ID_FATURA = (SELECT MAX(ID_FATURA) FROM FATURAT)";
                    break;

                case "FshiFavorite":
                    strSql = "DELETE FROM FAVORITE";
                    break;

                case "ShfaqFavorite":
                    strSql = "SELECT * FROM FAVORITE ORDER BY PRIORITETI ASC";
                    break;

                case "ShfaqRecetatSipasKategorive":
                    strSql = "SELECT ID_RECETA, EMRI, R.ID_KATEGORIARECETA, PERSHKRIMI " +
                             "FROM RECETAT AS R INNER JOIN KATEGORITE_RECETAT AS K ON R.ID_KATEGORIARECETA = K.ID_KATEGORIARECETA " +
                             "ORDER BY R.ID_KATEGORIARECETA, EMRI ASC ";
                    break;

                case "ShfaqRecetatSipasKategorivePerFavorite":
                    strSql = "SELECT ID_RECETA, EMRI, R.ID_KATEGORIARECETA, PERSHKRIMI " +
                             "FROM RECETAT AS R INNER JOIN KATEGORITE_RECETAT AS K ON R.ID_KATEGORIARECETA = K.ID_KATEGORIARECETA " +
                             "WHERE (DISPONUESHEM = 1 AND AKTIVE = 1) " +
                             "ORDER BY R.ID_KATEGORIARECETA, EMRI ASC ";
                    break;

                case "ShfaqArtikujtSipasKategorive":
                    strSql = "SELECT ID_ARTIKULLI, EMRI, A.ID_KATEGORIAARTIKULLI, PERSHKRIMI, ARTIKULL_KONSUMI, A.ID_NJESIA, NJESIA, NUMRI_TOTAL, SASIA_SKORTE, FOTO, DISPONUESHEM " +
                             "FROM ARTIKUJT AS A INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                             "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                             "WHERE DISPONUESHEM = 1 ORDER BY A.ID_KATEGORIAARTIKULLI";
                    break;

                case "ShfaqArtikujt":
                    strSql = "SELECT ID_ARTIKULLI, EMRI, A.ID_KATEGORIAARTIKULLI, PERSHKRIMI, ARTIKULL_KONSUMI, A.ID_NJESIA, NJESIA, NUMRI_TOTAL, SASIA_SKORTE, FOTO, DISPONUESHEM " +
                             "FROM ARTIKUJT AS A INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                             "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                             "WHERE DISPONUESHEM = 1 ORDER BY EMRI";

                    break;

                case "KtheNumerAdministratoresh":
                    strSql = "SELECT COUNT(ID_PERSONELI) AS NR_ADMIN FROM PERSONELI WHERE ID_ROLI = 1";
                    break;

                case "ShfaqRolet":
                    strSql = "SELECT ID_ROLI, ROLI FROM ROLET";
                    break;

                case "ShfaqKategoriteETavolinave":
                    strSql = "SELECT * FROM KATEGORITE_TAVOLINAT ORDER BY PERSHKRIMI";
                    break;

                case "ShfaqTavolinatDetaje":
                    strSql  = "SELECT ID_TAVOLINA, EMRI, KAPACITETI, GJENDJA, T.ID_KATEGORIATAVOLINA, PERSHKRIMI " +
                             "FROM TAVOLINAT AS T INNER JOIN KATEGORITE_TAVOLINAT AS KT ON " +
                             "KT.ID_KATEGORIATAVOLINA = T.ID_KATEGORIATAVOLINA";
                    break;

                case "ShfaqTavolinenMeNumerMeTeMadh":
                    strSql = "SELECT MAX(EMRI) FROM TAVOLINAT";
                    break;

                case "ShfaqKategoriteEArtikujve":
                    strSql = "SELECT  * FROM KATEGORITE_ARTIKUJT ORDER BY PERSHKRIMI";
                    break;

                case "ShfaqKategoriteEArtikujvePerMenu":
                    strSql = "SELECT  ID_KATEGORIAARTIKULLI, PERSHKRIMI FROM KATEGORITE_ARTIKUJT WHERE VISIBLE = 1 ORDER BY PERSHKRIMI";
                    break;

                case "ShfaqNumrinEArtikujvePerSecilenKategori":
                    strSql = "select ka.id_kategoriaartikulli, count(ka.id_kategoriaartikulli)  from artikujt as a " +
                            "inner join kategorite_artikujt as ka " +
                            "on a.id_kategoriaartikulli = ka.id_kategoriaartikulli " +
                            "group by ka.id_kategoriaartikulli";
                    break;

                case "ShfaqNumrinETavolinavePerSecilenKategori":
                    strSql = "select kt.id_kategoriatavolina, count(kt.id_kategoriatavolina)  from tavolinat as t " +
                            "inner join kategorite_tavolinat as kt " +
                            "on t.id_kategoriatavolina = kt.id_kategoriatavolina " +
                            "group by kt.id_kategoriatavolina";
                    break;

                case "ShfaqKategoriteERecetave":
                    strSql = "SELECT  * FROM KATEGORITE_RECETAT ORDER BY PERSHKRIMI";
                    break;

                case "ShfaqNumrinERecetavePerSecilenKategori":
                    strSql = "select kr.id_kategoriareceta, count(kr.id_kategoriareceta)  from recetat as r " +
                            "inner join kategorite_recetat as kr " +
                            "on r.id_kategoriareceta = kr.id_kategoriareceta " +
                            "group by kr.id_kategoriareceta";
                    break;

                case "ShfaqKategoriteEShpenzimeve":
                    strSql = "SELECT  * FROM KATEGORITE_SHPENZIMET ORDER BY PERSHKRIMI";
                    break;

                case "ShfaqNumrinEShpenzimevePerSecilenKategori":
                    strSql = "select ks.id_kategoriashpenzimi, count(ks.id_kategoriashpenzimi)  from shpenzimet as s " +
                            "inner join kategorite_shpenzimet as ks " +
                            "on s.id_kategoriashpenzimi = ks.id_kategoriashpenzimi " +
                            "group by ks.id_kategoriashpenzimi";
                    break;

                case "ShfaqNjesiteMatese":
                    strSql = "SELECT  * FROM NJESITE ORDER BY NJESIA";
                    break;

                case "ShfaqNumrinEArtikujvePerSecilenNjesi":
                    strSql = "select nj.id_njesia, count(nj.id_njesia)  from njesite " +
                                " as nj inner join artikujt as a " +
                                " on a.id_njesia = nj.id_njesia " +
                                " group by nj.id_njesia";
                    break;

                case "ShfaqFormatEPageses":
                    strSql = "SELECT * FROM FORMA_PAGESA ORDER BY FORMA_PAGESA";
                    break;

                case "ShfaqNumrinEFaturavePerSecilenFormePagese":
                    strSql = "select fp.id_formapagesa, count(fp.id_formapagesa)  from forma_pagesa " +
                                " as fp inner join faturat as f " +
                                " on f.id_formapagesa = fp.id_formapagesa " +
                                " group by fp.id_formapagesa ";
                    break;

                case "ShfaqNumrinEBlerjevePerSecilinFurnitor":
                    strSql = "select f.id_furnitori, count(f.id_furnitori)" +
                                  "  from furnitoret as f" +
                                  "  inner join blerjet as b" +
                                   " on f.id_furnitori = b.id_furnitori" +
                                   " group by f.id_furnitori ";
                    break;

                case "ShfaqNumrinEfaturavePerSecilinKlient":
                    strSql = "SELECT K.ID_KLIENTI, COUNT(K.ID_KLIENTI) AS NR_FATURAT " +
                             "FROM KLIENTET_RESTORANTI AS K INNER JOIN FATURAT AS F " +
                             "ON K.ID_KLIENTI = F.ID_KLIENTI " +
                             "GROUP BY K.ID_KLIENTI ";
                    break;


                case "ShfaqPerdoruesitJoKamariere":
                    strSql = "SELECT * FROM PERSONELI WHERE NOT ID_ROLI = 2";
                    break;

                case "RezervimetESkaduara":
                    strSql = "select  distinct(id_rezervimi),emri + ' ' + mbiemri as klienti, " +
                            " data_str,ora_fillimi_str,ora_mbarimi_str,data " +
                            "   from rezervim_tavolinash " +
                            " where getdate() >= ora_mbarimi";
                    break;

                case "GjejTavolinatERezervuara":
                    strSql = "select distinct(id_tavolina) from rezervim_tavolinash";
                    break;

                case "ShfaqPerdoruesitKamariere":
                    strSql = "SELECT ID_PERSONELI, EMRI, MBIEMRI, PERDORUESI, FJALEKALIMI,EMRI + ' ' + MBIEMRI AS KAMARIERI"
                     + " FROM PERSONELI WHERE ID_ROLI = 2 ORDER BY EMRI";
                    break;

                case "FshiHistorikTurnet":
                    string data = DateTime.Now.Date.Day + "." + DateTime.Now.Date.Month + "." + DateTime.Now.Date.Year;
                    strSql = "DELETE FROM TURNET WHERE ID_TURNI NOT IN (SELECT ID_TURNI FROM HYRJET_PERSONELI " +
                        "WHERE DATA = '" + data + "' OR DATA_MBARIMI = '" + data + "')";
                    break;

                case "LexoIntervaletCmime":
                    strSql = "SELECT * FROM PERIUDHAT";
                    break;

                case "ArtikujtDheRecetatCmimeIntervale":
                    strSql = "SELECT COUNT(ID_CMIMI) AS NR, A.ID_ARTIKULLI, A.EMRI, CP.ID_CMIMIPERIUDHA" +
                               " FROM ARTIKUJT AS A INNER JOIN CMIMET_PERIUDHA AS CP " +
                                " ON A.ID_ARTIKULLI = CP.ID_ARTIKULLI " +
                                " INNER JOIN CMIMET AS C ON C.ID_CMIMIPERIUDHA = CP.ID_CMIMIPERIUDHA " +
                                " WHERE CP.ID_CMIMIPERIUDHA IN ( SELECT CP1.ID_CMIMIPERIUDHA FROM " +
                                " ARTIKUJT AS A1 INNER JOIN CMIMET_PERIUDHA AS CP1 " +
                                " ON A1.ID_ARTIKULLI = CP1.ID_ARTIKULLI INNER JOIN CMIMET AS C1 ON C1.ID_CMIMIPERIUDHA = CP1.ID_CMIMIPERIUDHA " +
                                " WHERE CP1.ID_CMIMIPERIUDHA = (SELECT MAX(CP2.ID_CMIMIPERIUDHA) FROM CMIMET_PERIUDHA " +
                                " AS CP2 WHERE CP2.ID_ARTIKULLI = A1.ID_ARTIKULLI)) GROUP BY A.ID_ARTIKULLI, A.EMRI,CP.ID_CMIMIPERIUDHA";
                    strSql += Environment.NewLine + "SELECT COUNT(ID_CMIMI) AS NR, R.ID_RECETA, R.EMRI, CPR.ID_CMIMIPERIUDHA " +
                                " FROM RECETAT AS R INNER JOIN CMIMET_PERIUDHA_RECETAT AS CPR" +
                                " ON R.ID_RECETA = CPR.ID_RECETA" +
                                " INNER JOIN CMIMET_RECETAT AS CR ON CR.ID_CMIMIPERIUDHA = CPR.ID_CMIMIPERIUDHA" +
                                " WHERE CPR.ID_CMIMIPERIUDHA IN (" +
                                " SELECT CPR1.ID_CMIMIPERIUDHA FROM " +
                                " RECETAT AS R1 INNER JOIN CMIMET_PERIUDHA_RECETAT AS CPR1" +
                                " ON R1.ID_RECETA = CPR1.ID_RECETA" +
                                " INNER JOIN CMIMET_RECETAT AS CR1 ON CR1.ID_CMIMIPERIUDHA = CPR1.ID_CMIMIPERIUDHA" +
                                " WHERE CPR1.ID_CMIMIPERIUDHA = (SELECT MAX(CPR2.ID_CMIMIPERIUDHA) FROM CMIMET_PERIUDHA_RECETAT " +
                                " AS CPR2 WHERE CPR2.ID_RECETA = R1.ID_RECETA))" +
                                " GROUP BY R.ID_RECETA, R.EMRI, CPR.ID_CMIMIPERIUDHA";
                    break;

                case "ShfaqCmimetShitjeKorrenteRecetat":
                    strSql = "SELECT R.ID_RECETA, CR.VLERA,CR.ORE_FILLIMI, CR.ORE_MBARIMI " +
                            "FROM RECETAT AS R LEFT JOIN CMIMET_PERIUDHA_RECETAT AS CPR " +
                            "ON CPR.ID_RECETA = R.ID_RECETA " +
                            "LEFT JOIN CMIMET_RECETAT AS CR ON CR.ID_CMIMIPERIUDHA = CPR.ID_CMIMIPERIUDHA " +
                            "WHERE CPR.DATE_MBARIMI IS NULL " +
                            "AND (CONVERT(DATETIME, '1900-01-01 ' + CONVERT(char(5), GETDATE(), 108)) BETWEEN CR.ORE_FILLIMI AND CR.ORE_MBARIMI " +
                            "OR  " +
                            "(CONVERT(DATETIME, '1900-01-01 ' + CONVERT(char(5), GETDATE(), 108)) > CR.ORE_FILLIMI AND CR.ORE_MBARIMI = '1900-01-01 00:00:00.000') " +
                            "OR (CR.ORE_FILLIMI = '1900-01-01 00:00:00.000' AND CR.ORE_MBARIMI = '1900-01-01 00:00:00.000'))";
                    break;

                case "VendosNjeUserPerBazen":
                    strSql = "ALTER DATABASE ResManager SET SINGLE_USER";
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, string varString1)
        {
            string strSql;
            //varString1 = varString1.Replace("'", "''");
            switch (kerkesaQuery)
            {
                case "ShfaqTurnetSipasKerkimit" :
                    strSql = varString1;
                    break;
                case "ShfaqTavolinatMeEmer":
                    //varInt1 --> emri
                    strSql = "SELECT ID_TAVOLINA FROM TAVOLINAT WHERE EMRI = '" + varString1+ "'";
                    break;

                case "KontrolloKodinGrupCmimiPerInsert":
                    //varString1 --> emri i grupit te cmimit
                    strSql = "SELECT ID_GRUPCMIMI FROM GRUP_CMIMET WHERE KGRUPCMIMI = '" + varString1 + "'";
                    break;

                case "KontrolloKodinPerOferte" :
                    //varString1 --> emri i ofertes
                    strSql = "SELECT ID_OFERTA FROM OFERTAT WHERE EMRI = '" + varString1 + "'";
                    break;

                case "ShfaqShpenzimetMujoreSipasKerkimit":
                    //varString1 --> sherben si query
                    strSql = varString1;
                    break;

                case "KontrolloKategoriShpenzimMujor" :
                    //varString1 --> emri i kategorise
                    strSql = "SELECT * FROM KATEGORIA_SHPENZIMIMUJOR WHERE CSHPENZIMI = '" + varString1 + "'";
                    break;

                case "KtheFaturatSipasKerkimit" :
                    //varString1 --> sherben si query
                    strSql = varString1;
                    break;

                case "GjejKostoArtikujshPerFature" :
                    //varString1 --> sherben si query
                    strSql = varString1;
                    break;

                case "EkzekutoQuery":
                    //varString1 --> sherben si query
                    strSql = varString1;
                    break;

                case "ShfaqArtikujtPerBar":
                    //varString1 --> sherben si query
                    strSql = varString1;
                    break;

                case "KontrolloKodinPerKrijoArtikull":
                    strSql = "SELECT * FROM ARTIKUJT WHERE EMRI = '" + varString1 + "' ";
                    break;

                case "KontrolloKodiPerKrijoPersonelFjalekalimi":
                    strSql = "SELECT * FROM PERSONELI WHERE FJALEKALIMI = '" + varString1 + "'";
                    break;

                case "KontrolloKodiPerKrijoPersonel":
                    strSql = "SELECT * FROM PERSONELI WHERE PERDORUESI = '" + varString1 + "'";
                    break;

                case "ShfaqKategoriTavolinePerEmer":
                    strSql = "SELECT * FROM KATEGORITE_TAVOLINAT WHERE PERSHKRIMI = '" + varString1 + "'";
                    break;

                case "ShtoKategoriTavolinash":
                    strSql = "INSERT INTO KATEGORITE_TAVOLINAT(PERSHKRIMI) VALUES('" + varString1 + "')";
                    break;

                case "ShfaqKategoriteEArtikujvePerEmer":
                    strSql = "SELECT * FROM KATEGORITE_ARTIKUJT WHERE PERSHKRIMI = '" + varString1 + "'";
                    break;

                case "ShfaqKategoriteERecetavePerEmer":
                    strSql = "SELECT ID_KATEGORIARECETA, PERSHKRIMI FROM KATEGORITE_RECETAT WHERE PERSHKRIMI = '" + varString1 + "'";
                    break;

                case "ShtoKategoriRecete":
                    strSql = "INSERT INTO KATEGORITE_RECETAT(PERSHKRIMI) VALUES('" + varString1 + "')";
                    break;

                case "ShfaqKategoriteEShpenzimevePerEmer":
                    strSql = "SELECT * FROM KATEGORITE_SHPENZIMET WHERE PERSHKRIMI = '" + varString1 + "'";
                    break;

                case "ShtoKategoriShpenzimi":
                    strSql = "INSERT INTO KATEGORITE_SHPENZIMET VALUES('" + varString1 + "')";
                    break;

                case "ShfaqNjesitePerEmer":
                    strSql = "SELECT * FROM NJESITE WHERE NJESIA = '" + varString1 + "'";
                    break;

                case "ShtoNjesi":
                    strSql = "INSERT INTO NJESITE VALUES('" + varString1 + "')";
                    break;

                case "ShfaqFormaPagesePerEmer":
                    strSql = "SELECT  * FROM FORMA_PAGESA WHERE FORMA_PAGESA = '" + varString1 + "'";
                    break;

                case "ShfaqKlientet":
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    strSql = "SELECT  ID_KLIENTI, EMRI, MBIEMRI, KODI_KLIENTI, TELEFONI, ADRESA FROM KLIENTET_RESTORANTI  " + varString1 + " ORDER BY EMRI";
                    break;

                case "ShfaqFurnitoret":
                    varString1 = varString1.Replace("''", "'");
                    strSql = "SELECT  *,EMRI + ' ' + MBIEMRI AS FURNITORI FROM FURNITORET " + varString1 + " ORDER BY EMRI";
                    break;

                case "ShfaqShpenzimet":
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    strSql = "SELECT  * FROM SHPENZIMET_PERSONELI_KATEGORITE " + varString1 + " ORDER BY DATA";
                    break;

                case "ShfaqTurnet":
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    strSql = "SELECT * FROM HYRJET_PERSONELI " + varString1;
                    break;

                case "ShfaqBlerjet":
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    strSql = "SET CONCAT_NULL_YIELDS_NULL OFF " + "SELECT * FROM VIZUALIZIM_BLERJET " + varString1;
                    strSql += Environment.NewLine + "SELECT BA.ID_BLERJEARTIKUJ, BA.ID_BLERJA, BA.ID_ARTIKULLI, " +
                        "BA.SASIA, BA.CMIMI, OB.ID_ARTIKULLIFILLESTAR, OB.SASIA_KUSHT_OFERTA, A.EMRI AS ARTIKULLI_FILLESTAR, NJ.NJESIA  " +
                        " FROM BLERJET_ARTIKUJT AS BA LEFT JOIN OFERTAT_BLERJE AS OB " +
                        " ON BA.ID_BLERJEARTIKUJ = OB.ID_BLERJEARTIKUJ " +
                        " LEFT JOIN ARTIKUJT AS A ON A.ID_ARTIKULLI = OB.ID_ARTIKULLIFILLESTAR LEFT JOIN NJESITE AS NJ ON NJ.ID_NJESIA = A.ID_NJESIA WHERE " +
                        " ID_BLERJA IN (SELECT ID_BLERJA FROM VIZUALIZIM_BLERJET " + varString1 +
                        ") ORDER BY BA.ID_BLERJA"
                        + " SET CONCAT_NULL_YIELDS_NULL ON";
                    break;

                case "ShfaqArtikujtPerFurnitoret":
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    strSql = "SELECT * FROM PERKATESITE_ARTIKUJ_FURNITORE " + varString1;
                    break;

                case "ShfaqRecetat":
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    if (varString1.Trim() != "")
                        strSql = "SELECT * FROM VIZUALIZIM_RECETAT " + varString1 + " and AKTIVE = 1";
                    else
                        strSql = "SELECT * FROM VIZUALIZIM_RECETAT " + varString1 + " where AKTIVE = 1";


                    if (varString1.Trim() != "")
                    {
                        strSql = "SELECT     dbo.RECETAT.ID_RECETA, dbo.RECETAT.EMRI, dbo.RECETAT.ID_KATEGORIARECETA, dbo.RECETAT.DISPONUESHEM, " +
                                 "dbo.KATEGORITE_RECETAT.PERSHKRIMI, dbo.RECETA_ARTIKUJT.ID_ARTIKULLI, dbo.RECETA_ARTIKUJT.SASIA, dbo.NJESITE.NJESIA, " +
                                 "dbo.ARTIKUJT.EMRI AS ARTIKULLI, dbo.KATEGORITE_ARTIKUJT.PERSHKRIMI AS KATEGORIA_ARTIKULLI, dbo.ARTIKUJT.KOSTO AS CMIMI, " +
                                 "dbo.KATEGORITE_ARTIKUJT.ID_KATEGORIAARTIKULLI, CONVERT(varchar(50), dbo.RECETA_ARTIKUJT.SASIA) " +
                                 "  + ' ' + dbo.NJESITE.NJESIA AS SASIA_STR, dbo.RECETA_ARTIKUJT.SASIA * dbo.ARTIKUJT.KOSTO AS VLERA, dbo.RECETAT.AKTIVE " +
                                 "FROM         dbo.KATEGORITE_RECETAT INNER JOIN " +
                                 "dbo.RECETAT ON dbo.KATEGORITE_RECETAT.ID_KATEGORIARECETA = dbo.RECETAT.ID_KATEGORIARECETA LEFT OUTER JOIN " +
                                 "dbo.ARTIKUJT INNER JOIN " +
                                 "dbo.KATEGORITE_ARTIKUJT ON dbo.ARTIKUJT.ID_KATEGORIAARTIKULLI = dbo.KATEGORITE_ARTIKUJT.ID_KATEGORIAARTIKULLI INNER JOIN " +
                                 "dbo.NJESITE ON dbo.ARTIKUJT.ID_NJESIA = dbo.NJESITE.ID_NJESIA INNER JOIN " +
                                 "dbo.RECETA_ARTIKUJT ON dbo.ARTIKUJT.ID_ARTIKULLI = dbo.RECETA_ARTIKUJT.ID_ARTIKULLI ON " +
                                 "dbo.RECETAT.ID_RECETA = dbo.RECETA_ARTIKUJT.ID_RECETA  " + varString1 + " AND AKTIVE = 1";
                                 
                                  
                    }
                    else
                    {
                        strSql = "SELECT     dbo.RECETAT.ID_RECETA, dbo.RECETAT.EMRI, dbo.RECETAT.ID_KATEGORIARECETA, dbo.RECETAT.DISPONUESHEM, " +
                                 "dbo.KATEGORITE_RECETAT.PERSHKRIMI, dbo.RECETA_ARTIKUJT.ID_ARTIKULLI, dbo.RECETA_ARTIKUJT.SASIA, dbo.NJESITE.NJESIA, " +
                                 "dbo.ARTIKUJT.EMRI AS ARTIKULLI, dbo.KATEGORITE_ARTIKUJT.PERSHKRIMI AS KATEGORIA_ARTIKULLI, dbo.ARTIKUJT.KOSTO AS CMIMI, " +
                                 "dbo.KATEGORITE_ARTIKUJT.ID_KATEGORIAARTIKULLI, CONVERT(varchar(50), dbo.RECETA_ARTIKUJT.SASIA) " +
                                 "  + ' ' + dbo.NJESITE.NJESIA AS SASIA_STR, dbo.RECETA_ARTIKUJT.SASIA * dbo.ARTIKUJT.KOSTO AS VLERA, dbo.RECETAT.AKTIVE " +
                                 "FROM         dbo.KATEGORITE_RECETAT INNER JOIN " +
                                 "dbo.RECETAT ON dbo.KATEGORITE_RECETAT.ID_KATEGORIARECETA = dbo.RECETAT.ID_KATEGORIARECETA LEFT OUTER JOIN " +
                                 "dbo.ARTIKUJT INNER JOIN " +
                                 "dbo.KATEGORITE_ARTIKUJT ON dbo.ARTIKUJT.ID_KATEGORIAARTIKULLI = dbo.KATEGORITE_ARTIKUJT.ID_KATEGORIAARTIKULLI INNER JOIN " +
                                 "dbo.NJESITE ON dbo.ARTIKUJT.ID_NJESIA = dbo.NJESITE.ID_NJESIA INNER JOIN " +
                                 "dbo.RECETA_ARTIKUJT ON dbo.ARTIKUJT.ID_ARTIKULLI = dbo.RECETA_ARTIKUJT.ID_ARTIKULLI ON " +
                                 "dbo.RECETAT.ID_RECETA = dbo.RECETA_ARTIKUJT.ID_RECETA  " + varString1 + " WHERE AKTIVE = 1";
                    }

                    break;


                case "XhirojaPerSecilenDate":
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    strSql = "SELECT SUM(PASKONTO) AS VLERA, DATA_STR, DATA FROM (SELECT convert(decimal(20,2),(F.TOTALI - F.SKONTO - (F.TOTALI - F.SKONTO)*FP.KOMISIONI )) AS PASKONTO, CONVERT(char(12), F.DATA_ORA, 104) AS DATA_STR, CONVERT(DATETIME, CONVERT(char(12), F.DATA_ORA)) AS DATA, F.ANULLUAR " +
                       "FROM FATURAT AS F INNER JOIN FORMA_PAGESA AS FP ON FP.ID_FORMAPAGESA = F.ID_FORMAPAGESA " + varString1 + ") DERIVEDTBL GROUP BY DATA_STR, DATA";
                    break;

                case "ShfaqXhiroSipasFaturavePerDaten":
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    strSql = "SELECT F.NR_FATURE, P.PERDORUESI AS EMRI_KAMARIERI, convert(decimal(20,2),F.TOTALI - F.SKONTO) AS TOTALI, FP.FORMA_PAGESA, " +
                        " convert(decimal(20,2),F.TOTALI - F.SKONTO - (F.TOTALI - F.SKONTO)*FP.KOMISIONI) AS VLERA_KOMISION, T.EMRI AS TAVOLINA " +
                       " FROM FATURAT AS F LEFT JOIN PERSONELI AS P ON P.ID_PERSONELI = F.ID_PERSONELI " +
                       " LEFT JOIN FORMA_PAGESA AS FP ON FP.ID_FORMAPAGESA = F.ID_FORMAPAGESA " +
                       " LEFT JOIN TAVOLINAT AS T ON T.ID_TAVOLINA = F.ID_TAVOLINA " + varString1  + " ORDER BY F.DATA_ORA";
                    break;

                case "XhirojaPerSecilenDateSipasArtikujve":
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    strSql = "SELECT A.EMRI AS RECETA_ARTIKULLI,FA.SASIA + ' ' + NJ.NJESIA AS SASIA_STR, FA.SASIA, F.NR_FATURE, F.DATA_ORA, " + 
                         " CONVERT(char(12), F.DATA_ORA, 104) + CONVERT(char(5), F.DATA_ORA, 108) AS DATA_FATURA_STR, " + 
                        " CONVERT(char(12), F.DATA_ORA, 104) AS DATA_STR, CONVERT(char(5), F.DATA_ORA, 108) AS ORA_STR, FP.FORMA_PAGESA, FP.KOMISIONI, " + 
                        " convert(decimal(20,2),FA.SASIA * C.VLERA) AS TOTALI, convert(decimal(20,2),FA.SASIA * C.VLERA - FA.SASIA * C.VLERA * FP.KOMISIONI) AS VLERA_KOMISION " + 
                        " FROM ARTIKUJT AS A INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " + 
                        " INNER JOIN FATURA_ARTIKUJT AS FA ON FA.ID_ARTIKULLI = A.ID_ARTIKULLI " +
                        " INNER JOIN FATURAT AS F ON FA.ID_FATURA = F.ID_FATURA " + 
                        " INNER JOIN FORMA_PAGESA AS FP ON FP.ID_FORMAPAGESA = F.ID_FORMAPAGESA " + 
                        " INNER JOIN CMIMET_PERIUDHA AS CP ON A.ID_ARTIKULLI = CP.ID_ARTIKULLI " + 
                        " INNER JOIN CMIMET AS C ON CP.ID_CMIMIPERIUDHA = C.ID_CMIMIPERIUDHA " + 
                        " WHERE F.DATA_ORA BETWEEN CP.DATE_FILLIMI AND CP.DATE_MBARIMI " + 
                        " AND CONVERT(DATETIME, '1900-01-01 ' + CONVERT(char(5), F.DATA_ORA, 108)) " +
                        " BETWEEN C.ORE_FILLIMI AND C.ORE_MBARIMI " + varString1 + 
                        " ORDER BY RECETA_ARTIKULLI ";
                    break;

                case "XhirojaPerSecilenDateSipasRecetave":
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    varString1 = varString1.Replace("''", "'");
                    //strSql = "SELECT R.ID_RECETA, R.EMRI AS RECETA, F.ID_FATURA, F.NR_FATURE, F.DATA_ORA, CR.VLERA AS CMIMIS, CONVERT(char(12), F.DATA_ORA, 104) + CONVERT(char(5), F.DATA_ORA, 108) AS DATASTR, CONVERT(char(12), F.DATA_ORA, 104) AS DATA, CONVERT(char(5), F.DATA_ORA, 108) AS ORA, FR.SASIA , (CR.VLERA * FR.SASIA) AS TOTALI " +
                    //         "FROM RECETAT AS R " +
                    //         "INNER JOIN FATURA_RECETAT AS FR ON R.ID_RECETA = FR.ID_RECETA " +
                    //         "INNER JOIN FATURAT AS F ON FR.ID_FATURA = F.ID_FATURA " +
                    //         "INNER JOIN CMIMET_PERIUDHA_RECETAT AS CP ON R.ID_RECETA = CP.ID_RECETA " +
                    //         "INNER JOIN CMIMET_RECETAT AS CR ON CR.ID_CMIMIPERIUDHA = CP.ID_CMIMIPERIUDHA " +
                    //         "WHERE R.ID_RECETA = 77 " +
                    //         "AND ((F.DATA_ORA BETWEEN CP.DATE_FILLIMI AND CP.DATE_MBARIMI) OR (F.DATA_ORA > CP.DATE_FILLIMI AND CP.DATE_MBARIMI IS NULL))   AND CONVERT(DATETIME, '1900-01-01 ' + CONVERT(char(5), F.DATA_ORA, 108))   BETWEEN CR.ORE_FILLIMI AND CR.ORE_MBARIMI  " +
                    //         "ORDER BY R.ID_RECETA ";

                    strSql = varString1;
                    break;

                case "KrijoBackUp":
                    strSql = @"BACKUP DATABASE ResManager TO DISK = 'C:\ResManager Back up\" + varString1 + "' WITH FORMAT";
                    break;

                case "KarikoBackUp":
                    strSql = @"RESTORE DATABASE ResManager FROM DISK = 'C:\ResManager Back up\" + varString1 + "'";
                   
                    break;
                
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, string varString1)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            switch (kerkesaQuery)
            {
                case "KontrolloKodinGrupCmimiPerModifikim":
                    //varInt1 --> idGrupi
                    //varString1 --> emri
                    strSql = "SELECT ID_GRUPCMIMI FROM GRUP_CMIMET WHERE KGRUPCMIMI = '" + varString1 + "' AND ID_GRUPCMIMI <> " + varInt1;
                    break;
                case "ShfaqTavolinatMeEmerPerjashtoId":
                    //varInt1 --> emri
                    //varInt2 --> idTavolina
                    strSql = "SELECT  * FROM TAVOLINAT WHERE EMRI = '" + varString1 + "' AND NOT ID_TAVOLINA = " + varInt1;
                    break;

                case "KontrolloEmrinOfertaPerModifikim" :
                    //varInt1 --> idOferta
                    //varString1 --> emri
                    strSql = "SELECT ID_OFERTA FROM OFERTAT WHERE EMRI = '" + varString1 + "' AND ID_OFERTA <> " + varInt1;
                    break;

                case "ModifikoNrFatura" :
                    //varInt1 --> idFatura
                    //varString1 --> nrFatura
                    strSql = "UPDATE FATURAT SET NR_FATURE = '" + varString1 + "' WHERE ID_FATURA = " + varInt1;
                    break;

                case "ShfaqKategoriteEShpenzimeveMujorePerEmerPerjashtoId" :
                    //varInt1 --> idKategoria
                    //varString1 --> emri i kategorise
                    strSql = "SELECT * FROM KATEGORIA_SHPENZIMIMUJOR WHERE CSHPENZIMI = '" + varString1 + "' AND NOT (ID_KATSHPENZIMIMUJOR = " + varInt1 + ")";
                    break;

                case "VerifikoFjalekalimin":
                    //varInt1 --> idPerdoruesi
                    //varString1 --> fjalekalimi
                    strSql = "SELECT * FROM PERSONELI WHERE ID_PERSONELI = " + varInt1 + " AND FJALEKALIMI = '" + varString1 + "'";
                    break;

                case "ShtoKategoriArtikulli":
                    strSql = "INSERT INTO KATEGORITE_ARTIKUJT VALUES('" + varString1 + "', " + varInt1 + ")";
                    break;

                case "LexoTeDhenaPerArtikullin":
                    //varInt1 --> idArtikulli
                    //varString1 --> lloji i artikullit
                    if (varString1 == "A")
                    {
                        strSql = "SELECT A.ID_ARTIKULLI as CELESI, A.EMRI, VLERA, NJESIA, SASIA_SKORTE AS LIMITI, NUMRI_TOTAL " + 
                                 "FROM ARTIKUJT AS A INNER JOIN CMIMET_PERIUDHA AS CP ON CP.ID_ARTIKULLI = A.ID_ARTIKULLI " + 
                                 "INNER JOIN CMIMET AS C ON C.ID_CMIMIPERIUDHA = CP.ID_CMIMIPERIUDHA " +
                                 "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                                 "WHERE A.ID_ARTIKULLI = " + varInt1 + " " +
                                 "AND CP.DATE_MBARIMI IS NULL AND (CONVERT(DATETIME, '1900-01-01 ' + CONVERT(char(5), GETDATE(), 108)) " +
                                 "BETWEEN C.ORE_FILLIMI AND C.ORE_MBARIMI)";
                        

                    }
                    else
                    {
                        strSql = "SELECT R.ID_RECETA AS CELESI, R.EMRI, CMIMI AS VLERA " +
                                 "FROM RECETAT AS R INNER JOIN RECETA_CMIMET AS RC ON R.ID_RECETA = RC.ID_RECETA " +
                                 "WHERE R.ID_RECETA = " + varInt1 + " AND RC.ID_GRUPCMIMI IN (SELECT ID_GRUPCMIMI FROM GRUP_CMIMET WHERE ZGJEDHUR = 1) ";
                    }

                    break;

                case "KontrolloKodinPerModifikoArtikull":
                    //varInt1 --> idArtikulli
                    //varString1 --> emri i ri i artikullit
                    strSql = "SELECT EMRI FROM ARTIKUJT WHERE EMRI = '" + varString1 + "' AND NOT (ID_ARTIKULLI = " + varInt1 + ")";
                    break;

                case "ModifikoPathiFotoArtikulli":
                    //varInt1 --> idArtikulli
                    //varString1 --> pathi i ri i fotos se artikullit
                    strSql = "UPDATE ARTIKUJT SET FOTO = '" + varString1 + "' WHERE ID_ARTIKULLI = " + varInt1;
                    break;

                case "KontrolloKodiPerModifikoPersonel":
                    //varInt1 --> idPersoneli
                    //varString1 --> emri i perdoruesit 
                    strSql = "SELECT PERDORUESI FROM PERSONELI WHERE (PERDORUESI = '" + varString1 + "') AND NOT (ID_PERSONELI = " + varInt1 + ")";
                    break;

                case "KontrolloKodiPerModifikoPersonelFjalekalimi":
                    //varInt1 --> idPersoneli
                    //varString1 --> emri i perdoruesit 
                    strSql = "SELECT PERDORUESI FROM PERSONELI WHERE (FJALEKALIMI = '" + varString1 + "') AND NOT (ID_PERSONELI = " + varInt1 + ")";
                    break;

                case "ModifikoPathiFotoPersoneli":
                    //varInt1 --> idPersoneli
                    //varString1 --> pathi i ri i fotos se personelit
                    strSql = "UPDATE PERSONELI SET FOTO = '" + varString1 + "' WHERE ID_PERSONELI = " + varInt1;
                    break;

                case "ShfaqKategoriTavolinePerEmerPerjashtoId":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    strSql = "SELECT * FROM KATEGORITE_TAVOLINAT WHERE PERSHKRIMI = '" + varString1 + "' AND " +
                        " NOT ID_KATEGORIATAVOLINA = " + varInt1;
                    break;

                case "ModifikoKategoriTavoline":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    strSql = "UPDATE KATEGORITE_TAVOLINAT SET PERSHKRIMI = '" + varString1 + "' WHERE " +
                        " ID_KATEGORIATAVOLINA = " + varInt1;
                    break;
                case "ShfaqKategoriteEArtikujvePerEmerPerjashtoId":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    strSql = "SELECT * FROM KATEGORITE_ARTIKUJT WHERE PERSHKRIMI = '" + varString1 + "' AND " +
                        " NOT ID_KATEGORIAARTIKULLI = " + varInt1;
                    break;

               
                case "ShfaqKategoriteERecetavePerEmerPerjashtoId":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    strSql = "SELECT * FROM KATEGORITE_RECETAT WHERE PERSHKRIMI = '" + varString1 + "' AND " +
                        " NOT ID_KATEGORIARECETA = " + varInt1;
                    break;

                case "ModifikoKategoriRecete":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    strSql = "UPDATE KATEGORITE_RECETAT SET PERSHKRIMI = '" + varString1 + "' WHERE " +
                        " ID_KATEGORIARECETA = " + varInt1;
                    break;

                case "ShfaqKategoriteEShpenzimevePerEmerPerjashtoId":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    strSql = "SELECT * FROM KATEGORITE_SHPENZIMET WHERE PERSHKRIMI = '" + varString1 + "' AND " +
                        " NOT ID_KATEGORIASHPENZIMI = " + varInt1;
                    break;
                case "ModifikoKategoriShpenzimi":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    strSql = "UPDATE KATEGORITE_SHPENZIMET SET PERSHKRIMI = '" + varString1 + "' WHERE " +
                        " ID_KATEGORIASHPENZIMI = " + varInt1;
                    break;
                case "ShfaqNjesitePerEmerPerjashtoId":
                    //varInt1 --> idNjesia
                    //varString1 --> emri i ri i njesise
                    strSql = "SELECT * FROM NJESITE WHERE NJESIA = '" + varString1 + "' AND " +
                        " NOT ID_NJESIA = " + varInt1;
                    break;
                case "ModifikoNjesi":
                    //varInt1 --> idNjesia
                    //varString1 --> emri i ri i njesise
                    strSql = "UPDATE NJESITE SET NJESIA = '" + varString1 + "' WHERE " +
                        " ID_NJESIA = " + varInt1;
                    break;
                case "ShfaqFormePagesePerEmerPerjashtoId":
                    //varInt1 --> idNjesia
                    //varString1 --> emri i ri i njesise
                    strSql = "SELECT * FROM FORMA_PAGESA WHERE FORMA_PAGESA = '" + varString1 + "' AND " +
                        " NOT ID_FORMAPAGESA = " + varInt1;
                    break;

                case "ModifikoFjalekalim":
                    //varInt1 --> idPersoneli
                    //varString1 --> fjalekalimi i ri
                    strSql = "UPDATE PERSONELI SET FJALEKALIMI = '" + varString1 + "' WHERE ID_PERSONELI = " + varInt1;
                    break;

                case "KontrolloBlerjeSipasFurnitoritDheFatures":
                    //varInt1 --> idFurnitori
                    //varString1 --> numri i fatures
                    strSql = "SELECT  * FROM BLERJET WHERE ID_FURNITORI = " + varInt1 + " AND NR_FATURE = '" + varString1 + "'";
                    break;

                case "ShtoRecete":
                    //varInt1 --> idKategoriaReceta
                    //varString1 --> emri i recetes
                    strSql = "INSERT INTO RECETAT(ID_KATEGORIARECETA, EMRI, DISPONUESHEM, AKTIVE) VALUES(" + varInt1 + ", '" + varString1 + "', 1, 1)";
                    strSql += Environment.NewLine + "SELECT SCOPE_IDENTITY()";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, string varString1, decimal varDec1)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            switch (kerkesaQuery)
            {
                case "ModifikoFormePagese":
                    //varInt1 --> idNjesia
                    //varString1 --> emri i ri i njesise
                    strSql = "UPDATE FORMA_PAGESA SET FORMA_PAGESA = '" + varString1 + "', KOMISIONI = " + varDec1 + " WHERE " +
                        " ID_FORMAPAGESA = " + varInt1;
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, DataSet varDs)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ModifikoGrupCmiminZgjedhur":
                    //varDs --> id e grupeve

                    strSql = "";
                    int idGrupCmimi = 0;
                    bool zgjedhurGrup = false;
                    string strZgjedhur = "0";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        idGrupCmimi = Convert.ToInt32(dr["ID_GRUPCMIMI"]);
                        zgjedhurGrup = Convert.ToBoolean(dr["ZGJEDHUR"]);

                        if (zgjedhurGrup == true)
                        {
                            strZgjedhur = "1";
                        }
                        else
                        {
                            strZgjedhur = "0";
                        }

                        strSql += "UPDATE GRUP_CMIMET SET ZGJEDHUR = " + strZgjedhur + "  WHERE ID_GRUPCMIMI = " + idGrupCmimi  + Environment.NewLine;

                    }

                    break;
                    
                case "ShfaqArtikujtPerKostoBlerje":
                    //varDs --> id e artikujve

                    strSql = "";
                    int idArtikulli = 0;
                    string strKushti = "(";
                    foreach (DataRow dr in varDs.Tables[1].Rows)
                    {

                        idArtikulli = Convert.ToInt32(dr["ID_ARTIKULLI"]);

                        strKushti = strKushti + " " + idArtikulli.ToString() + ",";

                    }

                    strKushti = strKushti.Substring(0, strKushti.Length - 1);

                    strKushti = strKushti + ")";

                    strSql = "SELECT ID_ARTIKULLI, NUMRI_TOTAL, KOSTO FROM ARTIKUJT WHERE ID_ARTIKULLI IN " + strKushti;

                    break;

                case "KtheKufirinPerRecetat":
                    //varDs --> id e recetave

                    strSql = "";
                   
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {

                        strSql = "";

                    }

                    break;

                case "MbyllGjitheTurnet":
                    //varDs --> id e artikujve me sasite perkatese

                    strSql = "";
                    int idKamarieri = 0; ;
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        idKamarieri = Convert.ToInt32(dr[0]);
                        strSql += "UPDATE TURNET SET MBYLLUR = 1 , MBARIMI = GETDATE() WHERE ID_PERSONELI = " + idKamarieri + " AND MBYLLUR = 0 " + Environment.NewLine;

                    }

                    break;

                case "ModifikoSasiaPerArtikujtPerAnullim":
                    //varDs --> id e artikujve me sasite perkatese

                    strSql = "";
                    string sasia = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        sasia = this.FormatoNumrinDecimal(Convert.ToDouble(dr["SASIA"]));
                        strSql += "UPDATE ARTIKUJT SET NUMRI_TOTAL = NUMRI_TOTAL + " + sasia + " WHERE ID_ARTIKULLI = " + Convert.ToInt32(dr["CELESI"]) + " " + Environment.NewLine;

                    }

                    break;

                case "ModifikoSasiaPerArtikujt" :
                    //varDs --> id e artikujve me sasite perkatese
                  
                    strSql = "";
                    string sasia1 = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        sasia1 = this.FormatoNumrinDecimal(Convert.ToDouble(dr["SASIA"]));
                        strSql += "UPDATE ARTIKUJT SET NUMRI_TOTAL = NUMRI_TOTAL - " + sasia1 + " WHERE ID_ARTIKULLI = " + Convert.ToInt32(dr["CELESI"]) + " " + Environment.NewLine;

                    }
                    
                    break;

                case "HidhFavorite" :
                    //varDs --> id e artikujve qe jane zgjedhur si te preferuar
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "INSERT INTO FAVORITE (ID_FAVORITE, EMRI, LLOJI, PRIORITETI) VALUES(" + Convert.ToInt32(dr["ID_FAVORITE"]) + ", '" + Convert.ToString(dr["EMRI"]) + "', '" + Convert.ToString(dr["LLOJI"]) + "', '" + Convert.ToInt32(dr["PRIORITETI"]) + "')" + Environment.NewLine;

                    }
                    break;

                case "FshiArtikujt":
                    //varDs --> id e artikujve qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "UPDATE ARTIKUJT SET DISPONUESHEM = 0 WHERE ID_ARTIKULLI = " + Convert.ToInt32(dr["ID_ARTIKULLI"]) + Environment.NewLine;
                    }
                    break;

                case "AktivizoArtikujt":
                    //varDs --> id e artikuve
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "UPDATE ARTIKUJT SET DISPONUESHEM = 1 " +
                                  "WHERE ID_ARTIKULLI = " + Convert.ToInt32(dr["ID_ARTIKULLI"]) + Environment.NewLine;
                    }
                    break;

                case "CaktivizoArtikujt":
                    //varDs --> id e artikuve
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "UPDATE ARTIKUJT SET DISPONUESHEM = 0 " +
                                  "WHERE ID_ARTIKULLI = " + Convert.ToInt32(dr["ID_ARTIKULLI"]) + Environment.NewLine;
                    }
                    break;

                case "FshiKategoriteETavolinave":
                    //varDs --> id e kategorive qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM KATEGORITE_TAVOLINAT WHERE ID_KATEGORIATAVOLINA = "
                            + Convert.ToInt32(dr["ID_KATEGORIATAVOLINA"]) + Environment.NewLine;
                    }
                    break;

                case "FshiTavolinat":
                    //varDs --> id e tavolinave qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM TAVOLINAT WHERE ID_TAVOLINA = "
                            + Convert.ToInt32(dr["ID_TAVOLINA"]) + Environment.NewLine;
                    }
                    break;

                case "FshiKategoriteEArtikujve":
                    //varDs --> id e kategorive qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM KATEGORITE_ARTIKUJT WHERE ID_KATEGORIAARTIKULLI = "
                            + Convert.ToInt32(dr["ID_KATEGORIAARTIKULLI"]) + Environment.NewLine;
                    }
                    break;

                case "FshiKategoriteERecetave":
                    //varDs --> id e recetave qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM KATEGORITE_RECETAT WHERE ID_KATEGORIARECETA = "
                            + Convert.ToInt32(dr["ID_KATEGORIARECETA"]) + Environment.NewLine;
                    }
                    break;

                case "FshiRecetatNgaFavoritet":
                    //varDs --> id e recetave qe duhet te fshihen nga favoritet
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM FAVORITE WHERE ID_FAVORITE = " + Convert.ToInt32(dr["ID_RECETA"]) + Environment.NewLine;
                    }
                    break;

                case "FshiKategoriteEShpenzimeve":
                    //varDs --> id e recetave qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM KATEGORITE_SHPENZIMET WHERE ID_KATEGORIASHPENZIMI = "
                            + Convert.ToInt32(dr["ID_KATEGORIASHPENZIMI"]) + Environment.NewLine;
                    }
                    break;

                case "FshiNjesite":
                    //varDs --> id e recetave qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM NJESITE WHERE ID_NJESIA = "
                            + Convert.ToInt32(dr["ID_NJESIA"]) + Environment.NewLine;
                    }
                    break;

                case "FshiFormatEPageses":
                    //varDs --> id e formave te pageses qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM FORMA_PAGESA WHERE ID_FORMAPAGESA = "
                            + Convert.ToInt32(dr["ID_FORMAPAGESA"]) + Environment.NewLine;
                    }
                    break;

                case "FshiFurnitoret":
                    //varDs --> id e furnitoreve qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM ARTIKUJT_FURNITORET WHERE ID_FURNITORI = " +
                            Convert.ToInt32(dr["ID_FURNITORI"]) + Environment.NewLine;
                        strSql += "UPDATE BLERJET SET ID_FURNITORI = NULL WHERE ID_FURNITORI = "
                            + Convert.ToInt32(dr["ID_FURNITORI"]) + Environment.NewLine;
                        strSql += "DELETE FROM FURNITORET WHERE ID_FURNITORI = "
                            + Convert.ToInt32(dr["ID_FURNITORI"]) + Environment.NewLine;
                    }
                    break;

                case "FshiKlientet":
                    //varDs --> id e klienteve qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM KLIENTET_RESTORANTI WHERE ID_KLIENTI = " +
                            Convert.ToInt32(dr["ID_KLIENTI"]) + Environment.NewLine;
                        strSql += "UPDATE FATURAT SET ID_KLIENTI = NULL WHERE ID_KLIENTI = "
                            + Convert.ToInt32(dr["ID_KLIENTI"]) + Environment.NewLine;

                    }
                    break;


                case "FshiShpenzimet":
                    //varDs --> id e shpenzimeve qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += "DELETE FROM SHPENZIMET WHERE ID_SHPENZIMI = "
                            + Convert.ToInt32(dr["ID_SHPENZIMI"]) + Environment.NewLine;
                    }
                    break;

                case "FshiRezervimeSkaduara":
                    //varDs --> id e shpenzimeve qe duhet te fshihen
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "DELETE FROM REZERVIMI_TAVOLINAT WHERE ID_REZERVIMI = " +
                            Convert.ToInt32(dr["ID_REZERVIMI"]) + Environment.NewLine;
                        strSql += Environment.NewLine + "DELETE FROM REZERVIMET WHERE ID_REZERVIMI = "
                            + Convert.ToInt32(dr["ID_REZERVIMI"]);
                    }
                    break;

                case "Logout":
                    //varDs --> kamarieret per tu caktivizuar
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "UPDATE PERSONELI SET AKTIV = 0 WHERE ID_PERSONELI = " +
                            Convert.ToInt32(dr["ID_PERSONELI"]);
                    }
                    break;

                case "MbyllTurnKamarieri":
                    //varDs --> kamarieret per tu caktivizuar
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "UPDATE TURNET SET MBARIMI = GETDATE() WHERE ID_TURNI = (" +
                            "SELECT MAX(ID_TURNI) FROM TURNET WHERE ID_PERSONELI = " +
                            Convert.ToInt32(dr["ID_PERSONELI"]) + ")";
                    }
                    break;

                case "ModifikoSasiteArtikujt":
                    //varDs --> dataseti mban idEArtikujve qe kane marre pjese ne blerjen e pamodifikuar
                    //dhe sasite perkatese
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "UPDATE ARTIKUJT SET NUMRI_TOTAL = NUMRI_TOTAL - " +
                            Convert.ToDecimal(dr["SASIA"]) + " WHERE ID_ARTIKULLI = " +
                            Convert.ToInt32(dr["ID_ARTIKULLI"]);
                    }
                    break;

                case "SasitePerkateseTeArtikujvePerBlerjen":

                    //vards --> dataseti qe mban id e blerjeve
                    strSql = "SET CONCAT_NULL_YIELDS_NULL OFF";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "SELECT ID_ARTIKULLI, SUM(SASIA) AS SASIA FROM VIZUALIZIM_BLERJET " +
                                " WHERE ID_BLERJA = " + Convert.ToInt32(dr["ID_BLERJA"]) +
                                " GROUP BY ID_ARTIKULLI" + " SET CONCAT_NULL_YIELDS_NULL ON"; ;
                    }
                    break;

                case "NumriTotalArtikujtNeBlerje":
                    //vards --> dataseti qe mban id e blerjeve
                    strSql = "SET CONCAT_NULL_YIELDS_NULL OFF";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "SELECT ID_ARTIKULLI,EMRI, NUMRI_TOTAL FROM ARTIKUJT " +
                                " WHERE ID_ARTIKULLI IN (SELECT ID_ARTIKULLI FROM " +
                                " VIZUALIZIM_BLERJET WHERE ID_BLERJA = " + Convert.ToInt32(dr["ID_BLERJA"]) +
                                " GROUP BY ID_ARTIKULLI)" + " SET CONCAT_NULL_YIELDS_NULL ON"; ;
                    }
                    break;
                case "FshiPerkatesiArtikuj":
                    //vards --> dataseti qe mban id e blerjeve
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "DELETE FROM ARTIKUJT_FURNITORET WHERE ID_FURNITORI = " + Convert.ToInt32(dr["ID_FURNITORI"]) +
                            " AND ID_ARTIKULLI = " + Convert.ToInt32(dr["ID_ARTIKULLI"]);
                    }
                    break;

                case "KrijoPeriudhaTeRejaPerArtikujtDheRecetatMeIntervale":
                    //varDs --> dataseti ka dy datatable
                    //1 --> artikujt e ndare ne intervale
                    //2 --> recetat e ndara ne intervale
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "UPDATE CMIMET_PERIUDHA SET DATE_MBARIMI = GETDATE() WHERE ID_CMIMIPERIUDHA = " + Convert.ToInt32(dr["ID_CMIMIPERIUDHA"]);
                        strSql += Environment.NewLine + "INSERT INTO CMIMET_PERIUDHA(ID_ARTIKULLI, DATE_FILLIMI) VALUES(" + Convert.ToInt32(dr["ID_ARTIKULLI"]) + ", GETDATE())";
                    }
                    foreach (DataRow dr in varDs.Tables[1].Rows)
                    {
                        strSql += Environment.NewLine + "UPDATE CMIMET_PERIUDHA_RECETAT SET DATE_MBARIMI = GETDATE() WHERE ID_CMIMIPERIUDHA = " + Convert.ToInt32(dr["ID_CMIMIPERIUDHA"]);
                        strSql += Environment.NewLine + "INSERT INTO CMIMET_PERIUDHA_RECETAT(ID_RECETA, DATE_FILLIMI) VALUES(" + Convert.ToInt32(dr["ID_RECETA"]) + ", GETDATE())";
                    }
                    break;

                case "RuajIntervalet":
                    //varDs --> dataseti ka per rreshta te dhenat per intervalet e krijuar
                    strSql = "DELETE FROM PERIUDHAT";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "INSERT INTO PERIUDHAT VALUES('" +
                            Convert.ToDateTime(dr["ORE_FILLIMI"]).ToString("HH:mm") + "','" +
                            Convert.ToDateTime(dr["ORE_MBARIMI"]).ToString("HH:mm") + "')";
                    }
                    break;

                case "FshiRecetat":
                    //varDs --> dataseti ka per rreshta recetat qe duhen fshire
                    strSql = "";
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "UPDATE RECETAT SET AKTIVE = 0 WHERE ID_RECETA = " + Convert.ToInt32(dr["ID_RECETA"]);
                    }
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, DataSet varDs, DataSet varDs1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "FshiBlerjet":
                    //vards --> dataseti qe mban id e blerjeve
                    strSql = "";
                    int i = 0;
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "DELETE FROM OFERTAT_BLERJE WHERE ID_BLERJEARTIKUJ IN ( " +
                            " SELECT ID_BLERJEARTIKUJ FROM BLERJET_ARTIKUJT WHERE ID_BLERJA= " + Convert.ToInt32(dr["ID_BLERJA"]) + ")";
                        strSql += Environment.NewLine + "DELETE FROM BLERJET_ARTIKUJT WHERE ID_BLERJA = " + Convert.ToInt32(dr["ID_BLERJA"]);
                        strSql += Environment.NewLine + "DELETE FROM BLERJET WHERE ID_BLERJA = " + Convert.ToInt32(dr["ID_BLERJA"]);
                        foreach (DataRow r in varDs1.Tables[i].Rows)
                        {
                            strSql += Environment.NewLine + "UPDATE ARTIKUJT SET NUMRI_TOTAL = NUMRI_TOTAL - " + Convert.ToDouble(r["SASIA"]) +
                                " WHERE ID_ARTIKULLI = " + Convert.ToInt32(r["ID_ARTIKULLI"]);
                        }
                        i++;
                    }
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ShfaqEkstratPerReceten" :
                    strSql = "SELECT ID_EKSTRA, KEKSTRA FROM EKSTRAT WHERE ID_RECETA = " + varInt1;
                    break;

                case "FshiEkstratPerRecete" :
                    strSql = "DELETE FROM EKSTRAT WHERE ID_RECETA = " + varInt1;
                    break;

                case "ModifikoKostoVilaX" :
                        strSql = "UPDATE ARTIKUJT SET NUMRI_TOTAL = (SELECT SASIA FROM BLERJET_ARTIKUJT WHERE ID_ARTIKULLI = " + varInt1 + ") WHERE ID_ARTIKULLI = " + varInt1;
                        break;

                case "FshiGrupCmimi" :
                    //varInt1 --> idGrupCmimi
                    strSql = "DELETE FROM RECETA_CMIMET WHERE ID_GRUPCMIMI = " + varInt1;
                    strSql = strSql + Environment.NewLine + "DELETE FROM GRUP_CMIMET WHERE ID_GRUPCMIMI = " + varInt1;
                    break;
                
                case "AktivizoArtikull" :
                    //varInt1 --> idArtikulli;
                    strSql = "UPDATE ARTIKUJT SET DISPONUESHEM = 1";
                    break;

                case "ZgjidhGrupCmimi" :
                    //varInt1 --> idGrupCmimi
                    strSql = "UPDATE GRUP_CMIMET SET ZGJEDHUR = 1 WHERE ID_GRUPCMIMI = " + varInt1;
                    break;

                case "ShfaqFaturatKorentePerTavoline" :
                    //varInt1 --> idTavolina
                    strSql = "SELECT ID_FATURA FROM TAVOLINA_FATURAT WHERE ID_TAVOLINA = " + varInt1;
                    break;

                case "FshiLidhjetFaturePerTavoline" :
                    //varInt1 --> idTavolina
                    strSql = "DELETE FROM TAVOLINA_FATURAT WHERE ID_TAVOLINA = " + varInt1;
                    break;

                case "KtheIdRoli":
                    //varInt1 --> idPerdoruesi
                    strSql = "SELECT ID_ROLI FROM PERSONELI WHERE ID_PERSONELI = " + varInt1;
                    break;

                case "ShfaqCmimeRecetatPerGrupinZgjedhur" :
                    //varInt1 --> idGrupcmimi
                    strSql = "SELECT R.ID_RECETA, R.EMRI, R.ID_KATEGORIARECETA, K.PERSHKRIMI, RC.CMIMI , SUM(RA.SASIA * A.KOSTO) AS KOSTO " +
                             "FROM RECETAT AS R INNER JOIN KATEGORITE_RECETAT AS K ON R.ID_KATEGORIARECETA = K.ID_KATEGORIARECETA " +
                             "INNER JOIN RECETA_CMIMET AS  RC ON R.ID_RECETA = RC.ID_RECETA " +
                             "INNER JOIN RECETA_ARTIKUJT AS RA ON R.ID_RECETA = RA.ID_RECETA " +
                             "INNER JOIN ARTIKUJT AS A ON RA.ID_ARTIKULLI = A.ID_ARTIKULLI " +
                             "WHERE RC.ID_GRUPCMIMI = " + varInt1 + " AND R.AKTIVE = 1 " +
                             "GROUP BY R.ID_RECETA, R.EMRI, R.ID_KATEGORIARECETA,  K.PERSHKRIMI,  RC.CMIMI " +
                             "ORDER BY R.EMRI ";
                    break;

                case "KtheTurninLast" :
                    //varInt1 --> idPerdoruesi
                    strSql = "SELECT ID_TURNI, FILLIMI, MBARIMI, ID_PERSONELI, MBYLLUR FROM TURNET " +
                             "WHERE MBYLLUR = 0 AND ID_PERSONELI = " + varInt1;
                    break;

                case "FshiRecetatPerOferte" :
                    //varInt1 --> idOferta
                    strSql = "DELETE FROM OFERTA_RECETAT WHERE ID_OFERTA = " + varInt1;
                    break;

                case "ShfaqTeDhenaPerOferten" :
                    strSql = "SELECT O.ID_RECETA, R.ID_KATEGORIARECETA, SHPORTA, R.EMRI AS RECETA, O.SASIA " +
                             "FROM OFERTA_RECETAT AS O INNER JOIN RECETAT AS R ON O.ID_RECETA = R.ID_RECETA " +
                             "WHERE ID_OFERTA = " + varInt1 + " ORDER BY SHPORTA ASC ";
                    break;

                case "ShfaqRecetatPerKategoriOferte" :
                    //varInt1 --> idKategoriaRecete
                    strSql = "SELECT ID_RECETA, EMRI FROM RECETAT WHERE ID_KATEGORIARECETA = " + varInt1 + " AND AKTIVE = 1";
                    break;

                case "KtheTeDhenaPerFaturenPc" :
                    //varInt1 --> idFatura
                    strSql = "SELECT ID_FATURA, DATA_ORA, NR_FATURE, F.ID_TAVOLINA, T.EMRI AS TAVOLINA, P.ID_PERSONELI , P.EMRI AS KAMARIERI, SKONTO, TOTALI " +
                             "FROM FATURAT AS F INNER JOIN TAVOLINAT AS T ON F.ID_TAVOLINA = T.ID_TAVOLINA " +
                             "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                             "WHERE ID_FATURA = " + varInt1;
                    break;

                case "KtheRecetatPerPrintoPC" :
                    //varInt1 --> idFatura
                    strSql = "SELECT ID_RECETA AS CELESI , SASIA FROM FATURA_RECETAT WHERE ID_FATURA = " + varInt1;
                    break;

                case "ShfaqShpenzimetVitin" :
                    //varInt1 --> viti
                    strSql = "SELECT  'MUAJI'=MONTH(DATA), SUM(SASIA) AS SHPENZIMI " +
                             "FROM SHPENZIMET " +
                             "WHERE YEAR(DATA) = " + varInt1 + " " +
                             "GROUP BY MONTH(DATA) ORDER BY 1";
                    break;

                case "ShfaqShpenzimetMujorePerVitin" :
                    //varInt1 --> viti
                    strSql = "SELECT MUAJI, VLERA AS SHPENZIMI_MUJOR " +
                             "FROM SHPENZIMET_MUJORE " +
                             "WHERE VITI = " + varInt1 + " " +
                             "ORDER BY MUAJI";
                    break;

                case "ShfaqBlerjetPerVitin" :
                    //varInt1 --> viti
                    strSql = "SELECT  'MUAJI'=MONTH(B.DATA_BLERJE), SUM(SASIA * CMIMI) AS BLERJE " +
                             "FROM BLERJET_ARTIKUJT AS BA INNER JOIN BLERJET AS B ON BA.ID_BLERJA = B.ID_BLERJA " +
                             "WHERE YEAR(B.DATA_BLERJE) = " + varInt1 + " " +
                             "GROUP BY MONTH(B.DATA_BLERJE) ORDER BY 1";
                    break;

                case "ShfaqXhiroPerVitin":
                    // varInt1 --> viti
                    strSql = "SELECT  'MUAJI'=MONTH(DATA_ORA), SUM(TOTALI - SKONTO) AS XHIRO " +
                             "FROM FATURAT " +
                             "WHERE YEAR(DATA_ORA) = " + varInt1 + " AND ANULLUAR = 0 " +
                             "GROUP BY MONTH(DATA_ORA), ANULLUAR " +
                             "ORDER BY 1";
                    break;

                case "FshiLidhjenFaturaRecetat" :
                    //varInt1 --> idFatura
                    strSql = "DELETE FROM FATURA_RECETAT WHERE ID_FATURA = " + varInt1;
                    break;

                case "AnulloFaturen" :
                    //varInt1 --> idFatura
                    strSql = "UPDATE FATURAT SET ANULLUAR = 1 WHERE ID_FATURA = " + varInt1;
                    break;

                case "ShfaqTeDhenaPerFaturen" :
                    //varInt1 --> idFatura
                    strSql = "SELECT F.ID_FATURA, F.NR_FATURE, FR.ID_RECETA, R.EMRI, FR.CMIMI AS VLERA , FR.SASIA , (FR.CMIMI * FR.SASIA) AS TOTALI " +
                             "FROM FATURAT AS F " +
                             "INNER JOIN FATURA_RECETAT AS FR ON F.ID_FATURA = FR.ID_FATURA " +
                             "INNER JOIN RECETAT AS R ON FR.ID_RECETA = R.ID_RECETA " +
                             "WHERE F.ID_FATURA IN (" + varInt1 + ") " +
                             "ORDER BY FR.ID_RECETA";
                    break;

                case "KtheTurninKorent" :
                    //varInt1 --> idKamarieri
                    strSql = "SELECT * FROM TURNET WHERE ID_PERSONELI = " + varInt1 + " AND MBYLLUR = 0";
                    break;

                case "MbyllTurnin" :
                    //varInt1 --> idKamarieri
                    strSql = "UPDATE TURNET SET MBYLLUR = 1 , MBARIMI = GETDATE() WHERE ID_PERSONELI = " + varInt1 + " AND MBYLLUR = 0";
                    break;

                case "FshiPerdorues" :
                    //varInt1 --> idPerdoruesi
                    strSql = "UPDATE PERSONELI SET DISPONUESHEM = 0 WHERE ID_PERSONELI = " + varInt1;
                    break;

                case "LexoXhironPerKamarierin" :
                    //variNT1 --> idKamarieri
                    strSql = "SELECT F.ID_FATURA, F.NR_FATURE, FR.ID_RECETA, R.EMRI, FR.CMIMI AS VLERA , FR.SASIA , (FR.CMIMI * FR.SASIA) AS TOTALI " +
                             "FROM FATURAT AS F INNER JOIN FATURA_RECETAT AS FR ON F.ID_FATURA = FR.ID_FATURA " +
                             "INNER JOIN RECETAT AS R ON FR.ID_RECETA = R.ID_RECETA " +
                             "WHERE (F.ANULLUAR = 0) AND (MONTH(F.DATA_ORA) = MONTH(GETDATE()) AND DAY(F.DATA_ORA) = DAY(GETDATE()) AND YEAR(F.DATA_ORA) = YEAR(GETDATE())) AND CP.DATE_MBARIMI IS NULL " +
                             "AND F.ID_PERSONELI = " + varInt1 + " ORDER BY FR.ID_RECETA ";
                    break;

                case "ShfaqRecetatPerKategoriKonfigurimCmimesh" :
                    //varInt1 -->idKategoriaReceta
                    strSql = "SELECT R.ID_RECETA, R.EMRI, SUM(RA.SASIA * KA.KOSTO) AS KOSTO " +
                             "FROM RECETAT AS R INNER JOIN RECETA_ARTIKUJT AS RA ON R.ID_RECETA = RA.ID_RECETA " +
                             "LEFT JOIN (SELECT ID_ARTIKULLI, CMIMI AS KOSTO FROM BLERJET_ARTIKUJT AS B WHERE CMIMI <> 0 " +
                             "AND ID_BLERJEARTIKUJ >= (SELECT MAX(ID_BLERJEARTIKUJ) FROM BLERJET_ARTIKUJT AS BA WHERE BA.ID_ARTIKULLI = B.ID_ARTIKULLI)) AS KA " +
                             "ON RA.ID_ARTIKULLI = KA.ID_ARTIKULLI " +
                             "WHERE R.ID_KATEGORIARECETA = " + varInt1 + " " +
                             "GROUP BY R.ID_RECETA, R.EMRI ";
                    break;

                case "ShfaqArtikujtPerKategoriPerKonfigurimCmimesh" :
                    //varInt1 --> idKategoriaArtikulli
                    strSql = "SELECT A.ID_ARTIKULLI, A.EMRI,  B.CMIMI " +
                             "FROM ARTIKUJT AS A LEFT JOIN (SELECT ID_ARTIKULLI, CMIMI, SASIA, KONSUMUAR " +
                             "FROM BLERJET_ARTIKUJT AS BA1 WHERE ID_BLERJEARTIKUJ = (SELECT MAX(ID_BLERJEARTIKUJ) " +
                             "FROM BLERJET_ARTIKUJT AS BA2 WHERE BA2.ID_ARTIKULLI = BA1.ID_ARTIKULLI)) AS B " +
                             "ON A.ID_ARTIKULLI = B.ID_ARTIKULLI " +
                             "WHERE A.ID_KATEGORIAARTIKULLI = " + varInt1;
                    break;

                case "LexoSasineMinimalePerReceten" :
                    //varInt1 --> idFatura
                    strSql = "SELECT MIN(A.NUMRI_TOTAL/RA.SASIA) AS NR " +
                             "FROM RECETA_ARTIKUJT AS RA INNER JOIN ARTIKUJT AS A ON RA.ID_ARTIKULLI = A.ID_ARTIKULLI " +
                             "WHERE RA.ID_RECETA = " + varInt1;
                    break;

                case "LexoBlerjeArtikujshPerKonsumPerRecetat" :
                    //varInt1 --> idFatura
                    strSql = "SELECT ID_BLERJEARTIKUJ, ID_ARTIKULLI, SASIA, KONSUMUAR " +
                             "FROM BLERJET_ARTIKUJT WHERE ID_ARTIKULLI IN " +
                             "(SELECT ID_ARTIKULLI FROM RECETA_ARTIKUJT WHERE ID_RECETA IN " +
                             "(SELECT ID_RECETA FROM FATURA_RECETAT WHERE ID_FATURA = " + varInt1 + ")) " +
                             "AND SASIA <> KONSUMUAR";
                    break;

                case "LexoBlerjeArtikujshPerKonsumPerOfertat":
                    //varInt1 --> idFatura
                    strSql = "SELECT ID_BLERJEARTIKUJ, ID_ARTIKULLI, SASIA, KONSUMUAR " +
                             "FROM BLERJET_ARTIKUJT WHERE ID_ARTIKULLI IN " +
                             "(SELECT ID_ARTIKULLI FROM RECETA_ARTIKUJT WHERE ID_RECETA IN " +
                             "(SELECT ID_RECETA FROM FATURAOFERTA_RECETAT WHERE ID_FATURAOFERTA IN (SELECT ID_FATURAOFERTA FROM FATURA_OFERTAT WHERE ID_FATURA = " + varInt1 + "))) " +
                             "AND SASIA <> KONSUMUAR";
                    break;

                case "LexoBlerjeArtikujshPerKonsumPerRecetatPerAnullim":
                    //varInt1 --> idFatura
                    strSql = "SELECT ID_BLERJEARTIKUJ, ID_ARTIKULLI, SASIA, KONSUMUAR " +
                             "FROM BLERJET_ARTIKUJT WHERE ID_ARTIKULLI IN " +
                             "(SELECT ID_ARTIKULLI FROM RECETA_ARTIKUJT WHERE ID_RECETA IN " +
                             "(SELECT ID_RECETA FROM FATURA_RECETAT WHERE ID_FATURA = " + varInt1 + ")) " +
                             "ORDER BY ID_BLERJEARTIKUJ DESC ";
                    break;

                case "LexoBlerjeArtikujshPerKonsum":
                    //varInt1 --> idFatura
                    strSql = "SELECT ID_BLERJEARTIKUJ, ID_ARTIKULLI, SASIA, KONSUMUAR FROM BLERJET_ARTIKUJT WHERE ID_ARTIKULLI IN (SELECT ID_ARTIKULLI FROM FATURA_ARTIKUJT WHERE ID_FATURA = " + varInt1 + ") AND SASIA <> KONSUMUAR";
                    break;

                case "KtheArtikujtSasitePerRecetat":
                    //varInt1 --> idFatura
                    strSql = "SELECT RA.ID_ARTIKULLI AS CELESI, SUM(RA.SASIA * FA.SASIA) AS SASIA , SUM((RA.SASIA * FA.SASIA) * A.KOSTO) AS KOSTO " +
                             "FROM FATURA_RECETAT AS FA INNER JOIN RECETA_ARTIKUJT AS RA  ON FA.ID_RECETA = RA.ID_RECETA " +
                             "INNER JOIN ARTIKUJT AS A ON RA.ID_ARTIKULLI = A.ID_ARTIKULLI " +
                             "WHERE FA.ID_FATURA = " + varInt1 + " GROUP BY RA.ID_ARTIKULLI";
                    break;

                case "KtheArtikujtSasitePerOfertat":
                    //varInt1 --> idFatura
                    strSql = "SELECT RA.ID_ARTIKULLI AS CELESI, SUM(FR.SASIA * RA.SASIA) AS SASIA " +
                             "FROM FATURAOFERTA_RECETAT AS FR INNER JOIN RECETA_ARTIKUJT AS RA " +
                             "ON FR.ID_RECETA = RA.ID_RECETA " +
                             "WHERE ID_FATURAOFERTA IN (SELECT ID_FATURAOFERTA FROM FATURA_OFERTAT " +
                             "WHERE ID_FATURA = " + varInt1 + ") " +
                             "GROUP BY RA.ID_ARTIKULLI";
                    break;


                case "KtheIdCmimiLastReceta":
                    //varInt1 --> idPeriudhaCmimi
                    strSql = "SELECT * FROM CMIMET_RECETAT WHERE ID_CMIMI = (SELECT MAX(ID_CMIMI) FROM CMIMET_RECETAT WHERE ID_CMIMIPERIUDHA = " + varInt1 + ")";
                    break;

                case "KtheIdCmimiLast":
                    //varInt1 --> idPeriudhaCmimi
                    strSql = "SELECT * FROM CMIMET WHERE ID_CMIMI = (SELECT MAX(ID_CMIMI) FROM CMIMET WHERE ID_CMIMIPERIUDHA = " + varInt1 + ")";
                    break;

                case "MbyllTavoline" :
                    //varInt1 --> idTavolina
                    strSql = "UPDATE TAVOLINAT SET GJENDJA = 'L' WHERE ID_TAVOLINA = " + varInt1;
                    
                    break;

                case "HapTavoline" :
                    //varInt1 --> idTavolina
                    strSql = "UPDATE TAVOLINAT SET GJENDJA = 'Z' WHERE ID_TAVOLINA = " + varInt1;
                    break;

                case "LexoTeDhenaPerArtikullin":
                    //varInt1 --> idArtikulli
                    strSql = "SELECT ID_ARTIKULLI, ";
                    break;

                case "ShfaqCmimetEfunditPerArtikullin":
                    // varInt1 --> idArtikulli
                    strSql = "SET CONCAT_NULL_YIELDS_NULL OFF " +
                             "SELECT A.ID_ARTIKULLI, A.EMRI, A.ID_KATEGORIAARTIKULLI, K.PERSHKRIMI, P.DATE_FILLIMI, P.DATE_MBARIMI,  SUBSTRING(CONVERT(CHAR(20),C.ORE_FILLIMI, 108), 1, 5) AS ORE_FILLIMI, SUBSTRING(CONVERT(CHAR(20),C.ORE_MBARIMI, 108), 1, 5) AS ORE_MBARIMI, C.VLERA , CONVERT(varchar(11),P.DATE_FILLIMI,104)  + ' - ' + CONVERT(varchar(11),P.DATE_MBARIMI, 104) AS PERIUDHA " +
                             "FROM ARTIKUJT AS A INNER JOIN CMIMET_PERIUDHA AS P ON A.ID_ARTIKULLI = P.ID_ARTIKULLI " +
                             "INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                             "INNER JOIN CMIMET AS C ON C.ID_CMIMIPERIUDHA = P.ID_CMIMIPERIUDHA " +
                             "WHERE A.ID_ARTIKULLI = " + varInt1 + " AND P.ID_CMIMIPERIUDHA = (SELECT MAX(ID_CMIMIPERIUDHA) FROM CMIMET_PERIUDHA WHERE ID_ARTIKULLI = " + varInt1 + ") " +
                             "GROUP BY A.ID_ARTIKULLI,A.EMRI, A.ID_KATEGORIAARTIKULLI, K.PERSHKRIMI,  P.DATE_FILLIMI, P.DATE_MBARIMI, C.ORE_FILLIMI, C.ORE_MBARIMI, C.VLERA " +
                             "SET CONCAT_NULL_YIELDS_NULL ON";
                    break;

                case "KrijoPeriudhaCmimiPerReceten":
                    //varInt1 --> idReceta
                    strSql = "INSERT INTO CMIMET_PERIUDHA_RECETAT (ID_RECETA, DATE_FILLIMI) VALUES (" + varInt1 + ", GETDATE()) " +
                             "SELECT SCOPE_IDENTITY()";
                    break;

                case "KrijoPeriudhaCmimiPerArtikullin":
                    //varInt1 --> idArtikulli
                    strSql = "INSERT INTO CMIMET_PERIUDHA (ID_ARTIKULLI, DATE_FILLIMI) VALUES (" + varInt1 + ", GETDATE()) " +
                             "SELECT SCOPE_IDENTITY()";
                    break;

                case "ModifikoPeriudhaCmimiPerReceten":
                    //varInt1 --> idReceta
                    strSql = "UPDATE CMIMET_PERIUDHA_RECETAT SET DATE_MBARIMI = GETDATE() " +
                             "WHERE ID_RECETA = " + varInt1 + " AND DATE_MBARIMI IS NULL";
                    break;

                case "ModifikoPeriudhaCmimiPerArtikullin":
                    //varInt1 --> idArtikulli
                    strSql = "UPDATE CMIMET_PERIUDHA SET DATE_MBARIMI = GETDATE() " +
                             "WHERE ID_ARTIKULLI = " + varInt1 + " AND DATE_MBARIMI IS NULL";
                    break;

                case "ShfaqCmimetPerArtikullin":
                    // varInt1 --> idArtikulli
                    strSql = "SET CONCAT_NULL_YIELDS_NULL OFF " +
                              "SELECT A.ID_ARTIKULLI, A.EMRI, A.ID_KATEGORIAARTIKULLI, K.PERSHKRIMI, P.DATE_FILLIMI, P.DATE_MBARIMI,  SUBSTRING(CONVERT(CHAR(20),C.ORE_FILLIMI, 108), 1, 5) AS ORE_FILLIMI, SUBSTRING(CONVERT(CHAR(20),C.ORE_MBARIMI, 108), 1, 5) AS ORE_MBARIMI, C.VLERA , CONVERT(varchar(11),P.DATE_FILLIMI,104)  + ' -- ' + CONVERT(varchar(11),P.DATE_MBARIMI, 104) AS PERIUDHA " +
                              "FROM ARTIKUJT AS A INNER JOIN CMIMET_PERIUDHA AS P ON A.ID_ARTIKULLI = P.ID_ARTIKULLI " +
                              "INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                              "INNER JOIN CMIMET AS C ON C.ID_CMIMIPERIUDHA = P.ID_CMIMIPERIUDHA " +
                              "WHERE A.ID_ARTIKULLI = " + varInt1 + " " +
                              "GROUP BY A.ID_ARTIKULLI,A.EMRI, A.ID_KATEGORIAARTIKULLI, K.PERSHKRIMI,  P.DATE_FILLIMI, P.DATE_MBARIMI, C.ORE_FILLIMI, C.ORE_MBARIMI, C.VLERA " +
                              "ORDER BY P.DATE_FILLIMI, ORE_FILLIMI " +
                              "SET CONCAT_NULL_YIELDS_NULL ON";
                    break;

                case "KtheReferencaArtikulli":
                    //varInt1 --> idArtikulli
                    strSql = "SELECT ID_ARTIKULLI FROM RECETA_ARTIKUJT AS RA INNER JOIN RECETAT AS R ON RA.ID_RECETA = R.ID_RECETA " +
                             "WHERE R.AKTIVE = 1 AND ID_ARTIKULLI = " + varInt1;
                    break;

                case "ModifikoCmimiArtikulli":
                    //varInt1 --> cmimiArtikulli
                    strSql = "UPDATE ARTIKUJT_CMIME SET DATE_MBARIMI = GETDATE() WHERE ID_CMIMI = " + varInt1;
                    break;

                case "ShfaqCmimiArtikulli":
                    //varInt1 --> idArtikulli
                    strSql = "SELECT ID_CMIMI, DATE_FILLIMI , VLERA " +
                             "FROM ARTIKUJT_CMIME " +
                             "WHERE ID_CMIMI = (SELECT MAX(ID_CMIMI) FROM ARTIKUJT_CMIME WHERE ID_ARTIKULLI = " + varInt1 + ")";
                    break;

                case "ShfaqTeDhenaPerArtikullin":
                    //varInt1 --> idArtikulli
                    strSql = "SELECT ID_ARTIKULLI, A.ID_KATEGORIAARTIKULLI, K.PERSHKRIMI, CMIMI_SHITJE, SASIA_SKORTE, ARTIKULL_KONSUMI, A.ID_NJESIA, NJ.NJESIA, EMRI, FOTO " +
                             "FROM ARTIKUJT AS A INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                             "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                             "WHERE ID_ARTIKULLI = " + varInt1;
                    break;

                case "KtheFotoPersoneli":
                    //varInt1 --> idPersoneli
                    strSql = "SELECT FOTO FROM PERSONELI WHERE ID_PERSONELI = " + varInt1;
                    break;

                case "FshiPersonel":
                    //varInt1 --> idPersoneli
                    strSql = "DELETE FROM TURNET WHERE ID_PERSONELI = " + varInt1;
                    strSql += Environment.NewLine + "DELETE FROM PERSONELI WHERE ID_PERSONELI = " + varInt1;
                    break;

                case "FshiReferenceKamarieri":
                    //varInt1 --> idPersoneli
                    strSql = "UPDATE FATURAT SET ID_PERSONELI = NULL WHERE ID_PERSONELI = " + varInt1;
                    break;

                case "ShfaqTeDhenaPerPersonelinZgjedhur":
                    //varInt1 --> idPersoneli
                    strSql = "SELECT ID_PERSONELI, EMRI, MBIEMRI, TELEFONI, P.ID_ROLI, R.ROLI, PERDORUESI, FJALEKALIMI, EMAILI, ADRESA, FOTO, AKTIV " +
                             "FROM PERSONELI AS P INNER JOIN ROLET AS R ON P.ID_ROLI = R.ID_ROLI " +
                             "WHERE ID_PERSONELI = " + varInt1;
                    break;

               

                case "ShfaqTavolinatPerKategori":
                    //varInt1 --> idKategoria
                    strSql = "SELECT ID_TAVOLINA, EMRI FROM TAVOLINAT WHERE ID_KATEGORIATAVOLINA = " + varInt1;
                    break;


                case "ShfaqTeDhenaRezervimi" :
                    //varInt1 --> idRezervimi
                    strSql = "SELECT * FROM REZERVIMET WHERE ID_REZERVIMI = " + varInt1;
                    strSql += Environment.NewLine + "SELECT ID_TAVOLINA, TAVOLINA, KAPACITETI FROM REZERVIM_TAVOLINASH WHERE ID_REZERVIMI = " + varInt1;
                    break;

                case "Login" :
                    //varInt1 --> idPerdoruesi
                    strSql = "UPDATE PERSONELI SET AKTIV = 1 WHERE ID_PERSONELI = " + varInt1;
                    break;

                case "Logout" :
                    //varInt1 --> idPerdoruesi
                    strSql = "UPDATE PERSONELI SET AKTIV = 0 WHERE ID_PERSONELI = " + varInt1;
                    break;

                case "FshiRezervim" :
                    //varInt1 --> idPerdoruesi
                    strSql = "DELETE FROM REZERVIMI_TAVOLINAT WHERE ID_REZERVIMI = " + varInt1;
                    strSql += Environment.NewLine + "DELETE FROM REZERVIMET WHERE ID_REZERVIMI = " + varInt1;
                    break;

                case "MerrTurnKamarieri" :
                    //varInt1 --> idPerdoruesi
                    strSql = "INSERT INTO TURNET(ID_PERSONELI, FILLIMI, MBYLLUR) VALUES(" + varInt1 + ",GETDATE(), 0)";
                    break;

                case "MbyllTurnKamarieri":
                    //varInt1 --> idPerdoruesi
                    strSql = "UPDATE TURNET SET MBARIMI = GETDATE(), MBYLLUR = 1 WHERE ID_TURNI = " +
                        "(SELECT MAX(ID_TURNI) FROM TURNET WHERE ID_PERSONELI = " + varInt1 + ")";
                    break;

                case "ShfaqArtikujPerKategori":
                    //varInt1 --> idKategoria
                    strSql = "SELECT ID_ARTIKULLI, EMRI, NJESIA FROM ARTIKUJT AS A INNER JOIN NJESITE AS NJ " +
                             "ON NJ.ID_NJESIA = A.ID_NJESIA " +
                             "WHERE ID_KATEGORIAARTIKULLI = " + varInt1 + " AND DISPONUESHEM = 1 ORDER BY A.EMRI";
                    break;

                case "ShfaqArtikujtMeTeNjejtenKategori":
                    //varInt1 --> idArtikulli
                    strSql = "SELECT ID_ARTIKULLI, EMRI, NJESIA FROM ARTIKUJT AS A INNER JOIN NJESITE AS NJ " +
                             "ON NJ.ID_NJESIA = A.ID_NJESIA " +
                             "WHERE ID_KATEGORIAARTIKULLI IN (SELECT ID_KATEGORIAARTIKULLI FROM ARTIKUJT WHERE ID_ARTIKULLI = " + varInt1 + ")";
                    break;

                case "SasitePerkateseTeArtikujvePerBlerjen":
                    //varInt1 --> idBlerja
                    strSql = "SET CONCAT_NULL_YIELDS_NULL OFF " + "SELECT ID_ARTIKULLI, SUM(SASIA) AS SASIA FROM VIZUALIZIM_BLERJET " +
                            " WHERE ID_BLERJA = " + varInt1 +
                            " GROUP BY ID_ARTIKULLI" + " SET CONCAT_NULL_YIELDS_NULL ON"; ;
                    break;

                case "NumriTotalArtikujtNeBlerje":
                    //varInt1 --> idBlerja
                    strSql = "SET CONCAT_NULL_YIELDS_NULL OFF " + "SELECT ID_ARTIKULLI,EMRI, NUMRI_TOTAL FROM ARTIKUJT " +
                            " WHERE ID_ARTIKULLI IN (SELECT ID_ARTIKULLI FROM " +
                            " VIZUALIZIM_BLERJET WHERE ID_BLERJA = " + varInt1 +
                            " GROUP BY ID_ARTIKULLI)" + " SET CONCAT_NULL_YIELDS_NULL ON";
                    break;

                case "ShfaqArtikujCmimePerKategori":
                    //varInt1 --> idKategoria
                    strSql = "SELECT     A.ID_ARTIKULLI,A.EMRI, NJ.NJESIA,A.KOSTO AS CMIMI FROM  ARTIKUJT AS A LEFT JOIN KATEGORITE_ARTIKUJT  AS KA " +
                            " ON KA.ID_KATEGORIAARTIKULLI = A.ID_KATEGORIAARTIKULLI INNER JOIN NJESITE  AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                            " WHERE (A.ID_KATEGORIAARTIKULLI = " + varInt1 + ") ORDER BY A.EMRI";
                    break;

                case "ShfaqRecetatPerKategorine":
                    //varInt1 --> idKategoria
                    strSql = "SELECT * FROM RECETAT WHERE ID_KATEGORIARECETA = " + varInt1 + " AND AKTIVE = 1";
                    break;

                case "CaktivizoRecete":
                    //varInt1 --> idReceta
                    strSql = "UPDATE RECETAT SET AKTIVE = 0 WHERE ID_RECETA = " + varInt1;
                    break;

                case "LexoCmimetPerReceten":
                    //varInt1 --> idReceta
                    strSql = "SET CONCAT_NULL_YIELDS_NULL OFF " +
                            " SELECT R.ID_RECETA, R.EMRI, CPR.ID_CMIMIPERIUDHA, CPR.DATE_FILLIMI, CPR.DATE_MBARIMI, " +
                            " CR.ORE_FILLIMI, CR.ORE_MBARIMI, CR.VLERA,  " +
                            " CONVERT(char(12), CPR.DATE_FILLIMI, 104)  + '' + CONVERT(char(5), CPR.DATE_FILLIMI, 108) + '---' + " +
                            " CONVERT(char(12), CPR.DATE_MBARIMI, 104)  + '' + CONVERT(char(5), CPR.DATE_MBARIMI, 108)AS PERIUDHA, " +
                            " CONVERT(char(5), CR.ORE_FILLIMI, 108) AS ORE_FILLIMI_STR, " +
                            " CONVERT(char(5), CR.ORE_MBARIMI, 108) AS ORE_MBARIMI_STR, CONVERT(char(5), CR.ORE_FILLIMI, 108) + '---' + CONVERT(char(5), CR.ORE_MBARIMI, 108)  AS INTERVALI " +
                            " FROM RECETAT AS R INNER JOIN CMIMET_PERIUDHA_RECETAT AS CPR " +
                            " ON CPR.ID_RECETA = R.ID_RECETA " +
                            " INNER JOIN CMIMET_RECETAT AS CR ON CPR.ID_CMIMIPERIUDHA = CR.ID_CMIMIPERIUDHA " +
                            " WHERE R.ID_RECETA = " + varInt1;
                    strSql += strSql;
                    strSql += " AND CPR.DATE_MBARIMI IS NULL ";
                    break;

                case "CaktivizoCmiminEFunditPerReceten":
                    strSql = "UPDATE CMIMET_PERIUDHA_RECETAT SET DATE_MBARIMI = GETDATE() WHERE DATE_MBARIMI IS NULL AND ID_RECETA = " + varInt1;
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, DateTime varDate1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "KtheXhironPerTurnin" :
                    //varInt1 --> idKamarieri
                    //varDate1 --> date fillimi
                    strSql = "SELECT SUM(TOTALI - SKONTO) AS XHIRO FROM FATURAT WHERE ID_PERSONELI = " + varInt1 + " AND DATA_ORA > '" + varDate1.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    break;

                case "ModifikoOrenLast":
                    //varInt1 --> idCmimi
                    //varDate1 --> data e fundit
                    strSql = "UPDATE CMIMET SET ORE_MBARIMI = '" + varDate1.ToShortDateString() + "' WHERE ID_CMIMI = " + varInt1;
                    break;

                case "ModifikoOrenLastReceta":
                    //varInt1 --> idCmimi
                    //varDate1 --> data e fundit
                    strSql = "UPDATE CMIMET_RECETAT SET ORE_MBARIMI = '" + varDate1.ToShortDateString() + "' WHERE ID_CMIMI = " + varInt1;
                    break;

                case "LexoXhironPerKamarierin":
                    //variNT1 --> idKamarieri
                    strSql = "SELECT F.ID_FATURA, F.NR_FATURE, FR.ID_RECETA, R.EMRI, FR.CMIMI AS VLERA , FR.SASIA , (FR.CMIMI * FR.SASIA) AS TOTALI " +
                             "FROM FATURAT AS F INNER JOIN FATURA_RECETAT AS FR ON F.ID_FATURA = FR.ID_FATURA " +
                             "INNER JOIN RECETAT AS R ON FR.ID_RECETA = R.ID_RECETA " +
                             "WHERE (F.ANULLUAR = 0) AND F.ID_PERSONELI = " + varInt1 + " AND F.DATA_ORA > '" + varDate1.ToString("yyyy-MM-dd HH:mm:ss") + "'  ORDER BY FR.ID_RECETA ";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, DateTime varDate1, DateTime varDate2)
        {
            string strSql;
            switch (kerkesaQuery)
            {

                case "ShfaqShpenzimetDitorePerPeriudhen":
                  
                    //varDate1 --> ora fillimi
                    //varDate2 --> ora mbarimi

                    DateTime dateMbarimi = varDate2.AddDays(1);
                    string dtFirst = varDate1.ToString("yyyy.MM.dd");
                    string dtLast = varDate2.ToString("yyyy.MM.dd");

                    strSql = "SELECT  DATASHPENZIMI, SUM(SASIA) AS SHPENZIMI " +
                             "FROM (SELECT CONVERT(char(12), DATA, 102) AS DATASHPENZIMI, SASIA " +
                             "FROM SHPENZIMET) AS ARUSHA " +
                             "WHERE DATASHPENZIMI BETWEEN '" + dtFirst + "' AND '" + dtLast + "' " +
                             "GROUP BY DATASHPENZIMI";
                    break;

                case "ShfaqniFitiminPerPeriudhen" :

                    //varDate1 --> ora fillimi
                    //varDate2 --> ora mbarimi

                    DateTime dateMbarimiShpenzimi = varDate2.AddDays(1);
                    string dtFirstShpenzimi = varDate1.ToString("yyyy.MM.dd");
                    string dtLastShpenzimi = varDate2.ToString("yyyy.MM.dd");

                    strSql = "SELECT  DATAFITIMI, SUM(FITIMI) AS FITIMI " +
                             "FROM (SELECT CONVERT(char(12), DATA_ORA, 102) AS DATAFITIMI, TOTALI - KOSTO - SKONTO AS FITIMI, ANULLUAR " +
                             "FROM FATURAT) AS ARUSHA " +
                             "WHERE DATAFITIMI BETWEEN '" + dtFirstShpenzimi + "' AND '" + dtLastShpenzimi + "' AND ANULLUAR = 0 " +
                             "GROUP BY DATAFITIMI";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, DateTime varDate1, DateTime varDate2)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "LexoTurninPerKamarierin":
                    //variNT1 --> idKamarieri
                    //varDate1 --> ora fillimi
                    //varDate2 --> ora mbarimi
                    strSql = "SELECT F.ID_FATURA, F.NR_FATURE, FR.ID_RECETA, R.EMRI, FR.CMIMI AS VLERA , FR.SASIA , (FR.CMIMI * FR.SASIA) AS TOTALI " +
                             "FROM FATURAT AS F INNER JOIN FATURA_RECETAT AS FR ON F.ID_FATURA = FR.ID_FATURA " +
                             "INNER JOIN RECETAT AS R ON FR.ID_RECETA = R.ID_RECETA " +
                             "WHERE (F.ANULLUAR = 0) AND (DATA_ORA BETWEEN '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "' AND '" + varDate2.ToString("yyyy-MM-dd HH:mm") + "') " +
                             "AND F.ID_PERSONELI = " + varInt1 + " ORDER BY FR.ID_RECETA ";
                    break;

                case "ShfaqTavolinatEliraPerKategori":
                    //varInt1 --> idKategoria
                    //varDate1 --> ora fillimi
                    //varDate2 --> ora mbarimi
                    strSql = "SELECT ID_TAVOLINA,EMRI AS TAVOLINA, KAPACITETI, GJENDJA, " +
                            " ID_KATEGORIATAVOLINA FROM TAVOLINAT WHERE ID_KATEGORIATAVOLINA = " + varInt1 +
                            " AND ID_TAVOLINA NOT IN " +
                            " (SELECT ID_TAVOLINA FROM REZERVIM_TAVOLINASH " +
                            " WHERE ORA_FILLIMI BETWEEN '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "' AND '" + varDate2.ToString("yyyy-MM-dd HH:mm") + "' " +
                            " OR ORA_MBARIMI BETWEEN '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "' AND '" + varDate2.ToString("yyyy-MM-dd HH:mm") + "' " +
                            " OR (ORA_FILLIMI <= '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "' AND ORA_MBARIMI >= '" + varDate2.ToString("yyyy-MM-dd HH:mm") + "')) " +
                            " ORDER BY TAVOLINA";
                    break;

                case "ShfaqTurnetPerKamarierPerPeriudhen" :
                    strSql = "SELECT ID_TURNI, FILLIMI, MBARIMI, SUM(TOTALI - SKONTO) AS XHIRO " +
                             "FROM TURNET AS T INNER JOIN FATURAT AS F ON T.ID_PERSONELI = F.ID_PERSONELI " +
                             "WHERE T.ID_PERSONELI = " + varInt1 + " AND " +
                             "(DATA_ORA BETWEEN FILLIMI AND MBARIMI) AND " +
                             "FILLIMI BETWEEN '" + varDate1.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + varDate2.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                             "GROUP BY ID_TURNI, FILLIMI, MBARIMI";
                             
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, DateTime varDate1, DateTime varDate2, double varDouble1)
        {
            string strSql;
            switch (kerkesaQuery)
            {

                case "KrijoCmimPerArtikullin":

                    // varInt1 --> idArtikulli
                    // varDate1 --> ora fillimi
                    // varDate2 --> ora mbarimi
                    // varDouble1 --> cmimi

                    strSql = "INSERT INTO CMIMET(ID_CMIMIPERIUDHA, ORE_FILLIMI, ORE_MBARIMI, VLERA) VALUES (" + varInt1 + ", '" + varDate1.ToString("HH:mm") + "', '" + varDate2.ToString("HH:mm") + "', " + varDouble1 + ")";
                    break;

                case "KrijoCmimPerRecetat":

                    // varInt1 --> idReceta
                    // varDate1 --> ora fillimi
                    // varDate2 --> ora mbarimi
                    // varDouble1 --> cmimi

                    strSql = "INSERT INTO CMIMET_RECETAT(ID_CMIMIPERIUDHA, ORE_FILLIMI, ORE_MBARIMI, VLERA) VALUES (" + varInt1 + ", '" + varDate1.ToString("HH:mm") + "', '" + varDate2.ToString("HH:mm") + "', " + varDouble1 + ")";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int[] varArrayInt1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "TransferoTavolinen":
                    //varInt1 --> idTavolinaOld
                    //varInt2 --> idTavolinaNew
                    //varArrayInt1 --> vektori i idFaturave qe tranferohen

                    int nr = varArrayInt1.Length;
                    string kushti = "(";
                    for (int i = 0; i < nr - 1; i++)
                    {
                        kushti = kushti + varArrayInt1[i].ToString() + ", ";
                    }

                    kushti = kushti + varArrayInt1[nr - 1].ToString() + " )";

                    strSql = "UPDATE FATURAT SET ID_TAVOLINA = " + varInt2 + " WHERE ID_FATURA IN " + kushti;
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "LidhFatureOferteRecete" :
                    strSql = "INSERT INTO FATURAOFERTA_RECETAT(ID_FATURAOFERTA, ID_RECETA, SASIA) VALUES (" + varInt1 + ", " + varInt2 + ", " + varInt3 + ")";
                    break;

                case "KontrolloShpenzimMujor" :
                    //varInt1 --> idKategoria
                    //varInt2 --> muaji
                    //varInt3 --> viti

                    strSql = "SELECT * FROM SHPENZIMET_MUJORE WHERE ID_KATSHPENZIMIMUJOR = " + varInt1 + " AND MUAJI = " + varInt2 + " AND VITI = " + varInt3;
                    break;


                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, string varString1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ShtoTavoline":
                    //varString1 --> emri
                    //varInt2 --> idKategoria
                    //varInt3 --> kapaciteti


                    strSql = "INSERT INTO TAVOLINAT(EMRI, KAPACITETI, GJENDJA, ID_KATEGORIATAVOLINA) VALUES('" + varString1 + "'," + varInt2 + ",'L'," + varInt1 + ")";
                    break;

                case "ModifikoKategoriArtikulli":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    strSql = "UPDATE KATEGORITE_ARTIKUJT SET PERSHKRIMI = '" + varString1 + "', VISIBLE = " + varInt2 + " WHERE " +
                             " ID_KATEGORIAARTIKULLI = " + varInt1;
                    break;

                case "ShfaqPersonelinSipasZgjedhjes":
                    //varInt1 --> koeficenti i zgjedhjes
                    //varInt2 --> roli i personelit
                    //varString1 --> emri i personelit

                    varString1 = varString1.Replace("'", "''");

                    strSql = this.KtheStrPerShfaqjePersoneliSipasZgjedhjes(varInt1, varInt2, varString1);
                    break;

                case "ShfaqArtikujtSipasZgjedhjesPerSkorte":
                    //varInt1 --> koeficenti i zgjedhjes
                    //varInt2 --> celesi i kategorise
                    //varString1 --> emri i artikullit

                    varString1 = varString1.Replace("'", "'");

                    strSql = this.KtheStrPerShfaqjeArtikujshPerSkorteSipasZgjedhjes(varInt1, varInt2, varString1);
                    break;
                case "ModifikoRecete":
                    //varInt1 --> idReceta
                    //varInt2 --> idKategoria
                    //varString1 --> emri i recetes
                    varString1 = varString1.Replace("'", "'");

                    strSql = "UPDATE RECETAT SET EMRI = '" + varString1 + "',ID_KATEGORIARECETA = " + varInt2 + " WHERE ID_RECETA = " + varInt1;
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3, int varInt4)
        {
            string strSql;
            switch (kerkesaQuery)
            {

                case "ShfaqShpenzimeMujorePerPeriudhen" :
                    //varInt1 --> viti i  fiilimit
                    //varInt2 --> muaji i fillimit
                    //varInt3 --> viti i mbarimit
                    //varInt4 --> muaji i mbarimit

                    strSql = "SELECT MUAJI, VITI, SUM(VLERA) AS TOTALI " +
                             "FROM SHPENZIMET_MUJORE WHERE (MUAJI BETWEEN " + varInt2 + " AND " + varInt4 + " ) AND (VITI BETWEEN " + varInt1 + " AND " + varInt3 + " ) " +
                             "GROUP BY VITI, MUAJI";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, string  varString1, int varInt3, int varInt4)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ModifikoTavoline":
                    //varInt1 --> idTavolina
                    //varString1 --> emri
                    //varInt3 --> idKategoria
                    //varInt4 --> kapaciteti
                    strSql = "UPDATE TAVOLINAT SET EMRI = '" + varString1 + "', ID_KATEGORIATAVOLINA = " + varInt3 +
                        ", KAPACITETI = " + varInt4 + " WHERE ID_TAVOLINA = " + varInt1;
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "KrijoLidhjeTavolineFature" :
                    strSql = "INSERT INTO TAVOLINA_FATURAT (ID_TAVOLINA, ID_FATURA) VALUES(" + varInt1 + ", " + varInt2 + ")";
                    break;

                case "KrijoLidhjeArikujFurnitor":
                    strSql = "INSERT INTO ARTIKUJT_FURNITORET(ID_FURNITORI, ID_ARTIKULLI) VALUES(" + varInt1 + ", " + varInt2 + ")";
                    break;


                case "ShfaqArtikujPerKategoriFurnitor":
                    //varInt1 --> idKategoria
                    //varInt2 --> idFurnitori
                    strSql = "SELECT ID_ARTIKULLI, EMRI, NJESIA FROM ARTIKUJT AS A INNER JOIN NJESITE AS NJ" +
                        " ON NJ.ID_NJESIA = A.ID_NJESIA" +
                        " WHERE ID_KATEGORIAARTIKULLI = " + varInt1 + " AND ID_ARTIKULLI IN (" +
                        " SELECT ID_ARTIKULLI FROM ARTIKUJT_FURNITORET WHERE ID_FURNITORI = " + varInt2 + ")";
                    break;

                case "GjejNjeCmimMePare":
                    //varInt1 --> idArtikulli
                    //varInt2 --> idArtikullFurnitor
                    strSql = "SELECT     A.ID_ARTIKULLI,A.EMRI, NJ.NJESIA,BA.CMIMI, BA.ID_BLERJEARTIKUJ FROM  ARTIKUJT AS A LEFT JOIN KATEGORITE_ARTIKUJT  " +
                              "  AS KA  ON KA.ID_KATEGORIAARTIKULLI = A.ID_KATEGORIAARTIKULLI INNER JOIN NJESITE  AS NJ " +
                               " ON A.ID_NJESIA = NJ.ID_NJESIA LEFT JOIN  BLERJET_ARTIKUJT  AS BA ON A.ID_ARTIKULLI = BA.ID_ARTIKULLI " +
                               " WHERE  A.ID_ARTIKULLI = " + varInt1 + " AND BA.ID_BLERJEARTIKUJ = (SELECT MIN(BA1.ID_BLERJEARTIKUJ) " +
                                " FROM BLERJET_ARTIKUJT AS BA1 WHERE BA1.ID_ARTIKULLI = " + varInt1 + " AND NOT BA1.CMIMI = 0 AND BA1.ID_BLERJEARTIKUJ < " + varInt2 + ")";
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, double varDouble1)
        {
            string strSql;
            string strDouble = "";

            switch (kerkesaQuery)
            {

                case "ModifikoKostoFature" :
                    //varInt1 --> idFatura
                    //varDouble1 --> kostoFature
                    strDouble = this.FormatoNumrinDecimal(varDouble1);
                    strSql = "UPDATE FATURAT SET KOSTO = " + strDouble + " WHERE ID_FATURA = " + varInt1;
                    break;

                case "ModifikoTotaliFature":
                    //varInt1 --> idFatura
                    //varDouble1 --> totaliFature
                    strDouble = this.FormatoNumrinDecimal(varDouble1);
                    strSql = "UPDATE FATURAT SET TOTALI = " + strDouble + " WHERE ID_FATURA = " + varInt1;
                    break;


                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, double varDouble1, string varString1)
        {
            string strSql;
            switch (kerkesaQuery)
            {

                case "ModifikoShpenzimMujor":
                    //varInt1 --> idFatura
                    //varDouble1 --> kostoFature
                    string strDouble = this.FormatoNumrinDecimal(varDouble1);
                    strSql = "UPDATE SHPENZIMET_MUJORE SET VLERA = " + strDouble + ", KOMENTI = '" + varString1 + "' WHERE ID_SHPENZIMIMUJOR = " + varInt1;
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }


        public string GetQuery(string kerkesaQuery, int varInt1, string varString1, DateTime varDate1)
        {
            string strSql;
            switch (kerkesaQuery)
            {

                case "ShtoBlerje":
                    //varInt1 --> id Furnitori
                    //varDate1 --> data e blerjes
                    //varString1 -->numri i fatures
                    strSql = "INSERT INTO BLERJET VALUES(" + varInt1 + ", '"
                        + varDate1.ToString("yyyy-MM-dd HH:mm") + "','" + varString1 + "')";
                    strSql += Environment.NewLine + "SELECT SCOPE_IDENTITY()";
                    break;


                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, string varString1, string varString2)
        {
            string strSql;
            switch (kerkesaQuery)
            {

                case "ModifikoKategoriShpenzimiMujor":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    //varString2 --> pershkrimi i kategorise

                    strSql = "UPDATE KATEGORIA_SHPENZIMIMUJOR SET CSHPENZIMI = '" + varString1 + "', PSHPENZIMI = '" + varString2 + "' WHERE ID_KATSHPENZIMIMUJOR = " + varInt1;
                    break;

                case "ModifikoGrupCmimi":
                    //varInt1 --> idGrupi
                    //varString1 --> emri i grupit
                    //varString2 --> pershkrimi i grupit

                    strSql = "UPDATE GRUP_CMIMET SET KGRUPCMIMI = '" + varString1 + "', PGRUPCMIMI = '" + varString2 + "' WHERE ID_GRUPCMIMI = " + varInt1;
                    break;


                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, DataSet varDs)
        {
            string strSql = "";
            switch (kerkesaQuery)
            {
                case "KrijoEkstratPerRecete":
                    //varInt1 --> idReceta
                    //varDs --> mban ekstrat per recete

                    string ekstra = "";

                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        ekstra = Convert.ToString(dr[0]);
                        strSql += Environment.NewLine + "INSERT INTO EKSTRAT(ID_RECETA, KEKSTRA) VALUES(" + varInt1 + ", '" + ekstra + "')";



                    }
                    break;

                case "KrijoLidhjenReceteGrupCmimesh":
                    //varInt1 --> idReceta
                    //varDs --> mban grupet e cmimeve

                    int idGr = 0;

                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        idGr = Convert.ToInt32(dr[0]);
                        strSql += Environment.NewLine + "INSERT INTO RECETA_CMIMET(ID_RECETA, ID_GRUPCMIMI, CMIMI) VALUES(" + varInt1 + ", " + idGr + ", 0)";



                    }
                    break;

                case "ModifikoCmimeRecetatPerGrup":
                    //varInt1 --> idGrupCmimi
                    //varDs --> mban recetat 

                    int idRecetaGrupCmimi = 0;
                    decimal cmimiGrupRecete = 0;

                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        idRecetaGrupCmimi = Convert.ToInt32(dr["ID_RECETA"]);
                        cmimiGrupRecete = Convert.ToInt32(dr["CMIMI"]);

                        strSql += Environment.NewLine + "UPDATE RECETA_CMIMET SET CMIMI = " + cmimiGrupRecete + " WHERE ID_RECETA = " + idRecetaGrupCmimi + " AND ID_GRUPCMIMI = " + varInt1;



                    }
                    break;

                case "KrijoCmimRecetePerGrup":
                    //varInt1 --> idGrupCmimi
                    //varDs --> mban recetat 

                    int idRecetaGrupi = 0;
                   
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        idRecetaGrupi = Convert.ToInt32(dr[0]);
                        strSql += Environment.NewLine + "INSERT INTO RECETA_CMIMET(ID_RECETA, ID_GRUPCMIMI, CMIMI) VALUES(" + idRecetaGrupi + ", " + varInt1 + ", 0)";
                            


                    }
                    break;

                case "KrijoLidhjeOferteRecete" :
                    //varInt1 --> idOferta
                    //varDs --> dsRecetat

                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "INSERT INTO OFERTA_RECETAT(ID_OFERTA, ID_RECETA, SASIA, SHPORTA) VALUES(" + varInt1 + ", " +
                            Convert.ToInt32(dr["ID_RECETA"]) + ", " + Convert.ToInt32(dr["SASIA"]) + ", " + Convert.ToInt32(dr["SHPORTA"]) + ")";


                    }

                    break;

                case "LidhFaturenMeRecetat":
                    //varInt1 --> idFatura
                    //varDs --> mban recetat perberese te fatures

                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "INSERT INTO FATURA_RECETAT(ID_FATURA, ID_RECETA, SASIA, CMIMI) VALUES(" + varInt1 + ", " +
                            Convert.ToInt32(dr["CELESI"]) + ", " + Convert.ToInt32(dr["SASIA"]) + ", " + Convert.ToDecimal(dr["CMIMI"]) + ")";


                    }

                    break;

                case "LidhFaturenMeArtikujt":
                    //varInt1 --> idFatura
                    //varDs --> mban artikujt perberes te fatures

                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "INSERT INTO FATURA_ARTIKUJT VALUES(" + varInt1 + ", " +
                            Convert.ToInt32(dr["CELESI"]) + ", " + Convert.ToInt32(dr["SASIA"]) + ")";


                    }

                    break;

                case "ShtoArtikujNeBlerje":
                    //varInt1 --> idBlerja
                    //varDs --> mban artikujt perberes te blerjes
                    bool ugjet = false;
                    decimal kostoB = 0;
                    double sasiaB = 0;
                    decimal vleraB = 0;

                    foreach (DataRow dr in varDs.Tables[1].Rows)
                    {
                        kostoB = Convert.ToDecimal(dr["CMIMI"]);
                        sasiaB = Convert.ToDouble(dr["SASIA"]);
                        vleraB = kostoB * Convert.ToDecimal(sasiaB);

                        strSql += Environment.NewLine + "INSERT INTO BLERJET_ARTIKUJT VALUES(" + varInt1 + ", " +
                            Convert.ToInt32(dr["ID_ARTIKULLI"]) + ", " + Convert.ToDouble(dr["SASIA"]) +
                                ", '" + Convert.ToDateTime(dr["DATA_SKADENCA"]).ToString("yyyy-MM-dd HH:mm") + "', " + dr["CMIMI"].ToString() + ",0)";
                        if (Convert.ToDouble(dr["CMIMI"]) == 0)
                        {
                            if (!ugjet)
                                strSql += Environment.NewLine + "DECLARE @LAST AS INT SET @LAST =  SCOPE_IDENTITY()";
                            else
                                strSql += Environment.NewLine + "SET @LAST =  SCOPE_IDENTITY()";
                            strSql += Environment.NewLine + "INSERT INTO OFERTAT_BLERJE VALUES(@LAST, " + Convert.ToInt32(dr["ID_ARTIKULLIFILLESTAR"]) + ", " +
                                Convert.ToDouble(dr["SASIA_KUSHT_OFERTA"]) + ")";
                            ugjet = true;
                        }

                        strSql += Environment.NewLine + "UPDATE ARTIKUJT SET KOSTO = (NUMRI_TOTAL * KOSTO + " + vleraB.ToString() + ") / (NUMRI_TOTAL + " + sasiaB.ToString() + ") WHERE ID_ARTIKULLI = " + Convert.ToInt32(dr["ID_ARTIKULLI"]);

                        strSql += Environment.NewLine + "UPDATE ARTIKUJT SET NUMRI_TOTAL = NUMRI_TOTAL + " + Convert.ToDecimal(dr["SASIA"]) +
                            " WHERE ID_ARTIKULLI = " + Convert.ToInt32(dr["ID_ARTIKULLI"]);
                    }
                    break;

                case "RuajPerkatesiArtikuj":
                    //varInt1 --> idBlerja
                    //varDs --> mban artikujt perberes te blerjes
                    strSql = "DELETE FROM ARTIKUJT_FURNITORET WHERE ID_FURNITORI = " + varInt1;
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "INSERT INTO ARTIKUJT_FURNITORET VALUES(" + varInt1 +
                            ", " + Convert.ToInt32(dr["ID_ARTIKULLI"]) + ")";
                    }
                    break;

                case "ShtoArtikujNeRecete":
                    //varInt1 --> idReceta
                    //varDs --> mban artikujt perberes te recetes
                    strSql = "DELETE FROM RECETA_ARTIKUJT WHERE ID_RECETA = " + varInt1;
                    foreach (DataRow dr in varDs.Tables[1].Rows)
                    {
                        strSql += Environment.NewLine + "INSERT INTO RECETA_ARTIKUJT VALUES(" + varInt1 +
                            ", " + Convert.ToInt32(dr["ID_ARTIKULLI"]) + ", " + Convert.ToDouble(dr["SASIA"]) + ")";
                    }
                    break;

                case "NdryshoDisponibilitet":
                    //varInt1 --> 1 ose 0
                    //varDs --> recetat per tu ndryshuar
                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        strSql += Environment.NewLine + "UPDATE RECETAT SET DISPONUESHEM = " + varInt1 + " WHERE ID_RECETA = " + Convert.ToInt32(dr["ID_RECETA"]);
                    }
                    break;

                case "KrijoCmimePerRecete":
                    //varInt1 --> idReceta
                    //varDs --> cmimet qe duhet te shtohen
                    DateTime dateMbarimi = new DateTime();
                    int nr = varDs.Tables[0].Rows.Count;
                    int i = 0;
                    strSql = "INSERT INTO CMIMET_PERIUDHA_RECETAT(ID_RECETA, DATE_FILLIMI) VALUES(" + varInt1 + ",GETDATE())";
                    strSql += Environment.NewLine + "DECLARE @ID AS INT SET @ID = SCOPE_IDENTITY()";

                    foreach (DataRow dr in varDs.Tables[0].Rows)
                    {
                        i = i + 1;
                        if (i == nr)
                        {
                            dateMbarimi = Convert.ToDateTime(dr["ORE_MBARIMI"]).AddDays(1);
                        }
                        else
                        {
                            dateMbarimi = Convert.ToDateTime(dr["ORE_MBARIMI"]);
                        }

                        strSql += Environment.NewLine + "INSERT INTO CMIMET_RECETAT VALUES(@ID,'" + Convert.ToDateTime(dr["ORE_FILLIMI"]).ToString("HH:mm") + "','" + dateMbarimi.ToString("HH:mm") + "','" + Convert.ToDouble(dr["CMIMI"]) + "' )";
                    }
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }


        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, DateTime varDate1, DateTime varDate2)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ShfaqTavolinatEliraPerKategori":
                    //varInt1 --> idKategoria
                    //varInt2 --> idRezervimi
                    strSql = "SELECT ID_TAVOLINA,EMRI AS TAVOLINA, KAPACITETI, GJENDJA, " +
                            " ID_KATEGORIATAVOLINA FROM TAVOLINAT WHERE ID_KATEGORIATAVOLINA = " + varInt1 +
                            " AND ID_TAVOLINA NOT IN " +
                            " (SELECT ID_TAVOLINA FROM REZERVIM_TAVOLINASH " +
                            " WHERE (ORA_FILLIMI BETWEEN '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "' AND '" + varDate2.ToString("yyyy-MM-dd HH:mm") + "' " +
                            " OR ORA_MBARIMI BETWEEN '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "' AND '" + varDate2.ToString("yyyy-MM-dd HH:mm") + "' " +
                            " OR (ORA_FILLIMI <= '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "' AND ORA_MBARIMI >= '" + varDate2.ToString("yyyy-MM-dd HH:mm") + "')) AND " +
                             " NOT ID_REZERVIMI = " + varInt2 + ") " +
                            " ORDER BY TAVOLINA";
                    break;

                case "XhirojaPerSecilenDateSipasRecetave":
                    //varInt1 --> idKatReceta
                    //varInt2 --> idReceta
                    //varDate1 --> dateFillimi
                    //varDate2 --> dateMbarimi

                    string dtFillimi = varDate1.ToString("yyyy.MM.dd");
                    string dtMbarimi = varDate2.ToString("yyyy.MM.dd");

                    if (varInt2 == 0)
                    {
                        strSql = "SELECT R.ID_RECETA, R.EMRI AS RECETA, F.ID_FATURA, F.NR_FATURE, F.DATA_ORA, FR.CMIMI AS CMIMIS, CONVERT(char(12), F.DATA_ORA, 104) + CONVERT(char(5), F.DATA_ORA, 108) AS DATASTR, CONVERT(char(12), F.DATA_ORA, 104) AS DATA, CONVERT(char(5), F.DATA_ORA, 108) AS ORA, FR.SASIA , (FR.CMIMI * FR.SASIA) AS TOTALI " +
                                 "FROM RECETAT AS R " +
                                 "INNER JOIN FATURA_RECETAT AS FR ON R.ID_RECETA = FR.ID_RECETA " +
                                 "INNER JOIN FATURAT AS F ON FR.ID_FATURA = F.ID_FATURA " +
                                 "WHERE R.ID_KATEGORIARECETA = " + varInt1 + " AND F.DATA_ORA BETWEEN '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "' AND '" + varDate2.ToString("yyyy-MM-dd HH:mm") + "' AND F.ANULLUAR = 0 " +
                                 "ORDER BY R.ID_RECETA ";
  
                    }
                    else
                    {
                        strSql = "SELECT R.ID_RECETA, R.EMRI AS RECETA, F.ID_FATURA, F.NR_FATURE, F.DATA_ORA, FR.CMIMI AS CMIMIS, CONVERT(char(12), F.DATA_ORA, 104) + CONVERT(char(5), F.DATA_ORA, 108) AS DATASTR, CONVERT(char(12), F.DATA_ORA, 104) AS DATA, CONVERT(char(5), F.DATA_ORA, 108) AS ORA, FR.SASIA , (FR.CMIMI * FR.SASIA) AS TOTALI " +
                                 "FROM RECETAT AS R " +
                                 "INNER JOIN FATURA_RECETAT AS FR ON R.ID_RECETA = FR.ID_RECETA " +
                                 "INNER JOIN FATURAT AS F ON FR.ID_FATURA = F.ID_FATURA " +
                                 "WHERE R.ID_RECETA = " + varInt2 + " AND F.DATA_ORA BETWEEN '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "' AND '" + varDate2.ToString("yyyy-MM-dd HH:mm") + "' AND F.ANULLUAR = 0 " +
                                 "ORDER BY R.ID_RECETA ";
  
                    }


                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3, decimal varDecimal1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "LidhFatureOferte":
                    //varInt1 --> idFatura
                    //varInt2 --> idOferta
                    //varInt3 --> indeksi
                    //varDecimal1 --> cmimi

                    strSql = "INSERT INTO FATURA_OFERTAT (ID_FATURA, ID_OFERTA, INDEKSI, CMIMI) VALUES (" + varInt1 + ", " + varInt2 + ", " + varInt3 + ", " + varDecimal1 + ") " +
                             "SELECT SCOPE_IDENTITY()";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }


        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, string varString1, DateTime varDate1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ModifikoBlerje":
                    //varInt1 --> idBlerja
                    //varInt2 --> idFurnitori
                    //varDate1 --> data e blerjes
                    strSql = "UPDATE BLERJET SET ID_FURNITORI = " + varInt2 + ", DATA_BLERJE = '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "' " +
                        ",NR_FATURE = '" + varString1 + "' WHERE ID_BLERJA = " + varInt1;
                    strSql += Environment.NewLine + "DELETE FROM OFERTAT_BLERJE WHERE ID_BLERJEARTIKUJ IN " +
                        " ( SELECT ID_BLERJEARTIKUJ FROM BLERJET_ARTIKUJT WHERE ID_BLERJA = " + varInt1 + ")";
                    strSql += Environment.NewLine + "DELETE FROM BLERJET_ARTIKUJT WHERE ID_BLERJA = " + varInt1;
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3, double varDouble1, string varString1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "KrijoShpenzimMujor":
                    //varInt1 --> idKategoria
                    //varInt2 --> muaji
                    //varInt3 --> viti
                    //varDouble1 --> vlera
                    //varString1 --> komenti mbi shpenzimin
                    strSql = "INSERT INTO SHPENZIMET_MUJORE (ID_KATSHPENZIMIMUJOR, MUAJI, VITI, VLERA, KOMENTI) VALUES (" + varInt1 + ", " + varInt2 + ", " + varInt3 + ", " + varDouble1 + ", '" + varString1 + "')";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }


        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3, int varInt4, double varDouble1, double varDouble2, string varString1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "KrijoFature":
                    //varInt1 --> celesi i kamarierit
                    //varInt2 --> idTavolina
                    //varInt3 --> idKlienti
                    //varInt4 --> idFormaPagesa
                    //varDouble1 --> totali
                    //varDouble2 --> skonto
                    //varString1 --> nrFatura

                    strSql = "INSERT INTO FATURAT(ID_PERSONELI, ID_TAVOLINA, ID_KLIENTI, ID_FORMAPAGESA, TOTALI, SKONTO, NR_FATURE, DATA_ORA, KOSTO, ANULLUAR) " +
                             "VALUES(" + varInt1 + ", " + varInt2 + ", " + varInt3 + ", " + varInt4 + ", " + varDouble1 + ", " + varDouble2 + ", '" + varString1 + "', GETDATE(), 0, 0) " +
                             "SELECT SCOPE_IDENTITY()";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }


        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3, string varString1, string varString2, double varDouble1, double varDouble2)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "KrijoArtikull":
                    //varInt1 --> idKategoria
                    //varInt2 --> idNjesia
                    //varInt3 --> lloji i konsumit
                    //varString1 --> kodi i artikullit
                    //varString2 --> pathi i fotos
                    //varDouble1 --> cmimi
                    //varDouble2 --> sasiaSkorte

                    strSql = "INSERT INTO ARTIKUJT(NUMRI_TOTAL, ID_KATEGORIAARTIKULLI, ID_NJESIA, ARTIKULL_KONSUMI, EMRI, FOTO, SASIA_SKORTE, DISPONUESHEM) " +
                             "VALUES(0, " + varInt1 + ", " + varInt2 + ", " + varInt3 + ", '" + varString1 + "', '" + varString2 + "', " + varDouble2 + ", 1) " +
                             "SELECT SCOPE_IDENTITY()";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3, int varInt4, string varString1, string varString2, double varDouble1, double varDouble2)
        {
            string strSql;
            switch (kerkesaQuery)
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

                    strSql = "UPDATE ARTIKUJT SET ID_KATEGORIAARTIKULLI = " + varInt2 + ", ID_NJESIA = " + varInt3 + ", ARTIKULL_KONSUMI = " + varInt4 + ", EMRI = '" + varString1 + "', " +
                             "SASIA_SKORTE = " + varDouble2 + " WHERE ID_ARTIKULLI = " + varInt1;
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int[] varArrayInt1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "LexoTeDhenaPerTavolinen":
                    //varArrayInt1 --> idFaturat per tavolinen
                    int nr = varArrayInt1.Length;
                    string kushti = "(";
                    for (int i = 0; i < nr - 1; i++)
                    {
                        kushti = kushti + varArrayInt1[i].ToString() + ", ";
                    }

                    kushti = kushti + varArrayInt1[nr - 1].ToString() + " )";
                    strSql = "SELECT F.ID_FATURA, F.NR_FATURE, FR.ID_RECETA, R.EMRI, FR.CMIMI AS VLERA , FR.SASIA AS SASIA , (FR.CMIMI * FR.SASIA) AS TOTALI, F.ID_PERSONELI, P.PERDORUESI " +
                             "FROM FATURAT AS F INNER JOIN FATURA_RECETAT AS FR ON F.ID_FATURA = FR.ID_FATURA " +
                             "INNER JOIN RECETAT AS R ON FR.ID_RECETA = R.ID_RECETA " +
                             "INNER JOIN PERSONELI AS P ON F.ID_PERSONELI = P.ID_PERSONELI " +
                             "WHERE F.ID_FATURA IN " + kushti + " ORDER BY F.ID_FATURA";
                            
                    
                    break;

                case "LexoOfertatPerTavolinen":
                    //varArrayInt1 --> idFaturat per tavolinen
                    nr = varArrayInt1.Length;
                    kushti = "(";
                    for (int i = 0; i < nr - 1; i++)
                    {
                        kushti = kushti + varArrayInt1[i].ToString() + ", ";
                    }

                    kushti = kushti + varArrayInt1[nr - 1].ToString() + " )";
                    strSql = "SELECT F.ID_FATURA, NR_FATURE, OFER.ID_OFERTA, EMRI, OFER.CMIMI " +
                             "FROM FATURAT AS F INNER JOIN FATURA_OFERTAT AS FO ON F.ID_FATURA = FO.ID_FATURA " +
                             "INNER JOIN OFERTAT AS OFER ON FO.ID_OFERTA = OFER.ID_OFERTA " +
                             "WHERE F.ID_FATURA IN " + kushti;

                    break;

                case "LexoRecetatPerOfertatTavoline":
                    //varArrayInt1 --> idFaturat per tavolinen
                    nr = varArrayInt1.Length;
                    kushti = "(";
                    for (int i = 0; i < nr - 1; i++)
                    {
                        kushti = kushti + varArrayInt1[i].ToString() + ", ";
                    }

                    kushti = kushti + varArrayInt1[nr - 1].ToString() + " )";
                    strSql = "SELECT F.ID_FATURA, F.NR_FATURE, FO.ID_OFERTA , OFER.EMRI AS OFERTA, INDEKSI, FR.ID_RECETA,R.EMRI AS RECETA , SASIA " +
                             "FROM FATURAT AS F INNER JOIN FATURA_OFERTAT AS FO ON F.ID_FATURA = FO.ID_FATURA " +
                             "INNER JOIN FATURAOFERTA_RECETAT AS FR ON FO.ID_FATURAOFERTA = FR.ID_FATURAOFERTA " +
                             "INNER JOIN RECETAT AS R ON R.ID_RECETA = FR.ID_RECETA " +
                             "INNER JOIN OFERTAT AS OFER ON OFER.ID_OFERTA = FO.ID_OFERTA " +
                             "WHERE F.ID_FATURA IN " + kushti ;

                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }


        public string GetQuery(string kerkesaQuery, int varInt1, int[] arrayInt)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "RezervoTavolina":
                    //varInt1 --> idRezervimi
                    //varInt2 --> idTavolina vektor
                    strSql = "DELETE FROM REZERVIMI_TAVOLINAT WHERE ID_REZERVIMI = " + varInt1;
                    for (int i = 0; i < arrayInt.Length; i++)
                        strSql += Environment.NewLine + "INSERT INTO REZERVIMI_TAVOLINAT VALUES(" + varInt1 + ", " + arrayInt[i] + ")";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, string varString1, double varDouble1)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            switch (kerkesaQuery)
            {
                case "ShtoFormePagese":
                    //varInt1 --> emri i formes se pageses
                    //varInt2 --> komisioni
                    strSql = "INSERT INTO FORMA_PAGESA VALUES('" + varString1 + "', " + varDouble1 + ")";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, string varString1, string varString2, string varString3,
            string varString4, string varString5)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            varString2 = varString2.Replace("'", "''");
            varString3 = varString3.Replace("'", "''");
            varString4 = varString4.Replace("'", "''");
            varString5 = varString5.Replace("'", "''");
            switch (kerkesaQuery)
            {
                case "ShtoFurnitor":

                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> adresa
                    //varString4 --> emaili
                    //varString5 --> telefoni

                    strSql = "INSERT INTO FURNITORET VALUES('" + varString1 + "','" +
                        varString2 + "','" + varString3 + "','" + varString4 + "','" + varString5 + "')";
                    break;

                case "ShtoKlient":

                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> kodi
                    //varString4 --> telefoni
                    //varString5 --> adresa

                    strSql = "INSERT INTO KLIENTET_RESTORANTI( EMRI, MBIEMRI, TELEFONI, KODI_KLIENTI, ADRESA) VALUES('" + varString1 + "', '" + varString2 + "', '" + varString3 + "', '" + varString4 + "', '" + varString5 + "')";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, string varString1, string varString2, string varString3,
           string varString4, string varString5, string varString6, string varString7, string varString8)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            varString2 = varString2.Replace("'", "''");
            varString3 = varString3.Replace("'", "''");
            varString4 = varString4.Replace("'", "''");
            varString5 = varString5.Replace("'", "''");
            varString6 = varString6.Replace("'", "''");
            varString7 = varString7.Replace("'", "''");
            varString8 = varString8.Replace("'", "''");
            switch (kerkesaQuery)
            {
                case "KrijoPerdorues":
                    strSql = "INSERT INTO PERSONELI(ID_ROLI, EMRI, MBIEMRI, EMAILI, TELEFONI, ADRESA, PERDORUESI, FJALEKALIMI, FOTO_IMAZH) " +
                             "VALUES(" + varInt1 + ", '" + varString1 + "', '" + varString2 + "', '" + varString3 + "', '" + varString4 + "', '" + varString5 + "', '" + varString6 + "', '" + varString7 + "', '" + varString8 + "') " +
                             "SELECT SCOPE_IDENTITY()";

                    // varInt1 --> roli i personelit
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
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, string varString1, string varString2, string varString3,
          string varString4, string varString5, string varString6, string varString7, string varString8,  Image varImazh)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            varString2 = varString2.Replace("'", "''");
            varString3 = varString3.Replace("'", "''");
            varString4 = varString4.Replace("'", "''");
            varString5 = varString5.Replace("'", "''");
            varString6 = varString6.Replace("'", "''");
            varString7 = varString7.Replace("'", "''");
            switch (kerkesaQuery)
            {
                case "KrijoPerdorues":
                    strSql = "INSERT INTO PERSONELI(ID_ROLI, EMRI, MBIEMRI, EMAILI, TELEFONI, ADRESA, PERDORUESI, FJALEKALIMI, FOTO, FOTO_IMAZH, DISPONUESHEM, AKTIV) " +
                             "VALUES(" + varInt1 + ", '" + varString1 + "', '" + varString2 + "', '" + varString3 + "', '" + varString4 + "', '" + varString5 + "', '" + varString6 + "', '" + varString7 + "', '" + varString8 + "', '" + varImazh + "', 1, 0) " +
                             "SELECT SCOPE_IDENTITY()";

                    // varInt1 --> roli i personelit
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
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, string varString1, string varString2, string varString3,
          string varString4, string varString5, string varString6, string varString7, string varString8)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            varString2 = varString2.Replace("'", "''");
            varString3 = varString3.Replace("'", "''");
            varString4 = varString4.Replace("'", "''");
            varString5 = varString5.Replace("'", "''");
            varString6 = varString6.Replace("'", "''");
            varString7 = varString7.Replace("'", "''");
            varString8 = varString8.Replace("'", "''");
            switch (kerkesaQuery)
            {
                case "ModifikoPersonel":
                    strSql = "UPDATE PERSONELI SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "', EMAILI = '" + varString3 + "', TELEFONI = '" + varString4 + "', ADRESA = '" + varString5 + "', PERDORUESI = '" + varString6 + "', " +
                             "FJALEKALIMI = '" + varString7 + "', ID_ROLI = " + varInt2 + " WHERE ID_PERSONELI = " + varInt1;

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
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, string varString1, string varString2, string varString3,
            string varString4, string varString5)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            varString2 = varString2.Replace("'", "''");
            varString3 = varString3.Replace("'", "''");
            varString4 = varString4.Replace("'", "''");
            varString5 = varString5.Replace("'", "''");
            switch (kerkesaQuery)
            {
                case "ModifikoFurnitor":
                    //varInt1 --> idFurnitori
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> adresa
                    //varString4 --> emaili
                    //varString5 --> telefoni
                    strSql = "UPDATE FURNITORET SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "', " +
                        " ADRESA = '" + varString3 + "', EMAILI = '" + varString4 + "', TELEFONI = '" + varString5 + "' " +
                        " WHERE ID_FURNITORI = " + varInt1;
                    break;

                case "ModifikoKlient":

                    //varInt1 --> idKlienti
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> kodi
                    //varString4 --> telefoni

                    strSql = "UPDATE KLIENTET_RESTORANTI SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "', KODI_KLIENTI = '" + varString3 + "', TELEFONI = '" + varString4 + "', ADRESA = '" + varString5 + "' " +
                             "WHERE ID_KLIENTI = " + varInt1;
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, string varString1, string varString2, string varString3, string varString4)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            varString2 = varString2.Replace("'", "''");
            varString3 = varString3.Replace("'", "''");
            varString4 = varString4.Replace("'", "''");

            switch (kerkesaQuery)
            {
                case "ShtoKlient":

                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> kodi
                    //varString4 --> telefoni

                    strSql = "INSERT INTO KLIENTET_RESTORANTI( EMRI, MBIEMRI, TELEFONI, KODI_KLIENTI) VALUES('" + varString1 + "', '" + varString2 + "', '" + varString3 + "', '" + varString4 + "')";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, string varString1, string varString2, int varInt1, decimal varDecimal1)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            varString2 = varString2.Replace("'", "''");
            

            switch (kerkesaQuery)
            {
                case "KrijoOferte":

                    // varString1 --> emri i ofertes
                    // varString2 --> tipi i ofertes
                    // varInt1 --> numri i shportave
                    // varDecimal1 --> cmimi

                    strSql = "INSERT INTO OFERTAT( EMRI, TIPI, NR_SHPORTASH, CMIMI) VALUES('" + varString1 + "', '" + varString2 + "', " + varInt1 + ", " + varDecimal1 + ") SELECT SCOPE_IDENTITY()";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, string varString1, string varString2, string varString3, string varString4)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            varString2 = varString2.Replace("'", "''");
            varString3 = varString3.Replace("'", "''");
            varString4 = varString4.Replace("'", "''");

            switch (kerkesaQuery)
            {
                case "ModifikoKlient":

                    //varInt1 --> idKlienti
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> kodi
                    //varString4 --> telefoni

                    strSql = "UPDATE KLIENTET_RESTORANTI SET EMRI = '" + varString1 + "', MBIEMRI = '" + varString2 + "', KODI_KLIENTI = '" + varString3 + "', TELEFONI = '" + varString4 + "' " +
                             "WHERE ID_KLIENTI = " + varInt1;
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }



        public string GetQuery(string kerkesaQuery, string varString1, string varString2)
        {
            string strSql;
            varString1 = varString1.Replace("'", "''");
            varString2 = varString2.Replace("'", "''");
            switch (kerkesaQuery)
            {
                case "KrijoGrupCmimi" :
                    // varString1 --> emri i grupit te cmimit
                    // varString2 --> pershkrimi i grupit te cmimit

                    strSql = "INSERT INTO GRUP_CMIMET(KGRUPCMIMI, PGRUPCMIMI) VALUES('" + varString1 + "', '" + varString2 + "')";
                    break;

                case "GjejPerdorues":
                    //varInt1 --> perdoruesi
                    //varString1 --> fjalekalimi
                    strSql = "SELECT * FROM PERSONELI WHERE PERDORUESI = '" + varString1 + "' AND FJALEKALIMI = '" + varString2 + "'";
                    break;

                case "KrijoKategoriShpenzimMujor" :
                    // varString1 --> emri i kategorise
                    // varString2 --> pershkrimi i kategorise
                    strSql = "INSERT INTO KATEGORIA_SHPENZIMIMUJOR(CSHPENZIMI, PSHPENZIMI) VALUES ('" + varString1 + "', '" + varString2 + "')";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, DateTime varDate)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ShfaqFaturatPerDatenZgjedhur" :

                    string  dateFillimi = varDate.ToString("yyyy.MM.dd");
                    DateTime dateMbarimi = varDate.AddDays(1);

                    strSql = "SELECT ID_FATURA, NR_FATURE, TAVOLINA, KOSTO, VLERA , FITIMI,  DATAFITIMI , DATAFILLIMI , DATAMBARIMI " +
                             "FROM (SELECT ID_FATURA, NR_FATURE, T.EMRI AS TAVOLINA, KOSTO, (TOTALI - SKONTO) AS VLERA, SKONTO, (TOTALI - SKONTO - KOSTO) AS  FITIMI, CONVERT(char(12), DATA_ORA, 102) AS DATAFITIMI , '" + dateFillimi + "' AS DATAFILLIMI,  '" + dateFillimi + "' AS DATAMBARIMI, ANULLUAR " +
                             "FROM FATURAT AS F LEFT JOIN TAVOLINAT AS T ON F.ID_TAVOLINA = T.ID_TAVOLINA) AS FA " +
                             "WHERE DATAFITIMI BETWEEN DATAFILLIMI AND DATAMBARIMI AND ANULLUAR = 0";
                    break;

                case "ShpenzimetPerDaten":
                    strSql = "SELECT SUM(SASIA) AS SHUMA FROM SHPENZIMET WHERE " +
                              "   DAY(DATA) = DAY('" + varDate.ToString("yyyy-MM-dd HH:mm") + "')" +
                              "  AND MONTH(DATA) = MONTH('" + varDate.ToString("yyyy-MM-dd HH:mm") + "')" +
                              "  AND YEAR(DATA) = YEAR('" + varDate.ToString("yyyy-MM-dd HH:mm") + "')" +
                              "  AND DATA <= '" + varDate.ToString("yyyy-MM-dd HH:mm") + "'";
                    break;
                case "ShfaqRezervimetTavolina":
                    strSql = "SELECT * FROM  REZERVIM_TAVOLINASH WHERE " +
                              "   DAY(DATA) = DAY('" + varDate.ToString("yyyy-MM-dd HH:mm") + "')" +
                              "  AND MONTH(DATA) = MONTH('" + varDate.ToString("yyyy-MM-dd HH:mm") + "')" +
                              "  AND YEAR(DATA) = YEAR('" + varDate.ToString("yyyy-MM-dd HH:mm") + "')";
                    break;
                case "ShfaqGjendjeArka":
                    strSql = "SELECT CONVERT(DECIMAL,SUM(F.TOTALI - F.SKONTO)) AS VLERA_HEDHUR,F.ID_FORMAPAGESA,  FP.FORMA_PAGESA, " +
                            " FP.KOMISIONI, CONVERT(DECIMAL,SUM(F.TOTALI - F.SKONTO) - (SUM(F.TOTALI - F.SKONTO) * FP.KOMISIONI)) AS " +
                            " VLERA_KOMISION " +
                            " FROM FATURAT AS F INNER JOIN FORMA_PAGESA AS FP ON F.ID_FORMAPAGESA = FP.ID_FORMAPAGESA " +
                            " WHERE (MONTH(F.DATA_ORA) = MONTH('" + varDate.ToString("yyyy-MM-dd HH:mm") + "') AND " +
                            " YEAR(F.DATA_ORA) = YEAR('" + varDate.ToString("yyyy-MM-dd HH:mm") + "') AND " +
                            " DAY(F.DATA_ORA) = DAY('" + varDate.ToString("yyyy-MM-dd HH:mm") + "')) AND F.ANULLUAR = 0" +
                            " GROUP BY F.ID_FORMAPAGESA, FP.FORMA_PAGESA, FP.KOMISIONI";
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, string varString1, string varString2, int varInt2, decimal varDecimal1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ModifikoOferte" :
                    strSql = "UPDATE OFERTAT SET EMRI = '" + varString1 + "', TIPI = '" + varString2 + "', SHPORTAT = " + varInt2 + ", CMIMI = " + varDecimal1 + " WHERE ID_OFERTA = " + varInt1;
                    break;

                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, string varString1, DateTime varDate1,
            decimal varDec1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "KryejShpenzim":
                    if (varInt2 == -1)
                        strSql = "INSERT INTO SHPENZIMET VALUES(" + varInt1 + ",'" + varString1 + "'," + varDec1 + ",'" +
                            varDate1.ToString("yyyy-MM-dd HH:mm") + "',null)";
                    else
                        strSql = "INSERT INTO SHPENZIMET VALUES(" + varInt1 + ",'" + varString1 + "'," + varDec1 + ",'" +
                            varDate1.ToString("yyyy-MM-dd HH:mm") + "',2)";
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, int varInt2, int varInt3, string varString1, DateTime varDate1,
            decimal varDec1)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ModifikoShpenzim":
                    //varInt1 --> idShpenzimi
                    //varInt2 --> idKategoria
                    //varInt3 --> idPersoneli
                    //varString1 --> pershkrimi
                    //varDate1 --> data
                    //varDec --> sasia
                    if (varInt3 == 0)
                        strSql = "UPDATE SHPENZIMET SET ID_KATEGORIASHPENZIMI = " + varInt2 + ", " +
                            "ID_PERSONELI = NULL, KOMENT = '" + varString1 + "', " +
                            " DATA = '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "'," +
                            "SASIA = " + varDec1 + " WHERE ID_SHPENZIMI = " + varInt1;
                    else
                        strSql = "UPDATE SHPENZIMET SET ID_KATEGORIASHPENZIMI = " + varInt2 + ", " +
                            "ID_PERSONELI = " + varInt3 + ", KOMENT = '" + varString1 + "', " +
                            " DATA = '" + varDate1.ToString("yyyy-MM-dd HH:mm") + "'," +
                            "SASIA = " + varDec1 + " WHERE ID_SHPENZIMI = " + varInt1;
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, string varString1, string varString2, DateTime varDate1, DateTime varDate2,
            DateTime varDate3)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ShtoRezervim":
                    strSql = "INSERT INTO REZERVIMET VALUES('" + varString1 + "','" + varString2 + "','" +
                        varDate1.ToString("yyyy-MM-dd") + "','" + varDate2.ToString("yyyy-MM-dd HH:mm") + "','" +
                        varDate3.ToString("yyyy-MM-dd HH:mm") + "')" +
                        Environment.NewLine + "SELECT SCOPE_IDENTITY()";
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        public string GetQuery(string kerkesaQuery, int varInt1, string varString1, string varString2, DateTime varDate1, DateTime varDate2,
            DateTime varDate3)
        {
            string strSql;
            switch (kerkesaQuery)
            {
                case "ModifikoRezervim":
                    strSql = "UPDATE REZERVIMET SET EMRI = '" + varString1 + "'," +
                        " MBIEMRI = '" + varString2 + "'," +
                        " DATA = '" + varDate1.ToString("yyyy-MM-dd") + "'," +
                        " ORA_FILLIMI = '" + varDate2.ToString("yyyy-MM-dd HH:mm") + "'," +
                        " ORA_MBARIMI = '" + varDate3.ToString("yyyy-MM-dd HH:mm") + "' " +
                        " WHERE ID_REZERVIMI = " + varInt1;
                    break;
                default:
                    strSql = "";
                    break;
            }
            return strSql;
        }

        #endregion

        #region PrivateMethods

        private string KtheStrPerShfaqjePersoneliSipasZgjedhjes(int zgjedhja, int roli, string emri)
        {
            string strSql = "";

            switch (zgjedhja)
            {
                case 1:
                    strSql = "SELECT ID_PERSONELI, EMRI, MBIEMRI, TELEFONI, P.ID_ROLI, R.ROLI, PERDORUESI, FJALEKALIMI, EMAILI, ADRESA, FOTO, AKTIV, FOTO_IMAZH " +
                            "FROM PERSONELI AS P INNER JOIN ROLET AS R ON P.ID_ROLI = R.ID_ROLI " +
                            "WHERE PERDORUESI LIKE '" + emri + "%'";
                    break;

                case 2:
                    strSql = "SELECT ID_PERSONELI, EMRI, MBIEMRI, TELEFONI, P.ID_ROLI, R.ROLI, PERDORUESI, FJALEKALIMI, EMAILI, ADRESA, FOTO, AKTIV, FOTO_IMAZH " +
                            "FROM PERSONELI AS P INNER JOIN ROLET AS R ON P.ID_ROLI = R.ID_ROLI " +
                            "WHERE P.ID_ROLI = " + roli ;
                    break;

                case 3:
                    strSql = "SELECT ID_PERSONELI, EMRI, MBIEMRI, TELEFONI, P.ID_ROLI, R.ROLI, PERDORUESI, FJALEKALIMI, EMAILI, ADRESA, FOTO, AKTIV, FOTO_IMAZH " +
                            "FROM PERSONELI AS P INNER JOIN ROLET AS R ON P.ID_ROLI = R.ID_ROLI " +
                            "WHERE PERDORUESI LIKE '" + emri + "%' AND P.ID_ROLI = " + roli ;
                    break;

                case 4:
                    strSql = "SELECT ID_PERSONELI, EMRI, MBIEMRI, TELEFONI, P.ID_ROLI, R.ROLI, PERDORUESI, FJALEKALIMI, EMAILI, ADRESA, FOTO, AKTIV , FOTO_IMAZH " +
                            "FROM PERSONELI AS P INNER JOIN ROLET AS R ON P.ID_ROLI = R.ID_ROLI " +
                            "WHERE AKTIV = 1 ";
                    break;

                case 5:
                    strSql = "SELECT ID_PERSONELI, EMRI, MBIEMRI, TELEFONI, P.ID_ROLI, R.ROLI, PERDORUESI, FJALEKALIMI, EMAILI, ADRESA, FOTO, AKTIV , FOTO_IMAZH" +
                            "FROM PERSONELI AS P INNER JOIN ROLET AS R ON P.ID_ROLI = R.ID_ROLI " +
                            "WHERE PERDORUESI LIKE '" + emri + "%' AND AKTIV = 1 ";
                    break;

                case 6:
                    strSql = "SELECT ID_PERSONELI, EMRI, MBIEMRI, TELEFONI, P.ID_ROLI, R.ROLI, PERDORUESI, FJALEKALIMI, EMAILI, ADRESA, FOTO, AKTIV , FOTO_IMAZH" +
                            "FROM PERSONELI AS P INNER JOIN ROLET AS R ON P.ID_ROLI = R.ID_ROLI " +
                            "WHERE P.ID_ROLI = " + roli + " AND AKTIV = 1 ";
                    break;

                case 7:
                    strSql = "SELECT ID_PERSONELI, EMRI, MBIEMRI, TELEFONI, P.ID_ROLI, R.ROLI, PERDORUESI, FJALEKALIMI, EMAILI, ADRESA, FOTO, AKTIV , FOTO_IMAZH" +
                            "FROM PERSONELI AS P INNER JOIN ROLET AS R ON P.ID_ROLI = R.ID_ROLI " +
                            "WHERE PERDORUESI LIKE '" + emri + "%' AND P.ID_ROLI = " + roli + " AND AKTIV = 1 ";
                    break;

                default:

                    strSql = "";
                    break;
            }

            return strSql;
        }

        private string KtheStrPerShfaqjeArtikujshPerSkorteSipasZgjedhjes(int zgjedhja, int idKategoria, string artikulli)
        {
            string strSql = "";

            switch (zgjedhja)
            {
                case 1:
                    strSql = "SELECT ID_ARTIKULLI, EMRI, A.ID_KATEGORIAARTIKULLI, PERSHKRIMI, ARTIKULL_KONSUMI, A.ID_NJESIA, NJESIA, NUMRI_TOTAL, SASIA_SKORTE, FOTO, DISPONUESHEM  " +
                             "FROM ARTIKUJT AS A INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                             "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                             "WHERE EMRI LIKE + '" + artikulli + "%'";
                    break;

                case 2:
                    strSql = "SELECT ID_ARTIKULLI, EMRI, A.ID_KATEGORIAARTIKULLI, PERSHKRIMI, ARTIKULL_KONSUMI, A.ID_NJESIA, NJESIA, NUMRI_TOTAL, SASIA_SKORTE, FOTO, DISPONUESHEM  " +
                             "FROM ARTIKUJT AS A INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                             "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                             "WHERE A.ID_KATEGORIAARTIKULLI = " + idKategoria;
                    break;

                case 3:
                    strSql = "SELECT ID_ARTIKULLI, EMRI, A.ID_KATEGORIAARTIKULLI, PERSHKRIMI, ARTIKULL_KONSUMI, A.ID_NJESIA, NJESIA, NUMRI_TOTAL, SASIA_SKORTE, FOTO, DISPONUESHEM  " +
                             "FROM ARTIKUJT AS A INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                             "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                             "WHERE EMRI LIKE + '" + artikulli + "%' AND A.ID_KATEGORIAARTIKULLI = " + idKategoria;
                    break;

                case 4:
                    strSql = "SELECT ID_ARTIKULLI, EMRI, A.ID_KATEGORIAARTIKULLI, PERSHKRIMI, ARTIKULL_KONSUMI, A.ID_NJESIA, NJESIA, NUMRI_TOTAL, SASIA_SKORTE, FOTO, DISPONUESHEM  " +
                             "FROM ARTIKUJT AS A INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                             "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                             "WHERE NUMRI_TOTAL < SASIA_SKORTE";
                    break;

                case 5:
                    strSql = "SELECT ID_ARTIKULLI, EMRI, A.ID_KATEGORIAARTIKULLI, PERSHKRIMI, ARTIKULL_KONSUMI, A.ID_NJESIA, NJESIA, NUMRI_TOTAL, SASIA_SKORTE, FOTO, DISPONUESHEM  " +
                             "FROM ARTIKUJT AS A INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                             "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                             "WHERE NUMRI_TOTAL < SASIA_SKORTE AND EMRI LIKE '" + artikulli + "%'";
                    break;

                case 6:
                    strSql = "SELECT ID_ARTIKULLI, EMRI, A.ID_KATEGORIAARTIKULLI, PERSHKRIMI, ARTIKULL_KONSUMI, A.ID_NJESIA, NJESIA, NUMRI_TOTAL, SASIA_SKORTE, FOTO, DISPONUESHEM  " +
                             "FROM ARTIKUJT AS A INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                             "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                             "WHERE NUMRI_TOTAL < SASIA_SKORTE AND A.ID_KATEGORIAARTIKULLI = " + idKategoria;
                    break;

                case 7:
                    strSql = "SELECT ID_ARTIKULLI, EMRI, A.ID_KATEGORIAARTIKULLI, PERSHKRIMI, ARTIKULL_KONSUMI, A.ID_NJESIA, NJESIA, NUMRI_TOTAL, SASIA_SKORTE, FOTO, DISPONUESHEM  " +
                            "FROM ARTIKUJT AS A INNER JOIN KATEGORITE_ARTIKUJT AS K ON A.ID_KATEGORIAARTIKULLI = K.ID_KATEGORIAARTIKULLI " +
                            "INNER JOIN NJESITE AS NJ ON A.ID_NJESIA = NJ.ID_NJESIA " +
                            "WHERE NUMRI_TOTAL < SASIA_SKORTE AND A.ID_KATEGORIAARTIKULLI = " + idKategoria + " AND EMRI LIKE '" + artikulli + "%'";
                    break;

                default:
                    break;


            }
            return strSql;
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

            while(gjendet == false && i < gj)
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
        #endregion
    }
}
