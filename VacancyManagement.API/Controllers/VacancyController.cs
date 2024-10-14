using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacancyManagement.DataAccess.Services.Abstract;
using VacancyManagement.Domain.Dtos.Vacancy;

namespace VacancyManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VacancyController : ControllerBase
    {
        private readonly IVacancyService _vacancyService;
        private readonly IVacancyRequirementService _vacancyRequirementService;
        public VacancyController(IVacancyService vacancyService,
                                 IVacancyRequirementService vacancyRequirementService)
        {
            _vacancyService = vacancyService;
            _vacancyRequirementService = vacancyRequirementService;
        }

        [HttpGet]
        public async Task<IActionResult> GetActiveVacancies()
        {
            return Ok(await _vacancyService.GetActiveVacancies());
        }


        [HttpPost]
        public async Task<IActionResult> Add(VacancyRequest request)
        {
            var vacancy = await _vacancyService.Add(request);

            var requirements = await _vacancyRequirementService.AddRange(vacancy.Id, request.VacancyRequirements);

            return Ok(request);
        }


        [HttpPost]
        public async Task<IActionResult> Update(VacancyRequest request)
        {
            var vacancy = await _vacancyService.Update(request);

            var requirements = await _vacancyRequirementService.AddRange(request.Id, request.VacancyRequirements);

            return Ok(request);
        }


        [HttpGet]
        public async Task<IActionResult> GetVacancyById(int vacancyId)
        {
            return Ok(await _vacancyService.GetVacancyById(vacancyId));
        }


    }
}
