using CarRental_DataAccess;
using CarRental_DTO;
using System.Data;
using System.Threading.Tasks;

namespace CarRental_Buisness
{

    public class clsVehicle
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

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

        public clsVehicle()
        {
            VehicleID = -1;
            Make = "";
            Model = "";
            Years = 0;
            Mileage = 0;
            FuelTypeID = -1;
            PlateNumber = "";
            CarCategoryID = -1;
            RentalPricePerDay = 0;
            IsAvailableForRent = false;

            _Mode = enMode.AddNew;
        }

        private clsVehicle(int VehicleID, string Make, string Model, int Years, int Mileage,
                          int FuelTypeID, string PlateNumber, int CarCategoryID,
                          decimal RentalPricePerDay, bool IsAvailableForRent)
        {
            this.VehicleID = VehicleID;
            this.Make = Make;
            this.Model = Model;
            this.Years = Years;
            this.Mileage = Mileage;
            this.FuelTypeID = FuelTypeID;
            this.PlateNumber = PlateNumber;
            this.CarCategoryID = CarCategoryID;
            this.RentalPricePerDay = RentalPricePerDay;
            this.IsAvailableForRent = IsAvailableForRent;

            _Mode = enMode.Update;
        }

        private VehicleDTO _ToDTO()
        {
            return new VehicleDTO
            {
                VehicleID = this.VehicleID,
                Make = this.Make,
                Model = this.Model,
                Years = this.Years,
                Mileage = this.Mileage,
                FuelTypeID = this.FuelTypeID,
                PlateNumber = this.PlateNumber,
                CarCategoryID = this.CarCategoryID,
                RentalPricePerDay = this.RentalPricePerDay,
                IsAvailableForRent = this.IsAvailableForRent
            };
        }

        private async Task<bool> _AddNewAsync()
        {
            this.VehicleID = await clsVehicle_DA.AddNewVehicleAsync(this._ToDTO());
            return this.VehicleID != -1;
        }

        private async Task<bool> _UpdateAsync()
        {
            return await clsVehicle_DA.UpdateVehicleAsync(this._ToDTO());
        }

        public async Task<bool> SaveAsync()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewAsync())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    break;

                case enMode.Update:
                    return await _UpdateAsync();
            }
            return false;
        }

        public static async Task<clsVehicle> FindByIDAsync(int vehicleID)
        {
            VehicleDTO vehicle = await clsVehicle_DA.GetVehicleByIDAsync(vehicleID);

            if (vehicle == null)
                return null;

            return new clsVehicle(
                vehicle.VehicleID,
                vehicle.Make,
                vehicle.Model,
                vehicle.Years,
                vehicle.Mileage,
                vehicle.FuelTypeID,
                vehicle.PlateNumber,
                vehicle.CarCategoryID,
                vehicle.RentalPricePerDay,
                vehicle.IsAvailableForRent
            );
        }

        public static async Task<bool> DeleteVehicleAsync(int vehicleID)
        {
            return await clsVehicle_DA.DeleteVehicleAsync(vehicleID);
        }

        public static async Task<DataTable> GetAllVehiclesAsync()
        {
            return await clsVehicle_DA.GetAllVehiclesAsync();
        }
    }
}


