using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("barcode")]
    [DisplayName("Bar codes / SSCC number")]
    [Description("Detailed information about the individual handling units")]
    [ConiziAdditionalProperties(false)]
    public class EdiBarcode
    {
        [DisplayName("Bar code / SSCC / NVE")]
        [Description("Id of the handling unit, usually printed as machine readable bar code on the package")]
        public string Code { get; set; }
   
        [DisplayName("Master bar code")]
        [Description("Grouping code of multiple packages")]
        public string MasterBarcode { get; set; }

        [DisplayName("Batch")]
        [Description("Information identifying the manufacturing batch of the goods in the unit")]
        public string Batch { get; set; }

        [DisplayName("Best before")]
        [Description("Information about the expiry of good")]
        public string BestBefore { get; set; }

    }
}