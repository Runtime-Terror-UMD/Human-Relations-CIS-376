using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
                    cmd.CommandText = @"select userID as 'User ID', concat(firstName, ' ', lastName) as 'Name', from dbo.user where roleID = @roleID";
                    cmd.Parameters.Add("@roleID", MySqlDbType.Int32, 45).Value = cboxRole.SelectedValue;

                    //set role id type
                    switch (cboxRole.SelectedIndex)
                    {
                        case 0:
                            cmd.Parameters["@roleID"].Value = 1;
                            break;
                        case 1:
                            cmd.Parameters["@roleID"].Value = 2;
                            break;
                        case 2:
                            cmd.Parameters["@roleID"].Value = 3;
                            break;
                        case 3:
                            cmd.Parameters["@roleID"].Value = 4;
                            break;
                        case 4:
                            cmd.Parameters["@roleID"].Value = 5;
                            break;
                        case 5:
                            cmd.Parameters["@roleID"].Value = 6;
                            break;
                        case 6:
                            cmd.Parameters["@roleID"].Value = 7;
                            break;
                        case 7:
                            cmd.Parameters["@roleID"].Value = 8;
                            break;
                        case 8:
                            cmd.Parameters["@roleID"].Value = 9;
                            break;
                        case 9:
                            cmd.Parameters["@roleID"].Value = 10;
                            break;
                        case 10:
                            cmd.Parameters["@roleID"].Value = 11;
                            break;
                    }
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
                    MySqlCommand cmd = new MySqlCommand(@"select userID as 'User ID', concat(firstName, ' ', lastName) as 'Name', from dbo.user where depID = @depID");

                    cmd.Parameters.Add("@depID", MySqlDbType.Int32).Value = cboxDepartment.SelectedValue;


                    //switch (cboxDepartment.SelectedIndex)
                    //{
                    //    case 0:
                    //        cmd.Parameters["@depID"].Value = 1;
                    //        break;
                    //    case 1:
                    //        cmd.Parameters["@depID"].Value = 2;
                    //        break;
                    //    case 2:
                    //        cmd.Parameters["@depID"].Value = 3;
                    //        break;
                    //    case 3:
                    //        cmd.Parameters["@depID"].Value = 4;
                    //        break;
                    //    case 4:
                    //        cmd.Parameters["@depID"].Value = 5;
                    //        break;
                    //    case 5:
                    //        cmd.Parameters["@depID"].Value = 6;
                    //        break;
                    //    case 6:
                    //        cmd.Parameters["@depID"].Value = 7;
                    //        break;
                    //    case 7:
                    //        cmd.Parameters["@depID"].Value = 8;
                    //        break;
                    //    case 8:
                    //        cmd.Parameters["@depID"].Value = 9;
                    //        break;
                    //    case 9:
                    //        cmd.Parameters["@depID"].Value = 10;
                    //        break;
                    //    case 10:
                    //        cmd.Parameters["@depID"].Value = 11;
                    //        break;
                    //}
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
    }
}
