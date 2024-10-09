using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagement.Domain.Dtos.Account;

namespace VacancyManagement.DataAccess.Services.Abstract
{
    public interface ITokenService
    {
        Task<string> GenerateToken(TokenGenerationRequest request);
    }
}
