using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.DataAccess.UnitOfWork;
using VacancyManagement.Domain.Dtos.UserQuizAnswer;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Services.Implementation
{
    public class UserQuizAnswerService : IUserQuizAnswerService
    {
        private readonly IUserQuizAnswerRepository _userQuizAnswerRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public UserQuizAnswerService(IUserQuizAnswerRepository userQuizAnswerRepository,
            IMapper mapper,
            IUnitOfWork unitOfWork)
        {
            _userQuizAnswerRepository = userQuizAnswerRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<UserQuizAnswerViewDto> Add(UserQuizAnswerRequest request)
        {
            var map = _mapper.Map<UserQuizAnswer>(request);
            var result = await _userQuizAnswerRepository.Add(map);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<UserQuizAnswerViewDto>(result);
        }
    }
}
