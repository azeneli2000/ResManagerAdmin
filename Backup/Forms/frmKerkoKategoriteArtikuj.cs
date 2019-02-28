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
    public partial class frmKerkoKategoriteArtikuj : Form
    {
        public int idKategoria = 0;

        #region Form Load
        public frmKerkoKategoriteArtikuj()
        {
            InitializeComponent();
        }

        private void frmKerkoKategoriteArtikuj_Load(object sender, EventArgs e)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEArtikujve");
            lbKategorite.DataSource = ds.Tables[0];
        }
        #endregion

        #region Event Handlers

        private void btnOk_Click(object sender, EventArgs e)
        {
            error1.SetError(lbKategorite, "");
            if (lbKategorite.SelectedIndex >= 0)
            {
                idKategoria = Convert.ToInt32(lbKategorite.SelectedValue);
                Close();
            }
            else
                error1.SetError(lbKategorite, "Duhet të zgjidhni të paktën një kategori artikulli!");
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        
    }
}