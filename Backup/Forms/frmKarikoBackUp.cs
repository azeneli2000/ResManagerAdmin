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
    public partial class frmKarikoBackUp : Form
    {
        public frmKarikoBackUp()
        {
            InitializeComponent();
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmKarikoBackUp_Load(object sender, EventArgs e)
        {
            InputController data = new InputController();
            DataSet dsBackUp = data.KerkesaRead("LexoBackUp");
            gridBackUp.DataSource = dsBackUp.Tables[0];
            if (gridBackUp.RowCount <= 20)
            {
                gridBackUp.RootTable.Columns["EMRI"].Width = 432;
            }
            else
            {
                gridBackUp.RootTable.Columns["EMRI"].Width = 415;
            }
        }

        //private void btnRuaj_Click(object sender, EventArgs e)
        //{
        //    int i = gridBackUp.Row;
            
        //    if (i >= 1 && gridBackUp.GetRow(i).Cells["EMRI"].Text != "")
        //    {
        //        //DialogResult r = MessageBox.Show(this, "Karikimi i back up-it do te zevendesoje të gjitha të dhënat" +
        //        //    Environment.NewLine + "me të dhënat e back up-it që keni zgjedhur." + Environment.NewLine + "Jeni të sigurt që doni të vazhdoni me kryerjen e back up-it?",
        //        //    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        //if (r != DialogResult.Yes)
        //        //    return;
        //        timer.Enabled = true;
        //        timer.Start();
        //        InputController data = new InputController();
        //        string emri = gridBackUp.GetRow(i).Cells["EMRI"].Text;
        //        int b = data.KerkesaUpdate("KarikoBackUp", emri);
        //        this.Cursor = Cursors.Default;
        //        timer.Stop();
        //        if (b == 0)
        //        {
        //            MessageBox.Show(this, "Karikimi i back up-it u krye!" + Environment.NewLine + "Programi do te mbyllet dhe do te rihapet automatikisht për të ruajtur ndryshimet."
        //                , Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            Close();
        //            Application.Restart();
        //        }
              
        //    }
        //}
        private void btnRuaj_Click(object sender, EventArgs e)
        {
            int i = gridBackUp.Row;

            if (i >= 1 && gridBackUp.GetRow(i).Cells["EMRI"].Text != "")
            {
                this.Cursor = Cursors.WaitCursor;
                DialogResult r = MessageBox.Show(this, "Karikimi i back up-it do te zevendesoje të gjitha të dhënat" +
                    Environment.NewLine + "me të dhënat e back up-it që keni zgjedhur." + Environment.NewLine + "Jeni të sigurt që doni të vazhdoni me kryerjen e back up-it?",
                    Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes)
                    return;
                InputController data = new InputController();
                string emri = gridBackUp.GetRow(i).Cells["EMRI"].Text;
                int b = data.KerkesaUpdate("KarikoBackUp", emri);
                this.Cursor = Cursors.Default;
                if (b == 0)
                {
                    MessageBox.Show(this, "Karikimi i back up-it u krye!"
                        , Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (uiStatusBar.Panels[1].ProgressBarValue + 10 <= 100)
                uiStatusBar.Panels[1].ProgressBarValue = uiStatusBar.Panels[1].ProgressBarValue + 10;
        }

    

    }
}