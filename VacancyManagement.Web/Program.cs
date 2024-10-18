using FluentValidation;
using FluentValidation.AspNetCore;
using System.Text.Json.Serialization;
using VacancyManagement.Domain.Validation;
using VacancyManagement.Web;
using VacancyManagement.Web.ApiClient;
using VacancyManagement.Web.Services.Abstact;
using VacancyManagement.Web.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(
    options =>
{
    options.Filters.Add(new ValidationFilter());
    options.Filters.Add<GlobalExceptionFilter>();
	options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true;
}).AddJsonOptions(options => { options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; })
    .Services
    .AddFluentValidationAutoValidation()
    .AddFluentValidationClientsideAdapters();



builder.Services.AddValidatorsFromAssemblyContaining<ValidationFilter>();

builder.Services.AddScoped<IUserBusinessLogic, UserBusinessLogic>();
Configuration.ConfigureHttpClient<UserAPIClient>(builder.Services);
Configuration.ConfigureHttpClient<VacancyAPIClient>(builder.Services);
Configuration.ConfigureHttpClient<UserVacancyAPIClient>(builder.Services);
Configuration.ConfigureHttpClient<UserQuizAnswerAPIClient>(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{

    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
