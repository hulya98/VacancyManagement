using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.User;

namespace VacancyManagement.Domain.Validation
{
    public class UserIncludeCVRequestValidation : AbstractValidator<UserIncludeCVRequest>
    {
        public UserIncludeCVRequestValidation()
        {
            RuleFor(x => x.VacancyId).NotEmpty().WithMessage("Please, enter {PropertyName}");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Please, enter {PropertyName}");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please, enter {PropertyName}");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please, enter {PropertyName}");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Please, enter {PropertyName}");
        }
    }
}
