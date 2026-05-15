using CarRental_DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsVehicleReturn_DA
    {
        public static async Task<int> AddNewVehicleReturnAsync(VehicleReturnDTO vehicleReturnDTO)
        {
            int newReturnID = -1;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSetting.ConnectionString))

            using (SqlCommand command =
                new SqlCommand("Returns.SP_AddNewVehicleReturn", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ActualReturnDate",
                    vehicleReturnDTO.ActualReturnDate);

                command.Parameters.AddWithValue("@ActualRentalDays",
                    vehicleReturnDTO.ActualRentalDays);

                command.Parameters.AddWithValue("@Mileage",
                    vehicleReturnDTO.Mileage);

                command.Parameters.AddWithValue("@ConsumedMileage",
                    vehicleReturnDTO.ConsumedMileage);

                if (string.IsNullOrWhiteSpace(vehicleReturnDTO.FinalCheckNotes))
                    command.Parameters.AddWithValue("@FinalCheckNotes", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@FinalCheckNotes",
                        vehicleReturnDTO.FinalCheckNotes);

                command.Parameters.AddWithValue("@AdditionalCharges",
                    vehicleReturnDTO.AdditionalCharges);

                command.Parameters.AddWithValue("@ActualTotalDueAmount",
                    vehicleReturnDTO.ActualTotalDueAmount);

                SqlParameter outputParam =
                    new SqlParameter("@NewReturnID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                command.Parameters.Add(outputParam);

                await connection.OpenAsync();

                await command.ExecuteNonQueryAsync();

                newReturnID = (int)outputParam.Value;
            }

            return newReturnID;
        }

        public static async Task<int> AddNewVehicleReturnAsync(VehicleReturnDTO vehicleReturnDTO, SqlConnection dbConnection, SqlTransaction dbTransaction)
        {
            int newReturnID = -1;



            using (SqlCommand command = new SqlCommand("Returns.SP_AddNewVehicleReturn", dbConnection, dbTransaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ActualReturnDate",
                    vehicleReturnDTO.ActualReturnDate);

                command.Parameters.AddWithValue("@ActualRentalDays",
                    vehicleReturnDTO.ActualRentalDays);

                command.Parameters.AddWithValue("@Mileage",
                    vehicleReturnDTO.Mileage);

                command.Parameters.AddWithValue("@ConsumedMileage", vehicleReturnDTO.ConsumedMileage);

                if (string.IsNullOrWhiteSpace(vehicleReturnDTO.FinalCheckNotes))
                    command.Parameters.AddWithValue("@FinalCheckNotes", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@FinalCheckNotes", vehicleReturnDTO.FinalCheckNotes);

                command.Parameters.AddWithValue("@AdditionalCharges",
                    vehicleReturnDTO.AdditionalCharges);

                command.Parameters.AddWithValue("@ActualTotalDueAmount",
                    vehicleReturnDTO.ActualTotalDueAmount);

                SqlParameter outputParam =
                    new SqlParameter("@NewReturnID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                command.Parameters.Add(outputParam);


                await command.ExecuteNonQueryAsync();

                newReturnID = (int)outputParam.Value;
            }

            return newReturnID;
        }


        public static async Task<bool> UpdateVehicleReturnAsync(
            VehicleReturnDTO vehicleReturn)
        {
            int rowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSetting.ConnectionString))

            using (SqlCommand command =
                new SqlCommand("Returns.SP_UpdateVehicleReturn", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ReturnID",
                    vehicleReturn.ReturnID);

                command.Parameters.AddWithValue("@ActualReturnDate",
                    vehicleReturn.ActualReturnDate);

                command.Parameters.AddWithValue("@ActualRentalDays",
                    vehicleReturn.ActualRentalDays);

                command.Parameters.AddWithValue("@Mileage",
                    vehicleReturn.Mileage);

                command.Parameters.AddWithValue("@ConsumedMileage",
                    vehicleReturn.ConsumedMileage);

                if (string.IsNullOrWhiteSpace(vehicleReturn.FinalCheckNotes))
                    command.Parameters.AddWithValue("@FinalCheckNotes", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@FinalCheckNotes",
                        vehicleReturn.FinalCheckNotes);

                command.Parameters.AddWithValue("@AdditionalCharges",
                    vehicleReturn.AdditionalCharges);

                command.Parameters.AddWithValue("@ActualTotalDueAmount",
                    vehicleReturn.ActualTotalDueAmount);

                await connection.OpenAsync();

                rowsAffected = await command.ExecuteNonQueryAsync();
            }

            return rowsAffected > 0;
        }

        public static async Task<bool> DeleteVehicleReturnAsync(int returnID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSetting.ConnectionString))

            using (SqlCommand command =
                new SqlCommand("Returns.SP_DeleteVehicleReturn", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ReturnID", returnID);

                await connection.OpenAsync();

                rowsAffected = await command.ExecuteNonQueryAsync();
            }

            return rowsAffected > 0;
        }

        public static async Task<VehicleReturnDTO> GetVehicleReturnByIDAsync(int returnID)
        {
            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSetting.ConnectionString))

            using (SqlCommand command =
                new SqlCommand("Returns.SP_GetVehicleReturnByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ReturnID", returnID);

                await connection.OpenAsync();

                using (SqlDataReader reader =
                    await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new VehicleReturnDTO
                        {
                            ReturnID = (int)reader["ReturnID"],

                            ActualReturnDate =
                                (DateTime)reader["ActualReturnDate"],

                            ActualRentalDays =
                                (byte)reader["ActualRentalDays"],

                            Mileage =
                                (short)reader["Mileage"],

                            ConsumedMileage =
                                (short)reader["ConsumedMileage"],

                            FinalCheckNotes =
                                reader["FinalCheckNotes"] == DBNull.Value ?
                                "" :
                                (string)reader["FinalCheckNotes"],

                            AdditionalCharges =
                                (decimal)reader["AdditionalCharges"],

                            ActualTotalDueAmount =
                                (decimal)reader["ActualTotalDueAmount"]
                        };
                    }
                }
            }

            return null;
        }

        public static async Task<DataTable> GetAllVehicleReturnsAsync()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSetting.ConnectionString))

            using (SqlCommand command =
                new SqlCommand("Returns.SP_GetAllVehicleReturns", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                await connection.OpenAsync();

                using (SqlDataReader reader =
                    await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                        dt.Load(reader);
                }
            }

            return dt;
        }

        public static async Task<bool> IsVehicleReturnExistsAsync(int returnID)
        {
            bool isFound = false;

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSetting.ConnectionString))

            using (SqlCommand command =
                new SqlCommand("Returns.SP_CheckVehicleReturnExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ReturnID", returnID);

                await connection.OpenAsync();

                object result = await command.ExecuteScalarAsync();

                isFound = (result != null);
            }

            return isFound;
        }
    }
}