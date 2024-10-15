using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Dtos.Quiz
{
    public class QuizPageModel
    {
        public List<QuizViewDto> QuizList { get; set; } = new();
        public int VacationId { get; set; } = 1;
        public int CurrentQuestionIndex { get; set; } = 0;
    }
}
