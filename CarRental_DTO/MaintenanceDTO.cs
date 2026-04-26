using System;

namespace CarRental_DTO
{
    public class MaintenanceDTO
    {
        public int MaintenanceID { get; set; }
        public int VehicleID { get; set; }
        public string Description { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public decimal Cost { get; set; }
    }


}
