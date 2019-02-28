using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using Janus.Windows.GridEX;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmKonfigurimRecetash : System.Windows.Forms.Form, IPrintable
    {
        private int upDirection = 0;
        private int idReceta = -1;
        /// <summary>
        /// Sherben si id per cdo artikull
        /// brenda te njejtes recete
        /// </summary>
        private int id = 0;
        private DataSet dsEkstrat = null;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;


        #region FormLoad
        public frmKonfigurimRecetash()
        {
            InitializeComponent();
        }

        private void frmKonfigurimRecetash_Load(object sender, EventArgs e)
        {
            gridRecetat.BringToFront();
            LexoInformacione();
            AddConditionalFormatting();
            this.BllokoKerkimin();           

            this.dsEkstrat = this.KrijoDataSetEkstrat();
            this.gridaEkstrat.DataSource = this.dsEkstrat.Tables[0];
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
        }
        #endregion

        #region Private Methods

        private void MbushDataSetEkstrat(int idReceta)
        {
            try
            {
                InputController data = new InputController();
                DataSet ds = data.KerkesaRead("ShfaqEkstratPerReceten", idReceta);
                if (ds == null)
                    return;
                this.dsEkstrat.Tables[0].Rows.Clear();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DataRow drNew = this.dsEkstrat.Tables[0].NewRow();

                    drNew["KEKSTRA"] = dr["KEKSTRA"];

                    this.dsEkstrat.Tables[0].Rows.Add(drNew);
                }

                this.dsEkstrat.Tables[0].AcceptChanges();
            }
            catch(Exception ex)
            {
                return;
            }

        }

        private DataSet KrijoDataSetEkstrat()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("KEKSTRA", typeof(string));

            ds.Tables[0].AcceptChanges();
            ds.AcceptChanges();

            return ds;
        }

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

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void MbushGride(string kushti)
        {
            if (kushti == "")
            {
                cbArtikujt.Checked = false;
                cbKategoria.Checked = false;
                cbReceta.Checked = false;
            }
            InputController data = new InputController();
            this.ds = data.KerkesaRead("ShfaqRecetat", kushti);
            this.gridRecetat.DataSource = this.ds.Tables[0];
            this.Doc.GridEX = gridRecetat;
            Doc.DefaultPageSettings.Landscape = true;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            //FormatoGride(gridRecetat);
        }

        private void FormatoGride(Janus.Windows.GridEX.GridEX grid)
        {
            if (grid.Name == "gridArtikujt")
            {
                if (grid.RowCount <= 17)
                    grid.RootTable.Columns["EMRI"].Width = 121;
                else
                    grid.RootTable.Columns["EMRI"].Width = 104;
            }
            else
            {
                if (grid.RowCount <= 23)
                    grid.RootTable.Columns["EMRI"].Width = 142;
                else
                    grid.RootTable.Columns["EMRI"].Width = 125;
            }
        }

        private void MbushCombo()
        {
            InputController data = new InputController();
            DataSet dsTmp = data.KerkesaRead("ShfaqKategoriteERecetave");
            cmbKategoriaRecetaKerkim.DataSource = dsTmp.Tables[0];
            cmbKategoriaReceta.DataSource = dsTmp.Tables[0];


            dsTmp = data.KerkesaRead("ShfaqKategoriteEArtikujve");
            cmbKategoriaArtikujKerkim.DataSource = dsTmp.Tables[0];
            cmbKategoriteArtikulli.DataSource = dsTmp.Tables[0];
            cmbKategoriteArtikulliModifikim.DataSource = dsTmp.Tables[0];

        }

        private void PlotesoTeDhena()
        {
            dsReceta.Tables[0].Clear();
            dsReceta.Tables[1].Clear();
            int index = gridRecetat.Row;
            bool ugjet = false;
            int j = 1;
            this.idReceta = Convert.ToInt32(gridRecetat.GetRow(index).Cells["ID_RECETA"].Text);
            double kostoja = 0;
            for (int i = 0; i < gridRecetat.RowCount; i++)
            {
                if (gridRecetat.GetRow(i).Cells["ID_ARTIKULLI"].Text != "")
                {
                    //plotesojme te dhenat per artikujt perberes te recetes
                    if (idReceta == Convert.ToInt32(gridRecetat.GetRow(i).Cells["ID_RECETA"].Text))
                    {
                        ugjet = true;
                        DataRow r = dsReceta.Tables[1].NewRow();
                        Janus.Windows.GridEX.GridEXRow rGrid = gridRecetat.GetRow(i);
                        r["ID_ARTIKULLI"] = Convert.ToInt32(rGrid.Cells["ID_ARTIKULLI"].Text);
                        r["SASIA"] = Convert.ToDouble(rGrid.Cells["SASIA"].Text);
                        r["NJESIA"] = rGrid.Cells["NJESIA"].Text;
                        r["ARTIKULLI"] = Convert.ToString(rGrid.Cells["ARTIKULLI"].Text);
                        if (rGrid.Cells["CMIMI"].Text != "")
                            r["CMIMI"] = Convert.ToDouble(rGrid.Cells["CMIMI"].Text);
                        r["ID_KATEGORIAARTIKULLI"] = Convert.ToInt32(rGrid.Cells["ID_KATEGORIAARTIKULLI"].Text);
                        r["SASIA_STR"] = Convert.ToString(rGrid.Cells["SASIA_STR"].Text);
                        if (rGrid.Cells["VLERA"].Text != "")
                        {
                            r["VLERA"] = Convert.ToDouble(rGrid.Cells["VLERA"].Text);
                            kostoja += Convert.ToDouble(rGrid.Cells["VLERA"].Text);
                        }
                        r["CHECKED"] = false;
                        r["ID"] = j;
                        j++;
                        dsReceta.Tables[1].Rows.Add(r);
                        //nqs ende nuk i kemi hedhur te dhenat mbi receten
                        //bejme plotesimin e tyre
                        if (dsReceta.Tables[0].Rows.Count == 0)
                        {
                            r = dsReceta.Tables[0].NewRow();
                            r["ID_KATEGORIARECETA"] = Convert.ToString(rGrid.Cells["ID_KATEGORIARECETA"].Text);
                            r["EMRI"] = rGrid.Cells["EMRI"].Text;
                            r["DISPONUESHEM"] = rGrid.Cells["DISPONUESHEM"].Text;
                            dsReceta.Tables[0].Rows.Add(r);
                        }

                    }
                    //nqs me pare jane gjetur artikuj te recetes
                    //dhe rreshti qe po kontrolojme nuk i perket recetes
                    //atehere kerkimi ka mbaruar
                    else if (ugjet == true)
                        break;
                }
            }
            dsReceta.AcceptChanges();
            gridArtikujt.DataSource = dsReceta.Tables[1];
            txtEmriReceta.Text = dsReceta.Tables[0].Rows[0]["EMRI"].ToString();
            cmbKategoriaReceta.Value = Convert.ToInt32(dsReceta.Tables[0].Rows[0]["ID_KATEGORIARECETA"]);
            txtKostojaReceta.Text = kostoja.ToString();

            this.MbushDataSetEkstrat(this.idReceta);
        }

        private void PastroRecete()
        {
            dsReceta.Tables[0].Clear();
            dsReceta.Tables[1].Clear();
            this.idReceta = -1;
            this.id = 0;

            txtEmriReceta.Clear();
            cmbKategoriaReceta.Value = null;
            cmbKategoriaReceta.Text = "";
            txtKostojaReceta.Clear();

            cmbKategoriteArtikulli.Value = null;
            cmbKategoriteArtikulli.Text = "";
            cmbArtikulli.DataSource = null;
            numSasia.Value = 0;
            txtNjesia.Clear();
            txtCmimiBlerje.Clear();

            cmbKategoriteArtikulliModifikim.Value = null;
            cmbKategoriteArtikulliModifikim.Text = "";
            cmbArtikulliModifikim.DataSource = null;
            numSasiaModifikim.Value = 0;
            txtNjesiaModifikim.Clear();
            txtCmimiBlerjeModifikim.Clear();

            this.uiTabPerberesit.SelectedIndex = 0;
        }

        private DataSet ArtikujtPerKategori(int idKategoria)
        {
            InputController data = new InputController();
            return data.KerkesaRead("ShfaqArtikujCmimePerKategori", idKategoria);
        }

        private int GabimNeKonfigurimArtikulli()
        {
            //i njejti artikull nuk mund te figuroje dy here ne recete
            if (uiTabPerberesit.SelectedIndex == 1)
            {
                if (cmbKategoriteArtikulli.Value == null || cmbKategoriteArtikulli.Text == ""
                    || cmbArtikulli.Value == null || cmbArtikulli.Text == ""
                    || numSasia.Value == 0)
                    return 1;
                int idArtikulli = Convert.ToInt32(cmbArtikulli.Value);
                DataRow drSearch = dsReceta.Tables[1].Rows.Find(idArtikulli);
                if (drSearch == null)
                    return 0;
                else
                {
                    MessageBox.Show(this, "Ky artikull figuron një herë në recetë!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
            }
            else
            {
                if (cmbKategoriteArtikulliModifikim.Value == null || cmbKategoriteArtikulliModifikim.Text == ""
                    || cmbArtikulliModifikim.Value == null || cmbArtikulliModifikim.Text == ""
                    || numSasiaModifikim.Value == 0)
                    return 1;
                int idArtikulli = Convert.ToInt32(cmbArtikulliModifikim.Value);
                int i = gridArtikujt.Row;
                if (i < 0 || i == gridArtikujt.RowCount - 1)
                    return 1;
                DataRow drSearch = dsReceta.Tables[1].Rows.Find(idArtikulli);
                if (drSearch == null)
                    return 0;
                else if (Convert.ToInt32(drSearch["ID"]) == Convert.ToInt32(gridArtikujt.GetRow(i).Cells["ID"].Text))
                    return 0;
                else
                {
                    MessageBox.Show(this, "Ky artikull figuron një herë në recetë!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }
            }
        }

        private int GabimNeKonfigurimRecete()
        {
            if (dsReceta.Tables[1].Rows.Count == 0)
            {
                MessageBox.Show(this, "Receta duhet të përmbajë të paktën një artikull!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 1;
            }
            if (txtEmriReceta.Text == "" || cmbKategoriaReceta.Value == null || cmbKategoriaReceta.Text == "")
                return 1;
            if (dsReceta.Tables[0].Rows.Count == 0)
            {
                DataRow newR = dsReceta.Tables[0].NewRow();
                newR["EMRI"] = txtEmriReceta.Text;
                newR["ID_KATEGORIARECETA"] = Convert.ToInt32(cmbKategoriaReceta.Value);
                dsReceta.Tables[0].Rows.Add(newR);
            }
            else
            {
                dsReceta.Tables[0].Rows[0]["EMRI"] = txtEmriReceta.Text;
                dsReceta.Tables[0].Rows[0]["ID_KATEGORIARECETA"] = Convert.ToInt32(cmbKategoriaReceta.Value);
            }
            dsReceta.AcceptChanges();
            return 0;
        }

        private void ShtoRecete()
        {
            if (GabimNeKonfigurimRecete() == 0)
            {
                InputController data = new InputController();
                int b = data.KerkesaUpdate("ShtoRecete", dsReceta, dsEkstrat);
                if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston një recetë me të njëjtin emër." + Environment.NewLine
                        + "Ju lutem ndryshoni emrin e recetës!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (b == 1)
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë ruajtjes së recetës. Provoni përsëri!" , 
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show(this, "Receta e re u shtua në restorant!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PastroRecete();
                    btnKerko_Click(new object(), new EventArgs());
                    uiTabModifiko.Visible = false;
                    gridRecetat.Visible = true;
                    AktivizoPanel(panelTop);
                    AktivizoPanel(panelBottom);
                    if (gridArtikujt.RowCount == 0)
                        MbushGride("");
                }
            }
        }

        /// <summary>
        /// Gjate modifikimit te recetes receta e meparshme do te ruhet por 
        /// do te krijohet nje recete e re me te njejtin emer
        /// vetem kjo e fundit do te jete e vlefshme per tu aksesuar me tej
        /// </summary>
        private void ModifikoRecete()
        {
            if (GabimNeKonfigurimRecete() == 0)
            {
                InputController data = new InputController();
                int b = data.KerkesaUpdate("ModifikoRecete",  this.idReceta, dsReceta, this.dsEkstrat);
                if (b == 2)
                {
                    MessageBox.Show(this, "Ekziston një recetë me të njëjtin emër." + Environment.NewLine
                        + "Ju lutem ndryshoni emrin e recetës!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               else if (b == 1)
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë ruajtjes së recetës. Provoni përsëri!" , 
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else 
                {
                    string ms = "Receta e zgjedhur u modifikua!" + Environment.NewLine + "Nqs keni modifikuar përmbajtjen së recetës" +
                        Environment.NewLine+"duhet të rikonfiguroni çmimet!";
                    MessageBox.Show(this, ms, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PastroRecete();
                    btnKerko_Click(new object(), new EventArgs());
                    uiTabModifiko.Visible = false;
                    gridRecetat.Visible = true;
                    AktivizoPanel(panelTop);
                    AktivizoPanel(panelBottom);
                    if (gridArtikujt.RowCount == 0)
                        MbushGride("");

                }
            }
        }

        private void AddConditionalFormatting()
        {
            GridEXFormatCondition fc = new GridEXFormatCondition(
                this.gridRecetat.RootTable.Columns["DISPONUESHEM"],
                ConditionOperator.Equal, false);
            //fc.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            fc.FormatStyle.ForeColor = Color.Red;
            //fc.FormatStyle.FontStrikeout = TriState.True;
            this.gridRecetat.RootTable.FormatConditions.Add(fc);

        }

        private DataSet GjejRecetatEZgjedhura(string veprimi)
        {
            DataSet dsErase = new DataSet();
            dsErase.Tables.Add();
            dsErase.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            if (veprimi == "fshi")
                dsErase.Tables[0].Columns.Add("EMRI", typeof(String));
            DataColumn[] celesPrimar = new DataColumn[1];
            celesPrimar[0] = dsErase.Tables[0].Columns["ID_RECETA"];
            dsErase.Tables[0].PrimaryKey = celesPrimar;
            dsErase.AcceptChanges();
            for (int i = 0; i < gridRecetat.RowCount; i++)
            {
                if (gridRecetat.GetRow(i).Cells["CHECKED"].Text == "True")
                {
                    int idReceta = Convert.ToInt32(gridRecetat.GetRow(i).Cells["ID_RECETA"].Text);
                    string emriReceta = gridRecetat.GetRow(i).Cells["EMRI"].Text;
                    DataRow drSearch = dsErase.Tables[0].Rows.Find(idReceta);
                    if (drSearch == null)
                    {
                        DataRow newR = dsErase.Tables[0].NewRow();
                        newR["ID_RECETA"] = idReceta;
                        if (veprimi == "fshi")
                            newR["EMRI"] = emriReceta;
                        dsErase.Tables[0].Rows.Add(newR);
                    }
                }
            }
            dsErase.AcceptChanges();
            return dsErase;
        }

        private void BllokoKerkimin()
        {
            this.txtRecetaKerkim.Text = "";
            this.txtRecetaKerkim.Enabled = false;
            this.txtRecetaKerkim.BackColor = Color.White;

            this.cmbKategoriaRecetaKerkim.Enabled = false;
            this.cmbKategoriaRecetaKerkim.Text = "";
            this.cmbKategoriaRecetaKerkim.BackColor = Color.White;

            this.cmbKategoriaArtikujKerkim.Enabled = false;
            this.cmbKategoriaArtikujKerkim.Value = null;
            this.cmbKategoriaArtikujKerkim.BackColor = Color.White;

            this.cmbArtikujtKerkim.Enabled = false;
            this.cmbArtikujtKerkim.Value = null;
            this.cmbArtikujtKerkim.BackColor = Color.White;
        }

        #endregion

        #region EventHandlers
        #region Checked Changed

        private void cbReceta_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbReceta.Checked == true)
            {
                this.txtRecetaKerkim.Enabled = true;
                this.txtRecetaKerkim.Focus();

            }
            else
            {
                this.txtRecetaKerkim.Text = "";
                this.txtRecetaKerkim.Enabled = false;
                this.txtRecetaKerkim.BackColor = Color.White;

            }
        }

        private void cbKategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbKategoria.Checked == true)
            {
                this.cmbKategoriaRecetaKerkim.Enabled = true;
                this.cmbKategoriaRecetaKerkim.Focus();
            }
            else
            {
                this.cmbKategoriaRecetaKerkim.Enabled = false;
                this.cmbKategoriaRecetaKerkim.Value = null;
                this.cmbKategoriaRecetaKerkim.BackColor = Color.White;
            }
        }

        private void cbArtikujt_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbArtikujt.Checked == true)
            {
                this.cmbKategoriaArtikujKerkim.Enabled = true;
                this.cmbArtikujtKerkim.Enabled = true;

                this.cmbKategoriaArtikujKerkim.Focus();
            }
            else
            {
                this.cmbKategoriaArtikujKerkim.Enabled = false;
                this.cmbKategoriaArtikujKerkim.Value = null; 
                this.cmbKategoriaArtikujKerkim.BackColor = Color.White;

                this.cmbArtikujtKerkim.Enabled = false;
                this.cmbArtikujtKerkim.Value = null;
                this.cmbArtikujtKerkim.BackColor = Color.White;
            }
        }
        #endregion

        #region Combo Value Changed
        private void cmbKategoriteArtikulli_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idKategoria = Convert.ToInt32(cmbKategoriteArtikulli.Value);
                cmbArtikulli.DataSource = this.ArtikujtPerKategori(idKategoria).Tables[0];
                cmbArtikulli.Value = null;
                cmbArtikulli.Text = "";
                numSasia.Value = 0;
                txtNjesia.Text = "";
                txtCmimiBlerje.Text = "";
            }
            catch (Exception ex)
            {
                this.cmbArtikulli.DataSource = null;
                cmbArtikulli.Value = null;
                cmbArtikulli.Text = "";
                numSasia.Value = 0;
                txtNjesia.Text = "";
                txtCmimiBlerje.Text = "";
            }

            if (this.cmbKategoriteArtikulli.Text.Trim() == "")
            {
                this.cmbArtikulli.DataSource = null;
                cmbArtikulli.Value = null;
                cmbArtikulli.Text = "";
                numSasia.Value = 0;
                txtNjesia.Text = "";
                txtCmimiBlerje.Text = "";
            }
        }

        private void cmbKategoriaArtikujKerkim_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                int idKategoria = Convert.ToInt32(cmbKategoriaArtikujKerkim.Value);
                cmbArtikujtKerkim.DataSource = this.ArtikujtPerKategori(idKategoria).Tables[0];
                cmbArtikujtKerkim.Value = null;
                cmbArtikujtKerkim.Text = "";
            }
            catch (Exception ex)
            {
                this.cmbArtikujtKerkim.DataSource = null;
            }

            if (this.cmbKategoriaArtikujKerkim.Text.Trim() == "")
            {
                this.cmbArtikujtKerkim.DataSource = null;
            }
        }

        private void cmbKategoriteArtikulliModifikim_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idKategoria = Convert.ToInt32(cmbKategoriteArtikulliModifikim.Value);
                cmbArtikulliModifikim.DataSource = this.ArtikujtPerKategori(idKategoria).Tables[0];
                cmbArtikulliModifikim.Value = null;
                cmbArtikulliModifikim.Text = "";
                numSasiaModifikim.Value = 0;
                txtNjesiaModifikim.Text = "";
                txtCmimiBlerjeModifikim.Text = "";
            }
            catch (Exception ex)
            {
                cmbArtikulliModifikim.DataSource = null;
                cmbArtikulliModifikim.Value = null;
                cmbArtikulliModifikim.Text = "";
                numSasiaModifikim.Value = 0;
                txtNjesiaModifikim.Text = "";
                txtCmimiBlerjeModifikim.Text = "";
            }

            if (this.cmbKategoriteArtikulliModifikim.Text.Trim() == "")
            {
                cmbArtikulliModifikim.DataSource = null;
                cmbArtikulliModifikim.Value = null;
                cmbArtikulliModifikim.Text = "";
                numSasiaModifikim.Value = 0;
                txtNjesiaModifikim.Text = "";
                txtCmimiBlerjeModifikim.Text = "";
            }
        }

        private void cmbArtikulli_ValueChanged(object sender, EventArgs e)
        {
            if (cmbArtikulli.DropDownList.Row >= 0)
            {
                txtNjesia.Text = cmbArtikulli.DropDownList.GetRow(cmbArtikulli.DropDownList.Row).Cells["NJESIA"].Text;
                txtCmimiBlerje.Text = cmbArtikulli.DropDownList.GetRow(cmbArtikulli.DropDownList.Row).Cells["CMIMI"].Text;

            }
        }

        private void cmbArtikulliModifikim_ValueChanged(object sender, EventArgs e)
        {
            if (cmbArtikulliModifikim.DropDownList.Row >=0 )
            {
                txtNjesiaModifikim.Text = cmbArtikulliModifikim.DropDownList.GetRow(cmbArtikulliModifikim.DropDownList.Row).Cells["NJESIA"].Text;
                txtCmimiBlerjeModifikim.Text = cmbArtikulliModifikim.DropDownList.GetRow(cmbArtikulliModifikim.DropDownList.Row).Cells["CMIMI"].Text;
            }
        }


        #endregion

        #region gridRecetat EventHandlers
        private void gridRecetat_CurrentCellChanged(object sender, EventArgs e)
        {
            int index = this.gridRecetat.Row;
            if (index == 0 && upDirection == 1)
            {
                if (gridRecetat.RowCount >= 4)
                    gridRecetat.Row = 3;
                else
                    gridRecetat.Row = gridRecetat.RowCount - 1;
                return;
            }
            if (index == 0)
            {
                int i = index;
                while (i < gridRecetat.RowCount)
                {
                    i++;
                    if (gridRecetat.GetRow(i).Cells["ID_RECETA"].Text != "" ||
                        i == gridRecetat.RowCount - 1)
                        break;
                }
                gridRecetat.Row = i;
                return;
            }
            if ((index >= 0) && (gridRecetat.GetRow(index).Cells["ID_RECETA"].Text != ""))
            {
                PlotesoTeDhena();
            }
            else
            {
                if ((index > 1) && (upDirection == 1))
                {
                    gridRecetat.Row = index - 1;
                    return;
                }
                if (gridRecetat.RowCount > index + 1 && upDirection == 0)
                {
                    gridRecetat.Row = index + 1;
                    return;
                }
            }
        }

        private void gridRecetat_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            gridRecetat.Refresh();
            gridRecetat.UpdateData();
        }

        private void gridRecetat_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (e.Column.Key == "CHECKED")
            {
                Janus.Windows.GridEX.GridEXRow r = gridRecetat.GetRow(gridRecetat.Row);
                int idReceta = Convert.ToInt32(r.Cells["ID_RECETA"].Text);
                if (r.Cells["CHECKED"].Text != "")
                {
                    bool vlera = Convert.ToBoolean(r.Cells["CHECKED"].Text);
                    bool finish = false;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        if (Convert.ToInt32(dr["ID_RECETA"]) == idReceta)
                        {
                            dr["CHECKED"] = vlera;
                            finish = true;
                        }
                        else if (finish)
                            break;
                    }
                }
            }
        }
        #endregion

        #region Navigate Grid
        private void btnPari_Click(object sender, EventArgs e)
        {
            gridRecetat.ExpandGroups();
            if (gridRecetat.RowCount > 0)
            {
                gridRecetat.Row = 0;
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            upDirection = 1;
            gridRecetat.ExpandGroups();

            if (gridRecetat.Row == gridRecetat.RowCount - 1)
            {
                gridRecetat.Row = gridRecetat.Row - 2;
                return;
            }

            int idReceta = 0;
            if (gridRecetat.GetRow(gridRecetat.Row).Cells["ID_RECETA"].Text != "")
                idReceta = Convert.ToInt32(gridRecetat.GetRow(gridRecetat.Row).Cells["ID_RECETA"].Text);
            while ((gridRecetat.GetRow(gridRecetat.Row).Cells["ID_RECETA"].Text != "")
                && (idReceta == Convert.ToInt32(gridRecetat.GetRow(gridRecetat.Row).Cells["ID_RECETA"].Text))
                && (gridRecetat.Row != 2))
            {
                if ((gridRecetat.Row >= 1) && (gridRecetat.Row - 1 >= 0))
                {
                    gridRecetat.Row = gridRecetat.Row - 1;
                }
            }
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            upDirection = 0;
            gridRecetat.ExpandGroups();
            int idReceta = 0;
            if (gridRecetat.GetRow(gridRecetat.Row).Cells["ID_RECETA"].Text != "")
                idReceta = Convert.ToInt32(gridRecetat.GetRow(gridRecetat.Row).Cells["ID_RECETA"].Text);
            while ((gridRecetat.GetRow(gridRecetat.Row).Cells["ID_RECETA"].Text != "")
                && (idReceta == Convert.ToInt32(gridRecetat.GetRow(gridRecetat.Row).Cells["ID_RECETA"].Text)))
            {

                if ((gridRecetat.Row <= gridRecetat.RowCount - 2) &&
                    (gridRecetat.Row + 1 >= 0) &&
                    (gridRecetat.Row != gridRecetat.RowCount - 1))
                {
                    gridRecetat.Row = gridRecetat.Row + 1;
                }
            }
        }

        private void btnFundit_Click(object sender, EventArgs e)
        {
            gridRecetat.ExpandGroups();
            if ((gridRecetat.RowCount > 0) && (gridRecetat.RowCount - 3 >= 0))
            {
                gridRecetat.Row = gridRecetat.RowCount - 3;
            }
        }
        #endregion

        private void btnShtoRecete_Click(object sender, EventArgs e)
        {
            PastroRecete();
            uiTabPageModifiko.Text = "Shto recetë";
            uiTabPageModifiko.Image = ResManagerAdmin.Properties.Resources.news_info;
            this.txtKostojaReceta.Visible = false;
            this.gridRecetat.Visible = false;
            this.uiTabModifiko.Visible = true;
            this.CaktivizoPanel(panelTop);
            CaktivizoPanel(panelBottom);
            this.txtEmriReceta.Focus();
            this.dsEkstrat.Tables[0].Rows.Clear();
        }

        private void btnModifikoRecete_Click(object sender, EventArgs e)
        {
            int index = gridRecetat.Row;
            if (index >= 2 && gridRecetat.GetRow(index).Cells["ID_RECETA"].Text != "")
            {
                uiTabPageModifiko.Text = "Modifiko recetë";
                uiTabPageModifiko.Image = ResManagerAdmin.Properties.Resources.forum_newmsg;
                PlotesoTeDhena();
                //this.txtKostojaReceta.Visible = true;
                this.gridRecetat.Visible = false;
                this.uiTabModifiko.Visible = true;
                this.CaktivizoPanel(panelTop);
            }
        }

        private void btnRuajRecete_Click(object sender, EventArgs e)
        {
            this.gridRecetat.Visible = true;
            this.uiTabModifiko.Visible = false;
            this.AktivizoPanel(panelTop);
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.gridRecetat.Visible = true;
            this.uiTabModifiko.Visible = false;
            this.AktivizoPanel(panelTop);
        }

        private bool KaGabimNeKerkim()
        {

            if (this.cbArtikujt.Checked == true)
            {
                if (this.cmbArtikujtKerkim.Text.Trim() == "")
                {
                    MessageBox.Show("Ju duhet te zgjidhni nje prej artikujve !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                try
                {
                    int idArtikulli = Convert.ToInt32(this.cmbArtikujtKerkim.Value);


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Artikulli i zgjedhur nga ju nuk eshte i regjistruar ne program !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                
            }



            if (this.cbKategoria.Checked == true)
            {
                if (this.cmbKategoriaRecetaKerkim.Text.Trim() == "")
                {
                    MessageBox.Show("Ju duhet te zgjidhni nje nga kategorite e recetave !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                try
                {
                    int idKat = Convert.ToInt32(this.cmbKategoriaRecetaKerkim.Value);


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Kategoria e zgjedhur nga ju nuk eshte e regjistruar ne program !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                
            }

            return false;
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            if (this.KaGabimNeKerkim() == true)
            {
                return;
            }

            if (cbReceta.Checked == false && cbKategoria.Checked == false && cbArtikujt.Checked == false)
            {

            }
            else
            {
                string s = "WHERE ";
                bool check1 = false;
                string strDesc="";

                if (cbReceta.Checked == true)
                {
                    s += " dbo.RECETAT.EMRI LIKE '" + txtRecetaKerkim.Text + "%'";
                    check1 = true;
                    strDesc = "Recetat me emër " + txtRecetaKerkim.Text;
                }

                if (cbKategoria.Checked == true)
                {
                    if (cmbKategoriaRecetaKerkim.Value != null && cmbKategoriaRecetaKerkim.Text != "")
                    {
                        if (check1)
                        {
                            s += " AND dbo.RECETAT.ID_KATEGORIARECETA = " + Convert.ToInt32(cmbKategoriaRecetaKerkim.Value);
                            strDesc += ", të kategorisë " + cmbKategoriaRecetaKerkim.Text;
                        }
                        else
                        {
                            s += " dbo.RECETAT.ID_KATEGORIARECETA = " + Convert.ToInt32(cmbKategoriaRecetaKerkim.Value);
                            check1 = true;
                            strDesc += "Recetat për kategorinë " + cmbKategoriaRecetaKerkim.Text;
                        }
                    }
                    else
                        return;
                }

                if (cbArtikujt.Checked == true)
                {
                    if (cmbKategoriaArtikujKerkim.Value != null && cmbKategoriaArtikujKerkim.Text != ""
                        && cmbArtikujtKerkim.Value != null && cmbArtikujtKerkim.Text != "")
                    {
                        if (check1)
                        {
                            s += " AND dbo.ARTIKUJT.ID_ARTIKULLI =  " + Convert.ToInt32(cmbArtikujtKerkim.Value);
                            strDesc += ", që përmbajnë artikullin " + cmbArtikujtKerkim.Text;
                        }
                        else
                        {
                            s += " dbo.ARTIKUJT.ID_ARTIKULLI =  " + Convert.ToInt32(cmbArtikujtKerkim.Value);
                            check1 = true;
                            strDesc += "Recetat që përmbajnë artikullin " + cmbArtikujtKerkim.Text;
                        }
                    }
                    else
                        return;
                }
                MbushGride(s);
                Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + strDesc;
                gridRecetat.Visible = true;
                uiTabModifiko.Visible = false;
                AktivizoPanel(panelTop);
            }
        }
        
        private void btnAnullo_Click_1(object sender, EventArgs e)
        {
            PastroRecete();
            uiTabModifiko.Visible = false;
            gridRecetat.Visible = true;
            AktivizoPanel(panelTop);
            AktivizoPanel(panelBottom);
        }

        private void gridArtikujt_CurrentCellChanged(object sender, EventArgs e)
        {
            int i = gridArtikujt.Row;
            if (i >= 0 && i != gridArtikujt.RowCount - 1 && uiTabPerberesit.SelectedIndex == 2)
            {
                Janus.Windows.GridEX.GridEXRow rGrid = gridArtikujt.GetRow(i);
                this.cmbKategoriteArtikulliModifikim.Value = Convert.ToInt32(rGrid.Cells["ID_KATEGORIAARTIKULLI"].Text);
                cmbArtikulliModifikim.Value = Convert.ToInt32(rGrid.Cells["ID_ARTIKULLI"].Text);
                numSasiaModifikim.Value = Convert.ToDecimal(rGrid.Cells["SASIA"].Text);
                txtNjesiaModifikim.Text = rGrid.Cells["NJESIA"].Text;
                if (rGrid.Cells["CMIMI"].Text == "")
                    txtCmimiBlerjeModifikim.Text = "";
                else
                    txtCmimiBlerjeModifikim.Text = rGrid.Cells["CMIMI"].Text;
            }
        }

        private bool KaGabimShtimArtikulli()
        {
            if (this.cmbArtikulli.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te zgjidhni nje prej artikujve !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            try
            {
                int idArtikulli = Convert.ToInt32(this.cmbArtikulli.Value);


            }

            catch (Exception ex)
            {
                MessageBox.Show("Artikulli i zgjedhur nga ju nuk eshte i regjistruar ne program !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private bool KaGabimModifikimArtikulli()
        {
            if (this.cmbArtikulliModifikim.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te zgjidhni nje prej artikujve !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            try
            {
                int idArtikulli = Convert.ToInt32(this.cmbArtikulliModifikim.Value);


            }

            catch (Exception ex)
            {
                MessageBox.Show("Artikulli i zgjedhur nga ju nuk eshte i regjistruar ne program !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void btnRuajPerberesRi_Click(object sender, EventArgs e)
        {
            if (this.KaGabimShtimArtikulli() == true)
            {
                return;
            }

            if (GabimNeKonfigurimArtikulli() == 0)
            {
                DataRow newR = dsReceta.Tables[1].NewRow();
                newR["ID_ARTIKULLI"] = Convert.ToInt32(cmbArtikulli.Value);
                newR["SASIA"] = Convert.ToDouble(numSasia.Value);
                newR["NJESIA"] = txtNjesia.Text;
                newR["ARTIKULLI"] = cmbArtikulli.Text;
                if (txtCmimiBlerje.Text != "")
                    newR["CMIMI"] = Convert.ToDouble(txtCmimiBlerje.Text);
                newR["ID_KATEGORIAARTIKULLI"] = Convert.ToInt32(cmbKategoriteArtikulli.Value);
                newR["SASIA_STR"] = Convert.ToDouble(numSasia.Value).ToString() + " " + txtNjesia.Text;
                if (txtCmimiBlerje.Text != "")
                    newR["VLERA"] = Convert.ToString(Convert.ToDouble(numSasia.Value) * Convert.ToDouble(txtCmimiBlerje.Text));
                newR["CHECKED"] = false;
                newR["ID"] = dsReceta.Tables[1].Rows.Count + 1;
                dsReceta.Tables[1].Rows.Add(newR);
                dsReceta.AcceptChanges();
                gridArtikujt.DataSource = dsReceta.Tables[1];
                gridArtikujt.Refetch();
                if (gridArtikujt.RowCount - 1 >= 0)
                    txtKostojaReceta.Text = gridArtikujt.GetRow(gridArtikujt.RowCount - 1).Cells["VLERA"].Text;

                //pastro fusha
                //cmbKategoriteArtikulli.Value = null;
                //cmbKategoriteArtikulli.Text = "";
                //cmbArtikulli.DataSource = null;
                cmbArtikulli.Text = "";
                numSasia.Value = 0;
                txtNjesia.Clear();
                txtCmimiBlerje.Clear();
                this.cmbKategoriteArtikulli.Focus();
            }
        }

        private void btnModifikoPerberes_Click(object sender, EventArgs e)
        {
            if (this.KaGabimModifikimArtikulli() == true)
            {
                return;
            }

            if (GabimNeKonfigurimArtikulli() == 0)
            {
                int index = gridArtikujt.Row;
                if (index >= 0 && gridArtikujt.GetRow(index).Cells["ID_ARTIKULLI"].Text != "")
                {
                    int idArtikulli = Convert.ToInt32(gridArtikujt.GetRow(index).Cells["ID_ARTIKULLI"].Text);
                    DataRow rowU = dsReceta.Tables[1].Rows.Find(idArtikulli);
                    rowU["ID_ARTIKULLI"] = Convert.ToInt32(cmbArtikulliModifikim.Value);
                    rowU["SASIA"] = Convert.ToDouble(numSasiaModifikim.Value);
                    rowU["NJESIA"] = txtNjesiaModifikim.Text;
                    rowU["ARTIKULLI"] = cmbArtikulliModifikim.Text;
                    if (txtCmimiBlerjeModifikim.Text != "")
                        rowU["CMIMI"] = Convert.ToDouble(txtCmimiBlerjeModifikim.Text);
                    else
                        rowU["CMIMI"] = "";
                    rowU["ID_KATEGORIAARTIKULLI"] = Convert.ToInt32(cmbKategoriteArtikulliModifikim.Value);
                    rowU["SASIA_STR"] = Convert.ToDouble(numSasiaModifikim.Value).ToString() + " " + txtNjesiaModifikim.Text;
                    if (txtCmimiBlerjeModifikim.Text != "")
                        rowU["VLERA"] = Convert.ToString(Convert.ToDouble(numSasiaModifikim.Value) * Convert.ToDouble(txtCmimiBlerjeModifikim.Text));
                    rowU["CHECKED"] = false;
                    dsReceta.AcceptChanges();
                    gridArtikujt.DataSource = dsReceta.Tables[1];
                    if (gridArtikujt.RowCount - 1 >= 0)
                        txtKostojaReceta.Text = gridArtikujt.GetRow(gridArtikujt.RowCount - 1).Cells["VLERA"].Text;

                    //pastro fusha
                    cmbKategoriteArtikulliModifikim.Value = null;
                    cmbKategoriteArtikulliModifikim.Text = "";
                    cmbArtikulliModifikim.DataSource = null;
                    cmbArtikulliModifikim.Text = "";
                    numSasiaModifikim.Value = 0;
                    txtNjesiaModifikim.Clear();
                    txtCmimiBlerjeModifikim.Clear();
                }
            }
        }

        private void btnHiqArtikull_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dsReceta.Tables[1].Rows)
            {
                if (dr["CHECKED"].ToString() == "True")
                {
                        dr.Delete();
                }
            }
            dsReceta.AcceptChanges();
        }

        private void uiTabPerberesit_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            if (uiTabPerberesit.SelectedIndex == 2)
            {
                cmbKategoriteArtikulliModifikim.Value = null;
                cmbKategoriteArtikulliModifikim.Text = "";
                cmbArtikulliModifikim.DataSource = null;
                cmbArtikulliModifikim.Text = "";
                cmbArtikulliModifikim.Value = "";
                numSasiaModifikim.Value = 0;
                txtNjesiaModifikim.Clear();
                txtCmimiBlerjeModifikim.Clear();
            }
        }

        private void btnPerfundo_Click(object sender, EventArgs e)
        {
            
            if (uiTabPageModifiko.Text == "Shto recetë")
            {
                ShtoRecete();
            }
            else if (uiTabPageModifiko.Text == "Modifiko recetë")
            {
                ModifikoRecete();
            }
        }

        private void btnAktivizo_Click(object sender, EventArgs e)
        {
            DataSet dsErase = GjejRecetatEZgjedhura("");
            if (dsErase.Tables[0].Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show(this, "Recetat e zgjedhura do të figurojnë më në menu." +
                Environment.NewLine + "Rrjedhimisht ato mund të përdoren lirshëm në fatura." +
                Environment.NewLine + "Jeni të sigurtë që doni të vazhdoni me vendosjen në menu?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
                InputController data = new InputController();
                int b = data.KerkesaUpdate("NdryshoDisponibilitet",1, dsErase);
                if (b != 0)
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë vendosjes së recetave në menu. Provoni përsëri!",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (b == 0)
                {
                    MessageBox.Show(this, "Recetat e zgjedhura u vendosën në menu!",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnKerko_Click(sender, e);
                    if (gridRecetat.RowCount == 0)
                        MbushGride("");
                }
            }
        }

        private void btnCaktivizo_Click(object sender, EventArgs e)
        {
            DataSet dsErase = GjejRecetatEZgjedhura("");
            if (dsErase.Tables[0].Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show(this, "Recetat e zgjedhura nuk do të fshihen por nuk do të figurojnë më në menu." +
                Environment.NewLine + "Rrjedhimisht ato nuk mund të përdoren më në fatura." +
                Environment.NewLine + "Jeni të sigurtë që doni të vazhdoni me heqjen nga menuja?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
                InputController data = new InputController();
                int b = data.KerkesaUpdate("NdryshoDisponibilitet", 0, dsErase);
                if (b != 0)
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë heqjes së recetave nga menuja. Provoni përsëri!",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (b == 0)
                {
                    MessageBox.Show(this, "Recetat e zgjedhura u hoqën nga menuja!",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnKerko_Click(sender, e);
                    if (gridRecetat.RowCount == 0)
                        MbushGride("");
                }
            }
        }

        private void btnFshiRecete_Click(object sender, EventArgs e)
        {
            DataSet dsErase = GjejRecetatEZgjedhura("fshi");
            if (dsErase.Tables[0].Rows.Count != 0)
            {
                DialogResult result = MessageBox.Show(this, "Jeni të sigurt që doni të fshini recetat e zgjedhura?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
                InputController data = new InputController();
                int b = data.KerkesaUpdate("FshiRecetat", dsErase);
                if (b != 0)
                {
                    MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së recetave. Provoni përsëri!",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this, "Të gjitha recetat e zgjedhura u fshinë!",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnKerko_Click(sender, e);
                    if (gridRecetat.RowCount == 0)
                        MbushGride("");
                }
            }
        }
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.gridRecetat.RowCount != 0)
            {
                frmRaportJanus frmPrint = new frmRaportJanus();
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
            this.gridRecetat.ExpandGroups();
            string[] fushat = new string[4];
            string[] llojet = new string[4];
            string[] key = new string[4];
            fushat[0] = "Artikulli";
            fushat[1] = "Sasia";
            fushat[2] = "Cmimi_i_blerjes";
            fushat[3] = "Kosto";

            key[0] = "ARTIKULLI";
            key[1] = "SASIA_STR";
            key[2] = "CMIMI";
            key[3] = "VLERA";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "float";
            llojet[3] = "float";

            KlaseExcel excel = new KlaseExcel("Recetat.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("Recetat.xls", gridRecetat, fushat, key, llojet,
                    "ARTIKULLI");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Recetat.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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

        public void Print()
        {
            if (gridRecetat.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion

        private void cmbKategoriaArtikujKerkim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbKategoriteArtikulli.Value == null || cmbKategoriteArtikulli.Text == "")
                e.Handled = false;

        }

        private void numSasia_Enter(object sender, EventArgs e)
        {
            this.numSasia.Select(0, numSasia.Value.ToString("0.00").Length);
        }

        private void btnShtoEkstra_Click(object sender, EventArgs e)
        {
            frmEkstrat frm = new frmEkstrat();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.dsEkstrat = this.dsEkstrat;
            frm.ShowDialog();

            if (frm.veprimi == 1)
            {
                this.gridaEkstrat.DataSource = frm.dsEkstrat.Tables[0];
                this.dsEkstrat = frm.dsEkstrat;
            }
        }

        private void frmKonfigurimRecetash_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            MbushCombo();
            this.MbushGride("");
        }
  }
}