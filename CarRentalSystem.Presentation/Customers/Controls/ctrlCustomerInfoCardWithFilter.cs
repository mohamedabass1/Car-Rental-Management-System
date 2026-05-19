using CarRentalSystem.Business;
using CarRentalSystem.Presentation.People;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Customers.Controls
{
    public partial class ctrlCustomerInfoCardWithFilter : UserControl
    {
        public event Action<int> OnCustomerSelected;

        // Create a protected method to raise the event with a parameter
        protected virtual void CustomerSelected(int CustomerID)
        {
            Action<int> handler = OnCustomerSelected;
            if (handler != null)
            {
                handler(CustomerID); // Raise the event with the parameter
            }
        }

        int _CustomerID = -1;

        public int SelectedCustomerID
        {
            get { return ctrlCustomerInfoCard1.SelectedCustomerID; }
        }

        public clsCustomer SelectedCustomerInfo
        {
            get { return ctrlCustomerInfoCard1.SelectedCustomerInfo; }
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

        public ctrlCustomerInfoCardWithFilter()
        {
            InitializeComponent();
        }

        public async Task LoadCustomerInfo(int CustomerID)
        {
            _CustomerID = CustomerID;
            txtCustomerID.Text = _CustomerID.ToString();

            await ctrlCustomerInfoCard1.LoadCustomerInfo(_CustomerID);

            if (OnCustomerSelected != null && FilterEnabled)
                CustomerSelected(_CustomerID);

        }

        private void btnAddNewCustomer_Click(object sender, System.EventArgs e)
        {
            frmAddUpdateCustomer frm = new frmAddUpdateCustomer();
            frm.DataBack += DataBackEvent;  // Subscribe to the event
            frm.ShowDialog();
        }

        private async void DataBackEvent(object sender, int CustomerID)
        {
            _CustomerID = CustomerID;
            txtCustomerID.Text = _CustomerID.ToString();

            await ctrlCustomerInfoCard1.LoadCustomerInfo(_CustomerID);

        }

        private async void btnFindCustomer_Click(object sender, System.EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Customer ID is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await LoadCustomerInfo(int.Parse(txtCustomerID.Text));

        }

        private void txtCustomerID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 

            if (string.IsNullOrEmpty(txtCustomerID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCustomerID, "Vehicle ID is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtCustomerID, null);
            }
        }

        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFindCustomer.PerformClick();
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        public void FilterFocus()
        {
            txtCustomerID.Focus();
        }

        private void CustomerInfoCardWithFilter_Load(object sender, EventArgs e)
        {
            FilterFocus();
        }
    }
}
