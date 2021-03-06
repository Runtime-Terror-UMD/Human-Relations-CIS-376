﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Human_Relations.Pages
{
    public partial class ViewSchedule : Form
    {
        int adminUserID;
        int employeeUserID;
        DateTime inDateTime;
        DateTime outDateTime;
        //used when an existing schedule is being updated
        public ViewSchedule(int adminUserID, int employeeUserID, int schedID)
        {
            InitializeComponent();
            this.adminUserID = adminUserID;
            this.employeeUserID = employeeUserID;
            btnCreate.Visible = false;
            txtUserID.Text = "" + employeeUserID;
            txtUserID.Enabled = false;
            //pull existing schedule data
            //create command
            MySqlCommand cmd = new MySqlCommand(@"SELECT * from dbo.schedule where scheduleID = @scheduleID");
            cmd.Parameters.Add("@scheduleID", MySqlDbType.Int32).Value = schedID;

            DBConnect getscheduleConnection = new DBConnect();
            MySqlDataReader dataReader = getscheduleConnection.ExecuteReader(cmd);

            while (dataReader.Read())
            {
                inDateTime = Convert.ToDateTime(dataReader["inDateTime"]);
                outDateTime = Convert.ToDateTime(dataReader["outDateTime"]);
            }
            startDateTime.Value = inDateTime;
            endDateTime.Value = outDateTime;
        }
        //used when new schedule is being created
        public ViewSchedule(int user)
        {
            InitializeComponent();
            adminUserID = user;
            btnUpdate.Visible = false;
        }

        private void errorMessage(string error)
        {
            lblError.Text = "Error: " + error;
            lblError.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Utilities employee = new Utilities();

            int user = 0;
            try 
            {
                user = Int32.Parse(txtUserID.Text);
                User isActiveCheck = new User(user);
                if (!employee.userIDExists(user))
                {
                    errorMessage("User does not exist.");
                }
                else if(!isActiveCheck.isActive)
                {
                    errorMessage("User is not active in database.");
                }
                else if (!employee.isAdmin(user))
                {
                    if (endDateTime.Value > startDateTime.Value)
                    {
                        //find schedules for the same date
                        MySqlCommand dupCheck = new MySqlCommand(@"select count(*)
                                                                    from dbo.schedule
                                                                    where userID = @userID
                                                                    and ((@inDateTime between inDateTime and outDateTime)
                                                                    or (@outDateTime between inDateTime and outDateTime)
                                                                    or (inDateTime between @inDateTime and @outDateTime)
                                                                    or (outDateTime between @inDateTime and @outDateTime))");
                        dupCheck.Parameters.Add("@userID", MySqlDbType.Int32).Value = user;
                        dupCheck.Parameters.Add("@inDateTime", MySqlDbType.DateTime).Value = startDateTime.Value;
                        dupCheck.Parameters.Add("@outDateTime", MySqlDbType.DateTime).Value = endDateTime.Value;

                        DBConnect duplicateConn = new DBConnect();

                        if (duplicateConn.intScalar(dupCheck) > 0)
                            errorMessage("Shift overlaps existing shift.");
                        else
                        {
                            // SQL query
                            MySqlCommand cmd = new MySqlCommand(@"INSERT INTO `dbo`.`schedule`(`userID`,`inDateTime`,`outDateTime`)
                                                        VALUES(@userID,@inDateTime,@outDateTime)");
                            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = user;
                            cmd.Parameters.Add("@inDateTime", MySqlDbType.DateTime).Value = startDateTime.Value;
                            cmd.Parameters.Add("@outDateTime", MySqlDbType.DateTime).Value = endDateTime.Value;

                            // connect to database
                            DBConnect scheduleCreationConn = new DBConnect();

                            if (scheduleCreationConn.NonQuery(cmd) > 0)
                            {
                                //logging activity "created a new acount
                                LoggedActivity logging = new LoggedActivity();
                                cmd = new MySqlCommand("SELECT * FROM dbo.schedule WHERE userID = @UserID AND inDateTime = @inDateTime AND outDateTime = @outDateTime");
                                cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = user;
                                cmd.Parameters.Add("@inDateTime", MySqlDbType.DateTime).Value = startDateTime.Value;
                                cmd.Parameters.Add("@outDateTime", MySqlDbType.DateTime).Value = endDateTime.Value;
                                DBConnect UserProfileConn = new DBConnect();

                                //Create a data reader and Execute the command
                                MySqlDataReader dataReader = UserProfileConn.ExecuteReader(cmd);
                                int schedID = -1;
                                while (dataReader.Read())
                                {
                                    schedID = Convert.ToInt32(dataReader["scheduleID"]);
                                }
                                logging.logActivity(16, user, schedID, DateTime.Now, adminUserID);
                                MessageBox.Show("Schedule was created.");
                                this.Close();
                            }
                            else
                            {
                                errorMessage("Error creating schedule.");
                            }
                        }
                    }
                    else
                    {
                        errorMessage("Invalid Date.");
                    }
                }
                else
                {
                    errorMessage("Admin cannot be scheduled.");
                }
            }
            catch(FormatException error)
            {
                errorMessage("Invalid user ID." + error);
            }
            catch(Exception error)
            {
                errorMessage("Exception " + error);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //in

            if (endDateTime.Value > startDateTime.Value)
            {
                int ScheduleID = -1;
                DBConnect updateScheduleConnection = new DBConnect();
                MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM dbo.schedule 
                                                        WHERE userID = @userID 
                                                        AND InDateTime = @InDateTime 
                                                        AND outDateTime = @outDateTime");
                cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = employeeUserID;
                cmd.Parameters.Add("@InDateTime", MySqlDbType.DateTime).Value = inDateTime;
                cmd.Parameters.Add("@outDateTime", MySqlDbType.DateTime).Value = outDateTime;
                MySqlDataReader dataReader = updateScheduleConnection.ExecuteReader(cmd);
                while (dataReader.Read())
                {
                    ScheduleID = Convert.ToInt32(dataReader["scheduleID"]);
                }
                //find schedules for the same date
                MySqlCommand dupCheck = new MySqlCommand(@"select count(*)
                                                                    from dbo.schedule
                                                                    where scheduleID != @sched
                                                                    and userID = @userID
                                                                    and ((@inDateTime between inDateTime and outDateTime)
                                                                    or (@outDateTime between inDateTime and outDateTime)
                                                                    or (inDateTime between @inDateTime and @outDateTime)
                                                                    or (outDateTime between @inDateTime and @outDateTime))");
                dupCheck.Parameters.Add("@userID", MySqlDbType.Int32).Value = employeeUserID;
                dupCheck.Parameters.Add("@inDateTime", MySqlDbType.DateTime).Value = startDateTime.Value;
                dupCheck.Parameters.Add("@outDateTime", MySqlDbType.DateTime).Value = endDateTime.Value;
                dupCheck.Parameters.Add("@sched", MySqlDbType.Int32).Value = ScheduleID;

                DBConnect duplicateConn = new DBConnect();

                if (duplicateConn.intScalar(dupCheck) > 0)
                    errorMessage("Shift overlaps existing shift.");
                else
                {
                    cmd.CommandText = @"UPDATE dbo.schedule
                                    SET
                                    InDateTime = @InDateTime,
                                    outDateTime = @outDateTime
                                    WHERE scheduleID = @scheduleID;";
                    cmd.Parameters.Add("@scheduleID", MySqlDbType.Int32).Value = ScheduleID;
                    cmd.Parameters["@InDateTime"].Value = startDateTime.Value;
                    cmd.Parameters["@outDateTime"].Value = endDateTime.Value;

                    if (updateScheduleConnection.NonQuery(cmd) > 0)
                    {
                        //logging activity "created a new acount
                        LoggedActivity log = new LoggedActivity();
                        log.logActivity(17, employeeUserID, ScheduleID, DateTime.Now, adminUserID);
                        MessageBox.Show("Schedule was updated.");
                        this.Close();
                    }
                    else
                    {
                        errorMessage("Error updating schedule.");
                    }
                }
            }
            else
            {
                errorMessage("Invalid Date.");
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void startDateTime_ValueChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void endDateTime_ValueChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
