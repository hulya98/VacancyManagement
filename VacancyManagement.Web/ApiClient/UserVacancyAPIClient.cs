using System.Text.Json;
using VacancyManagement.Domain.Dtos.Quiz;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Dtos.Vacancy;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Web.ApiClient
{
    public class UserVacancyAPIClient
    {
        private readonly HttpClient _httpClient;
        public UserVacancyAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserQuizResultView>> GetAllAppliesAsync()
        {
            var response = await _httpClient.GetAsync("api/UserVacancy/GetAllApplies");

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var userVacancies = JsonSerializer.Deserialize<List<UserQuizResultView>>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return userVacancies;
        }

        public async Task<bool> CheckUserIsExist(string email, int vacancyId)
        {
            var response = await _httpClient.GetAsync($"/api/UserVacancy/CheckUserIsExist?email={email}&vacancyId={vacancyId}");

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var result = JsonSerializer.Deserialize<bool>(responseContent, options);
                return result;
            }
            return false;
        }

    }
}
