using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmInformacione : Form
    {
        private string PicturePath;
        private string emer, adrese, telefon, email, website, kodFiskal, mesazh;

        #region Form Load
        public frmInformacione()
        {
            InitializeComponent();
        }

        private void frmInformacione_Load(object sender, EventArgs e)
        {
            PicturePath = "";
            LexoXml();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Lexo te dhenat nga file-i xml
        /// </summary>
        private void LexoXml()
        {
            string str = "";
            string fileName = Global.stringXml  + "\\Informacione.xml";
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
                            case "Emri":
                                this.txtEmri.Text = tr.ReadElementString(str).ToString();
                                break;
                            case "Adresa":
                                this.txtAdresa.Text = tr.ReadElementString(str).ToString();
                                break;
                            case "Telefoni":
                                this.txtTelefon.Text = tr.ReadElementString(str).ToString();
                                break;
                            case "E-maili":
                                this.txtEmail.Text = tr.ReadElementString(str).ToString();
                                break;
                            case "Website-i":
                                this.txtWebsite.Text = tr.ReadElementString(str).ToString();
                                break;
                            case "KodiFiskal":
                                this.txtKodi.Text = tr.ReadElementString(str).ToString();
                                break;
                            case "LogoPath":
                                string x = tr.ReadElementString(str).ToString();
                                if (x != "")
                                    this.pictureBox.Image = Image.FromFile(x);
                                this.PicturePath = x;
                                break;
                            case "Mesazh":
                                this.txtMesazh.Text = tr.ReadElementString(str).ToString();
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(this, "Skedari ku ju keni ruajtur logon e restorantit " + System.Environment.NewLine + "eshte fshire ose nuk gjendet!", this.Text, 
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                tr.Close();
            }
        }

        /// <summary>
        /// Ruaj te dhenat ne file-in xml
        /// </summary>
        private void HidhXml()
        {
            string fileName = Global.stringXml  + "\\Informacione.xml";
            XmlTextWriter tw = new XmlTextWriter(fileName, null);
            tw.Formatting = Formatting.Indented;
            tw.WriteStartDocument();

            tw.WriteStartElement("Informacione");
            tw.WriteElementString("Emri", this.emer);
            tw.WriteElementString("Adresa", this.adrese);
            tw.WriteElementString("Telefoni", this.telefon);
            tw.WriteElementString("E-maili", this.email);
            tw.WriteElementString("Website-i", this.website);
            tw.WriteElementString("KodiFiskal", this.kodFiskal);
            tw.WriteElementString("Mesazh", this.mesazh);
            tw.WriteElementString("LogoPath", this.PicturePath);

            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Flush();
            tw.Close();
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
        #endregion

        #region Event Handlers
        private void btnGjejLogo_Click(object sender, EventArgs e)
        {
            string s = "";
            s = this.ZgjidhLogo(this.openFileDialog1, "Figura|*.bmp;*.ico;*.cur;*.jpg;*.gif;*.png");
            if (s == "")
            {
                return;
            }
            else
            {
                this.pictureBox.Image = Image.FromFile(s);
                this.PicturePath = s;
            }
        }

        private void btnFshiLogo_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = null;
            this.PicturePath = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.emer = this.txtEmri.Text;
            this.adrese = this.txtAdresa.Text;
            this.telefon = this.txtTelefon.Text;
            this.email = this.txtEmail.Text;
            this.website = this.txtWebsite.Text;
            this.mesazh = this.txtMesazh.Text;
            this.kodFiskal = this.txtKodi.Text;
            this.HidhXml();
            MessageBox.Show(this, "Informacionet për restorantin u ruajtën.", this.Text, MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            this.Close();
        }
        #endregion

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}