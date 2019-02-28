using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;
using ZedGraph;
using System.Drawing.Drawing2D;
using ResManagerLibrary;

namespace ResManagerAdmin.Forms
{
    public partial class frmBilancMujor : System.Windows.Forms.Form, IPrintable
    {
        private DataSet dsBilanci;
        private bool readyToPrint = true;
        private Janus.Windows.GridEX.GridEXPrintDocument doc;

        #region Load Form
        public frmBilancMujor()
        {
            InitializeComponent();
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Doc = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.Doc.GridEX = grida;
            Doc.DefaultPageSettings.Landscape = true;
            Doc.PageHeaderFormatStyle.Font = new Font(new FontFamily("Tahoma"), 11, FontStyle.Bold);
            Doc.PageHeaderFormatStyle.ForeColor = Color.Navy;
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine 
                + "Bilanci për vitin " + dtViti.Value.Year.ToString();

            this.LexoInformacione();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Size s = this.Size;
        }

        private void MbushGridenPerVitin(int viti)
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("ShfaqStatistikaPerVitin", viti);

            if (ds == null)
            {
                // mesazhGabimi

                this.dsBilanci = this.KrijoDataSetBilanci();
            }
            else
            {
                this.grida.DataSource = ds.Tables[0];
                this.dsBilanci = ds;

                this.NdertoZedGrafik();
            }
        }

        private void dtViti_ValueChanged(object sender, EventArgs e)
        {
            int viti = Convert.ToInt32(this.dtViti.Value.Year);
            this.MbushGridenPerVitin(viti);
            Doc.PageHeaderLeft = MDIAdminTjeter.emriRes + Environment.NewLine
                + "Bilanci për vitin " + dtViti.Value.Year.ToString();

        }

