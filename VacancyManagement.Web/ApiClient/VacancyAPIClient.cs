using System.Text.Json;
using VacancyManagement.Domain.Dtos.UserVacancy;
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

        public async Task<VacancyViewDto> AddVacancy(VacancyRequest request)
        {
            request.IsActive = true;
            var response = await _httpClient.PostAsJsonAsync("api/Vacancy/Add", request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var vacancy = JsonSerializer.Deserialize<VacancyViewDto>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });


            return vacancy;
        }

        public async Task<VacancyViewDto> GetVacancyByIdAsync(int vacancyId)
        {

            var response = await _httpClient.GetAsync($"/api/Vacancy/GetVacancyById?id={vacancyId}");

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var vacancy = JsonSerializer.Deserialize<VacancyViewDto>(responseContent, options);
                return vacancy;
            }

            return null;
        }

        public async Task<VacancyViewDto> UpdateVacancy(VacancyRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Vacancy/Update", request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var vacancy = JsonSerializer.Deserialize<VacancyViewDto>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return vacancy;
        }
    }
}
