using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Detailed information about the individual handling units
    /// </summary>
    [JsonObject("#barcode")]
    [DisplayName("Bar codes / SSCC number")]
    [Description("Detailed information about the individual handling units")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiBarcode : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Id of the handling unit, usually printed as machine readable bar code on the package
        /// </summary>
        [DisplayName("Bar code / SSCC / NVE")]
        [Description("Id of the handling unit, usually printed as machine readable bar code on the package")]
        public string Code { get; set; }

        /// <summary>
        /// Grouping code of multiple packages
        /// </summary>
        [DisplayName("Master bar code")]
        [Description("Grouping code of multiple packages")]
        public string MasterBarcode { get; set; }

        /// <summary>
        /// Information identifying the manufacturing batch of the goods in the unit
        /// </summary>
        [DisplayName("Batch")]
        [Description("Information identifying the manufacturing batch of the goods in the unit")]
        public string Batch { get; set; }

        /// <summary>
        /// Information about the expiry of good
        /// </summary>
        [DisplayName("Best before")]
        [Description("Information about the expiry of good")]
        public string BestBefore { get; set; }

    }
}