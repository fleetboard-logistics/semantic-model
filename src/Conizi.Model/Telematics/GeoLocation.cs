using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Conizi.Model.Transport.Truck.Groupage.Forwarding;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Telematics
{
    /// <summary>
    /// A single geo location which is transferred between two partners. Also vehicle and driver data could be included
    /// </summary>
    /// <remarks>
    /// The geo location is the basic conizi object for geo location and telematics.
    /// </remarks>
    [ConiziSchema("https://model.conizi.io/v1/telematics/geolocation.json", "geolocation.json")]
    [DisplayName("Geo Location")]
    [Description("A single geo location which is transferred between two partners. Also vehicle and driver data could be included")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class GeoLocation : EdiModel
    {
        /// <summary>
        /// Data about the current geo position
        /// </summary>
        [Required]
        public EdiGeoPosition GeoPosition { get; set; }

        /// <summary>
        /// Information about the vehicle
        /// </summary>
        [Required]
        public EdiVehicle Vehicle { get; set; }

        /// <summary>
        /// Information about the driver
        /// </summary>
        public EdiDriver Driver { get; set; }
    }
}
