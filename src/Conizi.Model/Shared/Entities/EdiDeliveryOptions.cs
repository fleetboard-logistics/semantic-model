using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("deliveryOptions")]
    [DisplayName("Delivery options")]
    [Description("Requirements for special services or equipment for the delivery")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDeliveryOptions : EdiPatternPropertiesBase
    {
        [DisplayName("Lifting Platform")]
        [Description("The consignment can only be delivered with a vehicle equipped with a lifting platform")]
        public bool LiftingPlatform { get; set; }

        [DisplayName("Point of use delivery - 1 man handling")]
        [Description("The goods must be deliverd to the point of use with one man handling")]
        public bool PointOfUseDelivery1Person { get; set; }

        [DisplayName("Point of use delivery - 2 men handling")]
        [Description("The goods must be deliverd to the point of use with two men handling")]
        public bool PointOfUseDelivery2Persons { get; set; }

        [DisplayName("Shelf service")]
        [Description("The goods must be put into the shelves at the destination")]
        public bool ShelfService { get; set; }

        public EdiUseSpecificLastMileProvider UseSpecificLastMileProvider { get; set; }

        public EdiCashOnDelivery CashOnDelivery { get; set; }

        [DisplayName("Pick up by consignee")]
        [Description("The consignee will pick up the goods at the receiving partner's warehouse. Do not perform local delivery")]
        public bool PickupByConsignee { get; set; }

        public EdiWorkRequest WorkRequest { get; set; }

        [DisplayName("Delivery only with delivery note")]
        [Description("Delivery should only be performed with the delivery note")]
        public bool DeliveryOnlyWithDeliveryNote { get; set; }

        [DisplayName("Digital delivery note")]
        [Description("The delivery note has been sent by means of digital communication (and is not attached to the goods)")]
        public bool DigitalDeliveryNote { get; set; }

        [DisplayName("Delivery note on goods")]
        [Description("The delivery note is attached to the goods")]
        public bool DeliveryNoteOnGoods { get; set; }

        [DisplayName("PoD on original delivery note")]
        [Description("The recipient must sign the original delivery note as proof of delivery. The signed document must be returned to the shipping partner")]
        public bool PodOnOriginalDeliveryNote { get; set; }

        [DisplayName("Delivery without receipt allowed")]
        [Description("The goods may be dropped at the designated location without a signature")]
        public bool DeliveryWithoutReceiptAllowed { get; set; }

        [DisplayName("For attention")]
        [Description("The delivery is for attention of the given company")]
        public string ForAttentionOf { get; set; }

    }
    
    [JsonObject("useSpecificLastMileProvider")]
    [DisplayName("Specific last mile provider")]
    [Description("A given last mile provider must be used")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiUseSpecificLastMileProvider : EdiPatternPropertiesBase
    {
        [DisplayName("Name of the provider")]
        [Description("The name of the provider to be used")]
        public string Name { get; set; }
    }

    [JsonObject("cashOnDelivery")]
    [DisplayName("Cash on delivery")]
    [Description("The goods must only be delivered if the recipient pays the given amount")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiCashOnDelivery : EdiPatternPropertiesBase
    {
        [DisplayName("Amount")]
        [Description("The amount to be paid")]
        public Decimal Amount { get; set; }

        [DisplayName("Currency")]
        [Description("The currency of the given amount")]
        public string Currency { get; set; }

        [DisplayName("acceptCash")]
        [Description("Specifies if cash should be accepted (true) or rejected (false)")]
        public bool AcceptCash { get; set; }

        [DisplayName("acceptCheque")]
        [Description("Specifies if cheques should be accepted")]
        public bool AcceptCheque { get; set; }
    }

    [JsonObject("workRequest")]
    [DisplayName("Work request")]
    [Description("The receiving partner should perform the action specified")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiWorkRequest : EdiPatternPropertiesBase
    {
        [DisplayName("Information")]
        [Description("A description of the action to be performed")]
        public string Info { get; set; }

    }
}