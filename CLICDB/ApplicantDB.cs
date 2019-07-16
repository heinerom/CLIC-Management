using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICDB
{
    public class ApplicantDB
    {
        // Load all applications
          public static List<Applicant> GetAllApplicants()
        {
            List<Applicant> applications = new List<Applicant>();//set up a list
            SqlConnection dbConn = DBConnection.GetConnection(); //get database connection
            string sql =
                "SELECT ApplicationId, DateRequested, FirstName, LastName, DateOfBirth, " +
                "PrimaryPhone, SecondaryPhone, Email, AppAddress, PostalCode, FormerClient, " +
                "LastVisit, NoOfChildren, CaseManager, Agency, RequestedItem, RequestedNote, CallStatus " +
                "FROM ApplicationInfo " +
                "ORDER BY DateRequested"; 
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Applicant application = new Applicant();

                    application.ApplicationId = Convert.ToInt32(dbReader["ApplicationId"]);
                    application.DateRequested = Convert.ToDateTime(dbReader["DateRequested"]);
                    application.FirstName = Convert.ToString(dbReader["FirstName"]);
                    application.LastName = Convert.ToString(dbReader["LastName"]);
                    application.Name = Convert.ToString(dbReader["FirstName"]) + " " + Convert.ToString(dbReader["LastName"]);
                    //application.DateOfBirth = Convert.ToDateTime(dbReader["DateOfBirth"] == DBNull.Value ? null : dbReader["DateOfBirth"]);
                    application.DateOfBirth = dbReader["DateOfBirth"] == DBNull.Value ? null : (DateTime?)dbReader["DateOfBirth"];
                    application.PrimaryPhone = Convert.ToString(dbReader["PrimaryPhone"]);
                    application.SecondaryPhone = Convert.ToString(dbReader["SecondaryPhone"] == DBNull.Value ? null : dbReader["SecondaryPhone"]);
                    application.Email = Convert.ToString(dbReader["Email"] == DBNull.Value ? null : dbReader["Email"]);
                    application.AppAddress = Convert.ToString(dbReader["AppAddress"] == DBNull.Value ? null : dbReader["AppAddress"]);
                    application.PostalCode = Convert.ToString(dbReader["PostalCode"] == DBNull.Value ? null : dbReader["PostalCode"]);
                    application.FormerClient = Convert.ToString(dbReader["FormerClient"]);
                    application.LastVisit = Convert.ToString(dbReader["LastVisit"]);
                    application.NoOfChildren = Convert.ToInt32(dbReader["NoOfChildren"]);
                    application.CaseManager = Convert.ToString(dbReader["CaseManager"] == DBNull.Value ? null : dbReader["CaseManager"]);
                    application.Agency = Convert.ToString(dbReader["Agency"] == DBNull.Value ? null : dbReader["Agency"]);
                    //application.RequestedItem = Convert.ToString(dbReader["RequestedItem"]);

                    if (Convert.ToInt32(dbReader["RequestedItem"]) == 0)
                    {
                        application.RequestedItem = "Desktop";
                    }
                    else if (Convert.ToInt32(dbReader["RequestedItem"]) == 1)
                    {
                        application.RequestedItem = "Laptop";
                    }

                    application.RequestedNote = Convert.ToString(dbReader["RequestedNote"] == DBNull.Value ? null : dbReader["RequestedNote"]);

                    if (Convert.ToInt32(dbReader["CallStatus"]) == 0)
                    {
                        application.CallStatus = "Waiting";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 1)
                    {
                        application.CallStatus = "Following-Up";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 2)
                    {
                        application.CallStatus = "Closed";
                    }

                    applications.Add(application);
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
            return applications;
        }

        // Add a new application
        public static int id;
        public static void InsertApplicant(Applicant Applicant)
        {
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql = 
                "IF EXISTS(SELECT * FROM ApplicationInfo " +
                    "WHERE FirstName = @FirstName AND LastName = @LastName ) " +
                    "SELECT ApplicationId FROM ApplicationInfo " +
                    "WHERE FirstName = @FirstName AND LastName = @LastName " +
                "ELSE " +
                "INSERT ApplicationInfo (" +
                               "DateRequested," +
                               "FirstName," +
                               "LastName," +
                               "DateOfBirth," +
                               "PrimaryPhone," +
                               "SecondaryPhone," +
                               "Email," +
                               "AppAddress," +
                               "PostalCode," +
                               "FormerClient," +
                               "LastVisit," +
                               "NoOfChildren," +
                               "CaseManager," +
                               "Agency," +
                               "RequestedItem," +
                               "RequestedNote," +
                               "CallStatus)" +
                        "VALUES (" +
                               "@DateRequested," +
                               "@FirstName," +
                               "@LastName," +
                               "@DateOfBirth," +
                               "@PrimaryPhone," +
                               "@SecondaryPhone," +
                               "@Email," +
                               "@AppAddress," +
                               "@PostalCode," +
                               "@FormerClient," +
                               "@LastVisit," +
                               "@NoOfChildren," +
                               "@CaseManager," +
                               "@Agency," +
                               "@RequestedItem," +
                               "@RequestedNote," +
                               "@CallStatus);";

            SqlCommand cmdInsert = new SqlCommand(sql, dbConn);
           

            cmdInsert.Parameters.AddWithValue("@DateRequested", Applicant.DateRequested);
            cmdInsert.Parameters.AddWithValue("@FirstName", Applicant.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", Applicant.LastName);
            cmdInsert.Parameters.AddWithValue("@DateOfBirth", (object)Applicant.DateOfBirth ?? DBNull.Value);
            cmdInsert.Parameters.AddWithValue("@PrimaryPhone", Applicant.PrimaryPhone);
            cmdInsert.Parameters.AddWithValue("@SecondaryPhone", Applicant.SecondaryPhone);
            cmdInsert.Parameters.AddWithValue("@Email", Applicant.Email);
            cmdInsert.Parameters.AddWithValue("@AppAddress", Applicant.AppAddress);
            cmdInsert.Parameters.AddWithValue("@PostalCode", Applicant.PostalCode);
            cmdInsert.Parameters.AddWithValue("@FormerClient", Applicant.FormerClient);
            cmdInsert.Parameters.AddWithValue("@LastVisit", Applicant.LastVisit);
            cmdInsert.Parameters.AddWithValue("@NoOfChildren", Applicant.NoOfChildren);
            cmdInsert.Parameters.AddWithValue("@CaseManager", Applicant.CaseManager);
            cmdInsert.Parameters.AddWithValue("@Agency", Applicant.Agency);
            cmdInsert.Parameters.AddWithValue("@RequestedItem", Applicant.RequestedItem);
            cmdInsert.Parameters.AddWithValue("@RequestedNote", Applicant.RequestedNote);
            cmdInsert.Parameters.AddWithValue("@CallStatus", Applicant.CallStatus);


            try
            {
                dbConn.Open();
                cmdInsert.ExecuteNonQuery();
                SqlDataReader dr = cmdInsert.ExecuteReader();

                while (dr.Read())
                {                    
                    id = Convert.ToInt32(dr["ApplicationId"]);                    
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
        }

        // Get the application id for check duplicat Applicants
        public static Applicant getId(int cid)
        {
            Applicant applicant = new Applicant();
            SqlConnection dbConn = DBConnection.GetConnection(); //get database connection
            string sql =
                "SELECT MAX(ApplicationId) as maxi FROM ApplicationInfo";
            SqlCommand cmdCheck = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdCheck.ExecuteReader();
                while (dbReader.Read())
                {
                    applicant.ApplicationId = Convert.ToInt32(dbReader["maxi"]);

                    if (cid == applicant.ApplicationId)
                    {

                    }
                    else if (cid != applicant.ApplicationId)
                    {
                        applicant.ApplicationId = 0;
                    }

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
            return applicant;
        }

        // Search the applicants
        public static List<Applicant> GetApplicantsByName(string n)
        {
            List<Applicant> applicants = new List<Applicant>();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                "EXEC sp_FindStringInTable " + "'%" + n + "%', 'dbo', 'ApplicationInfo'";

            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Applicant application = new Applicant();//make them readable adn set them in the list
                    application.ApplicationId = Convert.ToInt32(dbReader["ApplicationId"]);
                    application.DateRequested = Convert.ToDateTime(dbReader["DateRequested"]);
                    application.FirstName = Convert.ToString(dbReader["FirstName"]);
                    application.LastName = Convert.ToString(dbReader["LastName"]);
                    application.Name = Convert.ToString(dbReader["FirstName"]) + " " + Convert.ToString(dbReader["LastName"]);
                    application.DateOfBirth = Convert.ToDateTime(dbReader["DateOfBirth"] == DBNull.Value ? null : dbReader["DateOfBirth"]);
                    application.PrimaryPhone = Convert.ToString(dbReader["PrimaryPhone"]);
                    application.SecondaryPhone = Convert.ToString(dbReader["SecondaryPhone"] == DBNull.Value ? null : dbReader["SecondaryPhone"]);
                    application.Email = Convert.ToString(dbReader["Email"] == DBNull.Value ? null : dbReader["Email"]);
                    application.AppAddress = Convert.ToString(dbReader["AppAddress"] == DBNull.Value ? null : dbReader["AppAddress"]);
                    application.PostalCode = Convert.ToString(dbReader["PostalCode"] == DBNull.Value ? null : dbReader["PostalCode"]);
                    application.FormerClient = Convert.ToString(dbReader["FormerClient"]);
                    application.LastVisit = Convert.ToString(dbReader["LastVisit"]);
                    application.NoOfChildren = Convert.ToInt32(dbReader["NoOfChildren"]);
                    application.CaseManager = Convert.ToString(dbReader["CaseManager"] == DBNull.Value ? null : dbReader["CaseManager"]);
                    application.Agency = Convert.ToString(dbReader["Agency"] == DBNull.Value ? null : dbReader["Agency"]);
                    //application.RequestedItem = Convert.ToString(dbReader["RequestedItem"]);
                    if (Convert.ToInt32(dbReader["RequestedItem"]) == 0)
                    {
                        application.RequestedItem = "Desktop";
                    }
                    else if (Convert.ToInt32(dbReader["RequestedItem"]) == 1)
                    {
                        application.RequestedItem = "Laptop";
                    }
                    application.RequestedNote = Convert.ToString(dbReader["RequestedNote"]);
                    if (Convert.ToInt32(dbReader["CallStatus"]) == 0)
                    {
                        application.CallStatus = "Waiting";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 1)
                    {
                        application.CallStatus = "Following-Up";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 2)
                    {
                        application.CallStatus = "Closed";
                    }

                    applicants.Add(application);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbConn.Close();
            }
            return applicants;
        }

        // Get applicants in waiting
        public static List<Applicant> GetWaitingApplication()
        {
            List<Applicant> applicants = new List<Applicant>();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                        "SELECT ApplicationId, DateRequested, FirstName, LastName, DateOfBirth, " +
                        "PrimaryPhone, SecondaryPhone, Email, AppAddress, PostalCode, FormerClient, " +
                        "LastVisit, NoOfChildren, CaseManager, Agency, RequestedItem, RequestedNote, CallStatus " +
                        "FROM ApplicationInfo " +
                        "WHERE CallStatus = 0 " +
                        "ORDER BY DateRequested";
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Applicant application = new Applicant();//make them readable adn set them in the list
                    application.ApplicationId = Convert.ToInt32(dbReader["ApplicationId"]);
                    application.DateRequested = Convert.ToDateTime(dbReader["DateRequested"]);
                    application.FirstName = Convert.ToString(dbReader["FirstName"]);
                    application.LastName = Convert.ToString(dbReader["LastName"]);
                    application.Name = Convert.ToString(dbReader["FirstName"]) + " " + Convert.ToString(dbReader["LastName"]);
                    application.DateOfBirth = Convert.ToDateTime(dbReader["DateOfBirth"] == DBNull.Value ? null : dbReader["DateOfBirth"]);
                    application.PrimaryPhone = Convert.ToString(dbReader["PrimaryPhone"]);
                    application.SecondaryPhone = Convert.ToString(dbReader["SecondaryPhone"] == DBNull.Value ? null : dbReader["SecondaryPhone"]);
                    application.Email = Convert.ToString(dbReader["Email"] == DBNull.Value ? null : dbReader["Email"]);
                    application.AppAddress = Convert.ToString(dbReader["AppAddress"] == DBNull.Value ? null : dbReader["AppAddress"]);
                    application.PostalCode = Convert.ToString(dbReader["PostalCode"] == DBNull.Value ? null : dbReader["PostalCode"]);
                    application.FormerClient = Convert.ToString(dbReader["FormerClient"]);
                    application.LastVisit = Convert.ToString(dbReader["LastVisit"]);
                    application.NoOfChildren = Convert.ToInt32(dbReader["NoOfChildren"]);
                    application.CaseManager = Convert.ToString(dbReader["CaseManager"] == DBNull.Value ? null : dbReader["CaseManager"]);
                    application.Agency = Convert.ToString(dbReader["Agency"] == DBNull.Value ? null : dbReader["Agency"]);
                    //application.RequestedItem = Convert.ToString(dbReader["RequestedItem"]);
                    if (Convert.ToInt32(dbReader["RequestedItem"]) == 0)
                    {
                        application.RequestedItem = "Desktop";
                    }
                    else if (Convert.ToInt32(dbReader["RequestedItem"]) == 1)
                    {
                        application.RequestedItem = "Laptop";
                    }
                    application.RequestedNote = Convert.ToString(dbReader["RequestedNote"]);
                    if (Convert.ToInt32(dbReader["CallStatus"]) == 0)
                    {
                        application.CallStatus = "Waiting";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 1)
                    {
                        application.CallStatus = "Following-Up";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 2)
                    {
                        application.CallStatus = "Closed";
                    }

                    applicants.Add(application);
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
            return applicants;            
        }

        // Get the applicants following up
        public static List<Applicant> GetFollowingUpApplication()
        {
            List<Applicant> applicants = new List<Applicant>();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                        "SELECT ApplicationId, DateRequested, FirstName, LastName, DateOfBirth, " +
                        "PrimaryPhone, SecondaryPhone, Email, AppAddress, PostalCode, FormerClient, " +
                        "LastVisit, NoOfChildren, CaseManager, Agency, RequestedItem, RequestedNote, CallStatus " +
                        "FROM ApplicationInfo " +
                        "WHERE CallStatus = 1 " +
                        "ORDER BY DateRequested";
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Applicant application = new Applicant();//make them readable adn set them in the list
                    application.ApplicationId = Convert.ToInt32(dbReader["ApplicationId"]);
                    application.DateRequested = Convert.ToDateTime(dbReader["DateRequested"]);
                    application.FirstName = Convert.ToString(dbReader["FirstName"]);
                    application.LastName = Convert.ToString(dbReader["LastName"]);
                    application.Name = Convert.ToString(dbReader["FirstName"]) + " " + Convert.ToString(dbReader["LastName"]);
                    application.DateOfBirth = Convert.ToDateTime(dbReader["DateOfBirth"] == DBNull.Value ? null : (DateTime?)dbReader["DateOfBirth"]);
                    application.PrimaryPhone = Convert.ToString(dbReader["PrimaryPhone"]);
                    application.SecondaryPhone = Convert.ToString(dbReader["SecondaryPhone"] == DBNull.Value ? null : dbReader["SecondaryPhone"]);
                    application.Email = Convert.ToString(dbReader["Email"] == DBNull.Value ? null : dbReader["Email"]);
                    application.AppAddress = Convert.ToString(dbReader["AppAddress"] == DBNull.Value ? null : dbReader["AppAddress"]);
                    application.PostalCode = Convert.ToString(dbReader["PostalCode"] == DBNull.Value ? null : dbReader["PostalCode"]);
                    application.FormerClient = Convert.ToString(dbReader["FormerClient"]);
                    application.LastVisit = Convert.ToString(dbReader["LastVisit"]);
                    application.NoOfChildren = Convert.ToInt32(dbReader["NoOfChildren"]);
                    application.CaseManager = Convert.ToString(dbReader["CaseManager"] == DBNull.Value ? null : dbReader["CaseManager"]);
                    application.Agency = Convert.ToString(dbReader["Agency"] == DBNull.Value ? null : dbReader["Agency"]);
                    //application.RequestedItem = Convert.ToString(dbReader["RequestedItem"]);
                    if (Convert.ToInt32(dbReader["RequestedItem"]) == 0)
                    {
                        application.RequestedItem = "Desktop";
                    }
                    else if (Convert.ToInt32(dbReader["RequestedItem"]) == 1)
                    {
                        application.RequestedItem = "Laptop";
                    }
                    application.RequestedNote = Convert.ToString(dbReader["RequestedNote"] == DBNull.Value ? null : dbReader["RequestedNote"]);
                    if (Convert.ToInt32(dbReader["CallStatus"]) == 0)
                    {
                        application.CallStatus = "Waiting";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 1)
                    {
                        application.CallStatus = "Following-Up";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 2)
                    {
                        application.CallStatus = "Closed";
                    }

                    applicants.Add(application);
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
            return applicants;
        }

        // Get the closed applications
        public static List<Applicant> GetClosedApplication()
        {
            List<Applicant> applicants = new List<Applicant>();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                        "SELECT ApplicationId, DateRequested, FirstName, LastName, DateOfBirth, " +
                        "PrimaryPhone, SecondaryPhone, Email, AppAddress, PostalCode, FormerClient, " +
                        "LastVisit, NoOfChildren, CaseManager, Agency, RequestedItem, RequestedNote, CallStatus " +
                        "FROM ApplicationInfo " +
                        "WHERE CallStatus = 2 " +
                        "ORDER BY DateRequested";
            SqlCommand cmdSelect = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmdSelect.ExecuteReader();
                while (dbReader.Read())
                {
                    Applicant application = new Applicant();//make them readable adn set them in the list
                    application.ApplicationId = Convert.ToInt32(dbReader["ApplicationId"]);
                    application.DateRequested = Convert.ToDateTime(dbReader["DateRequested"]);
                    application.FirstName = Convert.ToString(dbReader["FirstName"]);
                    application.LastName = Convert.ToString(dbReader["LastName"]);
                    application.Name = Convert.ToString(dbReader["FirstName"]) + " " + Convert.ToString(dbReader["LastName"]);
                    application.DateOfBirth = Convert.ToDateTime(dbReader["DateOfBirth"] == DBNull.Value ? null : dbReader["DateOfBirth"]);
                    application.PrimaryPhone = Convert.ToString(dbReader["PrimaryPhone"]);
                    application.SecondaryPhone = Convert.ToString(dbReader["SecondaryPhone"] == DBNull.Value ? null : dbReader["SecondaryPhone"]);
                    application.Email = Convert.ToString(dbReader["Email"] == DBNull.Value ? null : dbReader["Email"]);
                    application.AppAddress = Convert.ToString(dbReader["AppAddress"] == DBNull.Value ? null : dbReader["AppAddress"]);
                    application.PostalCode = Convert.ToString(dbReader["PostalCode"] == DBNull.Value ? null : dbReader["PostalCode"]);
                    application.FormerClient = Convert.ToString(dbReader["FormerClient"]);
                    application.LastVisit = Convert.ToString(dbReader["LastVisit"]);
                    application.NoOfChildren = Convert.ToInt32(dbReader["NoOfChildren"]);
                    application.CaseManager = Convert.ToString(dbReader["CaseManager"] == DBNull.Value ? null : dbReader["CaseManager"]);
                    application.Agency = Convert.ToString(dbReader["Agency"] == DBNull.Value ? null : dbReader["Agency"]);

                    if (Convert.ToInt32(dbReader["RequestedItem"]) == 0)
                    {
                        application.RequestedItem = "Desktop";
                    }
                    else if (Convert.ToInt32(dbReader["RequestedItem"]) == 1)
                    {
                        application.RequestedItem = "Laptop";
                    }
                    application.RequestedNote = Convert.ToString(dbReader["RequestedNote"]);
                    if (Convert.ToInt32(dbReader["CallStatus"]) == 0)
                    {
                        application.CallStatus = "Waiting";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 1)
                    {
                        application.CallStatus = "Following-Up";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 2)
                    {
                        application.CallStatus = "Closed";
                    }

                    applicants.Add(application);
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
            return applicants;
        }  
    }
}
