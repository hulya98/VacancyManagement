using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.Domain.Dtos.Vacancy;
using VacancyManagement.Domain.Dtos.VacancyRequirement;

namespace VacancyManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacancyRequirementController : ControllerBase
    {
        private readonly IVacancyRequirementService _vacancyRequirementService;
        public VacancyRequirementController(IVacancyRequirementService vacancyRequirementService)
        {
            _vacancyRequirementService = vacancyRequirementService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllByVacancyId(int vacancyId)
        {
            return Ok(await _vacancyRequirementService.GetAllByVacancyId(vacancyId));
        }

        [HttpPost]
        public async Task<IActionResult> Add(int vacancyId, List<VacancyRequirementRequest> request)
        {
            return Ok(await _vacancyRequirementService.AddRange(vacancyId, request));
        }
    }
}
