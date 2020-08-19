using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyurvedicSystem.ShopViews;
using MySql.Data.MySqlClient;
using AyurvedicSystem.Controllers.TreatmentController;
using AyurvedicSystem.Controllers.RegistrationController;

namespace AyurvedicSystem.Treatments
{
    public partial class TreatmentsExisting : UserControl
    {
        String user;
        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        String max;
        public TreatmentsExisting(String user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void TreatmentsExisting_Load(object sender, EventArgs e)
        {
           loadPatients();
            loadDoctores();
            max = new Generalprocess().getNextTreatmentNo();
            //txtSeqId.Text = "T" + (int.Parse(max) + 1).ToString();
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
        public void loadDoctores()
        {
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
            conn = new MySqlConnection(connetionString);
            String query;


            query = "SELECT * FROM ayurvedicsystem.doctordetails ";
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                rd = command.ExecuteReader();
                //comboBox1.Items.Clear();
                while (rd.Read())
                {
                    comboBox1.Items.Add(rd.GetString("employee_id"));

                    //Console.WriteLine(rd.GetString("sname"));
                }
                //comboBox1.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //String seq_id =txtSeqId.Text;
            String patient_id =comboBox2.SelectedItem.ToString();
               String doctor_id = comboBox1.SelectedItem.ToString(); ;
            String treatment_type =txtTreatmentType.Text;
            String other_treatment =txtOther.Text;
            String description =txtDescription.Text;
            String mr_issue_date =DateTime.Now.ToString();
            String created_by =user;
            new TreatmentControll().addTreatementForExistingPatient( " ",  patient_id,  doctor_id,  treatment_type,  other_treatment,  description,  mr_issue_date,  created_by);
        }
    }
}
