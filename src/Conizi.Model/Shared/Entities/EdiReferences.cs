using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Numbers of various sources identifying this consignment or references from this consignment to other business processes
    /// </summary>
    
    [DisplayName("References")]
    [Description("Numbers of various sources identifing this consignment or references from this consignment to other business processes")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiReferences : EdiPatternPropertiesBase
    {
        /// <summary>
        /// All references to the linked documents, systems and devices
        /// </summary>
        public EdiDocumentReferences DocumentReferences { get; set; }

        /// <summary>
        /// Reference to another consignment which content is return using this pickup order
        /// </summary>
        public EdiReturnOfPreviousConsignment ReturnOfPreviousConsignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public EdiPartnerIdentification ForwardedFor { get; set; }

        /// <summary>
        /// Additional delivery to our Bordero from: ... (additional text) (Shipment-no. Of the dispatching and receiving partner are to be transferred additionally)
        /// </summary>
        public EdiSubsequentDelivery SubsequentDelivery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public EdiPickupOrder PickupOrder { get; set; }

        /// <summary>
        /// The delivery note of the shipper which describes the content of this consignment
        /// </summary>
        [DisplayName("Delivery note")]
        [Description("The delivery note of the shipper which describes the content of this consignment")]
        public string DeliveryNote { get; set; }

        /// <summary>
        /// A reference of the shipper for this consignment
        /// </summary>
        [DisplayName("Customer order no")]
        [Description("A reference of the shipper for this consignment")]
        public string CustomerOrderNo { get; set; }

        /// <summary>
        /// Date when the order was places with the shipping partner
        /// </summary>
        [DisplayName("Customer order date")]
        [Description("Date when the order was places with the shipping partner")]
        [JsonConverter(typeof(ConiziDateConverter))]
        [ConiziDateOnly]
        public DateTime? CustomerOrderDate { get; set; }

        /// <summary>
        /// An unique reference number from the system which was used to enter the order details
        /// </summary>
        [DisplayName("Order entry system reference")]
        [Description("A unique reference number from the system which was used to enter the order details")]
        public string OrderEntrySystemReference { get; set; }
    }

    /// <summary>
    /// Reference to another consignment which content is return using this consignment
    /// </summary>
    
    [DisplayName("Return of previous consignment")]
    [Description("Reference to another consignment which content is return using this consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiReturnOfPreviousConsignment : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The consignment number of the original consignment being returned
        /// </summary>
        [DisplayName("Consignment number of the consignment being returned")]
        [Description("The consignment number of the original consignment being returned")]
        public string ConsignmentNoShippingPartner { get; set; }

        /// <summary>
        /// The date when the original shipment was forwarded
        /// </summary>
        [DisplayName("Shipping date")]
        [Description("The date when the original shipment was forwarded")]
        [JsonConverter(typeof(ConiziDateConverter))]
        [ConiziDateOnly]
        public DateTime? ShippingDate { get; set; }

        /// <summary>
        /// The partner which originally forwarded the consignment
        /// </summary>
        public EdiPartnerIdentification ShippingPartner { get; set; }
    }

    /// <summary>
    /// Additional delivery to our Bordero from: ... (additional text) (Shipment-no. Of the dispatching and receiving partner are to be transferred additionally)
    /// </summary>
    
    [DisplayName("Subsequent Delivery")]
    [Description("Additional delivery to our Bordero from: ... (additional text) (Shipment-no. Of the dispatching and receiving partner are to be transferred additionally)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSubsequentDelivery : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Consignment number of the consignment for that the subsequent delivery is
        /// </summary>
        [DisplayName("Consignment number of the consignment for that the subsequent delivery is")]
        [Description("The consignment number of the original consignment")]
        public string ConsignmentNoShippingPartner { get; set; }

        /// <summary>
        /// The date when the original shipment was forwarded
        /// </summary>
        [DisplayName("Shipping date")]
        [Description("The date when the original shipment was forwarded")]
        [JsonConverter(typeof(ConiziDateConverter))]
        [ConiziDateOnly]
        public DateTime? ShippingDate { get; set; }

        /// <summary>
        /// The partner which originally forwarded the consignment
        /// </summary>
        public EdiPartnerIdentification ShippingPartner { get; set; }
    }

    /// <summary>
    /// Reference to a pickup order which resulted in this consignment
    /// </summary>
    
    [DisplayName("Pickup order")]
    [Description("Reference to a pickup order which resulted in this consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupOrder : EdiPatternPropertiesBase
    {
        /// <summary>
        /// Number to the referenced pickup order
        /// </summary>
        [DisplayName("Number of the Pickup order")]
        [Description("Number to the referenced pickup order")]
        public string PickupOrderNo { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public EdiPartnerIdentification OrderingParty { get; set; }
    }

}
