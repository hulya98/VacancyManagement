using Microsoft.AspNetCore.Mvc;
using VacancyManagement.Domain.Dtos.User;

namespace VacancyManagement.Web.Controllers
{
    public class UserController : Controller
    {

        private ApiClient.ApiClient _apiClient;

        public UserController(ApiClient.ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Apply(UserRequest request)
        {
            if (!ModelState.IsValid)
            {

            }
            var success = await _apiClient.AddUserAsync(request);
            if (success)
            {
                return RedirectToAction("Success");
            }
            else
            {
                ModelState.AddModelError("", "Error adding user");
                return View();
            }
        }
    }
}
