using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace VacancyManagement.Web
{
	public class GlobalExceptionFilter : IExceptionFilter
	{
		private readonly ILogger<GlobalExceptionFilter> _logger;

		public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger)
		{
			_logger = logger;
		}

		public void OnException(ExceptionContext context)
		{
			// Log the exception
			_logger.LogError(context.Exception, "An unhandled exception occurred.");

			// Return a view for an error page
			var result = new ViewResult { ViewName = "Error" };
            result.ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), context.ModelState)
			{
			    { "ErrorMessage", "An error occurred while processing your request." }
			};
			context.Result = result;

			// Mark the exception as handled
			context.ExceptionHandled = true;
		}
	}
}
