using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("services")]
    [DisplayName("Services")]
    [Description("Special services which can be requested by the ordering party (or the shipping partner)")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiServices : EdiPatternPropertiesBase
    {
        public EdiPackagingOptions PackagingOptions { get; set; }

        [DisplayName("Special Run")]
        [Description("The transport is produced via special run (and with special fares)")]
        public string SpecialRun { get; set; }

        public EdiNotifications Notifications { get; set; }

        public EdiAnonymity Anonymity { get; set; }

        public EdiTimeSlotBooking TimeSlotBooking { get; set; }

        public EdiTimeOptions TimeOptions { get; set; }

        public EdiDeliveryOptions DeliveryOptions { get; set; }

        public EdiLoadingOptions LoadingOptions { get; set; }

        public EdiUnloadingOptions UnloadingOptions { get; set; }

        public EdiGateway Gateway { get; set; }

        public EdiHandlingInstructions HandlingInstructions { get; set; }

        public EdiReturnOfGoods ReturnOfGoods { get; set; }

    }

    [JsonObject("gateway")]
    [DisplayName("Gateway-Options")]
    [Description("Special requirements for the handling of the goods at intermediate hubs / gateways")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiGateway : EdiPatternPropertiesBase
    {
        [DisplayName("Priority")]
        [Description("The consignment must be processed with priority")]
        public bool Priority { get; set; }
    }

    [JsonObject("handlingInstructions")]
    [DisplayName("Handling instructions")]
    [Description("Handling instructions for the goods, e.g. to prevent damage")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiHandlingInstructions : EdiPatternPropertiesBase
    {
        [DisplayName("Customs Goods")]
        [Description("The goods are subject to customs processing and must be processed according the rules of the local authorities")]
        public bool CustomsGoods { get; set; }

        [DisplayName("Customs Goods resubmission date")]
        [Description("The resubmission date for the customs goods")]
        [ConiziDateOnly]
        public DateTime CustomsGoodsResubmissionDate { get; set; }

        [DisplayName("Handle with care")]
        [Description("The goods must be handeled with care to prevent damage")]
        public bool HandleWithCare { get; set; }

        [DisplayName("Empties exchange required")]
        [Description("Specifies whether empties should be exchanged with the consignee")]
        public bool EmptiesExchange { get; set; }

        public EdiOrientation Orientation { get; set; }

        public EdiStacking Stacking { get; set; }

        public EdiFood Food { get; set; }
    }
    
    [JsonObject("orientation")]
    [DisplayName("Orientation")]
    [Description("The goods must be transported in a given orientatien and may not be flipped over")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiOrientation : EdiPatternPropertiesBase
    {
        [DisplayName("Upright")]
        [Description("The goods must be transported upright")]
        public bool Vertical { get; set; }

        [DisplayName("Horizontal")]
        [Description("The goods must be transported flat down")]
        public bool Horizontal { get; set; }
    }

    [JsonObject("returnOfGoods")]
    [DisplayName("Return of goods")]
    [Description("Services for the return of goods")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiReturnOfGoods : EdiPatternPropertiesBase
    {
        [DisplayName("Packaging disposal")]
        [Description("The packaging of the goods is taken back and dispose")]
        public bool EmptyPackaging { get; set; }
    }

    [JsonObject("stacking")]
    [DisplayName("Stacking")]
    [Description("Indicated wheter the goods may or may not be stacked")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiStacking : EdiPatternPropertiesBase
    {
        [DisplayName("Stacking forbidden")]
        [Description("The goods must not be stacked")]
        public bool Forbidden { get; set; }

        [DisplayName("Stacking possible")]
        [Description("Stacking of the goods is safely possible")]
        public bool Allowed { get; set; }
    }

    [JsonObject("food")]
    [DisplayName("Food related regulatory restrictions")]
    [Description("Special requirements for transporting food")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiFood : EdiPatternPropertiesBase
    {
        [DisplayName("Stacking forbidden")]
        [Description("The HACCP regulations apply")]
        public bool Haccp { get; set; }

    }

    
}