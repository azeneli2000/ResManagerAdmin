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
    public partial class frmRezervime : Form
    {
        #region FormLoad
        public frmRezervime()
        {
            InitializeComponent();
        }

        private void frmRezervime_Load(object sender, EventArgs e)
        {
            LexoInformacione();
            if (!RezervimetESkaduara())
            {
                button1_Click(sender, e);
            }

        }
        #endregion

        #region PrivateMethods

        /// <summary>
        /// Shfaq te gjithe rezervimet qe u ka kaluar afati
        /// Kthen true nqs ka patur rezervime te skaduara dhe eshte tentuar te modifikohet ndonje
        /// Kthen false nqs nuk eshte tentuar te modifikohet ndonje rezervim
        /// </summary>
        /// <returns></returns>
        private bool RezervimetESkaduara()
        {
            InputController data = new InputController();
            DataSet ds = data.KerkesaRead("RezervimetESkaduara");
            ds.Tables[0].Columns.Add("CHECKED", typeof(Boolean));
            ds.Tables[0].Columns["CHECKED"].DefaultValue = false;
            ds.AcceptChanges();
            if (ds.Tables[0].Rows.Count != 0)
            {
                frmRezervimetSkaduara frm = new frmRezervimetSkaduara();
                frm.ds = ds;
                frm.ShowDialog();
                //dmth qe eshte zgjedhur nje rezervim  per ta modifikuar
                DateTime dataZgjedhur = frm.dataZgjedhur;
                int idRezervimi = frm.idRezervimi;
                if (dataZgjedhur != Convert.ToDateTime("0001-01-01 12:00:00.PD") && idRezervimi != 0)
                {
                    calendar.CurrentDate = dataZgjedhur;
                    DateTime[] v = new DateTime[1];
                    v[0] = dataZgjedhur;
                    calendar.SelectedDates = v;
                    scheduleRezervimet.SelectedAppointments.Clear();
                    scheduleRezervimet.SelectedAppointments.Add(scheduleRezervimet.Appointments[idRezervimi.ToString()]);
                    this.modifikoRezerviminEZgjedhurToolStripMenuItem_Click(new object(), new EventArgs());
                    return true;
                }
                return false;
            }
            else
                return false;
        }

        private void LexoInformacione()
        {
            InputController data = new InputController();
            string fileName = Global.stringXml + "\\Informacione.xml";
            DataSet dsInf = data.KerkesaRead("InformacionetPerRestorantinShkurt");
            string s = dsInf.Tables[0].Rows[0][0].ToString();
            this.expandablePanel1.TitleText = s;
        }

        private void ShfaqRezervimetSchedule(DateTime dt)
        {
            PastroSchedule();
            InputController data = new InputController();
            DataSet dsRezervimetTavolinat = data.KerkesaRead("ShfaqRezervimetTavolina", dt);
            //nuk ka asnje rezervim per daten e zgjedhur
            if (dsRezervimetTavolinat.Tables[0].Rows.Count == 0)
            {
                return;
            }
            else
            {
                //Shtojme ne headerin siper te gjithe rezervimet per diten e zgjedhur
                //per secilin rezervim hedhim te dhenat perkatese
                DataSet dsRez = GjejRezervimet(dsRezervimetTavolinat);
                dsRez.Tables[0].Columns.Add("TEKST", typeof(String));
                dsRez.AcceptChanges();
                //DataSeti nuk ka mundesi te jete bosh
                foreach (DataRow dr in dsRez.Tables[0].Rows)
                {
                    int idRezervimi = Convert.ToInt32(dr["ID_REZERVIMI"]);
                    string emriRezervimi = dr["REZERVIMI"].ToString();

                    //gjejme tavolinat e rezervuara per secilin rezervim
                    string tekst = " Klienti " + emriRezervimi + " ka rezervuar tavolinat:";
                    int i = 0;
                    bool ugjet = false;
                    foreach (DataRow r in dsRezervimetTavolinat.Tables[0].Rows)
                    {
                        if (idRezervimi == Convert.ToInt32(r["ID_REZERVIMI"]))
                        {
                            tekst += Environment.NewLine + "Tavolina " + r["TAVOLINA"] + "(" + r["KAPACITETI"] + " vende)";
                            ugjet = true;
                        }
                        //nqs nuk jemi ne rreshtin e parafundit
                        if ((ugjet) && (i < dsRezervimetTavolinat.Tables[0].Rows.Count - 1))
                        {
                            int idRezTjeter = Convert.ToInt32(dsRezervimetTavolinat.Tables[0].Rows[i + 1]["ID_REZERVIMI"]);
                            if (idRezervimi != idRezTjeter)
                                break;
                        }
                        i++;
                    }
                    dr["TEKST"] = tekst;
                }
                int index = 0;
                foreach (DataRow dr in dsRez.Tables[0].Rows)
                {
                    DateTime fillimi = Convert.ToDateTime(dr["ORA_FILLIMI"]);
                    DateTime mbarimi = Convert.ToDateTime(dr["ORA_MBARIMI"]);
                    string tekst = dr["TEKST"].ToString();
                    Janus.Windows.Schedule.ScheduleAppointment rezervim =
                        new Janus.Windows.Schedule.ScheduleAppointment(fillimi, mbarimi, tekst);
                    rezervim.Key = dr["ID_REZERVIMI"].ToString();
                    scheduleRezervimet.Appointments.Add(rezervim);
                    index++;
                }
            }
        }
       
        /// <summary>
        /// Pastron tabelen nga rezervimet
        /// </summary>
        private void PastroSchedule()
        {
             scheduleRezervimet.Owners.Clear();
             int l = scheduleRezervimet.Appointments.Count;
             for (int i = 0; i < l; i++)
             {
                 scheduleRezervimet.Appointments.RemoveAt(0);
             }
        }

        private DataSet GjejRezervimet(DataSet ds)
        {
            DataSet dsRez = new DataSet();
            dsRez.Tables.Add();
            dsRez.Tables[0].Columns.Add("ID_REZERVIMI", typeof(Int32));
            dsRez.Tables[0].Columns.Add("REZERVIMI", typeof(String));
            dsRez.Tables[0].Columns.Add("ORA_FILLIMI", typeof(DateTime));
            dsRez.Tables[0].Columns.Add("ORA_MBARIMI", typeof(DateTime));
            DataColumn[] vektorPrimary = new DataColumn[1];
            vektorPrimary[0] = dsRez.Tables[0].Columns["ID_REZERVIMI"];
            dsRez.Tables[0].PrimaryKey = vektorPrimary;
            dsRez.AcceptChanges();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int idRezervimi = Convert.ToInt32(dr["ID_REZERVIMI"]);
                DataRow drSearch = dsRez.Tables[0].Rows.Find(idRezervimi);
                //nqs tavolinen nuk e kemi shtuar me pare 
                //e shtojme ne dataset
                if (drSearch == null)
                {
                    DataRow newRow = dsRez.Tables[0].NewRow();
                    newRow["ID_REZERVIMI"] = dr["ID_REZERVIMI"];
                    newRow["REZERVIMI"] = dr["EMRI"].ToString() + " " + dr["MBIEMRI"].ToString();
                    newRow["ORA_FILLIMI"] = dr["ORA_FILLIMI"];
                    newRow["ORA_MBARIMI"] = dr["ORA_MBARIMI"];
                    dsRez.Tables[0].Rows.Add(newRow);
                }
                dsRez.AcceptChanges();
            }
            return dsRez;
        }


        #endregion

        #region Context Menu Event Handlers
        private void toolStripShto_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmKonfiguroRezervime frm = new frmKonfiguroRezervime();
            frm.llojiVeprimi = "Shtim";
            frm.ShowDialog();
            this.ShfaqRezervimetSchedule(calendar.CurrentDate);
            this.Cursor = Cursors.Default;
        }

        private void modifikoRezerviminEZgjedhurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //nuk eshte zgjedhur asnje rezervim
            if (scheduleRezervimet.SelectedAppointments.Count == 0)
            {
                MessageBox.Show(this, "Më parë duhet të zgjidhni një prej rezervimeve!", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmKonfiguroRezervime frm = new frmKonfiguroRezervime();
                frm.llojiVeprimi = "Modifikim";
                int id = Convert.ToInt32(scheduleRezervimet.SelectedAppointments[0].Key);
                frm.idRezervimi = id;
                frm.ShowDialog();
            }
            this.ShfaqRezervimetSchedule(calendar.CurrentDate);
            this.Cursor = Cursors.Default;
        }

        private void fshiRezerviminEZgjedhurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //nuk eshte zgjedhur asnje rezervim
            if (scheduleRezervimet.SelectedAppointments.Count == 0)
            {
                MessageBox.Show(this, "Më parë duhet të zgjidhni një prej rezervimeve!", this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InputController data = new InputController();
                int idRezervimi = Convert.ToInt32(scheduleRezervimet.SelectedAppointments[0].Key);
                int b = data.KerkesaUpdate("FshiRezervim", idRezervimi);

            }
            this.ShfaqRezervimetSchedule(calendar.CurrentDate);
            this.Cursor = Cursors.Default;
        }

        private void rezervimetJashtëAfatitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!RezervimetESkaduara())
            {
                button1_Click(sender, e);
            }
        }
        #endregion

        #region Event Handlers

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime[] v = new DateTime[1];
            v[0] = DateTime.Now;
            calendar.SelectedDates = v;
            calendar.CurrentDate = DateTime.Now;
        }

        private void calendar_SelectionChanged(object sender, EventArgs e)
        {
            DateTime data = calendar.CurrentDate;
            scheduleRezervimet.Date = data;
            ShfaqRezervimetSchedule(data);
        }

        private void scheduleRezervimet_AppointmentDoubleClick(object sender, Janus.Windows.Schedule.AppointmentEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmKonfiguroRezervime frm = new frmKonfiguroRezervime();
            frm.llojiVeprimi = "Modifikim";
            frm.idRezervimi = Convert.ToInt32(e.Appointment.Key);
            frm.ShowDialog();
            this.ShfaqRezervimetSchedule(calendar.CurrentDate);
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region linkLabel Clicked
        private void lnShtoREzervim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toolStripShto_Click(sender,e);
        }

        private void lnModifiko_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            modifikoRezerviminEZgjedhurToolStripMenuItem_Click(sender, e);
        }

        private void lnFshi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fshiRezerviminEZgjedhurToolStripMenuItem_Click(sender, e);
        }

        private void lnSkaduara_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rezervimetJashtëAfatitToolStripMenuItem_Click(sender, e);
        }
        #endregion
    }
}