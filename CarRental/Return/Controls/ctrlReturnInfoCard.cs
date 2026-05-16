using CarRental.Booking;
using CarRental.Transactions;
using CarRental_Buisness;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Return.Controls
{
    public partial class ctrlReturnInfoCard : UserControl
    {
        int _ReturnID = -1;
        clsVehicleReturn _VehicleReturn;

        clsRentalTransaction _TransactionInfo;
        public ctrlReturnInfoCard()
        {
            InitializeComponent();
        }

        public async Task LoadVehicleReturnInfo(int ReturnID)
        {
            _VehicleReturn = await clsVehicleReturn.FindByIDAsync(ReturnID);

            if (_VehicleReturn == null)
            {
                MessageBox.Show($"Vehicle Return with ID {ReturnID} NOT found!",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                llShowTransactionInfo.Enabled = false;
                llbShowBookingInfo.Enabled = false;
                return;
            }

            await _FillVehicleReturnInfo();

        }

        private async Task _FillVehicleReturnInfo()
        {
            _ReturnID = _VehicleReturn.ReturnID;
            lblReturnID.Text = _ReturnID.ToString();
            lblSActualReturnDate.Text = _VehicleReturn.ActualReturnDate.ToShortDateString();
            lblActualRentalDays.Text = _VehicleReturn.ActualRentalDays.ToString();
            lblMileage.Text = _VehicleReturn.Mileage.ToString();
            lblConsumedMileage.Text = _VehicleReturn.ConsumedMileage.ToString();
            lblFinalCheckNotes.Text = string.IsNullOrWhiteSpace(_VehicleReturn.FinalCheckNotes) ? "N/A" : _VehicleReturn.FinalCheckNotes;
            lblAdditionalCharges.Text = _VehicleReturn.AdditionalCharges.ToString("0.00");
            lblActualTotalDueAmount.Text = _VehicleReturn.ActualTotalDueAmount.ToString("0.00");


            // Load TransactionInfo
            _TransactionInfo = await clsRentalTransaction.FindByReturnIDAsync(_ReturnID);


            llbShowBookingInfo.Enabled = _TransactionInfo != null;
            llShowTransactionInfo.Enabled = _TransactionInfo != null;

        }

        private void llShowTransactionInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTransactionDetails frm = new frmTransactionDetails(_VehicleReturn.ReturnID, frmTransactionDetails.enFindBy.ReturnID);
            frm.ShowDialog();
        }

        private void llbShowBookingInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowBookingDetails frm = new frmShowBookingDetails(_TransactionInfo.BookingInfo.BookingID);
            frm.ShowDialog();
        }
    }
}
