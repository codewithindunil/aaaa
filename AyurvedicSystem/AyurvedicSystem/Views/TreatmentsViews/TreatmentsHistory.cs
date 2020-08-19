using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AyurvedicSystem.Treatments
{
    public partial class TreatmentsNew : UserControl
    {
        String user;
        public String serverPassword = "";
        public String serverName = "localhost";
        public String serveruser = "root";
        public TreatmentsNew(String user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("asd", "seq_id");
            dataGridView1.Columns.Add("asd", "patient_id");

            dataGridView1.Columns.Add("asd", "doctor_id");
            dataGridView1.Columns.Add("asd", "treatment_type");
            dataGridView1.Columns.Add("asd", "other_treatment");
            dataGridView1.Columns.Add("asd", "description");
            dataGridView1.Columns.Add("asd", "mr_issue_date");
            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 160;
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[4].Width = 160;
            dataGridView1.Columns[5].Width = 160;
            dataGridView1.Columns[6].Width = 160;


            
            
            String searchId = txtPatientID.Text;
            if (searchId == "")
            {
                MessageBox.Show("Please enter Patient ID");
            }
            else
            {


                MySqlDataReader rd;
                MySqlConnection conn;
                string connetionString = null;
                connetionString = "server='" + serverName + "';database=ayurvedicsystem;uid='" + serveruser + "';pwd='" + serverPassword + "';";
                conn = new MySqlConnection(connetionString);
                String query;
                query = "select * from treatments where patient_id = '" + searchId + "' ";

                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);
                    rd = command.ExecuteReader();
                    while (rd.Read())
                    {
                        String seq_id = rd["seq_id"].ToString();
                        String patient_id = rd["patient_id"].ToString();
                        String doctor_id = rd["doctor_id"].ToString();
                        String treatment_type = rd["treatment_type"].ToString();
                        String other_treatment = rd["other_treatment"].ToString();
                        String description = rd["description"].ToString();
                        String mr_issue_date = rd["mr_issue_date"].ToString();
                        string[] row = { seq_id, patient_id, doctor_id, treatment_type, other_treatment, description, mr_issue_date};

                        dataGridView1.Rows.Add(row);
                    }



                }
                catch (Exception )
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtPatientID.Text = "";
        }
    }
        
    
}
