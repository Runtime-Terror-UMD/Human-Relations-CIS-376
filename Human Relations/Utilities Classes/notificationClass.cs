using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Human_Relations.Utilities_Classes
{
   public class notificationClass
    {
        public int notificationID { get; set; }
        public string notificationText { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int createdBy { get; set; }
        public bool AdminOnlyNotification { get; set; }
        public bool isActive { get; set; }

        private DBConnect notificationConn = new DBConnect();
        private MySqlCommand notificationCmd = new MySqlCommand();

        public notificationClass(){ }
        public notificationClass(int notifyID)
        {
            notificationCmd.CommandText = "SELECT * FROM dbo.notifications WHERE notificationID = @notificationID";
            notificationCmd.Parameters.Add("@notificationID", MySqlDbType.Int32).Value = notifyID;

            MySqlDataReader dataReader = notificationConn.ExecuteReader(notificationCmd);

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                notificationID = Convert.ToInt32(dataReader["notificationID"]);
                notificationText = dataReader["notificationText"].ToString();
                startDate = Convert.ToDateTime(dataReader["startDate"]);
                endDate = Convert.ToDateTime(dataReader["endDate"]);
                AdminOnlyNotification = Convert.ToBoolean(dataReader["AdminOnlyNotification"]);
                isActive = Convert.ToBoolean(dataReader["isActive"]);
            }

            dataReader.Close();
        }


            //DESCRIPTION: Creates a notification using specified parameters
            public bool createNotification(string text, DateTime? startDate, DateTime? endDate, int createdBy, bool isAdminOnly, bool isActive)
        {

            notificationCmd.CommandText= (@"INSERT INTO dbo.notifications
                                                                (notificationText,startDate,endDate,createdBy,AdminOnlyNotification,isActive) VALUES
                                                                (@notificationText,@startDate,@endDate, @createdBy, @adminOnly, @isActive);");
            notificationCmd.Parameters.Add("@notificationText", MySqlDbType.VarChar).Value = text;
            notificationCmd.Parameters.Add("@startDate", MySqlDbType.Date).Value = startDate;
            notificationCmd.Parameters.Add("@endDate", MySqlDbType.Date).Value = endDate;
            notificationCmd.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = createdBy;
            notificationCmd.Parameters.Add("@adminOnly", MySqlDbType.Bit).Value = isAdminOnly;
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

        public DataTable getAdminPageNotifications()
        {
            notificationCmd.CommandText = (@"SELECT 
                                            n.notificationID AS 'ID',
                                            n.notificationText AS 'Text',
                                            n.startDate AS 'Start Date',
                                            n.endDate AS 'End Date',
                                            concat(u.firstName, ' ', u.lastName) AS 'Created By',
                                            CASE 
	                                            WHEN n.AdminOnlyNotification = 1 THEN 'Admin Only'
                                                ELSE 'All Employees'
                                            END AS 'Type'
                                            FROM dbo.notifications n
                                            JOIN dbo.user u
	                                            ON u.userID = n.createdBy
                                            WHERE n.isActive = 1
                                            ORDER by n.startDate DESC;");
            DataTable reportData = notificationConn.ExecuteDataTable(notificationCmd);
            return reportData;
        }
    }
}
