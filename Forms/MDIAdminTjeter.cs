using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using System.IO;
using System.Data.SqlClient;

namespace ResManagerAdmin.Forms
{
    public partial class MDIAdminTjeter : System.Windows.Forms.Form
    {
        private int childFormNumber = 0;
        public static int idPerdoruesi = 0;
        public static  string emerPerdoruesi = "";
        public static string mbiemerPerdoruesi = "";
        public static string perdoruesi = "";
        public static int idRoli = 0;
        public static string emriRes = "";
        public bool anullo = false;

        public static string strKonfigurimi = "";

        #region MDIParent
        public MDIAdminTjeter()
        {
            frmLogin.ShowForm();
            idPerdoruesi = frmLogin.idPerdoruesi;
            emerPerdoruesi = frmLogin.emerPerdoruesi;
            mbiemerPerdoruesi = frmLogin.mbiemerPerdoruesi;
            perdoruesi = frmLogin.perdoruesi;
            idRoli = frmLogin.idRoli;
            if (idPerdoruesi == -1)
            {
                anullo = true;
                this.Close();
                return;
            }
            System.Globalization.CultureInfo MyCulture = System.Globalization.CultureInfo.CreateSpecificCulture("sq-Al");
            MyCulture.DateTimeFormat.LongDatePattern = "dd-MM-yyyy";
            MyCulture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            MyCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            MyCulture.NumberFormat.CurrencyGroupSeparator = ",";

            MyCulture.NumberFormat.NumberDecimalSeparator = ".";
            MyCulture.NumberFormat.NumberGroupSeparator = ",";
            MyCulture.NumberFormat.NumberDecimalDigits = 2;
            MyCulture.NumberFormat.CurrencyDecimalDigits = 2;
            Application.CurrentCulture = MyCulture;
            InitializeComponent();
        }

        private void MDIAdmin_Load(object sender, EventArgs e)
        {

            //Shtojme nje dokument fillestar per documentManager
            FaqjaKryesore frm = new FaqjaKryesore();
            frm.FormBorderStyle = FormBorderStyle.None;
            this.ShowNewForm(frm);

            //lexohet emri i restorantit
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.Xml";
            DataSet ds = data.KerkesaRead("LexoInformacioneRestoranti");
            MDIAdminTjeter.emriRes = ds.Tables[0].Rows[0]["EMRI"].ToString();
        }
        #endregion

        #region MenuItem Events
        
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            int n = tabStrip1.Tabs.Count;
            for (int i = 0; i < n - 1; i++)
            {
                tabStrip1.Tabs.RemoveAt(tabStrip1.Tabs.Count - 1);
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.documentManager.FocusedDocument == null)
                return;
            ResManagerLibrary.IPrintable frm = this.documentManager.FocusedDocument.Control as ResManagerLibrary.IPrintable;
            if (frm != null)
            {
                this.Cursor = Cursors.WaitCursor;
                frm.Print();
                this.Cursor = Cursors.Default;
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.documentManager.FocusedDocument == null)
                return;
            ResManagerLibrary.IPrintable frm = this.documentManager.FocusedDocument.Control as ResManagerLibrary.IPrintable;
            if (frm != null)
            {
                this.Cursor = Cursors.WaitCursor;
                frm.PrintPreview();
                this.Cursor = Cursors.Default;
            }
        }

