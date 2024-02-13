using System.Diagnostics;

namespace HubSpot.Business.Models
{
    /// <summary>
    /// Represents One Contact => Generated from the HubSpotApiResponse
    /// </summary>
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class ContactDto
    {
        public int Vid { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string AmsMemberNumber {  get; set; } = string.Empty;

        private string GetDebuggerDisplay()
        {
            return $"Vid: {Vid}, FirstName: {FirstName}, LastName: {LastName}";
        }
    }
}
