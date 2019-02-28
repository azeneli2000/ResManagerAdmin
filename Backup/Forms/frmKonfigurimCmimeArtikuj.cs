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
    public partial class frmKonfigurimCmimeArtikuj : Form
    {
        #region FormLoad
        public frmKonfigurimCmimeArtikuj()
        {
            InitializeComponent();
        }

       
        #endregion

        private int zgjidhArtikull = 0;
        private int zgjidhKategori = 0;

        private void uiGroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void cbNdajNeIntervale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNdajNeIntervale.Checked == true)
            {
                panelIntervale.Visible = true;
                panelDita.Visible = false;
                this.numCmimi1.Value = 0;
                this.numCmimi1.Value = 0;
                this.numCmimi1.Value = 0;
                this.numCmimi1.Value = 0;
                this.LexoIntervale();
            }
            else
            {
                panelIntervale.Visible = false;
                panelDita.Visible = true;
                this.numCmimiDitor.Value = 0;
            }
        }

        private void LexoIntervale()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("LexoIntervaletCmime");
            if (ds.Tables[0].Rows.Count <= 1)
            {
                this.cbNdajNeIntervale.Checked = false;
                this.KonfiguroPerNje();
            }
            else
            {
                int nr = ds.Tables[0].Rows.Count;
                this.KonfiguroPerShume(nr);

                for (int i = 1; i <= nr; i++)
                {
                    foreach (Control c in panelIntervale.Controls)
                    {
                        if ((c is TextBox) && (c.Name.EndsWith(i.ToString())))
                        {
                            TextBox d = c as TextBox;
                            if (d.Name.StartsWith("txtDataFillimi"))
                                d.Text = Convert.ToDateTime(ds.Tables[0].Rows[i - 1]["ORE_FILLIMI"]).ToString("HH : mm");
                            else
                            {
                                d.Text = Convert.ToDateTime(ds.Tables[0].Rows[i - 1]["ORE_MBARIMI"]).ToString("HH : mm");
                            }
                        }
                    }
                }

            }
        }

        private void KonfiguroPerShume(int nr)
        {
            for (int i = 1; i <= nr; i++)
            {
                foreach (Control c in this.panelIntervale.Controls)
                {
                    if (c.Name.EndsWith(i.ToString()))
                    {
                        c.Visible = true;
                        
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

        private void KonfiguroPerNje()
        {
            
            this.lbFillimi2.Visible = false;
            this.lbFillimi3.Visible = false;
            this.lbFillimi4.Visible = false;

            this.txtDataFillimi2.Visible = false;
            this.txtDataFillimi3.Visible= false;
            this.txtDataFillimi4.Visible = false;

            this.txtDataMbarimi2.Visible = false;
            this.txtDataMbarimi3.Visible = false;
            this.txtDataMbarimi4.Visible = false;

            this.numCmimi2.Visible = false;
            this.numCmimi3.Visible = false;
            this.numCmimi4.Visible = false;


        }

      
        private void cmbKategoriaKerkim_ValueChanged(object sender, EventArgs e)
        {
  
            int celesi = Convert.ToInt32(this.cmbKategoriaKerkim.Value);

            //InputController data = new InputController();
            //DataSet ds = data.KerkesaRead("ShfaqArtikujtPerKategori", celesi);
            //this.lstArtikujt.DataSource = ds.Tables[0];
            //this.lstArtikujt.DisplayMember = "EMRI";
            //this.lstArtikujt.ValueMember = "ID_ARTIKULLI";

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqArtikujtPerKategoriPerKonfigurimCmimesh", celesi);

            this.grida.DataSource = ds.Tables[0];



        }

        private void MbushKategorite()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEArtikujve");
            this.cmbKategoriaKerkim.DataSource = ds.Tables[0];
        }

        private void frmKonfigurimCmimeArtikuj_Load(object sender, EventArgs e)
        {
            this.MbushKategorite();
        }


    
        private void btnRuajFurnitor_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;

            int celesi = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);
            if (celesi <= 0)
            {
                return;
            }

            if (KontrolloGabimet() == true)
            {
                return;
            }

            InputController data = new InputController();
            DataSet ds = this.KrijoDataSetCmimet();

            if (this.cbNdajNeIntervale.Checked == false)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr["ORE_FILLIMI"] = Convert.ToDateTime("00:00");
                dr["ORE_MBARIMI"] = Convert.ToDateTime("00:00");
           
                dr["CMIMI"] = Convert.ToDouble(this.numCmimiDitor.Value);

                ds.Tables[0].Rows.Add(dr);
            }
            else
            {
                DateTime oraLast ;

                int nrCmimet = this.GjejNrCmimet();

                if (numCmimi1.Visible == true)
                {
                    DataRow dr1 = ds.Tables[0].NewRow();
                    dr1["ORE_FILLIMI"] = Convert.ToDateTime(this.txtDataFillimi1.Text);
                    dr1["ORE_MBARIMI"] = Convert.ToDateTime(this.txtDataMbarimi1.Text);
                    
                    dr1["CMIMI"] = Convert.ToDouble(this.numCmimi1.Value);

                    ds.Tables[0].Rows.Add(dr1);

                }

                if (numCmimi2.Visible == true)
                {
                    DataRow dr2 = ds.Tables[0].NewRow();
                    dr2["ORE_FILLIMI"] = Convert.ToDateTime(this.txtDataFillimi2.Text);
                    dr2["ORE_MBARIMI"] = Convert.ToDateTime(this.txtDataMbarimi2.Text); 
                    
                    dr2["CMIMI"] = Convert.ToDouble(this.numCmimi2.Value);

                    ds.Tables[0].Rows.Add(dr2);
                }

                if (numCmimi3.Visible == true)
                {
                    DataRow dr3 = ds.Tables[0].NewRow();
                    dr3["ORE_FILLIMI"] = Convert.ToDateTime(this.txtDataFillimi3.Text);
                    dr3["ORE_MBARIMI"] = Convert.ToDateTime(this.txtDataMbarimi3.Text);

                    dr3["CMIMI"] = Convert.ToDouble(this.numCmimi3.Value);

                    ds.Tables[0].Rows.Add(dr3);
                }

                if (numCmimi4.Visible == true)
                {
                    DataRow dr4 = ds.Tables[0].NewRow();
                    dr4["ORE_FILLIMI"] = Convert.ToDateTime(this.txtDataFillimi4.Text);
                    dr4["ORE_MBARIMI"] = Convert.ToDateTime(this.txtDataMbarimi4.Text);
                    
                    dr4["CMIMI"] = Convert.ToDouble(this.numCmimi4.Value);

                    ds.Tables[0].Rows.Add(dr4);
                }

            }

            int b = data.KerkesaUpdate("KrijoCmimePerArtikull", celesi, ds);

            if (b == 0)
            {
                lstArtikujt_SelectedValueChanged(sender, e);
                numCmimi1.Value = 0;
                numCmimi2.Value = 0;
                numCmimi3.Value = 0;
                numCmimi4.Value = 0;
                numCmimiDitor.Value = 0;
                MessageBox.Show(this, "Cmimi për artikullin e zgjedhur u ruajt!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(this, "Një gabim ndodhi gjatë ruajtjes së çmimit për artikullin!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
           

        }

        #region Private Methods

        private DataSet KonvertoDataSetIntervali(DataSet dsIntervali)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("INTERVALI", typeof(string));
            ds.Tables[0].Columns.Add("VLERA", typeof(string));

            ds.Tables[0].AcceptChanges();

            int nr = dsIntervali.Tables[0].Rows.Count;

            int i = 0;

            foreach (DataRow dr in dsIntervali.Tables[0].Rows)
            {
                i = i + 1;
                DataRow drNew = ds.Tables[0].NewRow();

                if (i < nr)
                {
                    drNew["INTERVALI"] = Convert.ToString(dr["ORE_FILLIMI"]) + " --- " + Convert.ToString(dr["ORE_MBARIMI"]);
                    drNew["VLERA"] = Convert.ToString(dr["VLERA"]);
                }
                else
                {
                    drNew["INTERVALI"] = Convert.ToString(dr["ORE_FILLIMI"]) + " --- " + "24:00";
                    drNew["VLERA"] = Convert.ToString(dr["VLERA"]);
                }

                ds.Tables[0].Rows.Add(drNew);
            }

            ds.Tables[0].AcceptChanges();

            return ds;
                
            
        }


        private bool KontrolloGabimet()
        {
            double cmimi = 0;

            if (this.cbNdajNeIntervale.Checked == false)
            {
                cmimi = Convert.ToDouble(this.numCmimiDitor.Value);
                if (cmimi == 0)
                {
                    DialogResult result = MessageBox.Show(this, "Cmimi i artikullit nuk mund te jete 0", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            else
            {
                if (this.numCmimi1.Visible == true)
                {
                    cmimi = Convert.ToDouble(this.numCmimi1.Value);
                    if (cmimi == 0)
                    {
                        DialogResult result = MessageBox.Show(this, "Cmimi i artikullit nuk mund te jete 0", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }

                if (this.numCmimi2.Visible == true)
                {
                    cmimi = Convert.ToDouble(this.numCmimi2.Value);
                    if (cmimi == 0)
                    {
                        DialogResult result = MessageBox.Show(this, "Cmimi i artikullit nuk mund te jete 0", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }

                if (this.numCmimi3.Visible == true)
                {
                    cmimi = Convert.ToDouble(this.numCmimi3.Value);
                    if (cmimi == 0)
                    {
                        DialogResult result = MessageBox.Show(this, "Cmimi i artikullit nuk mund te jete 0", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }

                if (this.numCmimi4.Visible == true)
                {
                    cmimi = Convert.ToDouble(this.numCmimi4.Value);
                    if (cmimi == 0)
                    {
                        DialogResult result = MessageBox.Show(this, "Cmimi i artikullit nuk mund te jete 0", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                }
            }

            return false;
        }

        private DataSet KrijoDataSetCmimet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ORE_FILLIMI", typeof(DateTime));
            ds.Tables[0].Columns.Add("ORE_MBARIMI", typeof(DateTime));
            ds.Tables[0].Columns.Add("CMIMI", typeof(float));

            ds.Tables[0].AcceptChanges();

            return ds;
        }

        private int GjejNrCmimet()
        {
            int nr = 0;

            if (this.txtDataFillimi1.Visible == true)
            {
                nr = nr + 1;
            }

            if (this.txtDataFillimi2.Visible == true)
            {
                nr = nr + 1;
            }

            if (this.txtDataFillimi3.Visible == true)
            {
                nr = nr + 1;
            }

            if (this.txtDataFillimi4.Visible == true)
            {
                nr = nr + 1;
            }

            return nr;
        }

        #endregion

        private void numCmimi4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstArtikujt_SelectedValueChanged(object sender, EventArgs e)
        {
            this.zgjidhArtikull = this.zgjidhArtikull + 1;
            if (this.zgjidhArtikull == 1)
                return;

            int celesi = Convert.ToInt32(this.lstArtikujt.SelectedValue);

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqCmimetPerArtikullin", celesi);

            if (ds == null)
            {
                // mesazh gabimi
            }

            this.gridaArtikujt.DataSource = ds.Tables[0];

            DataSet dsTjeter = data.KerkesaRead("ShfaqCmimetEfunditPerArtikullin", celesi);

            DataSet dsIntervali = this.KonvertoDataSetIntervali(dsTjeter);
            this.gridaCmimet.DataSource = dsIntervali.Tables[0];
        }

        private void gridaCmimet_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void gridaArtikujt_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void panelIntervale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstArtikujt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grida_CurrentCellChanged(object sender, EventArgs e)
        {
            this.zgjidhArtikull = this.zgjidhArtikull + 1;
            if (this.zgjidhArtikull == 1)
                return;

            int indeksi = this.grida.Row;

            int celesi = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqCmimetPerArtikullin", celesi);

            if (ds == null)
            {
                // mesazh gabimi
            }

            this.gridaArtikujt.DataSource = ds.Tables[0];

            DataSet dsTjeter = data.KerkesaRead("ShfaqCmimetEfunditPerArtikullin", celesi);

            DataSet dsIntervali = this.KonvertoDataSetIntervali(dsTjeter);
            this.gridaCmimet.DataSource = dsIntervali.Tables[0];

            panelIntervale.Visible = false;
            panelDita.Visible = true;
            this.numCmimiDitor.Value = 0;

            this.txtIdArtikulli.Text = Convert.ToString(celesi);
        }

        #region Event Handlers
       
        #endregion      

    }
}