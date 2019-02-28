using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using Microsoft.SqlServer;
using ResManagerAdmin.BusDatService;

namespace ResManager.Forms
{
    public partial class frmTavolina : Form
    {
        public DataSet dsTavolinat;
        public int idTavolina;
        public string nrTavolina;
        public string gjendja;
        public int[] idFaturat;
        public int veprimi = 0;

        private string[] printArtikujt = null;
        private string[] printCmimet = null;
        private string[] printSasite = null;
        private string[] printVlerat = null;
        private string printTotali = "";
        private string printBari = "";
        private string printTavolina = "";
        private string printUser = "";

        public int tranferimi;
        public int idTavNew;

        private int printModeli = 3;

        private DataSet dsPrinterTavolina = null;
        private DataSet dsPrinterBanaku = null;

        public frmTavolina()
        {
            InitializeComponent();
        }

        private void frmTavolina_Load(object sender, EventArgs e)
        {
            this.Text = "Tavolina :  " + this.nrTavolina;
           this.MbushGridenTotali();
            this.MbushGridenFaturat();
            this.KtheInformacionPerBarin();
            this.LexoXml();

            this.dsPrinterTavolina = this.KrijoDataSetZgjidh();
            this.dsPrinterBanaku = this.KrijoDataSetZgjidh();

            this.LexoXmlPrinterat();
        }

        private void MbushGridenFaturat()
        {
            int nr = 0;

            for (int i = 0; i < 20; i++)
            {
                if (idFaturat[i] != 0)
                {
                    nr = nr + 1;
                }
            }

            if (nr == 0)
            {
                return;
            }

            int[] celesi = new int[nr];

            for (int i = 0; i < nr; i++)
            {
                celesi[i] = idFaturat[i];
            }

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("LexoTeDhenaPerTavolinen", celesi);

            DataSet dsFaturat = this.FormatoDataSetFaturat(ds);
            this.gridaFaturat.DataSource = dsFaturat.Tables[0];

        }

        private DataSet FormatoDataSetFaturat(DataSet ds)
        {
            DataSet dsFaturat = new DataSet();
            dsFaturat.Tables.Add();

            dsFaturat.Tables[0].Columns.Add("ID_FATURA", typeof(Int32));
            dsFaturat.Tables[0].Columns.Add("NR_FATURE", typeof(string));
            dsFaturat.Tables[0].Columns.Add("ID_RECETA", typeof(Int32));
            dsFaturat.Tables[0].Columns.Add("EMRI", typeof(string));
            dsFaturat.Tables[0].Columns.Add("CMIMI", typeof(float));
            dsFaturat.Tables[0].Columns.Add("SASIA", typeof(float));
            dsFaturat.Tables[0].Columns.Add("VLERA", typeof(float));
            dsFaturat.Tables[0].Columns.Add("PERSHKRIMI", typeof(string));

            dsFaturat.Tables[0].AcceptChanges();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = dsFaturat.Tables[0].NewRow();

                drNew["ID_FATURA"] = dr["ID_FATURA"];
                drNew["NR_FATURE"] = dr["NR_FATURE"];
                drNew["ID_RECETA"] = dr["ID_RECETA"];
                drNew["EMRI"] = dr["EMRI"];
                drNew["CMIMI"] = dr["VLERA"];
                drNew["SASIA"] = dr["SASIA"];
                drNew["VLERA"] = dr["TOTALI"];
                drNew["PERSHKRIMI"] = "Nr: " + Convert.ToString(dr["NR_FATURE"]) + ",   Kamarieri:  " + Convert.ToString(dr["PERDORUESI"]);

                dsFaturat.Tables[0].Rows.Add(drNew);
            }

            dsFaturat.Tables[0].AcceptChanges();

            return dsFaturat;

        }

        

