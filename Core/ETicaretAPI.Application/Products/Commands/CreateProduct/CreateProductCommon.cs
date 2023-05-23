using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Products.Commands.CreateProduct
{
    public record CreateProductCommon ( string Name) :IRequest<ErrorOr<Product>>;
}
