namespace CarRental_DTO
{
    public class VehicleDTO
    {
        public int VehicleID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Years { get; set; }
        public int Mileage { get; set; }
        public int FuelTypeID { get; set; }
        public string PlateNumber { get; set; }
        public int CarCategoryID { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailableForRent { get; set; }

    }
}
