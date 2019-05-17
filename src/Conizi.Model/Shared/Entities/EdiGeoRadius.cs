using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Definitions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Shared.Entities
{
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
        public int? Radius { get; set; }

        /// <summary>
        /// Code that describes the unit in which the radius is measured
        /// </summary>
        [DisplayName("Unit Code for GeoRadius")]
        [Description("Code that describes the unit in which the radius is measured")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MeasurementUnitCode? RadiusMeasurementUnitCode { get; set; }
    }
}
