using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResManagerAdmin.Forms
{
    public partial class frmZgjidhPrintiminXhiro : Form
    {

        public int zgjedhja = 0;

        public frmZgjidhPrintiminXhiro()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rbDitet.Checked)
                zgjedhja = 1;
            else
                zgjedhja = 2;
            Close();
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}