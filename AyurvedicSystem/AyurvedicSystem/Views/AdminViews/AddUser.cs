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
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            String name, username, password, privilages;
            name = txtame.Text;
            username = txtUsername.Text;
            password = txtPassword.Text;
            if (bunifuSwitch1.Value == true)
            {
                privilages = "1";
            }
            else
            {
                privilages = "2";
            }

            bool status=new AccessCOntroller().addUser(name.ToUpper(), username.ToUpper(), password, privilages);
            if (status = true)
            {
                MessageBox.Show("Added Successfully");
                txtame.Text = "";
                txtPassword.Text = "";
                txtUsername.Text = "";

            }
            else
            {
                MessageBox.Show("Something Wrong.Plese try again");
            }
        }
    }
}
