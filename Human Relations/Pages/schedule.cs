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
                btnCreate.Show();
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
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var newSchedule = new ViewSchedule(UserID, "new");
            newSchedule.FormClosed += new FormClosedEventHandler(newSchedule_formClosed);
            this.Hide();
            newSchedule.Show();
        }

        private void newSchedule_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            search();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //TODO: get schedule selected and populate view schedule page
        }


    }
}
