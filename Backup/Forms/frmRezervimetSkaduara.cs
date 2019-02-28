using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ResManagerAdmin.BusDatService;

namespace ResManagerAdmin.Forms
{
    public partial class frmRezervimetSkaduara : Form
    {
        public  DateTime dataZgjedhur;
        public int idRezervimi = 0;

        #region Form Load
        public frmRezervimetSkaduara()
        {
            InitializeComponent();
        }

        private void frmRezervimetSkaduara_Load(object sender, EventArgs e)
        {
            gridEXRezervimet.DataSource = this.ds.Tables[0];
        }
        #endregion

        #region Event Handlers
        private void btnAnullo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //sigurohemi nqs eshte zgjedhur nje prej rreshtave te grides
                int index = -1;
                for (int i = 0; i < gridEXRezervimet.RowCount; i++)
                {
                    if (gridEXRezervimet.GetRow(i).Cells["CHECKED"].Text == "True")
                    {
                        index = i;
                        break;
                    }
                }
                if (index >= 0)
                {
                    this.dataZgjedhur = Convert.ToDateTime(gridEXRezervimet.GetRow(index).Cells["DATA"].Text);
                    this.idRezervimi = Convert.ToInt32(gridEXRezervimet.GetRow(index).Cells["ID_REZERVIMI"].Text);
                    Close();
                }
            }
            catch
            {
                return;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnFshi_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataSet dsToErase = new DataSet();
                dsToErase.Tables.Add();
                dsToErase.Tables[0].Columns.Add("ID_REZERVIMI", typeof(Int32));
                dsToErase.AcceptChanges();
                for (int i = 0; i < gridEXRezervimet.RowCount; i++)
                {
                    if (gridEXRezervimet.GetRow(i).Cells["CHECKED"].Text == "True")
                    {
                        DataRow r = dsToErase.Tables[0].NewRow();
                        r["ID_REZERVIMI"] = Convert.ToInt32(gridEXRezervimet.GetRow(i).Cells["ID_REZERVIMI"].Text);
                        dsToErase.Tables[0].Rows.Add(r);
                    }
                }
                dsToErase.AcceptChanges();
                if (dsToErase.Tables[0].Rows.Count != 0)
                {
                    InputController data = new InputController();
                    DataSet dsFshire = data.KerkesaRead("FshiRezervimeSkaduara", dsToErase);
                    if (dsFshire == null)
                        MessageBox.Show(this, "Një gabim ndodhi gjatë fshirjes së rezervimeve. Provoni përsëri!",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show(this, "Rezervimet e zgjedhur u fshinë.",
                            this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //nqs jane fshire te gjithe rezervimet e skaduara atehere
                        //forma e rezervimeve te skaduara mbyllet
                        if (dsToErase.Tables[0].Rows.Count == gridEXRezervimet.RowCount)
                            Close();
                        //perndryshe rimbushim griden me rezervimet  e skaduara
                        else
                        {
                            this.ds = data.KerkesaRead("RezervimetESkaduara");
                            this.ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
                            this.ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
                            this.ds.AcceptChanges();
                            gridEXRezervimet.DataSource = this.ds.Tables[0];
                        }
                    }
                }
            }
            catch
            {
                return;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion


    }
}