using ErrorOr;
using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Products.Commands.DeleteProduct
{
    public record DeleteProductCommon(long id) : IRequest<ErrorOr<Product>>;
}
