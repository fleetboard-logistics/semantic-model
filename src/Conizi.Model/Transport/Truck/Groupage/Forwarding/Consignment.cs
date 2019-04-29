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
    /// use the consignment for additional business processes. 
    /// </remarks>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/consignment.json", "consignment.json")]
    [DisplayName("Consignment")]
    [Description("A single consignment which is transferred between two partners. Usually used within the context a manifest")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class Consignment : EdiModel
    {
        /// <summary>
        /// Unique central consignment number
        /// </summary>
        [DisplayName("Unique central consignment number")]
        public string ConsignmentObjectId { get; set; }
        /// <summary>
        /// Consignment number of the shipping partner
        /// </summary>
        [DisplayName("Consignment number of the shipping partner")]
        public string ConsignmentNoShippingPartner { get; set; }
        /// <summary>
        /// Consignment number of the receiving partner
        /// </summary>
        [DisplayName("Consignment number of the receiving partner")]
        public string ConsignmentNoReceivingPartner { get; set; }

        /// <summary>
        /// Shipping date
        /// </summary>
        [DisplayName("Shipping date")] 
        [JsonProperty(PropertyName = "shippingDate",Required = Required.Always)]
        [ConiziDateOnly]
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Manifest (Bordero) id of the shipping partner
        /// </summary>
        [DisplayName("Manifest (Bordero) id of the shipping partner")]
        [Description("Unique identification for the manifest on which the shipment was loaded in the transport management system of the shipping partner")]
        public string ManifestId { get; set; }

        /// <summary>
        /// Tour number. Number of the planned / assigned local traffic tour for delivery.
        /// </summary>
        [DisplayName("Tour number")]
        [Description("Number of the planned / assigned local traffic tour for delivery")]
        public string TourNumber { get; set; }

        
        [DisplayName("Is a pre advice")]
        public bool IsPreAdvice { get; set; }

        public List<EdiPartnerIdentification> AdditionalPartners { get; set; }

        public EdiAddress OrderingParty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonRequired]
        public EdiPartnerIdentification ShippingPartner { get; set; }

        [JsonRequired]
        public EdiPartnerIdentification ReceivingPartner { get; set; }

        public EdiRouting Routing { get; set; }

        public EdiServices Services { get; set; }

        public EdiExternalServices ExternalServices { get; set; }

        public EdiInformation Information { get; set; }

        public EdiReferences References { get; set; }

        public EdiBilling Billing { get; set; }

        public EdiCustomsInformation CustomsInformation { get; set; }

        public EdiContent Content { get; set; }
    }
}
