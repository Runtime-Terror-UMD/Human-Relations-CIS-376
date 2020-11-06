using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Relations.Pages
{
    public partial class ManageEmp : Form
    {
        public int adminUserID;
        public int empUserID;
        public int ZIPInt;
        public double payRateDouble;
        public User userInfo;

        public ManageEmp()
        {
            InitializeComponent();
        }

// DESCRIPTION: Opens new employee account page
        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            var hire = new NewAccount(adminUserID);
            hire.FormClosed += new FormClosedEventHandler(NewAccount_FormClosed);
            this.Hide();
            hire.Show();
        }

// DESCRIPTION: returns to menu if new account window is closed
        private void NewAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

// DESCRIPTION: Logs user out
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }
        public ManageEmp(int UserID)
        {
            InitializeComponent();
            adminUserID = UserID;
        }

// DESCRIPTION: Displays error
        private void displayError(string errorMessage)
        {
            lblError.ForeColor = Color.Red;
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }


// DESCRIPTION return to menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageEmp_Load(object sender, EventArgs e)
        {


        }

// DESCRIPTION: Validates updated information and updates data in DB
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            Utilities checkEmail = new Utilities();

            // check all fields are valid
            if(string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                displayError("User ID of employee is required");
            }
            // check first name is entered
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                displayError("First name is required");
            }
            // check that last name is entered
            else if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                displayError("Last name is required");
            }
            // check that address line 1 is entered
            else if (string.IsNullOrEmpty(txtAddress1.Text))
            {
                displayError("Street address is required");
            }
            //check that city is entered
            else if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                displayError("City is required");
            }
            // check that state is selected
            else if (cBoxStates.SelectedIndex == -1)
            {
                displayError("State is required");
            }
            // check that zip code is entered
            else if (string.IsNullOrWhiteSpace(txtZIP.Text))
            {
                displayError("ZIP code is required");
            }
            // checks ZIP code is a number
            else if (!(int.TryParse(txtZIP.Text, out ZIPInt)))
            {
                displayError("Invalid ZIP code");
            }
            else if (txtZIP.TextLength < 5)
            {
                displayError("Zip code must have 5 numbers");
            }
            // checks that phone number is entered
            else if (!(txtPhoneNum.MaskCompleted))
            {
                displayError("Phone number is required");
            }
            // check that payRate is entered
            else if(string.IsNullOrWhiteSpace(txtPayRate.Text))
            {
                displayError("Pay Rate is required");
            }
            // check that payRate is in a valid format
            else if(!(double.TryParse(txtPayRate.Text, out payRateDouble)))
            {
                displayError("Pay Rate must be a number");
            }
            // check that email is entered
            else if(string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                displayError("E-mail address is required");
            }    
            // check that email is in a valid format
            else if(!(checkEmail.isValidEmail(txtEmail.Text)))
            {
                displayError("E-mail address is in an invalid format");
            }
            else
            {
                // update user object
                userInfo.address1 = txtAddress1.Text;
                userInfo.address2 = txtAddress2.Text;
                userInfo.city = txtCity.Text;
                userInfo.state = cBoxStates.SelectedItem.ToString();
                userInfo.zip = ZIPInt;
                userInfo.firstName = txtFName.Text;
                userInfo.lastName = txtLName.Text;
                userInfo.phoneNum = txtPhoneNum.Text;
                userInfo.payRate = payRateDouble;
                userInfo.email = txtEmail.Text;
                userInfo.roleID = Convert.ToInt32(cBoxRole.SelectedValue);
                userInfo.depID = Convert.ToInt32(cBoxDep.SelectedValue);
                if(cBoxStates.SelectedItem.ToString() == "Active")
                {
                    userInfo.isActive = true;
                }
                else 
                { 
                    userInfo.isActive = false;
                    userInfo.lastDate = DateTime.Now;
                }
                if(cBoxAdmin.SelectedItem.ToString() == "Yes")
                {
                    userInfo.isAdmin = true;
                }
                else
                {
                    userInfo.isAdmin = false;
                }

                // update user row in database
                if (userInfo.updateUser(userInfo))
                {
                    // add update to activity log
                    LoggedActivity logVerification = new LoggedActivity();
                    logVerification.logActivity(1, userInfo.userID, userInfo.userID, DateTime.Now, adminUserID);

                    // display success message
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "Employee profile updated successfully";
                    lblError.Visible = true;

                }
                else
                {
                    //something went wrong with the Database
                    displayError("Unable to update employee profile. Contact IT");
                }
            }
        }

// DESCRIPTION: Conducts search for user ID profile
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            Utilities verifyAccount = new Utilities();

            // check that userID is an int
            if (!(int.TryParse(txtUserID.Text, out empUserID)))
            {
                displayError("User ID must be an integer");
            }
            // check that userID exists
            else if (!(verifyAccount.userIDExists(empUserID)))
            {
                displayError("User ID does not exist");
            }
            // check that admin is not updating themselves
            else if (adminUserID == empUserID)
            { displayError("You must update your own profile through the 'My Account' page"); }

            else
            {
                // TODO: This line of code loads data into the 'dboDataSet.role' table. You can move, or remove it, as needed.
                this.roleTableAdapter.Fill(this.dboDataSet.role);
                // TODO: This line of code loads data into the 'dboDataSet.department' table. You can move, or remove it, as needed.
                this.departmentTableAdapter.Fill(this.dboDataSet.department);

                // fill form fields with user info

                userInfo = new User(empUserID);
                txtFName.Text = userInfo.firstName;
                txtLName.Text = userInfo.lastName;
                txtAddress1.Text = userInfo.address1;
                txtAddress2.Text = userInfo.address2;
                txtCity.Text = userInfo.city;
                cBoxStates.SelectedItem = userInfo.state;
                txtZIP.Text = userInfo.zip.ToString();
                txtPhoneNum.Text = userInfo.phoneNum;
                txtEmail.Text = userInfo.email;
                txtPayRate.Text = userInfo.payRate.ToString();
                cBoxDep.SelectedValue = userInfo.depID;
                cBoxRole.SelectedValue = userInfo.roleID;

                if (userInfo.isAdmin == true)
                {
                    cBoxAdmin.SelectedItem = "Yes";
                }
                else
                {
                    cBoxAdmin.SelectedItem = "No";
                }
                if (userInfo.isActive == true)
                {
                    cBoxStatus.SelectedItem = "Active";
                }
                else { cBoxStatus.SelectedItem = "Inactive"; }
            }
        }
    }
}
