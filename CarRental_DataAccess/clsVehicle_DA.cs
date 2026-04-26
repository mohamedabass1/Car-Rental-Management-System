using CarRental_DTO;
using CarRental_Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsVehicle_DA
    {

        public static async Task<int> AddNewVehicleAsync(VehicleDTO vehicle)
        {
            int newID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Vehicle.SP_AddVehicle", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Make", vehicle.Make);
                command.Parameters.AddWithValue("@Model", vehicle.Model);
                command.Parameters.AddWithValue("@Years", vehicle.Years);
                command.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
                command.Parameters.AddWithValue("@FuelTypeID", vehicle.FuelTypeID);
                command.Parameters.AddWithValue("@PlateNumber", vehicle.PlateNumber);
                command.Parameters.AddWithValue("@CarCategoryID", vehicle.CarCategoryID);
                command.Parameters.AddWithValue("@RentalPricePerDay", vehicle.RentalPricePerDay);
                command.Parameters.AddWithValue("@IsAvailableForRent", vehicle.IsAvailableForRent);

                SqlParameter output = new SqlParameter("@NewVehicleID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(output);

                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                    newID = (int)output.Value;
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return newID;
        }

        public static async Task<VehicleDTO> GetVehicleByIDAsync(int id)
        {
            VehicleDTO v = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Vehicle.SP_GetVehicleByID", connection))
            {
                command.Parameters.AddWithValue("@VehicleID", id);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            v = new VehicleDTO
                            {
                                VehicleID = (int)reader["VehicleID"],
                                Make = (string)reader["Make"],
                                Model = (string)reader["Model"],
                                Years = (int)reader["Years"],
                                Mileage = (int)reader["Mileage"],
                                FuelTypeID = (int)reader["FuelTypeID"],
                                PlateNumber = (string)reader["PlateNumber"],
                                CarCategoryID = (int)reader["CarCategoryID"],
                                RentalPricePerDay = (decimal)reader["RentalPricePerDay"],
                                IsAvailableForRent = (bool)reader["IsAvailableForRent"]
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return v;
        }

        public static async Task<DataTable> GetAllVehiclesAsync()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Vehicle.SP_GetAllVehicles", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader r = await command.ExecuteReaderAsync())
                    {
                        if (r.HasRows)
                            dt.Load(r);
                    }
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return dt;
        }

        public static async Task<DataTable> ListVehiclesPagedAsync(int PageNumber, int RowsPerPage)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Vehicle.SP_ListVehiclesPaged", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader r = await command.ExecuteReaderAsync())
                    {
                        if (r.HasRows)
                            dt.Load(r);
                    }
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return dt;
        }

        public static async Task<bool> UpdateVehicleAsync(VehicleDTO vehicle)
        {
            int rows = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Vehicle.SP_UpdateVehicle", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@VehicleID", vehicle.VehicleID);
                command.Parameters.AddWithValue("@Make", vehicle.Make);
                command.Parameters.AddWithValue("@Model", vehicle.Model);
                command.Parameters.AddWithValue("@Years", vehicle.Years);
                command.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
                command.Parameters.AddWithValue("@FuelTypeID", vehicle.FuelTypeID);
                command.Parameters.AddWithValue("@PlateNumber", vehicle.PlateNumber);
                command.Parameters.AddWithValue("@CarCategoryID", vehicle.CarCategoryID);
                command.Parameters.AddWithValue("@RentalPricePerDay", vehicle.RentalPricePerDay);
                command.Parameters.AddWithValue("@IsAvailableForRent", vehicle.IsAvailableForRent);

                try
                {
                    await connection.OpenAsync();
                    rows = await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return rows > 0;
        }

        public static async Task<bool> DeleteVehicleAsync(int id)
        {
            int rows = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Vehicle.SP_DeleteVehicle", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VehicleID", id);

                try
                {
                    await connection.OpenAsync();
                    rows = await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return rows > 0;
        }

        public static async Task<bool> IsVehicleExistsByPlateNumber(string PlateNumber)
        {
            bool isExists = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Vehicle.SP_CheckVehicleExistsByPlateNumber", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PlateNumber", PlateNumber);

                try
                {
                    await connection.OpenAsync();

                    object result = await command.ExecuteScalarAsync();

                    isExists = (result != null);

                }
                catch (Exception ex)
                {
                    isExists = false;
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return isExists;
        }
    }
}
