using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using ETicaretAPI.Application.Common.Model;
using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Customers.Queries.GetCustomer
{
    public record CustomerQuery :BaseQuery, IRequest<ErrorOr<Customer>>;
}
