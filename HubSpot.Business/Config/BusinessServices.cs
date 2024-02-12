using HubSpot.Business.Api;
using Microsoft.Extensions.DependencyInjection;

namespace HubSpot.Business.Config
{
    public static class BusinessServices
    {
        /// <summary>
        /// Register any Dependencies Needed for the Business Project
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureBusinessServices(IServiceCollection services)
        {
            // Services //
            services.AddScoped<HttpClient>();
            services.AddScoped<IApiService, ApiService>();

            return services;
        }
    }
}
