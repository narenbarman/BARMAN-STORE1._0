using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace BARMAN_STORE1._0.Include
{
    
    class SQLConfig
    {

        private const string CONNECTIONSTRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\NAREN\DESKTOP\BSPROJECT\BARMAN STORE1._0\USERDATABASE.MDF;Integrated Security=True";

       // private const string CONNECTIONSTRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserDatabase.mdf;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(CONNECTIONSTRING);
        private SqlCommand command;
        private SqlDataAdapter dataadapter;
        public DataTable datatable;
        public BindingSource bindingSource;
        public DataView dataView;
        int result;
        usableFunction funct = new usableFunction();
        public bool CExecute_CUD(string sql, string msg_false, string msg_true)
        {
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                result = command.ExecuteNonQuery();

                if(result > 0)
                {
                    MessageBox.Show(msg_true+result);
                    return true;
                }
                else
                {
                    MessageBox.Show(msg_false);
                    return false;
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.Close(); 
            }
        }
        public void Execute_Query(string sql)
        {
            try
            {
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                result = command.ExecuteNonQuery();
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Load_DTG(string sql,DataGridView dtg)
        {
            try
            {
                connection.Open();
                command = new SqlCommand();
                dataadapter = new SqlDataAdapter();
                datatable = new DataTable();
                bindingSource = new BindingSource();
                

                command.Connection = connection;
                command.CommandText = sql;
                dataadapter.SelectCommand = command;
                dataadapter.Fill(datatable);
                dataView = new DataView(datatable);
                bindingSource.DataSource= datatable;
                dtg.DataSource = dataView;//datatable;

               
                //funct.ResponsiveDtg(dtg);
                //dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataadapter.Dispose();
                connection.Close();
            }

        }
        public void fiil_CBO(string sql, ComboBox cbo)
        {
            try
            {
                connection.Open();
                command = new SqlCommand();
                dataadapter = new SqlDataAdapter();
                datatable = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataadapter.SelectCommand = command;
                dataadapter.Fill(datatable);
                cbo.DataSource = datatable;
                cbo.ValueMember = datatable.Columns[0].ColumnName;
                cbo.DisplayMember = datatable.Columns[0].ColumnName;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataadapter.Dispose();
                connection.Close();
            }

        }
        public void fiil_CBOX(string sql, ComboBox cbo)
        {
            try
            {
                connection.Open();
                command = new SqlCommand();
                dataadapter = new SqlDataAdapter();
                datatable = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataadapter.SelectCommand = command;
                dataadapter.Fill(datatable);
                cbo.Items.Clear();
                cbo.Items.Add("*ALL");
                foreach(DataRow X in datatable.Rows)
                {
                    cbo.Items.Add(X[0].ToString());
                }
                cbo.ValueMember = datatable.Columns[0].ColumnName;
                cbo.DisplayMember = datatable.Columns[0].ColumnName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataadapter.Dispose();
                connection.Close();
            }

        }
        public void singleResult(string sql)

        {
            try
            {
                connection.Open();
                command = new SqlCommand();
                dataadapter = new SqlDataAdapter();
                datatable = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataadapter.SelectCommand = command;
                dataadapter.Fill(datatable);  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataadapter.Dispose();
                connection.Close();
            }
        }

        public void loadReports(string sql)

        {
            try
            {
                connection.Open();
                command = new SqlCommand();
                dataadapter = new SqlDataAdapter();
                datatable = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataadapter.SelectCommand = command;
                dataadapter.Fill(datatable);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataadapter.Dispose();
                connection.Close();
            }
        }

        public void autocomplete(string sql,TextBox txt)
        {
            try
            {
                connection.Open();
                command = new SqlCommand();
                dataadapter = new SqlDataAdapter();
                datatable = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataadapter.SelectCommand = command;
                dataadapter.Fill(datatable);
                txt.AutoCompleteCustomSource.Clear();
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                foreach (DataRow r in datatable.Rows)
                {
                    txt.AutoCompleteCustomSource.Add(r.Field<string>(0));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataadapter.Dispose();
                connection.Close();
            }
        }

        public void autonumber(string sql,TextBox txt)
        {
            try
            {
                connection.Open();
                command = new SqlCommand();
                dataadapter = new SqlDataAdapter();
                datatable = new DataTable();


                command.Connection = connection;
                command.CommandText = sql;
                dataadapter.SelectCommand = command;
                dataadapter.Fill(datatable);

                txt.Text = datatable.Rows[0].Field<string>(0);
            

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                dataadapter.Dispose();
                connection.Close();
            }
        }
        public void update_Autonumber(string id)
        { 
            Execute_Query("UPDATE `tblautonumber` SET `END`=`END`+`INCREMENT` WHERE `DESCRIPTION`='" + id + "'");
        }
       


    }
}