        private void panelBack_Click(object sender, EventArgs e)
        {

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

        private void MbushGridenTotali()
        {
            int nr = 0;

            for (int i = 0; i < 20; i++)
            {
                if (idFaturat[i] != 0)
                {
                    nr = nr + 1;
                }
            }

            if (nr == 0)
            {
                return;
            }

            int[] celesi = new int[nr];

            for (int i = 0; i < nr; i++)
            {
                celesi[i] = idFaturat[i];
            }

            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("LexoTeDhenaPerTavolinen", celesi);

            DataSet dsFaturat = this.KrijoDataSet();

            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                DataRow drNew = dsFaturat.Tables[0].NewRow();

                drNew["ID_FATURA"] = dr["ID_FATURA"];
                drNew["NR_FATURE"] = dr["NR_FATURE"];
                drNew["ID_RECETA"] = dr["ID_RECETA"];
                drNew["EMRI"] = dr["EMRI"];
                drNew["CMIMI"] = dr["VLERA"];
                drNew["SASIA"] = dr["SASIA"];
                drNew["VLERA"] = Convert.ToDouble(dr["VLERA"]) * Convert.ToInt32(dr["SASIA"]);

                dsFaturat.Tables[0].Rows.Add(drNew);

            }

            dsFaturat.Tables[0].AcceptChanges();

            DataSet dsArtikujt = this.KtheDsArtikujt(dsFaturat);

            this.gridaTotali.DataSource = dsArtikujt.Tables[0];

            int numri = dsArtikujt.Tables[0].Rows.Count;

            double totali = 0;
            int j = 0;
            double vlera = 0;

            printArtikujt = new string[numri];
            printCmimet = new string[numri];
            printSasite = new string[numri];
            printVlerat = new string[numri];

            foreach (DataRow dr in dsArtikujt.Tables[0].Rows)
            {
                printArtikujt[j] = Convert.ToString(dr["EMRI"]);
                printCmimet[j] = Convert.ToString(dr["CMIMI"]);
                printSasite[j] = Convert.ToString(dr["SASIA"]);

                vlera = Convert.ToInt32(dr["SASIA"]) * Convert.ToDouble(dr["CMIMI"]);
                totali = totali + vlera;
                printVlerat[j] = vlera.ToString();

                j = j + 1;

            }

            printTotali = totali.ToString();
           
            
        }

        private void btnTransfero_Click(object sender, EventArgs e)
        {
            
            if (this.gridaTotali.RowCount == 0)
            {
                return;
            }

            frmTransfero frm = new frmTransfero();
            frm.idTavolina = this.idTavolina;
            frm.dsTavolinat = this.dsTavolinat;
            frm.emriTavolina = this.nrTavolina;
            frm.ShowDialog();

            this.tranferimi = frm.transferimi;
            this.idTavNew = frm.idTavNew;
            this.dsTavolinat = frm.dsTavolinat;

            this.Close();

        }

