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

namespace Human_Relations
{
    public partial class NewAccount : Form
    {
        int loggedUserID;
        public NewAccount(int loggedInID)
        {
            InitializeComponent();
            this.pickHireDate.MinDate = DateTime.Now;
            this.pickHireDate.Value = DateTime.Now;
            this.loggedUserID = loggedInID;
        }

        private void displayError(string errorMessage)
        {
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }

        // DESCRIPTION: Begins user account creation process
        private void btnNew_Click(object sender, EventArgs e)
        {
            //reset error status
            lblError.Visible = false;

            Utilities verifyNewAccount = new Utilities();

            // check that fields are entered and valid

            // if no account type selected
            if ((rbtnAdmin.Checked == false) && (rbtnEmployee.Checked == false))
            {
               displayError("Please select account type");
            }
            // if first name not entered
            else if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                displayError("First Name is required");
            }
            // if last name not entered
            else if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                displayError("Last Name is required");
            }
            //if username is not entered
            else if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                displayError("Username is required");
            }
            else if (verifyNewAccount.usernameExists(txtUsername.Text))
            {
                displayError("Username already exists");
            }
            // if email not entered
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                displayError("Email address is required");
            }
            // if email format is invalid
            else if (!(verifyNewAccount.isValidEmail(txtEmail.Text)))
            {
                displayError("Invalid email format");
            }
            // if password not entered
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                displayError("Password is required");
            }
            // if payrate is not entered
            else if (string.IsNullOrWhiteSpace(txtPayRate.Text))
            {
                displayError("Password is required");
            }
            // if hire date is not checked
            else if (!pickHireDate.Checked)
            {
                displayError("hiredate is required");
            }
            // if payrate is not entered
            else if ((txtPayRate.Text.Length) > 45)
            {
                displayError("Password cannot exceed 45 characters");
            }
            // if role is not selected
            else if (cBoxRole.SelectedIndex <= -1)
            {
                displayError("Please select a Role");
            }
            // if department is not selected
            else if (cBoxDepartment.SelectedIndex <= -1)
            {
                displayError("Please select a Department");
            }
            
            else
            {
                //Fields are entered and valid. Proceed with mySQL
                // if email address already in use
                if (verifyNewAccount.emailExists(txtEmail.Text))
                {
                    displayError("Email address already in use");
                }
                else
                {
                    // Everything is good. Create user account
                    
                    MySqlCommand cmd = new MySqlCommand(@"INSERT INTO `dbo`.`user`(`isAdmin`,`firstName`,`lastName`,`username`,`email`,`password`,`payrate`,`hiredate`,`roleID`,`depID`,`isActive`,`ptoTime`)
                                                        VALUES(@isAdmin,@firstName,@lastName,@username,@email,@password,@payrate,@hiredate,@roleID,@depID,@isActive,@ptoTime)");

                    // assign parameter values
                    cmd.Parameters.Add("@isAdmin", MySqlDbType.Bit);
                    cmd.Parameters.Add("@firstName", MySqlDbType.VarChar, 45).Value = txtFirstName.Text;
                    cmd.Parameters.Add("@lastName", MySqlDbType.VarChar, 45).Value = txtLastName.Text;
                    cmd.Parameters.Add("@username", MySqlDbType.VarChar, 45).Value = txtUsername.Text;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = txtEmail.Text;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar, 45).Value = txtPassword.Text;
                    cmd.Parameters.Add("@payrate", MySqlDbType.Decimal).Value = txtPayRate.Text;
                    cmd.Parameters.Add("@ptoTime", MySqlDbType.Decimal).Value = 0;
                    cmd.Parameters.Add("@hiredate", MySqlDbType.DateTime).Value = pickHireDate.Value;
                    cmd.Parameters.Add("@roleID", MySqlDbType.VarChar, 45).Value = cBoxRole.SelectedValue;
                    cmd.Parameters.Add("@depID", MySqlDbType.VarChar).Value = cBoxDepartment.SelectedValue;
                    cmd.Parameters.Add("@isActive", MySqlDbType.Bit).Value = 1;
                    

                    // set user type

                    if (rbtnAdmin.Checked == true)
                    { cmd.Parameters["@isAdmin"].Value = 1; }
                    else { cmd.Parameters["@isAdmin"].Value = 0; }

                    // set department id value
                    switch (cBoxDepartment.SelectedIndex)
                    {
                        case 0:
                            cmd.Parameters["@depID"].Value = 1;
                            break;
                        case 1:
                            cmd.Parameters["@depID"].Value = 2;
                            break;
                        case 2:
                            cmd.Parameters["@depID"].Value = 3;
                            break;
                        case 3:
                            cmd.Parameters["@depID"].Value = 4;
                            break;
                        case 4:
                            cmd.Parameters["@depID"].Value = 5;
                            break;
                        case 5:
                            cmd.Parameters["@depID"].Value = 6;
                            break;
                        case 6:
                            cmd.Parameters["@depID"].Value = 7;
                            break;
                        case 7:
                            cmd.Parameters["@depID"].Value = 8;
                            break;
                        case 8:
                            cmd.Parameters["@depID"].Value = 9;
                            break;
                        case 9:
                            cmd.Parameters["@depID"].Value = 10;
                            break;
                        case 10:
                            cmd.Parameters["@depID"].Value = 11;
                            break;
                    }

                    //set role id type
                    switch (cBoxRole.SelectedIndex)
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

                    // connect to database
                    DBConnect userCreationConn = new DBConnect();

                    // execute statement
                    if(userCreationConn.NonQuery(cmd) > 0)
                    {
                        //logging activity "created a new acount
                        LoggedActivity logging = new LoggedActivity();
                        string astring = txtUsername.Text;
                        int userid = verifyNewAccount.getUserIDFromUsername(txtUsername.Text);
                        logging.logActivity(14, userid, userid, DateTime.Now, loggedUserID);
                    }
                    else
                    {
                        displayError("Error creating account");
                    }
                    this.Close();
                }
            }
        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoggedActivity loginActivity = new LoggedActivity();
            loginActivity.logActivity(13, loggedUserID, 0, DateTime.Now, loggedUserID);
            this.Close();
            Application.OpenForms["ManageEmp"].Close();
            Application.OpenForms["Menu"].Close();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dboDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dboDataSet.department);
            // TODO: This line of code loads data into the 'dboDataSet.role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.dboDataSet.role);

        }
    }
}
