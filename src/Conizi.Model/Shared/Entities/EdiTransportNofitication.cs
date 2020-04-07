using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Definitions;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conizi.Model.Shared.Entities
{
    /// <summary>
    /// General notifications about the transport
    /// </summary>
    
    [DisplayName("TransportNotification")]
    [Description("General notifications about the transport")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EdiTransportNotification : EdiPatternPropertiesBase
    {
        /// <summary>
        /// A geo-fence is a virtual perimeter for a real-world geographic area
        /// </summary>
        public EdiGeoPosition GeoFence { get; set; }

        /// <summary>
        /// Contact Information for Notification
        /// </summary>
        public EdiAddress ContactNotification { get; set; }

        /// <summary>
        /// Notification by driver
        /// </summary>
        [DisplayName("By driver")]
        [Description("Notification by driver")]
        public bool? ByDriver { get; set; }

        /// <summary>
        /// Notification by load (pickup, delivery)
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public LoadType NotifyAt { get; set; }
        
        /// <summary>
        /// Free text information about the transport
        /// </summary>
        [DisplayName("Remarks")]
        [Description("Free text information about the transport")]
        public string Remarks { get; set; }
    }
}
