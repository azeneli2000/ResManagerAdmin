using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace ResManager.Forms
{
    public partial class frmKonfigurimPrinteri : Form
    {
        private DataSet dsPrinterat1 = null;
        private DataSet dsPrinterat2 = null;
        private DataSet dsPrinterat3 = null;
        private DataSet dsPrinterat4 = null;

        public frmKonfigurimPrinteri()
        {
            InitializeComponent();
        }

        private void frmKonfigurimPrinteri_Load(object sender, EventArgs e)
        {
            dsPrinterat1 = this.KrijoDataSet();
            dsPrinterat2 = this.KrijoDataSet();
            dsPrinterat3 = this.KrijoDataSet();
            dsPrinterat4 = this.KrijoDataSet();

            this.MbushGridaPrinterat();

            this.grida1.DataSource = this.dsPrinterat1.Tables[0];
            this.grida2.DataSource = this.dsPrinterat2.Tables[0];
            this.grida3.DataSource = this.dsPrinterat3.Tables[0];
            this.grida4.DataSource = this.dsPrinterat4.Tables[0];

        }

        private void MbushGridaPrinterat()
        {
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                DataRow drNew1 = this.dsPrinterat1.Tables[0].NewRow();
                drNew1["PRINTERI"] = strPrinter;

                this.dsPrinterat1.Tables[0].Rows.Add(drNew1);

                DataRow drNew3 = this.dsPrinterat3.Tables[0].NewRow();
                drNew3["PRINTERI"] = strPrinter;

                this.dsPrinterat3.Tables[0].Rows.Add(drNew3);
            }

            this.dsPrinterat1.Tables[0].AcceptChanges();
            this.dsPrinterat3.Tables[0].AcceptChanges();

        }

        private DataSet KrijoDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("PRINTERI", typeof(string));

            ds.AcceptChanges();

            return ds;
        }

        private bool GjendetPrinter(DataSet ds, string pr)
        {
            string printeri = "";
            
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                printeri = Convert.ToString(dr[0]);

                if (printeri == pr)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnKalo1_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida1.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida1.GetRow(indeksi).Cells[0].Text);

            if (this.GjendetPrinter(this.dsPrinterat2, pr) == false)
            {
                DataRow dr = this.dsPrinterat2.Tables[0].NewRow();
                dr["PRINTERI"] = pr;

                this.dsPrinterat2.Tables[0].Rows.Add(dr);

                this.dsPrinterat2.Tables[0].AcceptChanges();
            }
        }

        private void btnKalo2_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida3.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida3.GetRow(indeksi).Cells[0].Text);

            if (this.GjendetPrinter(this.dsPrinterat4, pr) == false)
            {
                DataRow dr = this.dsPrinterat4.Tables[0].NewRow();
                dr["PRINTERI"] = pr;

                this.dsPrinterat4.Tables[0].Rows.Add(dr);

                this.dsPrinterat4.Tables[0].AcceptChanges();
            }
        }

        private void grida2_DoubleClick(object sender, EventArgs e)
        {
            int indeksi = this.grida2.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida2.GetRow(indeksi).Cells[0].Text);

            string printeri = "";

            foreach (DataRow dr in this.dsPrinterat2.Tables[0].Rows)
            {
                printeri = Convert.ToString(dr[0]);

                if (printeri == pr)
                {
                    this.dsPrinterat2.Tables[0].Rows.Remove(dr);
                    this.dsPrinterat2.Tables[0].AcceptChanges();

                    return;
                }
            }

        }

        private void grida4_DoubleClick(object sender, EventArgs e)
        {
            int indeksi = this.grida4.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida4.GetRow(indeksi).Cells[0].Text);

            string printeri = "";

            foreach (DataRow dr in this.dsPrinterat4.Tables[0].Rows)
            {
                printeri = Convert.ToString(dr[0]);

                if (printeri == pr)
                {
                    this.dsPrinterat4.Tables[0].Rows.Remove(dr);
                    this.dsPrinterat4.Tables[0].AcceptChanges();

                    return;
                }
            }
        }

        private void grida1_DoubleClick(object sender, EventArgs e)
        {
            int indeksi = this.grida1.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida1.GetRow(indeksi).Cells[0].Text);

            if (this.GjendetPrinter(this.dsPrinterat2, pr) == false)
            {
                DataRow dr = this.dsPrinterat2.Tables[0].NewRow();
                dr["PRINTERI"] = pr;

                this.dsPrinterat2.Tables[0].Rows.Add(dr);

                this.dsPrinterat2.Tables[0].AcceptChanges();
            }
        }

        private void grida3_DoubleClick(object sender, EventArgs e)
        {
            int indeksi = this.grida3.Row;

            if (indeksi < 0)
            {
                return;
            }

            string pr = Convert.ToString(this.grida3.GetRow(indeksi).Cells[0].Text);

            if (this.GjendetPrinter(this.dsPrinterat4, pr) == false)
            {
                DataRow dr = this.dsPrinterat4.Tables[0].NewRow();
                dr["PRINTERI"] = pr;

                this.dsPrinterat4.Tables[0].Rows.Add(dr);

                this.dsPrinterat4.Tables[0].AcceptChanges();
            }
        }
    }
}