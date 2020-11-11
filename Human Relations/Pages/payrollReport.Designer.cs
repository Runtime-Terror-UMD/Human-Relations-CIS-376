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
            ((System.ComponentModel.ISupportInitialize)(this.payperiodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxPayPeriodID
            // 
            this.cBoxPayPeriodID.DataSource = this.payperiodsBindingSource;
            this.cBoxPayPeriodID.DisplayMember = "payPeriodName";
            this.cBoxPayPeriodID.FormattingEnabled = true;
            this.cBoxPayPeriodID.Location = new System.Drawing.Point(193, 154);
            this.cBoxPayPeriodID.Name = "cBoxPayPeriodID";
            this.cBoxPayPeriodID.Size = new System.Drawing.Size(247, 28);
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
            this.lblDescribe.Location = new System.Drawing.Point(291, 78);
            this.lblDescribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(600, 31);
            this.lblDescribe.TabIndex = 8;
            this.lblDescribe.Text = "View a report for the selected pay period";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(970, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 45);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(36, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 45);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(291, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 62);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPayPeriod
            // 
            this.lblPayPeriod.AutoSize = true;
            this.lblPayPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayPeriod.Location = new System.Drawing.Point(31, 157);
            this.lblPayPeriod.Name = "lblPayPeriod";
            this.lblPayPeriod.Size = new System.Drawing.Size(125, 26);
            this.lblPayPeriod.TabIndex = 10;
            this.lblPayPeriod.Text = "Pay Period:";
            // 
            // btnViewReport
            // 
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(970, 137);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(160, 45);
            this.btnViewReport.TabIndex = 11;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 221);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 26);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(31, 261);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(157, 26);
            this.lblHoursWorked.TabIndex = 13;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblAmtMade
            // 
            this.lblAmtMade.AutoSize = true;
            this.lblAmtMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtMade.Location = new System.Drawing.Point(31, 304);
            this.lblAmtMade.Name = "lblAmtMade";
            this.lblAmtMade.Size = new System.Drawing.Size(154, 26);
            this.lblAmtMade.TabIndex = 14;
            this.lblAmtMade.Text = "Amount Made:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(193, 221);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(247, 26);
            this.txtName.TabIndex = 15;
            // 
            // txtAmtMade
            // 
            this.txtAmtMade.BackColor = System.Drawing.Color.White;
            this.txtAmtMade.Location = new System.Drawing.Point(193, 304);
            this.txtAmtMade.Name = "txtAmtMade";
            this.txtAmtMade.ReadOnly = true;
            this.txtAmtMade.Size = new System.Drawing.Size(247, 26);
            this.txtAmtMade.TabIndex = 17;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.BackColor = System.Drawing.Color.White;
            this.txtHoursWorked.Location = new System.Drawing.Point(193, 261);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.ReadOnly = true;
            this.txtHoursWorked.Size = new System.Drawing.Size(247, 26);
            this.txtHoursWorked.TabIndex = 16;
            // 
            // payrollReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
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
            this.Name = "payrollReport";
            this.Text = "My Payroll";
            this.Load += new System.EventHandler(this.payrollReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payperiodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).EndInit();
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
    }
}