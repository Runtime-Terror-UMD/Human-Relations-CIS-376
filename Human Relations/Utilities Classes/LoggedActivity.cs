using Human_Relations;
using MySql.Data.MySqlClient;
using System;
public class LoggedActivity
{
   public LoggedActivity() { }

    public bool logActivity(int activityType, int affectedUserID, int refID, DateTime created, int createdBy)
    {
        DBConnect logActivityConn = new DBConnect();
        MySqlCommand logActivity = new MySqlCommand(@"INSERT INTO `dbo`.`activitylog`
                                                 (`affectedUser`,`activityTypeID`,`refID`,`created`,`createdBy`)
                                                 VALUES(@affectedUser,@activityType,@refID,@created,@createdBy)");
        logActivity.Parameters.Add("@userID", MySqlDbType.Int32).Value = affectedUserID;
        logActivity.Parameters.Add("@activityType", MySqlDbType.Int32).Value = activityType;
        logActivity.Parameters.Add("@refID", MySqlDbType.Int32).Value = refID;
        logActivity.Parameters.Add("@created", MySqlDbType.Date).Value = created;
        logActivity.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = createdBy;
        if (logActivityConn.NonQuery(logActivity) > 0)
            return true;
        return false;
    }
}