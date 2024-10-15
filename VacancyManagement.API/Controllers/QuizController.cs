using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacancyManagement.DataAccess.Services.Abstract;

namespace VacancyManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;

        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllByVacationId(int vacationId)
        {
            return Ok(await _quizService.GetQuizzesByVacancyId(vacationId));
        }
    }
}
