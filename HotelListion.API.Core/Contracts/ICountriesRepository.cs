using HotelListing.API.Data;
using HotelListion.API.Core.Models.Country;

namespace HotelListion.API.Core.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}
