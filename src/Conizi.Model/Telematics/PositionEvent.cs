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
    /// A single telematics event message for position data which is transferred between two partners.
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/telematics/position-event.json", "position-event.json")]
    [DisplayName("Position event")]
    [Description("A single telematics event message for position data which is transferred between two partners.")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class PositionEvent : EdiModel
    {

        /// <summary>
        /// Date and time when the event occurred
        /// </summary>
        [DisplayName("Event Date-time")]
        [Description("Date and time when the event occurred")]
        [JsonProperty("eventDateTime", Order = -16, Required = Required.Always)]
        public DateTime EventDateTime { get; set; }

        /// <summary>
        /// Geo position data and tour reference for gps tracking
        /// </summary>
        [JsonProperty(Order = -2, Required = Required.Always)]
        public List<EdiGpsTracking> GpsTracking { get; set; }
    }

    /// <summary>
    /// Geo position data and tour reference for gps tracking
    /// </summary>
    [DisplayName("GPS tracking")]
    [Description("Geo position data and tour reference for gps tracking")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties(false)]
    public class EdiGpsTracking : EdiGeoPosition
    {
        /// <summary>
        /// List of conizi tour ids
        /// </summary>
        [DisplayName("Tour Ids")]
        [Description("List of conizi tour ids")]
        [JsonProperty(Required = Required.DisallowNull, Order = -1)]
        public List<string> TourIds { get; set; }
    }

}
