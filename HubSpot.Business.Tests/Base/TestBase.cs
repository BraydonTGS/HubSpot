using HubSpot.Business.Api;
using HubSpot.Business.Api.Responses;
using HubSpot.Business.Helpers;
using HubSpot.Business.Mappers;
using HubSpot.Business.Models;
using Microsoft.Extensions.DependencyInjection;


namespace HubSpot.Business.Tests.Base
{
    /// <summary>
    /// Base Class for any Business Logic Test Classes
    /// Used for Configuring Dependencies and Seeding Data if Needed
    /// </summary>
    public class TestBase
    {
        protected string _outputDirectory = @"C:ADD YOUR FILE PATH HERE\HubSpot\HubSpot.Business.Tests\TestOutput\";

        // Register Services Required for Unit Tests //
        public virtual IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // Api Services //
            services.AddScoped<HttpClient>();
            services.AddScoped<IApiService, ApiService>();
            services.AddScoped<IHubSpotApiService, HubSpotApiService>();
            services.AddScoped<IApiResponseMapper<ContactDto, HubSpotContactListApiResponse>, HubSpotApiResponseMapper>();

            // Helpers //
            services.AddSingleton<ICsvExportHelper, CsvExportHelper>();

            return services;
        }
    }
}
