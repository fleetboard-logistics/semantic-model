using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Transport.Truck.Groupage.Forwarding
{
    public class PickupOrderBulk : EdiDocument
    {
        public EdiDocument[] Pickuporders { get; set; }
    }
}