﻿using Human_Relations;
using MySql.Data.MySqlClient;
using System;
public class LoggedActivity
{
    private int activityLogID { get; set; }
    private int customerID { get; set; }
    private int activityTypeID { get; set; }
    private DateTime creationDate { get; set; }
    LoggedActivity (int customer, int type, DateTime date)
    {
     //   this.activityLogID = ?? from database
        this.customerID = customer;
        this.activityTypeID = type;
        this.creationDate = date;
    }

   public LoggedActivity() { }

    public bool logActivity(int userID, int activityType, int refID, DateTime created, int createdBy)
    {
        DBConnect cancelResConn = new DBConnect();
        MySqlCommand cancelRes = new MySqlCommand("INSERT INTO `dbo`.`activitylog`(`userID`,`activityTypeID`,`refID`,`created`,`createdBy`)VALUES(@userID,@activityType,@refID,@created,@createdBy)");
        cancelRes.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
        cancelRes.Parameters.Add("@activityType", MySqlDbType.Int32).Value = activityType;
        cancelRes.Parameters.Add("@refID", MySqlDbType.Int32).Value = refID;
        cancelRes.Parameters.Add("@created", MySqlDbType.Date).Value = created;
        cancelRes.Parameters.Add("@createdBy", MySqlDbType.Int32).Value = createdBy;
        if (cancelResConn.NonQuery(cancelRes) > 0)
            return true;
        return false;
    }
}