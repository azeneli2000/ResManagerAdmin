using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;

namespace ResManager.Forms
{
    public partial class frmLogimi : Form
    {
        public DataSet dsKam = null;
        public int idUser = 0;
        public string perdoruesi = "";
        public string fjalekalimi = "";
        public int veprimi = 0;

        public frmLogimi()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;
            teksti = teksti + "1";

            this.txtFjalekalimi.Text = teksti;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;
            teksti = teksti + "2";

            this.txtFjalekalimi.Text = teksti;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;
            teksti = teksti + "3";

            this.txtFjalekalimi.Text = teksti;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;
            teksti = teksti + "4";

            this.txtFjalekalimi.Text = teksti;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;
            teksti = teksti + "5";

            this.txtFjalekalimi.Text = teksti;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;
            teksti = teksti + "6";

            this.txtFjalekalimi.Text = teksti;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;
            teksti = teksti + "7";

            this.txtFjalekalimi.Text = teksti;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;
            teksti = teksti + "8";

            this.txtFjalekalimi.Text = teksti;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;
            teksti = teksti + "9";

            this.txtFjalekalimi.Text = teksti;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;
            teksti = teksti + "0";

            this.txtFjalekalimi.Text = teksti;
        }

        private void btnPrapa_Click(object sender, EventArgs e)
        {
            string teksti = this.txtFjalekalimi.Text;

            if (teksti == "")
            {
                return;
            }

            int nr = teksti.Length;

            string tekstiNew = teksti.Substring(0, nr - 1);

            this.txtFjalekalimi.Text = tekstiNew;
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            this.txtFjalekalimi.Text = "";
        }

        private void MbushKomboUser()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKamarieretPerKombo");

            if (ds != null)
            {

                this.cboUser.DataSource = ds.Tables[0];
            }
        }

        private void frmLogimi_Load(object sender, EventArgs e)
        {
            this.MbushKomboUser();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.KaGabim() == true)
            {
                return;
            }

            int idKam = Convert.ToInt32(this.cboUser.Value);
            string kodi = this.txtFjalekalimi.Text.Trim();

            if (this.GjendetUser(idKam) == true)
            {
                MessageBox.Show(this, "Ky perdorues eshte tashme i loguar !", "Vemendje !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTeDhenaPerPersonelinZgjedhur", idKam);

            if (ds == null || ds.Tables[0].Rows.Count == 0)
            {
                return;
            }

            this.fjalekalimi = Convert.ToString(ds.Tables[0].Rows[0]["FJALEKALIMI"]).Trim();
            this.perdoruesi = Convert.ToString(ds.Tables[0].Rows[0]["PERDORUESI"]).Trim();
            this.idUser = idKam;

            string password = Convert.ToString(ds.Tables[0].Rows[0]["FJALEKALIMI"]).Trim();

            if (kodi != password)
            {
                MessageBox.Show(this, "Fjalekalimi juaj nuk eshte i sakte !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            int b = data.KerkesaUpdate("Login", idKam, 1);

            if (b == 0)
            {
                this.veprimi = 1;
                this.Close();
            }







            
        }

        private bool KaGabim()
        {
            string kam = this.cboUser.Text.Trim();

            if (kam == "")
            {
                return true;
            }

            string kodi = this.txtFjalekalimi.Text.Trim();

            if (kodi == "")
            {
                return true;
            }

            int numri = kodi.Length;

            if (numri != 4)
            {
                MessageBox.Show(this, "Fjalekalimi i kamarierit eshte kombinim 4 shifrash !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;


        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.veprimi = 0;
            this.Close();
        }

        private bool GjendetUser(int idKam)
        {
            int celesi = 0;

            foreach (DataRow dr in this.dsKam.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr[0]);

                if (celesi == idKam)
                {
                    return true;
                }
            }

            return false;
        }
        
    }
}