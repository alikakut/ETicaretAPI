using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using ETicaretAPI.Domain.Entities;
using MediatR;

namespace ETicaretAPI.Application.Customers.Commands.CreateCustomer
{
    public record CreateCustomerCommand(
       string Name ) : IRequest<ErrorOr<Customer>> ;
}
