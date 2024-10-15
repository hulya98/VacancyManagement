using VacancyManagement.Domain.Dtos.User;
using VacancyManagement.Web.ApiClient;

namespace VacancyManagement.Web.Validations
{
    public static class UserValidation
    {
        public static async Task<bool> UserIsExist(UserVacancyAPIClient apiClient, string email, int vacancyId)
        {
            var users = await apiClient.GetAllAppliesAsync();
            var user = users.Where(x => x.Email == email &&
                                        x.VacancyId == vacancyId).FirstOrDefault();

            if (user != null)
                return true;

            return false;

        }

    }
}
