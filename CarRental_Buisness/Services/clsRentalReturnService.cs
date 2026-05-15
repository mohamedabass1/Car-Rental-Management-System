using CarRental_DataAccess;
using CarRental_DTO;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace CarRental_Buisness.Services
{
    public class clsRentalReturnService
    {
        /// <summary>
        /// Completes the full vehicle return workflow:
        /// 1. Validate return data.
        /// 2. Create vehicle return record.
        /// 3. Update rental transaction.
        /// 4. Update vehicle status and mileage.
        /// 
        /// All operations are executed inside a single SQL transaction
        /// to guarantee atomicity and data consistency.
        /// </summary>
        public static async Task<int> CompleteRentalReturnAsync(clsRentalBooking booking, DateTime actualReturnDate,
                                                    short currentMileage, string finalCheckNotes, decimal additionalCharges)
        {

            // Validation
            if (actualReturnDate < booking.RentalStartDate)
                return -1;

            if (currentMileage < booking.VehicleInfo.Mileage)
                return -1;

            // Load Transaction
            clsRentalTransaction rentalTransaction = await clsRentalTransaction.FindByBookingIDAsync(booking.BookingID);

            if (rentalTransaction == null)
                return -1;



            using (SqlConnection dbConnection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                await dbConnection.OpenAsync();

                // Start atomic database transaction.
                using (SqlTransaction dbTransaction = dbConnection.BeginTransaction())
                {
                    byte actualRentDays = CalculateActualRentalDays(booking.RentalStartDate, actualReturnDate);

                    decimal actualTotalDueAmount = CalculateActualTotalDueAmount(actualRentDays, booking.RentalPricePerDay, additionalCharges);

                    decimal remaining = 0;
                    decimal refund = 0;

                    CalculateRefundOrRemaining(booking.InitialTotalDueAmount, actualTotalDueAmount, out remaining, out refund);

                    short consumedMileage = Convert.ToInt16(currentMileage - booking.VehicleInfo.Mileage);

                    VehicleReturnDTO vehicleReturnDTO = new VehicleReturnDTO
                    {
                        ActualReturnDate = actualReturnDate,
                        ActualRentalDays = actualRentDays,
                        ActualTotalDueAmount = actualTotalDueAmount,
                        Mileage = currentMileage,
                        ConsumedMileage = consumedMileage,
                        FinalCheckNotes = finalCheckNotes,
                        AdditionalCharges = additionalCharges
                    };
                    int VehicleReturnID = await clsVehicleReturn_DA.AddNewVehicleReturnAsync(vehicleReturnDTO, dbConnection, dbTransaction);

                    // if the oration failed rollback
                    if (VehicleReturnID == -1)
                    {
                        dbTransaction.Rollback();
                        return -1;
                    }

                    rentalTransaction.ReturnID = VehicleReturnID;
                    rentalTransaction.ActualTotalDueAmount = actualTotalDueAmount;
                    rentalTransaction.TotalRemaining = remaining;
                    rentalTransaction.TotalRefundedAmount = refund;
                    rentalTransaction.UpdatedTransactionDate = DateTime.Now;



                    // Update rental transaction.
                    bool isTransactionUpdated = await clsRentalTransaction_DA.
                                                UpdateRentalTransactionAsync(rentalTransaction._ToDTO(), dbConnection, dbTransaction);

                    if (!isTransactionUpdated)
                    {
                        dbTransaction.Rollback();
                        return -1;
                    }


                    // Update vehicle availability and mileage.
                    bool isVehicleUpdated = await clsVehicle_DA.SetAvailableAsync(booking.VehicleID, currentMileage, dbConnection, dbTransaction);


                    if (!isVehicleUpdated)
                    {
                        dbTransaction.Rollback();
                        return -1;
                    }


                    // Commit all database operations.
                    dbTransaction.Commit();

                    return VehicleReturnID;

                }
            }

        }

        // Calculates actual rental days.
        private static byte CalculateActualRentalDays(DateTime rentalStartDate, DateTime actualReturnDate)
        {

            return (byte)((actualReturnDate - rentalStartDate).Days + 1);
        }

        private static decimal CalculateActualTotalDueAmount(byte actualRentDays, decimal rentalPricePerDay, decimal additionalCharges)
        {
            return (actualRentDays * rentalPricePerDay) + additionalCharges;
        }

        private static void CalculateRefundOrRemaining(decimal paidInitialAmount, decimal actualTotalDueAmount, out decimal remaining, out decimal refund)
        {
            remaining = 0;
            refund = 0;

            if (actualTotalDueAmount > paidInitialAmount)
            {
                remaining = actualTotalDueAmount - paidInitialAmount;
            }
            else if (paidInitialAmount > actualTotalDueAmount)
            {
                refund = paidInitialAmount - actualTotalDueAmount;
            }
        }
    }
}
