using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Relations.Pages
{
    public partial class adminLeave : Form
    {
        DBConnect connection = new DBConnect();
        DataTable pendingLeave = new DataTable();
        BindingSource bindingSource = new BindingSource();
        MySqlCommand cmd = new MySqlCommand();

        public adminLeave()
        {
            InitializeComponent();
            displayPendingRequests();

        }

// DESCRIPTION: Displays all pending leave requests (oldest to newest, by start date of request)
        private void displayPendingRequests()
        {
            try
            {
                cmd.CommandText = @"select
                                    lm.userID as 'User ID',
                                    concat(emp.firstName, ' ', emp.lastName) as 'Employee',
                                    lm.dateStart as 'Request Start',
                                    lm.dateEnd as 'Request End',
                                    DATE(lm.created) as 'Requested On',
                                    lm.approvalStatus
                                    from dbo.leavemgmt lm
                                    join dbo.user emp
                                        on emp.userID = lm.userID
                                    where lm.approvalstatus = 'Pending'
                                    order by lm.dateStart";
                pendingLeave = connection.ExecuteDataTable(cmd);
                bindingSource.DataSource = pendingLeave;
                adminLeaveDataGrid.DataSource = bindingSource;
                adminLeaveDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        // DESCRIPTION: Displays all leave requests (oldest to newest, by start date of request)
        private void displayAllRequests()
        {
            try
            {
                cmd.CommandText = @"select
                                    lm.userID as 'User ID',
                                    concat(emp.firstName, ' ', emp.lastName) as 'Employee',
                                    lm.dateStart as 'Request Start',
                                    lm.dateEnd as 'Request End',
                                    DATE(lm.created) as 'Requested On',
                                    lm.approvalStatus
                                    from dbo.leavemgmt lm
                                    join dbo.user emp
                                        on emp.userID = lm.userID
                                    order by lm.dateStart";
                pendingLeave = connection.ExecuteDataTable(cmd);
                bindingSource.DataSource = pendingLeave;
                adminLeaveDataGrid.DataSource = bindingSource;
                adminLeaveDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        // DESCRIPTION: Logs user out of application
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        //DESCRIPTION: Returns user to menu screen

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // DESCRIPTION: Handler for when checkbox is checked
        private void checkAllRequests_CheckedChanged(object sender, EventArgs e)
        {
            // if checked
            if(checkAllRequests.Checked == true)
            {
                displayAllRequests();
            }
            //if not checked
            else if(checkAllRequests.Checked == false)
            {
                displayPendingRequests();
            }
        }
    }
}
