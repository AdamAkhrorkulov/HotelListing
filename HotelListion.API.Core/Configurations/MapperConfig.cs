using AutoMapper;
using HotelListing.API.Data;
using HotelListion.API.Core.Models.Country;
using HotelListion.API.Core.Models.Hotel;
using HotelListion.API.Core.Models.Users;

namespace HotelListion.API.Core.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();

            CreateMap<ApiUserDto, ApiUser>().ReverseMap();
        }
    }
}
