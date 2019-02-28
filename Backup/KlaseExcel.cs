using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace ResManagerAdmin
{
    class KlaseExcel
    {
        private string connString;
        private OleDbConnection conn = new OleDbConnection();
        public string excelPath = @"C:\Excel Restoranti";
        OleDbCommand cmd = new OleDbCommand();
        public int gabim = 0;

        public KlaseExcel(string file, string[] fushat, string[] lloji)
        {
            try
            {
                connString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                   @"Data Source=" + excelPath + "\\" + file +
                   @";Extended Properties=""Excel 8.0;HDR=YES""";
                conn.ConnectionString = connString;

                if (!Directory.Exists(excelPath))
                {
                    Directory.CreateDirectory(excelPath);
                }
                if (File.Exists(excelPath + "\\" + file))
                    File.Delete(excelPath + "\\" + file);

                conn.Open();
                cmd.Connection = conn;
                string str = "";
                str = "CREATE TABLE " + file.Remove(file.Length - 4) + "(";
                for (int i = 0; i < fushat.Length; i++)
                {
                    str += fushat[i] + " " + lloji[i] + ",";
                }
                str = str.Remove(str.Length - 1);
                str += ")";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
                gabim = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ndodhi një gabim gjatë konvertimit në Excel!"
                    + Environment.NewLine + "Nqs keni të hapur ndonjë skedar Excel me emër " + file +
                    Environment.NewLine + "mbylleni dhe riprovoni të bëni konvertimin në Excel.", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gabim = 1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

        /// <summary>
        /// Hedh ne file-in Excel te dhenat e grides pa ndonje kategorizim te vecante
        /// </summary>
        /// <param name="file"></param>
        /// <param name="grid"></param>
        /// <param name="fushat"></param>
        /// <param name="key"></param>
        /// <param name="llojet"></param>
        /// <param name="id"></param>
        public void ShkruajGride(string file, Janus.Windows.GridEX.GridEX grid,
            string[] fushat, string[] key, string[] llojet, string id)
        {
            try
            {
                connString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                       @"Data Source=" + excelPath + "\\" + file +
                       @";Extended Properties=""Excel 8.0;HDR=YES""";
                conn.ConnectionString = connString;
                conn.Open();
                cmd.Connection = conn;
                for (int i = 0; i < grid.RowCount; i++)
                {
                    bool total = false;
                    if (grid.GetRow(i).Cells[id].Text == "")
                    {
                        //nqs eshte rresthi total ath shkruaje ne excel
                        if (grid.TotalRow == Janus.Windows.GridEX.InheritableBoolean.True && i == grid.RowCount - 1)
                        {
                            total = true;
                        }
                        else
                            continue;
                    }
                    string str = "INSERT INTO [" + file.Remove(file.Length - 4) + "$] (";
                    for (int j = 0; j < fushat.Length; j++)
                        str += fushat[j] + ",";
                    str = str.Remove(str.Length - 1);
                    str += ") VALUES ( ";
                    for (int j = 0; j < fushat.Length; j++)
                    {
                        if (grid.GetRow(i).Cells[id].Text == "" && total == true && j == 0)
                        {
                            str += "'TOTAL',";
                            continue;
                        }
                        else if (llojet[j] == "char(255)")
                            str += "'" + grid.GetRow(i).Cells[key[j]].Text.Replace("'", "`") + "',";
                        else if (llojet[j] == "float")
                        {
                            if (grid.GetRow(i).Cells[key[j]].Value == null)
                                str += "0,";
                            else
                                str += grid.GetRow(i).Cells[key[j]].Value.ToString() + ",";
                        }
                        else
                            str += grid.GetRow(i).Cells[key[j]].Text + ",";

                    }
                    str = str.Remove(str.Length - 1);
                    str += ")";
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                    gabim = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ndodhi një gabim gjatë konvertimit në Excel!"
                    + Environment.NewLine + "Nqs keni të hapur ndonjë skedar Excel me emër " + file +
                    Environment.NewLine + "mbylleni dhe riprovoni të bëni konvertimin në Excel.", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gabim = 1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

        }


        //public void ShkruajGrideKategori(string file, Janus.Windows.GridEX.GridEX grid,
        //    string[] fushat, string[] key, string[] llojet, string id, string colKategori)
        //{
        //    try
        //    {
        //        connString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
        //               @"Data Source=" + excelPath + "\\" + file +
        //               @";Extended Properties=""Excel 8.0;HDR=YES""";
        //        conn.ConnectionString = connString;
        //        conn.Open();
        //        cmd.Connection = conn;
        //        for (int i = 0; i < grid.RowCount; i++)
        //        {
        //            string str = "";
        //            //nqs eshte rresht kategorizimi

        //            if (grid.GetRow(i).Cells[id].Text == "")
        //            {
        //                if (colKategori == "TAVOLINA")
        //                {
        //                    str = "INSERT INTO [" + file.Remove(file.Length - 4) + "$] (";
        //                    if (grid.GetRow(i).GroupCaption != null)
        //                        str += fushat[0] + ") VALUES ('" + grid.GetRow(i).GroupCaption.Replace("'", "`") + "')";
        //                    else
        //                    {
        //                        str += fushat[0] + ",Vlera) VALUES ('TOTAL', " + grid.GetRow(i).Cells["VLERA"].Value + ")";
        //                    }
        //                }
        //                else //if (colKategori == "EMRI")
        //                {
        //                    str = "INSERT INTO [" + file.Remove(file.Length - 4) + "$] (";
        //                    if (grid.GetRow(i).GroupCaption != null)
        //                        str += fushat[0] + ") VALUES ('" + grid.GetRow(i).GroupCaption.Replace("'", "`") + "')";
        //                    else
        //                    {
        //                        if (grid.Name == "gridBlerjet")
        //                            str += fushat[0] + ",Vlera_e_blerjes, Skonto, Blerja_në_total, Paguar, Detyrimi_ndaj_furnitorit) VALUES ('TOTAL' "
        //                            + ", " + grid.GetRow(i).Cells["VLERA"].Value + "," + grid.GetRow(i).Cells["SKONTO"].Value + "," + grid.GetRow(i).Cells["TOTAL"].Value + "," + grid.GetRow(i).Cells["PAGUAR"].Value +
        //                            ", " + grid.GetRow(i).Cells["DETYRIMI"].Value + ")";
        //                        else if (grid.Name == "gridShitjet")
        //                            str += fushat[0] + ",Vlera_e_shitjes, Skonto, Shitja_në_total, Paguar, Detyrimi_i_klientit) VALUES ('TOTAL' "
        //                            + ", " + grid.GetRow(i).Cells["VLERA"].Value + "," + grid.GetRow(i).Cells["SKONTO"].Value + "," + grid.GetRow(i).Cells["TOTAL"].Value + "," + grid.GetRow(i).Cells["PAGUAR"].Value +
        //                            ", " + grid.GetRow(i).Cells["DETYRIMI"].Value + ")";
        //                    }
        //                }

        //            }
        //            //nqs eshte rresht element
        //            else
        //            {
        //                str = "INSERT INTO [" + file.Remove(file.Length - 4) + "$] (";
        //                for (int j = 0; j < fushat.Length; j++)
        //                    str += fushat[j] + ",";
        //                str = str.Remove(str.Length - 1);
        //                str += ") VALUES ( ";
        //                for (int j = 0; j < fushat.Length; j++)
        //                {
        //                    if (llojet[j] == "char(255)")
        //                        str += "'" + grid.GetRow(i).Cells[key[j]].Text.Replace("'", "`") + "',";
        //                    else if (llojet[j] == "float")
        //                    {
        //                        if (grid.GetRow(i).Cells[key[j]].Text != "")
        //                            str += grid.GetRow(i).Cells[key[j]].Value.ToString() + ",";
        //                        else
        //                            str += "0" + ",";
        //                    }
        //                    else
        //                        str += grid.GetRow(i).Cells[key[j]].Text + ",";

        //                }
        //                str = str.Remove(str.Length - 1);
        //                str += ")";
        //            }
        //            cmd.CommandText = str;
        //            cmd.ExecuteNonQuery();
        //            gabim = 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ndodhi një gabim gjatë konvertimit në Excel!"
        //            + Environment.NewLine + "Nqs keni të hapur ndonjë skedar Excel me emër " + file +
        //            Environment.NewLine + "mbylleni dhe riprovoni të bëni konvertimin në Excel.", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        gabim = 1;
        //    }
        //    finally
        //    {
        //        if (conn.State == System.Data.ConnectionState.Open)
        //            conn.Close();
        //    }

        //}

        public void ShkruajGrideKategori(string file, Janus.Windows.GridEX.GridEX grid,
            string[] fushat, string[] key, string[] llojet, string id)
        {
            try
            {
                connString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                       @"Data Source=" + excelPath + "\\" + file +
                       @";Extended Properties=""Excel 8.0;HDR=YES""";
                conn.ConnectionString = connString;
                conn.Open();
                cmd.Connection = conn;
                for (int i = 0; i < grid.RowCount; i++)
                {
                    string str = "";
                    str = "INSERT INTO [" + file.Remove(file.Length - 4) + "$] (";
                    if (grid.GetRow(i).RowType == Janus.Windows.GridEX.RowType.GroupHeader)
                    {
                        str += grid.RootTable.Columns[id].Caption.Replace(" ", "_") + ")";
                        str += " VALUES ('" + grid.GetRow(i).Group.Column.Caption + ":" + grid.GetRow(i).GroupCaption + "')";
                    }
                    else if (grid.GetRow(i).RowType == Janus.Windows.GridEX.RowType.TotalRow ||
                        grid.GetRow(i).RowType == Janus.Windows.GridEX.RowType.GroupFooter)
                    {
                        for (int j = 0; j < key.Length; j++)
                        {
                            //if (key[j] == colKategori)
                            //    continue;
                            str += fushat[j] + ",";
                        }
                        str = str.Substring(0, str.Length - 1);
                        str += ") VALUES ('TOTAL',";
                        for (int j = 0; j < key.Length; j++)
                        {
                            if (j == 0)
                                continue;
                            if (llojet[j] == "char(255)")
                                str += "'" + grid.GetRow(i).Cells[key[j]].Text.Replace("'", "`") + "',";
                            else if (llojet[j] == "float")
                            {
                                if (grid.GetRow(i).Cells[key[j]].Value == null)
                                    str += "null,";
                                else
                                    str += grid.GetRow(i).Cells[key[j]].Value.ToString() + ",";
                            }
                            else
                                str += grid.GetRow(i).Cells[key[j]].Text + ",";

                        }
                        str = str.Remove(str.Length - 1);
                        str += ")";
                    }
                    else
                    {
                        for (int j = 0; j < key.Length; j++)
                        {
                            //if (key[j] == colKategori)
                            //    continue;
                            str += fushat[j] + ",";
                        }
                        str = str.Substring(0, str.Length - 1);
                        str += ") VALUES (";
                        for (int j = 0; j < key.Length; j++)
                        {
                            //if (key[j] == colKategori)
                            //    continue;
                            if (llojet[j] == "char(255)")
                                str += "'" + grid.GetRow(i).Cells[key[j]].Text.Replace("'", "`") + "',";
                            else if (llojet[j] == "float")
                                str += grid.GetRow(i).Cells[key[j]].Value.ToString() + ",";
                            else
                                str += grid.GetRow(i).Cells[key[j]].Text + ",";
                            
                        }
                        str = str.Remove(str.Length - 1);
                        str += ")";
                    }
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ndodhi një gabim gjatë konvertimit në Excel!"
                    + Environment.NewLine + "Nqs keni të hapur ndonjë skedar Excel me emër " + file +
                    Environment.NewLine + "mbylleni dhe riprovoni të bëni konvertimin në Excel.", "Konvertimi në Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gabim = 1;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

        }
    }
}
