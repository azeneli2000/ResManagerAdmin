using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ResManagerAdmin.BusDatService
{
    /// <summary>
    /// Summary description for DbManager
    /// </summary>
    public class DbManager : System.ComponentModel.Component
    {
        #region Private Fields
        public string strSql = "";
        private System.Data.SqlClient.SqlCommand cmdRes;
        private System.Data.SqlClient.SqlConnection conn;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Constructors & Destructors
        public DbManager(System.ComponentModel.IContainer container)
        {
            ///
            /// Required for Windows.Forms Class Composition Designer support
            ///
            container.Add(this);
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public DbManager()
        {
            ///
            /// Required for Windows.Forms Class Composition Designer support
            ///
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public DbManager(string query)
        {
            strSql = query;
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region GetData

        public int GetData()
        {
            return this.Execut1();
        }

        public DataSet GetData(string CRUD)
        {
            SqlDataReader dr = this.Execut2();
            return this.ConvertDataReaderToDataSet(dr);
        }

        public DataSet GetData(int data)
        {
            return this.ConvertDataReaderToDataSet(this.Execut2());
        }

        #endregion

        #region Private Methods

        private int Execut1()
        {
            try
            {
                this.conn.Open();
                this.cmdRes.CommandText = this.strSql;
                int p = cmdRes.ExecuteNonQuery();
                this.conn.Close();
                return 0;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //HotelManagment.Forms.FaqeKryesore main = new HotelManagment.Forms.FaqeKryesore();
                //VisionInfoSolutionLibrary.MessageBox.Show(main, ex);
                return 1;

            }
            finally
            {
                this.conn.Close();
            }
        }

        private SqlDataReader Execut2()
        {
            try
            {
                this.conn.Open();
                this.cmdRes.CommandText = this.strSql;
                SqlDataReader reader = cmdRes.ExecuteReader();
                return reader;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //MainForm main = new MainForm();
                //VisionInfoSolutionLibrary.MessageBox.Show(ex);
                return null;
            }

        }

        /// <summary>
        /// Ben konvertimin e nje datareaderi ne nje dataset me nje datatable
        /// </summary>
        /// <param name="reader">DataReader-i qe do te konvertohet</param>
        /// <returns>DataSetin qe merret nga konvertimi</returns>
        public DataSet ConvertDataReaderToDataSet(SqlDataReader reader)
        {
            try
            {
                DataSet dataSet = new DataSet();
                do
                {
                    // Krijo nje dataTable te ri

                    DataTable schemaTable = reader.GetSchemaTable();
                    DataTable dataTable = new DataTable();

                    if (schemaTable != null)
                    {
                        // A query returning records was executed

                        for (int i = 0; i < schemaTable.Rows.Count; i++)
                        {
                            DataRow dataRow = schemaTable.Rows[i];
                            // Create a column name that is unique in the data table
                            string columnName = (string)dataRow["ColumnName"]; //+ "<C" + i + "/>";
                            // Add the column definition to the data table
                            DataColumn column = new DataColumn(columnName, (Type)dataRow["DataType"]);
                            dataTable.Columns.Add(column);
                        }

                        dataSet.Tables.Add(dataTable);

                        // Fill the data table we just created

                        while (reader.Read())
                        {
                            DataRow dataRow = dataTable.NewRow();

                            for (int i = 0; i < reader.FieldCount; i++)
                                dataRow[i] = reader.GetValue(i);

                            dataTable.Rows.Add(dataRow);
                        }
                    }
                    else
                    {
                        // No records were returned

                        DataColumn column = new DataColumn("RowsAffected");
                        dataTable.Columns.Add(column);
                        dataSet.Tables.Add(dataTable);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = reader.RecordsAffected;
                        dataTable.Rows.Add(dataRow);
                    }
                }
                while (reader.NextResult());
                return dataSet;
            }
            catch (Exception ex)
            {
                DataSet ds = null;
                return ds;
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdRes = new System.Data.SqlClient.SqlCommand();
            this.conn = new System.Data.SqlClient.SqlConnection();
            // 
            // cmdRes
            // 
            this.cmdRes.Connection = this.conn;
            // 
            // conn
            // 
            this.conn.ConnectionString = "Data Source=SERVER\\REM;Initial Catalog=ResManager;User ID=sa;Password=vision";
            this.conn.FireInfoMessageEventOnUserErrors = false;

        }
        #endregion
    }
}
