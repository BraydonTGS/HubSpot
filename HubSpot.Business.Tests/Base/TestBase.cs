using HubSpot.Business.Config;
using Microsoft.Extensions.DependencyInjection;


namespace HubSpot.Business.Tests.Base
{
    /// <summary>
    /// Base Class for any Business Logic Test Classes
    /// Used for Configuring Dependencies and Seeding Data if Needed
    /// </summary>
    public class TestBase
    {
        protected string _outputDirectory = @"C:\Users\brayd\Documents\repos\HubSpot\HubSpot.Business.Tests\TestOutput\";

        // Register Services Required for Unit Tests //
        public virtual IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register Business Dependencies //
            BusinessServices.ConfigureBusinessServices(services);

            return services;
        }
    }
}
