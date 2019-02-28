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
    public partial class frmMbyllTurninAdministratori : Form
    {
        public int veprimi = 0;
        public DataSet dsKam = null;
        public int idUser = 0;

        public frmMbyllTurninAdministratori()
        {
            InitializeComponent();
        }

        private void MbushKomboUser()
        {
            this.cboUser.DataSource = this.dsKam.Tables[0];
        }

        private void MbushKomboAdministrator()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqPerdoruesitJoKamariere");

            this.cboAdministratori.DataSource = ds.Tables[0];
        }

        private void frmMbyllTurninAdministratori_Load(object sender, EventArgs e)
        {
            this.MbushKomboUser();
            this.MbushKomboAdministrator();
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            this.veprimi = 0;
            this.Close();
        }

        private bool KaGabim()
        {
            string kam = this.cboUser.Text.Trim();

            if (kam == "")
            {
                MessageBox.Show(this, "Ju duhet te zgjidhni kamarierin turnin e te cilit duhet te mbyllni !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
              
            }

            string administrator = this.cboAdministratori.Text.Trim();

            if (administrator == "")
            {
                MessageBox.Show(this, "Ju duhet identifikoheni  !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            string kodi = this.txtFjalekalimi.Text.Trim();

            if (kodi == "")
            {
                MessageBox.Show(this, "Ju duhet te jepni fjalekalimin e administratorit !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

           

            return false;


        }

        private bool VerifikoAdministratorin()
        {
            string fjalekalimi = this.txtFjalekalimi.Text;

            int indeksi = this.cboAdministratori.DropDownList.Row;

            string celesi = Convert.ToString(this.cboAdministratori.DropDownList.GetRow(indeksi).Cells["FJALEKALIMI"].Text);

            if (fjalekalimi == celesi)
            {
                return true;
            }
            else
            {
                MessageBox.Show(this, "Fjalekalimi juaj nuk eshte i sakte !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        private void btnMbyll_Click(object sender, EventArgs e)
        {
            if (this.KaGabim() == true)
            {
                return;
            }

            if (this.VerifikoAdministratorin() == false)
            {
                return;
            }

            int indeksi = this.cboUser.DropDownList.Row;
            int idKam = Convert.ToInt32(this.cboUser.DropDownList.GetRow(indeksi).Cells[0].Text);

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
    }
}