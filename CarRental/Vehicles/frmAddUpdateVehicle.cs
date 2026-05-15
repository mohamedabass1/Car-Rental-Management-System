using CarRental_Buisness;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Vehicles
{
    public partial class frmAddUpdateVehicle : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int VehicleID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        int _VehicleID = -1;
        clsVehicle _Vehicle;

        private enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;
        public frmAddUpdateVehicle()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateVehicle(int VehicleID)
        {
            InitializeComponent();
            _Mode = enMode.Update;

            _VehicleID = VehicleID;
        }

        private async void frmAddUpdateVehicle_Load(object sender, System.EventArgs e)
        {
            await _ResetDefualtValues();

            if (_Mode == enMode.Update)
                await _LoadData();

        }

        private async Task _ResetDefualtValues()
        {
            await _FillFuelTypesInComboBox();

            await _FillCarCategoriesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                _Vehicle = new clsVehicle();
                lblTitle.Text = "Add New Vehicle";
            }
            else
            {
                lblTitle.Text = "Update Vehicle";
            }

            cbCarCategory.SelectedIndex = 0;
            cbFuelType.SelectedIndex = 0;

            txtMake.Text = "";
            txtModel.Text = "";
            txtMileage.Text = "";
            txtPlateNumber.Text = "";
            txtRentalPricePerDay.Text = "";
            txtYear.Text = "";
            chbIsAvilableForRent.Checked = true;



        }

        private async Task _FillCarCategoriesInComboBox()
        {
            DataTable dt = await clsVehicleCategory.GetAllVehicleCategoriesAsync();

            foreach (DataRow row in dt.Rows)
            {
                cbCarCategory.Items.Add(row["CategoryName"]);
            }
        }

        private async Task _FillFuelTypesInComboBox()
        {
            DataTable dt = await clsFuelType.GetAllFuelTypesAsync();

            foreach (DataRow row in dt.Rows)
            {
                cbFuelType.Items.Add(row["FuelTypeName"]);
            }
        }

        private async Task _LoadData()
        {
            _Vehicle = await clsVehicle.FindByIDAsync(_VehicleID);

            if (_Vehicle == null)
            {
                MessageBox.Show("No Vehicle with VehicleID = " + _VehicleID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblVehicleID.Text = _VehicleID.ToString();
            txtMake.Text = _Vehicle.Make;
            txtModel.Text = _Vehicle.Model;
            txtMileage.Text = _Vehicle.Mileage.ToString();
            txtPlateNumber.Text = _Vehicle.PlateNumber;
            txtRentalPricePerDay.Text = _Vehicle.RentalPricePerDay.ToString();
            txtYear.Text = _Vehicle.Years.ToString();
            chbIsAvilableForRent.Checked = _Vehicle.IsAvailableForRent;

            cbCarCategory.SelectedIndex = cbCarCategory.FindString(_Vehicle.CategoryInfo.CategoryName);
            cbFuelType.SelectedIndex = cbFuelType.FindString(_Vehicle.FuelTypeInfo.FuelTypeName);


        }

        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Vehicle.Make = txtMake.Text.Trim();
            _Vehicle.Model = txtModel.Text.Trim();
            _Vehicle.Years = Convert.ToInt16(txtYear.Text.Trim());
            _Vehicle.Mileage = Convert.ToInt32(txtMileage.Text.Trim());
            _Vehicle.PlateNumber = txtPlateNumber.Text.Trim();
            _Vehicle.RentalPricePerDay = Convert.ToDecimal(txtRentalPricePerDay.Text.Trim());
            _Vehicle.IsAvailableForRent = chbIsAvilableForRent.Checked;

            clsVehicleCategory vehicleCategory = await clsVehicleCategory.FindByNameAsync(cbCarCategory.Text);
            _Vehicle.CarCategoryID = vehicleCategory.CategoryID;

            clsFuelType fuelType = await clsFuelType.FindByNameAsync(cbFuelType.Text);
            _Vehicle.FuelTypeID = fuelType.FuelTypeID;


            if (await _Vehicle.SaveAsync())
            {
                lblVehicleID.Text = _Vehicle.VehicleID.ToString();
                lblTitle.Text = "Update Vehicle";

                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trigger the event to send data back to the caller form.
                this.DataBack?.Invoke(this, _Vehicle.VehicleID);



            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            Guna2TextBox Temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }
        private void txtYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

        private async void txtPlateNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);

            string PlateNumber = txtPlateNumber.Text.Trim();

            if (PlateNumber != _Vehicle.PlateNumber && await clsVehicle.IsVehicleExistsByPlateNumberAsync(PlateNumber))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPlateNumber, "Plate Number is used for another vehicle!");
            }
            else
            {
                errorProvider1.SetError(txtPlateNumber, null);
            }
        }

        private void txtMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void txtYear_Validating1(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);

            int Year = int.Parse(txtYear.Text.Trim());

            if (Year > DateTime.Now.Year)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtYear, "Please Enter valid Year!");
            }
            else
            {
                errorProvider1.SetError(txtYear, null);
            }
        }
    }
}
