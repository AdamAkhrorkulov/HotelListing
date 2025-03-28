﻿namespace HotelListion.API.Core.Models;

public class PagedResult<T>
{
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int RecordNumber { get; set; }
    public List<T> Item { get; set; }
}