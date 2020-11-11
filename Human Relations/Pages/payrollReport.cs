using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Human_Relations.Pages
{
    public partial class payrollReport : Form
    {
        private User userinfo;
        private double minutesWorked;
        private double hoursWorked;
        private double amountEarned;
        public payrollReport(int userID)
        {
            InitializeComponent();
            userinfo = new User(userID);
        }

// DESCRIPTION: Loads comboBox data
        private void payrollReport_Load(object sender, EventArgs e)
        {
            // loads data
            this.payperiodsTableAdapter.Fill(this.dboDataSet.payperiods);

        }

 // DESCRIPTION: Logs the user out
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

// DESCRIPTION: Returns to the menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

// DESCRIPTION: Pulls name, total hours, and total amount earned for user for selected pay Period
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            // SQL Query pulls total minutes worked and total amount earned for payPeriod and userID
            DBConnect payrollReportConn = new DBConnect();
            MySqlCommand payrollReportCmd = new MySqlCommand(@"SELECT IFNULL(SUM(TIMESTAMPDIFF(minute, inDateTime, outDateTime)), 0) AS 'Minutes',
                                                            IFNULL(SUM(totalPay), 0) as 'TotalPay'
                                                            from dbo.timetracking
                                                            where userID = @userID
                                                            and payPeriodID = @payPeriodID;");
            payrollReportCmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userinfo.userID;
            payrollReportCmd.Parameters.Add("@payPeriodID", MySqlDbType.Int32).Value = cBoxPayPeriodID.SelectedValue;

            MySqlDataReader dataReader = payrollReportConn.ExecuteReader(payrollReportCmd);

            //Read the data and store them in values
            while (dataReader.Read())
            {
                minutesWorked = Convert.ToDouble(dataReader["Minutes"]);
                amountEarned = Convert.ToDouble(dataReader["TotalPay"]);
            }
            //close Data Reader
            dataReader.Close(); ;

            // divide minutesWorked by 60 to get hoursWorked
            hoursWorked = minutesWorked / 60;

            // fill text boxes
            txtName.Text = userinfo.firstName + " " + userinfo.lastName;
            txtHoursWorked.Text = String.Format("{0:F1}", hoursWorked);
            txtAmtMade.Text = (amountEarned.ToString("C", CultureInfo.CurrentCulture));
        }
    }
}

