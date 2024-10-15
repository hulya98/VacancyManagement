using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Web.ApiClient;
using VacancyManagement.Web.Validations;

namespace VacancyManagement.Web.Controllers
{
    public class UserController : Controller
    {

        private UserAPIClient _apiClient;
        private UserVacancyAPIClient _userVacancyAPIClient;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UserController(UserAPIClient apiClient,
                              UserVacancyAPIClient userVacancyAPIClient,
                              IWebHostEnvironment webHostEnvironment)
        {
            _apiClient = apiClient;
            _userVacancyAPIClient = userVacancyAPIClient;
            _webHostEnvironment = webHostEnvironment;
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
            if (await UserValidation.UserIsExist(_userVacancyAPIClient, request.Email, request.VacancyId))
            {
                ModelState.AddModelError("existUser", "This user already exist in our system");
            }

            if (!ModelState.IsValid)
            {
                return View("ExistUser");
            }


            var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads/cvs");
            Directory.CreateDirectory(uploadsFolder); // Ensure the folder exists

            string fileName = Guid.NewGuid().ToString() + "_" + request.CV.FileName;
            var filePath = Path.Combine(uploadsFolder, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await request.CV.CopyToAsync(fileStream);
            }

            // Save the file name to the view model (this can be saved to the database later)
            request.CVName = request.FirstName + request.LastName;
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
