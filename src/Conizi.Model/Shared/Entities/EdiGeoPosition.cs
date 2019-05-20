﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
        /// North–south position of a point on the Earth's surface
        /// </summary>
        [DisplayName("Latitude")]
        [Description("North–south position of a point on the Earth's surface")]
        [JsonProperty(Required = Required.DisallowNull, Order = -10)]
        public decimal? Latitude { get; set; }

        /// <summary>
        /// East–west position of a point on the Earth's surface
        /// </summary>
        [DisplayName("Longitude")]
        [Description("East–west position of a point on the Earth's surface")]
        [JsonProperty(Required = Required.DisallowNull, Order = -9)]
        public decimal? Longitude { get; set; }

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
        public DateTimeOffset? RecordTime { get; set; }

        /// <summary>
        /// The angle is the direction that the vehicle is moving in
        /// </summary>
        [DisplayName("Angle")]
        [Description("The angle is the direction that the vehicle is moving in")]
        public decimal? Angle { get; set; }

        /// <summary>
        /// The current speed of the vehicle in a defined measurement
        /// </summary>
        public EdiGeoSpeed Speed { get; set; }

        /// <summary>
        /// GeoRadius on which this GeoPosition is considered as in range
        /// </summary>
        public EdiGeoRadius GeoRadius { get; set; }
    }

    /// <summary>
    /// The current speed of the vehicle in a defined measurement
    /// </summary>
    [DisplayName("Speed")]
    [Description("The current speed of the vehicle")]
    public class EdiGeoSpeed
    {
        /// <summary>
        /// The current speed of the vehicle
        /// </summary>
        [DisplayName("Speed")]
        [Description("The current speed of the vehicle")]
        [Required]
        public decimal Speed { get; set; }

        /// <summary>
        /// Code that describes the unit in which the speed is measured
        /// Default Kilometer per hour
        /// </summary>
        [DisplayName("Unit Code for Speed")]
        [Description("Code that describes the unit in which the Speed is measured. Default kilometers (KMT)")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MeasurementUnitCode? SpeedMeasurementUnitCode { get; set; }
    }

    /// <summary>
    /// GeoRadius on which this GeoPosition is considered as in range containing measurement unit an the distance
    /// </summary>
    [DisplayName("GeoRadius for the accuracy")]
    [Description("GeoRadius that describes when a Position is considered as in range")]
    public class EdiGeoRadius
    {
        /// <summary>
        /// GeoRadius on which this GeoPosition is considered as in range
        /// </summary>
        [DisplayName("GeoRadius for the Coordinates")]
        [Description("GeoRadius that extends the range of the coordinates")]
        [Required]
        public decimal Radius { get; set; }

        /// <summary>
        /// Code that describes the unit in which the radius is measured
        /// Default kilometers (KMT)
        /// </summary>
        [DisplayName("Unit Code for GeoRadius")]
        [Description("Code that describes the unit in which the radius is measured. Default kilometers (KMT)")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MeasurementUnitCode? RadiusMeasurementUnitCode { get; set; }
    }

    /// <summary>
    /// The estimated time of arrival (ETA) is the time when a ship, vehicle, aircraft, cargo, emergency service or person is expected to arrive at a certain place
    /// </summary>
    ///<remarks> The ETA should always be used in conjunction with a GPS position <see cref="EdiGeoPosition"/>.</remarks>
    [DisplayName("ETA (Estimated time of arrival)")]
    [Description(
        "The estimated time of arrival (ETA) is the time when a ship, vehicle, aircraft, cargo, emergency service or person is expected to arrive at a certain place. " +
        "The ETA should always be used in conjunction with a GPS position")]
    public class EdiGeoEta
    {
        /// <summary>
        /// ETA (Estimated time of arrival) absolute as time string (e.g. 14:12:33)
        /// </summary>
        /// <remarks>If no date component is specified <see cref="EtaDateAbsolute"/>, the current day applies.</remarks>
        [DisplayName("ETA (Estimated time of arrival)")]
        [Description("ETA (Estimated time of arrival) absolute as time string (e.g. 14:12:33)")]
        [Required]
        [ConiziTimeOnly]
        public string EtaTimeAbsolute { get; set; }

        /// <summary>
        /// ETA (Estimated time of arrival) date component date (e.g. 2019-05-17)
        /// </summary>
        /// <remarks>The date component is only required if it is not the current day.</remarks>
        [DisplayName("ETA (Estimated time of arrival) date component")]
        [Description("ETA (Estimated time of arrival) date component date (e.g. 2019-05-17). " +
                     "The date component is only required if it is not the current day.")]
        [ConiziDateOnly]
        public DateTime EtaDateAbsolute { get; set; }

        /// <summary>
        /// ETE (estimated time enroute, estimated time elapsed) in seconds
        /// </summary>
        [DisplayName("Estimated time elapsed")]
        [Description("ETE (estimated time enroute, estimated time elapsed) in seconds")]
        public int? Ete { get; set; }

        /// <summary>
        /// The distance to destination
        /// </summary>
        [DisplayName("Distance to destination")]
        [Description("The distance to destination")]
        public decimal? DistanceToDestination { get; set; }

        /// <summary>
        /// Code that describes the unit in which the distance is measured
        /// Default kilometers (KMT)
        /// </summary>
        [DisplayName("Unit Code for distance to destination")]
        [Description("Code that describes the unit in which the distance is measured. Default kilometers (KMT)")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MeasurementUnitCode? DistanceMeasurementUnitCode { get; set; }

        /// <summary>
        /// The number of stops <see cref="EdiTourStop"/> to destination
        /// </summary>
        [DisplayName("Stops to destination")]
        [Description("The number of stops to destination")]
        public int? StopsToDestination { get; set; }
    }
}