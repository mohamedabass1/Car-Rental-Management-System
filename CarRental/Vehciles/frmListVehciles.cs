using CarRental_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarRental.Vehciles
{
    public partial class frmListVehciles : Form
    {
        public frmListVehciles()
        {
            InitializeComponent();
        }

        private DataTable _dtVehciles;
        private async void frmListVehciles_Load(object sender, EventArgs e)
        {
            _dtVehciles = await clsVehicle.GetAllVehiclesAsync();

            dgvVehciles.DataSource = _dtVehciles;

            lblRecordsCount.Text = dgvVehciles.Rows.Count.ToString();

        }
    }
}
