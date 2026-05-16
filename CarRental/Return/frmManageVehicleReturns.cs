using CarRental.Booking;
using CarRental.Customers;
using CarRental.Vehicles;
using CarRental_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Return
{
    public partial class frmManageVehicleReturns : Form
    {
        public frmManageVehicleReturns()
        {
            InitializeComponent();
        }


        DataTable dtVehicleReturns;

        private async void frmManageVehicleReturns_Load(object sender, EventArgs e)
        {
            dtVehicleReturns = await clsVehicleReturn.GetAllAsync();

            dgvVehcileReturns.DataSource = dtVehicleReturns;

            cbFilterBy.SelectedIndex = 0;

            lblRecordsCount.Text = dgvVehcileReturns.Rows.Count.ToString();

            if (dgvVehcileReturns.Rows.Count > 0)
            {

                dgvVehcileReturns.ColumnHeadersHeight = 38;

                dgvVehcileReturns.Columns[0].HeaderText =
                    "Return ID";
                dgvVehcileReturns.Columns[0].Width = 100;

                dgvVehcileReturns.Columns[1].HeaderText =
                    "Customer ID";
                dgvVehcileReturns.Columns[1].Width = 110;

                dgvVehcileReturns.Columns[2].HeaderText =
                    "Customer Name";
                dgvVehcileReturns.Columns[2].Width = 220;

                dgvVehcileReturns.Columns[3].HeaderText =
                    "Vehicle ID";
                dgvVehcileReturns.Columns[3].Width = 100;

                dgvVehcileReturns.Columns[4].HeaderText =
                    "Booking ID";
                dgvVehcileReturns.Columns[4].Width = 100;

                dgvVehcileReturns.Columns[5].HeaderText =
                    "Transaction ID";
                dgvVehcileReturns.Columns[5].Width = 120;

                dgvVehcileReturns.Columns[6].HeaderText =
                    "Return Date";
                dgvVehcileReturns.Columns[6].Width = 140;

                dgvVehcileReturns.Columns[7].HeaderText =
                    "Rental Days";
                dgvVehcileReturns.Columns[7].Width = 110;

                dgvVehcileReturns.Columns[8].HeaderText =
                    "Additional Charges";
                dgvVehcileReturns.Columns[8].Width = 150;

                dgvVehcileReturns.Columns[9].HeaderText =
                    "Total Due";
                dgvVehcileReturns.Columns[9].Width = 130;
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Return ID":
                    FilterColumn = "ReturnID";
                    break;

                case "Customer ID":
                    FilterColumn = "CustomerID";
                    break;

                case "Customer Name":
                    FilterColumn = "CustomerName";
                    break;

                case "Vehicle ID":
                    FilterColumn = "VehicleID";
                    break;

                case "Booking ID":
                    FilterColumn = "BookingID";
                    break;

                case "Transaction ID":
                    FilterColumn = "TransactionID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            // Reset Filter
            if (txtFilterValue.Text.Trim() == ""
                || FilterColumn == "None")
            {
                dtVehicleReturns.DefaultView.RowFilter = "";

                lblRecordsCount.Text =
                    dgvVehcileReturns.Rows.Count.ToString();

                return;
            }

            // Numeric Filters
            if (FilterColumn == "ReturnID"
                || FilterColumn == "CustomerID"
                || FilterColumn == "VehicleID"
                || FilterColumn == "BookingID"
                || FilterColumn == "TransactionID")
            {
                dtVehicleReturns.DefaultView.RowFilter =
                    string.Format(
                        "[{0}] = {1}",
                        FilterColumn,
                        txtFilterValue.Text.Trim());
            }
            else
            {
                dtVehicleReturns.DefaultView.RowFilter =
                    string.Format(
                        "[{0}] LIKE '{1}%'",
                        FilterColumn,
                        txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text =
                dgvVehcileReturns.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Return ID"
                   || cbFilterBy.Text == "Customer ID"
                   || cbFilterBy.Text == "Vehicle ID"
                   || cbFilterBy.Text == "Booking ID"
                   || cbFilterBy.Text == "Transaction ID"
               )
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btnVehicleReturn_Click(object sender, EventArgs e)
        {
            frmVehicleReturn frm = new frmVehicleReturn();
            frm.ShowDialog();

            frmManageVehicleReturns_Load(null, null);

        }

        private void showReturnDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ReturnID = (int)dgvVehcileReturns.CurrentRow.Cells[0].Value;

            frmShowReturnDetails frm = new frmShowReturnDetails(ReturnID);
            frm.Show();
        }

        private void showBookingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BookingID = (int)dgvVehcileReturns.CurrentRow.Cells[4].Value;
            frmShowBookingDetails frm = new frmShowBookingDetails(BookingID);

            frm.ShowDialog();
        }

        private void showCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CustomerID = (int)dgvVehcileReturns.CurrentRow.Cells[1].Value;
            frmShowCustomerDetails frm = new frmShowCustomerDetails(CustomerID);
            frm.ShowDialog();

        }

        private void showVehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int VehicleID = (int)dgvVehcileReturns.CurrentRow.Cells[3].Value;
            frmShowVehicleDetails frm = new frmShowVehicleDetails(VehicleID);
            frm.ShowDialog();
        }
    }
}
