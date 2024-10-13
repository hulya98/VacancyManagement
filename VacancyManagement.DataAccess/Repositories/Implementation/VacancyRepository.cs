using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.Domain.Entities;
using VacancyManagement.Domain;
using VacancyManagement.Domain.Dtos.Vacancy;

namespace VacancyManagement.DataAccess.Repositories.Implementation
{
    public class VacancyRepository : Repository<Vacancy>, IVacancyRepository
    {
        private readonly Context _context;
        private readonly DbSet<Vacancy> _dbSet;

        public VacancyRepository(Context context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<Vacancy>();
        }

        public async Task<List<Vacancy>> GetActiveVacancies()
        {
            var data = await _dbSet.Include(x => x.VacancyRequirements).Where(x => x.IsActive == true).ToListAsync();
            return data;
        }

        public async Task<Vacancy> GetVacancyById(int id)
        {
            var data = await _dbSet.Where(x => x.Id == id).Include(x => x.VacancyRequirements).FirstOrDefaultAsync();
            return data;
        }
    }
}
