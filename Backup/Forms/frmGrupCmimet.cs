using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerLibrary;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmGrupCmimet : System.Windows.Forms.Form
    {
        private int veprimi = 0;

        public frmGrupCmimet()
        {
            InitializeComponent();
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.paneli.TitleText = s;
        }

        private void frmGrupCmimet_Load(object sender, EventArgs e)
        {
            this.LexoInformacione();
        }

        private void Aktivizo()
        {
            this.btnShto.Enabled = true;
            this.btnModifiko.Enabled = true;
            this.btnFshi.Enabled = true;
        }

        private void Caktivizo()
        {
            this.btnShto.Enabled = false;
            this.btnModifiko.Enabled = false;
            this.btnFshi.Enabled = false;
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            this.veprimi = 0;
            this.Pastro();
            this.uiTab.TabPages[0].Text = "Shtim";
            this.grida.Visible = false;
            this.Caktivizo();
        }

        private void Pastro()
        {
            this.txtKodi.Text = "";
            this.txtPershkrimi.Text = "";
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (this.txtKodi.Text.Trim() == "")
            {
                return;
            }

            string kodi = this.txtKodi.Text.Trim();
            string pershkrimi = this.txtPershkrimi.Text.Trim();

            InputController data = new InputController();
            int b = 0;

            if (this.veprimi == 0)
            {
                b = data.KerkesaUpdate("KrijoGrupCmimi", kodi, pershkrimi);
            }
            else
            {
                int indeksi = this.grida.Row;
                int idGrupCmimi = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);

                b = data.KerkesaUpdate("ModifikoGrupCmimi", idGrupCmimi, kodi, pershkrimi);
            }

            if (b == 1)
            {
                MessageBox.Show(this, "Ju keni hasur nje problem ne aksesimin e bazes se te dhenave !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (b == 2)
            {
                MessageBox.Show(this, "Ekziston tashme nje grup me kete kod !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.MbushGriden();
            this.veprimi = 0;
            this.Aktivizo();
            this.grida.Visible = true;
            this.Pastro();
        }

        private void MbushGriden()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqGrupCmimet");

            if (data != null)
            {
                this.grida.DataSource = ds.Tables[0];
            }
        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;
            if (indeksi < 0)
            {
                return;
            }

            this.txtKodi.Text = Convert.ToString(this.grida.GetRow(indeksi).Cells["KGRUPCMIMI"].Text);
            this.txtPershkrimi.Text = Convert.ToString(this.grida.GetRow(indeksi).Cells["PGRUPCMIMI"].Text);

            this.veprimi = 1;
           
            this.uiTab.TabPages[0].Text = "Modifikim";
            this.grida.Visible = false;
            this.Caktivizo();

        }

        private void grida_DoubleClick(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;
            if (indeksi < 0)
            {
                return;
            }

            this.txtKodi.Text = Convert.ToString(this.grida.GetRow(indeksi).Cells["KGRUPCMIMI"].Text);
            this.txtPershkrimi.Text = Convert.ToString(this.grida.GetRow(indeksi).Cells["PGRUPCMIMI"].Text);

            this.veprimi = 1;

            this.uiTab.TabPages[0].Text = "Modifikim";
            this.grida.Visible = false;
            this.Caktivizo();
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.veprimi = 0;
            this.Aktivizo();
            this.grida.Visible = true;
            this.Pastro();
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;

            if (indeksi < 0)
            {
                return;
            }

            bool zgjedhur = Convert.ToBoolean(this.grida.GetRow(indeksi).Cells["ZGJEDHUR"].Text);

            if (zgjedhur == true)
            {
                MessageBox.Show(this, "Ju nuk mund te fshini grupin e cmimeve qe eshte ne perdorim !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(this, "Ju jeni duke fshire nje grup cmimesh. Jeni te sigurte se doni te vazhdoni ?", "Vemendje !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            InputController data = new InputController();

            int idGrupi = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);

            int b = data.KerkesaUpdate("FshiGrupCmimi", idGrupi);

            if (b != 0)
            {
                MessageBox.Show(this, "Nje gabim ndodhi ne fshirjen e grupit te cmimeve " + Environment.NewLine + "Ju lutem provoni perseri !", "Vemendje !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.MbushGriden();
        }

        private void frmGrupCmimet_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            MbushGriden();
        }

        
    }
}