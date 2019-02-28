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
    public partial class frmNjesiteMatese : Form
    {
        #region FormLoad
        public frmNjesiteMatese()
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
        /// Ben formatimin e grides ne varesi te numrit te rreshtave
        /// </summary>
        /// <param name="grid"></param>
        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.RowCount <= 14)
                grid.RootTable.Columns["NJESIA"].Width = 293;
            else
                grid.RootTable.Columns["NJESIA"].Width = 276;
        }

        /// <summary>
        /// Mbush griden me njesite matese
        /// </summary>
        private void MbushGride()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqNjesiteMatese");
            gridEXKategorite.DataSource = ds.Tables[0];
            //FormatoGride(gridEXKategorite);
        }

        private int ShtoNjesi()
        {
            if (txtEmri.Text != "")
            {
                InputController data = new InputController();
                int b = data.KerkesaUpdate("ShtoNjesi", txtEmri.Text);
                if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston një njësi matëse me këtë emër!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
                else if (b == 1)
                {
                    MessageBox.Show(this, "Njësia e re e matëse nuk u shtua. Provoni përsëri!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
                else if (b == 0)
                {
                    //MessageBox.Show(this, "Njësia e re e matëse u shtua.", this.Text, MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    return 0;
                }
                else return 1;
            }
            else return 1;
        }

        private int ModifikoNjesi()
        {
            if (txtEmri.Text != "")
            {
                InputController data = new InputController();
                int index = gridEXKategorite.Row;
                int idKategoria = Convert.ToInt32(gridEXKategorite.GetRow(index).Cells["ID_NJESIA"].Text);
                int b = data.KerkesaUpdate("ModifikoNjesi", idKategoria, txtEmri.Text);
                if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston një njësi matëse me këtë emër!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
                else if (b == 1)
                {
                    MessageBox.Show(this, "Njësia matëse e zgjedhur nuk u modifikua. Provoni përsëri!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
                else if (b == 0)
                {
                    //MessageBox.Show(this, "Njësia matëse e zgjedhur u modifikua.", this.Text, MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    return 0;
                }
                else return 1;
            }
            else return 1;
        }
        #endregion 

        #region Event Handlers
        private void btnShto_Click(object sender, EventArgs e)
        {
            this.txtEmri.Clear();
            this.gridEXKategorite.Visible = false;
            this.uiTab.Visible = true;
            uiTabPage.Text = "Shtim";
            uiTabPage.Image = ResManagerAdmin.Properties.Resources.news_info;
            this.CaktivizoPanel(panelTop);
            this.CaktivizoPanel(panelBottom);
        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            int index = gridEXKategorite.Row;
            if (index >= 0)
            {
                txtEmri.Text = gridEXKategorite.GetRow(index).Cells["NJESIA"].Text;
                this.gridEXKategorite.Visible = false;
                uiTabPage.Text = "Modifikim";
                uiTabPage.Image = ResManagerAdmin.Properties.Resources.forum_newmsg;
                this.uiTab.Visible = true;
                this.CaktivizoPanel(panelTop);
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            int r = 1;
            if (uiTabPage.Text == "Shtim")
            {
                r = this.ShtoNjesi();
            }
            else if (uiTabPage.Text == "Modifikim")
            {
                r = this.ModifikoNjesi();
            }
            if (r == 0)
            {
                this.gridEXKategorite.Visible = true;
                this.uiTab.Visible = false;
                this.AktivizoPanel(panelTop);
                this.AktivizoPanel(panelBottom);
                this.MbushGride();
                txtEmri.Clear();
            }
        }

        private void btnRuajKrijo_Click(object sender, EventArgs e)
        {
            int r = 1;
            if (uiTabPage.Text == "Shtim")
            {
                r = this.ShtoNjesi();
            }
            else if (uiTabPage.Text == "Modifikim")
            {
                r = this.ModifikoNjesi();
            }
            if (r == 0)
            {
                this.MbushGride();
                txtEmri.Clear();
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
            this.gridEXKategorite.Visible = true;
            this.uiTab.Visible = false;
            this.AktivizoPanel(panelTop);
            this.AktivizoPanel(panelBottom);
            txtEmri.Clear();
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            DataSet dsId = new DataSet();
            dsId.Tables.Add();
            dsId.Tables[0].Columns.Add("ID_NJESIA", typeof(Int32));
            dsId.Tables[0].Columns.Add("NJESIA", typeof(String));
            dsId.AcceptChanges();
            for (int i = 0; i < gridEXKategorite.RowCount; i++)
            {
                if (gridEXKategorite.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    DataRow r = dsId.Tables[0].NewRow();
                    r["ID_NJESIA"] = Convert.ToInt32(gridEXKategorite.GetRow(i).Cells["ID_NJESIA"].Text);
                    r["NJESIA"] = gridEXKategorite.GetRow(i).Cells["NJESIA"].Text;
                    dsId.Tables[0].Rows.Add(r);
                }
            }
            dsId.AcceptChanges();
            if (dsId.Tables[0].Rows.Count != 0)
            {
                InputController data = new InputController();
                DataSet dsError = data.KerkesaRead("FshiNjesite", dsId);
                if (Convert.IsDBNull(dsError))
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së njësive matëse!" + Environment.NewLine +
                        "Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //jane fshire te gjitha kategorite dhe gjate fshirjes
                //nuk ka patur konflikte
                if (dsError.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(this, "Njësitë matëse të zgjedhura u fshinë.",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string s = "Njësitë matëse të mëposhtme nuk u fshinë";
                    s += Environment.NewLine + "sepse ka ende artikuj që kanë këto njëi matëse.";
                    int i = 1;
                    foreach (DataRow dr in dsError.Tables[0].Rows)
                    {
                        s += Environment.NewLine + i + ". " + dr["NJESIA"].ToString();
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
                Janus.Windows.GridEX.GridEXFilterCondition(gridEXKategorite.RootTable.Columns["NJESIA"], operatori, tekst);
            gridEXKategorite.Find(kusht, 0, -1);
        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            if (gridEXKategorite.RowCount > 0)
            {
                gridEXKategorite.Row = 0;
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

        private void btnFundit_Click(object sender, EventArgs e)
        {
            if ((gridEXKategorite.RowCount > 0) && (gridEXKategorite.RowCount - 1 >= 0))
            {
                gridEXKategorite.Row = gridEXKategorite.RowCount - 1;
            }
        }

        private void gridEXKategorite_CurrentCellChanged(object sender, EventArgs e)
        {
            int index = gridEXKategorite.Row;
            txtEmri.Text = gridEXKategorite.GetRow(index).Cells["NJESIA"].Text;
        }
        #endregion

       
    }
}