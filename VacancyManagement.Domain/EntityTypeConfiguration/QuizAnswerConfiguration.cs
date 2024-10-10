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
	public class QuizAnswerConfiguration : IEntityTypeConfiguration<QuizAnswer>
	{
		public void Configure(EntityTypeBuilder<QuizAnswer> builder)
		{
			builder.HasData(
							new QuizAnswer { Id = 1, QuizId = 1, Item = "A", Title = "To store session data on the client side" },
							new QuizAnswer { Id = 2, QuizId = 1, Item = "B", Title = "To authenticate users and manage user sessions securely", IsCorrect = true },
							new QuizAnswer { Id = 3, QuizId = 1, Item = "C", Title = "To encrypt all user data" },

							new QuizAnswer { Id = 4, QuizId = 2, Item = "A", Title = "They always require a message queue" },
							new QuizAnswer { Id = 5, QuizId = 2, Item = "B", Title = "They use HTTP methods like GET, POST, PUT, DELETE", IsCorrect = true },
							new QuizAnswer { Id = 6, QuizId = 2, Item = "C", Title = "They require a relational database for data storage" },

							new QuizAnswer { Id = 7, QuizId = 3, Item = "A", Title = "To enable communication and data exchange between services asynchronously", IsCorrect = true },
							new QuizAnswer { Id = 8, QuizId = 3, Item = "B", Title = "To handle authentication across all services" },
							new QuizAnswer { Id = 9, QuizId = 3, Item = "C", Title = "To ensure that each service runs on a different server" },

							new QuizAnswer { Id = 10, QuizId = 4, Item = "A", Title = "Only hiring and firing employees" },
							new QuizAnswer { Id = 11, QuizId = 4, Item = "B", Title = "Financial management" },
							new QuizAnswer { Id = 12, QuizId = 4, Item = "C", Title = "Selecting, developing, and retaining employees with long-term strategies", IsCorrect = true },

							new QuizAnswer { Id = 13, QuizId = 5, Item = "A", Title = "Employee skills and organizational needs", IsCorrect = true },
							new QuizAnswer { Id = 14, QuizId = 5, Item = "B", Title = "Only the directives from the managers" },
							new QuizAnswer { Id = 15, QuizId = 5, Item = "C", Title = "The company's revenue reports" },

							new QuizAnswer { Id = 16, QuizId = 6, Item = "A", Title = "By offering only financial rewards", IsCorrect = true },
							new QuizAnswer { Id = 17, QuizId = 6, Item = "B", Title = "By providing career development opportunities and fostering employee growth" },
							new QuizAnswer { Id = 18, QuizId = 6, Item = "C", Title = "By forcing them to attend monthly training sessions" }
			);
		}
	}
}
