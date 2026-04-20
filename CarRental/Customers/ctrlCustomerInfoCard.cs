using CarRental.People;
using CarRental_Buisness;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Customers
{
    public partial class ctrlCustomerInfoCard : UserControl
    {
        int _CustomerID = -1;
        clsCustomer _Customer;

        public int SelectedCustomerID
        {
            get { return _CustomerID; }
        }

        public clsCustomer SelectedCustomer
        {
            get { return _Customer; }
        }
        public ctrlCustomerInfoCard()
        {
            InitializeComponent();
        }

        public async Task LoadCustomerInfo(int CustomerID)
        {
            _CustomerID = CustomerID;
            _Customer = await clsCustomer.FindByIDAsync(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show($"Customer with ID{_CustomerID} Not Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            await ctrlPersonCard1.LoadPersonInfo(_Customer.PersonID);
            lblCustomerID.Text = _CustomerID.ToString();
            lblDriverLicenseNumber.Text = _Customer.DriverLicenseNumber;
        }

        private void lblEditCustomerInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddUpdateCustomer(_CustomerID);
            frm.ShowDialog();

            // refresh after editing
            LoadCustomerInfo(_CustomerID);
        }
    }
}
