using Microsoft.AspNetCore.Mvc;
using VacancyManagement.Domain.Dtos.Vacancy;
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
        public async Task<IActionResult> Success()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ActiveVacancies()
        {
            var data = await _apiClient.GetActiveVacanciesAsync();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> AddVacancy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddVacancy(VacancyRequest request)
        {
            var vacancy = await _apiClient.SaveVacancy(request);

            return RedirectToAction("Success");
        }

        [HttpGet]
        public async Task<IActionResult> GetVacancyById(int vacancyId)
        {
            var vacancy = await _apiClient.GetVacancyByIdAsync(vacancyId);
            return View(vacancy);
        }
    }
}
