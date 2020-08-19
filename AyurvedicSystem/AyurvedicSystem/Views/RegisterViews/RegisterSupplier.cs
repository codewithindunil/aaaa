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
    public partial class RegisterSupplier : UserControl
    {
        String user,max;
        bool status;
        public RegisterSupplier(String user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            String supId = txtSpId.Text;
            String supName = txtSupName.Text;
            String adr1 = txtAdressLine1.Text;
            String adr2 = txtAdressLine2.Text;
            String adr3 = txtAdressLine3.Text;
       
            String contatc_perosn = txtType.Text;
            String mobile = txtMobile.Text;
            String email = txtEmail.Text;
            String createdBy = user;

            if (supId == "" || supName == "" || adr1 == "" || adr2 == "" || adr3 == "" || contatc_perosn == "" || mobile == "" || email == "")
            { 
                MessageBox.Show("Please fill all the details");
            }
            else
            {
                status = new Registrations().registerSupplier(supId, supName, adr1, adr2, adr3,  contatc_perosn,  mobile, email, createdBy);
                if (status == true)
                {

                    txtSpId.Text = "";
                    txtSupName.Text = "";
                    txtAdressLine1.Text = "";
                    txtAdressLine2.Text = "";
                    txtAdressLine3.Text = "";
                    txtEmail.Text = "";
                    txtMobile.Text = "";
                    txtType.Text = "";

                    RegisterSupplier_Load(sender, e);
                }

            }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtSpId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtSupName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtAdressLine1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtAdressLine2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtAdressLine3_OnValueChanged(object sender, EventArgs e)
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

        private void txtMobile_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtType_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSpId.Text = "";
            txtSupName.Text = "";
            txtAdressLine1.Text = "";
            txtAdressLine2.Text = "";
            txtAdressLine3.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtType.Text = "";
        }

        private void RegisterSupplier_Load(object sender, EventArgs e)
        {
            max = new Generalprocess().getNextSupplierNo();
            txtSpId.Text = "SUP" + (int.Parse(max) + 1).ToString();
        }
    }
}
