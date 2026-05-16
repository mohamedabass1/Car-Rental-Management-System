using CarRental_DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsRentalTransaction_DA
    {
        public static async Task<int> AddNewRentalTransactionAsync(RentalTransactionDTO transaction)
        {
            int newTransactionID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Transactions.SP_AddNewRentalTransaction", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@BookingID", transaction.BookingID);
                command.Parameters.AddWithValue("@PaymentDetails", transaction.PaymentDetails);
                command.Parameters.AddWithValue("@PaidInitialTotalDueAmount", transaction.PaidInitialTotalDueAmount);

                SqlParameter outputParam = new SqlParameter("@NewTransactionID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(outputParam);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                newTransactionID = (int)outputParam.Value;
            }

            return newTransactionID;
        }

        public static async Task<bool> UpdateRentalTransactionAsync(RentalTransactionDTO transaction)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Transactions.SP_UpdateRentalTransaction", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TransactionID", transaction.TransactionID);

                command.Parameters.AddWithValue("@ReturnID",
                    transaction.ReturnID.HasValue ? (object)transaction.ReturnID : DBNull.Value);

                command.Parameters.AddWithValue("@ActualTotalDueAmount",
                    transaction.ActualTotalDueAmount.HasValue ? (object)transaction.ActualTotalDueAmount : DBNull.Value);

                command.Parameters.AddWithValue("@TotalRemaining",
                    transaction.TotalRemaining.HasValue ? (object)transaction.TotalRemaining : DBNull.Value);

                command.Parameters.AddWithValue("@TotalRefundedAmount",
                    transaction.TotalRefundedAmount.HasValue ? (object)transaction.TotalRefundedAmount : DBNull.Value);

                command.Parameters.AddWithValue("@UpdatedTransactionDate",
                   transaction.UpdatedTransactionDate.HasValue ? (object)transaction.UpdatedTransactionDate : DBNull.Value);

                await connection.OpenAsync();
                rowsAffected = await command.ExecuteNonQueryAsync();
            }

            return rowsAffected > 0;
        }

        public static async Task<bool> UpdateRentalTransactionAsync(RentalTransactionDTO transaction, SqlConnection dbConnection, SqlTransaction dbTransaction)
        {
            int rowsAffected = 0;

            using (SqlCommand command = new SqlCommand("Transactions.SP_UpdateRentalTransaction", dbConnection, dbTransaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TransactionID", transaction.TransactionID);

                command.Parameters.AddWithValue("@ReturnID",
                    transaction.ReturnID.HasValue ? (object)transaction.ReturnID : DBNull.Value);

                command.Parameters.AddWithValue("@ActualTotalDueAmount",
                    transaction.ActualTotalDueAmount.HasValue ? (object)transaction.ActualTotalDueAmount : DBNull.Value);

                command.Parameters.AddWithValue("@TotalRemaining",
                    transaction.TotalRemaining.HasValue ? (object)transaction.TotalRemaining : DBNull.Value);

                command.Parameters.AddWithValue("@TotalRefundedAmount",
                    transaction.TotalRefundedAmount.HasValue ? (object)transaction.TotalRefundedAmount : DBNull.Value);

                command.Parameters.AddWithValue("@UpdatedTransactionDate",
                   transaction.UpdatedTransactionDate.HasValue ? (object)transaction.UpdatedTransactionDate : DBNull.Value);

                rowsAffected = await command.ExecuteNonQueryAsync();
            }

            return rowsAffected > 0;
        }

        public static async Task<bool> DeleteRentalTransactionAsync(int transactionID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Transactions.SP_DeleteRentalTransaction", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TransactionID", transactionID);

                await connection.OpenAsync();
                rowsAffected = await command.ExecuteNonQueryAsync();
            }

            return rowsAffected > 0;
        }

        public static async Task<RentalTransactionDTO> GetRentalTransactionByIDAsync(int transactionID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Transactions.SP_GetRentalTransactionByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TransactionID", transactionID);

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new RentalTransactionDTO
                        {
                            TransactionID = (int)reader["TransactionID"],
                            BookingID = (int)reader["BookingID"],

                            ReturnID = reader["ReturnID"] == DBNull.Value ? (int?)null : (int)reader["ReturnID"],
                            PaymentDetails = (string)reader["PaymentDetails"],

                            PaidInitialTotalDueAmount = (decimal)reader["PaidInitialTotalDueAmount"],

                            ActualTotalDueAmount = reader["ActualTotalDueAmount"] == DBNull.Value ? (decimal?)null : (decimal)reader["ActualTotalDueAmount"],
                            TotalRemaining = reader["TotalRemaining"] == DBNull.Value ? (decimal?)null : (decimal)reader["TotalRemaining"],
                            TotalRefundedAmount = reader["TotalRefundedAmount"] == DBNull.Value ? (decimal?)null : (decimal)reader["TotalRefundedAmount"],

                            TransactionDate = (DateTime)reader["TransactionDate"],
                            UpdatedTransactionDate = reader["UpdatedTransactionDate"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["UpdatedTransactionDate"]
                        };
                    }
                }
            }

            return null;
        }

        public static async Task<DataTable> GetAllRentalTransactionsAsync()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Transactions.SP_GetAllRentalTransactions", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
            }

            return dt;
        }

        public static async Task<RentalTransactionDTO> GetTransactionByBookingIDAsync(int bookingID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Transactions.SP_GetTransactionByBookingID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookingID", bookingID);

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new RentalTransactionDTO
                        {
                            TransactionID = (int)reader["TransactionID"],
                            BookingID = (int)reader["BookingID"],

                            ReturnID = reader["ReturnID"] == DBNull.Value ? (int?)null : (int)reader["ReturnID"],
                            PaymentDetails = (string)reader["PaymentDetails"],

                            PaidInitialTotalDueAmount = (decimal)reader["PaidInitialTotalDueAmount"],

                            ActualTotalDueAmount = reader["ActualTotalDueAmount"] == DBNull.Value ? (decimal?)null : (decimal)reader["ActualTotalDueAmount"],
                            TotalRemaining = reader["TotalRemaining"] == DBNull.Value ? (decimal?)null : (decimal)reader["TotalRemaining"],
                            TotalRefundedAmount = reader["TotalRefundedAmount"] == DBNull.Value ? (decimal?)null : (decimal)reader["TotalRefundedAmount"],

                            TransactionDate = (DateTime)reader["TransactionDate"],
                            UpdatedTransactionDate = reader["UpdatedTransactionDate"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["UpdatedTransactionDate"]
                        };
                    }
                }
            }

            return null;
        }

        public static async Task<RentalTransactionDTO> GetTransactionByReturnIDIDAsync(int ReturnID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Transactions.SP_GetTransactionByReturnID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ReturnID", ReturnID);

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new RentalTransactionDTO
                        {
                            TransactionID = (int)reader["TransactionID"],
                            BookingID = (int)reader["BookingID"],

                            ReturnID = reader["ReturnID"] == DBNull.Value ? (int?)null : (int)reader["ReturnID"],
                            PaymentDetails = (string)reader["PaymentDetails"],

                            PaidInitialTotalDueAmount = (decimal)reader["PaidInitialTotalDueAmount"],

                            ActualTotalDueAmount = reader["ActualTotalDueAmount"] == DBNull.Value ? (decimal?)null : (decimal)reader["ActualTotalDueAmount"],
                            TotalRemaining = reader["TotalRemaining"] == DBNull.Value ? (decimal?)null : (decimal)reader["TotalRemaining"],
                            TotalRefundedAmount = reader["TotalRefundedAmount"] == DBNull.Value ? (decimal?)null : (decimal)reader["TotalRefundedAmount"],

                            TransactionDate = (DateTime)reader["TransactionDate"],
                            UpdatedTransactionDate = reader["UpdatedTransactionDate"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["UpdatedTransactionDate"]
                        };
                    }
                }
            }

            return null;
        }


        public static async Task<bool> IsRentalTransactionExistsAsync(int transactionID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Transactions.SP_CheckRentalTransactionExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TransactionID", transactionID);

                await connection.OpenAsync();

                object result = await command.ExecuteScalarAsync();
                isFound = (result != null);
            }

            return isFound;
        }

        public static async Task<bool> IsBookingReturnedAsync(int BookingID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Transactions.SP_IsBookingReturned", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookingID", BookingID);

                await connection.OpenAsync();

                object result = await command.ExecuteScalarAsync();
                isFound = (result != null);
            }

            return isFound;
        }

    }
}
