using CarRental_DataAccess;
using CarRental_DTO;
using System.Data;
using System.Threading.Tasks;

namespace CarRental_Buisness
{
    public class clsFuelType
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int FuelTypeID { get; set; }
        public string FuelTypeName { get; set; }

        public clsFuelType()
        {
            FuelTypeID = -1;
            FuelTypeName = "";
            _Mode = enMode.AddNew;
        }

        private clsFuelType(int FuelTypeID, string FuelTypeName)
        {
            this.FuelTypeID = FuelTypeID;
            this.FuelTypeName = FuelTypeName;
            _Mode = enMode.Update;
        }

        private FuelTypeDTO _ToDTO()
        {
            return new FuelTypeDTO
            {
                FuelTypeID = this.FuelTypeID,
                FuelTypeName = this.FuelTypeName
            };
        }

        private async Task<bool> _AddNewAsync()
        {
            this.FuelTypeID = await clsFuelType_DA.AddNewFuelTypeAsync(this._ToDTO());
            return this.FuelTypeID != -1;
        }

        private async Task<bool> _UpdateAsync()
        {
            return await clsFuelType_DA.UpdateFuelTypeAsync(this._ToDTO());
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

        public static async Task<clsFuelType> FindByIDAsync(int fuelTypeID)
        {
            FuelTypeDTO fuelType = await clsFuelType_DA.GetFuelTypeByIDAsync(fuelTypeID);

            if (fuelType == null)
                return null;

            return new clsFuelType(fuelType.FuelTypeID, fuelType.FuelTypeName);
        }

        public static async Task<clsFuelType> FindByNameAsync(string fuelTypeName)
        {
            FuelTypeDTO fuelType = await clsFuelType_DA.GetFuelTypeByNameAsync(fuelTypeName);

            if (fuelType == null)
                return null;

            return new clsFuelType(fuelType.FuelTypeID, fuelType.FuelTypeName);
        }
        public static async Task<bool> DeleteFuelTypeAsync(int fuelTypeID)
        {
            return await clsFuelType_DA.DeleteFuelTypeAsync(fuelTypeID);
        }

        public static async Task<DataTable> GetAllFuelTypesAsync()
        {
            return await clsFuelType_DA.GetAllFuelTypesAsync();
        }
    }
}
