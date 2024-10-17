using System.Text.Json;
using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Dtos.Vacancy;

namespace VacancyManagement.Web.ApiClient
{
    public class UserAPIClient
    {
        private readonly HttpClient _httpClient;

        public UserAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<UserVacancyViewDto> AddUserAsync(UserIncludeCVRequest userRequest)
        {
            UserRequest request = new UserRequest
            {
                CVName = userRequest.CVName,
                Email = userRequest.Email,
                FirstName = userRequest.FirstName,
                LastName = userRequest.LastName,
                Id = userRequest.Id,
                PhoneNumber = userRequest.PhoneNumber,
                VacancyId = userRequest.VacancyId,
            };
            var response = await _httpClient.PostAsJsonAsync("api/User/Add", request);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var userVacancy = JsonSerializer.Deserialize<UserVacancyViewDto>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return userVacancy;
        }


    }
}
