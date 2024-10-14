using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.Quiz;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Services.Abstract
{
    public interface IQuizService
    {
        Task<List<QuizViewDto>> GetQuizzesByVacancyId(int vacancyId);

        Task<QuizViewDto> AddQuiz(QuizRequest request);
    }
}
