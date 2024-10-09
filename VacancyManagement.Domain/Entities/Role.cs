using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacancyManagement.Domain.Entities
{
    public sealed class Role : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
