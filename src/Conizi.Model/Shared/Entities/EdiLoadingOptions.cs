using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information about the loading of the main haul
    /// </summary>
    [JsonObject("loadingOptions")]
    [DisplayName("Loading options")]
    [Description("Information about the loading of the main haul")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiLoadingOptions : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The goods picked up by the line haul and are not loaded by the shipping partners warehouse
        /// </summary>
        [DisplayName("Direct pickup")]
        [Description("The goods picked up by the line haul and are not loaded by the shipping partners warehouse")]
        public bool? DirectPickup { get; set; }

        /// <summary>
        /// The partner which should get the goods after pickup from the contracted partners. If not set the receiving partner usually is determined by the networks routing rules
        /// </summary>
        //[DisplayName("Receiving Partner Disposal ")]
        //[Description("The partner which should get the goods after pickup from the contracted partners. If not set the receiving partner usually is determined by the networks routing rules")]
        public EdiPartnerIdentification ReceivingPartnerDisposal { get; set; }

        /// <summary>
        /// The gateway / HUB to which the goods should send after pickup from the contracted partners. If not set the route usually is determined by the networks routing rules
        /// </summary>
        public EdiPartnerIdentification GatewayDisposal { get; set; }
    }

}