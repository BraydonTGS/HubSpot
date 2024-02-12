using HubSpot.Business.Api.Response;
using HubSpot.Business.Models;

namespace HubSpot.Business.Mappers
{
    /// <summary>
    /// HubSpotApiResponseMapper - Map from the <see cref="HubSpotContactListApiResponse"/> a Collection of <see cref="ContactDto"/>
    /// </summary>
    public class HubSpotApiResponseMapper : IApiResponseMapper<ContactDto, HubSpotContactListApiResponse>
    {
        public HubSpotApiResponseMapper() { }

        #region MapFromApiResponseCollection
        /// <summary>
        /// Main Method for Mapping from the <see cref="HubSpotContactListApiResponse"/> to a Collection of <see cref="ContactDto"/>
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public IEnumerable<ContactDto> MapFromApiResponseCollection(HubSpotContactListApiResponse response)
        {
            var contacts = new List<ContactDto>();


            return contacts;
        }
        #endregion
    }
}

