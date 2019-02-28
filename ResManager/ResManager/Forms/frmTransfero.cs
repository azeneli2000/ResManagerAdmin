using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;using ResManagerAdmin.BusDatService;

namespace ResManager.Forms
{
    public partial class frmTransfero : Form
    {
        public int idTavolina;
        public string emriTavolina;
        public DataSet dsTavolinat;
        public int transferimi = 0;
        public int idTavNew;

        private int rezervimi = 0;

        public frmTransfero()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;
            teksti = teksti + "1";

            this.txtNumri.Text = teksti;

            this.lblMesazhi.Text = "";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;
            teksti = teksti + "2";

            this.txtNumri.Text = teksti;

            this.lblMesazhi.Text = "";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;
            teksti = teksti + "3";

            this.txtNumri.Text = teksti;

            this.lblMesazhi.Text = "";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;
            teksti = teksti + "4";

            this.txtNumri.Text = teksti;

            this.lblMesazhi.Text = "";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;
            teksti = teksti + "5";

            this.txtNumri.Text = teksti;

            this.lblMesazhi.Text = "";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;
            teksti = teksti + "6";

            this.txtNumri.Text = teksti;

            this.lblMesazhi.Text = "";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;
            teksti = teksti + "7";

            this.txtNumri.Text = teksti;

            this.lblMesazhi.Text = "";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;
            teksti = teksti + "8";

            this.txtNumri.Text = teksti;

            this.lblMesazhi.Text = "";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;
            teksti = teksti + "9";

            this.txtNumri.Text = teksti;

            this.lblMesazhi.Text = "";

        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;
            teksti = teksti + "0";

            this.txtNumri.Text = teksti;

            this.lblMesazhi.Text = "";

        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            string teksti = this.txtNumri.Text;

            if (teksti == "")
            {
                return;
            }

            int nr = teksti.Length;

            string tekstiNew = teksti.Substring(0, nr - 1);

            this.txtNumri.Text = tekstiNew;

            this.lblMesazhi.Text = "";
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nrTav = this.txtNumri.Text;

            DataSet ds = this.KontrolloTavolinen(nrTav);

            int pergjigje = 0;
            int celesi = 0;

            pergjigje = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            celesi = Convert.ToInt32(ds.Tables[0].Rows[0][2]);

            switch (pergjigje)
            {
                case 0:

                    int b = this.TranferoTavolinen(this.idTavolina, celesi);
                    if (b != 0)
                    {
                        MessageBox.Show("Ju keni hasur nje problem ne aksesimin e te dhenave!Ju lutem provoni perseri!", "Kujdes!!!");
                    }
                    else
                    {
                        this.transferimi = 1;
                        this.idTavNew = celesi;
                        this.Close();
                    }
                    break;

                case 1:

                    DialogResult result = MessageBox.Show("Tavolina eshte e rezervuar.Jeni te sigurte se doni te vashdoni ?", "Vemendje!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        int br = this.TranferoTavolinen(this.idTavolina, celesi);
                        if (br != 0)
                        {
                            MessageBox.Show("Ju keni hasur nje problem ne aksesimin e te dhenave!Ju lutem provoni perseri!", "Kujdes!!!");
                        }
                        else
                        {
                            this.transferimi = 1;
                            this.idTavNew = celesi;
                            this.Close();
                        }
                    }

                    break;

                case 2:
                    lblMesazhi.Text = "Tavolina eshte e zene!";
                    break;

                case 3:
                    break;

                case 4:
                    lblMesazhi.Text = "Nuk ekziston nje tavoline me kete emer!";
                    break;

                default:
                    break;
            }
        }

        private DataSet KontrolloTavolinen(string nrTav)
        {
            int ktheNr = 0;

            int pergjigje = 0;
            string numri = "";
            string gjendja = "";
            int celesi = 0;
            DataSet dsKthe = this.KrijoDataSet();

            foreach (DataRow dr in dsTavolinat.Tables[0].Rows)
            {
                numri = Convert.ToString(dr[2]);
                

                if (numri == nrTav)
                {
                    gjendja = Convert.ToString(dr[1]);

                    if (gjendja == "L")
                    {
                        pergjigje = 0;
                    }
                    else if (gjendja == "R")
                    {
                        pergjigje = 1;
                    }
                    else
                    {
                        pergjigje = 2;
                    }

                    celesi = Convert.ToInt32(dr[0]);

                    DataRow drNew = dsKthe.Tables[0].NewRow();

                    drNew[0] = pergjigje;
                    drNew[1] = gjendja;
                    drNew[2] = celesi;

                    dsKthe.Tables[0].Rows.Add(drNew);

                    dsKthe.Tables[0].AcceptChanges();

                    return dsKthe;

                }
            }


            DataRow drNew1 = dsKthe.Tables[0].NewRow();

            drNew1[0] = 4;
            drNew1[1] = gjendja;
            drNew1[2] = celesi;

            dsKthe.Tables[0].Rows.Add(drNew1);

            dsKthe.Tables[0].AcceptChanges();

            return dsKthe;


         }

        private DataSet KrijoDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("PERGJIGJE", typeof(Int32));
            ds.Tables[0].Columns.Add("GJENDJA", typeof(string));
            ds.Tables[0].Columns.Add("ID_TAVOLINA", typeof(Int32));

            ds.Tables[0].AcceptChanges();

            return ds;
        }

        private int TranferoTavolinen(int idOld, int idNew)
        {
            Int32[] idFaturat = new Int32[30];

            int celesi = 0;
            int idFatura = 0;
            int i = 0;
            foreach (DataRow dr in dsTavolinat.Tables[1].Rows)
            {
                celesi = Convert.ToInt32(dr[0]);
                idFatura = Convert.ToInt32(dr[1]);

                if (celesi == idOld)
                {
                    idFaturat[i] = idFatura;
                    i = i + 1;

                    dr[0] = idNew;
                }
            }
            dsTavolinat.Tables[1].AcceptChanges();

            foreach (DataRow dr1 in dsTavolinat.Tables[0].Rows)
            {
                celesi = Convert.ToInt32(dr1[0]);

                if (celesi == idOld)
                {
                    dr1[1] = "L";
                }

                if (celesi == idNew)
                {
                    dr1[1] = "Z";
                }
            }

            this.dsTavolinat.Tables[0].AcceptChanges();

            Int32[] idFat = new Int32[i];

            for (int j = 0; j < i; j++)
            {
                idFat[j] = idFaturat[j];
            }

            InputController data = new InputController();
            int b = data.KerkesaUpdate("TransferoTavolinen", idOld, idNew, idFaturat);

            return b;

            
        }

        private void btnPastro_Click(object sender, EventArgs e)
        {
            this.txtNumri.Text = "";
        }
    }
}