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
    public partial class frmKategoriteReceta : Form
    {
        #region FormLoad
        public frmKategoriteReceta()
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
                grid.RootTable.Columns["PERSHKRIMI"].Width = 293;
            else
                grid.RootTable.Columns["PERSHKRIMI"].Width = 276;
        }

        /// <summary>
        /// Mbush griden me Kategorite e recetave
        /// </summary>
        private void MbushGride()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteERecetave");
            gridEXKategorite.DataSource = ds.Tables[0];
            //FormatoGride(gridEXKategorite);
        }

        private int ShtoKategori()
        {
            if (txtEmri.Text != "")
            {
                InputController data = new InputController();
                int b = data.KerkesaUpdate("ShtoKategoriRecete", txtEmri.Text);
                if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston nj� kategori recete me k�t� em�r!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
                else if (b == 1)
                {
                    MessageBox.Show(this, "Kategoria e re e recetave nuk u shtua. Provoni p�rs�ri!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
                else if (b == 0)
                {
                    //MessageBox.Show(this, "Kategoria e re e recetave u shtua.", this.Text, MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information);
                    return 0;
                }
                else return 1;
            }
            else return 1;
        }

        private int ModifikoKategori()
        {
            if (txtEmri.Text != "")
            {
                InputController data = new InputController();
                int index = gridEXKategorite.Row;
                int idKategoria = Convert.ToInt32(gridEXKategorite.GetRow(index).Cells["ID_KATEGORIARECETA"].Text);
                int b = data.KerkesaUpdate("ModifikoKategoriRecete", idKategoria, txtEmri.Text);
                if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston nj� kategori recete me k�t� em�r!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
                else if (b == 1)
                {
                    MessageBox.Show(this, "Kategoria e zgjedhur e recetave nuk u modifikua. Provoni p�rs�ri!", this.Text,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
                else if (b == 0)
                {
                    //MessageBox.Show(this, "Kategoria e zgjedhur e recetave u modifikua.", this.Text, MessageBoxButtons.OK,
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
                txtEmri.Text = gridEXKategorite.GetRow(index).Cells["PERSHKRIMI"].Text;
                this.gridEXKategorite.Visible = false;
                uiTabPage.Text = "Modifikim";
                uiTabPage.Image = ResManagerAdmin.Properties.Resources.forum_newmsg;
                this.uiTab.Visible = true;
                this.CaktivizoPanel(panelTop);
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
            dsId.Tables[0].Columns.Add("ID_KATEGORIARECETA", typeof(Int32));
            dsId.Tables[0].Columns.Add("PERSHKRIMI", typeof(String));
            dsId.AcceptChanges();
            for (int i = 0; i < gridEXKategorite.RowCount; i++)
            {
                if (gridEXKategorite.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    DataRow r = dsId.Tables[0].NewRow();
                    r["ID_KATEGORIARECETA"] = Convert.ToInt32(gridEXKategorite.GetRow(i).Cells["ID_KATEGORIARECETA"].Text);
                    r["PERSHKRIMI"] = gridEXKategorite.GetRow(i).Cells["PERSHKRIMI"].Text;
                    dsId.Tables[0].Rows.Add(r);
                }
            }
            dsId.AcceptChanges();
            if (dsId.Tables[0].Rows.Count != 0)
            {
                InputController data = new InputController();
                DataSet dsError = data.KerkesaRead("FshiKategoriteERecetave", dsId);
                if (Convert.IsDBNull(dsError))
                {
                    MessageBox.Show(this, "Nj� gabim ndodhi gjat� fshirjes s� kategorive t� recetave!" + Environment.NewLine +
                        "Provoni p�rs�ri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //jane fshire te gjitha kategorite dhe gjate fshirjes
                //nuk ka patur konflikte
                if (dsError.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(this, "Kategorit� e zgjedhura t� recetave u fshin�.",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string s = "Kategorit� e m�poshtme t� recetave nuk u fshin�";
                    s += Environment.NewLine + "sepse ka ende receta q� i p�rkasin k�tyre kategorive.";
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

        private void btnRuaj_Click_1(object sender, EventArgs e)
        {
            int r = 1;
            if (uiTabPage.Text == "Shtim")
            {
                r = this.ShtoKategori();
            }
            else if (uiTabPage.Text == "Modifikim")
            {
                r = this.ModifikoKategori();
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

        private void btnRuajKrijo_Click_1(object sender, EventArgs e)
        {
            int r = 1;
            if (uiTabPage.Text == "Shtim")
            {
                r = this.ShtoKategori();
            }
            else if (uiTabPage.Text == "Modifikim")
            {
                r = this.ModifikoKategori();
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
        #endregion     
        
    }
}