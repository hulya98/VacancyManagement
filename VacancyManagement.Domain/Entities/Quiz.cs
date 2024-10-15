using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Entities
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public Vacancy Vacancy { get; set; }
        public int VacancyId { get; set; }
        public List<QuizAnswer> QuizAnswers { get; set; }
    }
}
