using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.VacancyRequirement;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Domain.Dtos.Vacancy
{
    public class VacancyRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<VacancyRequirementRequest> VacancyRequirements { get; set; } = new List<VacancyRequirementRequest>(5);
    }
}
