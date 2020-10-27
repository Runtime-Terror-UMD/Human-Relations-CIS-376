using Human_Relations;
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
    public double payRate { get; set; }
    public int roleID { get; set; }
    public int depID { get; set; }
    public double ptoDays { get; set; }
    public string address1 { get; set; }
    public string address2 { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public int? zip { get; set; }
    public string phoneNum { get; set; }


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
            if(dataReader["lastDate"] == DBNull.Value) //cannot convert null to DateTime
            {
                lastDate = DateTime.MinValue;
            }
            else
            {
                lastDate = Convert.ToDateTime(dataReader["lastDate"]);
            }
            payRate = Convert.ToDouble(dataReader["payRate"]);
            roleID = Convert.ToInt32(dataReader["roleID"]);
            depID = Convert.ToInt32(dataReader["depID"]);
            ptoDays = Convert.ToDouble(dataReader["ptoDays"]);
            address1 = Convert.ToString(dataReader["address1"]);
            address2 = Convert.ToString(dataReader["address2"]);
            city = Convert.ToString(dataReader["city"]);
            state = Convert.ToString(dataReader["state"]);
            if (dataReader["zip"] == DBNull.Value)
            {
                zip = null;
            }
            else
            {
                zip = Convert.ToInt32(dataReader["zip"]);
            }
            phoneNum = Convert.ToString(dataReader["phoneNum"]);
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
                                                        address1 = @address1,
                                                        address2 = @address2,
                                                        city = @city,
                                                        state = @state,
                                                        zip = @zip,
                                                        phoneNum = @phoneNum
                                                        WHERE userID = @userID;");
        updateUserCmd.Parameters.Add("@firstName", MySqlDbType.VarChar, 45).Value = userinfo.firstName;
        updateUserCmd.Parameters.Add("@lastName", MySqlDbType.VarChar, 45).Value = userinfo.lastName;
        updateUserCmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = userinfo.email;
        updateUserCmd.Parameters.Add("@userName", MySqlDbType.VarChar, 45).Value = userinfo.username;
        updateUserCmd.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = userinfo.password;
        updateUserCmd.Parameters.Add("@isActive", MySqlDbType.Bit).Value = userinfo.isActive;
        updateUserCmd.Parameters.Add("@hireDate", MySqlDbType.DateTime).Value = userinfo.hireDate;
        updateUserCmd.Parameters.Add("@lastDate", MySqlDbType.DateTime).Value = userinfo.lastDate;
        updateUserCmd.Parameters.Add("@payRate", MySqlDbType.Decimal).Value = userinfo.payRate;
        updateUserCmd.Parameters.Add("@roleID", MySqlDbType.Int32).Value = userinfo.roleID;
        updateUserCmd.Parameters.Add("@depID", MySqlDbType.Int32).Value = userinfo.depID;
        updateUserCmd.Parameters.Add("@ptoDays", MySqlDbType.Decimal).Value = userinfo.ptoDays;
        updateUserCmd.Parameters.Add("@address1", MySqlDbType.VarChar, 45).Value = userinfo.address1;
        updateUserCmd.Parameters.Add("@address2", MySqlDbType.VarChar, 45).Value = userinfo.address2;
        updateUserCmd.Parameters.Add("@city", MySqlDbType.VarChar, 45).Value = userinfo.city;
        updateUserCmd.Parameters.Add("@state", MySqlDbType.VarChar, 2).Value = userinfo.state;
        updateUserCmd.Parameters.Add("@zip", MySqlDbType.Int32).Value = userinfo.zip;
        updateUserCmd.Parameters.Add("@phoneNum", MySqlDbType.VarChar, 45).Value = userinfo.phoneNum;
        updateUserCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userinfo.userID;

        if (updateUserConn.NonQuery(updateUserCmd) > 0)
            return true;
        return false;
    }

}

