using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.DataAccess.Services.Implementation;
using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Domain.Dtos.UserVacancy;

namespace VacancyManagement.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class UserVacancyController : ControllerBase
	{
		private readonly IUserVacancyService _userVacancyService;
		public UserVacancyController(IUserVacancyService userVacancyService)
		{
			_userVacancyService = userVacancyService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllApplies()
		{
			return Ok(await _userVacancyService.GetAllApplies());
		}

		[HttpPost]
		public async Task<IActionResult> Save(UserVacancyRequest request)
		{
			await _userVacancyService.Add(request);
			return Ok();
		}
	}
}
