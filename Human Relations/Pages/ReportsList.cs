using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Human_Relations.Pages;
using System.Globalization;

namespace Human_Relations.Pages
{
    public partial class ReportsList : Form
    {
        int userID;
        public ReportsList()
        {
            InitializeComponent();
        }
        public ReportsList(int user)
        {
            userID = user;
            InitializeComponent();
        }

        public void errorMessage(string error)
        {
            lblError.Text = "Error: " + error;
            lblError.Visible = true;
        }

        private void ReportsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dboDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dboDataSet.department);
            // TODO: This line of code loads data into the 'dboDataSet.role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.dboDataSet.role);
        }


        DBConnect reportConn = new DBConnect();
        DataTable reportData = new DataTable();
        BindingSource reportBindingSource = new BindingSource();
        private void btnRole_Click(object sender, EventArgs e)
        {
            if(cboxRole.SelectedIndex != -1)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = @"SELECT u.userID as 'User ID', concat(u.firstName, ' ', u.lastName) as 'Name', d.depName as 'Department', u.isAdmin as 'is Admin?', u.isActive as 'isActive?', u.payRate as 'Pay Rate' FROM dbo.user u join dbo.department d on u.depID = d. depID WHERE roleID = @roleID";
                    cmd.Parameters.Add("@roleID", MySqlDbType.Int32).Value = cboxRole.SelectedValue;

                    reportData = reportConn.ExecuteDataTable(cmd);
                    reportBindingSource.DataSource = reportData;
                    reportDataGrid.DataSource = reportBindingSource;
                    reportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    lblError.Visible = false;
                }
                catch (Exception ex)
                {
                    errorMessage("SQL statement failed for role report. " + ex);
                }
            }
            else
            {
                errorMessage("No role selected.");
            }
            
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            if (cboxDepartment.SelectedIndex != -1)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = @"SELECT u.userID as 'User ID', concat(u.firstName, ' ', u.lastName) as 'Name', r.roleName as 'Role', u.isAdmin as 'is Admin?', u.isActive as 'isActive?', u.payRate as 'Pay Rate' FROM dbo.user u join dbo.role r on u.roleID = r.roleID WHERE depID = @depID";

                    cmd.Parameters.Add("@depID", MySqlDbType.Int32).Value = cboxDepartment.SelectedValue;

                    reportData = reportConn.ExecuteDataTable(cmd);
                    reportBindingSource.DataSource = reportData;
                    reportDataGrid.DataSource = reportBindingSource;
                    reportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    lblError.Visible = false;

                }
                catch (Exception ex)
                {
                    errorMessage("SQL statement failed for role report. " + ex);
                } 
            
            }
            else
            {
                errorMessage("No department selected.");
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }
    }
}
