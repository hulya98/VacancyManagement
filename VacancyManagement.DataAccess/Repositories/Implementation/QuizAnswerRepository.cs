using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.Domain;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Implementation
{
    public class QuizAnswerRepository : Repository<QuizAnswer>, IQuizAnswerRepository
    {
        private readonly Context _context;
        private readonly DbSet<QuizAnswer> _dbSet;

        public QuizAnswerRepository(Context context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<QuizAnswer>();
        }

        public async Task<List<QuizAnswer>> AddRange(List<QuizAnswer> quizAnswers)
        {
            await _dbSet.AddRangeAsync(quizAnswers);
            return quizAnswers;
        }

        public void DeleteAllByVacancyId(int quizId)
        {
            var datas = _dbSet.Where(x => x.QuizId == quizId).ToList();
            _dbSet.RemoveRange(datas);
        }

        public async Task<List<QuizAnswer>> GetAllByQuizId(int quizId)
        {
            var datas = await _dbSet.Where(x => x.QuizId == quizId).ToListAsync();
            return datas;
        }
    }
}
