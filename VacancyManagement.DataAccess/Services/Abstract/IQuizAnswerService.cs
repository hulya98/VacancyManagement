using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.QuizAnswer;
using VacancyManagement.Domain.Dtos.VacancyRequirement;

namespace VacancyManagement.DataAccess.Services.Abstract
{
    public interface IQuizAnswerService
    {
        Task<List<QuizAnswerViewDto>> AddRange(int quizId, List<QuizAnswerRequest> request);

        Task<List<QuizAnswerViewDto>> GetAllByQuizId(int quizId);
    }
}
