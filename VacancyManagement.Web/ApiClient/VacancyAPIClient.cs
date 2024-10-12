using System.Text.Json;
using VacancyManagement.Domain.Dtos.Vacancy;

namespace VacancyManagement.Web.ApiClient
{
    public class VacancyAPIClient
    {
        private readonly HttpClient _httpClient;
        public VacancyAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<VacancyViewDto>> GetActiveVacanciesAsync()
        {
            var response = await _httpClient.GetAsync("api/Vacancy/GetActiveVacancies");

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var vacancies = JsonSerializer.Deserialize<List<VacancyViewDto>>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return vacancies;
        }
    }
}
