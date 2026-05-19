using CarRental_DTO;
using CarRental_Utilities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_DataAccess
{
    public class clsPerson_DA
    {
        /*
          PersonID,
    FirstName,
    SecondName,
    LastName,
    DateOfBirth,
    Gendor,
    Address,
    Phone,
    Email,
    NationalityCountryID
         
         */

        public static async Task<int> AddNewPersonAsync(PersonDTO Person)
        {
            int NewPersonID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("People.SP_AddNewPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", Person.FirstName);

                    if (string.IsNullOrWhiteSpace(Person.SecondName))
                        command.Parameters.AddWithValue("@SecondName", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@SecondName", Person.SecondName);


                    command.Parameters.AddWithValue("@LastName", Person.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", Person.DateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", Person.Gendor);
                    command.Parameters.AddWithValue("@Address", Person.Address);
                    command.Parameters.AddWithValue("@Phone", Person.Phone);

                    if (string.IsNullOrWhiteSpace(Person.Email))
                        command.Parameters.AddWithValue("@Email", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Email", Person.Email);

                    command.Parameters.AddWithValue("@NationalityCountryID", Person.NationalityCountryID);


                    SqlParameter outputPersonIDParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(outputPersonIDParam);

                    // Open connection and execute the command
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                    NewPersonID = (int)outputPersonIDParam.Value;

                }

            }
            return NewPersonID;
        }
        public static async Task<int> AddNewPersonAsync(PersonDTO Person, SqlConnection connection, SqlTransaction dbTransaction)
        {
            int NewPersonID = -1;

            using (SqlCommand command = new SqlCommand("People.SP_AddNewPerson", connection, dbTransaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", Person.FirstName);

                if (string.IsNullOrWhiteSpace(Person.SecondName))
                    command.Parameters.AddWithValue("@SecondName", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@SecondName", Person.SecondName);


                command.Parameters.AddWithValue("@LastName", Person.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", Person.DateOfBirth);
                command.Parameters.AddWithValue("@Gendor", Person.Gendor);
                command.Parameters.AddWithValue("@Address", Person.Address);
                command.Parameters.AddWithValue("@Phone", Person.Phone);

                if (string.IsNullOrWhiteSpace(Person.Email))
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Email", Person.Email);

                command.Parameters.AddWithValue("@NationalityCountryID", Person.NationalityCountryID);


                SqlParameter outputPersonIDParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                command.Parameters.Add(outputPersonIDParam);


                await command.ExecuteNonQueryAsync();
                NewPersonID = (int)outputPersonIDParam.Value;

            }

            return NewPersonID;
        }

        public static async Task<PersonDTO> GetPersonByIDAsync(int PersonID)
        {
            PersonDTO person1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("People.SP_GetPersonByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        // Open connection and execute the command
                        await connection.OpenAsync();
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                person1 = new PersonDTO
                                {
                                    PersonID = (int)reader["PersonID"],
                                    FirstName = (string)reader["FirstName"],
                                    SecondName = (reader["SecondName"] == DBNull.Value) ? "" : (string)reader["SecondName"],
                                    LastName = (string)reader["LastName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Gendor = (byte)reader["Gendor"],
                                    Address = (string)reader["Address"],
                                    Phone = (string)reader["Phone"],

                                    Email = (reader["Email"] == DBNull.Value) ? "" : (string)reader["Email"],
                                    NationalityCountryID = (int)reader["NationalityCountryID"],
                                };

                                return person1;
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);


                    }
                }
            }

            return null;
        }

        public static DataTable GetAllPeople()
        {
            DataTable dtPeople = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("People.GetAllPeople", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtPeople.Load(reader);
                    }
                }

            }

            return dtPeople;
        }
        public static async Task<DataTable> GetAllPeopleAsync()
        {
            DataTable dtPeople = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("People.GetAllPeople", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        dtPeople.Load(reader);
                    }
                }

            }
            return dtPeople;
        }

        public static async Task<bool> DeletePersonAsync(int PersonID)
        {
            int rowAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("People.SP_DeletePerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    await connection.OpenAsync();
                    rowAffected = await command.ExecuteNonQueryAsync();

                }
                catch (Exception ex)
                {
                    rowAffected = 0;
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }
            return rowAffected > 0;
        }


        public static async Task<bool> IsPersonExistsAsync(int PeronID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("People.SP_CheckPersonExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", PeronID);

                try
                {
                    await connection.OpenAsync();

                    object result = await command.ExecuteScalarAsync();

                    // if the person dose not exists the the result will be null
                    isFound = (result != null);

                }
                catch (Exception ex)
                {
                    isFound = false;
                    throw;
                }
            }

            return isFound;
        }


        public static async Task<bool> UpdatePersonAsync(PersonDTO person)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("People.SP_UpdatePersonInfo", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", person.PersonID);
                command.Parameters.AddWithValue("@FirstName", person.FirstName);

                if (string.IsNullOrWhiteSpace(person.SecondName))
                    command.Parameters.AddWithValue("@SecondName", DBNull.Value);
                else
                    command.Parameters.AddWithValue("@SecondName", person.SecondName);


                command.Parameters.AddWithValue("@LastName", person.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
                command.Parameters.AddWithValue("@Gendor", person.Gendor);

                command.Parameters.AddWithValue("@Address", person.Address);
                command.Parameters.AddWithValue("@Phone", person.Phone);

                if (string.IsNullOrWhiteSpace(person.Email))
                    command.Parameters.AddWithValue("@Email", System.DBNull.Value);
                else
                    command.Parameters.AddWithValue("@Email", person.Email);

                command.Parameters.AddWithValue("@NationalityCountryID", person.NationalityCountryID);


                try
                {
                    await connection.OpenAsync();
                    rowsAffected = await command.ExecuteNonQueryAsync();

                }
                catch (Exception ex)
                {
                    rowsAffected = 0;
                    clsEventLogger.Log($"DataBase Exception {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                }
            }
            return rowsAffected > 0;
        }


    }
}
