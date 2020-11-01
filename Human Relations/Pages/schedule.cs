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



        private void btnSearch_Click(object sender, EventArgs e)
        { }
    }
}
//            DBConnect scheduleConn = new DBConnect();
//            DataTable scheduleData = new DataTable();
//            BindingSource scheduleBindingSource = new BindingSource();
//            MySqlCommand cmd = new MySqlCommand();

//            if ()
//            {
//                try
//                {
//                    cmd.CommandText = @"select ";
//                    cmd.Parameters.Add("@userID", MySqlDbType.Int32).Value = userID;

//                    scheduleData = scheduleConn.ExecuteDataTable(cmd);
//                    scheduleBindingSource.DataSource = scheduleData;
//                    scheduleDataGrid.DataSource = scheduleBindingSource;
//                    scheduleDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//                }

//                catch (Exception err)
//                {
//                    MessageBox.Show(err.ToString());
//                }
//            }
//    }
//}
