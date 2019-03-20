using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Base class for all partner identification stuff.
    /// Used to allow combining schemas in a JSON Schema <seealson href="https://json-schema.org/understanding-json-schema/reference/combining.html"/>
    /// </summary>
    [DisplayName("Fields to identify the partner")]
    [KnownType(typeof(EdiAddress))]
    [KnownType(typeof(EdiIdIdentification))]
    [KnownType(typeof(EdiConiziIdentification))]
    [KnownType(typeof(EdiPartner))]
    [ConiziAnyOf]
    [JsonObject("partnerIdentification")]
    public abstract class EdiPartnerIdentification
    {
    }

    /// <summary>
    /// Information about the technical sender and receiver
    /// </summary>
    [JsonObject("ediId")]
    public class EdiIdIdentification : EdiPartnerIdentification
    {
        /// <summary>
        /// Edi Id is used to identify the technical sender or receiver (e.g. CONIZVK)
        /// </summary>
        [JsonRequired]
        [DisplayName("The Edi Id")]
        [Description("The Edi Id is the technical sender or receiver (e.g. CONIZVK)")]
        [StringLength(50)]
        public string EdiId { get; set; }
    }

    /// <summary>
    /// Information about the sending or receiving partner
    /// </summary>
    [JsonObject("partnerId")]
    public class EdiPartner : EdiPartnerIdentification
    {
        /// <summary>
        /// Partner Id is used to identify the real sender or receiver (e.g. 1234)
        /// </summary>
        [JsonRequired]
        [DisplayName("The PartnerId")]
        [Description("The partner which is sending the message to the receiving partner for further actions (e.g. 1234)")]
        [MaxLength(50)]
        public string PartnerId { get; set; }
    }

    /// <summary>
    /// Information about the sending or receiving object on the conizi platform
    /// </summary>
    [JsonObject("coniziId")]
    public class EdiConiziIdentification : EdiPartnerIdentification
    {
        /// <summary>
        /// Conizi Id is used to identify the sending or receiving Tenant/Site/App on the conizi platform 
        /// </summary>
        [JsonRequired]
        [DisplayName("The Conizi Id")]
        [Description("The conizi id for internal routing purposes")]
        [MaxLength(50)]
        public string ConiziId { get; set; }
    }
}