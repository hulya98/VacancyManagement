using System.Text.Json;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Dtos.Vacancy;

namespace VacancyManagement.Web.ApiClient
{
    public class UserVacancyAPIClient
    {
        private readonly HttpClient _httpClient;
        public UserVacancyAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserVacancyViewDto>> GetAllAppliesAsync()
        {
            var response = await _httpClient.GetAsync("api/UserVacancy/GetAllApplies");

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var userVacancies = JsonSerializer.Deserialize<List<UserVacancyViewDto>>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return userVacancies;
        }
    }
}
