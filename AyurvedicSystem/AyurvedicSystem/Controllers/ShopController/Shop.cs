using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyurvedicSystem.Controllers.ShopController
{
    class Shop
    {

        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        bool status;
        int count = 0;

        public int sell(String order_no, String item_name, String item_code, String qty, String eachprice,String total,String patient_no,String customer_name)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "insert into ayurvedicsystem.shop (`order_no`, `item_name`, `item_code`, `qty`, `eachprice`, `total`, `patient_no`, `customer_name`) values" +
                " ('" + order_no + "','" + item_name + "','" + item_code + "','" +qty+ "','" + eachprice + "','" + total+ "','" + patient_no + "','" + customer_name + "')";

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                conn.Close();
                count = count + 1;
            }

            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);

            }

            return count;
        }

        public Double pay(String order_no)
        {
            Double total = 0;
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            List<String> suplierDetails = new List<string>();

            query = "select * from shop where order_no = '" + order_no + "' ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    total = total + Double.Parse(rd["total"].ToString());

                }
               

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return total;
        }

    }
}
