using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using ResManager;
using ResManagerAdmin.BusDatService;
using System.IO;

namespace ResManagerAdmin.Forms
{
    public partial class frmHyrje : Form
    {
        public frmHyrje()
        {
            InitializeComponent();
            Global globalObject = new Global();
        }

        private void bubbleButtonAdministratori_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                ResManagerAdmin.Forms.MDIAdminTjeter frm = new ResManagerAdmin.Forms.MDIAdminTjeter();
                if (frm.anullo)
                {

                }
                else
                {
                    this.Visible = false;
                    frm.Show();

                }
            }
            catch(Exception ex)
            {
                return;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void bubbleButtonKamarieri_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                InputController data = new InputController();
                DataSet ds = data.KerkesaRead("ShfaqGrupCmimet");

                if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
                {
                    ResManager.Forms.MDIResManager frm = new ResManager.Forms.MDIResManager();
                    if (frm.anullo)
                    {

                    }
                    else
                    {
                        this.Visible = false;
                        frm.Show();

                    }
                }
                else
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show(this, "Asnje grup cmimesh nuk eshte konfiguruar per produketet . " + Environment.NewLine + "Per te aksesuar modulin e kamarierit ju duhet te konfiguroni te pakten nje grup cmimesh !", "Kujdes !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
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

        private void bubbleButtonDil_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            Application.Exit();
        }

        private void KrijoDirektori()
        {
            if (!Directory.Exists(Global.stringXml))
            {
                Directory.CreateDirectory(Global.stringXml);
            }
            if (!File.Exists(Global.stringXml + "\\Informacione.Xml"))
            {
                File.Copy(Application.StartupPath + "\\Raportet\\Informacione.Xml", Global.stringXml + "\\Informacione.Xml");
            }
        }

        private void frmHyrje_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void frmHyrje_Load(object sender, EventArgs e)
        {
            KrijoDirektori();
        }

        private void bubbleBarAdministratori_ButtonClick(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }
    }
}