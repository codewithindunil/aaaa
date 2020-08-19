using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using AyurvedicSystem.Controllers.RegistrationController;
using MySql.Data.MySqlClient;

namespace AyurvedicSystem.RegisterViews
{
    public partial class RegisterItem : UserControl
    {
        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        String user,max;
        bool status;
        public RegisterItem(String user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
         
            String itemId = txtItemID.Text;
            String itemName = txtItemName.Text;
           // String itemCode = txtItemCode.Text;
            String uom = txtUom.Text;
            String expYear =dateTimePicker1.Value.Year.ToString();
            String expMonth=dateTimePicker1.Value.ToString("MM");
            String expDate= dateTimePicker1.Value.Day.ToString();
            String supplier = comboBox1.SelectedItem.ToString();
            String price = txtPrice.Text;
            if (itemId == "" || itemName == ""  || uom == "" || expYear == "" || expMonth == "" || expDate == "" )
            {
                MessageBox.Show("Please fill all the details");
            }
            else
            {
                status = new Registrations().registerItem(itemId, "", itemName, uom, user, expDate, expMonth, expYear, supplier,price);
                if (status == true)
                {

                    txtItemID.Text = "";
                    txtItemName.Text = "";
                   // txtItemCode.Text = "";
                    txtUom.Text = "";
                    txtPrice.Text = "";


                    RegisterItem_Load(sender, e);
                }

            }
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
            //txtItemCode.Text = "";
            txtUom.Text = "";
            txtPrice.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegisterItem_Load(object sender, EventArgs e)
        {
            max = new Generalprocess().getNextItemNo();
            txtItemID.Text = "ITEM" + (int.Parse(max) + 1).ToString();
            //txtItemCode.Text= (int.Parse(max) + 1).ToString();
            loadSuppliers();
        }

        public void loadSuppliers()
        {
            MySqlDataReader rd;
         
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM ayurvedicsystem.suppliers ";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                comboBox1.Items.Clear();
                while (rd.Read())
                {
                    comboBox1.Items.Add(rd.GetString("suplier_id"));

                    //Console.WriteLine(rd.GetString("sname"));
                }
                comboBox1.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
