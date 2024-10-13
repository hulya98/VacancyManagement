using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.Vacancy;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Abstract
{
    public interface IVacancyRepository : IRepository<Vacancy>
    {
        Task<List<Vacancy>> GetActiveVacancies();
        Task<Vacancy> GetVacancyById(int id);
    }
}
