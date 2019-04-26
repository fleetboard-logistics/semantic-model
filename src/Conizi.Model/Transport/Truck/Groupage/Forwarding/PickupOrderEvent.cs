using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// An event which occurred during the processing of the referenced pickup order <seealso cref="PickupOrderEvent"/>
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/pickuporder-event.json",
        "pickuporder-event.json")]
    [DisplayName("Pickup order event")]
    [Description("An event which occurred during the processing of the referenced pickup order")]
    [ConiziAdditionalProperties(true)]
    [ConiziAllowXProperties]
    public class PickupOrderEvent : EdiModel
    {
    }
}
