using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.Domain;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Implementation
{
    public class UserVacancyRepository : Repository<UserVacancy>, IUserVacancyRepository
    {
        private readonly Context _context;
        private readonly DbSet<UserVacancy> _dbSet;

        public UserVacancyRepository(Context context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<UserVacancy>();
        }

        public async Task<List<UserVacancy>> GetAllApplies()
        {
            var allApplies = await _context.UserVacancies
                                        .Include(x => x.User)
                                        .Include(x => x.Vacancy)
                                        .ToListAsync();
            return allApplies;
        }
    }
}
