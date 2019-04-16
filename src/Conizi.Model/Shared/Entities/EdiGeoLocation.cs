using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Data about the current geo location
    /// </summary>
    [DisplayName("Geo location")]
    [Description("Data about the current geo location")]
    [JsonObject("geoLocation")]
    [ConiziAdditionalProperties(false)]
    public class EdiGeoLocation
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
        /// Time the GPS record was created
        /// </summary>
        [DisplayName("Record time")]
        [Description("Time the GPS record was created")]
        public DateTimeOffset RecordTime { get; set; }
    }
}
