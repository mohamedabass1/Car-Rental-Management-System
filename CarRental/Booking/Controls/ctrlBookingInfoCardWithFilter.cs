using CarRental_Buisness;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.Booking.Controls
{
    public partial class ctrlBookingInfoCardWithFilter : UserControl
    {
        public event Action<int> OnBookingSelected;

        // Create a protected method to raise the event with a parameter
        protected virtual void BookingSelected(int BookingID)
        {
            Action<int> handler = OnBookingSelected;
            if (handler != null)
            {
                handler(BookingID); // Raise the event with the parameter
            }
        }
        public clsRentalBooking SelectedBookingInfo { get { return ctrlBookingInfoCard1.SelectedBookingInfo; } }
        public int SelectedBookingID
        {
            get
            {
                return ctrlBookingInfoCard1.SelectedBookingID;
            }
        }

        int _BookingID = -1;
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

        public ctrlBookingInfoCardWithFilter()
        {
            InitializeComponent();
        }



        private async void btnFindBooking_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Booking ID is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int bookingID = int.Parse(txtBookingID.Text);

            await LoadRentalBookingInfo(bookingID);
        }

        public async Task LoadRentalBookingInfo(int BookingID)
        {
            _BookingID = BookingID;
            txtBookingID.Text = _BookingID.ToString();

            await ctrlBookingInfoCard1.LoadRentalBookingInfo(_BookingID);

            if (OnBookingSelected != null && FilterEnabled)
                BookingSelected(_BookingID);

        }
        public void FilterFocus()
        {
            txtBookingID.Focus();
        }


        private void txtBookingID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFindBooking.PerformClick();
                e.Handled = true;
                return;
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBookingID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 

            if (string.IsNullOrEmpty(txtBookingID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBookingID, "Booking ID is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtBookingID, null);
            }
        }
    }
}
