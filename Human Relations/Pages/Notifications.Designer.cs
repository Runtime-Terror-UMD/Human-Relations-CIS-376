namespace Human_Relations.Pages
{
    partial class Notifications
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notificationDataGrid = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblActiveNotifications = new System.Windows.Forms.Label();
            this.gBoxDetails = new System.Windows.Forms.GroupBox();
            this.btnCreateNotification = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.rBtnEndDate = new System.Windows.Forms.RadioButton();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblNotificationText = new System.Windows.Forms.Label();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtNotificationText = new System.Windows.Forms.TextBox();
            this.btnNewNotification = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdateNotification = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataGrid)).BeginInit();
            this.gBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationDataGrid
            // 
            this.notificationDataGrid.AllowUserToAddRows = false;
            this.notificationDataGrid.AllowUserToDeleteRows = false;
            this.notificationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notificationDataGrid.Location = new System.Drawing.Point(75, 221);
            this.notificationDataGrid.MultiSelect = false;
            this.notificationDataGrid.Name = "notificationDataGrid";
            this.notificationDataGrid.ReadOnly = true;
            this.notificationDataGrid.RowHeadersWidth = 62;
            this.notificationDataGrid.RowTemplate.Height = 28;
            this.notificationDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notificationDataGrid.Size = new System.Drawing.Size(1019, 278);
            this.notificationDataGrid.TabIndex = 18;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblError.Location = new System.Drawing.Point(298, 86);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(600, 38);
            this.lblError.TabIndex = 33;
            this.lblError.Text = "Error:";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(298, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 77);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1046, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 35);
            this.btnLogout.TabIndex = 31;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(16, 12);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 35);
            this.btnReturn.TabIndex = 30;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblActiveNotifications
            // 
            this.lblActiveNotifications.AutoSize = true;
            this.lblActiveNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveNotifications.Location = new System.Drawing.Point(461, 157);
            this.lblActiveNotifications.Name = "lblActiveNotifications";
            this.lblActiveNotifications.Size = new System.Drawing.Size(257, 32);
            this.lblActiveNotifications.TabIndex = 34;
            this.lblActiveNotifications.Text = "Active Notifications";
            // 
            // gBoxDetails
            // 
            this.gBoxDetails.Controls.Add(this.btnUpdateNotification);
            this.gBoxDetails.Controls.Add(this.btnCreateNotification);
            this.gBoxDetails.Controls.Add(this.lblType);
            this.gBoxDetails.Controls.Add(this.rBtnEndDate);
            this.gBoxDetails.Controls.Add(this.lblEndDate);
            this.gBoxDetails.Controls.Add(this.lblStartDate);
            this.gBoxDetails.Controls.Add(this.lblNotificationText);
            this.gBoxDetails.Controls.Add(this.cBoxType);
            this.gBoxDetails.Controls.Add(this.EndDatePicker);
            this.gBoxDetails.Controls.Add(this.startDatePicker);
            this.gBoxDetails.Controls.Add(this.txtNotificationText);
            this.gBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxDetails.Location = new System.Drawing.Point(75, 542);
            this.gBoxDetails.Name = "gBoxDetails";
            this.gBoxDetails.Size = new System.Drawing.Size(1019, 268);
            this.gBoxDetails.TabIndex = 35;
            this.gBoxDetails.TabStop = false;
            this.gBoxDetails.Text = "Notification Details";
            this.gBoxDetails.Visible = false;
            // 
            // btnCreateNotification
            // 
            this.btnCreateNotification.Location = new System.Drawing.Point(762, 209);
            this.btnCreateNotification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateNotification.Name = "btnCreateNotification";
            this.btnCreateNotification.Size = new System.Drawing.Size(225, 35);
            this.btnCreateNotification.TabIndex = 38;
            this.btnCreateNotification.Text = "Create Notification";
            this.btnCreateNotification.UseVisualStyleBackColor = true;
            this.btnCreateNotification.Click += new System.EventHandler(this.btnCreateNotification_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(595, 123);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(157, 25);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Notification Type";
            // 
            // rBtnEndDate
            // 
            this.rBtnEndDate.AutoSize = true;
            this.rBtnEndDate.Location = new System.Drawing.Point(20, 170);
            this.rBtnEndDate.Name = "rBtnEndDate";
            this.rBtnEndDate.Size = new System.Drawing.Size(153, 29);
            this.rBtnEndDate.TabIndex = 7;
            this.rBtnEndDate.TabStop = true;
            this.rBtnEndDate.Text = "Set End Date";
            this.rBtnEndDate.UseVisualStyleBackColor = true;
            this.rBtnEndDate.CheckedChanged += new System.EventHandler(this.rBtnEndDate_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(15, 219);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 25);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(10, 123);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(99, 25);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblNotificationText
            // 
            this.lblNotificationText.AutoSize = true;
            this.lblNotificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationText.Location = new System.Drawing.Point(15, 37);
            this.lblNotificationText.Name = "lblNotificationText";
            this.lblNotificationText.Size = new System.Drawing.Size(337, 25);
            this.lblNotificationText.TabIndex = 4;
            this.lblNotificationText.Text = "Notification Text (limit 250 characters)";
            // 
            // cBoxType
            // 
            this.cBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Items.AddRange(new object[] {
            "Admins Only",
            "All Employees"});
            this.cBoxType.Location = new System.Drawing.Point(784, 115);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(203, 33);
            this.cBoxType.TabIndex = 3;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(124, 214);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(329, 30);
            this.EndDatePicker.TabIndex = 2;
            this.EndDatePicker.Visible = false;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(124, 118);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(329, 30);
            this.startDatePicker.TabIndex = 1;
            // 
            // txtNotificationText
            // 
            this.txtNotificationText.Location = new System.Drawing.Point(16, 65);
            this.txtNotificationText.Multiline = true;
            this.txtNotificationText.Name = "txtNotificationText";
            this.txtNotificationText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotificationText.Size = new System.Drawing.Size(971, 35);
            this.txtNotificationText.TabIndex = 0;
            // 
            // btnNewNotification
            // 
            this.btnNewNotification.Location = new System.Drawing.Point(75, 154);
            this.btnNewNotification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewNotification.Name = "btnNewNotification";
            this.btnNewNotification.Size = new System.Drawing.Size(168, 35);
            this.btnNewNotification.TabIndex = 36;
            this.btnNewNotification.Text = "New Notification";
            this.btnNewNotification.UseVisualStyleBackColor = true;
            this.btnNewNotification.Click += new System.EventHandler(this.btnNewNotification_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(926, 154);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 35);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUpdateNotification
            // 
            this.btnUpdateNotification.Location = new System.Drawing.Point(762, 209);
            this.btnUpdateNotification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateNotification.Name = "btnUpdateNotification";
            this.btnUpdateNotification.Size = new System.Drawing.Size(225, 35);
            this.btnUpdateNotification.TabIndex = 39;
            this.btnUpdateNotification.Text = "Update Notification";
            this.btnUpdateNotification.UseVisualStyleBackColor = true;
            this.btnUpdateNotification.Visible = false;
            this.btnUpdateNotification.Click += new System.EventHandler(this.btnUpdateNotification_Click);
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewNotification);
            this.Controls.Add(this.gBoxDetails);
            this.Controls.Add(this.lblActiveNotifications);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.notificationDataGrid);
            this.Name = "Notifications";
            this.Text = "Notifications";
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataGrid)).EndInit();
            this.gBoxDetails.ResumeLayout(false);
            this.gBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView notificationDataGrid;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblActiveNotifications;
        private System.Windows.Forms.GroupBox gBoxDetails;
        private System.Windows.Forms.Button btnNewNotification;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.TextBox txtNotificationText;
        private System.Windows.Forms.RadioButton rBtnEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblNotificationText;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.Button btnCreateNotification;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnUpdateNotification;
    }
}