        private void cmimetEArtikujveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKonfigurimCmimeArtikuj());
        }

        private void kategoriteTavolinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResManagerAdmin.Forms.frmKategoriteTavolina frm = new frmKategoriteTavolina();
            ShowNewDialogForm(frm);
        }

      

        private void konfigurimTavolinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResManagerAdmin.Forms.frmKonfigurimTavolinash frm = new frmKonfigurimTavolinash();
            ShowNewDialogForm(frm);
        }

        private void pozicionimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmPozicionimiTavolina());
        }

        private void imazhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmImazhRestoranti());
        }

        private void rezervimetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmRezervime());
        }

        private void dergesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmDergesa());
        }

        private void konfigurimArtikujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKonfigurimArtikujsh());
        }

        private void kategoriteArtikujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategoriteArtikuj frm = new frmKategoriteArtikuj();
            ShowNewDialogForm(frm);
        }

        private void kontrolloSkorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKontrolloSkorte());
        }

        private void konfigurimRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKonfigurimRecetash());
        }

        

        private void konfigurimFurnitoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void blerjeArtikujshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmBlerjeArtikujsh());
        }

        private void kategoritëEShpenzimeveToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmKategoriteShpenzime frm = new frmKategoriteShpenzime();
             ShowNewDialogForm(frm);
        }

        private void kryejShpenzimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKryejShpenzim frm = new frmKryejShpenzim();
            ShowNewDialogForm(frm);
        }

        private void kategoriteRecetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategoriteReceta frm = new frmKategoriteReceta();
            ShowNewDialogForm(frm);
        }
        
        private void shfaqBlerjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmShfaqBlerjet());
        }

        private void faturatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmFatura());
        }

        private void shfaqShpenzimetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmShfaqShpenzime());
        }

        private void fitimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmFitimi());
        }

        private void bilancDitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmBilancDitor());
        }

        private void bilancMujorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmBilancMujor());
        }

        private void sipasFaturaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmXhiroSipasFaturave());
        }

        private void sipasArtikujveDheRecetaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmXhiroSipasArtikujve());
        }

        private void arkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmArka());
        }

        private void konfigurimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKonfiguroPersonel frm = new frmKonfiguroPersonel();
            frm.veprimi = 1;
            ShowNewDialogForm(frm);
        }

        private void turnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmTurnet());
        }

        private void vizualizimStafiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmVizualizimStafi());
        }

        private void krijoOfertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void shfaqOfertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmShfaqOferta());
        }

        private void formaEPagesaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormatPagesa frm = new frmFormatPagesa();
            ShowNewDialogForm(frm);
        }

        private void njësiMateseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNjesiteMatese frm = new frmNjesiteMatese();
            ShowNewDialogForm(frm);
        }

        private void informacioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformacione frm = new frmInformacione();
            ShowNewDialogForm(frm);
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void konfigurimTëDhënashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKonfigurimFurnitoresh());

        }

        private void përkatësitëEArtikujveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmArtikujFurnitore());
        }

       
        private void klientetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKonfigurimKlientet());
        }

      
        private void kategoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKatShpenzimiMujor frm = new frmKatShpenzimiMujor();
            ShowNewDialogForm(frm);
        }

        #endregion

        #region PrivateMethods

        private void ShowNewForm(System.Windows.Forms.Form frm)
        {
            //nqs forma eshte hapur njehere atehere nuk e hapim per here te dyte
            foreach (DevComponents.DotNetBar.TabItem i in tabStrip1.Tabs)
            {
                if (frm.Name == i.Name)
                {
                    tabStrip1.SelectedTab = i;
                    return;
                }
            }
            frm.MdiParent = this;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ControlBox = false;
            childFormNumber++;
            //shtojme elementin ne tabStrip
            DevComponents.DotNetBar.TabItem item = new DevComponents.DotNetBar.TabItem();
            item.Name = frm.Name;
            item.Text = frm.Text;
            tabStrip1.Tabs.Add(item);
            frm.Dock = DockStyle.Fill;
            //per te njejtin element qe shtuam ne tabStrip shtojme
            //dokumentin korrespondues ne documentManager
            DocumentManager.Document doc = new DocumentManager.Document(frm, frm.Name);
            this.documentManager.AddDocument(doc);
            this.documentManager.FocusedDocument = doc;
            this.ActiveControl = frm;
            frm.Activate();
            frm.Location = new Point(0, 23);
            tabStrip1.SelectedTab = tabStrip1.Tabs[tabStrip1.Tabs.Count - 1];
            this.ToggleMenuItems(frm);
            
        }

        private void ShowNewDialogForm(System.Windows.Forms.Form frm)
        {
            Form frm2 = this.ActiveControl as Form;
            if (frm2 != null)
            {
                frm2.CausesValidation = true;
            }
            frm.ShowDialog();
            if (frm2 != null)
            {

                frm2.CausesValidation = false;
                frm2.Focus();
            }
        }
        #endregion

        #region TabStrip Events
        private void tabStrip1_TabItemClose_1(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            //ne te njejten kohe mbyllim edhe elementin ne tabStrip
            //edhe dokumentin ne documentManager
            if (tabStrip1.SelectedTab.Name == "FaqjaKryesore")
                return;
            int index = tabStrip1.SelectedTabIndex;
            documentManager.RemoveDocument(documentManager.FocusedDocument);
            tabStrip1.Tabs.RemoveAt(index);
        }

        private void tabStrip1_SelectedTabChanged_1(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            //ngjarjet e tabStrip i lidhim me ngjarjet e docMananager
            //Nqs ndryshon elementi i zgjedhur ne tabStrip
            //ndryshojme edhe dokumentin e fokusuar ne documentManager
            if (documentManager.TabStrips.Count != 0)
                if (documentManager.TabStrips[0].Documents.Count != 0)
                {
                    documentManager.FocusedDocument = documentManager.TabStrips[0].Documents[tabStrip1.SelectedTabIndex];
                }
        }

        private void tabStrip1_NavigateForward_1(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            tabStrip1.SelectedTabIndex = tabStrip1.SelectedTabIndex + 1;
        }

        private void tabStrip1_NavigateBack_1(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            tabStrip1.SelectedTabIndex = tabStrip1.SelectedTabIndex - 1;
        }
        
        private void documentManager_FocusedDocumentChanged_1(object sender, EventArgs e)
        {
            if (this.documentManager.FocusedDocument != null)
            {
                System.Windows.Forms.Form frm = this.documentManager.FocusedDocument.Control as System.Windows.Forms.Form;

                if (frm != null)
                {
                    // Beji update help-it dhe menuve te printimit
                    //this.ShowHelp(frm.HelpFile);
                    this.ToggleMenuItems(frm);
                    frm.Activate();
                    frm.CausesValidation = true;
                    frm.CausesValidation = false;
                }
            }
        }

        #endregion             

        #region Icon_Click
        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.documentManager.FocusedDocument == null)
                return;
            ResManagerLibrary.IPrintable frm = this.documentManager.FocusedDocument.Control as ResManagerLibrary.IPrintable;
            if (frm != null)
            {
                this.Cursor = Cursors.WaitCursor;
                frm.PrintPreview();
                this.Cursor = Cursors.Default;
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.documentManager.FocusedDocument == null)
                return;
            ResManagerLibrary.IPrintable frm = this.documentManager.FocusedDocument.Control as ResManagerLibrary.IPrintable;
            if (frm != null)
            {
                this.Cursor = Cursors.WaitCursor;
                frm.Print();
                this.Cursor = Cursors.Default;
            }
        }

        private void toolStripButtonExcel_Click(object sender, EventArgs e)
        {
            if (this.documentManager.FocusedDocument == null)
                return;
            ResManagerLibrary.IPrintable frm = this.documentManager.FocusedDocument.Control as ResManagerLibrary.IPrintable;
            if (frm != null)
            {
                this.Cursor = Cursors.WaitCursor;
                frm.ConvertToExcel();
                this.Cursor = Cursors.Default;
            }
        }

        private void konvertoNëExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.documentManager.FocusedDocument == null)
                return;
            ResManagerLibrary.IPrintable frm = this.documentManager.FocusedDocument.Control as ResManagerLibrary.IPrintable;
            if (frm != null)
            {
                this.Cursor = Cursors.WaitCursor;
                frm.ConvertToExcel();
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        private void MDIAdminTjeter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (idPerdoruesi > 0)
            {
                InputController data = new InputController();
                int b = data.KerkesaUpdate("Logout", idPerdoruesi, 0);
            }
        }

        private void MDIAdminTjeter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region Toggle Menus & Buttons

        /// <summary>
        /// Ndrysho gjendjet (enable dhe disable) te butonave print dhe printPreview
        /// </summary>
        /// <param name="frm"></param>
        private void TogglePrintMenus(ResManagerLibrary.IPrintable frm)
        {
            if (frm.ReadyToPrint)
            {
                this.printToolStripMenuItem.Enabled = true;
                this.printPreviewToolStripMenuItem.Enabled = true;
                this.printToolStripButton.Enabled = true;
                this.printPreviewToolStripButton.Enabled = true;
                konvertoNëExcelToolStripMenuItem.Enabled = true;
                toolStripButtonExcel.Enabled = true;
            }
            else
            {
                this.printToolStripMenuItem.Enabled = false;
                this.printPreviewToolStripMenuItem.Enabled = false;
                this.printToolStripButton.Enabled = false;
                this.printPreviewToolStripButton.Enabled = false;
                konvertoNëExcelToolStripMenuItem.Enabled = false;
                toolStripButtonExcel.Enabled = false;
            }
        }

        private void ToggleMenuItems(System.Windows.Forms.Form frm)
        {
            ResManagerLibrary.IPrintable printable = frm as ResManagerLibrary.IPrintable;
            if (printable != null)
            {
                printable.ReadyToPrintChanged += new ResManagerLibrary.ReadyChangedEventHandler(OnReadyToPrintChanged);
                this.TogglePrintMenus(printable);
                if (printable.ReadyToPrint)
                {
                    this.printToolStripMenuItem.Enabled = true;
                    this.printPreviewToolStripMenuItem.Enabled = true;
                    this.printToolStripButton.Enabled = true;
                    this.printPreviewToolStripButton.Enabled = true;
                    konvertoNëExcelToolStripMenuItem.Enabled = true;
                    toolStripButtonExcel.Enabled = true;
                }
                else
                {
                    this.printToolStripMenuItem.Enabled = false;
                    this.printPreviewToolStripMenuItem.Enabled = false;
                    this.printToolStripButton.Enabled = false;
                    this.printPreviewToolStripButton.Enabled = false;
                    konvertoNëExcelToolStripMenuItem.Enabled = false;
                    toolStripButtonExcel.Enabled = false;
                }
            }
            else
            {
                this.printToolStripMenuItem.Enabled = false;
                this.printPreviewToolStripMenuItem.Enabled = false;
                this.printToolStripButton.Enabled = false;
                this.printPreviewToolStripButton.Enabled = false;
                konvertoNëExcelToolStripMenuItem.Enabled = false;
                toolStripButtonExcel.Enabled = false;
            }

        }
        #endregion

        #region Event Handlers
        private void OnReadyToPrintChanged(object sender, ResManagerLibrary.ReadyChangedEventArgs e)
        {
            ResManagerLibrary.Form frm = sender as ResManagerLibrary.Form;
            if (frm != null)
            {
                ResManagerLibrary.IPrintable printable = frm as ResManagerLibrary.IPrintable;
                if (printable != null)
                {
                    this.TogglePrintMenus(printable);
                }
            }
        }

        private void documentManager_FocusedDocumentChanged(object sender, EventArgs e)
        {
            if (this.documentManager.FocusedDocument != null)
            {
                System.Windows.Forms.Form frm = this.documentManager.FocusedDocument.Control as System.Windows.Forms.Form;
                //if (frm.Name != this.formaFundit)
                //{
                //    frm.PastroForme(frm);
                //    frm.NgarkoForme();
                //    this.formaFundit = frm.Name;
                //    frm.AutoScrollPosition = new Point(0, 0);
                //}
                if (frm != null)
                {
                    // Beji update help-it dhe menuve te printimit
                    //this.ShowHelp(frm.HelpFile);
                    this.ToggleMenuItems(frm);
                    //Debug.WriteLine(String.Format("Dokumenti fokus: {0}", this.documentManager.FocusedDocument.Text));
                }
                //if (frm.Name != "FaqeKryesore")
                //{
                //    this.pnlNdihme.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
                //    this.pnlNdihme.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
                //    this.faqeKryesore = false;
                //    this.pnlNdihme.AutoHide = true;
                //    frm.AutoScrollPosition = new Point(0, 0);
                //}
                //else
                //{
                //    this.pnlNdihme.Width = 200;
                //    this.pnlNdihme.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
                //    this.pnlNdihme.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
                //    this.pnlNdihme.AutoHideActive = false;
                //    if (this.pnlNdihme.Closed)
                //        this.pnlNdihme.Closed = false;
                //    if (this.pnlNdihme.AutoHide)
                //        this.pnlNdihme.AutoHide = false;
                //    this.faqeKryesore = true;
                //}
            }
        }
        #endregion

        #region Back up Database

        private void krijoBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show(this, "Jeni të sigurtë që doni t'i bëni back up bazës së të dhënave?", Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.No)
                    return;
                InputController data = new InputController();
                int b = data.KerkesaUpdate("KrijoBackUp");
                if (b == 0)
                {
                    MessageBox.Show(this, "Back up-i u ruajt në C:\\ResManager Back up.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Ndodhi një gabim gjatë krijimit të back-up! Provoni përsëri!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ndodhi një gabim gjatë krijimit të back-up! Provoni përsëri!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void karikoBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKarikoBackUp frm = new frmKarikoBackUp();
            frm.ShowDialog();
        }
        #endregion

        private void kryejShpenzimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmShpenzimetMujore());
        }
       
        private void konfigurimeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKonfigurime());
        }

        private void ofertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKrijoOferte());
        }

        private void shfaqRezervimetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmRezervime());
        }        

        private void grupetECmimeveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmGrupCmimet());
        }

        private void cmimetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmCmimet());
        }

        private void tabStrip1_Click(object sender, EventArgs e)
        {

        }
        
        private void rrethNeshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zgjidhGrupinKorentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmZgjidhGrupCmimi());
        }

        private void menuEShpejteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmFavoritet());
        }

        private void tabStrip1_TabRemoved(object sender, EventArgs e)
        {
            
        }

        private void modelPrintimiToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmPrintimi());
        }

        private void documentManager_ControlRemoved(object sender, ControlEventArgs e)
        {
            //if (MDIAdminTjeter.strKonfigurimi == "")
            //{
            //    return;
            //}

            //int indeksiOld = tabStrip1.SelectedTabIndex;

            //if (MDIAdminTjeter.strKonfigurimi == "Model printimi")
            //{
            //    this.ShowNewForm(new frmPrintimi());
            //}

            
            //int index = tabStrip1.SelectedTabIndex;
            ////documentManager.RemoveDocument(documentManager.FocusedDocument);
            //tabStrip1.Tabs.RemoveAt(indeksiOld);

            //MDIAdminTjeter.strKonfigurimi = "";
           
        }

        private void banakuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmLevizMallin());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKonfigurimArtikujsh());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmFatura());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmRezervime());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmKryejShpenzim frm = new frmKryejShpenzim();
            frm.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKonfigurimRecetash());
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmBlerjeArtikujsh());
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmKonfigurimFurnitoresh());
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmXhiroSipasFaturave());
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmFitimi());
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.ShowNewForm(new frmTurnet());
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show(this, "Jeni të sigurtë që doni t'i bëni back up bazës së të dhënave?", Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (r == DialogResult.No)
                    return;
                InputController data = new InputController();
                int b = data.KerkesaUpdate("KrijoBackUp");
                if (b == 0)
                {
                    MessageBox.Show(this, "Back up-i u ruajt në C:\\ResManager Back up.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Ndodhi një gabim gjatë krijimit të back-up! Provoni përsëri!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ndodhi një gabim gjatë krijimit të back-up! Provoni përsëri!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        
    }
}
