using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.VacancyRequirement;

namespace VacancyManagement.Domain.Dtos.Vacancy
{
    public class VacancyViewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<VacancyRequirementViewDto> VacancyRequirements { get; set; }
    }
}
