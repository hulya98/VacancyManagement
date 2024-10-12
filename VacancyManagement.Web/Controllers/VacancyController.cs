using Microsoft.AspNetCore.Mvc;
using VacancyManagement.Web.ApiClient;

namespace VacancyManagement.Web.Controllers
{
    public class VacancyController : Controller
    {
        private VacancyAPIClient _apiClient;
        public VacancyController(VacancyAPIClient apiClient)
        {
            _apiClient = apiClient;
        }

        [HttpGet]
        public async Task<IActionResult> ActiveVacancies()
        {
            var data = await _apiClient.GetActiveVacanciesAsync();
            return View(data);
        }
    }
}
