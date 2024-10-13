using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.VacancyRequirement;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Services.Abstract
{
    public interface IVacancyRequirementService
    {
        Task<List<VacancyRequirementViewDto>> AddRange(int vacancyId, List<VacancyRequirementRequest> request);

        Task<List<VacancyRequirementViewDto>> GetAllByVacancyId(int vacancyId);
    }
}
