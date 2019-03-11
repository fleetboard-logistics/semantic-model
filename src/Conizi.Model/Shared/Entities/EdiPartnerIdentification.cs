using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    
    [DisplayName("Fields to identify the partner")]
    [KnownType(typeof(EdiAddress))]
    [KnownType(typeof(EdiIdIdentification))]
    [KnownType(typeof(EdiConiziIdentification))]
    [KnownType(typeof(EdiPartner))]
    [ConiziAnyOf]
    [JsonObject("partnerIdentification")]
    public class EdiPartnerIdentification
    {
        
    }

    [JsonObject("ediId")]
    public class EdiIdIdentification : EdiPartnerIdentification
    {
        [JsonRequired]
        [DisplayName("The Edi Id (e.g. CONIZVK)")]
        [StringLength(50)]
        public string EdiId { get; set; }
    }

    [JsonObject("partnerId")]
    public class EdiPartner : EdiPartnerIdentification
    {
        [JsonRequired]
        [DisplayName("The PartnerId (e.g. 1234)")]
        [MaxLength(50)]
        public string PartnerId { get; set; }
    }

    [JsonObject("coniziId")]
    public class EdiConiziIdentification : EdiPartnerIdentification
    {
        [JsonRequired]
        [DisplayName("The conizi id for internal routing purposes")]
        [MaxLength(50)]
        public string ConiziId { get; set; }
    }
}