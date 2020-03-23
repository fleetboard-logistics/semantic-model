using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information about the route to be driven
    /// </summary>
    [DisplayName("Route Information")]
    [Description("Information about the route to be driven")]
    [ConiziAdditionalProperties(false)]
    public class EdiRouteInformation
    {
        /// <summary>
        /// Toll distance on this tour
        /// </summary>
        [DisplayName("Toll Distance")]
        [Description("Toll distance on this tour")]
        [Required]
        public Decimal TollDistance { get; set; }

        /// <summary>
        /// Toll distance on this tour
        /// </summary>
        [DisplayName("Distance")]
        [Description("Distance on this tour")]
        [Required]
        public Decimal Distance { get; set; }

        /// <summary>
        /// Code that describes the unit in which the radius is measured
        /// Default kilometers (KMT)
        /// </summary>
        [DisplayName("Unit Code for Distance")]
        [Description("Code that describes the unit in which the distance is measured. Default kilometers (KMT)")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MeasurementUnitCode? DistanceMeasurementUnitCode { get; set; }
    }
}