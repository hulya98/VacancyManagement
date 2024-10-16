using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.RawSqlDtos;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Abstract
{
    public interface IUserQuizAnswerRepository : IRepository<UserQuizAnswer>
    {
        Task<List<QuizAnswerCompare>> GetUserAnswerCompare(int vacancyId, int userId);
    }
}
