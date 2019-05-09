using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Dangerous goods to be declared contained in a consignment 
    /// </summary>
    [DisplayName("Dangerous goods")]
    [Description("Dangerous goods to be declared contained in a consignment")]
    
    [ConiziAdditionalProperties(false)]
    public class TourDangerousGoods
    {
        /// <summary>
        /// Fits the European Agreement concerning the International Carriage of Dangerous Goods by Road
        /// </summary>
        [DisplayName("Is ADR")]
        [Description("Fits the European Agreement concerning the International Carriage of Dangerous Goods by Road")]
        [JsonProperty("isADR")]
        public bool? IsAdr { get; set; }

        /// <summary>
        /// Total Point to ADR
        /// </summary>
        [DisplayName("Total Point ADR")]
        [Description("Total Point to ADR")]
        [JsonProperty("totalPointADR")]
        public decimal? TotalPointAdr { get; set; }
    }
}