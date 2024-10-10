using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.Domain.Dtos.User
{
    public class UserRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] CV { get; set; }
        public string CVName { get; set; }
    }
}
