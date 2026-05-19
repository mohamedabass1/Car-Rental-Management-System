using CarRentalSystem.Business;
using CarRentalSystem.Presentation.People;
using System.Data;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Customers
{
    public partial class frmListCustomers : Form
    {
        public frmListCustomers()
        {
            InitializeComponent();
        }

        DataTable _dtCustomers;


        private async void frmListCustomers_Load(object sender, System.EventArgs e)
        {
            _dtCustomers = await clsCustomer.GetAllCustomersAsync();


            dgvCustomersList.DataSource = _dtCustomers;

            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvCustomersList.Rows.Count.ToString();

            if (dgvCustomersList.Rows.Count > 0)
            {

                dgvCustomersList.Columns[0].HeaderText = "ID";
                dgvCustomersList.Columns[0].Width = 90;

                dgvCustomersList.Columns[1].HeaderText = "First Name";
                dgvCustomersList.Columns[1].Width = 120;

                dgvCustomersList.Columns[2].HeaderText = "Second Name";
                dgvCustomersList.Columns[2].Width = 140;

                dgvCustomersList.Columns[3].HeaderText = "Last Name";
                dgvCustomersList.Columns[3].Width = 120;

                dgvCustomersList.Columns[4].HeaderText = "Gendor";
                dgvCustomersList.Columns[4].Width = 120;

                dgvCustomersList.Columns[5].HeaderText = "Nationality";
                dgvCustomersList.Columns[5].Width = 120;

                dgvCustomersList.Columns[7].HeaderText = "Date Of Birth";
                dgvCustomersList.Columns[7].Width = 160;

                dgvCustomersList.Columns[6].HeaderText = "Phone";
                dgvCustomersList.Columns[6].Width = 120;

                dgvCustomersList.Columns[8].HeaderText = "Email";
                dgvCustomersList.Columns[8].Width = 170;

                dgvCustomersList.Columns[9].HeaderText = "License Number";
                dgvCustomersList.Columns[9].Width = 170;
            }
        }

        // filtering
        #region 
        private void txtFilterValue_TextChanged(object sender, System.EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Customer ID":
                    FilterColumn = "CustomerID";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "Gendor";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                case "License No":
                    FilterColumn = "DriverLicenseNumber";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtCustomers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvCustomersList.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "CustomerID")
                //in this case we deal with integer not string.

                _dtCustomers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtCustomers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvCustomersList.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, System.EventArgs e)
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
            //we allow number incase person id is selected.
            if (cbFilterBy.Text == "Customer ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        private void btnAddCustomer_Click(object sender, System.EventArgs e)
        {
            Form frm = new frmAddUpdateCustomer();
            frm.ShowDialog();

            // refresh
            frmListCustomers_Load(null, null);
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form frm = new frmAddUpdateCustomer();
            frm.ShowDialog();

            // refresh
            frmListCustomers_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int CustomerID = (int)dgvCustomersList.CurrentRow.Cells[0].Value;

            Form frm = new frmAddUpdateCustomer(CustomerID);
            frm.ShowDialog();

            // refresh
            frmListCustomers_Load(null, null);
        }

        private async void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int CustomerID = (int)dgvCustomersList.CurrentRow.Cells[0].Value;


            if (MessageBox.Show("Are you sure you want to delete Customer [" + CustomerID + "]",
                "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (await clsCustomer.DeleteCustomerAsync(CustomerID))
            {
                MessageBox.Show("Customer Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // refresh
                frmListCustomers_Load(null, null);
            }
            else
                MessageBox.Show("Customer was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void showCustomerDeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int CustomerID = (int)dgvCustomersList.CurrentRow.Cells[0].Value;

            Form frm = new frmShowCustomerDetails(CustomerID);
            frm.ShowDialog();
        }

        private void showCustomerBookingHistoryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int CustomerID = (int)dgvCustomersList.CurrentRow.Cells[0].Value;

            frmCustomerBookingHistory frm = new frmCustomerBookingHistory(CustomerID);
            frm.ShowDialog();
        }

        private void showCustomerTransactionsHistoryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            int CustomerID = (int)dgvCustomersList.CurrentRow.Cells[0].Value;
            frmCustomerTransactionsHistory frm = new frmCustomerTransactionsHistory(CustomerID);
            frm.ShowDialog();
        }
    }
}
