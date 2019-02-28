using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Management;
using System.Diagnostics;
using System.Threading;
using System.IO.IsolatedStorage;
using System.Windows.Forms;

namespace ResManagerAdmin
{
    /// <summary>
    /// Klase qe mban funksionet e regjistrimit te programit si metoda statike
    /// </summary>
    public sealed class RegistrationClass
    {
        #region Private fields
        private static string path = "\\Software\\VisionInfoSolution\\RestaurantManager";
        private static string name = "Key";
        private static byte[] key = Encoding.ASCII.GetBytes("Vetem Zotit i perulem");
        private static string dateInstalledFilePath = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\conn.4343.sys";

        #endregion

        #region Public Methods
        /// <summary>
        /// Kontrollon nese Celesi i Hotel Manager, i ruajtur ne rregjistra eshte i vlefshem per versionin FULL
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool CelesVlefshem()
        {
            string encrypted = EncryptKeyDemo();

            string decrypted = DecryptKeyFull(encrypted);
            string vlere = EncryptKeyFull();
            if (decrypted == encrypted)
                return true;
            StoreKeyToRegistry(name, encrypted);
            GetSystemLoadedTime();
            return false;
        }

        /// <summary>
        /// Lexon numrin serial nga rregjistrat
        /// </summary>
        /// <returns></returns>
        public static string GetKey()
        {
            return GetKeyValue(path, name);
        }


        /// <summary>
        /// Lexon numrin serial nga rregjistrat dhe nga ky numer, ne baze te algoritmit,
        /// nxjerr numrin e dhomave
        /// </summary>
        /// <returns></returns>


