using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Application.Products.Queries
{
    public record ProductQueryResult(
    int CurrentPage,
    int PageSize,
    int TotalPageCount,
    int TotalRowCount,
    List<Product> Data);

}
