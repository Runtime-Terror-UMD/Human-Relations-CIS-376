using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Human_Relations.Pages
{
    public partial class History : Form
    {
        DBConnect reportConn = new DBConnect();
        DataTable ReportData = new DataTable();
        BindingSource bindingSource1 = new BindingSource();
        MySqlCommand cmd = new MySqlCommand();
        int empUserID;
        Utilities verifyUser = new Utilities();
        LoggedActivity verifyLog = new LoggedActivity();
        User userinfo;

        public History()
        {
            InitializeComponent();
        }

        private void displayError(string error)
        {
            lblError.Text = "Error: " + error;
            lblError.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }


        // DESCRIPTION: verifies fields and pulls activity log report
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                displayError("User ID is required");
            }
            else if (!(int.TryParse(txtUserID.Text, out empUserID)))
            {
                displayError("User ID must be an integer");
            }
            else if (!(verifyUser.userIDExists(empUserID)))
            {
                displayError("User ID does not exist");
            }
            else if (!verifyLog.checkForLoggedActivity(empUserID))
            {
                displayError("No activity logged for this user");
            }
            else
            {
                userinfo = new User(empUserID);
                txtName.Text = userinfo.firstName + " " + userinfo.lastName;
                
                try
                {
                    cmd.CommandText = @"SELECT 
                                    atype.activityTypeDescription AS 'Action',
                                    DATE(al.created) AS 'Date',
                                    CASE
	                                    when effected.userID IS NULL THEN 'N/A'
	                                    ELSE concat(effected.firstName, ' ', effected.lastname) 
                                        END 'Effected User',
                                    al.effectedUser AS 'Effected User ID'
                                    FROM dbo.activitylog al
                                    JOIN dbo.user adminuser
	                                    on al.createdBy = adminuser.userID
                                    LEFT JOIN dbo.user effected
	                                    on al.effectedUser = effected.userID
                                    join dbo.activitytype atype
	                                    on atype.activityTypeID = al.activityTypeID
                                    where al.createdBy = @userID
                                    order by al.created desc";
                    cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = txtUserID.Text;

                    ReportData = reportConn.ExecuteDataTable(cmd);
                    bindingSource1.DataSource = ReportData;
                    reportDataGrid.DataSource = bindingSource1;
                    reportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }
    }
}
