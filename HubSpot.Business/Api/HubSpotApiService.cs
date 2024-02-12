using HubSpot.Business.Api.Response;
using HubSpot.Business.Connection;
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

        public HubSpotApiService(IApiService apiService)
        {
            _apiService = apiService;
            _apiService.SetBaseApiUrl(Constants.HubSpotBaseUrl);
            _apiService.SetAuthorizationHeader(Hidden.GetHubSpotApiKey());
        }

        #region GetSpecifiedListOfContactsAsync
        public async Task<List<ContactDto>> GetSpecifiedListOfContactsAsync(int id)
        {
            try
            {
                var url = $"https://api.hubapi.com/contacts/v1/lists/{id}/contacts/all?property=vid&property=email&property=firstname&property=lastname&property=ams_member_number";

                var contactList = await _apiService.GetApiResponseAsync<HubSpotContactListApiResponse>(url);

                return new List<ContactDto>();
            }
            catch (Exception ex)
            {

                throw;
            }
   
        }
        #endregion

    }
}
