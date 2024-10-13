using System.Text.Json;
using VacancyManagement.Domain.Dtos.Vacancy;
using VacancyManagement.Domain.Dtos.VacancyRequirement;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Web.ApiClient
{
    public class VacancyRequirementAPIClient
    {
        private readonly HttpClient _httpClient;
        public VacancyRequirementAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<VacancyRequirementViewDto> AddVacancyRequirementsAsync(VacancyRequirementRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/VacancyRequirement/Add", request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var requirement = JsonSerializer.Deserialize<VacancyRequirementViewDto>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return requirement;
        }
    }
}
