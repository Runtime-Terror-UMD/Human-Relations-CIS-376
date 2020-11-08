using System;
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
        public ViewSchedule(int adminUserID, int employeeUserID)
        {
            InitializeComponent();
            this.adminUserID = adminUserID;
            this.employeeUserID = employeeUserID;
            btnCreate.Visible = false;
            txtUserID.Text = "" + employeeUserID;
            txtUserID.Enabled = false;
            //pull existing schedule data
            DBConnect getscheduleConnection = new DBConnect();
            //create command
            MySqlCommand cmd = new MySqlCommand(@"SELECT InDateTime from dbo.schedule where userID = @userID");
            cmd.Parameters.Add("@userID", MySqlDbType.VarChar, 45).Value = employeeUserID;
            inDateTime = getscheduleConnection.dateTimeScalar(cmd);
            startDate.Value = inDateTime;
            //cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"SELECT outDateTime from dbo.schedule where userID = @userID";
            //MySqlCommand cmd2 = new MySqlCommand("SELECT outDateTime from dbo.schedule where userID = @userID");
            //cmd2.Parameters.Add("@userID", MySqlDbType.VarChar, 45).Value = employeeUserID;
            outDateTime = getscheduleConnection.dateTimeScalar(cmd);
            endDate.Value = outDateTime;
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

                if (!employee.isAdmin(user))
                {
                    if(endDate.Value > startDate.Value)
                    {
                        // SQL query
                        MySqlCommand cmd = new MySqlCommand(@"INSERT INTO `dbo`.`schedule`(`userID`,`inDateTime`,`outDateTime`)
                                                        VALUES(@userID,@inDateTime,@outDateTime)");
                        cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = user;
                        cmd.Parameters.Add("@inDateTime", MySqlDbType.DateTime).Value = startDate.Value;
                        cmd.Parameters.Add("@outDateTime", MySqlDbType.DateTime).Value = endDate.Value;

                        // connect to database
                        DBConnect scheduleCreationConn = new DBConnect();

                        if (scheduleCreationConn.NonQuery(cmd) > 0)
                        {
                            //logging activity "created a new acount
                            LoggedActivity logging = new LoggedActivity();
                            cmd = new MySqlCommand("SELECT * FROM dbo.schedule WHERE userID = @UserID AND inDateTime = @inDateTime AND outDateTime = @outDateTime");
                            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = user;
                            cmd.Parameters.Add("@inDateTime", MySqlDbType.DateTime).Value = startDate.Value;
                            cmd.Parameters.Add("@outDateTime", MySqlDbType.DateTime).Value = endDate.Value;
                            DBConnect UserProfileConn = new DBConnect();

                            //Create a data reader and Execute the command
                            MySqlDataReader dataReader = UserProfileConn.ExecuteReader(cmd);
                            int schedID = -1;
                            while (dataReader.Read())
                            {
                                schedID = Convert.ToInt32(dataReader["scheduleID"]);
                            }
                            logging.logActivity(15, user, schedID, DateTime.Now, adminUserID);
                            MessageBox.Show("Schedule was created.");
                            this.Close();
                        }
                        else
                        {
                            errorMessage("Error creating schedule.");
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
            catch(Exception error)
            {
                errorMessage("Exception " + error);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //inDateTime = startDate;
            //outDateTime = endDate.Value
            if (endDate.Value > startDate.Value)
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
                cmd.CommandText =@"UPDATE dbo.schedule
                                    SET
                                    InDateTime = @InDateTime,
                                    outDateTime = @outDateTime
                                    WHERE scheduleID = @scheduleID;";
                cmd.Parameters.Add("@scheduleID", MySqlDbType.Int32).Value = ScheduleID;
                cmd.Parameters["@InDateTime"].Value = startDate.Value;
                cmd.Parameters["@outDateTime"].Value = endDate.Value;
                
                if (updateScheduleConnection.NonQuery(cmd) > 0)
                {
                    //logging activity "created a new acount
                    LoggedActivity log = new LoggedActivity();
                    log.logActivity(16, employeeUserID, ScheduleID, DateTime.Now, adminUserID);
                    MessageBox.Show("Schedule was updated.");
                    this.Close();
                }
                else
                {
                    errorMessage("Error updating schedule.");
                }
            }
            else
            {
                errorMessage("Invalid Date.");
            }
        }
    }
}
