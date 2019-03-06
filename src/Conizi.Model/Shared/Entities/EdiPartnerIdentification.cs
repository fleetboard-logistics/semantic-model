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
    [KnownType(typeof(EdiPartnerIdentification))]
    [ConiziAnyOf]
    [JsonObject("partnerIdentification")]
    public class EdiPartnerIdentificationBase
    {
        
    }

    [JsonObject("ediId")]
    public class EdiIdIdentification : EdiPartnerIdentificationBase
    {
        [JsonRequired]
        [DisplayName("The Edi Id (e.g. CONIZVK)")]
        public string EdiId { get; set; }
    }

    [JsonObject("partnerId")]
    public class EdiPartnerIdentification : EdiPartnerIdentificationBase
    {
        [JsonRequired]
        [DisplayName("The PartnerId (e.g. 1234)")]
        public string PartnerId { get; set; }
    }

    [JsonObject("coniziId")]
    public class EdiConiziIdentification : EdiPartnerIdentificationBase
    {
        [JsonRequired]
        [DisplayName("The conizi id for internal routing purposes")]
        public string ConiziId { get; set; }
    }
}