using CarRental_Buisness;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Vehicles.Controls
{
    public partial class ctrlVehicleInfoCardWithFilter : UserControl
    {

        /// <summary>
        /// Event triggered when a vehicle is selected.
        /// Passes the selected VehicleID to subscribers.
        /// </summary>

        public event Action<int> OnVehicleSelected;

        // Create a protected method to raise the event with a parameter
        protected virtual void VehicleSelected(int VehicleID)
        {
            Action<int> handler = OnVehicleSelected;
            if (handler != null)
            {
                handler(VehicleID); // Raise the event with the parameter
            }
        }

        /// <summary>
        /// Holds the current vehicle ID. Default is -1 (no selection).
        /// </summary>
        int _VehicleID = -1;

        public int SelectedVehicleID { get { return ctrlVehicleInfoCard1.SelectedVehicleID; } }

        /// <summary>
        /// Gets the selected vehicle full information.
        /// </summary>
        public clsVehicle SelectedVehicleInfo
        {
            get { return ctrlVehicleInfoCard1.SelectedVehicleInfo; }
        }

        public bool FilterEnabled
        {
            get
            {
                return gbFilter.Enabled;
            }

            set
            {
                gbFilter.Enabled = value;
            }
        }



        public ctrlVehicleInfoCardWithFilter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads vehicle information by ID and updates the UI.
        /// Also triggers the selection event if filtering is enabled.
        /// </summary>
        /// <param name="VehicleID">The vehicle ID to load.</param>
        /// <returns>Async task.</returns>
        public async Task LoadVehicleInfo(int VehicleID)
        {
            _VehicleID = VehicleID;
            txtVehicleID.Text = VehicleID.ToString();

            await ctrlVehicleInfoCard1.LoadVehicleInfo(_VehicleID);

            if (OnVehicleSelected != null && FilterEnabled)
                VehicleSelected(ctrlVehicleInfoCard1.SelectedVehicleID);
        }



        private void btnAddNewVehicle_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateVehicle frm = new frmAddUpdateVehicle();
            frm.DataBack += DataBackEvent; // Subscribe to the event
            frm.ShowDialog();


        }

        /// <summary>
        /// Handles data returned from Add/Update form and refreshes vehicle info.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="VehicleID">Returned vehicle ID (currently unused).</param>
        private async void DataBackEvent(object sender, int VehicleID)
        {
            _VehicleID = VehicleID;
            txtVehicleID.Text = VehicleID.ToString();
            await ctrlVehicleInfoCard1.LoadVehicleInfo(VehicleID);
        }

        private async void btnFindVehicle_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Vehicle ID is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await LoadVehicleInfo(int.Parse(txtVehicleID.Text.Trim()));

        }

        private void txtVehicleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFindVehicle.PerformClick();
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        public void FilterFocus()
        {
            txtVehicleID.Focus();
        }

        private void txtVehicleID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 

            if (string.IsNullOrEmpty(txtVehicleID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtVehicleID, "Vehicle ID is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtVehicleID, null);
            }
        }

        private void ctrlVrhicleInfoCardWithFilter_Load(object sender, System.EventArgs e)
        {
            FilterFocus();

        }
    }
}
