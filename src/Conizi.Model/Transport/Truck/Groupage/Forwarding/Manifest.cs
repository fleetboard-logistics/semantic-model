using System;
using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Manifest;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// A manifest describes multiple consignments which are forwarded from one partner to another at the same time
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/manifest.json", "manifest.json")]
    [DisplayName("Manifest")]
    [Description(
        "A manifest describes multiple consignments which are forwarded from one partner to another at the same time")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class Manifest : EdiModel
    {
        [JsonProperty(PropertyName = "manifestId", Required = Required.Always)]
        [DisplayName("Manifest id")]
        [Description("A unique identifier assigned to this cargo manifest by the shipping partner")]
        public string ManifestId { get; set; }

        [JsonProperty(PropertyName = "manifestType", Required = Required.Always)]
        [DisplayName("Manifest type")]
        [Description("Type of the manifest (STD, INF, AVI)")]
        public string ManifestType { get; set; }


        [JsonProperty(PropertyName = "shippingDate", Required = Required.Always)]
        [DisplayName("Shipping date")]
        [Description("The date on which the manifest was issued")]
        [ConiziDateOnly]
        public DateTime ShippingDate { get; set; }


        [DisplayName("Transport type")]
        [Description(
            "Information about the way of production of that transport (i.e. by HUB, by direct transport, ...)")]
        public string TransportType { get; set; }

        [DisplayName("Is a pre advice")]
        [Description("Adds the possibility of sending the manifest (after saving, before approval) to e.g. a TMS)")]
        public bool IsPreAdvice { get; set; }

        public List<EdiPartnerIdentification> AdditionalPartners { get; set; }

        public EdiPartnerIdentification ShippingPartner { get; set; }

        public EdiPartnerIdentification ReceivingPartner { get; set; }

        public EdiPartnerIdentification Carrier { get; set; }

        public List<EdiVehicle> Vehicles { get; set; }

        public List<EdiLoadUnit> LoadUnits { get; set; }

        public EdiAdditionalLoadingEquipment AdditionalLoadingEquipment { get; set; }

        public List<EdiManifestLine> Lines { get; set; }
    }
}