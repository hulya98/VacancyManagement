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
	public class VacancyRequirementConfiguration : IEntityTypeConfiguration<VacancyRequirement>
	{
		public void Configure(EntityTypeBuilder<VacancyRequirement> builder)
		{
			builder.HasData(
							new VacancyRequirement { Id = 1, VacancyId = 1, Requirement = "Sərbəst araşdırma bacarığı;" },
							new VacancyRequirement { Id = 2, VacancyId = 1, Requirement = "Komanda ilə işləmək bacarığı;" },
							new VacancyRequirement { Id = 3, VacancyId = 1, Requirement = "Yaradıcı düşünmə və problemləri həll etmə bacarığı;" },
							new VacancyRequirement { Id = 4, VacancyId = 1, Requirement = "C# OOP üzrə biliklər;" },
							new VacancyRequirement { Id = 5, VacancyId = 1, Requirement = "NET Core üzrə biliklər;" },

							new VacancyRequirement { Id = 6, VacancyId = 2, Requirement = "Şirkətdaxili istedad bazasının təşkili üçün aidiyyatı struktur rəhbərləri ilə birgə işlərin görülməsi;" },
							new VacancyRequirement { Id = 7, VacancyId = 2, Requirement = "İstedadların performans göstəricilərinin analiz olunması;" },
							new VacancyRequirement { Id = 8, VacancyId = 2, Requirement = "İstedadların davamlı inkişafına dəstək göstərilməsi;" },
							new VacancyRequirement { Id = 9, VacancyId = 2, Requirement = "İntranet Platformasının yeni funksionallıqlarla mütəmadi inkişaf etdirilməsi və effektivliyinə nəzarət;" },
							new VacancyRequirement { Id = 10, VacancyId = 2, Requirement = "Key role, critical skills holder və high potential anlayışlara dair müvafiq təsvirin və kriteriyaların formalaşdırmaq;" }
			);
		}
	}
}
