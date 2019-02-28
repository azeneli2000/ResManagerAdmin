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
    public partial class frmLogin : Form
    {
        /// <summary>
        /// idPerdoruesi = 0 nqs nuk asnje perdorues administrator apo supervizor
        /// idPerdoruesi > 0 nqs nje perdorues logohet me sukses
        /// idPerdoruesi = -1 nqs klikohet Anullo
        /// </summary>
        public static  int idPerdoruesi = 0;
        public static string emerPerdoruesi = "";
        public static string mbiemerPerdoruesi = "";
        public static string perdoruesi = "";
        public static int idRoli = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.error.SetError(txtFjalekalimi, "");
                this.error.SetError(txtPerdoruesi, "");
                if (txtPerdoruesi.Text != "" && txtFjalekalimi.Text != "")
                {
                    InputController data = new InputController();
                    DataSet ds = data.KerkesaRead("GjejPerdorues", txtPerdoruesi.Text, txtFjalekalimi.Text);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        this.error.SetError(txtFjalekalimi, "Emri ose fjalëkalimi nuk janë të saktë!");
                        this.error.SetError(txtPerdoruesi, "Emri ose fjalëkalimi nuk janë të saktë!");
                        return;
                    }
                    else
                    {
                        int idRoli = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_ROLI"]);
                        if (idRoli == 2)
                        {
                            MessageBox.Show(this, "Ju nu keni të drejtë të aksesoni modulin e administratorit!", this.Text, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        int aktiv = Convert.ToInt32(ds.Tables[0].Rows[0]["AKTIV"]);
                        if (aktiv == 1)
                        {
                            //MessageBox.Show(this, "Ky përdorues është një herë i loguar!", this.Text, MessageBoxButtons.OK,
                            //    MessageBoxIcon.Warning);
                            //return;
                        }

                        //logimi eshte i suksesshem
                        idPerdoruesi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_PERSONELI"]);
                        emerPerdoruesi = ds.Tables[0].Rows[0]["EMRI"].ToString();
                        mbiemerPerdoruesi = ds.Tables[0].Rows[0]["MBIEMRI"].ToString();
                        perdoruesi = ds.Tables[0].Rows[0]["PERDORUESI"].ToString();
                        idRoli = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_ROLI"]);
                        //duhet te behet logimi
                        int b = data.KerkesaUpdate("Login", idPerdoruesi, 0);
                        this.Close();
                    }
                }
            }
            catch
            {
                return;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            idPerdoruesi = -1;
            this.Close();
        }

        public static void ShowForm()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqPerdoruesitJoKamariere");
            //nqs nuk ka asnje administrator apo supervizor aplikacioni hapet
            
            if (ds.Tables[0].Rows.Count == 0)
            {
                idPerdoruesi = 0;
                return;
            }
            else
            {
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}