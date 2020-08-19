using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyurvedicSystem.Controllers.RegistrationController
{
    class Search
    {
        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        public List<String> searchDoctorDetails(String id)
        {
            MySqlDataReader rd;
            String user = "", privilages = "";
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            List<String> doctorDetails = new List<string>();

            query = "select * from doctordetails where employee_id = '" + id + "' ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {



                    doctorDetails.Add(rd["employee_id"].ToString());
                    doctorDetails.Add(rd["employee_name"].ToString());
                    doctorDetails.Add(rd["address_line_1"].ToString());
                    doctorDetails.Add(rd["address_line_2"].ToString());
                    doctorDetails.Add(rd["address_line_3"].ToString());
                    doctorDetails.Add(rd["sex"].ToString());
                    doctorDetails.Add(rd["type"].ToString());
                    doctorDetails.Add(rd["doctor_reg_no"].ToString());
                    doctorDetails.Add(rd["mobile"].ToString());
                    doctorDetails.Add(rd["email"].ToString());
                    doctorDetails.Add(rd["created_by"].ToString());

                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return doctorDetails;
        }

        public List<String> searchPatientDetails(String id)
        {
            int count = 0;
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            List<String> patientDetails = new List<string>();

            query = "select * from patientdetails where patient_id = '" + id + "' ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    count = count + 1;


                    patientDetails.Add(rd["patient_id"].ToString());
                    patientDetails.Add(rd["patient_name"].ToString());
                    patientDetails.Add(rd["address_line_1"].ToString());
                    patientDetails.Add(rd["address_line_2"].ToString());
                    patientDetails.Add(rd["address_line_3"].ToString());
                    patientDetails.Add(rd["age"].ToString());
                    patientDetails.Add(rd["sex"].ToString());
                    patientDetails.Add(rd["mobile"].ToString());
                    patientDetails.Add(rd["email"].ToString());

                }
                Console.WriteLine(patientDetails);
                if (count < 1)
                {
                    MessageBox.Show("not a valid id");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return patientDetails;
        }
        public List<String> searchItemDetails(String id)
        {
            int count = 0;
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            List<String> itemDetails = new List<string>();

            query = "select * from medicine_items where item_id = '" + id + "' ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    count = count + 1;


                    itemDetails.Add(rd["item_id"].ToString());
                    itemDetails.Add(rd["item_code"].ToString());
                    itemDetails.Add(rd["item_name"].ToString());
                    itemDetails.Add(rd["uom"].ToString());
                    itemDetails.Add(rd["expDate"].ToString());
                    itemDetails.Add(rd["expMonth"].ToString());
                    itemDetails.Add(rd["expYear"].ToString());
                    itemDetails.Add(rd["supplier_id"].ToString());

                }
                Console.WriteLine(itemDetails);
                if (count < 1)
                {
                    MessageBox.Show("not a valid id");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return itemDetails;
        }

        public List<String> searchSuplieretails(String id)
        {
            int count = 0;
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            List<String> suplierDetails = new List<string>();

            query = "select * from suppliers where suplier_id = '" + id + "' ";

            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                while (rd.Read())
                {
                    count = count + 1;


                    suplierDetails.Add(rd["suplier_id"].ToString());
                    suplierDetails.Add(rd["suplier_name"].ToString());
                    suplierDetails.Add(rd["adress_line_1"].ToString());
                    suplierDetails.Add(rd["adress_line_2"].ToString());
                    suplierDetails.Add(rd["adress_line_3"].ToString());
                    suplierDetails.Add(rd["contact_person"].ToString());
                    suplierDetails.Add(rd["mobile_no"].ToString());
                    suplierDetails.Add(rd["email"].ToString());
                    suplierDetails.Add(rd["created_by"].ToString());

                }
                if (count < 1)
                {
                    MessageBox.Show("not a valid id");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return suplierDetails;
        }
    }
}
