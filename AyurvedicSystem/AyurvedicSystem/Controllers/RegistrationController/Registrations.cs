using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyurvedicSystem.Controllers.RegistrationController
{
    class Registrations
    {
        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        bool status;

        //මෙම method එක call කිරීමෙන් නව Doctor කෙනෙක් register කල හැක
        public bool registerDoctor(String empId,String empName,String ad1,String ad2,String ad3,String sex,String type,String docRegNo,String mobile,String email,String createdBy)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "insert into ayurvedicsystem.doctordetails ( `employee_id`, `employee_name`, `address_line_1`, `address_line_2`, `address_line_3`, `sex`, `type`, `doctor_reg_no`, `mobile`, `email`, `created_by`) values" +
                " ('" + empId + "','" + empName.ToUpper() + "','" + ad1 + "','" + ad2.ToUpper() + "','" + ad3.ToUpper() + "','" + sex.ToUpper() + "','" + type.ToUpper() + "','" + docRegNo + "','" + mobile + "','" + email+ "','" + createdBy.ToUpper() + "')";

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("Doctor added sussefully ...");
                status = true;
            }

            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);

            }
            return status;
        }

        //මෙම method එක call කිරීමෙන් නම patient කෙනෙක් register කල හැක
        public bool registerPatient(String patientId, String patientName, String ad1, String ad2, String ad3, String sex, String type, String age, String mobile, String email, String createdBy)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "insert into ayurvedicsystem.patientdetails (`patient_id`, `patient_name`, `address_line_1`, `address_line_2`, `address_line_3`, `age`, `sex`, `mobile`, `email`, `created_by` ) values" +
                " ('" + patientId + "','" + patientName.ToUpper() + "','" + ad1 + "','" + ad2.ToUpper() + "','" + ad3.ToUpper() + "','" + age + "','" + sex.ToUpper() + "','" + mobile + "','" + email + "','" + createdBy.ToUpper() + "')";


            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("Patient added sussefully ...");
                status = true;
            }

            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);

            }
            return status;
        }

        public bool registerSupplier(String supId, String supName, String adr1, String adr2, String adr3, String contactPerson, String mobile, String email, String createdBy)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "insert into ayurvedicsystem.suppliers ( `suplier_id`, `suplier_name`, `adress_line_1`, `adress_line_2`, `adress_line_3`, `contact_person`, `mobile_no`, `email`, `created_by` ) values" +
                " ('" + supId + "','" + supName.ToUpper() + "','" + adr1 + "','" + adr2.ToUpper() + "','" + adr3.ToUpper() + "','"+contactPerson.ToUpper()+"','" + mobile + "','" + email + "','" + createdBy.ToUpper() + "')";


            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("Supplier added sussefully ...");
                status = true;
            }

            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);

            }
            return status;
        }


        public bool registerItem(String itemId,String itemCode,String itemName,String uom,String createdBy,String expDate,String expMonth,String expYear,String supplier,String price)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "insert into ayurvedicsystem.medicine_items ( `item_id`, `item_code`, `item_name`, `uom`, `created_by`, `expDate`, `expMonth`, `expYear`, `supplier_id`,`selling_price` ) values" +
                " ('" + itemId + "','" + itemCode + "','" + itemName + "','" + uom + "','" + createdBy + "','" +expDate + "','" + expMonth + "','" + expYear + "','"+supplier+"','"+price+"')";


            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("Item added sussefully ...");
                status = true;
            }

            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);

            }
            return status;
        }
    }

   

}
