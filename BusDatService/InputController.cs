using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ResManagerAdmin.BusDatService;
using ResManagerAdmin;

namespace ResManagerAdmin.BusDatService
{
    public class InputController
    {
        #region Constructor
        #endregion

        #region KerkesaRead
        public DataSet KerkesaRead(string idKerkesa)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShfaqGrupCmimet":
                    ds = busObject.VeprimeRead("ShfaqGrupCmimet");
                    break;

                case "KtheKamarieretLoguar":
                    ds = busObject.VeprimeRead("KtheKamarieretLoguar");
                    break;

                case "ShfaqOfertatPerHotelin":
                    ds = busObject.VeprimeRead("ShfaqOfertatPerHotelin");
                    break;

                case "ShfaqOfertatPerBarin":
                    ds = busObject.VeprimeRead("ShfaqOfertatPerBarin");
                    break;

                case "ShfaqShpenzimetMujore":
                    ds = busObject.VeprimeRead("ShfaqShpenzimetMujore");
                    break;

                case "ShfaqKategoriShpenzimeshMujore":
                    ds = busObject.VeprimeRead("ShfaqKategoriShpenzimeshMujore");
                    break;

                case "ShfaqKamarieretPerKombo":
                    ds = busObject.VeprimeRead("ShfaqKamarieretPerKombo");
                    break;

                case "ShfaqTavolinatPerKombo":
                    ds = busObject.VeprimeRead("ShfaqTavolinatPerKombo");
                    break;

                case "ShfaqFaturatPerSot":
                    ds = busObject.VeprimeRead("ShfaqFaturatPerSot");
                    break;

                case "KtheInformacionPerBarin":
                    ds = busObject.VeprimeRead("KtheInformacionPerBarin");
                    break;

                case "KtheNrFaturaLast":
                    ds = busObject.VeprimeRead("KtheNrFaturaLast");
                    break;

                case "ShfaqFavorite":
                    ds = busObject.VeprimeRead("ShfaqFavorite");
                    break;

                case "ShfaqRecetatSipasKategorivePerFavorite":
                    ds = busObject.VeprimeRead("ShfaqRecetatSipasKategorivePerFavorite");
                    break;

                case "ShfaqRecetatSipasKategorive":
                    ds = busObject.VeprimeRead("ShfaqRecetatSipasKategorive");
                    break;

                case "ShfaqArtikujtSipasKategorive" :
                    ds = busObject.VeprimeRead("ShfaqArtikujtSipasKategorive");
                    break;

                case "ShfaqArtikujt":
                    ds = busObject.VeprimeRead("ShfaqArtikujt");
                    break;

                case "ShfaqRolet":
                    ds = busObject.VeprimeRead("ShfaqRolet");
                    break;

                case "ShfaqKategoriteETavolinave":
                    ds = busObject.VeprimeRead("ShfaqKategoriteETavolinave");
                    break;

                case "ShfaqTavolinatDetaje":
                    ds = busObject.VeprimeRead("ShfaqTavolinatDetaje");
                    break;

                case "ShfaqTavolinenMeNumerMeTeMadh":
                    ds = busObject.VeprimeRead("ShfaqTavolinenMeNumerMeTeMadh");
                    break;

                case "ShfaqKategoriteEArtikujve":
                    ds = busObject.VeprimeRead("ShfaqKategoriteEArtikujve");
                    break;

                case "ShfaqKategoriteEArtikujvePerMenu":
                    ds = busObject.VeprimeRead("ShfaqKategoriteEArtikujvePerMenu");
                    break;

                case "ShfaqKategoriteERecetave":
                    ds = busObject.VeprimeRead("ShfaqKategoriteERecetave");
                    break;


                case "ShfaqKategoriteERecetavePerMenu":
                    ds = busObject.VeprimeRead("ShfaqKategoriteERecetavePerMenu");
                    break;

                case "ShfaqKategoriteEShpenzimeve":
                    ds = busObject.VeprimeRead("ShfaqKategoriteEShpenzimeve");
                    break;
                case "ShfaqNjesiteMatese":
                    ds = busObject.VeprimeRead("ShfaqNjesiteMatese");
                    break;

                case "ShfaqFormatEPageses":
                    ds = busObject.VeprimeRead("ShfaqFormatEPageses");
                    break;

                case "ShfaqPerdoruesitJoKamariere":
                    ds = busObject.VeprimeRead("ShfaqPerdoruesitJoKamariere");
                    break;

                case "RezervimetESkaduara":
                    ds = busObject.VeprimeRead("RezervimetESkaduara");
                    break;

                case "ShfaqPerdoruesitKamariere":
                    ds = busObject.VeprimeRead("ShfaqPerdoruesitKamariere");
                    break;

                case "LexoIntervaletCmime":
                    ds = busObject.VeprimeRead("LexoIntervaletCmime");
                    break;

                case "LexoInformacioneRestoranti":
                    ds = busObject.VeprimeRead("LexoInformacioneRestoranti");
                    break;

                case "InformacionetPerRestorantinShkurt":
                    ds = busObject.VeprimeRead("InformacionetPerRestorantinShkurt");
                    break;

