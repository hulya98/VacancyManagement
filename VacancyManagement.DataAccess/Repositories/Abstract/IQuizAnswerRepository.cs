using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Abstract
{
    public interface IQuizAnswerRepository : IRepository<QuizAnswer>
    {
        Task<List<QuizAnswer>> GetAllByQuizId(int quizId);
        Task<List<QuizAnswer>> AddRange(List<QuizAnswer> quizAnswers);
        void DeleteAllByVacancyId(int quizId);
    }
}
