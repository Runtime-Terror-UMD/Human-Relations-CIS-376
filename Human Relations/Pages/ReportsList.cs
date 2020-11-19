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
    public partial class ReportsList : Form
    {
        int userID;
        public ReportsList()
        {
            InitializeComponent();
        }
        public ReportsList(int user)
        {
            userID = user;
            InitializeComponent();
        }

        public void errorMessage(string error)
        {
            lblError.Text = "Error: " + error;
            lblError.Visible = true;
        }
    }
}
