namespace Human_Relations.Pages
{
    partial class adminLeave
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
            this.lblrequesterror = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.adminLeaveDataGrid = new System.Windows.Forms.DataGridView();
            this.Dec_butn_Click = new System.Windows.Forms.Button();
            this.Ac_butn_Click = new System.Windows.Forms.Button();
            this.checkAllRequests = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminLeaveDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(9, 16);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblrequesterror
            // 
            this.lblrequesterror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequesterror.Location = new System.Drawing.Point(197, 64);
            this.lblrequesterror.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrequesterror.Name = "lblrequesterror";
            this.lblrequesterror.Size = new System.Drawing.Size(400, 20);
            this.lblrequesterror.TabIndex = 11;
            this.lblrequesterror.Text = "View your history";
            this.lblrequesterror.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(197, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(695, 16);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 25);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // adminLeaveDataGrid
            // 
            this.adminLeaveDataGrid.AllowUserToAddRows = false;
            this.adminLeaveDataGrid.AllowUserToDeleteRows = false;
            this.adminLeaveDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminLeaveDataGrid.Location = new System.Drawing.Point(29, 119);
            this.adminLeaveDataGrid.MultiSelect = false;
            this.adminLeaveDataGrid.Name = "adminLeaveDataGrid";
            this.adminLeaveDataGrid.ReadOnly = true;
            this.adminLeaveDataGrid.RowHeadersWidth = 62;
            this.adminLeaveDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminLeaveDataGrid.Size = new System.Drawing.Size(726, 345);
            this.adminLeaveDataGrid.TabIndex = 16;
            // 
            // Dec_butn_Click
            // 
            this.Dec_butn_Click.Location = new System.Drawing.Point(565, 497);
            this.Dec_butn_Click.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dec_butn_Click.Name = "Dec_butn_Click";
            this.Dec_butn_Click.Size = new System.Drawing.Size(75, 23);
            this.Dec_butn_Click.TabIndex = 17;
            this.Dec_butn_Click.Text = "Decline";
            this.Dec_butn_Click.UseVisualStyleBackColor = true;
            this.Dec_butn_Click.Click += new System.EventHandler(this.Dec_butn_Click_Click);
            // 
            // Ac_butn_Click
            // 
            this.Ac_butn_Click.Location = new System.Drawing.Point(130, 497);
            this.Ac_butn_Click.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ac_butn_Click.Name = "Ac_butn_Click";
            this.Ac_butn_Click.Size = new System.Drawing.Size(75, 23);
            this.Ac_butn_Click.TabIndex = 18;
            this.Ac_butn_Click.Text = "Accept";
            this.Ac_butn_Click.UseVisualStyleBackColor = true;
            this.Ac_butn_Click.Click += new System.EventHandler(this.Ac_butn_Click_Click);
            // 
            // checkAllRequests
            // 
            this.checkAllRequests.AutoSize = true;
            this.checkAllRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAllRequests.Location = new System.Drawing.Point(29, 93);
            this.checkAllRequests.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkAllRequests.Name = "checkAllRequests";
            this.checkAllRequests.Size = new System.Drawing.Size(188, 21);
            this.checkAllRequests.TabIndex = 17;
            this.checkAllRequests.Text = "Display all leave requests";
            this.checkAllRequests.UseVisualStyleBackColor = true;
            this.checkAllRequests.CheckedChanged += new System.EventHandler(this.checkAllRequests_CheckedChanged);
            // 
            // adminLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Ac_butn_Click);
            this.Controls.Add(this.Dec_butn_Click);
            this.Controls.Add(this.checkAllRequests);
            this.Controls.Add(this.adminLeaveDataGrid);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblrequesterror);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogOut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "adminLeave";
            this.Text = "Human Resources: Leave Management";
            ((System.ComponentModel.ISupportInitialize)(this.adminLeaveDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblrequesterror;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView adminLeaveDataGrid;
        private System.Windows.Forms.Button Dec_butn_Click;
        private System.Windows.Forms.Button Ac_butn_Click;
        private System.Windows.Forms.CheckBox checkAllRequests;
    }
}