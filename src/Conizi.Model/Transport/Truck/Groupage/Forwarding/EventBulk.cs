using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{

    /// <summary>
    /// Events for different consignments, pickup orders or packages, that can be send in bulk, which occurred during the processing <seealso cref="Consignment"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/event-bulk.json", "event-bulk.json")]
    [DisplayName("Bulk Event")]
    [Description("Events for different consignments, pickup orders or packages, that can be send in bulk, which occurred during the processing")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class EventBulk : EdiModel
    {
        /// <summary>
        /// List of consignment events <see cref="ConsignmentEvent"/>
        /// </summary>
        [JsonProperty("consignment-events")]
        public List<ConsignmentEvent> ConsignmentEvents { get; set; }

        /// <summary>
        /// List of pickup order events <see cref="PickupOrderEvent"/>
        /// </summary>
        [JsonProperty("pickuporder-events")]
        public List<PickupOrderEvent> PickupOrderEvents { get; set; }

        /// <summary>
        /// List of package events <see cref="PackageEvent"/>
        /// </summary>
        [ConiziHandleExternal("https://raw.githubusercontent.com/fleetboard-logistics/semantic-model/master/model/transport/truck/groupage/forwarding/package-event.json")]
        [JsonProperty("package-events")]
        public List<PackageEvent> PackageEvents { get; set; }

        /// <summary>
        /// List of tour events <see cref="TourEvent"/>
        /// </summary>
        [JsonProperty("tour-events")]
        public List<TourEvent> TourEvents { get; set; }
    }
}