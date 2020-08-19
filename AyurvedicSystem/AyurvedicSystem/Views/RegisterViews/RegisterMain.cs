using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyurvedicSystem.RegisterViews;

namespace AyurvedicSystem
{
    public partial class RegisterMain : UserControl
    {
        String user;
        public RegisterMain(String user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            RegistrationDoctor item = new RegistrationDoctor(user);
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            RegisterPatient item = new RegisterPatient(user);
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            RegisterSupplier item = new RegisterSupplier(user);
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            RegisterItem item = new RegisterItem(user);
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
        }

        private void RegisterMain_Load(object sender, EventArgs e)
        {

        }
    }
}
