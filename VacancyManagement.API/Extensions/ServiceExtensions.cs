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
		}
	}
}
