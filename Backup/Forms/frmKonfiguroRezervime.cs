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
    public partial class frmKonfiguroRezervime : Form
    {
        public string llojiVeprimi;
        public int idRezervimi;

        #region FormLoad
        public frmKonfiguroRezervime()
        {
            InitializeComponent();
        }

       
        private void frmKonfiguroRezervime_Load(object sender, EventArgs e)
        {
            if (llojiVeprimi == "Modifikim")
                btnFshi.Visible = true;
            else
                btnFshi.Visible = false;
            MbushCombo();
            ShfaqTeDhenaRezervimi();
        }
        #endregion

        #region Private Methods
        private void MbushCombo()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteETavolinave");
            cmbKategorite.DataSource = ds.Tables[0];
        }

        private void ShfaqTeDhenaRezervimi()
        {
            if (idRezervimi > 0)
            {
                InputController data = new InputController();
                dsRezervimi = data.KerkesaRead("ShfaqTeDhenaRezervimi", idRezervimi);
                //dataseti ka dy tabela
                //tabela 1 ka te dhenat e rezervimit
                //tabela 2 ka emrin dhe id e tavolinave qe i perkasin rezervimit
                txtEmri.Text = dsRezervimi.Tables[0].Rows[0]["EMRI"].ToString();
                txtMbiemri.Text = dsRezervimi.Tables[0].Rows[0]["MBIEMRI"].ToString();
                dtpData.Value = Convert.ToDateTime(dsRezervimi.Tables[0].Rows[0]["DATA"].ToString());
                dtpOraFillimi.Value = Convert.ToDateTime(dsRezervimi.Tables[0].Rows[0]["ORA_FILLIMI"].ToString());
                dtpOraMbarimi.Value = Convert.ToDateTime(dsRezervimi.Tables[0].Rows[0]["ORA_MBARIMI"].ToString());
                dsRezervimi = data.KerkesaRead("ShfaqTeDhenaRezervimi", idRezervimi);
                dsRezervimi.Tables[1].Columns.Add("CHECKED", typeof(Boolean));
                dsRezervimi.Tables[1].Columns["CHECKED"].DefaultValue = false;
                DataColumn[] vektorPrimary = new DataColumn[1];
                vektorPrimary[0] = dsRezervimi.Tables[1].Columns["ID_TAVOLINA"];
                dsRezervimi.Tables[1].PrimaryKey = vektorPrimary;
                gridEXTavolinaRezervimi.DataSource = dsRezervimi.Tables[1];
                dsRezervimi.AcceptChanges();
            }
            else
            {
                dtpData.Value = DateTime.Now;
                dtpOraFillimi.Value = DateTime.Now;
                dtpOraMbarimi.Value = DateTime.Now;
                dsRezervimi = new DataSet();
                dsRezervimi.Tables.Add();
                dsRezervimi.Tables.Add();
                dsRezervimi.Tables[1].Columns.Add("ID_TAVOLINA", typeof(Int32));
                dsRezervimi.Tables[1].Columns.Add("TAVOLINA", typeof(Int32));
                dsRezervimi.Tables[1].Columns.Add("KAPACITETI", typeof(Int32));
                dsRezervimi.Tables[1].Columns.Add("CHECKED", typeof(Boolean));
                dsRezervimi.Tables[1].Columns["CHECKED"].DefaultValue = false;
                DataColumn[] vektorPrimary = new DataColumn[1];
                vektorPrimary[0] = dsRezervimi.Tables[1].Columns["ID_TAVOLINA"];
                dsRezervimi.Tables[1].PrimaryKey = vektorPrimary;
                gridEXTavolinaRezervimi.DataSource = dsRezervimi.Tables[1];
                dsRezervimi.AcceptChanges();
            }
        }

        private int ModifikoRezervim()
        {
            if (KaGabim(0))
                return 1;
            int[] vektorTavolina = new int[dsRezervimi.Tables[1].Rows.Count];
            for (int i = 0; i < dsRezervimi.Tables[1].Rows.Count; i++)
                vektorTavolina[i] = Convert.ToInt32(dsRezervimi.Tables[1].Rows[i]["ID_TAVOLINA"]);
            InputController data = new InputController();
            DateTime[] vekData = MerrData();
            int b = data.KerkesaUpdate("ModifikoRezervim",this.idRezervimi, txtEmri.Text, txtMbiemri.Text,
                dtpData.Value, vekData[0], vekData[1], vektorTavolina);
            if (b == 0)
            {
                MessageBox.Show(this, "Rezervimi i zgjedhur u modifikua.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            else
            {
                MessageBox.Show(this, "Një gabim ndodhi gjatë modifikimt të rezervimit.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
        }

        private int ShtoRezervim()
        {
            if (KaGabim(0))
                return 1;
            int[] vektorTavolina = new int[dsRezervimi.Tables[1].Rows.Count];
            for (int i = 0; i < dsRezervimi.Tables[1].Rows.Count; i++)
                vektorTavolina[i] = Convert.ToInt32(dsRezervimi.Tables[1].Rows[i]["ID_TAVOLINA"]);
            InputController data = new InputController();
            DateTime[] vekData = MerrData();
            int b = data.KerkesaUpdate("ShtoRezervim", txtEmri.Text, txtMbiemri.Text,
                dtpData.Value, vekData[0], vekData[1], vektorTavolina);
            if (b == 0)
            {
                MessageBox.Show(this, "Rezervimi i ri u shtua.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            else
            {
                MessageBox.Show(this, "Një gabim ndodhi gjatë shtimit të rezervimit.", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
        }

        private bool KaGabim(int i)
        {
            this.error.SetError(dtpOraFillimi, "");
            this.error.SetError(dtpOraFillimi, "");
            this.error.SetError(dtpOraMbarimi, "");
            this.error.SetError(gridEXTavolinaRezervimi, "");
            if (txtEmri.Text == "" || txtMbiemri.Text == "")
                return true;
            //nuk mund te behet rezervim per ditet e kaluara
            if (dtpData.Value.Date < DateTime.Now.Date)
            {
                this.error.SetError(dtpData, "Data e rezervimit nuk mund të jetë më e vogel se data sot!");
                return true;
            }

            if ((dtpData.Value.Date == DateTime.Now.Date)&&(dtpOraFillimi.Value.TimeOfDay < DateTime.Now.TimeOfDay))
            {
                this.error.SetError(dtpOraFillimi, "Ora e rezervimit nuk mund të jetë më e vogel se ora tani!");
                return true;
            }

            if (dtpOraFillimi.Value.TimeOfDay >= dtpOraMbarimi.Value.TimeOfDay)
            {
                this.error.SetError(dtpOraMbarimi, "Ora e fillimit të rezervimit duhet te jetë më e vogël se ora e mbarimit!");
                return true;
            }
            if ((i == 0)&&(dsRezervimi.Tables[1].Rows.Count == 0))
            {
                this.error.SetError(gridEXTavolinaRezervimi, "Duhet të zgjidhni të paktën një tavolinë për rezervim!");
                return true;
            }
            return false;
        }

        private void Pastro()
        {
            btnPastro_Click(new object(), new EventArgs());
            txtEmri.Clear();
            txtMbiemri.Clear();
            dtpData.Value = DateTime.Now;
            dtpOraFillimi.Value = DateTime.Now;
            dtpOraMbarimi.Value = DateTime.Now;
        }

        private DateTime[] MerrData()
        {
            if (KaGabim(1))
                return null;
            string data = dtpData.Value.ToString("yyyy-MM-dd");
            string oraFillimi = dtpOraFillimi.Value.ToString("HH:mm");
            string oraMbarimi = dtpOraMbarimi.Value.ToString("HH:mm");
            DateTime[] v = new DateTime[2];
            v[0] = Convert.ToDateTime(data + " " + oraFillimi);
            v[1] = Convert.ToDateTime(data + " " + oraMbarimi);
            return v;
        }

        private bool Fund()
        {
            bool fund = true;
            for (int i = 0; i < this.gridEXTavolinaRezervimi.RowCount; i++)
            {
                if (gridEXTavolinaRezervimi.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    fund = false;
                    break;
                }
            }
            return fund;
        }
        #endregion

        #region Event Handlers
        private void btnAnullo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbKategorite_ValueChanged(object sender, EventArgs e)
        {
            InputController data = new InputController();
            DateTime[] vekDatat = MerrData();
            if (vekDatat == null)
                return;
            if (llojiVeprimi == "Shtim")
                dsTavolinat = data.KerkesaRead("ShfaqTavolinatEliraPerKategori", 
                    Convert.ToInt32(cmbKategorite.Value),vekDatat[0], vekDatat[1]);
            else
            {
                dsTavolinat = data.KerkesaRead("ShfaqTavolinatEliraPerKategori", 
                    Convert.ToInt32(cmbKategorite.Value), idRezervimi,vekDatat[0], vekDatat[1] );
            }
            dsTavolinat.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
            dsTavolinat.Tables[0].Columns["CHECKED"].DefaultValue = false;
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsTavolinat.Tables[0].Columns["ID_TAVOLINA"];
            dsTavolinat.Tables[0].PrimaryKey = vektorPrimary;
            dsTavolinat.AcceptChanges();
            gridEXTavolina.DataSource = dsTavolinat.Tables[0];
        }

        private void btnPastro_Click(object sender, EventArgs e)
        {
            cmbKategorite.Value = null;
            cmbKategorite.Text = "";
            if (dsTavolinat.Tables.Count >= 1)
                dsTavolinat.Tables[0].Rows.Clear();
            if (dsRezervimi.Tables.Count == 2)
                dsRezervimi.Tables[1].Rows.Clear();
        }

        private void btnDjathtas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridEXTavolina.RowCount; i++)
            {
                if (gridEXTavolina.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    int idTavolina = Convert.ToInt32(gridEXTavolina.GetRow(i).Cells["ID_TAVOLINA"].Text);
                    DataRow drSearch = dsRezervimi.Tables[1].Rows.Find(idTavolina);
                    if (drSearch == null)
                    {
                        string gjendja = Convert.ToString(gridEXTavolina.GetRow(i).Cells["GJENDJA"].Text);
                        int emriTavolina = Convert.ToInt32(gridEXTavolina.GetRow(i).Cells["TAVOLINA"].Text);
                        bool LejoRezervim;
                        if (gjendja == "Z")
                        {
                            DialogResult result = MessageBox.Show(this, "Tavolina " + emriTavolina + " është e zënë për momentin!" +
                                Environment.NewLine + "Jeni të sigurtë që doni të bëni një rezervim për të?", this.Text,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                                LejoRezervim = true;
                            else
                                LejoRezervim = false;
                        }
                        else
                            LejoRezervim = true;
                        if (LejoRezervim)
                        {
                            DataRow r = dsRezervimi.Tables[1].NewRow();
                            r["ID_TAVOLINA"] = idTavolina;
                            r["TAVOLINA"] = emriTavolina;
                            r["KAPACITETI"] = Convert.ToInt32(gridEXTavolina.GetRow(i).Cells["KAPACITETI"].Text);
                            dsRezervimi.Tables[1].Rows.Add(r);
                        }
                    }
                    drSearch = dsTavolinat.Tables[0].Rows.Find(idTavolina);
                    drSearch["CHECKED"] = false;
                }
            }
        }

        private void btnMajtas_Click(object sender, EventArgs e)
        {
            while (!Fund())
            {
                for (int i = 0; i < gridEXTavolinaRezervimi.RowCount; i++)
                {
                    if (gridEXTavolinaRezervimi.GetRow(i).Cells["CHECKED"].Text == "True")
                    {
                        int idTavolina = Convert.ToInt32(gridEXTavolinaRezervimi.GetRow(i).Cells["ID_TAVOLINA"].Text);
                        DataRow drSearch = dsRezervimi.Tables[1].Rows.Find(idTavolina);
                        dsRezervimi.Tables[1].Rows.Remove(drSearch);
                        dsRezervimi.AcceptChanges();
                    }
                }
            }
            
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            int r;
            if (llojiVeprimi == "Shtim")
            {
                r = ShtoRezervim();
            }
            else
            {
                r = ModifikoRezervim();
            }
            if (r == 0)
            {
                if (llojiVeprimi == "Shtim")
                {
                    Pastro();
                }
                //nqs eshte bere modifikim
                //forma mbyllet
                else
                {
                    Close();
                }
            }
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            InputController data = new InputController();
            int b = data.KerkesaUpdate("FshiRezervim", this.idRezervimi);
            if (b == 0)
            {
                MessageBox.Show(this, "Rezervimi i zgjedhur u fshi.", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Pastro();
            }
            else
            {
                MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së rezervimit. Provoni përsëri!", this.Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            btnPastro_Click(sender, e);
        }

        private void dtpOraFillimi_ValueChanged(object sender, EventArgs e)
        {
            btnPastro_Click(sender, e);
        }

        private void dtpOraMbarimi_ValueChanged(object sender, EventArgs e)
        {
            btnPastro_Click(sender, e);
        }

        #endregion

        
        
        
    }
}