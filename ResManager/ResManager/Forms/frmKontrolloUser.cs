using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResManager.Forms
{
    public partial class frmKontrolloUser : Form
    {
        public DataSet dsKam = null;
        public int idUser = 0;
        public string perdoruesi = "";
        public int veprimi = 0;

        public frmKontrolloUser()
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.KaGabim() == true)
            {
                return;
            }

            string kodi = this.txtFjalekalimi.Text.Trim();
            string celesi = "";

            foreach (DataRow dr in this.dsKam.Tables[0].Rows)
            {
                celesi = Convert.ToString(dr["FJALEKALIMI"]).Trim();

                if (kodi == celesi)
                {
                    this.idUser = Convert.ToInt32(dr["ID_PERSONELI"]);
                    this.perdoruesi = Convert.ToString(dr["PERDORUESI"]);
                    this.veprimi = 1;

                    this.Close();
                    return;
                }
            }

            MessageBox.Show(this, "Fjalekalimi i dhene nga ju nuk i korespondon nje kamarieri te loguar !", "Vemendje !", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private bool KaGabim()
        {
            string kodi = this.txtFjalekalimi.Text.Trim();

            if (kodi == "")
            {
                return true;
            }

            int numri = kodi.Length;

            if (numri != 4)
            {
                MessageBox.Show(this, "Fjalekalimi i kamarierit eshte kombinim 4 shifrash !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            return false;
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.veprimi = 0;
            this.Close();
        }
    }
}