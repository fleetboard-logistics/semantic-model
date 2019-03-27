using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{

    /// <summary>
    /// Fields to identify the partner or/and further data routing information
    /// </summary>
    [DisplayName("Fields to identify the partner")]
    [JsonObject("partnerIdentification")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPartnerIdentification : EdiMessageRouting
    {
        //[JsonRequired]
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

    /// <summary>
    /// Routing information to identify the parties involved in the data transfer (e.g. PartnerId, ConiziId...)
    /// </summary>
    [JsonObject("messageRouting")]
    [DisplayName("Routing information of the message")]
    [Description("Routing information to identify the parties involved in the data transfer")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiMessageRouting : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Partner Id is used to identify the real sender or receiver (e.g. 1234)
        /// </summary>
        [DisplayName("The PartnerId")]
        [Description("The partner which is sending the message to the receiving partner for further actions (e.g. 1234)")]
        [MaxLength(50)]
        public string PartnerId { get; set; }

        /// <summary>
        /// Edi Id is used to identify the technical sender or receiver (e.g. CONIZVK)
        /// </summary>
        [DisplayName("The Edi Id")]
        [Description("The Edi Id is the technical sender or receiver (e.g. CONIZVK)")]
        [StringLength(50)]
        public string EdiId { get; set; }

        /// <summary>
        /// Conizi Id is used to identify the sending or receiving Tenant/Site/App on the conizi platform 
        /// </summary>
        [DisplayName("The Conizi Id")]
        [Description("The conizi id for internal routing purposes")]
        [MaxLength(50)]
        public string ConiziId { get; set; }
        
        [JsonProperty("network", Required = Required.DisallowNull)]
        public EdiNetwork Network { get; set; }
    }
}