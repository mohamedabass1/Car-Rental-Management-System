using CarRental_DataAccess;
using CarRental_DTO;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CarRental_Buisness
{
    public class clsMaintenance
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int MaintenanceID { get; set; }
        public int VehicleID { get; set; }
        public string Description { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public decimal Cost { get; set; }

        public clsMaintenance()
        {
            MaintenanceID = -1;
            VehicleID = -1;
            Description = "";
            MaintenanceDate = DateTime.Now;
            Cost = 0;
            _Mode = enMode.AddNew;
        }

        private clsMaintenance(int MaintenanceID, int VehicleID, string Description, DateTime MaintenanceDate, decimal Cost)
        {
            this.MaintenanceID = MaintenanceID;
            this.VehicleID = VehicleID;
            this.Description = Description;
            this.MaintenanceDate = MaintenanceDate;
            this.Cost = Cost;

            _Mode = enMode.Update;
        }

        private MaintenanceDTO _ToDTO()
        {
            return new MaintenanceDTO
            {
                MaintenanceID = this.MaintenanceID,
                VehicleID = this.VehicleID,
                Description = this.Description,
                MaintenanceDate = this.MaintenanceDate,
                Cost = this.Cost
            };
        }

        private async Task<bool> _AddNewAsync()
        {
            this.MaintenanceID = await clsMaintenance_DA.AddNewMaintenanceAsync(this._ToDTO());
            return this.MaintenanceID != -1;
        }

        private async Task<bool> _UpdateAsync()
        {
            return await clsMaintenance_DA.UpdateMaintenanceAsync(this._ToDTO());
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

        public static async Task<clsMaintenance> FindByIDAsync(int maintenanceID)
        {
            MaintenanceDTO dto = await clsMaintenance_DA.GetMaintenanceByIDAsync(maintenanceID);

            if (dto == null)
                return null;

            return new clsMaintenance(dto.MaintenanceID, dto.VehicleID, dto.Description, dto.MaintenanceDate, dto.Cost);
        }

        public static async Task<DataTable> GetAllMaintenanceAsync()
        {
            return await clsMaintenance_DA.GetAllMaintenanceAsync();
        }

        public static async Task<DataTable> GetAllVehicleMaintenanceAsync(int vehicleID)
        {
            return await clsMaintenance_DA.GetAllVehicleMaintenanceAsync(vehicleID);
        }

        public static async Task<bool> DeleteMaintenanceAsync(int maintenanceID)
        {
            return await clsMaintenance_DA.DeleteMaintenanceAsync(maintenanceID);
        }

        public static async Task<clsMaintenance> GetLastVehicleMaintenanceDataAsync(int vehicleID)
        {
            MaintenanceDTO dto = await clsMaintenance_DA.GetLastVehicleMaintenanceDataAsync(vehicleID);

            if (dto == null)
                return null;

            return new clsMaintenance(dto.MaintenanceID, dto.VehicleID, dto.Description, dto.MaintenanceDate, dto.Cost);

        }
        public static async Task<DateTime?> GetLastVehicleMaintenanceDateAsync(int vehicleID)
        {
            return await clsMaintenance_DA.GetLastVehicleMaintenanceDateAsync(vehicleID);
        }

    }
}
