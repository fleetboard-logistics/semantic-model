using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("packagingOptions")]
    [DisplayName("Packaging Options")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPackagingOptions : EdiPatternPropertiesBase
    {
        [DisplayName("Return")]
        public bool Return { get; set; }

        [DisplayName("Correction")]
        public bool Correction { get; set; }

        [DisplayName("Third Party Delivery")]
        public string ThirdPartyDelivery { get; set; }

        [DisplayName("Package Pickup")]
        public string Pickup { get; set; }
    }
}