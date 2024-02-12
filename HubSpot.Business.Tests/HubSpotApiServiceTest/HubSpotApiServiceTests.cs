using HubSpot.Business.Api;
using HubSpot.Business.Tests.Base;
using Microsoft.Extensions.DependencyInjection;

namespace HubSpot.Business.Tests.HubSpotApiTest
{
    [TestClass]
    public class HubSpotApiServiceTests : TestBase
    {
        private readonly IServiceCollection _services;
        private readonly IServiceProvider _serviceProvider;
        private readonly IHubSpotApiService _hubSpotApiService;

        public HubSpotApiServiceTests()
        {
            _services = ConfigureServices();
            _serviceProvider = _services.BuildServiceProvider();
            _hubSpotApiService = _serviceProvider.GetRequiredService<IHubSpotApiService>();
        }

        [TestMethod]
        public void ConstructorNotNull_Success()
        {
            Assert.IsNotNull(_hubSpotApiService);
        }
    }
}
