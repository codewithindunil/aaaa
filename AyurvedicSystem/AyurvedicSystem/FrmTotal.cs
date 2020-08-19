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
    public partial class FrmTotal : Form
    {
        String total,order_no;
        public FrmTotal(String total, String order_no)
        {
            this.total = total;
            this.order_no = order_no;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmTotal_Load(object sender, EventArgs e)
        {
            txtOrder.Text = order_no;
            txtTotal.Text = total;
        }
    }
}
