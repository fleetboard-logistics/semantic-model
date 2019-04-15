using System.ComponentModel;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    /// <summary>
    /// 
    /// </summary>
    [ConiziSchema("https://model.conizi.io/v1/transport/truck/groupage/forwarding/pickuporder-bulk.json",
        "pickuporder-bulk.json")]
    [DisplayName("Consignment event")]
    [Description("An event which occured during the processing of the referenced consignment")]
    [ConiziAdditionalProperties(false)]
    [ConiziAllowXProperties]
    public class PickupOrderBulk : EdiModel
    {

    }
}