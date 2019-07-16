using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICDB
{
    public class InventoryDB
    {
        // Get all inventories to a list
        public static List<Inventory> GetAllInventories()
        {
            List<Inventory> inventory = new List<Inventory>();//set up a list
            SqlConnection dbConn = DBConnection.GetConnection(); //get database connection
            string sql =
                "SELECT PCPickUpNo, PCType, Model, OldOS, OldCOA, " +
                "DateBuilt, MarCreated, NewCOA, PCStatus, Details, Recipient " +
                "FROM Inventory " +
                "ORDER BY PCPickUpNo";
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Inventory inv = new Inventory();
                    inv.PCPickUpNo = Convert.ToInt32(dbReader["PCPickUpNo"]);
                    inv.PCType = Convert.ToString(dbReader["PCType"]);
                    inv.Model = Convert.ToString(dbReader["Model"]);
                    if (Convert.ToInt32(dbReader["OldOS"]) == 0)
                    {
                        inv.OldOS = "Windows 8 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 1)
                    {
                        inv.OldOS = "Windows 7 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 2)
                    {
                        inv.OldOS = "Windows 7 Home Prem";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 3)
                    {
                        inv.OldOS = "Windows Vista Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 4)
                    {
                        inv.OldOS = "Windows Vista Home";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 5)
                    {
                        inv.OldOS = "No registered OS";
                    }
                    inv.OldCOA = Convert.ToString(dbReader["OldCOA"]);
                    inv.DateBuilt = Convert.ToDateTime(dbReader["DateBuilt"]);
                    inv.MarCreated = dbReader["MarCreated"] == DBNull.Value ? null : (DateTime?)dbReader["MarCreated"];
                    inv.NewCOA = Convert.ToString(dbReader["NewCOA"] == DBNull.Value ? null : dbReader["NewCOA"]);
                    if (Convert.ToInt32(dbReader["PCStatus"]) == 0)
                    {
                        inv.PCStatus = "Claimed/Given-Out";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 1)
                    {
                        inv.PCStatus = "In Storage";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 2)
                    {
                        inv.PCStatus = "Deployed to DI Downtown";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 3)
                    {
                        inv.PCStatus = "Busted-Recycling";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 4)
                    {
                        inv.PCStatus = "Unable to Locate Unit";
                    }
                    inv.Details = Convert.ToString(dbReader["Details"] == DBNull.Value ? null : dbReader["Details"]);
                    inv.Recipient = Convert.ToString(dbReader["Recipient"] == DBNull.Value ? null : dbReader["Recipient"]);


                    inventory.Add(inv);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                dbConn.Close();
            }
            return inventory;
        }

        // Get Stored inventories to a list
        public static List<Inventory> GetInstorageInventories()
        {
            List<Inventory> inventory = new List<Inventory>();//set up a list
            SqlConnection dbConn = DBConnection.GetConnection(); //get database connection
            string sql =
                "SELECT PCPickUpNo, PCType, Model, OldOS, OldCOA, " +
                "DateBuilt, MarCreated, NewCOA, PCStatus, Details, Recipient " +
                "FROM Inventory " +
                "WHERE PCStatus = 1 " +
                "ORDER BY PCPickUpNo";
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Inventory inv = new Inventory();
                    inv.PCPickUpNo = Convert.ToInt32(dbReader["PCPickUpNo"]);
                    inv.PCType = Convert.ToString(dbReader["PCType"]);
                    inv.Model = Convert.ToString(dbReader["Model"]);
                    if (Convert.ToInt32(dbReader["OldOS"]) == 0)
                    {
                        inv.OldOS = "Windows 8 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 1)
                    {
                        inv.OldOS = "Windows 7 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 2)
                    {
                        inv.OldOS = "Windows 7 Home Prem";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 3)
                    {
                        inv.OldOS = "Windows Vista Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 4)
                    {
                        inv.OldOS = "Windows Vista Home";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 5)
                    {
                        inv.OldOS = "No registered OS";
                    }
                    inv.OldCOA = Convert.ToString(dbReader["OldCOA"]);
                    inv.DateBuilt = Convert.ToDateTime(dbReader["DateBuilt"]);
                    inv.MarCreated = dbReader["MarCreated"] == DBNull.Value ? null : (DateTime?)dbReader["MarCreated"];
                    inv.NewCOA = Convert.ToString(dbReader["NewCOA"] == DBNull.Value ? null : dbReader["NewCOA"]);
                    if (Convert.ToInt32(dbReader["PCStatus"]) == 0)
                    {
                        inv.PCStatus = "Claimed/Given-Out";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 1)
                    {
                        inv.PCStatus = "In Storage";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 2)
                    {
                        inv.PCStatus = "Deployed to DI Downtown";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 3)
                    {
                        inv.PCStatus = "Busted-Recycling";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 4)
                    {
                        inv.PCStatus = "Unable to Locate Unit";
                    }
                    inv.Details = Convert.ToString(dbReader["Details"] == DBNull.Value ? null : dbReader["Details"]);
                    inv.Recipient = Convert.ToString(dbReader["Recipient"] == DBNull.Value ? null : dbReader["Recipient"]);


                    inventory.Add(inv);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                dbConn.Close();
            }
            return inventory;
        }

        // Get Claimed inventories to a list
        public static List<Inventory> GetClaimedInventories()
        {
            List<Inventory> inventory = new List<Inventory>();//set up a list
            SqlConnection dbConn = DBConnection.GetConnection(); //get database connection
            string sql =
                "SELECT PCPickUpNo, PCType, Model, OldOS, OldCOA, " +
                "DateBuilt, MarCreated, NewCOA, PCStatus, Details, Recipient " +
                "FROM Inventory " +
                "WHERE PCStatus = 0 " +
                "ORDER BY PCPickUpNo";
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Inventory inv = new Inventory();
                    inv.PCPickUpNo = Convert.ToInt32(dbReader["PCPickUpNo"]);
                    inv.PCType = Convert.ToString(dbReader["PCType"]);
                    inv.Model = Convert.ToString(dbReader["Model"]);
                    if (Convert.ToInt32(dbReader["OldOS"]) == 0)
                    {
                        inv.OldOS = "Windows 8 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 1)
                    {
                        inv.OldOS = "Windows 7 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 2)
                    {
                        inv.OldOS = "Windows 7 Home Prem";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 3)
                    {
                        inv.OldOS = "Windows Vista Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 4)
                    {
                        inv.OldOS = "Windows Vista Home";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 5)
                    {
                        inv.OldOS = "No registered OS";
                    }
                    inv.OldCOA = Convert.ToString(dbReader["OldCOA"]);
                    inv.DateBuilt = Convert.ToDateTime(dbReader["DateBuilt"]);
                    inv.MarCreated = dbReader["MarCreated"] == DBNull.Value ? null : (DateTime?)dbReader["MarCreated"];
                    inv.NewCOA = Convert.ToString(dbReader["NewCOA"] == DBNull.Value ? null : dbReader["NewCOA"]);
                    if (Convert.ToInt32(dbReader["PCStatus"]) == 0)
                    {
                        inv.PCStatus = "Claimed/Given-Out";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 1)
                    {
                        inv.PCStatus = "In Storage";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 2)
                    {
                        inv.PCStatus = "Deployed to DI Downtown";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 3)
                    {
                        inv.PCStatus = "Busted-Recycling";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 4)
                    {
                        inv.PCStatus = "Unable to Locate Unit";
                    }
                    inv.Details = Convert.ToString(dbReader["Details"] == DBNull.Value ? null : dbReader["Details"]);
                    inv.Recipient = Convert.ToString(dbReader["Recipient"] == DBNull.Value ? null : dbReader["Recipient"]);


                    inventory.Add(inv);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                dbConn.Close();
            }
            return inventory;
        }

        // Get DI inventories to a list
        public static List<Inventory> GetDIInventories()
        {
            List<Inventory> inventory = new List<Inventory>();//set up a list
            SqlConnection dbConn = DBConnection.GetConnection(); //get database connection
            string sql =
                "SELECT PCPickUpNo, PCType, Model, OldOS, OldCOA, " +
                "DateBuilt, MarCreated, NewCOA, PCStatus, Details, Recipient " +
                "FROM Inventory " +
                "WHERE PCStatus = 2 " +
                "ORDER BY PCPickUpNo";
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Inventory inv = new Inventory();
                    inv.PCPickUpNo = Convert.ToInt32(dbReader["PCPickUpNo"]);
                    inv.PCType = Convert.ToString(dbReader["PCType"]);
                    inv.Model = Convert.ToString(dbReader["Model"]);
                    if (Convert.ToInt32(dbReader["OldOS"]) == 0)
                    {
                        inv.OldOS = "Windows 8 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 1)
                    {
                        inv.OldOS = "Windows 7 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 2)
                    {
                        inv.OldOS = "Windows 7 Home Prem";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 3)
                    {
                        inv.OldOS = "Windows Vista Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 4)
                    {
                        inv.OldOS = "Windows Vista Home";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 5)
                    {
                        inv.OldOS = "No registered OS";
                    }
                    inv.OldCOA = Convert.ToString(dbReader["OldCOA"]);
                    inv.DateBuilt = Convert.ToDateTime(dbReader["DateBuilt"]);
                    inv.MarCreated = dbReader["MarCreated"] == DBNull.Value ? null : (DateTime?)dbReader["MarCreated"];
                    inv.NewCOA = Convert.ToString(dbReader["NewCOA"] == DBNull.Value ? null : dbReader["NewCOA"]);
                    if (Convert.ToInt32(dbReader["PCStatus"]) == 0)
                    {
                        inv.PCStatus = "Claimed/Given-Out";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 1)
                    {
                        inv.PCStatus = "In Storage";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 2)
                    {
                        inv.PCStatus = "Deployed to DI Downtown";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 3)
                    {
                        inv.PCStatus = "Busted-Recycling";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 4)
                    {
                        inv.PCStatus = "Unable to Locate Unit";
                    }
                    inv.Details = Convert.ToString(dbReader["Details"] == DBNull.Value ? null : dbReader["Details"]);
                    inv.Recipient = Convert.ToString(dbReader["Recipient"] == DBNull.Value ? null : dbReader["Recipient"]);


                    inventory.Add(inv);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                dbConn.Close();
            }
            return inventory;
        }

        // Get Busted inventories to a list
        public static List<Inventory> GetBustedInventories()
        {
            List<Inventory> inventory = new List<Inventory>();//set up a list
            SqlConnection dbConn = DBConnection.GetConnection(); //get database connection
            string sql =
                "SELECT PCPickUpNo, PCType, Model, OldOS, OldCOA, " +
                "DateBuilt, MarCreated, NewCOA, PCStatus, Details, Recipient " +
                "FROM Inventory " +
                "WHERE PCStatus = 3 " +
                "ORDER BY PCPickUpNo";
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Inventory inv = new Inventory();
                    inv.PCPickUpNo = Convert.ToInt32(dbReader["PCPickUpNo"]);
                    inv.PCType = Convert.ToString(dbReader["PCType"]);
                    inv.Model = Convert.ToString(dbReader["Model"]);
                    if (Convert.ToInt32(dbReader["OldOS"]) == 0)
                    {
                        inv.OldOS = "Windows 8 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 1)
                    {
                        inv.OldOS = "Windows 7 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 2)
                    {
                        inv.OldOS = "Windows 7 Home Prem";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 3)
                    {
                        inv.OldOS = "Windows Vista Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 4)
                    {
                        inv.OldOS = "Windows Vista Home";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 5)
                    {
                        inv.OldOS = "No registered OS";
                    }
                    inv.OldCOA = Convert.ToString(dbReader["OldCOA"]);
                    inv.DateBuilt = Convert.ToDateTime(dbReader["DateBuilt"]);
                    inv.MarCreated = dbReader["MarCreated"] == DBNull.Value ? null : (DateTime?)dbReader["MarCreated"];
                    inv.NewCOA = Convert.ToString(dbReader["NewCOA"] == DBNull.Value ? null : dbReader["NewCOA"]);
                    if (Convert.ToInt32(dbReader["PCStatus"]) == 0)
                    {
                        inv.PCStatus = "Claimed/Given-Out";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 1)
                    {
                        inv.PCStatus = "In Storage";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 2)
                    {
                        inv.PCStatus = "Deployed to DI Downtown";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 3)
                    {
                        inv.PCStatus = "Busted-Recycling";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 4)
                    {
                        inv.PCStatus = "Unable to Locate Unit";
                    }
                    inv.Details = Convert.ToString(dbReader["Details"] == DBNull.Value ? null : dbReader["Details"]);
                    inv.Recipient = Convert.ToString(dbReader["Recipient"] == DBNull.Value ? null : dbReader["Recipient"]);


                    inventory.Add(inv);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                dbConn.Close();
            }
            return inventory;
        }

        // Get Stored inventories to a list
        public static List<Inventory> GetNotWorkingInventories()
        {
            List<Inventory> inventory = new List<Inventory>();//set up a list
            SqlConnection dbConn = DBConnection.GetConnection(); //get database connection
            string sql =
                "SELECT PCPickUpNo, PCType, Model, OldOS, OldCOA, " +
                "DateBuilt, MarCreated, NewCOA, PCStatus, Details, Recipient " +
                "FROM Inventory " +
                "WHERE PCStatus = 4 " +
                "ORDER BY PCPickUpNo";
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Inventory inv = new Inventory();
                    inv.PCPickUpNo = Convert.ToInt32(dbReader["PCPickUpNo"]);
                    inv.PCType = Convert.ToString(dbReader["PCType"]);
                    inv.Model = Convert.ToString(dbReader["Model"]);
                    if (Convert.ToInt32(dbReader["OldOS"]) == 0)
                    {
                        inv.OldOS = "Windows 8 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 1)
                    {
                        inv.OldOS = "Windows 7 Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 2)
                    {
                        inv.OldOS = "Windows 7 Home Prem";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 3)
                    {
                        inv.OldOS = "Windows Vista Pro";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 4)
                    {
                        inv.OldOS = "Windows Vista Home";
                    }
                    else if (Convert.ToInt32(dbReader["OldOS"]) == 5)
                    {
                        inv.OldOS = "No registered OS";
                    }
                    inv.OldCOA = Convert.ToString(dbReader["OldCOA"]);
                    inv.DateBuilt = Convert.ToDateTime(dbReader["DateBuilt"]);
                    inv.MarCreated = dbReader["MarCreated"] == DBNull.Value ? null : (DateTime?)dbReader["MarCreated"];
                    inv.NewCOA = Convert.ToString(dbReader["NewCOA"] == DBNull.Value ? null : dbReader["NewCOA"]);
                    if (Convert.ToInt32(dbReader["PCStatus"]) == 0)
                    {
                        inv.PCStatus = "Claimed/Given-Out";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 1)
                    {
                        inv.PCStatus = "In Storage";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 2)
                    {
                        inv.PCStatus = "Deployed to DI Downtown";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 3)
                    {
                        inv.PCStatus = "Busted-Recycling";
                    }
                    else if (Convert.ToInt32(dbReader["PCStatus"]) == 4)
                    {
                        inv.PCStatus = "Unable to Locate Unit";
                    }
                    inv.Details = Convert.ToString(dbReader["Details"] == DBNull.Value ? null : dbReader["Details"]);
                    inv.Recipient = Convert.ToString(dbReader["Recipient"] == DBNull.Value ? null : dbReader["Recipient"]);


                    inventory.Add(inv);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                dbConn.Close();
            }
            return inventory;
        }

        // Delete the selected inventory by PC PickUp No
        public static void DeleteInventoryByID(int pid)
        {
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql = "DELETE FROM Inventory " +
                "Where PCPickUpNo = @PCPickUpNo ";
            SqlCommand cmdDelete = new SqlCommand(sql, dbConn);
            cmdDelete.Parameters.AddWithValue("@PCPickUpNo", pid);
            try
            {
                dbConn.Open();
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("PC Delete Successful");
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

        // Add a new inventory
        public static void InsertInventory(Inventory inventory)
        {
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                        "INSERT Inventory (PCPickUpNo, PCType, Model, OldOS, OldCOA, DateBuilt, " +
                                          "MarCreated, NewCOA, PCStatus, Details, Recipient)" +
                                "VALUES (@PCPickUpNo, @PCType, @Model, @OldOS, @OldCOA, @DateBuilt, " +
                                "@MarCreated, @NewCOA, @PCStatus, @Details, @Recipient);";

            SqlCommand cmdInsert = new SqlCommand(sql, dbConn);


            cmdInsert.Parameters.AddWithValue("@PCPickUpNo", inventory.PCPickUpNo);
            cmdInsert.Parameters.AddWithValue("@PCType", inventory.PCType);
            cmdInsert.Parameters.AddWithValue("@Model", inventory.Model);
            cmdInsert.Parameters.AddWithValue("@OldOS", inventory.OldOS);
            cmdInsert.Parameters.AddWithValue("@OldCOA", inventory.OldCOA);
            cmdInsert.Parameters.AddWithValue("@DateBuilt", inventory.DateBuilt);
            cmdInsert.Parameters.AddWithValue("@MarCreated", (object)inventory.MarCreated ?? DBNull.Value);
            cmdInsert.Parameters.AddWithValue("@NewCOA", (object)inventory.NewCOA ?? DBNull.Value);
            cmdInsert.Parameters.AddWithValue("@PCStatus", inventory.PCStatus);
            cmdInsert.Parameters.AddWithValue("@Details", (object)inventory.Details ?? DBNull.Value);
            cmdInsert.Parameters.AddWithValue("@Recipient", (object)inventory.Recipient ?? DBNull.Value);
            try
            {
                dbConn.Open();
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("New inventory created successful");
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

        // Get the inventory by PC PickUp No
        public static Inventory GetInventoryByID(int invId)
        {
            Inventory inv = new Inventory();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
               "SELECT PCPickUpNo, PCType, Model, OldOS, OldCOA, " +
                    "DateBuilt, MarCreated, NewCOA, PCStatus, Details, Recipient " +
                "FROM Inventory " +
                "WHERE PCPickUpNo = @PCPickUpNo";
            SqlCommand cmd = new SqlCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@PCPickUpNo", invId);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    inv.PCPickUpNo = Convert.ToInt32(dbReader["PCPickUpNo"]);
                    inv.PCType = Convert.ToString(dbReader["PCType"]);
                    inv.Model = Convert.ToString(dbReader["Model"]);
                    inv.OldOS = Convert.ToString(dbReader["OldOS"]);
                    inv.OldCOA = Convert.ToString(dbReader["OldCOA"]);
                    inv.DateBuilt = Convert.ToDateTime(dbReader["DateBuilt"]);
                    inv.MarCreated = dbReader["MarCreated"] == DBNull.Value ? null : (DateTime?)dbReader["MarCreated"];
                    inv.NewCOA = Convert.ToString(dbReader["NewCOA"] == DBNull.Value ? null : dbReader["NewCOA"]);
                    inv.PCStatus = Convert.ToString(dbReader["PCStatus"]);
                    inv.Details = Convert.ToString(dbReader["Details"] == DBNull.Value ? null : dbReader["Details"]);
                    inv.Recipient = Convert.ToString(dbReader["Recipient"] == DBNull.Value ? null : dbReader["Recipient"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                dbConn.Close();
            }
            return inv;
        }

        // Update inventory
        public static void UpdateInventory(Inventory newi, Inventory oldi)
        {
            SqlConnection dbConn = DBConnection.GetConnection();

            string sql =
                         "UPDATE Inventory " +
                             "SET PCType = @nPCType, " +
                                 "Model = @nModel, " +
                                 "OldOS = @nOldOS, " +
                                 "OldCOA = @nOldCOA, " +
                                 "DateBuilt = @nDateBuilt, " +
                                 "MarCreated = @nMarCreated, " +
                                 "NewCOA = @nNewCOA, " +
                                 "PCStatus = @nPCStatus, " +
                                 "Details = @nDetails, " +
                                 "Recipient = @nRecipient " +
                             "WHERE PCPickUpNo = @PCPickUpNo";
            SqlCommand cmdUpdate = new SqlCommand(sql, dbConn);
            cmdUpdate.Parameters.AddWithValue("nPCType", newi.PCType);
            cmdUpdate.Parameters.AddWithValue("nModel", newi.Model);
            cmdUpdate.Parameters.AddWithValue("nOldOS", newi.OldOS);
            cmdUpdate.Parameters.AddWithValue("nOldCOA", newi.OldCOA);
            cmdUpdate.Parameters.AddWithValue("nDateBuilt", newi.DateBuilt);
            cmdUpdate.Parameters.AddWithValue("nMarCreated", (object)newi.MarCreated ?? DBNull.Value);
            cmdUpdate.Parameters.AddWithValue("nNewCOA", (object)newi.NewCOA ?? DBNull.Value);
            cmdUpdate.Parameters.AddWithValue("nPCStatus", newi.PCStatus);
            cmdUpdate.Parameters.AddWithValue("nDetails", (object)newi.Details ?? DBNull.Value);
            cmdUpdate.Parameters.AddWithValue("nRecipient", (object)newi.Recipient ?? DBNull.Value);

            cmdUpdate.Parameters.AddWithValue("PCPickUpNo", oldi.PCPickUpNo);
            try
            {
                dbConn.Open();
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Update successful");
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
