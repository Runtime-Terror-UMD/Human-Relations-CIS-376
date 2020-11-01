namespace Human_Relations.Pages
{
    partial class schedule
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
            this.scheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.dboDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dboDataSet = new Human_Relations.dboDataSet();
            this.scheduleDatePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleDataGrid
            // 
            this.scheduleDataGrid.AllowUserToAddRows = false;
            this.scheduleDataGrid.AllowUserToDeleteRows = false;
            this.scheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGrid.Location = new System.Drawing.Point(86, 271);
            this.scheduleDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scheduleDataGrid.MultiSelect = false;
            this.scheduleDataGrid.Name = "scheduleDataGrid";
            this.scheduleDataGrid.ReadOnly = true;
            this.scheduleDataGrid.RowHeadersWidth = 62;
            this.scheduleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scheduleDataGrid.Size = new System.Drawing.Size(1016, 506);
            this.scheduleDataGrid.TabIndex = 0;
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
            // scheduleDatePicker
            // 
            this.scheduleDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleDatePicker.Location = new System.Drawing.Point(86, 211);
            this.scheduleDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scheduleDatePicker.Name = "scheduleDatePicker";
            this.scheduleDatePicker.Size = new System.Drawing.Size(326, 30);
            this.scheduleDatePicker.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(446, 212);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(21, 14);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 38);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDescribe
            // 
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(344, 75);
            this.lblDescribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(600, 31);
            this.lblDescribe.TabIndex = 9;
            this.lblDescribe.Text = "View, create, and update schedules";
            this.lblDescribe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(339, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 62);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Human Resources";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(86, 146);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(243, 38);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create New Schedule";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(858, 206);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(243, 38);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.scheduleDatePicker);
            this.Controls.Add(this.scheduleDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "schedule";
            this.Text = "Scheduling";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scheduleDataGrid;
        private System.Windows.Forms.BindingSource dboDataSetBindingSource;
        private dboDataSet dboDataSet;
        private System.Windows.Forms.DateTimePicker scheduleDatePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
    }
}