                case "LexoBackUp":
                    ds = busObject.VeprimeRead("LexoBackUp");
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, DataSet varDs)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "KtheKufirinPerRecetat":
                    ds = busObject.VeprimeRead("KtheKufirinPerRecetat", varDs);
                    break;

                case "FshiArtikujt":
                    ds = busObject.VeprimeRead("FshiArtikujt", varDs);
                    break;

                case "FshiKategoriteETavolinave":
                    ds = busObject.VeprimeRead("FshiKategoriteETavolinave", varDs);
                    break;

                case "FshiTavolinat":
                    ds = busObject.VeprimeRead("FshiTavolinat", varDs);
                    break;

                case "FshiKategoriteEArtikujve":
                    ds = busObject.VeprimeRead("FshiKategoriteEArtikujve", varDs);
                    break;

                case "FshiKategoriteERecetave":
                    ds = busObject.VeprimeRead("FshiKategoriteERecetave", varDs);
                    break;

                case "FshiKategoriteEShpenzimeve":
                    ds = busObject.VeprimeRead("FshiKategoriteEShpenzimeve", varDs);
                    break;

                case "ShfaqNjesiteMatese":
                    ds = busObject.VeprimeRead("ShfaqNjesiteMatese", varDs);
                    break;

                case "FshiNjesite":
                    ds = busObject.VeprimeRead("FshiNjesite", varDs);
                    break;

                case "FshiFormatEPageses":
                    ds = busObject.VeprimeRead("FshiFormatEPageses", varDs);
                    break;

                case "FshiRezervimeSkaduara":
                    ds = busObject.VeprimeRead("FshiRezervimeSkaduara", varDs);
                    break;

