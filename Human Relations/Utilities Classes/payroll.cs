using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Relations.Utilities_Classes
{
    class payroll
    {
        public int getCurrentPayPeriod(int month, int day) 
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
    }
}
