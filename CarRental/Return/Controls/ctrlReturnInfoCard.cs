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
        public clsVehicleReturn SelectedVehicleReturn;

        clsRentalTransaction _TransactionInfo;
        public ctrlReturnInfoCard()
        {
            InitializeComponent();
        }

        public async Task LoadVehicleReturnInfo(int ReturnID)
        {
            SelectedVehicleReturn = await clsVehicleReturn.FindByIDAsync(ReturnID);

            if (SelectedVehicleReturn == null)
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
            _ReturnID = SelectedVehicleReturn.ReturnID;
            lblReturnID.Text = _ReturnID.ToString();
            lblSActualReturnDate.Text = SelectedVehicleReturn.ActualReturnDate.ToShortDateString();
            lblActualRentalDays.Text = SelectedVehicleReturn.ActualRentalDays.ToString();
            lblMileage.Text = SelectedVehicleReturn.Mileage.ToString();
            lblConsumedMileage.Text = SelectedVehicleReturn.ConsumedMileage.ToString();
            lblFinalCheckNotes.Text = string.IsNullOrWhiteSpace(SelectedVehicleReturn.FinalCheckNotes) ? "N/A" : SelectedVehicleReturn.FinalCheckNotes;
            lblAdditionalCharges.Text = SelectedVehicleReturn.AdditionalCharges.ToString("0.00");
            lblActualTotalDueAmount.Text = SelectedVehicleReturn.ActualTotalDueAmount.ToString("0.00");


            // Load TransactionInfo
            _TransactionInfo = await clsRentalTransaction.FindByReturnIDAsync(_ReturnID);


            llbShowBookingInfo.Enabled = _TransactionInfo != null;
            llShowTransactionInfo.Enabled = _TransactionInfo != null;

        }

        private void llShowTransactionInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTransactionDetails frm = new frmTransactionDetails(SelectedVehicleReturn.ReturnID, frmTransactionDetails.enFindBy.ReturnID);
            frm.ShowDialog();
        }

        private void llbShowBookingInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowBookingDetails frm = new frmShowBookingDetails(_TransactionInfo.BookingInfo.BookingID);
            frm.ShowDialog();
        }
    }
}
