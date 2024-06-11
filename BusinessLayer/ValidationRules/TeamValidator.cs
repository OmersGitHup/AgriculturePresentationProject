using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Title cannot be empty");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image URL cannot be empty");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Please enter less than 50 character");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Please enter at least 5 character");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Please enter less than 50 character");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Please enter at least 3 character");

        }
    }
}
