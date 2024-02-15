using HubSpot.Business.Api.Responses;
using HubSpot.Business.Connection;
using HubSpot.Business.Mappers;
using HubSpot.Business.Models;
using HubSpot.Global.Constants;
using System.Text;

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
        private List<KeyValuePair<string, string>> _optionalParameters = new List<KeyValuePair<string, string>>();

        public HubSpotApiService(
            IApiService apiService,
            IApiResponseMapper<ContactDto, HubSpotContactListApiResponse> mapper)
        {
            _apiService = apiService;
            _mapper = mapper;

            _apiService.SetBaseApiUrl(Constants.HubSpotBaseUrl);
            _apiService.SetAuthorizationHeader(Hidden.GetHubSpotApiKey());

            BuildOptionalParametersCollection();
        }

        #region GetSpecifiedListOfContactsAsync
        /// <summary>
        /// Get the Specified List of Contacts Async
        /// 
        /// Specify the List Id
        /// 
        /// Add Additional Contact Property Fields to the url
        /// 
        /// Map API Results to a Collection of DTO(s)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ContactDto>> GetSpecifiedListOfContactsAsync(int id)
        {
            try
            {
                var builder = new StringBuilder();

                var optionalParameters = ConvertOptionalParametersToQueryString();

                builder.Append($"contacts/v1/lists/{id}/contacts/all?{optionalParameters}");

                var response = await _apiService.GetApiResponseAsync<HubSpotContactListApiResponse>(builder.ToString());

                var results = _mapper.MapFromApiResponseCollection(response);

                return results;
            }
            catch (Exception) { throw; }

        }
        #endregion

        #region ConvertOptionalParametersToQueryString
        /// <summary>
        /// Convert the KeyValuePair Collection of OptionalParameters into a Single String
        /// </summary>
        /// <returns></returns>
        private string ConvertOptionalParametersToQueryString()
        {
            if (_optionalParameters.Any())
                return String.Join("&", _optionalParameters.Select(kvp => $"{kvp.Key}={kvp.Value}"));

            return string.Empty;

        }
        #endregion

        #region BuildOptionalParametersDictionary
        /// <summary>
        /// Create a KeyValuePair Collection of Optional Parameters that Can Be Added to your Query
        /// </summary>
        private void BuildOptionalParametersCollection()
        {
            _optionalParameters.Add(new KeyValuePair<string, string>("property", "vid"));
            _optionalParameters.Add(new KeyValuePair<string, string>("property", "email"));
            _optionalParameters.Add(new KeyValuePair<string, string>("property", "firstname"));
            _optionalParameters.Add(new KeyValuePair<string, string>("property", "lastname"));
            _optionalParameters.Add(new KeyValuePair<string, string>("property", "ams_member_number"));
        }
        #endregion 

    }
}
