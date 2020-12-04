using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Relations.Utilities_Classes
{
    class timetracking
    {
        public bool clockIn(int UserID)
        {
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            
            payroll getPayPeriodID = new payroll();
            int payPeriodID = getPayPeriodID.getPayPeriod(month, day);

            MySqlCommand cmd = new MySqlCommand(@"INSERT INTO dbo.timetracking(userID,payPeriodID,inDateTime,shifton)VALUES(@userID,@payPeriodID,@inDateTime,@shifton)");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = UserID;
            cmd.Parameters.Add("@payPeriodID", MySqlDbType.Int32).Value = payPeriodID;
            cmd.Parameters.Add("@inDateTime", MySqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@shifton", MySqlDbType.Bit).Value = 1;
            DBConnect clockInConn = new DBConnect();

            // execute statement
            if (clockInConn.NonQuery(cmd) > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

// DESCRIPTION: clocks user out, adds clock-out to activity log
        public int clockOut(int UserID)
        {
            int logID = -1;
            // connect to database
        DBConnect clockOutConn = new DBConnect();

        // get logID of shift to pass to payroll calculation
        MySqlCommand getLogIDCmd = new MySqlCommand(@"SELECT logID 
                                                        FROM dbo.timetracking
                                                        WHERE userID = @userID
                                                        and shifton = 1;");
        getLogIDCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = UserID;
        logID = clockOutConn.intScalar(getLogIDCmd);

        if(logID != -1)
            {
                // clock user out
                MySqlCommand clockOutCmd = new MySqlCommand(@"UPDATE dbo.timetracking
                                                        SET outDateTime = @outDateTime,
                                                            shifton = 0
                                                        WHERE userID = @userID
                                                        AND shifton = 1; ");
                clockOutCmd.Parameters.Add("@outDateTime", MySqlDbType.DateTime).Value = DateTime.Now;
                clockOutCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = UserID;

                if (clockOutConn.NonQuery(clockOutCmd) > 0)
                {
                    // returns logID to be used in payroll calculation
                    return logID;
                }
                else
                {
                    return -1;

                }
            }
            else
            {
                // failed to retrieve logID, return -1;
                return -1;
            }      
        }
}
}
