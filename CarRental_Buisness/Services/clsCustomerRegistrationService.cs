using CarRental_DataAccess;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRental_Buisness.Services
{
    public class clsCustomerRegistrationService
    {
        /// <summary>
        /// Registers a new customer and creates
        /// the related person record inside a single
        /// atomic database transaction.
        /// </summary>
        /// <param name="customer">
        /// Customer business object that contains
        /// both customer info and person info.
        /// </param>
        /// <returns>
        /// Returns the newly created CustomerID.
        /// Returns -1 if registration fails.
        /// </returns>
        public static async Task<int> RegisterCustomerAsync(clsCustomer customer)
        {
            int newCustomerID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                await connection.OpenAsync();

                using (SqlTransaction dbTransaction = connection.BeginTransaction())
                {
                    try
                    {

                        // Create Person
                        customer.PersonID = await clsPerson_DA.AddNewPersonAsync(customer.PersonInfo.ToDTO(),
                                                                          connection, dbTransaction);

                        if (customer.PersonID == -1)
                        {
                            dbTransaction.Rollback();
                            return -1;
                        }


                        // Create Customer
                        newCustomerID = await clsCustomer_DA.AddNewCustomerAsync(customer.ToDTO(), connection, dbTransaction);

                        if (newCustomerID == -1)
                        {
                            dbTransaction.Rollback();

                            return -1;
                        }



                        // Update customer mode to update mode
                        customer.MarkAsSaved();
                        customer.CustomerID = newCustomerID;


                        // Commit Transaction
                        dbTransaction.Commit();
                    }
                    catch
                    {
                        dbTransaction.Rollback();
                        throw;
                    }
                }
            }
            return newCustomerID;
        }
    }
}