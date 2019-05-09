using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// A single pickup order which is transferred between two partners
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/pickuporder.json",
        "pickuporder.json")]
    [DisplayName("Pickup order")]
    [Description("A single pickup order which is transferred between two partners")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class PickupOrder : EdiModel
    {
        /// <summary>
        /// Unique identification for the pickup order within the transport management system of the contract partner
        /// </summary>
        [DisplayName("Pickup order number of the contract partner")]
        [Description("Unique identification for the pickup order within the transport management system of the contract partner")]
        [JsonProperty("pickupOrderNo", Order = -10)]
        [Required]
        public string PickupOrderNo { get; set; }


        /// <summary>
        /// The date on which the pickup order was forwarded to the contracted partner
        /// </summary>
        [DisplayName("Pickup order date")]
        [Description("The date on which the pickup order was forwarded to the contracted partner")]
        [JsonProperty("pickupOrderDate", Order = -9)]
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        [Required]
        public DateTime PickupOrderDate { get; set; }

        /// <summary>
        /// The date on which the pickup order should be processed by the contracted partner
        /// </summary>
        public EdiPickupDate PickupDate { get; set; }

        /// <summary>
        /// The partner which is sending the pickup order to the contracted partner for pickup
        /// </summary>
        [JsonProperty("orderingPartner", Order = -7)]
        [Required]
        public EdiPartnerIdentification OrderingPartner { get; set; }

        /// <summary>
        /// Person or company that ordered the transport of the consignment. Often identical to the shipper
        /// </summary>
        [JsonProperty("orderingParty", Order = -6)]
        public EdiAddress OrderingParty { get; set; }

        /// <summary>
        /// The partner which is contracted for processing the pickup order
        /// </summary>
        [JsonProperty("contractedPartner", Order = -5)]
        [Required]
        public EdiPartnerIdentification ContractedPartner { get; set; }

        /// <summary>
        /// Additional partners which are also involved in processing this pickup order
        /// </summary>
        public List<EdiPartnerIdentification> AdditionalPartners { get; set; }

        /// <summary>
        /// Information about the route take by this pickup order
        /// </summary>
        public EdiRouting Routing { get; set; }

        /// <summary>
        /// Special services which can be requested by the ordering party (or the shipping partner) for this pickup order
        /// </summary>
        public EdiPickupServices Services { get; set; }

        /// <summary>
        /// Services that are not provided by the parties involved in the physical transport but by external service providers (e.g. central services by the networks)
        /// </summary>
        public EdiExternalServices ExternalServices { get; set; }

        /// <summary>
        /// General information about the pickup order
        /// </summary>
        public EdiInformation Information { get; set; }

        /// <summary>
        /// Numbers of various sources identifying this pickup order or references from this pickup to other business processes
        /// </summary>
        public EdiReferences References { get; set; }

        /// <summary>
        /// Information for invoicing and clearing
        /// </summary>
        public EdiBilling Billing { get; set; }

        /// <summary>
        /// Used to specify information necessary in the customs process
        /// </summary>
        public EdiCustomsInformation CustomsInformation { get; set; }

        /// <summary>
        /// Describes the nature and quantity of the goods in this pickup order
        /// </summary>
        public EdiContent Content { get; set; }
    }
}
