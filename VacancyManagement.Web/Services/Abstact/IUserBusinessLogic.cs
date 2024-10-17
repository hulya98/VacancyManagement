using VacancyManagement.Domain.Dtos.User;

namespace VacancyManagement.Web.Services.Abstact
{
    public interface IUserBusinessLogic
    {
        Task<bool> UserExistsAsync(string email, int vacancyId);
        Task<string> SaveCVAsync(IFormFile cvFile);

        Task<ApiResult<int>> Apply(UserIncludeCVRequest request);
    }
}
