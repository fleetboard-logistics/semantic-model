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
    /// Telematics data about the truck
    /// </summary>
    [DisplayName("Truck Telematics")]
    [Description("Telematics data about the truck")]
    [ConiziAdditionalProperties(false)]
    public class EdiTruckTelematics
    {

        /// <summary>
        /// Time the measurement was created
        /// </summary>
        [DisplayName("Record time")]
        [Description("Time the measurement was recored")]
        [JsonProperty(Required = Required.Always, Order = -11)]
        public DateTimeOffset RecordTime { get; set; }

        /// <summary>
        /// The speed of the vehicle in KM/h
        /// </summary>
        [DisplayName("Speed in KM/h")]
        [Description("The speed of the vehicle in KM/h")]
        [JsonProperty(Order = -10)]
        public int? Speed { get; set; }

        /// <summary>
        /// The Total Driven Distance in meter
        /// </summary>
        [DisplayName("Total Driven Distance in meter")]
        [Description("The Total Driven Distance in meter")]
        [JsonProperty(Order = -9)]
        public int? TotalDrivenDistance { get; set; }

        /// <summary>
        /// The engine Speed (UpM/RpM)
        /// </summary>
        [DisplayName("Engine Speed")]
        [Description("The engine Speed (UpM/RpM)")]
        public int? EngineSpeed { get; set; }

        /// <summary>
        /// The weight of the vehicle in Kg
        /// </summary>
        [DisplayName("Weight")]
        [Description("The weight of the vehicle in Kg")]
        public int? Weight { get; set; }

        /// <summary>
        /// The Total Fuel Consumption in ML
        /// </summary>
        [DisplayName("Total Fuel Consumption")]
        [Description("The Total Fuel Consumption in ML")]
        public int? TotalFuelConsumption { get; set; }

        /// <summary>
        /// The Total AdBlue Used in ML
        /// </summary>
        [DisplayName("Total AdBlue Used")]
        [Description("The Total AdBlue Used in ML")]
        public int? TotalAdBlueUsed { get; set; }

        /// <summary>
        /// The Total Operating Time in seconds
        /// </summary>
        [DisplayName("Total Operation Time")]
        [Description("The Total Operating Time in seconds")]
        public int? TotalOperatingTime { get; set; }
    }
}