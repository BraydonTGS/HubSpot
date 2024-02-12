using HubSpot.Business.Api.Responses;
using HubSpot.Business.Models;

namespace HubSpot.Business.Mappers
{
    /// <summary>
    /// HubSpotApiResponseMapper - Map from the <see cref="HubSpotContactListApiResponse"/> a Collection of <see cref="ContactDto"/>
    /// 
    /// Todo: Logging, Exception Handling, Custom Exception for a Mapping Error
    /// </summary>
    public class HubSpotApiResponseMapper : IApiResponseMapper<ContactDto, HubSpotContactListApiResponse>
    {
        public HubSpotApiResponseMapper() { }

        #region MapFromApiResponseCollection
        /// <summary>
        /// Main Method for Mapping from the <see cref="HubSpotContactListApiResponse"/> to a Collection of <see cref="ContactDto"/>
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public IEnumerable<ContactDto> MapFromApiResponseCollection(HubSpotContactListApiResponse response)
        {
            try
            {
                if (response?.contacts is null) return null;

                if (!response.contacts.Any()) return null;

                var contacts = new List<ContactDto>();

                GenerateContactsFromApiResponse(contacts, response.contacts);

                return contacts;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region GenerateContactsFromApiResponse
        /// <summary>
        /// Mapping from the API Contacts Collection to the DTO Contacts Collections
        /// 
        /// Passed by Reference
        /// </summary>
        /// <param name="contacts"></param>
        /// <param name="apiContacts"></param>
        private void GenerateContactsFromApiResponse(List<ContactDto> contacts, List<Contact> apiContacts)
        {

            foreach (var contact in apiContacts)
            {
                var dto = new ContactDto();

                var vid = 0; var firstName = ""; var lastName = ""; var email = ""; var amsMemberNumber = "";

                if (contact.properties is not null)
                {
                    if (contact.vid != 0) { vid = contact.vid; }
                    if (!string.IsNullOrEmpty(contact.properties.firstname?.value)) { firstName = contact.properties.firstname.value; }
                    if (!string.IsNullOrEmpty(contact.properties.lastname?.value)) { lastName = contact.properties.lastname.value; }
                    if (!string.IsNullOrEmpty(contact.properties.email?.value)) { email = contact.properties.email.value; }
                    if (contact.properties.ams_member_number?.value != null) { amsMemberNumber = contact.properties.ams_member_number.value; }
                }
                if (vid != 0)
                    dto.Id = vid; dto.FirstName = firstName; dto.LastName = lastName; dto.Email = email; dto.AmsMemberNumber = amsMemberNumber; contacts.Add(dto);
            }
        }
        #endregion
    }
}

