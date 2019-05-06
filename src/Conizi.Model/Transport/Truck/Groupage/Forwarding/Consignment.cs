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
    /// A single consignment which is transferred between two partners. Usually used within the context a <see cref="Manifest"/>
    /// </summary>
    /// <remarks>
    /// The consignment is the basic business object for conizi. Other objects like <see cref="Manifest"/>, <see cref="Tour"/>
    /// uses the consignment for additional business processes. 
    /// </remarks>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/consignment.json", "consignment.json")]
    [DisplayName("Consignment")]
    [Description("A single consignment which is transferred between two partners. Usually used within the context a manifest")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class Consignment : EdiModel
    {
        /// <summary>
        /// Unique identification for the consignment in a central system
        /// </summary>
        [DisplayName("Unique central consignment number")]
        [Description("Unique identification for the consignment in a central system")]
        [JsonProperty(Order = 10)]
        public string ConsignmentObjectId { get; set; }

        /// <summary>
        /// Unique identification for the consignment within the transport management system of the shipping partner
        /// </summary>
        [DisplayName("Consignment number of the shipping partner")]
        [Description("Unique identification for the consignment within the transport management system of the shipping partner")]
        [JsonProperty(Order = -9)]
        public string ConsignmentNoShippingPartner { get; set; }
        /// <summary>
        /// Unique identification for the consignment within the transport management system of the receiving partner
        /// </summary>
        [DisplayName("Consignment number of the receiving partner")]
        [Description("Unique identification for the consignment within the transport management system of the receiving partner")]
        [JsonProperty(Order = -8)]
        public string ConsignmentNoReceivingPartner { get; set; }

        /// <summary>
        /// The date on which the consignment was forwarded to the receiving partner. If the consignment was part of a cargo manifest, this is the date on which the manifest was issued
        /// </summary>
        [DisplayName("Shipping date")]
        [Description("The date on which the consignment was forwarded to the receiving partner. If the consignment was part of a cargo manifest, this is the date on which the manifest was issued")]
        [JsonProperty(Order = -7)]
        [ConiziDateOnly]
        [Required]
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Manifest (Bordero) id of the shipping partner
        /// </summary>
        [DisplayName("Manifest (Bordero) id of the shipping partner")]
        [Description("Unique identification for the manifest on which the shipment was loaded in the transport management system of the shipping partner")]
        [JsonProperty(Order = -6)]
        public string ManifestId { get; set; }

        /// <summary>
        /// Tour number. Number of the planned / assigned local traffic tour for delivery.
        /// </summary>
        [DisplayName("Tour number")]
        [Description("Number of the planned / assigned local traffic tour for delivery")]
        [JsonProperty(Order = -5)]
        public string TourNumber { get; set; }

        /// <summary>
        /// Adds the possibility of sending the consignment (after saving, before approval) to e.g. a TMS
        /// </summary>
        [DisplayName("Is a pre advice")]
        [Description("dds the possibility of sending the consignment (after saving, before approval) to e.g. a TMS")]
        public bool? IsPreAdvice { get; set; }

        /// <summary>
        /// Additional partners which are also involved in processing this consignment
        /// </summary>
        public List<EdiPartnerIdentification> AdditionalPartners { get; set; }

        /// <summary>
        /// Person or company that ordered the transport of the consignment. Often identical to the shipper
        /// </summary>
        public EdiAddress OrderingParty { get; set; }
        
        /// <summary>
        /// The partner which is sending the consignment to the receiving partner for further delivery
        /// </summary>
        [Required]
        public EdiPartnerIdentification ShippingPartner { get; set; }

        /// <summary>
        /// The partner which is receiving the goods declared on the manifest from the shipping partner for further delivery
        /// </summary>
        [Required]
        public EdiPartnerIdentification ReceivingPartner { get; set; }

        /// <summary>
        /// The address of the party which is sending the goods. This is usually the place where the transport originated
        /// </summary>
        public EdiRouting Routing { get; set; }

        /// <summary>
        /// Special services which can be requested by the ordering party (or the shipping partner)
        /// </summary>
        public EdiServices Services { get; set; }

        /// <summary>
        /// Services that are not provided by the parties involved in the physical transport but by external service providers (e.g. central services by the networks)
        /// </summary>
        public EdiExternalServices ExternalServices { get; set; }

        /// <summary>
        /// General information about the consignment
        /// </summary>
        public EdiInformation Information { get; set; }

        /// <summary>
        /// Numbers of various sources identifing this consignment or references from this consignment to other business processes
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
        /// Describes the nature and quantity of the goods in this consignment
        /// </summary>
        public EdiContent Content { get; set; }
    }
}
