using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResManagerAdmin.Forms
{
    public partial class Forma : Form
    {
        #region Load Form
        public Forma()
        {
            InitializeComponent();
            this.expandablePanel1.TitleText = this.Text;
        }
        #endregion

        private void Forma_Load(object sender, EventArgs e)
        {
            this.expandablePanel1.TitleText = this.Text;
        }
        #region Event Handlers
        #endregion
    }
}