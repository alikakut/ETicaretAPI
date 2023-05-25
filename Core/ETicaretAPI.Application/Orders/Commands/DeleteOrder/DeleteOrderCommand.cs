using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Orders.Commands.DeleteOrder
{
    public record DeleteOrderCommand(long id) : IRequest<ErrorOr<Order>>;
}
