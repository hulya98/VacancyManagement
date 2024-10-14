using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.QuizAnswer;

namespace VacancyManagement.Domain.Dtos.Quiz
{
    public class QuizRequest
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int VacancyId { get; set; }
        public List<QuizAnswerRequest> QuizAnswers { get; set; }
    }
}
