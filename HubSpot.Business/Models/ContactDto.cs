namespace HubSpot.Business.Models
{
    /// <summary>
    /// Represents One Contact => Generated from the HubSpotApiResponse
    /// </summary>
    public class ContactDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
