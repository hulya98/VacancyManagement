using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.Domain;
using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Implementation
{
	public class UserRepository : Repository<User>, IUserRepository
	{
		private readonly Context _context;
		private readonly DbSet<User> _dbSet;

		public UserRepository(Context context) : base(context)
		{
			_context = context;
			_dbSet = context.Set<User>();
		}

		public async Task<List<User>> GetGuestUsers()
		{
			var guestUsers = await _context.Users
			.Where(u => u.UserRoles.Any(ur => ur.Role.Name == "Guest"))
			.ToListAsync();

			return guestUsers;
		}
	}
}
