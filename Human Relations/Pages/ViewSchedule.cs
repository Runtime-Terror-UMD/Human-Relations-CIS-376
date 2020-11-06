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
        public ViewSchedule(int user, string access)
        {
            InitializeComponent();
            adminUserID = user;
            //access specifies which button was pressed to get this screen
            if(access == "new")
            {

            }
            else if(access == "edit")
            {
                //TODO: load parameters from sql
            }
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
    }
}
