using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResManagerAdmin.Forms
{
    public partial class frmWarningKonfiguroIntervale : Form
    {
        public frmWarningKonfiguroIntervale()
        {
            InitializeComponent();
        }

        private void frmWarningKonfiguroIntervale_Load(object sender, EventArgs e)
        {
            lbArtikujt.DataSource = dsResult.Tables[0];
            lbRecetat.DataSource = dsResult.Tables[1];
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}