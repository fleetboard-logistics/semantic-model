using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Telematics
{
    /// <summary>
    /// A single telematics event message for ground vehicles which is transferred between two partners.
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/telematics/ground-telematics-event.json", "ground-telematics-event.json")]
    [DisplayName("Ground telematics event")]
    [Description("A single telematics event message for ground vehicles which is transferred between two partners.")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class GroundTelematicsEvent : EdiModel
    {

        /// <summary>
        /// Date and time when the event occurred
        /// </summary>
        [DisplayName("Event Date-time")]
        [Description("Date and time when the event occurred")]
        [JsonProperty("eventDateTime", Order = -16, Required = Required.Always)]
        public DateTime EventDateTime { get; set; }

        /// <summary>
        /// Information about the vehicle
        /// </summary>
        [JsonProperty(Order = -6, Required = Required.Always)]
        public EdiVehicle Vehicle { get; set; }

        /// <summary>
        /// Information about the driver
        /// </summary>
        [JsonProperty(Order = -4)]
        public EdiDriver Driver { get; set; }

        /// <summary>
        /// Information about the 2nd driver
        /// </summary>
        [JsonProperty(Order = -3)]
        public EdiDriver CoDriver { get; set; }

        /// <summary>
        /// Event for geo and vehicle data
        /// </summary>
        [JsonProperty(Order = -2, Required = Required.Always)]
        public EdiGeoLocationEvent GeoLocationEvent { get; set; }

        /// <summary>
        /// Event for truck telematics data
        /// </summary>
        [JsonProperty(Order = -1)]
        public EdiTruckTelematicsEvent TruckTelematicsEvent { get; set; }

        /// <summary>
        /// Event for trailer telematics data
        /// </summary>
        [JsonProperty(Order = 0)]
        public EdiTrailerTelematicsEvent TrailerTelematicsEvent { get; set; }
    }
}
