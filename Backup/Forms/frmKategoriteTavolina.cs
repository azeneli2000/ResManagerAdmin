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
    public partial class frmKategoriteTavolina : Form
    {
        #region FormLoad
        public frmKategoriteTavolina()
        {
            InitializeComponent();
        }

        private void frmKategoriteTavolina_Load(object sender, EventArgs e)
        {
            this.gridEXKategorite.BringToFront();
            this.MbushGride();
             
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
        /// Ben mbushjen e grides me kategorite e tavolinave
        /// </summary>
        private void MbushGride()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteETavolinave");
            gridEXKategorite.DataSource = ds.Tables[0];
            //FormatoGride(gridEXKategorite);
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.RowCount <= 14)
                grid.RootTable.Columns["PERSHKRIMI"].Width = 293;
            else
                grid.RootTable.Columns["PERSHKRIMI"].Width = 276;
           }
        #endregion 

        #region Event Handlers
        private void btnShto_Click(object sender, EventArgs e)
        {
            txtEmri.Clear();
            this.lblGabimi.Visible = false;
            this.uiTabPage.Text = "Shtim";
            this.uiTabPage.Image = ResManagerAdmin.Properties.Resources.news_info;
            this.gridEXKategorite.Visible = false;
            this.uiTab.Visible = true;
            this.CaktivizoPanel(panelTop);
            this.CaktivizoPanel(panelBottom);

        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            int index = gridEXKategorite.Row;
            if (index >= 0)
            {
                this.lblGabimi.Visible = false;
                txtEmri.Text = gridEXKategorite.GetRow(index).Cells["PERSHKRIMI"].Text;
                this.uiTabPage.Text = "Modifikim";
                this.uiTabPage.Image = ResManagerAdmin.Properties.Resources.forum_newmsg;
                this.gridEXKategorite.Visible = false;
                this.uiTab.Visible = true;
                this.CaktivizoPanel(panelTop);
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            if (this.txtEmri.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te jepni emrin e kategorise !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtEmri.Text != "")
            {
                int b;
                InputController data = new InputController();
                //ne varesi te veprimit te zgjedhur behet shtimi i nje kategorie te re ose
                //modifikimi i kategorise se zgjedhur
                if (uiTabPage.Text == "Shtim")
                {
                    b = data.KerkesaUpdate("ShtoKategoriTavolinash", txtEmri.Text);
                    if (b == 0)
                    {
                        MessageBox.Show(this, "Kategoria e re e tavolinave u shtua.", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.MbushGride();
                    }
                    else if (b == 2)
                    {
                        MessageBox.Show(this, "Ekziston një kategori tavolinash me këtë emër.", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this, "Kategoria e re e tavolinave nuk u shtua. Provoni përsëri!", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (uiTabPage.Text == "Modifikim")
                {
                    int index = gridEXKategorite.Row;
                    int idKategoria = Convert.ToInt32(gridEXKategorite.GetRow(index).Cells["ID_KATEGORIATAVOLINA"].Text);
                    b = data.KerkesaUpdate("ModifikoKategoriTavoline", idKategoria, this.txtEmri.Text);
                    if (b == 0)
                    {
                        MessageBox.Show(this, "Kategoria e zgjedhur e tavolinave u modifikua.", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.MbushGride();
                    }
                    else if (b == 2)
                    {
                        MessageBox.Show(this, "Ekziston një kategori tavolinash me këtë emër.", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this, "Kategoria e zgjedhur e tavolinave nuk u modifikua. Provoni përsëri!", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                this.txtEmri.Clear();
                this.gridEXKategorite.Visible = true;
                this.uiTab.Visible = false;
                this.AktivizoPanel(panelTop);
                this.AktivizoPanel(panelBottom);
            }
        }

        private void btnRuajKrijo_Click(object sender, EventArgs e)
        {
            
            if (this.txtEmri.Text.Trim() == "")
            {
                this.lblGabimi.Text = "Kujdes !   Ju duhet te vendosni emrin e kategorise !!!";
                this.lblGabimi.Visible = true;
                return;
            }

            if (txtEmri.Text != "")
            {
                InputController data = new InputController();
                int b;
                if (uiTabPage.Text == "Shtim")
                {
                    b = data.KerkesaUpdate("ShtoKategoriTavolinash", txtEmri.Text);
                    if (b == 0)
                    {
                        MessageBox.Show(this, "Kategoria e re e tavolinave u shtua.", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.MbushGride();
                    }
                    else if (b == 2)
                    {
                        MessageBox.Show(this, "Ekziston një kategori tavolinash me këtë emër.", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this, "Kategoria e re e tavolinave nuk u shtua. Provoni përsëri!", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (uiTabPage.Text == "Modifikim")
                {
                    int index = gridEXKategorite.Row;
                    int idKategoria = Convert.ToInt32(gridEXKategorite.GetRow(index).Cells["ID_KATEGORIATAVOLINA"].Text);
                    b = data.KerkesaUpdate("ModifikoKategoriTavoline", idKategoria, this.txtEmri.Text);
                    if (b == 0)
                    {
                        MessageBox.Show(this, "Kategoria e zgjedhur e tavolinave u modifikua.", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.MbushGride();
                    }
                    else if (b == 2)
                    {
                        MessageBox.Show(this, "Ekziston një kategori tavolinash me këtë emër.", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this, "Kategoria e zgjedhur e tavolinave nuk u modifikua. Provoni përsëri!", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                this.txtEmri.Clear();
                this.lblGabimi.Visible = false;
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
            this.txtEmri.Clear();
            this.gridEXKategorite.Visible = true;
            this.uiTab.Visible = false;
            this.AktivizoPanel(panelTop);
            this.AktivizoPanel(panelBottom);
        }     

        private void gridEXKategorite_CurrentCellChanged(object sender, EventArgs e)
        {
            int index = gridEXKategorite.Row;
            txtEmri.Text = gridEXKategorite.GetRow(index).Cells["PERSHKRIMI"].Text;
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            if (gridEXKategorite.RowCount > 0)
            {
                gridEXKategorite.Row = 0;
            }
        }

        private void btnFundit_Click(object sender, EventArgs e)
        {
            if ((gridEXKategorite.RowCount > 0) && (gridEXKategorite.RowCount - 1 >= 0))
            {
                gridEXKategorite.Row = gridEXKategorite.RowCount - 1;
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            if ((gridEXKategorite.Row >= 1) && (gridEXKategorite.Row - 1 >= 0))
            {
                gridEXKategorite.Row = gridEXKategorite.Row - 1;
            }
        }

        private void btnPAs_Click(object sender, EventArgs e)
        {
            if ((gridEXKategorite.Row <= gridEXKategorite.RowCount - 2) && (gridEXKategorite.Row + 1 >= 0))
            {
                gridEXKategorite.Row = gridEXKategorite.Row + 1;
            }
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            DataSet dsId = new DataSet();
            dsId.Tables.Add();
            dsId.Tables[0].Columns.Add("ID_KATEGORIATAVOLINA", typeof(Int32));
            dsId.Tables[0].Columns.Add("PERSHKRIMI", typeof(String));
            dsId.AcceptChanges();
            for (int i = 0; i < gridEXKategorite.RowCount; i++)
            {
                if (gridEXKategorite.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    DataRow r = dsId.Tables[0].NewRow();
                    r["ID_KATEGORIATAVOLINA"] = Convert.ToInt32(gridEXKategorite.GetRow(i).Cells["ID_KATEGORIATAVOLINA"].Text);
                    r["PERSHKRIMI"] = gridEXKategorite.GetRow(i).Cells["PERSHKRIMI"].Text;
                    dsId.Tables[0].Rows.Add(r);
                }
            }
            dsId.AcceptChanges();
            if (dsId.Tables[0].Rows.Count != 0)
            {
                InputController data = new InputController();
                DataSet dsError = data.KerkesaRead("FshiKategoriteETavolinave", dsId);
                if (Convert.IsDBNull(dsError))
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së kategorive të tavolinave!" + Environment.NewLine + 
                        "Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //jane fshire te gjitha kategorite dhe gjate fshirjes
                //nuk ka patur konflikte
                if (dsError.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(this, "Kategoritë e zgjedhura të tavolinave u fshinë.",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string s = "Kategoritë e mëposhtme të tavolinave nuk u fshinë";
                    s += Environment.NewLine + "sepse ka ende tavolina që i përkasin këtyre kategorive.";
                    int i = 1;
                    foreach (DataRow dr in dsError.Tables[0].Rows)
                    {
                        s += Environment.NewLine + i + ". " + dr["PERSHKRIMI"].ToString();
                        i++;
                    }
                    MessageBox.Show(this, s, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.MbushGride();
            }
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            Forms.frmKerko frm = new frmKerko();
            frm.ShowDialog();
            string tekst = frm.txtKerkim.Text;
            Janus.Windows.GridEX.ConditionOperator operatori = new Janus.Windows.GridEX.ConditionOperator();
            operatori = Janus.Windows.GridEX.ConditionOperator.BeginsWith;
            Janus.Windows.GridEX.GridEXFilterCondition kusht = new 
                Janus.Windows.GridEX.GridEXFilterCondition(gridEXKategorite.RootTable.Columns["PERSHKRIMI"], operatori, tekst);
            gridEXKategorite.Find(kusht, 0, -1);
        }

        #endregion

    }
}