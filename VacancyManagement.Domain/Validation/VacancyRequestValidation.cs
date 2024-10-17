using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.Vacancy;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Domain.Validation
{
    public class VacancyRequestValidation : AbstractValidator<VacancyRequest>
    {
        public VacancyRequestValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please, enter {PropertyName}");
        }
    }
}
