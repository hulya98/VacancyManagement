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
    }
}
