using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICDB
{
    public class ApplicantInfoStatusDB
    {
        // Load the application info by ID
        public static ApplicantInfoStatus GetInfoStatusesByID(int aid)
        {
            ApplicantInfoStatus apis = new ApplicantInfoStatus();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
               "SELECT Apl.ApplicationId, Apl.DateRequested, Apl.FirstName, Apl.LastName, Apl.DateOfBirth, " +
                    "Apl.PrimaryPhone, Apl.SecondaryPhone, Apl.Email, Apl.AppAddress, Apl.PostalCode, Apl.FormerClient, " +
                    "Apl.LastVisit, Apl.NoOfChildren, Apl.CaseManager, Apl.Agency, Apl.RequestedItem, Apl.RequestedNote, " +
                    "Apl.CallStatus, Aps.Attempt1, Aps.Remarks1, Aps.Attempt2, Aps.Remarks2, Aps.Attempt3, Aps.Remarks3, " +
                    "Aps.ScheduledPickUp, Aps.DatePickedUp, Aps.PickUpNo, Aps.Comments " +
                "FROM ApplicationInfo Apl " +
                "LEFT OUTER JOIN ApplicationStatus Aps " +
                "ON Apl.ApplicationId = Aps.ApplicationId " +
                "WHERE Apl.ApplicationId = @ApplicationId " +
                "ORDER BY DateRequested";
            SqlCommand cmd = new SqlCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@ApplicationId", aid);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    apis.ApplicationId = Convert.ToInt32(dbReader["ApplicationId"]);
                    apis.DateRequested = Convert.ToDateTime(dbReader["DateRequested"]);
                    apis.FirstName = Convert.ToString(dbReader["FirstName"]);
                    apis.LastName = Convert.ToString(dbReader["LastName"]);
                    apis.DateOfBirth = dbReader["DateOfBirth"] == DBNull.Value ? null : (DateTime?)dbReader["DateOfBirth"];
                    apis.PrimaryPhone = Convert.ToString(dbReader["PrimaryPhone"]);
                    apis.SecondaryPhone = Convert.ToString(dbReader["SecondaryPhone"] == DBNull.Value ? null : dbReader["SecondaryPhone"]);
                    apis.Email = Convert.ToString(dbReader["Email"] == DBNull.Value ? null : dbReader["Email"]);
                    apis.AppAddress = Convert.ToString(dbReader["AppAddress"] == DBNull.Value ? null : dbReader["AppAddress"]);
                    apis.PostalCode = Convert.ToString(dbReader["PostalCode"] == DBNull.Value ? null : dbReader["PostalCode"]);
                    apis.FormerClient = Convert.ToString(dbReader["FormerClient"]);
                    apis.LastVisit = Convert.ToString(dbReader["LastVisit"]);
                    apis.NoOfChildren = Convert.ToInt32(dbReader["NoOfChildren"]);
                    apis.CaseManager = Convert.ToString(dbReader["CaseManager"] == DBNull.Value ? null : dbReader["CaseManager"]);
                    apis.Agency = Convert.ToString(dbReader["Agency"] == DBNull.Value ? null : dbReader["Agency"]);
                    apis.RequestedItem = Convert.ToString(dbReader["RequestedItem"]);
                    apis.RequestedNote = Convert.ToString(dbReader["RequestedNote"] == DBNull.Value ? null : dbReader["RequestedNote"]);
                    apis.CallStatus = Convert.ToString(dbReader["CallStatus"]);
                    apis.Attempt1 = dbReader["Attempt1"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt1"];
                    apis.Remarks1 = Convert.ToString(dbReader["Remarks1"] == DBNull.Value ? null : dbReader["Remarks1"]);
                    apis.Attempt2 = dbReader["Attempt2"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt2"];
                    apis.Remarks2 = Convert.ToString(dbReader["Remarks2"] == DBNull.Value ? null : dbReader["Remarks2"]);
                    apis.Attempt3 = dbReader["Attempt3"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt3"];
                    apis.Remarks3 = Convert.ToString(dbReader["Remarks3"] == DBNull.Value ? null : dbReader["Remarks3"]);
                    apis.ScheduledPickUp = dbReader["ScheduledPickUp"] == DBNull.Value ? null : (DateTime?)dbReader["ScheduledPickUp"];
                    apis.DatePickedUp = dbReader["DatePickedUp"] == DBNull.Value ? null : (DateTime?)dbReader["DatePickedUp"];
                    apis.PickUpNo = Convert.ToString(dbReader["PickUpNo"] == DBNull.Value ? null : dbReader["PickUpNo"]);
                    apis.Comments = Convert.ToString(dbReader["Comments"] == DBNull.Value ? null : dbReader["Comments"]);
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
            return apis;
        }

        // Test
        // To show the data in grid view tables
        public static List<ApplicantInfoStatus> GetAllTest()
        {
            List<ApplicantInfoStatus> appInfoS = new List<ApplicantInfoStatus>();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                "SELECT Apl.ApplicationId, Apl.DateRequested, Apl.FirstName, Apl.LastName, Apl.DateOfBirth, " +
                "Apl.PrimaryPhone, Apl.SecondaryPhone, Apl.Email, Apl.AppAddress, Apl.PostalCode, Apl.FormerClient, " +
                "Apl.LastVisit, Apl.NoOfChildren, Apl.CaseManager, Apl.Agency, Apl.RequestedItem, Apl.RequestedNote, " +
                "Apl.CallStatus, Aps.Attempt1, Aps.Remarks1, Aps.Attempt2, Aps.Remarks2, Aps.Attempt3, Aps.Remarks3, " +
                "Aps.ScheduledPickUp, Aps.DatePickedUp, Aps.PickUpNo, Aps.Comments " +
                "FROM ApplicationInfo Apl " +
                "LEFT OUTER JOIN ApplicationStatus Aps " +
                "ON Apl.ApplicationId = Aps.ApplicationId " +
                "ORDER BY DateRequested";

            SqlCommand cmd = new SqlCommand(sql, dbConn);
            //cmd.Parameters.AddWithValue("@Application", app.ApplicationId);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    ApplicantInfoStatus apis = new ApplicantInfoStatus();
                    apis.ApplicationId = Convert.ToInt32(dbReader["ApplicationId"]);
                    apis.DateRequested = Convert.ToDateTime(dbReader["DateRequested"]);
                    apis.FirstName = Convert.ToString(dbReader["FirstName"]);
                    apis.LastName = Convert.ToString(dbReader["LastName"]);
                    apis.Name = Convert.ToString(dbReader["FirstName"]) + " " + Convert.ToString(dbReader["LastName"]);
                    apis.DateOfBirth = Convert.ToDateTime(dbReader["DateOfBirth"] == DBNull.Value ? null : dbReader["DateOfBirth"]);
                    apis.PrimaryPhone = Convert.ToString(dbReader["PrimaryPhone"]);
                    apis.SecondaryPhone = Convert.ToString(dbReader["SecondaryPhone"]);
                    apis.Email = Convert.ToString(dbReader["Email"]);
                    apis.AppAddress = Convert.ToString(dbReader["AppAddress"]);
                    apis.PostalCode = Convert.ToString(dbReader["PostalCode"]);
                    apis.FormerClient = Convert.ToString(dbReader["FormerClient"]);
                    apis.LastVisit = Convert.ToString(dbReader["LastVisit"]);
                    apis.NoOfChildren = Convert.ToInt32(dbReader["NoOfChildren"]);
                    apis.CaseManager = Convert.ToString(dbReader["CaseManager"]);
                    apis.Agency = Convert.ToString(dbReader["Agency"]);
                    //apis.RequestedItem = Convert.ToString(dbReader["RequestedItem"]);
                    apis.RequestedNote = Convert.ToString(dbReader["RequestedNote"]);
                    //apis.CallStatus = Convert.ToString(dbReader["CallStatus"]);
                    apis.Attempt1 = dbReader["Attempt1"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt1"];
                    apis.Remarks1 = Convert.ToString(dbReader["Remarks1"] == DBNull.Value ? null : dbReader["Remarks1"]);
                    apis.Attempt2 = dbReader["Attempt2"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt2"];
                    apis.Remarks2 = Convert.ToString(dbReader["Remarks2"] == DBNull.Value ? null : dbReader["Remarks2"]);
                    apis.Attempt3 = dbReader["Attempt3"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt3"];
                    apis.Remarks3 = Convert.ToString(dbReader["Remarks3"] == DBNull.Value ? null : dbReader["Remarks3"]);
                    apis.ScheduledPickUp = dbReader["ScheduledPickUp"] == DBNull.Value ? null : (DateTime?)dbReader["ScheduledPickUp"];
                    apis.DatePickedUp = dbReader["DatePickedUp"] == DBNull.Value ? null : (DateTime?)dbReader["DatePickedUp"];
                    apis.PickUpNo = Convert.ToString(dbReader["PickUpNo"] == DBNull.Value ? null : dbReader["PickUpNo"]);
                    apis.Comments = Convert.ToString(dbReader["Comments"] == DBNull.Value ? null : dbReader["Comments"]);

                    if (Convert.ToInt32(dbReader["RequestedItem"]) == 0)
                    {
                        apis.RequestedItem = "Desktop";
                    }
                    else if (Convert.ToInt32(dbReader["RequestedItem"]) == 1)
                    {
                        apis.RequestedItem = "Laptop";
                    }
                    
                    if (Convert.ToInt32(dbReader["CallStatus"]) == 0)
                    {
                        apis.CallStatus = "Waiting";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 1)
                    {
                        apis.CallStatus = "Following-Up";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 2)
                    {
                        apis.CallStatus = "Closed";
                    }

                    appInfoS.Add(apis);
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
            return appInfoS;
        }

        public static List<ApplicantInfoStatus> GetClosedTest()
        {
            List<ApplicantInfoStatus> appInfoS = new List<ApplicantInfoStatus>();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                "SELECT Apl.ApplicationId, Apl.DateRequested, Apl.FirstName, Apl.LastName, Apl.DateOfBirth, " +
                "Apl.PrimaryPhone, Apl.SecondaryPhone, Apl.Email, Apl.AppAddress, Apl.PostalCode, Apl.FormerClient, " +
                "Apl.LastVisit, Apl.NoOfChildren, Apl.CaseManager, Apl.Agency, Apl.RequestedItem, Apl.RequestedNote, " +
                "Apl.CallStatus, Aps.Attempt1, Aps.Remarks1, Aps.Attempt2, Aps.Remarks2, Aps.Attempt3, Aps.Remarks3, " +
                "Aps.ScheduledPickUp, Aps.DatePickedUp, Aps.PickUpNo, Aps.Comments " +
                "FROM ApplicationInfo Apl " +
                "LEFT OUTER JOIN ApplicationStatus Aps " +
                "ON Apl.ApplicationId = Aps.ApplicationId " +
                "WHERE CallStatus = 2 " +
                "ORDER BY DateRequested";

            SqlCommand cmd = new SqlCommand(sql, dbConn);
            //cmd.Parameters.AddWithValue("@Application", app.ApplicationId);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    ApplicantInfoStatus apis = new ApplicantInfoStatus();
                    apis.ApplicationId = Convert.ToInt32(dbReader["ApplicationId"]);
                    apis.DateRequested = Convert.ToDateTime(dbReader["DateRequested"]);
                    apis.FirstName = Convert.ToString(dbReader["FirstName"]);
                    apis.LastName = Convert.ToString(dbReader["LastName"]);
                    apis.Name = Convert.ToString(dbReader["FirstName"]) + " " + Convert.ToString(dbReader["LastName"]);
                    apis.DateOfBirth = Convert.ToDateTime(dbReader["DateOfBirth"] == DBNull.Value ? null : dbReader["DateOfBirth"]);
                    apis.PrimaryPhone = Convert.ToString(dbReader["PrimaryPhone"]);
                    apis.SecondaryPhone = Convert.ToString(dbReader["SecondaryPhone"]);
                    apis.Email = Convert.ToString(dbReader["Email"]);
                    apis.AppAddress = Convert.ToString(dbReader["AppAddress"]);
                    apis.PostalCode = Convert.ToString(dbReader["PostalCode"]);
                    apis.FormerClient = Convert.ToString(dbReader["FormerClient"]);
                    apis.LastVisit = Convert.ToString(dbReader["LastVisit"]);
                    apis.NoOfChildren = Convert.ToInt32(dbReader["NoOfChildren"]);
                    apis.CaseManager = Convert.ToString(dbReader["CaseManager"]);
                    apis.Agency = Convert.ToString(dbReader["Agency"]);
                    //apis.RequestedItem = Convert.ToString(dbReader["RequestedItem"]);
                    apis.RequestedNote = Convert.ToString(dbReader["RequestedNote"]);
                    //apis.CallStatus = Convert.ToString(dbReader["CallStatus"]);
                    apis.Attempt1 = dbReader["Attempt1"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt1"];
                    apis.Remarks1 = Convert.ToString(dbReader["Remarks1"] == DBNull.Value ? null : dbReader["Remarks1"]);
                    apis.Attempt2 = dbReader["Attempt2"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt2"];
                    apis.Remarks2 = Convert.ToString(dbReader["Remarks2"] == DBNull.Value ? null : dbReader["Remarks2"]);
                    apis.Attempt3 = dbReader["Attempt3"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt3"];
                    apis.Remarks3 = Convert.ToString(dbReader["Remarks3"] == DBNull.Value ? null : dbReader["Remarks3"]);
                    apis.ScheduledPickUp = dbReader["ScheduledPickUp"] == DBNull.Value ? null : (DateTime?)dbReader["ScheduledPickUp"];
                    apis.DatePickedUp = dbReader["DatePickedUp"] == DBNull.Value ? null : (DateTime?)dbReader["DatePickedUp"];
                    apis.PickUpNo = Convert.ToString(dbReader["PickUpNo"] == DBNull.Value ? null : dbReader["PickUpNo"]);
                    apis.Comments = Convert.ToString(dbReader["Comments"] == DBNull.Value ? null : dbReader["Comments"]);

                    if (Convert.ToInt32(dbReader["RequestedItem"]) == 0)
                    {
                        apis.RequestedItem = "Desktop";
                    }
                    else if (Convert.ToInt32(dbReader["RequestedItem"]) == 1)
                    {
                        apis.RequestedItem = "Laptop";
                    }

                    if (Convert.ToInt32(dbReader["CallStatus"]) == 0)
                    {
                        apis.CallStatus = "Waiting";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 1)
                    {
                        apis.CallStatus = "Following-Up";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 2)
                    {
                        apis.CallStatus = "Closed";
                    }

                    appInfoS.Add(apis);
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
            return appInfoS;
        }

        // update the new data into the tables
        // insert into the status table if not exists
        public static void UpdateApplicant(ApplicantInfoStatus newa, ApplicantInfoStatus olda)
        {
            SqlConnection dbConn = DBConnection.GetConnection();

            string sql = "IF EXISTS(SELECT * FROM ApplicationStatus WHERE ApplicationId = @ApplicationId) " +
                            "UPDATE ApplicationStatus " +
                            "SET Attempt1 = @nAttempt1, " +
                            "Attempt2 = @nAttempt2, " +
                            "Attempt3 = @nAttempt3, " +
                            "Remarks1 = @nRemarks1, " +
                            "Remarks2 = @nRemarks2, " +
                            "Remarks3 = @nRemarks3, " +
                            "ScheduledPickUp = @nScheduledPickUp, " +
                            "DatePickedUp = @nDatePickedUp, " +
                            "PickUpNo = @nPickUpNo, " +
                            "Comments = @nComments " +
                            "WHERE ApplicationId = @ApplicationId " +
                         "ELSE " +
                            "INSERT INTO ApplicationStatus(ApplicationId, Attempt1, Attempt2, Attempt3, " +
                                                         "Remarks1, Remarks2, Remarks3, ScheduledPickUp, " +
                                                         "DatePickedUp, PickUpNo, Comments) " +
                            "VALUES(@ApplicationId, @nAttempt1, @nAttempt2, @nAttempt3, @nRemarks1, @nRemarks2, " +
                                    "@nRemarks3, @nScheduledPickUp, @nDatePickedUp, @nPickUpNo, @nComments) " +
                         "UPDATE ApplicationInfo " +
                         "SET DateRequested = @nDateRequested, " +
                         "FirstName = @nFirstName, " +
                         "LastName = @nLastName, " +
                         "DateOfBirth = @nDateOfBirth, " +
                         "PrimaryPhone = @nPrimaryPhone, " +
                         "SecondaryPhone = @nSecondaryPhone, " +
                         "Email = @nEmail, " +
                         "AppAddress = @nAppAddress, " +
                         "PostalCode = @nPostalCode, " +
                         "NoOfChildren = @nNoOfChildren, " +
                         "CaseManager = @nCaseManager, " +
                         "Agency = @nAgency, " +
                         "RequestedItem = @nRequestedItem, " +
                         "RequestedNote = @nRequestedNote, " +
                         "CallStatus = @nCallStatus " +                         
                         "WHERE ApplicationId = @ApplicationId";
            SqlCommand cmdUpdate = new SqlCommand(sql, dbConn);
            cmdUpdate.Parameters.AddWithValue("nDateRequested", newa.DateRequested);
            cmdUpdate.Parameters.AddWithValue("nFirstName", newa.FirstName);
            cmdUpdate.Parameters.AddWithValue("nLastName", newa.LastName);
            cmdUpdate.Parameters.AddWithValue("nDateOfBirth", (object)newa.DateOfBirth ?? DBNull.Value);
            cmdUpdate.Parameters.AddWithValue("nPrimaryPhone", newa.PrimaryPhone);
            cmdUpdate.Parameters.AddWithValue("nSecondaryPhone", newa.SecondaryPhone);
            cmdUpdate.Parameters.AddWithValue("nEmail", newa.Email);
            cmdUpdate.Parameters.AddWithValue("nAppAddress", newa.AppAddress);
            cmdUpdate.Parameters.AddWithValue("nPostalCode", newa.PostalCode);
            cmdUpdate.Parameters.AddWithValue("nNoOfChildren", newa.NoOfChildren);
            cmdUpdate.Parameters.AddWithValue("nCaseManager", newa.CaseManager);
            cmdUpdate.Parameters.AddWithValue("nAgency", newa.Agency);
            cmdUpdate.Parameters.AddWithValue("nRequestedItem", newa.RequestedItem);
            cmdUpdate.Parameters.AddWithValue("nRequestedNote", newa.RequestedNote);
            cmdUpdate.Parameters.AddWithValue("nCallStatus", newa.CallStatus);
            cmdUpdate.Parameters.AddWithValue("nAttempt1", (object)newa.Attempt1 ?? DBNull.Value);
            cmdUpdate.Parameters.AddWithValue("nAttempt2", (object)newa.Attempt2 ?? DBNull.Value);
            cmdUpdate.Parameters.AddWithValue("nAttempt3", (object)newa.Attempt3 ?? DBNull.Value);
            cmdUpdate.Parameters.AddWithValue("nRemarks1", newa.Remarks1);
            cmdUpdate.Parameters.AddWithValue("nRemarks2", newa.Remarks2);
            cmdUpdate.Parameters.AddWithValue("nRemarks3", newa.Remarks3);
            cmdUpdate.Parameters.AddWithValue("nScheduledPickUp", (object)newa.ScheduledPickUp ?? DBNull.Value);
            cmdUpdate.Parameters.AddWithValue("nDatePickedUp", (object)newa.DatePickedUp ?? DBNull.Value);
            cmdUpdate.Parameters.AddWithValue("nPickUpNo", newa.PickUpNo);
            cmdUpdate.Parameters.AddWithValue("nComments", newa.Comments);

            cmdUpdate.Parameters.AddWithValue("ApplicationId", olda.ApplicationId);
            try
            {
                dbConn.Open();
                cmdUpdate.ExecuteNonQuery();

                MessageBox.Show("Update successful");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                dbConn.Close();
            }
        }

        // Delete application
        public static void DeleteApplicationByID(int aid)
        {
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql = "DELETE FROM ApplicationInfo " +
                "Where ApplicationId = @ApplicationId " +
                "DELETE FROM ApplicationStatus " +
                "Where ApplicationId = @ApplicationId";
            SqlCommand cmdDelete = new SqlCommand(sql, dbConn);
            cmdDelete.Parameters.AddWithValue("@ApplicationId", aid);
            try
            {
                dbConn.Open();
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Application Delete Successful");
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

        // Show the applicants who gonna come to pick up the desktop
        public static List<ApplicantInfoStatus> GetApplicantScheduled()
        {
            List<ApplicantInfoStatus> appInfoS = new List<ApplicantInfoStatus>();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                "SELECT Apl.ApplicationId, Apl.DateRequested, Apl.FirstName, Apl.LastName, Apl.DateOfBirth, " +
                "Apl.PrimaryPhone, Apl.SecondaryPhone, Apl.Email, Apl.AppAddress, Apl.PostalCode, Apl.FormerClient, " +
                "Apl.LastVisit, Apl.NoOfChildren, Apl.CaseManager, Apl.Agency, Apl.RequestedItem, Apl.RequestedNote, " +
                "Apl.CallStatus, Aps.Attempt1, Aps.Remarks1, Aps.Attempt2, Aps.Remarks2, Aps.Attempt3, Aps.Remarks3, " +
                "Aps.ScheduledPickUp, Aps.DatePickedUp, Aps.PickUpNo, Aps.Comments " +
                "FROM ApplicationInfo Apl " +
                "LEFT OUTER JOIN ApplicationStatus Aps " +
                "ON Apl.ApplicationId = Aps.ApplicationId " +
                "WHERE Aps.ScheduledPickUp >= getdate() " +
                "ORDER BY DateRequested";

            SqlCommand cmd = new SqlCommand(sql, dbConn);
            //cmd.Parameters.AddWithValue("@Application", app.ApplicationId);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    ApplicantInfoStatus apis = new ApplicantInfoStatus();

                    apis.ApplicationId = Convert.ToInt32(dbReader["ApplicationId"]);
                    apis.DateRequested = Convert.ToDateTime(dbReader["DateRequested"]);
                    apis.FirstName = Convert.ToString(dbReader["FirstName"]);
                    apis.LastName = Convert.ToString(dbReader["LastName"]);
                    apis.Name = Convert.ToString(dbReader["FirstName"]) + " " + Convert.ToString(dbReader["LastName"]);
                    apis.DateOfBirth = Convert.ToDateTime(dbReader["DateOfBirth"] == DBNull.Value ? null : dbReader["DateOfBirth"]);
                    apis.PrimaryPhone = Convert.ToString(dbReader["PrimaryPhone"]);
                    apis.SecondaryPhone = Convert.ToString(dbReader["SecondaryPhone"]);
                    apis.Email = Convert.ToString(dbReader["Email"]);
                    apis.AppAddress = Convert.ToString(dbReader["AppAddress"]);
                    apis.PostalCode = Convert.ToString(dbReader["PostalCode"]);
                    apis.FormerClient = Convert.ToString(dbReader["FormerClient"]);
                    apis.LastVisit = Convert.ToString(dbReader["LastVisit"]);
                    apis.NoOfChildren = Convert.ToInt32(dbReader["NoOfChildren"]);
                    apis.CaseManager = Convert.ToString(dbReader["CaseManager"]);
                    apis.Agency = Convert.ToString(dbReader["Agency"]);
                    apis.RequestedNote = Convert.ToString(dbReader["RequestedNote"]);
                    apis.Attempt1 = dbReader["Attempt1"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt1"];
                    apis.Remarks1 = Convert.ToString(dbReader["Remarks1"] == DBNull.Value ? null : dbReader["Remarks1"]);
                    apis.Attempt2 = dbReader["Attempt2"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt2"];
                    apis.Remarks2 = Convert.ToString(dbReader["Remarks2"] == DBNull.Value ? null : dbReader["Remarks2"]);
                    apis.Attempt3 = dbReader["Attempt3"] == DBNull.Value ? null : (DateTime?)dbReader["Attempt3"];
                    apis.Remarks3 = Convert.ToString(dbReader["Remarks3"] == DBNull.Value ? null : dbReader["Remarks3"]);
                    apis.ScheduledPickUp = dbReader["ScheduledPickUp"] == DBNull.Value ? null : (DateTime?)dbReader["ScheduledPickUp"];
                    apis.DatePickedUp = dbReader["DatePickedUp"] == DBNull.Value ? null : (DateTime?)dbReader["DatePickedUp"];
                    apis.PickUpNo = Convert.ToString(dbReader["PickUpNo"] == DBNull.Value ? null : dbReader["PickUpNo"]);
                    apis.Comments = Convert.ToString(dbReader["Comments"] == DBNull.Value ? null : dbReader["Comments"]);

                    if (Convert.ToInt32(dbReader["RequestedItem"]) == 0)
                    {
                        apis.RequestedItem = "Desktop";
                    }
                    else if (Convert.ToInt32(dbReader["RequestedItem"]) == 1)
                    {
                        apis.RequestedItem = "Laptop";
                    }

                    if (Convert.ToInt32(dbReader["CallStatus"]) == 0)
                    {
                        apis.CallStatus = "Waiting";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 1)
                    {
                        apis.CallStatus = "Following-Up";
                    }
                    else if (Convert.ToInt32(dbReader["CallStatus"]) == 2)
                    {
                        apis.CallStatus = "Closed";
                    }
                    appInfoS.Add(apis);
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
            return appInfoS;
        }
    }
}