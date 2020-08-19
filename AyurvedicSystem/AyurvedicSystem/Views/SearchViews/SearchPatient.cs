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

namespace AyurvedicSystem.SearchViews
{
    public partial class SearchPatient : UserControl
    {
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            String searchId = txtSearchId.Text;
            if (searchId == "")
            {
                MessageBox.Show("Please enter ID");
            }
            else
            {
                List<String> patient = new Search().searchPatientDetails(searchId);
                if (patient.Count > 0)
                {
                    txtPatientId.Text = patient[0];
                    txtPatientName.Text = patient[1];
                    txtAdressLine1.Text = patient[2];
                    txtAdressLine2.Text = patient[3];
                    txtAdressLine3.Text = patient[4];
                    txtAge.Text = patient[5];
                    txtSex.Text = patient[6];
                    txtMobile.Text = patient[7];

                    txtEmail.Text = patient[8];
                }
               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientId.Text = "";
            txtPatientName.Text = "";
            txtAdressLine1.Text = "";
            txtAdressLine2.Text = "";
            txtAdressLine3.Text = "";
            txtAge.Text = "";
            txtSex.Text = "";
            txtMobile.Text = "";

            txtEmail.Text = "";
        }
    }
}
