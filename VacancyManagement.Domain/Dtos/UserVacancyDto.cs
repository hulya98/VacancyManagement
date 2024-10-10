using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Domain.Dtos
{
	public class UserVacancyDto
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int VacancyId { get; set; }
	}
}
