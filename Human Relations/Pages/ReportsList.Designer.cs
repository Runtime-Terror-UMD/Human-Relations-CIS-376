
namespace Human_Relations.Pages
{
    partial class ReportsList
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.cboxRole = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboDataSet = new Human_Relations.dboDataSet();
            this.cboxDepartment = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new Human_Relations.dboDataSetTableAdapters.roleTableAdapter();
            this.departmentTableAdapter = new Human_Relations.dboDataSetTableAdapters.departmentTableAdapter();
            this.reportDataGrid = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(699, 11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRole
            // 
            this.btnRole.Location = new System.Drawing.Point(177, 125);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(121, 21);
            this.btnRole.TabIndex = 23;
            this.btnRole.Text = "Role Report";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDepartment.Location = new System.Drawing.Point(629, 124);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(121, 21);
            this.btnDepartment.TabIndex = 24;
            this.btnDepartment.Text = "Department Report";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // cboxRole
            // 
            this.cboxRole.DataSource = this.roleBindingSource;
            this.cboxRole.DisplayMember = "roleName";
            this.cboxRole.FormattingEnabled = true;
            this.cboxRole.Location = new System.Drawing.Point(50, 125);
            this.cboxRole.Name = "cboxRole";
            this.cboxRole.Size = new System.Drawing.Size(121, 21);
            this.cboxRole.TabIndex = 25;
            this.cboxRole.ValueMember = "roleID";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "role";
            this.roleBindingSource.DataSource = this.dboDataSetBindingSource;
            // 
            // dboDataSetBindingSource
            // 
            this.dboDataSetBindingSource.DataSource = this.dboDataSet;
            this.dboDataSetBindingSource.Position = 0;
            // 
            // dboDataSet
            // 
            this.dboDataSet.DataSetName = "dboDataSet";
            this.dboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboxDepartment
            // 
            this.cboxDepartment.DataSource = this.departmentBindingSource;
            this.cboxDepartment.DisplayMember = "depName";
            this.cboxDepartment.FormattingEnabled = true;
            this.cboxDepartment.Location = new System.Drawing.Point(502, 125);
            this.cboxDepartment.Name = "cboxDepartment";
            this.cboxDepartment.Size = new System.Drawing.Size(121, 21);
            this.cboxDepartment.TabIndex = 26;
            this.cboxDepartment.ValueMember = "depID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.dboDataSetBindingSource;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // reportDataGrid
            // 
            this.reportDataGrid.AllowUserToAddRows = false;
            this.reportDataGrid.AllowUserToDeleteRows = false;
            this.reportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGrid.Location = new System.Drawing.Point(50, 200);
            this.reportDataGrid.Name = "reportDataGrid";
            this.reportDataGrid.ReadOnly = true;
            this.reportDataGrid.Size = new System.Drawing.Size(700, 325);
            this.reportDataGrid.TabIndex = 27;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 50);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblError.Location = new System.Drawing.Point(200, 60);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(400, 25);
            this.lblError.TabIndex = 29;
            this.lblError.Text = "Error:";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // ReportsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.reportDataGrid);
            this.Controls.Add(this.cboxDepartment);
            this.Controls.Add(this.cboxRole);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturn);
            this.Name = "ReportsList";
            this.Text = "ReportsList";
            this.Load += new System.EventHandler(this.ReportsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.ComboBox cboxRole;
        private System.Windows.Forms.ComboBox cboxDepartment;
        private System.Windows.Forms.BindingSource dboDataSetBindingSource;
        private dboDataSet dboDataSet;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private dboDataSetTableAdapters.roleTableAdapter roleTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private dboDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.DataGridView reportDataGrid;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;
    }
}