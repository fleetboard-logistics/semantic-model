using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("deliveryOptions")]
    [DisplayName("Delivery options")]
    [Description("Requirements for special services or equipment for the delivery")]
    [ConiziAdditionalProperties(false)]
    public class EdiDeliveryOptions
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
    }
    
    [JsonObject("useSpecificLastMileProvider")]
    [DisplayName("Specific last mile provider")]
    [Description("A given last mile provider must be used")]
    [ConiziAdditionalProperties(false)]
    public class EdiUseSpecificLastMileProvider
    {
        [DisplayName("Name of the provider")]
        [Description("The name of the provider to be used")]
        public string Name { get; set; }
    }

    [JsonObject("cashOnDelivery")]
    [DisplayName("Cash on delivery")]
    [Description("The goods must only be delivered if the recipient pays the given amount")]
    [ConiziAdditionalProperties(false)]
    public class EdiCashOnDelivery
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
}