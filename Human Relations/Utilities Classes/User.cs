using Hotel_Reservation_Overhaul;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;

public class User
{
    public int userID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public bool isAdmin { get; set; }
    public bool isActive { get; set; }
    public DateTime hireDate { get; set; }
    public DateTime lastDate { get; set; }
    public decimal payRate { get; set; }
    public int roleID { get; set; }
    public int depID { get; set; }
    public decimal ptoDays { get; set; }


    public User(int UserID)
    {
        // declare and parameterize mySQL Command

        MySqlCommand cmd = new MySqlCommand("SELECT * FROM dbo.user WHERE userID = @UserID");
        cmd.Parameters.Add("@UserID", MySqlDbType.Int32).Value = UserID;

        // connect to database
        DBConnect UserProfileConn = new DBConnect();

        //Create a data reader and Execute the command
        MySqlDataReader dataReader = UserProfileConn.ExecuteReader(cmd);

        //Read the data and store them in the list
        while (dataReader.Read())
        {
            userID = Convert.ToInt32(dataReader["userID"]);
            firstName = dataReader["firstName"].ToString();
            lastName = dataReader["lastName"].ToString();
            email = dataReader["email"].ToString();
            username = dataReader["username"].ToString();
            password = dataReader["password"].ToString();
            isAdmin = Convert.ToBoolean(dataReader["isAdmin"]);
            isActive = Convert.ToBoolean(dataReader["isActive"]);
            hireDate = Convert.ToDateTime(dataReader["hireDate"]);
            lastDate = Convert.ToDateTime(dataReader["lastDate"]);
            payRate = Convert.ToDecimal(dataReader["payRate"]);
            roleID = Convert.ToInt32(dataReader["roleID"]);
            depID = Convert.ToInt32(dataReader["depID"]);
            ptoDays = Convert.ToDecimal(dataReader["ptoDays"]);

        }

        //close Data Reader
        dataReader.Close();;
    }

    // updates information on user record
    public bool updateUser(User userinfo)
    {
        DBConnect updateUserConn = new DBConnect();
        MySqlCommand updateUserCmd = new MySqlCommand(@"UPDATE `dbo`.`user`
                                                        SET
                                                        firstName = @firstName,
                                                        lastName = @lastName,
                                                        email = @email,
                                                        username = @userName,
                                                        password = @password,
                                                        isActive = @isActive,
                                                        hireDate = @hireDate,
                                                        lastDate = @lastDate,
                                                        payRate = @payRate,
                                                        roleID = @roleID,
                                                        depID = @depID,
                                                        ptoDays = @ptoDays,
                                                        WHERE userID = @userID;");
        updateUserCmd.Parameters.Add("@firstName", MySqlDbType.VarChar, 45).Value = userinfo.firstName;
        updateUserCmd.Parameters.Add("@lastName", MySqlDbType.VarChar, 45).Value = userinfo.lastName;
        updateUserCmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = userinfo.email;
        updateUserCmd.Parameters.Add("@userName", MySqlDbType.VarChar, 45).Value = userinfo.username;
        updateUserCmd.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = userinfo.password;
        updateUserCmd.Parameters.Add("@hireDate", MySqlDbType.DateTime).Value = userinfo.hireDate;
        updateUserCmd.Parameters.Add("@lastDate", MySqlDbType.DateTime).Value = userinfo.lastDate;
        updateUserCmd.Parameters.Add("@payRate", MySqlDbType.Decimal, 10).Value = userinfo.payRate;
        updateUserCmd.Parameters.Add("@roleID", MySqlDbType.Int32).Value = userinfo.roleID;
        updateUserCmd.Parameters.Add("@depID", MySqlDbType.Int32).Value = userinfo.depID;
        updateUserCmd.Parameters.Add("@ptoDays", MySqlDbType.Decimal, 10).Value = userinfo.ptoDays;



        updateUserCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userinfo.userID;
        if (updateUserConn.NonQuery(updateUserCmd) > 0)
            return true;
        return false;
    }

}

