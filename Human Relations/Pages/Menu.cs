using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Human_Relations.Pages;

namespace Human_Relations
{
    public partial class Menu : Form
    {
        public int UserID;
        Login loginWind;
        public Menu(Login loginInstance, DateTime current)
        {
            InitializeComponent();
            loginWind = loginInstance;
        }

        // DESCRIPTION: Initializer. Shows/hides hotel management button based on isCustomer
        public Menu(bool isAdmin, int userID, Login loginInstance)
        {
            InitializeComponent();
            loginWind = loginInstance;
            UserID = userID;
            if (!isAdmin)
            {
                btnManageEmp.Visible = false;
                
            }
        }
        //DESCRIPTION: Opens account settings page
        private void btnAccount_Click(object sender, EventArgs e)
        {
            var accountSettings = new AccountSettings(UserID);
            accountSettings.FormClosed += new FormClosedEventHandler(accountSettings_FormClosed);
            this.Hide();
            accountSettings.Show();
        }
        void accountSettings_FormClosed(object send, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var history = new History(UserID);
            history.FormClosed += new FormClosedEventHandler(history_FormClosed);
            this.Hide();
            history.Show();
        }

        private void history_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void ManageEmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            var manage = new ManageEmp(UserID);
            manage.FormClosed += new FormClosedEventHandler(ManageEmp_FormClosed);
            this.Hide();
            manage.Show();
        }

        private void btnManageProfile_Click(object sender, EventArgs e)
        {
            var profile = new ManageProfile(UserID);
            profile.FormClosed += new FormClosedEventHandler(profile_FormClosed);
            this.Hide();
            profile.Show();
        }

        private void profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
