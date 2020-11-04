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
    public partial class ManageProfile : Form
    {
        public int userID;
        public User current;
        public ManageProfile(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            current = new User(userID);
            txtID.Text = "" + current.userID;
            txtfname.Text = "" + current.firstName;
            txtlname.Text = "" + current.lastName;
            txtUsername.Text = "" + current.username;
            txtEmail.Text = "" + current.email;
            txtAddress.Text = current.address1 + "\r\n" + ((current.address2 != "") ? current.address2 + "\r\n" : "") + current.city + "\r\n" + current.state + "\r\n" + current.zip;
            txtPhoneNum.Text = "" + current.phoneNum;
            switch (current.depID)
            {
                case 1:
                    txtDept.Text = "Administration";
                    break;
                case 2:
                    txtDept.Text = "Executive";
                    break;
                case 3:
                    txtDept.Text = "Finance";
                    break;
                case 4:
                    txtDept.Text = "Human Resources";
                    break;
                case 5:
                    txtDept.Text = "Information Technology";
                    break;
                case 6:
                    txtDept.Text = "Maintenance";
                    break;
                case 7:
                    txtDept.Text = "Productions";
                    break;
                case 8:
                    txtDept.Text = "Projects";
                    break;
                case 9:
                    txtDept.Text = "Quality";
                    break;
                case 10:
                    txtDept.Text = "Research";
                    break;
                case 11:
                    txtDept.Text = "Sales";
                    break;
                case 12:
                    txtDept.Text = "Security";
                    break;
            }

            //set role id type
            switch (current.roleID)
            {
                case 1:
                    txtRole.Text = "Associate Staff";
                    break;
                case 2:
                    txtRole.Text = "Intermediate Staff";
                    break;
                case 3:
                    txtRole.Text = "Senior Staff";
                    break;
                case 4:
                    txtRole.Text = "Manager";
                    break;
                case 5:
                    txtRole.Text = "Senior Manager";
                    break;
                case 6:
                    txtRole.Text = "Advisor";
                    break;
                case 7:
                    txtRole.Text = "Senior Advisor";
                    break;
                case 8:
                    txtRole.Text = "Executive";
                    break;
                case 9:
                    txtRole.Text = "Senior Executive";
                    break;
                case 10:
                    txtRole.Text = "Director";
                    break;
                case 11:
                    txtRole.Text = "Senior Director";
                    break;
            }
            txtHireDate.Text = "" + current.hireDate;
            txtPayRate.Text = "" + current.payRate;
        }

        private void errorMessage(string errorText)
        {
            lblError.Text = "Error: " + errorText;
            lblError.Visible = true;
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnSubmit.Visible = true;
            txtfname.Enabled = true;
            txtPhoneNum.Enabled = true;
            txtlname.Enabled = true;
            txtEmail.Enabled = true;
            txtUsername.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Utilities verifyNewAccount = new Utilities();

            // checks that first name is entered
            if (string.IsNullOrWhiteSpace(txtfname.Text))
            {
                errorMessage("First name is required");
            }
            // check that last name is entered
            else if (string.IsNullOrWhiteSpace(txtlname.Text))
            {
                errorMessage("Last name is required");
            }
            else if (!(txtPhoneNum.MaskCompleted))
            {
                errorMessage("Phone number is required");
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorMessage("Username is required");
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorMessage("Email is required");
            }
            else if (!(verifyNewAccount.isValidEmail(txtEmail.Text)))
            {
                errorMessage("Invalid email format");
            }
            //cannot change if username already exists
            else if (txtUsername.Text != current.username && verifyNewAccount.usernameExists(txtUsername.Text))
            {
                errorMessage("Username is already taken.");
            }
            else
            {
                current.firstName = txtfname.Text;
                current.lastName = txtlname.Text;
                current.phoneNum = txtPhoneNum.Text;
                current.email = txtEmail.Text;
                current.username = txtUsername.Text;

                // update user row in database
                if (current.updateUser(current))
                {
                    // add verification to activity log
                    LoggedActivity logVerification = new LoggedActivity();
                    logVerification.logActivity(2, current.userID, current.userID, DateTime.Now, current.userID);

                    // display success message
                    MessageBox.Show("Account profile updated successfully");
                    lblError.Visible = false;

                    //disable labels and boxes
                    btnEdit.Visible = true;
                    btnSubmit.Visible = false;
                    txtfname.Enabled = false;
                    txtPhoneNum.Enabled = false;
                    txtlname.Enabled = false;
                    txtEmail.Enabled = false;
                    txtUsername.Enabled = false;

                }
                else
                {
                    //something went wrong with the Database
                    errorMessage("Unable to update account. Contact IT");
                }
            }
        }

        private void btnChangeAddress_Click(object sender, EventArgs e)
        {
            int ZIPInt;
            //check that all required fields are there
            if (string.IsNullOrEmpty(txtAddress1.Text))
            {
                errorMessage("Street address is required.");
            }
            else if (string.IsNullOrEmpty(txtCity.Text))
            {
                errorMessage("City address is required.");
            }
            else if (string.IsNullOrEmpty(txtCity.Text))
            {
                errorMessage("City is required.");
            }
            else if (cBoxStates.SelectedIndex == -1)
            {
                errorMessage("State is required.");
            }
            // check that zip code is entered
            else if (string.IsNullOrWhiteSpace(txtZIP.Text))
            {
                errorMessage("ZIP code is required.");
            }
            // checks ZIP code is a number
            else if (!(int.TryParse(txtZIP.Text, out ZIPInt)))
            {
                errorMessage("Invalid ZIP code.");
            }
            else if (txtZIP.TextLength < 5)
            {
                errorMessage("Zip code must have 5 numbers.");
            }
            else //update address
            {
                current.address1 = txtAddress1.Text;
                current.address2 = txtAddress2.Text;
                current.city = txtCity.Text;
                current.state = cBoxStates.SelectedItem.ToString();
                current.zip = ZIPInt;
                if (current.updateUser(current))
                {
                    // add verification to activity log
                    LoggedActivity logVerification = new LoggedActivity();
                    logVerification.logActivity(2, current.userID, current.userID, DateTime.Now, current.userID);

                    // display success message
                    MessageBox.Show("Account address changed successfully");
                    lblError.Visible = false;
                    txtAddress.Text = current.address1 + "\r\n" + ((current.address2 != "") ? current.address2 + "\r\n" : "") + current.city + "\r\n" + current.state + "\r\n" + current.zip;

                    txtAddress1.Clear();
                    txtAddress2.Clear();
                    txtCity.Clear();
                    cBoxStates.ResetText();
                    txtZIP.Clear();
                }
                else
                {
                    //something went wrong with the Database
                    errorMessage("Unable to verify account. Contact IT");
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Unable to change password");
            }
            Utilities accountInfo = new Utilities();
            if (accountInfo.passwordMatches(current.userID, txtCurrentPassword.Text))
            {
                current.password = txtNewPassword.Text;
                if (current.updateUser(current))
                {
                    LoggedActivity logVerification = new LoggedActivity();
                    logVerification.logActivity(9, current.userID, current.userID, DateTime.Now, current.userID);
                    MessageBox.Show("Account password changed successfully.");
                    lblError.Visible = false;
                    txtCurrentPassword.Clear();
                    txtNewPassword.Clear();
                }
                else
                {
                    errorMessage("Unable to change password.");
                }
            }
            else
            {
                errorMessage("Incorrect password. Unable to change password.");
            }
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
        }
    }
}
