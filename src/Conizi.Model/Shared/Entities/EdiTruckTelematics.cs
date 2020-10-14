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
        /// Time the measurement was recorded (Unix UTC Timestamp in milliseconds)
        /// </summary>
        [DisplayName("Record time")]
        [Description("Time the measurement was recorded (Unix UTC Timestamp in milliseconds)")]
        [JsonProperty(Required = Required.Always, Order = -11)]
        public long RecordTime { get; set; }

        /// <summary>
        /// The speed of the vehicle in KM/h
        /// </summary>
        [DisplayName("Speed in KM/h")]
        [Description("The speed of the vehicle in KM/h")]
        [JsonProperty(Order = -10)]
        public double? Speed { get; set; }

        /// <summary>
        /// The Total Driven Distance in meter
        /// </summary>
        [DisplayName("Total Driven Distance in meter")]
        [Description("The Total Driven Distance in meter")]
        [JsonProperty(Order = -9)]
        public double? TotalDrivenDistance { get; set; }
        
        /// <summary>
        /// The engine is on
        /// </summary>
        [DisplayName("Engine On")]
        [Description("The engine is on")]
        public bool? EngineOn { get; set; }

        /// <summary>
        /// The ignition is on
        /// </summary>
        [DisplayName("Ignition On")]
        [Description("The ignition is on")]
        public bool? IgnitionOn { get; set; }

        /// <summary>
        /// The engine Speed (UpM/RpM)
        /// </summary>
        [DisplayName("Engine Speed")]
        [Description("The engine Speed (UpM/RpM)")]
        public double? EngineSpeed { get; set; }

        /// <summary>
        /// The weight of the vehicle in Kg
        /// </summary>
        [DisplayName("Weight")]
        [Description("The weight of the vehicle in Kg")]
        public double? Weight { get; set; }

        /// <summary>
        /// The Total Fuel Consumption in ML
        /// </summary>
        [DisplayName("Total Fuel Consumption")]
        [Description("The Total Fuel Consumption in ML")]
        public double? TotalFuelConsumption { get; set; }

        /// <summary>
        /// The Total AdBlue Used in ML
        /// </summary>
        [DisplayName("Total AdBlue Used")]
        [Description("The Total AdBlue Used in ML")]
        public double? TotalAdBlueUsed { get; set; }

        /// <summary>
        /// The Total Operating Time in seconds
        /// </summary>
        [DisplayName("Total Operation Time")]
        [Description("The Total Operating Time in seconds")]
        public int? TotalOperatingTime { get; set; }

        /// <summary>
        /// The current AdBlue level in percent (0-100)
        /// </summary>
        [DisplayName("AdBlue level")]
        [Description("The current AdBlue level in percent (0-100)")]
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public double? AdBlueLevel { get; set; }

        /// <summary>
        /// The current Fuel level in percent (0-100)
        /// </summary>
        [DisplayName("Fuel level")]
        [Description("The current Fuel level in percent (0-100)")]
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public double? FuelLevel { get; set; }
    }
}