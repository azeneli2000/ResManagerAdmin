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
    public partial class frmKryejShpenzim : Form
    {
        #region FormLoad
        private int idPerdoruesi = 0;
        public frmKryejShpenzim()
        {
            InitializeComponent();
        }

        private void frmKryejShpenzim_Load(object sender, EventArgs e)
        {
            GjejPerdorues();
            MbushCombo();
            DateTime[] v = new DateTime[1];
            v[0] = DateTime.Now;
            calendar.SelectedDates = v;
            calendar.CurrentDate = DateTime.Now;
            dtpData.Value = DateTime.Now;
            //TotalShpenzime(DateTime.Now);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Gjen perdoruesin e loguar ne sistem dhe e shfaq ne forme
        /// </summary>
        private void GjejPerdorues()
        {
            this.idPerdoruesi = MDIAdminTjeter.idPerdoruesi;
            //nuk ka asnje perdorues te loguar
            if (this.idPerdoruesi == 0)
                return;
            else
            {
                txtPerdoruesi.Text = MDIAdminTjeter.emerPerdoruesi + " " +  MDIAdminTjeter.mbiemerPerdoruesi;
            }
                           
        }
        
        private void MbushCombo()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEShpenzimeve");
            cmbKategorite.DataSource = ds.Tables[0];
        }

        private void TotalShpenzime(DateTime dt)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShpenzimetPerDaten", dt);
            if (Convert.IsDBNull(ds.Tables[0].Rows[0][0]))
                numTotali.Value = 0;
            else
                numTotali.Value = Convert.ToDecimal(ds.Tables[0].Rows[0][0]);
        }

        private void GjejShpenzime()
        {
            DateTime data;
            string strdata;
            strdata = calendar.CurrentDate.Date.ToString("yyyy-MM-dd") + " " + dtpData.Value.Hour + ":" + dtpData.Value.Minute;
            data = Convert.ToDateTime(strdata);
            TotalShpenzime(data);
        }

        private void Pastro()
        {
            cmbKategorite.Value = null;
            cmbKategorite.Text = "";
            numVlera.Value = 0;
            txtPershkrimi.Text = "";
            calendar.CurrentDate = DateTime.Today;
            dtpData.Value = DateTime.Now;
        }
        #endregion

        #region Event Handlers

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            GjejShpenzime();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbKategorite.Text != "" && cmbKategorite.Value != null &&
                txtPershkrimi.Text != "" && numVlera.Value != 0)
            {
                InputController data = new InputController();
                int idKategoria = Convert.ToInt32(cmbKategorite.Value);
                DateTime dtShpenzimi;
                string strdata;
                strdata = calendar.CurrentDate.Date.ToString("yyyy-MM-dd") + " " + dtpData.Value.Hour + ":" + dtpData.Value.Minute;
                dtShpenzimi = Convert.ToDateTime(strdata);
                int b = data.KerkesaUpdate("KryejShpenzim", idKategoria, idPerdoruesi, txtPershkrimi.Text,
                    dtShpenzimi, numVlera.Value);
                if (b == 0)
                {
                    MessageBox.Show(this, "Shpenzimi u regjistrua.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pastro();
                }
                else
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë regjistrimit të shpenzimit. Provoni përsëri!.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        private void btnSot_Click(object sender, EventArgs e)
        {
            calendar.CurrentDate = DateTime.Now;
        }

        private void calendar_SelectionChanged(object sender, EventArgs e)
        {
            GjejShpenzime();
        }

        
    }
}