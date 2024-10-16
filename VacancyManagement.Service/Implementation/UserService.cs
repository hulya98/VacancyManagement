using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Service.Abstract;

namespace VacancyManagement.Service.Implementation
{
    public class UserService : IUserService
    {
        private UserVacancyAPIClient _userVacancyAPIClient;
        private readonly IApiClient _apiClient;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UserService(IUserVacancyAPIClient userVacancyAPIClient, IApiClient apiClient, IWebHostEnvironment webHostEnvironment)
        {
            _userVacancyAPIClient = userVacancyAPIClient;
            _apiClient = apiClient;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<bool> UserExistsAsync(string email, int vacancyId)
        {
            return await _userVacancyAPIClient.UserIsExist(email, vacancyId);
        }

        public async Task<bool> AddUserAsync(UserIncludeCVRequest request)
        {
            return await _apiClient.AddUserAsync(request);
        }

        public async Task<string> SaveCVAsync(IFormFile cvFile)
        {
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
    }

}
