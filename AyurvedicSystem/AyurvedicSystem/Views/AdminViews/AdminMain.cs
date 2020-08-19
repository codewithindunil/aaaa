using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyurvedicSystem.Views.AdminViews
{
    public partial class AdminMain : UserControl
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddUser item = new AddUser();
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ViewUser item = new ViewUser();
            panel1.Controls.Clear();
            //item.Top = 10;
            //item.Left = 10;
            panel1.Controls.Add(item);
        }
    }
}
