using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Manifest
{
    [JsonObject("loadUnits")]
    [DisplayName("Load units")]
    [Description("Load units (containers, swap bodies, ...) used to transport the goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiLoadUnit
    {
        [DisplayName("Identification")]
        [Description("Identification (e.g. registration number) of the unit")]
        public string Identification { get; set; }

        public List<EdiSeal> Seals { get; set; }

    }
}