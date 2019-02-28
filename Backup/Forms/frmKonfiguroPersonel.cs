using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmKonfiguroPersonel : Form
    {
        private string PicturePath;
        private int idRoli;
        public string fotoSkedari;
        public int veprimi;
        public int idPersoneli;
        public bool fshire;
        public int modifikoVeprimi;
         
        #region Form Load
        public frmKonfiguroPersonel()
        {
            InitializeComponent();
        }

        private void frmKonfiguroPersonel_Load(object sender, EventArgs e)
        {
            this.PicturePath = "";
            this.fshire = false;
            this.KonfiguroFormen();
        }
        #endregion

        #region Private Methods
        private void PastroFormen()
        {
            this.txtEmri.Text = "";
            this.txtMbiemri.Text = "";
            this.txtEmaili.Text = "";
            this.txtTelefoni.Text = "";
            this.txtAdresa.Text = "";
            this.txtPerdoruesi.Text = "";
            this.txtFjalekalimi.Text = "";
            this.txtPerseritFjalekalimi.Text = "";

            this.optAdministratori.Checked = false;
            this.optKamarieri.Checked = false;
            this.optSupervizori.Checked = false;

            this.pcbFoto.Image = null;
        }

        private string ZgjidhLogo(System.Windows.Forms.OpenFileDialog c, string s)
        {
            c.FileName = "";
            string result = "";
            c.CheckFileExists = true;
            try
            {
                c.Filter = s;
                c.ShowDialog();
                result = c.FileName;
                return result;
            }
            catch
            {
                return "";
            }
        }

        private void KonfiguroFormen()
        {
            if (veprimi == 1)
            {
                this.Text = "Konfiguro personel";
                this.btnFshi.Visible = false;
            }
            else
            {
                this.Text = "Modifiko personel";
                this.btnFshi.Visible = true;
                this.HidhTeDhenaNeForme(idPersoneli);
            }
        }

        private void HidhTeDhenaNeForme(int celesi)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTeDhenaPerPersonelinZgjedhur", celesi);

            if (ds == null)
            {
                // Mesazh gabimi
                return;
            }

            this.txtEmri.Text = Convert.ToString(ds.Tables[0].Rows[0]["EMRI"]);
            this.txtMbiemri.Text = Convert.ToString(ds.Tables[0].Rows[0]["MBIEMRI"]);
            this.txtEmaili.Text = Convert.ToString(ds.Tables[0].Rows[0]["EMAILI"]);
            this.txtAdresa.Text = Convert.ToString(ds.Tables[0].Rows[0]["ADRESA"]);
            this.txtTelefoni.Text = Convert.ToString(ds.Tables[0].Rows[0]["TELEFONI"]);

            //this.PicturePath = Convert.ToString(ds.Tables[0].Rows[0]["FOTO"]);

            //if (this.PicturePath != "")
            //{
            //    this.pcbFoto.Image = Image.FromFile(this.PicturePath);
            //}

            int roli = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_ROLI"]);
            this.idRoli = roli;
            switch (roli)
            {
                case 1:
                    this.optAdministratori.Checked = true;
                    break;

                case 2:
                    this.optKamarieri.Checked = true;
                    break;

                case 3:
                    this.optSupervizori.Checked = true;
                    break;

                default:
                    break;
            }

            this.txtPerdoruesi.Text = Convert.ToString(ds.Tables[0].Rows[0]["PERDORUESI"]);
            this.txtFjalekalimi.Text = Convert.ToString(ds.Tables[0].Rows[0]["FJALEKALIMI"]);
            this.txtPerseritFjalekalimi.Text = Convert.ToString(ds.Tables[0].Rows[0]["FJALEKALIMI"]);
        }        
        #endregion 

        #region Event Handlers
        private void btnOk_Click(object sender, EventArgs e)
        {

            if (this.KaGabime() == true)
            {
                return;
            }

            string emri = this.txtEmri.Text.Trim();
            string mbiemri = this.txtMbiemri.Text.Trim();
            string emaili = this.txtEmaili.Text.Trim();
            string telefoni = this.txtTelefoni.Text.Trim();
            string adresa = this.txtAdresa.Text.Trim();


            int roli = 0;

            if (this.optAdministratori.Checked == true)
            {
                roli = 1;
            }

            if (this.optKamarieri.Checked == true)
            {
                roli = 2;
            }

            if (this.optSupervizori.Checked == true)
            {
                roli = 3;
            }

            string perdoruesi = this.txtPerdoruesi.Text.Trim();
            string fjalekalimi = this.txtFjalekalimi.Text.Trim();

            string foto = this.PicturePath;
            this.fotoSkedari = this.PicturePath;

            int b = 0;
            InputController data = new InputController();
            
            switch (this.veprimi)
            {
                case 1:
                    b = data.KerkesaUpdate("KrijoPersonel", roli, emri, mbiemri, emaili, telefoni, adresa, perdoruesi, fjalekalimi, foto);
                    break;

                case 2:
                    b = data.KerkesaUpdate("ModifikoPersonel", this.idPersoneli, roli, emri, mbiemri, emaili,  telefoni, adresa, perdoruesi, fjalekalimi, foto);
                    break;

                default:
                    break;

            }

            if (b == 2)
            {
                MessageBox.Show(this, "Ekziston një përdorues me këtë emër përdoruesi." + Environment.NewLine + "Ju lutem jepini përdoruesit një emër tjetër!", 
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPerdoruesi.Text = "";
                this.txtFjalekalimi.Text = "";
                this.txtPerseritFjalekalimi.Text = "";

                return;

            }

            if (b == 3)
            {
                MessageBox.Show(this, "Ekziston një përdorues me këtë  fjalekalim." + Environment.NewLine + "Ju lutem jepini përdoruesit një fjalekalim tjetër!",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.txtFjalekalimi.Text = "";
                this.txtPerseritFjalekalimi.Text = "";

                return;

            }

            if (b == 1)
            {
                //Mesazh gabimi
            }

            if (this.veprimi == 1)
            {
                MessageBox.Show("Perdoruesi me username  '" + perdoruesi + "'  u shtua.", this.Text);
            }

            this.PastroFormen();

            if (this.veprimi == 2)
            {
                this.Close();
            }
            

        }

        private void btnGjejFoto_Click(object sender, EventArgs e)
        {
            string s = "";
            s = this.ZgjidhLogo(this.openFileDialog1, "Figura|*.bmp;*.ico;*.cur;*.jpg;*.gif;*.png");
            if (s == "")
            {
                return;
            }
            else
            {
                this.pcbFoto.Image = Image.FromFile(s);
                this.PicturePath = s;
            }
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFshiFoto_Click(object sender, EventArgs e)
        {
            this.pcbFoto.Image = null;
            this.PicturePath = "";
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {

            DialogResult result;
            if (this.idRoli != 2)
                result = MessageBox.Show(this, "Jeni të sigurtë se doni të fshini përdoruesin e zgjedhur?",
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else
                result = MessageBox.Show(this, "Fshirja e një kamarieri do të bëjë që faturat" +
                Environment.NewLine + "e prera nga ai të mos kenë më referencë kamarieri!" +
                Environment.NewLine + "Jeni të sigurte se doni të fshini përdoruesin e zgjedhur?",
                    this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                this.modifikoVeprimi = 0;
                return;
            }

            this.modifikoVeprimi = 2;
            this.pcbFoto.Image = null;

            InputController data = new InputController();
            int b = 0;
            DataSet ds = data.KerkesaRead("KthePathiFotoPersoneli", this.idPersoneli);

            if ((ds == null) || (ds.Tables[0].Rows.Count == 0))
            {
                this.fotoSkedari = "";
            }
            else
            {
                this.fotoSkedari = Convert.ToString(ds.Tables[0].Rows[0][0]);
            }

            
            b = data.KerkesaUpdate("FshiPersonel", this.idPersoneli);

            if (b == 10)
            {
                this.Close();
                return;
            }

            if (b == 0)
            {
                this.fshire = true;
                this.Close();
                return;

            }

            MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së përdoruesit!" + Environment.NewLine +
                "Ju lutem provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool KaGabime()
        {
            if (this.txtEmri.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te jepni emrin e perdoruesit!", "Kujdes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            if (this.optAdministratori.Checked == false && this.optKamarieri.Checked == false && this.optSupervizori.Checked == false)
            {
                MessageBox.Show("Ju duhet te percaktoni statusin e perdoruesit!", "Kujdes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            if (this.txtPerdoruesi.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te jepni username-in e perdoruesit!", "Kujdes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            if (this.txtFjalekalimi.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te jepni fjalekalimin e perdoruesit!", "Kujdes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            if (this.txtFjalekalimi.Text.Trim() != this.txtPerseritFjalekalimi.Text.Trim())
            {
                MessageBox.Show("Konfirmimi i fjalëkalimit nuk është i saktë. Jepni përsëri fjalëkalimin!", "Kujdes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.txtFjalekalimi.Text = "";
                this.txtPerseritFjalekalimi.Text = "";

                return true;

            }

            if (this.optKamarieri.Checked == true)
            {
                string kodi = this.txtFjalekalimi.Text.Trim();

                int numri = kodi.Length;

                if (numri != 4)
                {
                    MessageBox.Show("Fjalekalimi i kamarierit eshte kombinim 4 shifrash !", "Kujdes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }

                int kodiKam = 0;

                try
                {
                    kodiKam = Convert.ToInt32(kodi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fjalekalimi i kamarierit eshte kombinim 4 shifrash !", "Kujdes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
            }

            return false;

        }

        
        #endregion
    }
}