using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ETicaretAPI.Application.Products.Commands.DeleteProduct
{
    public class DeleteProductCommonValidator : AbstractValidator<DeleteProductCommon>
    {
        public DeleteProductCommonValidator() 
        {
            RuleFor(x => x.id).NotEmpty();
        }
    }
}
