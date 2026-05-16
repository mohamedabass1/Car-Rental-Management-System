using CarRental.Booking;
using CarRental.Customers;
using CarRental.Vehicles;
using CarRental_Buisness;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental.Transactions
{
    public partial class frmTransactionsList : Form
    {
        public frmTransactionsList()
        {
            InitializeComponent();
        }

        DataTable dtTransactions;
        private async void frmTransactionsList_Load(object sender, EventArgs e)
        {
            dtTransactions = await clsRentalTransaction.GetAllAsync();

            dgvTransactionsList.DataSource = dtTransactions;
            // ConfigureDataGridView();
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dtTransactions.Rows.Count.ToString();


            if (dgvTransactionsList.Rows.Count > 0)
            {
                dgvTransactionsList.Columns[0].HeaderText = "Transaction ID";
                dgvTransactionsList.Columns[0].Width = 130;

                dgvTransactionsList.Columns[1].HeaderText = "Customer ID";
                dgvTransactionsList.Columns[1].Width = 120;

                dgvTransactionsList.Columns[2].HeaderText = "Customer Name";
                dgvTransactionsList.Columns[2].Width = 220;

                dgvTransactionsList.Columns[3].HeaderText = "Booking ID";
                dgvTransactionsList.Columns[3].Width = 110;

                dgvTransactionsList.Columns[4].HeaderText = "Return ID";
                dgvTransactionsList.Columns[4].Width = 100;

                dgvTransactionsList.Columns[5].HeaderText = "Actual Total";
                dgvTransactionsList.Columns[5].Width = 130;

                dgvTransactionsList.Columns[6].HeaderText = "Remaining";
                dgvTransactionsList.Columns[6].Width = 120;

                dgvTransactionsList.Columns[7].HeaderText = "Refunded";
                dgvTransactionsList.Columns[7].Width = 120;

                dgvTransactionsList.Columns[8].HeaderText = "Transaction Date";
                dgvTransactionsList.Columns[8].Width = 150;

                dgvTransactionsList.Columns[9].HeaderText = "Updated Date";
                dgvTransactionsList.Columns[9].Width = 150;

            }



        }

        private void ConfigureDataGridView()
        {
            // Visual polish
            dgvTransactionsList.EnableHeadersVisualStyles = false;
            dgvTransactionsList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255); // DodgerBlue-like
            dgvTransactionsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTransactionsList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dgvTransactionsList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTransactionsList.RowTemplate.Height = 28;
            dgvTransactionsList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvTransactionsList.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            dgvTransactionsList.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 229, 255);
            dgvTransactionsList.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Behavior and readability
            dgvTransactionsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactionsList.MultiSelect = false;
            dgvTransactionsList.ReadOnly = true;
            dgvTransactionsList.AllowUserToAddRows = false;
            dgvTransactionsList.AllowUserToResizeRows = false;
            dgvTransactionsList.RowHeadersVisible = false;
            dgvTransactionsList.BorderStyle = BorderStyle.None;
            dgvTransactionsList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTransactionsList.GridColor = Color.LightGray;

            // Prevent user from reordering columns (keeps consistent layout)
            dgvTransactionsList.AllowUserToOrderColumns = false;

            // Improve initial column sizing behavior (widths are set later)
            dgvTransactionsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }




        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Transaction ID":
                    FilterColumn = "TransactionID";
                    break;

                case "Customer ID":
                    FilterColumn = "CustomerID";
                    break;

                case "Customer Name":
                    FilterColumn = "CustomerName";
                    break;

                case "Booking ID":
                    FilterColumn = "BookingID";
                    break;

                case "Return ID":
                    FilterColumn = "ReturnID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            // Reset Filter
            if (txtFilterValue.Text.Trim() == ""
                || FilterColumn == "None")
            {
                dtTransactions.DefaultView.RowFilter = "";

                lblRecordsCount.Text =
                    dgvTransactionsList.Rows.Count.ToString();

                return;
            }

            // Integer Filters
            if (FilterColumn == "TransactionID"
                || FilterColumn == "CustomerID"
                || FilterColumn == "BookingID"
                || FilterColumn == "ReturnID")
            {
                dtTransactions.DefaultView.RowFilter =
                    string.Format(
                        "[{0}] = {1}",
                        FilterColumn,
                        txtFilterValue.Text.Trim());
            }
            else
            {
                dtTransactions.DefaultView.RowFilter =
                    string.Format(
                        "[{0}] LIKE '{1}%'",
                        FilterColumn,
                        txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvTransactionsList.Rows.Count.ToString();
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
            if (cbFilterBy.Text == "Transaction ID"
      || cbFilterBy.Text == "Customer ID"
      || cbFilterBy.Text == "Booking ID"
      || cbFilterBy.Text == "Return ID")
            {
                e.Handled =
                    !char.IsDigit(e.KeyChar)
                    && !char.IsControl(e.KeyChar);
            }
        }

        private void showBookingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int bookingID = (int)dgvTransactionsList.CurrentRow.Cells[3].Value;

            frmShowBookingDetails frm = new frmShowBookingDetails(bookingID);
            frm.ShowDialog();
        }

        private void showCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int CustomerID = (int)dgvTransactionsList.CurrentRow.Cells[1].Value;

            Form frm = new frmShowCustomerDetails(CustomerID);
            frm.ShowDialog();
        }

        private void showTransactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int TransactionID = (int)dgvTransactionsList.CurrentRow.Cells[0].Value;

            Form frm = new frmTransactionDetails(TransactionID, frmTransactionDetails.enFindBy.TransactionID);
            frm.ShowDialog();
        }

        private async void showVehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int bookingID = (int)dgvTransactionsList.CurrentRow.Cells[3].Value;

            clsRentalBooking booking = await clsRentalBooking.FindByIDAsync(bookingID);

            if (booking != null)
            {
                Form frm = new frmShowVehicleDetails(booking.VehicleID);
                frm.ShowDialog();
            }
        }
    }
}
