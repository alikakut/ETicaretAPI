using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Common.Constants;
using FluentValidation;

namespace ETicaretAPI.Application.Orders.Queries.GetOrder
{
    public class OrderQueryValidator : AbstractValidator<OrderQuery>
    {
        public OrderQueryValidator()
        {
            RuleFor(x => x.Page)
           .NotEmpty()
           .GreaterThanOrEqualTo(QueryConstants.MinPage);
            RuleFor(x => x.Size)
                .NotEmpty()
                .GreaterThanOrEqualTo(QueryConstants.MinSize)
                .LessThanOrEqualTo(QueryConstants.MaxSize);
        }
    }
}
