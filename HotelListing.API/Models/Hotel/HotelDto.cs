using System.ComponentModel.DataAnnotations.Schema;
using static HotelListing.API.Models.Hotel.HotelDto;

namespace HotelListing.API.Models.Hotel
{
    public class HotelDto : BaseHotelDto
    {
        public int Id { get; set; }

    }
}
