using CarRental_DataAccess;
using CarRental_DTO;
using System;
using System.Data;
using System.Threading.Tasks;

namespace CarRental_Buisness
{
    public class clsPerson
    {
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + LastName; }
        }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public clsCountry CountryInfo;



        public clsPerson()

        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            _Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string FirstName, string SecondName,
            string LastName, DateTime DateOfBirth, short Gendor,
             string Address, string Phone, string Email,
            int NationalityCountryID)

        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;


            _Mode = enMode.Update;
        }


        public PersonDTO ToDTO()
        {
            return new PersonDTO
            {
                PersonID = this.PersonID,
                FirstName = this.FirstName,
                SecondName = this.SecondName,
                LastName = this.LastName,
                DateOfBirth = DateOfBirth,
                Gendor = this.Gendor,
                Address = this.Address,
                Phone = this.Phone,
                Email = this.Email,
                NationalityCountryID = this.NationalityCountryID,
            };
        }
        private async Task<bool> _AddNewPersonAsync()
        {
            this.PersonID = await clsPerson_DA.AddNewPersonAsync(this.ToDTO());

            return (this.PersonID != -1);
        }
        private async Task<bool> _UpdateAsync()
        {
            return await clsPerson_DA.UpdatePersonAsync(this.ToDTO());
        }

        public static async Task<clsPerson> FindAsync(int PersonID)
        {
            PersonDTO dto = await clsPerson_DA.GetPersonByIDAsync(PersonID);

            if (dto == null)
                return null;


            clsPerson Person = new clsPerson(dto.PersonID, dto.FirstName, dto.SecondName, dto.LastName, dto.DateOfBirth, dto.Gendor
                , dto.Address, dto.Phone, dto.Email, dto.NationalityCountryID);

            // load person info Async
            Person.CountryInfo = await clsCountry.FindAsync(Person.NationalityCountryID);

            return Person;

        }
        public async Task<bool> SaveAsync()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (await _AddNewPersonAsync())
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

        public static async Task<bool> DeletePersonAsync(int PersonID)
        {
            return await clsPerson_DA.DeletePersonAsync(PersonID);
        }

        public static async Task<bool> IsPersonExistsAsync(int PeronID)
        {
            return await clsPerson_DA.IsPersonExistsAsync(PeronID);
        }

        public static async Task<DataTable> GetAllPeopleAsync()
        {
            return await clsPerson_DA.GetAllPeopleAsync();
        }
    }
}
