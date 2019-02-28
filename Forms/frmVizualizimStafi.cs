using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using System.IO;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmVizualizimStafi : System.Windows.Forms.Form, IPrintable 
    {
        private DataSet dsPersoneli;
        private string fotoSkedari;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        #region Load Form

        public frmVizualizimStafi()
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

        private void frmVizualizimStafi_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = grida;
            Doc.DefaultPageSettings.Landscape = false;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;

            this.LexoInformacione();
            this.MbushKomboRoli();
            this.BllokoFutjeTeDhenash();
        }
        #endregion

        #region Private Methods

        private void MbushGridenMeTeGjithePersonelin()
        {
            int zgjedhja = 1;
            string emri = "";
            int roli = 0;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine + "Personeli";
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqPersonelinSipasZgjedhjes", zgjedhja, roli, emri);
            this.grida.DataSource = ds.Tables[0];

        }

        private void Kerko()
        {
            int zgjedhja = 0;

            string emri = "";
            int roli = 0;
            string strDesc = "Personeli ";
            if (this.chkEmri.Checked == true)
            {
                zgjedhja = zgjedhja + 1;
                emri = this.txtEmri.Text.Trim();
                strDesc += "me emër " + emri;
            }

            if (this.chkRoli.Checked == true)
            {
                roli = Convert.ToInt32(this.cboRoli.Value);
                if (zgjedhja != 0)
                    strDesc += ", me rol " + cboRoli.Text;
                else
                    strDesc += "me rol " + cboRoli.Text;
                zgjedhja = zgjedhja + 2;
            }

            if (this.chkLogimi.Checked == true)
            {
                if (zgjedhja != 0)
                    strDesc += ", aktualisht të loguar";
                else
                    strDesc += "aktualisht i loguar";
                zgjedhja = zgjedhja + 4;
            }

            if (zgjedhja == 0)
            {
                this.MbushGridenMeTeGjithePersonelin();
                return;
            }

            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine +
                strDesc;
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqPersonelinSipasZgjedhjes", zgjedhja, roli, emri);

            ///this.dsPersoneli = this.KonvertoDataSetin(ds);

            this.grida.DataSource = ds.Tables[0];
        }

        //private DataSet KonvertoDataSetin(DataSet ds)
        //{

        //    DataSet dsNew = new DataSet();
        //    dsNew.Tables.Add();
        //    dsNew.Tables[0].Columns.Add("ID_PERSONELI", typeof(Int32));
        //    dsNew.Tables[0].Columns.Add("EMRI", typeof(String));
        //    dsNew.Tables[0].Columns.Add("MBIEMRI", typeof(String));
        //    dsNew.Tables[0].Columns.Add("TELEFONI", typeof(String));
        //    dsNew.Tables[0].Columns.Add("ID_ROLI", typeof(Int32));
        //    dsNew.Tables[0].Columns.Add("ROLI", typeof(string));
        //    dsNew.Tables[0].Columns.Add("PERDORUESI", typeof(String));
        //    dsNew.Tables[0].Columns.Add("FJALEKALIMI", typeof(String));
        //    dsNew.Tables[0].Columns.Add("EMAILI", typeof(String));
        //    dsNew.Tables[0].Columns.Add("ADRESA", typeof(String));
        //    dsNew.Tables[0].Columns.Add("FOTO", typeof(Image));
        //    dsNew.Tables[0].Columns.Add("AKTIV", typeof(string));
        //    dsNew.AcceptChanges();

        //    int idPersoneli = 0;
        //    string emri = "";
        //    string mbiemri = "";
        //    string telefoni = "";
        //    int idRoli = 0;
        //    string roli = "";
        //    string perdoruesi = "";
        //    string fjalekalimi = "";
        //    string emaili = "";
        //    string adresa = "";
        //    string pathiFoto = "";
        //    Image foto = null;
        //    bool aktiv = false;
        //    string aktivStr = "";

        //    DataRow drNew = null;
        //    foreach (DataRow dr in ds.Tables[0].Rows)
        //    {
        //        drNew = dsNew.Tables[0].NewRow();

        //        idPersoneli = Convert.ToInt32(dr["ID_PERSONELI"]);
        //        emri = Convert.ToString(dr["EMRI"]);
        //        mbiemri = Convert.ToString(dr["MBIEMRI"]);
        //        telefoni = Convert.ToString(dr["TELEFONI"]);
        //        idRoli = Convert.ToInt32(dr["ID_ROLI"]);
        //        roli = Convert.ToString(dr["ROLI"]);
        //        perdoruesi = Convert.ToString(dr["PERDORUESI"]);
        //        fjalekalimi = Convert.ToString(dr["FJALEKALIMI"]);
        //        emaili = Convert.ToString(dr["EMAILI"]);
        //        adresa = Convert.ToString(dr["ADRESA"]);
        //        pathiFoto = Convert.ToString(dr["FOTO"]);
        //        if (pathiFoto == "")
        //            foto = null;
        //        else
        //            foto = Image.FromFile(pathiFoto);


        //        aktiv = Convert.ToBoolean(dr["AKTIV"]);

        //        if (aktiv == true)
        //            aktivStr = "Po";
        //        else
        //            aktivStr = "Jo";

        //        drNew["ID_PERSONELI"] = idPersoneli;
        //        drNew["EMRI"] = emri;
        //        drNew["MBIEMRI"] = mbiemri;
        //        drNew["TELEFONI"] = telefoni;
        //        drNew["ID_ROLI"] = idRoli;
        //        drNew["ROLI"] = roli;
        //        drNew["PERDORUESI"] = perdoruesi;
        //        drNew["FJALEKALIMI"] = fjalekalimi;
        //        drNew["EMAILI"] = emaili;
        //        drNew["ADRESA"] = adresa;
        //        drNew["FOTO"] = foto;
        //        drNew["AKTIV"] = aktivStr;

        //        dsNew.Tables[0].Rows.Add(drNew);
        //    }

        //    dsNew.Tables[0].AcceptChanges();

        //    return dsNew;
        //}

        private DataSet KonvertoDataSetin(DataSet ds)
        {
            ds.Tables[0].Columns.Add("AKTIV_STR", typeof(String));
            ds.Tables[0].Columns.Add("FOTONEW", typeof(Image));
            ds.Tables[0].Columns["AKTIV_STR"].DefaultValue = "Jo";
            ds.AcceptChanges();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int aktiv = Convert.ToInt32(dr["AKTIV"]);
                if (aktiv == 1)
                    dr["AKTIV_STR"] = "Po";
                if (!Convert.IsDBNull(dr["FOTO_IMAZH"]))
                {
                    //Byte[] buffer = (Byte[])dr["FOTO_IMAZH"];
                    //string path = Application.StartupPath + "\\tmp.bmp";
                    //FileStream f = new FileStream(path, FileMode.Open);
                    //f.Write(buffer, 0, buffer.Length);
                    //Image foto = Image.FromFile(path);
                    ///dr["FOTONEW"] = foto;

                }
                

            }
            return ds;
        }

        private void MbushKomboRoli()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqRolet");
            this.cboRoli.DataSource = ds.Tables[0];
        }

        private void BllokoFutjeTeDhenash()
        {

            this.txtEmri.Text = "";
            this.txtEmri.ReadOnly = true;
            this.txtEmri.BackColor = Color.White;

            this.cboRoli.Text = "";
            this.cboRoli.Enabled = false;
            this.cboRoli.BackColor = Color.White;

        }
        #endregion
        
        #region Event Handlers
        private void button1_Click(object sender, EventArgs e)
        {
            Size s = this.Size;

        }

        private void chkEmri_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEmri.Checked == true)
            {
                this.txtEmri.Text = "";
                this.txtEmri.ReadOnly = false;
            }
            else
            {
                this.txtEmri.Text = "";
                this.txtEmri.ReadOnly = true;
                this.txtEmri.BackColor = Color.White;
            }
        }

        private void chkRoli_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkRoli.Checked == true)
            {
                this.cboRoli.Text = "";
                this.cboRoli.Enabled = true;
            }
            else
            {
                this.cboRoli.Text = "";
                this.cboRoli.Enabled = false;
                this.cboRoli.BackColor = Color.White;
            }

        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            this.Kerko();

        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;

            if (indeksi < 0)
                return;

            int idPersoneli = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);
            frmKonfiguroPersonel frm = new frmKonfiguroPersonel();
            frm.veprimi = 2;
            frm.idPersoneli = idPersoneli;
            frm.ShowDialog();


            int modifikoVeprimi = frm.modifikoVeprimi;
            bool uFshi = frm.fshire;
            string fotoPathi = frm.fotoSkedari;
            frm.Dispose();

            this.MbushGridenMeTeGjithePersonelin();
            this.dsPersoneli = null;

            if (modifikoVeprimi == 2 && uFshi == true)
            {
                // File.Delete(fotoPathi);
            }

            this.Kerko();
        }

        private void cboRoli_TextChanged(object sender, EventArgs e)
        {
            if (this.cboRoli.Text != "")
            {
                int index = this.cboRoli.DropDownList.Row;
                cboRoli.Text = cboRoli.DropDownList.GetRow(index).Cells["colRoli"].Text;
            }
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            int indeksi = this.grida.Row;

            if (indeksi < 0)
            {
                return;
            }

            bool aktiv = Convert.ToBoolean(this.grida.GetRow(indeksi).Cells["AKTIV"].Text);

            if (aktiv == true)
            {
                MessageBox.Show("Ju nuk mund te fshini nje perdorues ne kohen qe ai eshte i loguar ne program!", "Vemendje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int celesi = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);
            string emri = Convert.ToString(this.grida.GetRow(indeksi).Cells["EMRI"].Text);
            string mbiemri = Convert.ToString(this.grida.GetRow(indeksi).Cells["MBIEMRI"].Text);

            InputController data = new InputController();
            int b = data.KerkesaUpdate("FshiPerdorues", celesi);

            if (b != 0)
            {
                MessageBox.Show("Ju keni hasur nje problem ne aksesimin e bazes se te dhenave!", "Vemendje!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Perdoruesi  '" + emri + "  " + mbiemri + "'  u fshi!", "Perdoruesit!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.grida.RowCount != 0)
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
            grida.ExpandGroups();
            string[] fushat = new string[8];
            string[] llojet = new string[8];
            string[] key = new string[8];
            fushat[0] = "Emri";
            fushat[1] = "Mbiemri";
            fushat[2] = "Statusi";
            fushat[3] = "Username";
            fushat[4] = "Fjalekalimi";
            fushat[5] = "Telefoni";
            fushat[6] = "Adresa";
            fushat[7] = "Aktiv";

            key[0] = "EMRI";
            key[1] = "MBIEMRI";
            key[2] = "ROLI";
            key[3] = "PERDORUESI";
            key[4] = "FJALEKALIMI";
            key[5] = "TELEFONI";
            key[6] = "ADRESA";
            key[7] = "AKTIV";

            llojet[0] = "char(255)";
            llojet[1] = "char(255)";
            llojet[2] = "char(255)";
            llojet[3] = "char(255)";
            llojet[4] = "char(255)";
            llojet[5] = "char(255)";
            llojet[6] = "char(255)";
            llojet[7] = "char(255)";

            KlaseExcel excel = new KlaseExcel("Stafi.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGrideKategori("Stafi.xls", grida, fushat, key, llojet,
                    "EMRI");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "Stafi.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (grida.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion

        private void frmVizualizimStafi_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            this.MbushGridenMeTeGjithePersonelin();
        }
    }
}