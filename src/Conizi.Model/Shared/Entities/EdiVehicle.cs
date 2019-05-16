using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

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
        /// The Id of the vehicle
        /// </summary>
        [DisplayName("The vehicle id")]
        public string VehicleId { get; set; }

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
        public EdiEmptyExtendableObject TruckType { get; set; }
    }
}