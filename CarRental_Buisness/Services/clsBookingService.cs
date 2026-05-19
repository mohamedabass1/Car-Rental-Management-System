using CarRental_DataAccess;
using CarRental_DTO;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_Buisness.Services
{
    public class clsBookingService
    {


        /// <summary>
        /// Creates a complete rental booking operation
        /// inside a single atomic database transaction.
        /// </summary>
        /// <param name="booking">
        /// Rental booking business object.
        /// </param>
        /// <param name="paymentDetails">
        /// Payment details information.
        /// </param>
        /// <returns>
        /// Returns:
        /// (BookingID, TransactionID)
        /// 
        /// Returns (-1,-1) if operation fails.
        /// </returns>
        static public async Task<(int BookingID, int TransactionID)> CreateRentalBookingAsync(clsRentalBooking booking, string paymentDetails)
        {
            int newBookingID = -1;
            int newTransactionID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                await connection.OpenAsync();

                using (SqlTransaction dbTransaction = connection.BeginTransaction())
                {
                    try
                    {
                        // create new booking
                        newBookingID = await clsRentalBooking_DA.AddNewRentalBookingAsync(booking.ToDTO(), connection, dbTransaction);

                        if (newBookingID == -1)
                        {
                            dbTransaction.Rollback();
                            return (-1, -1);
                        }



                        // update vehicle status
                        bool isVehicleUpdated = await clsVehicle_DA.SetUnavailableAsync(booking.VehicleID, connection, dbTransaction);

                        if (!isVehicleUpdated)
                        {
                            dbTransaction.Rollback();
                            return (-1, -1);
                        }

                        RentalTransactionDTO transactionDTO = new RentalTransactionDTO
                        {
                            BookingID = newBookingID,
                            PaidInitialTotalDueAmount = booking.InitialTotalDueAmount,
                            PaymentDetails = paymentDetails
                        };

                        newTransactionID = await clsRentalTransaction_DA.AddNewRentalTransactionAsync(transactionDTO, connection, dbTransaction);

                        if (newTransactionID == -1)
                        {
                            dbTransaction.Rollback();
                            return (-1, -1);
                        }


                        booking.BookingID = newBookingID;
                        booking.MarkAsSaved();



                        // Commit Transaction
                        dbTransaction.Commit();

                    }
                    catch
                    {
                        dbTransaction.Rollback();
                        throw;
                    }
                }
            }

            return (newBookingID, newTransactionID);
        }

    }
}
