using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using Janus.Windows.ExplorerBar;
using ResManagerAdmin.BusDatService;
using ResManager.Forms;
using ResManager;

namespace ResManager.Forms
{
    public partial class frmOffer : Form
    {
        private DataSet dsOfertat = null;
        private DataSet dsZgjedhur = null;
        public DataSet dsRecetat = null;
        private int grupi = 0;
        private int nrVisible = 0;
        private int nrGrupet = 0;
        private int nrOfertat = 0;
        private int mbetja = 0;
        private int[] ofertatVisible = new int[8];
        private int[] idOfertat = new int[8];
        private int[] nrShportat = new int[8];
        private string[] emratOferta = new string[8];
        private decimal[] cmimetOferta = new decimal[8];
        private bool para = false;
        private bool pas = false;
        public int idOfertaZgjedhur = 0;
        public string emriOfertaZgjedhur = "";
        public decimal cmimiOferta = 0;
        public int shportat = 0;
        public int veprimi = 0;
         

        public frmOffer()
        {
            InitializeComponent();
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemPanel1_Click(object sender, EventArgs e)
        {

        }

        private DataSet KrijoDataSetOfertat()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_OFERTA", typeof(Int32));
            ds.Tables[0].Columns.Add("EMRI", typeof(string));
            ds.Tables[0].Columns.Add("CMIMI", typeof(decimal));
            ds.Tables[0].Columns.Add("TIPI", typeof(string));
            ds.Tables[0].Columns.Add("NR_SHPORTASH", typeof(int));

            ds.AcceptChanges();

            return ds;
        }

        private void frmOffer_Load(object sender, EventArgs e)
        {
            this.dsOfertat = this.KrijoDataSetOfertat();
            this.dsRecetat = this.KrijoDsRecetat();
            this.MbushGridenPerBarin();

            this.grupi = 1;

            this.KonfiguroOfertat();
            this.ShfaqOfertat();

            this.ShfaqTeParen();
            
        }

        private void ShfaqTeParen()
        {
            int idOferta = Convert.ToInt32(btn1.Tag);

            this.MbushOferten(idOferta, 0);

            this.shportat = this.nrShportat[0];
            this.idOfertaZgjedhur = idOferta;
            this.emriOfertaZgjedhur = this.btn1.Text;
            this.cmimiOferta = Convert.ToDecimal(this.btn1.Tooltip);
        }

        private void MbushGridenPerBarin()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqOfertatPerBarin");

            this.dsOfertat = ds;
        }

        private void MbushGridenPerHotelin()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqOfertatPerHotelin");

