using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.DataAccess.Services.Implementation;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServiceExtensions(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUserVacancyService, UserVacancyService>();
            builder.Services.AddScoped<IVacancyService, VacancyService>();
            builder.Services.AddScoped<IVacancyRequirementService, VacancyRequirementService>();
        }
    }
}