                case "FshiBlerjet":
                    ds = busObject.VeprimeRead("FshiBlerjet", varDs);
                    break;  
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, DataSet varDs, string varString1)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "FshiFurnitoret":
                    ds = busObject.VeprimeRead("FshiFurnitoret", varDs, varString1);
                    break;

                case "FshiKlientet":
                    ds = busObject.VeprimeRead("FshiKlientet", varDs, varString1);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, int varInt1, int varInt2, int varInt3)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ShtoDisaTavolina":
                    //varInt1 --> numri i tavolinave qe do te shtohen
                    //varInt2 --> idKategoria
                    //varInt3 --> kapaciteti
                    ds = busObject.VeprimeRead("ShtoDisaTavolina", varInt1, varInt2, varInt3);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3, int varInt4, double varDouble1, double varDouble2, string varString1, DataSet varDs1, DataSet varDs2)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
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
                    //vardS2 --> ruan ofertat
                    

                    b = busObject.VeprimeUpdate("KrijoFature", varInt1, varInt2, varInt3, varInt4, varDouble1, varDouble2, varString1, varDs1, varDs2);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public DataSet KerkesaRead(string idKerkesa, int varInt1, int varInt2)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShfaqArtikujPerKategoriFurnitor":
                    //varInt1 --> idKategoria
                    //varInt2 --> idFurnitori
                    ds = busObject.VeprimeRead("ShfaqArtikujPerKategoriFurnitor", varInt1, varInt2);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, int varInt1, int varInt2, string varString1)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ShfaqArtikujtSipasZgjedhjes":
                    //varInt1 --> koeficenti i zgjedhjes
                    //varInt2 --> celesi i kategorise
                    //varString1 --> emri i artikullit
                    ds = busObject.VeprimeRead("ShfaqArtikujtSipasZgjedhjes", varInt1, varInt2, varString1);
                    break;

                case "ShfaqPersonelinSipasZgjedhjes":
                    //varInt1 --> koeficenti i zgjedhjes
                    //varInt2 --> roli i personelit
                    //varString1 --> emri i personelit
                    ds = busObject.VeprimeRead("ShfaqPersonelinSipasZgjedhjes", varInt1, varInt2, varString1);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, string varString1)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShfaqShpenzimetMujoreSipasKerkimit":
                    //varString1 --> query qe do te perdoret 
                    ds = busObject.VeprimeRead("ShfaqShpenzimetMujoreSipasKerkimit", varString1);
                    break;

                case "KtheFaturatSipasKerkimit":
                    //varString1 --> query qe do te perdoret 
                    ds = busObject.VeprimeRead("KtheFaturatSipasKerkimit", varString1);
                    break;

                case "ShfaqArtikujtPerBar":
                    //varString1 --> query qe do te perdoret 
                    ds = busObject.VeprimeRead("ShfaqArtikujtPerBar", varString1);
                    break;


                case "ShfaqKlientet":
                    ds = busObject.VeprimeRead("ShfaqKlientet", varString1);
                    break;

                case "ShfaqFurnitoret":
                    ds = busObject.VeprimeRead("ShfaqFurnitoret", varString1);
                    break;

                case "ShfaqShpenzimet":
                    ds = busObject.VeprimeRead("ShfaqShpenzimet", varString1);
                    break;

                case "ShfaqTurnet":
                    ds = busObject.VeprimeRead("ShfaqTurnet", varString1);
                    break;

                case "ShfaqBlerjet":
                    ds = busObject.VeprimeRead("ShfaqBlerjet", varString1);
                    break;

                case "ShfaqArtikujtPerFurnitoret":
                    ds = busObject.VeprimeRead("ShfaqArtikujtPerFurnitoret", varString1);
                    break;

                case "ShfaqRecetat":
                    ds = busObject.VeprimeRead("ShfaqRecetat", varString1);
                    break;

                case "XhirojaPerSecilenDate":
                    ds = busObject.VeprimeRead("XhirojaPerSecilenDate", varString1);
                    break;

                case "ShfaqXhiroSipasFaturavePerDaten":
                    ds = busObject.VeprimeRead("ShfaqXhiroSipasFaturavePerDaten", varString1);
                    break;

                case "XhirojaPerSecilenDateSipasArtikujve":
                    ds = busObject.VeprimeRead("XhirojaPerSecilenDateSipasArtikujve", varString1);
                    break;

                case "XhirojaPerSecilenDateSipasRecetave":
                    ds = busObject.VeprimeRead("XhirojaPerSecilenDateSipasRecetave", varString1);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, string varString1, string varString2)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "GjejPerdorues":
                    //varString1 --> emri i perdoruesit
                    //varString2 -->fjalekalimi
                    ds = busObject.VeprimeRead("GjejPerdorues", varString1, varString2);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, string varString1, int varInt1)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "LexoTeDhenaPerArtikullin":
                    //varString1 --> lloji i artikullit
                    //varInt1 --> celesi i artikullit
                    ds = busObject.VeprimeRead("LexoTeDhenaPerArtikullin", varString1, varInt1);
                    break;

                case "VerifikoFjalekalimin":
                    //varString1 --> fjalekalimi
                    //varInt1 --> celesi i perdoruesit
                    ds = busObject.VeprimeRead("VerifikoFjalekalimin", varString1, varInt1);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, DateTime varDate1)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShfaqFaturatPerDatenZgjedhur":
                    ds = busObject.VeprimeRead("ShfaqFaturatPerDatenZgjedhur", varDate1);
                    break;

                case "ShpenzimetPerDaten":
                    ds = busObject.VeprimeRead("ShpenzimetPerDaten", varDate1);
                    break;

                case "ShfaqRezervimetTavolina":
                    ds = busObject.VeprimeRead("ShfaqRezervimetTavolina", varDate1);
                    break;

                case "ShfaqGjendjeArka":
                    ds = busObject.VeprimeRead("ShfaqGjendjeArka",varDate1);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, int varInt1)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShfaqEkstratPerReceten":
                    //varInt1 --> idFatura
                    ds = busObject.VeprimeRead("ShfaqEkstratPerReceten", varInt1);
                    break;

                case "KtheArtikujtPerFature":
                    //varInt1 --> idFatura
                    ds = busObject.VeprimeRead("KtheArtikujtPerFature", varInt1);
                    break;

                case "ShfaqFaturatKorentePerTavoline":
                    //varInt1 --> idTavolina
                    ds = busObject.VeprimeRead("ShfaqFaturatKorentePerTavoline", varInt1);
                    break;

                case "ShfaqCmimeRecetatPerGrupinZgjedhur":
                    //varInt1 --> idGrupi
                    ds = busObject.VeprimeRead("ShfaqCmimeRecetatPerGrupinZgjedhur", varInt1);
                    break;

                case "ShfaqTeDhenaPerOferten":
                    //varInt1 --> idOferta
                    ds = busObject.VeprimeRead("ShfaqTeDhenaPerOferten", varInt1);
                    break;

                case "ShfaqRecetatPerKategoriOferte":
                    //varInt1 --> idKategoriaRecete
                    ds = busObject.VeprimeRead("ShfaqRecetatPerKategoriOferte", varInt1);
                    break;

                case "PrintoFaturenPC":
                    //varInt1 --> idFatura
                    ds = busObject.VeprimeRead("PrintoFaturenPC", varInt1);
                    break;

                case "ShfaqStatistikaPerVitin":
                    //varInt1 --> viti
                    ds = busObject.VeprimeRead("ShfaqStatistikaPerVitin", varInt1);
                    break;

                case "ShfaqTeDhenaPerFaturen":
                    //varInt1 --> celesi i fatures
                    ds = busObject.VeprimeRead("ShfaqTeDhenaPerFaturen", varInt1);
                    break;

                case "ShfaqTurnetPerLodim":
                    //varInt1 --> celesi i kamarierit
                    ds = busObject.VeprimeRead("ShfaqTurnetPerLodim", varInt1);
                    break;

                case "LexoXhironPerKamarierin":
                    ds = busObject.VeprimeRead("LexoXhironPerKamarierin", varInt1);
                    break;

                case "ShfaqRecetatPerKategoriKonfigurimCmimesh":
                    //varInt1 --> celesi i kategorise se recetave
                    ds = busObject.VeprimeRead("ShfaqRecetatPerKategoriKonfigurimCmimesh", varInt1);
                    break;

                case "ShfaqArtikujtPerKategoriPerKonfigurimCmimesh":
                    //varInt1 --> celesi i kategorise se artikujve
                    ds = busObject.VeprimeRead("ShfaqArtikujtPerKategoriPerKonfigurimCmimesh", varInt1);
                    break;

                case "MbyllTavolinen":
                    //varInt1 --> celesi i tavolines
                    ds = busObject.VeprimeRead("MbyllTavolinen", varInt1);
                    break;

                case "LexoTeDhenaPerArtikullin":
                    //varInt1 --> celesi i artikullit
                    ds = busObject.VeprimeRead("LexoTeDhenaPerArtikullin", varInt1);
                    break;

                case "ShfaqCmimetEfunditPerArtikullin":
                    //varInt1 --> celesi i artikullit
                    ds = busObject.VeprimeRead("ShfaqCmimetEfunditPerArtikullin" , varInt1);
                    break;

                case "ShfaqCmimetPerArtikullin":
                    //varInt1 --> celesi i artikullit
                    ds = busObject.VeprimeRead("ShfaqCmimetPerArtikullin", varInt1);
                    break;
                    
                case "ShfaqArtikujtPerKategori":
                    //varInt1 --> celesi i artikullit
                    ds = busObject.VeprimeRead("ShfaqArtikujPerKategori", varInt1);
                    break;

                case "ShfaqTeDhenaPerArtikullin":
                    //varInt1 --> celesi i artikullit
                    ds = busObject.VeprimeRead("ShfaqTeDhenaPerArtikullin", varInt1);
                    break;

                case "KthePathiFotoPersoneli":
                    //varInt1 --> celesi i personelit
                    ds = busObject.VeprimeRead("KthePathiFotoPersoneli", varInt1);
                    break;

                case "ShfaqTeDhenaPerPersonelinZgjedhur":
                    //varInt1 --> celesi i personelit
                    ds = busObject.VeprimeRead("ShfaqTeDhenaPerPersonelinZgjedhur", varInt1);
                    break;

                case "ShfaqTeDhenaRezervimi":
                    ds = busObject.VeprimeRead("ShfaqTeDhenaRezervimi", varInt1);
                    break;

                case "ShfaqArtikujPerKategori":
                    ds = busObject.VeprimeRead("ShfaqArtikujPerKategori", varInt1);
                    break;

                case "ShfaqArtikujtMeTeNjejtenKategori":
                    ds = busObject.VeprimeRead("ShfaqArtikujtMeTeNjejtenKategori", varInt1);
                    break;

                case "ShfaqArtikujCmimePerKategori":
                    ds = busObject.VeprimeRead("ShfaqArtikujCmimePerKategori", varInt1);
                    break;

                case "ShfaqRecetatPerKategori":
                    ds = busObject.VeprimeRead("ShfaqRecetatPerKategori", varInt1);
                    break;

                case "LexoCmimetPerReceten":
                    ds = busObject.VeprimeRead("LexoCmimetPerReceten", varInt1);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, DateTime varDate1, DateTime varDate2)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ShfaqBilancinPerPeriudhen":
                    ds = busObject.VeprimeRead("ShfaqBilancinPerPeriudhen", varDate1, varDate2);
                    break;

                case "ShfaqniFitiminPerPeriudhen":
                    ds = busObject.VeprimeRead("ShfaqniFitiminPerPeriudhen", varDate1, varDate2);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, int varInt1, DateTime varDate1, DateTime varDate2)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ShfaqTavolinatEliraPerKategori":
                    ds = busObject.VeprimeRead("ShfaqTavolinatEliraPerKategori", varInt1, varDate1, varDate2);
                    break;

                case "ShfaqTurnetPerKamarierPerPeriudhen":
                    ds = busObject.VeprimeRead("ShfaqTurnetPerKamarierPerPeriudhen", varInt1, varDate1, varDate2);
                    break;

                case "LexoTurninPerKamarierin":
                    ds = busObject.VeprimeRead("LexoTurninPerKamarierin", varInt1, varDate1, varDate2);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        public DataSet KerkesaRead(string idKerkesa, int varInt1, bool varBool1, int varInt2, DateTime varDate1)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShfaqTurnetSipasKerkimit":

                    //varInt1 --> zgjedhja
                    //varBool1 --> turn i hapur apo mbyllur
                    //varInt2 --> idKamarieri
                    //varDate1 --> data e kerkimit

                    ds = busObject.VeprimeRead("ShfaqTurnetSipasKerkimit", varInt1, varBool1, varInt2, varDate1);
                    break;

               

                default:
                    ds = null;
                    break;
            }
            return ds;
        }


        public DataSet KerkesaRead(string idKerkesa, int varInt1, int varInt2, DateTime varDate1, DateTime varDate2)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShfaqTavolinatEliraPerKategori":
                    //varInt1 --> idKategoria
                    //varInt2 --> idRezervimi
                    //kerkesa pritet te ktheje pervec dhomave te lira
                    //edhe dhomat e rezervuara ne kete rezervim
                    ds = busObject.VeprimeRead("ShfaqTavolinatEliraPerKategori",
                        varInt1, varInt2, varDate1, varDate2);
                    break;

                case "XhirojaPerSecilenDateSipasRecetave":
                    //varInt1 --> idKatReceta
                    //varInt2 --> idReceta
                    //varDate1 --> dateFillimi
                    //varDate2 --> dateMbarimi
                    ds = busObject.VeprimeRead("XhirojaPerSecilenDateSipasRecetave", varInt1, varInt2, varDate1, varDate2);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }


        public DataSet KerkesaRead(string idKerkesa, int[] varArrayInt1)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "LexoTeDhenaPerTavolinen" :
                    ds = busObject.VeprimeRead("LexoTeDhenaPerTavolinen", varArrayInt1);
                    break;

                case "LexoOfertatPerTavolinen" :
                    ds = busObject.VeprimeRead("LexoOfertatPerTavolinen", varArrayInt1);
                    break;

                default:
                    ds = null;
                    break;
            }
            return ds;
        }


        public DataSet KerkesaRead(string idKerkesa, int varInt1, DataSet varDs)
        {
            DataSet ds;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ModifikoBlerje":
                    ds = busObject.VeprimeRead("ModifikoBlerje", varInt1, varDs);
                    break;

                case "RuajPerkatesiArtikuj":
                    ds = busObject.VeprimeRead("RuajPerkatesiArtikuj", varInt1, varDs);
                    break;
                default:
                    ds = null;
                    break;
            }
            return ds;
        }

        #endregion

        #region KerkesaUpdate

        public int KerkesaUpdate(string idKerkesa)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ModifikoKostoVilaX":
                    b = busObject.VeprimeUpdate("ModifikoKostoVilaX");
                    break;


                case "FshiHistorikTurnet":
                    b = busObject.VeprimeUpdate("FshiHistorikTurnet");
                    break;

                case "KrijoBackUp":
                    b = busObject.VeprimeUpdate("KrijoBackUp");
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, string varString1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ShtoKategoriTavolinash":
                    b = busObject.VeprimeUpdate("ShtoKategoriTavolinash", varString1);
                    break;

                case "ShtoKategoriRecete":
                    b = busObject.VeprimeUpdate("ShtoKategoriRecete", varString1);
                    break;

                case "ShtoKategoriShpenzimi":
                    b = busObject.VeprimeUpdate("ShtoKategoriShpenzimi", varString1);
                    break;

                case "ShtoNjesi":
                    b = busObject.VeprimeUpdate("ShtoNjesi", varString1);
                    break;

                case "KarikoBackUp":
                    b = busObject.VeprimeUpdate("KarikoBackUp", varString1);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        

        public int KerkesaUpdate(string idKerkesa, int varInt1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "FshiGrupCmimi":
                    b = busObject.VeprimeUpdate("FshiGrupCmimi", varInt1);
                    // varInt1 --> idGrupCmimi
                    break;

                case "AnulloFaturen" :
                    b = busObject.VeprimeUpdate("AnulloFaturen", varInt1);
                    // varInt1 --> celesi i fatures
                    break;

                case "MbyllTurnin":
                    b = busObject.VeprimeUpdate("MbyllTurnin", varInt1);
                    // varInt1 --> celesi i kamarierit
                    break;

                case "FshiPerdorues":
                    b = busObject.VeprimeUpdate("FshiPerdorues", varInt1);
                    // varInt1 --> celesi i tavolines
                    break;

                case "MbyllTavolinen" :
                    b = busObject.VeprimeUpdate("MbyllTavolinen", varInt1);
                    // varInt1 --> celesi i tavolines
                    break;

                case "HapTavoline":
                    b = busObject.VeprimeUpdate("HapTavoline", varInt1);
                    // varInt1 --> celesi i personelit
                    break;

                case "FshiPersonel":
                    b = busObject.VeprimeUpdate("FshiPersonel", varInt1);
                    // varInt1 --> celesi i personelit
                    break;

                case "FshiRezervim":
                    b = busObject.VeprimeUpdate("FshiRezervim", varInt1);
                    break;


                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "Login":
                    b = busObject.VeprimeUpdate("Login", varInt1, varInt2);
                    break;


                case "Logout":
                    b = busObject.VeprimeUpdate("Logout", varInt1, varInt2);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, string varString1, decimal varDec1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShtoFormePagese":
                    //varString1 --> emri i formes se pageses
                    //varDec1 --> komisioni i formes se pageses
                    b = busObject.VeprimeUpdate("ShtoFormePagese", varString1, varDec1);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShtoKategoriArtikulli":
                    //varInt1 --> {0, 1} per statusin e kategorise
                    //varString1 --> emri i kategorise
                    b = busObject.VeprimeUpdate("ShtoKategoriArtikulli", varInt1, varString1);
                    break;

                case "ModifikoKategoriTavoline":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    b = busObject.VeprimeUpdate("ModifikoKategoriTavoline", varInt1, varString1);
                    break;

                

                case "ModifikoKategoriRecete":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    b = busObject.VeprimeUpdate("ModifikoKategoriRecete", varInt1, varString1);
                    break;
                case "ModifikoKategoriShpenzimi":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i ri i kategorise
                    b = busObject.VeprimeUpdate("ModifikoKategoriShpenzimi", varInt1, varString1);
                    break;
                case "ModifikoNjesi":
                    //varInt1 --> idNjesia
                    //varString1 --> emri i ri i njesise
                    b = busObject.VeprimeUpdate("ModifikoNjesi", varInt1, varString1);
                    break;

                case "ModifikoFjalekalim":
                    //varInt1 --> idPersoneli
                    //varString1 --> fjalekalimi i ri
                    b = busObject.VeprimeUpdate("ModifikoFjalekalim", varInt1, varString1);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1, decimal varDec1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ModifikoFormePagese":
                    //varInt1 --> idFormaPagesa
                    //varString1 --> emri i ri i formes se pageses
                    //varDec -->komisioni i formes se pageses
                    b = busObject.VeprimeUpdate("ModifikoFormePagese", varInt1, varString1, varDec1);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, string varString1, int varInt2, int varInt3)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ShtoTavoline":
                    //varString1 --> emri
                    //varInt2 --> idKategoria
                    //varInt3 --> kapaciteti
                    b = busObject.VeprimeUpdate("ShtoTavoline", varString1, varInt2, varInt3);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, string varString1, string varString2)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "KrijoKategoriShpenzimMujor":
                    //varString1 --> emri i kategorise
                    //varString1 --> pershkrimi i kategorise
                    b = busObject.VeprimeUpdate("KrijoKategoriShpenzimMujor", varString1, varString2);
                    break;

                case "KrijoGrupCmimi":
                    //varString1 --> emri i grupt
                    //varString1 --> pershkrimi i grupit
                    b = busObject.VeprimeUpdate("KrijoGrupCmimi", varString1, varString2);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, string varString1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ModifikoKategoriArtikulli":
                    //varInt1 --> idKategoria
                    //varInt2 --> {0, 1} percakton shfaqjen ne menu te artikullit
                    //varString1 --> emri i ri i kategorise
                    b = busObject.VeprimeUpdate("ModifikoKategoriArtikulli", varInt1, varInt2, varString1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1, string varString2)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ModifikoKategoriShpenzimiMujor":
                    //varInt1 --> idKategoria
                    //varString1 --> emri i kategorise
                    //varString2 --> pershkrimi i kategorise
                    b = busObject.VeprimeUpdate("ModifikoKategoriShpenzimiMujor", varInt1, varString1, varString2);
                    break;

                case "ModifikoGrupCmimi":
                    //varInt1 --> idGrupi
                    //varString1 --> emri i grupit
                    //varString2 --> pershkrimi i grupit
                    b = busObject.VeprimeUpdate("ModifikoGrupCmimi", varInt1, varString1, varString2);
                    break;


                default:
                    b = 1;
                    break;
            }
            return b;
        }




        public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int[] varArrayInt1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "TransferoTavolinen":
                    //varInt1 --> idTavolinaOld
                    //varInt2 --> idTavolinaNew
                    //varArrayInt1 --> vektori i idFaturave qe tranferohen
                    b = busObject.VeprimeUpdate("TransferoTavolinen", varInt1, varInt2, varArrayInt1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1, int varInt3, int varInt4)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ModifikoTavoline":
                    //varInt1 --> idTavolina
                    //varString1 --> emri
                    //varInt3 --> idKategoria
                    //varInt4 --> kapaciteti
                    b = busObject.VeprimeUpdate("ModifikoTavoline", varInt1, varString1, varInt3, varInt4);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3, double varDouble1, string varString1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "KrijoShpenzimMujor":
                    //varInt1 --> idKategoria
                    //varInt2 --> muaji
                    //varInt3 --> viti
                    //varDouble1 --> vlera
                    //varString1 --> komenti mbi shpenzimin
                    b = busObject.VeprimeUpdate("KrijoShpenzimMujor", varInt1, varInt2, varInt3, varDouble1, varString1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, double varDouble1, string varString1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ModifikoShpenzimMujor":
                    //varInt1 --> idShpenzimiMujor
                    //varDouble1 --> vlera
                    //varString1 --> komenti mbi shpenzimin
                    b = busObject.VeprimeUpdate("ModifikoShpenzimMujor", varInt1, varDouble1, varString1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1, string varString2, int varInt2, decimal varDecimal1,  DataSet varDs1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ModifikoOferte":

                    //varInt1 --> idOferta
                    // varString1 --> emri i ofertes
                    // varString2 --> tipi i ofertes
                    // varInt2 --> numri i shportave
                    // varDecimal1 --> cmimi
                    // varDs1 --> recetat

                    b = busObject.VeprimeUpdate("ModifikoOferte", varInt1, varString1, varString2, varInt2, varDecimal1, varDs1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int KerkesaUpdate(string idKerkesa, int varInt1, double varDouble1, double varDouble2, DataSet varDs1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ModifikoFature":
                    //varInt1 --> idFatura
                    //varDouble1 --> totali
                    //varDouble2 --> skonto
                    //varDs1 --> dataset i recetave
                    b = busObject.VeprimeUpdate("ModifikoFature", varInt1, varDouble1, varDouble2, varDs1);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, string varString1, string varString2, string varString3, string varString4, string varString5)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {

                case "ShtoKlient":
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> kodi
                    //varString4 --> telefoni
                    //varString5 --> adresa
                    b = busObject.VeprimeUpdate("ShtoKlient", varString1, varString2, varString3, varString4, varString5);
                    break;

                case "ShtoFurnitor":
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> adresa
                    //varString4 --> emaili
                    //varString5 --> telefoni
                    b = busObject.VeprimeUpdate("ShtoFurnitor", varString1, varString2, varString3, varString4, varString5);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

     

        public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1, string varString2, string varString3,
            string varString4, string varString5)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ModifikoFurnitor":
                    //varInt1 --> idFurnitori
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> adresa
                    //varString4 --> emaili
                    //varString5 --> telefoni
                    b = busObject.VeprimeUpdate("ModifikoFurnitor", varInt1, varString1, varString2, varString3, varString4, varString5);
                    break;

                case "ModifikoKlient":

                    //varInt1 --> idKlienti
                    //varString1 --> emri
                    //varString2 --> mbiemri
                    //varString3 --> kodi i klientit
                    //varString4 --> telefoni
                    //varString5 --> adresa

                    b = busObject.VeprimeUpdate("ModifikoKlient", varInt1, varString1, varString2, varString3, varString4, varString5);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, string varString1, DateTime varDate1,
            decimal varDec1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "KryejShpenzim":
                    //varInt1 --> idKategoria
                    //varInt2 --> idPersoneli
                    //varString1 --> pershkrimi
                    //varDate1 --> data
                    //varDec --> sasia
                    b = busObject.VeprimeUpdate("KryejShpenzim", varInt1, varInt2, varString1, varDate1, varDec1);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3, string varString1,
            DateTime varDate1, decimal varDec1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ModifikoShpenzim":
                    //varInt1 --> idShpenzimi
                    //varInt2 --> idKategoria
                    //varInt3 --> idPersoneli
                    //varString1 --> pershkrimi
                    //varDate1 --> data
                    //varDec --> sasia
                    b = busObject.VeprimeUpdate("ModifikoShpenzim", varInt1, varInt2, varInt3, varString1,
                        varDate1, varDec1);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3, string varString1, string varString2,
          double varDouble1, double varDouble2)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "KrijoArtikull":
                    //varInt1 --> idKategoria
                    //varInt2 --> idNjesia
                    //varInt3 --> lloji i konsumit
                    //varString1 --> kodi i artikullit
                    //varString2 --> pathi i fotos
                    //varDouble1 --> cmimi
                    //varDouble2 --> sasiaSkorte

                    b = busObject.VeprimeUpdate("KrijoArtikull", varInt1, varInt2, varInt3, varString1, varString2, varDouble1, varDouble2);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3, int varInt4, string varString1, string varString2, double varDouble1, double varDouble2)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
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

                    b = busObject.VeprimeUpdate("ModifikoArtikull", varInt1, varInt2, varInt3, varInt4, varString1, varString2, varDouble1, varDouble2);
                    break;

                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int KerkesaUpdate(string idKerkesa, DataSet varDs)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ModifikoGrupCmiminZgjedhur":
                    //varDs --> idGrupCmimet
                    b = busObject.VeprimeUpdate("ModifikoGrupCmiminZgjedhur", varDs);
                    break;

                case "MbyllGjitheTurnet":
                    //varDs --> idKamarieret
                    b = busObject.VeprimeUpdate("MbyllGjitheTurnet", varDs);
                    break;

                case "HidhFavorite":
                    b = busObject.VeprimeUpdate("HidhFavorite", varDs);
                    break;

                case "AktivizoArtikujt":
                    b = busObject.VeprimeUpdate("AktivizoArtikujt", varDs);
                    break;

                case "CaktivizoArtikujt":
                    b = busObject.VeprimeUpdate("CaktivizoArtikujt", varDs);
                    break;

                case "FshiShpenzimet":
                    b = busObject.VeprimeUpdate("FshiShpenzimet", varDs);
                    break;

                case "Logout":
                    b = busObject.VeprimeUpdate("Logout", varDs);
                    break;
                case "ShtoBlerje":
                    b = busObject.VeprimeUpdate("ShtoBlerje", varDs);
                    break;

                case "FshiPerkatesiArtikuj":
                    b = busObject.VeprimeUpdate("FshiPerkatesiArtikuj", varDs);
                    break;

                case "ShtoRecete":
                    b = busObject.VeprimeUpdate("ShtoRecete", varDs);
                    break;

                case "FshiRecetat":
                    b = busObject.VeprimeUpdate("FshiRecetat", varDs);
                    break;
                
                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int KerkesaUpdate(string idKerkesa, DataSet varDs1, DataSet varDs2)
        {
            int b;
            
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShtoRecete":
                    b = busObject.VeprimeUpdate("ShtoRecete", varDs1, varDs2);
                    break;

                //case "RuajIntervalet":
                //    ds = busObject.VeprimeUpdate("RuajIntervalet", varDs1, varDs2);
                //    break;

               default:
                    b = 1;
                    break;
            }
            return b;
        }



        public int KerkesaUpdate(string idKerkesa, int varInt1, DataSet varDs)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ModifikoCmimeRecetatPerGrup":
                    //varInt1 --> celesi i grupcmimit
                    //varDs --> ketu ruhen te dhenat per recetat
                    b = busObject.VeprimeUpdate("ModifikoCmimeRecetatPerGrup", varInt1, varDs);
                    break;

                case "KrijoFature":
                    //varInt1 --> celesi i kamarierit
                    //varDs --> ketur ruhen te dhenat e fatures
                    b = busObject.VeprimeUpdate("KrijoFature", varInt1, varDs);
                    break;

                case "KrijoCmimePerArtikull" :
                    b = busObject.VeprimeUpdate("KrijoCmimePerArtikull", varInt1, varDs);
                    break;

                case "ModifikoRecete":
                    b = busObject.VeprimeUpdate("ModifikoRecete", varInt1, varDs);
                    break;

                case "NdryshoDisponibilitet":
                    b = busObject.VeprimeUpdate("NdryshoDisponibilitet", varInt1, varDs);
                    break;

                case "KrijoCmimePerRecete":
                    b = busObject.VeprimeUpdate("KrijoCmimePerRecete", varInt1, varDs);
                    break;
                
                default:
                    b = 1;
                    break;
            }
            return b;
        }


        public int KerkesaUpdate(string idKerkesa, int varInt1, DataSet varDs1, DataSet varDs2)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ModifikoRecete":
                    b = busObject.VeprimeUpdate("ModifikoRecete", varInt1, varDs1, varDs2);
                    break;

               

                default:
                    b = 1;
                    break;
            }
            return b;
        }

        //public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, int varInt3, int varInt4, double varDouble1, double varDouble2, DataSet varDs1)
        //{
        //    int b;
        //    BusinessDelegate busObject = new BusinessDelegate();
        //    switch (idKerkesa)
        //    {
        //        case "KrijoFature":
        //            //varInt1 --> celesi i kamarierit
        //            //varInt2 --> idTavolina
        //            //varInt3 --> idKlienti
        //            //varInt4 --> idFormaPagesa
        //            //varDouble1 --> totali
        //            //varDouble2 --> skonto
        //            //varDs --> ketur ruhen te dhenat e fatures
        //            b = busObject.VeprimeUpdate("KrijoFature", varInt1, varInt2, varInt3, varInt4, varDouble1, varDouble2, varDs1);
        //            break;

        //        default:
        //            b = 1;
        //            break;
        //    }
        //    return b;
        //}

        

     
        public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1, string varString2, string varString3, string varString4, string varString5, string varString6, string varString7, string varString8)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "KrijoPersonel":
                    b = busObject.VeprimeUpdate("KrijoPersonel", varInt1, varString1, varString2, varString3, varString4, varString5, varString6, varString7, varString8);

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

        public int KerkesaUpdate(string idKerkesa, int varInt1, int varInt2, string varString1, string varString2, string varString3, string varString4, string varString5, string varString6, string varString7, string varString8)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ModifikoPersonel":
                    b = busObject.VeprimeUpdate("ModifikoPersonel", varInt1, varInt2, varString1, varString2, varString3, varString4, varString5, varString6, varString7, varString8);

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

        public int KerkesaUpdate(string idKerkesa, string varString1, string varString2, int varInt1, decimal varDecimal1, DataSet varDs1)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "KrijoOferte":
                    b = busObject.VeprimeUpdate("KrijoOferte",  varString1, varString2, varInt1, varDecimal1, varDs1);

                    // varString1 --> emri i ofertes
                    // varString2 --> tipi i ofertes
                    // varInt1 --> numri i shportave
                    // varDecimal1 --> cmimi
                    // varDs1 --> recetat

                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, string varString1, string varString2, DateTime varDate1,
            DateTime varDate2, DateTime varDate3, int[] arrayInt)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ShtoRezervim":
                    // varString1 --> emer
                    // varString2 --> mbiemer
                    // varDate1 --> data
                    // varDate2 --> ora fillimi
                    // varDate3 --> ora mbarimi
                    b = busObject.VeprimeUpdate("ShtoRezervim", varString1, varString2, varDate1, varDate2,
                        varDate3, arrayInt);
                    break;
                default:
                    b = 1;
                    break;
            }
            return b;
        }

        public int KerkesaUpdate(string idKerkesa, int varInt1, string varString1, string varString2, DateTime varDate1,
            DateTime varDate2, DateTime varDate3, int[] arrayInt)
        {
            int b;
            BusinessDelegate busObject = new BusinessDelegate();
            switch (idKerkesa)
            {
                case "ModifikoRezervim":
                    // varInt1 -->idrezervimi
                    // varString1 --> emer
                    // varString2 --> mbiemer
                    // varDate1 --> data
                    // varDate2 --> ora fillimi
                    // varDate3 --> ora mbarimi
                    b = busObject.VeprimeUpdate("ModifikoRezervim", varInt1, varString1, varString2, varDate1, varDate2,
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

