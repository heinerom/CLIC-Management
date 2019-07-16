using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICDB
{
    public class ReportDB
    {
        // Get report with selected requested dates
        public static Report GetReport(DateTime from, DateTime to)
        {
            Report report = new Report();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                        "SELECT " +
                            "COUNT(CASE WHEN DateRequested >= '" + from + "' " +
                                "AND DateRequested < '" + to + "' then 1 else null end) AS Received, " +
                            "COUNT(CASE WHEN DateRequested >= '" + from + "' " + "AND DateRequested < '" +
                                to + "' AND CallStatus = '2' AND (Comments NOT LIKE 'Denied' OR Comments IS NULL) then 1 else null end) AS Claimed, " +
                            "COUNT(CASE WHEN DateRequested >= '" + from + "' AND DateRequested < '" + to + "' " +
                                "AND CallStatus = '2' AND RequestedItem = '0' AND (Comments NOT LIKE 'Denied' OR Comments IS NULL) then 1 else null end) AS ClaimedDesk, " +
                            "COUNT(CASE WHEN DateRequested >= '" + from + "' AND DateRequested < '" + to + "' " +
                                "AND CallStatus = '2' AND RequestedItem = '1' AND (Comments NOT LIKE 'Denied' OR Comments IS NULL) then 1 else null end) AS ClaimedLap, " +
                            "COUNT(CASE WHEN DateRequested >= '" + from + "' AND DateRequested < '" + to + "' " + 
                                 "AND CallStatus != '2' then 1 else null end) AS Unclaimed, " +
                            "COUNT(CASE WHEN DateRequested >= '" + from + "' AND DateRequested < '" + to + "' " +
                                "AND CallStatus != '2' AND RequestedItem = '0' then 1 else null end) AS UnclaimedDesk, " +
                            "COUNT(CASE WHEN DateRequested >= '" + from + "' AND DateRequested < '" + to + "' " +
                                "AND CallStatus != '2' AND RequestedItem = '1' then 1 else null end) AS UnclaimedLap, " +
                            "COUNT(CASE WHEN DateRequested >= '" + from + "' AND DateRequested < '" + to + "' " +
                                "AND CallStatus = '2' AND COMMENTS LIKE '%Denied%' then 1 else null end) AS Denied " +
                            "FROM ApplicationInfo " +
                            "LEFT OUTER JOIN ApplicationStatus " +
                            "ON ApplicationInfo.ApplicationId = ApplicationStatus.ApplicationId";
                        

            SqlCommand cmd = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    report.Received = Convert.ToInt32(dbReader["Received"]);
                    report.Claimed = Convert.ToInt32(dbReader["Claimed"]);
                    report.ClaimedDesk = Convert.ToInt32(dbReader["ClaimedDesk"]);
                    report.ClaimedLap = Convert.ToInt32(dbReader["ClaimedLap"]);
                    report.Unclaimed = Convert.ToInt32(dbReader["Unclaimed"]);
                    report.UnclaimedDesk = Convert.ToInt32(dbReader["UnclaimedDesk"]);
                    report.UnclaimedLap = Convert.ToInt32(dbReader["UnclaimedLap"]);
                    report.Denied = Convert.ToInt32(dbReader["Denied"]);
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
            return report;
        }

        // Get the number of the claimed computers on the pick up date
        public static Report GetClaimedOnPickUpDate(DateTime from, DateTime to)
        {
            Report report = new Report();
            SqlConnection dbConn = DBConnection.GetConnection();
            string sql =
                        "SELECT " +                            
                            "COUNT(CASE WHEN DatePickedUp >= '" + from + "' AND DatePickedUp < '" + to +
                                "' AND CallStatus = '2' AND (Comments NOT LIKE '%Denied%' OR Comments IS NULL) then 1 else null end) AS Claimed, " +
                            "COUNT(CASE WHEN DatePickedUp >= '" + from + "' AND DatePickedUp < '" + to + "' " +
                                "AND CallStatus = '2' AND RequestedItem = '0' AND (Comments NOT LIKE '%Denied%' OR Comments IS NULL) then 1 else null end) AS ClaimedDesk, " +
                            "COUNT(CASE WHEN DatePickedUp >= '" + from + "' AND DatePickedUp < '" + to + "' " +
                                "AND CallStatus = '2' AND RequestedItem = '1' AND (Comments NOT LIKE '%Denied%' OR Comments IS NULL) then 1 else null end) AS ClaimedLap " +                          
                            "FROM ApplicationInfo " +
                            "INNER JOIN ApplicationStatus " +
                            "ON ApplicationInfo.ApplicationId = ApplicationStatus.ApplicationId";


            SqlCommand cmd = new SqlCommand(sql, dbConn);
            try
            {
                dbConn.Open();
                SqlDataReader dbReader = cmd.ExecuteReader();
                while (dbReader.Read())
                {
                    report.Claimed = Convert.ToInt32(dbReader["Claimed"]);
                    report.ClaimedDesk = Convert.ToInt32(dbReader["ClaimedDesk"]);
                    report.ClaimedLap = Convert.ToInt32(dbReader["ClaimedLap"]);
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
            return report;
        }
    }
}
