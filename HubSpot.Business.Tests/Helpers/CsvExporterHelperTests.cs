using HubSpot.Business.Api;
using HubSpot.Business.Helpers;
using HubSpot.Business.Tests.Base;
using Microsoft.Extensions.DependencyInjection;

namespace HubSpot.Business.Tests.Helpers
{
    [TestClass]
    public class CsvExporterHelperTests : TestBase
    {
        private readonly IServiceCollection _services;
        private readonly IServiceProvider _serviceProvider;
        private readonly ICsvExportHelper _csvExportHelper;
        public CsvExporterHelperTests()
        {
            _services = ConfigureServices();
            _serviceProvider = _services.BuildServiceProvider();
            _csvExportHelper = _serviceProvider.GetRequiredService<ICsvExportHelper>();
        }

        [TestMethod]
        public void ConstructorNotNull_Success()
        {
            Assert.IsNotNull(_csvExportHelper);
        }
    }
}
