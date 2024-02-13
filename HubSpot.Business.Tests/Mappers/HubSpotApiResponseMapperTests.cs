using HubSpot.Business.Api.Responses;
using HubSpot.Business.Mappers;
using HubSpot.Business.Models;
using HubSpot.Business.Tests.Base;
using Microsoft.Extensions.DependencyInjection;

namespace HubSpot.Business.Tests.Mappers
{
    [TestClass]
    public class HubSpotApiResponseMapperTests : TestBase
    {
        private readonly IServiceCollection _services;
        private readonly IServiceProvider _serviceProvider;
        private readonly IApiResponseMapper<ContactDto, HubSpotContactListApiResponse> _mapper;
        public HubSpotApiResponseMapperTests()
        {
            _services = ConfigureServices();
            _serviceProvider = _services.BuildServiceProvider();
            _mapper = _serviceProvider.GetRequiredService<IApiResponseMapper<ContactDto, HubSpotContactListApiResponse>>();
        }

        [TestMethod]
        public void ConstructorNotNull_Success()
        {
            Assert.IsNotNull(_mapper);
        }
    }
}
