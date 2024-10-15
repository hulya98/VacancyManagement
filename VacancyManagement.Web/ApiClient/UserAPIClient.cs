using VacancyManagement.Domain.Dtos.User;

namespace VacancyManagement.Web.ApiClient
{
    public class UserAPIClient
    {
        private readonly HttpClient _httpClient;

        public UserAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<bool> AddUserAsync(UserIncludeCVRequest userRequest)
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
            return response.IsSuccessStatusCode;
        }


    }
}
