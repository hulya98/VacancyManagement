using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VacancyManagement.Domain.Validation
{
    public class ValidationFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var modelState = context.ModelState;
            if (!modelState.IsValid)
            {
                var errorTex = modelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                var propert = modelState
               .Where(x => x.Value.Errors.Count > 0)
               .Select(x => x.Key.Split(".").Last())
               .ToList();
                context.Result = new ObjectResult(new
                {
                    StatusCode = 422,
                    ErrorMessage = errorTex
                });
            }
        }
    }
}
