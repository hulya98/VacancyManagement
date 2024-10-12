using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Entities
{
	public class UserVacancy
	{
		[Key]
		public int Id { get; set; }
		public User User { get; set; }
		public int UserId { get; set; }
		public Vacancy Vacancy { get; set; }
		public int VacancyId { get; set; }
	}
}
