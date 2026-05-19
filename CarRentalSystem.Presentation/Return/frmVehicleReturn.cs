using CarRentalSystem.Business;
using CarRentalSystem.Business.Services;
using CarRentalSystem.Presentation.Transactions;
using System;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Return
{
    public partial class frmVehicleReturn : Form
    {
        int _BookingID = -1;
        clsRentalBooking _SelectedRentalBooking;

        int _ReturnID;
        public frmVehicleReturn()
        {
            InitializeComponent();
        }

        public frmVehicleReturn(int BookingID)
        {
            InitializeComponent();
            _BookingID = BookingID;
        }



        private async void btnReturn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue because the form is not valid
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            decimal AdditionalCharges = Convert.ToDecimal(txtAdditionalCharges.Text.Trim());
            short CurrentMileage = Convert.ToInt16(txtMileage.Text.Trim());
            string FinalCheckNotes = string.IsNullOrWhiteSpace(txtFinalCheckNotes.Text) ? "" : txtFinalCheckNotes.Text.Trim();
            DateTime ActualReturnDate = dtpActualReturnDate.Value;


            var VehicleReturn = await clsRentalReturnService.CompleteRentalReturnAsync(_SelectedRentalBooking, ActualReturnDate,
                CurrentMileage, FinalCheckNotes, AdditionalCharges);

            if (VehicleReturn == null)
            {
                MessageBox.Show($"Vehicle Returned Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            _ReturnID = VehicleReturn.ReturnID;

            lblReturnID.Text = _ReturnID.ToString();
            lblActualRentalDays.Text = VehicleReturn.ActualRentalDays.ToString();
            lblConsumedMileage.Text = VehicleReturn.ConsumedMileage.ToString();
            lblActualTotalDueAmount.Text = VehicleReturn.ActualTotalDueAmount.ToString();


            MessageBox.Show($"Vehicle Returned Successfully With Return ID: {_ReturnID} ", "Succeeded",
                MessageBoxButtons.OK, MessageBoxIcon.Information);



            llShowReturnDetails.Enabled = true;
            llShowUpdatedTransactionInfo.Enabled = true;
            btnReturn.Enabled = false;
            ctrlBookingInfoCardWithFilter1.FilterEnabled = false;

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

            if (_SelectedRentalBooking == null)
                return;
            int OldVehicleMileage = _SelectedRentalBooking.VehicleInfo.Mileage;

            int InputMileage = 0;

            int.TryParse(txtMileage.Text.Trim(), out InputMileage);

            if (InputMileage < OldVehicleMileage)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMileage, $"Enter Valid Mileage the vehicle mileage before rent is {OldVehicleMileage}!");
            }
            else
                errorProvider1.SetError(txtMileage, null);


        }

        private async void ctrlBookingInfoCardWithFilter1_OnBookingSelected(int bookingID)
        {
            if (ctrlBookingInfoCardWithFilter1.SelectedBookingInfo == null)
            {
                btnReturn.Enabled = false;
                llShowReturnDetails.Enabled = false;
                llShowUpdatedTransactionInfo.Enabled = false;
                lblActualRentalDays.Text = "[???]";
                return;
            }

            bool isBookingReturned = await clsRentalTransaction.IsBookingReturnedAsync(ctrlBookingInfoCardWithFilter1.SelectedBookingID);
            if (isBookingReturned)
            {
                MessageBox.Show($"This booking has finished and the vehicle already returned",
                    "Not Allow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReturn.Enabled = false;
                return;
            }



            _BookingID = bookingID;
            _SelectedRentalBooking = ctrlBookingInfoCardWithFilter1.SelectedBookingInfo;
            lblActualRentalDays.Text = ((dtpActualReturnDate.Value - _SelectedRentalBooking.RentalStartDate).Days + 1).ToString();

            btnReturn.Enabled = true;

        }

        private async void frmVehicleReturn_Load(object sender, EventArgs e)
        {

            if (_BookingID != -1)
            {
                await ctrlBookingInfoCardWithFilter1.LoadRentalBookingInfo(_BookingID);
                ctrlBookingInfoCardWithFilter1.FilterEnabled = false;
            }
            dtpActualReturnDate.MinDate = DateTime.Now;

        }

        private void llShowUpdatedTransactionInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTransactionDetails frm = new frmTransactionDetails(_BookingID, frmTransactionDetails.enFindBy.BookingID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowReturnDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowReturnDetails frm = new frmShowReturnDetails(_ReturnID);
            frm.ShowDialog();
        }
    }
}
