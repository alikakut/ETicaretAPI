using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using ETicaretAPI.Application.Repository.Customers;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Domain.Errors;
using MediatR;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ETicaretAPI.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, ErrorOr<Customer>>
    { 
        private readonly ICustomerReadRepository _customerReadRepository;

        public CreateCustomerCommandHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

       
        public async Task<ErrorOr<Customer>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var customer = new Customer 
            {
                Name = request.Name
            };
            var persistenceResult = _customerReadRepository.Add(customer);
            if (persistenceResult is null || persistenceResult.Id < 1)
            {
                return Errors.DbPersistence;
            }
            else
            {
                return persistenceResult.Result;
            }
        }
    }
}
