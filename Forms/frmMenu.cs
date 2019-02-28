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
    public partial class frmMenu : Form
    {
        #region Load Form
        public frmMenu()
        {
            InitializeComponent();
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.LexoInformacione();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Size s = this.Size;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        #region Event Handlers
        #endregion
    }
}