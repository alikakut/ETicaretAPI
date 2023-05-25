using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Application.Orders.Queries.GetOrder
{
    public record OrderQueryResult(
    int CurrentPage,
    int PageSize,
    int TotalPageCount,
    int TotalRowCount,
    List<Order> Data);
}
