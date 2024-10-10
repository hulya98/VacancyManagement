﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Entities;
using System.Reflection.Emit;

namespace VacancyManagement.Domain.EntityTypeConfiguration
{
	internal class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasData(
						   new User { Id = 1, FirstName = "Admin", LastName = "Admin", Password = "123", Email = "qeriblih@gmail.com", PhoneNumber = "+994 51 359 86 44" }
			);
		}
	}
}
