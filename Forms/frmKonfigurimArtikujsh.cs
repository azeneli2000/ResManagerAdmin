using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using ResManagerAdmin.BusDatService;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmKonfigurimArtikujsh : System.Windows.Forms.Form, IPrintable
    {
        private string PicturePath;
        private int idArtikulliModifiko;
        private int upDirection = 0;

        private string emri = "";
        private int idKategoria = 0;
        private bool konsumi = false;
        private int idNjesia = 0;
        private double cmimi = 0;
        private double sasiaSkorte = 0;
        private Image foto = null;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        #region Form Load
        public frmKonfigurimArtikujsh()
        {
            InitializeComponent();
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void frmKonfigurimArtikujsh_Load(object sender, EventArgs e)
        {
            this.LexoInformacione();

            this.PicturePath = "";
            //gridArtikujt.Size = new Size(619, 428);
            this.AddConditionalFormatting();
            gridArtikujt.BringToFront();
            this.BllokoKerkimin();

            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            
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

        private void MbushKomboKategorite()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEArtikujve");
            this.cboKategoria.DataSource = ds.Tables[0];


        }

        private void MbushKomboKategoriteBaze()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqKategoriteEArtikujve");
            this.cboKategoriaBaze.DataSource = ds.Tables[0];


        }

        private void MbushKomboNjesia()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqNjesiteMatese");
            this.cboNjesia.DataSource = ds.Tables[0];
        }

        private void PastroTekstet()
        {
          
                this.txtEmri.Text = "";
                this.cboKategoria.Value = null;
                
                this.chkKonsumi.Checked = false;
                this.cboNjesia.Value = null;
                this.cboSasiaSkorte.Value = 0;

                this.pcbFoto.Image = null;
                this.PicturePath = "";
           

        }

        private void MbushGridenArtikujt()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqArtikujt");
            this.gridArtikujt.DataSource = ds.Tables[0];

            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            Doc.GridEX = gridArtikujt;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Artikujt në Bar Restorant";
            Doc.DefaultPageSettings.Landscape = true;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;

        }

        private DataSet KonvertoDataSetin(DataSet ds)
        {
            DataSet dsNew = new DataSet();
            return dsNew;
        }

        private void AddConditionalFormatting()
        {
            GridEXFormatCondition fc = new GridEXFormatCondition(
                this.gridArtikujt.RootTable.Columns["colDisponibiliteti"],
                ConditionOperator.Equal, false);
            //fc.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            //fc.FormatStyle.ForeColor = Color.Chocolate;
            fc.FormatStyle.FontStrikeout = TriState.True;
            this.gridArtikujt.RootTable.FormatConditions.Add(fc);

        }

        private void Kerko(string kodi)
        {
            Janus.Windows.GridEX.ConditionOperator operatori = new Janus.Windows.GridEX.ConditionOperator();
            operatori = Janus.Windows.GridEX.ConditionOperator.Equal;
            Janus.Windows.GridEX.GridEXFilterCondition kusht = new Janus.Windows.GridEX.GridEXFilterCondition(gridArtikujt.RootTable.Columns["colEmri"], operatori, kodi);
            gridArtikujt.Find(kusht, 0, -1);
        }

        private string ZgjidhLogo(System.Windows.Forms.OpenFileDialog c, string s)
        {
            c.FileName = "";
            string result = "";
            c.CheckFileExists = true;
            try
            {
                c.Filter = s;
                c.ShowDialog();
                result = c.FileName;
                return result;
            }
            catch
            {
                return "";
            }
        }

        private bool KaGabimKerkimi()
        {
            if (this.chkKategoria.Checked == true)
            {
                if (this.cboKategoriaBaze.Text.Trim() == "")
                {
                    MessageBox.Show("Ju duhet te zgjidhni nje nga kategorite e artikujve !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                try
                {
                    int idKat = Convert.ToInt32(this.cboKategoriaBaze.Value);


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Kategoria e zgjedhur nga ju nuk eshte e regjistruar ne program !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

                return false;
            }

            return false;
        }

        private void BllokoKerkimin()
        {
            this.txtEmriBaze.Text = "";
            this.txtEmriBaze.Enabled = false;
            this.txtEmriBaze.BackColor = Color.White;

            this.cboKategoriaBaze.Enabled = false;
            this.cboKategoriaBaze.Text = "";
            this.cboKategoriaBaze.BackColor = Color.White;
        }

        private void MbushTeDhenaModifiko(int idArtikulli)
        {
            InputController data = new InputController();
            DataSet ds = null;

            ds = data.KerkesaRead("ShfaqTeDhenaPerArtikullin", idArtikulli);

            if (ds == null)
            {
                // mesazh gabimi

                return;

            }

            string emri = Convert.ToString(ds.Tables[0].Rows[0]["EMRI"]);
            int idKategoria = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_KATEGORIAARTIKULLI"]);
            string kodiKategoria = Convert.ToString(ds.Tables[0].Rows[0]["PERSHKRIMI"]);
            double cmimiShitje = Convert.ToDouble(ds.Tables[0].Rows[0]["CMIMI_SHITJE"]);
            double sasiaSkorte = Convert.ToDouble(ds.Tables[0].Rows[0]["SASIA_SKORTE"]);
            bool artikullKonsumi = Convert.ToBoolean(ds.Tables[0].Rows[0]["ARTIKULL_KONSUMI"]);
            int idNjesia = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_NJESIA"]);
            string njesia = Convert.ToString(ds.Tables[0].Rows[0]["NJESIA"]);
            string pathiFoto = Convert.ToString(ds.Tables[0].Rows[0]["FOTO"]);


            Image foto = null;
            if (pathiFoto != "")
            {
                foto = Image.FromFile(pathiFoto);
            }

            this.txtEmri.Text = emri;
            this.cboKategoria.Value = idKategoria;
            this.cboKategoria.Text = kodiKategoria;
            this.chkKonsumi.Checked = artikullKonsumi;
            this.cboNjesia.Value = idNjesia;
            this.cboNjesia.Text = njesia;
            this.cboSasiaSkorte.Value = Convert.ToDecimal(sasiaSkorte);
            this.pcbFoto.Image = foto;
        }

        private bool KaGabim()
        {
            if (this.cboKategoria.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te zgjidhni nje nga kategorite e artikujve !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            try
            {
                int idKat = Convert.ToInt32(this.cboKategoria.Value);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoria e zgjedhur nga ju nuk eshte e regjistruar ne program !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (this.txtEmri.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te jepni emri e artikullit !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }


            if (this.cboNjesia.Text.Trim() == "")
            {
                MessageBox.Show("Ju duhet te zgjidhni njesine matese te artikullit !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            try
            {
                int idNjesia = Convert.ToInt32(this.cboNjesia.Value);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Njesia e zgjedhur nga ju nuk eshte e regjistruar ne program !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        #endregion

        #region Event Handlers
        private void btnShtoArtikull_Click(object sender, EventArgs e)
        {
            
            this.CaktivizoPanel(panelTop);
            this.CaktivizoPanel(panelBottom);
            uiTabPageModifiko.Text = "Shtim";
            uiTabPageModifiko.Image = ResManagerAdmin.Properties.Resources.news_info;

            this.PastroTekstet();

            this.gridArtikujt.Visible = false;
            this.uiTabPageModifiko.Visible = true;
        }

        private void btnModifikoArtikull_Click(object sender, EventArgs e)
        {
            int indeksi = this.gridArtikujt.Row;
            if (indeksi < 0)
            {
                return;
            }
            if (this.gridArtikujt.GetRow(indeksi).Cells[0].Text == "")
            {
                return;
            }

            int idArtikulli = Convert.ToInt32(this.gridArtikujt.GetRow(indeksi).Cells[0].Text);

            this.gridArtikujt.Visible = false;
            this.uiTabPageModifiko.Visible = true;
            this.CaktivizoPanel(panelTop);
            uiTabPageModifiko.Text = "Modifikim";
            uiTabPageModifiko.Image = ResManagerAdmin.Properties.Resources.forum_newmsg;

            this.MbushTeDhenaModifiko(idArtikulli);

        }

        private void btnRuajArtikull_Click(object sender, EventArgs e)
        {
            if (this.KaGabim() == true)
            {
                return;
            }

            string emri = this.txtEmri.Text.Trim();
            int idKategoria = Convert.ToInt32(this.cboKategoria.Value);
            int idNjesia = Convert.ToInt32(this.cboNjesia.Value);
            double sasiaSkorte = Convert.ToDouble(this.cboSasiaSkorte.Value);
            int konsumi = 0;

            if (this.chkKonsumi.Checked == true)
            {
                konsumi = 1;
            }

            string pathiFoto = this.PicturePath;
            double cmimiArtikulli = 0;

            int b = 0;
            InputController data = new InputController();

            string veprimiStr = this.uiTabPageModifiko.Text;

            switch (veprimiStr)
            {
                case "Shtim":

                    b = data.KerkesaUpdate("KrijoArtikull", idKategoria, idNjesia, konsumi, emri, pathiFoto, cmimiArtikulli, sasiaSkorte);
                    if (b == 2)
                    {
                        MessageBox.Show(this, "Ekziston një artikull me të njëjtin emër!", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else if (b == 0)
                    {
                        //MessageBox.Show(this, "Artikulli i ri u krijua!", this.Text,
                        //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(this, "Një gabim ndodhi gjatë krijimit të artikullit. Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    break;

                case "Modifikim":

                    int indeksi = this.gridArtikujt.Row;
                    int idArtikulli = Convert.ToInt32(this.gridArtikujt.GetRow(indeksi).Cells[0].Text);

                    b = data.KerkesaUpdate("ModifikoArtikull", idArtikulli, idKategoria, idNjesia, konsumi, emri, pathiFoto, cmimiArtikulli, sasiaSkorte);

                    if (b == 2)
                    {
                        MessageBox.Show(this, "Ekziston një artikull me të njëjtin emër!", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else if (b == 0)
                    {
                        //MessageBox.Show(this, "Artikulli i ri u krijua!", this.Text,
                        //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        //MessageBox.Show(this, "Një gabim ndodhi gjatë modifikimit të artikullit. Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }


                    break;

                default:
                    break;

            }



            this.PastroTekstet();

            this.gridArtikujt.GroupMode = GroupMode.Collapsed;
            this.MbushGridenArtikujt();


            this.gridArtikujt.Visible = true;
            this.uiTabPageModifiko.Visible = false;
            this.AktivizoPanel(panelTop);
            this.AktivizoPanel(panelBottom);



            this.Kerko(emri);
            
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.PastroTekstet();

            this.gridArtikujt.Visible = true;
            this.uiTabPageModifiko.Visible = false;
            this.AktivizoPanel(panelTop);
            this.AktivizoPanel(panelBottom);
        }

        private void btnFshiArtikull_Click(object sender, EventArgs e)
        {
            InputController data = new InputController();
            DataSet dsFshi = new DataSet();
            dsFshi.Tables.Add();

            dsFshi.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            dsFshi.Tables[0].Columns.Add("EMRI", typeof(string));

            dsFshi.AcceptChanges();

            DataSet dsKthe = new DataSet();
            dsKthe.Tables.Add();

            dsKthe.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            dsKthe.Tables[0].Columns.Add("EMRI", typeof(string));

            dsKthe.AcceptChanges();

            int numriTotal = 0;

            DataRow dr = null;
            DataRow drKthe = null;

            for (int i = 0; i < this.gridArtikujt.RowCount; i++)
            {
                if (this.gridArtikujt.GetRow(i).Cells["colZgjedhur"].Text == "True")
                {
                    numriTotal = Convert.ToInt32(this.gridArtikujt.GetRow(i).Cells[8].Text);

                    if (numriTotal == 0)
                    {
                        dr = dsFshi.Tables[0].NewRow();
                        dr["ID_ARTIKULLI"] = Convert.ToInt32(this.gridArtikujt.GetRow(i).Cells["colCelesi"].Text);
                        dr["EMRI"] = Convert.ToString(this.gridArtikujt.GetRow(i).Cells["colEmri"].Text);

                        dsFshi.Tables[0].Rows.Add(dr);
                    }
                    else
                    {
                        drKthe = dsKthe.Tables[0].NewRow();
                        drKthe["ID_ARTIKULLI"] = Convert.ToInt32(this.gridArtikujt.GetRow(i).Cells["colCelesi"].Text);
                        drKthe["EMRI"] = Convert.ToString(this.gridArtikujt.GetRow(i).Cells["colEmri"].Text);

                        dsKthe.Tables[0].Rows.Add(drKthe);
                    }
                }
            }

            dsFshi.Tables[0].AcceptChanges();
            dsKthe.Tables[0].AcceptChanges();

            string strKthe = "";

            if (dsKthe.Tables[0].Rows.Count != 0)
            {
                strKthe = "Artikujt e meposhtem nuk mund te fshihen sepse kane gjendje te ndryshem nga  '0' ." + Environment.NewLine; ;

                foreach (DataRow drK in dsKthe.Tables[0].Rows)
                {
                    strKthe = strKthe + Environment.NewLine + " - " + Convert.ToString(drK[1]);

                }

                strKthe = strKthe + Environment.NewLine + Environment.NewLine + "Ju mund te fshini vetem artikujt me gjendje  '0' !";

                MessageBox.Show(this, strKthe, "Vemendje !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            if (dsFshi.Tables[0].Rows.Count == 0)
            {
                //MessageBox.Show("Artikujt e zgjedhur u fshine", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataSet dsError = data.KerkesaRead("FshiArtikujt", dsFshi);

            if (dsError == null)
            {
                MessageBox.Show(this, "Ju keni hasur probleme ne aksesimin e bazes se te dhenave.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dsError.Tables[0].Rows.Count == 0)
            {
                return;
            }

            string strMesazhi = "Artikujt e meposhtem nuk u fshine per shkak te referencave perkatese";

            string emri;
            bool ofertat;
            bool recetat;
            int nr = 0;
            int indeksi = 0;

            string strArtikulli;

            foreach (DataRow drError in dsError.Tables[0].Rows)
            {
                indeksi = indeksi + 1;
                emri = Convert.ToString(drError["EMRI"]);
                ofertat = Convert.ToBoolean(drError["OFERTAT"]);
                recetat = Convert.ToBoolean(drError["RECETAT"]);

                strArtikulli = Convert.ToString(indeksi) + ". " + emri + " perdoret ne ";



                if (ofertat == true)
                {
                    if (nr > 0)
                    {
                        strArtikulli += ", Ofertat";
                    }
                    else
                    {
                        strArtikulli += " Ofertat";
                    }

                    nr = nr + 1;
                }

                if (recetat == true)
                {
                    if (nr > 0)
                    {
                        strArtikulli += ", Recetat";
                    }
                    else
                    {
                        strArtikulli += " Recetat";
                    }

                    nr = nr + 1;
                }

                strArtikulli += " .";

                strMesazhi += Environment.NewLine + strArtikulli;


            }

            MessageBox.Show(this, strMesazhi, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.MbushGridenArtikujt();




        }

        private void btnGjejFoto_Click(object sender, EventArgs e)
        {
            string s = "";
            s = this.ZgjidhLogo(this.openFileDialog1, "Figura|*.bmp;*.ico;*.cur;*.jpg;*.gif;*.png");
            if (s == "")
            {
                return;
            }
            else
            {
                this.pcbFoto.Image = Image.FromFile(s);
                this.PicturePath = s;
            }
        }

        private void btnFshiFoto_Click(object sender, EventArgs e)
        {
            this.pcbFoto.Image = null;
            this.PicturePath = "";
        }

        private void btnCaktivizo_Click(object sender, EventArgs e)
        {
            int index = this.gridArtikujt.Row;
            if ((index < 0) || (this.gridArtikujt.GetRow(index).Cells[0].Text == ""))
            {
                return;
            }

            InputController data = new InputController();
            DataSet dsHiq = new DataSet();
            dsHiq.Tables.Add();

            dsHiq.Tables[0].Columns.Add("ID_ARTIKULLI", typeof(Int32));
            dsHiq.Tables[0].Columns.Add("EMRI", typeof(string));

            dsHiq.AcceptChanges();
            DataRow dr = null;
            for (int i = 0; i < this.gridArtikujt.RowCount; i++)
            {
                if (this.gridArtikujt.GetRow(i).Cells["colZgjedhur"].Text == "True")
                {
                    dr = dsHiq.Tables[0].NewRow();
                    dr["ID_ARTIKULLI"] = Convert.ToInt32(this.gridArtikujt.GetRow(i).Cells["colCelesi"].Text);
                    dr["EMRI"] = Convert.ToString(this.gridArtikujt.GetRow(i).Cells["colEmri"].Text);

                    dsHiq.Tables[0].Rows.Add(dr);
                }
            }

            dsHiq.Tables[0].AcceptChanges();

            int b = data.KerkesaUpdate("CaktivizoArtikujt", dsHiq);

            if (b == 1)
            {
                MessageBox.Show(this, "Ju keni hasur probleme ne aksesimin e bazes se te dhenave." + Environment.NewLine + "Provoni perseri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.MbushGridenArtikujt();





        }

        private void btnAktivizo_Click(object sender, EventArgs e)
        {
            InputController data = new InputController();

            DataSet dsShto = new DataSet();
            dsShto.Tables.Add();
            dsShto.Tables[0].Columns.Add("ID_ARTIKULLI");
            dsShto.AcceptChanges();

            DataRow dr = null;
            for (int i = 0; i < this.gridArtikujt.RowCount; i++)
            {
                if (this.gridArtikujt.GetRow(i).Cells["colZgjedhur"].Text == "True" && this.gridArtikujt.GetRow(i).Cells["colDisponibiliteti"].Text == "False")
                {
                    dr = dsShto.Tables[0].NewRow();
                    dr["ID_ARTIKULLI"] = Convert.ToInt32(this.gridArtikujt.GetRow(i).Cells["colCelesi"].Text);


                    dsShto.Tables[0].Rows.Add(dr);
                }
            }

            dsShto.Tables[0].AcceptChanges();

            if (dsShto.Tables[0].Rows.Count == 0)
            {
                return;
            }

            int b = data.KerkesaUpdate("AktivizoArtikujt", dsShto);

            if (b == 1)
            {
                MessageBox.Show(this, "Ju keni hasur probleme ne aksesimin e bazes se te dhenave." + Environment.NewLine + "Provoni perseri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.MbushGridenArtikujt();







        }

        private void btnPari_Click(object sender, EventArgs e)
        {
            this.gridArtikujt.ExpandGroups();
            if (this.gridArtikujt.RowCount > 0)
            {
                this.gridArtikujt.Row = 0;
            }
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            upDirection = 1;
            this.gridArtikujt.ExpandGroups();
            if ((this.gridArtikujt.Row >= 1) && (this.gridArtikujt.Row - 1 >= 0))
            {
                this.gridArtikujt.Row = this.gridArtikujt.Row - 1;
            }
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            this.gridArtikujt.ExpandGroups();
            if ((this.gridArtikujt.Row <= this.gridArtikujt.RowCount - 2) && (this.gridArtikujt.Row + 1 >= 0))
            {
                this.gridArtikujt.Row = this.gridArtikujt.Row + 1;
            }
        }

        private void btnFundi_Click(object sender, EventArgs e)
        {
            this.gridArtikujt.ExpandGroups();
            if ((this.gridArtikujt.RowCount > 0) && (this.gridArtikujt.RowCount - 1 >= 0))
            {
                this.gridArtikujt.Row = this.gridArtikujt.RowCount - 1;
            }
        }

        private void gridArtikujt_CurrentCellChanged(object sender, EventArgs e)
        {
            int index = this.gridArtikujt.Row;
            if ((index >= 0) && (this.gridArtikujt.GetRow(index).Cells["colCelesi"].Text != ""))
            {
                this.txtEmri.Text = Convert.ToString(this.gridArtikujt.GetRow(index).Cells["colEmri"].Text);
                this.cboKategoria.Value = Convert.ToInt32(this.gridArtikujt.GetRow(index).Cells["colIdKategoriaArtikulli"].Text);
                this.chkKonsumi.Checked = Convert.ToBoolean(this.gridArtikujt.GetRow(index).Cells["colArtikullKonsumi"].Text);
                this.cboNjesia.Value = Convert.ToInt32(this.gridArtikujt.GetRow(index).Cells["colIdNjesia"].Text);
                this.cboSasiaSkorte.Value = Convert.ToDecimal(this.gridArtikujt.GetRow(index).Cells["colSasiaSkorte"].Text);
                this.pcbFoto.Image = this.gridArtikujt.GetRow(index).Cells["colFoto"].Image;
            }
            else
            {
                if ((index > 0) && (upDirection == 1))
                {
                    this.gridArtikujt.Row = index - 1;
                    upDirection = 0;
                    return;
                }
                if (this.gridArtikujt.RowCount > index + 1)
                {
                    this.gridArtikujt.Row = index + 1;
                    return;
                }
            }
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            if (this.KaGabimKerkimi() == true)
            {
                return;
            }

            int kerkimi = 0;
            int idKategoria = 0;
            string artikulli = "";
            if (this.chkArtikulli.Checked == true)
            {
                kerkimi = kerkimi + 1;
                artikulli = this.txtEmriBaze.Text.Trim();
            }

            if (this.chkKategoria.Checked == true)
            {
                kerkimi = kerkimi + 2;
                idKategoria = Convert.ToInt32(this.cboKategoriaBaze.Value);
            }

            InputController data = new InputController();
            DataSet ds = null;
            if (kerkimi > 0)
            {
                ds = data.KerkesaRead("ShfaqArtikujtSipasZgjedhjes", kerkimi, idKategoria, artikulli);
            }
            else
            {
                ds = data.KerkesaRead("ShfaqArtikujt");
            }

            this.gridArtikujt.GroupMode = GroupMode.Expanded;
            this.gridArtikujt.DataSource = ds.Tables[0];


            string s = "Artikujt në Bar Restorant";
            Doc.GridEX = gridArtikujt;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + s;

        }

        private void chkArtikulli_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkArtikulli.Checked == true)
            {
                this.txtEmriBaze.Enabled = true;

            }
            else
            {
                this.txtEmriBaze.Text = "";
                this.txtEmriBaze.Enabled = false;
                this.txtEmriBaze.BackColor = Color.White;

            }
        }

        private void chkKategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkKategoria.Checked == true)
            {
                this.cboKategoriaBaze.Enabled = true;
            }
            else
            {
                this.cboKategoriaBaze.Enabled = false;
                this.cboKategoriaBaze.Text = "";
                this.cboKategoriaBaze.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.KaGabim() == true)
            {
                return;
            }

            string emri = this.txtEmri.Text.Trim();
            int idKategoria = Convert.ToInt32(this.cboKategoria.Value);
            int idNjesia = Convert.ToInt32(this.cboNjesia.Value);
            double sasiaSkorte = Convert.ToDouble(this.cboSasiaSkorte.Value);
            int konsumi = 0;

            if (this.chkKonsumi.Checked == true)
            {
                konsumi = 1;
            }

            string pathiFoto = this.PicturePath;
            double cmimiArtikulli = 0;

            int b = 0;
            InputController data = new InputController();

            string veprimiStr = this.uiTabPageModifiko.Text;

            switch (veprimiStr)
            {
                case "Shtim":

                    b = data.KerkesaUpdate("KrijoArtikull", idKategoria, idNjesia, konsumi, emri, pathiFoto, cmimiArtikulli, sasiaSkorte);
                    if (b == 2)
                    {
                        MessageBox.Show(this, "Ekziston një artikull me të njëjtin emër!", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else if (b == 0)
                    {
                        //MessageBox.Show(this, "Artikulli i ri u krijua!", this.Text,
                        //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(this, "Një gabim ndodhi gjatë krijimit të artikullit. Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    break;

                case "Modifikim":

                    int indeksi = this.gridArtikujt.Row;
                    int idArtikulli = Convert.ToInt32(this.gridArtikujt.GetRow(indeksi).Cells[0].Text);

                    b = data.KerkesaUpdate("ModifikoArtikull", idArtikulli, idKategoria, idNjesia, konsumi, emri, pathiFoto, cmimiArtikulli, sasiaSkorte);

                    if (b == 2)
                    {
                        MessageBox.Show(this, "Ekziston një artikull me të njëjtin emër!", this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                    else if (b == 0)
                    {
                        //MessageBox.Show(this, "Artikulli i ri u krijua!", this.Text,
                        //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        //MessageBox.Show(this, "Një gabim ndodhi gjatë modifikimit të artikullit. Provoni përsëri!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }


                    break;

                default:
                    break;

            }

            this.txtEmri.Text = "";

            //this.PastroTekstet();

            this.gridArtikujt.GroupMode = GroupMode.Collapsed;
            this.MbushGridenArtikujt();


            //this.gridArtikujt.Visible = true;
            //this.uiTabPageModifiko.Visible = false;
            //this.AktivizoPanel(panelTop);
            //this.AktivizoPanel(panelBottom);



            //this.Kerko(emri);

        }

        private void frmKonfigurimArtikujsh_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            this.MbushGridenArtikujt();
            this.MbushKomboKategoriteBaze();
            this.MbushKomboKategorite();
            this.MbushKomboNjesia();
        }
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            try
            {
                if (this.gridArtikujt.RowCount != 0)
                {
                    frmRaportJanus frmPrint = new frmRaportJanus();
                    frmPrint.PrintPreviewControl1.Document = Doc;
                    frmPrint.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                return;
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
            gridArtikujt.ExpandGroups();
            string[] fushat = new string[3];
            string[] llojet = new string[3];
            string[] key = new string[3];
            fushat[0] = "Artikulli";
            fushat[1] = "Njesia";
            fushat[2] = "Sasia_skorte";

            key[0] = "colEmri";
            key[1] = "colNjesia";
            key[2] = "colSasiaSkorte";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "float";

            KlaseExcel excel = new KlaseExcel("Artikujt.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("Artikujt.xls", gridArtikujt, fushat, key, llojet,
                    "colEmri");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Artikujt.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (this.gridArtikujt.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion
    }
}