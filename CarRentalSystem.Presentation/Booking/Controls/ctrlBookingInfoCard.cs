using CarRentalSystem.Business;
using CarRentalSystem.Presentation.Transactions;
using CarRentalSystem.Presentation.Vehicles;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Booking
{
    public partial class ctrlBookingInfoCard : UserControl
    {
        int _BookingID = -1;
        clsRentalBooking _RentalBooking;


        public int SelectedBookingID { get { return _BookingID; } }
        public clsRentalBooking SelectedBookingInfo { get { return _RentalBooking; } }
        public ctrlBookingInfoCard()
        {
            InitializeComponent();
        }



        public async Task LoadRentalBookingInfo(int BookingID)
        {
            _RentalBooking = await clsRentalBooking.FindByIDAsync(BookingID);

            if (_RentalBooking == null)
            {
                MessageBox.Show($"Rental Booking with ID {BookingID} NOT found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llShowTransactionInfo.Enabled = false;
                llbShowVehicleInfo.Enabled = false;

                return;

            }

            _FillRentalBookingInfo();
        }

        private void _FillRentalBookingInfo()
        {
            _BookingID = _RentalBooking.BookingID;

            lblBookingID.Text = _BookingID.ToString();

            lblCustomerName.Text = _RentalBooking.CustomerInfo?.PersonInfo?.FullName ?? "N/A";
            lblStartDate.Text = _RentalBooking.RentalStartDate.ToShortDateString();
            lblEndDate.Text = _RentalBooking.RentalEndDate.ToShortDateString();
            lblInitalRentalDays.Text = _RentalBooking.InitialRentalDays.ToString();
            lblInitalTotalDueAmount.Text = _RentalBooking.InitialTotalDueAmount.ToString("0.00");
            lblVehicleID.Text = _RentalBooking.VehicleID.ToString();
            lblPickupLocation.Text = _RentalBooking.PickupLocation;
            lblDropOfLocation.Text = _RentalBooking.DropOffLocation;
            lblInitalCheckNotes.Text = string.IsNullOrWhiteSpace(_RentalBooking.InitialCheckNotes) ? "No Notes" : _RentalBooking.InitialCheckNotes;


            llShowTransactionInfo.Enabled = true;
            llbShowVehicleInfo.Enabled = true;
        }

        private void llShowTransactionInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmTransactionDetails frm = new frmTransactionDetails(_BookingID, frmTransactionDetails.enFindBy.BookingID);
            frm.ShowDialog();

        }

        private void llbShowVehicleInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowVehicleDetails frm = new frmShowVehicleDetails(_RentalBooking.VehicleID);
            frm.ShowDialog();

        }
    }
}
