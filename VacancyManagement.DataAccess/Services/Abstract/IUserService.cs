using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.User;

namespace VacancyManagement.DataAccess.Services.Abstract
{
	public interface IUserService
	{
		Task<UserViewDto> Add(UserRequest request);
		Task<List<UserViewDto>> GetGuestUsers();
	}
}
