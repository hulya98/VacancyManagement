using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.Domain.Dtos.UserQuizAnswer;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserQuizAnswerController : ControllerBase
    {
        private readonly IUserQuizAnswerService _userQuizAnswerService;

        public UserQuizAnswerController(IUserQuizAnswerService userQuizAnswerService)
        {
            _userQuizAnswerService = userQuizAnswerService;
        }

        [HttpPost]
        public async Task<IActionResult> SaveUserAnswer(UserQuizAnswerRequest request)
        {
            var result = await _userQuizAnswerService.Add(request);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserAnswerCompare(int vacancyId, int userId)
        {
            var data = await _userQuizAnswerService.GetUserAnswerCompare(vacancyId, userId);
            return Ok(data);
        }
    }
}
