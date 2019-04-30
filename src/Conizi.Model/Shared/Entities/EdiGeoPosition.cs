using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Data about the current geo position
    /// </summary>
    [DisplayName("Geo position")]
    [Description("Data about the current geo position")]
    [JsonObject("geoPosition")]
    [ConiziAdditionalProperties(false)]
    public class EdiGeoPosition
    {
        /// <summary>
        /// East–west position of a point on the Earth's surface
        /// </summary>
        [JsonRequired]
        [DisplayName("Longitude")]
        [Description("East–west position of a point on the Earth's surface")]
        public decimal Longitude { get; set; }

        /// <summary>
        /// North–south position of a point on the Earth's surface
        /// </summary>
        [DisplayName("Latitude")]
        [Description("North–south position of a point on the Earth's surface")]
        [JsonRequired]
        public decimal Latitude { get; set; }

        /// <summary>
        /// The place name of the current geo position
        /// </summary>
        [DisplayName("Place name")]
        [Description("The place name of the current geo position")]
        public string PlaceName { get; set; }

        /// <summary>
        /// A coordinate for the What3Words service like index.home.raft
        /// </summary>
        [DisplayName("What3words coordinate")]
        [Description("A coordinate for the What3Words service like index.home.raft")]
        public string W3WCoordinate { get; set; }

        /// <summary>
        /// Time the GPS record was created
        /// </summary>
        [DisplayName("Record time")]
        [Description("Time the GPS record was created")]
        public DateTimeOffset RecordTime { get; set; }
    }
}