        private void NdertoZedGrafik()
        {
            try
            {
                this.ZedBilanci.Refresh();
                GraphPane BilancPane = new GraphPane();
                BilancPane.Title = "Bilanci, te ardhurat, shpenzimet dhe blerjet per vitin e zgjedhur";
                BilancPane.XAxis.Title = "Muajt";
                BilancPane.XAxis.TitleFontSpec.FontColor = Color.Chocolate;
                BilancPane.XAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
                BilancPane.XAxis.TitleFontSpec.Size = 12;
                BilancPane.YAxis.Title = "Vlera";
                BilancPane.YAxis.TitleFontSpec.FontColor = Color.Chocolate;
                BilancPane.YAxis.TitleFontSpec.Family = "Microsoft Sans Serif";
                BilancPane.YAxis.TitleFontSpec.Size = 12;
                double[] bilanci = new double[12];
                double[] xhiro = new double[12];
                double[] shpenzime = new double[12];
                double[] shpenzimeMujore = new double[12];
                double[] blerje = new double[12];
                double[] maximum = new double[12];
                double[] minimum = new double[12];
                for (int i = 0; i < 12; i++)
                {
                    bilanci[i] = Convert.ToDouble(this.dsBilanci.Tables[0].Rows[i]["BILANCI"]);
                    maximum[i] = bilanci[i];
                    minimum[i] = bilanci[i];

                    xhiro[i] = Convert.ToDouble(this.dsBilanci.Tables[0].Rows[i]["XHIRO"]);
                    if (maximum[i] < xhiro[i])
                        maximum[i] = xhiro[i];
                    if (minimum[i] > xhiro[i])
                        minimum[i] = xhiro[i];

                    shpenzime[i] = Convert.ToDouble(this.dsBilanci.Tables[0].Rows[i]["SHPENZIMI_DITOR"]);
                    if (maximum[i] < shpenzime[i])
                        maximum[i] = shpenzime[i];
                    if (minimum[i] > shpenzime[i])
                        minimum[i] = shpenzime[i];

                    shpenzimeMujore[i] = Convert.ToDouble(this.dsBilanci.Tables[0].Rows[i]["SHPENZIMI_MUJOR"]);
                    if (maximum[i] < shpenzimeMujore[i])
                        maximum[i] = shpenzimeMujore[i];
                    if (minimum[i] > shpenzimeMujore[i])
                        minimum[i] = shpenzimeMujore[i];

                    blerje[i] = Convert.ToDouble(this.dsBilanci.Tables[0].Rows[i]["BLERJE"]);
                    if (maximum[i] < blerje[i])
                        maximum[i] = blerje[i];
                    if (minimum[i] > blerje[i])
                        minimum[i] = blerje[i];
                }
                string[] str = { "Janar", "Shkurt", "Mars", "Prill", "Maj", "Qershor", "Korrik", "Gusht", 
                                   "Shtator", "Tetor", "Nentor", "Dhjetor"};

                BarItem TeArdhuraVije = BilancPane.AddBar("Te ardhurat", null, xhiro, Color.AliceBlue);
                TeArdhuraVije.Bar.Fill = new Fill(Color.White, System.Drawing.SystemColors.Desktop, 45.0f);
                TeArdhuraVije.Bar.Border.IsVisible = true;

                BarItem ShpenzimeMujoreVije = BilancPane.AddBar("Shpenzimet mujore", null, shpenzimeMujore, Color.AliceBlue);
                ShpenzimeMujoreVije.Bar.Fill = new Fill(Color.White, Color.Salmon, 45.0f);
                ShpenzimeMujoreVije.Bar.Border.IsVisible = true;

                BarItem ShpenzimeVije = BilancPane.AddBar("Shpenzimet", null, shpenzime, Color.AliceBlue);
                ShpenzimeVije.Bar.Fill = new Fill(Color.White, Color.Yellow, 45.0f);
                ShpenzimeVije.Bar.Border.IsVisible = true;

                BarItem BlerjeMaterialiVije = BilancPane.AddBar("Blerje Materialesh", null, blerje, Color.AliceBlue);
                BlerjeMaterialiVije.Bar.Fill = new Fill(Color.White, Color.Violet, 45.0f);
                BlerjeMaterialiVije.Bar.Border.IsVisible = true;

                BarItem BilanciVije = BilancPane.AddBar("Bilanci", null, bilanci, Color.AliceBlue);
                BilanciVije.Bar.Fill = new Fill(Color.White, Color.DarkSeaGreen, 45.0f);
                BilanciVije.Bar.Border.IsVisible = true;

                // Draw the X tics between the labels instead of at the labels
                BilancPane.XAxis.IsTicsBetweenLabels = false;

                // Set the XAxis labels
                BilancPane.XAxis.TextLabels = str;
                BilancPane.XAxis.StepAuto = false;

                // Set the XAxis to Text type
                BilancPane.XAxis.Type = AxisType.Text;

                // Fill the axis background with a color gradient
                BilancPane.AxisFill = new Fill(Color.White, Color.LightSteelBlue, 45.0f);
                BilancPane.PaneFill = new Fill(Color.White, Color.Bisque, 45.0f);
                // enable the legend
                BilancPane.Legend.IsVisible = true;
                BilancPane.PaneRect = new RectangleF(0, 0, 800, 400);
                // percakohet fonti i titullit
                BilancPane.FontSpec = new FontSpec("Microsoft Sans Serif", 12, Color.Chocolate, true, false, false);
                for (int i = 0; i < 12; i++)
                {
                    //Convert.ToInt32(maximum[i]+ 10)
                    BoxItem box = new BoxItem(new RectangleF(0.5f + i, Convert.ToInt32(maximum[i]), 1, Convert.ToInt32(maximum[i])), Color.MidnightBlue, Color.White, Color.Empty);
                    box.Location.CoordinateFrame = CoordType.AxisXYScale;
                    box.Location.AlignH = AlignH.Left;
                    box.Location.AlignV = AlignV.Top;
                    box.ZOrder = ZOrder.E_BehindAxis;
                    BilancPane.GraphItemList.Add(box);
                    if (minimum[i] < 0)
                    {
                        BoxItem box2 = new BoxItem(new RectangleF(0.5f + i, 0, 1, Convert.ToInt32(minimum[i])), Color.MidnightBlue, Color.White, Color.Empty);
                        box2.Location.CoordinateFrame = CoordType.AxisXYScale;
                        box2.Location.AlignH = AlignH.Left;
                        box2.Location.AlignV = AlignV.Top;
                        box2.ZOrder = ZOrder.E_BehindAxis;
                        BilancPane.GraphItemList.Add(box2);
                    }

                }

                ZedBilanci.MasterPane.PaneList.Clear();
                ZedBilanci.GraphPane = BilancPane;
                ZedBilanci.GraphPane.MarginAll = 10;
                ZedBilanci.Anchor = AnchorStyles.Left | AnchorStyles.Top
                    | AnchorStyles.Right | AnchorStyles.Bottom;
                ZedBilanci.Width = 800;
                ZedBilanci.Height = 400;
                //ZedBilanci.Parent = this.groupBox1;
                ZedBilanci.Location = new Point(20, 50);
                this.ZedBilanci.AxisChange();
                this.ZedBilanci.Refresh();

            }
            catch (Exception ex)
            {
                return;
            }

        }

