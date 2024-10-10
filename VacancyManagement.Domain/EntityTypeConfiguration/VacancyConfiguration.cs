using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Domain.EntityTypeConfiguration
{
	public class VacancyConfiguration : IEntityTypeConfiguration<Vacancy>
	{
		public void Configure(EntityTypeBuilder<Vacancy> builder)
		{
			builder.HasData(
							new Vacancy { Id = 1, Name = "BACK-END DEVELOPER", IsActive = true },
							new Vacancy { Id = 2, Name = "İstedadların idarəolunması və inkişaf üzrə mütəxəssis", IsActive = true }
			);
		}
	}
}
