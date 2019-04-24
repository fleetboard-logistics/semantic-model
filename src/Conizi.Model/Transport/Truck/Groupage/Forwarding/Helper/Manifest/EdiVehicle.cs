using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Manifest
{
    /// <summary>
    /// Information about the vehicles used in the transport
    /// </summary>
    [JsonObject("vehicle")]
    [DisplayName("Vehicle")]
    [Description("Information about the vehicles used in the transport")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiVehicle
    {
        /// <summary>
        /// The Id of the vehicle
        /// </summary>
        [DisplayName("The vehicle id")]
        public string VehicleId { get; set; }

        [DisplayName("Registration")]
        [Description("Official registration of the vehicle (e.g. license plate number)")]
        public string Registration { get; set; }

        /// <summary>
        /// The truck type
        /// </summary>
        [DisplayName("Truck type")]
        public object TruckType { get; set; }
    }
}