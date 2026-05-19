using System;

namespace CarRentalSystem.DTO
{
    public class RentalTransactionDTO
    {
        public int TransactionID { get; set; }

        public int BookingID { get; set; }

        public int? ReturnID { get; set; }

        public string PaymentDetails { get; set; }

        public decimal PaidInitialTotalDueAmount { get; set; }

        public decimal? ActualTotalDueAmount { get; set; }

        public decimal? TotalRemaining { get; set; }

        public decimal? TotalRefundedAmount { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateTime? UpdatedTransactionDate { get; set; }
    }
}
