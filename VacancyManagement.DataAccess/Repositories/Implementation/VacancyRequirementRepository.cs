using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.Domain;
using VacancyManagement.Domain.Dtos.VacancyRequirement;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Implementation
{
    public class VacancyRequirementRepository : Repository<VacancyRequirement>, IVacancyRequirementRepository
    {
        private readonly Context _context;
        private readonly DbSet<VacancyRequirement> _dbSet;

        public VacancyRequirementRepository(Context context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<VacancyRequirement>();
        }

        public async Task<List<VacancyRequirement>> AddRange(List<VacancyRequirement> vacancyRequirements)
        {
            await _dbSet.AddRangeAsync(vacancyRequirements);
            return vacancyRequirements;
        }

        public void DeleteAllByVacancyId(int vacancyId)
        {
            var datas = _dbSet.Where(x => x.VacancyId == vacancyId).ToList();
            _dbSet.RemoveRange(datas);
        }

        public async Task<List<VacancyRequirement>> GetAllByVacancyId(int vacancyId)
        {
            var datas = await _dbSet.Where(x => x.VacancyId == vacancyId).ToListAsync();
            return datas;
        }
    }
}
