using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
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
        [Required]
        public DateTime PickupOrderDate { get; set; }

        /// <summary>
        /// The date on which the pickup order should be processed by the contracted partner
        /// </summary>
        [DisplayName("Pickup date")]
        [Description("The date on which the pickup order should be processed by the contracted partner")]
        [JsonProperty("pickupDate", Order = -8)]
        [ConiziDateOnly]
        [Required]
        public DateTime PickupDate { get; set; }

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
    }
}
