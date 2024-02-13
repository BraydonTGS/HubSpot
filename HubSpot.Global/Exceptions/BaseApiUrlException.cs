namespace HubSpot.Global.Exceptions
{
    /// <summary>
    /// Custom Exception for when there is an issue setting the BaseApiUrl
    /// </summary>
    public class BaseApiUrlException : Exception
    {
        public BaseApiUrlException(string message) : base(message) { }
        public BaseApiUrlException(string message, Exception innerException) : base(message, innerException) { }
    }
}
