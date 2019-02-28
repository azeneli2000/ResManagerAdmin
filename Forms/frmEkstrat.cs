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
    public partial class frmEkstrat : Form
    {
        public int idReceta;

        public DataSet dsEkstrat = null;
        public int veprimi = 0;

        public frmEkstrat()
        {
            InitializeComponent();
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.veprimi = 0;
            this.Close();
        }

        private void frmEkstrat_Load(object sender, EventArgs e)
        {
            //this.dsEkstrat = this.KrijoDsRecetat();
            this.grida.DataSource = this.dsEkstrat.Tables[0];

            //this.MbushGriden();
        }

        private DataSet KrijoDsRecetat()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("KEKSTRA", typeof(string));

            ds.AcceptChanges();

            return ds;
        }

        private void MbushGriden()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqEkstratPerReceten", idReceta);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = this.dsEkstrat.Tables[0].NewRow();

                drNew["KEKSTRA"] = dr["KEKSTRA"];

                this.dsEkstrat.Tables[0].Rows.Add(drNew);
            }

            this.dsEkstrat.Tables[0].AcceptChanges();



        }

        private bool GjendetEkstra(string ekstra)
        {
            foreach (DataRow dr in dsEkstrat.Tables[0].Rows)
            {
                if (Convert.ToString(dr[0]) == ekstra)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            if (this.txtEkstra.Text.Trim() == "")
            {
                return;
            }

            string ekstra = this.txtEkstra.Text.Trim();

            if (this.GjendetEkstra(ekstra))
            {
                return;
            }

            DataRow dr = this.dsEkstrat.Tables[0].NewRow();
            dr["KEKSTRA"] = ekstra;
            this.dsEkstrat.Tables[0].Rows.Add(dr);
            this.dsEkstrat.Tables[0].AcceptChanges();

            this.txtEkstra.Text = "";


        }

        private void btnPastro_Click(object sender, EventArgs e)
        {
            this.txtEkstra.Text = "";
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;
            if (indeksi < 0)
            {
                return;
            }

            string ekstra = Convert.ToString(this.grida.GetRow(indeksi).Cells[0].Text);

            foreach (DataRow dr in this.dsEkstrat.Tables[0].Rows)
            {
                if (Convert.ToString(dr[0]) == ekstra)
                {
                    this.dsEkstrat.Tables[0].Rows.Remove(dr);
                    this.dsEkstrat.Tables[0].AcceptChanges();
                    return;
                }
            }
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            this.veprimi = 1;
            this.Close();
        }
    }
}