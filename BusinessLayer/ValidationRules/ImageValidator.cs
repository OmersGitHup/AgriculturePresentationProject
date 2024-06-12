using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Picture Title CanNot be EMPTY");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Picture Description CanNot be EMPTY");
            RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Picture ImageURL CanNot be EMPTY");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Please enter maximum 20 character");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Please enter at least 8 character ");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Please enter maximum 20 character");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Please enter at least 10 character ");

        }
    }
}
