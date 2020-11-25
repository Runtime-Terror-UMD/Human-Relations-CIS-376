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

namespace Human_Relations
{
    public partial class Menu : Form
    {
        public int UserID;
        Login loginWind;
        Timer t = new Timer();
        private Utilities utilityObject = new Utilities();
        private timetracking clockInOut = new timetracking();
        private notificationClass pullNotifications = new notificationClass();
        private DataTable notificationData = new DataTable();
        BindingSource notificationBindingSource = new BindingSource();

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

            // displays notifications based on admin status
            displayNotifications(isAdmin);

            if (isAdmin == false)
            {
                // hides non-admin buttons
                btnManageEmp.Hide();
                btnReport.Hide();
                btnNotificaitons.Hide();
            }
            if(utilityObject.isClockedIn(UserID))
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

        // DESCRIPTION: Displays notifications depending on admin/non-admin role
        private void displayNotifications(bool isAdmin)
        {
            if(isAdmin)
            {
                notificationData = pullNotifications.getAdminNotifications();
               
            }
            else
            {
                notificationData = pullNotifications.getEmployeeNotifications();

            }
            notificationBindingSource.DataSource = notificationData;
            notificationDataGrid.DataSource = notificationBindingSource;
            notificationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            var scheduleMgmt = new schedule(UserID);
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

        // DESCRIPTION: Clocks user out
        private void ClockOut_Click(object sender, EventArgs e)
        {
            // clocks user out from timetracking object
           int logID = clockInOut.clockOut(this.UserID);

            // if clock-out succeeded
           if(logID != -1)
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

        // DESCRIPTION: Clocks user in
        private void Clockin_Click(object sender, EventArgs e)
        {
            // clocks user in using timetracking object
            if(clockInOut.clockIn(this.UserID))
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

 // DESCRIPTION: Opens "My Payroll" page
        private void btnPayroll_Click(object sender, EventArgs e)
        {
            var viewPayroll = new payrollReport(UserID);
            viewPayroll.FormClosed += new FormClosedEventHandler(payrollReport_formClosed);
            this.Hide();
            viewPayroll.Show();
        }

// DESCRIPTION: Returns to menu when "My Payroll" page is closed
        private void payrollReport_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

// DESCRIPTION: Opens different leave management page depending on isAdmin
        private void btnLeaveMgmt_Click(object sender, EventArgs e)
        {
            // if non-admin, redirect to employee leave management page
            if(!utilityObject.isAdmin(UserID))
            {
                var empLeavePage = new employeeLeave(UserID);
                empLeavePage.FormClosed += new FormClosedEventHandler(employeeLeave_FormClosed);
                this.Hide();
                empLeavePage.Show();
            }
            else
            // if admin, redirect to admin leave management page
            {
                var adminLeavePage = new adminLeave();
                adminLeavePage.FormClosed += new FormClosedEventHandler(adminLeave_FormClosed);
                this.Hide();
                adminLeavePage.Show();
            }    

        }
// DESCRIPTION: Returns to menu when employee "Leave Managementl" page is closed
        private void employeeLeave_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
// DESCRIPTION: Returns to menu when admin "Leave Managementl" page is closed
        private void adminLeave_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        //description: Shows report page to admins
        private void btnReport_Click(object sender, EventArgs e)
        {
            var viewReports = new ReportsList(UserID);
            viewReports.FormClosed += new FormClosedEventHandler(reportsList_formClosed);
            this.Hide();
            viewReports.Show();
        }

        private void reportsList_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        // DESCRIPTION: Opens notification configuration page
        private void btnNotificaitons_Click(object sender, EventArgs e)
        {
            var notificationPage = new Notifications(this.UserID);
            notificationPage.FormClosed += new FormClosedEventHandler(notificationPage_formClosed);
            this.Hide();
            notificationPage.Show();
        }

        // DESCRIPTION: Displays menu when notification configuration page is closed
        private void notificationPage_formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }

}
