using System;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Vehicles
{
    public partial class frmShowVehicleDetails : Form
    {
        int _VehicleID = -1;
        public frmShowVehicleDetails(int VehicleID)
        {
            InitializeComponent();
            _VehicleID = VehicleID;
        }

        private async void frmShowVehicleDetails_Load(object sender, EventArgs e)
        {
            await ctrlVehicleInfoCard1.LoadVehicleInfo(_VehicleID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
