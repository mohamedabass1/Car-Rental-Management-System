using CarRentalSystem.DTO;
using CarRentalSystem.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace CarRentalSystem.DataAccess
{
    public class clsFuelType_DA
    {
        public static async Task<int> AddNewFuelTypeAsync(FuelTypeDTO fuelType)
        {
            int newFuelTypeID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("FuelType.SP_AddFuelType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FuelTypeName", fuelType.FuelTypeName);

                SqlParameter outputParam = new SqlParameter("@NewFuelTypeID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(outputParam);

                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();

                    newFuelTypeID = (int)outputParam.Value;
                }
                catch (Exception ex)
                {
                    newFuelTypeID = -1;
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return newFuelTypeID;
        }

        public static async Task<FuelTypeDTO> GetFuelTypeByIDAsync(int fuelTypeID)
        {
            FuelTypeDTO fuelType = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("FuelType.SP_GetFuelTypeByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            fuelType = new FuelTypeDTO
                            {
                                FuelTypeID = (int)reader["FuelTypeID"],
                                FuelTypeName = (string)reader["FuelTypeName"]
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return fuelType;
        }

        public static async Task<FuelTypeDTO> GetFuelTypeByNameAsync(string fuelTypeName)
        {
            FuelTypeDTO fuelType = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("FuelType.SP_GetFuelTypeByName", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FuelTypeName", fuelTypeName);

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            fuelType = new FuelTypeDTO
                            {
                                FuelTypeID = (int)reader["FuelTypeID"],
                                FuelTypeName = (string)reader["FuelTypeName"]
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return fuelType;
        }
        public static async Task<DataTable> GetAllFuelTypesAsync()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("FuelType.SP_GetAllFuelTypes", connection))
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
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return dt;
        }

        public static async Task<bool> UpdateFuelTypeAsync(FuelTypeDTO fuelType)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("FuelType.SP_UpdateFuelType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FuelTypeID", fuelType.FuelTypeID);
                command.Parameters.AddWithValue("@FuelTypeName", fuelType.FuelTypeName);

                try
                {
                    await connection.OpenAsync();
                    rowsAffected = await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                    rowsAffected = 0;
                }
            }

            return rowsAffected > 0;
        }

        public static async Task<bool> DeleteFuelTypeAsync(int fuelTypeID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("FuelType.SP_DeleteFuelType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FuelTypeID", fuelTypeID);

                try
                {
                    await connection.OpenAsync();
                    rowsAffected = await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                    rowsAffected = 0;
                }
            }

            return rowsAffected > 0;
        }

    }
}
