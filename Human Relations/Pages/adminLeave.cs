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
        public adminLeave()
        {
            InitializeComponent();
            //display pending leave requests when the page opens
            displayPendingLeave();
        }
            private void displayPendingLeave() {
                try
                {
                    DBConnect connection = new DBConnect();
                    DataTable pendingLeave = new DataTable();
                    BindingSource bindingSource = new BindingSource();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = @"select
                                    lm.leaveID as 'leave ID',
                                    lm.userID as 'User ID',
                                    concat(emp.firstName, ' ', emp.lastName) as 'Employee',
                                    lm.dateStart as 'Request Start',
                                    lm.dateEnd as 'Request End',
                                    DATE(lm.created) as 'Requested On',
                                    lm.approvalStatus,
                                    lm.applyPTO as 'Apply PTO'
                                    from dbo.leavemgmt lm
                                    join dbo.user emp
                                        on emp.userID = lm.userID
                                    where lm.approvalstatus = 'Pending'
                                    order by lm.created desc";
                    //cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = UserID;
                    //cmd.Parameters.Add("@currentDate", MySqlDbType.DateTime).Value = DateTime.Today;
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
            
        

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ac_butn_Click_Click(object sender, EventArgs e)
        {
            if (adminLeaveDataGrid.Rows.Count == 0)
            {
                lblrequesterror.Text = " The selected date has no scheduled shifts";
                lblrequesterror.Visible = true;
            }
            else if (adminLeaveDataGrid.SelectedRows.Count == 0)
            {
                lblrequesterror.Text = " Please select a row";
                lblrequesterror.Visible = true;
            }
            else if (adminLeaveDataGrid.SelectedRows.Count > 1)
            {
                lblrequesterror.Text = " Please select one row";
                lblrequesterror.Visible = true;
            }
            else
            {
                DBConnect updateStatus = new DBConnect();
                MySqlCommand cmd = new MySqlCommand(@"UPDATE `dbo`.`leavemgmt` SET `approvalStatus` = 'approved' WHERE (`leaveID` = @leaveID);");
                cmd.Parameters.Add("@leaveID", MySqlDbType.Int32).Value = Int32.Parse(adminLeaveDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                if (updateStatus.NonQuery(cmd) > 0)
                {
                    string check = adminLeaveDataGrid.SelectedRows[0].Cells[7].Value.ToString();
                    string sdate = adminLeaveDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                    string edate = adminLeaveDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                    string userID = adminLeaveDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                    cmd.CommandText = @"SELECT payRate, ptoTime FROM dbo.user where userID = '@userID';";
                    cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = Int32.Parse(adminLeaveDataGrid.SelectedRows[0].Cells[1].Value.ToString());
                    MySqlDataReader dataReader = updateStatus.ExecuteReader(cmd);

                    if (check == "Yes")
                    {
                        //cmd.CommandText =@"Insert"
                    }
                    lblrequesterror.Text = "The Request was accepted";
                    lblrequesterror.ForeColor = Color.Green;
                    lblrequesterror.Visible = true;
                    displayPendingLeave();
                }
                else
                {
                    //change
                    lblrequesterror.Text = "Accepting was unsuccessful";
                    lblrequesterror.ForeColor = Color.Red;
                    lblrequesterror.Visible = true;
                }

            }
        }

        private void Dec_butn_Click_Click(object sender, EventArgs e)
        {
            if (adminLeaveDataGrid.Rows.Count == 0)
            {
                lblrequesterror.Text = " The selected date has no scheduled shifts";
                lblrequesterror.Visible = true;
            }
            else if (adminLeaveDataGrid.SelectedRows.Count == 0)
            {
                lblrequesterror.Text = " Please select a row";
                lblrequesterror.Visible = true;
            }
            else if (adminLeaveDataGrid.SelectedRows.Count > 1)
            {
                lblrequesterror.Text = " Please select one row";
                lblrequesterror.Visible = true;
            }
            else
            {
                DBConnect updateStatus = new DBConnect();
                MySqlCommand cmd = new MySqlCommand(@"UPDATE `dbo`.`leavemgmt` SET `approvalStatus` = 'Declined' WHERE (`leaveID` = @leaveID);");
                cmd.Parameters.Add("@leaveID", MySqlDbType.Int32).Value = Int32.Parse(adminLeaveDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                if (updateStatus.NonQuery(cmd) > 0)
                {
                    lblrequesterror.Text = "The Request was Declined";
                    lblrequesterror.ForeColor = Color.Green;
                    lblrequesterror.Visible = true;
                    displayPendingLeave();
                }
                else
                {
                    lblrequesterror.Text = "Declining was unsuccessful";
                    lblrequesterror.ForeColor = Color.Green;
                    lblrequesterror.Visible = true;
                }
            }
        }
    }
}
