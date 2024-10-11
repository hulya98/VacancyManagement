using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Dtos.UserVacancy
{
	public class UserVacancyViewDto
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string FullName { get; set; }
		public int VacancyId { get; set; }
		public string VacancyName { get; set; }
	}
}
