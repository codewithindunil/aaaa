using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyurvedicSystem.Controllers.AccessController;

namespace AyurvedicSystem.Views.AdminViews
{
    public partial class ViewUser : UserControl
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtPrivilages.Text = "";
            txtUsername.Text = "";

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (txtNameForSearch.Text == "")
            {
                MessageBox.Show("Please Enter a Name");
            }
            else
            {
                List<String> userDetails = new AccessCOntroller().searchUser(txtNameForSearch.Text);
                txtName.Text = userDetails[0];
                txtUsername.Text = userDetails[1];
                txtPrivilages.Text = userDetails[3];
                txtPassword.Text = userDetails[2];

            }
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            new AccessCOntroller().updateUser(txtNameForSearch.Text,txtName.Text,txtUsername.Text,txtPassword.Text,txtPrivilages.Text);
          
        }
    }
}
