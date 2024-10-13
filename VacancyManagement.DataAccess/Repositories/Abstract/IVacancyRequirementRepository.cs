using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.VacancyRequirement;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Abstract
{
    public interface IVacancyRequirementRepository : IRepository<VacancyRequirement>
    {
        Task<List<VacancyRequirement>> GetAllByVacancyId(int vacancyId);
        Task<List<VacancyRequirement>> AddRange(List<VacancyRequirement> vacancyRequirements);
        void DeleteAllByVacancyId(int vacancyId);
    }
}
