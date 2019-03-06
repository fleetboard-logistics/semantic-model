using System.ComponentModel;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("packagingOptions")]
    public class EdiPackagingOptions
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