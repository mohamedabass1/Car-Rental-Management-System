using CarRental_DataAccess;
using CarRental_DTO;
using System.Data;
using System.Threading.Tasks;

namespace CarRental_Buisness
{
    public class clsCountry
    {

        public int ID { set; get; }
        public string CountryName { set; get; }

        public clsCountry()

        {
            this.ID = -1;
            this.CountryName = "";

        }

        private clsCountry(int ID, string CountryName)

        {
            this.ID = ID;
            this.CountryName = CountryName;
        }


        public static async Task<clsCountry> FindAsync(int ID)
        {
            CountryDTO country = await clsCountryData.GetCountryByIDAsync(ID);

            if (country != null)
            {
                return new clsCountry(country.CountryID, country.CountryName);
            }
            else
                return null;

        }


        public static async Task<clsCountry> FindAsync(string CountryName)
        {
            CountryDTO country = await clsCountryData.GetCountryByNameAsync(CountryName);

            if (country != null)
            {
                return new clsCountry(country.CountryID, country.CountryName);
            }
            else
                return null;

        }

        public static async Task<DataTable> GetAllCountriesAsync()
        {
            return await clsCountryData.GetAllCountriesAsync();
        }





    }
}
