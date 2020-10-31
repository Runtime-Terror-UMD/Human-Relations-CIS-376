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
        public ManageProfile(int userID)
        {
            InitializeComponent();
            this.userID = userID;
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
    }
}
