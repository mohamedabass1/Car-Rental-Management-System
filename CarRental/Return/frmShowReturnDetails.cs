using CarRental_Buisness;
using System;
using System.Windows.Forms;

namespace CarRental.Return
{
    public partial class frmShowReturnDetails : Form
    {
        int _ReturnID = -1;
        public frmShowReturnDetails(int ReturnID)
        {
            InitializeComponent();
            _ReturnID = ReturnID;
        }

        private async void frmShowReturnDetails_Load(object sender, EventArgs e)
        {
            await ctrlReturnInfoCard1.LoadVehicleReturnInfo(_ReturnID);


            if (ctrlReturnInfoCard1.SelectedVehicleReturn != null)
            {
                clsRentalTransaction rentalTransaction = await clsRentalTransaction.FindByReturnIDAsync(_ReturnID);

                int CustomerID = rentalTransaction.BookingInfo.CustomerID;

                int VehicleID = rentalTransaction.BookingInfo.VehicleID;

                await ctrlCustomerInfoCard1.LoadCustomerInfo(CustomerID);
                await ctrlVehicleInfoCard1.LoadVehicleInfo(VehicleID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
