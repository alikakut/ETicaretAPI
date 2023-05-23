using ErrorOr;
using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Orders.Commands.CreateOrder
{
    public record CreateOrderCommand(string Name) : IRequest<ErrorOr<Order>>;

}
