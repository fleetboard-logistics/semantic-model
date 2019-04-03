using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{

    /// <summary>
    /// Fields to save address relevant data
    /// </summary>
    [DisplayName("Address fields")]
    [JsonObject("ediAddress")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiAddress : IAddress
    {
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
        public string EmailAddress { get; set; }
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
        [DisplayName("An address reference")]
        public string Reference { get; set; }
    }
}
