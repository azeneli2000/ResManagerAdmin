using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ResManagerAdmin.Forms;
using System.IO;

namespace ResManagerAdmin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Initialize() == false)
            {
                Application.Exit();
                return;
            }
            Application.Run(new Forms.frmHyrje());
        }

        private static bool Initialize()
        {
            if (Program.CheckFirstTime())
            {
            }
            if (RegistrationClass.CelesVlefshem())
            {
                return true;
            }
            NumriSerial nrSerial1 = new NumriSerial();
            nrSerial1.ShowDialog();
            if (nrSerial1.rregjistroNr == false)
                return false;
            Rregjistrimi register = new Rregjistrimi();
            register.ShowDialog();
            if (!register.regSakte)
                return false;
            if (register.regSakte)
                return true;
            return false;
        }

        /// <summary>
        /// Kontrollon nese programi po hapet per here te pare
        /// </summary>
        /// <returns></returns>
        private static bool CheckFirstTime()
        {
            if (Globals.GetIsolatedStorageContent("FirstTime") != "false")
            {
                StreamWriter writer = Globals.GetIsolatedStorageStreamWriter("FirstTime");
                writer.Close();
                Globals.StoreToIsolatedStorage("FirstTime", "false");
                return false;
            }
            return false;
        }
    }
}