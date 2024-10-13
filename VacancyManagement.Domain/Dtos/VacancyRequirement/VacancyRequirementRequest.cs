using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Dtos.VacancyRequirement
{
    public class VacancyRequirementRequest
    {
        public int Id { get; set; }
        public string Requirement { get; set; }
        public int VacancyId { get; set; }
    }
}
