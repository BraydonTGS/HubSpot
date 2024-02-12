using HubSpot.Business.Connection;
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
        public async Task GetSpecifiedListOfContactsAsync(int id)
        {
            return;
        }
        #endregion

    }
}
