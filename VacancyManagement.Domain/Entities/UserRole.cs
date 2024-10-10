using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Entities
{
    public sealed class UserRole : BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }   // Foreign key to User
		public User User { get; set; }     // Navigation property to User

		public int RoleId { get; set; }    // Foreign key to Role
		public Role Role { get; set; }      // Nav
	}
}
