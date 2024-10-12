using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.DataAccess.UnitOfWork;
using VacancyManagement.Domain.Dtos.Vacancy;

namespace VacancyManagement.DataAccess.Services.Implementation
{
    public class VacancyService : IVacancyService
    {
        private readonly IVacancyRepository _vacancyRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public VacancyService(IVacancyRepository vacancyRepository,
                              IMapper mapper,
                              IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _vacancyRepository = vacancyRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<VacancyViewDto>> GetActiveVacancies()
        {
            var vacancies = await _vacancyRepository.GetActiveVacancies();
            var map = _mapper.Map<List<VacancyViewDto>>(vacancies);
            return map;

        }
    }
}
