using CarRentalSystem.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRentalSystem.DataAccess
{
    public class clsCountryData
    {

        public static async Task<CountryDTO> GetCountryByIDAsync(int ID)
        {
            CountryDTO country;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Countries WHERE CountryID = @CountryID", connection))
                {
                    command.Parameters.AddWithValue("@CountryID", ID);

                    try
                    {
                        await connection.OpenAsync();

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                country = new CountryDTO
                                {
                                    CountryID = (int)reader["CountryID"],
                                    CountryName = (string)reader["CountryName"]
                                };

                                return country;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return null;
        }

        public static CountryDTO GetCountryByID(int ID)
        {
            CountryDTO country;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Countries WHERE CountryID = @CountryID", connection))
                {
                    command.Parameters.AddWithValue("@CountryID", ID);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                country = new CountryDTO
                                {
                                    CountryID = (int)reader["CountryID"],
                                    CountryName = (string)reader["CountryName"]
                                };

                                return country;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return null;
        }

        public static async Task<CountryDTO> GetCountryByNameAsync(string CountryName)
        {
            CountryDTO country;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Countries WHERE CountryName = @CountryName", connection))
                {
                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        await connection.OpenAsync();

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                country = new CountryDTO
                                {
                                    CountryID = (int)reader["CountryID"],
                                    CountryName = (string)reader["CountryName"]
                                };

                                return country;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return null; ;
        }

        public static CountryDTO GetCountryByName(string CountryName)
        {
            CountryDTO country;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Countries WHERE CountryName = @CountryName", connection))
                {
                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                country = new CountryDTO
                                {
                                    CountryID = (int)reader["CountryID"],
                                    CountryName = (string)reader["CountryName"]
                                };

                                return country;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return null; ;
        }

        public static async Task<DataTable> GetAllCountriesAsync()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Countries ORDER BY CountryName", connection))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return dt;
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Countries ORDER BY CountryName", connection))
            {
                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return dt;
        }

    }


}
