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
            //display pending leave requests (oldest first) when the page opens
            try
            {
                DBConnect connection = new DBConnect();
                DataTable pendingLeave = new DataTable();
                BindingSource bindingSource = new BindingSource();
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
                                    where lm.approvalstatus = 'Pending'
                                    order by lm.created";
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
    }
}
