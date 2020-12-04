using Human_Relations.Utilities_Classes;
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

        public adminLeave()
        {
            InitializeComponent();
            //display pending leave requests when the page opens
            displayPendingRequests();

        }

// DESCRIPTION: Displays all pending leave requests (oldest to newest, by start date of request)
        private void displayPendingRequests()
        {
            try
            {
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


        // DESCRIPTION: Displays all leave requests (oldest to newest, by start date of request)
        private void displayAllRequests()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();

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
                    payroll getpayP = new payroll();
                    string check = adminLeaveDataGrid.SelectedRows[0].Cells[7].Value.ToString();
                    string sdate = adminLeaveDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                    string edate = adminLeaveDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                    string userID = adminLeaveDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                    int USERID = Int16.Parse(userID);
                    cmd.CommandText = @"SELECT payRate, ptoTime FROM dbo.user where userID = '@userID';";
                    cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = Int32.Parse(adminLeaveDataGrid.SelectedRows[0].Cells[1].Value.ToString());
                    var use = new User(USERID);
                    double totalPay = use.payRate * use.ptoTime;
                    DateTime s = Convert.ToDateTime(sdate).Date;
                    DateTime s2 = Convert.ToDateTime(edate).Date;
                    double total = (double)(s2 - s).TotalDays;
                    DBConnect clockOutConn = new DBConnect();
                    int payP= getpayP.getPayPeriod(s.Month, s.Day);
                    if ((total * 8) <= use.ptoTime)
                    {
                        double totH = total * 8;
                        totalPay = totH * use.payRate;
                        MySqlCommand clockOutCmd = new MySqlCommand(@"UPDATE dbo.user
                                                        SET ptoTime = @ptoTime
                                                        WHERE userID = @userID; ");
                        clockOutCmd.Parameters.Add("@ptoTime", MySqlDbType.Double).Value =totH;
                        clockOutCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = USERID;

                        if (clockOutConn.NonQuery(clockOutCmd) > 0)
                        {
                            
                        }
                        else
                        {

                            lblrequesterror.Text = "Your Database was not updated";
                        }

                    }
                    else if ((total * 8) > use.ptoTime)
                    {
                        totalPay = use.payRate * use.ptoTime;
                        MySqlCommand clockOutCmd = new MySqlCommand(@"UPDATE dbo.user
                                                        SET ptoTime = @ptoTime
                                                        WHERE userID = @userID; ");
                        clockOutCmd.Parameters.Add("@ptoTime", MySqlDbType.Double).Value = 0.00;
                        clockOutCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = USERID;

                        if (clockOutConn.NonQuery(clockOutCmd) > 0)
                        {

                        }
                        else
                        {

                            lblrequesterror.Text = "Your Database was not updated";
                        }
                    }
                    DBConnect paidvacConn = new DBConnect();
                    MySqlCommand paidvac = new MySqlCommand(@"INSERT INTO dbo.timetracking
                                                            (userID,
                                                            payPeriodID,
                                                            inDateTime,
                                                            outDateTime,
                                                            totalPay,
                                                            shifton)
                                                            VALUES
                                                            (@userID,
                                                            @payPeriodID,
                                                            @inDateTime,
                                                            @outDateTime,
                                                            @totalPay,
                                                            @shifton)");

                    paidvac.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;
                    paidvac.Parameters.Add("@payPeriodID", MySqlDbType.Int32).Value = payP;
                    paidvac.Parameters.Add("@inDateTime", MySqlDbType.DateTime).Value = s;
                    paidvac.Parameters.Add("@outDateTime", MySqlDbType.DateTime).Value = s2;
                    paidvac.Parameters.Add("@totalPay", MySqlDbType.Double).Value = totalPay;
                    paidvac.Parameters.Add("@shifton", MySqlDbType.Bit).Value = 0;

                    if (paidvacConn.NonQuery(paidvac) > 0)
                    {

                    }
                    else
                    {
                        lblrequesterror.Text = "Your Database was not updated";
                    }

                    //Login login = new Login();
                   // Menu off = new Menu(login, s);
                    lblrequesterror.Text = "The Request was accepted";
                    lblrequesterror.ForeColor = Color.Green;
                    lblrequesterror.Visible = true;
                    displayPendingRequests();
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
                    displayPendingRequests();
                }
                else
                {
                    lblrequesterror.Text = "Declining was unsuccessful";
                    lblrequesterror.ForeColor = Color.Green;
                    lblrequesterror.Visible = true;
                }
            }
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
