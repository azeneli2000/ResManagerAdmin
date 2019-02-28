using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ResManagerAdmin.BusDatService;
using ResManagerAdmin;

namespace ResManagerAdmin.BusDatService
{
    public class BusinessDelegate
    {
        #region Construcor
        #endregion

        #region Veprime Read
        public DataSet VeprimeRead(string idVeprime)
        {
            DataSet ds = null;
            switch (idVeprime)
            {
                case "ShfaqGrupCmimet" :
                    Receta objGrupCmimi = new Receta();
                    ds = objGrupCmimi.ShfaqGrupCmimet();
                    break;

                case "KtheKamarieretLoguar" :
                    Kamarieri kam = new Kamarieri();
                    ds = kam.KtheKamarieretLoguar();
                    break;

                case "ShfaqOfertatPerHotelin":
                    Oferta ofertaHoteli = new Oferta();
                    ds = ofertaHoteli.ShfaqOfertatPerHotelin();
                    break;

                case "ShfaqOfertatPerBarin":
                    Oferta ofertaBari = new Oferta();
                    ds = ofertaBari.ShfaqOfertatPerBarin();
                    break;

                case "ShfaqShpenzimetMujore":
                    Shpenzime objShpenzimeMujore = new Shpenzime();
                    ds = objShpenzimeMujore.ShfaqShpenzimetMujore();
                    break;
                    
                case "ShfaqKategoriShpenzimeshMujore" :
                    Shpenzime katShpenzimeMujore = new Shpenzime();
                    ds = katShpenzimeMujore.ShfaqKategoriShpenzimeshMujore();
                    break;

                case "ShfaqKamarieretPerKombo" :
                    Kamarieri kamKombo = new Kamarieri();
                    ds = kamKombo.ShfaqKamarieretPerKombo();
                    break;

                case "ShfaqTavolinatPerKombo" :
                    Tavolina tvKombo = new Tavolina();
                    ds = tvKombo.ShfaqTavolinatPerKombo();
                    break;
                    
                case "ShfaqFaturatPerSot" :
                    Fatura fatSot = new Fatura();
                    ds = fatSot.ShfaqFaturatPerSot();
                    break;

                case "KtheNrFaturaLast" :
                    Fatura fatLastObject = new Fatura();
                    ds = fatLastObject.KtheNrFaturaLast();
                    break;

                case "ShfaqFavorite":
                    Artikulli favoriteObject = new Artikulli();
                    ds = favoriteObject.ShfaqFavorite();
                    break;

                case "ShfaqRecetatSipasKategorive":
                    Receta recetaObjectKat = new Receta();
                    ds = recetaObjectKat.ShfaqRecetatSipasKategorive();
                    break;

                case "ShfaqRecetatSipasKategorivePerFavorite":
                    Receta recetaObjectKatFav = new Receta();
                    ds = recetaObjectKatFav.ShfaqRecetatSipasKategorivePerFavorite();
                    break;

                case "ShfaqArtikujtSipasKategorive":
                    Artikulli artikulliObject1 = new Artikulli();
                    ds = artikulliObject1.ShfaqArtikujtSipasKategorive();
                    break;

                case "ShfaqArtikujt":
                    Artikulli artikulliObject = new Artikulli();
                    ds = artikulliObject.ShfaqArtikujt();
                    break;

                case "ShfaqRolet":
                    Perdorues persObject = new Perdorues();
                    ds = persObject.ShfaqRolet();
                    break;

                case "ShfaqKategoriteETavolinave":
                    Tavolina tavolinaObject = new Tavolina();
                    ds = tavolinaObject.ShfaqKategorite();
                    break;
                case "ShfaqTavolinatDetaje":
                    Tavolina tavolinaObject1 = new Tavolina();
                    ds = tavolinaObject1.ShfaqTavolinatDetaje();
                    break;
                case "ShfaqTavolinenMeNumerMeTeMadh":
                    Tavolina tavolinaObject2 = new Tavolina();
                    ds = tavolinaObject2.TavolinaMeNrMeTeMadh();
                    break;

                case "ShfaqKategoriteEArtikujve":
                    Artikulli artikulliObject2 = new Artikulli();
                    ds = artikulliObject2.ShfaqKategoriteArtikuj();
                    break;

                case "ShfaqKategoriteEArtikujvePerMenu":
                    Artikulli artikulliObject22 = new Artikulli();
                    ds = artikulliObject22.ShfaqKategoriteArtikujPerMenu();
                    break;

                case "ShfaqKategoriteERecetave":
                    Receta recetaObject = new Receta();
                    ds = recetaObject.ShfaqKategoriteReceta();
                    break;

                case "ShfaqKategoriteERecetavePerMenu":
                    Receta recetaObjectMenu = new Receta();
                    ds = recetaObjectMenu.ShfaqKategoriteRecetaPerMenu();
                    break;

                case "ShfaqKategoriteEShpenzimeve":
                    Shpenzime shpenzimeObject = new Shpenzime();
                    ds = shpenzimeObject.ShfaqKategoriteShpenzime();
                    break;
                case "ShfaqNjesiteMatese":
                    Artikulli artikulliObject4 = new Artikulli();
                    ds = artikulliObject4.ShfaqNjesiteMatese();
                    break;
                case "ShfaqFormatEPageses":
                    Fatura faturaObject = new Fatura();
                    ds = faturaObject.ShfaqFormatEPageses();
                    break;
                case "ShfaqPerdoruesitJoKamariere":
                    Perdorues furnitoriObject = new Perdorues();
                    ds = furnitoriObject.ShfaqPerdoruesJoKamarier();
                    break;

                case "RezervimetESkaduara":
                    Rezervimi rezervimiObject = new Rezervimi();
                    ds = rezervimiObject.ShfaqRezervimeSkaduara();
                    break;

                case "ShfaqPerdoruesitKamariere":
                    Kamarieri kamarieriObject = new Kamarieri();
                    ds = kamarieriObject.ShfaqKamarieret();
                    break;

                case "LexoIntervaletCmime":
                    Global globalObject = new Global();
                    ds = globalObject.LexoIntervaletECmimeve();
                    break;

                case "InformacionetPerRestorantinShkurt":
                    //varString1 --> pathi i skedarit Xml
                    Global resObject = new Global();
                    ds = resObject.LexoInformacioneRestorantiShkurt();
                    break;

                case "LexoInformacioneRestoranti":
                    //varString1 --> pathi i skedarit Xml
                    Global resObject1 = new Global();
                    ds = resObject1.LexoInformacioneRestoranti(Global.stringXml + "\\Informacione.xml");
                    break;

                case "LexoBackUp":
                    Global globalObject2 = new Global();
                    ds = globalObject2.LexoBackUp();
                    break;     
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, DataSet varDs)
        {
            DataSet ds;
            switch (idVeprime)
            {
                case "KtheKufirinPerRecetat":
                    Receta recetatKufiri = new Receta();
                    ds = recetatKufiri.KtheKufirinPerRecetat(varDs);
                    break;

                case "FshiArtikujt":
                    Artikulli artikulliFshi = new Artikulli();
                    ds = artikulliFshi.FshiArtikujt(varDs);
                    break;

                case "FshiKategoriteETavolinave":
                    Tavolina tavolinaObject = new Tavolina();
                    ds = tavolinaObject.FshiKategoriTavoline(varDs);
                    break;

                case "FshiTavolinat":
                    Tavolina tavolinaObject1 = new Tavolina();
                    ds = tavolinaObject1.FshiTavolina(varDs);
                    break;

                case "FshiKategoriteEArtikujve":
                    Artikulli artikulliObject = new Artikulli();
                    ds = artikulliObject.FshiKategoriArtikujsh(varDs);
                    break;

                case "FshiKategoriteERecetave":
                    Receta recetaObject = new Receta();
                    ds = recetaObject.FshiKategoriRecetash(varDs);
                    break;

                case "FshiKategoriteEShpenzimeve":
                    Shpenzime shpenzimeObject = new Shpenzime();
                    ds = shpenzimeObject.FshiKategoriShpenzimi(varDs);
                    break;

                case "FshiNjesite":
                    Artikulli artikulliObject1 = new Artikulli();
                    ds = artikulliObject1.FshiNjesiMatese(varDs);
                    break;

                case "FshiFormatEPageses":
                    Fatura faturaObject = new Fatura();
                    ds = faturaObject.FshiFormaPagese(varDs);
                    break;

                case "FshiRezervimeSkaduara":
                    Rezervimi rezervimiObject = new Rezervimi();
                    ds = rezervimiObject.FshiRezervim(varDs);
                    break;

                case "FshiBlerjet":
                    Blerje blerjeObject = new Blerje();
                    ds = blerjeObject.FshiBlerjet(varDs);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, DataSet varDs, String varString1)
        {
            DataSet ds;
            switch (idVeprime)
            {
                case "FshiFurnitoret":
                    Furnitori furnitoriObject = new Furnitori();
                    ds = furnitoriObject.FshiFurnitor(varDs, varString1);
                    break;

                case "FshiKlientet":
                    Klienti klientiObject = new Klienti();
                    ds = klientiObject.FshiKlient(varDs, varString1);
                    ds = null;
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, int varInt1, int varInt2, int varInt3)
        {
            DataSet ds;
            switch (idVeprime)
            {
                case "ShtoDisaTavolina":
                    //varInt1 --> numri i tavolinave qe do te shtohen
                    //varInt2 --> idKategoria
                    //varInt3 --> kapaciteti
                    Tavolina tavolinaObject = new Tavolina();
                    ds = tavolinaObject.ShtoDisaTavolina(varInt1, varInt2, varInt3);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, int varInt1, int varInt2)
        {
            DataSet ds;
            switch (idVeprime)
            {
                case "ShfaqArtikujPerKategoriFurnitor":
                    //varInt1 --> idKategoria
                    //varInt2 --> idFurnitori
                    Artikulli artikulliObject = new Artikulli();
                    ds = artikulliObject.ArtikujtPerKategoriFurnitor(varInt1, varInt2);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, int varInt1, int varInt2, string varString1)
        {
            DataSet ds;
            switch (idVeprime)
            {
                case "ShfaqArtikujtSipasZgjedhjes":
                    //varInt1 --> koeficenti i zgjedhjes
                    //varInt2 --> celesi i kategorise
                    //varString1 --> emri i artikullit
                    Artikulli artikulliObject = new Artikulli();
                    ds = artikulliObject.ShfaqArtikujtSipasZgjedhjesPerSkorte(varInt1, varInt2, varString1);
                    break;

                case "ShfaqPersonelinSipasZgjedhjes":
                    //varInt1 --> koeficenti i zgjedhjes
                    //varInt2 --> roli i personelit
                    //varString1 --> emri i personelit
                    Perdorues perdoruesObject = new Perdorues();
                    ds = perdoruesObject.ShfaqPersonelinSipasZgjedhjes(varInt1, varInt2, varString1);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, string varString1)
        {
            DataSet ds = null;
            switch (idVeprime)
            {

                case "ShfaqShpenzimetMujoreSipasKerkimit" :
                    //varString1 --> query qe do te perdoret
                    Shpenzime kerkoShpenzimeMujore = new Shpenzime();
                    ds = kerkoShpenzimeMujore.ShfaqShpenzimetMujoreSipasKerkimit(varString1);
                    break;

                case "KtheFaturatSipasKerkimit" :
                     //varString1 --> query qe do te perdoret
                    Fatura faturaKerkimi = new Fatura();
                    ds = faturaKerkimi.KtheFaturatSipasKerkimit(varString1);
                    break;

                case "ShfaqArtikujtPerBar":
                    //varString1 --> query qe do te perdoret
                    Artikulli artRecObject = new Artikulli();
                    ds = artRecObject.ShfaqArtikujtPerBar(varString1);
                    break;


                case "ShfaqKlientet":
                    Klienti klientiObject = new Klienti();
                    ds = klientiObject.ShfaqKlientet(varString1);
                    break;

                case "ShfaqFurnitoret":
                    Furnitori furnitoriObject = new Furnitori();
                    ds = furnitoriObject.ShfaqFurnitore(varString1);
                    break;

                case "ShfaqShpenzimet":
                    Shpenzime shpenzimeObject = new Shpenzime();
                    ds = shpenzimeObject.ShfaqShpenzime(varString1);
                    break;

                case "ShfaqTurnet":
                    Kamarieri kamarieriObject = new Kamarieri();
                    ds = kamarieriObject.ShfaqTurnet(varString1);
                    break;

                case "ShfaqBlerjet":
                    Blerje blerjeObject = new Blerje();
                    ds = blerjeObject.ShfaqBlerjet(varString1);
                    break;

                case "ShfaqArtikujtPerFurnitoret":
                    Furnitori furnitoriObject1 = new Furnitori();
                    ds = furnitoriObject1.ShfaqArtikujtPerFurnitoret(varString1);
                    break;

                case "ShfaqRecetat":
                    Receta recetaObject = new Receta();
                    ds = recetaObject.ShfaqRecetat(varString1);
                    break;

                case "XhirojaPerSecilenDate":
                    Statistika statistikaObject = new Statistika();
                    ds = statistikaObject.XhirojaPerSecilenDate(varString1);
                    break;

                case "ShfaqXhiroSipasFaturavePerDaten":
                    Statistika statistikaObject1 = new Statistika();
                    ds = statistikaObject1.XhirojaPerDatenSipasFaturave(varString1);
                    break;

                case "XhirojaPerSecilenDateSipasArtikujve":
                    Statistika statistikaObject2 = new Statistika();
                    ds = statistikaObject2.XhirojaPerArtikullin(varString1);
                    break;

                case "XhirojaPerSecilenDateSipasRecetave":
                    Statistika statistikaObject3 = new Statistika();
                    ds = statistikaObject3.XhirojaPerReceten(varString1);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, string varString1, string varString2)
        {
            DataSet ds;
            switch (idVeprime)
            {
                case "GjejPerdorues":
                    Perdorues perdoruesObject = new Perdorues();
                    ds = perdoruesObject.GjejPerdorues(varString1, varString2);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, string varString1, int varInt1)
        {
            DataSet ds;
            switch (idVeprime)
            {
                case "LexoTeDhenaPerArtikullin":
                    Artikulli artikulliTeDhena = new Artikulli();
                    ds = artikulliTeDhena.LexoTeDhenaPerArtikullin(varString1, varInt1);
                    //varString1 --> lloji i artikullit
                    //varInt1 --> celesi i artkullit
                    break;

                case "VerifikoFjalekalimin":
                    Perdorues userObj = new Perdorues();
                    ds = userObj.VerifikoFjalekalimin(varString1, varInt1);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, DateTime varDate1)
        {
            DataSet ds;
            switch (idVeprime)
            {
                case "ShfaqFaturatPerDatenZgjedhur" :
                    Fatura fatObject = new Fatura();
                    ds = fatObject.FaturatPerdaten(varDate1);
                    break;
                       
                case "ShpenzimetPerDaten":
                    Shpenzime shpenzimeObject = new Shpenzime();
                    ds = shpenzimeObject.ShpenzimetPerDaten(varDate1);
                    break;

                case "ShfaqRezervimetTavolina":
                    Rezervimi rezervimiObject = new Rezervimi();
                    ds = rezervimiObject.ShfaqRezervime(varDate1);
                    break;

                case "ShfaqGjendjeArka":
                    Statistika statistikaObject = new Statistika();
                    ds = statistikaObject.GjendjeArke(varDate1);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, int varInt1)
        {
            DataSet ds = null;
            switch (idVeprime)
            {
                case "ShfaqEkstratPerReceten":
                    //varInt1 --> idReceta
                    Receta recEkstra = new Receta();
                    ds = recEkstra.ShfaqEkstratPerReceten(varInt1);
                    break;

                case "KtheArtikujtPerFature" :
                    //varInt1 --> idFatura
                    Fatura fatArtikujt = new Fatura();
                    ds = fatArtikujt.KtheArtikujtPerFature(varInt1);
                    break;

                case "ShfaqFaturatKorentePerTavoline" :
                    //varInt1 --> idTavolina
                    Tavolina tavFaturat = new Tavolina();
                    ds = tavFaturat.ShfaqFaturatKorentePerTavoline(varInt1);
                    break;

                case "ShfaqCmimeRecetatPerGrupinZgjedhur" :
                    //varInt1 --> idGrupi
                    Receta cmimetGrupi = new Receta();
                    ds = cmimetGrupi.ShfaqCmimeRecetatPerGrupinZgjedhur(varInt1);
                    break;

                case "ShfaqTeDhenaPerOferten":
                    //varInt1 --> idOferta
                    Oferta ofertaRecetat = new Oferta();
                    ds = ofertaRecetat.ShfaqTeDhenaPerOferten(varInt1);
                    break;

                case "ShfaqRecetatPerKategoriOferte":
                    //varInt1 --> idKategoriaRecete
                    Receta recetaObjectKatOferte = new Receta();
                    ds = recetaObjectKatOferte.ShfaqRecetatPerKategoriOferte(varInt1);
                    break;

                case "PrintoFaturenPC" :
                    //varInt1 --> idFatura
                    Fatura fatPrintoPc = new Fatura();
                    ds = fatPrintoPc.PrintoFaturenPC(varInt1);
                    break;

                case "ShfaqStatistikaPerVitin" :
                    //varInt1 --> viti
                    Statistika statViti = new Statistika();
                    ds = statViti.ShfaqStatistikaPerVitin(varInt1);
                    break;

                case "ShfaqTeDhenaPerFaturen" :
                    //varInt1 --> celesi i fatures
                    Fatura fat1Object = new Fatura();
                    ds = fat1Object.ShfaqTeDhenaPerFaturen(varInt1);
                    break;

                case "ShfaqTurnetPerLodim":
                    Kamarieri kamTurniXhiro = new Kamarieri();
                    ds = kamTurniXhiro.ShfaqTurnetPerLodim(varInt1);
                    break;

                case "LexoXhironPerKamarierin":
                    Perdorues kamXhiro = new Perdorues();
                    ds = kamXhiro.LexoXhironPerKamarierin(varInt1);
                    break;

                case "ShfaqRecetatPerKategoriKonfigurimCmimesh" :
                    //varInt1 --> celesi i kategorise se recetave
                    Receta recetaShfaqKostoPerKat = new Receta();
                    ds = recetaShfaqKostoPerKat.ShfaqRecetatPerKategoriKonfigurimCmimesh(varInt1);
                    break;

                case "ShfaqArtikujtPerKategoriPerKonfigurimCmimesh":
                    Artikulli artikulliCmimet1 = new Artikulli();
                    ds = artikulliCmimet1.ShfaqArtikujtPerKategoriPerKonfigurimCmimesh(varInt1);
                    //varInt1 --> celesi i kategorise se artikulli
                    break;

                case "ShfaqCmimetEfunditPerArtikullin":
                    Artikulli artikulliCmimetShfaq = new Artikulli();
                    ds = artikulliCmimetShfaq.ShfaqCmimetEfunditPerArtikullin(varInt1);
                    //varInt1 --> celesi i artikullit
                    break;

                case "ShfaqCmimetPerArtikullin":
                    Artikulli artikulliCmimetShfaq1 = new Artikulli();
                    ds = artikulliCmimetShfaq1.ShfaqCmimetPerArtikullin(varInt1);
                    //varInt1 --> celesi i artikullit
                    break;

                case "ShfaqTeDhenaPerArtikullin":
                    Artikulli artikulliModifiko = new Artikulli();
                    ds = artikulliModifiko.ShfaqTeDhenaPerArtikullin(varInt1);
                    //varInt1 --> celesi i artikullit
                    break;

                case "KthePathiFotoPersoneli":
                    Perdorues fotoPathi = new Perdorues();
                    ds = fotoPathi.KthePathiFotoPersoneli(varInt1);
                    //varInt1 --> celesi i personelit
                    break;

                case "ShfaqTeDhenaPerPersonelinZgjedhur":
                    Perdorues userObject = new Perdorues();
                    ds = userObject.ShfaqTeDhenaPerPersonelinZgjedhur(varInt1);
                    //varInt1 --> celesi i personelit
                    break;

                case "ShfaqTeDhenaRezervimi":
                    Rezervimi rezervimiObject = new Rezervimi();
                    ds = rezervimiObject.ShfaqTeDhenaRezervimi(varInt1);
                    break;

                case "ShfaqArtikujPerKategori":
                    //varInt1 --> idKategoria
                    Artikulli artikullObject = new Artikulli();
                    ds = artikullObject.ArtikujtPerKategori(varInt1);
                    break;

                case "ShfaqArtikujtMeTeNjejtenKategori":
                    //varInt1 --> idArtikulli
                    Artikulli artikullObject1 = new Artikulli();
                    ds = artikullObject1.ArtikujtKategoriNjejte(varInt1);
                    break;

                case "ShfaqArtikujCmimePerKategori":
                    //varInt1 --> idKategoria
                    Receta recetaObject2 = new Receta();
                    ds = recetaObject2.ArtikujtCmimetPerKategorine(varInt1);
                    break;

                case "ShfaqRecetatPerKategori":
                    //varInt1 --> idKategoria
                    Receta recetaObject3 = new Receta();
                    ds = recetaObject3.ShfaqRecetatPerKategorine(varInt1);
                    break;

                case "LexoCmimetPerReceten":
                    //varInt1 --> idReceta
                    Receta recetaObject4 = new Receta();
                    ds = recetaObject4.LexoCmiminERecetes(varInt1);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, DateTime varDate1, DateTime varDate2)
        {
            DataSet ds = null;
            switch (idVeprime)
            {

                case "ShfaqBilancinPerPeriudhen":
                    Statistika statBilanci = new Statistika();
                    ds = statBilanci.ShfaqBilancinPerPeriudhen(varDate1, varDate2);
                    break;

                case "ShfaqniFitiminPerPeriudhen":
                    Statistika statFitimi = new Statistika();
                    ds = statFitimi.ShfaqniFitiminPerPeriudhen(varDate1, varDate2);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }


        public DataSet VeprimeRead(string idVeprime, int varInt1, DateTime varDate1, DateTime varDate2)
        {
            DataSet ds = null;
            switch (idVeprime)
            {

                case "ShfaqTavolinatEliraPerKategori":
                    Tavolina tavolinaObject = new Tavolina();
                    ds = tavolinaObject.TavolinatLiraPerKategori(varInt1, varDate1, varDate2);
                    break;

                case "ShfaqTurnetPerKamarierPerPeriudhen" :
                    Kamarieri kamTurniXhiro = new Kamarieri();
                    ds = kamTurniXhiro.ShfaqTurnetPerKamarierPerPeriudhen(varInt1, varDate1, varDate2);
                    break;

                case "LexoTurninPerKamarierin":
                    Kamarieri kamTurni= new Kamarieri();
                    ds = kamTurni.LexoTurninPerKamarierin(varInt1, varDate1, varDate2);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, int varInt1, int varInt2,
            DateTime varDate1, DateTime varDate2)
        {
            DataSet ds = null;
            switch (idVeprime)
            {
                case "ShfaqTavolinatEliraPerKategori":
                    Tavolina tavolinaObject = new Tavolina();
                    ds = tavolinaObject.TavolinatLiraPerKategori(varInt1, varInt2, varDate1, varDate2);
                    break;

                case "XhirojaPerSecilenDateSipasRecetave" :
                    //varInt1 --> idKatReceta
                    //varInt2 --> idReceta
                    //varDate1 --> dateFillimi
                    //varDate2 --> dateMbarimi
                    Statistika statXhiroReceta = new Statistika();
                    ds = statXhiroReceta.XhirojaPerSecilenDateSipasRecetave(varInt1, varInt2, varDate1, varDate2);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, int varInt1, bool varBool1, int varInt2, DateTime varDate1)
        {
            DataSet ds = null;
            switch (idVeprime)
            {
                case "ShfaqTurnetSipasKerkimit":
                    Kamarieri kamTurnet = new Kamarieri();
                    ds = kamTurnet.ShfaqTurnetSipasKerkimit(varInt1, varBool1, varInt2, varDate1);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }


        public DataSet VeprimeRead(string idVeprime, int[] varArrayInt1)
        {
            DataSet ds = null;
            switch (idVeprime)
            {

                case "LexoTeDhenaPerTavolinen" :

                    Fatura fatTavObject = new Fatura();
                    ds = fatTavObject.LexoTeDhenaPerTavolinen(varArrayInt1);
                    break;

                case "LexoOfertatPerTavolinen":

                    Fatura fatTavOfertat = new Fatura();
                    ds = fatTavOfertat.LexoTeDhenaPerTavolinen(varArrayInt1);
                    break;


                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet VeprimeRead(string idVeprime, int varInt1, DataSet varDs)
        {
            DataSet ds = null;
            switch (idVeprime)
            {

                case "ModifikoBlerje":
                    Blerje blerjeObject = new Blerje();
                    ds = blerjeObject.ModifikoBlerje(varInt1, varDs);
                    break;

                case "RuajPerkatesiArtikuj":
                    Furnitori furnitoriObject = new Furnitori();
                    ds = furnitoriObject.RuajPerkatesiArtikuj(varInt1, varDs);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        #endregion

        #region VeprimeUpdate

        public int VeprimeUpdate(string idVeprime)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoKostoVilaX" :
                    Artikulli vilaX = new Artikulli();
                    b = vilaX.ModifikoKostoVilaX();
                    return b;

                case "FshiHistorikTurnet":
                    Kamarieri kamarieriObject = new Kamarieri();
                    b = kamarieriObject.FshiHistorikTurnet();
                    break;

                case "KrijoBackUp":
                    Global globalObject = new Global();
                    b = globalObject.KrijoBackUp();
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, string varString1)
        {
            int b = 0;
            switch (idVeprime)
            {
                case "ShtoKategoriTavolinash":
                    Tavolina tavolinaObject = new Tavolina();
                    b = tavolinaObject.ShtoKategoriTavoline(varString1);
                    break;

                case "ShtoKategoriRecete":
                    Receta recetaObject = new Receta();
                    b = recetaObject.ShtoKategoriRecete(varString1);
                    break;

                case "ShtoKategoriShpenzimi":
                    Shpenzime shpenzimeObject = new Shpenzime();
                    b = shpenzimeObject.ShtoKategoriShpenzimi(varString1);
                    break;


                case "ShtoNjesi":
                    Artikulli artikulliObject1 = new Artikulli();
                    b = artikulliObject1.ShtoNjesiMatese(varString1);
                    break;

                case "KarikoBackUp":
                    Global globalObject = new Global();
                    b = globalObject.KarikoBackUp(varString1);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, string varString1, decimal varDec1)
        {
            int b;
            switch (idVeprime)
            {
                case "ShtoFormePagese":
                    //varString1 --> emri i formes se pageses
                    //varDec1 --> komisioni i formes se pageses
                    Fatura faturaObject = new Fatura();
                    b = faturaObject.ShtoFormePagese(varString1, varDec1);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, string varString1)
        {
            int b;
            switch (idVeprime)
            {
                case "ShtoKategoriArtikulli":
                    //varInt1 --> {0, 1} per statusin e kategorise
                    //varString1 --> emri i kategorise
                    Artikulli artikulliObject = new Artikulli();
                    b = artikulliObject.ShtoKategoriArtikulli(varString1, varInt1);
                    break;

                case "ModifikoKategoriTavoline":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    Tavolina tavolinaObject = new Tavolina();
                    b = tavolinaObject.ModifikoKategoriTavoline(varInt1, varString1);
                    break;

                
                case "ModifikoKategoriRecete":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    Receta recetaObject = new Receta();
                    b = recetaObject.ModifikoKategoriRecete(varInt1, varString1);
                    break;

                case "ModifikoKategoriShpenzimi":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    Shpenzime shpenzimeObject = new Shpenzime();
                    b = shpenzimeObject.ModifikoKategoriShpenzimi(varInt1, varString1);
                    break;
                case "ModifikoNjesi":
                    //varInt1 --> idNjesia
                    //varString1 --> emri i ri i njesise
                    Artikulli artikulliObject22 = new Artikulli();
                    b = artikulliObject22.ModifikoNjesiMatese(varInt1, varString1);
                    break;

                case "ModifikoFjalekalim":
                    //varInt1 --> idPerdoruesi
                    //varString1 --> fjalekalimi i ri
                    Kamarieri kamarieriObject = new Kamarieri();
                    b = kamarieriObject.ModifikoFjalekalim(varInt1, varString1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1)
        {
            int b = 0;
            switch (idVeprime)
            {
                case "FshiGrupCmimi" :
                    // varInt1 --> idGrupCmimi
                    Receta fshiGrupCmimi = new Receta();
                    fshiGrupCmimi.FshiGrupCmimi(varInt1);
                    break;

                case "AnulloFaturen" :
                    //varInt1 --> celesi i fatures
                    Fatura fatAnullo = new Fatura();
                    b = fatAnullo.AnulloFaturen(varInt1);
                    break;


                case "MbyllTurnin":
                    //varInt1 --> celesi i kamarierit
                    Perdorues kamTurni = new Perdorues();
                    b = kamTurni.MbyllTurnin(varInt1);
                    break;

                case "FshiPerdorues" :
                    //varInt1 --> idPerdoruesi
                    Perdorues userObject11 = new Perdorues();
                    b = userObject11.FshiPerdorues(varInt1);
                    break;

                case "MbyllTavolinen" :
                    //varInt1 --> idTavolina
                    Tavolina tavolinaMbyll = new Tavolina();
                    b = tavolinaMbyll.Mbyll(varInt1);
                    break;

                case "HapTavoline":
                    //varInt1 --> idTavolina
                    Tavolina tavolinaHap = new Tavolina();
                    b = tavolinaHap.HapTavoline(varInt1);
                    break;

                case "FshiPersonel":
                    //varInt1 --> idPersoneli
                    Perdorues perdoruesFshi = new Perdorues();
                    b = perdoruesFshi.FshiPersonel(varInt1);
                    break;

                case "FshiRezervim":
                    //varInt1 --> idRezervimi
                    Rezervimi rezervimiObject = new Rezervimi();
                    b = rezervimiObject.FshiRezervim(varInt1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2)
        {
            int b;
            switch (idVeprime)
            {
                case "Login":
                    //varInt1 --> idPerdoruesi
                    //varInt2 --> tregon nqs duhet bere modifikimi i turneve
                    Perdorues perdoruesObject = new Perdorues();
                    b = perdoruesObject.Login(varInt1, varInt2);
                    break;

                case "Logout":
                    //varInt1 --> idPerdoruesi
                    //varInt2 --> tregon nqs duhet bere modifikimi i turneve
                    Perdorues perdoruesObject1 = new Perdorues();
                    b = perdoruesObject1.Logout(varInt1, varInt2);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, string varString1, decimal varDec1)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoFormePagese":
                    //varInt1 --> idFormaPagesa
                    //varString1 --> emri i ri i formes se pageses
                    //varDec -->komisioni i formes se pageses
                    Fatura faturaObject = new Fatura();
                    b = faturaObject.ModifikoFormePagese(varInt1, varString1, varDec1);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, string varString1, int varInt2, int varInt3)
        {
            int b;
            switch (idVeprime)
            {
                case "ShtoTavoline":
                    //varString1 --> emri
                    //varInt2 --> idKategoria
                    //varInt3 --> kapaciteti
                    Tavolina tavolinaObject = new Tavolina();
                    b = tavolinaObject.ShtoTavoline(varString1, varInt2, varInt3);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, string varString1)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoKategoriArtikulli":
                    //varInt1 --> idKategoria
                    //varInt2 --> {0, 1} percakton shfaqjen ne menu te artikullit
                    //varString1 --> emri i ri i kategorise
                    Artikulli artikulliObject1 = new Artikulli();
                    b = artikulliObject1.ModifikoKategoriArtikulli(varInt1, varInt2, varString1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, string varString1, string varString2)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoKategoriShpenzimiMujor":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i kategorise
                    //varString2 --> pershkrimi i kategorise
                    Shpenzime katShpenzimiMujor = new Shpenzime();
                    b = katShpenzimiMujor.ModifikoKategoriShpenzimiMujor(varInt1, varString1, varString2);
                    break;

                case "ModifikoGrupCmimi" :
                    //varInt1 --> idGrupi
                    //varString1 --> emri i grupit
                    //varString2 --> pershkrimi i grupit
                    Receta grupCmimi = new Receta();
                    b = grupCmimi.ModifikoGrupCmimi(varInt1, varString1, varString2);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, int[] varArrayInt1)
        {
            int b;
            switch (idVeprime)
            {
                case "TransferoTavolinen":
                    //varInt1 --> idTavolinaOld
                    //varInt2 --> idTavolinaNew
                    //varArrayInt1 --> vektori i idFaturave qe tranferohen
                    Tavolina tavolinaObject = new Tavolina();
                    b = tavolinaObject.TransferoTavolinen(varInt1, varInt2, varArrayInt1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, string  varString1, int varInt3, int varInt4)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoTavoline":
                    //varInt1 -->idTavolina
                    //varString1 --> emri
                    //varInt3 --> idKategoria
                    //varInt4 --> kapaciteti
                    Tavolina tavolinaObject = new Tavolina();
                    b = tavolinaObject.ModifikoTavoline(varInt1, varString1, varInt3, varInt4);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, string varString1, string varString2, int varInt2, decimal varDecimal1, DataSet varDs1)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoOferte":

                    //varInt1 --> idOferta
                    // varString1 --> emri i ofertes
                    // varString2 --> tipi i ofertes
                    // varInt2 --> numri i shportave
                    // varDecimal1 --> cmimi
                    // varDs1 --> recetat

                    Oferta ofertaModifiko = new Oferta();
                    b = ofertaModifiko.ModifikoOferte(varInt1, varString1, varString2, varInt2, varDecimal1, varDs1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int VeprimeUpdate(string idVeprime, int varInt1, double varDouble1, double varDouble2, DataSet varDs1)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoFature":
                    //varInt1 --> idFatura
                    //varDouble1 --> totali
                    //varDouble2 --> skonto
                    //varDs1 --> dataset i recetave
                    Fatura fatObject = new Fatura();
                    b = fatObject.ModifikoFature(varInt1, varDouble1, varDouble2, varDs1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int VeprimeUpdate(string idVeprime, string varString1, string varString2, string varString3,
            string varString4, string varString5)
        {
            int b;
            switch (idVeprime)
            {
                case "ShtoKlient":

                    //varInt1 --> idKlienti
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> kodi
                    //varString4 --> telefoni
                    //varString5 --> adresa

                    Klienti klientiObject = new Klienti();
                    b = klientiObject.ShtoKlient(varString1, varString2, varString3, varString4, varString5);

                    break;

                case "ShtoFurnitor":
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> adresa
                    //varString4 --> emaili
                    //varString5 --> telefoni
                    Furnitori furnitorObject = new Furnitori();
                    b = furnitorObject.ShtoFurnitor(varString1, varString2, varString3,
                        varString4, varString5);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, string varString1, string varString2, string varString3,
            string varString4, string varString5)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoFurnitor":
                    //varInt1 -->idFurnitori
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> adresa
                    //varString4 --> emaili
                    //varString5 --> telefoni
                    Furnitori furnitorObject = new Furnitori();
                    b = furnitorObject.ModifikoFurnitor(varInt1, varString1, varString2, varString3,
                        varString4, varString5);
                    break;

                case "ModifikoKlient":
                    //varInt1 -->idFurnitori
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> adresa
                    //varString4 --> emaili
                    //varString5 --> telefoni
                    Klienti klientiObject = new Klienti();
                    b = klientiObject.ModifikoKlient(varInt1, varString1, varString2, varString3, varString4, varString5);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, string varString1, DateTime varDate1,
            decimal varDec1)
        {
            int b;
            switch (idVeprime)
            {
                case "KryejShpenzim":
                    //varInt1 --> idKategoria
                    //varInt2 --> idPersoneli
                    //varString1 --> pershkrimi
                    //varDate1 --> data
                    //varDec --> sasia
                    Shpenzime shpenzimeObject = new Shpenzime();
                    b = shpenzimeObject.KryejShpenzim(varInt1, varInt2, varString1, varDate1, varDec1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, int varInt3, string varString1, string varString2, double varDouble1, double varDouble2)
        {
            int b;
            switch (idVeprime)
            {
                case "KrijoArtikull":
                    //varInt1 --> idKategoria
                    //varInt2 --> idNjesia
                    //varInt3 --> lloji i konsumit
                    //varString1 --> kodi i artikullit
                    //varString2 --> pathi i fotos
                    //varDouble1 --> cmimi
                    //varDouble2 --> sasiaSkorte

                    Artikulli artikullObject = new Artikulli();
                    b = artikullObject.KrijoArtikull(varInt1, varInt2, varInt3, varString1, varString2, varDouble1, varDouble2);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, int varInt3, int varInt4, string varString1, string varString2, double varDouble1, double varDouble2)
        {
            int b;
            switch (idVeprime)
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

                    Artikulli artikullObject = new Artikulli();
                    b = artikullObject.ModifikoArtikull(varInt1, varInt2, varInt3, varInt4, varString1, varString2, varDouble1, varDouble2);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, int varInt3, string varString1, DateTime varDate1,
            decimal varDec1)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoShpenzim":
                    //varInt1 --> idShpenzimi
                    //varInt2 --> idKategoria
                    //varInt3 --> idPersoneli
                    //varString1 --> pershkrimi
                    //varDate1 --> data
                    //varDec --> sasia
                    Shpenzime shpenzimeObject = new Shpenzime();
                    b = shpenzimeObject.ModifikoShpenzim(varInt1, varInt2, varInt3, varString1, varDate1, varDec1);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }



        public int VeprimeUpdate(string idVeprime, DataSet varDs)
        {
            int b = 0;
            switch (idVeprime)
            {
                case "ModifikoGrupCmiminZgjedhur" :
                    Receta modifikoGrupCmimi = new Receta();
                    b = modifikoGrupCmimi.ModifikoGrupCmiminZgjedhur(varDs);
                    break;

                case "MbyllGjitheTurnet" :
                    Perdorues mbyllTurnet = new Perdorues();
                    b = mbyllTurnet.MbyllGjitheTurnet(varDs);
                    break;
                
                case "HidhFavorite":
                    Artikulli favoriteObject = new Artikulli();
                    b = favoriteObject.HidhFavorite(varDs);
                    break;

                case "AktivizoArtikujt":
                    Artikulli artAktivizo = new Artikulli();
                    b = artAktivizo.AktivizoArtikujt(varDs);
                    break;

                case "CaktivizoArtikujt":
                    Artikulli artikulliObject = new Artikulli();
                    b = artikulliObject.CaktivizoArtikujt(varDs);
                    break;

                case "FshiShpenzimet":
                    Shpenzime shpenzimeObject = new Shpenzime();
                    b = shpenzimeObject.FshiShpenzime(varDs);
                    break;

                case "Logout":
                    Perdorues perdoruesObject = new Perdorues();
                    b = perdoruesObject.Logout(varDs);
                    break;

                case "ShtoBlerje":
                    Blerje blerjeObject = new Blerje();
                    b = blerjeObject.ShtoBlerje(varDs);
                    break;

                case "FshiPerkatesiArtikuj":
                    Furnitori furnitoriObject = new Furnitori();
                    b = furnitoriObject.FshiPerkatesiArtikuj(varDs);
                    break;

                case "ShtoRecete":
                    Receta recetaObject = new Receta();
                    //b = recetaObject.ShtoRecete(varDs);
                    break;

                case "FshiRecetat":
                    Receta recetaObject1 = new Receta();
                    b = recetaObject1.FshiReceta(varDs);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int VeprimeUpdate(string idVeprime, DataSet varDs1, DataSet varDs2)
        {
            int b = 0;
            DataSet ds = null;
            switch (idVeprime)
            {
               
                case "ShtoRecete":
                    Receta recetaObject = new Receta();
                    b = recetaObject.ShtoRecete(varDs1, varDs2);
                    break;

                case "RuajIntervalet":
                    //varDs1 --> ds i modifikuar
                    //varDs2 --> ds ekzistues
                    Global globalObject = new Global();
                    ds = globalObject.RuajIntervalet(varDs1, varDs2);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int VeprimeUpdate(string idVeprime, int varInt1, DataSet varDs)
        {
            int b = 0;
            switch (idVeprime)
            {
                case "ModifikoCmimeRecetatPerGrup" :
                    //varInt1 --> celesi i grupcmimit
                    //varDs --> ketu ruhen te dhenat per recetat
                    Receta grupCmimet = new Receta();
                    b = grupCmimet.ModifikoCmimeRecetatPerGrup(varInt1, varDs);
                    break;
                
                case "KrijoCmimePerArtikull":
                    //varInt1 --> cmimi i artikullit
                    //varDs --> cmimet per artikujt
                    Artikulli artikulliCmimet = new Artikulli();
                    b = artikulliCmimet.KrijoCmimetPerArtikullin(varInt1, varDs);
                    break;

               
                case "NdryshoDisponibilitet":
                    Receta recetaObject1 = new Receta();
                    b = recetaObject1.NdryshoDisponibilitet(varInt1, varDs);
                    break;

                case "KrijoCmimePerRecete":
                    Receta recetaObject2 = new Receta();
                    b = recetaObject2.KrijoCmimetPerReceten(varInt1, varDs);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int VeprimeUpdate(string idVeprime, int varInt1, DataSet varDs1, DataSet varDs2)
        {
            int b = 0;
            switch (idVeprime)
            {
              
                case "ModifikoRecete":
                    //varInt1 --> idReceta
                    //varDs1 --> artikujt perberes te recetes
                    //varDs2 --> mban ekstrat per receten
                    Receta recetaObject = new Receta();
                    b = recetaObject.ModifikoRecete(varInt1, varDs1, varDs2);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, int varInt3, double varDouble1, string varString1)
        {
            int b = 0;
            switch (idVeprime)
            {
                case "KrijoShpenzimMujor":
                    //varInt1 --> idKategoria
                    //varInt2 --> muaji
                    //varInt3 --> viti
                    //varDouble1 --> vlera
                    //varString1 --> komenti mbi shpenzimin
                    Shpenzime shpenzimeObject = new Shpenzime();
                    b = shpenzimeObject.KrijoShpenzimMujor(varInt1, varInt2, varInt3, varDouble1, varString1);
                    break;


                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, double varDouble1, string varString1)
        {
            int b = 0;
            switch (idVeprime)
            {
                case "ModifikoShpenzimMujor":
                    //varInt1 --> idShpenzimiMujor
                    //varDouble1 --> vlera
                    //varString1 --> komenti mbi shpenzimin
                    Shpenzime shpenzimeObject = new Shpenzime();
                    b = shpenzimeObject.ModifikoShpenzimMujor(varInt1, varDouble1, varString1);
                    break;


                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, string varString1, string varString2, int varInt1, decimal varDecimal1, DataSet varDs1)
        {
            int b = 0;
            switch (idVeprime)
            {
                case "KrijoOferte":

                    // varString1 --> emri i ofertes
                    // varString2 --> tipi i ofertes
                    // varInt1 --> numri i shportave
                    // varDecimal1 --> cmimi
                    // varDs1 --> recetat

                    Oferta ofertaKrijo = new Oferta();
                    b = ofertaKrijo.KrijoOferte(varString1, varString2, varInt1, varDecimal1, varDs1);
                    break;


                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, int varInt3, int varInt4, double varDouble1, double varDouble2, string varString1,  DataSet varDs1, DataSet varDs2)
        {
            int b = 0;
            switch (idVeprime)
            {
                case "KrijoFature":
                    //varInt1 --> idUser
                    //varInt2 --> idTavolina
                    //varInt3 --> idKlienti
                    //varInt4 --> idFormaPagesa
                    //varDouble1 --> totali
                    //varDouble2 --> skonto
                    //varString1 --> nrFatura
                    //varDs1 --> ruan recetat
                    //varDs2 --> ruan ofertat

                    Fatura fatObject = new Fatura();
                    b = fatObject.KrijoFature(varInt1, varInt2, varInt3, varInt4, varDouble1, varDouble2, varString1,  varDs1, varDs2);
                    break;


                default:
                    b = 1;
                    break;
            }
            return b;
        }


       

        public int VeprimeUpdate(string idVeprime, int varInt1, string varString1, string varString2, string varString3, string varString4, string varString5, string varString6, string varString7, string varString8)
        {
            int b;
            switch (idVeprime)
            {
                case "KrijoPersonel":
                    Perdorues perdoruesi = new Perdorues();
                    b = perdoruesi.KrijoPerdorues(varInt1, varString1, varString2, varString3, varString4, varString5, varString6, varString7, varString8);

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
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, int varInt2, string varString1, string varString2, string varString3, string varString4, string varString5, string varString6, string varString7, string varString8)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoPersonel":
                    Perdorues perdoruesi = new Perdorues();
                    b = perdoruesi.ModifikoPersonel(varInt1, varInt2, varString1, varString2, varString3, varString4, varString5, varString6, varString7, varString8);

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

        public int VeprimeUpdate(string idVeprime, string varString1, string varString2)
        {
            int b;
            switch (idVeprime)
            {
                case "KrijoKategoriShpenzimMujor":
                    // varString1 --> emri i kategorise
                    // varString2 --> pershkrimi i kategorise

                    Shpenzime shpenzimiMujorKat = new Shpenzime();
                    b = shpenzimiMujorKat.KrijoKategoriShpenzimMujor(varString1, varString2);
                    break;

                case "KrijoGrupCmimi" :

                    //varString1 --> emri i grupt
                    //varString1 --> pershkrimi i grupit

                    Receta grupCmimi = new Receta();
                    b = grupCmimi.KrijoGrupCmimi(varString1, varString2);
                    break;


                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int VeprimeUpdate(string idVeprime, string varString1, string varString2, DateTime varDate1,
            DateTime varDate2, DateTime varDate3, int[] arrayInt)
        {
            int b;
            switch (idVeprime)
            {
                case "ShtoRezervim":
                    // varString1 --> emer
                    // varString2 --> mbiemer
                    // varDate1 --> data
                    // varDate2 --> ora fillimi
                    // varDate3 --> ora mbarimi
                    Rezervimi rezervimiObject = new Rezervimi();
                    b = rezervimiObject.ShtoRezervim(varString1, varString2, varDate1, varDate2,
                        varDate3, arrayInt);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int VeprimeUpdate(string idVeprime, int varInt1, string varString1, string varString2, DateTime varDate1,
            DateTime varDate2, DateTime varDate3, int[] arrayInt)
        {
            int b;
            switch (idVeprime)
            {
                case "ModifikoRezervim":
                    // varInt1 -->idrezervimi
                    // varString1 --> emer
                    // varString2 --> mbiemer
                    // varDate1 --> data
                    // varDate2 --> ora fillimi
                    // varDate3 --> ora mbarimi
                    Rezervimi rezervimiObject = new Rezervimi();
                    b = rezervimiObject.ModifikoRezervim(varInt1, varString1, varString2, varDate1, varDate2,
                        varDate3, arrayInt);
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
