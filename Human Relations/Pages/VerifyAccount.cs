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
    public partial class VerifyAccount : Form
    {
        public User userInfo;
        public int ZIPInt;

        //DESCRIPTION: Fills in existing fields

        public VerifyAccount(int userID)
        {
            InitializeComponent();
            userInfo = new User(userID);
            txtFName.Text = userInfo.firstName;
            txtLName.Text = userInfo.lastName;
            txtAddress1.Text = userInfo.address1;
            txtAddress2.Text = userInfo.address2;
            txtCity.Text = userInfo.city;
            cBoxStates.SelectedItem = userInfo.state;
            txtZIP.Text = userInfo.zip.ToString();
            txtPhoneNum.Text = userInfo.phoneNum;
        }

        //DESCRIPTION: Displays error message

        private void displayError(string errorMessage)
        {
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }

        //DESCRIPTION: Returns user to login screen

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //DESCRIPTION: Verifies entries and updates user data

        private void btnNew_Click(object sender, EventArgs e)
        {
            // checks that first name is entered
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
            else if(txtZIP.TextLength < 5)
            {
                displayError("Zip code must have 5 numbers");
            }
            // checks that phone number is entered
            else if (!(txtPhoneNum.MaskCompleted))
            {
                displayError("Phone number is required");
            }
            // checks that current password is entered
            else if (string.IsNullOrWhiteSpace(txtCurrPW.Text))
            {
                displayError("Current password is required");
            }
            // checks that new password is entered
            else if (string.IsNullOrWhiteSpace(txtNewPW.Text))
            {
                displayError("New password is required");
            }
            // all fields are good. Proceed with update process
            else
            {
                Utilities verifyAccount = new Utilities();
                // check that entered current password matches
                if (verifyAccount.passwordMatches(userInfo.username, txtCurrPW.Text))
                {
                    // if new password is the same as current password
                    if (txtCurrPW.Text == txtNewPW.Text)
                    {
                        displayError("New password cannot match current password");
                    }
                    else
                    {   // update user object
                        userInfo.address1 = txtAddress1.Text;
                        userInfo.address2 = txtAddress2.Text;
                        userInfo.city = txtCity.Text;
                        userInfo.state = cBoxStates.SelectedItem.ToString();
                        userInfo.zip = ZIPInt;
                        userInfo.password = txtNewPW.Text;
                        userInfo.firstName = txtFName.Text;
                        userInfo.lastName = txtLName.Text;
                        userInfo.phoneNum = txtPhoneNum.Text;


                        // update user row in database
                        if (userInfo.updateUser(userInfo))
                        {
                            // add verification to activity log
                            LoggedActivity logVerification = new LoggedActivity();
                            logVerification.logActivity(14, userInfo.userID, userInfo.userID, DateTime.Now, userInfo.userID);

                            // display success message
                            lblError.ForeColor = Color.Green;
                            lblError.Text = "Account verified successfully";
                            lblError.Visible = true;

                        }
                        else
                        {
                            //something went wrong with the Database
                            displayError("Unable to verify account. Contact IT");
                        }
                    }
                } 
                // password doesn't match
                else
                {
                    displayError("Invalid current password entered");
                }
            }

            }
          
        }
    }

