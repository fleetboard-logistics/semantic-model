using System.Collections.Generic;
using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{

    /// <summary>
    /// Pickup orders, that can be send in bulk. See <seealso cref="PickupOrderBulk"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/pickuporder-bulk.json", "pickuporder-bulk.json")]
    [DisplayName("Pickup-order bulk")]
    [Description("Pickup orders, that can be send in bulk")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class PickupOrderBulk : EdiModel
    {
        /// <summary>
        /// List of <see cref="PickupOrder"/>s
        /// </summary>
        [JsonProperty("consignment-events")]
        public List<PickupOrder> PickupOfOrders { get; set; }

    }
}