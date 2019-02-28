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
    public partial class frmKonfigurimCmimeReceta : Form
    {
        private int zgjidhArtikull = 0;
        private int idZgjedhur = 0;

        #region FormLoad

        public frmKonfigurimCmimeReceta()
        {
            InitializeComponent();
        }

        private void frmKonfigurimCmimeArtikuj_Load(object sender, EventArgs e)
        {
            this.MbushKategorite();
            LexoInformacione();
            cmbKategoriaKerkim.Value = null;
            cmbKategoriaKerkim.Text = "";
        }
        #endregion

        #region Private Methods
        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
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
            this.txtDataFillimi3.Visible = false;
            this.txtDataFillimi4.Visible = false;

            this.txtDataMbarimi2.Visible = false;
            this.txtDataMbarimi3.Visible = false;
            this.txtDataMbarimi4.Visible = false;

            this.numCmimi2.Visible = false;
            this.numCmimi3.Visible = false;
            this.numCmimi4.Visible = false;


        }

        private DataSet KonvertoDataSetIntervali(DataSet dsIntervali)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("INTERVALI", typeof(string));
            ds.Tables[0].Columns.Add("VLERA", typeof(string));

            ds.Tables[0].AcceptChanges();

            foreach (DataRow dr in dsIntervali.Tables[0].Rows)
            {
                DataRow drNew = ds.Tables[0].NewRow();

                drNew["INTERVALI"] = Convert.ToString(dr["ORE_FILLIMI"]) + " --- " + Convert.ToString(dr["ORE_MBARIMI"]);
                drNew["VLERA"] = Convert.ToString(dr["VLERA"]);

                ds.Tables[0].Rows.Add(drNew);
            }

            ds.Tables[0].AcceptChanges();

            return ds;


        }

        private bool KontrolloGabimet()
        {
            double cmimi = 0;
            error1.SetError(numCmimiDitor, "");
            error1.SetError(numCmimi1, "");
            error1.SetError(numCmimi2, "");
            error1.SetError(numCmimi3, "");
            error1.SetError(numCmimi4, "");
            if (this.cbNdajNeIntervale.Checked == false)
            {
                cmimi = Convert.ToDouble(this.numCmimiDitor.Value);
                if (cmimi == 0)
                {
                    error1.SetError(numCmimiDitor, "Cmimi i recetës nuk mund te jetë 0");
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
                        error1.SetError(numCmimi1, "Cmimi i recetës nuk mund te jetë 0");
                        return true;
                    }
                }

                if (this.numCmimi2.Visible == true)
                {
                    cmimi = Convert.ToDouble(this.numCmimi2.Value);
                    if (cmimi == 0)
                    {
                        error1.SetError(numCmimi2, "Cmimi i recetës nuk mund te jetë 0");
                        return true;
                    }
                }

                if (this.numCmimi3.Visible == true)
                {
                    cmimi = Convert.ToDouble(this.numCmimi3.Value);
                    if (cmimi == 0)
                    {
                        error1.SetError(numCmimi3, "Cmimi i recetës nuk mund te jetë 0");
                        return true;
                    }
                }

                if (this.numCmimi4.Visible == true)
                {
                    cmimi = Convert.ToDouble(this.numCmimi4.Value);
                    if (cmimi == 0)
                    {
                        error1.SetError(numCmimi4, "Cmimi i recetës nuk mund te jetë 0");
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
            ds.Tables[0].Columns.Add("CMIMI", typeof(Double));
            ds.Tables[0].AcceptChanges();
            return ds;
        }

        private void MbushKategorite()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteERecetave");
            this.cmbKategoriaKerkim.DataSource = ds.Tables[0];
        }
        #endregion

        #region Event Handlers
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
                this.numCmimi2.Value = 0;
                this.numCmimi3.Value = 0;
                this.numCmimi4.Value = 0;
                this.LexoIntervale();
            }
            else
            {
                panelIntervale.Visible = false;
                panelDita.Visible = true;
                this.numCmimiDitor.Value = 0;
            }
        }

        private void cmbKategoriaKerkim_ValueChanged(object sender, EventArgs e)
        {
            error1.SetError(numCmimiDitor, "");
            error1.SetError(numCmimi1, "");
            error1.SetError(numCmimi2, "");
            error1.SetError(numCmimi3, "");
            error1.SetError(numCmimi4, "");
            int celesi = Convert.ToInt32(this.cmbKategoriaKerkim.Value);
            InputController data = new InputController();

            //DataSet ds = data.KerkesaRead("ShfaqRecetatPerKategori", celesi);
            //this.lstRecetat.DataSource = ds.Tables[0];
            //gridTeGjitha.DataSource = null;
            //gridKorrent.DataSource = null;
            //idZgjedhur = 0;

            DataSet ds = data.KerkesaRead("ShfaqRecetatPerKategoriKonfigurimCmimesh", celesi);
            this.grida.DataSource = ds.Tables[0];

        }

        private void btnRuajFurnitor_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;
            if (indeksi < 0)
            {
                return;
            }


            if (gridTeGjitha.RowCount > 0)
            {
                //cmimi i reetes nuk mund te ndryshohet brenda nje intervali kohe prej 1minute
                DateTime dtFundit = Convert.ToDateTime(gridTeGjitha.GetRow(gridTeGjitha.RowCount - 1).Cells["DATE_FILLIMI"].Text);
                if (dtFundit.Minute == DateTime.Now.Minute && dtFundit.Hour == DateTime.Now.Hour && dtFundit.Date == DateTime.Now.Date)
                {
                    MessageBox.Show(this, "Nuk mund të modifikoni çmimin e recetës dy herë brenda një intervali të shkurtër kohe." + Environment.NewLine
                         + "Provoni pak momente më vonë!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //cmimi i recetes nuk mund te modifikohet nqs data tani eshte me e vogel se data e ndonje periudhe te konfiguruar
                //me pare. Nje gje e tille mund te ndodhe ne rast se i eshte nderruar ora sistemit dhe i eshte 
                //vendosur me vogel se ora e meparshme
                if (DateTime.Now < dtFundit)
                {
                    MessageBox.Show(this, "Ka një problem me mospërputhjen e datave të periudhave për çmimet!" + Environment.NewLine + 
                        "Data/Ora tani është më e vogël se Data/Ora e periudhës më të fundit të konfiguruar për recetën!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            int idReceta = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);
            if (idReceta <= 0)
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
                DateTime oraLast;

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

            int b = data.KerkesaUpdate("KrijoCmimePerRecete", idReceta, ds);
            if (b == 0)
            {
                lstArtikujt_SelectedValueChanged(sender, e);
                numCmimi1.Value = 0;
                numCmimi2.Value = 0;
                numCmimi3.Value = 0;
                numCmimi4.Value = 0;
                numCmimiDitor.Value = 0;
                MessageBox.Show(this,"Cmimi për recetën e zgjedhur u ruajt!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(this, "Një gabim ndodhi gjatë ruajtjes së çmimit për recetën!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void numCmimi4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstArtikujt_SelectedValueChanged(object sender, EventArgs e)
        {
            //error1.SetError(numCmimiDitor, "");
            //error1.SetError(numCmimi1, "");
            //error1.SetError(numCmimi2, "");
            //error1.SetError(numCmimi3, "");
            //error1.SetError(numCmimi4, "");
            //if (!Convert.IsDBNull(lstRecetat.SelectedValue))
            //{
            //    int idReceta = Convert.ToInt32(lstRecetat.SelectedValue);
            //    idZgjedhur = idReceta;
            //    InputController data = new InputController();
            //    dsCmimi = data.KerkesaRead("LexoCmimetPerReceten", idReceta);
            //    //Tabela e pare mban te gjithe historikun e cmimeve per receten
            //    gridTeGjitha.DataSource = dsCmimi.Tables[0];
            //    //Tabela e dyte mban vetem cmimin korrent sipas intervaleve
            //    gridKorrent.DataSource = dsCmimi.Tables[1];
            //}
            
        }
        #endregion      

        private void grida_CurrentCellChanged(object sender, EventArgs e)
        {
            error1.SetError(numCmimiDitor, "");
            error1.SetError(numCmimi1, "");
            error1.SetError(numCmimi2, "");
            error1.SetError(numCmimi3, "");
            error1.SetError(numCmimi4, "");
            if (!Convert.IsDBNull(lstRecetat.SelectedValue))
            {
                int indeksi = this.grida.Row;
                int idReceta = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);
                idZgjedhur = idReceta;
                InputController data = new InputController();
                dsCmimi = data.KerkesaRead("LexoCmimetPerReceten", idReceta);
                //Tabela e pare mban te gjithe historikun e cmimeve per receten
                gridTeGjitha.DataSource = dsCmimi.Tables[0];
                //Tabela e dyte mban vetem cmimin korrent sipas intervaleve
                gridKorrent.DataSource = dsCmimi.Tables[1];
            }
        }

    }
}