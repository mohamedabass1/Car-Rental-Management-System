using CarRental.Global_Classes;
using CarRental_Buisness;
using CarRental_Buisness.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace CarRental.People
{
    public partial class frmAddUpdateCustomer : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int CustomerID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;
        int _CustomerID = -1;
        clsCustomer _Customer;

        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateCustomer(int CustomerID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _CustomerID = CustomerID;
        }

        private void _ResetDefaultValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Customer";
                _Customer = new clsCustomer();
            }
            else
            {
                lblTitle.Text = "Update Customer";
            }


            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);



            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtLastName.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtLicenseNumber.Text = "";


        }

        private async void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = await clsCountry.GetAllCountriesAsync();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }

            //this will set default country to Yemen.
            cbCountry.SelectedIndex = cbCountry.FindString("Yemen");

        }



        private async void _LoadCustomerData()
        {
            _Customer = await clsCustomer.FindByIDAsync(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show("No Customer with ID = " + _CustomerID, "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            lblCustomerID.Text = _CustomerID.ToString();
            txtLicenseNumber.Text = _Customer.DriverLicenseNumber;
            txtFirstName.Text = _Customer.PersonInfo.FirstName;
            txtSecondName.Text = _Customer.PersonInfo.SecondName;
            txtLastName.Text = _Customer.PersonInfo.LastName;
            dtpDateOfBirth.Value = _Customer.PersonInfo.DateOfBirth;

            if (_Customer.PersonInfo.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtAddress.Text = _Customer.PersonInfo.Address;
            txtPhone.Text = _Customer.PersonInfo.Phone;
            txtEmail.Text = _Customer.PersonInfo.Email;

            cbCountry.SelectedIndex = cbCountry.FindString(_Customer.PersonInfo.CountryInfo.CountryName);

        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadCustomerData();
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            clsCountry countryInfo = await clsCountry.FindAsync(cbCountry.Text);


            int NationalityCountryID = countryInfo.ID;

            _Customer.DriverLicenseNumber = txtLicenseNumber.Text.Trim();
            _Customer.PersonInfo.FirstName = txtFirstName.Text.Trim();
            _Customer.PersonInfo.SecondName = txtSecondName.Text.Trim();
            _Customer.PersonInfo.LastName = txtLastName.Text.Trim();
            _Customer.PersonInfo.Email = txtEmail.Text.Trim();
            _Customer.PersonInfo.Phone = txtPhone.Text.Trim();
            _Customer.PersonInfo.Address = txtAddress.Text.Trim();
            _Customer.PersonInfo.DateOfBirth = dtpDateOfBirth.Value;



            if (rbMale.Checked)
                _Customer.PersonInfo.Gendor = (short)enGendor.Male;
            else
                _Customer.PersonInfo.Gendor = (short)enGendor.Female;

            _Customer.PersonInfo.NationalityCountryID = NationalityCountryID;


            bool isSaved = false;

            if (_Mode == enMode.AddNew)
            {
                isSaved = await clsCustomerRegistrationService
                    .RegisterCustomerAsync(_Customer) != -1;
            }
            else
            {
                // update mode
                isSaved = await _Customer.SaveAsync();
            }

            if (isSaved)
            {
                lblCustomerID.Text = _Customer.CustomerID.ToString();

                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Customer";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Customer.CustomerID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
            ;

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);

        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);

        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);

        }

        private async void txtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);

            if (txtLicenseNumber.Text.Trim() != _Customer.DriverLicenseNumber &&
                await clsCustomer.IsCustomerExistsAsync(txtLicenseNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseNumber, "License Number is used by another customers");
            }
            else
                errorProvider1.SetError(txtLicenseNumber, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
