using System;
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
    /// Telematics data about the trailer
    /// </summary>
    [DisplayName("Trailers Telematics")]
    [Description("Telematics data about the trailer")]
    [ConiziAdditionalProperties(false)]
    public class EdiTrailerTelematics
    {

        /// <summary>
        /// Time the measurement was created
        /// </summary>
        [DisplayName("Record time")]
        [Description("Time the measurement was recored")]
        [JsonProperty(Required = Required.Always, Order = -11)]
        public DateTimeOffset RecordTime { get; set; }

        /// <summary>
        /// The trailer temperature in degree Celsius
        /// </summary>
        [DisplayName("Temperature in Celsius")]
        [Description("The trailer temperature in degree Celsius")]
        [JsonProperty(Order = -9)]
        public decimal? Temperature { get; set; }
    }
}