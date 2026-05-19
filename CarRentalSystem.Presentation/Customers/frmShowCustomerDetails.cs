using System;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Customers
{
    public partial class frmShowCustomerDetails : Form
    {
        int _CustomerID = -1;
        public frmShowCustomerDetails(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }

        private async void frmShowCustomerDetails_Load(object sender, EventArgs e)
        {
            await ctrlCustomerInfoCard1.LoadCustomerInfo(_CustomerID);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
