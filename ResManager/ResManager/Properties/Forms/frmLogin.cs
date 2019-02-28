using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;

namespace ResManager.Forms
{
    public partial class frmLogin : Form
    {
        public static int idPerdoruesi = 0;
        public static string emerPerdoruesi = "";
        public static string mbiemerPerdoruesi = "";
        public static string perdoruesi = "";
        public static string fjalekalimi = "";

        #region Form Load
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public static void ShowForm()
        {
            InputController data = new InputController();
            DataSet dsKamariere = data.KerkesaRead("ShfaqPerdoruesitKamariere");
            //nqs nuk ka asnje kamarier te konfiguruar
            //nuk mund te aksesohet moduli i kamarierit.
            if (dsKamariere.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Në sistem nuk është konfiguruar asnjë kamarier." + 
                    Environment.NewLine + "Konfiguroni një kamarier dhe më pas do të keni mundësi" + 
                    Environment.NewLine  + "të aksesoni modulin e kamarierit!", "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                idPerdoruesi = -1;
            }
            else
            {
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
        }
        #endregion

        #region Event Handlers
        private void btnAnullo_Click(object sender, EventArgs e)
        {
            idPerdoruesi = -1;
            Close();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.error.SetError(txtPerdoruesi, "");
                this.error.SetError(txtFjalekalimi, "");
                if (txtFjalekalimi.Text != "" && txtPerdoruesi.Text != "")
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
                        if (idRoli == 1 || idRoli == 3)
                        {
                            MessageBox.Show(this, "Ju nu keni të drejtë të aksesoni modulin e kamarierit!", this.Text, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                        int aktiv = Convert.ToInt32(ds.Tables[0].Rows[0]["AKTIV"]);
                        //if (aktiv == 1)
                        //{
                        //    MessageBox.Show(this, "Ky përdorues është një herë i loguar!", this.Text, MessageBoxButtons.OK,
                        //        MessageBoxIcon.Warning);
                        //    return;
                        //}

                        //logimi eshte i suksesshem
                        idPerdoruesi = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_PERSONELI"]);
                        emerPerdoruesi = ds.Tables[0].Rows[0]["EMRI"].ToString();
                        mbiemerPerdoruesi = ds.Tables[0].Rows[0]["MBIEMRI"].ToString();
                        perdoruesi = ds.Tables[0].Rows[0]["PERDORUESI"].ToString();
                        fjalekalimi = Convert.ToString(ds.Tables[0].Rows[0]["FJALEKALIMI"]);
                        //duhet te behet logimi
                        int b;
                        if (aktiv == 0)
                            b = data.KerkesaUpdate("Login", idPerdoruesi, 1);
                        else if (aktiv == 1)
                            b = data.KerkesaUpdate("Login", idPerdoruesi, 0);
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
        #endregion

        
    }
}