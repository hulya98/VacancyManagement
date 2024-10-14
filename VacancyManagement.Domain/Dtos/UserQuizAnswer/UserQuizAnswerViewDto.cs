using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Dtos.UserQuizAnswer
{
    public class UserQuizAnswerViewDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VacancyId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public int UserAnswerId { get; set; }
        public string UserAnswerItem { get; set; }
        public string UserAnswer { get; set; }
        public string CorrectAnswerItem { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