        private void KtheInformacionPerBarin()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("LexoInformacioneRestoranti");

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.printBari = Convert.ToString(ds.Tables[0].Rows[0]["EMRI"]);

            }
            else
            {
                this.printBari = "";
            }

        }

        private DataSet KrijoDataSet()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("ID_FATURA", typeof(int));
            ds.Tables[0].Columns.Add("NR_FATURE", typeof(string));
            ds.Tables[0].Columns.Add("ID_RECETA", typeof(int));
            ds.Tables[0].Columns.Add("EMRI", typeof(string));
            ds.Tables[0].Columns.Add("CMIMI", typeof(double));
            ds.Tables[0].Columns.Add("SASIA", typeof(int));
            ds.Tables[0].Columns.Add("VLERA", typeof(double));

            ds.AcceptChanges();

            return ds;
        }

        private void btnMbyll_Click(object sender, EventArgs e)
        {

            this.veprimi = 1;

            InputController data = new InputController();
            int b = data.KerkesaUpdate("MbyllTavolinen", idTavolina);


           
            int idTav = 0;
            int nrDr = 0;

            foreach (DataRow drNew in this.dsTavolinat.Tables[1].Rows)
            {
                 idTav = Convert.ToInt32(drNew[0]);

                 if (idTav == this.idTavolina)
                 {
                     nrDr = nrDr + 1;
                 }
            }

            DataRow[] drArray = new DataRow[nrDr];
            int j = 0;
            foreach (DataRow drNew in this.dsTavolinat.Tables[1].Rows)
            {
                idTav = Convert.ToInt32(drNew[0]);


                if (idTav == this.idTavolina)
                {
                     drArray[j] = drNew;
                     j = j + 1;
                }
             }


             for (int k = 0; k < nrDr; k++)
             {
                 this.dsTavolinat.Tables[1].Rows.Remove(drArray[k]);
             }

             this.dsTavolinat.Tables[1].AcceptChanges();

             foreach (DataRow dr in this.dsTavolinat.Tables[0].Rows)
             {
                 idTav = Convert.ToInt32(dr[0]);

                 if (idTav == this.idTavolina)
                 {
                    dr[1] = "L";
                 }
             }

             this.dsTavolinat.Tables[0].AcceptChanges();


             this.Close();
        }


        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string drawString = "";
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float posX = 90;
            float posY = 0;
            PointF drawPoint = new PointF();

            string dataSot = System.DateTime.Today.ToString("dd/MM/yyyy");
            string oraTani = System.DateTime.Now.ToString("HH:mm");

            bool gjendetImazhi = true;
            string shumezimi = "×";

            switch (printModeli)
            {
                case 1:



                    if (gjendetImazhi)
                    {

                        drawFont = new Font("Nina", 16);
                        drawString = this.printBari;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        posX = 10;
                        posY = 40;


                    }
                    else
                    {
                        posX = 70;
                        posY = 0;
                    }

                    drawFont = new Font("Arial", 10);

                    drawString = "Tavolina: " + this.nrTavolina;
                    //PointF drawPoint = new PointF(70.0F, 10.0F)
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawPoint = new PointF(10.0F, 20.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 15;
                    }
                    else
                    {
                        posX = 10;
                        posY = 55;
                    }

                    drawFont = new Font("Arial", 8);

                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Data: " + dataSot + " , Ora: " + oraTani;
                    //drawPoint = new PointF(10.0F, 30.0F);



                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 30;

                    }
                    else
                    {
                        posX = 10;
                        posY = 70;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 43;

                    }
                    else
                    {
                        posX = 10;
                        posY = 73;
                    }

                    //drawString = "Tavolina: " + this.printTavolina + " ,       Kamarieri: " + this.printUser;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);



                    drawString = "----------------------------------------------------------------";
                    //drawPoint = new PointF(10.0F, 40.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 58;

                    }
                    else
                    {
                        posX = 10;
                        posY = 88;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Emertimi";
                    //drawPoint = new PointF(10.0F, 50.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 73;

                    }
                    else
                    {
                        posX = 10;
                        posY = 103;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Cmimi";
                    //drawPoint = new PointF(10.0F, 50.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 110;
                        posY = 73;

                    }
                    else
                    {
                        posX = 110;
                        posY = 103;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Sasia";
                    //drawPoint = new PointF(10.0F, 50.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 155;
                        posY = 73;

                    }
                    else
                    {
                        posX = 155;
                        posY = 103;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Vlera";
                    //drawPoint = new PointF(10.0F, 50.0F);


                    if (gjendetImazhi == false)
                    {
                        posX = 195;
                        posY = 73;

                    }
                    else
                    {
                        posX = 195;
                        posY = 103;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "----------------------------------------------------------------";
                    drawPoint = new PointF(10.0F, 60.0F);
                    posX = 10;

                    if (gjendetImazhi == false)
                    {
                        posY = 83;
                    }
                    else
                    {
                        posY = 113;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    int nr = this.printArtikujt.Length;

                    for (int i = 0; i < nr; i++)
                    {
                        //posX = 10;
                        //posY = posY + 15;

                        //drawString = "--------------------------------------------------";
                        ////drawPoint = new PointF(10.0F,  70.0F);
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        drawString = this.FormayoEmrinRecetaPerPrintim(this.printArtikujt[i]);
                        posX = 10;
                        posY = posY + 20;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        drawString = this.printCmimet[i];
                        posX = 118;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printSasite[i];
                        posX = 163;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printVlerat[i];
                        posX = 200;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    }

                    posX = 10;
                    posY = posY + 15;

                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 15;

                    drawString = "Vlera totale :";


                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 200;

                    drawString = this.printTotali;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 15;


                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
                    posX = 10;
                    posY = posY + 3;

                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawFont = new Font("Pristina", 12);
                    posX = 80;
                    posY = posY + 25;

                    drawString = "Faleminderit !";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    drawFont = new Font("Verdana", 7);
                    posX = 60;
                    posY = posY + 30;

                    drawString = "www.visioninfosolution.com";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    break;

                case 2:

                    //drawPoint = new PointF(10.0F, 20.0F);
                    posX = 90;
                    posY = 0;

                    drawFont = new Font("Nina", 16);
                    drawString = this.printBari;

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawString = "Data: " + dataSot + " , Ora: " + oraTani;
                    ////drawPoint = new PointF(10.0F, 30.0F);

                    posX = 10;
                    posY = 40;

                    drawFont = new Font("Nina", 9);

                    drawString = "TAVOLINA :  " + this.nrTavolina;
                    ///PointF drawPoint = new PointF(70.0F, 10.0F)
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawPoint = new PointF(10.0F, 20.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 15;
                    }
                    else
                    {
                        posX = 10;
                        posY = 52;
                    }


                    drawFont = new Font("Nina", 8);
                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawFont = new Font("Nina", 8);
                    drawString = "DATA:  " + dataSot + "  ,   ORA:  " + oraTani;
                    //drawPoint = new PointF(10.0F, 30.0F);



                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 30;

                    }
                    else
                    {
                        posX = 10;
                        posY = 70;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    //if (gjendetImazhi == false)
                    //{
                    //    posX = 10;
                    //    posY = 43;

                    //}
                    //else
                    //{
                    //    posX = 10;
                    //    posY = 77;
                    //}

                    //drawString = "Tavolina: " + this.printTavolina + " ,       Kamarieri: " + this.printUser;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    drawFont = new Font("Nina", 8);
                    drawString = "----------------------------------------------------------------";
                    //drawPoint = new PointF(10.0F, 40.0F);

                    if (gjendetImazhi == false)
                    {
                        posX = 10;
                        posY = 58;

                    }
                    else
                    {
                        posX = 10;
                        posY = 88;
                    }

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);



                    int nr2 = this.printArtikujt.Length;

                    //posY = posY + 15; 

                    for (int i = 0; i < nr2; i++)
                    {
                        //posX = 10;
                        //posY = posY + 15;

                        //drawString = "--------------------------------------------------";
                        ////drawPoint = new PointF(10.0F,  70.0F);
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawFont = new Font("Nina", 8);

                        drawString = this.FormayoEmrinRecetaPerPrintim(this.printArtikujt[i].ToUpper());
                        posX = 10;
                        posY = posY + 20;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        drawString = this.printSasite[i] + " " + shumezimi + " " + this.printCmimet[i];
                        posX = 150;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        //drawString = shumezimi; /// +" " + shumezimi + " " + this.printCmimet[i];
                        //posX = 160;
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        //drawString = this.printSasite[i];
                        //posX = 170;
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printVlerat[i];
                        posX = 220;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    }

                    posX = 10;
                    posY = posY + 15;

                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 20;

                    drawString = "TOTALI :";
                    drawFont = new Font("Agency FB", 14);

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 210;

                    drawString = this.printTotali;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 15;


                    //drawString = "----------------------------------------------------------------";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
                    //posX = 10;
                    //posY = posY + 3;

                    //drawString = "----------------------------------------------------------------";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawFont = new Font("Pristina", 14);
                    posX = 80;
                    posY = posY + 30;

                    drawString = "Faleminderit !";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    drawFont = new Font("Verdana", 7);
                    posX = 60;
                    posY = posY + 30;

                    drawString = "www.visioninfosolution.com";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    break;


                case 3:
                    //drawString = "Fatura nr: " + this.printNrFatura;
                    ////PointF drawPoint = new PointF(70.0F, 10.0F);


                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);



                    //drawPoint = new PointF(10.0F, 20.0F);
                    posX = 100;
                    posY = 0;

                    drawFont = new Font("Nina", 16);
                    drawString = this.printBari;

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawString = "Data: " + dataSot + " , Ora: " + oraTani;
                    ////drawPoint = new PointF(10.0F, 30.0F);

                    //posX = 10;
                    //posY = 30;

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //posX = 10;
                    //posY = 43;
                    //drawString = "Tavolina: " + this.printTavolina + " ,       Kamarieri: " + this.printUser;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);



                    //drawString = "----------------------------------------------------------------";
                    //drawPoint = new PointF(10.0F, 40.0F);

                    //posX = 10;
                    //posY = 58;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawFont = new Font("Nina", 8);
                    //drawString = "Emertimi";
                    ////drawPoint = new PointF(10.0F, 50.0F);
                    //posX = 10;
                    //posY = posY + 50;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawString = "Cmimi";
                    ////drawPoint = new PointF(10.0F, 50.0F);
                    //posX = 130;
                    ////posY = 73;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawString = "Sasia";
                    ////drawPoint = new PointF(10.0F, 50.0F);
                    //posX = 175;
                    ////posY = 73;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawString = "Vlera";
                    ////drawPoint = new PointF(10.0F, 50.0F);
                    //posX = 215;
                    ////posY = 73;
                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
                    //posY = posY + 30; 

                    posX = 10;
                    posY = 35;

                    drawFont = new Font("Nina", 9);
                    drawString = "Tavolina: " + this.nrTavolina;
                    //PointF drawPoint = new PointF(70.0F, 10.0F);


                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawFont = new Font("Nina", 8);
                    
                    drawString = "------------------------------------------------------------------";
                    drawPoint = new PointF(10.0F, 60.0F);
                    posX = 10;
                    posY = posY + 15;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    int nr3 = this.printArtikujt.Length;



                    for (int i = 0; i < nr3; i++)
                    {
                        //posX = 10;
                        //posY = posY + 15;

                        //drawString = "--------------------------------------------------";
                        ////drawPoint = new PointF(10.0F,  70.0F);
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawFont = new Font("Nina", 8);

                        drawString = this.printArtikujt[i].ToUpper();
                        posX = 50;
                        posY = posY + 20;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        //drawString = this.printCmimet[i];
                        //posX = 10;
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printSasite[i];
                        posX = 10;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printVlerat[i];
                        posX = 220;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    }

                    posX = 10;
                    posY = posY + 20;

                    drawString = "------------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 20;

                    drawString = "TOTALI :";
                    drawFont = new Font("Agency FB", 14);

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 210;

                    drawString = this.printTotali;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 15;


                    //drawString = "----------------------------------------------------------------";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
                    //posX = 10;
                    //posY = posY + 3;

                    //drawString = "----------------------------------------------------------------";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawFont = new Font("Pristina", 14);
                    posX = 80;
                    posY = posY + 30;

                    drawString = "Faleminderit !";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    drawFont = new Font("Verdana", 7);
                    posX = 60;
                    posY = posY + 30;

                    drawString = "www.visioninfosolution.com";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    break;

                default:
                    break;
            }

        }

        private void btnPrinto_Click(object sender, EventArgs e)
        {
            if (this.gridaTotali.RowCount == 0)
            {
                return;
            }

            printDoc.Print();

            string strBanaku = "";
            int nrBanaku = 0;




            foreach (DataRow dr in this.dsPrinterTavolina.Tables[0].Rows)
            {
                strBanaku = Convert.ToString(dr[0]);
                nrBanaku = Convert.ToInt32(dr[1]);


                printDoc.PrinterSettings.PrinterName = strBanaku;
                for (int i = 0; i < nrBanaku; i++)
                {
                    printDoc.Print();
                }

            }
        }

        private DataSet KrijoDataSetZgjidh()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();

            ds.Tables[0].Columns.Add("PRINTERI", typeof(string));
            ds.Tables[0].Columns.Add("NUMRI", typeof(Int32));

            ds.AcceptChanges();

            return ds;
        }

        private DataSet KtheDsArtikujt(DataSet ds)
        {
            DataSet dsArtikujt = new DataSet();
            dsArtikujt.Tables.Add();

            dsArtikujt.Tables[0].Columns.Add("ID_RECETA", typeof(int));
            dsArtikujt.Tables[0].Columns.Add("EMRI", typeof(string));
            dsArtikujt.Tables[0].Columns.Add("CMIMI", typeof(double));
            dsArtikujt.Tables[0].Columns.Add("SASIA", typeof(int));
            dsArtikujt.Tables[0].Columns.Add("VLERA", typeof(double));

            ds.AcceptChanges();

            

            bool gjendet = false;
            int idOld = 0;
            int idKorenti = 0;
            int idArtikulli = 0;
            int idCelesi = 0;
            int sasia = 0;
            double vlera = 0;

            DataRow drNew = dsArtikujt.Tables[0].NewRow();
            drNew[0] = ds.Tables[0].Rows[0][2];
            drNew[1] = ds.Tables[0].Rows[0][3];
            drNew[2] = ds.Tables[0].Rows[0][4];
            drNew[3] = ds.Tables[0].Rows[0][5];
            drNew[4] = ds.Tables[0].Rows[0][6];

            idOld = Convert.ToInt32(drNew[0]);

            int k = 0;

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (k != 0)
                {
                    idKorenti = Convert.ToInt32(dr[2]);

                    if (idOld == idKorenti)
                    {
                        drNew[3] = Convert.ToInt32(drNew[3]) + Convert.ToInt32(dr[5]);
                        drNew[4] = Convert.ToDouble(drNew[4]) + Convert.ToDouble(dr[6]);
                    }
                    else
                    {
                        dsArtikujt.Tables[0].Rows.Add(drNew);
                        drNew = dsArtikujt.Tables[0].NewRow();

                        drNew[0] = dr[2];
                        drNew[1] = dr[3];
                        drNew[2] = dr[4];
                        drNew[3] = dr[5];
                        drNew[4] = dr[6];
                    }

                    idOld = idKorenti;
                }

                k = k + 1;
            }

            dsArtikujt.Tables[0].Rows.Add(drNew);
            dsArtikujt.Tables[0].AcceptChanges();

            int rreshtat = dsArtikujt.Tables[0].Rows.Count;
            
            return dsArtikujt;

        }

        private void printProva_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
           

           

            ///printProva.

        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            this.tabTavolina.SelectedIndex = 0;

        }

        private void btnTotali_Click(object sender, EventArgs e)
        {
            this.tabTavolina.SelectedIndex = 1;
        }

        private void LexoXmlPrinterat()
        {
            string str = "";
            string korenti = "";
            string fileName = Global.stringXml + "\\Printerat.xml";

            DataRow dr1 = null;
            DataRow dr2 = null;

            XmlTextReader tr = new XmlTextReader(fileName);
            try
            {
                while (tr.Read())
                {

                    switch (tr.NodeType)
                    {
                        case XmlNodeType.Element:


                            str = tr.Name;

                            if (str == "Banaku")
                            {
                                dr1 = this.dsPrinterBanaku.Tables[0].NewRow();
                                korenti = "Banaku";

                            }
                            else if (str == "Tavolina")
                            {
                                dr2 = this.dsPrinterTavolina.Tables[0].NewRow();
                                korenti = "Tavolina";
                            }
                            else if (str == "Emri")
                            {
                                if (korenti == "Banaku")
                                {
                                    dr1["PRINTERI"] = tr.ReadElementString().ToString();
                                }
                                else
                                {
                                    dr2["PRINTERI"] = tr.ReadElementString().ToString();
                                }

                            }
                            else if (str == "Numri")
                            {
                                if (korenti == "Banaku")
                                {
                                    dr1["NUMRI"] = Convert.ToInt32(tr.ReadElementString().ToString());
                                    this.dsPrinterBanaku.Tables[0].Rows.Add(dr1);
                                }
                                else
                                {
                                    dr2["NUMRI"] = Convert.ToInt32(tr.ReadElementString().ToString());
                                    this.dsPrinterTavolina.Tables[0].Rows.Add(dr2);
                                }
                            }
                            else
                            {
                            }

                            break;

                        //case XmlNodeType.Text:

                        //    str = tr.Value;
                        //    break;

                        default:
                            break;


                    }

                }

                this.dsPrinterBanaku.Tables[0].AcceptChanges();
                this.dsPrinterTavolina.Tables[0].AcceptChanges();



            }


            catch
            {

            }
            finally
            {
                tr.Close();
            }
        }

        private string FormayoEmrinRecetaPerPrintim(string emri)
        {
            string kthe = "";
            int gjatesia = 0;

            gjatesia = emri.Length;

            if (gjatesia <= 20)
            {
                return emri;
            }

            kthe = emri.Substring(0, 20);

            return kthe;
        }


        

       
        
    }
}