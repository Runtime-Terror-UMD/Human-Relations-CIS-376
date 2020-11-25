using System;
using System.Data;
using Human_Relations;
using MySql.Data.MySqlClient;

// class to manage creation and updates of leave requests

    public class leavemgmtclass
    {

    /*
     DESCRIPTION: creates leave request record in dbo.leavemgmt and adds to activity log table.
    Parameters: userID requesting leave, startDateTime of leave, endDateTime of leave
     */
        public bool requestLeave(int userID, DateTime startDateTime, DateTime endDateTime)
        {
            // SQL command to insert leave request record
            DBConnect reqLeaveConn = new DBConnect();
            MySqlCommand reqLeaveCmd = new MySqlCommand(@"INSERT INTO dbo.leavemgmt
                                                            (userID,
                                                            dateStart,
                                                            dateEnd,
                                                            approvalStatus,
                                                            created)
                                                            VALUES
                                                            (@userID,
                                                            @dateTimeStart,
                                                            @dateTimeEnd,
                                                            @approvalStatus,
                                                            @created);");
            reqLeaveCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            reqLeaveCmd.Parameters.Add("@dateTimeStart", MySqlDbType.Date).Value = startDateTime.Date;
            reqLeaveCmd.Parameters.Add("@dateTimeEnd", MySqlDbType.Date).Value = endDateTime.Date;
            reqLeaveCmd.Parameters.Add("approvalStatus", MySqlDbType.VarChar).Value = "Pending";
            reqLeaveCmd.Parameters.Add("@created", MySqlDbType.DateTime).Value = DateTime.Now;
            if (reqLeaveConn.NonQuery(reqLeaveCmd) > 0)
            {
                // get leaveID for logged activty record
                int leaveID = -1;
                DBConnect getLeaveIDConn = new DBConnect();
                MySqlCommand getLeaveIDCmd = new MySqlCommand(@"select leaveID
                                                                    from dbo.leavemgmt
                                                                    where userID = @userID
                                                                    order by created
                                                                    limit 1");
                getLeaveIDCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
                leaveID = getLeaveIDConn.intScalar(getLeaveIDCmd);


                // add record to activity log
                LoggedActivity logLeaveRequest = new LoggedActivity();
                logLeaveRequest.logActivity(18, userID, leaveID, DateTime.Now, userID);
            return true;
            }
        return false;
        }

    
    // DESCRIPTION:pulls report of specified employee's leave requests. Returns a datatable to be used on employee leave page
    
        public DataTable employeeLeaveHistory(int userID)
    {
        DBConnect leaveReportConn = new DBConnect();
        MySqlCommand leaveReportCmd = new MySqlCommand(@"SELECT
                                        DATE(dateStart) AS 'Start Date',
                                        DATE(dateEnd) AS 'End Date',
                                        approvalStatus AS 'Approval Status'
                                        FROM leavemgmt
                                        WHERE userID = @userID
                                        ORDER BY created desc");
        leaveReportCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
        DataTable reportData = leaveReportConn.ExecuteDataTable(leaveReportCmd);
        return reportData;
    }

    // DESCRIPTION: Gets accrued PTO hours of specified user
    public double getAccruedPTO(int userID)
    {
        DBConnect getPTOConn = new DBConnect();
        MySqlCommand getPTOCmd = new MySqlCommand(@"SELECT ptoTime
                                                        FROM dbo.user
                                                        where userID = @userID");
        getPTOCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
        double ptoHours = getPTOConn.doubleScalar(getPTOCmd);
        return ptoHours;
    }
    }
