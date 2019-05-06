using System;
using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// A manifest describes multiple <see cref="Consignment"/>s which are forwarded from one partner to another at the same time
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/manifest.json", "manifest.json")]
    [DisplayName("Manifest")]
    [Description(
        "A manifest describes multiple consignments which are forwarded from one partner to another at the same time")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class Manifest : EdiModel
    {
        /// <summary>
        /// A unique identifier assigned to this cargo manifest by the shipping partner
        /// </summary>
        [JsonProperty(PropertyName = "manifestId", Required = Required.Always)]
        [DisplayName("Manifest id")]
        [Description("A unique identifier assigned to this cargo manifest by the shipping partner")]
        public string ManifestId { get; set; }

        /// <summary>
        /// Type of the manifest (STD, INF, AVI)
        /// </summary>
        [JsonProperty(PropertyName = "manifestType", Required = Required.Always)]
        [DisplayName("Manifest type")]
        [Description("Type of the manifest (STD, INF, AVI)")]
        public string ManifestType { get; set; }

        /// <summary>
        /// The date on which the manifest was issued
        /// </summary>
        [JsonProperty(PropertyName = "shippingDate", Required = Required.Always)]
        [DisplayName("Shipping date")]
        [Description("The date on which the manifest was issued")]
        [ConiziDateOnly]
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Information about the way of production of that transport (i.e. by HUB, by direct transport, ...)
        /// </summary>
        [DisplayName("Transport type")]
        [Description(
            "Information about the way of production of that transport (i.e. by HUB, by direct transport, ...)")]
        public string TransportType { get; set; }

        /// <summary>
        /// Adds the possibility of sending the manifest (after saving, before approval) to e.g. a TMS)
        /// </summary>
        [DisplayName("Is a pre advice")]
        [Description("Adds the possibility of sending the manifest (after saving, before approval) to e.g. a TMS)")]
        public bool? IsPreAdvice { get; set; }

        /// <summary>
        /// Routing information to identify the parties involved in the data transfer
        /// </summary>
        public List<EdiPartnerIdentification> AdditionalPartners { get; set; }

        /// <summary>
        /// The partner which is sending the consignment to the receiving partner for further delivery.
        /// </summary>
        public EdiPartnerIdentification ShippingPartner { get; set; }

        /// <summary>
        /// The partner which is receiving the goods declared on the manifest from the shipping partner for further delivery
        /// </summary>
        public EdiPartnerIdentification ReceivingPartner { get; set; }

        /// <summary>
        /// Company responsible for the actual transport of the goods from the shipping partner to the receiving partner
        /// </summary>
        public EdiPartnerIdentification Carrier { get; set; }

        /// <summary>
        /// Information about the vehicles used in the transport
        /// </summary>
        public List<EdiVehicle> Vehicles { get; set; }

        /// <summary>
        /// Load units (containers, swap bodies, ...) used to transport the goods
        /// </summary>
        public List<EdiLoadUnit> LoadUnits { get; set; }

        /// <summary>
        /// Additional loading equipment used to securely load the goods into for the passage
        /// </summary>
        public EdiAdditionalLoadingEquipment AdditionalLoadingEquipment { get; set; }

        /// <summary>
        /// Ordinal number of the line within the manifest. Is referenced in other messages such as the unloading report
        /// </summary>
        public List<EdiManifestLine> Lines { get; set; }
    }
}