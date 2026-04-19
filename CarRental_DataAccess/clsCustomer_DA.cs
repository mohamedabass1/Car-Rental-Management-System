using CarRental_DTO;
using CarRental_Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace CarRental_DataAccess
{
    public class clsCustomer_DA
    {
        public static async Task<int> AddNewCustomerAsync(CustomerDTO customer)
        {
            int newCustomerID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Customers.SP_AddNewCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", customer.PersonID);
                command.Parameters.AddWithValue("@DriverLicenseNumber", customer.DriverLicenseNumber);

                SqlParameter outputParam = new SqlParameter("@NewCustomerID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(outputParam);

                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();

                    newCustomerID = (int)outputParam.Value;
                }
                catch (Exception ex)
                {

                    newCustomerID = -1;
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }

            }

            return newCustomerID;
        }

        public static async Task<CustomerDTO> GetCustomerByIDAsync(int customerID)
        {
            CustomerDTO customer = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Customers.SP_GetCustomerByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            customer = new CustomerDTO
                            {
                                CustomerID = (int)reader["CustomerID"],
                                PersonID = (int)reader["PersonID"],
                                DriverLicenseNumber = (string)reader["DriverLicenseNumber"]
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }


            return customer;
        }

        public static async Task<CustomerDTO> GetCustomerByLicenseAsync(string licenseNumber)
        {
            CustomerDTO customer = null;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Customers.SP_GetCustomerByDriverLicenseNumber", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DriverLicenseNumber", licenseNumber);

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            customer = new CustomerDTO
                            {
                                CustomerID = (int)reader["CustomerID"],
                                PersonID = (int)reader["PersonID"],
                                DriverLicenseNumber = (string)reader["DriverLicenseNumber"]
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }

            return customer;
        }

        public static async Task<DataTable> GetAllCustomersAsync()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Customers.SP_GetAllCustomers", connection))
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

        public static async Task<DataTable> ListCustomersPagedAsync(int PageNumber, int RowsPerPage)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Customers.SP_ListCustomersPaged", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PageNumber", PageNumber);
                command.Parameters.AddWithValue("@RowsPerPage", RowsPerPage);

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

        public static async Task<bool> UpdateCustomerAsync(CustomerDTO customer)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Customers.SP_UpdateCustomerInfo", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                command.Parameters.AddWithValue("@PersonID", customer.PersonID);
                command.Parameters.AddWithValue("@DriverLicenseNumber", customer.DriverLicenseNumber);

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

        public static async Task<bool> DeleteCustomerAsync(int customerID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Customers.SP_DeleteCustomer", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);

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

        public static async Task<bool> IsCustomerExistsAsync(int customerID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Customers.SP_CheckCustomerExistsByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerID);

                try
                {
                    await connection.OpenAsync();

                    object result = await command.ExecuteScalarAsync();
                    isFound = (result != null);
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                    isFound = false;
                }
            }

            return isFound;
        }

        public static async Task<bool> IsCustomerExistsByLicenseAsync(string licenseNumber)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Customers.SP_CheckCustomerExistsByDriverLicenseNumber", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DriverLicenseNumber", licenseNumber);

                try
                {
                    await connection.OpenAsync();

                    object result = await command.ExecuteScalarAsync();
                    isFound = (result != null);
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                    isFound = false;
                }
            }

            return isFound;
        }
    }
}
