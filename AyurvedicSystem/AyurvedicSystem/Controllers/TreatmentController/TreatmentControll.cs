using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyurvedicSystem.Controllers.TreatmentController
{
    class TreatmentControll
    {
        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        bool status;
        public void addTreatementForExistingPatient(String seq_id, String patient_id, String doctor_id, String treatment_type, String other_treatment, String description, String mr_issue_date, String created_by)
        {
            MySqlDataReader rd;
            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "insert into ayurvedicsystem.treatments ( `seq_id`, `patient_id`, `doctor_id`, `treatment_type`, `other_treatment`, `description`, `mr_issue_date`, `created_by` ) values" +
                " ('" + seq_id + "','" + patient_id + "','" + doctor_id + "','" + treatment_type + "','" + other_treatment + "','" + description + "','" + mr_issue_date + "','" + created_by + "')";


            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("Treatment added sussefully ...");
                status = true;
            }

            catch (Exception ex)
            {
                status = false;
                Console.WriteLine(ex.Message);

            }
        }

      
    
}
}
