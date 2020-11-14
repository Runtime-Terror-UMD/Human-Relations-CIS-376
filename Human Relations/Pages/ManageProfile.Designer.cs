namespace Human_Relations.Pages
{
    partial class ManageProfile
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblNewPassDesc = new System.Windows.Forms.Label();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblPasswordDesc = new System.Windows.Forms.Label();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.cBoxStates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.txtStates = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblfName = new System.Windows.Forms.Label();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(215, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(402, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(45, 29);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 29);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(618, 12);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 29);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPhoneNum);
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblNewPassDesc);
            this.groupBox1.Controls.Add(this.txtPayRate);
            this.groupBox1.Controls.Add(this.txtCurrentPassword);
            this.groupBox1.Controls.Add(this.lblPayRate);
            this.groupBox1.Controls.Add(this.lblPasswordDesc);
            this.groupBox1.Controls.Add(this.txtHireDate);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtDept);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtZIP);
            this.groupBox1.Controls.Add(this.txtRole);
            this.groupBox1.Controls.Add(this.cBoxStates);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddress2);
            this.groupBox1.Controls.Add(this.txtAddress1);
            this.groupBox1.Controls.Add(this.lblHireDate);
            this.groupBox1.Controls.Add(this.txtStates);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblDept);
            this.groupBox1.Controls.Add(this.lblAddress2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblAddress1);
            this.groupBox1.Controls.Add(this.txtlname);
            this.groupBox1.Controls.Add(this.txtfname);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblRole);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.lbllname);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblfName);
            this.groupBox1.Location = new System.Drawing.Point(45, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 382);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Profile";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Enabled = false;
            this.txtPhoneNum.Location = new System.Drawing.Point(166, 301);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNum.Mask = "(999) 000-0000";
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(155, 20);
            this.txtPhoneNum.TabIndex = 49;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(509, 344);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(152, 25);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(166, 344);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 25);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "Click to Edit Profile";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(509, 298);
            this.txtNewPassword.MaxLength = 45;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(155, 21);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(166, 344);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(152, 25);
            this.btnSubmit.TabIndex = 60;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblNewPassDesc
            // 
            this.lblNewPassDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassDesc.Location = new System.Drawing.Point(343, 298);
            this.lblNewPassDesc.Name = "lblNewPassDesc";
            this.lblNewPassDesc.Size = new System.Drawing.Size(152, 20);
            this.lblNewPassDesc.TabIndex = 0;
            this.lblNewPassDesc.Text = "New Password:";
            this.lblNewPassDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Enabled = false;
            this.txtPayRate.Location = new System.Drawing.Point(509, 164);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(155, 20);
            this.txtPayRate.TabIndex = 16;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(509, 262);
            this.txtCurrentPassword.MaxLength = 45;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(155, 21);
            this.txtCurrentPassword.TabIndex = 3;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPayRate.Location = new System.Drawing.Point(409, 164);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(78, 20);
            this.lblPayRate.TabIndex = 16;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // lblPasswordDesc
            // 
            this.lblPasswordDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordDesc.Location = new System.Drawing.Point(343, 263);
            this.lblPasswordDesc.Name = "lblPasswordDesc";
            this.lblPasswordDesc.Size = new System.Drawing.Size(152, 20);
            this.lblPasswordDesc.TabIndex = 0;
            this.lblPasswordDesc.Text = "Current Password:";
            this.lblPasswordDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Enabled = false;
            this.txtHireDate.Location = new System.Drawing.Point(509, 134);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(155, 20);
            this.txtHireDate.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(166, 212);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(155, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtDept
            // 
            this.txtDept.Enabled = false;
            this.txtDept.Location = new System.Drawing.Point(509, 106);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(155, 20);
            this.txtDept.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ZIP Code:";
            // 
            // txtZIP
            // 
            this.txtZIP.Enabled = false;
            this.txtZIP.Location = new System.Drawing.Point(166, 273);
            this.txtZIP.MaxLength = 5;
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(155, 20);
            this.txtZIP.TabIndex = 9;
            // 
            // txtRole
            // 
            this.txtRole.Enabled = false;
            this.txtRole.Location = new System.Drawing.Point(509, 77);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(155, 20);
            this.txtRole.TabIndex = 13;
            // 
            // cBoxStates
            // 
            this.cBoxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxStates.FormattingEnabled = true;
            this.cBoxStates.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NB",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cBoxStates.Location = new System.Drawing.Point(166, 241);
            this.cBoxStates.Name = "cBoxStates";
            this.cBoxStates.Size = new System.Drawing.Size(155, 21);
            this.cBoxStates.TabIndex = 5;
            this.cBoxStates.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "State:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Enabled = false;
            this.txtAddress2.Location = new System.Drawing.Point(166, 186);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(155, 20);
            this.txtAddress2.TabIndex = 7;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Enabled = false;
            this.txtAddress1.Location = new System.Drawing.Point(166, 160);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(155, 20);
            this.txtAddress1.TabIndex = 6;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHireDate.Location = new System.Drawing.Point(406, 134);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(81, 20);
            this.lblHireDate.TabIndex = 15;
            this.lblHireDate.Text = "Hire Date:";
            // 
            // txtStates
            // 
            this.txtStates.Enabled = false;
            this.txtStates.Location = new System.Drawing.Point(166, 241);
            this.txtStates.Name = "txtStates";
            this.txtStates.Size = new System.Drawing.Size(155, 20);
            this.txtStates.TabIndex = 11;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhone.Location = new System.Drawing.Point(57, 299);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 20);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone Nb:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(509, 51);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 20);
            this.txtID.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(96, 212);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(166, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDept.Location = new System.Drawing.Point(380, 106);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(107, 20);
            this.lblDept.TabIndex = 14;
            this.lblDept.Text = "Departement:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(16, 186);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(119, 20);
            this.lblAddress2.TabIndex = 1;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(166, 104);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(155, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(16, 160);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(119, 20);
            this.lblAddress1.TabIndex = 0;
            this.lblAddress1.Text = "Address Line 1:";
            // 
            // txtlname
            // 
            this.txtlname.Enabled = false;
            this.txtlname.Location = new System.Drawing.Point(166, 77);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(155, 20);
            this.txtlname.TabIndex = 8;
            // 
            // txtfname
            // 
            this.txtfname.Enabled = false;
            this.txtfname.Location = new System.Drawing.Point(166, 51);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(155, 20);
            this.txtfname.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(83, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRole.Location = new System.Drawing.Point(441, 77);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 20);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Role:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.Location = new System.Drawing.Point(48, 104);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbllname.Location = new System.Drawing.Point(45, 77);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(90, 20);
            this.lbllname.TabIndex = 2;
            this.lbllname.Text = "Last Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblID.Location = new System.Drawing.Point(457, 51);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblfName
            // 
            this.lblfName.AutoSize = true;
            this.lblfName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblfName.Location = new System.Drawing.Point(45, 51);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(90, 20);
            this.lblfName.TabIndex = 1;
            this.lblfName.Text = "First Name:";
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(215, 61);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(402, 20);
            this.lblDescribe.TabIndex = 5;
            this.lblDescribe.Text = "Manage Profile";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(383, 523);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 48;
            this.lblError.Text = "Error: ";
            this.lblError.Visible = false;
            // 
            // ManageProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 510);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Name = "ManageProfile";
            this.Text = "Human Resources: Manage Profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.TextBox txtStates;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassDesc;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblPasswordDesc;
        private System.Windows.Forms.TextBox txtZIP;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.ComboBox cBoxStates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MaskedTextBox txtPhoneNum;
    }
}