using CarRentalSystem.DTO;
using CarRentalSystem.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRentalSystem.DataAccess
{
    public class clsUser_DA
    {

        public static async Task<int> AddNewUserAsync(UserDTO user)
        {
            int newUserID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Users.SP_AddNewUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", user.PersonID);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Permissions", user.Permissions);
                command.Parameters.AddWithValue("@JoinDate", user.JoinDate);

                if (string.IsNullOrWhiteSpace(user.ImagePath))
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ImagePath", user.ImagePath);

                command.Parameters.AddWithValue("@IsActive", user.IsActive);

                SqlParameter outputParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(outputParam);

                try
                {
                    await connection.OpenAsync();

                    await command.ExecuteNonQueryAsync();

                    newUserID = (int)outputParam.Value;
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log("Database Exception: " + ex.Message,
                        System.Diagnostics.EventLogEntryType.Error);

                    throw;
                }
            }

            return newUserID;
        }

        public static async Task<int> AddNewUserAsync(UserDTO user, SqlConnection connection, SqlTransaction dbTransaction)
        {
            int newUserID = -1;

            using (SqlCommand command = new SqlCommand("Users.SP_AddNewUser", connection, dbTransaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", user.PersonID);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Permissions", user.Permissions);
                command.Parameters.AddWithValue("@JoinDate", user.JoinDate);

                if (string.IsNullOrWhiteSpace(user.ImagePath))
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ImagePath", user.ImagePath);

                command.Parameters.AddWithValue("@IsActive", user.IsActive);

                SqlParameter outputParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(outputParam);

                try
                {

                    await command.ExecuteNonQueryAsync();

                    newUserID = (int)outputParam.Value;
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log("Database Exception: " + ex.Message,
                        System.Diagnostics.EventLogEntryType.Error);

                    throw;
                }
            }

            return newUserID;
        }

        public static async Task<bool> UpdateUserAsync(UserDTO user)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Users.SP_UpdateUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", user.UserID);
                command.Parameters.AddWithValue("@PersonID", user.PersonID);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Permissions", user.Permissions);
                command.Parameters.AddWithValue("@JoinDate", user.JoinDate);

                if (string.IsNullOrWhiteSpace(user.ImagePath))
                    command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@ImagePath", user.ImagePath);

                command.Parameters.AddWithValue("@IsActive", user.IsActive);

                try
                {
                    await connection.OpenAsync();

                    rowsAffected = await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log("Database Exception: " + ex.Message,
                        System.Diagnostics.EventLogEntryType.Error);

                    throw;
                }
            }

            return rowsAffected > 0;
        }


        public static async Task<bool> DeleteUserAsync(int userID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Users.SP_DeleteUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    await connection.OpenAsync();

                    rowsAffected = await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log("Database Exception: " + ex.Message,
                        System.Diagnostics.EventLogEntryType.Error);

                    throw;
                }
            }

            return rowsAffected > 0;
        }

        public static async Task<UserDTO> GetUserByIDAsync(int userID)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Users.SP_GetUserByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new UserDTO
                            {
                                UserID = (int)reader["UserID"],
                                PersonID = (int)reader["PersonID"],
                                Username = (string)reader["Username"],
                                Password = (string)reader["Password"],
                                Permissions = (int)reader["Permissions"],
                                JoinDate = (DateTime)reader["JoinDate"],

                                ImagePath =
                                reader["ImagePath"] == DBNull.Value ?
                                "" : (string)reader["ImagePath"],

                                IsActive = (bool)reader["IsActive"]
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log("Database Exception: " + ex.Message,
                        System.Diagnostics.EventLogEntryType.Error);

                    throw;
                }
            }

            return null;
        }


        public static async Task<UserDTO> GetUserByUsernameAsync(string username)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Users.SP_GetUserByUsername", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return new UserDTO
                            {
                                UserID = (int)reader["UserID"],
                                PersonID = (int)reader["PersonID"],
                                Username = (string)reader["Username"],
                                Password = (string)reader["Password"],
                                Permissions = (int)reader["Permissions"],
                                JoinDate = (DateTime)reader["JoinDate"],

                                ImagePath =
                                reader["ImagePath"] == DBNull.Value ?
                                "" : (string)reader["ImagePath"],

                                IsActive = (bool)reader["IsActive"]
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log("Database Exception: " + ex.Message,
                        System.Diagnostics.EventLogEntryType.Error);

                    throw;
                }
            }

            return null;
        }

        public static async Task<DataTable> GetAllUsersAsync()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Users.SP_GetAllUsers", connection))
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
                    clsEventLogger.Log("Database Exception: " + ex.Message,
                        System.Diagnostics.EventLogEntryType.Error);

                    throw;
                }
            }

            return dt;
        }


        public static async Task<bool> IsUserExistsAsync(int userID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Users.SP_CheckUserExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    await connection.OpenAsync();

                    object result = await command.ExecuteScalarAsync();

                    isFound = (result != null);
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log("Database Exception: " + ex.Message,
                        System.Diagnostics.EventLogEntryType.Error);

                    throw;
                }
            }

            return isFound;
        }
        public static async Task<bool> IsUserExistsAsync(string userName)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("Users.SP_CheckIsUserExistsByUsername", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Username", userName);

                try
                {
                    await connection.OpenAsync();

                    object result = await command.ExecuteScalarAsync();

                    isFound = (result != null);
                }
                catch (Exception ex)
                {
                    clsEventLogger.Log("Database Exception: " + ex.Message,
                        System.Diagnostics.EventLogEntryType.Error);

                    throw;
                }
            }

            return isFound;
        }
    }
}