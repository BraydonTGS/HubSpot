using HubSpot.Business.Connection;
using HubSpot.Global.Constants;
using HubSpot.Global.Exceptions;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace HubSpot.Business.Api
{
    /// <summary>
    /// ApiService 
    /// </summary>
    public class ApiService : IApiService
    {
        private string _baseApiUrl { get; set; } = string.Empty;
        private readonly HttpClient _client;

        public ApiService(HttpClient client) => _client = client ?? throw new ArgumentNullException(nameof(client));

        #region SetBaseApiUrl
        public void SetBaseApiUrl(string baseApiUrl)
        {
            if (string.IsNullOrEmpty(baseApiUrl)) { throw new BaseApiUrlException("The Base API URL can not be Null or Empty"); }
            _baseApiUrl = baseApiUrl;
        }
        #endregion

        #region AddBearerToken
        public void SetAuthorizationHeader(string token)
        {
            if (_client is not null)
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.Bearer, token);
        }
        #endregion

        #region GetApiResponseAsync
        public async Task<TResponse> GetApiResponseAsync<TResponse>(string route)
        {
            try
            {
                var url = $"{_baseApiUrl}{route}";

                var response = await _client.GetStringAsync(url);

                var results = JsonConvert.DeserializeObject<TResponse>(response);

                if (results is null) return Activator.CreateInstance<TResponse>();

                return results;
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(JsonSerializationException))
                {
                    throw new JsonException("An error occurred while deserializing the API response.", ex);
                }
                else
                    throw new ApiException("An error occurred while processing the request.", ex);
            }
        }
        #endregion
    }
}
