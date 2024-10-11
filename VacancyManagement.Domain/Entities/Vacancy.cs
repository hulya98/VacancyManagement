using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Entities
{
	public class Vacancy
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsActive { get; set; }
		public ICollection<VacancyRequirement> VacancyRequirements { get; set; }
		public ICollection<UserVacancy> UserVacancies { get; set; }
	}
}
