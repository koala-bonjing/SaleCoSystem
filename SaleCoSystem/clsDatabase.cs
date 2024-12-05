using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace SaleCoSystem
{
    public class clsDatabase
    {
        const string DB_HOST = "127.0.0.1";
        const string DB_USER = "root";
        const string DB_PWD = "";
        const string DB_NAME = "salecodb";

        const string CNString = @"SERVER=" + DB_HOST + ";" +
                                "UID=" + DB_USER + ";" +
                                "PWD=" + DB_PWD + ";" +
                                "DATABASE=" + DB_NAME + ";";
        public string PCODE = "";
        //RETRIEVE DATA 
        public DataTable QueryData(string _sql)
        {
            using (MySqlConnection _cn = new MySqlConnection(CNString))
            {
                try
                {
                    _cn.Open();

                    MySqlCommand _cmd = new MySqlCommand();
                    //Set command properties
                    _cmd.Connection = _cn;  //Assign active connection
                    _cmd.CommandType = CommandType.Text;
                    _cmd.CommandText = _sql; //assign SQL command

                    using (MySqlDataReader _dr = _cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(_dr);
                        return dt;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has encountered while attempting to connect with your database." +
                    "\n" + e.Message, "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }
            }
        }
        //----RETRIEVE DATA 


        //Execute NoneQuery
        public bool ExecuteSQLQuery(string _sql)
        {
            using (MySqlConnection _cn = new MySqlConnection(CNString))
            {
                try
                {
                    _cn.Open();

                    using (MySqlCommand _cmd = new MySqlCommand())
                    {
                        _cmd.Connection = _cn;  //Assign active connection
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = _sql; //assign SQL command

                        _cmd.ExecuteNonQuery();

                    }
                    //Set command properties
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has encountered while attempting to perform action." +
                    "\n" + e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            }
        }



        //----Execute NonQuery
        // FillCombo Box dynamically
        public void FillComboBox(string sql, string Value_Member, string Display_Member,System.Windows.Forms.ComboBox combo)
        {
            DataTable dt = new DataTable();
            using (var connection = new MySqlConnection(CNString))
            {
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (MySqlException e)
                    {
                        MessageBox.Show(" Error : " + e.ToString());
                    }
                }
            }
            combo.DataSource = dt;
            combo.ValueMember = Value_Member;
            combo.DisplayMember = Display_Member;
        }

        //----Execute Scalar - Returns single value

        public Int64 ExecuteQryScalar(string sql)
        {
            DataTable dt = new DataTable();
            using (var connection = new MySqlConnection(CNString))
            {
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        return Convert.ToInt64(cmd.ExecuteScalar());
                    }
                    catch (MySqlException e)
                    {
                        MessageBox.Show(" Error : " + e.ToString());
                        return 0;
                    }
                }
            }

        }

        public DataTable getData1(string sql, MySqlParameter parameter)

        {
            //Datatable to represent the rows/column of the database 
            DataTable dt = new DataTable();

            //MySqlConnection Class: amo ini ha Erika! an insasabi ni sir na 'SqlConnection' 1st step ini after mag declare connnection string
            //Amo ya an 1st: Establish connection between the databse and the system, tas an ipass mo na parameter is an name san connection string
            using (MySqlConnection connection = new MySqlConnection(CNString))
            {
                connection.Open();
                //Nah try & catch akoo para error handling 
                try
                {

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        if (parameter != null)
                        {
                            cmd.Parameters.Add(parameter);
                        }
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                //Ini an Exeception na i tothrow san program kun may sala 
                catch (MySqlException ex)
                {
                    MessageBox.Show("Sql Error: " + ex.Message);
                }
                //Close 'function?' dunno kun function an gahoy sun
                //always magclose every tapos san code mo na inopen mo ha para di ka mapagal
                finally
                {
                    connection.Close();
                }
                //Return dt since an ginamit ta na return type is 'Datatable'. Here ho: ' public 'DataTable' getData(string sql)'
                return dt;
            }
        }
       
        public void filterCombo()
        {
            
        }
            }
        }
    
