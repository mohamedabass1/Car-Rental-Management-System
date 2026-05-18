using CarRental_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Customers
{
    public partial class frmCustomerTransactionsHistory : Form
    {
        int _CustomerID = -1;
        public frmCustomerTransactionsHistory(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }

        DataTable dtTransactionsHistory;
        private async void frmCustomerTransactionsHistory_Load(object sender, EventArgs e)
        {
            await ctrlCustomerInfoCard1.LoadCustomerInfo(_CustomerID);

            dtTransactionsHistory = await clsRentalTransaction.GetCustomerTransactionsHistoryAsync(_CustomerID);

            dgvTransactionsHistory.DataSource = dtTransactionsHistory;
            lblRecordsCount.Text = dgvTransactionsHistory.Rows.Count.ToString();

            if (dgvTransactionsHistory.Rows.Count > 0)
            {
                dgvTransactionsHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvTransactionsHistory.Columns[0].HeaderText = "Transaction ID";
                dgvTransactionsHistory.Columns[0].FillWeight = 110;

                dgvTransactionsHistory.Columns[1].HeaderText = "Booking ID";
                dgvTransactionsHistory.Columns[1].FillWeight = 90;

                dgvTransactionsHistory.Columns[2].HeaderText = "Vehicle ID";
                dgvTransactionsHistory.Columns[2].FillWeight = 90;

                dgvTransactionsHistory.Columns[3].HeaderText = "Return ID";
                dgvTransactionsHistory.Columns[3].FillWeight = 80;

                dgvTransactionsHistory.Columns[4].HeaderText = "Actual Total";
                dgvTransactionsHistory.Columns[4].FillWeight = 110;

                dgvTransactionsHistory.Columns[5].HeaderText = "Remaining";
                dgvTransactionsHistory.Columns[5].FillWeight = 90;

                dgvTransactionsHistory.Columns[6].HeaderText = "Refunded";
                dgvTransactionsHistory.Columns[6].FillWeight = 90;

                dgvTransactionsHistory.Columns[7].HeaderText = "Transaction Date";
                dgvTransactionsHistory.Columns[7].FillWeight = 130;

                dgvTransactionsHistory.Columns[8].HeaderText = "Updated Date";
                dgvTransactionsHistory.Columns[8].FillWeight = 130;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
