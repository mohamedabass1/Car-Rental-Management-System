using CarRental_DataAccess;
using CarRental_DTO;
using System.Data;
using System.Threading.Tasks;

namespace CarRental_Buisness
{
    public class clsCustomer
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;
        public int CustomerID { get; set; }
        public int PersonID { get; set; }

        public clsPerson PersonInfo;

        public string DriverLicenseNumber { get; set; }

        public clsCustomer()
        {
            CustomerID = -1;
            PersonID = -1;
            DriverLicenseNumber = "";
            PersonInfo = new clsPerson();
            _Mode = enMode.AddNew;
        }


        private clsCustomer(int CustomerID, int PersonID, string DriverLicenseNumber)
        {
            this.CustomerID = CustomerID;
            this.PersonID = PersonID;


            this.DriverLicenseNumber = DriverLicenseNumber;
            _Mode = enMode.Update;
        }

        private async Task<bool> _AddNewAsync()
        {
            CustomerDTO customer = new CustomerDTO
            {
                PersonID = this.PersonID,
                DriverLicenseNumber = this.DriverLicenseNumber
            };

            this.CustomerID = await clsCustomer_DA.AddNewCustomerAsync(customer);

            return this.CustomerID != -1;
        }

        private async Task<bool> _UpdateAsync()
        {
            CustomerDTO customer = new CustomerDTO
            {
                CustomerID = this.CustomerID,
                PersonID = this.PersonID,
                DriverLicenseNumber = this.DriverLicenseNumber
            };

            return await clsCustomer_DA.UpdateCustomerAsync(customer);
        }

        public async Task<bool> SaveAsync()
        {
            if (!await PersonInfo.SaveAsync())
            {
                return false;
            }

            this.PersonID = PersonInfo.PersonID;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewAsync())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return await _UpdateAsync();
            }
            return false;
        }

        public static async Task<clsCustomer> FindByIDAsync(int customerID)
        {
            CustomerDTO customer = await clsCustomer_DA.GetCustomerByIDAsync(customerID);

            if (customer != null)
            {
                clsCustomer newCus = new clsCustomer(customer.CustomerID, customer.PersonID, customer.DriverLicenseNumber);

                // load person info
                newCus.PersonInfo = await clsPerson.FindAsync(customer.PersonID);

                return newCus;
            }
            else
                return null;
        }

        public static async Task<clsCustomer> FindByDriverLicenseNumberAsync(string DriverLicenseNumber)
        {
            CustomerDTO customer = await clsCustomer_DA.GetCustomerByLicenseAsync(DriverLicenseNumber);

            if (customer != null)
            {
                clsCustomer newCus = new clsCustomer(customer.CustomerID, customer.PersonID, customer.DriverLicenseNumber);

                // load person info
                newCus.PersonInfo = await clsPerson.FindAsync(customer.PersonID);

                return newCus;
            }
            else
                return null;

        }

        public static async Task<bool> DeleteCustomerAsync(int customerID)
        {
            return await clsCustomer_DA.DeleteCustomerAsync(customerID);
        }

        public static async Task<bool> IsCustomerExistsAsync(int customerID)
        {
            return await clsCustomer_DA.IsCustomerExistsAsync(customerID);
        }

        public static async Task<bool> IsCustomerExistsAsync(string DriverLicenseNumber)
        {
            return await clsCustomer_DA.IsCustomerExistsByLicenseAsync(DriverLicenseNumber);
        }

        public static async Task<DataTable> ListCustomersPaged(int PageNumber, int RowsPerPage)
        {
            return await clsCustomer_DA.ListCustomersPaged(PageNumber, RowsPerPage);
        }

        public static async Task<DataTable> GetAllCustomersAsync()
        {
            return await clsCustomer_DA.GetAllCustomersAsync();
        }
    }


}
