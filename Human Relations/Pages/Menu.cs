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
using Human_Relations.Utilities_Classes;
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

            Utilities checkStatus = new Utilities();
            if(checkStatus.isClockedIn(UserID))
            {
                Clock_in.Hide(); //hide clock in button
                clock_out.Show();
            }
            else
            {

                Clock_in.Show(); 
                clock_out.Hide();
            }
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
            // connect to database
            DBConnect clockOutConn = new DBConnect();
            
            // get logID of shift to pass to payroll calculation
            MySqlCommand getLogIDCmd = new MySqlCommand(@"SELECT logID 
                                                        FROM dbo.timetracking
                                                        WHERE userID = @userID
                                                        and shifton = 1;");
            getLogIDCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = this.UserID;
            int logID = clockOutConn.intScalar(getLogIDCmd);

            // clock user out
            MySqlCommand clockOutCmd = new MySqlCommand(@"UPDATE dbo.timetracking
                                                        SET outDateTime = @outDateTime,
                                                            shifton = 0
                                                        WHERE userID = @userID
                                                        AND shifton = 1; ");
            clockOutCmd.Parameters.Add("@outDateTime", MySqlDbType.DateTime).Value = DateTime.Now;
            clockOutCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = this.UserID;

            // execute statement
            if (clockOutConn.NonQuery(clockOutCmd) > 0)
            {
                Clock_in.Visible = true;
                clock_out.Visible = false;

                // update shift pay and PTO
                payroll calcShiftPay = new payroll();
                calcShiftPay.onClockOut(logID, this.UserID);
            }
            else
            {
                displayError("Error Clocking Out");

            }
        }

        private void Clockin_Click(object sender, EventArgs e)
        {
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;

            payroll getPayPeriodID = new payroll();
            int payPeriodID = getPayPeriodID.getPayPeriod(month, day);

            MySqlCommand cmd = new MySqlCommand(@"INSERT INTO dbo.timetracking(userID,payPeriodID,inDateTime,shifton)VALUES(@userID,@payPeriodID,@inDateTime,@shifton)");
            cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = this.UserID;
            cmd.Parameters.Add("@payPeriodID", MySqlDbType.Int32).Value = payPeriodID;
            cmd.Parameters.Add("@inDateTime", MySqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@shifton", MySqlDbType.Bit).Value = 1;
            DBConnect clockInConn = new DBConnect();

            // execute statement
            if (clockInConn.NonQuery(cmd) > 0)
            {
                Clock_in.Visible = false;
                clock_out.Visible = true;

            }
            else
            {
                displayError("Error Clocking In");

            }
            
        }
        private void displayError(string errorMessage)
        {
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }

    }
}
