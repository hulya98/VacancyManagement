using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Domain.EntityTypeConfiguration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
			builder.HasOne(ur => ur.User)
	               .WithMany(u => u.UserRoles)
	               .HasForeignKey(ur => ur.UserId)
	               .OnDelete(DeleteBehavior.Cascade); // Cascade delete if needed

			builder.HasOne(ur => ur.Role)
					.WithMany(r => r.UserRoles)
					.HasForeignKey(ur => ur.RoleId)
					.OnDelete(DeleteBehavior.Cascade); // Cascade delete if needed

			builder.HasKey(x => new { x.RoleId, x.UserId });
            builder.HasData(new UserRole { Id = 1, RoleId = 1, UserId = 1 });

        }
    }
}
