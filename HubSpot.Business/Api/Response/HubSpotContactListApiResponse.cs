using Newtonsoft.Json;

namespace HubSpot.Business.Api.Response
{
    /// <summary>
    /// HubSpot API Response Object - Contact List
    /// 
    /// This is used to Deserialize the API Results when making an API request
    /// 
    /// Used Postman to test the End Point to get the JSON
    /// 
    /// Generated with: https://json2csharp.com/ 
    /// 
    /// Important Properties 
    /// vid, email, firstname, lastname, and ams_member_number. 
    /// </summary>
    public class HubSpotContactListApiResponse
    {
        [JsonProperty("contacts")]
        public List<Contact> contacts { get; set; }

        [JsonProperty("has-more")]
        public bool hasmore { get; set; }

        [JsonProperty("vid-offset")]
        public int vidoffset { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AmsMemberNumber
    {
        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class Contact
    {
        [JsonProperty("vid")]
        public int vid { get; set; }

        [JsonProperty("canonical-vid")]
        public int canonicalvid { get; set; }

        [JsonProperty("merged-vids")]
        public List<object> mergedvids { get; set; }

        [JsonProperty("portal-id")]
        public int portalid { get; set; }

        [JsonProperty("is-contact")]
        public bool iscontact { get; set; }

        [JsonProperty("properties")]
        public Properties properties { get; set; }

        [JsonProperty("form-submissions")]
        public List<object> formsubmissions { get; set; }

        [JsonProperty("identity-profiles")]
        public List<IdentityProfile> identityprofiles { get; set; }

        [JsonProperty("merge-audits")]
        public List<object> mergeaudits { get; set; }

        [JsonProperty("addedAt")]
        public object addedAt { get; set; }
    }

    public class Email
    {
        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class Firstname
    {
        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class Identity
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }

        [JsonProperty("timestamp")]
        public object timestamp { get; set; }

        [JsonProperty("is-primary")]
        public bool? isprimary { get; set; }
    }

    public class IdentityProfile
    {
        [JsonProperty("vid")]
        public int vid { get; set; }

        [JsonProperty("saved-at-timestamp")]
        public object savedattimestamp { get; set; }

        [JsonProperty("deleted-changed-timestamp")]
        public int deletedchangedtimestamp { get; set; }

        [JsonProperty("identities")]
        public List<Identity> identities { get; set; }
    }

    public class Lastmodifieddate
    {
        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class Lastname
    {
        [JsonProperty("value")]
        public string value { get; set; }
    }

    public class Properties
    {
        [JsonProperty("firstname")]
        public Firstname firstname { get; set; }

        [JsonProperty("ams_member_number")]
        public AmsMemberNumber ams_member_number { get; set; }

        [JsonProperty("lastmodifieddate")]
        public Lastmodifieddate lastmodifieddate { get; set; }

        [JsonProperty("email")]
        public Email email { get; set; }

        [JsonProperty("lastname")]
        public Lastname lastname { get; set; }
    }
}
