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
    public partial class frmKatShpenzimiMujor : Form
    {
        public frmKatShpenzimiMujor()
        {
            InitializeComponent();
        }

        #region PrivateMethods

        private void CaktivizoPanel(System.Windows.Forms.Panel panel)
        {
            foreach (Control c in grTop.Controls)
            {
                if (c is Button)
                    c.Enabled = false;
            }
        }

        private void AktivizoPanel(System.Windows.Forms.Panel panel)
        {
            foreach (Control c in grTop.Controls)
            {
                if (c is Button)
                    c.Enabled = true;
            }
        }

        #endregion

        private void btnShto_Click(object sender, EventArgs e)
        {
            this.txtEmri.Clear();
            this.txtPershkrimi.Clear();
           
            this.grida.Visible = false;
            this.tabi.Visible = true;
            this.tabPage.Text = "Shtim";
            this.tabPage.Image = ResManagerAdmin.Properties.Resources.news_info;
            this.CaktivizoPanel(panelTop);
            
        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            int index = this.grida.Row;
            if (index >= 0)
            {
                this.txtEmri.Text = grida.GetRow(index).Cells["CSHPENZIMI"].Text;
                this.txtPershkrimi.Text = grida.GetRow(index).Cells["PSHPENZIMI"].Text;

                
                this.grida.Visible = false;
                this.tabPage.Text = "Modifikim";
                this.tabPage.Image = ResManagerAdmin.Properties.Resources.forum_newmsg;
                this.tabi.Visible = true;
                this.CaktivizoPanel(panelTop);
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (this.txtEmri.Text.Trim() == "")
            {
                return;
            }

            string emri = this.txtEmri.Text.Trim();
            string pershkrimi = this.txtPershkrimi.Text.Trim();

            InputController data = new InputController();
            int b = 0;

            string veprimi = this.tabPage.Text.Trim();

            switch (veprimi)
            {
                case "Shtim":

                    b = data.KerkesaUpdate("KrijoKategoriShpenzimMujor", emri, pershkrimi);

                    if (b == 1)
                    {
                        MessageBox.Show("Ju keni hasur nje problem ne aksesimin e bazes se te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (b == 2)
                    {
                        MessageBox.Show("Ekziston tashme nje kategori e shpenzimeve mujore me kete emer.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                   
                    //MessageBox.Show("Kategoria e re u shtua me sukses!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    

                    break;

                case "Modifikim":

                    int indeksi = this.grida.Row;
                    int idKategoria = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);

                    b = data.KerkesaUpdate("ModifikoKategoriShpenzimiMujor", idKategoria, emri, pershkrimi);

                    if (b == 1)
                    {
                        MessageBox.Show("Ju keni hasur nje problem ne aksesimin e bazes se te dhenave!", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (b == 2)
                    {
                        MessageBox.Show("Ekziston nje tjeter kategori e shpenzimeve mujore me kete emer.", "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    break;

                default:
                    break;

            }

            this.MbushGriden();
            this.grida.Visible = true;
            this.tabi.Visible = false;
            this.AktivizoPanel(panelTop);

            txtEmri.Clear();
            this.txtPershkrimi.Clear();

        }

        private void MbushGriden()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriShpenzimeshMujore");

            if (ds == null)
            {
                return;
            }

            this.grida.DataSource = ds.Tables[0];
        }

        private void frmKatShpenzimiMujor_Load(object sender, EventArgs e)
        {
            this.MbushGriden();
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.grida.Visible = true;
            this.tabi.Visible = false;
            this.AktivizoPanel(panelTop);
           
            txtEmri.Clear();
            this.txtPershkrimi.Clear();
        }

    }
}