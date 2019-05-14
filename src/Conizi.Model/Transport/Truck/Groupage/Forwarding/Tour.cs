using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Converters;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// A tour describes a amount of stops given an explicit stop order, containing all information about activities to be done,
    /// e.g.loading and unloading information about <see cref="Consignment"/>s or maintenance stops
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/tour.json", "tour.json")]
    [DisplayName("Tour")]
    [Description("A tour describes a amount of stops given an explicit stop order, containing all information about activities to be done, e.g.loading and unloading information about consignments or maintenance stops")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class Tour : EdiModel
    {
        /// <summary>
        /// Message function code
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("messageFunctionCode", Order = -11)]
        [DisplayName("Message function code")]
        public EdiMessageFunctionCode MessageFunctionCode { get; set; }

        /// <summary>
        /// The Tour Id. A unique identifier assigned to this tour by the devlivering company
        /// </summary>
        [DisplayName("Tour id")]
        [Description("A unique identifier assigned to this tour by the devlivering company")]
        [JsonProperty("tourId", Order = -10)]
        [Required]
        public string TourId { get; set; }

        /// <summary>
        /// The Description. A description of the tour, maybe the occasion of the tour
        /// </summary>
        [DisplayName("Description")]
        [Description("A description of the tour, maybe the occasion of the tour")]
        [JsonProperty("description", Order = -9)]
        public string Description { get; set; }
   
        /// <summary>
        /// The Route. Information about the route to be driven or its identification
        /// </summary>
        [DisplayName("Route")]
        [Description("Information about the route to be driven or its identification")]
        [JsonProperty("route", Order = -8)]
        public string Route { get; set; }
       
        /// <summary>
        /// Driver Notes. Notes which can be attached by the delivering driver
        /// </summary>
        [DisplayName("Driver Notes")]
        [Description("Notes which can be attached by the delivering driver")]
        [JsonProperty("driverNotes", Order = -8)]
        public string DriverNotes { get; set; }

        /// <summary>
        /// Carrier Notes. Notes which can be attached by the delivering driver
        /// </summary>
        [DisplayName("Carrier Notes")]
        [Description("Notes which can be attached by the carrier")]
        [JsonProperty("carrierNotes", Order = -7)]
        public string CarrierNotes { get; set; }

        /// <summary>
        /// Shipping date
        /// </summary>
        [DisplayName("Shipping date")] 
        [Description("Day on which the tour is proccessed")]
        [JsonProperty("shippingDate", Order = -6)]
        [ConiziDateOnly]
        [JsonConverter(typeof(ConiziDateConverter))]
        [Required]
        public DateTime ShippingDate { get; set; }

        /// <summary>
        /// Company responsible for the actual transport of the goods from the shipping partner to the recipient
        /// </summary>
        //[DisplayName("Carrier")]
        //[Description("Company responsible for the actual transport of the goods from the shipping partner to the recipient")]
        [JsonProperty("carrier", Order = -5)]
        public EdiAddress Carrier { get; set; }

        /// <summary>
        /// Additional loading aids which are not part of the consignment but which have been added to safely transport the goods
        /// </summary>
        public EdiAdditionalLoadingEquipment AdditionalLoadingEquipment { get; set; }

        /// <summary>
        /// Load units (containers, swap bodies, ...) used to transport the goods
        /// </summary>
        public List<EdiLoadUnit> LoadUnits { get; set; }

         /// <summary>
        /// Notification Parties
        /// </summary>
        [DisplayName("Notification Parties")] 
        [Description("Parties should be notified")]
        public List<EdiPartnerIdentification> NotificationParties { get; set; }

        /// <summary>
        ///  Information about the drivers of the vehicles
        /// </summary>
        public List<EdiDriver> Divers { get; set; }

        /// <summary>
        /// Information about the vehicles used in the transport
        /// </summary>
        public List<EdiVehicle> Vehicles { get; set; }

        /// <summary>
        /// Consignments. Consignments which are delivered while processing the tour
        /// </summary>
        //[DisplayName("Consignments")]
        //[Description("Consignments which are delivered while processing the tour")]
        [JsonProperty("consignments", ReferenceLoopHandling = ReferenceLoopHandling.Ignore, IsReference = false,ItemIsReference = true)]
        public List<Consignment> Consignments { get; set; }

        /// <summary>
        ///  Dangerous goods to be declared contained in a consignment 
        /// </summary>
        public TourDangerousGoods DangerousGoods { get; set; }

        /// <summary>
        /// Tour start options. Activities the driver is supposed to do before starting driving the tour
        /// </summary>
        public TourStartOptions TourStartOptions { get; set;}

        /// <summary>
        /// Tour end options. Activities the driver is supposed to do before starting driving the tour
        /// </summary>
        public TourEndOptions TourEndOptions { get; set; }

        /// <summary>
        ///  Stops for delivering the actual goods
        /// </summary>
        public List<EdiTourStop> Stops { get; set; }
    }
}
