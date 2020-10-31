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
    public partial class UpdateEmpProfile : Form
    {
        public int adminUserID;
        public int empUserID;

        public UpdateEmpProfile()
        {
            InitializeComponent();
        }

        public UpdateEmpProfile(int UserID)
        {
            InitializeComponent();
            adminUserID = UserID;
        }

        private void displayError(string errorMessage)
        {
            lblError.Text = "Error: " + errorMessage;
            lblError.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Utilities verifyAcct = new Utilities();

            if (!(int.TryParse(txtUserID.Text, out empUserID)))
            { displayError("User ID must be an integer"); }

            else if(!(verifyAcct.userIDExists(empUserID)))
            { displayError("User ID does not exist"); }

            else if(empUserID == adminUserID)
            { displayError("You must update your account through the 'My Account Settings' page"); }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
