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
        private readonly IUserQuizAnswerRepository _userQuizAnswerRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public UserVacancyService(IUserVacancyRepository userVacancyRepository,
                                  IUserQuizAnswerRepository userQuizAnswerRepository,
                                  IMapper mapper,
                                  IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userVacancyRepository = userVacancyRepository;
            _userQuizAnswerRepository = userQuizAnswerRepository;
        }

        public async Task<UserVacancyViewDto> Add(UserVacancyRequest request)
        {
            var map = _mapper.Map<UserVacancy>(request);
            var userVacancy = await _userVacancyRepository.Add(map);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<UserVacancyViewDto>(userVacancy);
        }


        public async Task<bool> CheckUserIsExist(string email, int vacancyId)
        {
            var users = await GetAllApplies();
            var user = users.Where(x => x.Email == email &&
                                        x.VacancyId == vacancyId).FirstOrDefault();

            if (user != null)
                return true;

            return false;
        }

        public async Task<List<UserQuizResultView>> GetAllApplies()
        {
            var allApplies = await _userVacancyRepository.GetAllApplies();
            var map = _mapper.Map<List<UserQuizResultView>>(allApplies);
            var applies = map.Select(x => new UserQuizResultView
            {
                Id = x.Id,
                UserId = x.UserId,
                FullName = x.User.FullName,
                VacancyId = x.VacancyId,
                VacancyName = x.Vacancy.Name,
                PhoneNumber = x.User.PhoneNumber,
                Email = x.User.Email,
                CVName = x.User.CVName
            }).ToList();

            for (var i = 0; i < applies.Count; i++)
            {
                applies[i].QuizResults = await _userQuizAnswerRepository.GetUserAnswerCompare(applies[i].VacancyId, applies[i].UserId);
                if (applies[i].QuizResults.Count > 0)
                {
                    decimal correctCount = applies[i].QuizResults.Where(x => x.IsCorrect == 1).ToList().Count;
                    decimal totalCount = applies[i].QuizResults.Count;
                    decimal divide = Math.Round((correctCount / totalCount), 2);
                    applies[i].Result = divide * 100;
                }
            }

            return applies;
        }
    }
}
