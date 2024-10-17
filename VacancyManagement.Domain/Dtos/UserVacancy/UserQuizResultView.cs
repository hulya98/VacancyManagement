using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.RawSqlDtos;

namespace VacancyManagement.Domain.Dtos.UserVacancy
{
	public class UserQuizResultView
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public Entities.User User { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public Entities.Vacancy Vacancy { get; set; }
		public int VacancyId { get; set; }
		public string VacancyName { get; set; }
		public string CVName { get; set; }
		public decimal Result { get; set; }
		public List<QuizAnswerCompare> QuizResults { get; set; }
	}
}
