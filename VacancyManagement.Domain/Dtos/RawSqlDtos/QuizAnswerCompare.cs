using System;

namespace VacancyManagement.Domain.Dtos.RawSqlDtos
{
    public class QuizAnswerCompare
    {
        public int IsCorrect { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string UserAnswer { get; set; }
    }
}
