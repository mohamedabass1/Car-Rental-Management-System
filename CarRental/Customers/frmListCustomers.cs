using CarRental.People;
using CarRental_Buisness;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Customers
{
    public partial class frmListCustomers : Form
    {
        public frmListCustomers()
        {
            InitializeComponent();
        }

        DataTable _dtCustomers;

        int _PageNumber = 1;
        int _RowsPerPage = 10;
        private async void frmListCustomers_Load(object sender, System.EventArgs e)
        {
            _dtCustomers = await clsCustomer.ListCustomersPagedAsync(_PageNumber, _RowsPerPage);

            dgvCustomersList.DataSource = _dtCustomers;


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



    }
}
