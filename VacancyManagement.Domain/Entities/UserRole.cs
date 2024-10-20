﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Entities
{
    public sealed class UserRole : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }   
		public User User { get; set; }    

		public int RoleId { get; set; }   
		public Role Role { get; set; }    
	}
}
