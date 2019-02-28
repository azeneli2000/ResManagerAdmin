using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmFaturaShfaq : Form
    {
        public int idFatura;
        public string dataFatura;
        public string nrFatura;
        public string kamarieri;
        public string tavolina;
        public string skonto;
        public string totali;

        public frmFaturaShfaq()
        {
            InitializeComponent();
        }

        private void frmFaturaShfaq_Load(object sender, EventArgs e)
        {
            this.MbushGriden();

            this.lblDataoRA.Text = this.dataFatura;
            this.lblTavolina.Text = this.tavolina;
            this.lblKamarieri.Text = this.kamarieri;
            this.lblNrFature.Text = this.nrFatura;
            this.lblSkonto.Text = this.skonto;
            this.lblTotali.Text = this.totali;
        }

        private void MbushGriden()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTeDhenaPerFaturen", this.idFatura);

            if (ds == null)
            {
                MessageBox.Show("Ju keni hasur nje problem ne aksesimin e bazes se te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            this.gridaFatura.DataSource = ds.Tables[0];
        }

        private void btnMbyll_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}