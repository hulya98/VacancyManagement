using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.Vacancy;

namespace VacancyManagement.DataAccess.Services.Abstract
{
    public interface IVacancyService
    {
        public Task<List<VacancyViewDto>> GetActiveVacancies();
        public Task<List<VacancyViewDto>> GetAllVacancies();
        public Task<VacancyViewDto> Add(VacancyRequest request);
        public Task<VacancyViewDto> Update(VacancyRequest request);
        Task<VacancyViewDto> GetVacancyById(int vacancyId);
    }
}
