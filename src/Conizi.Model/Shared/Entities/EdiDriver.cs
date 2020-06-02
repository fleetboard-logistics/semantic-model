using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// Information about the drivers of the vehicles
    /// </summary>
    
    [DisplayName("Driver")]
    [Description("Information about the drivers of the vehicles")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiDriver : EdiPatternPropertiesBase
    {
        /// <summary>
        /// The id of the driver
        /// </summary>
        [DisplayName("Diver Id")]
        [Description("The id of the driver")]
        public string DriverId { get; set; }

        /// <summary>
        /// The name of the driver
        /// </summary>
        [DisplayName("Name of the driver")]
        [Description("The name of the driver")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number of the driver
        /// </summary>
        [DisplayName("Phone number")]
        [Description("The phone number of the driver")]
        [Phone]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The system wide id of the vehicle, the driver is connected
        /// </summary>
        [DisplayName("The vehicle id")]
        [Description("The system wide id of the vehicle, the driver is connected")]
        public string VehicleId { get; set; }
    }
}