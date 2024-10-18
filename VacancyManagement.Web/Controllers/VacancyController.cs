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
        public async Task<IActionResult> AllVacancies()
        {
            var data = await _apiClient.GetAllVacanciesAsync();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> ActiveVacanciesForGuest()
        {
            var data = await _apiClient.GetActiveVacanciesAsync();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(VacancyRequest request)
        {
            var vacancy = await _apiClient.AddVacancy(request);
            return RedirectToAction("Success");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var vacancy = await _apiClient.GetVacancyByIdAsync(id);
            return View(vacancy);
        }

        [HttpPost]
        public async Task<IActionResult> Update(VacancyRequest request)
        {
            var vacancy = await _apiClient.UpdateVacancy(request);
            return RedirectToAction("Success");
        }

    }
}
