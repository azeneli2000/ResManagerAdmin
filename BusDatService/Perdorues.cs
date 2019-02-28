using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace ResManagerAdmin.BusDatService
{
    public class Perdorues
    {
        #region Constructor
        #endregion

        #region Public Methods
        /// <summary>
        /// Kthen te dhenat per perdoruesin per emrin dhe fjalekalimin e dhene
        /// </summary>
        /// <param name="emri"></param>
        /// <param name="fjalekalimi"></param>
        /// <returns></returns>
        public DataSet GjejPerdorues(string emri, string fjalekalimi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("GjejPerdorues", emri, fjalekalimi);
            return ds;
        }

        /// <summary>
        /// Kthen nje dataset me te dhenat per perdoruesit jo kamariere
        /// </summary>
        /// <returns></returns>
        public DataSet ShfaqPerdoruesJoKamarier()
        {
            DbController db = new DbController();
            DataSet ds = db.Read("ShfaqPerdoruesitJoKamariere");
            return ds;
        }

        public int KrijoPerdorues(int roli, string emri, string mbiemri, string emaili, 
            string telefoni, string adresa, string perdoruesi, string fjalekalimi, string foto)
        {
            int b = 0;
            DataSet ds = null;
            DbController db = new DbController();

            ds = db.Read("KontrolloKodiPerKrijoPersonel", perdoruesi);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return 2;
            }

            ds = db.Read("KontrolloKodiPerKrijoPersonelFjalekalimi", fjalekalimi);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return 3;
            }

            Image fotoPersoneli = null;


            //try
            //{
            //    fotoPersoneli = Image.FromFile(foto);
            //}
            //catch (Exception ex)
            //{
            //    fotoPersoneli = null;
            //}

            
            //ds = db.Read("KrijoPerdorues", roli, emri, mbiemri, emaili, telefoni, adresa, perdoruesi, fjalekalimi, foto);
            ds = db.Read("KrijoPerdorues", roli, emri, mbiemri, emaili, telefoni, adresa, perdoruesi, fjalekalimi, foto, fotoPersoneli);
            if (ds == null)
            {
                return 1;
            }

            //int celesi = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            //if (foto != "")
            //{
            //    int gjatesia = foto.Length;

            //    string prapashtesa = foto.Substring(gjatesia - 4, 4);
            //    string skedari = Convert.ToString(celesi).Trim();


            //    string pathiFoto = Application.StartupPath + "\\Foto\\Personeli\\" + skedari + prapashtesa;

            //    File.Copy(foto, pathiFoto, true);

            //    b = db.Update("ModifikoPathiFotoPersoneli", celesi, pathiFoto);
            //}


            return b;
        }

        public DataSet ShfaqPersonelinSipasZgjedhjes(int zgjedhja, int roli, string emri)
        {
            DataSet ds = null;
            DbController db = new DbController();
            ds = db.Read("ShfaqPersonelinSipasZgjedhjes", zgjedhja, roli, emri);

            return ds;
        }

        public DataSet ShfaqTeDhenaPerPersonelinZgjedhur(int idPersoneli)
        {
            DataSet ds = null;
            DbController db = new DbController();
            ds = db.Read("ShfaqTeDhenaPerPersonelinZgjedhur", idPersoneli);

            return ds;
        }

        public DataSet ShfaqRolet()
        {
            DataSet ds = null;
            DbController db = new DbController();
            ds = db.Read("ShfaqRolet");

            return ds;
        }

        public int ModifikoPersonel(int idPersoneli, int roli, string emri, string mbiemri, string emaili, string telefoni, string adresa, string perdoruesi, string fjalekalimi, string foto)
        {
            int b = 0;
            DataSet ds = null;
            DbController db = new DbController();

            ds = db.Read("KontrolloKodiPerModifikoPersonel", idPersoneli, perdoruesi);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return 2;
            }

            ds = db.Read("KontrolloKodiPerModifikoPersonelFjalekalimi", idPersoneli, fjalekalimi);

            if (ds.Tables[0].Rows.Count > 0)
            {
                return 3;
            }

            b = db.Update("ModifikoPersonel", idPersoneli, roli, emri, mbiemri, emaili, telefoni, adresa, perdoruesi, fjalekalimi, foto);

            if (ds == null)
            {
                return 1;
            }

            int celesi = idPersoneli;
            string pathiFoto = "";
            if (foto != "")
            {
                int gjatesia = foto.Length;

                string prapashtesa = foto.Substring(gjatesia - 4, 4);
                string skedari = Convert.ToString(celesi).Trim();



                pathiFoto = Application.StartupPath + "\\Foto\\Personeli\\" + skedari + prapashtesa;
               // File.Copy(foto, pathiFoto, true);


            }
            else
            {
                pathiFoto = "";
               // b = db.Update("ModifikoPathiFotoPersoneli", celesi, pathiFoto);

            }


            return b;

        }

        /// <summary>
        /// ben aktiv perdoruesin e loguar
        /// </summary>
        /// <param name="idPerdoruesi"></param>
        /// <returns></returns>
        public int Login(int idPerdoruesi, int modifikoTurne)
        {
            DbController db = new DbController();
            int b = db.Update("Login", idPerdoruesi);

            DataSet dsRoli = db.Read("KtheIdRoli", idPerdoruesi);

            int idRoli = Convert.ToInt32(dsRoli.Tables[0].Rows[0][0]);

            if (idRoli == 2)
            {

                DataSet ds = db.Read("KtheTurninLast", idPerdoruesi);
                if (ds == null)
                {
                    MessageBox.Show("Ju keni hasur nje problem ne aksesimin e bazes se te dhenave !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }

                if (ds.Tables[0].Rows.Count == 0)
                {
                    b = db.Create("MerrTurnKamarieri", idPerdoruesi);
                    return 0;
                }

                bool mbyllur = Convert.ToBoolean(ds.Tables[0].Rows[0]["MBYLLUR"]);

                if (mbyllur == false)
                {
                    DialogResult result = MessageBox.Show("Ju nuk e keni mbyllur turnin . Doni te hapni turn te ri ? ", "Vemendje !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        b = db.Update("MbyllTurnin", idPerdoruesi);
                        b = db.Create("MerrTurnKamarieri", idPerdoruesi);
                    }

                }
            }


            return b;
        }

        /// <summary>
        /// caktivizon perdoruesin gjate daljes
        /// ose gjate mbylljes se turnit ne varesi te llojit te perdoruesit
        /// </summary>
        /// <param name="idPerdoruesi"></param>
        /// <returns></returns>
        public int Logout(int idPerdoruesi, int modifikoTurne)
        {
            DbController db = new DbController();
            int b = db.Update("Logout", idPerdoruesi);
            if (modifikoTurne == 1)
                b += db.Update("MbyllTurnKamarieri", idPerdoruesi);
            return b;
        }

        /// <summary>
        /// caktivizon te gjithe kamarieret e loguar ne 
        /// kete workstation
        /// </summary>
        /// <param name="dsKamarieret"></param>
        /// <returns></returns>
        public int Logout(DataSet dsKamarieret)
        {
            DbController db = new DbController();
            int b = db.Update("Logout", dsKamarieret);
            b += db.Update("MbyllTurnKamarieri", dsKamarieret);
            return b;
        }

        public int FshiPersonel(int idPersoneli)
        {
            int b = 0;
            DataSet ds = null;
            DbController db = new DbController();

            ds = db.Read("ShfaqTeDhenaPerPersonelinZgjedhur", idPersoneli);

            int roli = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_ROLI"]);
            bool aktiv = Convert.ToBoolean(ds.Tables[0].Rows[0]["AKTIV"]);
            string perdoruesi = Convert.ToString(ds.Tables[0].Rows[0]["PERDORUESI"]);
            string pathiFoto = Convert.ToString(ds.Tables[0].Rows[0]["FOTO"]);


            if (aktiv == true)
            {
               
                MessageBox.Show("Ju nuk mund te fshini nje perdorues kur ai eshte i loguar!", "Personeli!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 10;
            }

            if (roli == 1)
            {
                ds = db.Read("KtheNumerAdministratoresh");
                int nrAdmin = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                if (nrAdmin == 1)
                {
                    MessageBox.Show("Ju nuk mund të fshini administratorin kur ai është i vetëm!", "Personeli!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 10;
                }
            }

            if (roli == 2)
            {
                b = db.Update("FshiReferenceKamarieri", idPersoneli);
            }

            b = db.Delete("FshiPersonel", idPersoneli);
           

            switch (roli)
            {
                case 1 :
                    MessageBox.Show("Administratori me kodin '" + perdoruesi + "' u fshi!", "Personeli!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case 2:
                    MessageBox.Show("Kamarieri me kodin '" + perdoruesi + "' u fshi!", "Personeli!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case 3:
                    MessageBox.Show("Supervizori me kodin '" + perdoruesi + "' u fshi!", "Personeli!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                default :
                    break;
            }

            return b;
        }

        public int MbyllGjitheTurnet(DataSet dsKam)
        {
            DbController db = new DbController();
            int b = 0;

            b = db.Update("MbyllGjitheTurnet", dsKam);

            return b;
        }

        public DataSet KthePathiFotoPersoneli(int idPersoneli)
        {
            DataSet ds = null;
            DbController db = new DbController();

            ds = db.Read("KtheFotoPersoneli", idPersoneli);

            return ds;


        }

        public DataSet LexoXhironPerKamarierin(int idKamarieri)
        {
            
            DbController db = new DbController();

            DataSet ds = db.Read("KtheTurninKorent", idKamarieri);

            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            DateTime fillimi = Convert.ToDateTime(ds.Tables[0].Rows[0]["FILLIMI"]);

            ds = db.Read("LexoXhironPerKamarierin", idKamarieri, fillimi);

            return ds;
        }

        public int FshiPerdorues(int idPerdoruesi)
        {
            DbController db = new DbController();
            int b = db.Delete("FshiPerdorues", idPerdoruesi);

            return b;
        }

        public int MbyllTurnin(int idKamarieri)
        {
            DbController db = new DbController();
            int b = db.Update("MbyllTurnin", idKamarieri);

            return b;
        }

        public DataSet VerifikoFjalekalimin(string fjalekalimi, int idPerdoruesi)
        {
            DbController db = new DbController();
            DataSet ds = db.Read("VerifikoFjalekalimin", idPerdoruesi, fjalekalimi);

            return ds;
        }

        #endregion

        #region Private Methods
        #endregion
    }
}
