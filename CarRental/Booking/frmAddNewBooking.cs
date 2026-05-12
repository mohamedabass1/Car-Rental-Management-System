using CarRental.Transactions;
using CarRental_Buisness;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarRental.Booking
{
    public partial class frmAddNewBooking : Form
    {
        clsRentalBooking _Booking;

        int _TransactionID = -1;
        clsRentalTransaction _Transaction;

        clsVehicle _SelectedVehicle;
        clsCustomer _SelectedCustomer;
        public frmAddNewBooking()
        {
            InitializeComponent();
        }

        private void frmAddNewBooking_Load(object sender, System.EventArgs e)
        {
            ctrlCustomerInfoCardWithFilter1.FilterFoucs();
            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
            lblInitalRentalDays.Text = "1";


        }
        private void _CalculateTotalAmount()
        {
            if (_SelectedVehicle == null)
                return;

            int rentalDays = (dtpEndDate.Value.Date - dtpStartDate.Value.Date).Days;

            lblInitalRentalDays.Text = rentalDays.ToString();

            decimal totalAmount = rentalDays * _SelectedVehicle.RentalPricePerDay;

            lblInitalTotalDueAmount.Text = totalAmount.ToString();
        }
        private void ctrlVehicleInfoCardWithFilter1_OnVehicleSelected(int vehicleID)
        {
            lblVehicleID.Text = vehicleID.ToString();

            if (ctrlVehicleInfoCardWithFilter1.SelectedVehicleInfo == null)
            {
                btnBooking.Enabled = false;
                return;
            }


            if (!ctrlVehicleInfoCardWithFilter1.SelectedVehicleInfo.IsAvailableForRent)
            {
                MessageBox.Show("This car is NOT available for rent now!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBooking.Enabled = false;
                return;
            }

            _SelectedVehicle = ctrlVehicleInfoCardWithFilter1.SelectedVehicleInfo;

            lblVehicleID.Text = vehicleID.ToString();
            lblRntalPricePerDay.Text = _SelectedVehicle.RentalPricePerDay.ToString();

            _CalculateTotalAmount();

            btnBooking.Enabled = true;

        }

        private void guna2TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (guna2TabControl1.SelectedTab == tbVehicleInfo)
                if (ctrlCustomerInfoCardWithFilter1.SelectedCustomerInfo == null)
                {
                    MessageBox.Show("Please Select Customer First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    guna2TabControl1.SelectTab("tbCustomerInfo");
                    return;
                }

            ctrlVehicleInfoCardWithFilter1.FilterFocus();
        }

        private void ctrlCustomerInfoCardWithFilter1_OnCustomerSelected(int customerID)
        {
            if (ctrlCustomerInfoCardWithFilter1.SelectedCustomerInfo == null)
                return;


            lblCustomerID.Text = customerID.ToString();
            _SelectedCustomer = ctrlCustomerInfoCardWithFilter1.SelectedCustomerInfo;
        }
        private async void btnBooking_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue because the form is not valid
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (MessageBox.Show("Are you sure you want to Rent this Vehicle?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            _Booking = new clsRentalBooking();

            _Booking.CustomerID = _SelectedCustomer.CustomerID;
            _Booking.VehicleID = _SelectedVehicle.VehicleID;

            _Booking.RentalStartDate = dtpStartDate.Value;
            _Booking.RentalEndDate = dtpEndDate.Value;

            _Booking.PickupLocation = txtPickupLocation.Text;
            _Booking.DropOffLocation = txtDropOfLocation.Text;
            _Booking.InitialRentalDays = byte.Parse(lblInitalRentalDays.Text);
            _Booking.RentalPricePerDay = decimal.Parse(lblRntalPricePerDay.Text);
            _Booking.InitialTotalDueAmount = decimal.Parse(lblInitalTotalDueAmount.Text);
            _Booking.InitialCheckNotes = string.IsNullOrEmpty(txtInitalCheckNotes.Text) ? "" : txtInitalCheckNotes.Text;

            if (!await _Booking.SaveAsync())
            {
                MessageBox.Show("Failed to complete operation!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!await _SelectedVehicle.SetUnavailable())
            {
                await clsRentalBooking.DeleteAsync(_Booking.BookingID);
                MessageBox.Show("Failed to complete operation!", "Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _Transaction = new clsRentalTransaction();
            _Transaction.BookingID = _Booking.BookingID;
            _Transaction.PaymentDetails = txtPaymentDetails.Text;
            _Transaction.PaidInitialTotalDueAmount = _Booking.InitialTotalDueAmount;
            _Transaction.TransactionDate = DateTime.Now;

            if (await _Transaction.SaveAsync())
            {
                _TransactionID = _Transaction.TransactionID;
                llShowTransactionInfo.Enabled = true;
                MessageBox.Show("Vehicle rented successfully with transaction ID=" + _TransactionID.ToString(),
                    "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblBookingID.Text = _Booking.BookingID.ToString();
            }
            else
            {
                await clsRentalBooking.DeleteAsync(_Booking.BookingID);
                await _SelectedVehicle.SetAvailable();
                MessageBox.Show("Failed to complete operation!", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnBooking.Enabled = false;
            ctrlCustomerInfoCardWithFilter1.FilterEnabled = false;
            ctrlVehicleInfoCardWithFilter1.FilterEnabled = false;

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);

            _CalculateTotalAmount();

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            _CalculateTotalAmount();
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            Guna2TextBox Temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtPickupLocation_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowTransactionInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTransactionDetails frm = new frmTransactionDetails(_TransactionID);
            frm.ShowDialog();
        }
    }
}
