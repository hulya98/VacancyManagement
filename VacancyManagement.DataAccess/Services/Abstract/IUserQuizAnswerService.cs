using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.UserQuizAnswer;

namespace VacancyManagement.DataAccess.Services.Abstract
{
    public interface IUserQuizAnswerService
    {
        Task<UserQuizAnswerViewDto> Add(UserQuizAnswerRequest request);
    }
}
