namespace Human_Relations
{
    partial class Menu
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnManageEmp = new System.Windows.Forms.Button();
            this.btnScheduleMgmt = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.Clock1 = new System.Windows.Forms.Label();
            this.Clock_in = new System.Windows.Forms.Button();
            this.clock_out = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(929, 15);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 31);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(267, 74);
            this.lblDescribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(533, 25);
            this.lblDescribe.TabIndex = 0;
            this.lblDescribe.Text = "Make a selection.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(267, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(533, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(200, 400);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(267, 62);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.BackColor = System.Drawing.SystemColors.Window;
            this.lblNotification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.Location = new System.Drawing.Point(267, 123);
            this.lblNotification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(533, 37);
            this.lblNotification.TabIndex = 0;
            this.lblNotification.Text = "No new notifications.";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmployee.Location = new System.Drawing.Point(200, 492);
            this.btnNewEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(267, 62);
            this.btnNewEmployee.TabIndex = 7;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnManageEmp
            // 
            this.btnManageEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmp.Location = new System.Drawing.Point(600, 492);
            this.btnManageEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageEmp.Name = "btnManageEmp";
            this.btnManageEmp.Size = new System.Drawing.Size(267, 62);
            this.btnManageEmp.TabIndex = 8;
            this.btnManageEmp.Text = "Manage Employees";
            this.btnManageEmp.UseVisualStyleBackColor = true;
            this.btnManageEmp.Click += new System.EventHandler(this.btnManageEmp_Click);
            // 
            // btnScheduleMgmt
            // 
            this.btnScheduleMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleMgmt.Location = new System.Drawing.Point(395, 562);
            this.btnScheduleMgmt.Margin = new System.Windows.Forms.Padding(4);
            this.btnScheduleMgmt.Name = "btnScheduleMgmt";
            this.btnScheduleMgmt.Size = new System.Drawing.Size(267, 62);
            this.btnScheduleMgmt.TabIndex = 9;
            this.btnScheduleMgmt.Text = "Schedule Management";
            this.btnScheduleMgmt.UseVisualStyleBackColor = true;
            this.btnScheduleMgmt.Click += new System.EventHandler(this.btnScheduleMgmt_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(600, 400);
            this.btnViewProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(267, 62);
            this.btnViewProfile.TabIndex = 10;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // Clock1
            // 
            this.Clock1.AutoSize = true;
            this.Clock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock1.Location = new System.Drawing.Point(400, 181);
            this.Clock1.Name = "Clock1";
            this.Clock1.Size = new System.Drawing.Size(262, 69);
            this.Clock1.TabIndex = 11;
            this.Clock1.Text = "00:00:00";
            this.Clock1.Click += new System.EventHandler(this.Clock1_Click);
            // 
            // Clock_in
            // 
            this.Clock_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_in.Location = new System.Drawing.Point(395, 288);
            this.Clock_in.Margin = new System.Windows.Forms.Padding(4);
            this.Clock_in.Name = "Clock_in";
            this.Clock_in.Size = new System.Drawing.Size(267, 62);
            this.Clock_in.TabIndex = 12;
            this.Clock_in.Text = "Clock in";
            this.Clock_in.UseVisualStyleBackColor = true;
            this.Clock_in.Click += new System.EventHandler(this.Clockin_Click);
            // 
            // clock_out
            // 
            this.clock_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock_out.Location = new System.Drawing.Point(600, 288);
            this.clock_out.Margin = new System.Windows.Forms.Padding(4);
            this.clock_out.Name = "clock_out";
            this.clock_out.Size = new System.Drawing.Size(267, 62);
            this.clock_out.TabIndex = 13;
            this.clock_out.Text = "Clock out";
            this.clock_out.UseVisualStyleBackColor = true;
            this.clock_out.Visible = false;
            this.clock_out.Click += new System.EventHandler(this.ClockOut_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(270, 354);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(533, 25);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Error!!";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.clock_out);
            this.Controls.Add(this.Clock_in);
            this.Controls.Add(this.Clock1);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnScheduleMgmt);
            this.Controls.Add(this.btnManageEmp);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Human Resources: Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnManageEmp;
        private System.Windows.Forms.Button btnScheduleMgmt;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Label Clock1;
        private System.Windows.Forms.Button Clock_in;
        private System.Windows.Forms.Button clock_out;
        private System.Windows.Forms.Label lblError;
    }
}