using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Dtos.User
{
	public class UserViewDto
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string FullName => string.Join(" ", FirstName, LastName);
		public string? Password { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
	}
}
