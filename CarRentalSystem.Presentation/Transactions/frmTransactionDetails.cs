using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Transactions
{
    public partial class frmTransactionDetails : Form
    {
        int _ID = -1;
        public enum enFindBy { TransactionID = 0, BookingID = 1, ReturnID = 2 };
        enFindBy FindBy = enFindBy.TransactionID;
        public frmTransactionDetails(int ID, enFindBy findBy)
        {
            InitializeComponent();
            _ID = ID;

            FindBy = findBy;
        }


        private async void frmTransactionDetails_Load(object sender, System.EventArgs e)
        {
            if (FindBy == enFindBy.TransactionID)
            {
                await ctrlTransactionInfoCard1.LoadTransactionInfo(_ID);
            }
            else if (FindBy == enFindBy.BookingID)
            {
                await ctrlTransactionInfoCard1.LoadTransactionInfoByBookingID(_ID);
            }
            else
                await ctrlTransactionInfoCard1.LoadTransactionInfoByReturnID(_ID);


        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
