using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.Domain;
using VacancyManagement.Domain.Dtos.Quiz;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Implementation
{
    public class QuizRepository : Repository<Quiz>, IQuizRepository
    {
        private readonly Context _context;
        private readonly DbSet<Quiz> _dbSet;
        public QuizRepository(Context context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<Quiz>();
        }

        public async Task<List<Quiz>> GetQuizzesByVacationId(int vacationId)
        {
            var quizzes = await _dbSet.Where(x => x.VacancyId == vacationId).ToListAsync();
            return quizzes;
        }
    }
}
