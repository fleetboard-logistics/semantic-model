using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("loadingOptions")]
    [DisplayName("Loading options")]
    [Description("Information about the loading of the main haul")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiLoadingOptions
    {
        [DisplayName("Direct pickup")]
        [Description("The goods picked up by the line haul and are not loaded by the shipping partners warehouse")]
        public bool DirectPickup { get; set; }
    }

}