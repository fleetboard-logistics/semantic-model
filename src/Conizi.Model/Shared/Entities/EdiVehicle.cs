using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information about the vehicles used in the transport
    /// </summary>
    
    [DisplayName("Vehicle")]
    [Description("Information about the vehicles used in the transport")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiVehicle : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The system wide id of the vehicle
        /// </summary>
        [DisplayName("The vehicle id")]
        public string VehicleId { get; set; }

        /// <summary>
        /// The unique vehicle identification number (VIN)
        /// </summary>
        [DisplayName("The vehicle identification number")]
        public string VehicleIdentificationNumber { get; set; }

        /// <summary>
        /// Official registration of the vehicle (e.g. license plate number
        /// </summary>
        [DisplayName("Registration")]
        [Description("Official registration of the vehicle (e.g. license plate number)")]
        public string Registration { get; set; }

        /// <summary>
        /// The truck type
        /// </summary>
        [DisplayName("Truck type")]
        public string TruckType { get; set; }

        /// <summary>
        /// The vehicle is classified as trailer
        /// </summary>
        [DisplayName("Is a trailer")]
        [Description("The vehicle is classified as trailer")]
        public bool? IsTrailer { get; set; }

        /// <summary>
        /// The vehicle sends telematics data to a central instance
        /// </summary>
        [DisplayName("Vehicle sends telematics")]
        [Description("The vehicle sends telematics data to a central instance")]
        public bool? SendTelematics { get; set; }

        /// <summary>
        /// List of device ids, are part of this vehicle
        /// </summary>
        [DisplayName("Device Ids")]
        [Description("List of device ids, are part of this vehicle")]
        public List<string> DeviceIds { get; set; }

        /// <summary>
        /// Dimensions of the vehicle
        /// </summary>
        public EdiMeasures Dimensions { get; set; }

        /// <summary>
        /// The Manufacturer of the vehicle
        /// </summary>
        [DisplayName("Device Ids")]
        [Description("List of device ids, are part of this vehicle")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// Further Vehicle Information
        /// </summary>
        [DisplayName("Information")]
        [Description("Further Vehicle Information")]
        public string Information { get; set; }


    }
}