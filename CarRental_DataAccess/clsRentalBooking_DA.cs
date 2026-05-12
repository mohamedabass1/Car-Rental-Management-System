using CarRental_DTO;
using CarRental_Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsRentalBooking_DA
    {
        public static async Task<int> AddNewRentalBookingAsync(RentalBookingDTO booking)
        {
            int newBookingID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("RentalBooking.SP_AddNewRentalBooking", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CustomerID", booking.CustomerID);
                command.Parameters.AddWithValue("@VehicleID", booking.VehicleID);
                command.Parameters.AddWithValue("@RentalStartDate", booking.RentalStartDate);
                command.Parameters.AddWithValue("@RentalEndDate", booking.RentalEndDate);
                command.Parameters.AddWithValue("@PickupLocation", booking.PickupLocation);
                command.Parameters.AddWithValue("@DropoffLocation", booking.DropOffLocation);
                command.Parameters.AddWithValue("@RentalPricePerDay", booking.RentalPricePerDay);
                command.Parameters.AddWithValue("@InitialTotalDueAmount", booking.InitialTotalDueAmount);

                if (string.IsNullOrWhiteSpace(booking.InitialCheckNotes))
                    command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@InitialCheckNotes", booking.InitialCheckNotes);

                SqlParameter outputParam = new SqlParameter("@NewBookingID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(outputParam);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                newBookingID = (int)outputParam.Value;
            }

            return newBookingID;
        }
        public static async Task<bool> UpdateRentalBookingAsync(RentalBookingDTO booking)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("RentalBooking.SP_UpdateRentalBooking", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@BookingID", booking.BookingID);
                command.Parameters.AddWithValue("@CustomerID", booking.CustomerID);
                command.Parameters.AddWithValue("@VehicleID", booking.VehicleID);
                command.Parameters.AddWithValue("@RentalStartDate", booking.RentalStartDate);
                command.Parameters.AddWithValue("@RentalEndDate", booking.RentalEndDate);
                command.Parameters.AddWithValue("@PickupLocation", booking.PickupLocation);
                command.Parameters.AddWithValue("@DropoffLocation", booking.DropOffLocation);
                command.Parameters.AddWithValue("@RentalPricePerDay", booking.RentalPricePerDay);
                command.Parameters.AddWithValue("@InitialTotalDueAmount", booking.InitialTotalDueAmount);

                if (string.IsNullOrWhiteSpace(booking.InitialCheckNotes))
                    command.Parameters.AddWithValue("@InitialCheckNotes", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@InitialCheckNotes", booking.InitialCheckNotes);

                await connection.OpenAsync();
                rowsAffected = await command.ExecuteNonQueryAsync();
            }

            return rowsAffected > 0;
        }

        public static async Task<RentalBookingDTO> GetRentalBookingByIDAsync(int bookingID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("RentalBooking.SP_GetRentalBookingByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookingID", bookingID);

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new RentalBookingDTO
                        {
                            BookingID = (int)reader["BookingID"],
                            CustomerID = (int)reader["CustomerID"],
                            VehicleID = (int)reader["VehicleID"],
                            RentalStartDate = (DateTime)reader["RentalStartDate"],
                            RentalEndDate = (DateTime)reader["RentalEndDate"],
                            PickupLocation = (string)reader["PickupLocation"],
                            DropOffLocation = (string)reader["DropoffLocation"],
                            InitialRentalDays = (byte)reader["InitialRentalDays"],
                            RentalPricePerDay = (decimal)reader["RentalPricePerDay"],
                            InitialTotalDueAmount = (decimal)reader["InitialTotalDueAmount"],
                            InitialCheckNotes = reader["InitialCheckNotes"] == DBNull.Value ? "" : (string)reader["InitialCheckNotes"]
                        };
                    }
                }
            }

            return null;
        }

        public static async Task<DataTable> GetAllRentalBookingsAsync()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("RentalBooking.SP_GetAllRentalBookings", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {

                    clsEventLogger.Log(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                }

            }

            return dt;
        }

        public static async Task<bool> DeleteRentalBookingAsync(int bookingID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("RentalBooking.SP_DeleteRentalBooking", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookingID", bookingID);

                await connection.OpenAsync();
                rowsAffected = await command.ExecuteNonQueryAsync();
            }

            return rowsAffected > 0;
        }

        public static async Task<bool> IsRentalBookingExistsAsync(int bookingID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("RentalBooking.SP_CheckRentalBookingExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookingID", bookingID);

                await connection.OpenAsync();

                object result = await command.ExecuteScalarAsync();
                isFound = (result != null);
            }

            return isFound;
        }

        public static async Task<DataTable> GetCustomerBookingHistoryAsync(int customerID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("RentalBooking.SP_GetCustomerBookingHistory", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
            }

            return dt;
        }

        public static async Task<DataTable> GetVehicleBookingHistoryAsync(int vehicleID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("RentalBooking.SP_GetVehicleBookingHistory", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VehicleID", vehicleID);

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
            }

            return dt;
        }
    }
}