            this.dsOfertat = ds;
        }

        private void KonfiguroOfertat()
        {
            this.nrOfertat = this.dsOfertat.Tables[0].Rows.Count;

            this.mbetja = this.nrOfertat % 8;

            this.nrGrupet = this.nrOfertat / 8;

            if (mbetja != 0)
            {
                this.nrGrupet = this.nrGrupet + 1;
            }

        }

        private void ShfaqOfertat()
        {
            if (this.nrGrupet == grupi)
            {
                if (this.mbetja == 0)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        this.ofertatVisible[i] = this.nrGrupet - 8 + i;
                        this.nrVisible = 8;
                    }
                }
                else
                {
                    for (int i = 0; i < this.mbetja; i++)
                    {
                        this.ofertatVisible[i] = (grupi - 1) * 8 + i;
                        this.nrVisible = this.mbetja;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    this.ofertatVisible[i] = (grupi - 1) * 8 + i;
                    this.nrVisible = 8;
                }
            }

            int indeksiDs = 0;
            int indeksiOferta = this.ofertatVisible[0];
            int celesi = 0;
            string emri = "";
            decimal cmimi = 0;
            int indeksi = 0;
            


            foreach (DataRow dr in dsOfertat.Tables[0].Rows)
            {
                if (indeksiDs == this.ofertatVisible[indeksi])
                {
                    celesi = Convert.ToInt32(dr["ID_OFERTA"]);
                    emri = Convert.ToString(dr["EMRI"]);
                    cmimi = Convert.ToDecimal(dr["CMIMI"]);

                    this.nrShportat[indeksi] = Convert.ToInt32(dr["NR_SHPORTASH"]);
                    this.idOfertat[indeksi] = celesi;
                    this.emratOferta[indeksi] = emri;
                    this.cmimetOferta[indeksi] = cmimi;

                    indeksi = indeksi + 1;
                }

                indeksiDs = indeksiDs + 1;
            }

            if (this.nrVisible >= 1)
            {
                this.btn1.Text = this.emratOferta[0];
                this.btn1.Tag = this.idOfertat[0].ToString();
                this.btn1.Tooltip = this.cmimetOferta[0].ToString();
                this.btn1.Visible = true;
            }
            else
            {
                this.btn1.Visible = false;
            }


            if (this.nrVisible >= 2)
            {
                this.btn2.Text = this.emratOferta[1];
                this.btn2.Tag = this.idOfertat[1].ToString();
                this.btn2.Tooltip = this.cmimetOferta[1].ToString();
                this.btn2.Visible = true;
            }
            else
            {
                this.btn2.Visible = false;
            }

            if (this.nrVisible >= 3)
            {
                this.btn3.Text = this.emratOferta[2];
                this.btn3.Tag = this.idOfertat[2].ToString();
                this.btn3.Tooltip = this.cmimetOferta[2].ToString();
                this.btn3.Visible = true;
            }
            else
            {
                this.btn3.Visible = false;
            }

            if (this.nrVisible >= 4)
            {
                this.btn4.Text = this.emratOferta[3];
                this.btn4.Tag = this.idOfertat[3].ToString();
                this.btn4.Tooltip = this.cmimetOferta[3].ToString();
                this.btn4.Visible = true;
            }
            else
            {
                this.btn4.Visible = false;
            }


            if (this.nrVisible >= 5)
            {
                this.btn5.Text = this.emratOferta[4];
                this.btn5.Tag = this.idOfertat[4].ToString();
                this.btn5.Tooltip = this.cmimetOferta[4].ToString();
                this.btn5.Visible = true;
            }
            else
            {
                this.btn5.Visible = false;
            }

            if (this.nrVisible >= 6)
            {
                this.btn6.Text = this.emratOferta[5];
                this.btn6.Tag = this.idOfertat[5].ToString();
                this.btn6.Tooltip = this.cmimetOferta[5].ToString();
                this.btn6.Visible = true;
            }
            else
            {
                this.btn6.Visible = false;
            }

            if (this.nrVisible >= 7)
            {
                this.btn7.Text = this.emratOferta[6];
                this.btn7.Tag = this.idOfertat[6].ToString();
                this.btn7.Tooltip = this.cmimetOferta[6].ToString();
                this.btn7.Visible = true;
            }
            else
            {
                this.btn7.Visible = false;
            }

            if (this.nrVisible >= 8)
            {
                this.btn8.Text = this.emratOferta[7];
                this.btn8.Tag = this.idOfertat[7].ToString();
                this.btn8.Tooltip = this.cmimetOferta[7].ToString();
                this.btn8.Visible = true;
            }
            else
            {
                this.btn8.Visible = false;
            }

            if (this.grupi == 1)
            {
                this.btnPas.Enabled = false;
            }

            if (this.grupi == this.nrGrupet)
            {
                this.btnPara.Enabled = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int idOferta = Convert.ToInt32(btn1.Tag);
           
            this.MbushOferten(idOferta, 0);

            this.shportat = this.nrShportat[0];
            this.idOfertaZgjedhur = idOferta;
            this.emriOfertaZgjedhur = this.btn1.Text;
            this.cmimiOferta = Convert.ToDecimal(this.btn1.Tooltip);
        }

        private void MbushOferten(int idOferta, int indeksi)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqTeDhenaPerOferten", idOferta);

            string shporta = "";
            int j = 0;

            this.btnOferta.Groups.Clear();

            Janus.Windows.ButtonBar.ButtonBarGroup grupi = new Janus.Windows.ButtonBar.ButtonBarGroup();

            for(int i = 0; i < this.nrShportat[indeksi]; i++)
            {
                j = j + 1;
                shporta = j.ToString();

                grupi.Text = shporta;

                ///grupi.Icon = ((System.Drawing.Icon)(FromFile("D:\\ResManagerAdmin\\ResManager\\ResManager\\Resources\\shporta.ico")));
                this.btnOferta.Groups.Add(shporta);
            }

            int indeksiShporta = 0;
            int oldBasket = 1;
            int newBasket = 1;
            string receta = "";
            int idReceta = 0;
            int sasia = 0;
            int ugjet = 1;
            int rreshti = 0;

            this.dsRecetat.Tables[0].Rows.Clear();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                newBasket = Convert.ToInt32(dr["SHPORTA"]);
                idReceta = Convert.ToInt32(dr["ID_RECETA"]);
                receta = Convert.ToString(dr["RECETA"]);
                sasia = Convert.ToInt32(dr["SASIA"]);

                rreshti = rreshti + 1;

                if (rreshti == 1)
                {
                    DataRow drNew = this.dsRecetat.Tables[0].NewRow();
                    drNew["SHPORTA"] = dr["SHPORTA"];
                    drNew["ID_RECETA"] = dr["ID_RECETA"];
                    drNew["RECETA"] = dr["RECETA"];
                    drNew["SASIA"] = dr["SASIA"];

                    this.dsRecetat.Tables[0].Rows.Add(drNew);
                }

                if (oldBasket == newBasket)
                {
                    Janus.Windows.ButtonBar.ButtonBarItem el = new Janus.Windows.ButtonBar.ButtonBarItem();
                    el.Text = receta;
                    el.TagString = idReceta.ToString();
                    el.ToolTipText = sasia.ToString();

                    this.btnOferta.Groups[indeksiShporta].Items.Add(el);
                }
                else
                {
                    indeksiShporta = indeksiShporta + 1;
                    Janus.Windows.ButtonBar.ButtonBarItem el = new Janus.Windows.ButtonBar.ButtonBarItem();
                    el.Text = receta;
                    el.TagString = idReceta.ToString();
                    el.ToolTipText = sasia.ToString();

                    this.btnOferta.Groups[indeksiShporta].Items.Add(el);
                    oldBasket = newBasket;

                    DataRow drNew = this.dsRecetat.Tables[0].NewRow();
                    drNew["SHPORTA"] = dr["SHPORTA"];
                    drNew["ID_RECETA"] = dr["ID_RECETA"];
                    drNew["RECETA"] = dr["RECETA"];
                    drNew["SASIA"] = dr["SASIA"];

                    this.dsRecetat.Tables[0].Rows.Add(drNew);
                }
            }

            this.dsRecetat.Tables[0].AcceptChanges();

            this.grida.DataSource = this.dsRecetat.Tables[0];
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int idOferta = Convert.ToInt32(btn2.Tag);

            this.MbushOferten(idOferta, 1);

            this.shportat = this.nrShportat[1];
            this.idOfertaZgjedhur = idOferta;
            this.emriOfertaZgjedhur = this.btn2.Text;
            this.cmimiOferta = Convert.ToDecimal(this.btn2.Tooltip);
        }

        private DataSet KrijoDsRecetat()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("SHPORTA", typeof(Int32));
            ds.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            ds.Tables[0].Columns.Add("RECETA", typeof(string));
            ds.Tables[0].Columns.Add("SASIA", typeof(Int32));

            ds.AcceptChanges();

            return ds;
        }

        private void btnOferta_ItemClick(object sender, Janus.Windows.ButtonBar.ItemEventArgs e)
        {
            int shporta = Convert.ToInt32(this.btnOferta.SelectedItem.Group.Text);
            int idReceta = Convert.ToInt32(this.btnOferta.SelectedItem.TagString.Trim());
            string receta = this.btnOferta.SelectedItem.Text.Trim();
            int sasia = Convert.ToInt32(this.btnOferta.SelectedItem.ToolTipText.Trim());

            int celesi = 0;

            foreach (DataRow dr in this.dsRecetat.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["SHPORTA"]);

                if (celesi == shporta)
                {
                    dr["ID_RECETA"] = idReceta;
                    dr["RECETA"] = receta;
                    dr["SASIA"] = sasia;
                }
            }

            this.dsRecetat.Tables[0].AcceptChanges();
        }

        private void btnOferta_ItemSelected(object sender, EventArgs e)
        {
            int shporta = Convert.ToInt32(this.btnOferta.SelectedItem.Group.Text);
            int idReceta = Convert.ToInt32(this.btnOferta.SelectedItem.TagString.Trim());
            string receta = this.btnOferta.SelectedItem.Text.Trim();
            int sasia = Convert.ToInt32(this.btnOferta.SelectedItem.ToolTipText.Trim());

            int celesi = 0;

            foreach (DataRow dr in this.dsRecetat.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr["SHPORTA"]);

                if (celesi == shporta)
                {
                    dr["ID_RECETA"] = idReceta;
                    dr["RECETA"] = receta;
                    dr["SASIA"] = sasia;
                }
            }

            this.dsRecetat.Tables[0].AcceptChanges();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            this.veprimi = 1;
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int idOferta = Convert.ToInt32(btn3.Tag);

            this.MbushOferten(idOferta, 2);

            this.shportat = this.nrShportat[2];
            this.idOfertaZgjedhur = idOferta;
            this.cmimiOferta = Convert.ToDecimal(this.btn3.Tooltip);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int idOferta = Convert.ToInt32(btn4.Tag);

            this.MbushOferten(idOferta, 3);

            this.shportat = this.nrShportat[3];
            this.idOfertaZgjedhur = idOferta;
            this.cmimiOferta = Convert.ToDecimal(this.btn4.Tooltip);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int idOferta = Convert.ToInt32(btn5.Tag);

            this.MbushOferten(idOferta, 4);

            this.shportat = this.nrShportat[4];
            this.idOfertaZgjedhur = idOferta;
            this.cmimiOferta = Convert.ToDecimal(this.btn5.Tooltip);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int idOferta = Convert.ToInt32(btn6.Tag);

            this.MbushOferten(idOferta, 5);

            this.shportat = this.nrShportat[5];
            this.idOfertaZgjedhur = idOferta;
            this.cmimiOferta = Convert.ToDecimal(this.btn6.Tooltip);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int idOferta = Convert.ToInt32(btn7.Tag);

            this.MbushOferten(idOferta, 6);

            this.shportat = this.nrShportat[6];
            this.idOfertaZgjedhur = idOferta;
            this.cmimiOferta = Convert.ToDecimal(this.btn7.Tooltip);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int idOferta = Convert.ToInt32(btn8.Tag);

            this.MbushOferten(idOferta, 7);

            this.shportat = this.nrShportat[7];
            this.idOfertaZgjedhur = idOferta;
            this.cmimiOferta = Convert.ToDecimal(this.btn8.Tooltip);
        }
    }
}