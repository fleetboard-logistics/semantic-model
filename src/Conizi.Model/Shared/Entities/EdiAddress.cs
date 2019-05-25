using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Shared.Entities
{

    /// <summary>
    /// Fields to save address relevant data
    /// </summary>
    [DisplayName("Address fields")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiAddress : EdiPatternPropertiesBase, IAddress
    {
        /// <summary>
        /// Name of the address
        /// </summary>
        [DisplayName("Name of the address")]
        public string Name { get; set; }

        /// <summary>
        /// Street of the address
        /// </summary>
        [DisplayName("Street of the address")]
        public string Street { get; set; }

        /// <summary>
        /// House number of the address
        /// </summary>
        [DisplayName("House number of the address")]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Zip code of the Address
        /// </summary>
        [DisplayName("Zip code of the Address")]
        public string ZipCode { get; set; }

        /// <summary>
        /// City of the address
        /// </summary>
        [DisplayName("City of the address")]
        public string City { get; set; }

        /// <summary>
        /// Town area address"
        /// </summary>
        [DisplayName("Town area address")]
        public string TownArea { get; set; }

        /// <summary>
        /// Country code of the address Use ISO 3166-1 Alpha-2 codes. See also <seealso href="https://en.wikipedia.org/wiki/ISO_3166-1"></seealso>
        /// </summary>
        [DisplayName("Country code of the address Use ISO 3166-1 Alpha-2 codes.")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Email of the address
        /// </summary>
        [DisplayName("Email of the address")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Phone number of the address
        /// </summary>
        [Phone]
        [DisplayName("Phone number of the address")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Additional address lines of the address
        /// </summary>
        [DisplayName("Additional address lines of the address")]
        public List<string> AdditionalAddressLines { get; set; }

        /// <summary>
        /// Reference number for an address
        /// </summary>
        [DisplayName("Reference number for an address")]
        public string Reference { get; set; }

        /// <summary>
        /// The contact person
        /// </summary>
        [DisplayName("The contact person")]
        public string ContactPerson { get; set; }

        /// <summary>
        /// The Fax number
        /// </summary>
        [Phone]
        [DisplayName("The Fax number")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// The geo position
        /// </summary>
        [JsonProperty("geoPosition", Order = -9, Required = Required.DisallowNull)]
        public EdiGeoPosition GeoPosition { get; set; }
    }
}
