using Microsoft.AspNetCore.Mvc;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.Web.ApiClient;

namespace VacancyManagement.Web.Controllers
{
    public class UserVacancyController : Controller
    {
        private UserVacancyAPIClient _apiClient;
        public UserVacancyController(UserVacancyAPIClient apiClient)
        {
            _apiClient = apiClient;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllApplies()
        {
            var data = await _apiClient.GetAllAppliesAsync();
            return View(data);
        }
    }
}
