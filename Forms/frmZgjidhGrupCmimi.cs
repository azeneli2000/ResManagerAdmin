using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerLibrary;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmZgjidhGrupCmimi : System.Windows.Forms.Form
    {
        private DataSet dsGrupet = null;
        private int zgjedhur = 0;
        

        public frmZgjidhGrupCmimi()
        {
            InitializeComponent();
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.paneli.TitleText = s;
        }

        private void MbushGriden()
        {
            string grupiZgjedhur = "";

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqGrupCmimet");

            if (data != null)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    DataRow drNew = this.dsGrupet.Tables[0].NewRow();

                    drNew[0] = dr[0];
                    drNew[1] = dr[1];
                    drNew[2] = dr[2];
                    drNew[3] = dr[3];

                    this.dsGrupet.Tables[0].Rows.Add(drNew);

                    if (Convert.ToBoolean(dr[3]))
                    {
                        grupiZgjedhur = Convert.ToString(dr[1]);
                        this.lblGrupi.Text = "Grupi korent :  " + grupiZgjedhur;
                    }
                }

                this.dsGrupet.Tables[0].AcceptChanges();


                this.grida.DataSource = this.dsGrupet.Tables[0];
            }
        }

        private void frmZgjidhGrupCmimi_Load(object sender, EventArgs e)
        {
            this.LexoInformacione();

        }

        private DataSet KrijoDsGrupet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_GRUPCMIMI", typeof(Int32));
            ds.Tables[0].Columns.Add("KGRUPCMIMI", typeof(string));
            ds.Tables[0].Columns.Add("PGRUPCMIMI", typeof(string));
            ds.Tables[0].Columns.Add("ZGJEDHUR", typeof(bool));

            ds.AcceptChanges();

            return ds;

        }

        private void grida_CurrentCellChanged(object sender, EventArgs e)
        {
          
        }

        private void grida_Click(object sender, EventArgs e)
        {
            //this.zgjedhur = this.zgjedhur + 1;
            //if (this.zgjedhur == 1)
            //{
            //    return;
            //}

            int indeksi = this.grida.Row;
            if (indeksi < 0)
            {
                return;
            }

            int idGrupi = Convert.ToInt32(this.grida.GetRow(indeksi).Cells[0].Text);

            int celesi = 0;


            foreach (DataRow dr in this.dsGrupet.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr[0]);

                if (celesi == idGrupi)
                {
                    dr["ZGJEDHUR"] = true;
                }
                else
                {
                    dr["ZGJEDHUR"] = false;
                }
            }

            this.dsGrupet.Tables[0].AcceptChanges();

            this.grida.Row = indeksi;
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.dsGrupet.Tables[0].Rows.Clear();
            this.MbushGriden();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            InputController data = new InputController();
            int b = data.KerkesaUpdate("ModifikoGrupCmiminZgjedhur", this.dsGrupet);

            if (b == 0)
            {
                MessageBox.Show(this, "Grupi i cmimit i zgjedhur u aktivizua !", "Grupi i cmimeve !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dsGrupet.Tables[0].Rows.Clear();
                this.MbushGriden();

            }
            else
            {
                MessageBox.Show(this, "Nje gabim ndodhi gjate aksesimit te bazes se te dhenave !" + Environment.NewLine + "Provoni perseri me vone !", "Vemendje !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmZgjidhGrupCmimi_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;
            this.dsGrupet = this.KrijoDsGrupet();
            this.MbushGriden();
        }
      
    }
}