using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Services.Abstract
{
    public interface IUserVacancyService
	{
		Task<UserVacancyViewDto> Add(UserVacancyRequest request);
		Task<List<UserQuizResultView>> GetAllApplies();
        Task<bool> CheckUserIsExist(string email, int vacancyId);
    }
}
