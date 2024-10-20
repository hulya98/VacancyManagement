﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Dtos.UserQuizAnswer
{
    public class UserQuizAnswerRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VacancyId { get; set; }
        public int QuestionId { get; set; }
        public int UserAnswerId { get; set; }
        public int CurrentQuestionIndex { get; set; }
    }
}
