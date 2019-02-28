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
    public partial class frmDergesa : Form
    {
        #region FormLoad
        public frmDergesa()
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


        private void frmDergesa_Load(object sender, EventArgs e)
        {
            this.LexoInformacione();

            gridDergesat.Size = new Size(869, 388);
            gridDergesat.BringToFront();
        }
        #endregion

        #region Private Methods
        private void CaktivizoPanel(System.Windows.Forms.Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Button)
                    c.Enabled = false;
            }
        }

        private void AktivizoPanel(System.Windows.Forms.Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is Button)
                    c.Enabled = true;
            }
        }
        #endregion

        #region Event Handlers
        private void btnMbyll_Click(object sender, EventArgs e)
        {
            this.uiTabModifiko.Visible = false;
            this.gridDergesat.Visible = true;
            this.AktivizoPanel(panelButona);
        }

        private void btnRuajDergese_Click(object sender, EventArgs e)
        {
            this.uiTabModifiko.Visible = false;
            this.gridDergesat.Visible = true;
            this.AktivizoPanel(panelButona);
        }

        private void btnShtoDergese_Click(object sender, EventArgs e)
        {
            this.gridDergesat.Visible = false;
            this.uiTabModifiko.Visible = true;
            this.CaktivizoPanel(panelButona);

        }

        private void btnModifikoDergese_Click(object sender, EventArgs e)
        {
            this.gridDergesat.Visible = false;
            this.uiTabModifiko.Visible = true;
            this.CaktivizoPanel(panelButona);
        }
        #endregion

        
    }
}