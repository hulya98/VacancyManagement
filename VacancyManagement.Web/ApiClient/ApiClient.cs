using VacancyManagement.Domain.Dtos.User;

namespace VacancyManagement.Web.ApiClient
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Example: GET request
        public async Task<UserViewDto> GetUserAsync(int userId)
        {
            return await _httpClient.GetFromJsonAsync<UserViewDto>($"api/users/{userId}");
        }

        // Example: POST request
        public async Task<bool> AddUserAsync(UserRequest userRequest)
        {
            var response = await _httpClient.PostAsJsonAsync("api/User/Save", userRequest);
            return response.IsSuccessStatusCode;
        }
    }

}
