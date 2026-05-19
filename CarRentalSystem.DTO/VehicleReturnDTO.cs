using System;

namespace CarRentalSystem.DTO
{
    public class VehicleReturnDTO
    {
        public int ReturnID { get; set; }

        public DateTime ActualReturnDate { get; set; }

        public byte ActualRentalDays { get; set; }

        public short Mileage { get; set; }

        public short ConsumedMileage { get; set; }

        public string FinalCheckNotes { get; set; }

        public decimal AdditionalCharges { get; set; }

        public decimal ActualTotalDueAmount { get; set; }
    }
}