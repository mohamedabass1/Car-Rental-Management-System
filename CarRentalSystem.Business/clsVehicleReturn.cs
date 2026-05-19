using CarRentalSystem.DataAccess;
using CarRentalSystem.DTO;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CarRentalSystem.Business
{
    public class clsVehicleReturn
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int ReturnID { get; set; }

        public DateTime ActualReturnDate { get; set; }

        public byte ActualRentalDays { get; set; }

        public short Mileage { get; set; }

        public short ConsumedMileage { get; set; }

        public string FinalCheckNotes { get; set; }

        public decimal AdditionalCharges { get; set; }

        public decimal ActualTotalDueAmount { get; set; }

        public clsVehicleReturn()
        {
            ReturnID = -1;
            ActualReturnDate = DateTime.Now;
            ActualRentalDays = 0;
            Mileage = 0;
            ConsumedMileage = 0;
            FinalCheckNotes = string.Empty;
            AdditionalCharges = 0;
            ActualTotalDueAmount = 0;

            _Mode = enMode.AddNew;
        }

        private clsVehicleReturn(
            int returnID,
            DateTime actualReturnDate,
            byte actualRentalDays,
            short mileage,
            short consumedMileage,
            string finalCheckNotes,
            decimal additionalCharges,
            decimal actualTotalDueAmount)
        {
            ReturnID = returnID;
            ActualReturnDate = actualReturnDate;
            ActualRentalDays = actualRentalDays;
            Mileage = mileage;
            ConsumedMileage = consumedMileage;
            FinalCheckNotes = finalCheckNotes;
            AdditionalCharges = additionalCharges;
            ActualTotalDueAmount = actualTotalDueAmount;

            _Mode = enMode.Update;
        }

        // 🔹 Convert To DTO
        private VehicleReturnDTO _ToDTO()
        {
            return new VehicleReturnDTO
            {
                ReturnID = this.ReturnID,

                ActualReturnDate = this.ActualReturnDate,

                ActualRentalDays = this.ActualRentalDays,

                Mileage = this.Mileage,

                ConsumedMileage = this.ConsumedMileage,

                FinalCheckNotes = this.FinalCheckNotes,

                AdditionalCharges = this.AdditionalCharges,

                ActualTotalDueAmount = this.ActualTotalDueAmount
            };
        }

        private async Task<bool> _AddNewAsync()
        {
            this.ReturnID =
                await clsVehicleReturn_DA
                .AddNewVehicleReturnAsync(this._ToDTO());

            return this.ReturnID != -1;
        }

        private async Task<bool> _UpdateAsync()
        {
            return await clsVehicleReturn_DA
                .UpdateVehicleReturnAsync(this._ToDTO());
        }

        public async Task<bool> SaveAsync()
        {
            //  Simple Validation

            if (ActualRentalDays <= 0)
                return false;

            if (Mileage < 0)
                return false;

            if (ConsumedMileage < 0)
                return false;

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

        public static async Task<clsVehicleReturn> FindByIDAsync(int returnID)
        {
            VehicleReturnDTO dto =
                await clsVehicleReturn_DA
                .GetVehicleReturnByIDAsync(returnID);

            if (dto == null)
                return null;

            return new clsVehicleReturn(
                dto.ReturnID,
                dto.ActualReturnDate,
                dto.ActualRentalDays,
                dto.Mileage,
                dto.ConsumedMileage,
                dto.FinalCheckNotes,
                dto.AdditionalCharges,
                dto.ActualTotalDueAmount
            );
        }

        public static async Task<bool> DeleteAsync(int returnID)
        {
            return await clsVehicleReturn_DA.DeleteVehicleReturnAsync(returnID);
        }

        public static async Task<bool> IsExistsAsync(int returnID)
        {
            return await clsVehicleReturn_DA.IsVehicleReturnExistsAsync(returnID);
        }

        public static async Task<DataTable> GetAllAsync()
        {
            return await clsVehicleReturn_DA.GetAllVehicleReturnsAsync();
        }
    }
}