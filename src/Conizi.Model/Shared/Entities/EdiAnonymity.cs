using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Neutral addresses which are shown to the shipper or consignee in order to conceal the actual shipper or recipient of the goods
    /// </summary>
    [JsonObject("#anonymity")]
    [DisplayName("Anonymity services")]
    [Description("Neutral addresses which are shown to the shipper or consignee in order to conceal the actual shipper or recipient of the goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiAnonymity : EdiPatternPropertiesBase
    {
        /// <summary>
        /// An address to be shown to the consignee instead of the actual shipper when delivering the goods
        /// </summary>
        public EdiAddress NeutralShipper { get; set; }

        /// <summary>
        /// An address to be shown to the shipper instead of the actual address the consignee when picking up the goods
        /// </summary>
        public EdiAddress NeutralConsignee { get; set; }
    }
}