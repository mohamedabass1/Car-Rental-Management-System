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

        internal CustomerDTO ToDTO()
        {
            return new CustomerDTO { CustomerID = this.CustomerID, PersonID = this.PersonID, DriverLicenseNumber = this.DriverLicenseNumber };
        }

        private async Task<bool> _AddNewAsync()
        {

            this.CustomerID = await clsCustomer_DA.AddNewCustomerAsync(this.ToDTO());

            return this.CustomerID != -1;
        }

        private async Task<bool> _UpdateAsync()
        {
            return await clsCustomer_DA.UpdateCustomerAsync(this.ToDTO());
        }
        public void MarkAsSaved()
        {
            _Mode = enMode.Update;
        }

        public async Task<bool> SaveAsync()
        {


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

            if (customer == null)
                return null;


            clsCustomer newCus = new clsCustomer(customer.CustomerID,
                                                  customer.PersonID,
                                                  customer.DriverLicenseNumber);

            // load person info Async
            newCus.PersonInfo = await clsPerson.FindAsync(customer.PersonID);

            return newCus;
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

        public static async Task<DataTable> ListCustomersPagedAsync(int PageNumber, int RowsPerPage)
        {
            return await clsCustomer_DA.ListCustomersPagedAsync(PageNumber, RowsPerPage);
        }

        public static async Task<DataTable> GetAllCustomersAsync()
        {
            return await clsCustomer_DA.GetAllCustomersAsync();
        }

        public static async Task<int> GetCustomersCountAsync()
        {
            return await clsCustomer_DA.GetCustomersCountAsync();
        }
    }


}
