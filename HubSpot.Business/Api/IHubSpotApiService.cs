
using HubSpot.Business.Models;

namespace HubSpot.Business.Api
{
    /// <summary>
    /// Interface to Define the Implementation for the <see cref="HubSpotApiService"/>
    /// </summary>
    public interface IHubSpotApiService
    {
        Task<IEnumerable<ContactDto>> GetSpecifiedListOfContactsAsync(int id);
    }
}
