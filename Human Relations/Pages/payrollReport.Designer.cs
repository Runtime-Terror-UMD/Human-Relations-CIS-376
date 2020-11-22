namespace Human_Relations.Pages
{
    partial class payrollReport
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
            this.components = new System.ComponentModel.Container();
            this.cBoxPayPeriodID = new System.Windows.Forms.ComboBox();
            this.payperiodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboDataSet = new Human_Relations.dboDataSet();
            this.dboDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payperiodsTableAdapter = new Human_Relations.dboDataSetTableAdapters.payperiodsTableAdapter();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPayPeriod = new System.Windows.Forms.Label();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblAmtMade = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmtMade = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.personalAttendanceDataGrid = new System.Windows.Forms.DataGridView();
            this.btnPrintPayroll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.payperiodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalAttendanceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxPayPeriodID
            // 
            this.cBoxPayPeriodID.DataSource = this.payperiodsBindingSource;
            this.cBoxPayPeriodID.DisplayMember = "payPeriodName";
            this.cBoxPayPeriodID.FormattingEnabled = true;
            this.cBoxPayPeriodID.Location = new System.Drawing.Point(129, 100);
            this.cBoxPayPeriodID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxPayPeriodID.Name = "cBoxPayPeriodID";
            this.cBoxPayPeriodID.Size = new System.Drawing.Size(166, 21);
            this.cBoxPayPeriodID.TabIndex = 0;
            this.cBoxPayPeriodID.ValueMember = "payPeriodID";
            // 
            // payperiodsBindingSource
            // 
            this.payperiodsBindingSource.DataMember = "payperiods";
            this.payperiodsBindingSource.DataSource = this.dboDataSet;
            // 
            // dboDataSet
            // 
            this.dboDataSet.DataSetName = "dboDataSet";
            this.dboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dboDataSetBindingSource
            // 
            this.dboDataSetBindingSource.DataSource = this.dboDataSet;
            this.dboDataSetBindingSource.Position = 0;
            // 
            // payperiodsTableAdapter
            // 
            this.payperiodsTableAdapter.ClearBeforeFill = true;
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(194, 51);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 8;
            this.lblDescribe.Text = "View a report for the selected pay period";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(647, 19);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 29);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(24, 19);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 29);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(194, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPayPeriod
            // 
            this.lblPayPeriod.AutoSize = true;
            this.lblPayPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayPeriod.Location = new System.Drawing.Point(21, 102);
            this.lblPayPeriod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayPeriod.Name = "lblPayPeriod";
            this.lblPayPeriod.Size = new System.Drawing.Size(84, 18);
            this.lblPayPeriod.TabIndex = 10;
            this.lblPayPeriod.Text = "Pay Period:";
            // 
            // btnViewReport
            // 
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(647, 89);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(107, 29);
            this.btnViewReport.TabIndex = 11;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(21, 144);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(21, 170);
            this.lblHoursWorked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(110, 18);
            this.lblHoursWorked.TabIndex = 13;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblAmtMade
            // 
            this.lblAmtMade.AutoSize = true;
            this.lblAmtMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtMade.Location = new System.Drawing.Point(21, 198);
            this.lblAmtMade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmtMade.Name = "lblAmtMade";
            this.lblAmtMade.Size = new System.Drawing.Size(104, 18);
            this.lblAmtMade.TabIndex = 14;
            this.lblAmtMade.Text = "Amount Made:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(129, 144);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(166, 20);
            this.txtName.TabIndex = 15;
            // 
            // txtAmtMade
            // 
            this.txtAmtMade.BackColor = System.Drawing.Color.White;
            this.txtAmtMade.Location = new System.Drawing.Point(129, 198);
            this.txtAmtMade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAmtMade.Name = "txtAmtMade";
            this.txtAmtMade.ReadOnly = true;
            this.txtAmtMade.Size = new System.Drawing.Size(166, 20);
            this.txtAmtMade.TabIndex = 17;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.BackColor = System.Drawing.Color.White;
            this.txtHoursWorked.Location = new System.Drawing.Point(129, 170);
            this.txtHoursWorked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.ReadOnly = true;
            this.txtHoursWorked.Size = new System.Drawing.Size(166, 20);
            this.txtHoursWorked.TabIndex = 16;
            // 
            // personalAttendanceDataGrid
            // 
            this.personalAttendanceDataGrid.AllowUserToAddRows = false;
            this.personalAttendanceDataGrid.AllowUserToDeleteRows = false;
            this.personalAttendanceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalAttendanceDataGrid.Location = new System.Drawing.Point(151, 237);
            this.personalAttendanceDataGrid.Name = "personalAttendanceDataGrid";
            this.personalAttendanceDataGrid.ReadOnly = true;
            this.personalAttendanceDataGrid.RowHeadersWidth = 62;
            this.personalAttendanceDataGrid.Size = new System.Drawing.Size(489, 287);
            this.personalAttendanceDataGrid.TabIndex = 18;
            // 
            // btnPrintPayroll
            // 
            this.btnPrintPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPayroll.Location = new System.Drawing.Point(647, 159);
            this.btnPrintPayroll.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintPayroll.Name = "btnPrintPayroll";
            this.btnPrintPayroll.Size = new System.Drawing.Size(107, 29);
            this.btnPrintPayroll.TabIndex = 19;
            this.btnPrintPayroll.Text = "Print Payroll";
            this.btnPrintPayroll.UseVisualStyleBackColor = true;
            this.btnPrintPayroll.Click += new System.EventHandler(this.btnPrintPayroll_Click);
            // 
            // payrollReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 536);
            this.Controls.Add(this.btnPrintPayroll);
            this.Controls.Add(this.personalAttendanceDataGrid);
            this.Controls.Add(this.txtAmtMade);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAmtMade);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.lblPayPeriod);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cBoxPayPeriodID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "payrollReport";
            this.Text = "My Payroll";
            this.Load += new System.EventHandler(this.payrollReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payperiodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalAttendanceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxPayPeriodID;
        private System.Windows.Forms.BindingSource dboDataSetBindingSource;
        private dboDataSet dboDataSet;
        private System.Windows.Forms.BindingSource payperiodsBindingSource;
        private dboDataSetTableAdapters.payperiodsTableAdapter payperiodsTableAdapter;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPayPeriod;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblAmtMade;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAmtMade;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.DataGridView personalAttendanceDataGrid;
        private System.Windows.Forms.Button btnPrintPayroll;
    }
}