using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Relations.Utilities_Classes
{
    class payroll
    {
        public User userInfo;
 /*
 DESCRIPTION: Gets the payPeriodID of the specified month and day.
 PARAMETERS: month: integer value of month
             day: interger value of day
 */
        public int getPayPeriod(int month, int day) 
        {
            int payPeriodID;

            // SQL Query
            DBConnect payPeriodConn = new DBConnect();
            MySqlCommand cmd = new MySqlCommand(@"SELECT payPeriodID 
                                                FROM dbo.payperiods
                                                where monthno = @month
                                                and @day between startDate and endDate");
            
            // use month and day parameters in query
            cmd.Parameters.Add("@month", MySqlDbType.Int32).Value = month;
            cmd.Parameters.Add("@day", MySqlDbType.Int32).Value = day;
            payPeriodID = payPeriodConn.intScalar(cmd);
            
            // return current pay Period
            return payPeriodID;
        }

  /*
DESCRIPTION: Gets the total hours worked by a user in a given pay period
PARAMETERS: userID: user ID of user record to perform calculation on
            payPeriodID: pay period ID to make calculation for
*/
        public double getHoursWorkedInPeriod(int userID, int payPeriodID)
        {
            double totalHours;
            double totalMinutes;    //needed because SQL doesn't pull hours in decimal format

            DBConnect minutesInPeriodConn = new DBConnect();
            MySqlCommand minutesInPeriodCmd = new MySqlCommand(@"SELECT IFNULL(SUM(TIMESTAMPDIFF(minute, inDateTime, outDateTime)), 0)
                                                                from dbo.timetracking
                                                                where userID = @userID
                                                                and payPeriodID = @payPeriodID;");
            minutesInPeriodCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            minutesInPeriodCmd.Parameters.Add("@payPeriodID", MySqlDbType.Int32).Value = payPeriodID;

            // total minutes worked
            totalMinutes = minutesInPeriodConn.doubleScalar(minutesInPeriodCmd);

            // if no time worked
            if (totalMinutes == 0)
            { return 0; }
            else
            {
                totalHours = totalMinutes / 60;
                return totalHours;
            }
        }

 /*
 DESCRIPTION: Gets hours worked on specific shift
 PARAMETERS: userID: logID of shift to calculate for
 */
        public double hoursWorkedOnShift(int logID)
        {
            double minutesWorked; //needed because SQL doesn't pull hours in decimal format
            double hoursWorked;
            DBConnect minsWorkedOnShiftConn = new DBConnect();
            MySqlCommand minWorkedOnShiftCmd = new MySqlCommand(@"SELECT (TIMESTAMPDIFF(MINUTE, inDateTime, outDateTime))
                                                                FROM dbo.timetracking
                                                                where logid = @logID");
            minWorkedOnShiftCmd.Parameters.Add("@logID", MySqlDbType.Int32).Value = logID;
            minutesWorked = minsWorkedOnShiftConn.doubleScalar(minWorkedOnShiftCmd);
            hoursWorked = minutesWorked / 60;
            return hoursWorked;
        }

 /*
 DESCRIPTION: Calculates pay for shift and if overtime is owed
 PARAMETERS: logID: log ID of timetracking record
             userID: userID attached to logID
 */
        public double calculateShiftPay (int logID, int userID)
        {
            userInfo = new User(userID);
            // total hours worked in payPeriod by user
            double hoursWorkedInPeriod = getHoursWorkedInPeriod(userID, getPayPeriod(DateTime.Now.Month, DateTime.Now.Day));
            double shiftHours = hoursWorkedOnShift(logID);
            double overtimeHours;
            double regPay;
            double overtimePay;

            // if user has worked over 80 hours in pay period
            if(hoursWorkedInPeriod > 80)
            {
                // check if there were any regular hours, or if they are all overtime hours
                double regHours = 80 - shiftHours;
                // if there are some regular hours
                if(regHours > 0)
                {
                    // calculate over time hours and regular pay hours
                    overtimeHours = shiftHours - regHours;
                    regPay = regHours * userInfo.payRate;
                    overtimePay = overtimeHours * (userInfo.payRate * 1.5);
                }
                // else all overtime hours
                else
                {
                    regPay = 0;
                    overtimePay = shiftHours * (userInfo.payRate * 1.5);
                }
            }
            // else all regular pay hours
            else
            {
                regPay = shiftHours * userInfo.payRate;
                overtimePay = 0;
            }
            // sum totals
            double totalShiftPay = regPay + overtimePay;
            return totalShiftPay;
        }
 /*
 DESCRIPTION: updates pay on shift
 PARAMETERS: logID: log ID of timetracking record
             userID: userID attached to logID
             totalShiftPay: payment amount to attach to shift
 */
        public void updateShiftPay(int logID, int userID, double totalShiftPay)
        {
            DBConnect updateShiftPayConn = new DBConnect();
            MySqlCommand updateShiftPayCmd = new MySqlCommand(@"UPDATE dbo.timetracking
                                                                SET
                                                                totalPay = @totalShiftPay
                                                                WHERE logID = @logID;");
            updateShiftPayCmd.Parameters.Add("@totalShiftPay", MySqlDbType.Decimal).Value = totalShiftPay;
            updateShiftPayCmd.Parameters.Add("@logID", MySqlDbType.Int32).Value = logID;
            
            if(updateShiftPayConn.NonQuery(updateShiftPayCmd) > 0)
            {
                return;
            }
            else
            {
                MessageBox.Show("Error updating shift pay. Contact HR");
            }
        }

/*
DESCRIPTION: updates PTO on user record
PARAMETERS: logID: log ID of timetracking record
            userID: userID attached to logID
*/
        public void updatePTO(int logID, int userID)
        {
            double shiftHours = hoursWorkedOnShift(logID);
            
            // .05 of each hours (2 hours PTO for every 40 hours)
            double PTO = shiftHours * 0.05;                

            // SQL command
            DBConnect updatePTOConn = new DBConnect();
            MySqlCommand updatePTOCmd = new MySqlCommand(@"UPDATE dbo.user
                                                            SET
                                                            ptoTime = ptoTime + @PTO
                                                            WHERE userID = @userID;");
            updatePTOCmd.Parameters.Add("@PTO", MySqlDbType.Decimal).Value = PTO;
            updatePTOCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            
            // add to PTO
            if(updatePTOConn.NonQuery(updatePTOCmd) > 0)
            {
                return;
            }
            // something went wrong in the DB
            else
            {
                MessageBox.Show("Error updating PTO. Contact HR");
            }
        }

/*
  DESCRIPTION: driver funciton for payroll calculation
  PARAMETERS: logID: log ID of timetracking record
              userID: userID attached to logID
 */
        public void onClockOut(int logID, int userID)
        {
            double totalShiftPay = calculateShiftPay(logID, userID);
            updateShiftPay(logID, userID, totalShiftPay);
            updatePTO(logID, userID);
            return;
        }
    }
}
