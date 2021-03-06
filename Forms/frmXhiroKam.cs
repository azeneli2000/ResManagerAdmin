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
    public partial class frmXhiroKam : Form
    {
        public int idKam = 0;
        public string kamarieri = "";
        public DateTime dtFillimi;
        public DateTime dtMbarimi;
        public decimal xhiro;
        public bool mbyllur = false;

        private string[] printArtikujt = null;
        private string[] printCmimet = null;
        private string[] printSasite = null;
        private string[] printVlerat = null;
        private string printTotali = "";
        private string printBari = "";
        private string printTavolina = "";
        private string printUser = "";

        private int printModeli = 1;

        public frmXhiroKam()
        {
            InitializeComponent();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            this.tabTavolina.SelectedIndex = 0;
        }

        private void btnTotali_Click(object sender, EventArgs e)
        {
            this.tabTavolina.SelectedIndex = 1;
        }

        private void frmXhiroKam_Load(object sender, EventArgs e)
        {
            this.MbushGridenFaturat();
            this.MbushGridenTotali();

            this.printUser = this.kamarieri;

            string strTitle = "Kamarieri:  " +  this.kamarieri.ToUpper() + "           " + this.dtFillimi.ToString("dd.MM.yyyy  HH:mm") + "   ---   ";

            if (this.mbyllur == true)
            {
                strTitle = strTitle + this.dtMbarimi.ToString("dd.MM.yyyy  HH:mm");
            }

            this.paneli.TitleText = strTitle;
        }

        private void btnMbyll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MbushGridenTotali()
        {

            InputController data = new InputController();
            DataSet ds = null;
            if (mbyllur == false)
            {
                ds = data.KerkesaRead("LexoXhironPerKamarierin", this.idKam);
            }
            else
            {
                ds = data.KerkesaRead("LexoTurninPerKamarierin", this.idKam, this.dtFillimi, this.dtMbarimi);
            }

            DataSet dsFaturat = this.KrijoDataSet();

            double xhiro = 0;

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

                xhiro = xhiro + Convert.ToDouble(dr["VLERA"]) * Convert.ToInt32(dr["SASIA"]);

                dsFaturat.Tables[0].Rows.Add(drNew);

            }

            dsFaturat.Tables[0].AcceptChanges();

            this.printTotali = xhiro.ToString("0.00");

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

            if (ds.Tables[0].Rows.Count > 0)
            {
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
            }


            return dsArtikujt;

        }


        private void MbushGridenFaturat()
        {

            InputController data = new InputController();
            DataSet ds = null;
            if (mbyllur == false)
            {
                ds = data.KerkesaRead("LexoXhironPerKamarierin", this.idKam);
            }
            else
            {
                ds = data.KerkesaRead("LexoTurninPerKamarierin", this.idKam, this.dtFillimi, this.dtMbarimi);
            }

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

                dsFaturat.Tables[0].Rows.Add(drNew);
            }

            dsFaturat.Tables[0].AcceptChanges();

            return dsFaturat;

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

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string drawString = "";
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float posX = 70;
            float posY = 0;
            PointF drawPoint = new PointF();

            string dataSot = System.DateTime.Today.ToString("dd/MM/yyyy");
            string oraTani = System.DateTime.Now.ToString("HH:mm:ss");


            string strFillimi = this.dtFillimi.ToString("dd.MM.yyyy  HH:mm");
            string strMbarimi = "     --------     ";

            if (this.mbyllur == true)
            {
                strMbarimi = this.dtMbarimi.ToString("dd.MM.yyyy  HH:mm");
            }
          


            switch (printModeli)
            {
                case 1:

                    posX = 10;
                    posY = 5;

                    drawFont = new Font("Nina", 11);

                    drawString = "Kamarieri :  " + this.printUser;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawPoint = new PointF(10.0F, 20.0F);
                    drawFont = new Font("Arial", 9);

                    posX = 10;
                    posY = 25;


                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Filloi ne:       " + strFillimi;
                    //drawPoint = new PointF(10.0F, 30.0F);

                    posX = 10;
                    posY = 42;

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Mbaroi ne:    " + strMbarimi;
                    //drawPoint = new PointF(10.0F, 30.0F);

                    posX = 10;
                    posY = 62;

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);






                    drawString = "----------------------------------------------------------------";
                    //drawPoint = new PointF(10.0F, 40.0F);
                    posX = 10;
                    posY = 78;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Emertimi";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 10;
                    posY = 93;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Cmimi";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 110;
                    posY = 93;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Sasia";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 165;
                    posY = 93;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Vlera";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 215;
                    posY = 93;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "----------------------------------------------------------------";
                    drawPoint = new PointF(10.0F, 60.0F);
                    posX = 10;
                    posY = 103;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    int nr = this.printArtikujt.Length;

                    for (int i = 0; i < nr; i++)
                    {
                        //posX = 10;
                        //posY = posY + 15;

                        //drawString = "--------------------------------------------------";
                        ////drawPoint = new PointF(10.0F,  70.0F);
                        //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        drawString = this.printArtikujt[i];
                        posX = 10;
                        posY = posY + 20;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        drawString = this.printCmimet[i];
                        posX = 118;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printSasite[i];
                        posX = 173;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printVlerat[i];
                        posX = 220;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    }

                    posX = 10;
                    posY = posY + 15;

                    drawString = "----------------------------------------------------------------";

                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 10;
                    posY = posY + 15;

                    drawString = "Totali :";


                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    posX = 220;

                    drawString = this.printTotali;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //posX = 10;
                    //posY = posY + 15;


                    //drawString = "----------------------------------------------------------------";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
                    //posX = 10;
                    //posY = posY + 3;

                    //drawString = "----------------------------------------------------------------";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    //drawFont = new Font("Pristina", 12);
                    //posX = 80;
                    //posY = posY + 25;

                    /////drawString = "Faleminderit !";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    //drawFont = new Font("Verdana", 7);
                    //posX = 60;
                    //posY = posY + 30;

                    /////drawString = "www.visioninfosolution.com";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    break;

                case 2:

                    //drawString = "Fatura nr: " + this.printNrFatura;
                    ////PointF drawPoint = new PointF(70.0F, 10.0F);


                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);



                    //drawPoint = new PointF(10.0F, 20.0F);
                    posX = 90;
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

                    drawFont = new Font("Nina", 8);
                    drawString = "Emertimi";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 10;
                    posY = posY + 50;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Cmimi";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 130;
                    //posY = 73;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Sasia";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 175;
                    //posY = 73;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "Vlera";
                    //drawPoint = new PointF(10.0F, 50.0F);
                    posX = 215;
                    //posY = 73;
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    drawString = "------------------------------------------------------------------";
                    drawPoint = new PointF(10.0F, 60.0F);
                    posX = 10;
                    posY = posY + 15;
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

                        drawString = this.printArtikujt[i].ToUpper();
                        posX = 10;
                        posY = posY + 20;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                        drawString = this.printCmimet[i];
                        posX = 138;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printSasite[i];
                        posX = 183;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                        drawString = this.printVlerat[i];
                        posX = 220;
                        e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    }

                    posX = 10;
                    posY = posY + 15;

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

                    //drawFont = new Font("Pristina", 14);
                    //posX = 80;
                    //posY = posY + 30;

                    //////drawString = "Faleminderit !";

                    /////e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    //drawFont = new Font("Verdana", 7);
                    //posX = 60;
                    //posY = posY + 30;

                    //////drawString = "www.visioninfosolution.com";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

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

                    drawFont = new Font("Nina", 8);
                    drawString = "------------------------------------------------------------------";
                    drawPoint = new PointF(10.0F, 60.0F);
                    posX = 10;
                    posY = posY + 40;
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

                    //drawFont = new Font("Pristina", 14);
                    //posX = 80;
                    //posY = posY + 30;

                    /////drawString = "Faleminderit !";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


                    //drawFont = new Font("Verdana", 7);
                    //posX = 60;
                    //posY = posY + 30;

                    //////drawString = "www.visioninfosolution.com";

                    //e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

                    break;

                default:
                    break;
            }
        }

        private void btnPrinto_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridaTotali.RowCount == 0)
                {
                    return;
                }

                int numri = this.gridaTotali.RowCount;

                this.printTotali = Convert.ToDouble(this.gridaTotali.GetRow(numri - 1).Cells["colVlera"].Text).ToString("0.00");

                printDoc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printXhiro_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string drawString = "";
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float posX = 70;
            float posY = 0;
            PointF drawPoint = new PointF();

            string dataSot = System.DateTime.Today.ToString("dd/MM/yyyy");
            string oraTani = System.DateTime.Now.ToString("HH:mm:ss");


            string strFillimi = this.dtFillimi.ToString("dd.MM.yyyy  HH:mm");
            string strMbarimi = "     --------     ";

            if (this.mbyllur == true)
            {
                strMbarimi = this.dtMbarimi.ToString("dd.MM.yyyy  HH:mm");
            }



            posX = 10;
            posY = 5;

            drawFont = new Font("Nina", 11);

            drawString = "Kamarieri :  " + this.printUser;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            //drawPoint = new PointF(10.0F, 20.0F);
            drawFont = new Font("Arial", 9);

            posX = 10;
            posY = 25;


            drawString = "----------------------------------------------------------------";

            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            drawString = "Filloi ne:       " + strFillimi;
            //drawPoint = new PointF(10.0F, 30.0F);

            posX = 10;
            posY = 42;

            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);

            drawString = "Mbaroi ne:    " + strMbarimi;
            //drawPoint = new PointF(10.0F, 30.0F);

            posX = 10;
            posY = 62;

            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);






            drawString = "----------------------------------------------------------------";
            //drawPoint = new PointF(10.0F, 40.0F);
            posX = 10;
            posY = 78;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);


            drawFont = new Font("Nina", 11);

            drawString = "Xhiro :   " + this.printTotali;
            //drawPoint = new PointF(10.0F, 40.0F);
            posX = 10;
            posY = 98;
            e.Graphics.DrawString(drawString, drawFont, drawBrush, posX, posY);
          

        }

        private void btnPrintoXhiro_Click(object sender, EventArgs e)
        {
            if (this.gridaTotali.RowCount == 0)
            {
                return;
            }

            printXhiro.Print();
        }


    }
}