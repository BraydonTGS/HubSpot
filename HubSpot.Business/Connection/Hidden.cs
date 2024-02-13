namespace HubSpot.Business.Connection
{
    /// <summary>
    /// Hidden File
    /// 
    /// Connection Strings
    /// 
    /// URLs
    /// 
    /// API Keys
    /// 
    ///Git Ignore This File After You Clone
    /// </summary>
    public static class Hidden
    {
        private static string _connectionString { get; set; } = "";

        /// <summary>
        /// Add the HubSpotApi Key Here
        /// </summary>
        private static string _hubSpotApiKey { get; set; } = "";

        /// <summary>
        /// Get the DataBase Connection String
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            return _connectionString;
        }

        /// <summary>
        /// Used to get the Specified API Key if Applicable. 
        /// </summary>
        /// <returns></returns>
        public static string GetHubSpotApiKey()
        {
            return _hubSpotApiKey;
        }
    }
}
