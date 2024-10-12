namespace VacancyManagement.Web
{
    public static class Configuration
    {
        public static void ConfigureHttpClient<TClient>(IServiceCollection services) where TClient : class
        {
            var baseUrl = "https://localhost:7119/";
            services.AddHttpClient<TClient>(client =>
            {
                client.BaseAddress = new Uri(baseUrl);
            });
        }

    }
}
