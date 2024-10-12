using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Web.ApiClient;

namespace VacancyManagement.Web.Controllers
{
    public class UserController : Controller
    {

        private UserAPIClient _apiClient;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UserController(UserAPIClient apiClient, IWebHostEnvironment webHostEnvironment)
        {
            _apiClient = apiClient;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
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
            if (!ModelState.IsValid)
            {
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
            request.CVName = "fileName";
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
