using CarRental_Buisness;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Transactions.Controls
{
    public partial class ctrlTransactionInfoCard : UserControl
    {
        public ctrlTransactionInfoCard()
        {
            InitializeComponent();
        }

        private int _TransactionID = -1;
        private clsRentalTransaction _Transaction;


        public int SelectedTransactionID
        {
            get { return _TransactionID; }
        }
        public clsRentalTransaction SelectedTransaction
        {
            get { return _Transaction; }
        }


        public async Task LoadTransactionInfo(int TransactionID)
        {
            _Transaction = await clsRentalTransaction.FindByIDAsync(TransactionID);

            if (_Transaction == null)
            {
                MessageBox.Show("No Transaction with TransactionID = " + TransactionID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillTransactionInfo();
        }

        public async Task LoadTransactionInfoByBookingID(int BookingID)
        {
            _Transaction = await clsRentalTransaction.FindByBookingIDAsync(BookingID);

            if (_Transaction == null)
            {
                MessageBox.Show("No Transaction with Booking ID = " + BookingID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillTransactionInfo();
        }

        public async Task LoadTransactionInfoByReturnID(int ReturnID)
        {
            _Transaction = await clsRentalTransaction.FindByReturnIDAsync(ReturnID);

            if (_Transaction == null)
            {
                MessageBox.Show("No Transaction with Return ID = " + ReturnID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillTransactionInfo();
        }


        private void _FillTransactionInfo()
        {
            _TransactionID = _Transaction.TransactionID;
            lblTransactionID.Text = _TransactionID.ToString();
            lblBookingID.Text = _Transaction.BookingID.ToString();

            lblCustomerName.Text = _Transaction.BookingInfo?.CustomerInfo?.PersonInfo?.FullName ?? "N/A";

            lblReturnID.Text = _Transaction.ReturnID?.ToString() ?? "Not Returned Yet";
            lblPaymentDetails.Text = _Transaction.PaymentDetails;
            lblTransactionDate.Text = _Transaction.TransactionDate.ToShortDateString();
            lblInitalTotalDueAmount.Text = _Transaction.PaidInitialTotalDueAmount.ToString();

            lblActualTotalDueAmount.Text = _Transaction.ActualTotalDueAmount?.ToString("0.00") ?? "N/A";
            lblTotalRemaining.Text = _Transaction.TotalRemaining?.ToString("0.00") ?? "N/A";
            lblTotalRefundedAmount.Text = _Transaction.TotalRefundedAmount?.ToString("0.00") ?? "N/A";
            lblUpdatedTransactionDate.Text = _Transaction.UpdatedTransactionDate?.ToShortDateString() ?? "N/A";
        }
    }
}
