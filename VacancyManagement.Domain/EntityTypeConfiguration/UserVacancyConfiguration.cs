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
    public class UserVacancyConfiguration : IEntityTypeConfiguration<UserVacancy>
    {
        public void Configure(EntityTypeBuilder<UserVacancy> builder)
        {
            builder
                  .Property(u => u.Id)
                  .ValueGeneratedOnAdd();

            builder.HasOne(ur => ur.User)
                   .WithMany(u => u.UserVacancies)
                   .HasForeignKey(ur => ur.UserId)
                   .OnDelete(DeleteBehavior.Cascade); // Cascade delete if needed

            builder.HasOne(ur => ur.Vacancy)
                    .WithMany(r => r.UserVacancies)
                    .HasForeignKey(ur => ur.VacancyId)
                    .OnDelete(DeleteBehavior.Cascade); // Cascade delete if needed

            builder.HasKey(x => new { x.Id });

        }
    }
}
