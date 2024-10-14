using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.QuizAnswer;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Domain.Dtos.Quiz
{
    public class QuizViewDto
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public List<QuizAnswerViewDto> QuizzAnswers { get; set; }
    }
}
