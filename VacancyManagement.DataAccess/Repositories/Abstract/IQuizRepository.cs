using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Abstract
{
    public interface IQuizRepository : IRepository<Quiz>
    {
        Task<List<Quiz>> GetQuizzesByVacationId(int vacationId);
    }
}
