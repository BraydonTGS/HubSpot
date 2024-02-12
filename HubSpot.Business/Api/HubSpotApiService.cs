using HubSpot.Business.Api.Responses;
using HubSpot.Business.Connection;
using HubSpot.Business.Mappers;
using HubSpot.Business.Models;
using HubSpot.Global.Constants;

namespace HubSpot.Business.Api
{
    /// <summary>
    /// HubSpotApiService Class 
    /// 
    /// Used for interacting with the HubSpotApi
    /// </summary>
    public class HubSpotApiService : IHubSpotApiService
    {
        private readonly IApiService _apiService;
        private readonly IApiResponseMapper<ContactDto, HubSpotContactListApiResponse> _mapper;

        public HubSpotApiService(IApiService apiService,
            IApiResponseMapper<ContactDto, HubSpotContactListApiResponse> mapper)
        {
            _apiService = apiService;
            _mapper = mapper;

            _apiService.SetBaseApiUrl(Constants.HubSpotBaseUrl);
            _apiService.SetAuthorizationHeader(Hidden.GetHubSpotApiKey());
        }

        #region GetSpecifiedListOfContactsAsync
        /// <summary>
        /// Get the Specified List of Contacts Async
        /// 
        /// Todo: Update Method to Add Parameters based on if the User wants to filter.
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="addParameters"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ContactDto>> GetSpecifiedListOfContactsAsync(int id, bool addParameters = false)
        {
            try
            {
                var route = $"contacts/v1/lists/{id}/contacts/all?property=vid&property=email&property=firstname&property=lastname&property=ams_member_number";

                var response = await _apiService.GetApiResponseAsync<HubSpotContactListApiResponse>(route);

                var results = _mapper.MapFromApiResponseCollection(response);

                return results;
            }
            catch (Exception) { throw; }

        }
        #endregion

    }
}
