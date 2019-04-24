using Conizi.Model.Shared.Entities;
using Conizi.Model.Shared.Interfaces;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding.Helper.Tour
{
    /// <summary>
    /// Base class for a tour based event
    /// </summary>
    public abstract class EdiTourEventBase : EdiEventBase
    {
        /// <summary>
        /// The geo location, the event was recorded
        /// </summary>
        [JsonProperty("geoPosition", Order = -9, Required = Required.DisallowNull)]
        public EdiGeoPosition GeoPosition { get; set; }
    }
}