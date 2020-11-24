using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Human_Relations.Utilities_Classes
{
   public class notifications
    {
        private DBConnect notificationConn = new DBConnect();
        private MySqlCommand notificationCmd = new MySqlCommand();

//DESCRIPTION: Creates a notification using specified parameters
        public bool createNotification(string text, DateTime startDate, DateTime endDate, int createdBy, bool isAdminOnly, bool isActive)
        {
            notificationCmd.CommandText= (@"INSERT INTO dbo.notifications
                                                                (notificationText,startDate,endDate,createdBy,AdminOnlyNotification,isActive) VALUES
                                                                (@notificationText,@startDate,@endDate, @createdBy, @adminOnly, @isActive);");
            notificationCmd.Parameters.Add("@notificationText", MySqlDbType.VarChar).Value = text;
            notificationCmd.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate.Date;
            notificationCmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate.Date;
            notificationCmd.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = createdBy;
            notificationCmd.Parameters.Add("@isAdminOnly", MySqlDbType.Bit).Value = isAdminOnly;
            notificationCmd.Parameters.Add("@isActive", MySqlDbType.Bit).Value = isActive;

            if (notificationConn.NonQuery(notificationCmd) > 0)
                return true;
            return false;
        }

// DESCRIPTION: Returns data table of employee notifications for menu page

        public DataTable getEmployeeNotifications()
        {
            notificationCmd.CommandText =  (@"SELECT notificationText 
                                                                FROM dbo.notifications
                                                                WHERE isActive = 1
                                                                AND AdminOnlyNotification = 0
                                                                ORDER by startDate DESC;");
            DataTable reportData = notificationConn.ExecuteDataTable(notificationCmd);
            return reportData;
        }

// DESCRIPTION: Returns data table of admin notifications for menu page
        public DataTable getAdminNotifications()
        {
            notificationCmd.CommandText = (@"SELECT notificationText 
                                                                    FROM dbo.notifications
                                                                    WHERE isActive = 1
                                                                    ORDER by startDate DESC;");
            DataTable reportData = notificationConn.ExecuteDataTable(notificationCmd);
            return reportData;
        }
    }
}
