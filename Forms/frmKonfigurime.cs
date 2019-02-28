using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmKonfigurime : Form
    {
        private int nrTavolinat = 0;
        private int skadenca = 0;
        private int modeSkadenca = 0;
        private int nrSkadenca = 0;
        private string strOfertat = "0";
        private string strMinus = "0";
        private string strKam = "1";

        public string veprimi = "";

        public frmKonfigurime()
        {
            InitializeComponent();
        }

        private void HidhXml(string strNrTavolinat, string strSkadenca, string strModeSkadenca, string strNrSkadenca, string oferta, string strMin, string strKamarieri)
        {
            string fileName = Global.stringXml + "\\Konfigurime.xml";
            XmlTextWriter tw = new XmlTextWriter(fileName, null);
            tw.Formatting = Formatting.Indented;
            tw.WriteStartDocument();

            tw.WriteStartElement("Konfigurime");

            tw.WriteStartElement("Tavolinat");
            tw.WriteElementString("Nr", strNrTavolinat);
            tw.WriteEndElement();

            tw.WriteStartElement("Ofertat");
            tw.WriteElementString("OfertaMode", oferta);
            tw.WriteEndElement();

            tw.WriteStartElement("Skadenca");
            tw.WriteElementString("Perdorur", strSkadenca);
            tw.WriteElementString("ModeSkadenca", strModeSkadenca);
            tw.WriteElementString("NrSkadenca", strNrSkadenca);
            tw.WriteEndElement();

            tw.WriteStartElement("MeMinus");
            tw.WriteElementString("ModeMinus", strMin);
            tw.WriteEndElement();

            tw.WriteStartElement("TavKam");
            tw.WriteElementString("ModeKam", strKamarieri);
            tw.WriteEndElement();
            
            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Flush();
            tw.Close();


        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            int numri = 0;

            if (this.optOne.Checked == true)
            {
                numri = 0;
            }
            else
            {
                numri = 1;
            }

            if (this.chkSkadenca.Checked == false)
            {
                this.skadenca = 0;
                this.modeSkadenca = 0;
                this.nrSkadenca = 0;
            }
            else
            {
                this.skadenca = 1;

                if (this.optMuajtSkadenca.Checked == true)
                {
                    this.modeSkadenca = 1;
                    this.nrSkadenca = Convert.ToInt32(this.cboMuajiSkadenca.Text);
                }
                else if (this.optJavetSkadenca.Checked == true)
                {
                    this.modeSkadenca = 2;
                    this.nrSkadenca = Convert.ToInt32(this.cboJavaSkadenca.Text);
                }
                else
                {
                    this.modeSkadenca = 3;
                    this.nrSkadenca = Convert.ToInt32(this.cboDitaSkadenca.Text);
                }

            }

            if (this.optMeOferta.Checked == true)
            {
                this.strOfertat = "1";
            }
            else
            {
                this.strOfertat = "0";
            }

            if (this.optMinus.Checked == true)
            {
                this.strMinus = "1";
            }
            else
            {
                this.strMinus = "0";
            }

            if (this.optKamOne.Checked == true)
            {
                this.strKam = "1";
            }
            else
            {
                this.strKam = "2";
            }

            string strNrTavolinat = numri.ToString();
            string strSkadenca = this.skadenca.ToString();
            string strModeSkadenca = this.modeSkadenca.ToString();
            string strNrSkadenca = this.nrSkadenca.ToString();

            this.HidhXml(strNrTavolinat,strSkadenca, strModeSkadenca, strNrSkadenca, strOfertat, strMinus, strKam);

            MessageBox.Show(this, "Konfigurimet u ruajten", "Konfigurimet !", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void LexoXml()
        {
            string str = "";
            string fileName = Global.stringXml + "\\Konfigurime.xml";
            XmlTextReader tr = new XmlTextReader(fileName);
            try
            {
                while (tr.Read())
                {
                    if (tr.NodeType == XmlNodeType.Element)
                    {
                        str = tr.LocalName.ToString();
                        switch (str)
                        {
                            case "Nr":
                                this.nrTavolinat = Convert.ToInt32(tr.ReadElementString(str).ToString());
                                break;

                            case "OfertaMode" :
                                this.strOfertat = tr.ReadElementString(str).ToString();
                                break;

                            case "ModeMinus" :
                                this.strMinus = tr.ReadElementString(str).ToString();
                                break;

                            case "ModeKam":
                                this.strKam = tr.ReadElementString(str).ToString();
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
            catch
            {

            }
            finally
            {
                tr.Close();
            }
        }

        private void PercaktoKonfigurimet()
        {
            if (this.nrTavolinat == 0)
            {
                this.optOne.Checked = true;
            }
            else
            {
                this.optMany.Checked = true;
            }



            if (this.strOfertat == "0")
            {
                this.optPaOferta.Checked = true;
            }
            else
            {
                this.optMeOferta.Checked = true;
            }

            if (this.strMinus == "1")
            {
                this.optMinus.Checked = true;
            }
            else
            {
                this.optPlus.Checked = true;
            }

            if (this.strKam == "1")
            {
                this.optKamOne.Checked = true;
            }
            else
            {
                this.optKamMany.Checked = true;
            }

        }

        private void frmKonfigurime_Load(object sender, EventArgs e)
        {
            this.LexoInformacione();
            this.LexoXml();

            this.PercaktoKonfigurimet();
            this.MbushKombotSkadenca();
        }

        private void chkSkadenca_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkSkadenca.Checked == true)
            {
                this.optMuajtSkadenca.Checked = true;
                this.optDitetSkadenca.Checked = false;
                this.optJavetSkadenca.Checked = false;

                this.optMuajtSkadenca.Enabled = true;
                this.optDitetSkadenca.Enabled = true;
                this.optJavetSkadenca.Enabled = true;

                this.cboMuajiSkadenca.Enabled = true;
                this.cboMuajiSkadenca.SelectedIndex = 0;

                this.cboJavaSkadenca.SelectedIndex = -1;
                this.cboJavaSkadenca.Enabled = false;
                this.cboJavaSkadenca.BackColor = Color.White;

                this.cboDitaSkadenca.SelectedIndex = -1;
                this.cboDitaSkadenca.Enabled = false;
                this.cboDitaSkadenca.BackColor = Color.White;

            }
            else
            {
                this.optMuajtSkadenca.Checked = false;
                this.optDitetSkadenca.Checked = false;
                this.optJavetSkadenca.Checked = false;

                this.optMuajtSkadenca.Enabled = false;
                this.optDitetSkadenca.Enabled = false;
                this.optJavetSkadenca.Enabled = false;

                this.cboMuajiSkadenca.Enabled = false;
                this.cboMuajiSkadenca.SelectedIndex = -1;

                this.cboJavaSkadenca.SelectedIndex = -1;
                this.cboJavaSkadenca.Enabled = false;

                this.cboDitaSkadenca.SelectedIndex = -1;
                this.cboDitaSkadenca.Enabled = false;
            }
        }

        private void MbushKombotSkadenca()
        {
            this.cboMuajiSkadenca.Items.Add("1");
            this.cboMuajiSkadenca.Items.Add("2");
            this.cboMuajiSkadenca.Items.Add("3");
            this.cboMuajiSkadenca.Items.Add("4");
            this.cboMuajiSkadenca.Items.Add("5");
            this.cboMuajiSkadenca.Items.Add("6");
            this.cboMuajiSkadenca.Items.Add("7");
            this.cboMuajiSkadenca.Items.Add("8");
            this.cboMuajiSkadenca.Items.Add("9");
            this.cboMuajiSkadenca.Items.Add("10");
            this.cboMuajiSkadenca.Items.Add("11");
            this.cboMuajiSkadenca.Items.Add("12");

            this.cboJavaSkadenca.Items.Add("1");
            this.cboJavaSkadenca.Items.Add("2");
            this.cboJavaSkadenca.Items.Add("3");
            this.cboJavaSkadenca.Items.Add("4");
            this.cboJavaSkadenca.Items.Add("5");
            this.cboJavaSkadenca.Items.Add("6");
            this.cboJavaSkadenca.Items.Add("7");
            this.cboJavaSkadenca.Items.Add("8");
            this.cboJavaSkadenca.Items.Add("9");
            this.cboJavaSkadenca.Items.Add("10");
            this.cboJavaSkadenca.Items.Add("11");
            this.cboJavaSkadenca.Items.Add("12");

            this.cboDitaSkadenca.Items.Add("1");
            this.cboDitaSkadenca.Items.Add("2");
            this.cboDitaSkadenca.Items.Add("3");
            this.cboDitaSkadenca.Items.Add("4");
            this.cboDitaSkadenca.Items.Add("5");
            this.cboDitaSkadenca.Items.Add("6");
            this.cboDitaSkadenca.Items.Add("7");
            this.cboDitaSkadenca.Items.Add("8");
            this.cboDitaSkadenca.Items.Add("9");
            this.cboDitaSkadenca.Items.Add("10");
            this.cboDitaSkadenca.Items.Add("11");
            this.cboDitaSkadenca.Items.Add("12");
            this.cboDitaSkadenca.Items.Add("13");
            this.cboDitaSkadenca.Items.Add("14");
            this.cboDitaSkadenca.Items.Add("15");
            this.cboDitaSkadenca.Items.Add("16");
            this.cboDitaSkadenca.Items.Add("17");
            this.cboDitaSkadenca.Items.Add("18");
            this.cboDitaSkadenca.Items.Add("19");
            this.cboDitaSkadenca.Items.Add("20");
            this.cboDitaSkadenca.Items.Add("21");
            this.cboDitaSkadenca.Items.Add("22");
            this.cboDitaSkadenca.Items.Add("23");
            this.cboDitaSkadenca.Items.Add("24");
            this.cboDitaSkadenca.Items.Add("25");
            this.cboDitaSkadenca.Items.Add("26");
            this.cboDitaSkadenca.Items.Add("27");
            this.cboDitaSkadenca.Items.Add("28");
            this.cboDitaSkadenca.Items.Add("29");
            this.cboDitaSkadenca.Items.Add("30");
            this.cboDitaSkadenca.Items.Add("31");



        }

        private void optJavetSkadenca_CheckedChanged(object sender, EventArgs e)
        {
            if (this.optJavetSkadenca.Checked == true)
            {
                this.cboJavaSkadenca.Enabled = true;
                this.cboJavaSkadenca.SelectedIndex = -1;

                this.cboDitaSkadenca.SelectedIndex = -1;
                this.cboDitaSkadenca.Enabled = false;
                this.cboDitaSkadenca.BackColor = Color.White;

                this.cboMuajiSkadenca.SelectedIndex = -1;
                this.cboMuajiSkadenca.Enabled = false;
                this.cboDitaSkadenca.BackColor = Color.White;
            }
            else
            {
                this.cboJavaSkadenca.SelectedIndex = -1;
                this.cboJavaSkadenca.Enabled = false;
                this.cboDitaSkadenca.BackColor = Color.White;
            }
        }

        private void optMuajtSkadenca_CheckedChanged(object sender, EventArgs e)
        {
            if (this.optMuajtSkadenca.Checked == true)
            {
                this.cboJavaSkadenca.Enabled = false;
                this.cboJavaSkadenca.SelectedIndex = -1;
                this.cboJavaSkadenca.BackColor = Color.White;

                this.cboDitaSkadenca.SelectedIndex = -1;
                this.cboDitaSkadenca.Enabled = false;
                this.cboDitaSkadenca.BackColor = Color.White;

                this.cboMuajiSkadenca.SelectedIndex = -1;
                this.cboMuajiSkadenca.Enabled = true;
                
            }
            else
            {
                
                this.cboMuajiSkadenca.SelectedIndex = -1;
                this.cboMuajiSkadenca.Enabled = false;
                this.cboMuajiSkadenca.BackColor = Color.White;
            }
        }

        private void optDitetSkadenca_CheckedChanged(object sender, EventArgs e)
        {
            if (this.optDitetSkadenca.Checked == true)
            {
                this.cboJavaSkadenca.Enabled = false;
                this.cboJavaSkadenca.SelectedIndex = -1;
                this.cboJavaSkadenca.BackColor = Color.White;

                this.cboDitaSkadenca.SelectedIndex = -1;
                this.cboDitaSkadenca.Enabled = true;

                this.cboMuajiSkadenca.SelectedIndex = -1;
                this.cboMuajiSkadenca.Enabled = false;
                this.cboMuajiSkadenca.BackColor = Color.White;
            }
            else
            {
                this.cboDitaSkadenca.SelectedIndex = -1;
                this.cboDitaSkadenca.Enabled = false;
                this.cboDitaSkadenca.BackColor = Color.White;
            }
        }

        private void optMinus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void btnModelPrintimi_Click(object sender, EventArgs e)
        {
            frmPrintimi frm = new frmPrintimi();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnRecetatPrintimi_Click(object sender, EventArgs e)
        {
            frmRecetatPrintimi frm = new frmRecetatPrintimi();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }

        private void btnPrinterat_Click(object sender, EventArgs e)
        {
            frmKonfigurimPrinteri frm = new frmKonfigurimPrinteri();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }


        

    }
}