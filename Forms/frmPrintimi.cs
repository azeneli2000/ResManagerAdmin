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
    public partial class frmPrintimi : Form
    {
        private int modelPrintimi = 0;
        private int printModeli = 3;

        public frmPrintimi()
        {
            InitializeComponent();
        }

        private void modeli1_Click(object sender, EventArgs e)
        {
            this.paneli1.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.paneli2.Style.Border = DevComponents.DotNetBar.eBorderType.None;
            this.paneli3.Style.Border = DevComponents.DotNetBar.eBorderType.None;

            this.opt1.Checked = true;

        }

        private void modeli2_Click(object sender, EventArgs e)
        {
            this.paneli1.Style.Border = DevComponents.DotNetBar.eBorderType.None;
            this.paneli2.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.paneli3.Style.Border = DevComponents.DotNetBar.eBorderType.None;

            this.opt2.Checked = true;
        }

        private void modeli3_Click(object sender, EventArgs e)
        {
            this.paneli1.Style.Border = DevComponents.DotNetBar.eBorderType.None;
            this.paneli2.Style.Border = DevComponents.DotNetBar.eBorderType.None;
            this.paneli3.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;


            this.opt3.Checked = true;
        }

        private void btnKonfirmo_Click(object sender, EventArgs e)
        {
          
        }
        #region PrivateMethods

        private void HidhXml(string strNumri, string strModeli)
        {
            string fileName = Global.stringXml + "\\Printimi.xml";
            XmlTextWriter tw = new XmlTextWriter(fileName, null);
            tw.Formatting = Formatting.Indented;
            tw.WriteStartDocument();

            tw.WriteStartElement("Printimi");
            tw.WriteElementString("Nr", strNumri);
            tw.WriteElementString("Modeli", strModeli);
      
            tw.WriteEndElement();
            tw.WriteEndDocument();
            tw.Flush();
            tw.Close();

           
        }

        private void LexoXml()
        {
            string str = "";
            string fileName = Global.stringXml + "\\Printimi.xml";
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
                            case "Modeli":
                                this.printModeli = Convert.ToInt32(tr.ReadElementString(str).ToString());
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

        #endregion

        private void frmPrintimi_Load(object sender, EventArgs e)
        {

            this.LexoXml();
            this.PercaktoModelinZgjedhur();
            
                 
        }

        private void PercaktoModelinZgjedhur()
        {
            switch (this.printModeli)
            {
                case 1:
                    this.opt1.Checked = true;
                    break;

                case 2:
                    this.opt2.Checked = true;
                    break;

                case 3:
                    this.opt3.Checked = true;
                    break;

                default:
                    break;
            }
        }

        private void opt1_CheckedChanged(object sender, EventArgs e)
        {
            this.paneli1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneli2.Style.Border = DevComponents.DotNetBar.eBorderType.None;
            this.paneli3.Style.Border = DevComponents.DotNetBar.eBorderType.None;
        }

        private void opt2_CheckedChanged(object sender, EventArgs e)
        {
            this.paneli1.Style.Border = DevComponents.DotNetBar.eBorderType.None;
            this.paneli2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneli3.Style.Border = DevComponents.DotNetBar.eBorderType.None;
        }

        private void opt3_CheckedChanged(object sender, EventArgs e)
        {
            this.paneli1.Style.Border = DevComponents.DotNetBar.eBorderType.None;
            this.paneli2.Style.Border = DevComponents.DotNetBar.eBorderType.None;
            this.paneli3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int numri = 3;
            int modeli = 0;

            if (this.opt1.Checked == true)
            {
                modeli = 1;
            }
            else if (this.opt2.Checked == true)
            {
                modeli = 2;
            }
            else
            {
                modeli = 3;
            }

            string strNumri = numri.ToString();
            string strModeli = modeli.ToString();

            this.HidhXml(strNumri, strModeli);

            MessageBox.Show(this, "Modeli i fatures i zgjedhur nga ju u aktivizua !", "Modeli i fatures !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}