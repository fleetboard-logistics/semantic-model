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
        /// Time the measurement was recorded (Unix UTC Timestamp in milliseconds)
        /// </summary>
        [DisplayName("Record time")]
        [Description("Time the measurement was recorded (Unix UTC Timestamp in milliseconds)")]
        [JsonProperty(Required = Required.Always, Order = -11)]
        public long RecordTime { get; set; }

        /// <summary>
        /// The trailer temperature in degree Celsius
        /// </summary>
        [JsonProperty(Order = -9)]
        public List<EdiTemperature> Temperatures { get; set; }

        /// <summary>
        /// The state of the doors
        /// </summary>
        [JsonProperty(Order = -8)]
        public List<EdiDoorState> DoorStates { get; set; }

        /// <summary>
        /// The state of the brake system
        /// </summary>
        [JsonProperty(Order = -8)]
        public List<EdiBrakeSystemState> BrakeSystemStates { get; set; }
    }

    /// <summary>
    /// The door state of the trailer
    /// </summary>
    [DisplayName("Temperature in Celsius")]
    [Description("The trailer temperature in degree Celsius")]
    public class EdiDoorState
    {
        /// <summary>
        /// Name of the door
        /// </summary>
        [DisplayName("Door name")]
        [Description("Name of the door")]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The Signal Id   
        /// </summary>
        [DisplayName("Signal Id")]
        [Description("The Signal Id")]
        [Required]
        public string SignalId { get; set; }

        /// <summary>
        /// The value as integer
        /// </summary>
        [DisplayName("Value")]
        [Description("The value as integer")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        [Required]
        public int Value { get; set; }

    }

    /// <summary>
    /// The temperature of the trailer
    /// </summary>
    [DisplayName("Temperature")]
    [Description("The temperature of the trailer")]
    public class EdiTemperature
    {
        /// <summary>
        /// Name of the signal
        /// </summary>
        [DisplayName("Signal name")]
        [Description("Name of the signal")]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The signal id
        /// </summary>
        [DisplayName("Signal Id")]
        [Description("The signal id")]
        [Required]
        public string SignalId { get; set; }

        /// <summary>
        /// The value as number
        /// </summary>
        [DisplayName("Value")]
        [Description("The value as number")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        [Required]
        public decimal Value { get; set; }

    }

    /// <summary>
    /// The voltage of the trailer/vehicle
    /// </summary>
    [DisplayName("Voltage")]
    [Description("The voltage of the trailer/vehicle")]
    public class EdiVoltage
    {
        /// <summary>
        /// The external voltage
        /// </summary>
        [DisplayName("External Voltage")]
        [Description("The external voltage")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        [Required]
        public decimal External { get; set; }

        /// <summary>
        /// The internal voltage
        /// </summary>
        [DisplayName("Internal voltage")]
        [Description("The internal voltage")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        [Required]
        public decimal Internal { get; set; }


    }


    /// <summary>
    /// The state of the Brake system
    /// </summary>
    [DisplayName("Brake system")]
    [Description("The state of the Brake system")]
    public class EdiBrakeSystemState
    {
        /// <summary>
        /// Name of the signal
        /// </summary>
        [DisplayName("Signal name")]
        [Description("Name of the signal")]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// The signal id
        /// </summary>
        [DisplayName("Signal Id")]
        [Description("The signal id")]
        [Required]
        public string SignalId { get; set; }

        /// <summary>
        /// The value as number
        /// </summary>
        [DisplayName("Value")]
        [Description("The value as number")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        [Required]
        public decimal Value { get; set; }


    }
}