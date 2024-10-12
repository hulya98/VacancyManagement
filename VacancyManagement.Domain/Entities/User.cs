using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace VacancyManagement.Domain.Entities
{
	public class User : BaseEntity
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string FullName => string.Join(" ", FirstName, LastName);
		public string? Password { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string? CVName { get; set; }
		public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
		public ICollection<UserVacancy> UserVacancies { get; set; } = new List<UserVacancy>();
	}
}
