using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;


namespace ResManager.Forms
{
    public partial class frmTurni : Form
    {
        public int idKamarieri;

        public frmTurni()
        {
            InitializeComponent();
        }

        private void txtFjalekalimiHap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMbyllTurnin_Click(object sender, EventArgs e)
        {
            string fjalekalimi = this.txtFjalekalimiMbyll.Text.Trim();
            if (fjalekalimi == "")
            {
                MessageBox.Show("Jepni fjalekalimin!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Doni te konsultoni xhiron ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmXhiroKamarieri frm = new frmXhiroKamarieri();
                frm.idKamarieri = this.idKamarieri;

                frm.Show();
            }

            

            InputController data = new InputController();

            DataSet ds = data.KerkesaRead("VerifikoFjalekalimin",  fjalekalimi, idKamarieri);

            if (ds == null)
            {
                MessageBox.Show("Ju keni hasur nje problem ne aksesimin e bazes se te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Fjalekalimi juaj nuk ishte i sakte!Jepni fjalekalimin e sakte!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtFjalekalimiMbyll.Text = "";
                return;
            }

            int b = data.KerkesaUpdate("MbyllTurnin", this.idKamarieri);
        }

        private void btnHapTurnin_Click(object sender, EventArgs e)
        {

        }

        private void frmTurni_Load(object sender, EventArgs e)
        {
            this.MbushGridenNeLodim();
        }

        private void MbushGridenNeLodim()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTurnetPerLodim", idKamarieri);

            this.grida.DataSource = ds.Tables[0];
        }

        private void MbushGridenSipasKerkimit(DateTime dateFillimi, DateTime dateMbarimi)
        {
            
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTurnetPerKamarierPerPeriudhen", this.idKamarieri, dateFillimi, dateMbarimi);

            this.grida.DataSource = ds.Tables[0];
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            DateTime dataFillimi = this.dtFillimi.Value;
            DateTime dataMbarimi = this.dtMbarimi.Value;

            this.MbushGridenSipasKerkimit(dataFillimi, dataMbarimi);
        }
    }
}