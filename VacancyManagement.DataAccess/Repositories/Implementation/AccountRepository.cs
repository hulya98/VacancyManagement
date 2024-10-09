using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain;
using VacancyManagement.Domain.Entities;

namespace VacancyManagement.DataAccess.Repositories.Implementation
{
    public class AccountRepository : Repository<AppUser>
    {
        public AccountRepository(Context context) : base(context)
        {
        }
    }
}
