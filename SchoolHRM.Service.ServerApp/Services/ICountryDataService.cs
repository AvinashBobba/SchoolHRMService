using SchoolHRM.Service.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolHRM.Service.ServerApp.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
