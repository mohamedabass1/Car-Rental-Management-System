using System;
using System.Windows.Forms;

namespace CarRental.Return
{
    public partial class frmVehicleReturn : Form
    {
        int _BookingID = -1;
        public frmVehicleReturn()
        {
            InitializeComponent();
        }

        public frmVehicleReturn(int BookingID)
        {
            InitializeComponent();
            _BookingID = BookingID;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void txtAdditionalCharges_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAdditionalCharges_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 

            if (string.IsNullOrEmpty(txtAdditionalCharges.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAdditionalCharges, "this felid is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtAdditionalCharges, null);
            }
        }


        private void txtMileage_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 

            if (string.IsNullOrEmpty(txtMileage.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMileage, "this felid is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtMileage, null);
            }
        }
    }
}
