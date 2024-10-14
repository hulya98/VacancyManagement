using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.DataAccess.Repositories.Implementation;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.DataAccess.UnitOfWork;
using VacancyManagement.Domain.Dtos.QuizAnswer;
using VacancyManagement.Domain.Dtos.VacancyRequirement;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Services.Implementation
{
    public class QuizAnswerService : IQuizAnswerService
    {
        private readonly IQuizAnswerRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public QuizAnswerService(IQuizAnswerRepository quizAnswerRepository,
                                 IMapper mapper,
                                 IUnitOfWork unitOfWork)
        {
            _repository = quizAnswerRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<QuizAnswerViewDto>> AddRange(int quizId, List<QuizAnswerRequest> request)
        {
            _repository.DeleteAllByVacancyId(quizId);
            foreach (var item in request)
            {
                item.QuizId = quizId;
                item.Id = 0;
            }
            var map = _mapper.Map<List<QuizAnswer>>(request);
            var quizAnswers = await _repository.AddRange(map);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<List<QuizAnswerViewDto>>(quizAnswers);
        }

        public async Task<List<QuizAnswerViewDto>> GetAllByQuizId(int quizId)
        {
            var requirements = await _repository.GetAllByQuizId(quizId);
            var map = _mapper.Map<List<QuizAnswerViewDto>>(requirements);
            return map;
        }
    }
}
