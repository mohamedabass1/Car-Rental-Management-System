using CarRentalSystem.DataAccess;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CarRentalSystem.Business.Services
{
    public class clsUserRegistrationService
    {
        /// <summary>
        /// Registers a new system user and creates
        /// the related person record inside a single
        /// atomic database transaction.
        /// </summary>
        /// <param name="user">
        /// User business object that contains
        /// both user info and person info.
        /// </param>
        /// <returns>
        /// Returns the newly created UserID.
        /// Returns -1 if the registration fails.
        /// </returns>
        public static async Task<int> RegisterUserAsync(clsUser user)
        {
            int newUserID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
            {
                await connection.OpenAsync();

                using (SqlTransaction dbTransaction = connection.BeginTransaction())
                {
                    try
                    {
                        user.PersonID = await clsPerson_DA.AddNewPersonAsync(user.PersonInfo.ToDTO(),
                                                                            connection, dbTransaction);

                        if (user.PersonID == -1)
                        {
                            dbTransaction.Rollback();
                            return -1;
                        }

                        newUserID = await clsUser_DA.AddNewUserAsync(user.ToDTO(), connection, dbTransaction);

                        if (newUserID == -1)
                        {
                            dbTransaction.Rollback();
                            return -1;
                        }

                        // Mark User As Saved Set user mode to update mode
                        user.MarkAsSaved();
                        user.UserID = newUserID;


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
            return newUserID;
        }
    }
}
