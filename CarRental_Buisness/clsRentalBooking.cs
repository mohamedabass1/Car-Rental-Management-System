using CarRental_DataAccess;
using CarRental_DTO;
using System;
using System.Data;
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
        public string DropOffLocation { get; set; }
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
            DropOffLocation = "";
            RentalPricePerDay = 0;
            InitialTotalDueAmount = 0;
            InitialCheckNotes = "";

            _Mode = enMode.AddNew;
        }

        private clsRentalBooking(int BookingID, int CustomerID, int VehicleID, DateTime RentalStartDate, DateTime RentalEndDate,
                                string PickupLocation, string DropoffLocation, byte InitialRentalDays, decimal RentalPricePerDay,
                                decimal InitialTotalDueAmount, string InitialCheckNotes)
        {
            this.BookingID = BookingID;
            this.CustomerID = CustomerID;
            this.VehicleID = VehicleID;
            this.RentalStartDate = RentalStartDate;
            this.RentalEndDate = RentalEndDate;
            this.PickupLocation = PickupLocation;
            this.DropOffLocation = DropoffLocation;
            this.InitialRentalDays = InitialRentalDays;
            this.RentalPricePerDay = RentalPricePerDay;
            this.InitialTotalDueAmount = InitialTotalDueAmount;
            this.InitialCheckNotes = InitialCheckNotes;

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
                DropOffLocation = this.DropOffLocation,
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

            clsRentalBooking booking = new clsRentalBooking(dto.BookingID, dto.CustomerID, dto.VehicleID, dto.RentalStartDate, dto.RentalEndDate,
                                                            dto.PickupLocation, dto.DropOffLocation, dto.InitialRentalDays,
                                                            dto.RentalPricePerDay, dto.InitialTotalDueAmount, dto.InitialCheckNotes);

            booking.CustomerInfo = await clsCustomer.FindByIDAsync(booking.CustomerID);
            booking.VehicleInfo = await clsVehicle.FindByIDAsync(booking.VehicleID);

            return booking;

        }

        public static async Task<bool> DeleteAsync(int bookingID)
        {
            return await clsRentalBooking_DA.DeleteRentalBookingAsync(bookingID);
        }

        public static async Task<bool> ExistsAsync(int bookingID)
        {
            return await clsRentalBooking_DA.IsRentalBookingExistsAsync(bookingID);
        }

        public static async Task<DataTable> GetAllAsync()
        {
            return await clsRentalBooking_DA.GetAllRentalBookingsAsync();
        }

        public static async Task<DataTable> GetCustomerHistoryAsync(int customerID)
        {
            return await clsRentalBooking_DA.GetCustomerBookingHistoryAsync(customerID);
        }

        public static async Task<DataTable> GetVehicleHistoryAsync(int vehicleID)
        {
            return await clsRentalBooking_DA.GetVehicleBookingHistoryAsync(vehicleID);
        }

        public async Task<clsVehicleReturn> VehicleReturn(DateTime ActualReturnDate, short CurrentMileage, string FinalCheckNotes, decimal AdditionalCharges)
        {

            clsRentalTransaction transaction = await clsRentalTransaction.FindByBookingIDAsync(this.BookingID);

            if (transaction == null)
                return null;


            clsVehicleReturn vehicleReturn = new clsVehicleReturn();

            byte ActualRentDays = (byte)((ActualReturnDate - this.RentalStartDate).Days + 1);

            decimal ActualTotalDueAmount = (ActualRentDays * this.RentalPricePerDay) + AdditionalCharges;
            short ConsumedMileage = Convert.ToInt16(CurrentMileage - this.VehicleInfo.Mileage);



            vehicleReturn.ActualReturnDate = ActualReturnDate;
            vehicleReturn.Mileage = CurrentMileage;
            vehicleReturn.ActualRentalDays = ActualRentDays;
            vehicleReturn.ConsumedMileage = ConsumedMileage;
            vehicleReturn.ActualTotalDueAmount = ActualTotalDueAmount;
            vehicleReturn.FinalCheckNotes = FinalCheckNotes;
            vehicleReturn.AdditionalCharges = AdditionalCharges;


            if (!await vehicleReturn.SaveAsync())
                return null;



            transaction.ReturnID = vehicleReturn.ReturnID;
            transaction.ActualTotalDueAmount = ActualTotalDueAmount;

            if (ActualTotalDueAmount > this.InitialTotalDueAmount)
            {
                transaction.TotalRemaining = ActualTotalDueAmount - this.InitialTotalDueAmount;
            }
            else if (ActualTotalDueAmount < this.InitialTotalDueAmount)
            {
                transaction.TotalRefundedAmount = this.InitialTotalDueAmount - ActualTotalDueAmount;
            }

            transaction.UpdatedTransactionDate = DateTime.Now;

            if (!await transaction.SaveAsync())
            {
                await clsVehicleReturn.DeleteAsync(vehicleReturn.ReturnID);
                return null;
            }




            await clsVehicleReturn.DeleteAsync(vehicleReturn.ReturnID);
            return null;
        }
    }
}
