using Microsoft.Exchange.WebServices.Data;
using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Web.ApiClient;
using VacancyManagement.Web.Services.Abstact;
using Task = System.Threading.Tasks.Task;
namespace VacancyManagement.Web.Services.Implementation
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly UserVacancyAPIClient _userVacancyAPIClient;
        private readonly UserAPIClient _userAPIClient;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UserBusinessLogic(UserVacancyAPIClient userVacancyAPIClient,
                                 UserAPIClient userAPIClient,
                                 IWebHostEnvironment webHostEnvironment)
        {
            _userAPIClient = userAPIClient;
            _userVacancyAPIClient = userVacancyAPIClient;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<string> SaveCVAsync(IFormFile cvFile)
        {
            if (cvFile != null && cvFile.Length > 0)
            {
                if (cvFile.Length > 5 * 1024 * 1024) // 5 MB
                {
                    //ModelState.AddModelError("CV", "File size must be less than or equal to 5 MB.");
                    return null;
                }

                // Validate file extension
                var allowedExtensions = new[] { ".pdf", ".docx" };
                var fileExtension = Path.GetExtension(cvFile.FileName).ToLower();

                if (!allowedExtensions.Contains(fileExtension))
                {
                    //ModelState.AddModelError("CV", "Only PDF, DOCX files are allowed.");
                    return null;
                }

            }
            else
            {
                return null;
            }
            var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads/cvs");
            Directory.CreateDirectory(uploadsFolder);

            string fileName = Guid.NewGuid().ToString() + "-" + cvFile.FileName;
            string filePath = Path.Combine(uploadsFolder, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await cvFile.CopyToAsync(fileStream);
            }
            return fileName;

        }

        public async Task<bool> UserExistsAsync(string email, int vacancyId)
        {
            return await _userVacancyAPIClient.CheckUserIsExist(email, vacancyId);
        }



        public async Task<ApiResult<int>> Apply(UserIncludeCVRequest request)
        {
            var result = new ApiResult<int>();

            if (await UserExistsAsync(request.Email, request.VacancyId))
            {
                result.Success = false;
                result.Errors.Add("User already exists.");
                return result;
            }

            request.CVName = await SaveCVAsync(request.CV);
            if (string.IsNullOrEmpty(request.CVName))
            {
                result.Errors.Add("Please, Check file format or size.");
                return result;
            }

            var user = await _userAPIClient.AddUserAsync(request);

            if (user is null)
            {
                result.Success = false;
                result.Errors.Add("Failed to add user.");
            }

            result.Data = user.Id;
            return result;
        }
    }
}
