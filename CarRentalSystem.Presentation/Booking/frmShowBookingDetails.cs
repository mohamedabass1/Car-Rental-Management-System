using CarRentalSystem.Business;
using System;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Booking
{
    public partial class frmShowBookingDetails : Form
    {
        int _BookingID = -1;
        public frmShowBookingDetails(int BookingID)
        {
            InitializeComponent();
            _BookingID = BookingID;
        }


        private async void frmShowBookingDetails_Load(object sender, EventArgs e)
        {
            clsRentalBooking booking = await clsRentalBooking.FindByIDAsync(_BookingID);

            if (booking == null)
            {
                MessageBox.Show($"Rental Booking with ID {_BookingID} NOT found!",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            await ctrlBookingInfoCard1.LoadRentalBookingInfo(_BookingID);
            await ctrlCustomerInfoCard1.LoadCustomerInfo(booking.CustomerID);
            await ctrlVehicleInfoCard1.LoadVehicleInfo(booking.VehicleID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
