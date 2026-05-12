using CarRental_DataAccess;
using CarRental_DTO;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CarRental_Buisness
{
    public class clsRentalTransaction
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int TransactionID { get; set; }

        public int BookingID { get; set; }
        public clsRentalBooking BookingInfo;

        public int? ReturnID { get; set; }

        public string PaymentDetails { get; set; }

        public decimal PaidInitialTotalDueAmount { get; set; }

        public decimal? ActualTotalDueAmount { get; set; }

        public decimal? TotalRemaining { get; set; }

        public decimal? TotalRefundedAmount { get; set; }

        public DateTime TransactionDate { get; set; }

        public DateTime? UpdatedTransactionDate { get; set; }

        public clsRentalTransaction()
        {
            TransactionID = -1;
            BookingID = -1;
            ReturnID = null;

            PaymentDetails = string.Empty;

            PaidInitialTotalDueAmount = 0;
            ActualTotalDueAmount = null;
            TotalRemaining = null;
            TotalRefundedAmount = null;

            TransactionDate = DateTime.Now;
            UpdatedTransactionDate = null;

            _Mode = enMode.AddNew;
        }

        private clsRentalTransaction(
            int transactionID,
            int bookingID,
            int? returnID,
            string paymentDetails,
            decimal paidInitialTotalDueAmount,
            decimal? actualTotalDueAmount,
            decimal? totalRemaining,
            decimal? totalRefundedAmount,
            DateTime transactionDate,
            DateTime? updatedTransactionDate)
        {
            TransactionID = transactionID;
            BookingID = bookingID;
            ReturnID = returnID;

            PaymentDetails = paymentDetails;

            PaidInitialTotalDueAmount = paidInitialTotalDueAmount;
            ActualTotalDueAmount = actualTotalDueAmount;
            TotalRemaining = totalRemaining;
            TotalRefundedAmount = totalRefundedAmount;

            TransactionDate = transactionDate;
            UpdatedTransactionDate = updatedTransactionDate;

            _Mode = enMode.Update;
        }

        // 🔹 Convert To DTO
        private RentalTransactionDTO _ToDTO()
        {
            return new RentalTransactionDTO
            {
                TransactionID = this.TransactionID,
                BookingID = this.BookingID,
                ReturnID = this.ReturnID,
                PaymentDetails = this.PaymentDetails,
                PaidInitialTotalDueAmount = this.PaidInitialTotalDueAmount,
                ActualTotalDueAmount = this.ActualTotalDueAmount,
                TotalRemaining = this.TotalRemaining,
                TotalRefundedAmount = this.TotalRefundedAmount,
                TransactionDate = this.TransactionDate,
                UpdatedTransactionDate = this.UpdatedTransactionDate
            };
        }

        private async Task<bool> _AddNewAsync()
        {
            this.TransactionID =
                await clsRentalTransaction_DA.AddNewRentalTransactionAsync(this._ToDTO());

            return this.TransactionID != -1;
        }

        private async Task<bool> _UpdateAsync()
        {
            return await clsRentalTransaction_DA
                .UpdateRentalTransactionAsync(this._ToDTO());
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

        public static async Task<clsRentalTransaction> FindByIDAsync(int transactionID)
        {
            RentalTransactionDTO dto =
                await clsRentalTransaction_DA
                .GetRentalTransactionByIDAsync(transactionID);

            if (dto == null)
                return null;

            clsRentalTransaction transaction = new clsRentalTransaction(
                dto.TransactionID,
                dto.BookingID,
                dto.ReturnID,
                dto.PaymentDetails,
                dto.PaidInitialTotalDueAmount,
                dto.ActualTotalDueAmount,
                dto.TotalRemaining,
                dto.TotalRefundedAmount,
                dto.TransactionDate,
                dto.UpdatedTransactionDate
            );

            // load booking info
            transaction.BookingInfo = await clsRentalBooking.FindByIDAsync(transaction.BookingID);


            return transaction;

        }

        // 🔹 Find By BookingID
        public static async Task<clsRentalTransaction> FindByBookingIDAsync(int bookingID)
        {
            RentalTransactionDTO dto =
                await clsRentalTransaction_DA
                .GetTransactionByBookingIDAsync(bookingID);

            if (dto == null)
                return null;

            clsRentalTransaction transaction = new clsRentalTransaction(
                          dto.TransactionID,
                          dto.BookingID,
                          dto.ReturnID,
                          dto.PaymentDetails,
                          dto.PaidInitialTotalDueAmount,
                          dto.ActualTotalDueAmount,
                          dto.TotalRemaining,
                          dto.TotalRefundedAmount,
                          dto.TransactionDate,
                          dto.UpdatedTransactionDate
                      );

            // load booking info
            transaction.BookingInfo = await clsRentalBooking.FindByIDAsync(transaction.BookingID);


            return transaction;
        }

        public static async Task<bool> DeleteAsync(int transactionID)
        {
            return await clsRentalTransaction_DA
                .DeleteRentalTransactionAsync(transactionID);
        }

        public static async Task<bool> IsExistsAsync(int transactionID)
        {
            return await clsRentalTransaction_DA
                .IsRentalTransactionExistsAsync(transactionID);
        }

        public static async Task<DataTable> GetAllAsync()
        {
            return await clsRentalTransaction_DA
                .GetAllRentalTransactionsAsync();
        }
    }
}