        private DataSet KrijoDataSetBilanci()
        {
            DataSet dsViti = new DataSet();
            dsViti.Tables.Add();

            dsViti.Tables[0].Columns.Add("MUAJI", typeof(Int32));
            dsViti.Tables[0].Columns.Add("MUAJISTR", typeof(string));
            dsViti.Tables[0].Columns.Add("XHIRO", typeof(float));
            dsViti.Tables[0].Columns.Add("BLERJE", typeof(float));
            dsViti.Tables[0].Columns.Add("SHPENZIMI_MUJOR", typeof(float));
            dsViti.Tables[0].Columns.Add("SHPENZIMI_DITOR", typeof(float));
            dsViti.Tables[0].Columns.Add("BILANCI", typeof(float));

            for (int i = 0; i < 12; i++)
            {
                DataRow drNew = dsViti.Tables[0].NewRow();

                drNew[0] = i + 1;
                drNew[1] = this.KtheMuajiStr(i + 1);
                drNew[2] = 0;
                drNew[3] = 0;
                drNew[4] = 0;
                drNew[5] = 0;

                dsViti.Tables[0].Rows.Add(drNew);
            }

            dsViti.Tables[0].AcceptChanges();

            dsViti.AcceptChanges();

            return dsViti;

        }

        private string KtheMuajiStr(int muaji)
        {
            string strMuaji = "";

            switch (muaji)
            {
                case 1:
                    strMuaji = "Janar";
                    break;

                case 2:
                    strMuaji = "Shkurt";
                    break;

                case 3:
                    strMuaji = "Mars";
                    break;

                case 4:
                    strMuaji = "Prill";
                    break;

                case 5:
                    strMuaji = "Maj";
                    break;

                case 6:
                    strMuaji = "Qershor";
                    break;

                case 7:
                    strMuaji = "Korrik";
                    break;

                case 8:
                    strMuaji = "Gusht";
                    break;

                case 9:
                    strMuaji = "Shtator";
                    break;

                case 10:
                    strMuaji = "Tetor";
                    break;

                case 11:
                    strMuaji = "Nentor";
                    break;

                case 12:
                    strMuaji = "Dhjetor";
                    break;

                default:
                    break;

            }

            return strMuaji;
        }

        private void optTabelare_CheckedChanged(object sender, EventArgs e)
        {
            if (this.optTabelare.Checked == true)
            {
                this.grida.Visible = true;
            }
            else
            {
                this.grida.Visible = false;
            }
        }

        private void frmBilancMujor_CausesValidationChanged(object sender, EventArgs e)
        {
            if (CausesValidation == true)
                return;

            int viti = dtViti.Value.Year;
            this.optTabelare.Checked = true;
            this.MbushGridenPerVitin(viti);
            this.NdertoZedGrafik();
        }

        #region Event Handlers
        #endregion

        #region IPrintableMembers
        public void PrintPreview()
        {
            if (this.grida.RowCount != 0)
            {
                frmRaportJanus frmPrint = new frmRaportJanus();
                frmPrint.PrintPreviewControl1.Document = Doc;
                frmPrint.ShowDialog();
            }
        }

        public bool ReadyToPrint
        {
            get
            {
                return this.readyToPrint;
            }
            set
            {
                bool oldValue = readyToPrint;
                readyToPrint = value;
                if (ReadyToPrintChanged != null && value != oldValue)
                    ReadyToPrintChanged(this, new ReadyChangedEventArgs());
            }
        }

        public void ConvertToExcel()
        {
            string[] fushat = new string[6];
            string[] llojet = new string[6];
            string[] key = new string[6];
            fushat[0] = "Muaji";
            fushat[1] = "Xhiro";
            fushat[2] = "Blerjet";
            fushat[3] = "Shpenzime_mujore";
            fushat[4] = "Shpenzime_te_ndryshme";
            fushat[5] = "Bilanci";

            key[0] = "MUAJISTR";
            key[1] = "XHIRO";
            key[2] = "BLERJE";
            key[3] = "SHPENZIMI_MUJOR";
            key[4] = "SHPENZIMI_DITOR";
            key[5] = "BILANCI";

            llojet[0] = "char(255)";
            llojet[1] = "float";
            llojet[2] = "float";
            llojet[3] = "float";
            llojet[4] = "float";
            llojet[5] = "float";

            KlaseExcel excel = new KlaseExcel("BilancMujor.xls", fushat, llojet);

            if (excel.gabim == 0)
            {
                excel.ShkruajGride("BilancMujor.xls", grida, fushat, key, llojet, "MUAJISTR");
            }
            if (excel.gabim == 0)
            {
                MessageBox.Show("Tabela u konvertua në skedarin " + excel.excelPath + "\\" +
                    "BilancMujor.xls!", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Janus.Windows.GridEX.GridEXPrintDocument Doc
        {
            get
            {
                return this.doc;
            }
            set
            {
                doc = value;
            }
        }

        public void Print()
        {
            if (grida.RowCount != 0)
            {
                Doc.Print();
            }
        }

        public event ResManagerLibrary.ReadyChangedEventHandler ReadyToPrintChanged;

        #endregion
    }
}