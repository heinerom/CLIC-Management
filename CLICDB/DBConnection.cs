using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICDB
{
    public class DBConnection
    {
    public static SqlConnection GetConnection()

        {

            string connectionString = "Data Source = DANIELZHAO--COM\\SQLEXPRESS; Initial Catalog = CLICApp; Integrated Security = True";

            SqlConnection connection = new SqlConnection(connectionString);

            return connection;


            //----------------------------ATTENTION---------------------------------//
            // For Application Info and Applicatin Status Tables:
            // Applications which ID between 1-7586 were from Old Access Data;
            // Applications which ID > 8000 were from the Excel Spreadsheet(Newer).
            //----------------------------------------------------------------------//
            // For Inventory Table:
            // Inventories which ID between 1-8064 were from Old Access Data;
            // Inventories which ID > 8850 were from the Excel Spreadsheet(Newer).
            //----------------------------------------------------------------------//
        }

    }
}
