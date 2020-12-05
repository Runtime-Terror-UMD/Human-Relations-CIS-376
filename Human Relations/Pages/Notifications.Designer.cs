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
            this.upBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataGrid)).BeginInit();
            this.gBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationDataGrid
            // 
            this.notificationDataGrid.AllowUserToAddRows = false;
            this.notificationDataGrid.AllowUserToDeleteRows = false;
            this.notificationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notificationDataGrid.Location = new System.Drawing.Point(50, 144);
            this.notificationDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notificationDataGrid.MultiSelect = false;
            this.notificationDataGrid.Name = "notificationDataGrid";
            this.notificationDataGrid.ReadOnly = true;
            this.notificationDataGrid.RowHeadersWidth = 62;
            this.notificationDataGrid.RowTemplate.Height = 28;
            this.notificationDataGrid.Size = new System.Drawing.Size(679, 181);
            this.notificationDataGrid.TabIndex = 18;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblError.Location = new System.Drawing.Point(199, 56);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(400, 25);
            this.lblError.TabIndex = 33;
            this.lblError.Text = "Error:";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(199, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 50);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(697, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 31;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(11, 8);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 30;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblActiveNotifications
            // 
            this.lblActiveNotifications.AutoSize = true;
            this.lblActiveNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveNotifications.Location = new System.Drawing.Point(307, 102);
            this.lblActiveNotifications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActiveNotifications.Name = "lblActiveNotifications";
            this.lblActiveNotifications.Size = new System.Drawing.Size(166, 24);
            this.lblActiveNotifications.TabIndex = 34;
            this.lblActiveNotifications.Text = "Active Notifications";
            // 
            // gBoxDetails
            // 
            this.gBoxDetails.Controls.Add(this.upBTN);
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
            this.gBoxDetails.Location = new System.Drawing.Point(50, 352);
            this.gBoxDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxDetails.Name = "gBoxDetails";
            this.gBoxDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxDetails.Size = new System.Drawing.Size(679, 174);
            this.gBoxDetails.TabIndex = 35;
            this.gBoxDetails.TabStop = false;
            this.gBoxDetails.Text = "Notification Details";
            this.gBoxDetails.Visible = false;
            // 
            // btnCreateNotification
            // 
            this.btnCreateNotification.Location = new System.Drawing.Point(508, 136);
            this.btnCreateNotification.Name = "btnCreateNotification";
            this.btnCreateNotification.Size = new System.Drawing.Size(150, 23);
            this.btnCreateNotification.TabIndex = 38;
            this.btnCreateNotification.Text = "Create Notification";
            this.btnCreateNotification.UseVisualStyleBackColor = true;
            this.btnCreateNotification.Click += new System.EventHandler(this.btnCreateNotification_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(397, 80);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(114, 17);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Notification Type";
            // 
            // rBtnEndDate
            // 
            this.rBtnEndDate.AutoSize = true;
            this.rBtnEndDate.Location = new System.Drawing.Point(13, 110);
            this.rBtnEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtnEndDate.Name = "rBtnEndDate";
            this.rBtnEndDate.Size = new System.Drawing.Size(110, 21);
            this.rBtnEndDate.TabIndex = 7;
            this.rBtnEndDate.TabStop = true;
            this.rBtnEndDate.Text = "Set End Date";
            this.rBtnEndDate.UseVisualStyleBackColor = true;
            this.rBtnEndDate.CheckedChanged += new System.EventHandler(this.rBtnEndDate_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(10, 142);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(67, 17);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.Visible = false;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(7, 80);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(72, 17);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblNotificationText
            // 
            this.lblNotificationText.AutoSize = true;
            this.lblNotificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationText.Location = new System.Drawing.Point(10, 24);
            this.lblNotificationText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotificationText.Name = "lblNotificationText";
            this.lblNotificationText.Size = new System.Drawing.Size(246, 17);
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
            this.cBoxType.Location = new System.Drawing.Point(523, 73);
            this.cBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(137, 24);
            this.cBoxType.TabIndex = 3;
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(83, 139);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(221, 23);
            this.EndDatePicker.TabIndex = 2;
            this.EndDatePicker.Visible = false;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(83, 77);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(221, 23);
            this.startDatePicker.TabIndex = 1;
            // 
            // txtNotificationText
            // 
            this.txtNotificationText.Location = new System.Drawing.Point(11, 42);
            this.txtNotificationText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNotificationText.Multiline = true;
            this.txtNotificationText.Name = "txtNotificationText";
            this.txtNotificationText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotificationText.Size = new System.Drawing.Size(649, 18);
            this.txtNotificationText.TabIndex = 0;
            // 
            // btnNewNotification
            // 
            this.btnNewNotification.Location = new System.Drawing.Point(50, 100);
            this.btnNewNotification.Name = "btnNewNotification";
            this.btnNewNotification.Size = new System.Drawing.Size(112, 23);
            this.btnNewNotification.TabIndex = 36;
            this.btnNewNotification.Text = "New Notification";
            this.btnNewNotification.UseVisualStyleBackColor = true;
            this.btnNewNotification.Click += new System.EventHandler(this.btnNewNotification_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(617, 100);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 23);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // upBTN
            // 
            this.upBTN.Location = new System.Drawing.Point(508, 136);
            this.upBTN.Name = "upBTN";
            this.upBTN.Size = new System.Drawing.Size(150, 26);
            this.upBTN.TabIndex = 39;
            this.upBTN.Text = "Update";
            this.upBTN.UseVisualStyleBackColor = true;
            this.upBTN.Visible = false;
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewNotification);
            this.Controls.Add(this.gBoxDetails);
            this.Controls.Add(this.lblActiveNotifications);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.notificationDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button upBTN;
    }
}