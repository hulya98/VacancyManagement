using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.DataAccess.UnitOfWork;
using VacancyManagement.Domain.Dtos.VacancyRequirement;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Services.Implementation
{
    public class VacancyRequirementService : IVacancyRequirementService
    {
        private readonly IVacancyRequirementRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public VacancyRequirementService(IVacancyRequirementRepository vacancyRequirementRepository,
            IMapper mapper,
            IUnitOfWork unitOfWork)
        {
            _repository = vacancyRequirementRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<VacancyRequirementViewDto>> AddRange(int vacancyId, List<VacancyRequirementRequest> request)
        {
            //_repository.DeleteAllByVacancyId(vacancyId);
            foreach (var item in request)
            {
                item.VacancyId = vacancyId;
                item.Id = 0;
            }
            var map = _mapper.Map<List<VacancyRequirement>>(request);
            var vacancyRequirement = await _repository.AddRange(map);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<List<VacancyRequirementViewDto>>(vacancyRequirement);

        }

        public async Task<List<VacancyRequirementViewDto>> GetAllByVacancyId(int vacancyId)
        {
            var requirements = await _repository.GetAllByVacancyId(vacancyId);
            var map = _mapper.Map<List<VacancyRequirementViewDto>>(requirements);
            return map;
        }
    }
}
