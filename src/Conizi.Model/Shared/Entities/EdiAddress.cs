using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [DisplayName("Address relevant fields")]
    [JsonObject("address")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiAddress : EdiPartnerIdentification
    {
        [JsonRequired]
        [DisplayName("Name of the address")]
        public string Name { get; set; }
        [DisplayName("Street of the address")]
        public string Street { get; set; }
        [DisplayName("House number of the address")]
        public string HouseNumber { get; set; }
        [DisplayName("Zip code of the Address")]
        public string ZipCode { get; set; }
        [DisplayName("City of the address")]
        public string City { get; set; }
        [DisplayName("Town area address")]
        public string TownArea { get; set; }
        [DisplayName("Country code of the address")]
        public string CountryCode { get; set; }
        [DisplayName("Email of the address")]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        [DisplayName("Phone number of the address")]
        public string PhoneNumber { get; set; }
        [DisplayName("Additional address lines of the address")]
        public List<string> AdditionalAddressLines { get; set; }
        [DisplayName("Reference number of the consignment")]
        public string ReferenceNumber { get; set; }
        [DisplayName("The contact person")]
        public string ContactPerson { get; set; }
        [Phone]
        [DisplayName("The Fax number")]
        public string FaxNumber { get; set; }
    }
}
