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
	public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
	{
		public void Configure(EntityTypeBuilder<Quiz> builder)
		{
			builder.HasData(
							new Quiz { Id = 1, Question = "What is the purpose of using JWT (JSON Web Tokens) in a web application?", VacancyId = 1 },
							new Quiz { Id = 2, Question = "Which of the following is a key feature of RESTful APIs?", VacancyId = 1 },
							new Quiz { Id = 3, Question = "In a microservices architecture, what is the primary role of a message broker?", VacancyId = 1 },

							new Quiz { Id = 4, Question = "What does talent management include?", VacancyId = 2 },
							new Quiz { Id = 5, Question = "What are the key factors in creating development plans?", VacancyId = 2 },
							new Quiz { Id = 6, Question = "How can a talent management specialist increase employee motivation?", VacancyId = 2 }
			);
		}
	}
}
