using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Telematics.Truck
{
    /// <summary>
    /// A single optimized transport order which is transferred between two partners. Usually used within the context a <see cref="TruckTour"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/telematics/truck/truck-transport-order.json", "truck-transport-order.json")]
    [DisplayName("Transport Order")]
    [Description("An optimized transport order for industry and FTL/LTL purpose")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TruckTransportOrder : EdiModel
    {

        /// <summary>
        /// Message function code
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("messageFunctionCode", Order = -16)]
        [DisplayName("Message function code")]
        public EdiMessageFunctionCode? MessageFunctionCode { get; set; }

        /// <summary>
        /// Shipping date
        /// </summary>
        [DisplayName("Shipping date")]
        [Description("Day on which the tour is proccessed")]
        [JsonProperty("shippingDate", Order = -13)]
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        [Required]
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Person or company who placed the order
        /// </summary>
        [Required]
        [JsonProperty(Order = -11)]
        public EdiAddress Orderer { get; set; }

        /// <summary>
        /// Changes description for Loading and Unloading Address. Should be used, if the address is different from shipper/consignee
        /// </summary>
        [JsonProperty(Order = -10)]
        public EdiRouting Routing { get; set; }

        /// <summary>
        /// Describes the nature and quantity of the goods in this transport order
        /// </summary>
        [JsonProperty(Order = -9)]
        [Required]
        public EdiContent Content { get; set; }

        /// <summary>
        /// Handling instructions for the goods, e.g. to prevent damage
        /// </summary>
         [JsonProperty(Order = -8)]
        public EdiHandlingInstructions HandlingInstructions { get; set; }

        /// <summary>
        /// Services needed about the transport
        /// </summary>
        [JsonProperty(Order = -7)]
        public EdiTransportServices Services { get; set; }

        /// <summary>
        /// Time information of this transport
        /// </summary>
        [JsonProperty(Order = -6)]
        public EdiTransportTimeSlot TimeSlot { get; set; }

        /// <summary>
        /// Free-text information about the transport
        /// </summary>
        [JsonProperty(Order = -5)]
        public EdiTransportInformation Information { get; set; }


        /// <summary>
        /// Financial information of this transport 
        /// </summary>
        [JsonProperty(Order = -4)]
        public EdiTransportBilling Billing { get; set; }

    }
}
