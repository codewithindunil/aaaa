using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyurvedicSystem.Controllers.RegistrationController
{
    class Generalprocess
    {
        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        String max;

        public String getLastEmpId()
        {
            
            MySqlDataReader rd;
            string sMonth = DateTime.Now.ToString("MM");
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT MAX(id) FROM doctordetails; ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                max=command.ExecuteScalar().ToString();
                
                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return max;
        }

        public String getNextPatientNo()
        {

            MySqlDataReader rd;
            string sMonth = DateTime.Now.ToString("MM");
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT MAX(id) FROM patientdetails; ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                max = command.ExecuteScalar().ToString();

                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return max;
        }

        public String getNextSupplierNo()
        {

            MySqlDataReader rd;
            string sMonth = DateTime.Now.ToString("MM");
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT MAX(id) FROM suppliers; ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                max = command.ExecuteScalar().ToString();

                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return max;
        }

        public String getNextItemNo()
        {
            MySqlDataReader rd;
            string sMonth = DateTime.Now.ToString("MM");
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT MAX(id) FROM medicine_items; ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                max = command.ExecuteScalar().ToString();

                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return max;
        }

        public String getNextOrderNo()
        {
            MySqlDataReader rd;
            string sMonth = DateTime.Now.ToString("MM");
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT MAX(id) FROM shop; ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                max = command.ExecuteScalar().ToString();

                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return max;
        }
        public String getNextTreatmentNo()
        {
            MySqlDataReader rd;
            string sMonth = DateTime.Now.ToString("MM");
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT MAX(id) FROM treatments; ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                max = command.ExecuteScalar().ToString();

                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return max;
        }

    }
}
