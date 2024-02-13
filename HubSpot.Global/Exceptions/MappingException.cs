namespace HubSpot.Global.Exceptions
{
    /// <summary>
    /// Custom exception class for Mapping-related errors
    /// </summary>
    public class MappingException : Exception
    {
        public MappingException(string message) : base(message) { }
        public MappingException(string message, Exception innerException) : base(message, innerException) { }
    }
}
