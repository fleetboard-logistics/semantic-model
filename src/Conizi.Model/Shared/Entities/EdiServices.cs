using System;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    [JsonObject("services")]
    [DisplayName("Services")]
    [Description("Special services which can be requested by the ordering party (or the shipping partner)")]
    [ConiziAdditionalProperties(false)]
    public class EdiServices
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

        public EdiGateway EdiGateway { get; set; }

        public EdiHandlingInstructions EdiHandlingInstructions { get; set; }

        public EdiReturnOfGoods EdiReturnOfGoods { get; set; }

    }

    [JsonObject("gateway")]
    [DisplayName("Gateway-Options")]
    [Description("Special requirements for the handling of the goods at intermediate hubs / gateways")]
    [ConiziAdditionalProperties(false)]
    public class EdiGateway
    {
        [DisplayName("Priority")]
        [Description("The consignment must be processed with priority")]
        public bool Priority { get; set; }
    }

    [JsonObject("handlingInstructions")]
    [DisplayName("Handling instructions")]
    [Description("Handling instructions for the goods, e.g. to prevent damage")]
    [ConiziAdditionalProperties(false)]
    public class EdiHandlingInstructions
    {
        [DisplayName("Customs Goods")]
        [Description("The goods are subject to customs processing and must be processed according the rules of the local authorities")]
        public bool CustomsGoods { get; set; }

        [DisplayName("Customs Goods resubmission date")]
        [Description("The resubmission date for the customs goods")]
        public string CustomsGoodsResubmissionDate { get; set; }

        [DisplayName("Handle with care")]
        [Description("The goods must be handeled with care to prevent damage")]
        public string HandleWithCare { get; set; }

        [DisplayName("Empties exchange required")]
        [Description("Specifies whether empties should be exchanged with the consignee")]
        public string EmptiesExchange { get; set; }

        public EdiOrientation EdiOrientation { get; set; }

    }
    
    [JsonObject("orientation")]
    [DisplayName("Orientation")]
    [Description("The goods must be transported in a given orientatien and may not be flipped over")]
    [ConiziAdditionalProperties(false)]
    public class EdiOrientation
    {
        [DisplayName("Upright")]
        [Description("The goods must be transported upright")]
        public bool Upright { get; set; }

        [DisplayName("Horizontal")]
        [Description("The goods must be transported flat down")]
        public bool Horizontal { get; set; }
    }

    [JsonObject("returnOfGoods")]
    [DisplayName("Return of goods")]
    [Description("Services for the return of goods")]
    [ConiziAdditionalProperties(false)]
    public class EdiReturnOfGoods
    {
        [DisplayName("Packaging disposal")]
        [Description("The packaging of the goods is taken back and dispose")]
        public bool EmptyPackaging { get; set; }
    }


}