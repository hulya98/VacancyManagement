using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.Domain;
using VacancyManagement.Domain.Dtos.RawSqlDtos;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Implementation
{
    public class UserQuizAnswerRepository : Repository<UserQuizAnswer>, IUserQuizAnswerRepository
    {
        private readonly Context _context;
        private readonly DbSet<UserQuizAnswer> _dbSet;

        public UserQuizAnswerRepository(Context context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<UserQuizAnswer>();
        }

        public async Task<List<QuizAnswerCompare>> GetUserAnswerCompare(int vacancyId, int userId)
        {
            var result = await _context.Set<QuizAnswerCompare>()
                        .FromSqlRaw("EXEC dbo.QuizAndUserAnswerCompare {0},{1}", vacancyId, userId)
                        .ToListAsync();
            return result;
        }
    }
}
