using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// A single pickup order which is transferred between two partners
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/pickuporder.json",
        "pickuporder.json")]
    [DisplayName("Pickup order")]
    [Description("A single pickup order which is transferred between two partners")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    class PickupOrder : EdiModel
    {
    }
}
