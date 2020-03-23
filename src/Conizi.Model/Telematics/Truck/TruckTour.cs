using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Telematics.Truck
{
    /// <summary>
    /// A (truck) tour describes an amount of stops given an explicit stop order, containing all information about activities to be done, e.g. loading and unloading information about transport orders or maintenance stops
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/telematics/truck/truck-tour.json", "truck-tour.json")]
    [DisplayName("Tour")]
    [Description("A truck tour describes an amount of stops given an explicit stop order, containing all information about activities to be done, e.g. loading and unloading information about transport orders or maintenance stops")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TruckTour : EdiModel
    {

        /// <summary>
        /// Shipping date
        /// </summary>
        [DisplayName("Shipping date")]
        [Description("Day on which the tour is proccessed")]
        [JsonProperty("shippingDate", Order = -17)]
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        [Required]
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Numbers of various sources identifying this tour or references from this tour to other business processes
        /// </summary>
        [JsonProperty(Order = -17)]
        public new EdiReferences References { get; set; }

        /// <summary>
        /// Message function code
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("messageFunctionCode", Order = -16)]
        [DisplayName("Message function code")]
        public EdiMessageFunctionCode? MessageFunctionCode { get; set; }
        
        /// <summary>
        /// Free-Text information about the tour
        /// </summary>
        [JsonProperty(Order = -15)]
        public EdiTourInformation TourInformation { get; set; }

        /// <summary>
        /// Information about the route to be driven
        /// </summary>
        [JsonProperty(Order = -14)]
        public EdiRouteInformation RouteInformation { get; set; }

        /// <summary>
        /// Transport orders within the tour
        /// </summary>
        [JsonProperty(Order = -13)]
        public List<TruckTransportOrder> TransportOrders { get; set; }


            /// <summary>
        /// Information about the vehicles used in the transport
        /// </summary>
        [JsonProperty(Order = -12)]
        public List<EdiVehicle> Vehicles { get; set; }

        /// <summary>
        ///  Information about the drivers of the vehicles
        /// </summary>
        [JsonProperty(Order = -11 )]
        public List<EdiDriver> Drivers { get; set; }
        
        /// <summary>
        /// Company or person responsible for the actual transport of the goods from the shipping partner to the recipient
        /// </summary>
        [JsonProperty(Order = -10)]
        public EdiAddress Carrier { get; set; }

        /// <summary>
        /// Company or person responsible for dispatching the transport
        /// </summary>
        [JsonProperty(Order = -9)]
        public EdiAddress Dispatcher { get; set; }

        /// <summary>
        ///  Stops for delivering the actual goods
        /// </summary>
        [JsonProperty(Order = -8)]
        public List<EdiTourStop> Stops { get; set; }

        /// <summary>
        ///  Flags indicating special goods within the tour
        /// </summary>
        [JsonProperty(Order = -7)]
        public EdiContentFlag Flags { get; set; }

        /// <summary>
        /// Load units (containers, swap bodies, ...) used to transport the goods
        /// </summary>
        [JsonProperty(Order = -6)]
        public List<EdiLoadUnit> LoadUnits { get; set; }

        /// <summary>
        /// Tour start options. Activities the driver is supposed to do before starting driving the tour
        /// </summary>
        [JsonProperty(Order = -5)]
        public TourStartOptions TourStartOptions { get; set;}

        /// <summary>
        /// Tour end options. Activities the driver is supposed to do before starting driving the tour
        /// </summary>
        [JsonProperty(Order = -4)]
        public TourEndOptions TourEndOptions { get; set; }

        /// <summary>
        /// Tour end options. Activities the driver is supposed to do before starting driving the tour
        /// </summary>
        [JsonProperty(Order = -3)]
        public List<EdiSelfDisposal> SelfDisposal { get; set; }

        /// <summary>
        /// Additional remarks (free form)
        /// </summary>
        [DisplayName("Remarks")]
        [Description("Additional remarks (free form)s")]
        [JsonProperty(Order = -2)]
        public List<string> Remarks { get; set; }
    }
}
