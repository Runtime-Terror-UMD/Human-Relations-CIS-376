using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Human_Relations.Pages;



namespace Human_Relations.Pages
{
    public partial class schedule : Form
    {
        public schedule()
        {
            InitializeComponent();
        }

        DBConnect scheduleConn = new DBConnect();
        DataTable scheduleData = new DataTable();
        BindingSource scheduleBindingSource = new BindingSource();
        MySqlCommand cmd = new MySqlCommand();


        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            try
            {
                string formattedDate = scheduleDatePicker.Value.ToString("yyyy-MM-dd");

                cmd.CommandText = @"SELECT   
                                    u.userID as 'User ID',
                                    concat(u.firstName, ' ', u.lastName) as 'Name',
                                    TIME_FORMAT(s.indateTime, '%r') as 'Start Time', 
                                    TIME_FORMAT(s.outDateTime, '%r') as 'End Time'
                                    from dbo.schedule s
                                    join dbo.user u
	                                    on u.userID = s.userID
                                    WHERE DATE(s.inDateTime) = @date";
                cmd.Parameters.Add("@date", MySqlDbType.Date).Value = formattedDate;

                scheduleData = scheduleConn.ExecuteDataTable(cmd);
                scheduleBindingSource.DataSource =scheduleData;
                scheduleDataGrid.DataSource = scheduleBindingSource;
                scheduleDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
