using System;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using Human_Relations.Utilities_Classes;


namespace Human_Relations.Pages
{
    public partial class Notifications : Form
    {
        // objects to use on page
        BindingSource notificationBindingSource = new BindingSource();
        public notificationClass pullNotifications = new notificationClass();
        private notificationClass createNotification;
        private DataTable notificationData = new DataTable();
        private int userID;

        public Notifications(int UserID)
        {
            InitializeComponent();
            userID = UserID;
            populateTable();
        }

        // DESCRIPTION: Populates table of active notifications
        public void populateTable()
        {
            notificationData = pullNotifications.getAdminPageNotifications();
            notificationBindingSource.DataSource = notificationData;
            notificationDataGrid.DataSource = notificationBindingSource;
            notificationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // DESCRIPTION: Utility function to display error
        private void displayError(string error)
        {
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Text = "Error: " + error;
            lblError.Visible = true;
        }

        //DESCRIPTION: Logs user out of application
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }
        
        //DESCRIPTION: Returns user to menu screen
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // DESCRIPTION: shows end date time picker if user wants to set end date
        private void rBtnEndDate_CheckedChanged(object sender, EventArgs e)
        {
            lblEndDate.Visible = true;
            EndDatePicker.Visible = true;
        }

// DESCRIPTION: Shows new notification details window
        private void btnNewNotification_Click(object sender, EventArgs e)
        {
            gBoxDetails.Visible = true;
        }

// DESCRIPTION: Validates data and creates notification
        private void btnCreateNotification_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            // if no text entered
            if (string.IsNullOrWhiteSpace(txtNotificationText.Text))
            {
                displayError("Notification text is requred");
            }
            // if text entered is longer than 250 charcters
            else if(txtNotificationText.Text.Length > 250)
            {
                displayError("Notifications are limited to 250 characters");
            }
            // if start date is before today
            else if (startDatePicker.Value < DateTime.Today.Date)
            {
                displayError("Start date cannot be in the past");
            }
            else if (cBoxType.SelectedIndex <= -1)
            {
                displayError("Notification type is requred");
            }
            // if end date is specified
            else if (rBtnEndDate.Checked == true)
            {
                // if end date is before today
                if (EndDatePicker.Value < DateTime.Today.Date)
                {
                    displayError("End date cannot be in the past");
                }
                // if end date is before start date
                else if (EndDatePicker.Value < startDatePicker.Value)
                {
                    displayError("Start date cannot be after end date");
                }
            }
            else 
            {
                // fields are valid, create notification
                string notificationText;
                DateTime? startDate;
                DateTime? endDate;
                bool AdminOnly;
                bool isActive;

                // set notification text
                notificationText = txtNotificationText.Text;

                // set start date
                startDate = startDatePicker.Value;
                // if end date specified
                if(rBtnEndDate.Checked == true)
                {
                    // set end date
                    endDate = EndDatePicker.Value;
                }    
                else
                {
                    // set end date to null
                    endDate = null;
                }
                // if admin-only notification
                if(cBoxType.SelectedItem.ToString() == "Admins Only")
                {
                    AdminOnly = true;
                }
                else
                {
                    AdminOnly = false;
                }
                // if start date in future
                if(startDate >= DateTime.Today)
                {
                    isActive = false;
                }    
                else
                {
                    isActive = true;
                }
                createNotification = new notificationClass();
                // create notification
                if(createNotification.createNotification(notificationText, startDate, endDate, userID, AdminOnly, isActive))
                {
                    lblError.ForeColor = System.Drawing.Color.Green;
                    lblError.Text = "Notification created successfully";
                    lblError.Visible = true;
                    populateTable();
                }
                else
                {
                    displayError("Error creating notification");
                }
            }

        }
    }
}
