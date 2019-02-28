using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResManager.Forms
{
    public partial class frmZgjidhTavoline : Form
    {
        public DataSet dsTavolinat = null;
        public int idTavolina = 0;
        public string gjendjaTav = "";
        public string emriTavolina = "";

        public frmZgjidhTavoline()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;
            teksti = teksti + "1";

            this.txtTavolina.Text = teksti;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;
            teksti = teksti + "2";

            this.txtTavolina.Text = teksti;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;
            teksti = teksti + "3";

            this.txtTavolina.Text = teksti;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;
            teksti = teksti + "4";

            this.txtTavolina.Text = teksti;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;
            teksti = teksti + "5";

            this.txtTavolina.Text = teksti;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;
            teksti = teksti + "6";

            this.txtTavolina.Text = teksti;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;
            teksti = teksti + "7";

            this.txtTavolina.Text = teksti;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;
            teksti = teksti + "8";

            this.txtTavolina.Text = teksti;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;
            teksti = teksti + "9";

            this.txtTavolina.Text = teksti;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;
            teksti = teksti + "0";

            this.txtTavolina.Text = teksti;
        }

        private void btnPrapa_Click(object sender, EventArgs e)
        {
            string teksti = this.txtTavolina.Text;

            if (teksti == "")
            {
                return;
            }

            int nr = teksti.Length;

            string tekstiNew = teksti.Substring(0, nr - 1);

            this.txtTavolina.Text = tekstiNew;
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            this.txtTavolina.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txtTavolina.Text == "")
            {
                return;
            }

            string tav = this.txtTavolina.Text.Trim();
            string celesi = "";

            foreach (DataRow dr in this.dsTavolinat.Tables[0].Rows)
            {
                celesi = Convert.ToString(dr[2]).Trim();

                if (celesi == tav)
                {
                    this.idTavolina = Convert.ToInt32(dr[0]);
                    this.gjendjaTav = Convert.ToString(dr[1]);
                    this.emriTavolina = tav;

                    this.Close();
                    return;
                }
            }

            MessageBox.Show(this, "Nuk ekziston nje tavoline me kete numer !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }
    }
}