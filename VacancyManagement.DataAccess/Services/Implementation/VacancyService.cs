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
using VacancyManagement.Domain.Entities;

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

        public async Task<VacancyViewDto> Add(VacancyRequest request)
        {
            var map = _mapper.Map<Vacancy>(request);
            var vacancy = await _vacancyRepository.Add(map);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<VacancyViewDto>(vacancy);
        }

        public async Task<VacancyViewDto> Update(VacancyRequest request)
        {
            var map = _mapper.Map<Vacancy>(request);
            var vacancy = await _vacancyRepository.Update(map);
            return _mapper.Map<VacancyViewDto>(vacancy);
        }

        public async Task<List<VacancyViewDto>> GetActiveVacancies()
        {
            var vacancies = await _vacancyRepository.GetActiveVacancies();
            var map = _mapper.Map<List<VacancyViewDto>>(vacancies);
            return map;
        }

        public async Task<List<VacancyViewDto>> GetAllVacancies()
        {
            var vacancies = await _vacancyRepository.GetAllVacancies();
            var map = _mapper.Map<List<VacancyViewDto>>(vacancies);
            return map;
        }

        public async Task<VacancyViewDto> GetVacancyById(int vacancyId)
        {
            var data = await _vacancyRepository.GetVacancyById(vacancyId);
            var map = _mapper.Map<VacancyViewDto>(data);
            return map;
        }
    }
}
