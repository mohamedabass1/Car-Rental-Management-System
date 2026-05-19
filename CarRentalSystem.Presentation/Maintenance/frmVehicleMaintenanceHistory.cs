using CarRentalSystem.Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Vehicles
{
    public partial class frmVehicleMaintenanceHistory : Form
    {
        int _VehicleID = -1;
        public frmVehicleMaintenanceHistory(int VehicleID)
        {
            InitializeComponent();
            _VehicleID = VehicleID;
        }

        DataTable dtVehicleMaintenanceHistory;
        private async void frmVehicleMaintenanceHistory_Load(object sender, EventArgs e)
        {
            await ctrlVehicleInfoCard1.LoadVehicleInfo(_VehicleID);
            dtVehicleMaintenanceHistory = await clsMaintenance.GetAllVehicleMaintenanceAsync(_VehicleID);

            dgvMaintenanceHistory.DataSource = dtVehicleMaintenanceHistory;

            lblRecordsCount.Text = dgvMaintenanceHistory.Rows.Count.ToString();

            if (dgvMaintenanceHistory.Rows.Count > 0)
            {

                dgvMaintenanceHistory.Columns[0].HeaderText = "Maintenance ID";
                dgvMaintenanceHistory.Columns[0].Width = 120;

                dgvMaintenanceHistory.Columns[1].HeaderText = "Vehicle ID";
                dgvMaintenanceHistory.Columns[1].Width = 120;

                dgvMaintenanceHistory.Columns[2].HeaderText = "Description";
                dgvMaintenanceHistory.Columns[2].Width = 140;

                dgvMaintenanceHistory.Columns[3].HeaderText = "Maintenance Date";
                dgvMaintenanceHistory.Columns[3].Width = 130;

                dgvMaintenanceHistory.Columns[4].HeaderText = "Cost";
                dgvMaintenanceHistory.Columns[4].Width = 120;

            }


        }

        private void btnClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
