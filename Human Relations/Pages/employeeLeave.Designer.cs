﻿namespace Human_Relations.Pages
{
    partial class employeeLeave
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblPTOTitle = new System.Windows.Forms.Label();
            this.ptoDataGrid = new System.Windows.Forms.DataGridView();
            this.txtPtoHours = new System.Windows.Forms.TextBox();
            this.gBoxMakeRequest = new System.Windows.Forms.GroupBox();
            this.CheckPTO = new System.Windows.Forms.CheckBox();
            this.btnRequestLeave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.endDateTime = new System.Windows.Forms.DateTimePicker();
            this.startDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblLeaveRequestHist = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptoDataGrid)).BeginInit();
            this.gBoxMakeRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(15, 32);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 38);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(297, 106);
            this.lblDescribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(600, 31);
            this.lblDescribe.TabIndex = 7;
            this.lblDescribe.Text = "Manage your leave requests";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(297, 37);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 62);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1042, 32);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 38);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblPTOTitle
            // 
            this.lblPTOTitle.AutoSize = true;
            this.lblPTOTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTOTitle.Location = new System.Drawing.Point(40, 177);
            this.lblPTOTitle.Name = "lblPTOTitle";
            this.lblPTOTitle.Size = new System.Drawing.Size(244, 29);
            this.lblPTOTitle.TabIndex = 12;
            this.lblPTOTitle.Text = "Available PTO Hours:";
            // 
            // ptoDataGrid
            // 
            this.ptoDataGrid.AllowUserToAddRows = false;
            this.ptoDataGrid.AllowUserToDeleteRows = false;
            this.ptoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ptoDataGrid.Location = new System.Drawing.Point(45, 288);
            this.ptoDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptoDataGrid.Name = "ptoDataGrid";
            this.ptoDataGrid.ReadOnly = true;
            this.ptoDataGrid.RowHeadersWidth = 62;
            this.ptoDataGrid.Size = new System.Drawing.Size(662, 482);
            this.ptoDataGrid.TabIndex = 19;
            // 
            // txtPtoHours
            // 
            this.txtPtoHours.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPtoHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtoHours.Location = new System.Drawing.Point(290, 177);
            this.txtPtoHours.Name = "txtPtoHours";
            this.txtPtoHours.ReadOnly = true;
            this.txtPtoHours.Size = new System.Drawing.Size(100, 35);
            this.txtPtoHours.TabIndex = 20;
            // 
            // gBoxMakeRequest
            // 
            this.gBoxMakeRequest.Controls.Add(this.CheckPTO);
            this.gBoxMakeRequest.Controls.Add(this.btnRequestLeave);
            this.gBoxMakeRequest.Controls.Add(this.label1);
            this.gBoxMakeRequest.Controls.Add(this.lblStart);
            this.gBoxMakeRequest.Controls.Add(this.endDateTime);
            this.gBoxMakeRequest.Controls.Add(this.startDateTime);
            this.gBoxMakeRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxMakeRequest.Location = new System.Drawing.Point(714, 252);
            this.gBoxMakeRequest.Name = "gBoxMakeRequest";
            this.gBoxMakeRequest.Size = new System.Drawing.Size(441, 317);
            this.gBoxMakeRequest.TabIndex = 21;
            this.gBoxMakeRequest.TabStop = false;
            this.gBoxMakeRequest.Text = "Request Leave";
            // 
            // CheckPTO
            // 
            this.CheckPTO.AutoSize = true;
            this.CheckPTO.Location = new System.Drawing.Point(27, 245);
            this.CheckPTO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckPTO.Name = "CheckPTO";
            this.CheckPTO.Size = new System.Drawing.Size(156, 33);
            this.CheckPTO.TabIndex = 29;
            this.CheckPTO.Text = "Apply PTO";
            this.CheckPTO.UseVisualStyleBackColor = true;
            // 
            // btnRequestLeave
            // 
            this.btnRequestLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestLeave.Location = new System.Drawing.Point(243, 243);
            this.btnRequestLeave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRequestLeave.Name = "btnRequestLeave";
            this.btnRequestLeave.Size = new System.Drawing.Size(176, 38);
            this.btnRequestLeave.TabIndex = 24;
            this.btnRequestLeave.Text = "Request Leave";
            this.btnRequestLeave.UseVisualStyleBackColor = true;
            this.btnRequestLeave.Click += new System.EventHandler(this.btnRequestLeave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 28;
            this.label1.Text = "End Date:";
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(40, 110);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(137, 38);
            this.lblStart.TabIndex = 27;
            this.lblStart.Text = "Start Date:";
            // 
            // endDateTime
            // 
            this.endDateTime.CustomFormat = "MM-dd-yyyy";
            this.endDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTime.Location = new System.Drawing.Point(195, 166);
            this.endDateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(204, 35);
            this.endDateTime.TabIndex = 26;
            // 
            // startDateTime
            // 
            this.startDateTime.Checked = false;
            this.startDateTime.CustomFormat = "MM-dd-yyyy";
            this.startDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTime.Location = new System.Drawing.Point(195, 105);
            this.startDateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(204, 35);
            this.startDateTime.TabIndex = 25;
            // 
            // lblLeaveRequestHist
            // 
            this.lblLeaveRequestHist.AutoSize = true;
            this.lblLeaveRequestHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveRequestHist.Location = new System.Drawing.Point(40, 252);
            this.lblLeaveRequestHist.Name = "lblLeaveRequestHist";
            this.lblLeaveRequestHist.Size = new System.Drawing.Size(254, 29);
            this.lblLeaveRequestHist.TabIndex = 22;
            this.lblLeaveRequestHist.Text = "Leave Request History";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(754, 622);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(358, 66);
            this.lblError.TabIndex = 23;
            this.lblError.Visible = false;
            // 
            // employeeLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblLeaveRequestHist);
            this.Controls.Add(this.gBoxMakeRequest);
            this.Controls.Add(this.txtPtoHours);
            this.Controls.Add(this.ptoDataGrid);
            this.Controls.Add(this.lblPTOTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Name = "employeeLeave";
            this.Text = "Human Resources: Leave Management";
            ((System.ComponentModel.ISupportInitialize)(this.ptoDataGrid)).EndInit();
            this.gBoxMakeRequest.ResumeLayout(false);
            this.gBoxMakeRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblPTOTitle;
        private System.Windows.Forms.DataGridView ptoDataGrid;
        private System.Windows.Forms.TextBox txtPtoHours;
        private System.Windows.Forms.GroupBox gBoxMakeRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker endDateTime;
        private System.Windows.Forms.DateTimePicker startDateTime;
        private System.Windows.Forms.Label lblLeaveRequestHist;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnRequestLeave;
        private System.Windows.Forms.CheckBox CheckPTO;
    }
}