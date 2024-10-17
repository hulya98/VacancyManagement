using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Abstract
{
	public interface IUserVacancyRepository : IRepository<UserVacancy>
	{
		Task<List<UserVacancy>> GetAllApplies ();
	}
}
