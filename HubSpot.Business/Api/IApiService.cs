namespace HubSpot.Business.Api
{
    /// <summary>
    /// Interface used to define functionality that will be implemented by <see cref=ApiService/>
    /// </summary>
    public interface IApiService
    {
        public void SetBaseApiUrl(string baseApiUrl);
        public void SetAuthorizationHeader(string token);   
        public Task<TResponse> GetApiResponseAsync<TResponse>(string url);
    }
}
