using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hotel_Reservation_Overhaul
{
    public partial class Login : Form
    {
        private Utilities verifyCredentials = new Utilities();
        public Login()
        {
            InitializeComponent();
        }

        // DESCRIPTION: Utility function for error display
        private void displayError(string errorMessage)
        {
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }

        

        // DESCRIPTION: checks if user is customer account
        private bool isAdmin(string username)
        {
            Utilities getUserID = new Utilities();
            int userID = getUserID.getUserIDFromUsername(username);
            User isAdminCheck = new User(userID);
            bool adminAcct = false;

            if(isAdminCheck.isAdmin == true)
            
            { adminAcct = true; }
        
            return adminAcct;
        }
        
         // DESCRIPTION: Login process
         private void btnLogin_Click(object sender, EventArgs e)
        {
            Utilities account = new Utilities();
            // reset error status
            lblError.Visible = false;

            // if username not entered
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                displayError("Username is required");
            }
            // if password not entered
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                displayError("Password is required");
            }

            else
            {
                if(verifyCredentials.usernameExists(txtUsername.Text))
                {
                    if(verifyCredentials.passwordMatches(txtUsername.Text, txtPassword.Text))
                    {
                        if(isAdmin(txtUsername.Text))
                        {
                            // re-drecit to menu, hide hotel management button
                            var menuScreen = new Menu(true, verifyCredentials.getUserIDFromUsername(txtUsername.Text), this, true);
                            menuScreen.FormClosed += new FormClosedEventHandler(menuScreen_FormClosed);
                            this.Hide();
                            menuScreen.Show();
                        }
                        else
                        {   // re-drecit to menu, show hotel management button
                            var menuScreen = new Menu(false, verifyCredentials.getUserIDFromUsername(txtUsername.Text), this);
                            menuScreen.FormClosed += new FormClosedEventHandler(menuScreen_FormClosed);
                            this.Hide();
                            menuScreen.Show();
                        }                       
                    }
                    else
                    {
                        displayError("Invalid password");
                    }    
                }
                else
                {
                    displayError("Username does not exist");
                }
            }
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void menuScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


    }
}
