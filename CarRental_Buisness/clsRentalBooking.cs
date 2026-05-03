using CarRental_DataAccess;
using CarRental_DTO;
using System;
using System.Threading.Tasks;

namespace CarRental_Buisness
{
    public class clsRentalBooking
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public clsCustomer CustomerInfo;
        public int VehicleID { get; set; }
        public clsVehicle VehicleInfo;
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public byte InitialRentalDays { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public decimal InitialTotalDueAmount { get; set; }
        public string InitialCheckNotes { get; set; }

        public clsRentalBooking()
        {
            BookingID = -1;
            CustomerID = -1;
            VehicleID = -1;
            RentalStartDate = DateTime.Now;
            RentalEndDate = DateTime.Now;
            PickupLocation = "";
            DropoffLocation = "";
            RentalPricePerDay = 0;
            InitialTotalDueAmount = 0;
            InitialCheckNotes = "";

            _Mode = enMode.AddNew;
        }

        private clsRentalBooking(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate,
           string PickupLocation, string DropoffLocation, byte InitialRentalDays, decimal RentalPricePerDay, decimal )
        {
            //BookingID = dto.BookingID;
            //CustomerID = dto.CustomerID;
            //VehicleID = dto.VehicleID;
            //RentalStartDate = dto.RentalStartDate;
            //RentalEndDate = dto.RentalEndDate;
            //PickupLocation = dto.PickupLocation;
            //DropoffLocation = dto.DropoffLocation;
            //InitialRentalDays = dto.InitialRentalDays;
            //RentalPricePerDay = dto.RentalPricePerDay;
            //InitialTotalDueAmount = dto.InitialTotalDueAmount;
            //InitialCheckNotes = dto.InitialCheckNotes;

            _Mode = enMode.Update;
        }
        private RentalBookingDTO _ToDTO()
        {
            return new RentalBookingDTO
            {
                BookingID = this.BookingID,
                CustomerID = this.CustomerID,
                VehicleID = this.VehicleID,
                RentalStartDate = this.RentalStartDate,
                RentalEndDate = this.RentalEndDate,
                PickupLocation = this.PickupLocation,
                DropoffLocation = this.DropoffLocation,
                RentalPricePerDay = this.RentalPricePerDay,
                InitialTotalDueAmount = this.InitialTotalDueAmount,
                InitialCheckNotes = this.InitialCheckNotes
            };
        }

        private async Task<bool> _AddNewAsync()
        {
            this.BookingID = await clsRentalBooking_DA.AddNewRentalBookingAsync(_ToDTO());
            return this.BookingID != -1;
        }

        private async Task<bool> _UpdateAsync()
        {
            return await clsRentalBooking_DA.UpdateRentalBookingAsync(_ToDTO());
        }

        public async Task<bool> SaveAsync()
        {
            // 🔥 Validation مهم
            if (RentalEndDate < RentalStartDate)
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

        public static async Task<clsRentalBooking> FindByIDAsync(int bookingID)
        {
            RentalBookingDTO dto = await clsRentalBooking_DA.GetRentalBookingByIDAsync(bookingID);

            if (dto == null)
                return null;

            //return new clsRentalBooking(dto);
        }


    }
}
