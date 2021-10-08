using API.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ModelValidations
{
    public class SubscriberValidator : AbstractValidator<SubscriberDTO>
    {
        public SubscriberValidator()
        {
            RuleFor(m => m.FirstName).NotEmpty();
            RuleFor(m => m.LastName).NotEmpty();
            RuleFor(m => m.EmailAddress).NotEmpty().EmailAddress();
            RuleFor(m => m.DateOfBirth).NotEmpty().LessThanOrEqualTo(p => DateTime.Now).WithMessage("Birth of date can't be in the future");
        }
    }
}
