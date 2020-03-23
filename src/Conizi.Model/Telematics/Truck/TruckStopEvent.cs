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
    /// A (truck) stop event 
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/telematics/truck/truck-stop-event.json", "truck-stop-event.json")]
    [DisplayName("Stop Event")]
    [Description("A (truck) stop event")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class TruckStopEvent : EdiModel
    {


        /// <summary>
        /// Date and time when the event occurred
        /// </summary>
        [DisplayName("Event Date-time")]
        [Description("Date and time when the event occurred")]
        [JsonProperty("eventDateTime", Order = -16, Required = Required.Always)]
        public DateTime EventDateTime { get; set; }


        /// <summary>
        /// The estimated time of arrival (ETA) is the time when a ship, vehicle, aircraft, cargo, emergency service or person is expected to arrive at a certain place
        /// </summary>
        [JsonProperty(Order = -14)]
        public EdiGeoEta Eta { get; set; }

        /// <summary>
        /// Data about the current geo position
        /// </summary>
        [JsonProperty(Order = -13)]
        public EdiGeoPosition GeoPosition { get; set; }

        /// <summary>
        /// Information about loading equipment exchange
        /// </summary>
        [JsonProperty(Order = -12)]
        public EdiLoadingEquipmentExchange LoadingEquipmentExchange { get; set; }

        /// <summary>
        /// Events indicating arrival at an unloading stop
        /// </summary>
        [JsonProperty(Order = -11)]
        public EdiEventArrived ArrivedAtUnloadingPoint { get; set; }


        /// <summary>
        /// Events indicating arrival at a loading stop
        /// </summary>
        [JsonProperty(Order = -10)]
        public EdiEventArrived ArrivedAtLoadingPoint { get; set; }

        /// <summary>
        /// Events indicating, that the transport is leaving the actual stop
        /// </summary>
        [JsonProperty(Order = -9)]
        public EdiEventOnWay Departure { get; set; }

        /// <summary>
        /// Object to transmit file attachments
        /// </summary>
        public EdiFileAttachment FileAttachment { get; set; }

        /// <summary>
        /// Events indicating, that the transport is on the way to an unloading stop
        /// </summary>
        [JsonProperty(Order = -7)]
        public EdiEventOnWay OnWayUnloadingPoint { get; set; }

        /// <summary>
        /// Events indicating, that the transport is on the way to a loading stop
        /// </summary>
        [JsonProperty(Order = -6)]
        public EdiEventOnWay OnWayLoadingPoint { get; set; }

        /// <summary>
        /// Events occurred while loading the order 
        /// </summary>
        [JsonProperty(Order = -5)]
        public EdiEventLoading LoadingStarted { get; set; }


        /// <summary>
        /// Events indicating a successful pickup
        /// </summary>
        [JsonProperty(Order = -4)]
        public EdiPickupSuccessful LoadingCompleted { get; set; }

        /// <summary>
        /// Events occurred while loading the order 
        /// </summary>
        [JsonProperty(Order = -3)]
        public EdiPickupAttemptFailed LoadingFailed { get; set; }

        /// <summary>
        /// Events occurred while unloading the order
        /// </summary>
        [JsonProperty(Order = -2)]
        public EdiUnloading UnloadingStarted { get; set; }

        /// <summary>
        /// Detailed information about the exceptions that occurred when consignment was successfully delivered
        /// </summary>
        [JsonProperty(Order = -1)]
        public EdiEventDeliverySuccessful UnloadingCompleted { get; set; }

        /// <summary>
        /// Events indicating a failed delivery attempt
        /// </summary>
        [JsonProperty(Order = 0)]
        public EdiEventDeliveryAttemptFailed UnloadingFailed { get; set; }


        /// <summary>
        /// Additional remarks (free form)
        /// </summary>
        [DisplayName("Remarks")]
        [Description("Additional remarks (free form)s")]
        [JsonProperty(Order = 1)]
        public List<string> Remarks { get; set; }
    }
}
