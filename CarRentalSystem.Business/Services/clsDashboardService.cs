using System.Threading.Tasks;

namespace CarRentalSystem.Business.Services
{
    public class clsDashboardService
    {
        // Dashboard Statistics DTO

        public class DashboardStatsDTO
        {
            public int TotalVehicles { get; set; }

            public int AvailableVehicles { get; set; }

            public int CustomersCount { get; set; }

            public int ActiveBookings { get; set; }
        }

        // Get Dashboard Statistics

        public static async Task<DashboardStatsDTO> GetDashboardStatsAsync()
        {
            DashboardStatsDTO stats = new DashboardStatsDTO();

            // Total Vehicles
            stats.TotalVehicles = await clsVehicle.GetTotalVehiclesCountAsync();

            // Available Vehicles
            stats.AvailableVehicles = await clsVehicle.GetAvailableVehiclesCountAsync();

            // Customers Count
            stats.CustomersCount = await clsCustomer.GetCustomersCountAsync();

            // Active Bookings
            stats.ActiveBookings = stats.TotalVehicles - stats.AvailableVehicles;

            return stats;
        }
    }
}