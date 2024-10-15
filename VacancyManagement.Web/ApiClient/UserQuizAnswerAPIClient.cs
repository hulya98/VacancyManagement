using System.Text.Json;
using VacancyManagement.Domain.Dtos.Quiz;
using VacancyManagement.Domain.Dtos.Vacancy;

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
    }
}
