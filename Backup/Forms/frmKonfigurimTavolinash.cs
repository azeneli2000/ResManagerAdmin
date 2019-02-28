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
    public partial class frmKonfigurimTavolinash : Form
    {
        /// <summary>
        /// Variabli do te perdoret per te percaktuar nqs
        /// eshte klikuar butoni Para.
        /// </summary>
        private int upDirection = 0;

        #region FormLoad
        public frmKonfigurimTavolinash()
        {
            InitializeComponent();
        }

        private void frmKategoriteTavolina_Load(object sender, EventArgs e)
        {
            this.gridEXTavolinat.BringToFront();
            this.MbushGride();
            this.MbushCombo();
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
        
        /// <summary>
        /// Sherben per te mbushur griden me tavolinat ne restorant
        /// </summary>
        private void MbushGride()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTavolinatDetaje");
            gridEXTavolinat.DataSource = ds.Tables[0];
            ///FormatoGride(gridEXTavolinat);
        }
       
        /// <summary>
        /// Formaton pamjen e grides
        /// </summary>
        /// <param name="grid"></param>
        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.RowCount <= 14)
                grid.RootTable.Columns["PERSHKRIMI"].Width = 181;
            else
                grid.RootTable.Columns["PERSHKRIMI"].Width = 164;
        }
        
        private void Pastro()
        {
            cmbKategorite.Value = null;
            numKapaciteti.Value = 0;
            numEmri.Text = "0";
            numNumerTavolinash.Value = 0;
        }
       
        /// <summary>
        /// Shton nje tavoline ne restorant
        /// </summary>
        /// <returns></returns>
        private int ShtoTavoline()
        {
            
            if (!Convert.IsDBNull(cmbKategorite.Value) && numEmri.Text.Trim() != "" && 
                numKapaciteti.Value != 0 && cmbKategorite.Text != "")
            {
                InputController data = new InputController();
                int idKategoria = Convert.ToInt32(cmbKategorite.Value);
                int b = data.KerkesaUpdate("ShtoTavoline", numEmri.Text,
                    idKategoria, Convert.ToInt32(numKapaciteti.Value));
                if (b == 0)
                {
                    MessageBox.Show(this, "Tavolina e re u shtua.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
                else if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston një tavolinë me këtë emër.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
                else
                {
                    MessageBox.Show(this, "Tavolina e re nuk u shtua. Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            }
            else 
                return 1;
        }

        private int ShtoDisaTavolina()
        {
            if (!Convert.IsDBNull(cmbKategorite.Value) && this.numNumerTavolinash.Value != 0 &&
                numKapaciteti.Value != 0 && cmbKategorite.Text != "")
            {
                int idKategoria = Convert.ToInt32(cmbKategorite.Value);
                InputController data = new InputController();
                DataSet dsResult = data.KerkesaRead("ShtoDisaTavolina", Convert.ToInt32(numNumerTavolinash.Value),
                    idKategoria, Convert.ToInt32(numNumerTavolinash.Value));
                if (dsResult.Tables[0].Rows.Count != 0)
                {
                    string s = "Tavolinat e mëposhtme u shtuan në restorant:";
                    int i = 1;
                    foreach (DataRow dr in dsResult.Tables[0].Rows)
                    {
                        s += Environment.NewLine + i + ". " + dr["EMRI"].ToString();
                        i++;
                    }
                    MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }
                else
                {
                    MessageBox.Show(this, "Asnjë tavolinë nuk u shtua. Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
            }
            else return 1;
        }

        public int ModifikoTavoline()
        {
            if (!Convert.IsDBNull(cmbKategorite.Value) && numEmri.Text.Trim() != "" &&
                numKapaciteti.Value != 0 && cmbKategorite.Text != "")
            {
                InputController data = new InputController();
                int index = gridEXTavolinat.Row;
                //nqs tavolina eshte e zene ose e rezervuar atehere kapaciteti i tavolines nuk 
                //mund te zvogelohet
                if ((gridEXTavolinat.GetRow(index).Cells["GJENDJA"].Text != "L") &&
                    (Convert.ToInt32(numKapaciteti.Value) < 
                    Convert.ToInt32(gridEXTavolinat.GetRow(index).Cells["KAPACITETI"].Text)))
                {
                    MessageBox.Show(this, "Tavolina e zgjedhur figuron e zënë ose e rezervuar." + 
                        Environment.NewLine + "Nuk mund të zvogëloni kapacitetin e saj!", this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return 1;
                }
                else if ((gridEXTavolinat.GetRow(index).Cells["GJENDJA"].Text != "L") &&
                    (this.numEmri.Text !=
                    gridEXTavolinat.GetRow(index).Cells["EMRI"].Text))
                {
                    MessageBox.Show(this, "Tavolina e zgjedhur figuron e zënë ose e rezervuar." +
                        Environment.NewLine + "Nuk mund të ndryshoni emërtimin e saj!", this.Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return 1;
                }
                //pnd bejme modifikimet perkatese
                else
                {
                    int idTavolina = Convert.ToInt32(gridEXTavolinat.GetRow(index).Cells["ID_TAVOLINA"].Text);
                    string  emri = numEmri.Text;
                    int idKategoria = Convert.ToInt32(cmbKategorite.Value);
                    int kapaciteti = Convert.ToInt32(numKapaciteti.Value);
                    int b = data.KerkesaUpdate("ModifikoTavoline", idTavolina, emri, idKategoria, kapaciteti);
                    if (b == 2)
                    {
                        MessageBox.Show(this, "Ekziston një tavolinë me këtë emër.", this.Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return 1;
                    }
                    else if (b == 0)
                    {
                        MessageBox.Show(this, "Tavolina e zgjedhur u modifikua.", this.Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return 0;
                    }
                    else
                    {
                        MessageBox.Show(this, "Tavolina e zgjedhur nuk u modifikua. Provoni përsëri!", this.Text, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return 1;
                    }
                }
            }
            else return 1;
        }

        private void MbushCombo()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteETavolinave");
            cmbKategorite.DataSource = ds.Tables[0];
        }
        
        /// <summary>
        /// Vendos ne numericBox numrin pasues per tavolinen e re qe do shtohet
        /// </summary>
        //private void InicializoNrTavoline()
        //{
        //    InputController data = new InputController();
        //    DataSet dsFundit = data.KerkesaRead("ShfaqTavolinenMeNumerMeTeMadh");
        //    if (Convert.IsDBNull(dsFundit.Tables[0].Rows[0][0]))
        //    {
        //        numEmri.Value = 1;
        //    }
        //    else
        //    {
        //        numEmri.Text = Convert.ToInt32(dsFundit.Tables[0].Rows[0][0]) + 1;
        //    }
        //}

        private void Kerko(string tekst)
        {
            Janus.Windows.GridEX.ConditionOperator operatori = new Janus.Windows.GridEX.ConditionOperator();
            operatori = Janus.Windows.GridEX.ConditionOperator.BeginsWith;
            Janus.Windows.GridEX.GridEXFilterCondition kusht = new
                Janus.Windows.GridEX.GridEXFilterCondition(gridEXTavolinat.RootTable.Columns["EMRI"], operatori, tekst);
            gridEXTavolinat.Find(kusht, 0, 1);
        }

        #endregion 

        #region Event Handlers
        private void btnShto_Click(object sender, EventArgs e)
        {
            this.lblGabimi.Visible = false;

            this.gridEXTavolinat.Visible = false;
            lblNrTavolinash.Text = "Tavolina nr";
            numNumerTavolinash.Visible = false;
            numEmri.Visible = true;

            this.uiTab.Visible = true;
            this.CaktivizoPanel(panelTop);
            this.CaktivizoPanel(panelBottom);
            this.uiTabPage.Text = "Shtim";
            this.uiTabPage.Image = ResManagerAdmin.Properties.Resources.news_info;
            numKapaciteti.Value = 0;
            cmbKategorite.Value = null;
            cmbKategorite.Text = "";
            numEmri.Clear();
        }

        private void btnShtoDisa_Click(object sender, EventArgs e)
        {
            this.lblGabimi.Visible = false;

            this.gridEXTavolinat.Visible = false;
            this.uiTab.Visible = true;
            this.CaktivizoPanel(panelTop);
            this.CaktivizoPanel(panelBottom);
            this.lblNrTavolinash.Text = "Numri i tavolinave";
            numNumerTavolinash.Visible = true;
            numEmri.Visible = false;
            this.uiTabPage.Text = "Shtim disa";
            this.uiTabPage.Image = ResManagerAdmin.Properties.Resources.new_disa;
        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            this.lblGabimi.Visible = false;

            int index = this.gridEXTavolinat.Row;
            if ((index >= 0) && (gridEXTavolinat.GetRow(index).Cells["EMRI"].Text != ""))
            {
                this.lblGabimi.Visible = false;
                numEmri.Text = gridEXTavolinat.GetRow(index).Cells["EMRI"].Text;
                numKapaciteti.Value = Convert.ToInt32(gridEXTavolinat.GetRow(index).Cells["KAPACITETI"].Text);
                cmbKategorite.Value = Convert.ToInt32(gridEXTavolinat.GetRow(index).Cells["ID_KATEGORIATAVOLINA"].Text);
                this.gridEXTavolinat.Visible = false;
                lblNrTavolinash.Text = "Tavolina nr";
                numNumerTavolinash.Visible = false;
                numEmri.Visible = true;
                this.uiTab.Visible = true;
                this.CaktivizoPanel(panelTop);
                this.uiTabPage.Text = "Modifikim";
                this.uiTabPage.Image = ResManagerAdmin.Properties.Resources.forum_newmsg;
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            //error.SetError(nu)
            if (numEmri.Text.Trim() == "")
            {

                this.lblGabimi.Text = "Kujdes !  Numri i tavolines nuk mund te jete bosh !!!";
                this.lblGabimi.Visible = true;
                return;
            }

            int r = 1;
            if (uiTabPage.Text == "Shtim")
            {
                r = this.ShtoTavoline();
            }
            else if (uiTabPage.Text == "Shtim disa")
            {
                r = this.ShtoDisaTavolina();
            }
            else if (uiTabPage.Text == "Modifikim")
            {
                r = this.ModifikoTavoline();
            }
            if (r == 0)
            {
                this.gridEXTavolinat.Visible = true;
                this.uiTab.Visible = false;
                this.AktivizoPanel(panelTop);
                this.AktivizoPanel(panelBottom);
                this.lblNrTavolinash.Text = "Tavolina nr:";
                this.MbushGride();
                this.Pastro();
            }
        }

        private void btnRuajKrijo_Click(object sender, EventArgs e)
        {
            if (numEmri.Text.Trim() == "")
            {
                this.lblGabimi.Text = "Kujdes !  Numri i tavolines nuk mund te jete 0 !!!";
                this.lblGabimi.Visible = true;
                return;
            }

            int r = 1;
            if (uiTabPage.Text == "Shtim")
            {
                r = this.ShtoTavoline();
            }
            else if (uiTabPage.Text == "Shtim disa")
            {
                r = this.ShtoDisaTavolina();
            }
            else if (uiTabPage.Text == "Modifikim")
            {
                r = this.ModifikoTavoline();
            }
            if (r == 0)
            {
                this.MbushGride();
                this.Pastro();
                if (uiTabPage.Text == "Modifikim")
                {
                    uiTabPage.Text = "Shtim";
                    uiTabPage.Image = ResManagerAdmin.Properties.Resources.news_info;
                    CaktivizoPanel(panelBottom);
                }
            }
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.Pastro();
            this.gridEXTavolinat.Visible = true;
            this.uiTab.Visible = false;
            this.AktivizoPanel(panelTop);
            this.AktivizoPanel(panelBottom);
            this.lblNrTavolinash.Text = "Tavolina nr:";
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Forms.frmKerko frm = new frmKerko();
            frm.ShowDialog();
            string tekst = frm.txtKerkim.Text;
            Kerko(tekst);
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            gridEXTavolinat.ExpandGroups();
            if (gridEXTavolinat.RowCount > 0)
            {
                gridEXTavolinat.Row = 0;
            }
        }

        private void btnFundit_Click(object sender, EventArgs e)
        {
            gridEXTavolinat.ExpandGroups();
            if ((gridEXTavolinat.RowCount > 0)&&(gridEXTavolinat.RowCount - 1 >= 0))
            {
                gridEXTavolinat.Row = gridEXTavolinat.RowCount - 1;
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            upDirection = 1;
            gridEXTavolinat.ExpandGroups();
            if ((gridEXTavolinat.Row >= 1) && (gridEXTavolinat.Row - 1 >= 0))
            {
                gridEXTavolinat.Row = gridEXTavolinat.Row - 1;
            }
        }

        private void btnPAs_Click(object sender, EventArgs e)
        {
            gridEXTavolinat.ExpandGroups();
            if ((gridEXTavolinat.Row <= gridEXTavolinat.RowCount - 2) && (gridEXTavolinat.Row + 1 >= 0))
            {
                gridEXTavolinat.Row = gridEXTavolinat.Row + 1;
            }
        }


        private void gridEXTavolinat_CurrentCellChanged(object sender, EventArgs e)
        {
            int index = this.gridEXTavolinat.Row;
            if ((index >= 0)&& (gridEXTavolinat.GetRow(index).Cells["ID_TAVOLINA"].Text != ""))
            {
                numEmri.Text = gridEXTavolinat.GetRow(index).Cells["EMRI"].Text;
                numKapaciteti.Value = Convert.ToInt32(gridEXTavolinat.GetRow(index).Cells["KAPACITETI"].Text);
                cmbKategorite.Value = Convert.ToInt32(gridEXTavolinat.GetRow(index).Cells["ID_KATEGORIATAVOLINA"].Text);
            }
            else
            {
                if ((index > 0) && (upDirection == 1))
                {
                    gridEXTavolinat.Row = index - 1;
                    upDirection = 0;
                    return;
                }
                if ((gridEXTavolinat.RowCount > index + 1)&& (index + 1 >= 0))
                {
                    gridEXTavolinat.Row = index + 1;
                    return;
                }
            }
        }
        private void btnFshi_Click(object sender, EventArgs e)
        {
            DataSet dsId = new DataSet();
            dsId.Tables.Add();
            dsId.Tables[0].Columns.Add("ID_TAVOLINA", typeof(Int32));
            dsId.Tables[0].Columns.Add("EMRI", typeof(Int32));
            dsId.AcceptChanges();
            for (int i = 0; i < gridEXTavolinat.RowCount; i++)
            {
                if (gridEXTavolinat.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    DataRow r = dsId.Tables[0].NewRow();
                    r["ID_TAVOLINA"] = Convert.ToInt32(gridEXTavolinat.GetRow(i).Cells["ID_TAVOLINA"].Text);
                    r["EMRI"] = gridEXTavolinat.GetRow(i).Cells["EMRI"].Text;
                    dsId.Tables[0].Rows.Add(r);
                }
            }
            dsId.AcceptChanges();
            if (dsId.Tables[0].Rows.Count != 0)
            {
                InputController data = new InputController();
                DataSet dsError = data.KerkesaRead("FshiTavolinat", dsId);
                if (Convert.IsDBNull(dsError))
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së tavolinave!" + Environment.NewLine +
                        "Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //jane fshire te gjitha tavolinat dhe gjate fshirjes
                //nuk ka patur konflikte
                if (dsError.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(this, "Tavolinat e zgjedhura u fshinë." + Environment.NewLine + "Referenca në faturat që i përkasin" +
                        Environment.NewLine + "këtyre tavolinave nuk është më e vlefshme!",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string s = "Tavolinat e mëposhtme nuk u fshinë";
                    s += Environment.NewLine + "sepse gjendja e tyre figuron e zënë ose e rezervuar.";
                    int i = 1;
                    foreach (DataRow dr in dsError.Tables[0].Rows)
                    {
                        s += Environment.NewLine + i + ". " + dr["EMRI"].ToString();
                        i++;
                    }
                    MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.MbushGride();
            }
        }
        #endregion      
     }
}