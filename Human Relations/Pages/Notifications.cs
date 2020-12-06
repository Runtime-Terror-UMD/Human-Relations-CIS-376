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
        private notificationClass updateNotification;
        private DataTable notificationData = new DataTable();
        private int userID;
        private int notificationID;


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

        // DESCRIPTION: Clears group box values
        private void resetGBox()
        {
            txtNotificationText.Clear();
            startDatePicker.Value = DateTime.Now.Date;
            EndDatePicker.Value = DateTime.Now.Date;
            EndDatePicker.Visible = false;
            rBtnEndDate.Checked = false;
            cBoxType.SelectedIndex = -1;
        }

        //DESCRIPTION: Logs user out of application
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoggedActivity loginActivity = new LoggedActivity();
            loginActivity.logActivity(13, userID, 0, DateTime.Now, userID); 
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

        // DESCRIPTION: Validates fields of gBox
        private bool validateFields()
        {
            lblError.Visible = false;
            // if no text entered
            if (string.IsNullOrWhiteSpace(txtNotificationText.Text))
            {
                displayError("Notification text is requred");
                return false;
            }
            // if text entered is longer than 250 charcters
            else if (txtNotificationText.Text.Length > 250)
            {
                displayError("Notifications are limited to 250 characters");
                return false;
            }
            // if start date is before today
            else if (startDatePicker.Value < DateTime.Today.Date)
            {
                displayError("Start date cannot be in the past");
                return false;
            }
            else if (cBoxType.SelectedIndex <= -1)
            {
                displayError("Notification type is requred");
                return false;
            }
            // if end date is specified
            else if (rBtnEndDate.Checked == true)
            {
                // if end date is before today
                if (EndDatePicker.Value < DateTime.Today.Date)
                {
                    displayError("End date cannot be in the past");
                    return false;
                }
                // if end date is before start date
                else if (EndDatePicker.Value < startDatePicker.Value)
                {
                    displayError("Start date cannot be after end date");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

// DESCRIPTION: Shows new notification details window
        private void btnNewNotification_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            gBoxDetails.Visible = true;
            btnCreateNotification.Visible = true;
            btnUpdateNotification.Visible = false;
            resetGBox();
        }

        // DESCRIPTION: Validates data and creates notification
        private void btnCreateNotification_Click(object sender, EventArgs e)
        {
            if (validateFields() == true)
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
                if (rBtnEndDate.Checked == true)
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
                if (cBoxType.SelectedItem.ToString() == "Admins Only")
                {
                    AdminOnly = true;
                }
                else
                {
                    AdminOnly = false;
                }
                // if start date in future
                if (startDate >= DateTime.Today.Date)
                {
                    isActive = true;
                }
                else
                {
                    isActive = false;
                }
                createNotification = new notificationClass();
                // create notification
                if (createNotification.createNotification(notificationText, startDate, endDate, userID, AdminOnly, isActive))
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

        // DESCRIPTION: Loads selected notificaiton data into group box
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnUpdateNotification.Visible = true;
            btnCreateNotification.Visible = false;

            // if no rows in data grid
            if (notificationDataGrid.Rows.Count == 0)
            {
                lblError.Text += " There are no active notifications";
                lblError.Visible = true;
            }
            // if no rows selected
            else if (notificationDataGrid.SelectedRows.Count == 0)
            {
                lblError.Text += " Please select a row";
                lblError.Visible = true;
            }
            else
            {
                // create notiifcationClass object for selected notification
                notificationID = Int32.Parse(notificationDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                updateNotification = new notificationClass(notificationID);

                // set gBoxDetails values
                gBoxDetails.Visible = true;
                txtNotificationText.Text = updateNotification.notificationText;
                startDatePicker.Value = (DateTime)updateNotification.startDate;
                if(updateNotification.endDate is null)
                {
                    EndDatePicker.Visible = false;
                    rBtnEndDate.Checked = false;
                }
                else
                {
                    rBtnEndDate.Checked = true;
                    EndDatePicker.Value = (DateTime)updateNotification.endDate;
                }
                if(updateNotification.AdminOnlyNotification == true)
                {
                    cBoxType.SelectedIndex = 0;
                }
                else
                {
                    cBoxType.SelectedIndex = 1;
                }
            }
        }

        private void btnUpdateNotification_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            if (validateFields() == true)
            {
                // make updates to notification object
                updateNotification.notificationText = txtNotificationText.Text;
                updateNotification.startDate = startDatePicker.Value;
                if (rBtnEndDate.Checked == true)
                {
                    updateNotification.endDate = EndDatePicker.Value;
                }
                else
                {
                    updateNotification.endDate = null;
                }
                if (cBoxType.SelectedItem.ToString() == "Admins Only")
                {
                    updateNotification.AdminOnlyNotification = true;
                }
                else
                {
                    updateNotification.AdminOnlyNotification = false;
                }
                if (updateNotification.startDate >= DateTime.Today.Date)
                {
                    updateNotification.isActive = true;
                }
                else
                {
                    updateNotification.isActive = false;
                }
                // update notification in database
                if(updateNotification.updateNotifcation())
                {
                    lblError.ForeColor = System.Drawing.Color.Green;
                    lblError.Text = "Notification updated successfully";
                    lblError.Visible = true;
                    populateTable();
                }
                else
                {
                    displayError("Unable to update notification");
                }
            }
        }
    }
}

