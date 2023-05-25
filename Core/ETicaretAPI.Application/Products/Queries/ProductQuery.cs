using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using ETicaretAPI.Application.Common.Model;
using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Products.Queries
{
    public record ProductQuery : BaseQuery , IRequest<ErrorOr<ProductQueryResult>>;
}
