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
    public partial class SearchItems : UserControl
    {
        public SearchItems()
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
                List<String> item = new Search().searchItemDetails(searchId);
                if (item.Count > 0)
                {
                    txtItemID.Text = item[0];
                    txtItemName.Text = item[1];
                    //xtItemCode.Text = item[2];
                    txtUom.Text = item[3];
                    txtYear.Text = item[4];
                    txtMonth.Text = item[5];
                    txtDate.Text = item[6];
                    txtSuplierId.Text = item[7];
                    
                }

            }
        }

        private void SearchItems_Load(object sender, EventArgs e)
        {

        }
    }
}
