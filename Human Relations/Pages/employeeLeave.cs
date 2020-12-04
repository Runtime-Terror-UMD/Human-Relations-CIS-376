using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Human_Relations.Pages
{
    public partial class employeeLeave : Form
    {
        public int UserID;
        private DataTable ptoData;
        private leavemgmtclass leaveMgmt = new leavemgmtclass();
        BindingSource ptoBindingSource = new BindingSource();
        private double ptoHours;

        public employeeLeave()
        {
            InitializeComponent();
        }

// DESCRIPTION: Parameterized initializer. Fills the "my leave requests" table and the "Accrued PTO" label
        public employeeLeave(int userID)
        {         
            InitializeComponent();
            UserID = userID;
            refreshLeaveReport(UserID);
          
         
        }
//DESCRIPTION: Pulls leave request report for user
        private void refreshLeaveReport(int UserID)
        {
            // try-catch block to handle exceptions
            try
            {
                // fills the data table 
                ptoData = leaveMgmt.employeeLeaveHistory(UserID);
                ptoBindingSource.DataSource = ptoData;
                ptoDataGrid.DataSource = ptoBindingSource;
                ptoDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            // fill accrued PTO text box
            ptoHours = leaveMgmt.getAccruedPTO(UserID);
            txtPtoHours.Text = String.Format("{0:F1}", ptoHours);
        }

//DESCRIPTION: Creates leave request entry
        private void btnRequestLeave_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if(startDateTime.Value < DateTime.Now)
            {
                displayError("Start of leave cannot be in the past");
            }
            else if(endDateTime.Value < DateTime.Now)
            {
                displayError("End of leave cannot be in the past.");
            }
            else if (startDateTime.Value > endDateTime.Value)
            {
                displayError("Start of leave cannot be later than end of leave");
            }
            else
            {
                // calls function in leavemgmtclass to create leave request and add to activity log
                leavemgmtclass requestLeave = new leavemgmtclass();
                if(requestLeave.requestLeave(UserID, startDateTime.Value.Date, endDateTime.Value.Date, CheckPTO.Checked))
                {
                    refreshLeaveReport(UserID);
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Request created and pending review";
                    lblError.Visible = true;
                }
                else
                {
                    displayError("Error creating leave request");
                }
           }
        }

// DESCRIPTION: returns user to menu screen
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

// DESCRIPTION: Logs user out of system
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoggedActivity loginActivity = new LoggedActivity();
            loginActivity.logActivity(13, UserID, 0, DateTime.Now, UserID);
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        private void displayError(string error)
        {
            lblError.ForeColor = Color.Red;
            lblError.Text = "Error: " + error;
            lblError.Show();
        }

    }
}

