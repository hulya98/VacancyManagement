using VacancyManagement.DataAccess.Repositories.Abstract;
using VacancyManagement.DataAccess.Repositories.Implementation;
using VacancyManagement.DataAccess.UnitOfWork;

namespace VacancyManagement.API.Extensions
{
	public static class RepositoryExtensions
	{
		public static void AddRepositoryExtensions(this WebApplicationBuilder builder)
		{
			builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
			builder.Services.AddScoped<IUserRepository, UserRepository>();
			builder.Services.AddScoped<IUserVacancyRepository, UserVacancyRepository>();

		}
	}
}
