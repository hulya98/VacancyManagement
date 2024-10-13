using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.Domain.Dtos.User;

namespace VacancyManagement.API.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		public UserController(IUserService userService)
		{
			_userService = userService;
		}


		[HttpGet]
		public async Task<IActionResult> GetAllUsers()
		{
			return Ok(await _userService.GetGuestUsers());
		}

		[HttpPost]
		public async Task<IActionResult> Add(UserRequest request)
		{
			await _userService.Add(request);
			return Ok();
		}
	}
}
