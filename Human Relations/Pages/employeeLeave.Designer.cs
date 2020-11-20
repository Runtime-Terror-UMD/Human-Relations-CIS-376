namespace Human_Relations.Pages
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
            this.btnReturn.Location = new System.Drawing.Point(10, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(198, 69);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 7;
            this.lblDescribe.Text = "Manage your leave requests";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(198, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(695, 21);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblPTOTitle
            // 
            this.lblPTOTitle.AutoSize = true;
            this.lblPTOTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTOTitle.Location = new System.Drawing.Point(27, 115);
            this.lblPTOTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPTOTitle.Name = "lblPTOTitle";
            this.lblPTOTitle.Size = new System.Drawing.Size(158, 20);
            this.lblPTOTitle.TabIndex = 12;
            this.lblPTOTitle.Text = "Available PTO Hours:";
            // 
            // ptoDataGrid
            // 
            this.ptoDataGrid.AllowUserToAddRows = false;
            this.ptoDataGrid.AllowUserToDeleteRows = false;
            this.ptoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ptoDataGrid.Location = new System.Drawing.Point(30, 187);
            this.ptoDataGrid.Name = "ptoDataGrid";
            this.ptoDataGrid.ReadOnly = true;
            this.ptoDataGrid.RowHeadersWidth = 62;
            this.ptoDataGrid.Size = new System.Drawing.Size(441, 313);
            this.ptoDataGrid.TabIndex = 19;
            // 
            // txtPtoHours
            // 
            this.txtPtoHours.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPtoHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtoHours.Location = new System.Drawing.Point(193, 115);
            this.txtPtoHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPtoHours.Name = "txtPtoHours";
            this.txtPtoHours.ReadOnly = true;
            this.txtPtoHours.Size = new System.Drawing.Size(68, 26);
            this.txtPtoHours.TabIndex = 20;
            // 
            // gBoxMakeRequest
            // 
            this.gBoxMakeRequest.Controls.Add(this.btnRequestLeave);
            this.gBoxMakeRequest.Controls.Add(this.label1);
            this.gBoxMakeRequest.Controls.Add(this.lblStart);
            this.gBoxMakeRequest.Controls.Add(this.endDateTime);
            this.gBoxMakeRequest.Controls.Add(this.startDateTime);
            this.gBoxMakeRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxMakeRequest.Location = new System.Drawing.Point(476, 164);
            this.gBoxMakeRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxMakeRequest.Name = "gBoxMakeRequest";
            this.gBoxMakeRequest.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxMakeRequest.Size = new System.Drawing.Size(294, 206);
            this.gBoxMakeRequest.TabIndex = 21;
            this.gBoxMakeRequest.TabStop = false;
            this.gBoxMakeRequest.Text = "Request Leave";
            // 
            // btnRequestLeave
            // 
            this.btnRequestLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestLeave.Location = new System.Drawing.Point(93, 159);
            this.btnRequestLeave.Name = "btnRequestLeave";
            this.btnRequestLeave.Size = new System.Drawing.Size(117, 25);
            this.btnRequestLeave.TabIndex = 24;
            this.btnRequestLeave.Text = "Request Leave";
            this.btnRequestLeave.UseVisualStyleBackColor = true;
            this.btnRequestLeave.Click += new System.EventHandler(this.btnRequestLeave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "End Date/Time:";
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(-1, 71);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(125, 25);
            this.lblStart.TabIndex = 27;
            this.lblStart.Text = "Start Date/Time:";
            // 
            // endDateTime
            // 
            this.endDateTime.CustomFormat = "MM-dd-yyyy HH:mm";
            this.endDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTime.Location = new System.Drawing.Point(125, 108);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(165, 26);
            this.endDateTime.TabIndex = 26;
            // 
            // startDateTime
            // 
            this.startDateTime.Checked = false;
            this.startDateTime.CustomFormat = "MM-dd-yyyy HH:mm";
            this.startDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTime.Location = new System.Drawing.Point(130, 68);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(161, 26);
            this.startDateTime.TabIndex = 25;
            // 
            // lblLeaveRequestHist
            // 
            this.lblLeaveRequestHist.AutoSize = true;
            this.lblLeaveRequestHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaveRequestHist.Location = new System.Drawing.Point(27, 164);
            this.lblLeaveRequestHist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeaveRequestHist.Name = "lblLeaveRequestHist";
            this.lblLeaveRequestHist.Size = new System.Drawing.Size(170, 20);
            this.lblLeaveRequestHist.TabIndex = 22;
            this.lblLeaveRequestHist.Text = "Leave Request History";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(503, 404);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(239, 43);
            this.lblError.TabIndex = 23;
            this.lblError.Visible = false;
            // 
            // employeeLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "employeeLeave";
            this.Text = "Human Resources: Leave Management";
            ((System.ComponentModel.ISupportInitialize)(this.ptoDataGrid)).EndInit();
            this.gBoxMakeRequest.ResumeLayout(false);
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
    }
}