using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmSettings : Form
    {
        #region Load Form
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LexoInformacione();
            LexoIntervale();
        }

        #endregion

        #region Private Methods
        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Application.StartupPath + "\\SkedaretXml\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void LexoIntervale()
        {
            InputController data = new InputController();
            this.dsIntervalet = data.KerkesaRead("LexoIntervaletCmime");
            if (dsIntervalet.Tables[0].Rows.Count <= 1)
            {
                cbNdajNeIntervale.Checked = false;
                KonfiguroPerNjeInterval();
                gbIntervalet.Enabled = false;
            }
            else
            {
                cbNdajNeIntervale.Checked = true;
                int nr = dsIntervalet.Tables[0].Rows.Count;
                numNrIntervalesh.Value = nr - 1;
                //ndryshimi i vleres ne numeric box ben edhe ndryshimin
                //ne numrin e intervaleve te shfaqur
                numNrIntervalesh.Value = nr;
                for (int i = 1; i <= nr; i++)
                {
                    foreach (Control c in panelIntervale.Controls)
                    {
                        if ((c is DateTimePicker)&&(c.Name.EndsWith(i.ToString())))
                        {
                            DateTimePicker d = c as DateTimePicker;
                            if (d.Name.StartsWith("dtpFillimi"))
                                d.Value = Convert.ToDateTime(dsIntervalet.Tables[0].Rows[i - 1]["ORE_FILLIMI"]);
                            else
                            {
                                d.Value = Convert.ToDateTime(dsIntervalet.Tables[0].Rows[i - 1]["ORE_MBARIMI"]);
                            }
                        }
                    }
                }
                
            }
        }

        private void KonfiguroPerNjeInterval()
        {
            numNrIntervalesh.Value = 1;
            lb2.Visible = false;
            lb3.Visible = false;
            lb4.Visible = false;

            lbFillimi2.Visible = false;
            lbFillimi3.Visible = false;
            lbFillimi4.Visible = false;

            lbMbarimi2.Visible = false;
            lbMbarimi3.Visible = false;
            lbMbarimi4.Visible = false;

            dtpFillimi2.Visible = false;
            dtpFillimi3.Visible = false;
            dtpFillimi4.Visible = false;

            lbMbarimi2.Visible = false;
            lbMbarimi3.Visible = false;
            lbMbarimi4.Visible = false;

            dtpMbarimi2.Visible = false;
            dtpMbarimi3.Visible = false;
            dtpMbarimi4.Visible = false;

            dtpFillimi1.Text = "00:00";
            dtpMbarimi1.Text = "00:00";
        }

        private int KontrolloPerGabime()
        {
            int r = 0;
            this.error1.SetError(numNrIntervalesh, "");
            this.error1.SetError(dtpFillimi1, "");
            this.error1.SetError(dtpFillimi2, "");
            this.error1.SetError(dtpFillimi3, "");
            this.error1.SetError(dtpFillimi4, "");
            this.error1.SetError(dtpMbarimi1, "");
            this.error1.SetError(dtpMbarimi2, "");
            this.error1.SetError(dtpMbarimi3, "");
            this.error1.SetError(dtpMbarimi4, "");
            if (cbNdajNeIntervale.Checked)
            {
                if (numNrIntervalesh.Value <= 1)
                {
                    this.error1.SetError(numNrIntervalesh, "Duhet të konfiguroni të paktën dy intervale");
                    r++;
                }
                int nr = Convert.ToInt32(numNrIntervalesh.Value);
                for (int i = 1; i < nr; i++)
                {
                    DateTimePicker dFillimi = new DateTimePicker();
                    DateTimePicker dMbarimi = new DateTimePicker();
                    foreach (Control c in panelIntervale.Controls)
                    {
                        if (c is DateTimePicker && c.Name.EndsWith(i.ToString()))
                        {
                            if (c.Name.StartsWith("dtpFillimi"))
                                dFillimi = c as DateTimePicker;
                            else
                            {
                                dMbarimi = c as DateTimePicker;
                            }
                        }
                    }
                    DateTime dataFillimi = Convert.ToDateTime(dFillimi.Value);
                    DateTime dataMbarimi = Convert.ToDateTime(dMbarimi.Value);
                    TimeSpan ts = dataMbarimi.Subtract(dataFillimi);
                    double ore = ts.TotalHours;
                    if ( ore < 1)
                    {
                        this.error1.SetError(dFillimi, "Nuk mund të caktohen intervale me të shkurtër se një orë!");
                        this.error1.SetError(dMbarimi, "Nuk mund të caktohen intervale me të shkurtër se një orë!");
                        r++;
                    }
                    if (dataFillimi.TimeOfDay >= dataMbarimi.TimeOfDay)
                    {
                        this.error1.SetError(dFillimi, "Data e fillimit duhet të jetë më e vogël se data e mbarimit!");
                        this.error1.SetError(dMbarimi, "Data e fillimit duhet të jetë më e vogël se data e mbarimit!");
                        r++;
                    }
                }

            }
            return r;
        }

        private void VendosFundin()
        {
            int nr = Convert.ToInt32(numNrIntervalesh.Value);
            switch (nr)
            {
                case 1:
                    dtpMbarimi1.Text = "00:00";
                    break;
                case 2:
                    dtpMbarimi2.Text = "00:00";
                    break;
                case 3:
                    dtpMbarimi3.Text = "00:00";
                    break;
                case 4:
                    dtpMbarimi4.Text = "00:00";
                    break;
            }
        }

        //private void RuajIntervale()
        //{
        //    DataSet ds = new DataSet();
        //    ds.Tables.Add();
        //    ds.Tables[0].Columns.Add("ORE_FILLIMI", typeof(DateTime));
        //    ds.Tables[0].Columns.Add("ORE_MBARIMI", typeof(DateTime));
        //    ds.AcceptChanges();
        //    if (cbNdajNeIntervale.Checked)
        //    {
        //        int nr = Convert.ToInt32(numNrIntervalesh.Value);
        //        for (int i = 1; i <= nr; i++)
        //        {
        //            DataRow newR = ds.Tables[0].NewRow();
        //            foreach (Control c in panelIntervale.Controls)
        //            {
        //                if (c.Name.EndsWith(i.ToString()) && c is DateTimePicker)
        //                {
        //                    if (c.Name.StartsWith("dtpFillimi"))
        //                    {
        //                        DateTimePicker d = c as DateTimePicker;
        //                        newR["ORE_FILLIMI"] = Convert.ToDateTime(d.Value);
        //                    }
        //                    else
        //                    {
        //                        DateTimePicker d = c as DateTimePicker;
        //                        newR["ORE_MBARIMI"] = Convert.ToDateTime(d.Value);
        //                    }
        //                }
        //            }
        //            ds.Tables[0].Rows.Add(newR);
        //        }
        //        ds.AcceptChanges();
        //    }
        //    InputController data = new InputController();
        //    DataSet dsResult = data.KerkesaUpdate("RuajIntervalet", ds, dsIntervalet);
        //    if (dsResult == null)
        //    {
        //        MessageBox.Show(this, "Një gabim ndodhi gjatë ruajtjes së intervaleve. Provoni përsëri!"
        //            , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    if (dsResult.Tables[0].Rows.Count == 0 && dsResult.Tables[1].Rows.Count == 0)
        //    {
        //        MessageBox.Show(this, "Intervalet e reja për çmimet u ruajtën!" + Environment.NewLine + 
        //            "Modifikimet nuk patën efekte anësore në ndonjë prej artikujve apo recetave", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    else if (dsResult.Tables[0].Rows.Count + dsResult.Tables[1].Rows.Count <= 20)
        //    {
        //        string s = "Intervalet e reja për çmimet u ruajtën!" + Environment.NewLine +
        //            "Si pasojë e modifikimeve, për disa prej artikujve dhe recetave" + Environment.NewLine +
        //            "çmimet e të cilëve ishin konfiguruar me intervale, çmimet ekzistuese janë çaktivizuar." + Environment.NewLine +
        //            "Eshtë e domosdoshme që për këta artikuj dhe receta të bëhet rikonfigurimi i çmimeve.";
        //        int i = 1;
        //        foreach (DataRow dr in dsResult.Tables[0].Rows)
        //        {
        //            s += Environment.NewLine + i + ". " + dr["EMRI"].ToString();
        //            i++;
        //        }
        //        foreach (DataRow dr in dsResult.Tables[1].Rows)
        //        {
        //            s += Environment.NewLine + i + ". " + dr["EMRI"].ToString();
        //            i++;
        //        }
        //        MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    else
        //    {
        //        frmWarningKonfiguroIntervale frm = new frmWarningKonfiguroIntervale();
        //        frm.dsResult = dsResult;
        //        frm.ShowDialog();
        //    }
        //}
        #endregion

        #region Event Handlers
        private void cbNdajNeIntervale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNdajNeIntervale.Checked == true)
            {
                gbIntervalet.Enabled = true;
                numNrIntervalesh.Value = 2;
            }
            else
            {
                KonfiguroPerNjeInterval();
                gbIntervalet.Enabled = false;
            }
        }

        private void numNrIntervalesh_ValueChanged(object sender, EventArgs e)
        {
            int nr = Convert.ToInt32(numNrIntervalesh.Value);
            //Shfaqim kontrollet qe duam
            for (int i = 1; i <= nr; i++)
            {
                foreach (Control c in this.panelIntervale.Controls)
                {
                    if (c.Name.EndsWith(i.ToString()))
                    {
                        c.Visible = true;
                        if (c is DateTimePicker)
                            c.Text = "00:00";
                    }
                }
            }
            //Fshehim kontrollet e tjere
            if (nr < 4)
            {
                for (int i = nr + 1; i <= 4; i++)
                {
                    foreach (Control c in panelIntervale.Controls)
                    {
                        if (c.Name.EndsWith(i.ToString()))
                            c.Visible = false;
                    }
                }
            }
        }

        private void dtpMbarimi1_ValueChanged(object sender, EventArgs e)
        {
            dtpFillimi2.Value = dtpMbarimi1.Value;
            VendosFundin();
        }

        private void dtpMbarimi2_ValueChanged(object sender, EventArgs e)
        {
            dtpFillimi3.Value = dtpMbarimi2.Value;
            VendosFundin();
        }

        private void dtpMbarimi3_ValueChanged(object sender, EventArgs e)
        {
            dtpFillimi4.Value = dtpMbarimi3.Value;
            VendosFundin();
        }

        private void dtpFillimi1_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFillimi1.Text != "00:00")
                dtpFillimi1.Text = "00:00";
            VendosFundin();
        }

        private void dtpMbarimi4_ValueChanged(object sender, EventArgs e)
        {
            if (dtpMbarimi4.Text != "00:00")
                dtpMbarimi4.Text = "00:00";
        }

        private void btnRuajPerberesRi_Click(object sender, EventArgs e)
        {
            int r = KontrolloPerGabime();
            if (r == 0)
            {
                //RuajIntervale();
            }
        }

        private void dtpFillimi2_ValueChanged(object sender, EventArgs e)
        {
            dtpFillimi2.Value = dtpMbarimi1.Value;
        }
        
        private void dtpFillimi3_ValueChanged(object sender, EventArgs e)
        {
            dtpFillimi3.Value = dtpMbarimi2.Value;
        }

        private void dtpFillimi4_ValueChanged(object sender, EventArgs e)
        {
            dtpFillimi4.Value = dtpMbarimi3.Value;
        }


        #endregion

        
    }
}