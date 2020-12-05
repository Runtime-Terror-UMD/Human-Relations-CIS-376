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
            this.btnLeaveMgmt = new System.Windows.Forms.Button();
            this.btnManageEmp = new System.Windows.Forms.Button();
            this.btnScheduleMgmt = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.Clock1 = new System.Windows.Forms.Label();
            this.Clock_in = new System.Windows.Forms.Button();
            this.clock_out = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnPayroll = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.notificationDataGrid = new System.Windows.Forms.DataGridView();
            this.btnNotificaitons = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(697, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(200, 60);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 0;
            this.lblDescribe.Text = "Make a selection.";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(125, 475);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(175, 50);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnLeaveMgmt
            // 
            this.btnLeaveMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveMgmt.Location = new System.Drawing.Point(125, 400);
            this.btnLeaveMgmt.Name = "btnLeaveMgmt";
            this.btnLeaveMgmt.Size = new System.Drawing.Size(175, 50);
            this.btnLeaveMgmt.TabIndex = 7;
            this.btnLeaveMgmt.Text = "Leave Management";
            this.btnLeaveMgmt.UseVisualStyleBackColor = true;
            this.btnLeaveMgmt.Click += new System.EventHandler(this.btnLeaveMgmt_Click);
            // 
            // btnManageEmp
            // 
            this.btnManageEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmp.Location = new System.Drawing.Point(500, 475);
            this.btnManageEmp.Name = "btnManageEmp";
            this.btnManageEmp.Size = new System.Drawing.Size(175, 50);
            this.btnManageEmp.TabIndex = 8;
            this.btnManageEmp.Text = "Manage Employees";
            this.btnManageEmp.UseVisualStyleBackColor = true;
            this.btnManageEmp.Click += new System.EventHandler(this.btnManageEmp_Click);
            // 
            // btnScheduleMgmt
            // 
            this.btnScheduleMgmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleMgmt.Location = new System.Drawing.Point(125, 325);
            this.btnScheduleMgmt.Name = "btnScheduleMgmt";
            this.btnScheduleMgmt.Size = new System.Drawing.Size(175, 50);
            this.btnScheduleMgmt.TabIndex = 9;
            this.btnScheduleMgmt.Text = "Schedule Management";
            this.btnScheduleMgmt.UseVisualStyleBackColor = true;
            this.btnScheduleMgmt.Click += new System.EventHandler(this.btnScheduleMgmt_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(500, 325);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(175, 50);
            this.btnViewProfile.TabIndex = 10;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // Clock1
            // 
            this.Clock1.AutoSize = true;
            this.Clock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock1.Location = new System.Drawing.Point(299, 166);
            this.Clock1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Clock1.Name = "Clock1";
            this.Clock1.Size = new System.Drawing.Size(212, 55);
            this.Clock1.TabIndex = 11;
            this.Clock1.Text = "00:00:00";
            // 
            // Clock_in
            // 
            this.Clock_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_in.Location = new System.Drawing.Point(300, 235);
            this.Clock_in.Name = "Clock_in";
            this.Clock_in.Size = new System.Drawing.Size(200, 50);
            this.Clock_in.TabIndex = 12;
            this.Clock_in.Text = "Clock in";
            this.Clock_in.UseVisualStyleBackColor = true;
            this.Clock_in.Click += new System.EventHandler(this.Clockin_Click);
            // 
            // clock_out
            // 
            this.clock_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock_out.Location = new System.Drawing.Point(300, 235);
            this.clock_out.Name = "clock_out";
            this.clock_out.Size = new System.Drawing.Size(200, 50);
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
            this.lblError.Location = new System.Drawing.Point(202, 288);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(400, 20);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Error!!";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // btnPayroll
            // 
            this.btnPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayroll.Location = new System.Drawing.Point(500, 400);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Size = new System.Drawing.Size(175, 50);
            this.btnPayroll.TabIndex = 15;
            this.btnPayroll.Text = "My Payroll";
            this.btnPayroll.UseVisualStyleBackColor = true;
            this.btnPayroll.Click += new System.EventHandler(this.btnPayroll_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(315, 475);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(175, 50);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // notificationDataGrid
            // 
            this.notificationDataGrid.AllowUserToAddRows = false;
            this.notificationDataGrid.AllowUserToDeleteRows = false;
            this.notificationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notificationDataGrid.ColumnHeadersVisible = false;
            this.notificationDataGrid.Location = new System.Drawing.Point(125, 90);
            this.notificationDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notificationDataGrid.Name = "notificationDataGrid";
            this.notificationDataGrid.ReadOnly = true;
            this.notificationDataGrid.RowHeadersVisible = false;
            this.notificationDataGrid.RowHeadersWidth = 62;
            this.notificationDataGrid.RowTemplate.Height = 28;
            this.notificationDataGrid.Size = new System.Drawing.Size(549, 54);
            this.notificationDataGrid.TabIndex = 17;
            // 
            // btnNotificaitons
            // 
            this.btnNotificaitons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificaitons.Location = new System.Drawing.Point(315, 400);
            this.btnNotificaitons.Name = "btnNotificaitons";
            this.btnNotificaitons.Size = new System.Drawing.Size(175, 50);
            this.btnNotificaitons.TabIndex = 18;
            this.btnNotificaitons.Text = "Notifications";
            this.btnNotificaitons.UseVisualStyleBackColor = true;
            this.btnNotificaitons.Click += new System.EventHandler(this.btnNotificaitons_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 495);
            this.Controls.Add(this.btnNotificaitons);
            this.Controls.Add(this.notificationDataGrid);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnPayroll);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.clock_out);
            this.Controls.Add(this.Clock_in);
            this.Controls.Add(this.Clock1);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnScheduleMgmt);
            this.Controls.Add(this.btnManageEmp);
            this.Controls.Add(this.btnLeaveMgmt);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Name = "Menu";
            this.Text = "Human Resources: Menu";
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnLeaveMgmt;
        private System.Windows.Forms.Button btnManageEmp;
        private System.Windows.Forms.Button btnScheduleMgmt;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Label Clock1;
        private System.Windows.Forms.Button Clock_in;
        private System.Windows.Forms.Button clock_out;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView notificationDataGrid;
        private System.Windows.Forms.Button btnNotificaitons;
    }
}