using CarRental_Buisness;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Vehicles.Controls
{
    public partial class ctrlVehicleInfoCard : UserControl
    {
        int _VehicleID = -1;
        clsVehicle _Vehicle;

        public int SelectedVehicleID { get { return _VehicleID; } }

        public clsVehicle SelectedVehicleInfo
        {
            get { return _Vehicle; }
        }
        public ctrlVehicleInfoCard()
        {
            InitializeComponent();
        }

        public async Task LoadVehicleInfo(int VehicleID)
        {
            _VehicleID = VehicleID;

            _Vehicle = await clsVehicle.FindByIDAsync(_VehicleID);

            if (_Vehicle == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Vehicle with VehicleID = " + VehicleID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillVehicleInfo();

        }

        private void _FillVehicleInfo()
        {
            llEditVehicleInfo.Enabled = true;
            lblVehicleID.Text = _VehicleID.ToString();
            lblMake.Text = _Vehicle.Make;
            lblModel.Text = _Vehicle.Model;
            lblYear.Text = _Vehicle.Years.ToString();
            lblRntalPrice.Text = _Vehicle.RentalPricePerDay.ToString();
            lblFuelType.Text = _Vehicle.FuelTypeInfo.FuelTypeName;
            lblCatigory.Text = _Vehicle.CategoryInfo.CategoryName;
            lblIsAvilableForRent.Text = _Vehicle.IsAvailableForRent ? "Available" : "Not Available";
            lblMileage.Text = _Vehicle.Mileage.ToString();
            lblPlateNumber.Text = _Vehicle.PlateNumber;
            lblLastMentainnaceDate.Text = (_Vehicle.LastMaintenanceInfo != null ? _Vehicle.LastMaintenanceInfo.MaintenanceDate.ToShortDateString() : "No Maintenance");
        }

        public void ResetPersonInfo()
        {
            _VehicleID = -1;
            llEditVehicleInfo.Enabled = false;

            lblVehicleID.Text = "[????]";
            lblMake.Text = "[????]";
            lblModel.Text = "[????]";
            lblYear.Text = "[????]";
            lblRntalPrice.Text = "[????]";
            lblFuelType.Text = "[????]";
            lblCatigory.Text = "[????]";
            lblIsAvilableForRent.Text = "[????]";
            lblMileage.Text = "[????]";
            lblLastMentainnaceDate.Text = "[????]";
            lblPlateNumber.Text = "[????]";

        }

        private async void llEditVehicleInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddUpdateVehicle(_VehicleID);
            frm.ShowDialog();

            // refresh
            await LoadVehicleInfo(_VehicleID);
        }

        private void ctrlVehicleInfoCard_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
