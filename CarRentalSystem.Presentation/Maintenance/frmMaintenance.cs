using CarRentalSystem.Presentation.Vehicles;
using CarRentalSystem.Business;
using System;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Maintenance
{

    public partial class frmMaintenance : Form
    {
        int _SelectedVehicleID = -1;


        int _MaintenanceID = -1;
        clsMaintenance _Maintenance;
        public frmMaintenance()
        {
            InitializeComponent();
        }

        public frmMaintenance(int VehicleID)
        {
            InitializeComponent();
            _SelectedVehicleID = VehicleID;

        }

        private async void frmMaintenance_Load(object sender, System.EventArgs e)
        {
            if (_SelectedVehicleID != -1)
            {
                await ctrlVrhicleInfoCardWithFilter1.LoadVehicleInfo(_SelectedVehicleID);
                ctrlVrhicleInfoCardWithFilter1.FilterEnabled = false;
            }

            dtpMaintenanceDate.MinDate = DateTime.Now;
            dtpMaintenanceDate.MaxDate = DateTime.Now;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;

            _Maintenance = new clsMaintenance();

            _Maintenance.VehicleID = _SelectedVehicleID;
            _Maintenance.MaintenanceDate = DateTime.Now;
            _Maintenance.Cost = Convert.ToDecimal(txtCost.Text);
            _Maintenance.Description = txtDescription.Text;

            if (MessageBox.Show("Are you sure want to maintain the vehicle? ", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (await _Maintenance.SaveAsync())
            {
                _MaintenanceID = _Maintenance.MaintenanceID;
                lblMaintenanceID.Text = _MaintenanceID.ToString();

                MessageBox.Show($"Vehicle maintained successfully maintain ID: {_MaintenanceID} ", "Comfirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ctrlVrhicleInfoCardWithFilter1.FilterEnabled = false;
                btnSave.Enabled = false;

            }
        }
        private void ctrlVrhicleInfoCardWithFilter1_OnVehicleSelected(int VehicleID)
        {

            _SelectedVehicleID = VehicleID;

            lblVehicleID.Text = _SelectedVehicleID.ToString();
            btnSave.Enabled = (VehicleID != -1);
            llShowVehicleMaintenanceHistory.Enabled = (VehicleID != -1);
        }

        private void frmMaintenance_Activated(object sender, System.EventArgs e)
        {
            ctrlVrhicleInfoCardWithFilter1.FilterFocus();
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtCost_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 

            if (string.IsNullOrEmpty(txtCost.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCost, "Cost is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtCost, null);
            }
        }

        private void txtDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 

            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "Description is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtDescription, null);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowVehicleMaintenanceHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmVehicleMaintenanceHistory(_SelectedVehicleID);
            frm.ShowDialog();
        }
    }
}
