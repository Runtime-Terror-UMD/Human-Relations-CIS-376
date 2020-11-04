﻿namespace Human_Relations.Pages
{
    partial class ManageEmp
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gBoxName = new System.Windows.Forms.GroupBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.cBoxStates = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxAdmin = new System.Windows.Forms.ComboBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cBoxRole = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboDataSet = new Human_Relations.dboDataSet();
            this.lblRole = new System.Windows.Forms.Label();
            this.cBoxDep = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDep = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.departmentTableAdapter = new Human_Relations.dboDataSetTableAdapters.departmentTableAdapter();
            this.gBoxContactInfo = new System.Windows.Forms.GroupBox();
            this.txtPhoneNum = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new Human_Relations.dboDataSetTableAdapters.roleTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gBoxName.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.gBoxContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(255, 80);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(225, 50);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(400, 20);
            this.lblDescribe.TabIndex = 2;
            this.lblDescribe.Text = "Search and manage employee profiles";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(222, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(688, 14);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(72, 26);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmployee.Location = new System.Drawing.Point(89, 18);
            this.btnNewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(109, 29);
            this.btnNewEmployee.TabIndex = 9;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(16, 14);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 25);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // gBoxName
            // 
            this.gBoxName.Controls.Add(this.lblFName);
            this.gBoxName.Controls.Add(this.lblLName);
            this.gBoxName.Controls.Add(this.txtLName);
            this.gBoxName.Controls.Add(this.txtFName);
            this.gBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxName.Location = new System.Drawing.Point(44, 121);
            this.gBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxName.Name = "gBoxName";
            this.gBoxName.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxName.Size = new System.Drawing.Size(296, 100);
            this.gBoxName.TabIndex = 1;
            this.gBoxName.TabStop = false;
            this.gBoxName.Text = "Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(13, 31);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(90, 20);
            this.lblFName.TabIndex = 10;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(13, 63);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(90, 20);
            this.lblLName.TabIndex = 41;
            this.lblLName.Text = "Last Name:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(136, 63);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(148, 26);
            this.txtLName.TabIndex = 2;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(136, 29);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(148, 26);
            this.txtFName.TabIndex = 1;
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.txtZIP);
            this.groupBoxAddress.Controls.Add(this.txtCity);
            this.groupBoxAddress.Controls.Add(this.txtAddress2);
            this.groupBoxAddress.Controls.Add(this.txtAddress1);
            this.groupBoxAddress.Controls.Add(this.cBoxStates);
            this.groupBoxAddress.Controls.Add(this.label2);
            this.groupBoxAddress.Controls.Add(this.label1);
            this.groupBoxAddress.Controls.Add(this.lblCity);
            this.groupBoxAddress.Controls.Add(this.lblAddress2);
            this.groupBoxAddress.Controls.Add(this.lblAddress1);
            this.groupBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddress.Location = new System.Drawing.Point(44, 235);
            this.groupBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAddress.Size = new System.Drawing.Size(296, 181);
            this.groupBoxAddress.TabIndex = 2;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Address";
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(135, 146);
            this.txtZIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtZIP.MaxLength = 5;
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(82, 26);
            this.txtZIP.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(135, 85);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(149, 26);
            this.txtCity.TabIndex = 2;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(135, 57);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(149, 26);
            this.txtAddress2.TabIndex = 1;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(136, 27);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(149, 26);
            this.txtAddress1.TabIndex = 0;
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
            this.cBoxStates.Location = new System.Drawing.Point(135, 117);
            this.cBoxStates.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxStates.Name = "cBoxStates";
            this.cBoxStates.Size = new System.Drawing.Size(82, 28);
            this.cBoxStates.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ZIP Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(4, 89);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 20);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City: ";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(4, 60);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(119, 20);
            this.lblAddress2.TabIndex = 1;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(4, 29);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(119, 20);
            this.lblAddress1.TabIndex = 0;
            this.lblAddress1.Text = "Address Line 1:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(43, 84);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(68, 20);
            this.lblUserID.TabIndex = 44;
            this.lblUserID.Text = "User ID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(113, 80);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(129, 26);
            this.txtUserID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxAdmin);
            this.groupBox1.Controls.Add(this.lblAdmin);
            this.groupBox1.Controls.Add(this.cBoxStatus);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.cBoxRole);
            this.groupBox1.Controls.Add(this.lblRole);
            this.groupBox1.Controls.Add(this.cBoxDep);
            this.groupBox1.Controls.Add(this.lblDep);
            this.groupBox1.Controls.Add(this.lblPayRate);
            this.groupBox1.Controls.Add(this.txtPayRate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(408, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(317, 211);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employment Information";
            // 
            // cBoxAdmin
            // 
            this.cBoxAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAdmin.FormattingEnabled = true;
            this.cBoxAdmin.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cBoxAdmin.Location = new System.Drawing.Point(122, 174);
            this.cBoxAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxAdmin.Name = "cBoxAdmin";
            this.cBoxAdmin.Size = new System.Drawing.Size(162, 28);
            this.cBoxAdmin.TabIndex = 4;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(4, 179);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(107, 20);
            this.lblAdmin.TabIndex = 19;
            this.lblAdmin.Text = "Administrator:";
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cBoxStatus.Location = new System.Drawing.Point(122, 140);
            this.cBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(162, 28);
            this.cBoxStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(4, 146);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status:";
            // 
            // cBoxRole
            // 
            this.cBoxRole.DataSource = this.roleBindingSource;
            this.cBoxRole.DisplayMember = "roleName";
            this.cBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxRole.FormattingEnabled = true;
            this.cBoxRole.Location = new System.Drawing.Point(122, 107);
            this.cBoxRole.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxRole.Name = "cBoxRole";
            this.cBoxRole.Size = new System.Drawing.Size(162, 28);
            this.cBoxRole.TabIndex = 2;
            this.cBoxRole.ValueMember = "roleID";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "role";
            this.roleBindingSource.DataSource = this.dboDataSet;
            // 
            // dboDataSet
            // 
            this.dboDataSet.DataSetName = "dboDataSet";
            this.dboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(4, 112);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 20);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role:";
            // 
            // cBoxDep
            // 
            this.cBoxDep.DataSource = this.departmentBindingSource;
            this.cBoxDep.DisplayMember = "depName";
            this.cBoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDep.FormattingEnabled = true;
            this.cBoxDep.Location = new System.Drawing.Point(122, 71);
            this.cBoxDep.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxDep.Name = "cBoxDep";
            this.cBoxDep.Size = new System.Drawing.Size(162, 28);
            this.cBoxDep.TabIndex = 1;
            this.cBoxDep.ValueMember = "depID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.dboDataSet;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(4, 76);
            this.lblDep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(98, 20);
            this.lblDep.TabIndex = 13;
            this.lblDep.Text = "Department:";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(4, 39);
            this.lblPayRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(78, 20);
            this.lblPayRate.TabIndex = 11;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(122, 37);
            this.txtPayRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(162, 26);
            this.txtPayRate.TabIndex = 0;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // gBoxContactInfo
            // 
            this.gBoxContactInfo.Controls.Add(this.txtPhoneNum);
            this.gBoxContactInfo.Controls.Add(this.lblPhoneNum);
            this.gBoxContactInfo.Controls.Add(this.lblEmail);
            this.gBoxContactInfo.Controls.Add(this.txtEmail);
            this.gBoxContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxContactInfo.Location = new System.Drawing.Point(408, 323);
            this.gBoxContactInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxContactInfo.Name = "gBoxContactInfo";
            this.gBoxContactInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxContactInfo.Size = new System.Drawing.Size(317, 93);
            this.gBoxContactInfo.TabIndex = 4;
            this.gBoxContactInfo.TabStop = false;
            this.gBoxContactInfo.Text = "Contact Information";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(130, 23);
            this.txtPhoneNum.Mask = "(999) 000-0000";
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(154, 26);
            this.txtPhoneNum.TabIndex = 0;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(4, 27);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNum.TabIndex = 53;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(4, 63);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 60);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(640, 430);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(356, 467);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(400, 20);
            this.lblError.TabIndex = 56;
            this.lblError.Text = "Error:";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "department";
            this.departmentBindingSource1.DataSource = this.dboDataSet;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNewEmployee);
            this.groupBox2.Location = new System.Drawing.Point(44, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 56);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Employee";
            // 
            // ManageEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gBoxContactInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.gBoxName);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ManageEmp";
            this.Text = "Human Resources: Employee Management";
            this.Load += new System.EventHandler(this.ManageEmp_Load);
            this.gBoxName.ResumeLayout(false);
            this.gBoxName.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.gBoxContactInfo.ResumeLayout(false);
            this.gBoxContactInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox gBoxName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.GroupBox groupBoxAddress;
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
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxAdmin;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.ComboBox cBoxRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cBoxDep;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.TextBox txtPayRate;
        private dboDataSet dboDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private dboDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.GroupBox gBoxContactInfo;
        private System.Windows.Forms.MaskedTextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private dboDataSetTableAdapters.roleTableAdapter roleTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}