using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Interfaces;

namespace Conizi.Model.Shared.Entities
{

    /// <summary>
    /// A geo location event which is transferred between two partners
    /// </summary>
    [DisplayName("Geo Location")]
    [Description("A geo location event which is transferred between two partners")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiGeoLocationEvent : EdiEventBase, IDevice
    {
        /// <summary>
        /// The id of the used device, should be used if the vehicle is not the unique asset for the geo location
        /// </summary>
        [DisplayName("Device Id")]
        [Description("The id of the used device, should be used if the vehicle is not the unique asset for the geo location")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Data about the current geo position
        /// </summary>
        [Required]
        public EdiGeoPosition GeoPosition { get; set; }

    }
}
