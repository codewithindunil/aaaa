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
    public partial class SearchSupplier : UserControl
    {
        public SearchSupplier()
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
                List<String> patient = new Search().searchSuplieretails(searchId);
                if (patient.Count > 0)
                {
                    txtSpId.Text = patient[0];
                    txtSupName.Text = patient[1];
                    txtAdressLine1.Text = patient[2];
                    txtAdressLine2.Text = patient[3];
                    txtAdressLine3.Text = patient[4];
                    txtMobile.Text = patient[5];
                    txtContactPerson.Text = patient[6];
                    txtEmail.Text = patient[7];

                }

            }
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
            txtSupName.Text = "";
        }
    }
}
