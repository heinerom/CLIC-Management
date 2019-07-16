using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICDB
{
    public class AdminDB
    {
        public static void InsertAdminUser(Admin Admin)
        {
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql ="INSERT Users (" +
                               "FirstName," +
                               "LastName," +
                               "Phone," +
                               "Username," +
                               "Password)" +
                        "VALUES (" +
                               "@FirstName," +
                               "@LastName," +
                               "@Phone," +
                               "@Username," +
                               "@Password);";

            SqlCommand cmdInsert = new SqlCommand(sql, dbConn);

            cmdInsert.Parameters.AddWithValue("@FirstName", Admin.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", Admin.LastName);
            cmdInsert.Parameters.AddWithValue("@Phone", Admin.Phone);
            cmdInsert.Parameters.AddWithValue("@Username", Admin.Username);
            cmdInsert.Parameters.AddWithValue("@Password", Admin.Password);

            try
            {
                dbConn.Open();
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("New Admin User created successful");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                dbConn.Close();
            }
        }

    }
}
