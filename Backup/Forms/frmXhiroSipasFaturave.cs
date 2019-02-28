using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmXhiroSipasFaturave : System.Windows.Forms.Form, IPrintable
    {
        #region Load Form
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;


        public frmXhiroSipasFaturave()
        {
            InitializeComponent();
        }

        private void frmXhiroSipasFaturave_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;

            dtpFillimi.Value = DateTime.Now;
            dtpMbarimi.Value = DateTime.Now;
            LexoInformacione();
        }
        #endregion

        #region Private Methods
        private void MbushKombo()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqPerdoruesitKamariere");
            cboKamarieri.DataSource = ds.Tables[0];
            ds = data.KerkesaRead("ShfaqTavolinatDetaje");
            this.cboTavolina.DataSource = ds.Tables[0];
            cboKamarieri.Text = "";
            cboTavolina.Text = "";
            cboKamarieri.SelectedItem = null;
            cboTavolina.SelectedItem = null;
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void MbushGride(string s)
        {
            InputController data = new InputController();
            DataSet dsData = data.KerkesaRead("XhirojaPerSecilenDate", s);
            if (dsData != null)
            {
                dsData = KonvertoDataSet(dsData);
                gridDatat.DataSource = dsData.Tables[0];
                FormatoGride(gridDatat);
                dsData.WriteXml(Global.stringXml + "\\xhiroSipasFaturavePaDetaje.Xml", XmlWriteMode.WriteSchema);
                this.ReadyToPrint = true;
            }
            else
                this.ReadyToPrint = false;
        }

        /// <summary>
        /// Shton ne dataset ato data per te cilat nuk jane kryer veprime
        /// </summary>
        /// <param name="ds"></param>
        private DataSet KonvertoDataSet(DataSet ds)
        {
            DataColumn[] celes = new DataColumn[1];
            celes[0] = ds.Tables[0].Columns["DATA"];
            ds.Tables[0].PrimaryKey = celes;
            DateTime dtFillimi = dtpFillimi.Value.Date;
            DateTime dtMbarimi = dtpMbarimi.Value.Date;
            TimeSpan ts = dtMbarimi.Subtract(dtFillimi);
            for (int i = 1; i <= ts.TotalDays + 1; i++)
            {
                DateTime dt = dtFillimi.AddDays(i - 1);
                DataRow drSearch = ds.Tables[0].Rows.Find(dt);
                if (drSearch == null)
                {
                    DataRow newR = ds.Tables[0].NewRow();
                    newR["DATA_STR"] = dt.ToString("dd.MM.yyyy");
                    newR["DATA"] = dt;
                    newR["VLERA"] = 0;
                    ds.Tables[0].Rows.Add(newR);
                }
            }
            ds.AcceptChanges();
            ds.Tables.Add("KOMENT_RAPORTI");
            ds.Tables[1].Columns.Add("KOMENT");
            DataRow nR = ds.Tables[1].NewRow();
            nR["KOMENT"] = gbXhiro.Text;
            ds.Tables[1].Rows.Add(nR);
            ds.AcceptChanges();
            return ds;
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.Name == gridDatat.Name)
            {
                if (grid.RowCount <= 27)
                {
                    grid.RootTable.Columns["VLERA"].Width = 138;
                }
                else
                {
                    grid.RootTable.Columns["VLERA"].Width = 121;
                }
            }
            else
            {
                if (grid.RowCount <= 27)
                {
                    grid.RootTable.Columns["VLERA_KOMISION"].Width = 99;
                }
                else
                {
                    grid.RootTable.Columns["VLERA_KOMISION"].Width = 82;
                }
            }
        }

        #endregion

        #region Event Handlers
        private void btnKerko_Click(object sender, EventArgs e)
        {
            gridDatat.DataSource = null;
            gridDetaje.DataSource = null;

            error1.SetError(dtpFillimi, "");
            error1.SetError(dtpMbarimi,"");
            error1.SetError(cboTavolina, "");
            error1.SetError(cboKamarieri, "");
            if (dtpFillimi.Value.Date > dtpMbarimi.Value.Date)
            {
                error1.SetError(dtpFillimi,"Data e fillimit duhet të jetë më e vogël se data e mbarimit!");
                return;
            }
            string s = "WHERE ANULLUAR = 0 AND";
            //Kufizimi brenda datave
            s += " CONVERT(DATETIME, CONVERT(char(12), F.DATA_ORA)) BETWEEN '" + dtpFillimi.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpMbarimi.Value.ToString("yyyy-MM-dd")  + "'";
            gbXhiro.Text = "Xhiro efektive për intervalin  datave midis " + dtpFillimi.Text + " dhe " + dtpMbarimi.Text;
            if (this.chkKamarieri.Checked == true)
            {
                if (this.cboKamarieri.Text != "")
                {
                    s += " AND F.ID_PERSONELI = " + Convert.ToInt32(cboKamarieri.SelectedValue);
                    gbXhiro.Text += ", për kamarierin " + cboKamarieri.Text;
                }
                else
                {
                    error1.SetError(cboKamarieri, "Zgjidhni një prej kamarierëve!");
                    gbXhiro.Text = "Xhiro efektive për intervalin e zgjedhur të datave";
                    return;
                }
            }
            if (chkTavolina.Checked == true)
            {
                if (this.cboTavolina.Text != "")
                {
                    s += " AND F.ID_TAVOLINA = " + Convert.ToInt32(cboTavolina.SelectedValue);
                    gbXhiro.Text += ", për tavolinën " + cboTavolina.Text;
                }
                else
                {
                    error1.SetError(cboTavolina, "Zgjidhni një prej tavolinave!");
                    gbXhiro.Text = "Xhiro efektive për intervalin e zgjedhur të datave";
                    return;
                }
               
            }
            MbushGride(s);
        }

        private void cbKamarieri_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkKamarieri.Checked == true)
            {
                this.cboKamarieri.Enabled = true;
                cboKamarieri.Text = "";
                
                this.cboKamarieri.BackColor = Color.White;
            }
            else
            {

                cboKamarieri.Text = "";

                this.cboKamarieri.Enabled = false;
                this.cboKamarieri.BackColor = Color.White;
            }
        }

        private void cbTavolina_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkTavolina.Checked == true)
            {
                this.cboTavolina.Enabled = true;
                this.cboTavolina.Text = "";

                this.cboTavolina.BackColor = Color.White;
            }
            else
            {

                this.cboTavolina.Text = "";

                this.cboTavolina.Enabled = false;
                this.cboTavolina.BackColor = Color.White;
            }
        }

        private void gridDatat_CurrentCellChanged(object sender, EventArgs e)
        {
            int i = gridDatat.Row;
            if (i == gridDatat.RowCount - 1)
            {
                gridDetaje.DataSource = null;
                this.lblDataZgjedhur.Text = "Faturat per daten e zgjedhur :";
                return;
            }
            DateTime data = Convert.ToDateTime(gridDatat.GetRow(i).Cells["DATA"].Text);
            if (Convert.ToDouble(gridDatat.GetRow(i).Cells["VLERA"].Value) != 0)
            {
                error1.SetError(dtpFillimi, "");
                error1.SetError(dtpMbarimi, "");
                error1.SetError(cboTavolina, "");
                error1.SetError(cboKamarieri, "");
                if (dtpFillimi.Value.Date > dtpMbarimi.Value.Date)
                {
                    error1.SetError(dtpFillimi, "Data e fillimit duhet të jetë më e vogël se data e mbarimit!");
                    return;
                }
                string koment = "Xhiro efektive sipas faturave e detajuar për datën " + data.ToString("dd.MM.yyyy");
                //Kufizimi brenda datave
                string s = " WHERE (F.ANULLUAR = 0) AND DAY(F.DATA_ORA) = DAY('" + data.ToString("yyyy-MM-dd") + "') AND MONTH(F.DATA_ORA) = MONTH('" + data.ToString("yyyy-MM-dd") + "') AND YEAR(F.DATA_ORA) = YEAR('" + data.ToString("yyyy-MM-dd") + "')";
                if (this.chkKamarieri.Checked == true)
                {
                    if (this.cboKamarieri.Text != "" && cboKamarieri.SelectedValue != null)
                    {
                        s += " AND F.ID_PERSONELI = " + Convert.ToInt32(cboKamarieri.SelectedValue);
                        koment += " për personelin " + cboKamarieri.Text;
                    }
                    else
                    {
                        error1.SetError(cboKamarieri, "Zgjidhni një prej kamarierëve!");
                        return;
                    }
                }
                if (chkTavolina.Checked == true)
                {
                    if (this.cboTavolina.Text != "" && cboTavolina.SelectedValue != null)
                    {
                        s += " AND F.ID_TAVOLINA = " + Convert.ToInt32(cboTavolina.SelectedValue);
                        koment += " për tavolinën " + cboTavolina.Text;
                    }
                    else
                    {
                        error1.SetError(cboTavolina, "Zgjidhni një prej tavolinave!");
                        return;
                    }

                }
                InputController dataI = new InputController();
                DataSet dsXhiroPerDaten = dataI.KerkesaRead("ShfaqXhiroSipasFaturavePerDaten", s);
                gridDetaje.RootTable.Groups.Clear();
                for (int j = 0; j < gridDetaje.RootTable.Columns.Count; j++)
                    gridDetaje.RootTable.Columns[j].Visible = true;
                gridDetaje.DataSource = dsXhiroPerDaten.Tables[0];
                FormatoGride(gridDetaje);
                dsXhiroPerDaten.Tables.Add("KOMENT_RAPORTI");
                dsXhiroPerDaten.Tables[1].Columns.Add("KOMENT", typeof(string));
                DataRow newR = dsXhiroPerDaten.Tables[1].NewRow();
                newR["KOMENT"] = koment;
                dsXhiroPerDaten.Tables[1].Rows.Add(newR);
                dsXhiroPerDaten.AcceptChanges();
                dsXhiroPerDaten.WriteXml(Global.stringXml + "\\xhiroSipasFaturaveMeDetaje.Xml", XmlWriteMode.WriteSchema);
            }
            else
            {
                for (int j = 0; j < gridDetaje.RootTable.Columns.Count; j++)
                    gridDetaje.RootTable.Columns[j].Visible = true;
                gridDetaje.DataSource = null;
            }

            this.lblDataZgjedhur.Text = "Faturat per daten :   " + data.ToString("dd.MM.yyyy");
        }

        #endregion

        #region ContextMenuStrip
        private void tavolinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tavolinaToolStripMenuItem.Checked)
            {
                Janus.Windows.GridEX.GridEXGroup g = new Janus.Windows.GridEX.GridEXGroup();
                g.Column = gridDetaje.RootTable.Columns["TAVOLINA"];
                gridDetaje.RootTable.Groups.Add(g);
            }
            else
            {
                gridDetaje.RootTable.Groups.Remove(gridDetaje.RootTable.Groups["TAVOLINA"]);
            }
        }

        private void kamarieriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kamarieriToolStripMenuItem.Checked)
            {
                Janus.Windows.GridEX.GridEXGroup g = new Janus.Windows.GridEX.GridEXGroup();
                g.Column = gridDetaje.RootTable.Columns["EMRI_KAMARIERI"];
                gridDetaje.RootTable.Groups.Add(g);
            }
            else
            {
                gridDetaje.RootTable.Groups.Remove(gridDetaje.RootTable.Groups["EMRI_KAMARIERI"]);
            }
        }

        private void formaEPagesësToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formaEPagesësToolStripMenuItem.Checked)
            {
                Janus.Windows.GridEX.GridEXGroup g = new Janus.Windows.GridEX.GridEXGroup();
                g.Column = gridDetaje.RootTable.Columns["FORMA_PAGESA"];
                gridDetaje.RootTable.Groups.Add(g);
            }
            else
            {
                gridDetaje.RootTable.Groups.Remove(gridDetaje.RootTable.Groups["FORMA_PAGESA"]);
            }
        }

        private void nrFatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nrFatureToolStripMenuItem.Checked)
                gridDetaje.RootTable.Columns["NR_FATURE"].Visible = true;
            else
                gridDetaje.RootTable.Columns["NR_FATURE"].Visible = false;
        }

        private void tavolinaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tavolinaToolStripMenuItem1.Checked)
                gridDetaje.RootTable.Columns["TAVOLINA"].Visible = true;
            else
                gridDetaje.RootTable.Columns["TAVOLINA"].Visible = false;
        }

        private void kamarieriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (kamarieriToolStripMenuItem1.Checked)
                gridDetaje.RootTable.Columns["EMRI_KAMARIERI"].Visible = true;
            else
                gridDetaje.RootTable.Columns["EMRI_KAMARIERI"].Visible = false;
        }

        private void vleraEXhirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vleraEXhirosToolStripMenuItem.Checked)
                gridDetaje.RootTable.Columns["TOTALI"].Visible = true;
            else
                gridDetaje.RootTable.Columns["TOTALI"].Visible = false;
        }

        private void formaEPagesësToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formaEPagesësToolStripMenuItem1.Checked)
                gridDetaje.RootTable.Columns["FORMA_PAGESA"].Visible = true;
            else
                gridDetaje.RootTable.Columns["FORMA_PAGESA"].Visible = false;
        }

        private void vleraMeKomisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vleraMeKomisionToolStripMenuItem.Checked)
                gridDetaje.RootTable.Columns["VLERA_KOMISION"].Visible = true;
            else
                gridDetaje.RootTable.Columns["VLERA_KOMISION"].Visible = false;
        }
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            frmZgjidhPrintiminXhiro frm = new frmZgjidhPrintiminXhiro();
            frm.ShowDialog();
            if ((frm.zgjedhja == 1) && (gridDatat.RowCount != 0))
            {
                Doc.GridEX = gridDatat;
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine +
                    "Xhiro e përmbledhur midis datave " + this.dtpFillimi.Value.ToString("dd.MM.yyyy") + " dhe " +
                        dtpMbarimi.Value.ToString("dd.MM.yyyy");
                if (chkKamarieri.Checked)
                    Doc.PageHeaderLeft += ", për kamarierin " + cboKamarieri.Text;
                if (chkTavolina.Checked)
                    Doc.PageHeaderLeft += ", për tavolinën " + cboTavolina.Text;
                frmRaportJanus frmPrint = new frmRaportJanus();
                frmPrint.PrintPreviewControl1.Document = Doc;
                frmPrint.ShowDialog();
            }
            else if ((frm.zgjedhja == 2) && (gridDetaje.RowCount != 0))
            {
                Doc.GridEX = gridDetaje;
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine +
                                    "Xhiro e detajuar për datën " + gridDatat.GetRow(gridDatat.Row).Cells["DATA_STR"].Text;
                if (chkKamarieri.Checked)
                    Doc.PageHeaderLeft += ", për kamarierin " + cboKamarieri.Text;
                if (chkTavolina.Checked)
                    Doc.PageHeaderLeft += ", për tavolinën " + cboTavolina.Text; frmRaportJanus frmPrint = new frmRaportJanus();
                frmPrint.PrintPreviewControl1.Document = Doc;
                frmPrint.ShowDialog();
            }
        }

        public bool ReadyToPrint
        {
            get
            {
                return this.readyToPrint;
            }
            set
            {
                bool oldValue = readyToPrint;
                readyToPrint = value;
                if (ReadyToPrintChanged != null && value != oldValue)
                    ReadyToPrintChanged(this, new ReadyChangedEventArgs());
            }
        }

        public void ConvertToExcel()
        {
            frmZgjidhPrintiminXhiro frm = new frmZgjidhPrintiminXhiro();
            frm.label1.Text = "Zgjidhni se cilën prej tabelave doni të konvertoni në Excel:";
            frm.ShowDialog();
            if ((frm.zgjedhja == 1) && (gridDatat.RowCount != 0))
            {
                this.ExcelGridaDatat();
            }
            else if ((frm.zgjedhja == 2) && (gridDetaje.RowCount != 0))
            {
                ExcelGridaDetaje();
            }
        }

        public void Print()
        {
            
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        public Janus.Windows.GridEX.GridEXPrintDocument Doc
        {
            get
            {
                return this.doc;
            }
            set
            {
                doc = value;
            }
        }

        #endregion

        private void frmXhiroSipasFaturave_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            MbushKombo();
            btnKerko_Click(sender, e);
        }

        private void ExcelGridaDatat()
        {
            string[] fushat = new string[2];
            string[] llojet = new string[2];
            string[] key = new string[2];

            fushat[0] = "Data";
            fushat[1] = "Vlera_e_xhiros";

            key[0] = "DATA_STR";
            key[1] = "VLERA";

            llojet[0] = "char(255)";
            llojet[1] = "float";

            KlaseExcel excel = new KlaseExcel("XhiroSipasDatave.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGride("XhiroSipasDatave.xls", gridDatat, fushat, key, llojet, "DATA_STR");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "XhiroSipasDatave.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExcelGridaDetaje()
        {
            string[] fushat = new string[6];
            string[] llojet = new string[6];
            string[] key = new string[6];
            fushat[0] = "Nr_Fature";
            fushat[1] = "Tavolina";
            fushat[2] = "Kamarieri";
            fushat[3] = "Vlera";
            fushat[4] = "Fr_pagesa";
            fushat[5] = "Vl_me_komision";

            key[0] = "NR_FATURE";
            key[1] = "TAVOLINA";
            key[2] = "EMRI_KAMARIERI";
            key[3] = "TOTALI";
            key[4] = "FORMA_PAGESA";
            key[5] = "VLERA_KOMISION";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "char(255)";
            llojet[3] = "float";
            llojet[4] = "char(255)";
            llojet[5] = "float";

            KlaseExcel excel = new KlaseExcel("DetajeXhiroPerDaten.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("DetajeXhiroPerDaten.xls", gridDetaje,
                    fushat, key, llojet, "NR_FATURE");

            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "DetajeXhiroPerDaten.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}