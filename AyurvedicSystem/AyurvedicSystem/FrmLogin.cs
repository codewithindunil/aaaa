using AyurvedicSystem.Controllers.AccessController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledger_horana
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch(Exception )
            {
                MessageBox.Show("Servers are down....");
            }
           


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUserName.Text;
            String password = txtPassword.Text;

            bool status = new AccessCOntroller().login(username, password);
            if (status == true)
            {
                this.Hide();
            }
            else
            {
                txtPassword.Text = "";
                txtUserName.Text = "";
            }
        }

    }
}
