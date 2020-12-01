using Human_Relations;
using MySql.Data.MySqlClient;
using System;
public class LoggedActivity
{
   public LoggedActivity() { }

    /*
     DESCRIPTION: Adds row to ActivityLog table in database.
     PARAMETERS: ActivityType: ActivityTypeID (value from dbo.activitytype table) 
                 EffectedUserID: The UserID of the user effected by the change
                 RefID: optional; primary key of row inserted/updated by activity
                 Created: DateTime activity is created
                 CreatedBY: UserID of user carrying out activity
     */
    public bool logActivity(int activityType, int effectedUserID, int refID, DateTime created, int createdBy)
    {
        DBConnect logActivityConn = new DBConnect();
        MySqlCommand logActivity = new MySqlCommand(@"INSERT INTO `dbo`.`activitylog`
                                                 (`effectedUser`,`activityTypeID`,`refID`,`created`,`createdBy`)
                                                 VALUES(@effectedUser,@activityType,@refID,@created,@createdBy)");
        logActivity.Parameters.Add("@effectedUser", MySqlDbType.Int32).Value = effectedUserID;
        logActivity.Parameters.Add("@activityType", MySqlDbType.Int32).Value = activityType;
        logActivity.Parameters.Add("@refID", MySqlDbType.Int32).Value = refID;
        logActivity.Parameters.Add("@created", MySqlDbType.Date).Value = created;
        logActivity.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = createdBy;
        if (logActivityConn.NonQuery(logActivity) > 0)
            return true;
        return false;
    }

    // DESCRIPTION: Checks to see if any activity has been logged for a specific user ID
    public bool checkForLoggedActivity(int userID)
    {
        DBConnect checkActivityConn = new DBConnect();
        MySqlCommand checkActivityCmd = new MySqlCommand(@"SELECT COUNT(*)
                                                            FROM dbo.activitylog al
                                                            WHERE al.createdBy = @userID");
        checkActivityCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
        int count = checkActivityConn.intScalar(checkActivityCmd);
        if (count > 0)
            return true;
        return false;
    }
}