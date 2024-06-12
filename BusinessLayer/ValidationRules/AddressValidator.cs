using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Description CANNOT be empty");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Description 2 CANNOT be empty");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Description 3 CANNOT be empty");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Description 4 CANNOT be empty");
            RuleFor(x => x.MapInfo).NotEmpty().WithMessage("Map Info CANNOT be empty");
            RuleFor(x => x.Description1).MaximumLength(25).WithMessage("Please use maximum 25 character");
            RuleFor(x => x.Description2).MaximumLength(25).WithMessage("Please use maximum 25 character");
            RuleFor(x => x.Description3).MaximumLength(25).WithMessage("Please use maximum 25 character");
            RuleFor(x => x.Description4).MaximumLength(25).WithMessage("Please use maximum 25 character");
        }
    }
}
