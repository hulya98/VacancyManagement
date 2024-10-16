using System.Text.Json;
using VacancyManagement.Domain.Dtos.Quiz;
using VacancyManagement.Domain.Dtos.UserQuizAnswer;
using VacancyManagement.Domain.Dtos.UserVacancy;
using VacancyManagement.Domain.Dtos.Vacancy;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Web.ApiClient
{
    public class UserQuizAnswerAPIClient
    {
        private readonly HttpClient _httpClient;
        public UserQuizAnswerAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<QuizViewDto>> GetQuizzesByVacancyId(int vacancyId)
        {
            var response = await _httpClient.GetAsync($"/api/Quiz/GetAllByVacationId?vacationId={vacancyId}");

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var quizzes = JsonSerializer.Deserialize<List<QuizViewDto>>(responseContent, options);
                return quizzes;
            }
            return new();
        }

        public async Task<UserQuizAnswerViewDto> SaveUserAnswer(UserQuizAnswerRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/UserQuizAnswer/SaveUserAnswer", request);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var userQuizAnswer = JsonSerializer.Deserialize<UserQuizAnswerViewDto>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return userQuizAnswer;
        }
    }
}
