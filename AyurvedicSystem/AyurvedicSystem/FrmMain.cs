using AyurvedicSystem.SearchViews;
using AyurvedicSystem.ShopViews;
using AyurvedicSystem.Treatments;
using AyurvedicSystem.Views.AdminViews;
using ledger_horana;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyurvedicSystem
{
    public partial class FrmMain : Form
    {
        String user, privilages;
        public FrmMain(String user,String privilages)
        {
            this.user = user;
            this.privilages = privilages;

            InitializeComponent();
            lblUser.Text = user;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtDebit_Click(object sender, EventArgs e)
        {

        }

        private void txtCredit_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            RegisterMain item = new RegisterMain( user);
            panel2.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel2.Controls.Add(item);
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            SearchMain item = new SearchMain();
            panel2.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel2.Controls.Add(item);
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            TteatmentsMain  item = new TteatmentsMain(user);
            panel2.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel2.Controls.Add(item);
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            AdminMain item = new AdminMain();
            panel2.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel2.Controls.Add(item);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string message = "Do you want logout ?";
            string title = "logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                frmLogin f = new frmLogin();
                
                f.Show();
                this.Hide();

            }
            else
            {
                // Do something  
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDay.Text = DateTime.Now.ToString("dddd");

            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSecond.Location.Y);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            ShopMain item = new ShopMain();
            panel2.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel2.Controls.Add(item);
        }
    }
}
