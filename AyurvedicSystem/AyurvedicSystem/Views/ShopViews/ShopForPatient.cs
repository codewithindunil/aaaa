using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyurvedicSystem.Controllers.RegistrationController;
using MySql.Data.MySqlClient;
using AyurvedicSystem.Controllers.ShopController;

namespace AyurvedicSystem.ShopViews
{
    public partial class ShopForPatient : UserControl
    {
        int count = 0;
        double netTotal = 0;
        String max;
        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        public ShopForPatient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShopForPatient_Load(object sender, EventArgs e)
        {
            max = new Generalprocess().getNextOrderNo();
            txtOrderNo.Text = "OTHER" + (int.Parse(max) + 1).ToString();
            loadItems();
            loadPatients();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPrices(comboBox1.SelectedItem.ToString());

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            String order_id = txtOrderNo.Text;
            String patient_name = txtPatientName.Text;
            String iteme_id = comboBox1.SelectedItem.ToString();
            String item_name = txtItemName.Text;
            String qty = txtQty.Text;
            String each_price = txtEachPrice.Text;
            String total = txtTotal.Text;
            String patient_Id = comboBox2.SelectedItem.ToString();

            netTotal = netTotal + Double.Parse(total);



            dataGridView1.Columns.Add("asd", "order_id");
            dataGridView1.Columns.Add("asd", "patient_id");

            dataGridView1.Columns.Add("asd", "patient_name");
            dataGridView1.Columns.Add("asd", "iteme_id");
            dataGridView1.Columns.Add("asd", "item_name");
            dataGridView1.Columns.Add("asd", "qty");
            dataGridView1.Columns.Add("asd", "each_price");
            dataGridView1.Columns.Add("asd", "total");
            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 160;
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[4].Width = 160;
            dataGridView1.Columns[5].Width = 160;
            dataGridView1.Columns[6].Width = 160;
            dataGridView1.Columns[7].Width = 160;


            string[] row = { order_id, patient_Id, patient_name, iteme_id, item_name, qty, each_price, total };
            count = new Shop().sell(order_id, item_name, iteme_id, qty, each_price, total, patient_Id, patient_name);
            if (count == 1)
            {
                dataGridView1.Rows.Add(row);
            }
        }

        public void loadPrices(String item_id)
        {
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM ayurvedicsystem.medicine_items where item_id = '" + item_id + "' ";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    txtEachPrice.Text = rd.GetString("selling_price");
                    txtItemName.Text = rd.GetString("item_name");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void loadPatients()
        {
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM ayurvedicsystem.patientdetails ";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                //comboBox1.Items.Clear();
                while (rd.Read())
                {
                    comboBox2.Items.Add(rd.GetString("patient_id"));

                    //Console.WriteLine(rd.GetString("sname"));
                }
                //comboBox1.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPatientsNames(comboBox2.SelectedItem.ToString());
        }
        public void loadItems()
        {
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM ayurvedicsystem.medicine_items ";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                //comboBox1.Items.Clear();
                while (rd.Read())
                {
                    comboBox1.Items.Add(rd.GetString("item_id"));

                    //Console.WriteLine(rd.GetString("sname"));
                }
                //comboBox1.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void loadPatientsNames(String patient_id)
        {
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM ayurvedicsystem.patientdetails where patient_id = '" + patient_id+"' ";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                //comboBox1.Items.Clear();
                while (rd.Read())
                {
                    txtPatientName.Text= rd.GetString("patient_name");

                    //Console.WriteLine(rd.GetString("sname"));
                }
                //comboBox1.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void txtQty_OnValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = (Double.Parse(txtQty.Text) * Double.Parse(txtEachPrice.Text)).ToString();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Double total = new Shop().pay(txtOrderNo.Text);
            new FrmTotal(total.ToString(), txtOrderNo.Text).Show();
        }
    }
}
