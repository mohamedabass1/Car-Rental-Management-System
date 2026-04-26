using CarRental_DTO;
using CarRental_Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsMaintenance_DA
    {
        public static async Task<int> AddNewMaintenanceAsync(MaintenanceDTO maintenance)
        {
            int newID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Maintenance.SP_AddNewMaintenance", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@VehicleID", maintenance.VehicleID);

                    if (string.IsNullOrWhiteSpace(maintenance.Description))
                        command.Parameters.AddWithValue("@Description", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Description", maintenance.Description);

                    command.Parameters.AddWithValue("@MaintenanceDate", maintenance.MaintenanceDate);

                    command.Parameters.AddWithValue("@Cost", maintenance.Cost);

                    SqlParameter outputParam = new SqlParameter("@NewMaintenanceID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(outputParam);

                    try
                    {
                        await connection.OpenAsync();
                        await command.ExecuteNonQueryAsync();
                        newID = (int)outputParam.Value;
                    }
                    catch (Exception ex)
                    {
                        clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                        newID = -1;
                    }
                }
            }

            return newID;
        }

        public static async Task<MaintenanceDTO> GetMaintenanceByIDAsync(int maintenanceID)
        {
            MaintenanceDTO maintenance = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Maintenance.SP_GetMaintenanceByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaintenanceID", maintenanceID);

                    try
                    {
                        await connection.OpenAsync();

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                maintenance = new MaintenanceDTO
                                {
                                    MaintenanceID = (int)reader["MaintenanceID"],
                                    VehicleID = (int)reader["VehicleID"],
                                    Description = reader["Description"] == DBNull.Value ? "" : (string)reader["Description"],
                                    MaintenanceDate = (DateTime)reader["MaintenanceDate"],
                                    Cost = reader["Cost"] == DBNull.Value ? 0 : (decimal)reader["Cost"]
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }

            return maintenance;
        }

        public static async Task<DataTable> GetAllMaintenanceAsync()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Maintenance.SP_GetAllMaintenance", connection))
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

        public static async Task<DataTable> GetAllVehicleMaintenanceAsync(int vehicleID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Maintenance.SP_GetAllVehicleMaintenance", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VehicleID", vehicleID);

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

        public static async Task<bool> UpdateMaintenanceAsync(MaintenanceDTO maintenance)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Maintenance.SP_UpdateMaintenance", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaintenanceID", maintenance.MaintenanceID);
                command.Parameters.AddWithValue("@VehicleID", maintenance.VehicleID);

                if (string.IsNullOrWhiteSpace(maintenance.Description))
                    command.Parameters.AddWithValue("@Description", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Description", maintenance.Description);

                command.Parameters.AddWithValue("@MaintenanceDate", maintenance.MaintenanceDate);

                if (maintenance.Cost == 0)
                    command.Parameters.AddWithValue("@Cost", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Cost", maintenance.Cost);

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
        public static async Task<bool> DeleteMaintenanceAsync(int maintenanceID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Maintenance.SP_DeleteMaintenance", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaintenanceID", maintenanceID);

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

        public static async Task<MaintenanceDTO> GetLastVehicleMaintenanceDataAsync(int vehicleID)
        {
            MaintenanceDTO maintenance = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Maintenance.SP_GetLastVehicleMaintenanceData", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VehicleID", vehicleID);

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            maintenance = new MaintenanceDTO
                            {
                                MaintenanceID = (int)reader["MaintenanceID"],
                                VehicleID = (int)reader["VehicleID"],
                                Description = reader["Description"] == DBNull.Value ? "" : (string)reader["Description"],
                                MaintenanceDate = (DateTime)reader["MaintenanceDate"],
                                Cost = reader["Cost"] == DBNull.Value ? 0 : (decimal)reader["Cost"]
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return maintenance;
        }

        public static async Task<DateTime?> GetLastVehicleMaintenanceDateAsync(int vehicleID)
        {
            DateTime? lastDate = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Maintenance.SP_GetLastVehicleMaintenanceDate", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VehicleID", vehicleID);

                try
                {
                    await connection.OpenAsync();

                    object result = await command.ExecuteScalarAsync();

                    if (result != null && result != DBNull.Value)
                        lastDate = (DateTime)result;
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                    lastDate = null;
                }
            }

            return lastDate;
        }
    }
}
