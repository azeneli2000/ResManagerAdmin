using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ResManagerAdmin.Forms
{
    public partial class Rregjistrimi : Form
    {
        public bool regSakte;
        public Rregjistrimi()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string serial = this.txtSerial1.Text + this.txtSerial2.Text + this.txtSerial3.Text + this.txtSerial4.Text;
            if (serial == RegistrationClass.GetEncryptedKeyFull())
            {
                RegistrationClass.StoreKeyToRegistry(serial);
                MessageBox.Show("Rregjistrimi i programit u krye me sukses", "Rregjistrimi i programit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                regSakte = true;
            }
            else
            {
                MessageBox.Show("Numri qe vendoset nuk eshte i sakte. Ju lutemi kontaktoni me VisionInfoSolution!", "Rregjistrimi i programit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                regSakte = false;
            }
            this.Close();
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            regSakte = false;
            this.Close();
        }

        private void SerialTextChanged(object sender, System.EventArgs e)
        {
            string serial = this.txtSerial1.Text + "-" + this.txtSerial2.Text + "-" +
                this.txtSerial3.Text + "-" + this.txtSerial4.Text + "-";
        }

        private void SerialKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            VisionInfoSolutionLibrary.TextBox txt = sender as VisionInfoSolutionLibrary.TextBox;
            if (txt.Text.Length >= 5 && Char.IsLetterOrDigit((char)e.KeyValue))
            {
                this.SelectNextControl(txt, true, true, true, true);
            }
            // Nese numri serial i futur eshte me 20 karaktere atehere kontrollojme nese numri eshte
            // ai i duhuri per te bere aktivizimin e programit
            if (this.txtSerial1.TextLength + this.txtSerial2.TextLength + this.txtSerial3.TextLength +
                this.txtSerial4.TextLength == 20)
            {
                this.btnOK.Enabled = true;
                this.AcceptButton = btnOK;
            }
            else
                this.btnOK.Enabled = false;
        }

        private void txtSerial1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtSerial3_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtSerial4_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtSerial2_KeyUp(object sender, KeyEventArgs e)
        {

        }

    }
}