        /// <summary>
        /// Kontrollon nese Hotel Managment eshte i instaluar si version Demo apo jo.
        /// Ky kontroll behet duke u nisura nga vlera qe ndodhet ne rregjister
        /// </summary>
        /// <returns>true nese programi eshte version Demo; perndryshe false</returns>
        public static bool IsDemoVersion()
        {
            try
            {
                string key1 = GetKey();
                string encrypted = EncryptKeyDemo();
                if (key1 == encrypted)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }


        public static string GetEncryptedKeyFull()
        {
            return EncryptKeyFull();
        }

        /// <summary>
        /// Ben ndryshimin e vleres se ruajtur ne rregjistra duke deshifruar vleren e deritanishme
        /// te ruajtur ne rregjistra. Versioni kthehet ne DEMO nese numri i dhomave eshte me i madh
        /// se sa ai i dhene me perpara, pavaresisht nese ka qene version i plote apo jo
        /// </summary>
        /// <param name="numerFillestarDhomash"></param>
        /// <param name="numerDhomash"></param>
        public static void EditRegistryKey()
        {
            //    string key1 = "";
            //    string keyValue = GetKeyValue(path, name);
            //    string[] splitKey = keyValue.Split(new char[] { '-' });
            //    int roomsCount = (numerDhomash + 4) * 3;
            //    if (splitKey.Length >= 2)
            //    {
            //        splitKey.SetValue(roomsCount.ToString(), splitKey.Length - 1);
            //        for (int i = 0; i < splitKey.Length - 1; i++)
            //        {
            //            key1 += splitKey.GetValue(i).ToString();
            //        }
            //        key1 += "-" + splitKey.GetValue(splitKey.Length - 1).ToString();
            //        key1 = RegistrationClass.EncryptKeyDemo();
            //        StoreKeyValue(path, name, key1);
            //        StoreKeyValue("Vlera2", numerDhomash.ToString().Length.ToString());
            //    }
            //    else
            //    {
            //        key1 = RegistrationClass.EncryptKeyDemo();
            //        StoreKeyValue(path, name, key1);
            //        StoreKeyValue("Vlera2", numerDhomash.ToString().Length.ToString());
            //    }
        }


        /// <summary>
        /// Ruan nje vlere per dhomat, per versionin DEMO te programit
        /// </summary>
        /// <param name="numerDhomash"></param>


        public static void StoreKeyToRegistry()
        {
            string Key = EncryptKeyDemo();
            StoreKeyValue(path, name, Key);
            //StoreKeyValue(path, name, "1");
        }

        /// <summary>
        /// Ruan vleren <see cref="celes"/> ne rregjistra
        /// </summary>
        /// <param name="celes"></param>
        public static void StoreKeyToRegistry(string celes)
        {
            StoreKeyValue(path, name, celes);
        }

        public static void StoreKeyToRegistry(string pathName, string valueName)
        {
            StoreKeyValue(pathName, valueName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public static bool IsDemoVersion(string Key)
        {
            try
            {
                if (Key[0] != '0')
                    return false;
            }
            catch
            {
                return true;
            }
            return true;
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Kap ditet qe kur programi eshte hapur per here te pare
        /// </summary>
        /// <returns></returns>
        private static int NumriDiteveNgaInstalimi()
        {
            string str = System.Environment.MachineName;
            string encFileString = "";
            TimeSpan days = TimeSpan.MaxValue;
            DateTime dateInstalled = DateTime.MinValue;
            StreamReader reader = null;
            try
            {
                if (File.Exists(dateInstalledFilePath))
                {
                    FileStream stream = File.Open(dateInstalledFilePath, FileMode.Open);
                    reader = new StreamReader(stream);
                    encFileString = reader.ReadToEnd();
                    dateInstalled = Convert.ToDateTime(encFileString);
                    days = DateTime.Now.Subtract(dateInstalled);
                }
            }
            catch
            {
                // Nese dicka nuk eshte ne rregull atehere i japim vleren maksimale
                days = TimeSpan.MaxValue;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return days.Days;
        }


        /// <summary>
        /// Kap numrin serial te hard diskut te pare qe eshte i instaluar dhe ka numer serial te vlefshem
        /// KUJDES!!! Duhet qe te testohet kur ne kompjutera perdoret Norton Ghost
        /// </summary>
        /// <returns>numrin serial qe kap nga Windowsi</returns>
        private static string GetHardDiskSignature()
        {
            try
            {
                ManagementObjectSearcher query;
                ManagementObjectCollection queryCollection;
                System.Management.ObjectQuery oq;
                ConnectionOptions co = new ConnectionOptions();
                ManagementScope ms = new ManagementScope("\\\\localhost\\root\\cimv2", co);
                oq = new System.Management.ObjectQuery("SELECT * FROM Win32_DiskDrive");
                query = new ManagementObjectSearcher(ms, oq);
                queryCollection = query.Get();
                foreach (ManagementObject mo in queryCollection)
                {
                    if (mo["Signature"] != null)
                    {
                        if (mo["Signature"].ToString().Length > 8)
                        {
                            string id = mo["Signature"].ToString();
                            return id.Substring(id.Length - 8, 8);
                        }
                        return Convert.ToInt64(mo["Signature"]).ToString("00000000");
                    }
                }
                return "00000001";
            }
            catch (Exception ex)
            {
                return "00000001";
            }
        }


        /// <summary>
        /// Merr numrin serial te windows-it qe eshte instaluar ne kete kompjuter dhe nxjerr nga ky numer
        /// 10 shifrat e para pa shenjen '-'. Ne rast te ndonje gabimi kthen "1".
        /// Ky numer nuk eshte unik per cdo kompjuter, te pakten ne rastet kur perdoret Norton Ghost.
        /// </summary>
        /// <returns>10 shifrat e para te numrit serial te Windows-it</returns>
        private static string GetSystemSerial()
        {
            try
            {
                string serial = "00000001";
                ManagementObjectSearcher query;
                ManagementObjectCollection queryCollection;
                System.Management.ObjectQuery oq;
                ConnectionOptions co = new ConnectionOptions();
                ManagementScope ms = new ManagementScope("\\\\localhost\\root\\cimv2", co);
                oq = new System.Management.ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                query = new ManagementObjectSearcher(ms, oq);
                queryCollection = query.Get();
                foreach (ManagementObject mo in queryCollection)
                {
                    if (mo["SerialNumber"] != null)
                    {
                        serial = mo["SerialNumber"].ToString();
                        break;
                    }
                }
                char[] str = { };
                if (serial.Replace("-", "").Length > 8)
                {
                    serial = serial.Replace("-", "");
                    return serial.Substring(serial.Length - 8, 8);
                }
                return serial;
            }
            catch
            {
                return "0000000001";
            }
        }


        /// <summary>
        /// Ne menyre qe nje nga variablat te jete dinamike, sepse ne kete menyre siguria do te
        /// rritej me shume, percaktojme se sa kohe ka qe eshte ngarkuar sistemi
        /// </summary>
        /// <returns>Kohen ne milisekonda gjate se ciles eshte ngarkuar sistemi. 1 nese
        /// ka ndodh ndonje gabim</returns>
        private static int GetSystemLoadedTime()
        {
            try
            {
                // Shohim ne fillim nese koha e hapjes eshte e ruajtur. Nese po, atehere kthe
                // vleren e ruajtjes
                if (GetKeyValue("SLT") == "" || GetKeyValue("SLT") == null || GetKeyValue("SLT").Length != 4)
                {
                    // Perndryshe gjej kohen dhe ktheje
                    string tickString = Environment.TickCount.ToString();
                    int tickInt = 1;
                    if (tickString.Length >= 4)
                    {
                        // Ne fillim shohim nese koha qe kur eshte ngarkuar sistemi eshte me e madhe
                        // se 10 sekonda. Ne kete rast marrim 4 shifrat e fundit
                        tickInt = Convert.ToInt32(tickString.Substring(tickString.Length - 4, 4));
                        tickString = tickInt.ToString();
                    }
                    else
                    {
                        // Perndryshe marrim te gjitha vlerat, duke i shtuar zero perpara
                        tickInt = Convert.ToInt32(tickString);
                        tickString = tickInt.ToString("0000");
                        Convert.ToInt32(tickString);
                    }
                    StoreKeyToRegistry("SLT", tickString);
                }
                return Convert.ToInt32(GetKeyValue("SLT"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SLT");
                StoreKeyToRegistry("SLT", "");
                return 1000;
            }
        }


        /// <summary>
        /// Kap daten kur eshte instaluar sistemi i shfrytezimit ne kete kompjuter
        /// </summary>
        /// <returns></returns>
        private static string GetSystemDateInstalled()
        {
            try
            {
                ManagementObjectSearcher query;
                ManagementObjectCollection queryCollection;
                System.Management.ObjectQuery oq;
                string dateInstalledString = "";
                ConnectionOptions co = new ConnectionOptions();
                ManagementScope ms = new ManagementScope("\\\\localhost\\root\\cimv2", co);
                oq = new System.Management.ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                query = new ManagementObjectSearcher(ms, oq);
                queryCollection = query.Get();
                foreach (ManagementObject mo in queryCollection)
                {
                    if (mo["InstallDate"] != null)
                    {
                        dateInstalledString = mo["InstallDate"].ToString();
                    }
                }
                return dateInstalledString;
            }
            catch
            {
                return "";
            }
        }


        /// <summary>
        /// Ben kriptimin e celesit per versionin demo duke u nisur nga numri i dhomave, numri serial
        /// i Windows-it numri identifikues i Hard Diskut dhe koha qe kur sistemi eshte ngarkuar per
        /// here te fundit.
        /// Numri i dhomave mblidhet me 4 dhe i gjithe numri shumezohet me 3;
        /// </summary>
        /// <returns>vleren e kriptuar per celesin qe do te ruhet ne rregjistra</returns>
        private static string EncryptKeyDemo()
        {
            string hardDisk = GetHardDiskSignature();
            int loadedSystemTime = GetSystemLoadedTime();
            string serial = GetSystemSerial();
            return serial + hardDisk + loadedSystemTime;
        }


        private static string EncryptKeyFull()
        {
            string keyDemo = GetKeyValue(path, name);
            if (keyDemo == null)
            {

            }
            Encoding ascii = Encoding.ASCII;
            int nr;

            // Bejme kriptimin e kohes kur eshte ngarkuar sistemi
            string loadedSystemTime = keyDemo.Substring(keyDemo.Length - 4, 4);
            Byte[] systemTime = ascii.GetBytes(loadedSystemTime);
            string encodedSystemTime = "";
            foreach (Byte b in systemTime)
            {
                nr = Algebra.GetIndex(Convert.ToChar(b));
                // Bejme kete veprim: ((nr + 15) * 3) - 8
                nr = Algebra.Substract(Algebra.Multiply(Algebra.Sum(nr, 15, 59), 3, 59), 6, 59);
                encodedSystemTime += Algebra.GetChar(nr).ToString();
            }

            // Bejme kriptimin e numrit serial te Windows-it
            string systemSerial = keyDemo.Substring(0, 8);
            Byte[] encodedSystemSerial = ascii.GetBytes(systemSerial);
            string systemSerialEnc = "";
            foreach (Byte b in encodedSystemSerial)
            {
                nr = Algebra.GetIndex(Convert.ToChar(b));
                // Bejme kete veprim: ((nr - 2) * 10) + 7
                nr = Algebra.Sum(Algebra.Multiply(Algebra.Substract(nr, 2, 59), 10, 59), 7, 59);
                systemSerialEnc += Algebra.GetChar(nr);
            }

            // Bejme kriptimin e ID-se se hardDiskut
            string hardDisk = keyDemo.Substring(8, 8);
            Byte[] encodedHardDiskID = ascii.GetBytes(hardDisk);
            string hardDiskIDEnc = "";
            int i = 0;
            foreach (Byte b in encodedHardDiskID)
            {
                nr = Algebra.GetIndex(Convert.ToChar(b));
                // Bejme kete veprim: ((nr + 6) * 7) + ((i * 3) + 3)
                nr = Algebra.Sum(Algebra.Multiply(Algebra.Sum(nr, 6, 59), 7, 59),
                    Algebra.Sum(Algebra.Multiply(i, 3, 59), 3, 59), 59);
                hardDiskIDEnc += Algebra.GetChar(nr);
                i++;
            }

            // Ne kete pike vendosim te gjitha vlerat e nxjerra nga kriptimi, bashke
            return systemSerialEnc + hardDiskIDEnc + encodedSystemTime;
        }


        /// <summary>
        /// Ben deshifrimin e numrit serial qe eshte i ruajtur ne rregjistra nga versioni i plote ne
        /// versionin DEMO
        /// </summary>
        /// <returns>numrin serial te deshifruar</returns>
        private static string DecryptKeyFull(string encrypted)
        {
            try
            {
                string keyFull = GetKeyValue(path, name);
                if (keyFull == null || keyFull == "")
                {
                    StoreKeyToRegistry(name, encrypted);
                    keyFull = encrypted;
                }
                Encoding ascii = Encoding.ASCII;
                int nr;

                // Bejme deshifrimin e kohes se ngarkimit te sistemit
                string loadedSystemTime = keyFull.Substring(keyFull.Length - 4, 4);
                string systemTimeDec = "";
                Byte[] systemTime = ascii.GetBytes(loadedSystemTime);
                foreach (Byte b in systemTime)
                {
                    nr = Algebra.GetIndex(Convert.ToChar(b));
                    // Bejme kete veprim: ((nr + 8) / 3) - 15
                    nr = Algebra.Substract(Algebra.Divide(Algebra.Sum(nr, 6, 59), 3, 59), 15, 59);
                    systemTimeDec += Algebra.GetChar(nr).ToString();
                }

                // Bejme deshifrimin e numrit serial te sistemit
                string systemSerial = keyFull.Substring(0, 8);
                string systemSerialDec = "";
                Byte[] encodedSystemSerial = ascii.GetBytes(systemSerial);
                foreach (Byte b in encodedSystemSerial)
                {
                    nr = Algebra.GetIndex(Convert.ToChar(b));
                    // Bejme kete veprim: ((nr - 7) / 10) + 2
                    nr = Algebra.Sum(Algebra.Divide(Algebra.Substract(nr, 7, 59), 10, 59), 2, 59);
                    systemSerialDec += Algebra.GetChar(nr).ToString();
                }

                // Bejme deshifrimin e numrit serial te hard diskut
                string hardDiskSerial = keyFull.Substring(8, 8);
                string hardDiskSerialDec = "";
                Byte[] encodedHDSerial = ascii.GetBytes(hardDiskSerial);
                int i = 0;
                foreach (Byte b in encodedHDSerial)
                {
                    nr = Algebra.GetIndex(Convert.ToChar(b));
                    // Bejme kete veprim: ((nr - ((i * 3) + 3) / 7) - 6
                    nr = Algebra.Substract(Algebra.Divide(Algebra.Substract(nr,
                        Algebra.Sum(Algebra.Multiply(i, 3, 59), 3, 59), 59), 7, 59), 6, 59);
                    hardDiskSerialDec += Algebra.GetChar(nr).ToString();
                    i++;
                }
                // Tani bashkojme vlerat e gjetura nga deshifrimet e mesiperme dhe e kthejme kete vlere
                return systemSerialDec + hardDiskSerialDec + systemTimeDec;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private static int DecryptRoomsCountFull()
        {
            try
            {
                string lengthString = GetKeyValue("Vlera2");
                string keyFull = GetKeyValue(path, name);
                int length = Convert.ToInt32(lengthString);
                Encoding ascii = Encoding.ASCII;
                int nr;
                // Bejme deshifrimin e numrit te dhomave qe jane ne program
                string nrDhomash = keyFull.Substring(keyFull.Length - length, length);
                string nrDhomashDec = "";
                Byte[] encodedRoomCount = ascii.GetBytes(nrDhomash);
                foreach (Byte b in encodedRoomCount)
                {
                    nr = Algebra.GetIndex(Convert.ToChar(b));
                    // Bejme kete veprim: ((nr + 6) / 8) - 9
                    nr = Algebra.Substract(Algebra.Divide(Algebra.Sum(nr, 6, 59), 8, 59), 9, 59);
                    nrDhomashDec += Algebra.GetChar(nr).ToString();
                }
                return Convert.ToInt32(nrDhomashDec);
            }
            catch
            {
                return 0;
            }
        }


        /// <summary>
        /// Merr vleren e regjistrit per path-in dhe emrin e caktuar te rregjistrit
        /// </summary>
        /// <param name="keyPath">Path-i i celesit</param>
        /// <param name="name">Emri i celesit</param>
        /// <returns>Vleren ne pathin e dhene</returns>
        private static string GetKeyValue(string keyPath, string name)
        {
            try
            {
                Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
                Microsoft.Win32.RegistryKey hkSoftware = hklm.OpenSubKey("Software", true);
                Microsoft.Win32.RegistryKey hkHotel = hkSoftware.OpenSubKey("VisionInfoSolution");
                Microsoft.Win32.RegistryKey key = hkHotel.OpenSubKey("RestaurantManager");
                if (key != null)
                {
                    string str = key.GetValue(name).ToString();
                    return str;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private static string GetKeyValue(string name)
        {
            Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
            Microsoft.Win32.RegistryKey hkSoftware = hklm.OpenSubKey("Software", true);
            Microsoft.Win32.RegistryKey hkHotel = hkSoftware.OpenSubKey("VisionInfoSolution");
            Microsoft.Win32.RegistryKey key = hkHotel.OpenSubKey("RestaurantManager");
            if (key != null)
                return key.GetValue(name).ToString();
            else
                return null;
        }


        /// <summary>
        /// Ruan vleren e dhene te regjistrit ne path-in dhe emrin e dhene
        /// </summary>
        /// <param name="keyPath">Path-i i celesit</param>
        /// <param name="name">Emri i celesit</param>
        /// <param name="keyValue">Vlera qe do ti jepet celesit</param>
        private static void StoreKeyValue(string keyPath, string name, string keyValue)
        {
            Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
            Microsoft.Win32.RegistryKey hkSoftware = hklm.OpenSubKey("Software", true);
            Microsoft.Win32.RegistryKey hkHotel = hkSoftware.CreateSubKey("VisionInfoSolution");
            Microsoft.Win32.RegistryKey key = hkHotel.CreateSubKey("RestaurantManager");
            if (key != null)
                key.SetValue(name, keyValue);
        }

        private static void StoreKeyValue(string name, string keyValue)
        {
            Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.Registry.LocalMachine;
            Microsoft.Win32.RegistryKey hkSoftware = hklm.OpenSubKey("Software", true);
            Microsoft.Win32.RegistryKey hkHotel = hkSoftware.CreateSubKey("VisionInfoSolution");
            Microsoft.Win32.RegistryKey key = hkHotel.CreateSubKey("RestaurantManager");
            //			Microsoft.Win32.RegistryKey key = hklm.CreateSubKey(keyPath);
            if (key != null)
                key.SetValue(name, keyValue);
        }
        #endregion
    }


    /// <summary>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
    /// Klase qe ben veprimet matematikore ne nje unaze me 59 elemente.
    /// Kjo klase nuk mund te inheritohet
    /// </summary>
    public sealed class Algebra
    {
        /// <summary>
        /// Mban te gjitha karakteret qe do te perdoren per shifrim
        /// </summary>
        private static char[] elements = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 
											 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 
											 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 
											 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 
											 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 
											 'U', 'V', 'W',};



        /// <summary>
        /// Gjen shumefishin me te vogel te perbashket te numrave <see cref="x"/> dhe <see cref="y"/>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>shumefishin me te vogel te numrave <see cref="x"/> dhe <see cref="y"/></returns>
        public static long GCD(long x, long y)
        {
            while (y != 0)
            {
                long r = x % y;
                x = y;
                y = r;
            }
            return x;
        }


        /// <summary>
        /// Gjen te anasjelltin e elementit <see cref="x"/> ne fushen me <see cref="y"/> elemente.
        /// <para> Kjo metode bazohet ne algoritmin e Knuth</para>
        /// </summary>
        /// <param name="x">elementi per te cilin duhet te gjendet i anasjellti</param>
        /// <param name="y">elementet e fushes ne te cilin duhet te gjendet i anasjellti</param>
        /// <returns>te anasjelltin e numrit x ne fushen y</returns>
        public static long GCD1(long x, long y)
        {
            if (x == 0)
                return 0;
            if (x == 1)
                return 1;
            if (x == y)
                return x;
            long[] u = { 1, 0, x }, v = { 0, 1, y }, t = new long[3];
            while (v[2] != 0)
            {
                long q = u[2] / v[2];
                for (int i = 0; i < 3; i++)
                {
                    t[i] = u[i] - v[i] * q;
                    u[i] = v[i];
                    v[i] = t[i];
                }
            }
            Int64 nr1 = Convert.ToInt64(u.GetValue(0));
            if (nr1 <= 0)
                nr1 = 59 + nr1;
            return nr1;
        }


        /// <summary>
        /// Kryen shumezimin e dy numrave <see cref="x"/> dhe <see cref="y"/> ne fushen me
        /// <see cref="z"/> elemente
        /// </summary>
        /// <param name="x">numri i pare qe do te shumezohet</param>
        /// <param name="y">numri i dyte qe do te shumezohet</param>
        /// <param name="z">fusha ne te cilen do te kryhet veprimi i shumezimit</param>
        /// <returns>vleren qe merret nga shumezimi i dy numrave ne fushen me <see cref="z"/> elemente</returns>
        public static int Multiply(int x, int y, int z)
        {
            int a = x * y;
            if (a > z - 1)
                a = a % z;
            return a;
        }


        /// <summary>
        /// Kryen mbledhjen e dy numrave <see cref="x"/> dhe <see cref="y"/> ne fushen me
        /// <see cref="z"/> elemente
        /// </summary>
        /// <param name="x">numri i pare qe do te mblidhet</param>
        /// <param name="y">numri i dyte qe do te mblidhet</param>
        /// <param name="z">fusha ne te cilen do te kryhet veprimi i mbledhjes</param>
        /// <returns>vleren qe merret nga mbledhja e dy numrave ne fushen me <see cref="z"/> elemente</returns>
        public static int Sum(int x, int y, int z)
        {
            int a = x + y;
            if (a > z - 1)
                a = a % z;
            return a;
        }


        /// <summary>
        /// Kryen zbritjen e dy numrave <see cref="x"/> dhe <see cref="y"/> ne fushen me
        /// <see cref="z"/> elemente
        /// </summary>
        /// <param name="x">numri nga i cili do te zbritet numri <see cref="y"/></param>
        /// <param name="y">numri i cili do ti zbritet numri <see cref="x"/></param>
        /// <param name="z">fusha ne te cilen do te kryhet veprimi i zbritjes</param>
        /// <returns>vleren qe do te perftohet nga zbritja e dy numrave ne fushen me <see cref="z"/> elemente</returns>
        public static int Substract(int x, int y, int z)
        {
            int a = x - y;
            if (a < 0)
                a = a + z;
            return a;
        }


        /// <summary>
        /// Kryen pjesetimin e numrit <see cref="x"/> me numrin <see cref="y"/> ne fushen me
        /// <see cref="z"/> elemente
        /// </summary>
        /// <param name="x">numri nga i cili do te pjesetohet numri <see cref="y"/></param>
        /// <param name="y">pjesetuesi i numrit <see cref="x"/></param>
        /// <param name="z">fusha ne te cilen do te kryhet veprimi i pjesetimi</param>
        /// <returns>vleren qe merret nga pjesetimi i dy numrave</returns>
        public static int Divide(int x, int y, int z)
        {
            // Ne fillim gjejme te anasjelltin e y ne fushen z
            int b = Convert.ToInt32(Algebra.GCD1(y, z));
            long a = x * b;
            if (a > z)
                a = a % z;
            return Convert.ToInt32(a);
        }


        public static char GetChar(int x)
        {
            if (x < 0)
                return elements[x + 59];
            if (x > 58)
                return elements[x % 59];
            return elements[x];
        }

        /// <summary>
        /// Merr indeksin e shkronjes ch ne korrespondence me vektorin elements
        /// </summary>
        /// <param name="ch">karakteri per te cilin do te gjendet korrespondenca</param>
        /// <returns>indeksin e karakterit <see cref="ch"/></returns>
        public static int GetIndex(char ch)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == ch)
                    return i;
            }
            return 0;
        }
    }



    /// <summary>
    /// Summary description for Global.
    /// </summary>
    public class Globals
    {
        private string loggedUser = "";
        private static string defaultHelpFile = "about:blank";
#if DEBUG
        private static string homeFile = @"\..\..\home.htm";
#else
		private static string homeFile = @"\home.htm";
#endif
        public Globals()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static void UserData()
        {
            Globals global = new Globals();
        }

        public string LoggedUser
        {
            get
            {
                return this.loggedUser;
            }
            set
            {
                this.loggedUser = value;
            }
        }

        /// <summary>
        /// Skedari default qe hapet per help-in ku ai nuk eshte i vlefshem
        /// </summary>
        public static string DefaultHelpFile
        {
            get
            {
                return defaultHelpFile;
            }
        }

        /// <summary>
        /// Skedari home per help-in
        /// </summary>
        public static string HomeFile
        {
            get
            {
                return homeFile;
            }
        }

        /// <summary>
        /// Merr te dhenat e skedarit te dhene nga nje isolated storage
        /// </summary>
        /// <param name="fileName">emri i skedarit per te cilin do te merren te dhenat</param>
        /// <returns>te dhenat e skedarit. Nese skedari nuk ekziston, kthen null</returns>
        public static string GetIsolatedStorageContent(string fileName)
        {
            IsolatedStorageFile store = IsolatedStorageFile.GetStore(IsolatedStorageScope.Assembly |
                IsolatedStorageScope.User, null, null);
            string[] fileNames = store.GetFileNames(fileName);
            if (fileNames.Length == 0)
                return null;
            string content = "";
            using (StreamReader reader = new StreamReader(new IsolatedStorageFileStream(
                      fileName, FileMode.Open, store)))
            {
                content = reader.ReadToEnd();
            }
            return content;
        }

        public static void StoreToIsolatedStorage(string fileName, string data)
        {
            IsolatedStorageFile store = IsolatedStorageFile.GetStore(IsolatedStorageScope.Assembly |
                IsolatedStorageScope.User, null, null);
            using (StreamWriter writer = new StreamWriter(new IsolatedStorageFileStream(fileName,
                       FileMode.OpenOrCreate, store)))
            {
                writer.Write(data);
            }
        }

        public static StreamWriter GetIsolatedStorageStreamWriter(string fileName)
        {
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
            return new StreamWriter(new IsolatedStorageFileStream(fileName, FileMode.Create, isoStore));
        }

    }


}
