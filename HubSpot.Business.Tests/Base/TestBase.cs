using HubSpot.Business.Api;
using Microsoft.Extensions.DependencyInjection;

namespace HubSpot.Business.Tests.Base
{
    public class TestBase
    {
        // Register Services Required for Unit Tests //
        public virtual IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // Api Services //
            services.AddScoped<HttpClient>();
            services.AddScoped<IApiService, ApiService>();
            services.AddScoped<IHubSpotApiService, HubSpotApiService>();

            return services;
        }
    }
}
