using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.DataAccess.UnitOfWork;
using VacancyManagement.Domain.Dtos.Quiz;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Services.Implementation
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository _quizRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public QuizService(IQuizRepository quizRepository,
                           IUnitOfWork unitOfWork,
                           IMapper mapper)
        {
            _quizRepository = quizRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<QuizViewDto> AddQuiz(QuizRequest request)
        {
            var map = _mapper.Map<Quiz>(request);
            var data = await _quizRepository.Add(map);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<QuizViewDto>(data);
        }

        public async Task<QuizViewDto> UpdateQuiz(QuizRequest request)
        {
            var map = _mapper.Map<Quiz>(request);
            var data = await _quizRepository.Update(map);
            await _unitOfWork.CommitAsync();
            return _mapper.Map<QuizViewDto>(data);
        }

        public async Task<List<QuizViewDto>> GetQuizzesByVacancyId(int vacancyId)
        {
            var quizzes = await _quizRepository.GetQuizzesByVacationId(vacancyId);
            var map = _mapper.Map<List<QuizViewDto>>(quizzes);
            return map;
        }


    }
}
