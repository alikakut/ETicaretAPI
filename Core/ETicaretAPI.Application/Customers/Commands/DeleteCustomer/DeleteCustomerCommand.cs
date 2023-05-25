using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Customers.Commands.DeleteCustomer
{
    public record DeleteCustomerCommand(long id) :IRequest<ErrorOr<Customer>>;
}
