using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("anonymity")]
    [DisplayName("Anonymity services")]
    [Description("Neutral addresses which are shown to the shipper or consignee in order to conceal the actual shipper or recipient of the goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiAnonymity : EdiPatternPropertiesBase
    {
        public EdiPartnerIdentification NeutralShipper { get; set; }
        public EdiPartnerIdentification NeutralConsignee { get; set; }
    }
}