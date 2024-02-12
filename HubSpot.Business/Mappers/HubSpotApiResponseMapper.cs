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
        public IEnumerable<ContactDto> MapFromApiResponseCollection(HubSpotContactListApiResponse response)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

