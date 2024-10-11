using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.DataAccess.UnitOfWork;
using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Services.Implementation
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IUserVacancyService _userVacancyService;
		public UserService(IUserRepository userRepository,
						   IUnitOfWork unitOfWork,
						   IMapper mapper)
		{
			_mapper = mapper;
			_userRepository = userRepository;
			_unitOfWork = unitOfWork;
		}

		public async Task<UserViewDto> Add(UserRequest request)
		{
			var map = _mapper.Map<User>(request);
			var user = await _userRepository.Add(map);
			var userVacancy = new UserVacancyRequest { UserId = user.Id, VacancyId = request.VacancyId };
			await _userVacancyService.Add(userVacancy);
			await _unitOfWork.CommitAsync();
			return _mapper.Map<UserViewDto>(user);
		}

		public async Task<List<UserViewDto>> GetGuestUsers()
		{
			var users = await _userRepository.GetGuestUsers();
			var map = _mapper.Map<List<UserViewDto>>(users);
			return map;
		}
	}
}
