using HubSpot.Business.Api;
using HubSpot.Business.Helpers;
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
        private readonly ICsvExportHelper _csvExportHelper;

        public HubSpotApiServiceTests()
        {
            _services = ConfigureServices();
            _serviceProvider = _services.BuildServiceProvider();
            _hubSpotApiService = _serviceProvider.GetRequiredService<IHubSpotApiService>();
            _csvExportHelper = _serviceProvider.GetRequiredService<ICsvExportHelper>();
        }

        [TestMethod]
        public void ConstructorNotNull_Success()
        {
            Assert.IsNotNull(_hubSpotApiService);
        }

        [TestMethod]
        public async Task HubSpotApiService_GetSpecifiedContactListAsync_Success()
        {

            var contacts = await _hubSpotApiService.GetSpecifiedListOfContactsAsync(314);

            Assert.IsNotNull(contacts);
            Assert.AreEqual(20, contacts.Count());
        }

        [TestMethod]
        public async Task HubSpotApiService_GetSpecifiedContactListAsync_EnsurePropertiesAreNotNull_Success()
        {

            var contacts = await _hubSpotApiService.GetSpecifiedListOfContactsAsync(314);

            Assert.IsNotNull(contacts);
            Assert.AreEqual(20, contacts.Count());

            foreach (var contact in contacts)
            {
                Assert.IsNotNull(contact.FirstName);
                Assert.IsNotNull(contact.LastName);
                Assert.IsNotNull(contact.Email);
                Assert.IsNotNull(contact.AmsMemberNumber);
            }
        }

        [TestMethod]
        public async Task HubSpotApiService_GetSpecifiedContactListAsync_GetFirstContact_HasRequiredProperties_Success()
        {

            var contacts = await _hubSpotApiService.GetSpecifiedListOfContactsAsync(314);

            var contact = contacts.FirstOrDefault();

            Assert.IsNotNull(contact);

            Assert.AreNotEqual(0, contact.Vid);
            Assert.IsNotNull(contact.FirstName);
            Assert.IsNotNull(contact.LastName);
            Assert.IsNotNull(contact.Email);
            Assert.IsNotNull(contact.AmsMemberNumber);

            Assert.AreEqual(1, contact.Vid);
            Assert.AreEqual("myNewName", contact.FirstName);
            Assert.AreEqual("Halligan (Sample Contact)", contact.LastName);
            Assert.AreEqual("bh@hubspot.com", contact.Email);
            Assert.AreEqual("1025478057", contact.AmsMemberNumber);

        }


        [TestMethod]
        public async Task HubSpotApiService_GetSpecifiedContactListAsync_IncorrectListSpecified_ResultsAreNull_Success()
        {

            var contacts = await _hubSpotApiService.GetSpecifiedListOfContactsAsync(46574);

            Assert.AreEqual(null, contacts);
        }

        [TestMethod]
        public async Task HubSpotApiService_GetSpecifiedContactListAsync_WriteResultsToCSV_Success()
        {

            var contacts = await _hubSpotApiService.GetSpecifiedListOfContactsAsync(314);
            Assert.IsNotNull(contacts);
            Assert.AreEqual(20, contacts.Count());

            var csvFileLocation = Path.Combine(_outputDirectory, "Contacts.csv");

            var success = _csvExportHelper.ExportRecords(contacts, csvFileLocation);

            Assert.IsTrue(success);
        }

    }
}
