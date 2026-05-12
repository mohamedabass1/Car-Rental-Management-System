using CarRental_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Booking
{
    public partial class frmRentalBookingList : Form
    {
        public frmRentalBookingList()
        {
            InitializeComponent();
        }

        DataTable dtBooking;
        private async void frmRentalBookingList_Load(object sender, EventArgs e)
        {
            dtBooking = await clsRentalBooking.GetAllAsync();

            dgvRentlBooking.DataSource = dtBooking;

            cbFilterBy.SelectedIndex = 0;

            lblRecordsCount.Text = dgvRentlBooking.Rows.Count.ToString();

            if (dgvRentlBooking.Rows.Count > 0)
            {
                dgvRentlBooking.Columns[0].HeaderText = "Booking ID";
                dgvRentlBooking.Columns[0].Width = 90;

                dgvRentlBooking.Columns[1].HeaderText = "Customer ID";
                dgvRentlBooking.Columns[1].Width = 90;

                dgvRentlBooking.Columns[2].HeaderText = "Customer Name";
                dgvRentlBooking.Columns[2].Width = 180;

                dgvRentlBooking.Columns[3].HeaderText = "Vehicle ID";
                dgvRentlBooking.Columns[3].Width = 90;

                dgvRentlBooking.Columns[4].HeaderText = "Model";
                dgvRentlBooking.Columns[4].Width = 140;

                dgvRentlBooking.Columns[5].HeaderText = "Start Date";
                dgvRentlBooking.Columns[5].Width = 140;

                dgvRentlBooking.Columns[6].HeaderText = "End Date";
                dgvRentlBooking.Columns[6].Width = 140;

                dgvRentlBooking.Columns[7].HeaderText = "Pickup";
                dgvRentlBooking.Columns[7].Width = 150;

                dgvRentlBooking.Columns[8].HeaderText = "Dropoff";
                dgvRentlBooking.Columns[8].Width = 150;

                dgvRentlBooking.Columns[9].HeaderText = "Days";
                dgvRentlBooking.Columns[9].Width = 70;

                dgvRentlBooking.Columns[10].HeaderText = "Price / Day";
                dgvRentlBooking.Columns[10].Width = 110;

                dgvRentlBooking.Columns[11].HeaderText = "Total";
                dgvRentlBooking.Columns[11].Width = 110;
            }
        }

        private void btnAddNewBooking_Click(object sender, EventArgs e)
        {
            frmAddNewBooking frm = new frmAddNewBooking();
            frm.ShowDialog();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Booking ID":
                    FilterColumn = "BookingID";
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

                case "Model":
                    FilterColumn = "Model";
                    break;

                case "Pickup":
                    FilterColumn = "PickupLocation";
                    break;

                case "Dropoff":
                    FilterColumn = "DropoffLocation";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            // Reset Filter
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                dtBooking.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvRentlBooking.Rows.Count.ToString();
                return;
            }

            // Numeric Filter
            if (FilterColumn == "BookingID"
                || FilterColumn == "CustomerID"
                || FilterColumn == "VehicleID")
            {
                dtBooking.DefaultView.RowFilter =
                    string.Format("[{0}] = {1}",
                    FilterColumn,
                    txtFilterValue.Text.Trim());
            }
            else
            {
                dtBooking.DefaultView.RowFilter =
                    string.Format("[{0}] LIKE '{1}%'",
                    FilterColumn,
                    txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvRentlBooking.Rows.Count.ToString();
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

            if (cbFilterBy.Text == "Booking ID"
                || cbFilterBy.Text == "Customer ID"
                || cbFilterBy.Text == "Vehicle ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar)
                            && !char.IsControl(e.KeyChar);
            }
        }
    }
}
