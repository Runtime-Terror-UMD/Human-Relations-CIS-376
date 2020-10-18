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
        logActivity.Parameters.Add("@created", MySqlDbType.DateTime).Value = created;
        logActivity.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = createdBy;
        if (logActivityConn.NonQuery(logActivity) > 0)
            return true;
        return false;
    }
}