using HotelListion.API.Core.Models.Hotel;

namespace HotelListion.API.Core.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }

        public List<HotelDto> Hotels { get; set; }
    }
}
