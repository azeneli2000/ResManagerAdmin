using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResManagerAdmin.Forms
{
    public partial class NumriSerial : Form
    {
        public bool rregjistroNr = false;
        public NumriSerial()
        {
            InitializeComponent();
        }

        private void btnRregjistro_Click(object sender, EventArgs e)
        {
            try
            {
                rregjistroNr = true;
                this.Close();
            }
            catch
            {
            }
        }

        private void btnMbyll_Click(object sender, EventArgs e)
        {
            rregjistroNr = false;
            this.Close();
        }

        private void NumriSerial_Load(object sender, EventArgs e)
        {
            this.txtNrPerRregjistrim.Text = RegistrationClass.GetKey();
        }

        private void lblInfoEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:info@visioninfosolution.com");
        }
    }
}