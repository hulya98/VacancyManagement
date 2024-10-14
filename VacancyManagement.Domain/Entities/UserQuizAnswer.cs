using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Entities
{
    public class UserQuizAnswer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VacancyId { get; set; }
        public int QuestionId { get; set; }
        public int UserAnswerId { get; set; }
    }
}
