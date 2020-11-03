using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Human_Relations.Pages;
using MySql.Data.MySqlClient;

namespace Human_Relations
{
    public partial class Menu : Form
    {
        public int UserID;
        Login loginWind;
        Timer t = new Timer();
        
        public Menu(Login loginInstance, DateTime current)
        {
            InitializeComponent();
            loginWind = loginInstance;
        }

        // DESCRIPTION: Initializer. Shows/hides hotel management button based on isCustomer
        public Menu(bool isAdmin, int userID, Login loginInstance)
        {

            InitializeComponent();
            loginWind = loginInstance;
            
            t.Interval = 1000;
            t.Tick += new EventHandler(this.T_Tick);
            t.Start();
            UserID = userID;
            
            //if (isAdmin == false)
            //    btnHotelManagement.Visible = false;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var history = new History(UserID);
            history.FormClosed += new FormClosedEventHandler(history_FormClosed);
            this.Hide();
            history.Show();
        }

        private void history_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            var hire = new NewAccount(UserID);
            hire.FormClosed += new FormClosedEventHandler(NewAccount_FormClosed);
            this.Hide();
            hire.Show();
        }

        private void NewAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            var manageEmp = new ManageEmp(UserID);
            manageEmp.FormClosed += new FormClosedEventHandler(manageEmp_FormClosed);
            this.Hide();
            manageEmp.Show();
        }
        private void manageEmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnScheduleMgmt_Click(object sender, EventArgs e)
        {
            var scheduleMgmt = new schedule();
            scheduleMgmt.FormClosed += new FormClosedEventHandler(scheduleMgmt_formClosed);
            this.Hide();
            scheduleMgmt.Show();
        }

        private void scheduleMgmt_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            var viewProfile = new ManageProfile(UserID);
            viewProfile.FormClosed += new FormClosedEventHandler(viewProfile_formClosed);
            this.Hide();
            viewProfile.Show();
        }

        private void viewProfile_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        
        private void Clock1_Click(object sender, EventArgs e)
        {
           
        }
        private void T_Tick(object sender, EventArgs e)
        {
            string time = "";
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            
            if (hour < 10)
            {
                time += "0" + hour;
            }
            else
            {
                time += hour;
            }
            time += ":";
            if (min < 10)
            {
                time += "0" + min;
            }
            else
            {
                time += min;
            }
            time += ":";
            if (sec < 10)
            {
                time += "0" + sec;
            }
            else
            {
                time += sec;
            }
            Clock1.Text = time;

        }

        private void ClockOut_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(@"INSERT INTO dbo.timetracking(userID,outDate,outTime)VALUES(@userID,@outDate,@outTime)");
            cmd.Parameters.Add("@userID", MySqlDbType.VarChar, 45).Value = this.UserID;
            cmd.Parameters.Add("@outDate", MySqlDbType.Date).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@outTime", MySqlDbType.Time).Value = TimeSpan.Parse(Clock1.Text);
            // connect to database
            DBConnect userCreationConn = new DBConnect();

            // execute statement
            if (userCreationConn.NonQuery(cmd) > 0)
            {
                Clock_in.Visible = false;
            }
            else
            {
                displayError("Error Clocking In");

            }
            Clock_in.Visible = true;
            clock_out.Visible = false;
        }

        private void Clockin_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(@"INSERT INTO dbo.timetracking(userID,inDate,inTime)VALUES(@userID,@inDate,@inTime)");
            cmd.Parameters.Add("@userID", MySqlDbType.VarChar, 45).Value = this.UserID;
            cmd.Parameters.Add("@inDate", MySqlDbType.Date).Value = DateTime.Now.Date;
            cmd.Parameters.Add("@inTime", MySqlDbType.Time).Value = TimeSpan.Parse(Clock1.Text);
            // connect to database
            DBConnect userCreationConn = new DBConnect();

            // execute statement
            if (userCreationConn.NonQuery(cmd) > 0)
            {
                Clock_in.Visible = false;
            }
            else
            {
                displayError("Error Clocking In");

            }
            Clock_in.Visible = false;
            clock_out.Visible = true;
        }
        private void displayError(string errorMessage)
        {
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }

    }
}
