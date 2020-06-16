using SchoolHRM.Service.Shared;
using System.Collections.Generic;

namespace SchoolHRM.Service.WebAPI.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
