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
        public employeeLeave()
        {
            InitializeComponent();
        }

// DESCRIPTION: Parameterized initializer. Fills the "my leave requests" table and the "Accrued PTO" label
        public employeeLeave(int userID)
        {
            
            InitializeComponent();
            UserID = userID;
            // fill PTO history table

            // initialize report connection, binding source, and sql command
            DBConnect reportConn = new DBConnect();
            BindingSource ptoBindingSource = new BindingSource();
            MySqlCommand cmd = new MySqlCommand();

            // try-catch block to handle exceptions
            try
            {
                // SQL command for report
                cmd.CommandText = @"SELECT 
                                        DATE(dateTimeStart) AS 'Start Date',
                                        TIME(dateTimeStart) AS 'Start Time',
                                        DATE(dateTimeEnd) AS 'End Date',
                                        TIME(dateTimeEnd) AS 'End Time',
                                        approvalStatus AS 'Approval Status'
                                        FROM leavemgmt
                                        WHERE userID = @userID
                                        ORDER BY created desc";
                    cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

                    // fills the data table 
                    DataTable ptoData = reportConn.ExecuteDataTable(cmd);
                    ptoBindingSource.DataSource = ptoData;
                    ptoDataGrid.DataSource = ptoBindingSource;
                    ptoDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }

    // fill accrued PTO text box

            DBConnect getPTOConn = new DBConnect();
            MySqlCommand getPTOCmd = new MySqlCommand(@"SELECT ptoTime
                                                        FROM dbo.user
                                                        where userID = @userID");
            getPTOCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
            double ptoHours = getPTOConn.doubleScalar(getPTOCmd);
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
                if(requestLeave.requestLeave(UserID, startDateTime.Value, endDateTime.Value, CheckPTO.Checked))
                {

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
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        private void displayError(string error)
        {
            lblError.ForeColor = Color.Red;
            lblError.Text = "Error: " + error;
            lblError.Show();
        }

        private void CheckPTO_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

