﻿using AutoMapper;
using HotelListing.API.Data;
using HotelListion.API.Core.Contracts;

namespace HotelListion.API.Core.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

    }
}
