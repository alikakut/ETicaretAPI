﻿using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Application.Orders.Queries.GetOrder
{
    public record OrderQueryResultt(
    int CurrentPage,
    int PageSize,
    int TotalPageCount,
    int TotalRowCount,
    List<Order> Data);
}
