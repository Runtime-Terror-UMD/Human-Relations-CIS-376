using System;
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
                                                            dateTimeStart,
                                                            dateTimeEnd,
                                                            approvalStatus,
                                                            created)
                                                            VALUES
                                                            (@userID,
                                                            @dateTimeStart,
                                                            @dateTimeEnd,
                                                            @approvalStatus,
                                                            @created);");
            reqLeaveCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            reqLeaveCmd.Parameters.Add("@dateTimeStart", MySqlDbType.DateTime).Value = startDateTime;
            reqLeaveCmd.Parameters.Add("@dateTimeEnd", MySqlDbType.DateTime).Value = endDateTime;
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
    }
