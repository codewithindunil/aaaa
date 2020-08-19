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
using Org.BouncyCastle.Crypto.Tls;

namespace AyurvedicSystem.RegisterViews
{
    public partial class RegistrationDoctor : UserControl
    {
        String user,id;
        bool status;
        public RegistrationDoctor(String user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtInvoiceNo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationDoctor_Load(object sender, EventArgs e)
        {
             id = new Generalprocess().getLastEmpId();
            txtEmpId.Text = "D" + (int.Parse(id)+1).ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            

            String empId = txtEmpId.Text;
            String empName = txtRmpName.Text;
            String adr1 = txtAdressLine1.Text;
            String adr2 = txtAdressLine2.Text;
            String adr3 = txtAdressLine3.Text;
            String sex = comboBox1.SelectedItem.ToString();
            String regNo = "";
            String type = txtType.Text;
            String mobile = txtMobile.Text;
            String email = txtEmail.Text;
            String createdBy = user;

            if(empId=="" || empName==""|| adr1 =="" || adr2=="" || adr3=="" || sex =="" || regNo=="" || type=="" || mobile=="" || email == "")
            {
                MessageBox.Show("Please fill all the details");
            }
            else
            {
                 status=new Registrations().registerDoctor(empId, empName, adr1, adr2, adr3, sex, type, regNo, mobile, email, createdBy);
                if (status == true)
                {

                    txtEmpId.Text = "";
                    txtRmpName.Text = "";
                    txtAdressLine1.Text = "";
                    txtAdressLine2.Text = "";
                    txtAdressLine3.Text = "";
                    txtEmail.Text = "";
                    //txtRegNo.Text = "";
                    txtType.Text = "";
                    //txtSex.Text = "";
                    RegistrationDoctor_Load(sender,  e);
                }

            }
            



        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtEmpId.Text= "";
            txtRmpName.Text = "";
            txtAdressLine1.Text = "";
            txtAdressLine2.Text = "";
            txtAdressLine3.Text = "";
            txtEmail.Text = "";
            //txtRegNo.Text = "";
            txtType.Text = "";
            //txtSex.Text = "";
            
           
        }
    }
   }

