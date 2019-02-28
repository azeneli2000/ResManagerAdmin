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
    public partial class frmMbyllTurnin : Form
    {
        public int veprimi = 0;
        public DataSet dsKam = null;
        public int idUser = 0;

        public frmMbyllTurnin()
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
            this.cboUser.DataSource = this.dsKam.Tables[0];
        }

        private void frmMbyllTurnin_Load(object sender, EventArgs e)
        {
            this.MbushKomboUser();
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.KaGabim() == true)
            {
                return;
            }

            int idKam = Convert.ToInt32(this.cboUser.Value);
            string kam = this.txtFjalekalimi.Text.Trim();

            int celesi = 0;
            string kodi = "";

            bool ugjet = false;

            foreach (DataRow dr in this.dsKam.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr[0]);
                kodi = Convert.ToString(dr["FJALEKALIMI"]);

                if (idKam == celesi)
                {
                    if (kodi == kam)
                    {
                        ugjet = true;
                    }
                }
            }

            if (ugjet == false)
            {
                MessageBox.Show(this, "Fjalekalimi juaj nuk eshte i sakte !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            InputController data = new InputController();

            int b = data.KerkesaUpdate("Logout", idKam, 1);

            if (b == 0)
            {

                this.veprimi = 1;
                this.idUser = idKam;
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show(this, "Ju haset nje problem ne aksesimin e bazes se te dhenave !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

    }
}