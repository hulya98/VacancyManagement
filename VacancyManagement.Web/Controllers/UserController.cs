﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Domain.Entities;
using VacancyManagement.Web.ApiClient;
using VacancyManagement.Web.Services.Abstact;

namespace VacancyManagement.Web.Controllers
{
    public class UserController : Controller
    {

        private UserAPIClient _apiClient;
        private readonly IUserBusinessLogic _userBusinessLogic;
        public UserController(IUserBusinessLogic userBusinessLogic,
                                                UserAPIClient apiClient)
        {
            _apiClient = apiClient;
            _userBusinessLogic = userBusinessLogic;
        }

        [HttpGet]
        public async Task<IActionResult> ExistUser()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply(int vacancyId)
        {
            UserIncludeCVRequest request = new UserIncludeCVRequest
            {
                VacancyId = vacancyId,
            };
            return View(request);
        }

        [HttpPost]
        public async Task<IActionResult> Apply(UserIncludeCVRequest request)
        {
            var response = await _userBusinessLogic.Apply(request);

            if (response.HasErrors)
            {
                foreach (var error in response.Errors)
                {
                    ModelState.AddModelError(string.Empty, error);
                    throw new Exception(error);
                }
            }

            return RedirectToAction("TakeQuiz", "UserQuizAnswer", new { vacationId = request.VacancyId, userId = response.Data });

        }
    }
}
