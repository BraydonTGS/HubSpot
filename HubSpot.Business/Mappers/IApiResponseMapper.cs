namespace HubSpot.Business.Mappers
{
    /// <summary>
    /// Interface to Define the Implementation for any Custom API Mapper
    /// </summary>
    /// <typeparam name="TDto">Type of DTO to Map To</typeparam>
    /// <typeparam name="TApiResponse">Request from the API</typeparam>
    public interface IApiResponseMapper<TDto, TApiResponse>
    {
        public IEnumerable<TDto> MapFromApiResponseCollection(TApiResponse response);
    }
}
