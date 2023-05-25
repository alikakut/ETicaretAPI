using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using ETicaretAPI.Application.Common.Model;
using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Orders.Queries.GetOrder
{
    public record OrderQuery : BaseQuery,IRequest<ErrorOr<OrderQueryResult>>;
}
