using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.DataAccess.UnitOfWork;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Services.Implementation
{
	public class UserVacancyService : IUserVacancyService
	{
		private readonly IUserVacancyRepository _userVacancyRepository;
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;
		public UserVacancyService(IUserVacancyRepository userVacancyRepository,
								  IMapper mapper,
								  IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
			_userVacancyRepository = userVacancyRepository;
		}

		public async Task<UserVacancyViewDto> Add(UserVacancyRequest request)
		{
			var map = _mapper.Map<UserVacancy>(request);
			var userVacancy = await _userVacancyRepository.Add(map);
			await _unitOfWork.CommitAsync();
			return _mapper.Map<UserVacancyViewDto>(userVacancy);
		}

		public async Task<List<UserVacancyViewDto>> GetAllApplies()
		{
			var allApplies = await _userVacancyRepository.GetAllApplies();
			return allApplies;
		}
	}
}
