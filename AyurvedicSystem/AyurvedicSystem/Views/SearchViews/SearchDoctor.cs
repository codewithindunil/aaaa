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
    public partial class SearchDoctor : UserControl
    {
        public SearchDoctor()
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
                List<String> doctor = new Search().searchDoctorDetails(searchId);
                if (doctor.Count > 0)
                {
                    txtEmpId.Text = doctor[0];
                    txtRmpName.Text = doctor[1];
                    txtAdressLine1.Text = doctor[2];
                    txtAdressLine2.Text = doctor[3];
                    txtAdressLine3.Text = doctor[4];
                    txtSex.Text = doctor[5];
                    txtType.Text = doctor[6];
                  //  txtRegNo.Text = doctor[7];
                    txtMobile.Text = doctor[8];

                    txtEmail.Text = doctor[9];
                }
              
            }
      
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpId.Text = "";
            txtRmpName.Text = "";
            txtAdressLine1.Text = "";
            txtAdressLine2.Text = "";
            txtAdressLine3.Text ="";
            txtSex.Text = "";
            txtType.Text = "";
            //txtRegNo.Text = "";
            txtMobile.Text = "";

            txtEmail.Text = "";
        }
    }
}
