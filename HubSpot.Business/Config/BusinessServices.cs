using HubSpot.Business.Api;
using HubSpot.Business.Api.Responses;
using HubSpot.Business.Helpers;
using HubSpot.Business.Logging;
using HubSpot.Business.Mappers;
using HubSpot.Business.Models;
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
            // Api Services //
            services.AddScoped<HttpClient>();
            services.AddScoped<IApiService, ApiService>();
            services.AddScoped<IHubSpotApiService, HubSpotApiService>();
            services.AddScoped<IApiResponseMapper<ContactDto, HubSpotContactListApiResponse>, HubSpotApiResponseMapper>();

            // Helpers //
            services.AddSingleton<ICsvExportHelper, CsvExportHelper>();

            // Logging //
            LoggingConfig.ConfigureLogging(services);

            return services;
        }
    }
}
