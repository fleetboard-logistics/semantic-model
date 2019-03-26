using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("references")]
    [DisplayName("References")]
    [Description("Numbers of various sources identifing this consignment or references from this consignment to other business processes")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiReferences : EdiPatternPropertiesBase
    {
        public EdiReturnOfPreviousConsignment ReturnOfPreviousConsignment { get; set; }

      
        public EdiPartnerIdentification ForwardedFor { get; set; }
        
        public EdiSubsequentDelivery SubsequentDelivery { get; set; }

        public EdiPickupOrder PickupOrder { get; set; }

        [DisplayName("Delivery note")]
        [Description("The delivery note of the shipper which describes the content of this consignment")]
        public string DeliveryNote { get; set; }  

        [DisplayName("Customer order no")]
        [Description("A reference of the shipper for this consignment")]
        public string CustomerOrderNo { get; set; }

        [DisplayName("Customer order date")]
        [Description("Date when the order was places with the shipping partner")]
        [ConiziDateOnly]
        public DateTime CustomerOrderDate { get; set; }

        [DisplayName("Order entry system reference")]
        [Description("A unqiue reference number from the system which was used to enter the order details")]
        public string OrderEntrySystemReference { get; set; }
    }


    [JsonObject("returnOfPreviousConsignment")]
    [DisplayName("Return of previous consignment")]
    [Description("Reference to another consignment which content is return using this consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiReturnOfPreviousConsignment : EdiPatternPropertiesBase
    {
        [DisplayName("Consignment number of the consignment being returned")]
        [Description("The consignment number of the original consignment being returned")]
        public string ConsignmentNoShippingPartner { get; set; }
        
        [DisplayName("Shipping date")]
        [Description("The date when the original shipment was forwarded")]
        [ConiziDateOnly]
        public DateTime ShippingDate { get; set; }

        public EdiPartnerIdentification ShippingPartner { get; set; }
    }
   
    [JsonObject("subsequentDelivery")]
    [DisplayName("Subsequent Delivery")]
    [Description("Additional delivery to our Bordero from: ... (additional text) (Shipment-no. Of the dispatching and receiving partner are to be transferred additionally)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiSubsequentDelivery : EdiPatternPropertiesBase
    {
        [DisplayName("Consignment number of the consignment for that the subsequent delivery is")]
        [Description("The consignment number of the original consignment")]
        public string ConsignmentNoShippingPartner { get; set; }
        
        [DisplayName("Shipping date")]
        [Description("The date when the original shipment was forwarded")]
        [ConiziDateOnly]
        public DateTime ShippingDate { get; set; }

        public EdiPartnerIdentification ShippingPartner { get; set; }
    }
    
    [JsonObject("pickupOrder")]
    [DisplayName("Pickup order")]
    [Description("Reference to a pickup order which resulted in this consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiPickupOrder : EdiPatternPropertiesBase
    {
        [DisplayName("Number of the Pickup order")]
        [Description("Number to the referenced pickup order")]
        public string PickupOrderNo { get; set; }
        
        public EdiPartnerIdentification OrderingParty { get; set; }
    }

}
