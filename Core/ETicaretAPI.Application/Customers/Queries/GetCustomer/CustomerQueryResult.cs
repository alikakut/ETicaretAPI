using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Application.Customers.Queries.GetCustomer
{
    public record CustomerQueryResult(
    int CurrentPage,
    int PageSize,
    int TotalPageCount,
    int TotalRowCount,
    List<Customer> Data);
}
