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
    public partial class ManageProfile : Form
    {
        public int userID;
        public User user;
        public ManageProfile(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            User current = new User(userID);
            txtID.Text = "" + current.userID;
            txtfname.Text = "" + current.firstName;
            txtlname.Text = "" + current.lastName;
            txtUsername.Text = "" + current.username;
            txtEmail.Text = "" + current.email;
            txtAddress.Text = current.address1 + "\r\n" + ((current.address2 != "") ? "\r\n" + current.address2 : "") + current.city + "\r\n" + current.state + "\r\n" + current.zip;
            txtPhone.Text = "" + current.phoneNum;
            switch (current.depID)
            {
                case 1:
                    txtDept.Text = "Administration";
                    break;
                case 2:
                    txtDept.Text = "Executive";
                    break;
                case 3:
                    txtDept.Text = "Finance";
                    break;
                case 4:
                    txtDept.Text = "Human Resources";
                    break;
                case 5:
                    txtDept.Text = "Information Technology";
                    break;
                case 6:
                    txtDept.Text = "Maintenance";
                    break;
                case 7:
                    txtDept.Text = "Productions";
                    break;
                case 8:
                    txtDept.Text = "Projects";
                    break;
                case 9:
                    txtDept.Text = "Quality";
                    break;
                case 10:
                    txtDept.Text = "Research";
                    break;
                case 11:
                    txtDept.Text = "Sales";
                    break;
                case 12:
                    txtDept.Text = "Security";
                    break;
            }

            //set role id type
            switch (current.roleID)
            {
                case 1:
                    txtRole.Text = "Associate Staff";
                    break;
                case 2:
                    txtRole.Text = "Intermediate Staff";
                    break;
                case 3:
                    txtRole.Text = "Senior Staff";
                    break;
                case 4:
                    txtRole.Text = "Manager";
                    break;
                case 5:
                    txtRole.Text = "Senior Manager";
                    break;
                case 6:
                    txtRole.Text = "Advisor";
                    break;
                case 7:
                    txtRole.Text = "Senior Advisor";
                    break;
                case 8:
                    txtRole.Text = "Executive";
                    break;
                case 9:
                    txtRole.Text = "Senior Executive";
                    break;
                case 10:
                    txtRole.Text = "Director";
                    break;
                case 11:
                    txtRole.Text = "Senior Director";
                    break;
            }
            txtHireDate.Text = "" + current.hireDate;
            txtPayRate.Text = "" + current.payRate;
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Menu"].Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnSubmit.Visible = true;
            txtID.Enabled = true;
            txtfname.Enabled = true;
            txtPhone.Enabled = true;
            txtlname.Enabled = true;
            txtEmail.Enabled = true;
            txtUsername.Enabled = true;
        }
    }
}
