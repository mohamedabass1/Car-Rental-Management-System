using CarRental.Maintenance;
using CarRental.Vehicles;
using CarRental_Buisness;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Vehciles
{
    public partial class frmListVehicles : Form
    {
        public frmListVehicles()
        {
            InitializeComponent();
        }

        private DataTable _dtVehciles;

        private async Task _LoadVehicleList(int PageNumber, int RowsPerPage)
        {
            _dtVehciles = await clsVehicle.ListVehiclesPagedAsync(PageNumber, RowsPerPage);

            dgvVehciles.DataSource = _dtVehciles;



            lblRecordsCount.Text = dgvVehciles.Rows.Count.ToString();

            if (dgvVehciles.Rows.Count > 0)
            {

                dgvVehciles.Columns[0].HeaderText = "ID";
                dgvVehciles.Columns[0].Width = 90;

                dgvVehciles.Columns[1].HeaderText = "Make";
                dgvVehciles.Columns[1].Width = 120;

                dgvVehciles.Columns[2].HeaderText = "Model";
                dgvVehciles.Columns[2].Width = 140;

                dgvVehciles.Columns[3].HeaderText = "Years";
                dgvVehciles.Columns[3].Width = 100;

                dgvVehciles.Columns[4].HeaderText = "Mileage";
                dgvVehciles.Columns[4].Width = 120;

                dgvVehciles.Columns[5].HeaderText = "Fuel Type";
                dgvVehciles.Columns[5].Width = 120;

                dgvVehciles.Columns[7].HeaderText = "Category";
                dgvVehciles.Columns[7].Width = 120;

                dgvVehciles.Columns[6].HeaderText = "Plate Number";
                dgvVehciles.Columns[6].Width = 160;


                dgvVehciles.Columns[8].HeaderText = "Price Per Day";
                dgvVehciles.Columns[8].Width = 170;

                dgvVehciles.Columns[9].HeaderText = "Is Available";
                dgvVehciles.Columns[9].Width = 120;
            }

        }
        private async void frmListVehciles_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            cbPages.SelectedIndex = 0;

            await _LoadVehicleList(1, 20);

        }

        private async void cbPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int PageNumber = Convert.ToInt32(cbPages.Text);

            await _LoadVehicleList(PageNumber, 20);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbFilterBy.Text == "Is Available")
            {
                txtFilterValue.Visible = false;
                cbVehicleStatus.Visible = true;
                cbVehicleStatus.Focus();
                cbVehicleStatus.SelectedIndex = 0;
            }
            else
            {

                txtFilterValue.Visible = (cbFilterBy.Text != "None");
                cbVehicleStatus.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    txtFilterValue.Enabled = false;
                }
                else
                    txtFilterValue.Enabled = true;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Vehicle ID":
                    FilterColumn = "VehicleID";
                    break;

                case "Make":
                    FilterColumn = "Make";
                    break;

                case "Model":
                    FilterColumn = "Model";
                    break;

                case "Year":
                    FilterColumn = "Years";
                    break;

                case "Price":
                    FilterColumn = "RentalPricePerDay";
                    break;

                case "Fuel Type":
                    FilterColumn = "FuelTypeName";
                    break;

                case "Plate Number":
                    FilterColumn = "PlateNumber";
                    break;


                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtVehciles.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvVehciles.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "VehicleID" || FilterColumn == "Years" || FilterColumn == "RentalPricePerDay")
                //in this case we deal with numbers not string.
                _dtVehciles.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtVehciles.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtVehciles.Rows.Count.ToString();
        }

        private void cbVehicleStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsAvailableForRent";
            string FilterValue = cbVehicleStatus.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Available":
                    FilterValue = "1";
                    break;
                case "Unavailable":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtVehciles.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtVehciles.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = _dtVehciles.Rows.Count.ToString();

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "Vehicle ID" || cbFilterBy.Text == "Year" || cbFilterBy.Text == "Price")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddNewVehcile_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateVehicle();
            frm.ShowDialog();

            frmListVehciles_Load(null, null);
        }

        private void showVehicleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int VehicleID = (int)dgvVehciles.CurrentRow.Cells[0].Value;
            Form frm = new frmShowVehicleDetails(VehicleID);
            frm.ShowDialog();
        }

        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateVehicle();
            frm.ShowDialog();

            frmListVehciles_Load(null, null);
        }

        private void editVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int VehicleID = (int)dgvVehciles.CurrentRow.Cells[0].Value;

            Form frm = new frmAddUpdateVehicle(VehicleID);
            frm.ShowDialog();

            frmListVehciles_Load(null, null);

        }

        private async void deleteVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int VehicleID = (int)dgvVehciles.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete Vehicle [" + VehicleID + "]",
             "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (await clsVehicle.DeleteVehicleAsync(VehicleID))
            {
                MessageBox.Show("Vehicle Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // refresh
                frmListVehciles_Load(null, null);

            }
            else
                MessageBox.Show("Vehicle was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int VehicleID = (int)dgvVehciles.CurrentRow.Cells[0].Value;
            Form frm = new frmMaintenance(VehicleID);
            frm.ShowDialog();
        }

        private void btnNewMaintenance_Click(object sender, EventArgs e)
        {
            Form frm = new frmMaintenance();
            frm.ShowDialog();
        }
    }
}
