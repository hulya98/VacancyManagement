using Microsoft.AspNetCore.Mvc;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.Domain.Dtos.Quiz;
using VacancyManagement.Domain.Dtos.UserQuizAnswer;
using VacancyManagement.Domain.Entities;
using VacancyManagement.Web.ApiClient;

namespace VacancyManagement.Web.Controllers
{
	public class UserQuizAnswerController : Controller
	{
		private readonly UserQuizAnswerAPIClient _apiClient;

		public UserQuizAnswerController(UserQuizAnswerAPIClient apiClient)
		{
			_apiClient = apiClient;
		}

		[HttpGet]
		public async Task<IActionResult> Success()
		{
			return View();
		}


		[HttpGet]
		public async Task<IActionResult> TakeQuiz(int vacationId, int userId)
		{
			var quizList = await _apiClient.GetQuizzesByVacancyId(vacationId);

			if (quizList == null || !quizList.Any())
			{
				return NotFound("Quiz not found.");
			}

			var model = new QuizPageModel
			{
				QuizList = quizList,
				VacationId = vacationId,
				CurrentQuestionIndex = 0,
				UserId = userId

			};

			return View(model);
		}



		[HttpPost]
		public async Task<IActionResult> SubmitAnswer(UserQuizAnswerRequest userQuizAnswer)
		{
			userQuizAnswer.CurrentQuestionIndex++;
			var quizModel = await GetQuizPageModel(userQuizAnswer.VacancyId, userQuizAnswer.QuestionId, userQuizAnswer.UserId, userQuizAnswer.CurrentQuestionIndex); // A method to get the

			await _apiClient.SaveUserAnswer(userQuizAnswer);

			if (quizModel.CurrentQuestionIndex >= quizModel.QuizList.Count)
			{
				return RedirectToAction("Success");
			}

			return View("TakeQuiz", quizModel);
		}

		private async Task<QuizPageModel> GetQuizPageModel(int vacationId, int currentQuestionId, int userId, int index)
		{
			var quizzes = await _apiClient.GetQuizzesByVacancyId(vacationId);

			return new QuizPageModel
			{
				QuizList = quizzes,
				CurrentQuestionIndex = index,
				VacationId = vacationId,
				UserId = userId
			};
		}

	
	}
}
