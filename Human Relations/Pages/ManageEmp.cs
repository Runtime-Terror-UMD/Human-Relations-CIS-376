using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Relations.Pages
{
    public partial class ManageEmp : Form
    {
        public int userID;
        public ManageEmp(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            var hire = new NewAccount(userID);
            hire.FormClosed += new FormClosedEventHandler(NewAccount_FormClosed);
            this.Hide();
            hire.Show();
        }

        private void NewAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }
    }
}
