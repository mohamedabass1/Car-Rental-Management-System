using System.Windows.Forms;

namespace CarRental.Transactions
{
    public partial class frmTransactionDetails : Form
    {
        int _TransactionID = -1;
        public frmTransactionDetails(int TransactionID)
        {
            InitializeComponent();

            _TransactionID = TransactionID;
        }

        private async void frmTransactionDetails_Load(object sender, System.EventArgs e)
        {
            await ctrlTransactionInfoCard1.LoadTransactionInfo(_TransactionID);
        }

        private void guna2Button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
