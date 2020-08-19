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

namespace AyurvedicSystem.RegisterViews
{
    public partial class RegisterPatient : UserControl
    {
        String max,user;
        bool status;
        public RegisterPatient(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            String patientId = txtPatientId.Text;
            String patientName = txtPatientName.Text;
            String adr1 = txtAdressLine1.Text;
            String adr2 = txtAdressLine2.Text;
            String adr3 = txtAdressLine3.Text;
            String sex = comboBox1.SelectedItem.ToString();
            String age = txtAge.Text;
            String type = txtType.Text;
            String mobile = txtMobile.Text;
            String email = txtEmail.Text;
            String createdBy = user;

            if (patientId == "" || patientId == "" || adr1 == "" || adr2 == "" || adr3 == "" || sex == "" || age == "" || type == "" || mobile == "" || email == "")
            {
                MessageBox.Show("Please fill all the details");
            }
            else
            {
                status = new Registrations().registerPatient(patientId, patientName, adr1, adr2, adr3, sex, type, age, mobile, email, createdBy);
                if (status == true)
                {

                    txtPatientId.Text = "";
                    txtPatientName.Text = "";
                    txtAdressLine1.Text = "";
                    txtAdressLine2.Text = "";
                    txtAdressLine3.Text = "";
                    txtEmail.Text = "";
                    txtAge.Text = "";
                    txtMobile.Text = "";
                    txtType.Text = "";

                    //txtSex.Text = "";
                    RegisterPatient_Load(sender, e);
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
            txtEmail.Text = "";
            txtAge.Text = "";
            txtType.Text = "";
            txtMobile.Text = "";
            //txtSex.Text = "";
        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtAdressLine3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAdressLine2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAdressLine1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPatientName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPatientId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtType_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMobile_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSex_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPatient_Load(object sender, EventArgs e)
        {
            max = new Generalprocess().getNextPatientNo();
            txtPatientId.Text = "P" + (int.Parse(max) + 1).ToString();
        }
    }
}
