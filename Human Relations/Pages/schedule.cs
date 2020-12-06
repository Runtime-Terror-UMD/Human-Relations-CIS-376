using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Human_Relations.Pages;
using System.Globalization;

namespace Human_Relations.Pages
{
    public partial class schedule : Form
    {
        int UserID;
        public schedule(int user)
        {
            InitializeComponent();
            UserID = user;
            Utilities employee = new Utilities();
            if(employee.isAdmin(UserID))
            {
                btnCreate.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnCreate.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
        }

        // components for schedule viewing

        DBConnect scheduleConn = new DBConnect();
        DataTable scheduleData = new DataTable();
        BindingSource scheduleBindingSource = new BindingSource();

        private void search()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                // formats date value from dateTime picker
                string formattedDate = scheduleDatePicker.Value.ToString("yyyy-MM-dd");

                // SQL query
                cmd.CommandText = @"SELECT   
                                    u.userID as 'User ID',
                                    s.scheduleID as 'Schedule ID',
                                    concat(u.firstName, ' ', u.lastName) as 'Name',
                                    TIME_FORMAT(s.indateTime, '%r') as 'Start Time', 
                                    TIME_FORMAT(s.outDateTime, '%r') as 'End Time'
                                    from dbo.schedule s
                                    join dbo.user u
	                                    on u.userID = s.userID
                                    WHERE DATE(s.inDateTime) = @date";
                cmd.Parameters.Add("@date", MySqlDbType.Date).Value = formattedDate;

                // fills data grid
                scheduleData = scheduleConn.ExecuteDataTable(cmd);
                scheduleBindingSource.DataSource = scheduleData;
                scheduleDataGrid.DataSource = scheduleBindingSource;
                scheduleDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
/*
DESCRIPTION: pulls all user schedules for specified date
*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
        // returns to menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // logs user out of system
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoggedActivity loginActivity = new LoggedActivity();
            loginActivity.logActivity(13, UserID, 0, DateTime.Now, UserID);
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var newSchedule = new ViewSchedule(UserID);
            newSchedule.FormClosed += new FormClosedEventHandler(newSchedule_formClosed);
            this.Hide();
            newSchedule.Show();
        }

        private void newSchedule_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            search();
        }
        /*private void SetDateTime(DateTime date, String inTime, String outTime)
        {
            //string temp = new string(inTime.TakeWhile(c => c != ' ').ToArray());
            this.inDateTime = date.Date + TimeSpan.Parse(inTime);
            if (inTime.Substring(inTime.Length - 2) == "PM" && outTime.Substring(outTime.Length - 2) == "AM")
                date.AddDays(1);
            //temp = new string(outTime.TakeWhile(c => c != ' ').ToArray());
            this.outDateTime = date.Date + TimeSpan.Parse(outTime);
        }*/
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //TODO: get schedule selected and populate view schedule page
            if(scheduleDataGrid.Rows.Count == 0)
            {
                lblError.Text += " The selected date has no scheduled shifts";
                lblError.Visible = true;
            }
            else if (scheduleDataGrid.SelectedRows.Count == 0)
            {
                lblError.Text += " Please select a row";
                lblError.Visible = true;
            }
            else if(scheduleDataGrid.SelectedRows.Count > 1)
            {
                lblError.Text += " Please select one row";
                lblError.Visible = true;
            }
            else
            {

                var updateSchedule = new ViewSchedule(UserID, Int32.Parse(scheduleDataGrid.SelectedRows[0].Cells[0].Value.ToString()), Int32.Parse(scheduleDataGrid.SelectedRows[0].Cells[1].Value.ToString()));
                updateSchedule.FormClosed += new FormClosedEventHandler(newSchedule_formClosed);
                updateSchedule.Show();
                this.Hide();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (scheduleDataGrid.Rows.Count == 0)
            {
                lblError.Text += " The selected date has no scheduled shifts";
                lblError.Visible = true;
            }
            else if (scheduleDataGrid.SelectedRows.Count == 0)
            {
                lblError.Text += " Please select a row";
                lblError.Visible = true;
            }
            else if (scheduleDataGrid.SelectedRows.Count > 1)
            {
                lblError.Text += " Please select one row";
                lblError.Visible = true;
            }
            else
            {
                int ScheduleID = Int32.Parse(scheduleDataGrid.SelectedRows[0].Cells[1].Value.ToString());
                int empID = Int32.Parse(scheduleDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                DBConnect deleteScheduleConnection = new DBConnect();
                MySqlCommand cmd = new MySqlCommand(@"DELETE FROM dbo.schedule WHERE scheduleID = @scheduleID");
                cmd.Parameters.Add("@scheduleID", MySqlDbType.Int32).Value = ScheduleID;
                if(deleteScheduleConnection.NonQuery(cmd) > 0)
                {
                    MessageBox.Show("Schedule " + ScheduleID + " was deleted.");
                    search();
                    LoggedActivity updateSched = new LoggedActivity();
                    updateSched.logActivity(19, empID, ScheduleID, DateTime.Now, UserID);
                }
            }
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                // SQL query
                cmd.CommandText = @"SELECT   
                                    u.userID as 'User ID',
                                    concat(u.firstName, ' ', u.lastName) as 'Name',
                                    s.indateTime as 'Start Time', 
                                    s.outDateTime as 'End Time'
                                    from dbo.schedule s
                                    join dbo.user u
	                                    on u.userID = s.userID
                                    WHERE s.userID = @userID
                                    AND DATE(s.inDateTime) >= @currentDate";
                cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = UserID;
                cmd.Parameters.Add("@currentDate", MySqlDbType.DateTime).Value = DateTime.Today;

                // fills data grid
                scheduleData = scheduleConn.ExecuteDataTable(cmd);
                scheduleBindingSource.DataSource = scheduleData;
                scheduleDataGrid.DataSource = scheduleBindingSource;
                scheduleDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

    }
}
