using CarRentalSystem.Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Customers
{
    public partial class frmCustomerBookingHistory : Form
    {
        int _CustomerID = -1;
        public frmCustomerBookingHistory(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }

        DataTable dtCustomerBookingHistory;
        private async void frmCustomerBookingHistory_Load(object sender, EventArgs e)
        {
            await ctrlCustomerInfoCard1.LoadCustomerInfo(_CustomerID);


            dtCustomerBookingHistory = await clsRentalBooking.GetCustomerHistoryAsync(_CustomerID);
            dgvBookingHistory.DataSource = dtCustomerBookingHistory;

            lblRecordsCount.Text = dgvBookingHistory.Rows.Count.ToString();

            if (dgvBookingHistory.Rows.Count > 0)
            {

                dgvBookingHistory.Columns[0].HeaderText = "ID";
                dgvBookingHistory.Columns[0].FillWeight = 40;


                dgvBookingHistory.Columns[1].HeaderText = "Vehicle ID";
                dgvBookingHistory.Columns[1].FillWeight = 60;


                dgvBookingHistory.Columns[2].HeaderText = "Start Date";
                dgvBookingHistory.Columns[2].FillWeight = 90;

                dgvBookingHistory.Columns[3].HeaderText = "End Date";
                dgvBookingHistory.Columns[3].FillWeight = 90;

                dgvBookingHistory.Columns[4].HeaderText = "Pickup";
                dgvBookingHistory.Columns[4].FillWeight = 100;

                dgvBookingHistory.Columns[5].HeaderText = "Dropoff";
                dgvBookingHistory.Columns[5].FillWeight = 100;

                dgvBookingHistory.Columns[6].HeaderText = "Rental Days";
                dgvBookingHistory.Columns[6].FillWeight = 50;

                dgvBookingHistory.Columns[7].HeaderText = "Price / Day";
                dgvBookingHistory.Columns[7].FillWeight = 80;

                dgvBookingHistory.Columns[8].HeaderText = "Total Amount";
                dgvBookingHistory.Columns[8].FillWeight = 100;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
