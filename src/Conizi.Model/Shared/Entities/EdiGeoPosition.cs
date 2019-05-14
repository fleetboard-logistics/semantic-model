using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Data about the current geo position
    /// </summary>
    [DisplayName("Geo position")]
    [Description("Data about the current geo position")]
    
    [ConiziAdditionalProperties(false)]
    public class EdiGeoPosition
    {
        /// <summary>
        /// East–west position of a point on the Earth's surface
        /// </summary>
        [JsonRequired]
        [DisplayName("Longitude")]
        [Description("East–west position of a point on the Earth's surface")]
        public decimal? Longitude { get; set; }

        /// <summary>
        /// North–south position of a point on the Earth's surface
        /// </summary>
        [DisplayName("Latitude")]
        [Description("North–south position of a point on the Earth's surface")]
        [JsonRequired]
        public decimal? Latitude { get; set; }

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

        /// <summary>
        /// Radius on which this GeoPosition is considered as in range
        /// </summary>
        public EdiRadius Radius { get; set; }

        /// <summary>
        /// Radius on which this GeoPosition is considered as in range containing measurement unit an the distance
        /// </summary>
        [DisplayName("Radius for the accuracy")]
        [Description("Radius that describes when a Position is considered as in range")]
        public class EdiRadius
        {
            /// <summary>
            /// Radius on which this GeoPosition is considered as in range
            /// </summary>
            [DisplayName("Radius for the Coordinates")]
            [Description("Radius that extends the range of the coordinates")]
            public double? Radius { get; set; }

            /// <summary>
            /// Code that describes the unit in which the radius is measured
            /// </summary>
            [DisplayName("Unit Code for Radius")]
            [Description("Code that describes the unit in which the radius is measured")]
            public MeasurementUnitCode? RadiusMeasurementUnitCode { get; set; }
        }


    }
}
