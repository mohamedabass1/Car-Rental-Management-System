using CarRental_DataAccess;
using CarRental_DTO;
using System.Data;
using System.Threading.Tasks;

namespace CarRental_Buisness
{
    public class clsVehicleCategory
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public clsVehicleCategory()
        {
            CategoryID = -1;
            CategoryName = "";
            _Mode = enMode.AddNew;
        }

        private clsVehicleCategory(int CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            _Mode = enMode.Update;
        }

        private VehicleCategoryDTO _ToDTO()
        {
            return new VehicleCategoryDTO
            {
                CategoryID = this.CategoryID,
                CategoryName = this.CategoryName
            };
        }

        private async Task<bool> _AddNewAsync()
        {
            this.CategoryID = await clsVehicleCategory_DA.AddNewVehicleCategoryAsync(this._ToDTO());
            return this.CategoryID != -1;
        }

        private async Task<bool> _UpdateAsync()
        {
            return await clsVehicleCategory_DA.UpdateVehicleCategoryAsync(this._ToDTO());
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

        public static async Task<clsVehicleCategory> FindByIDAsync(int categoryID)
        {
            VehicleCategoryDTO category = await clsVehicleCategory_DA.GetVehicleCategoryByIDAsync(categoryID);

            if (category == null)
                return null;

            return new clsVehicleCategory(category.CategoryID, category.CategoryName);
        }

        public static async Task<clsVehicleCategory> FindByNameAsync(string categoryName)
        {
            VehicleCategoryDTO category = await clsVehicleCategory_DA.GetVehicleCategoryByNameAsync(categoryName);

            if (category == null)
                return null;

            return new clsVehicleCategory(category.CategoryID, category.CategoryName);
        }

        public static async Task<bool> DeleteVehicleCategoryAsync(int categoryID)
        {
            return await clsVehicleCategory_DA.DeleteVehicleCategoryAsync(categoryID);
        }

        public static async Task<DataTable> GetAllVehicleCategoriesAsync()
        {
            return await clsVehicleCategory_DA.GetAllVehicleCategoriesAsync();
        }
    }
}

