
using HubSpot.Business.Models;

namespace HubSpot.Business.Api
{
    /// <summary>
    /// Interface to Define the Implementation for the <see cref="HubSpotApiService"/>
    /// </summary>
    public interface IHubSpotApiService
    {
        Task<List<ContactDto>> GetSpecifiedListOfContactsAsync(int id, bool addParameters = false);
    }
}
